using System;
using System.Windows.Forms;
using System.Drawing;
using MonoMac.AppKit;

namespace Common.Forms
{
	public  partial class KeyEventArgs : System.Windows.Forms.KeyEventArgs
	{
		#region Constructors
		[Obsolete("This method is not cross-platform compatible.", true)]
		public KeyEventArgs (MonoMac.AppKit.NSEvent theEvent) : base (theEvent)
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
		public   new void ViewDidMoveToSuperview () { base.ViewDidMoveToSuperview();}
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
		public new System.EventHandler SelectedIndexChanged {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectedIndexChanged;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SelectedValueChanged {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectedValueChanged;}set{throw new NotImplementedException();}}
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
		#endregion
	}
	
	public  partial class UserControl : System.Windows.Forms.UserControl
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean shouldDraw;
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint {get{  return  base.Paint;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsFlipped {get{  return  base.IsFlipped;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Host {get{  return  base.Host;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSCell SelectedCell {get{  return  base.SelectedCell;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectedTag {get{  return  base.SelectedTag;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSText CurrentEditor {get{  return  base.CurrentEditor;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSCell Cell {get{  return  base.Cell;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject Target {get{  return  base.Target;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.ObjCRuntime.Selector Action {get{  return  base.Action;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IgnoresMultiClick {get{  return  base.IgnoresMultiClick;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Continuous {get{  return  base.Continuous;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.UInt32 Alignment {get{  return  base.Alignment;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject Formatter {get{  return  base.Formatter;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject ObjectValue {get{  return  base.ObjectValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String StringValue {get{  return  base.StringValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 IntValue {get{  return  base.IntValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single FloatValue {get{  return  base.FloatValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Double DoubleValue {get{  return  base.DoubleValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSWritingDirection BaseWritingDirection { get{  return  base.BaseWritingDirection;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 IntegerValue {get{  return  base.IntegerValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RefusesFirstResponder {get{  return  base.RefusesFirstResponder;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSWindow Window {get{  return  base.Window;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSView Superview {get{  return  base.Superview;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSView OpaqueAncestor {get{  return  base.OpaqueAncestor;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHiddenOrHasHiddenAncestor {get{  return  base.IsHiddenOrHasHiddenAncestor;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean WantsDefaultClipping {get{  return  base.WantsDefaultClipping;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsRotatedFromBase {get{  return  base.IsRotatedFromBase;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsRotatedOrScaledFromBase {get{  return  base.IsRotatedOrScaledFromBase;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsOpaque {get{  return  base.IsOpaque;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean NeedsPanelToBecomeKey {get{  return  base.NeedsPanelToBecomeKey;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean MouseDownCanMoveWindow {get{  return  base.MouseDownCanMoveWindow;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShouldDrawColor {get{  return  base.ShouldDrawColor;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSScrollView EnclosingScrollView {get{  return  base.EnclosingScrollView;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InLiveResize {get{  return  base.InLiveResize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean PreservesContentDuringLiveResize {get{  return  base.PreservesContentDuringLiveResize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.RectangleF RectPreservedDuringLiveResize {get{  return  base.RectPreservedDuringLiveResize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSTextInputContext InputContext {get{  return  base.InputContext;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Hidden {get{  return  base.Hidden;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSView[] Subviews {get{  return  base.Subviews;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean PostsFrameChangedNotifications {get{  return  base.PostsFrameChangedNotifications;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoresizesSubviews {get{  return  base.AutoresizesSubviews;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSViewResizingMask AutoresizingMask { get{  return  base.AutoresizingMask;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.RectangleF Frame {get{  return  base.Frame;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single FrameRotation {get{  return  base.FrameRotation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single FrameCenterRotation {get{  return  base.FrameCenterRotation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single BoundsRotation {get{  return  base.BoundsRotation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanDrawConcurrently {get{  return  base.CanDrawConcurrently;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean NeedsDisplay {get{  return  base.NeedsDisplay;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AcceptsTouchEvents {get{  return  base.AcceptsTouchEvents;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean WantsRestingTouches {get{  return  base.WantsRestingTouches;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSViewLayerContentsRedrawPolicy LayerContentsRedrawPolicy { get{  return  base.LayerContentsRedrawPolicy;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSViewLayerContentsPlacement LayerContentsPlacement { get{  return  base.LayerContentsPlacement;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean WantsLayer {get{  return  base.WantsLayer;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.CoreAnimation.CALayer Layer {get{  return  base.Layer;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single AlphaValue {get{  return  base.AlphaValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSShadow Shadow {get{  return  base.Shadow;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean PostsBoundsChangedNotifications {get{  return  base.PostsBoundsChangedNotifications;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ToolTip {get{  return  base.ToolTip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsInFullscreenMode {get{  return  base.IsInFullscreenMode;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject Animator {get{  return  base.Animator;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSDictionary Animations {get{  return  base.Animations;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSResponder NextResponder {get{  return  base.NextResponder;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSMenu Menu {get{  return  base.Menu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr SuperHandle {get{  return  base.SuperHandle;}}
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
		public new event System.EventHandler Activated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler viewDidMoveToSuperview;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void DrawRect (System.Drawing.RectangleF dirtyRect) { base.DrawRect(dirtyRect);}
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
		public new System.EventHandler Scroll {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Scroll;}set{throw new NotImplementedException();}}
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
		#endregion
	}
	
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
		#endregion
	}
	
	public delegate void  UICuesEventHandler (System.Object sender , System.Windows.Forms.UICuesEventArgs e );
	
	public delegate void  ControlEventHandler (System.Object sender , System.Windows.Forms.ControlEventArgs e );
	
	public delegate void  DragEventHandler (System.Object sender , System.Windows.Forms.DragEventArgs e );
	
	public delegate void  GiveFeedbackEventHandler (System.Object sender , System.Windows.Forms.GiveFeedbackEventArgs e );
	
	public delegate void  InvalidateEventHandler (System.Object sender , System.Windows.Forms.InvalidateEventArgs e );
	
	public delegate void  LayoutEventHandler (System.Object sender , System.Windows.Forms.LayoutEventArgs e );
	
	public delegate void  PreviewKeyDownEventHandler (System.Object sender , System.Windows.Forms.PreviewKeyDownEventArgs e );
	
	public delegate void  QueryAccessibilityHelpEventHandler (System.Object sender , System.Windows.Forms.QueryAccessibilityHelpEventArgs e );
	
	public delegate void  HelpEventHandler (System.Object sender , System.Windows.Forms.HelpEventArgs e );
	
	public delegate void  QueryContinueDragEventHandler (System.Object sender , System.Windows.Forms.QueryContinueDragEventArgs e );
	
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
	
	public delegate void  ConvertEventHandler (System.Object sender , System.Windows.Forms.ConvertEventArgs e );
	
	public delegate void  BindingCompleteEventHandler (System.Object sender , System.Windows.Forms.BindingCompleteEventArgs e );
	
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
	
	public delegate void  BindingManagerDataErrorEventHandler (System.Object sender , System.Windows.Forms.BindingManagerDataErrorEventArgs e );
	
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
	
	public delegate void  ItemChangedEventHandler (System.Object sender , System.Windows.Forms.ItemChangedEventArgs e );
	
	public class ItemChangedEventArgs
	{
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
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
	
	public class CurrencyManager
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
	
	public class ArrangedElementCollection
	{
		#region Properties
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
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
	
	public delegate void  ScrollEventHandler (System.Object sender , System.Windows.Forms.ScrollEventArgs e );
	
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
	
	public  partial class Timer : System.Windows.Forms.Timer
	{
		#region Constructors
		public Timer (System.ComponentModel.IContainer container) : base (container)
		{
		}
		
		public Timer () : base ()
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
	
	public  partial class MessageBox : System.Windows.Forms.MessageBox
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DialogResult result;
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String MessageText {get{  return  base.MessageText;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String InformativeText {get{  return  base.InformativeText;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSImage Icon {get{  return  base.Icon;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSButton[] Buttons {get{  return  base.Buttons;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowsHelp {get{  return  base.ShowsHelp;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String HelpAnchor {get{  return  base.HelpAnchor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSAlertStyle AlertStyle { get{  return  base.AlertStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSAlertDelegate Delegate {get{  return  base.Delegate;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowsSuppressionButton {get{  return  base.ShowsSuppressionButton;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSButton SuppressionButton {get{  return  base.SuppressionButton;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSView AccessoryView {get{  return  base.AccessoryView;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject Window {get{  return  base.Window;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSAlertPredicate ShowHelp {get{  return  base.ShowHelp;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr SuperHandle {get{  return  base.SuperHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr Handle {get{  return  base.Handle;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public static  new System.Windows.Forms.DialogResult GetResult (System.Int32 result , System.Windows.Forms.MessageBoxButtons buttons) {return System.Windows.Forms.MessageBox.GetResult(result , buttons);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void SetupIcon (System.Windows.Forms.MessageBoxIcon icon) { base.SetupIcon(icon);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void SetupButtons (System.Windows.Forms.MessageBoxButtons buttons) { base.SetupButtons(buttons);}
		#endregion
	}
	
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
		public new System.Windows.Forms.PaintEventHandler Paint {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Paint;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object components {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.components;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Load {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Load;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new BorderStyle BorderStyle { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.BorderStyle;}set{throw new NotImplementedException();}}
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
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void onPaint (System.Windows.Forms.PaintEventArgs e) { base.onPaint(e);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void onPaintBackground (System.Windows.Forms.PaintEventArgs e) { base.onPaintBackground(e);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void FireMouseDown (System.Object sender , System.Windows.Forms.MouseEventArgs e) { base.FireMouseDown(sender , e);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void FireMouseUp (System.Object sender , System.Windows.Forms.MouseEventArgs e) { base.FireMouseUp(sender , e);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void FireMouseMove (System.Object sender , System.Windows.Forms.MouseEventArgs e) { base.FireMouseMove(sender , e);}
		#endregion
	}
	
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
		public new System.String[] Lines {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Lines;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ScrollBars ScrollBars { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.ScrollBars;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Multiline {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.Multiline;}set{throw new NotImplementedException();}}
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
		public new DialogResult DialogResult { get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.DialogResult;}set{throw new NotImplementedException();}}
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
		#endregion
	}
	
	public  partial class CheckedListBox : System.Windows.Forms.CheckedListBox
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSTableView tableView;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSTableColumn column;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSString colString;
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSView CurrentEditor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CurrentEditor;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SelectedValueChanged {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectedValueChanged;}set{throw new NotImplementedException();}}
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
		public   override void SetupColumn () { base.SetupColumn();}
		#endregion
	}
	
	public  partial class ListBox : System.Windows.Forms.ListBox
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSTableView tableView;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSTableColumn column;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSString colString;
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSView CurrentEditor {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.CurrentEditor;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SelectedValueChanged {get{   if( !this.DesignMode ) throw new NotImplementedException(); return  base.SelectedValueChanged;}set{throw new NotImplementedException();}}
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
		public   override void SetupTable () { base.SetupTable();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void SetupColumn () { base.SetupColumn();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void SetNeedsDisplay () { base.SetNeedsDisplay();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void CollectionChanged () { base.CollectionChanged();}
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
		public new System.String Text {get{  return  base.Text;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TabIndex {get{  return  base.TabIndex;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Click {get{  return  base.Click;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color BackColor {get{  return  base.BackColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Title {get{  return  base.Title;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AlternateTitle {get{  return  base.AlternateTitle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSImage AlternateImage {get{  return  base.AlternateImage;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSCellImagePosition ImagePosition { get{  return  base.ImagePosition;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSImageScale ImageScale { get{  return  base.ImageScale;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 HighlightsBy {get{  return  base.HighlightsBy;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ShowsStateBy {get{  return  base.ShowsStateBy;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsOpaque {get{  return  base.IsOpaque;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Transparent {get{  return  base.Transparent;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String KeyEquivalent {get{  return  base.KeyEquivalent;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSEventModifierMask KeyEquivalentModifierMask { get{  return  base.KeyEquivalentModifierMask;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSFont KeyEquivalentFont {get{  return  base.KeyEquivalentFont;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 AlternateMnemonicLocation {get{  return  base.AlternateMnemonicLocation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AlternateMnemonic {get{  return  base.AlternateMnemonic;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ImageDimsWhenDisabled {get{  return  base.ImageDimsWhenDisabled;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowsBorderOnlyWhileMouseInside {get{  return  base.ShowsBorderOnlyWhileMouseInside;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSColor BackgroundColor {get{  return  base.BackgroundColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSAttributedString AttributedTitle {get{  return  base.AttributedTitle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSAttributedString AttributedAlternateTitle {get{  return  base.AttributedAlternateTitle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSBezelStyle BezelStyle { get{  return  base.BezelStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSSound Sound {get{  return  base.Sound;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject Target {get{  return  base.Target;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.ObjCRuntime.Selector Action {get{  return  base.Action;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSView ControlView {get{  return  base.ControlView;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSCellType CellType { get{  return  base.CellType;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Enabled {get{  return  base.Enabled;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsContinuous {get{  return  base.IsContinuous;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Editable {get{  return  base.Editable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selectable {get{  return  base.Selectable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Bordered {get{  return  base.Bordered;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Bezeled {get{  return  base.Bezeled;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Scrollable {get{  return  base.Scrollable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Highlighted {get{  return  base.Highlighted;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSTextAlignment Alignment { get{  return  base.Alignment;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Wraps {get{  return  base.Wraps;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSFont Font {get{  return  base.Font;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSFormatter Formatter {get{  return  base.Formatter;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject ObjectValue {get{  return  base.ObjectValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasValidObjectValue {get{  return  base.HasValidObjectValue;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String StringValue {get{  return  base.StringValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 IntValue {get{  return  base.IntValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single FloatValue {get{  return  base.FloatValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Double DoubleValue {get{  return  base.DoubleValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSImage Image {get{  return  base.Image;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSControlTint ControlTint { get{  return  base.ControlTint;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSControlSize ControlSize { get{  return  base.ControlSize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject RepresentedObject {get{  return  base.RepresentedObject;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF CellSize {get{  return  base.CellSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MouseDownFlags {get{  return  base.MouseDownFlags;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSMenu Menu {get{  return  base.Menu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSWritingDirection BaseWritingDirection { get{  return  base.BaseWritingDirection;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSLineBreakMode LineBreakMode { get{  return  base.LineBreakMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsUndo {get{  return  base.AllowsUndo;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 IntegerValue {get{  return  base.IntegerValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TruncatesLastVisibleLine {get{  return  base.TruncatesLastVisibleLine;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSUserInterfaceLayoutDirection UserInterfaceLayoutDirection { get{  return  base.UserInterfaceLayoutDirection;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UsesSingleLineMode {get{  return  base.UsesSingleLineMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowsFirstResponder {get{  return  base.ShowsFirstResponder;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MnemonicLocation {get{  return  base.MnemonicLocation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Mnemonic {get{  return  base.Mnemonic;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSFocusRingType focusRingType { get{  return  base.focusRingType;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean WantsNotificationForMarkedText {get{  return  base.WantsNotificationForMarkedText;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsEditingTextAttributes {get{  return  base.AllowsEditingTextAttributes;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ImportsGraphics {get{  return  base.ImportsGraphics;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsMixedState {get{  return  base.AllowsMixedState;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 NextState {get{  return  base.NextState;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSBackgroundStyle BackgroundStyle { get{  return  base.BackgroundStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSBackgroundStyle InteriorBackgroundStyle { get{  return  base.InteriorBackgroundStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr SuperHandle {get{  return  base.SuperHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr Handle {get{  return  base.Handle;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Activated;
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class DataGridViewButtonColumn : System.Windows.Forms.DataGridViewButtonColumn
	{
		#region Constructors
		public DataGridViewButtonColumn () : base ()
		{
		}
		
		[Obsolete("This method is not cross-platform compatible.", true)]
		public DataGridViewButtonColumn (MonoMac.Foundation.NSObject identifier) : base (identifier)
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
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject Identifier {get{  return  base.Identifier;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSTableView TableView {get{  return  base.TableView;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single MinWidth {get{  return  base.MinWidth;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single MaxWidth {get{  return  base.MaxWidth;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSCell DataCell {get{  return  base.DataCell;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Editable {get{  return  base.Editable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSSortDescriptor SortDescriptorPrototype {get{  return  base.SortDescriptorPrototype;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSTableColumnResizingMask ResizingMask { get{  return  base.ResizingMask;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String HeaderToolTip {get{  return  base.HeaderToolTip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Hidden {get{  return  base.Hidden;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr SuperHandle {get{  return  base.SuperHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr Handle {get{  return  base.Handle;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class DataGridViewCheckBoxColumn : System.Windows.Forms.DataGridViewCheckBoxColumn
	{
		#region Constructors
		public DataGridViewCheckBoxColumn () : base ()
		{
		}
		
		[Obsolete("This method is not cross-platform compatible.", true)]
		public DataGridViewCheckBoxColumn (MonoMac.Foundation.NSObject identifier) : base (identifier)
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
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject Identifier {get{  return  base.Identifier;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSTableView TableView {get{  return  base.TableView;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single MinWidth {get{  return  base.MinWidth;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single MaxWidth {get{  return  base.MaxWidth;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSCell DataCell {get{  return  base.DataCell;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Editable {get{  return  base.Editable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSSortDescriptor SortDescriptorPrototype {get{  return  base.SortDescriptorPrototype;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSTableColumnResizingMask ResizingMask { get{  return  base.ResizingMask;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String HeaderToolTip {get{  return  base.HeaderToolTip;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Hidden {get{  return  base.Hidden;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr SuperHandle {get{  return  base.SuperHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr Handle {get{  return  base.Handle;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public  partial class DataGridViewCheckBoxCell : System.Windows.Forms.DataGridViewCheckBoxCell
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
		public new System.Boolean Checked {get{  return  base.Checked;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new CheckState CheckState { get{  return  base.CheckState;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Text {get{  return  base.Text;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TabIndex {get{  return  base.TabIndex;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Click {get{  return  base.Click;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color BackColor {get{  return  base.BackColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Title {get{  return  base.Title;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AlternateTitle {get{  return  base.AlternateTitle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSImage AlternateImage {get{  return  base.AlternateImage;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSCellImagePosition ImagePosition { get{  return  base.ImagePosition;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSImageScale ImageScale { get{  return  base.ImageScale;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 HighlightsBy {get{  return  base.HighlightsBy;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ShowsStateBy {get{  return  base.ShowsStateBy;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsOpaque {get{  return  base.IsOpaque;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Transparent {get{  return  base.Transparent;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String KeyEquivalent {get{  return  base.KeyEquivalent;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSEventModifierMask KeyEquivalentModifierMask { get{  return  base.KeyEquivalentModifierMask;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSFont KeyEquivalentFont {get{  return  base.KeyEquivalentFont;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 AlternateMnemonicLocation {get{  return  base.AlternateMnemonicLocation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AlternateMnemonic {get{  return  base.AlternateMnemonic;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ImageDimsWhenDisabled {get{  return  base.ImageDimsWhenDisabled;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowsBorderOnlyWhileMouseInside {get{  return  base.ShowsBorderOnlyWhileMouseInside;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSColor BackgroundColor {get{  return  base.BackgroundColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSAttributedString AttributedTitle {get{  return  base.AttributedTitle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSAttributedString AttributedAlternateTitle {get{  return  base.AttributedAlternateTitle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSBezelStyle BezelStyle { get{  return  base.BezelStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSSound Sound {get{  return  base.Sound;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject Target {get{  return  base.Target;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.ObjCRuntime.Selector Action {get{  return  base.Action;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSView ControlView {get{  return  base.ControlView;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSCellType CellType { get{  return  base.CellType;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Enabled {get{  return  base.Enabled;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsContinuous {get{  return  base.IsContinuous;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Editable {get{  return  base.Editable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selectable {get{  return  base.Selectable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Bordered {get{  return  base.Bordered;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Bezeled {get{  return  base.Bezeled;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Scrollable {get{  return  base.Scrollable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Highlighted {get{  return  base.Highlighted;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSTextAlignment Alignment { get{  return  base.Alignment;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Wraps {get{  return  base.Wraps;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSFont Font {get{  return  base.Font;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSFormatter Formatter {get{  return  base.Formatter;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject ObjectValue {get{  return  base.ObjectValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasValidObjectValue {get{  return  base.HasValidObjectValue;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String StringValue {get{  return  base.StringValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 IntValue {get{  return  base.IntValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single FloatValue {get{  return  base.FloatValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Double DoubleValue {get{  return  base.DoubleValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSImage Image {get{  return  base.Image;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSControlTint ControlTint { get{  return  base.ControlTint;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSControlSize ControlSize { get{  return  base.ControlSize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject RepresentedObject {get{  return  base.RepresentedObject;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF CellSize {get{  return  base.CellSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MouseDownFlags {get{  return  base.MouseDownFlags;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSMenu Menu {get{  return  base.Menu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSWritingDirection BaseWritingDirection { get{  return  base.BaseWritingDirection;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSLineBreakMode LineBreakMode { get{  return  base.LineBreakMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsUndo {get{  return  base.AllowsUndo;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 IntegerValue {get{  return  base.IntegerValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TruncatesLastVisibleLine {get{  return  base.TruncatesLastVisibleLine;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSUserInterfaceLayoutDirection UserInterfaceLayoutDirection { get{  return  base.UserInterfaceLayoutDirection;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UsesSingleLineMode {get{  return  base.UsesSingleLineMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowsFirstResponder {get{  return  base.ShowsFirstResponder;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MnemonicLocation {get{  return  base.MnemonicLocation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Mnemonic {get{  return  base.Mnemonic;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSFocusRingType focusRingType { get{  return  base.focusRingType;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean WantsNotificationForMarkedText {get{  return  base.WantsNotificationForMarkedText;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsEditingTextAttributes {get{  return  base.AllowsEditingTextAttributes;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ImportsGraphics {get{  return  base.ImportsGraphics;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsMixedState {get{  return  base.AllowsMixedState;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 NextState {get{  return  base.NextState;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSBackgroundStyle BackgroundStyle { get{  return  base.BackgroundStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSBackgroundStyle InteriorBackgroundStyle { get{  return  base.InteriorBackgroundStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr SuperHandle {get{  return  base.SuperHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr Handle {get{  return  base.Handle;}set{throw new NotImplementedException();}}
		#endregion
		#endregion
		#region Events
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Activated;
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class BindingsCollection
	{
		#region Properties
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
		
		public Control (System.String text) : base (text)
		{
		}
		
		public Control (System.Windows.Forms.Control control , System.String text) : base (control , text)
		{
		}
		
		public Control (System.String text , System.Int32 left , System.Int32 top , System.Int32 width , System.Int32 height) : base (text , left , top , width , height)
		{
		}
		
		public Control (System.Windows.Forms.Control control , System.String text , System.Int32 left , System.Int32 top , System.Int32 width , System.Int32 height) : base (control , text , left , top , width , height)
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
		#endregion
	}
	
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
	
	public class LayoutSettings
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

