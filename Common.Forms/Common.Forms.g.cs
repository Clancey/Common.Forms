using System;

namespace Common.Forms
{
	public class Button : System.Windows.Forms.Button,System.Windows.Forms.IBindableComponent,System.Windows.Forms.IDropTarget,System.IDisposable,System.Windows.Forms.IButtonControl,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.ComponentModel.ISynchronizeInvoke
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		public new System.Windows.Forms.DialogResult DialogResult {get;set;}
		public new System.Boolean AutoSize {get;set;}
		public new System.Drawing.Color BackColor {get;set;}
		public new System.Drawing.Image Image {get;set;}
		public new System.String Text {get;set;}
		public new System.Drawing.Rectangle Bounds {get;set;}
		public new System.Drawing.Rectangle ClientRectangle {get;set;}
		public new System.Drawing.Size ClientSize {get;set;}
		public new System.Boolean Enabled {get;set;}
		public new System.Boolean Focused {get;set;}
		public new System.Drawing.Font Font {get;set;}
		public new System.IntPtr Handle {get;set;}
		public new System.Int32 Height {get;set;}
		public new System.Drawing.Point Location {get;set;}
		public new System.String Name {get;set;}
		public new System.Drawing.Size Size {get;set;}
		public new System.Int32 TabIndex {get;set;}
		public new System.Object Tag {get;set;}
		public new System.Boolean Visible {get;set;}
		public new System.Int32 Width {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoSizeMode AutoSizeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoEllipsis {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatButtonAppearance FlatAppearance {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatStyle FlatStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.ContentAlignment ImageAlign {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ImageIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ImageKey {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageList ImageList {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImeMode ImeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.ContentAlignment TextAlign {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.TextImageRelation TextImageRelation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCompatibleTextRendering {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseMnemonic {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseVisualStyleBackColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleRole AccessibleRole {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AnchorStyles Anchor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageLayout BackgroundImageLayout {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DockStyle Dock {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.RightToLeft RightToLeft {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get;set;}
		#endregion
		#endregion
		#region Events
		public new System.EventHandler AutoSizeChanged { get;set;}
		public new System.EventHandler Click { get;set;}
		public new System.EventHandler GotFocus { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDoubleClick { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDown { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseMove { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseUp { get;set;}
		public new System.EventHandler SizeChanged { get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageLayoutChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BindingContextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CausesValidationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.UICuesEventHandler ChangeUICues { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ClientSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuStripChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlAdded { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlRemoved { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CursorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Disposed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DockChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DoubleClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragDrop { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DragLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragOver { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler EnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Enter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FontChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ForeColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleCreated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleDestroyed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HelpEventHandler HelpRequested { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ImeModeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.InvalidateEventHandler Invalidated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyPressEventHandler KeyPress { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyUp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.LayoutEventHandler Layout { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Leave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LocationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LostFocus { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MarginChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseCaptureChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseHover { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseWheel { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Move { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler PaddingChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ParentChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RegionChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Resize { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RightToLeftChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler StyleChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SystemColorsChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabStopChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Validated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.CancelEventHandler Validating { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler VisibleChanged { get;set;}
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class CheckBox : System.Windows.Forms.CheckBox,System.Windows.Forms.IBindableComponent,System.Windows.Forms.IDropTarget,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.ComponentModel.ISynchronizeInvoke
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		public new System.Boolean Checked {get;set;}
		public new System.Windows.Forms.CheckState CheckState {get;set;}
		public new System.Boolean ThreeState {get;set;}
		public new System.Boolean AutoSize {get;set;}
		public new System.Drawing.Color BackColor {get;set;}
		public new System.Drawing.Image Image {get;set;}
		public new System.String Text {get;set;}
		public new System.Drawing.Rectangle Bounds {get;set;}
		public new System.Drawing.Rectangle ClientRectangle {get;set;}
		public new System.Drawing.Size ClientSize {get;set;}
		public new System.Boolean Enabled {get;set;}
		public new System.Boolean Focused {get;set;}
		public new System.Drawing.Font Font {get;set;}
		public new System.IntPtr Handle {get;set;}
		public new System.Int32 Height {get;set;}
		public new System.Drawing.Point Location {get;set;}
		public new System.String Name {get;set;}
		public new System.Drawing.Size Size {get;set;}
		public new System.Int32 TabIndex {get;set;}
		public new System.Object Tag {get;set;}
		public new System.Boolean Visible {get;set;}
		public new System.Int32 Width {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Appearance Appearance {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoCheck {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.ContentAlignment CheckAlign {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.ContentAlignment TextAlign {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoEllipsis {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatButtonAppearance FlatAppearance {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatStyle FlatStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.ContentAlignment ImageAlign {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ImageIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ImageKey {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageList ImageList {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImeMode ImeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.TextImageRelation TextImageRelation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCompatibleTextRendering {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseMnemonic {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseVisualStyleBackColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleRole AccessibleRole {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AnchorStyles Anchor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageLayout BackgroundImageLayout {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DockStyle Dock {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.RightToLeft RightToLeft {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get;set;}
		#endregion
		#endregion
		#region Events
		public new System.EventHandler AutoSizeChanged { get;set;}
		public new System.EventHandler Click { get;set;}
		public new System.EventHandler GotFocus { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDoubleClick { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDown { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseMove { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseUp { get;set;}
		public new System.EventHandler SizeChanged { get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler AppearanceChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageLayoutChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BindingContextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CausesValidationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.UICuesEventHandler ChangeUICues { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CheckedChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CheckStateChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ClientSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuStripChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlAdded { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlRemoved { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CursorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Disposed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DockChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DoubleClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragDrop { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DragLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragOver { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler EnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Enter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FontChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ForeColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleCreated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleDestroyed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HelpEventHandler HelpRequested { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ImeModeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.InvalidateEventHandler Invalidated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyPressEventHandler KeyPress { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyUp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.LayoutEventHandler Layout { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Leave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LocationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LostFocus { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MarginChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseCaptureChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseHover { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseWheel { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Move { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler PaddingChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ParentChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RegionChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Resize { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RightToLeftChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler StyleChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SystemColorsChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabStopChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Validated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.CancelEventHandler Validating { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler VisibleChanged { get;set;}
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class CheckedListBox : System.Windows.Forms.CheckedListBox,System.Windows.Forms.IBindableComponent,System.Windows.Forms.IDropTarget,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.ComponentModel.ISynchronizeInvoke
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		public new System.Object DataSource {get;set;}
		public new System.String DisplayMember {get;set;}
		public new System.Windows.Forms.SelectionMode SelectionMode {get;set;}
		public new System.String ValueMember {get;set;}
		public new System.Drawing.Color BackColor {get;set;}
		public new System.Windows.Forms.BorderStyle BorderStyle {get;set;}
		public new System.Drawing.Rectangle Bounds {get;set;}
		public new System.Drawing.Rectangle ClientRectangle {get;set;}
		public new System.Drawing.Size ClientSize {get;set;}
		public new System.Boolean Focused {get;set;}
		public new System.IntPtr Handle {get;set;}
		public new System.Int32 Height {get;set;}
		public new System.Drawing.Point Location {get;set;}
		public new System.String Name {get;set;}
		public new System.Drawing.Size Size {get;set;}
		public new System.Object Tag {get;set;}
		public new System.Boolean Visible {get;set;}
		public new System.Int32 Width {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.CheckedListBox.CheckedIndexCollection CheckedIndices {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.CheckedListBox.CheckedItemCollection CheckedItems {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CheckOnClick {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DrawMode DrawMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ItemHeight {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.CheckedListBox.ObjectCollection Items {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ThreeDCheckBoxes {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCompatibleTextRendering {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageLayout BackgroundImageLayout {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ColumnWidth {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.IntegerCollection CustomTabOffsets {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Font Font {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 HorizontalExtent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HorizontalScrollbar {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IntegralHeight {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean MultiColumn {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.RightToLeft RightToLeft {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ScrollAlwaysVisible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectedIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.SelectedIndexCollection SelectedIndices {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object SelectedItem {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.SelectedObjectCollection SelectedItems {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Sorted {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Text {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TopIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCustomTabOffsets {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseTabStops {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IFormatProvider FormatInfo {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String FormatString {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean FormattingEnabled {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object SelectedValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleRole AccessibleRole {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AnchorStyles Anchor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DockStyle Dock {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Enabled {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImeMode ImeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TabIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get;set;}
		#endregion
		#endregion
		#region Events
		public new System.EventHandler AutoSizeChanged { get;set;}
		public new System.EventHandler GotFocus { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDoubleClick { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDown { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseMove { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseUp { get;set;}
		public new System.EventHandler SizeChanged { get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageLayoutChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BindingContextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CausesValidationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.UICuesEventHandler ChangeUICues { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Click { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ClientSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuStripChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlAdded { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlRemoved { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CursorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DataSourceChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DisplayMemberChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Disposed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DockChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DoubleClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragDrop { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DragLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragOver { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DrawItemEventHandler DrawItem { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler EnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Enter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FontChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ForeColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListControlConvertEventHandler Format { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FormatInfoChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FormatStringChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FormattingEnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleCreated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleDestroyed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HelpEventHandler HelpRequested { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ImeModeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.InvalidateEventHandler Invalidated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ItemCheckEventHandler ItemCheck { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyPressEventHandler KeyPress { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyUp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.LayoutEventHandler Layout { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Leave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LocationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LostFocus { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MarginChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MeasureItemEventHandler MeasureItem { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseCaptureChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseHover { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseWheel { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Move { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler PaddingChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ParentChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RegionChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Resize { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RightToLeftChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SelectedIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SelectedValueChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler StyleChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SystemColorsChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabStopChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Validated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.CancelEventHandler Validating { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ValueMemberChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler VisibleChanged { get;set;}
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class ComboBox : System.Windows.Forms.ComboBox,System.Windows.Forms.IBindableComponent,System.Windows.Forms.IDropTarget,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.ComponentModel.ISynchronizeInvoke
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		public new System.Drawing.Color BackColor {get;set;}
		public new System.Object DataSource {get;set;}
		public new System.Boolean Focused {get;set;}
		public new System.Int32 ItemHeight {get;set;}
		public new System.Int32 SelectedIndex {get;set;}
		public new System.Object SelectedItem {get;set;}
		public new System.String DisplayMember {get;set;}
		public new System.Object SelectedValue {get;set;}
		public new System.String ValueMember {get;set;}
		public new System.Drawing.Rectangle Bounds {get;set;}
		public new System.Drawing.Rectangle ClientRectangle {get;set;}
		public new System.Drawing.Size ClientSize {get;set;}
		public new System.Boolean Enabled {get;set;}
		public new System.Drawing.Font Font {get;set;}
		public new System.IntPtr Handle {get;set;}
		public new System.Int32 Height {get;set;}
		public new System.Drawing.Point Location {get;set;}
		public new System.String Name {get;set;}
		public new System.Drawing.Size Size {get;set;}
		public new System.Object Tag {get;set;}
		public new System.Boolean Visible {get;set;}
		public new System.Int32 Width {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoCompleteStringCollection AutoCompleteCustomSource {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoCompleteMode AutoCompleteMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoCompleteSource AutoCompleteSource {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageLayout BackgroundImageLayout {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DrawMode DrawMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DropDownHeight {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ComboBoxStyle DropDownStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DropDownWidth {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean DroppedDown {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatStyle FlatStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IntegralHeight {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ComboBox.ObjectCollection Items {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MaxDropDownItems {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MaxLength {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String SelectedText {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectionLength {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectionStart {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Sorted {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Text {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IFormatProvider FormatInfo {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String FormatString {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean FormattingEnabled {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleRole AccessibleRole {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AnchorStyles Anchor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DockStyle Dock {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImeMode ImeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.RightToLeft RightToLeft {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TabIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get;set;}
		#endregion
		#endregion
		#region Events
		public new System.EventHandler AutoSizeChanged { get;set;}
		public new System.EventHandler GotFocus { get;set;}
		public new System.Windows.Forms.KeyPressEventHandler KeyPress { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDoubleClick { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDown { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseMove { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseUp { get;set;}
		public new System.EventHandler SizeChanged { get;set;}
		public new System.EventHandler TextChanged { get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageLayoutChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BindingContextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CausesValidationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.UICuesEventHandler ChangeUICues { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Click { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ClientSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuStripChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlAdded { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlRemoved { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CursorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DataSourceChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DisplayMemberChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Disposed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DockChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DoubleClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragDrop { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DragLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragOver { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DrawItemEventHandler DrawItem { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DropDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DropDownClosed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DropDownStyleChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler EnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Enter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FontChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ForeColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListControlConvertEventHandler Format { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FormatInfoChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FormatStringChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FormattingEnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleCreated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleDestroyed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HelpEventHandler HelpRequested { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ImeModeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.InvalidateEventHandler Invalidated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyUp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.LayoutEventHandler Layout { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Leave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LocationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LostFocus { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MarginChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MeasureItemEventHandler MeasureItem { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseCaptureChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseHover { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseWheel { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Move { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler PaddingChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ParentChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RegionChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Resize { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RightToLeftChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SelectedIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SelectedValueChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SelectionChangeCommitted { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler StyleChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SystemColorsChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabStopChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TextUpdate { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Validated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.CancelEventHandler Validating { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ValueMemberChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler VisibleChanged { get;set;}
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class Control : System.Windows.Forms.Control,System.Windows.Forms.IBindableComponent,System.Windows.Forms.IDropTarget,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.ComponentModel.ISynchronizeInvoke
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
		public new System.Drawing.Color BackColor {get;set;}
		public new System.Drawing.Rectangle Bounds {get;set;}
		public new System.IntPtr Handle {get;set;}
		public new System.Drawing.Point Location {get;set;}
		public new System.Drawing.Size Size {get;set;}
		public new System.Object Tag {get;set;}
		public new System.Boolean Visible {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color DefaultBackColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Font DefaultFont {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color DefaultForeColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Keys ModifierKeys {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseButtons MouseButtons {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point MousePosition {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CheckForIllegalCrossThreadCalls {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleRole AccessibleRole {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AnchorStyles Anchor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageLayout BackgroundImageLayout {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ClientRectangle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size ClientSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DockStyle Dock {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Enabled {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Focused {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Font Font {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Height {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImeMode ImeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Name {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.RightToLeft RightToLeft {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TabIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Text {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Width {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get;set;}
		#endregion
		#endregion
		#region Events
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler AutoSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageLayoutChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BindingContextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CausesValidationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.UICuesEventHandler ChangeUICues { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Click { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ClientSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuStripChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlAdded { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlRemoved { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CursorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Disposed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DockChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DoubleClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragDrop { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DragLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragOver { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler EnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Enter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FontChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ForeColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler GotFocus { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleCreated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleDestroyed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HelpEventHandler HelpRequested { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ImeModeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.InvalidateEventHandler Invalidated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyPressEventHandler KeyPress { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyUp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.LayoutEventHandler Layout { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Leave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LocationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LostFocus { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MarginChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseCaptureChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseDoubleClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseHover { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseMove { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseUp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseWheel { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Move { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler PaddingChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ParentChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RegionChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Resize { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RightToLeftChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler StyleChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SystemColorsChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabStopChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Validated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.CancelEventHandler Validating { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler VisibleChanged { get;set;}
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class DataGridViewButtonCell : System.Windows.Forms.DataGridViewButtonCell,System.IDisposable,System.ICloneable
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		public new System.Object Tag {get;set;}
		public new System.Windows.Forms.DataGridViewElementStates State {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type EditType {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatStyle FlatStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type FormattedValueType {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseColumnTextForButtonValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type ValueType {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ColumnIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ContentBounds {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object DefaultNewRowValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Displayed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object EditedFormattedValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ErrorIconBounds {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ErrorText {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object FormattedValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Frozen {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewElementStates InheritedState {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle InheritedStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsInEditMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewColumn OwningColumn {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewRow OwningRow {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Resizable {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 RowIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selected {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size Size {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle Style {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ToolTipText {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Value {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridView DataGridView {get;set;}
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class DataGridViewButtonColumn : System.Windows.Forms.DataGridViewButtonColumn,System.IDisposable,System.ICloneable,System.ComponentModel.IComponent
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		public new System.Windows.Forms.DataGridViewColumnHeaderCell HeaderCell {get;set;}
		public new System.Int32 Width {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCell CellTemplate {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle DefaultCellStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatStyle FlatStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Text {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseColumnTextForButtonValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewAutoSizeColumnMode AutoSizeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type CellType {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String DataPropertyName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DisplayIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DividerWidth {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single FillWeight {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Frozen {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String HeaderText {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewAutoSizeColumnMode InheritedAutoSizeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle InheritedStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDataBound {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MinimumWidth {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Name {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewTriState Resizable {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewColumnSortMode SortMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ToolTipText {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type ValueType {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type DefaultHeaderCellType {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Displayed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasDefaultCellStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Index {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selected {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridView DataGridView {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewElementStates State {get;set;}
		#endregion
		#endregion
		#region Events
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Disposed { get;set;}
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class DataGridViewCheckBoxCell : System.Windows.Forms.DataGridViewCheckBoxCell,System.IDisposable,System.ICloneable,System.Windows.Forms.IDataGridViewEditingCell
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
		public new System.Object Tag {get;set;}
		public new System.Windows.Forms.DataGridViewElementStates State {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object EditingCellFormattedValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean EditingCellValueChanged {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type EditType {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object FalseValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatStyle FlatStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type FormattedValueType {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object IndeterminateValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ThreeState {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object TrueValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type ValueType {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ColumnIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ContentBounds {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object DefaultNewRowValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Displayed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object EditedFormattedValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle ErrorIconBounds {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ErrorText {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object FormattedValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Frozen {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewElementStates InheritedState {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle InheritedStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsInEditMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewColumn OwningColumn {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewRow OwningRow {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Resizable {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 RowIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selected {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size Size {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle Style {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ToolTipText {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Value {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridView DataGridView {get;set;}
		#endregion
		#endregion
		#region Events
		#region Excluded
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class DataGridViewCheckBoxColumn : System.Windows.Forms.DataGridViewCheckBoxColumn,System.IDisposable,System.ICloneable,System.ComponentModel.IComponent
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
		public new System.Windows.Forms.DataGridViewColumnHeaderCell HeaderCell {get;set;}
		public new System.Int32 Width {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCell CellTemplate {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle DefaultCellStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object FalseValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatStyle FlatStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object IndeterminateValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ThreeState {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object TrueValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewAutoSizeColumnMode AutoSizeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type CellType {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String DataPropertyName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DisplayIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 DividerWidth {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Single FillWeight {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Frozen {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String HeaderText {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewAutoSizeColumnMode InheritedAutoSizeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewCellStyle InheritedStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDataBound {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MinimumWidth {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Name {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewTriState Resizable {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewColumnSortMode SortMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ToolTipText {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type ValueType {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Type DefaultHeaderCellType {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Displayed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasDefaultCellStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Index {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Selected {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridView DataGridView {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DataGridViewElementStates State {get;set;}
		#endregion
		#endregion
		#region Events
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Disposed { get;set;}
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class Form : System.Windows.Forms.Form,System.Windows.Forms.IBindableComponent,System.Windows.Forms.IContainerControl,System.Windows.Forms.IDropTarget,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.ComponentModel.ISynchronizeInvoke
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		public new System.Drawing.Color BackColor {get;set;}
		public new System.Drawing.Size ClientSize {get;set;}
		public new System.Boolean MaximizeBox {get;set;}
		public new System.Windows.Forms.MainMenu Menu {get;set;}
		public new System.Boolean MinimizeBox {get;set;}
		public new System.Drawing.Size Size {get;set;}
		public new System.String Text {get;set;}
		public new System.Drawing.Point Location {get;set;}
		public new System.Drawing.Rectangle ClientRectangle {get;set;}
		public new System.Windows.Forms.Control.ControlCollection Controls {get;set;}
		public new System.IntPtr Handle {get;set;}
		public new System.Int32 Height {get;set;}
		public new System.String Name {get;set;}
		public new System.Int32 Width {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form ActiveForm {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IButtonControl AcceptButton {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowTransparency {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoScale {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScaleBaseSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoScroll {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoSizeMode AutoSizeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoValidate AutoValidate {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IButtonControl CancelButton {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ControlBox {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DesktopBounds {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point DesktopLocation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DialogResult DialogResult {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FormBorderStyle FormBorderStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HelpButton {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Icon Icon {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMdiChild {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMdiContainer {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form ActiveMdiChild {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsRestrictedWindow {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean KeyPreview {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MenuStrip MainMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form[] MdiChildren {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form MdiParent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MainMenu MergedMenu {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Modal {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Double Opacity {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form[] OwnedForms {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form Owner {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle RestoreBounds {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RightToLeftLayout {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowIcon {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShowInTaskbar {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.SizeGripStyle SizeGripStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FormStartPosition StartPosition {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TabIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TopLevel {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TopMost {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color TransparencyKey {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FormWindowState WindowState {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control ActiveControl {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF AutoScaleDimensions {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoScaleMode AutoScaleMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF CurrentAutoScaleDimensions {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form ParentForm {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScrollMargin {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScrollMinSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollPosition {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ScrollableControl.DockPaddingEdges DockPadding {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HScrollProperties HorizontalScroll {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.VScrollProperties VerticalScroll {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleRole AccessibleRole {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AnchorStyles Anchor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageLayout BackgroundImageLayout {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle Bounds {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DockStyle Dock {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Enabled {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Focused {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Font Font {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImeMode ImeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.RightToLeft RightToLeft {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object Tag {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Visible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get;set;}
		#endregion
		#endregion
		#region Events
		public new System.EventHandler AutoSizeChanged { get;set;}
		public new System.EventHandler AutoValidateChanged { get;set;}
		public new System.EventHandler GotFocus { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDoubleClick { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDown { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseMove { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseUp { get;set;}
		public new System.EventHandler SizeChanged { get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Activated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageLayoutChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BindingContextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CausesValidationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.UICuesEventHandler ChangeUICues { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Click { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ClientSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Closed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.CancelEventHandler Closing { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuStripChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlAdded { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlRemoved { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CursorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Deactivate { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Disposed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DockChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DoubleClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragDrop { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DragLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragOver { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler EnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Enter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FontChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ForeColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FormClosedEventHandler FormClosed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FormClosingEventHandler FormClosing { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleCreated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleDestroyed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.CancelEventHandler HelpButtonClicked { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HelpEventHandler HelpRequested { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ImeModeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.InputLanguageChangedEventHandler InputLanguageChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.InputLanguageChangingEventHandler InputLanguageChanging { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.InvalidateEventHandler Invalidated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyPressEventHandler KeyPress { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyUp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.LayoutEventHandler Layout { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Leave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Load { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LocationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LostFocus { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MarginChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MaximizedBoundsChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MaximumSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MdiChildActivate { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MenuComplete { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MenuStart { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MinimumSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseCaptureChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseHover { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseWheel { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Move { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler PaddingChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ParentChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RegionChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Resize { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ResizeBegin { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ResizeEnd { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RightToLeftChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RightToLeftLayoutChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ScrollEventHandler Scroll { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Shown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler StyleChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SystemColorsChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabStopChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Validated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.CancelEventHandler Validating { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler VisibleChanged { get;set;}
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class KeyEventArgs : System.Windows.Forms.KeyEventArgs
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
		public new System.Boolean Alt {get;set;}
		public new System.Boolean Control {get;set;}
		public new System.Boolean Handled {get;set;}
		public new System.Windows.Forms.Keys KeyCode {get;set;}
		public new System.Windows.Forms.Keys KeyData {get;set;}
		public new System.Int32 KeyValue {get;set;}
		public new System.Windows.Forms.Keys Modifiers {get;set;}
		public new System.Boolean Shift {get;set;}
		public new System.Boolean SuppressKeyPress {get;set;}
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
	
	public class KeyPressEventArgs : System.Windows.Forms.KeyPressEventArgs
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
		public new System.Boolean Handled {get;set;}
		public new System.Char KeyChar {get;set;}
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
	
	public class Label : System.Windows.Forms.Label,System.Windows.Forms.IBindableComponent,System.Windows.Forms.IDropTarget,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.ComponentModel.ISynchronizeInvoke
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		public new System.Boolean AutoSize {get;set;}
		public new System.Windows.Forms.BorderStyle BorderStyle {get;set;}
		public new System.Drawing.ContentAlignment TextAlign {get;set;}
		public new System.String Text {get;set;}
		public new System.Windows.Forms.AnchorStyles Anchor {get;set;}
		public new System.Drawing.Color BackColor {get;set;}
		public new System.Drawing.Rectangle Bounds {get;set;}
		public new System.Drawing.Rectangle ClientRectangle {get;set;}
		public new System.Drawing.Size ClientSize {get;set;}
		public new System.Boolean Enabled {get;set;}
		public new System.Boolean Focused {get;set;}
		public new System.Drawing.Font Font {get;set;}
		public new System.IntPtr Handle {get;set;}
		public new System.Int32 Height {get;set;}
		public new System.Int32 Left {get;set;}
		public new System.Drawing.Point Location {get;set;}
		public new System.String Name {get;set;}
		public new System.Int32 Right {get;set;}
		public new System.Windows.Forms.RightToLeft RightToLeft {get;set;}
		public new System.Drawing.Size Size {get;set;}
		public new System.Int32 TabIndex {get;set;}
		public new System.Object Tag {get;set;}
		public new System.Int32 Top {get;set;}
		public new System.Boolean Visible {get;set;}
		public new System.Int32 Width {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoEllipsis {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageLayout BackgroundImageLayout {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.FlatStyle FlatStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image Image {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.ContentAlignment ImageAlign {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ImageIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ImageKey {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageList ImageList {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImeMode ImeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredWidth {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseMnemonic {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCompatibleTextRendering {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleRole AccessibleRole {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DockStyle Dock {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get;set;}
		#endregion
		#endregion
		#region Events
		public new System.EventHandler AutoSizeChanged { get;set;}
		public new System.EventHandler GotFocus { get;set;}
		public new System.Windows.Forms.KeyPressEventHandler KeyPress { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDoubleClick { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDown { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseMove { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseUp { get;set;}
		public new System.EventHandler SizeChanged { get;set;}
		public new System.EventHandler TextChanged { get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageLayoutChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BindingContextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CausesValidationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.UICuesEventHandler ChangeUICues { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Click { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ClientSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuStripChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlAdded { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlRemoved { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CursorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Disposed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DockChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DoubleClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragDrop { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DragLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragOver { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler EnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Enter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FontChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ForeColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleCreated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleDestroyed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HelpEventHandler HelpRequested { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ImeModeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.InvalidateEventHandler Invalidated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyUp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.LayoutEventHandler Layout { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Leave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LocationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LostFocus { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MarginChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseCaptureChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseHover { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseWheel { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Move { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler PaddingChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ParentChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RegionChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Resize { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RightToLeftChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler StyleChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SystemColorsChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabStopChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TextAlignChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Validated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.CancelEventHandler Validating { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler VisibleChanged { get;set;}
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class ListBox : System.Windows.Forms.ListBox,System.Windows.Forms.IBindableComponent,System.Windows.Forms.IDropTarget,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.ComponentModel.ISynchronizeInvoke
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
		public new System.Drawing.Color BackColor {get;set;}
		public new System.Windows.Forms.BorderStyle BorderStyle {get;set;}
		public new System.Windows.Forms.SelectionMode SelectionMode {get;set;}
		public new System.Object DataSource {get;set;}
		public new System.String DisplayMember {get;set;}
		public new System.String ValueMember {get;set;}
		public new System.Drawing.Rectangle Bounds {get;set;}
		public new System.Drawing.Rectangle ClientRectangle {get;set;}
		public new System.Drawing.Size ClientSize {get;set;}
		public new System.Boolean Focused {get;set;}
		public new System.IntPtr Handle {get;set;}
		public new System.Int32 Height {get;set;}
		public new System.Drawing.Point Location {get;set;}
		public new System.String Name {get;set;}
		public new System.Drawing.Size Size {get;set;}
		public new System.Object Tag {get;set;}
		public new System.Boolean Visible {get;set;}
		public new System.Int32 Width {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageLayout BackgroundImageLayout {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ColumnWidth {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.IntegerCollection CustomTabOffsets {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DrawMode DrawMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Font Font {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 HorizontalExtent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HorizontalScrollbar {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IntegralHeight {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 ItemHeight {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.ObjectCollection Items {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean MultiColumn {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.RightToLeft RightToLeft {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ScrollAlwaysVisible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectedIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.SelectedIndexCollection SelectedIndices {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object SelectedItem {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListBox.SelectedObjectCollection SelectedItems {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Sorted {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Text {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TopIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseCustomTabOffsets {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseTabStops {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.IFormatProvider FormatInfo {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String FormatString {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean FormattingEnabled {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Object SelectedValue {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleRole AccessibleRole {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AnchorStyles Anchor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DockStyle Dock {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Enabled {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImeMode ImeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TabIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get;set;}
		#endregion
		#endregion
		#region Events
		public new System.EventHandler AutoSizeChanged { get;set;}
		public new System.EventHandler GotFocus { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDoubleClick { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDown { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseMove { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseUp { get;set;}
		public new System.EventHandler SizeChanged { get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageLayoutChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BindingContextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CausesValidationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.UICuesEventHandler ChangeUICues { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Click { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ClientSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuStripChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlAdded { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlRemoved { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CursorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DataSourceChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DisplayMemberChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Disposed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DockChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DoubleClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragDrop { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DragLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragOver { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DrawItemEventHandler DrawItem { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler EnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Enter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FontChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ForeColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ListControlConvertEventHandler Format { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FormatInfoChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FormatStringChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FormattingEnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleCreated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleDestroyed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HelpEventHandler HelpRequested { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ImeModeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.InvalidateEventHandler Invalidated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyPressEventHandler KeyPress { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyUp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.LayoutEventHandler Layout { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Leave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LocationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LostFocus { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MarginChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MeasureItemEventHandler MeasureItem { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseCaptureChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseHover { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseWheel { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Move { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler PaddingChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ParentChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RegionChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Resize { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RightToLeftChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SelectedIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SelectedValueChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler StyleChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SystemColorsChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabStopChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Validated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.CancelEventHandler Validating { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ValueMemberChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler VisibleChanged { get;set;}
		#endregion
		#endregion
		#region Excluded Methods
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
	
	public class MouseEventArgs : System.Windows.Forms.MouseEventArgs
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
		public new System.Windows.Forms.MouseButtons Button {get;set;}
		public new System.Int32 Clicks {get;set;}
		public new System.Int32 Delta {get;set;}
		public new System.Int32 X {get;set;}
		public new System.Int32 Y {get;set;}
		public new System.Drawing.Point Location {get;set;}
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
	
	public class PaintEventArgs : System.Windows.Forms.PaintEventArgs,System.IDisposable
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
		public new System.Drawing.Rectangle ClipRectangle {get;set;}
		public new System.Drawing.Graphics Graphics {get;set;}
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
	
	public class TextBox : System.Windows.Forms.TextBox,System.Windows.Forms.IBindableComponent,System.Windows.Forms.IDropTarget,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.ComponentModel.ISynchronizeInvoke
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		public new System.String Text {get;set;}
		public new System.Windows.Forms.HorizontalAlignment TextAlign {get;set;}
		public new System.Drawing.Color BackColor {get;set;}
		public new System.Windows.Forms.BorderStyle BorderStyle {get;set;}
		public new System.Windows.Forms.AnchorStyles Anchor {get;set;}
		public new System.Drawing.Rectangle Bounds {get;set;}
		public new System.Drawing.Rectangle ClientRectangle {get;set;}
		public new System.Drawing.Size ClientSize {get;set;}
		public new System.Boolean Enabled {get;set;}
		public new System.Boolean Focused {get;set;}
		public new System.Drawing.Font Font {get;set;}
		public new System.IntPtr Handle {get;set;}
		public new System.Int32 Height {get;set;}
		public new System.Int32 Left {get;set;}
		public new System.Drawing.Point Location {get;set;}
		public new System.String Name {get;set;}
		public new System.Int32 Right {get;set;}
		public new System.Windows.Forms.RightToLeft RightToLeft {get;set;}
		public new System.Drawing.Size Size {get;set;}
		public new System.Int32 TabIndex {get;set;}
		public new System.Object Tag {get;set;}
		public new System.Int32 Top {get;set;}
		public new System.Boolean Visible {get;set;}
		public new System.Int32 Width {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoCompleteStringCollection AutoCompleteCustomSource {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoCompleteMode AutoCompleteMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoCompleteSource AutoCompleteSource {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseSystemPasswordChar {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AcceptsReturn {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.CharacterCasing CharacterCasing {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Char PasswordChar {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ScrollBars ScrollBars {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Multiline {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AcceptsTab {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanUndo {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HideSelection {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String[] Lines {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 MaxLength {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Modified {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 PreferredHeight {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ReadOnly {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String SelectedText {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectionLength {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 SelectionStart {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ShortcutsEnabled {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TextLength {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean WordWrap {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageLayout BackgroundImageLayout {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleRole AccessibleRole {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DockStyle Dock {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImeMode ImeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get;set;}
		#endregion
		#endregion
		#region Events
		public new System.EventHandler AutoSizeChanged { get;set;}
		public new System.EventHandler GotFocus { get;set;}
		public new System.Windows.Forms.KeyPressEventHandler KeyPress { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDoubleClick { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDown { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseMove { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseUp { get;set;}
		public new System.EventHandler SizeChanged { get;set;}
		public new System.EventHandler TextChanged { get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler AcceptsTabChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageLayoutChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BindingContextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BorderStyleChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CausesValidationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.UICuesEventHandler ChangeUICues { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Click { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ClientSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuStripChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlAdded { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlRemoved { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CursorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Disposed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DockChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DoubleClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragDrop { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DragLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragOver { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler EnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Enter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FontChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ForeColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleCreated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleDestroyed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HelpEventHandler HelpRequested { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HideSelectionChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ImeModeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.InvalidateEventHandler Invalidated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyUp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.LayoutEventHandler Layout { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Leave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LocationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LostFocus { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MarginChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ModifiedChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseCaptureChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseHover { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseWheel { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Move { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MultilineChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler PaddingChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ParentChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ReadOnlyChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RegionChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Resize { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RightToLeftChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler StyleChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SystemColorsChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabStopChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TextAlignChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Validated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.CancelEventHandler Validating { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler VisibleChanged { get;set;}
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class TrackBar : System.Windows.Forms.TrackBar,System.Windows.Forms.IBindableComponent,System.Windows.Forms.IDropTarget,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.ComponentModel.ISupportInitialize,System.ComponentModel.ISynchronizeInvoke
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		public new System.Drawing.Font Font {get;set;}
		public new System.Int32 LargeChange {get;set;}
		public new System.Int32 Maximum {get;set;}
		public new System.Int32 Minimum {get;set;}
		public new System.Int32 SmallChange {get;set;}
		public new System.Int32 TickFrequency {get;set;}
		public new System.Int32 Value {get;set;}
		public new System.Drawing.Color BackColor {get;set;}
		public new System.Drawing.Rectangle Bounds {get;set;}
		public new System.Drawing.Rectangle ClientRectangle {get;set;}
		public new System.Drawing.Size ClientSize {get;set;}
		public new System.Boolean Enabled {get;set;}
		public new System.Boolean Focused {get;set;}
		public new System.IntPtr Handle {get;set;}
		public new System.Int32 Height {get;set;}
		public new System.Drawing.Point Location {get;set;}
		public new System.String Name {get;set;}
		public new System.Drawing.Size Size {get;set;}
		public new System.Object Tag {get;set;}
		public new System.Boolean Visible {get;set;}
		public new System.Int32 Width {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageLayout BackgroundImageLayout {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImeMode ImeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Orientation Orientation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RightToLeftLayout {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String Text {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.TickStyle TickStyle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleRole AccessibleRole {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AnchorStyles Anchor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control.ControlCollection Controls {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DockStyle Dock {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.RightToLeft RightToLeft {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TabIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get;set;}
		#endregion
		#endregion
		#region Events
		public new System.EventHandler AutoSizeChanged { get;set;}
		public new System.EventHandler GotFocus { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDoubleClick { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDown { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseMove { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseUp { get;set;}
		public new System.EventHandler SizeChanged { get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageLayoutChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BindingContextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CausesValidationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.UICuesEventHandler ChangeUICues { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Click { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ClientSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuStripChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlAdded { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlRemoved { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CursorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Disposed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DockChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DoubleClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragDrop { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DragLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragOver { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler EnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Enter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FontChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ForeColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleCreated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleDestroyed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HelpEventHandler HelpRequested { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ImeModeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.InvalidateEventHandler Invalidated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyPressEventHandler KeyPress { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyUp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.LayoutEventHandler Layout { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Leave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LocationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LostFocus { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MarginChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseCaptureChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseHover { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseWheel { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Move { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler PaddingChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ParentChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RegionChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Resize { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RightToLeftChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RightToLeftLayoutChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Scroll { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler StyleChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SystemColorsChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabStopChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Validated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.CancelEventHandler Validating { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ValueChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler VisibleChanged { get;set;}
		#endregion
		#endregion
		#region Excluded Methods
		#endregion
	}
	
	public class UserControl : System.Windows.Forms.UserControl,System.Windows.Forms.IBindableComponent,System.Windows.Forms.IContainerControl,System.Windows.Forms.IDropTarget,System.IDisposable,System.Windows.Forms.IWin32Window,System.ComponentModel.IComponent,System.ComponentModel.ISynchronizeInvoke
	{
		#region Constructors
		#endregion
		#region Fields
		#region Exluded
		#endregion
		#endregion
		#region Properties
		public new System.String Text {get;set;}
		public new System.Windows.Forms.BorderStyle BorderStyle {get;set;}
		public new System.Drawing.Color BackColor {get;set;}
		public new System.Drawing.Rectangle Bounds {get;set;}
		public new System.Drawing.Rectangle ClientRectangle {get;set;}
		public new System.Drawing.Size ClientSize {get;set;}
		public new System.Windows.Forms.Control.ControlCollection Controls {get;set;}
		public new System.Boolean Enabled {get;set;}
		public new System.Boolean Focused {get;set;}
		public new System.Drawing.Font Font {get;set;}
		public new System.IntPtr Handle {get;set;}
		public new System.Int32 Height {get;set;}
		public new System.Drawing.Point Location {get;set;}
		public new System.String Name {get;set;}
		public new System.Drawing.Size Size {get;set;}
		public new System.Object Tag {get;set;}
		public new System.Boolean Visible {get;set;}
		public new System.Int32 Width {get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoSizeMode AutoSizeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoValidate AutoValidate {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control ActiveControl {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF AutoScaleDimensions {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AutoScaleMode AutoScaleMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.BindingContext BindingContext {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.SizeF CurrentAutoScaleDimensions {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Form ParentForm {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AutoScroll {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScrollMargin {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size AutoScrollMinSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollPosition {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Rectangle DisplayRectangle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ScrollableControl.DockPaddingEdges DockPadding {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HScrollProperties HorizontalScroll {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.VScrollProperties VerticalScroll {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleObject AccessibilityObject {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDefaultActionDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleDescription {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String AccessibleName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AccessibleRole AccessibleRole {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean AllowDrop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.AnchorStyles Anchor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Point AutoScrollOffset {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MaximumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size MinimumSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Image BackgroundImage {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImageLayout BackgroundImageLayout {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Bottom {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CanSelect {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Capture {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean CausesValidation {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String CompanyName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean ContainsFocus {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenu ContextMenu {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Created {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Cursor Cursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlBindingsCollection DataBindings {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean Disposing {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DockStyle Dock {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Color ForeColor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean HasChildren {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ImeMode ImeMode {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean InvokeRequired {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsAccessible {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsDisposed {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsHandleCreated {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean IsMirrored {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Layout.LayoutEngine LayoutEngine {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Left {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Margin {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Padding Padding {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control Parent {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Size PreferredSize {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductName {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.String ProductVersion {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean RecreatingHandle {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Drawing.Region Region {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Right {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.RightToLeft RightToLeft {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.ISite Site {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 TabIndex {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean TabStop {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Int32 Top {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.Control TopLevelControl {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Boolean UseWaitCursor {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.IWindowTarget WindowTarget {get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.IContainer Container {get;set;}
		#endregion
		#endregion
		#region Events
		public new System.EventHandler AutoSizeChanged { get;set;}
		public new System.EventHandler AutoValidateChanged { get;set;}
		public new System.EventHandler GotFocus { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDoubleClick { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseDown { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseMove { get;set;}
		public new System.Windows.Forms.MouseEventHandler MouseUp { get;set;}
		public new System.EventHandler SizeChanged { get;set;}
		#region Excluded
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BackgroundImageLayoutChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler BindingContextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CausesValidationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.UICuesEventHandler ChangeUICues { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Click { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ClientSizeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ContextMenuStripChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlAdded { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ControlEventHandler ControlRemoved { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler CursorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Disposed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DockChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DoubleClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragDrop { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler DragLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.DragEventHandler DragOver { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler EnabledChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Enter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler FontChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ForeColorChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleCreated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler HandleDestroyed { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.HelpEventHandler HelpRequested { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ImeModeChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.InvalidateEventHandler Invalidated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyPressEventHandler KeyPress { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.KeyEventHandler KeyUp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.LayoutEventHandler Layout { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Leave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Load { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LocationChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler LostFocus { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MarginChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseCaptureChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseClick { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseEnter { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseHover { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler MouseLeave { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.MouseEventHandler MouseWheel { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Move { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler PaddingChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PaintEventHandler Paint { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler ParentChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RegionChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Resize { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler RightToLeftChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.Windows.Forms.ScrollEventHandler Scroll { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler StyleChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler SystemColorsChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabIndexChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TabStopChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler TextChanged { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler Validated { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.ComponentModel.CancelEventHandler Validating { get;set;}
		[Obsolete("This method is not cross-platform compatible.", true)]
		public new System.EventHandler VisibleChanged { get;set;}
		#endregion
		#endregion
		#region Excluded Methods
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
}

