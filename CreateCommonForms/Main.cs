using System;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
namespace CreateCommonForms
{
	class MainClass
	{

		static TextWriter m_writer = null;
		
    	public static int Indent = 0;
		static string filePath = @"../../Common.Forms/Common.Forms.g.cs";
		public static void Main (string[] args)
		{
			//var winPath = args[0]; 
			var dir = Directory.GetCurrentDirectory ();
			//m_writer 
			if(File.Exists(filePath))
				File.Delete(filePath);
			m_writer = new StreamWriter(filePath);// File.Create (filePath);
			WriteLine ("using System;");
			//WriteLine ("using System.Windows.Forms;");
			WriteLine ("");
			BeginBlock ("namespace Common.Forms");
			
			
			var Windows = typeof(ButtonBase).Assembly;
			var enums = Windows.GetTypes ().Where (x => x.IsEnum);
			var wClasses = Windows.GetTypes ().Where (x => x.IsPublic && x.IsClass && !x.Name.Contains("Application")).ToList ();
			
			var MonoMac = typeof(MonoMac.Windows.Forms.EmptyObject).Assembly;
			var mClasses = MonoMac.GetTypes ().Where (x => x.IsPublic && x.IsClass).ToList ();
			
			var Combined = wClasses.Where (x => mClasses.Where (y => y.Name == x.Name).Count () > 0).ToList ();
			foreach (var theClass in Combined)
			{
				WriteClass (theClass, mClasses.Where (x => x.Name == theClass.Name).FirstOrDefault ());
				Console.WriteLine (theClass.FullName);
			}
			BeginRegion("Interfaces");
			foreach(var theClass in Windows.GetTypes().Where(x=> x.IsInterface).Where(x=> x.IsPublic))
			{
				WriteInterface (theClass);
				Console.WriteLine (theClass.FullName);
			}
			EndRegion();
			
			EndBlock();
	        m_writer.Flush();
	        m_writer.Close();
		}
		public static void WriteClass (Type winType, Type macType)
		{
			var interfaces = winType.GetInterfaces().Where(x=> x.IsPublic);
			
			//if delegate
			if(typeof(Delegate).IsAssignableFrom(winType))
					WriteDelegate(winType);
			// If static with no constructors
			else if (winType.GetConstructors().Count() == 0)
				WriteNonInherit(winType,macType);
			else
			{
				if(winType.IsSealed)
					WriteSealedClass(winType,macType);
				else	
					BeginBlock("public class " + winType.Name + " : " + winType.Namespace + "." + winType.Name + (interfaces.Count() > 0 ? ("," + string.Join(",",interfaces.Select(x=> (x.Namespace + "." + x.Name)).ToArray())): ""));
				WriteConstructors(winType,macType);
				WriteClassFields(winType,macType);
				WriteClassProperties(winType,macType);
				WriteClassEvents(winType,macType);
				WriteClassMethods(winType,macType);
				EndBlock();
			}
		}
		
		public static void WriteInterface(Type winType)
		{
			BeginBlock("public interface " + winType.Name + " : " + winType.Namespace + "." + winType.Name );
			EndBlock();
		}
		
		public static void WriteDelegate(Type winType)
		{		
			var test = winType.GetMembers().Where(x => x.Name == "IHTMLWindow2").FirstOrDefault();
			var members = winType.GetMember("Invoke");
			var invoke = members.FirstOrDefault().ToString();
			var newString = "public delegate ";
			var invokeIndex = invoke.IndexOf("Invoke");
			newString += invoke.Substring(0,invokeIndex).ToLower();
			newString += " " + winType.Name + " ";
			var endingString = invoke.Substring(invokeIndex + 6);
			endingString = endingString.Insert(endingString.IndexOf(",")," sender ");
			newString += endingString.Insert(endingString.IndexOf(")")," e ") + ";";
			WriteLine(newString);
			WriteLine("");
			
		
			
		}
		
		public static void WriteNonInherit(Type winType, Type macType)
		{
			BeginBlock("public class " + winType.Name );
			
			WriteClassProperties(winType,macType);
			WriteClassMethods(winType,macType);
			EndBlock();
			//TODO:
		}
		
		public static void WriteSealedClass(Type winType,Type macType)
		{
			//TODO:
		}
		public static void WriteConstructors(Type winType,Type macType)
		{
			BeginRegion("Constructors");
			var wCons = winType.GetConstructors();
			var mCons = macType.GetConstructors();
			var cons = wCons.Select(x=> x.ToString()).Intersect(mCons.Select(y=> y.ToString())).ToList();
			var con2 = wCons.Select(x=> x.ToString()).Except(mCons.Select(y=> y.ToString())).ToList();
			
			foreach(var con in wCons.Where(x=> cons.Contains(x.ToString())))
			{
				var theParams = con.GetParameters().OrderBy(x=> x.Position);
				if(theParams.Count() > 0 || wCons.Count() > 1 )
				{
					string line = "public " + winType.Name;
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
			foreach(var con in wCons.Where(x=> con2.Contains(x.ToString())))
			{
				var theParams = con.GetParameters().OrderBy(x=> x.Position);
				if(theParams.Count() > 0 || wCons.Count() > 1 )
				{
					string line = "public " + winType.Name;
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
		public static void WriteClassEvents(Type winType,Type macType)
		{
			BeginRegion("Events");
			var wEvents = winType.GetEvents();
			var mEvents = macType.GetEvents();
			var eventsInclude = wEvents.Select(x=> x.Name).Intersect(mEvents.Select(y=> y.Name)).Distinct().ToList();
			var eventsExclude = wEvents.Select(x=> x.Name).Except(eventsInclude).Distinct().ToList();
			
			foreach(var eventName in eventsInclude.OrderBy(x=> x))
			{
				var theEvent = wEvents.Where(x=> x.Name == eventName).First();
				string line = "public new " + theEvent.EventHandlerType + " " + theEvent.Name + " { get;set;}";
				WriteLine(line);
			}
			
			BeginRegion("Excluded");
			foreach(var eventName in eventsExclude.OrderBy(x=> x))
			{
				var theEvent = wEvents.Where(x=> x.Name == eventName).First();
				string line = "public new " + theEvent.EventHandlerType + " " + theEvent.Name + " { get;set;}";
				WriteObsoleteLine(line);
			}
			EndRegion();
			EndRegion();
			
		}
		
		public static void WriteClassProperties(Type winType, Type macType)
		{
			BeginRegion("Properties");
			var wProps = winType.GetProperties();
			var mProps = macType.GetProperties();
			var propsInclude = wProps.Select(x=> x.Name).Intersect(mProps.Select(y=> y.Name)).Distinct().ToList();
			var propsExclude = wProps.Select(x=> x.Name).Except(propsInclude).Distinct().ToList();
			
			//Included
			foreach(var propName in propsInclude)
			{
				var prop = wProps.Where(x=> x.Name == propName).First();
				writeClassProperty(prop,true);
			}
			
			BeginRegion("Excluded");
			foreach(var propName in propsExclude)
			{
				var prop = wProps.Where(x=> x.Name == propName).First();
				writeClassProperty(prop,false);
			}
			EndRegion();
			EndRegion();		
		}
		private static void writeClassProperty(PropertyInfo prop,bool included)
		{
			if(included)
			{
				var line = "public new " + prop.PropertyType.FullName.Replace("+",".") + " " + prop.Name + " {get;set;}";
				WriteLine(line);
			}
			else
			{
				var line = "public new " + prop.PropertyType.FullName.Replace("+",".") + " " + prop.Name + " {get;set;}";
				WriteObsoleteLine(line);
			}
		}
		
		public static void WriteClassFields(Type winType, Type macType)
		{
			BeginRegion("Fields");
			var wFields = winType.GetFields();
			var mFields = macType.GetFields();
			var fieldsInclude = wFields.Select(x=> x.Name).Intersect(mFields.Select(y=> y.Name)).Distinct().ToList();
			var fieldsExclude = wFields.Select(x=> x.Name).Except(fieldsInclude).Distinct().ToList();
			
			foreach(var fieldName in fieldsInclude)
			{
				var field = wFields.Where(x=> x.Name == fieldName).First();
				var line = "public new " + field.FieldType.FullName.Replace("+",".") + " " + field.Name + ";";
				WriteLine(line);
			}
			
			BeginRegion("Exluded");
			foreach( var fieldName in fieldsExclude)
			{
				
				var field = wFields.Where(x=> x.Name == fieldName).First();
				var line = "public new " + field.FieldType.FullName.Replace("+",".") + " " + field.Name + ";";
				WriteObsoleteLine(line);
			}
			EndRegion();
			EndRegion();
		}
		
		public static void WriteClassMethods(Type winType, Type macType)
		{
			BeginRegion("Excluded Methods");
			var wMethods = winType.GetMethods().Where(x=> !x.IsHideBySig).ToList();
			var mMethods = macType.GetMethods();			
			var methodsInclude = wMethods.Select(x=> x.Name).Intersect(mMethods.Select(y=> y.Name)).Distinct().ToList();
			var methodsExclude = wMethods.Select(x=> x.Name).Except(methodsInclude).Distinct().ToList();
			
			foreach(var methodName in methodsExclude)
			{
				var method = wMethods.Where(x=> x.Name == methodName).First();
				string line = "public " + (method.IsStatic ? "static " : " ") +  (method.IsVirtual ? " override " : " new ");
				line += method.ReturnType.FullName.Replace("+",".") + " ";
				line += method.Name;
				
				string paramString = " (";
				foreach(var p in method.GetParameters().OrderBy(x=> x.Position))
				{
					if(p.Position > 0)
					{
						paramString += " , ";
					}
					paramString += p.ParameterType.FullName.Replace("&","").Replace("+",".") + " " + p.Name;
				}
				paramString += ") {}";
				line += paramString;
				
				WriteObsoleteLine(line);
			}
			
			EndRegion();			
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
	      	WriteLine("[Obsolete(\"This method is not cross-platform compatible.\", true)]");
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

