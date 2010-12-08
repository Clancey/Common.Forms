using System;
using System.Windows.Forms;
using System.Drawing;

namespace Common.Forms
{
	public partial class Button : System.Windows.Forms.Button,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.Windows.Forms.IBindableComponent,System.ComponentModel.ISynchronizeInvoke,System.Windows.Forms.IDropTarget,System.Windows.Forms.IButtonControl
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
		public new AutoSizeMode AutoSizeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoEllipsis {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatButtonAppearance FlatAppearance {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ContentAlignment ImageAlign{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ImageIndex {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ImageKey {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageList ImageList {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ContentAlignment TextAlign{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new TextImageRelation TextImageRelation{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCompatibleTextRendering {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseMnemonic {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AnchorStyles Anchor{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImageLayout BackgroundImageLayout{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DockStyle Dock{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new RightToLeft RightToLeft{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler Click;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event System.EventHandler SizeChanged;
		#region Excluded
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
		public new event System.EventHandler MouseEnter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseHover;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseLeave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseWheel;
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
		public   override Void NotifyDefault (System.Boolean value) { base.NotifyDefault(value);}
		#endregion
	}
	
	public partial class CheckBox : System.Windows.Forms.CheckBox,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.Windows.Forms.IBindableComponent,System.ComponentModel.ISynchronizeInvoke,System.Windows.Forms.IDropTarget
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
		public new Appearance Appearance{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoCheck {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ContentAlignment CheckAlign{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ContentAlignment TextAlign{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoEllipsis {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatButtonAppearance FlatAppearance {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ContentAlignment ImageAlign{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ImageIndex {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ImageKey {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageList ImageList {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new TextImageRelation TextImageRelation{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCompatibleTextRendering {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseMnemonic {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AnchorStyles Anchor{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImageLayout BackgroundImageLayout{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DockStyle Dock{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new RightToLeft RightToLeft{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler Click;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event System.EventHandler SizeChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AppearanceChanged;
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
		public new event System.EventHandler CheckedChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler CheckStateChanged;
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
		public new event System.EventHandler MouseEnter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseHover;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseLeave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseWheel;
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
		#endregion
	}
	
	public partial class CheckedListBox : System.Windows.Forms.CheckedListBox,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.Windows.Forms.IBindableComponent,System.ComponentModel.ISynchronizeInvoke,System.Windows.Forms.IDropTarget
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
		public new System.Windows.Forms.CheckedListBox.CheckedIndexCollection CheckedIndices {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.CheckedListBox.CheckedItemCollection CheckedItems {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CheckOnClick {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DrawMode DrawMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ItemHeight {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ThreeDCheckBoxes {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCompatibleTextRendering {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImageLayout BackgroundImageLayout{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ColumnWidth {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.IntegerCollection CustomTabOffsets {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Font Font {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 HorizontalExtent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HorizontalScrollbar {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IntegralHeight {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean MultiColumn {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new RightToLeft RightToLeft{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ScrollAlwaysVisible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.SelectedIndexCollection SelectedIndices {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Sorted {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Text {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TopIndex {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCustomTabOffsets {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseTabStops {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IFormatProvider FormatInfo {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String FormatString {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object SelectedValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AnchorStyles Anchor{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DockStyle Dock{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Enabled {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event System.EventHandler SizeChanged;
		#region Excluded
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
		public new event System.EventHandler DataSourceChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DisplayMemberChanged;
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
		public new event System.Windows.Forms.DrawItemEventHandler DrawItem;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler EnabledChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Enter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FontChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ForeColorChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.ListControlConvertEventHandler Format;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormatInfoChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormatStringChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormattingEnabledChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback;
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
		public new event System.Windows.Forms.ItemCheckEventHandler ItemCheck;
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
		public new event System.EventHandler LocationChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler LostFocus;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MarginChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MeasureItemEventHandler MeasureItem;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseCaptureChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseClick;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseEnter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseHover;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseLeave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseWheel;
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
		public new event System.EventHandler SelectedIndexChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SelectedValueChanged;
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
		public new event System.EventHandler ValueMemberChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler VisibleChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Boolean GetItemChecked (System.Int32 index) {return  base.GetItemChecked(index);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new System.Windows.Forms.CheckState GetItemCheckState (System.Int32 index) {return  base.GetItemCheckState(index);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void SetItemChecked (System.Int32 index , System.Boolean value) { base.SetItemChecked(index , value);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void SetItemCheckState (System.Int32 index , System.Windows.Forms.CheckState value) { base.SetItemCheckState(index , value);}
		#endregion
	}
	
	public partial class ComboBox : System.Windows.Forms.ComboBox,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.Windows.Forms.IBindableComponent,System.ComponentModel.ISynchronizeInvoke,System.Windows.Forms.IDropTarget
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
		public new System.Windows.Forms.AutoCompleteStringCollection AutoCompleteCustomSource {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoCompleteMode AutoCompleteMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoCompleteSource AutoCompleteSource{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImageLayout BackgroundImageLayout{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DrawMode DrawMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DropDownHeight {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DropDownWidth {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean DroppedDown {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IntegralHeight {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MaxDropDownItems {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MaxLength {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String SelectedText {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectionLength {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectionStart {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Sorted {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IFormatProvider FormatInfo {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String FormatString {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AnchorStyles Anchor{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DockStyle Dock{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new RightToLeft RightToLeft{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler TextChanged;
		#region Excluded
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
		public new event System.EventHandler DataSourceChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DisplayMemberChanged;
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
		public new event System.Windows.Forms.DrawItemEventHandler DrawItem;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DropDown;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DropDownClosed;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DropDownStyleChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler EnabledChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Enter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FontChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ForeColorChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.ListControlConvertEventHandler Format;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormatInfoChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormatStringChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormattingEnabledChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback;
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
		public new event System.Windows.Forms.KeyEventHandler KeyUp;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.LayoutEventHandler Layout;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Leave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler LocationChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler LostFocus;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MarginChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MeasureItemEventHandler MeasureItem;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseCaptureChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseClick;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseEnter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseHover;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseLeave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseWheel;
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
		public new event System.EventHandler SelectedIndexChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SelectedValueChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SelectionChangeCommitted;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler StyleChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SystemColorsChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TabIndexChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TabStopChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TextUpdate;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Validated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.ComponentModel.CancelEventHandler Validating;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ValueMemberChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler VisibleChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void BeginUpdate () { base.BeginUpdate();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void EndUpdate () { base.EndUpdate();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Int32 FindString (System.String s) {return  base.FindString(s);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Int32 FindStringExact (System.String s) {return  base.FindStringExact(s);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Int32 GetItemHeight (System.Int32 index) {return  base.GetItemHeight(index);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Void ResetText () { base.ResetText();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void SelectAll () { base.SelectAll();}
		#endregion
	}
	
	public partial class Control : System.Windows.Forms.Control,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.Windows.Forms.IBindableComponent,System.ComponentModel.ISynchronizeInvoke,System.Windows.Forms.IDropTarget
	{
		#region Constructors
		public Control () : base ()
		{
		}
		
		[Obsolete("This method is not cross-platform compatible.", true)]
		public Control (System.Windows.Forms.Control parent , System.String text) : base (parent , text)
		{
		}
		
		[Obsolete("This method is not cross-platform compatible.", true)]
		public Control (System.Windows.Forms.Control parent , System.String text , System.Int32 left , System.Int32 top , System.Int32 width , System.Int32 height) : base (parent , text , left , top , width , height)
		{
		}
		
		[Obsolete("This method is not cross-platform compatible.", true)]
		public Control (System.String text) : base (text)
		{
		}
		
		[Obsolete("This method is not cross-platform compatible.", true)]
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
		public new System.Drawing.Color DefaultBackColor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Font DefaultFont {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color DefaultForeColor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new Keys ModifierKeys{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MouseButtons MouseButtons{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point MousePosition {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CheckForIllegalCrossThreadCalls {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AnchorStyles Anchor{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImageLayout BackgroundImageLayout{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ClientRectangle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size ClientSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DockStyle Dock{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Enabled {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Focused {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Font Font {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Height {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Name {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new RightToLeft RightToLeft{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TabIndex {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Text {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Width {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AutoSizeChanged;
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
		public new event System.Windows.Forms.MouseEventHandler MouseDoubleClick;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseDown;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseEnter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseHover;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseLeave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseMove;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseUp;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseWheel;
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
		public   new Void DrawToBitmap (System.Drawing.Bitmap bitmap , System.Drawing.Rectangle targetBounds) { base.DrawToBitmap(bitmap , targetBounds);}
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
		public   new Void BringToFront () { base.BringToFront();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Boolean Contains (System.Windows.Forms.Control ctl) {return  base.Contains(ctl);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void CreateControl () { base.CreateControl();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Graphics CreateGraphics () {return  base.CreateGraphics();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new System.Windows.Forms.DragDropEffects DoDragDrop (System.Object data , System.Windows.Forms.DragDropEffects allowedEffects) {return  base.DoDragDrop(data , allowedEffects);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new System.Windows.Forms.Form FindForm () {return  base.FindForm();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Boolean Focus () {return  base.Focus();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new System.Windows.Forms.Control GetChildAtPoint (System.Drawing.Point pt) {return  base.GetChildAtPoint(pt);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new System.Windows.Forms.IContainerControl GetContainerControl () {return  base.GetContainerControl();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new System.Windows.Forms.Control GetNextControl (System.Windows.Forms.Control ctl , System.Boolean forward) {return  base.GetNextControl(ctl , forward);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Size GetPreferredSize (System.Drawing.Size proposedSize) {return  base.GetPreferredSize(proposedSize);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void Hide () { base.Hide();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void Invalidate () { base.Invalidate();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Object Invoke (System.Delegate method) {return  base.Invoke(method);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void PerformLayout () { base.PerformLayout();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Point PointToClient (System.Drawing.Point p) {return  base.PointToClient(p);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Point PointToScreen (System.Drawing.Point p) {return  base.PointToScreen(p);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Rectangle RectangleToClient (System.Drawing.Rectangle r) {return  base.RectangleToClient(r);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Rectangle RectangleToScreen (System.Drawing.Rectangle r) {return  base.RectangleToScreen(r);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Void Refresh () { base.Refresh();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Void ResetBackColor () { base.ResetBackColor();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void ResetBindings () { base.ResetBindings();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Void ResetCursor () { base.ResetCursor();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Void ResetFont () { base.ResetFont();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Void ResetForeColor () { base.ResetForeColor();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void ResetImeMode () { base.ResetImeMode();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Void ResetRightToLeft () { base.ResetRightToLeft();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Void ResetText () { base.ResetText();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void ResumeLayout () { base.ResumeLayout();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void Scale (System.Single ratio) { base.Scale(ratio);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void Select () { base.Select();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Boolean SelectNextControl (System.Windows.Forms.Control ctl , System.Boolean forward , System.Boolean tabStopOnly , System.Boolean nested , System.Boolean wrap) {return  base.SelectNextControl(ctl , forward , tabStopOnly , nested , wrap);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void SendToBack () { base.SendToBack();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void SetBounds (System.Int32 x , System.Int32 y , System.Int32 width , System.Int32 height) { base.SetBounds(x , y , width , height);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void Show () { base.Show();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void SuspendLayout () { base.SuspendLayout();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void Update () { base.Update();}
		#endregion
	}
	
	public partial class DataGridViewButtonCell : System.Windows.Forms.DataGridViewButtonCell,System.IDisposable,System.ICloneable
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
		public new System.Type EditType {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type FormattedValueType {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseColumnTextForButtonValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type ValueType {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ColumnIndex {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ContentBounds {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object DefaultNewRowValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Displayed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object EditedFormattedValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ErrorIconBounds {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ErrorText {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object FormattedValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Frozen {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasStyle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewElementStates InheritedState{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle InheritedStyle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsInEditMode {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewColumn OwningColumn {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewRow OwningRow {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Resizable {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 RowIndex {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selected {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size Size {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle Style {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ToolTipText {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Value {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridView DataGridView {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
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
	
	public partial class DataGridViewButtonColumn : System.Windows.Forms.DataGridViewButtonColumn,System.IDisposable,System.ICloneable,System.ComponentModel.IComponent
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
		public new System.Windows.Forms.DataGridViewCell CellTemplate {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle DefaultCellStyle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Text {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseColumnTextForButtonValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewAutoSizeColumnMode AutoSizeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type CellType {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String DataPropertyName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DisplayIndex {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DividerWidth {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single FillWeight {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Frozen {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String HeaderText {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewAutoSizeColumnMode InheritedAutoSizeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle InheritedStyle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDataBound {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MinimumWidth {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Name {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewTriState Resizable{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewColumnSortMode SortMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ToolTipText {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type ValueType {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type DefaultHeaderCellType {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Displayed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasDefaultCellStyle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Index {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selected {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridView DataGridView {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewElementStates State{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
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
	
	public partial class DataGridViewCheckBoxCell : System.Windows.Forms.DataGridViewCheckBoxCell,System.Windows.Forms.IDataGridViewEditingCell,System.IDisposable,System.ICloneable
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
		public new System.Object EditingCellFormattedValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean EditingCellValueChanged {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type EditType {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object FalseValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type FormattedValueType {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object IndeterminateValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ThreeState {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object TrueValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type ValueType {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ColumnIndex {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ContentBounds {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object DefaultNewRowValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Displayed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object EditedFormattedValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ErrorIconBounds {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ErrorText {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object FormattedValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Frozen {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasStyle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewElementStates InheritedState{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle InheritedStyle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsInEditMode {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewColumn OwningColumn {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewRow OwningRow {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Resizable {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 RowIndex {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selected {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size Size {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle Style {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ToolTipText {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Value {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridView DataGridView {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
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
		public   override Void PrepareEditingCellForEdit (System.Boolean selectAll) { base.PrepareEditingCellForEdit(selectAll);}
		#endregion
	}
	
	public partial class DataGridViewCheckBoxColumn : System.Windows.Forms.DataGridViewCheckBoxColumn,System.IDisposable,System.ICloneable,System.ComponentModel.IComponent
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
		public new System.Windows.Forms.DataGridViewCell CellTemplate {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle DefaultCellStyle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object FalseValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object IndeterminateValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ThreeState {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object TrueValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewAutoSizeColumnMode AutoSizeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type CellType {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String DataPropertyName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DisplayIndex {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DividerWidth {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single FillWeight {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Frozen {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String HeaderText {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewAutoSizeColumnMode InheritedAutoSizeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle InheritedStyle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDataBound {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MinimumWidth {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Name {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewTriState Resizable{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewColumnSortMode SortMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ToolTipText {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type ValueType {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type DefaultHeaderCellType {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Displayed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasDefaultCellStyle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Index {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selected {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridView DataGridView {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DataGridViewElementStates State{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
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
	
	public partial class Form : System.Windows.Forms.Form,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.Windows.Forms.IBindableComponent,System.ComponentModel.ISynchronizeInvoke,System.Windows.Forms.IContainerControl,System.Windows.Forms.IDropTarget
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
		public new System.Windows.Forms.Form ActiveForm {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowTransparency {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoScale {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScaleBaseSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoScroll {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoSizeMode AutoSizeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoValidate AutoValidate{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ControlBox {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DesktopBounds {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point DesktopLocation {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FormBorderStyle FormBorderStyle{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HelpButton {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMdiChild {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMdiContainer {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form ActiveMdiChild {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsRestrictedWindow {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean KeyPreview {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MenuStrip MainMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form[] MdiChildren {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form MdiParent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MainMenu MergedMenu {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Double Opacity {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form[] OwnedForms {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form Owner {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle RestoreBounds {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RightToLeftLayout {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowIcon {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowInTaskbar {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new SizeGripStyle SizeGripStyle{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FormStartPosition StartPosition{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TabIndex {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TopLevel {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TopMost {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color TransparencyKey {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FormWindowState WindowState{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control ActiveControl {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF CurrentAutoScaleDimensions {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form ParentForm {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScrollMargin {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScrollMinSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollPosition {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ScrollableControl.DockPaddingEdges DockPadding {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HScrollProperties HorizontalScroll {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.VScrollProperties VerticalScroll {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AnchorStyles Anchor{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImageLayout BackgroundImageLayout{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle Bounds {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DockStyle Dock{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Enabled {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Focused {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Font Font {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new RightToLeft RightToLeft{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler AutoValidateChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event System.EventHandler SizeChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Activated;
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
		public new event System.EventHandler Closed;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.ComponentModel.CancelEventHandler Closing;
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
		public new event System.EventHandler Deactivate;
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
		public new event System.Windows.Forms.FormClosedEventHandler FormClosed;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.FormClosingEventHandler FormClosing;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler HandleCreated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler HandleDestroyed;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.ComponentModel.CancelEventHandler HelpButtonClicked;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.HelpEventHandler HelpRequested;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ImeModeChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.InputLanguageChangedEventHandler InputLanguageChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.InputLanguageChangingEventHandler InputLanguageChanging;
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
		public new event System.EventHandler MouseCaptureChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseClick;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseEnter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseHover;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseLeave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseWheel;
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
		public new event System.EventHandler ResizeBegin;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ResizeEnd;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler RightToLeftChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler RightToLeftLayoutChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.ScrollEventHandler Scroll;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Shown;
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
		public static  new SizeF GetAutoScaleSize (System.Drawing.Font font) {return System.Windows.Forms.Form.GetAutoScaleSize(font);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void Activate () { base.Activate();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void AddOwnedForm (System.Windows.Forms.Form ownedForm) { base.AddOwnedForm(ownedForm);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void LayoutMdi (System.Windows.Forms.MdiLayout value) { base.LayoutMdi(value);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void RemoveOwnedForm (System.Windows.Forms.Form ownedForm) { base.RemoveOwnedForm(ownedForm);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void SetDesktopBounds (System.Int32 x , System.Int32 y , System.Int32 width , System.Int32 height) { base.SetDesktopBounds(x , y , width , height);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void SetDesktopLocation (System.Int32 x , System.Int32 y) { base.SetDesktopLocation(x , y);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Boolean ValidateChildren () {return  base.ValidateChildren();}
		#endregion
	}
	
	public partial class KeyEventArgs : System.Windows.Forms.KeyEventArgs
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
	
	public delegate void  KeyEventHandler (System.Object sender , Common.Forms.KeyEventArgs e );
	
	public partial class KeyPressEventArgs : System.Windows.Forms.KeyPressEventArgs
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
	
	public delegate void  KeyPressEventHandler (System.Object sender , Common.Forms.KeyPressEventArgs e );
	
	public partial class Label : System.Windows.Forms.Label,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.Windows.Forms.IBindableComponent,System.ComponentModel.ISynchronizeInvoke,System.Windows.Forms.IDropTarget
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
		public new System.Boolean AutoEllipsis {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImageLayout BackgroundImageLayout{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new FlatStyle FlatStyle{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image Image {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ContentAlignment ImageAlign{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ImageIndex {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ImageKey {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageList ImageList {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredWidth {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseMnemonic {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCompatibleTextRendering {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DockStyle Dock{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler TextChanged;
		#region Excluded
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
		public new event System.Windows.Forms.KeyEventHandler KeyUp;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.LayoutEventHandler Layout;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Leave;
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
		public new event System.EventHandler MouseEnter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseHover;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseLeave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseWheel;
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
		public new event System.EventHandler StyleChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SystemColorsChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TabIndexChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TabStopChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TextAlignChanged;
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
		public   override Size GetPreferredSize (System.Drawing.Size proposedSize) {return  base.GetPreferredSize(proposedSize);}
		#endregion
	}
	
	public partial class ListBox : System.Windows.Forms.ListBox,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.Windows.Forms.IBindableComponent,System.ComponentModel.ISynchronizeInvoke,System.Windows.Forms.IDropTarget
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
		public new System.Drawing.Image BackgroundImage {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImageLayout BackgroundImageLayout{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ColumnWidth {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.IntegerCollection CustomTabOffsets {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DrawMode DrawMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Font Font {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 HorizontalExtent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HorizontalScrollbar {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IntegralHeight {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ItemHeight {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean MultiColumn {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new RightToLeft RightToLeft{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ScrollAlwaysVisible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.SelectedIndexCollection SelectedIndices {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Sorted {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Text {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TopIndex {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCustomTabOffsets {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseTabStops {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IFormatProvider FormatInfo {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String FormatString {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object SelectedValue {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AnchorStyles Anchor{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DockStyle Dock{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Enabled {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event System.EventHandler SizeChanged;
		#region Excluded
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
		public new event System.EventHandler DataSourceChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DisplayMemberChanged;
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
		public new event System.Windows.Forms.DrawItemEventHandler DrawItem;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler EnabledChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Enter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FontChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ForeColorChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.ListControlConvertEventHandler Format;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormatInfoChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormatStringChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler FormattingEnabledChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback;
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
		public new event System.EventHandler LocationChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler LostFocus;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MarginChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MeasureItemEventHandler MeasureItem;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseCaptureChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseClick;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseEnter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseHover;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseLeave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseWheel;
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
		public new event System.EventHandler SelectedIndexChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SelectedValueChanged;
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
		public new event System.EventHandler ValueMemberChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler VisibleChanged;
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
		public   override Void ResetBackColor () { base.ResetBackColor();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Void ResetForeColor () { base.ResetForeColor();}
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
	
	public partial class MouseEventArgs : System.Windows.Forms.MouseEventArgs
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
	
	public delegate void  MouseEventHandler (System.Object sender , Common.Forms.MouseEventArgs e );
	
	public partial class PaintEventArgs : System.Windows.Forms.PaintEventArgs,System.IDisposable
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
	
	public delegate void  PaintEventHandler (System.Object sender , Common.Forms.PaintEventArgs e );
	
	public partial class TextBox : System.Windows.Forms.TextBox,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.Windows.Forms.IBindableComponent,System.ComponentModel.ISynchronizeInvoke,System.Windows.Forms.IDropTarget
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
		public new System.Windows.Forms.AutoCompleteStringCollection AutoCompleteCustomSource {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoCompleteMode AutoCompleteMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoCompleteSource AutoCompleteSource{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseSystemPasswordChar {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AcceptsReturn {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new CharacterCasing CharacterCasing{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Char PasswordChar {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ScrollBars ScrollBars{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AcceptsTab {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanUndo {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HideSelection {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MaxLength {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Modified {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String SelectedText {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectionLength {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectionStart {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShortcutsEnabled {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TextLength {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean WordWrap {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImageLayout BackgroundImageLayout{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DockStyle Dock{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler TextChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AcceptsTabChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler BackColorChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler BackgroundImageChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler BackgroundImageLayoutChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler BindingContextChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler BorderStyleChanged;
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
		public new event System.EventHandler HandleCreated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler HandleDestroyed;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.HelpEventHandler HelpRequested;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler HideSelectionChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ImeModeChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.InvalidateEventHandler Invalidated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.KeyEventHandler KeyDown;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.KeyEventHandler KeyUp;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.LayoutEventHandler Layout;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Leave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler LocationChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler LostFocus;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MarginChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler ModifiedChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseCaptureChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseClick;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseEnter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseHover;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseLeave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseWheel;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Move;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MultilineChanged;
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
		public new event System.EventHandler ReadOnlyChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler RegionChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Resize;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler RightToLeftChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler StyleChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler SystemColorsChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TabIndexChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TabStopChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler TextAlignChanged;
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
		public   new Void Paste (System.String text) { base.Paste(text);}
		#endregion
	}
	
	public partial class TrackBar : System.Windows.Forms.TrackBar,System.ComponentModel.ISupportInitialize,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.Windows.Forms.IBindableComponent,System.ComponentModel.ISynchronizeInvoke,System.Windows.Forms.IDropTarget
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
		public new System.Boolean AutoSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImageLayout BackgroundImageLayout{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new Orientation Orientation{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RightToLeftLayout {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Text {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new TickStyle TickStyle{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AnchorStyles Anchor{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DockStyle Dock{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new RightToLeft RightToLeft{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event System.EventHandler SizeChanged;
		#region Excluded
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
		public new event System.EventHandler MouseEnter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseHover;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseLeave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseWheel;
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
		public new event System.EventHandler RightToLeftLayoutChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Scroll;
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
		public new event System.EventHandler ValueChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler VisibleChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new Void SetRange (System.Int32 minValue , System.Int32 maxValue) { base.SetRange(minValue , maxValue);}
		#endregion
	}
	
	public partial class UserControl : System.Windows.Forms.UserControl,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.Windows.Forms.IBindableComponent,System.ComponentModel.ISynchronizeInvoke,System.Windows.Forms.IContainerControl,System.Windows.Forms.IDropTarget
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
		public new System.Boolean AutoSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoSizeMode AutoSizeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoValidate AutoValidate{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control ActiveControl {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF AutoScaleDimensions {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF CurrentAutoScaleDimensions {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form ParentForm {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoScroll {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScrollMargin {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScrollMinSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollPosition {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ScrollableControl.DockPaddingEdges DockPadding {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HScrollProperties HorizontalScroll {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.VScrollProperties VerticalScroll {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AccessibleRole AccessibleRole{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AnchorStyles Anchor{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImageLayout BackgroundImageLayout{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new DockStyle Dock{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ImeMode ImeMode{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new RightToLeft RightToLeft{get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get{throw new NotImplementedException();}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler AutoValidateChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event System.EventHandler SizeChanged;
		#region Excluded
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
		public new event System.EventHandler MouseEnter;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseHover;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler MouseLeave;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.MouseEventHandler MouseWheel;
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
	
	#region Interfaces
	public interface IUIService : System.Windows.Forms.Design.IUIService
	{
	}
	
	public interface IWindowsFormsEditorService : System.Windows.Forms.Design.IWindowsFormsEditorService
	{
	}
	
	public interface ICom2PropertyPageDisplayService : System.Windows.Forms.ComponentModel.Com2Interop.ICom2PropertyPageDisplayService
	{
	}
	
	public interface IComPropertyBrowser : System.Windows.Forms.ComponentModel.Com2Interop.IComPropertyBrowser
	{
	}
	
	public interface IButtonControl : System.Windows.Forms.IButtonControl
	{
	}
	
	public interface IBindableComponent : System.Windows.Forms.IBindableComponent
	{
	}
	
	public interface ICommandExecutor : System.Windows.Forms.ICommandExecutor
	{
	}
	
	public interface IComponentEditorPageSite : System.Windows.Forms.IComponentEditorPageSite
	{
	}
	
	public interface IContainerControl : System.Windows.Forms.IContainerControl
	{
	}
	
	public interface ICurrencyManagerProvider : System.Windows.Forms.ICurrencyManagerProvider
	{
	}
	
	public interface IDataGridColumnStyleEditingNotificationService : System.Windows.Forms.IDataGridColumnStyleEditingNotificationService
	{
	}
	
	public interface IDataGridEditingService : System.Windows.Forms.IDataGridEditingService
	{
	}
	
	public interface IDataGridViewEditingCell : System.Windows.Forms.IDataGridViewEditingCell
	{
	}
	
	public interface IDataGridViewEditingControl : System.Windows.Forms.IDataGridViewEditingControl
	{
	}
	
	public interface IDataObject : System.Windows.Forms.IDataObject
	{
	}
	
	public interface IDropTarget : System.Windows.Forms.IDropTarget
	{
	}
	
	public interface IFeatureSupport : System.Windows.Forms.IFeatureSupport
	{
	}
	
	public interface IFileReaderService : System.Windows.Forms.IFileReaderService
	{
	}
	
	public interface IMessageFilter : System.Windows.Forms.IMessageFilter
	{
	}
	
	public interface IRootGridEntry : System.Windows.Forms.PropertyGridInternal.IRootGridEntry
	{
	}
	
	public interface IWin32Window : System.Windows.Forms.IWin32Window
	{
	}
	
	public interface IWindowTarget : System.Windows.Forms.IWindowTarget
	{
	}
	
	#endregion
	#region Enums
	#endregion
}

