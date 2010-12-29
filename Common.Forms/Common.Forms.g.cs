using System;
using System.Windows.Forms;
using System.Drawing;

namespace Common.Forms
{
	public  partial class BaseCollection : System.Windows.Forms.BaseCollection
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class Binding : System.Windows.Forms.Binding
	{
		#region Constructors
		public Binding (System.String propertyName , System.Object dataSource , System.String dataMember) : base (propertyName , dataSource , dataMember)
		{
		}
		
		public Binding (System.String propertyName , System.Object dataSource , System.String dataMember , System.Boolean formattingEnabled) : base (propertyName , dataSource , dataMember , formattingEnabled)
		{
		}
		
		public Binding (System.String propertyName , System.Object dataSource , System.String dataMember , System.Boolean formattingEnabled , System.Windows.Forms.DataSourceUpdateMode dataSourceUpdateMode) : base (propertyName , dataSource , dataMember , formattingEnabled , dataSourceUpdateMode)
		{
		}
		
		public Binding (System.String propertyName , System.Object dataSource , System.String dataMember , System.Boolean formattingEnabled , System.Windows.Forms.DataSourceUpdateMode dataSourceUpdateMode , System.Object nullValue) : base (propertyName , dataSource , dataMember , formattingEnabled , dataSourceUpdateMode , nullValue)
		{
		}
		
		public Binding (System.String propertyName , System.Object dataSource , System.String dataMember , System.Boolean formattingEnabled , System.Windows.Forms.DataSourceUpdateMode dataSourceUpdateMode , System.Object nullValue , System.String formatString) : base (propertyName , dataSource , dataMember , formattingEnabled , dataSourceUpdateMode , nullValue , formatString)
		{
		}
		
		public Binding (System.String propertyName , System.Object dataSource , System.String dataMember , System.Boolean formattingEnabled , System.Windows.Forms.DataSourceUpdateMode dataSourceUpdateMode , System.Object nullValue , System.String formatString , System.IFormatProvider formatInfo) : base (propertyName , dataSource , dataMember , formattingEnabled , dataSourceUpdateMode , nullValue , formatString , formatInfo)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		public new event Common.Forms.BindingCompleteEventHandler BindingComplete;
		public new event Common.Forms.ConvertEventHandler Format;
		public new event Common.Forms.ConvertEventHandler Parse;
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class BindingCompleteEventArgs : System.Windows.Forms.BindingCompleteEventArgs
	{
		#region Constructors
		public BindingCompleteEventArgs (System.Windows.Forms.Binding binding , System.Windows.Forms.BindingCompleteState state , System.Windows.Forms.BindingCompleteContext context) : base (binding , state , context)
		{
		}
		
		public BindingCompleteEventArgs (System.Windows.Forms.Binding binding , System.Windows.Forms.BindingCompleteState state , System.Windows.Forms.BindingCompleteContext context , System.String errorText) : base (binding , state , context , errorText)
		{
		}
		
		public BindingCompleteEventArgs (System.Windows.Forms.Binding binding , System.Windows.Forms.BindingCompleteState state , System.Windows.Forms.BindingCompleteContext context , System.String errorText , System.Exception exception) : base (binding , state , context , errorText , exception)
		{
		}
		
		public BindingCompleteEventArgs (System.Windows.Forms.Binding binding , System.Windows.Forms.BindingCompleteState state , System.Windows.Forms.BindingCompleteContext context , System.String errorText , System.Exception exception , System.Boolean cancel) : base (binding , state , context , errorText , exception , cancel)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  BindingCompleteEventHandler (System.Object sender , System.Windows.Forms.BindingCompleteEventArgs e );
	
	public  partial class BindingContext : System.Windows.Forms.BindingContext
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		public new event System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public abstract partial class BindingManagerBase : System.Windows.Forms.BindingManagerBase
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		public new event Common.Forms.BindingCompleteEventHandler BindingComplete;
		public new event System.EventHandler CurrentChanged;
		public new event System.EventHandler CurrentItemChanged;
		public new event Common.Forms.BindingManagerDataErrorEventHandler DataError;
		public new event System.EventHandler PositionChanged;
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class BindingManagerDataErrorEventArgs : System.Windows.Forms.BindingManagerDataErrorEventArgs
	{
		#region Constructors
		public BindingManagerDataErrorEventArgs (System.Exception exception) : base (exception)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  BindingManagerDataErrorEventHandler (System.Object sender , System.Windows.Forms.BindingManagerDataErrorEventArgs e );
	
	public class BindingsCollection
	{
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class Button : System.Windows.Forms.Button
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoSizeMode AutoSizeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoSizeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoEllipsis {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoEllipsis;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatButtonAppearance FlatAppearance {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.FlatAppearance;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.FlatStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image Image {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Image;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ContentAlignment ImageAlign { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImageAlign;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ImageIndex {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImageIndex;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ImageKey {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImageKey;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageList ImageList {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImageList;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ContentAlignment TextAlign { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TextAlign;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new TextImageRelation TextImageRelation { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TextImageRelation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCompatibleTextRendering {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseCompatibleTextRendering;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseMnemonic {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseMnemonic;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Cursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler BackColorChanged;
		public new event System.EventHandler BackgroundImageChanged;
		public new event System.EventHandler BackgroundImageLayoutChanged;
		public new event System.EventHandler BindingContextChanged;
		public new event System.EventHandler CausesValidationChanged;
		public new event Common.Forms.UICuesEventHandler ChangeUICues;
		public new event System.EventHandler Click;
		public new event System.EventHandler ClientSizeChanged;
		public new event System.EventHandler ContextMenuChanged;
		public new event System.EventHandler ContextMenuStripChanged;
		public new event Common.Forms.ControlEventHandler ControlAdded;
		public new event Common.Forms.ControlEventHandler ControlRemoved;
		public new event System.EventHandler CursorChanged;
		public new event System.EventHandler Disposed;
		public new event System.EventHandler DockChanged;
		public new event System.EventHandler DoubleClick;
		public new event Common.Forms.DragEventHandler DragDrop;
		public new event Common.Forms.DragEventHandler DragEnter;
		public new event System.EventHandler DragLeave;
		public new event Common.Forms.DragEventHandler DragOver;
		public new event System.EventHandler EnabledChanged;
		public new event System.EventHandler Enter;
		public new event System.EventHandler FontChanged;
		public new event System.EventHandler ForeColorChanged;
		public new event Common.Forms.GiveFeedbackEventHandler GiveFeedback;
		public new event System.EventHandler GotFocus;
		public new event System.EventHandler HandleCreated;
		public new event System.EventHandler HandleDestroyed;
		public new event Common.Forms.HelpEventHandler HelpRequested;
		public new event System.EventHandler ImeModeChanged;
		public new event Common.Forms.InvalidateEventHandler Invalidated;
		public new event Common.Forms.KeyEventHandler KeyDown;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.KeyEventHandler KeyUp;
		public new event Common.Forms.LayoutEventHandler Layout;
		public new event System.EventHandler Leave;
		public new event System.EventHandler LocationChanged;
		public new event System.EventHandler LostFocus;
		public new event System.EventHandler MarginChanged;
		public new event System.EventHandler MouseCaptureChanged;
		public new event Common.Forms.MouseEventHandler MouseClick;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler Move;
		public new event System.EventHandler PaddingChanged;
		public new event Common.Forms.PaintEventHandler Paint;
		public new event System.EventHandler ParentChanged;
		public new event Common.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		public new event Common.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		public new event Common.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		public new event System.EventHandler RegionChanged;
		public new event System.EventHandler Resize;
		public new event System.EventHandler RightToLeftChanged;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler StyleChanged;
		public new event System.EventHandler SystemColorsChanged;
		public new event System.EventHandler TabIndexChanged;
		public new event System.EventHandler TabStopChanged;
		public new event System.EventHandler TextChanged;
		public new event System.EventHandler Validated;
		public new event System.ComponentModel.CancelEventHandler Validating;
		public new event System.EventHandler VisibleChanged;
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void NotifyDefault (System.Boolean value) { base.NotifyDefault(value);}
		#endregion
	}
	
	public  partial class CheckBox : System.Windows.Forms.CheckBox
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new Appearance Appearance { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Appearance;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoCheck {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoCheck;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ContentAlignment CheckAlign { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CheckAlign;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ContentAlignment TextAlign { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TextAlign;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoEllipsis {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoEllipsis;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatButtonAppearance FlatAppearance {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.FlatAppearance;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.FlatStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image Image {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Image;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ContentAlignment ImageAlign { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImageAlign;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ImageIndex {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImageIndex;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ImageKey {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImageKey;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageList ImageList {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImageList;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new TextImageRelation TextImageRelation { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TextImageRelation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCompatibleTextRendering {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseCompatibleTextRendering;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseMnemonic {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseMnemonic;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Cursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler BackColorChanged;
		public new event System.EventHandler BackgroundImageChanged;
		public new event System.EventHandler BackgroundImageLayoutChanged;
		public new event System.EventHandler BindingContextChanged;
		public new event System.EventHandler CausesValidationChanged;
		public new event Common.Forms.UICuesEventHandler ChangeUICues;
		public new event System.EventHandler Click;
		public new event System.EventHandler ClientSizeChanged;
		public new event System.EventHandler ContextMenuChanged;
		public new event System.EventHandler ContextMenuStripChanged;
		public new event Common.Forms.ControlEventHandler ControlAdded;
		public new event Common.Forms.ControlEventHandler ControlRemoved;
		public new event System.EventHandler CursorChanged;
		public new event System.EventHandler Disposed;
		public new event System.EventHandler DockChanged;
		public new event System.EventHandler DoubleClick;
		public new event Common.Forms.DragEventHandler DragDrop;
		public new event Common.Forms.DragEventHandler DragEnter;
		public new event System.EventHandler DragLeave;
		public new event Common.Forms.DragEventHandler DragOver;
		public new event System.EventHandler EnabledChanged;
		public new event System.EventHandler Enter;
		public new event System.EventHandler FontChanged;
		public new event System.EventHandler ForeColorChanged;
		public new event Common.Forms.GiveFeedbackEventHandler GiveFeedback;
		public new event System.EventHandler GotFocus;
		public new event System.EventHandler HandleCreated;
		public new event System.EventHandler HandleDestroyed;
		public new event Common.Forms.HelpEventHandler HelpRequested;
		public new event System.EventHandler ImeModeChanged;
		public new event Common.Forms.InvalidateEventHandler Invalidated;
		public new event Common.Forms.KeyEventHandler KeyDown;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.KeyEventHandler KeyUp;
		public new event Common.Forms.LayoutEventHandler Layout;
		public new event System.EventHandler Leave;
		public new event System.EventHandler LocationChanged;
		public new event System.EventHandler LostFocus;
		public new event System.EventHandler MarginChanged;
		public new event System.EventHandler MouseCaptureChanged;
		public new event Common.Forms.MouseEventHandler MouseClick;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler Move;
		public new event System.EventHandler PaddingChanged;
		public new event Common.Forms.PaintEventHandler Paint;
		public new event System.EventHandler ParentChanged;
		public new event Common.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		public new event Common.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		public new event Common.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		public new event System.EventHandler RegionChanged;
		public new event System.EventHandler Resize;
		public new event System.EventHandler RightToLeftChanged;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler StyleChanged;
		public new event System.EventHandler SystemColorsChanged;
		public new event System.EventHandler TabIndexChanged;
		public new event System.EventHandler TabStopChanged;
		public new event System.EventHandler TextChanged;
		public new event System.EventHandler Validated;
		public new event System.ComponentModel.CancelEventHandler Validating;
		public new event System.EventHandler VisibleChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AppearanceChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler CheckedChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler CheckStateChanged;
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class CheckedListBox : System.Windows.Forms.CheckedListBox
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.CheckedListBox.CheckedIndexCollection CheckedIndices {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CheckedIndices;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.CheckedListBox.CheckedItemCollection CheckedItems {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CheckedItems;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CheckOnClick {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CheckOnClick;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DrawMode DrawMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.DrawMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ItemHeight {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ItemHeight;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ThreeDCheckBoxes {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ThreeDCheckBoxes;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCompatibleTextRendering {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseCompatibleTextRendering;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new BorderStyle BorderStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.BorderStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ColumnWidth {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ColumnWidth;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.IntegerCollection CustomTabOffsets {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CustomTabOffsets;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 HorizontalExtent {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.HorizontalExtent;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HorizontalScrollbar {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.HorizontalScrollbar;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IntegralHeight {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IntegralHeight;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean MultiColumn {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.MultiColumn;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredHeight;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ScrollAlwaysVisible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ScrollAlwaysVisible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.SelectedIndexCollection SelectedIndices {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectedIndices;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Sorted {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Sorted;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TopIndex {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopIndex;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCustomTabOffsets {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseCustomTabOffsets;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseTabStops {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseTabStops;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IFormatProvider FormatInfo {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.FormatInfo;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String FormatString {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.FormatString;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object SelectedValue {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectedValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Cursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler BackColorChanged;
		public new event System.EventHandler BackgroundImageChanged;
		public new event System.EventHandler BackgroundImageLayoutChanged;
		public new event System.EventHandler BindingContextChanged;
		public new event System.EventHandler CausesValidationChanged;
		public new event Common.Forms.UICuesEventHandler ChangeUICues;
		public new event System.EventHandler Click;
		public new event System.EventHandler ClientSizeChanged;
		public new event System.EventHandler ContextMenuChanged;
		public new event System.EventHandler ContextMenuStripChanged;
		public new event Common.Forms.ControlEventHandler ControlAdded;
		public new event Common.Forms.ControlEventHandler ControlRemoved;
		public new event System.EventHandler CursorChanged;
		public new event System.EventHandler Disposed;
		public new event System.EventHandler DockChanged;
		public new event System.EventHandler DoubleClick;
		public new event Common.Forms.DragEventHandler DragDrop;
		public new event Common.Forms.DragEventHandler DragEnter;
		public new event System.EventHandler DragLeave;
		public new event Common.Forms.DragEventHandler DragOver;
		public new event System.EventHandler EnabledChanged;
		public new event System.EventHandler Enter;
		public new event System.EventHandler FontChanged;
		public new event System.EventHandler ForeColorChanged;
		public new event Common.Forms.GiveFeedbackEventHandler GiveFeedback;
		public new event System.EventHandler GotFocus;
		public new event System.EventHandler HandleCreated;
		public new event System.EventHandler HandleDestroyed;
		public new event Common.Forms.HelpEventHandler HelpRequested;
		public new event System.EventHandler ImeModeChanged;
		public new event Common.Forms.InvalidateEventHandler Invalidated;
		public new event Common.Forms.KeyEventHandler KeyDown;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.KeyEventHandler KeyUp;
		public new event Common.Forms.LayoutEventHandler Layout;
		public new event System.EventHandler Leave;
		public new event System.EventHandler LocationChanged;
		public new event System.EventHandler LostFocus;
		public new event System.EventHandler MarginChanged;
		public new event System.EventHandler MouseCaptureChanged;
		public new event Common.Forms.MouseEventHandler MouseClick;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler Move;
		public new event System.EventHandler PaddingChanged;
		public new event Common.Forms.PaintEventHandler Paint;
		public new event System.EventHandler ParentChanged;
		public new event Common.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		public new event Common.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		public new event Common.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		public new event System.EventHandler RegionChanged;
		public new event System.EventHandler Resize;
		public new event System.EventHandler RightToLeftChanged;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler StyleChanged;
		public new event System.EventHandler SystemColorsChanged;
		public new event System.EventHandler TabIndexChanged;
		public new event System.EventHandler TabStopChanged;
		public new event System.EventHandler TextChanged;
		public new event System.EventHandler Validated;
		public new event System.ComponentModel.CancelEventHandler Validating;
		public new event System.EventHandler VisibleChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DataSourceChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DisplayMemberChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.DrawItemEventHandler DrawItem;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.ListControlConvertEventHandler Format;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormatInfoChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormatStringChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormattingEnabledChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.ItemCheckEventHandler ItemCheck;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MeasureItemEventHandler MeasureItem;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SelectedIndexChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SelectedValueChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ValueMemberChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Boolean GetItemChecked (System.Int32 index) {return  base.GetItemChecked(index);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new System.Windows.Forms.CheckState GetItemCheckState (System.Int32 index) {return  base.GetItemCheckState(index);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void SetItemChecked (System.Int32 index , System.Boolean value) { base.SetItemChecked(index , value);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void SetItemCheckState (System.Int32 index , System.Windows.Forms.CheckState value) { base.SetItemCheckState(index , value);}
		#endregion
	}
	
	public  partial class ComboBox : System.Windows.Forms.ComboBox
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoCompleteStringCollection AutoCompleteCustomSource {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoCompleteCustomSource;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoCompleteMode AutoCompleteMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoCompleteMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoCompleteSource AutoCompleteSource { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoCompleteSource;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DrawMode DrawMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.DrawMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DropDownHeight {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.DropDownHeight;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DropDownWidth {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.DropDownWidth;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean DroppedDown {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.DroppedDown;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.FlatStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IntegralHeight {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IntegralHeight;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ItemHeight {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ItemHeight;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MaxDropDownItems {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.MaxDropDownItems;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MaxLength {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.MaxLength;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredHeight;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectedIndex {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectedIndex;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String SelectedText {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectedText;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectionLength {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectionLength;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectionStart {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectionStart;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Sorted {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Sorted;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IFormatProvider FormatInfo {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.FormatInfo;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String FormatString {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.FormatString;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Cursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler BackColorChanged;
		public new event System.EventHandler BackgroundImageChanged;
		public new event System.EventHandler BackgroundImageLayoutChanged;
		public new event System.EventHandler BindingContextChanged;
		public new event System.EventHandler CausesValidationChanged;
		public new event Common.Forms.UICuesEventHandler ChangeUICues;
		public new event System.EventHandler Click;
		public new event System.EventHandler ClientSizeChanged;
		public new event System.EventHandler ContextMenuChanged;
		public new event System.EventHandler ContextMenuStripChanged;
		public new event Common.Forms.ControlEventHandler ControlAdded;
		public new event Common.Forms.ControlEventHandler ControlRemoved;
		public new event System.EventHandler CursorChanged;
		public new event System.EventHandler Disposed;
		public new event System.EventHandler DockChanged;
		public new event System.EventHandler DoubleClick;
		public new event Common.Forms.DragEventHandler DragDrop;
		public new event Common.Forms.DragEventHandler DragEnter;
		public new event System.EventHandler DragLeave;
		public new event Common.Forms.DragEventHandler DragOver;
		public new event System.EventHandler EnabledChanged;
		public new event System.EventHandler Enter;
		public new event System.EventHandler FontChanged;
		public new event System.EventHandler ForeColorChanged;
		public new event Common.Forms.GiveFeedbackEventHandler GiveFeedback;
		public new event System.EventHandler GotFocus;
		public new event System.EventHandler HandleCreated;
		public new event System.EventHandler HandleDestroyed;
		public new event Common.Forms.HelpEventHandler HelpRequested;
		public new event System.EventHandler ImeModeChanged;
		public new event Common.Forms.InvalidateEventHandler Invalidated;
		public new event Common.Forms.KeyEventHandler KeyDown;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.KeyEventHandler KeyUp;
		public new event Common.Forms.LayoutEventHandler Layout;
		public new event System.EventHandler Leave;
		public new event System.EventHandler LocationChanged;
		public new event System.EventHandler LostFocus;
		public new event System.EventHandler MarginChanged;
		public new event System.EventHandler MouseCaptureChanged;
		public new event Common.Forms.MouseEventHandler MouseClick;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler Move;
		public new event System.EventHandler PaddingChanged;
		public new event Common.Forms.PaintEventHandler Paint;
		public new event System.EventHandler ParentChanged;
		public new event Common.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		public new event Common.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		public new event Common.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		public new event System.EventHandler RegionChanged;
		public new event System.EventHandler Resize;
		public new event System.EventHandler RightToLeftChanged;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler StyleChanged;
		public new event System.EventHandler SystemColorsChanged;
		public new event System.EventHandler TabIndexChanged;
		public new event System.EventHandler TabStopChanged;
		public new event System.EventHandler TextChanged;
		public new event System.EventHandler Validated;
		public new event System.ComponentModel.CancelEventHandler Validating;
		public new event System.EventHandler VisibleChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DataSourceChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DisplayMemberChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.DrawItemEventHandler DrawItem;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DropDown;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DropDownClosed;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DropDownStyleChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.ListControlConvertEventHandler Format;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormatInfoChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormatStringChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormattingEnabledChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MeasureItemEventHandler MeasureItem;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SelectedIndexChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SelectedValueChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SelectionChangeCommitted;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TextUpdate;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ValueMemberChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void BeginUpdate () { base.BeginUpdate();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void EndUpdate () { base.EndUpdate();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Int32 FindString (System.String s) {return  base.FindString(s);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Int32 FindStringExact (System.String s) {return  base.FindStringExact(s);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Int32 GetItemHeight (System.Int32 index) {return  base.GetItemHeight(index);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void ResetText () { base.ResetText();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void Select (System.Int32 start , System.Int32 length) { base.Select(start , length);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void SelectAll () { base.SelectAll();}
		#endregion
	}
	
	public  partial class ContainerControl : System.Windows.Forms.ContainerControl
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HScrollProperties HorizontalScroll {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.HorizontalScroll;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.VScrollProperties VerticalScroll {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.VerticalScroll;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Cursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler AutoValidateChanged;
		public new event System.EventHandler BackColorChanged;
		public new event System.EventHandler BackgroundImageChanged;
		public new event System.EventHandler BackgroundImageLayoutChanged;
		public new event System.EventHandler BindingContextChanged;
		public new event System.EventHandler CausesValidationChanged;
		public new event Common.Forms.UICuesEventHandler ChangeUICues;
		public new event System.EventHandler Click;
		public new event System.EventHandler ClientSizeChanged;
		public new event System.EventHandler ContextMenuChanged;
		public new event System.EventHandler ContextMenuStripChanged;
		public new event Common.Forms.ControlEventHandler ControlAdded;
		public new event Common.Forms.ControlEventHandler ControlRemoved;
		public new event System.EventHandler CursorChanged;
		public new event System.EventHandler Disposed;
		public new event System.EventHandler DockChanged;
		public new event System.EventHandler DoubleClick;
		public new event Common.Forms.DragEventHandler DragDrop;
		public new event Common.Forms.DragEventHandler DragEnter;
		public new event System.EventHandler DragLeave;
		public new event Common.Forms.DragEventHandler DragOver;
		public new event System.EventHandler EnabledChanged;
		public new event System.EventHandler Enter;
		public new event System.EventHandler FontChanged;
		public new event System.EventHandler ForeColorChanged;
		public new event Common.Forms.GiveFeedbackEventHandler GiveFeedback;
		public new event System.EventHandler GotFocus;
		public new event System.EventHandler HandleCreated;
		public new event System.EventHandler HandleDestroyed;
		public new event Common.Forms.HelpEventHandler HelpRequested;
		public new event System.EventHandler ImeModeChanged;
		public new event Common.Forms.InvalidateEventHandler Invalidated;
		public new event Common.Forms.KeyEventHandler KeyDown;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.KeyEventHandler KeyUp;
		public new event Common.Forms.LayoutEventHandler Layout;
		public new event System.EventHandler Leave;
		public new event System.EventHandler LocationChanged;
		public new event System.EventHandler LostFocus;
		public new event System.EventHandler MarginChanged;
		public new event System.EventHandler MouseCaptureChanged;
		public new event Common.Forms.MouseEventHandler MouseClick;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler Move;
		public new event System.EventHandler PaddingChanged;
		public new event Common.Forms.PaintEventHandler Paint;
		public new event System.EventHandler ParentChanged;
		public new event Common.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		public new event Common.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		public new event Common.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		public new event System.EventHandler RegionChanged;
		public new event System.EventHandler Resize;
		public new event System.EventHandler RightToLeftChanged;
		public new event Common.Forms.ScrollEventHandler Scroll;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler StyleChanged;
		public new event System.EventHandler SystemColorsChanged;
		public new event System.EventHandler TabIndexChanged;
		public new event System.EventHandler TabStopChanged;
		public new event System.EventHandler TextChanged;
		public new event System.EventHandler Validated;
		public new event System.ComponentModel.CancelEventHandler Validating;
		public new event System.EventHandler VisibleChanged;
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class Control : System.Windows.Forms.Control
	{
		#region Constructors
		public Control () : base ()
		{
		}
		
		public Control (System.Windows.Forms.Control parent , System.String text) : base (parent , text)
		{
		}
		
		public Control (System.Windows.Forms.Control parent , System.String text , System.Int32 left , System.Int32 top , System.Int32 width , System.Int32 height) : base (parent , text , left , top , width , height)
		{
		}
		
		public Control (System.String text) : base (text)
		{
		}
		
		public Control (System.String text , System.Int32 left , System.Int32 top , System.Int32 width , System.Int32 height) : base (text , left , top , width , height)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Font DefaultFont {get{   if( !this.DesignMode ) throw new NotImplementedException(); return DefaultFont;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color DefaultForeColor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return DefaultForeColor;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new Keys ModifierKeys { get{   if( !this.DesignMode ) throw new NotImplementedException(); return ModifierKeys;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MouseButtons MouseButtons { get{   if( !this.DesignMode ) throw new NotImplementedException(); return MouseButtons;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point MousePosition {get{   if( !this.DesignMode ) throw new NotImplementedException(); return MousePosition;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CheckForIllegalCrossThreadCalls {get{   if( !this.DesignMode ) throw new NotImplementedException(); return CheckForIllegalCrossThreadCalls;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Cursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler BackColorChanged;
		public new event System.EventHandler BackgroundImageChanged;
		public new event System.EventHandler BackgroundImageLayoutChanged;
		public new event System.EventHandler BindingContextChanged;
		public new event System.EventHandler CausesValidationChanged;
		public new event Common.Forms.UICuesEventHandler ChangeUICues;
		public new event System.EventHandler Click;
		public new event System.EventHandler ClientSizeChanged;
		public new event System.EventHandler ContextMenuChanged;
		public new event System.EventHandler ContextMenuStripChanged;
		public new event Common.Forms.ControlEventHandler ControlAdded;
		public new event Common.Forms.ControlEventHandler ControlRemoved;
		public new event System.EventHandler CursorChanged;
		public new event System.EventHandler Disposed;
		public new event System.EventHandler DockChanged;
		public new event System.EventHandler DoubleClick;
		public new event Common.Forms.DragEventHandler DragDrop;
		public new event Common.Forms.DragEventHandler DragEnter;
		public new event System.EventHandler DragLeave;
		public new event Common.Forms.DragEventHandler DragOver;
		public new event System.EventHandler EnabledChanged;
		public new event System.EventHandler Enter;
		public new event System.EventHandler FontChanged;
		public new event System.EventHandler ForeColorChanged;
		public new event Common.Forms.GiveFeedbackEventHandler GiveFeedback;
		public new event System.EventHandler GotFocus;
		public new event System.EventHandler HandleCreated;
		public new event System.EventHandler HandleDestroyed;
		public new event Common.Forms.HelpEventHandler HelpRequested;
		public new event System.EventHandler ImeModeChanged;
		public new event Common.Forms.InvalidateEventHandler Invalidated;
		public new event Common.Forms.KeyEventHandler KeyDown;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.KeyEventHandler KeyUp;
		public new event Common.Forms.LayoutEventHandler Layout;
		public new event System.EventHandler Leave;
		public new event System.EventHandler LocationChanged;
		public new event System.EventHandler LostFocus;
		public new event System.EventHandler MarginChanged;
		public new event System.EventHandler MouseCaptureChanged;
		public new event Common.Forms.MouseEventHandler MouseClick;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler Move;
		public new event System.EventHandler PaddingChanged;
		public new event Common.Forms.PaintEventHandler Paint;
		public new event System.EventHandler ParentChanged;
		public new event Common.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		public new event Common.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		public new event Common.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		public new event System.EventHandler RegionChanged;
		public new event System.EventHandler Resize;
		public new event System.EventHandler RightToLeftChanged;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler StyleChanged;
		public new event System.EventHandler SystemColorsChanged;
		public new event System.EventHandler TabIndexChanged;
		public new event System.EventHandler TabStopChanged;
		public new event System.EventHandler TextChanged;
		public new event System.EventHandler Validated;
		public new event System.ComponentModel.CancelEventHandler Validating;
		public new event System.EventHandler VisibleChanged;
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void DrawToBitmap (System.Drawing.Bitmap bitmap , System.Drawing.Rectangle targetBounds) { base.DrawToBitmap(bitmap , targetBounds);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public static  new System.Windows.Forms.Control FromChildHandle (System.IntPtr handle) {return System.Windows.Forms.Control.FromChildHandle(handle);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public static  new System.Windows.Forms.Control FromHandle (System.IntPtr handle) {return System.Windows.Forms.Control.FromHandle(handle);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public static  new Boolean IsKeyLocked (System.Windows.Forms.Keys keyVal) {return System.Windows.Forms.Control.IsKeyLocked(keyVal);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public static  new Boolean IsMnemonic (System.Char charCode , System.String text) {return System.Windows.Forms.Control.IsMnemonic(charCode , text);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new IAsyncResult BeginInvoke (System.Delegate method) {return  base.BeginInvoke(method);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void BringToFront () { base.BringToFront();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void CreateControl () { base.CreateControl();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Graphics CreateGraphics () {return  base.CreateGraphics();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new System.Windows.Forms.DragDropEffects DoDragDrop (System.Object data , System.Windows.Forms.DragDropEffects allowedEffects) {return  base.DoDragDrop(data , allowedEffects);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Boolean Focus () {return  base.Focus();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new System.Windows.Forms.Control GetChildAtPoint (System.Drawing.Point pt) {return  base.GetChildAtPoint(pt);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Size GetPreferredSize (System.Drawing.Size proposedSize) {return  base.GetPreferredSize(proposedSize);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void Hide () { base.Hide();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Object Invoke (System.Delegate method) {return  base.Invoke(method);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Point PointToClient (System.Drawing.Point p) {return  base.PointToClient(p);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Point PointToScreen (System.Drawing.Point p) {return  base.PointToScreen(p);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Rectangle RectangleToClient (System.Drawing.Rectangle r) {return  base.RectangleToClient(r);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Rectangle RectangleToScreen (System.Drawing.Rectangle r) {return  base.RectangleToScreen(r);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void ResetBackColor () { base.ResetBackColor();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void ResetBindings () { base.ResetBindings();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void ResetCursor () { base.ResetCursor();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void ResetFont () { base.ResetFont();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void ResetForeColor () { base.ResetForeColor();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void ResetImeMode () { base.ResetImeMode();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void ResetRightToLeft () { base.ResetRightToLeft();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void ResetText () { base.ResetText();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void Select () { base.Select();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void SendToBack () { base.SendToBack();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void Show () { base.Show();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void Update () { base.Update();}
		#endregion
	}
	
	public  partial class ControlBindingsCollection : System.Windows.Forms.ControlBindingsCollection
	{
		#region Constructors
		public ControlBindingsCollection (System.Windows.Forms.IBindableComponent control) : base (control)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		public new event System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
		public new event System.ComponentModel.CollectionChangeEventHandler CollectionChanging;
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class ControlEventArgs : System.Windows.Forms.ControlEventArgs
	{
		#region Constructors
		public ControlEventArgs (System.Windows.Forms.Control control) : base (control)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  ControlEventHandler (System.Object sender , System.Windows.Forms.ControlEventArgs e );
	
	public  partial class ConvertEventArgs : System.Windows.Forms.ConvertEventArgs
	{
		#region Constructors
		public ConvertEventArgs (System.Object value , System.Type desiredType) : base (value , desiredType)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  ConvertEventHandler (System.Object sender , System.Windows.Forms.ConvertEventArgs e );
	
	public class CurrencyManager
	{
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class DataGridViewButtonCell : System.Windows.Forms.DataGridViewButtonCell
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type EditType {get{  return  base.EditType;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle { get{  return  base.FlatStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type FormattedValueType {get{  return  base.FormattedValueType;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseColumnTextForButtonValue {get{  return  base.UseColumnTextForButtonValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type ValueType {get{  return  base.ValueType;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{  return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ColumnIndex {get{  return  base.ColumnIndex;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ContentBounds {get{  return  base.ContentBounds;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{  return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object DefaultNewRowValue {get{  return  base.DefaultNewRowValue;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Displayed {get{  return  base.Displayed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object EditedFormattedValue {get{  return  base.EditedFormattedValue;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ErrorIconBounds {get{  return  base.ErrorIconBounds;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ErrorText {get{  return  base.ErrorText;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object FormattedValue {get{  return  base.FormattedValue;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Frozen {get{  return  base.Frozen;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasStyle {get{  return  base.HasStyle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewElementStates InheritedState { get{  return  base.InheritedState;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle InheritedStyle {get{  return  base.InheritedStyle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsInEditMode {get{  return  base.IsInEditMode;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewColumn OwningColumn {get{  return  base.OwningColumn;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewRow OwningRow {get{  return  base.OwningRow;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{  return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get{  return  base.ReadOnly;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Resizable {get{  return  base.Resizable;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 RowIndex {get{  return  base.RowIndex;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selected {get{  return  base.Selected;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size Size {get{  return  base.Size;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle Style {get{  return  base.Style;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ToolTipText {get{  return  base.ToolTipText;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Value {get{  return  base.Value;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get{  return  base.Visible;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridView DataGridView {get{  return  base.DataGridView;}}
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Object Clone () {return  base.Clone();}
		#endregion
	}
	
	public  partial class DataGridViewButtonColumn : System.Windows.Forms.DataGridViewButtonColumn
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCell CellTemplate {get{  return  base.CellTemplate;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle DefaultCellStyle {get{  return  base.DefaultCellStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle { get{  return  base.FlatStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Text {get{  return  base.Text;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseColumnTextForButtonValue {get{  return  base.UseColumnTextForButtonValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewAutoSizeColumnMode AutoSizeMode { get{  return  base.AutoSizeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type CellType {get{  return  base.CellType;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{  return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String DataPropertyName {get{  return  base.DataPropertyName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DisplayIndex {get{  return  base.DisplayIndex;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DividerWidth {get{  return  base.DividerWidth;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single FillWeight {get{  return  base.FillWeight;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Frozen {get{  return  base.Frozen;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String HeaderText {get{  return  base.HeaderText;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewAutoSizeColumnMode InheritedAutoSizeMode { get{  return  base.InheritedAutoSizeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle InheritedStyle {get{  return  base.InheritedStyle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDataBound {get{  return  base.IsDataBound;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MinimumWidth {get{  return  base.MinimumWidth;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Name {get{  return  base.Name;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get{  return  base.ReadOnly;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewTriState Resizable { get{  return  base.Resizable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewColumnSortMode SortMode { get{  return  base.SortMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ToolTipText {get{  return  base.ToolTipText;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type ValueType {get{  return  base.ValueType;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get{  return  base.Visible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type DefaultHeaderCellType {get{  return  base.DefaultHeaderCellType;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Displayed {get{  return  base.Displayed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasDefaultCellStyle {get{  return  base.HasDefaultCellStyle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Index {get{  return  base.Index;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selected {get{  return  base.Selected;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{  return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridView DataGridView {get{  return  base.DataGridView;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewElementStates State { get{  return  base.State;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Disposed;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Object Clone () {return  base.Clone();}
		#endregion
	}
	
	public  partial class DataGridViewCheckBoxCell : System.Windows.Forms.DataGridViewCheckBoxCell
	{
		#region Constructors
		public DataGridViewCheckBoxCell () : base ()
		{
		}
		
		[Obsolete("This method is not cross-platform compatible.", true)]
		public DataGridViewCheckBoxCell (System.Boolean threeState) : base (threeState)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object EditingCellFormattedValue {get{  return  base.EditingCellFormattedValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean EditingCellValueChanged {get{  return  base.EditingCellValueChanged;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type EditType {get{  return  base.EditType;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object FalseValue {get{  return  base.FalseValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle { get{  return  base.FlatStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type FormattedValueType {get{  return  base.FormattedValueType;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object IndeterminateValue {get{  return  base.IndeterminateValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ThreeState {get{  return  base.ThreeState;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object TrueValue {get{  return  base.TrueValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type ValueType {get{  return  base.ValueType;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{  return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ColumnIndex {get{  return  base.ColumnIndex;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ContentBounds {get{  return  base.ContentBounds;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{  return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object DefaultNewRowValue {get{  return  base.DefaultNewRowValue;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Displayed {get{  return  base.Displayed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object EditedFormattedValue {get{  return  base.EditedFormattedValue;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ErrorIconBounds {get{  return  base.ErrorIconBounds;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ErrorText {get{  return  base.ErrorText;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object FormattedValue {get{  return  base.FormattedValue;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Frozen {get{  return  base.Frozen;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasStyle {get{  return  base.HasStyle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewElementStates InheritedState { get{  return  base.InheritedState;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle InheritedStyle {get{  return  base.InheritedStyle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsInEditMode {get{  return  base.IsInEditMode;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewColumn OwningColumn {get{  return  base.OwningColumn;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewRow OwningRow {get{  return  base.OwningRow;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{  return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get{  return  base.ReadOnly;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Resizable {get{  return  base.Resizable;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 RowIndex {get{  return  base.RowIndex;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selected {get{  return  base.Selected;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size Size {get{  return  base.Size;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle Style {get{  return  base.Style;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ToolTipText {get{  return  base.ToolTipText;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Value {get{  return  base.Value;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get{  return  base.Visible;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridView DataGridView {get{  return  base.DataGridView;}}
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Object Clone () {return  base.Clone();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Object GetEditingCellFormattedValue (System.Windows.Forms.DataGridViewDataErrorContexts context) {return  base.GetEditingCellFormattedValue(context);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Object ParseFormattedValue (System.Object formattedValue , System.Windows.Forms.DataGridViewCellStyle cellStyle , System.ComponentModel.TypeConverter formattedValueTypeConverter , System.ComponentModel.TypeConverter valueTypeConverter) {return  base.ParseFormattedValue(formattedValue , cellStyle , formattedValueTypeConverter , valueTypeConverter);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void PrepareEditingCellForEdit (System.Boolean selectAll) { base.PrepareEditingCellForEdit(selectAll);}
		#endregion
	}
	
	public  partial class DataGridViewCheckBoxColumn : System.Windows.Forms.DataGridViewCheckBoxColumn
	{
		#region Constructors
		public DataGridViewCheckBoxColumn () : base ()
		{
		}
		
		[Obsolete("This method is not cross-platform compatible.", true)]
		public DataGridViewCheckBoxColumn (System.Boolean threeState) : base (threeState)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCell CellTemplate {get{  return  base.CellTemplate;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle DefaultCellStyle {get{  return  base.DefaultCellStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object FalseValue {get{  return  base.FalseValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle { get{  return  base.FlatStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object IndeterminateValue {get{  return  base.IndeterminateValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ThreeState {get{  return  base.ThreeState;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object TrueValue {get{  return  base.TrueValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewAutoSizeColumnMode AutoSizeMode { get{  return  base.AutoSizeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type CellType {get{  return  base.CellType;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{  return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String DataPropertyName {get{  return  base.DataPropertyName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DisplayIndex {get{  return  base.DisplayIndex;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DividerWidth {get{  return  base.DividerWidth;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single FillWeight {get{  return  base.FillWeight;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Frozen {get{  return  base.Frozen;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String HeaderText {get{  return  base.HeaderText;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewAutoSizeColumnMode InheritedAutoSizeMode { get{  return  base.InheritedAutoSizeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle InheritedStyle {get{  return  base.InheritedStyle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDataBound {get{  return  base.IsDataBound;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MinimumWidth {get{  return  base.MinimumWidth;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Name {get{  return  base.Name;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get{  return  base.ReadOnly;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewTriState Resizable { get{  return  base.Resizable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewColumnSortMode SortMode { get{  return  base.SortMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ToolTipText {get{  return  base.ToolTipText;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type ValueType {get{  return  base.ValueType;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get{  return  base.Visible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type DefaultHeaderCellType {get{  return  base.DefaultHeaderCellType;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Displayed {get{  return  base.Displayed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasDefaultCellStyle {get{  return  base.HasDefaultCellStyle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Index {get{  return  base.Index;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selected {get{  return  base.Selected;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{  return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridView DataGridView {get{  return  base.DataGridView;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewElementStates State { get{  return  base.State;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Disposed;
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class DragEventArgs : System.Windows.Forms.DragEventArgs
	{
		#region Constructors
		public DragEventArgs (System.Windows.Forms.IDataObject data , System.Int32 keyState , System.Int32 x , System.Int32 y , System.Windows.Forms.DragDropEffects allowedEffect , System.Windows.Forms.DragDropEffects effect) : base (data , keyState , x , y , allowedEffect , effect)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  DragEventHandler (System.Object sender , System.Windows.Forms.DragEventArgs e );
	
	public  partial class Form : System.Windows.Forms.Form
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowTransparency {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowTransparency;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScaleBaseSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoScaleBaseSize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoSizeMode AutoSizeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoSizeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ControlBox {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ControlBox;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DesktopBounds {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.DesktopBounds;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point DesktopLocation {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.DesktopLocation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FormBorderStyle FormBorderStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.FormBorderStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HelpButton {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.HelpButton;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMdiChild {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMdiChild;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMdiContainer {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMdiContainer;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form ActiveMdiChild {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ActiveMdiChild;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsRestrictedWindow {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsRestrictedWindow;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean KeyPreview {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.KeyPreview;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MenuStrip MainMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.MainMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form[] MdiChildren {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.MdiChildren;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form MdiParent {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.MdiParent;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MainMenu Menu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Menu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MainMenu MergedMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.MergedMenu;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Double Opacity {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Opacity;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form[] OwnedForms {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.OwnedForms;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form Owner {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Owner;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle RestoreBounds {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RestoreBounds;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RightToLeftLayout {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RightToLeftLayout;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowIcon {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ShowIcon;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowInTaskbar {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ShowInTaskbar;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new SizeGripStyle SizeGripStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SizeGripStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FormStartPosition StartPosition { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.StartPosition;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TopLevel {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevel;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TopMost {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopMost;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color TransparencyKey {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TransparencyKey;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FormWindowState WindowState { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowState;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HScrollProperties HorizontalScroll {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.HorizontalScroll;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.VScrollProperties VerticalScroll {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.VerticalScroll;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Cursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler AutoValidateChanged;
		public new event System.EventHandler BackColorChanged;
		public new event System.EventHandler BackgroundImageChanged;
		public new event System.EventHandler BackgroundImageLayoutChanged;
		public new event System.EventHandler BindingContextChanged;
		public new event System.EventHandler CausesValidationChanged;
		public new event Common.Forms.UICuesEventHandler ChangeUICues;
		public new event System.EventHandler Click;
		public new event System.EventHandler ClientSizeChanged;
		public new event System.EventHandler ContextMenuChanged;
		public new event System.EventHandler ContextMenuStripChanged;
		public new event Common.Forms.ControlEventHandler ControlAdded;
		public new event Common.Forms.ControlEventHandler ControlRemoved;
		public new event System.EventHandler CursorChanged;
		public new event System.EventHandler Disposed;
		public new event System.EventHandler DockChanged;
		public new event System.EventHandler DoubleClick;
		public new event Common.Forms.DragEventHandler DragDrop;
		public new event Common.Forms.DragEventHandler DragEnter;
		public new event System.EventHandler DragLeave;
		public new event Common.Forms.DragEventHandler DragOver;
		public new event System.EventHandler EnabledChanged;
		public new event System.EventHandler Enter;
		public new event System.EventHandler FontChanged;
		public new event System.EventHandler ForeColorChanged;
		public new event Common.Forms.GiveFeedbackEventHandler GiveFeedback;
		public new event System.EventHandler GotFocus;
		public new event System.EventHandler HandleCreated;
		public new event System.EventHandler HandleDestroyed;
		public new event Common.Forms.HelpEventHandler HelpRequested;
		public new event System.EventHandler ImeModeChanged;
		public new event Common.Forms.InvalidateEventHandler Invalidated;
		public new event Common.Forms.KeyEventHandler KeyDown;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.KeyEventHandler KeyUp;
		public new event Common.Forms.LayoutEventHandler Layout;
		public new event System.EventHandler Leave;
		public new event System.EventHandler LocationChanged;
		public new event System.EventHandler LostFocus;
		public new event System.EventHandler MarginChanged;
		public new event System.EventHandler MouseCaptureChanged;
		public new event Common.Forms.MouseEventHandler MouseClick;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler Move;
		public new event System.EventHandler PaddingChanged;
		public new event Common.Forms.PaintEventHandler Paint;
		public new event System.EventHandler ParentChanged;
		public new event Common.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		public new event Common.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		public new event Common.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		public new event System.EventHandler RegionChanged;
		public new event System.EventHandler Resize;
		public new event System.EventHandler RightToLeftChanged;
		public new event Common.Forms.ScrollEventHandler Scroll;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler StyleChanged;
		public new event System.EventHandler SystemColorsChanged;
		public new event System.EventHandler TabIndexChanged;
		public new event System.EventHandler TabStopChanged;
		public new event System.EventHandler TextChanged;
		public new event System.EventHandler Validated;
		public new event System.ComponentModel.CancelEventHandler Validating;
		public new event System.EventHandler VisibleChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Activated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Closed;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.ComponentModel.CancelEventHandler Closing;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Deactivate;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.FormClosedEventHandler FormClosed;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.FormClosingEventHandler FormClosing;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.ComponentModel.CancelEventHandler HelpButtonClicked;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.InputLanguageChangedEventHandler InputLanguageChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.InputLanguageChangingEventHandler InputLanguageChanging;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Load;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MaximizedBoundsChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MaximumSizeChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MdiChildActivate;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MenuComplete;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MenuStart;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MinimumSizeChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ResizeBegin;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ResizeEnd;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler RightToLeftLayoutChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Shown;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public static  new SizeF GetAutoScaleSize (System.Drawing.Font font) {return System.Windows.Forms.Form.GetAutoScaleSize(font);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void Activate () { base.Activate();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void AddOwnedForm (System.Windows.Forms.Form ownedForm) { base.AddOwnedForm(ownedForm);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void LayoutMdi (System.Windows.Forms.MdiLayout value) { base.LayoutMdi(value);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void RemoveOwnedForm (System.Windows.Forms.Form ownedForm) { base.RemoveOwnedForm(ownedForm);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void SetDesktopBounds (System.Int32 x , System.Int32 y , System.Int32 width , System.Int32 height) { base.SetDesktopBounds(x , y , width , height);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void SetDesktopLocation (System.Int32 x , System.Int32 y) { base.SetDesktopLocation(x , y);}
		#endregion
	}
	
	public  partial class GiveFeedbackEventArgs : System.Windows.Forms.GiveFeedbackEventArgs
	{
		#region Constructors
		public GiveFeedbackEventArgs (System.Windows.Forms.DragDropEffects effect , System.Boolean useDefaultCursors) : base (effect , useDefaultCursors)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  GiveFeedbackEventHandler (System.Object sender , System.Windows.Forms.GiveFeedbackEventArgs e );
	
	public  partial class HelpEventArgs : System.Windows.Forms.HelpEventArgs
	{
		#region Constructors
		public HelpEventArgs (System.Drawing.Point mousePos) : base (mousePos)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  HelpEventHandler (System.Object sender , System.Windows.Forms.HelpEventArgs e );
	
	public  partial class InvalidateEventArgs : System.Windows.Forms.InvalidateEventArgs
	{
		#region Constructors
		public InvalidateEventArgs (System.Drawing.Rectangle invalidRect) : base (invalidRect)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  InvalidateEventHandler (System.Object sender , System.Windows.Forms.InvalidateEventArgs e );
	
	public class ItemChangedEventArgs
	{
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  ItemChangedEventHandler (System.Object sender , System.Windows.Forms.ItemChangedEventArgs e );
	
	public  partial class KeyEventArgs : System.Windows.Forms.KeyEventArgs
	{
		#region Constructors
		[Obsolete("This method is not cross-platform compatible.", true)]
		public KeyEventArgs (System.Windows.Forms.Keys keyData) : base (keyData)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  KeyEventHandler (System.Object sender , System.Windows.Forms.KeyEventArgs e );
	
	public  partial class KeyPressEventArgs : System.Windows.Forms.KeyPressEventArgs
	{
		#region Constructors
		public KeyPressEventArgs (System.Char keyChar) : base (keyChar)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  KeyPressEventHandler (System.Object sender , System.Windows.Forms.KeyPressEventArgs e );
	
	public  partial class Label : System.Windows.Forms.Label
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoEllipsis {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoEllipsis;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new BorderStyle BorderStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.BorderStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.FlatStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image Image {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Image;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ContentAlignment ImageAlign { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImageAlign;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ImageIndex {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImageIndex;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ImageKey {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImageKey;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageList ImageList {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImageList;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredHeight;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredWidth {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredWidth;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseMnemonic {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseMnemonic;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCompatibleTextRendering {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseCompatibleTextRendering;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Cursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler BackColorChanged;
		public new event System.EventHandler BackgroundImageChanged;
		public new event System.EventHandler BackgroundImageLayoutChanged;
		public new event System.EventHandler BindingContextChanged;
		public new event System.EventHandler CausesValidationChanged;
		public new event Common.Forms.UICuesEventHandler ChangeUICues;
		public new event System.EventHandler Click;
		public new event System.EventHandler ClientSizeChanged;
		public new event System.EventHandler ContextMenuChanged;
		public new event System.EventHandler ContextMenuStripChanged;
		public new event Common.Forms.ControlEventHandler ControlAdded;
		public new event Common.Forms.ControlEventHandler ControlRemoved;
		public new event System.EventHandler CursorChanged;
		public new event System.EventHandler Disposed;
		public new event System.EventHandler DockChanged;
		public new event System.EventHandler DoubleClick;
		public new event Common.Forms.DragEventHandler DragDrop;
		public new event Common.Forms.DragEventHandler DragEnter;
		public new event System.EventHandler DragLeave;
		public new event Common.Forms.DragEventHandler DragOver;
		public new event System.EventHandler EnabledChanged;
		public new event System.EventHandler Enter;
		public new event System.EventHandler FontChanged;
		public new event System.EventHandler ForeColorChanged;
		public new event Common.Forms.GiveFeedbackEventHandler GiveFeedback;
		public new event System.EventHandler GotFocus;
		public new event System.EventHandler HandleCreated;
		public new event System.EventHandler HandleDestroyed;
		public new event Common.Forms.HelpEventHandler HelpRequested;
		public new event System.EventHandler ImeModeChanged;
		public new event Common.Forms.InvalidateEventHandler Invalidated;
		public new event Common.Forms.KeyEventHandler KeyDown;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.KeyEventHandler KeyUp;
		public new event Common.Forms.LayoutEventHandler Layout;
		public new event System.EventHandler Leave;
		public new event System.EventHandler LocationChanged;
		public new event System.EventHandler LostFocus;
		public new event System.EventHandler MarginChanged;
		public new event System.EventHandler MouseCaptureChanged;
		public new event Common.Forms.MouseEventHandler MouseClick;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler Move;
		public new event System.EventHandler PaddingChanged;
		public new event Common.Forms.PaintEventHandler Paint;
		public new event System.EventHandler ParentChanged;
		public new event Common.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		public new event Common.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		public new event Common.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		public new event System.EventHandler RegionChanged;
		public new event System.EventHandler Resize;
		public new event System.EventHandler RightToLeftChanged;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler StyleChanged;
		public new event System.EventHandler SystemColorsChanged;
		public new event System.EventHandler TabIndexChanged;
		public new event System.EventHandler TabStopChanged;
		public new event System.EventHandler TextChanged;
		public new event System.EventHandler Validated;
		public new event System.ComponentModel.CancelEventHandler Validating;
		public new event System.EventHandler VisibleChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TextAlignChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Size GetPreferredSize (System.Drawing.Size proposedSize) {return  base.GetPreferredSize(proposedSize);}
		#endregion
	}
	
	public class LayoutEngine
	{
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  LayoutEventHandler (System.Object sender , System.Windows.Forms.LayoutEventArgs e );
	
	public class LayoutSettings
	{
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class ListBindingConverter : System.Windows.Forms.ListBindingConverter
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class ListBindingHelper
	{
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class ListBox : System.Windows.Forms.ListBox
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DefaultItemHeight;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 NoMatches;
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new BorderStyle BorderStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.BorderStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ColumnWidth {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ColumnWidth;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.IntegerCollection CustomTabOffsets {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CustomTabOffsets;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DrawMode DrawMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.DrawMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 HorizontalExtent {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.HorizontalExtent;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HorizontalScrollbar {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.HorizontalScrollbar;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IntegralHeight {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IntegralHeight;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ItemHeight {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ItemHeight;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean MultiColumn {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.MultiColumn;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredHeight;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ScrollAlwaysVisible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ScrollAlwaysVisible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.SelectedIndexCollection SelectedIndices {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectedIndices;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Sorted {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Sorted;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TopIndex {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopIndex;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCustomTabOffsets {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseCustomTabOffsets;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseTabStops {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseTabStops;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IFormatProvider FormatInfo {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.FormatInfo;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String FormatString {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.FormatString;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object SelectedValue {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectedValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Cursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler BackColorChanged;
		public new event System.EventHandler BackgroundImageChanged;
		public new event System.EventHandler BackgroundImageLayoutChanged;
		public new event System.EventHandler BindingContextChanged;
		public new event System.EventHandler CausesValidationChanged;
		public new event Common.Forms.UICuesEventHandler ChangeUICues;
		public new event System.EventHandler Click;
		public new event System.EventHandler ClientSizeChanged;
		public new event System.EventHandler ContextMenuChanged;
		public new event System.EventHandler ContextMenuStripChanged;
		public new event Common.Forms.ControlEventHandler ControlAdded;
		public new event Common.Forms.ControlEventHandler ControlRemoved;
		public new event System.EventHandler CursorChanged;
		public new event System.EventHandler Disposed;
		public new event System.EventHandler DockChanged;
		public new event System.EventHandler DoubleClick;
		public new event Common.Forms.DragEventHandler DragDrop;
		public new event Common.Forms.DragEventHandler DragEnter;
		public new event System.EventHandler DragLeave;
		public new event Common.Forms.DragEventHandler DragOver;
		public new event System.EventHandler EnabledChanged;
		public new event System.EventHandler Enter;
		public new event System.EventHandler FontChanged;
		public new event System.EventHandler ForeColorChanged;
		public new event Common.Forms.GiveFeedbackEventHandler GiveFeedback;
		public new event System.EventHandler GotFocus;
		public new event System.EventHandler HandleCreated;
		public new event System.EventHandler HandleDestroyed;
		public new event Common.Forms.HelpEventHandler HelpRequested;
		public new event System.EventHandler ImeModeChanged;
		public new event Common.Forms.InvalidateEventHandler Invalidated;
		public new event Common.Forms.KeyEventHandler KeyDown;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.KeyEventHandler KeyUp;
		public new event Common.Forms.LayoutEventHandler Layout;
		public new event System.EventHandler Leave;
		public new event System.EventHandler LocationChanged;
		public new event System.EventHandler LostFocus;
		public new event System.EventHandler MarginChanged;
		public new event System.EventHandler MouseCaptureChanged;
		public new event Common.Forms.MouseEventHandler MouseClick;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler Move;
		public new event System.EventHandler PaddingChanged;
		public new event Common.Forms.PaintEventHandler Paint;
		public new event System.EventHandler ParentChanged;
		public new event Common.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		public new event Common.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		public new event Common.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		public new event System.EventHandler RegionChanged;
		public new event System.EventHandler Resize;
		public new event System.EventHandler RightToLeftChanged;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler StyleChanged;
		public new event System.EventHandler SystemColorsChanged;
		public new event System.EventHandler TabIndexChanged;
		public new event System.EventHandler TabStopChanged;
		public new event System.EventHandler TextChanged;
		public new event System.EventHandler Validated;
		public new event System.ComponentModel.CancelEventHandler Validating;
		public new event System.EventHandler VisibleChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DataSourceChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DisplayMemberChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.DrawItemEventHandler DrawItem;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.ListControlConvertEventHandler Format;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormatInfoChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormatStringChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormattingEnabledChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MeasureItemEventHandler MeasureItem;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SelectedIndexChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SelectedValueChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ValueMemberChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Int32 FindString (System.String s) {return  base.FindString(s);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Int32 FindStringExact (System.String s) {return  base.FindStringExact(s);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Int32 GetItemHeight (System.Int32 index) {return  base.GetItemHeight(index);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Rectangle GetItemRectangle (System.Int32 index) {return  base.GetItemRectangle(index);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Boolean GetSelected (System.Int32 index) {return  base.GetSelected(index);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Int32 IndexFromPoint (System.Drawing.Point p) {return  base.IndexFromPoint(p);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void ResetBackColor () { base.ResetBackColor();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void ResetForeColor () { base.ResetForeColor();}
		#endregion
	}
	
	public class MessageBox
	{
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class MouseEventArgs : System.Windows.Forms.MouseEventArgs
	{
		#region Constructors
		public MouseEventArgs (System.Windows.Forms.MouseButtons button , System.Int32 clicks , System.Int32 x , System.Int32 y , System.Int32 delta) : base (button , clicks , x , y , delta)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  MouseEventHandler (System.Object sender , System.Windows.Forms.MouseEventArgs e );
	
	public  partial class PaddingConverter : System.Windows.Forms.PaddingConverter
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class PaintEventArgs : System.Windows.Forms.PaintEventArgs
	{
		#region Constructors
		public PaintEventArgs (System.Drawing.Graphics graphics , System.Drawing.Rectangle clipRect) : base (graphics , clipRect)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  PaintEventHandler (System.Object sender , System.Windows.Forms.PaintEventArgs e );
	
	public  partial class Panel : System.Windows.Forms.Panel
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoSizeMode AutoSizeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoSizeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new BorderStyle BorderStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.BorderStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoScroll {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScrollMargin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoScrollMargin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScrollMinSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoScrollMinSize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollPosition {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoScrollPosition;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ScrollableControl.DockPaddingEdges DockPadding {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.DockPadding;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HScrollProperties HorizontalScroll {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.HorizontalScroll;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.VScrollProperties VerticalScroll {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.VerticalScroll;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Cursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler BackColorChanged;
		public new event System.EventHandler BackgroundImageChanged;
		public new event System.EventHandler BackgroundImageLayoutChanged;
		public new event System.EventHandler BindingContextChanged;
		public new event System.EventHandler CausesValidationChanged;
		public new event Common.Forms.UICuesEventHandler ChangeUICues;
		public new event System.EventHandler Click;
		public new event System.EventHandler ClientSizeChanged;
		public new event System.EventHandler ContextMenuChanged;
		public new event System.EventHandler ContextMenuStripChanged;
		public new event Common.Forms.ControlEventHandler ControlAdded;
		public new event Common.Forms.ControlEventHandler ControlRemoved;
		public new event System.EventHandler CursorChanged;
		public new event System.EventHandler Disposed;
		public new event System.EventHandler DockChanged;
		public new event System.EventHandler DoubleClick;
		public new event Common.Forms.DragEventHandler DragDrop;
		public new event Common.Forms.DragEventHandler DragEnter;
		public new event System.EventHandler DragLeave;
		public new event Common.Forms.DragEventHandler DragOver;
		public new event System.EventHandler EnabledChanged;
		public new event System.EventHandler Enter;
		public new event System.EventHandler FontChanged;
		public new event System.EventHandler ForeColorChanged;
		public new event Common.Forms.GiveFeedbackEventHandler GiveFeedback;
		public new event System.EventHandler GotFocus;
		public new event System.EventHandler HandleCreated;
		public new event System.EventHandler HandleDestroyed;
		public new event Common.Forms.HelpEventHandler HelpRequested;
		public new event System.EventHandler ImeModeChanged;
		public new event Common.Forms.InvalidateEventHandler Invalidated;
		public new event Common.Forms.KeyEventHandler KeyDown;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.KeyEventHandler KeyUp;
		public new event Common.Forms.LayoutEventHandler Layout;
		public new event System.EventHandler Leave;
		public new event System.EventHandler LocationChanged;
		public new event System.EventHandler LostFocus;
		public new event System.EventHandler MarginChanged;
		public new event System.EventHandler MouseCaptureChanged;
		public new event Common.Forms.MouseEventHandler MouseClick;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler Move;
		public new event System.EventHandler PaddingChanged;
		public new event Common.Forms.PaintEventHandler Paint;
		public new event System.EventHandler ParentChanged;
		public new event Common.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		public new event Common.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		public new event Common.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		public new event System.EventHandler RegionChanged;
		public new event System.EventHandler Resize;
		public new event System.EventHandler RightToLeftChanged;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler StyleChanged;
		public new event System.EventHandler SystemColorsChanged;
		public new event System.EventHandler TabIndexChanged;
		public new event System.EventHandler TabStopChanged;
		public new event System.EventHandler TextChanged;
		public new event System.EventHandler Validated;
		public new event System.ComponentModel.CancelEventHandler Validating;
		public new event System.EventHandler VisibleChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.ScrollEventHandler Scroll;
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class PreviewKeyDownEventArgs : System.Windows.Forms.PreviewKeyDownEventArgs
	{
		#region Constructors
		public PreviewKeyDownEventArgs (System.Windows.Forms.Keys keyData) : base (keyData)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  PreviewKeyDownEventHandler (System.Object sender , System.Windows.Forms.PreviewKeyDownEventArgs e );
	
	public  partial class PropertyManager : System.Windows.Forms.PropertyManager
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		public new event Common.Forms.BindingCompleteEventHandler BindingComplete;
		public new event System.EventHandler CurrentChanged;
		public new event System.EventHandler CurrentItemChanged;
		public new event Common.Forms.BindingManagerDataErrorEventHandler DataError;
		public new event System.EventHandler PositionChanged;
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class QueryAccessibilityHelpEventArgs : System.Windows.Forms.QueryAccessibilityHelpEventArgs
	{
		#region Constructors
		public QueryAccessibilityHelpEventArgs () : base ()
		{
		}
		
		public QueryAccessibilityHelpEventArgs (System.String helpNamespace , System.String helpString , System.String helpKeyword) : base (helpNamespace , helpString , helpKeyword)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  QueryAccessibilityHelpEventHandler (System.Object sender , System.Windows.Forms.QueryAccessibilityHelpEventArgs e );
	
	public  partial class QueryContinueDragEventArgs : System.Windows.Forms.QueryContinueDragEventArgs
	{
		#region Constructors
		public QueryContinueDragEventArgs (System.Int32 keyState , System.Boolean escapePressed , System.Windows.Forms.DragAction action) : base (keyState , escapePressed , action)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  QueryContinueDragEventHandler (System.Object sender , System.Windows.Forms.QueryContinueDragEventArgs e );
	
	public  partial class ScrollEventArgs : System.Windows.Forms.ScrollEventArgs
	{
		#region Constructors
		public ScrollEventArgs (System.Windows.Forms.ScrollEventType type , System.Int32 newValue) : base (type , newValue)
		{
		}
		
		public ScrollEventArgs (System.Windows.Forms.ScrollEventType type , System.Int32 oldValue , System.Int32 newValue) : base (type , oldValue , newValue)
		{
		}
		
		public ScrollEventArgs (System.Windows.Forms.ScrollEventType type , System.Int32 newValue , System.Windows.Forms.ScrollOrientation scroll) : base (type , newValue , scroll)
		{
		}
		
		public ScrollEventArgs (System.Windows.Forms.ScrollEventType type , System.Int32 oldValue , System.Int32 newValue , System.Windows.Forms.ScrollOrientation scroll) : base (type , oldValue , newValue , scroll)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  ScrollEventHandler (System.Object sender , System.Windows.Forms.ScrollEventArgs e );
	
	public  partial class ScrollableControl : System.Windows.Forms.ScrollableControl
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HScrollProperties HorizontalScroll {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.HorizontalScroll;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.VScrollProperties VerticalScroll {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.VerticalScroll;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Cursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler BackColorChanged;
		public new event System.EventHandler BackgroundImageChanged;
		public new event System.EventHandler BackgroundImageLayoutChanged;
		public new event System.EventHandler BindingContextChanged;
		public new event System.EventHandler CausesValidationChanged;
		public new event Common.Forms.UICuesEventHandler ChangeUICues;
		public new event System.EventHandler Click;
		public new event System.EventHandler ClientSizeChanged;
		public new event System.EventHandler ContextMenuChanged;
		public new event System.EventHandler ContextMenuStripChanged;
		public new event Common.Forms.ControlEventHandler ControlAdded;
		public new event Common.Forms.ControlEventHandler ControlRemoved;
		public new event System.EventHandler CursorChanged;
		public new event System.EventHandler Disposed;
		public new event System.EventHandler DockChanged;
		public new event System.EventHandler DoubleClick;
		public new event Common.Forms.DragEventHandler DragDrop;
		public new event Common.Forms.DragEventHandler DragEnter;
		public new event System.EventHandler DragLeave;
		public new event Common.Forms.DragEventHandler DragOver;
		public new event System.EventHandler EnabledChanged;
		public new event System.EventHandler Enter;
		public new event System.EventHandler FontChanged;
		public new event System.EventHandler ForeColorChanged;
		public new event Common.Forms.GiveFeedbackEventHandler GiveFeedback;
		public new event System.EventHandler GotFocus;
		public new event System.EventHandler HandleCreated;
		public new event System.EventHandler HandleDestroyed;
		public new event Common.Forms.HelpEventHandler HelpRequested;
		public new event System.EventHandler ImeModeChanged;
		public new event Common.Forms.InvalidateEventHandler Invalidated;
		public new event Common.Forms.KeyEventHandler KeyDown;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.KeyEventHandler KeyUp;
		public new event Common.Forms.LayoutEventHandler Layout;
		public new event System.EventHandler Leave;
		public new event System.EventHandler LocationChanged;
		public new event System.EventHandler LostFocus;
		public new event System.EventHandler MarginChanged;
		public new event System.EventHandler MouseCaptureChanged;
		public new event Common.Forms.MouseEventHandler MouseClick;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler Move;
		public new event System.EventHandler PaddingChanged;
		public new event Common.Forms.PaintEventHandler Paint;
		public new event System.EventHandler ParentChanged;
		public new event Common.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		public new event Common.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		public new event Common.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		public new event System.EventHandler RegionChanged;
		public new event System.EventHandler Resize;
		public new event System.EventHandler RightToLeftChanged;
		public new event Common.Forms.ScrollEventHandler Scroll;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler StyleChanged;
		public new event System.EventHandler SystemColorsChanged;
		public new event System.EventHandler TabIndexChanged;
		public new event System.EventHandler TabStopChanged;
		public new event System.EventHandler TextChanged;
		public new event System.EventHandler Validated;
		public new event System.ComponentModel.CancelEventHandler Validating;
		public new event System.EventHandler VisibleChanged;
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class TextBox : System.Windows.Forms.TextBox
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoCompleteStringCollection AutoCompleteCustomSource {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoCompleteCustomSource;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoCompleteMode AutoCompleteMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoCompleteMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoCompleteSource AutoCompleteSource { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoCompleteSource;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseSystemPasswordChar {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseSystemPasswordChar;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AcceptsReturn {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AcceptsReturn;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new CharacterCasing CharacterCasing { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CharacterCasing;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Char PasswordChar {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PasswordChar;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AcceptsTab {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AcceptsTab;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new BorderStyle BorderStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.BorderStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanUndo {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanUndo;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HideSelection {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.HideSelection;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MaxLength {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.MaxLength;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Modified {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Modified;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredHeight;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ReadOnly;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String SelectedText {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectedText;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectionLength {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectionLength;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectionStart {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectionStart;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShortcutsEnabled {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ShortcutsEnabled;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TextLength {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TextLength;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean WordWrap {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WordWrap;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Cursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler BackColorChanged;
		public new event System.EventHandler BackgroundImageChanged;
		public new event System.EventHandler BackgroundImageLayoutChanged;
		public new event System.EventHandler BindingContextChanged;
		public new event System.EventHandler CausesValidationChanged;
		public new event Common.Forms.UICuesEventHandler ChangeUICues;
		public new event System.EventHandler Click;
		public new event System.EventHandler ClientSizeChanged;
		public new event System.EventHandler ContextMenuChanged;
		public new event System.EventHandler ContextMenuStripChanged;
		public new event Common.Forms.ControlEventHandler ControlAdded;
		public new event Common.Forms.ControlEventHandler ControlRemoved;
		public new event System.EventHandler CursorChanged;
		public new event System.EventHandler Disposed;
		public new event System.EventHandler DockChanged;
		public new event System.EventHandler DoubleClick;
		public new event Common.Forms.DragEventHandler DragDrop;
		public new event Common.Forms.DragEventHandler DragEnter;
		public new event System.EventHandler DragLeave;
		public new event Common.Forms.DragEventHandler DragOver;
		public new event System.EventHandler EnabledChanged;
		public new event System.EventHandler Enter;
		public new event System.EventHandler FontChanged;
		public new event System.EventHandler ForeColorChanged;
		public new event Common.Forms.GiveFeedbackEventHandler GiveFeedback;
		public new event System.EventHandler GotFocus;
		public new event System.EventHandler HandleCreated;
		public new event System.EventHandler HandleDestroyed;
		public new event Common.Forms.HelpEventHandler HelpRequested;
		public new event System.EventHandler ImeModeChanged;
		public new event Common.Forms.InvalidateEventHandler Invalidated;
		public new event Common.Forms.KeyEventHandler KeyDown;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.KeyEventHandler KeyUp;
		public new event Common.Forms.LayoutEventHandler Layout;
		public new event System.EventHandler Leave;
		public new event System.EventHandler LocationChanged;
		public new event System.EventHandler LostFocus;
		public new event System.EventHandler MarginChanged;
		public new event System.EventHandler MouseCaptureChanged;
		public new event Common.Forms.MouseEventHandler MouseClick;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler Move;
		public new event System.EventHandler PaddingChanged;
		public new event Common.Forms.PaintEventHandler Paint;
		public new event System.EventHandler ParentChanged;
		public new event Common.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		public new event Common.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		public new event Common.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		public new event System.EventHandler RegionChanged;
		public new event System.EventHandler Resize;
		public new event System.EventHandler RightToLeftChanged;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler StyleChanged;
		public new event System.EventHandler SystemColorsChanged;
		public new event System.EventHandler TabIndexChanged;
		public new event System.EventHandler TabStopChanged;
		public new event System.EventHandler TextChanged;
		public new event System.EventHandler Validated;
		public new event System.ComponentModel.CancelEventHandler Validating;
		public new event System.EventHandler VisibleChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AcceptsTabChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler BorderStyleChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler HideSelectionChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ModifiedChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MultilineChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ReadOnlyChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TextAlignChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void Paste (System.String text) { base.Paste(text);}
		#endregion
	}
	
	public  partial class Timer : System.Windows.Forms.Timer
	{
		#region Constructors
		public Timer () : base ()
		{
		}
		
		public Timer (System.ComponentModel.IContainer container) : base (container)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler Disposed;
		public new event System.EventHandler Tick;
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class TrackBar : System.Windows.Forms.TrackBar
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new Orientation Orientation { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Orientation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RightToLeftLayout {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RightToLeftLayout;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new TickStyle TickStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TickStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Cursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Tag;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler BackColorChanged;
		public new event System.EventHandler BackgroundImageChanged;
		public new event System.EventHandler BackgroundImageLayoutChanged;
		public new event System.EventHandler BindingContextChanged;
		public new event System.EventHandler CausesValidationChanged;
		public new event Common.Forms.UICuesEventHandler ChangeUICues;
		public new event System.EventHandler Click;
		public new event System.EventHandler ClientSizeChanged;
		public new event System.EventHandler ContextMenuChanged;
		public new event System.EventHandler ContextMenuStripChanged;
		public new event Common.Forms.ControlEventHandler ControlAdded;
		public new event Common.Forms.ControlEventHandler ControlRemoved;
		public new event System.EventHandler CursorChanged;
		public new event System.EventHandler Disposed;
		public new event System.EventHandler DockChanged;
		public new event System.EventHandler DoubleClick;
		public new event Common.Forms.DragEventHandler DragDrop;
		public new event Common.Forms.DragEventHandler DragEnter;
		public new event System.EventHandler DragLeave;
		public new event Common.Forms.DragEventHandler DragOver;
		public new event System.EventHandler EnabledChanged;
		public new event System.EventHandler Enter;
		public new event System.EventHandler FontChanged;
		public new event System.EventHandler ForeColorChanged;
		public new event Common.Forms.GiveFeedbackEventHandler GiveFeedback;
		public new event System.EventHandler GotFocus;
		public new event System.EventHandler HandleCreated;
		public new event System.EventHandler HandleDestroyed;
		public new event Common.Forms.HelpEventHandler HelpRequested;
		public new event System.EventHandler ImeModeChanged;
		public new event Common.Forms.InvalidateEventHandler Invalidated;
		public new event Common.Forms.KeyEventHandler KeyDown;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.KeyEventHandler KeyUp;
		public new event Common.Forms.LayoutEventHandler Layout;
		public new event System.EventHandler Leave;
		public new event System.EventHandler LocationChanged;
		public new event System.EventHandler LostFocus;
		public new event System.EventHandler MarginChanged;
		public new event System.EventHandler MouseCaptureChanged;
		public new event Common.Forms.MouseEventHandler MouseClick;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler Move;
		public new event System.EventHandler PaddingChanged;
		public new event Common.Forms.PaintEventHandler Paint;
		public new event System.EventHandler ParentChanged;
		public new event Common.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		public new event Common.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		public new event Common.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		public new event System.EventHandler RegionChanged;
		public new event System.EventHandler Resize;
		public new event System.EventHandler RightToLeftChanged;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler StyleChanged;
		public new event System.EventHandler SystemColorsChanged;
		public new event System.EventHandler TabIndexChanged;
		public new event System.EventHandler TabStopChanged;
		public new event System.EventHandler TextChanged;
		public new event System.EventHandler Validated;
		public new event System.ComponentModel.CancelEventHandler Validating;
		public new event System.EventHandler VisibleChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler RightToLeftLayoutChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Scroll;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ValueChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void SetRange (System.Int32 minValue , System.Int32 maxValue) { base.SetRange(minValue , maxValue);}
		#endregion
	}
	
	public  partial class UICuesEventArgs : System.Windows.Forms.UICuesEventArgs
	{
		#region Constructors
		public UICuesEventArgs (System.Windows.Forms.UICues uicues) : base (uicues)
		{
		}
		
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public delegate void  UICuesEventHandler (System.Object sender , System.Windows.Forms.UICuesEventArgs e );
	
	public  partial class UserControl : System.Windows.Forms.UserControl
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoSize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoSizeMode AutoSizeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoSizeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoValidate AutoValidate { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoValidate;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new BorderStyle BorderStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.BorderStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control ActiveControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ActiveControl;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF AutoScaleDimensions {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoScaleDimensions;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoScaleMode AutoScaleMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoScaleMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.BindingContext;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF CurrentAutoScaleDimensions {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CurrentAutoScaleDimensions;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form ParentForm {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ParentForm;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoScroll {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScrollMargin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoScrollMargin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScrollMinSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoScrollMinSize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollPosition {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoScrollPosition;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.DisplayRectangle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ScrollableControl.DockPaddingEdges DockPadding {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.DockPadding;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HScrollProperties HorizontalScroll {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.HorizontalScroll;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.VScrollProperties VerticalScroll {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.VerticalScroll;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibilityObject;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDefaultActionDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleDescription;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AccessibleRole;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AllowDrop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AnchorStyles Anchor { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Anchor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.AutoScrollOffset;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.MaximumSize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.MinimumSize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.BackgroundImage;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImageLayout BackgroundImageLayout { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.BackgroundImageLayout;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Bottom;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanFocus;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CanSelect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Capture;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CausesValidation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ClientRectangle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ClientRectangle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size ClientSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ClientSize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CompanyName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContainsFocus;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ContextMenuStrip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Created;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.DataBindings;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Disposing;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DockStyle Dock { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Dock;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Focused {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Focused;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ForeColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.HasChildren;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Height {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Height;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ImeMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.InvokeRequired;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsAccessible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsDisposed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsHandleCreated;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.IsMirrored;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.LayoutEngine;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Left;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point Location {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Location;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Margin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Name {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Name;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Padding;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Parent;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.PreferredSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductName;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ProductVersion;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RecreatingHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Region;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Right;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new RightToLeft RightToLeft { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.RightToLeft;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size Size {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Size;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TabIndex {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TabIndex;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TabStop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Top;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.TopLevelControl;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.UseWaitCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Visible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Width {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Width;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.WindowTarget;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Container;}}
		#endregion
		#endregion
		#region Events
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AutoSizeChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AutoValidateChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler BackColorChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler BackgroundImageChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler BackgroundImageLayoutChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler BindingContextChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler CausesValidationChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.UICuesEventHandler ChangeUICues;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Click;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ClientSizeChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ContextMenuChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ContextMenuStripChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.ControlEventHandler ControlAdded;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.ControlEventHandler ControlRemoved;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler CursorChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Disposed;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DockChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DoubleClick;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.DragEventHandler DragDrop;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.DragEventHandler DragEnter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DragLeave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.DragEventHandler DragOver;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler EnabledChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Enter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FontChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ForeColorChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler GotFocus;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler HandleCreated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler HandleDestroyed;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.HelpEventHandler HelpRequested;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ImeModeChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.InvalidateEventHandler Invalidated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.KeyEventHandler KeyDown;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.KeyPressEventHandler KeyPress;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.KeyEventHandler KeyUp;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.LayoutEventHandler Layout;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Leave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Load;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler LocationChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler LostFocus;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MarginChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseCaptureChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseClick;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Move;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler PaddingChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.PaintEventHandler Paint;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ParentChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler RegionChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Resize;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler RightToLeftChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.ScrollEventHandler Scroll;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SizeChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler StyleChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SystemColorsChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TabIndexChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TabStopChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TextChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Validated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.ComponentModel.CancelEventHandler Validating;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler VisibleChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Boolean ValidateChildren () {return  base.ValidateChildren();}
		#endregion
	}
	
	public class ArrangedElementCollection
	{
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	#region Enums
	#endregion
}

