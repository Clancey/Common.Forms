using System;
using System.Windows.Forms;
using System.Drawing;
using MonoMac.AppKit;

namespace Common.Forms
{
	public partial class Button : System.Windows.Forms.Button
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
		public new BorderStyle BorderStyle { get{  return  base.BorderStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoScaleMode AutoScaleMode { get{  return  base.AutoScaleMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSButtonCell Cell {get{  return  base.Cell;}set{throw new NotImplementedException();}}
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
		public new NSCellStateValue State { get{  return  base.State;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Bordered {get{  return  base.Bordered;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Transparent {get{  return  base.Transparent;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String KeyEquivalent {get{  return  base.KeyEquivalent;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSEventModifierMask KeyEquivalentModifierMask { get{  return  base.KeyEquivalentModifierMask;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSAttributedString AttributedTitle {get{  return  base.AttributedTitle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSAttributedString AttributedAlternateTitle {get{  return  base.AttributedAlternateTitle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSBezelStyle BezelStyle { get{  return  base.BezelStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsMixedState {get{  return  base.AllowsMixedState;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSSound Sound {get{  return  base.Sound;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSCell SelectedCell {get{  return  base.SelectedCell;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectedTag {get{  return  base.SelectedTag;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSText CurrentEditor {get{  return  base.CurrentEditor;}}
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
		public new System.Boolean IsFlipped {get{  return  base.IsFlipped;}}
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
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler Click;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler SizeChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Activated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AutoValidateChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void DrawRect (System.Drawing.RectangleF dirtyRect) { base.DrawRect(dirtyRect);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseMoved (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseMoved(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireScrollWheel (MonoMac.AppKit.NSEvent theEvent) { base.FireScrollWheel(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseEntered (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseEntered(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseExited (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseExited(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDragged(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireRightMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireRightMouseDragged(theEvent);}
		#endregion
	}
	
	public partial class MessageBox : System.Windows.Forms.MessageBox
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
	
	public partial class Form : System.Windows.Forms.Form
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
		public new System.Windows.Forms.PaintEventHandler Paint {get{  return  base.Paint;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object components {get{  return  base.components;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Load {get{  return  base.Load;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new BorderStyle BorderStyle { get{  return  base.BorderStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Title {get{  return  base.Title;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSUrl RepresentedUrl {get{  return  base.RepresentedUrl;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String RepresentedFilename {get{  return  base.RepresentedFilename;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ExcludedFromWindowsMenu {get{  return  base.ExcludedFromWindowsMenu;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSView ContentView {get{  return  base.ContentView;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject WeakDelegate {get{  return  base.WeakDelegate;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSWindowDelegate Delegate {get{  return  base.Delegate;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 WindowNumber {get{  return  base.WindowNumber;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSWindowStyle StyleMask { get{  return  base.StyleMask;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.RectangleF Frame {get{  return  base.Frame;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InLiveResize {get{  return  base.InLiveResize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowsResizeIndicator {get{  return  base.ShowsResizeIndicator;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF ResizeIncrements {get{  return  base.ResizeIncrements;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF AspectRatio {get{  return  base.AspectRatio;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF ContentResizeIncrements {get{  return  base.ContentResizeIncrements;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF ContentAspectRatio {get{  return  base.ContentAspectRatio;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean FlushWindowDisabled {get{  return  base.FlushWindowDisabled;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ViewsNeedDisplay {get{  return  base.ViewsNeedDisplay;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Autodisplay {get{  return  base.Autodisplay;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean PreservesContentDuringLiveResize {get{  return  base.PreservesContentDuringLiveResize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSResponder FirstResponder {get{  return  base.FirstResponder;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ResizeFlags {get{  return  base.ResizeFlags;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReleasedWhenClosed {get{  return  base.ReleasedWhenClosed;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsZoomed {get{  return  base.IsZoomed;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMiniaturized {get{  return  base.IsMiniaturized;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSColor BackgroundColor {get{  return  base.BackgroundColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMovable {get{  return  base.IsMovable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean MovableByWindowBackground {get{  return  base.MovableByWindowBackground;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean hidesOnDeactivate {get{  return  base.hidesOnDeactivate;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanHide {get{  return  base.CanHide;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSImage MiniwindowImage {get{  return  base.MiniwindowImage;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String miniwindowTitle {get{  return  base.miniwindowTitle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSDockTile DockTile {get{  return  base.DockTile;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean DocumentEdited {get{  return  base.DocumentEdited;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsVisible {get{  return  base.IsVisible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsKeyWindow {get{  return  base.IsKeyWindow;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMainWindow {get{  return  base.IsMainWindow;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanBecomeKeyWindow {get{  return  base.CanBecomeKeyWindow;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanBecomeMainWindow {get{  return  base.CanBecomeMainWindow;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean PreventsApplicationTerminationWhenModal {get{  return  base.PreventsApplicationTerminationWhenModal;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsOneShot {get{  return  base.IsOneShot;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AreCursorRectsEnabled {get{  return  base.AreCursorRectsEnabled;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsToolTipsWhenApplicationIsInactive {get{  return  base.AllowsToolTipsWhenApplicationIsInactive;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSBackingStore BackingType { get{  return  base.BackingType;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSWindowLevel Level { get{  return  base.Level;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSWindowDepth DepthLimit { get{  return  base.DepthLimit;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean hasDynamicDepthLimit {get{  return  base.hasDynamicDepthLimit;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSScreen Screen {get{  return  base.Screen;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSScreen DeepestScreen {get{  return  base.DeepestScreen;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanStoreColor {get{  return  base.CanStoreColor;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasShadow {get{  return  base.HasShadow;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single AlphaValue {get{  return  base.AlphaValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsOpaque {get{  return  base.IsOpaque;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSWindowSharingType SharingType { get{  return  base.SharingType;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSWindowBackingLocation PreferredBackingLocation { get{  return  base.PreferredBackingLocation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSWindowBackingLocation BackingLocation { get{  return  base.BackingLocation;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsConcurrentViewDrawing {get{  return  base.AllowsConcurrentViewDrawing;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean DisplaysWhenScreenProfileChanges {get{  return  base.DisplaysWhenScreenProfileChanges;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanBecomeVisibleWithoutLogin {get{  return  base.CanBecomeVisibleWithoutLogin;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSWindowCollectionBehavior CollectionBehavior { get{  return  base.CollectionBehavior;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsOnActiveSpace {get{  return  base.IsOnActiveSpace;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String FrameAutosaveName {get{  return  base.FrameAutosaveName;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF MinSize {get{  return  base.MinSize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF MaxSize {get{  return  base.MaxSize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF ContentMinSize {get{  return  base.ContentMinSize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF ContentMaxSize {get{  return  base.ContentMaxSize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AcceptsMouseMovedEvents {get{  return  base.AcceptsMouseMovedEvents;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IgnoresMouseEvents {get{  return  base.IgnoresMouseEvents;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSDictionary DeviceDescription {get{  return  base.DeviceDescription;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.PointF MouseLocationOutsideOfEventStream {get{  return  base.MouseLocationOutsideOfEventStream;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject WindowController {get{  return  base.WindowController;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsSheet {get{  return  base.IsSheet;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSWindow AttachedSheet {get{  return  base.AttachedSheet;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSWindow[] ChildWindows {get{  return  base.ChildWindows;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSWindow ParentWindow {get{  return  base.ParentWindow;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSGraphicsContext GraphicsContext {get{  return  base.GraphicsContext;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single UserSpaceScaleFactor {get{  return  base.UserSpaceScaleFactor;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSColorSpace ColorSpace {get{  return  base.ColorSpace;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSView InitialFirstResponder {get{  return  base.InitialFirstResponder;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSButtonCell DefaultButtonCell {get{  return  base.DefaultButtonCell;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutorecalculatesKeyViewLoop {get{  return  base.AutorecalculatesKeyViewLoop;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowsToolbarButton {get{  return  base.ShowsToolbarButton;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr WindowRef {get{  return  base.WindowRef;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject Animator {get{  return  base.Animator;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSDictionary Animations {get{  return  base.Animations;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSObjectPredicate WindowShouldClose {get{  return  base.WindowShouldClose;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSWindowClient WillReturnFieldEditor {get{  return  base.WillReturnFieldEditor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSWindowResize WillResize {get{  return  base.WillResize;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSWindowFrame WillUseStandardFrame {get{  return  base.WillUseStandardFrame;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSWindowFramePredicate ShouldZoom {get{  return  base.ShouldZoom;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSWindowUndoManager WillReturnUndoManager {get{  return  base.WillReturnUndoManager;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSWindowSheetRect WillPositionSheet {get{  return  base.WillPositionSheet;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSWindowMenu ShouldPopUpDocumentPathMenu {get{  return  base.ShouldPopUpDocumentPathMenu;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSWindowDocumentDrag ShouldDragDocumentWithEvent {get{  return  base.ShouldDragDocumentWithEvent;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSResponder NextResponder {get{  return  base.NextResponder;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr SuperHandle {get{  return  base.SuperHandle;}}
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
		public new event System.EventHandler DidBecomeKey;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidBecomeMain;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidChangeScreen;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidChangeScreenProfile;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidDeminiaturize;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidEndLiveResize;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidEndSheet;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidExpose;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidMiniaturize;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidMoved;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidResignKey;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidResignMain;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidResize;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidUpdate;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler WillBeginSheet;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler WillClose;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler WillMiniaturize;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler WillMove;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler WillStartLiveResize;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void onPaint (System.Windows.Forms.PaintEventArgs e) { base.onPaint(e);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void onPaintBackground (System.Windows.Forms.PaintEventArgs e) { base.onPaintBackground(e);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void BecomeKeyWindow () { base.BecomeKeyWindow();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void FireMouseDown (System.Object sender , System.Windows.Forms.MouseEventArgs e) { base.FireMouseDown(sender , e);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void FireMouseUp (System.Object sender , System.Windows.Forms.MouseEventArgs e) { base.FireMouseUp(sender , e);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   new void FireMouseMove (System.Object sender , System.Windows.Forms.MouseEventArgs e) { base.FireMouseMove(sender , e);}
		#endregion
	}
	
	public partial class TextBox : System.Windows.Forms.TextBox
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
		public new AutoScaleMode AutoScaleMode { get{  return  base.AutoScaleMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSColor BackgroundColor {get{  return  base.BackgroundColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean DrawsBackground {get{  return  base.DrawsBackground;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSColor TextColor {get{  return  base.TextColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Bordered {get{  return  base.Bordered;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Bezeled {get{  return  base.Bezeled;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Editable {get{  return  base.Editable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selectable {get{  return  base.Selectable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject WeakDelegate {get{  return  base.WeakDelegate;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSTextFieldDelegate Delegate {get{  return  base.Delegate;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSTextFieldBezelStyle BezelStyle { get{  return  base.BezelStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsEditingTextAttributes {get{  return  base.AllowsEditingTextAttributes;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ImportsGraphics {get{  return  base.ImportsGraphics;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlText TextShouldBeginEditing {get{  return  base.TextShouldBeginEditing;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlText TextShouldEndEditing {get{  return  base.TextShouldEndEditing;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlTextError DidFailToFormatString {get{  return  base.DidFailToFormatString;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlTextValidation IsValidObject {get{  return  base.IsValidObject;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlCommand DoCommandBySelector {get{  return  base.DoCommandBySelector;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlTextFilter GetCompletions {get{  return  base.GetCompletions;}set{throw new NotImplementedException();}}
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
		public new System.Boolean IsFlipped {get{  return  base.IsFlipped;}}
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
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler TextChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Activated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AutoValidateChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Changed;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidFailToValidatePartialString;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler EditingBegan;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler EditingEnded;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.KeyEventHandler OnKeyDown;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.KeyEventHandler OnKeyUp;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void ViewDidMoveToSuperview () { base.ViewDidMoveToSuperview();}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void KeyDown (MonoMac.AppKit.NSEvent theEvent) { base.KeyDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void KeyUp (MonoMac.AppKit.NSEvent theEvent) { base.KeyUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void DidChange (MonoMac.Foundation.NSNotification notification) { base.DidChange(notification);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void DrawRect (System.Drawing.RectangleF dirtyRect) { base.DrawRect(dirtyRect);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseMoved (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseMoved(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireScrollWheel (MonoMac.AppKit.NSEvent theEvent) { base.FireScrollWheel(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseEntered (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseEntered(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseExited (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseExited(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDragged(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireRightMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireRightMouseDragged(theEvent);}
		#endregion
	}
	
	public partial class Label : System.Windows.Forms.Label
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
		public new System.String[] Lines {get{  return  base.Lines;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new ScrollBars ScrollBars { get{  return  base.ScrollBars;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Multiline {get{  return  base.Multiline;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint {get{  return  base.Paint;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoScaleMode AutoScaleMode { get{  return  base.AutoScaleMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSColor BackgroundColor {get{  return  base.BackgroundColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean DrawsBackground {get{  return  base.DrawsBackground;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSColor TextColor {get{  return  base.TextColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Bordered {get{  return  base.Bordered;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Bezeled {get{  return  base.Bezeled;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Editable {get{  return  base.Editable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selectable {get{  return  base.Selectable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject WeakDelegate {get{  return  base.WeakDelegate;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSTextFieldDelegate Delegate {get{  return  base.Delegate;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSTextFieldBezelStyle BezelStyle { get{  return  base.BezelStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsEditingTextAttributes {get{  return  base.AllowsEditingTextAttributes;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ImportsGraphics {get{  return  base.ImportsGraphics;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlText TextShouldBeginEditing {get{  return  base.TextShouldBeginEditing;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlText TextShouldEndEditing {get{  return  base.TextShouldEndEditing;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlTextError DidFailToFormatString {get{  return  base.DidFailToFormatString;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlTextValidation IsValidObject {get{  return  base.IsValidObject;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlCommand DoCommandBySelector {get{  return  base.DoCommandBySelector;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlTextFilter GetCompletions {get{  return  base.GetCompletions;}set{throw new NotImplementedException();}}
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
		public new System.Boolean IsFlipped {get{  return  base.IsFlipped;}}
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
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler TextChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Activated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AutoValidateChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Changed;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidFailToValidatePartialString;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler EditingBegan;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler EditingEnded;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.KeyEventHandler OnKeyDown;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.KeyEventHandler OnKeyUp;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override Boolean AcceptsFirstResponder () {return  base.AcceptsFirstResponder();}
		#endregion
	}
	
	public partial class KeyEventArgs : System.Windows.Forms.KeyEventArgs
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
	
	public partial class Control : System.Windows.Forms.Control
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
		public new System.Windows.Forms.KeyEventHandler OnKeyDown {get{  return  base.OnKeyDown;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler OnKeyUp {get{  return  base.OnKeyUp;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyPressEventHandler OnKeyPress {get{  return  base.OnKeyPress;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
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
		public new System.Boolean IsFlipped {get{  return  base.IsFlipped;}}
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
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void KeyDown (MonoMac.AppKit.NSEvent theEvent) { base.KeyDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void KeyUp (MonoMac.AppKit.NSEvent theEvent) { base.KeyUp(theEvent);}
		#endregion
	}
	
	public partial class CheckBox : System.Windows.Forms.CheckBox
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
		public new DialogResult DialogResult { get{  return  base.DialogResult;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint {get{  return  base.Paint;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new BorderStyle BorderStyle { get{  return  base.BorderStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoScaleMode AutoScaleMode { get{  return  base.AutoScaleMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSButtonCell Cell {get{  return  base.Cell;}set{throw new NotImplementedException();}}
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
		public new NSCellStateValue State { get{  return  base.State;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Bordered {get{  return  base.Bordered;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Transparent {get{  return  base.Transparent;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String KeyEquivalent {get{  return  base.KeyEquivalent;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSEventModifierMask KeyEquivalentModifierMask { get{  return  base.KeyEquivalentModifierMask;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSAttributedString AttributedTitle {get{  return  base.AttributedTitle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSAttributedString AttributedAlternateTitle {get{  return  base.AttributedAlternateTitle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSBezelStyle BezelStyle { get{  return  base.BezelStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsMixedState {get{  return  base.AllowsMixedState;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSSound Sound {get{  return  base.Sound;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSCell SelectedCell {get{  return  base.SelectedCell;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectedTag {get{  return  base.SelectedTag;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSText CurrentEditor {get{  return  base.CurrentEditor;}}
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
		public new System.Boolean IsFlipped {get{  return  base.IsFlipped;}}
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
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler Click;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler SizeChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Activated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AutoValidateChanged;
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public partial class CheckedListBox : System.Windows.Forms.CheckedListBox
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
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean shouldDraw;
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSView CurrentEditor {get{  return  base.CurrentEditor;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SelectedValueChanged {get{  return  base.SelectedValueChanged;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint {get{  return  base.Paint;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoScaleMode AutoScaleMode { get{  return  base.AutoScaleMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.RectangleF DocumentVisibleRect {get{  return  base.DocumentVisibleRect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF ContentSize {get{  return  base.ContentSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject DocumentView {get{  return  base.DocumentView;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSClipView ContentView {get{  return  base.ContentView;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSCursor DocumentCursor {get{  return  base.DocumentCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSBorderType BorderType { get{  return  base.BorderType;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSColor BackgroundColor {get{  return  base.BackgroundColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean DrawsBackground {get{  return  base.DrawsBackground;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasVerticalScroller {get{  return  base.HasVerticalScroller;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasHorizontalScroller {get{  return  base.HasHorizontalScroller;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSScroller VerticalScroller {get{  return  base.VerticalScroller;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSScroller HorizontalScroller {get{  return  base.HorizontalScroller;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutohidesScrollers {get{  return  base.AutohidesScrollers;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single HorizontalLineScroll {get{  return  base.HorizontalLineScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single VerticalLineScroll {get{  return  base.VerticalLineScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single LineScroll {get{  return  base.LineScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single HorizontalPageScroll {get{  return  base.HorizontalPageScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single VerticalPageScroll {get{  return  base.VerticalPageScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single PageScroll {get{  return  base.PageScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ScrollsDynamically {get{  return  base.ScrollsDynamically;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasVerticalRuler {get{  return  base.HasVerticalRuler;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasHorizontalRuler {get{  return  base.HasHorizontalRuler;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RulersVisible {get{  return  base.RulersVisible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSRulerView HorizontalRulerView {get{  return  base.HorizontalRulerView;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSRulerView VerticalRulerView {get{  return  base.VerticalRulerView;}set{throw new NotImplementedException();}}
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
		public new System.Boolean IsFlipped {get{  return  base.IsFlipped;}}
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
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler SizeChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AutoValidateChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void SetupColumn () { base.SetupColumn();}
		#endregion
	}
	
	public partial class ComboBox : System.Windows.Forms.ComboBox
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
		public new System.EventHandler SelectedIndexChanged {get{  return  base.SelectedIndexChanged;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SelectedValueChanged {get{  return  base.SelectedValueChanged;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint {get{  return  base.Paint;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new BorderStyle BorderStyle { get{  return  base.BorderStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoScaleMode AutoScaleMode { get{  return  base.AutoScaleMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasVerticalScroller {get{  return  base.HasVerticalScroller;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF IntercellSpacing {get{  return  base.IntercellSpacing;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 VisibleItems {get{  return  base.VisibleItems;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ButtonBordered {get{  return  base.ButtonBordered;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UsesDataSource {get{  return  base.UsesDataSource;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Count {get{  return  base.Count;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Completes {get{  return  base.Completes;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject[] Values {get{  return  base.Values;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSColor BackgroundColor {get{  return  base.BackgroundColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean DrawsBackground {get{  return  base.DrawsBackground;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSColor TextColor {get{  return  base.TextColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Bordered {get{  return  base.Bordered;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Bezeled {get{  return  base.Bezeled;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Editable {get{  return  base.Editable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selectable {get{  return  base.Selectable;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject WeakDelegate {get{  return  base.WeakDelegate;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSTextFieldDelegate Delegate {get{  return  base.Delegate;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSTextFieldBezelStyle BezelStyle { get{  return  base.BezelStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsEditingTextAttributes {get{  return  base.AllowsEditingTextAttributes;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ImportsGraphics {get{  return  base.ImportsGraphics;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlText TextShouldBeginEditing {get{  return  base.TextShouldBeginEditing;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlText TextShouldEndEditing {get{  return  base.TextShouldEndEditing;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlTextError DidFailToFormatString {get{  return  base.DidFailToFormatString;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlTextValidation IsValidObject {get{  return  base.IsValidObject;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlCommand DoCommandBySelector {get{  return  base.DoCommandBySelector;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSControlTextFilter GetCompletions {get{  return  base.GetCompletions;}set{throw new NotImplementedException();}}
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
		public new System.Boolean IsFlipped {get{  return  base.IsFlipped;}}
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
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.KeyPressEventHandler KeyPress;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler SizeChanged;
		public new event System.EventHandler TextChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Activated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AutoValidateChanged;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Changed;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler DidFailToValidatePartialString;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler EditingBegan;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler EditingEnded;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.KeyEventHandler OnKeyDown;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.Windows.Forms.KeyEventHandler OnKeyUp;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void KeyDown (MonoMac.AppKit.NSEvent theEvent) { base.KeyDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void KeyUp (MonoMac.AppKit.NSEvent theEvent) { base.KeyUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void DidChange (MonoMac.Foundation.NSNotification notification) { base.DidChange(notification);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void DrawRect (System.Drawing.RectangleF dirtyRect) { base.DrawRect(dirtyRect);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseMoved (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseMoved(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireScrollWheel (MonoMac.AppKit.NSEvent theEvent) { base.FireScrollWheel(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseEntered (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseEntered(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseExited (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseExited(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDragged(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireRightMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireRightMouseDragged(theEvent);}
		#endregion
	}
	
	public partial class UserControl : System.Windows.Forms.UserControl
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
		public new System.Boolean IsFlipped {get{  return  base.IsFlipped;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint {get{  return  base.Paint;}set{throw new NotImplementedException();}}
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
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler AutoValidateChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler SizeChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Activated;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void DrawRect (System.Drawing.RectangleF dirtyRect) { base.DrawRect(dirtyRect);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseMoved (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseMoved(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireScrollWheel (MonoMac.AppKit.NSEvent theEvent) { base.FireScrollWheel(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseEntered (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseEntered(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseExited (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseExited(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDragged(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireRightMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireRightMouseDragged(theEvent);}
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
	
	public partial class PaintEventArgs : System.Windows.Forms.PaintEventArgs
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
	
	public partial class ListBox : System.Windows.Forms.ListBox
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
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean shouldDraw;
		#endregion
		#endregion
		#region Properties
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSView CurrentEditor {get{  return  base.CurrentEditor;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SelectedValueChanged {get{  return  base.SelectedValueChanged;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint {get{  return  base.Paint;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoScaleMode AutoScaleMode { get{  return  base.AutoScaleMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.RectangleF DocumentVisibleRect {get{  return  base.DocumentVisibleRect;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF ContentSize {get{  return  base.ContentSize;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject DocumentView {get{  return  base.DocumentView;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSClipView ContentView {get{  return  base.ContentView;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSCursor DocumentCursor {get{  return  base.DocumentCursor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSBorderType BorderType { get{  return  base.BorderType;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSColor BackgroundColor {get{  return  base.BackgroundColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean DrawsBackground {get{  return  base.DrawsBackground;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasVerticalScroller {get{  return  base.HasVerticalScroller;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasHorizontalScroller {get{  return  base.HasHorizontalScroller;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSScroller VerticalScroller {get{  return  base.VerticalScroller;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSScroller HorizontalScroller {get{  return  base.HorizontalScroller;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutohidesScrollers {get{  return  base.AutohidesScrollers;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single HorizontalLineScroll {get{  return  base.HorizontalLineScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single VerticalLineScroll {get{  return  base.VerticalLineScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single LineScroll {get{  return  base.LineScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single HorizontalPageScroll {get{  return  base.HorizontalPageScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single VerticalPageScroll {get{  return  base.VerticalPageScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single PageScroll {get{  return  base.PageScroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ScrollsDynamically {get{  return  base.ScrollsDynamically;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasVerticalRuler {get{  return  base.HasVerticalRuler;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasHorizontalRuler {get{  return  base.HasHorizontalRuler;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RulersVisible {get{  return  base.RulersVisible;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSRulerView HorizontalRulerView {get{  return  base.HorizontalRulerView;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSRulerView VerticalRulerView {get{  return  base.VerticalRulerView;}set{throw new NotImplementedException();}}
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
		public new System.Boolean IsFlipped {get{  return  base.IsFlipped;}}
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
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler SizeChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AutoValidateChanged;
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
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void DrawRect (System.Drawing.RectangleF dirtyRect) { base.DrawRect(dirtyRect);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseMoved (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseMoved(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireScrollWheel (MonoMac.AppKit.NSEvent theEvent) { base.FireScrollWheel(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseEntered (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseEntered(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseExited (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseExited(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDragged(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireRightMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireRightMouseDragged(theEvent);}
		#endregion
	}
	
	public partial class TrackBar : System.Windows.Forms.TrackBar
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
		public new System.EventHandler Scroll {get{  return  base.Scroll;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint {get{  return  base.Paint;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new BorderStyle BorderStyle { get{  return  base.BorderStyle;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new AutoScaleMode AutoScaleMode { get{  return  base.AutoScaleMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 IsVertical {get{  return  base.IsVertical;}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Double MinValue {get{  return  base.MinValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Double MaxValue {get{  return  base.MaxValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Double AltIncrementValue {get{  return  base.AltIncrementValue;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.Foundation.NSObject TitleCell {get{  return  base.TitleCell;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSColor TitleColor {get{  return  base.TitleColor;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSFont TitleFont {get{  return  base.TitleFont;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Title {get{  return  base.Title;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single KnobThickness {get{  return  base.KnobThickness;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new MonoMac.AppKit.NSImage Image {get{  return  base.Image;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TickMarksCount {get{  return  base.TickMarksCount;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new NSTickMarkPosition TickMarkPosition { get{  return  base.TickMarkPosition;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowsTickMarkValuesOnly {get{  return  base.AllowsTickMarkValuesOnly;}set{throw new NotImplementedException();}}
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
		public new System.Boolean IsFlipped {get{  return  base.IsFlipped;}}
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
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler SizeChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler Activated;
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AutoValidateChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void DrawRect (System.Drawing.RectangleF dirtyRect) { base.DrawRect(dirtyRect);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseMoved (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseMoved(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireScrollWheel (MonoMac.AppKit.NSEvent theEvent) { base.FireScrollWheel(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseEntered (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseEntered(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseExited (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseExited(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDragged(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireRightMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireRightMouseDragged(theEvent);}
		#endregion
	}
	
	public partial class DataGridViewButtonCell : System.Windows.Forms.DataGridViewButtonCell
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
	
	public partial class DataGridViewButtonColumn : System.Windows.Forms.DataGridViewButtonColumn
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
	
	public partial class DataGridViewCheckBoxColumn : System.Windows.Forms.DataGridViewCheckBoxColumn
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
	
	public partial class DataGridViewCheckBoxCell : System.Windows.Forms.DataGridViewCheckBoxCell
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
	
	public partial class Panel : System.Windows.Forms.Panel
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
		public new AutoScaleMode AutoScaleMode { get{  return  base.AutoScaleMode;}set{throw new NotImplementedException();}}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IntPtr ClassHandle {get{  return  base.ClassHandle;}}
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
		public new event System.EventHandler AutoSizeChanged;
		public new event System.EventHandler GotFocus;
		public new event Common.Forms.MouseEventHandler MouseDoubleClick;
		public new event Common.Forms.MouseEventHandler MouseDown;
		public new event System.EventHandler MouseEnter;
		public new event System.EventHandler MouseHover;
		public new event System.EventHandler MouseLeave;
		public new event Common.Forms.MouseEventHandler MouseMove;
		public new event Common.Forms.MouseEventHandler MouseUp;
		public new event Common.Forms.MouseEventHandler MouseWheel;
		public new event System.EventHandler SizeChanged;
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new event System.EventHandler AutoValidateChanged;
		#endregion
		#endregion
		#region Excluded Methods
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void DrawRect (System.Drawing.RectangleF dirtyRect) { base.DrawRect(dirtyRect);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseDown (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseDown(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void RightMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.RightMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireOtherMouseUp (MonoMac.AppKit.NSEvent theEvent) { base.FireOtherMouseUp(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseMoved (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseMoved(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireScrollWheel (MonoMac.AppKit.NSEvent theEvent) { base.FireScrollWheel(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseEntered (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseEntered(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseExited (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseExited(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireMouseDragged(theEvent);}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public   override void FireRightMouseDragged (MonoMac.AppKit.NSEvent theEvent) { base.FireRightMouseDragged(theEvent);}
		#endregion
	}
	
	#region Enums
	#endregion
}

