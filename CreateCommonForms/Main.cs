using System;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
namespace CreateCommonForms
{
	class MainClass
	{
		
		
		const bool obsolete_error = true;

		static TextWriter m_writer = null;
		
    	public static int Indent = 0;
		static string WinFilePath = @"../../Common.Forms/Common.Forms.g.cs";
		static string MacFilePath = @"../../Common.Forms(mac)/Common.Forms.g.cs";
		public static List<Type> Enums = new List<Type>();
		public static void Main (string[] args)
		{			
			var type = args.Count() > 0 ?  args[0] : ""; 
			Console.WriteLine(type);
				
			var Windows = typeof(ButtonBase).Assembly;
			
			var MonoMac = typeof(MonoMac.Windows.Forms.EmptyObject).Assembly;
			
			if(type.ToLower() == "mac")
			{
				writeFile(MacFilePath,MonoMac,Windows,true);
			}
			else
			{
				
				writeFile(WinFilePath,Windows,MonoMac,false);
			}
		}
		public static void writeFile(string file,Assembly include, Assembly exclude, bool monomac)
		{
			
			var dir = Directory.GetCurrentDirectory ();
			//m_writer 
			if(File.Exists(file))
				File.Delete(file);
			m_writer = new StreamWriter(file);// File.Create (filePath);
			WriteLine ("using System;");
			WriteLine ("using System.Windows.Forms;");
			WriteLine ("using System.Drawing;");
			if(monomac) WriteLine ("using MonoMac.AppKit;");
			WriteLine ("");
			BeginBlock ("namespace Common.Forms");
			
			var iClasses = include.GetTypes ().Where (x => x.IsPublic && x.IsClass && !x.Name.Contains("Application")).ToList ();
			var eClasses = exclude.GetTypes ().Where (x => x.IsPublic && x.IsClass && !x.Name.Contains("Application")).ToList ();
					
			var Combined = iClasses.Where (x => eClasses.Where (y => y.Name == x.Name).Count () > 0).ToList ();
			foreach (var theClass in Combined)
			{
				WriteClass (theClass, eClasses.Where (x => x.Name == theClass.Name).FirstOrDefault ());
				Console.WriteLine (theClass.FullName);
			}
			/*
			BeginRegion("Interfaces");
			foreach(var theClass in include.GetTypes().Where(x=> x.IsInterface).Where(x=> x.IsPublic))
			{
				WriteInterface (theClass);
				Console.WriteLine (theClass.FullName);
			}
			
			EndRegion();
			*/
			BeginRegion("Enums");
			foreach(var theEnum in Enums)
			{
			//	WriteEnum(theEnum);
			}
			
			
			EndRegion();
			
			EndBlock();
	        m_writer.Flush();
	        m_writer.Close();
	
		}
		public static void WriteClass (Type includeType, Type exludeType)
		{
			var interfaces = includeType.GetInterfaces().Where(x=> x.IsPublic);
			interfaces = new Type[]{};
			if(includeType.Name == "Form")
				Console.WriteLine("Form");
			
			//if delegate
			if(typeof(Delegate).IsAssignableFrom(includeType))
					WriteDelegate(includeType);
			// If static with no constructors
			else if (includeType.GetConstructors().Count() == 0)
				WriteNonInherit(includeType,exludeType);
			else
			{
				if(includeType.IsSealed)
					WriteSealedClass(includeType,exludeType);
				else	
					BeginBlock("public partial class " + includeType.Name + " : " + includeType.Namespace + "." + includeType.Name + (interfaces.Count() > 0 ? ("," + string.Join(",",interfaces.Select(x=> (x.Namespace + "." + x.Name)).ToArray())): ""));
				WriteConstructors(includeType,exludeType);
				WriteClassFields(includeType,exludeType);
				WriteClassProperties(includeType,exludeType);
				WriteClassEvents(includeType,exludeType);
				WriteClassMethods(includeType,exludeType);
				EndBlock();
			}
		}
		
		public static void WriteInterface(Type type)
		{
			BeginBlock("public interface " + type.Name + " : " +type.Namespace + "." + type.Name );
			EndBlock();
		}
		
		
		public static void WriteDelegate(Type type)
		{		
			var members = type.GetMember("Invoke");
			var invoke = members.FirstOrDefault().ToString().Replace("System.Windows.Forms","Common.Forms");
			var newString = "public delegate ";
			var invokeIndex = invoke.IndexOf("Invoke");
			newString += invoke.Substring(0,invokeIndex).ToLower();
			newString += " " + type.Name + " ";
			var endingString = invoke.Substring(invokeIndex + 6);
			endingString = endingString.Insert(endingString.IndexOf(",")," sender ");
			newString += endingString.Insert(endingString.IndexOf(")")," e ") + ";";
			WriteLine(newString);
			WriteLine("");
		}
		
		public static void WriteNonInherit(Type includeType, Type excludeType)
		{
			BeginBlock("public class " + includeType.Name );
			
			WriteClassProperties(includeType,excludeType);
			WriteClassMethods(includeType,excludeType);
			EndBlock();
			//TODO:
		}
		
		public static void WriteSealedClass(Type winType,Type macType)
		{
			//TODO:
		}
		public static void WriteConstructors(Type includeType,Type excludeType)
		{
			BeginRegion("Constructors");
			var iCons = includeType.GetConstructors();
			var eCons = excludeType.GetConstructors();
			var cons = iCons.Select(x=> x.ToString()).Intersect(eCons.Select(y=> y.ToString())).ToList();
			var con2 = iCons.Select(x=> x.ToString()).Except(eCons.Select(y=> y.ToString())).ToList();
			
			foreach(var con in iCons.Where(x=> cons.Contains(x.ToString())))
			{
				var theParams = con.GetParameters().OrderBy(x=> x.Position);
				if(theParams.Count() > 0 || iCons.Count() > 1 )
				{
					string line = "public " + includeType.Name;
					string paramString = " (";
					string baseParamString = " : base (";
					foreach(var p in theParams)
					{
						if(p.Position > 0)
						{
							paramString += " , ";
							baseParamString += " , ";
						}
						paramString += p.ParameterType.FullName + " " + p.Name;
						baseParamString += p.Name;
					}
					paramString += ")";
					baseParamString += ")";
					line += (paramString + baseParamString);
					BeginBlock(line);
					EndBlock();
				}
			}
			//Not Supported
			foreach(var con in iCons.Where(x=> con2.Contains(x.ToString())))
			{
				var theParams = con.GetParameters().OrderBy(x=> x.Position);
				if(theParams.Count() > 0 || iCons.Count() > 1 )
				{
					string line = "public " + includeType.Name;
					string paramString = " (";
					string baseParamString = " : base (";
					foreach(var p in theParams)
					{
						if(p.Position > 0)
						{
							paramString += " , ";
							baseParamString += " , ";
						}
						paramString += p.ParameterType.FullName + " " + p.Name;
						baseParamString += p.Name;
					}
					paramString += ")";
					baseParamString += ")";
					line += (paramString + baseParamString);
					BeginObsoleteBlock(line);
					EndBlock();
				}
			}
			EndRegion();
		}
		public static void WriteClassEvents(Type includeType,Type excludeType)
		{
			BeginRegion("Events");
			var iEvents = includeType.GetEvents();
			var eEvents = excludeType.GetEvents();
			var eventsInclude = iEvents.Select(x=> x.Name).Intersect(eEvents.Select(y=> y.Name)).Distinct().ToList();
			var eventsExclude = iEvents.Select(x=> x.Name).Except(eventsInclude).Distinct().ToList();

			foreach(var eventName in eventsInclude.OrderBy(x=> x))
			{
				var theEvent = iEvents.Where(x=> x.Name == eventName).First();
				string line = "public new event " + theEvent.EventHandlerType.ToString().Replace("System.Windows.Forms.","Common.Forms.") + " " + theEvent.Name + ";";// + " { get;set;}";
				WriteLine(line);
			}
			
			
			
			BeginRegion("Excluded");
			foreach(var eventName in eventsExclude.OrderBy(x=> x))
			{
				var theEvent = iEvents.Where(x=> x.Name == eventName).First();
				string line = "public new event " + theEvent.EventHandlerType.Namespace + "." + theEvent.EventHandlerType.Name.Replace("`","").Replace("1","") + " " + theEvent.Name + ";";//" { get;set;}";
				WriteObsoleteLine(line);
			}
			EndRegion();
			EndRegion();
			
		}
		
		public static void WriteClassProperties(Type includeType, Type excludeType)
		{
			BeginRegion("Properties");
			var iProps = includeType.GetProperties();
			var eProps = excludeType.GetProperties();
			var propsInclude = iProps.Select(x=> x.Name).Intersect(eProps.Select(y=> y.Name)).Distinct().ToList();
			var propsExclude = iProps.Select(x=> x.Name).Except(propsInclude).Distinct().ToList();
			
			
			//Included
			foreach(var propName in propsInclude)
			{
				var prop = iProps.Where(x=> x.Name == propName).First();
				if(prop.PropertyType.IsEnum)
				{
					if(!Enums.Contains(prop.PropertyType))
						Enums.Add(prop.PropertyType);
					writeEnumProperty(prop,true);
				}
				//writeClassProperty(prop,true);
			}
			
			
			BeginRegion("Excluded");
			foreach(var propName in propsExclude)
			{
				if(propName == "Site" || (propName == "ActiveForm" && includeType.Name == "Form"))
					continue;
				var prop = iProps.Where(x=> x.Name == propName).First();
				if(prop.PropertyType.IsEnum)
				{
					if(!Enums.Contains(prop.PropertyType))
						Enums.Add(prop.PropertyType);
					writeEnumProperty(prop,false);
				}
				else
					writeClassProperty(prop,false);
				
			}
			EndRegion();
			EndRegion();		
		}
		private static void writeEnumProperty(PropertyInfo prop,bool include)
		{
			if(prop.Name == "DefaultBackColor")
				Console.Write("backcolor");
			if(include)
			{
				//WriteLine( "public new " + prop.PropertyType.Name + " " + prop.Name + "{get { return base." + prop.Name + ";}{set{base." + prop.Name + " = value ;}}"); 
				return;
			}
			var ifDesign = "";
			if(typeof(Component).IsAssignableFrom(prop.DeclaringType))
				ifDesign = "  if( !this.DesignMode ) throw new NotImplementedException();";
			
			var getString = "get{ " + ifDesign + " return ";
			var fullGetString = !prop.CanRead ? "" : (prop.GetGetMethod().IsStatic ? getString + prop.Name : getString + " base." + prop.Name) + ";}";

			WriteObsoleteLine( "public new " + prop.PropertyType.Name + " " + prop.Name + " { " + fullGetString + "set{throw new NotImplementedException();}}"); 
		}
		private static void writeClassProperty(PropertyInfo prop,bool included)
		{
			
			if(included)
			{
				var includeLine = "public new " + prop.PropertyType.FullName.Replace("+",".") + " " + prop.Name + " {get;set;}";
				//WriteLine(line);
				return;
			}
			var ifDesign = "";
			if(typeof(Component).IsAssignableFrom(prop.DeclaringType))
				ifDesign = "  if( !this.DesignMode ) throw new NotImplementedException();";
			var getString = "get{ " + ifDesign + " return ";
			var fullGetString = !prop.CanRead ? "" : (prop.GetGetMethod().IsStatic ? getString + prop.Name : getString + " base." + prop.Name) + ";}";
			var setString = !prop.CanWrite ? "" : "set{throw new NotImplementedException();}";
			
			var line = "public new " + prop.PropertyType.FullName.Replace("+",".") + " " + prop.Name + " {" +  fullGetString +  setString + "}";
			WriteObsoleteLine(line);
			
		}
		
		public static void WriteClassFields(Type includeType, Type excludeType)
		{
			BeginRegion("Fields");
			var iFields = includeType.GetFields();
			var eFields = excludeType.GetFields();
			var fieldsInclude = iFields.Select(x=> x.Name).Intersect(eFields.Select(y=> y.Name)).Distinct().ToList();
			var fieldsExclude = iFields.Select(x=> x.Name).Except(fieldsInclude).Distinct().ToList();
			/*
			foreach(var fieldName in fieldsInclude)
			{
				var field = wFields.Where(x=> x.Name == fieldName).First();
				var line = "public new " + field.FieldType.FullName.Replace("+",".") + " " + field.Name + ";";
				WriteLine(line);
			
			*/
			
			BeginRegion("Exluded");
			foreach( var fieldName in fieldsExclude)
			{
				
				var field = iFields.Where(x=> x.Name == fieldName).First();
				var line = "public new " + field.FieldType.FullName.Replace("+",".") + " " + field.Name + ";";
				WriteObsoleteLine(line);
			}
			EndRegion();
			EndRegion();
		}
		
		public static void WriteClassMethods(Type includeType, Type excludeType)
		{
			var iMethods = includeType.GetMethods(BindingFlags.Public|BindingFlags.Instance|BindingFlags.DeclaredOnly|BindingFlags.Static).Where(x=> !x.IsSpecialName ).ToList();//.Where(x=> !x.IsHideBySig).ToList();
			var eMethods = excludeType.GetMethods();			
			 var methodsInclude = iMethods.Select(x=> x.Name).Intersect(eMethods.Select(y=> y.Name)).Distinct().ToList();
			var methodsExclude = iMethods.Select(x=> x.Name).Except(methodsInclude).Distinct().ToList();
			foreach(var methodName in methodsInclude)
			{
				var method = iMethods.Where(x=> x.Name == methodName).First();
			//	writeMethod(includeType,method,true);
			}
			
			BeginRegion("Excluded Methods");
			foreach(var methodName in methodsExclude)
			{
				if(methodName == "BeginInit" || methodName == "EndInvoke" || methodName =="EndInit" || methodName == "PreProcessMessage" || methodName == "PreProcessControlMessage")
					continue;
				var method = iMethods.Where(x=> x.Name == methodName).First();
				writeMethod(includeType,method,false);
			}
			
			EndRegion();			
		}
		public static void writeMethod(Type includeType, MethodInfo method, bool include)
		{
			string line = "public " + (method.IsStatic ? "static " : " ") +  (method.IsVirtual ? " override " : " new ");
				line += (method.ReturnType.Namespace.Contains("System.Windows.Forms") ? (method.ReturnType.Namespace + ".") : "") +  (method.ReturnType.Name.ToLower() == "void" ? "void" : method.ReturnType.Name) + " ";
				line += method.Name;
				
				string paramNames  = "(";
				string paramString = " (";
				foreach(var p in method.GetParameters().OrderBy(x=> x.Position))
				{
					if(p.ParameterType.IsEnum)
					{
						if(!Enums.Contains(p.ParameterType))
							Enums.Add(p.ParameterType);
					}

					if(p.Position > 0)
					{
						paramString += " , ";
						paramNames += " , ";
					}
					paramNames += p.Name;
					paramString += p.ParameterType.FullName.Replace("&","").Replace("+",".") + " " + p.Name;
				}
				var execute = (method.IsStatic ?  includeType.FullName.Replace("&",".").Replace("+",".") + "."  : " base.") + method.Name + paramNames + ")";
				paramString += ") {" + (method.ReturnType.Name.ToLower() == "void" ? "" : "return ") + execute + ";}"; //( + ");") + "}";
				line += paramString;
				
			if(include)
				WriteLine(line);
			else
				WriteObsoleteLine(line);
		}
		
		public static void BeginRegion(string region)
		{
			WriteLine("#region " + region);	
		}
		public static void EndRegion()
		{
			WriteLine("#endregion");
		}
		public static void BeginObsoleteBlock(string line)
	    {
	      	WriteLine("[Obsolete(\"This method is not cross-platform compatible.\", " + (obsolete_error ? "true":"false" )  + ")]");
	      	BeginBlock(line);
	    }
		
		public static void WriteObsoleteLine(string line)
		{
	      	WriteLine("[Obsolete(\"This method is not cross-platform compatible.\", true)]");
			WriteLine(line);
		}
		
		public static void BeginBlock (string line)
		{
			WriteLine (line);
			WriteLine ("{");
			Indent++;
		}
		
		public static void EndBlock ()
		{
			Indent--;
			WriteLine ("}");
			WriteLine ("");
		}
		
		public static void WriteLine (string s)
		{
			StringBuilder indentedLine = new StringBuilder ();
			for (int i = 0; i < Indent; i++)
			{
				indentedLine.Append ("\t");
			}
			indentedLine.Append (s);
			m_writer.WriteLine (indentedLine);
		}
	}
}

