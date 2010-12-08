using System;
namespace Common.Forms
{
public enum DialogResult
	{
		None = System.Windows.Forms.DialogResult.None,
		OK = System.Windows.Forms.DialogResult.OK,
		Cancel = System.Windows.Forms.DialogResult.Cancel,
		Abort = System.Windows.Forms.DialogResult.Abort,
		Retry = System.Windows.Forms.DialogResult.Retry,
		Ignore = System.Windows.Forms.DialogResult.Ignore,
		Yes = System.Windows.Forms.DialogResult.Yes,
		No = System.Windows.Forms.DialogResult.No,
	}
	
	public enum AutoSizeMode
	{
		GrowAndShrink = System.Windows.Forms.AutoSizeMode.GrowAndShrink,
		GrowOnly = System.Windows.Forms.AutoSizeMode.GrowOnly,
	}
	
	public enum FlatStyle
	{
		Flat = System.Windows.Forms.FlatStyle.Flat,
		Popup = System.Windows.Forms.FlatStyle.Popup,
		Standard = System.Windows.Forms.FlatStyle.Standard,
	}
	
	public enum ContentAlignment
	{
		TopLeft = System.Drawing.ContentAlignment.TopLeft,
		TopCenter = System.Drawing.ContentAlignment.TopCenter,
		TopRight = System.Drawing.ContentAlignment.TopRight,
		MiddleLeft = System.Drawing.ContentAlignment.MiddleLeft,
		MiddleCenter = System.Drawing.ContentAlignment.MiddleCenter,
		MiddleRight = System.Drawing.ContentAlignment.MiddleRight,
		BottomLeft = System.Drawing.ContentAlignment.BottomLeft,
		BottomCenter = System.Drawing.ContentAlignment.BottomCenter,
		BottomRight = System.Drawing.ContentAlignment.BottomRight,
	}
	
	public enum ImeMode
	{
		NoControl = System.Windows.Forms.ImeMode.NoControl,
		On = System.Windows.Forms.ImeMode.On,
		Off = System.Windows.Forms.ImeMode.Off,
		Disable = System.Windows.Forms.ImeMode.Disable,
		Hiragana = System.Windows.Forms.ImeMode.Hiragana,
		Katakana = System.Windows.Forms.ImeMode.Katakana,
		KatakanaHalf = System.Windows.Forms.ImeMode.KatakanaHalf,
		AlphaFull = System.Windows.Forms.ImeMode.AlphaFull,
		Alpha = System.Windows.Forms.ImeMode.Alpha,
		HangulFull = System.Windows.Forms.ImeMode.HangulFull,
		Hangul = System.Windows.Forms.ImeMode.Hangul,
		Close = System.Windows.Forms.ImeMode.Close,
		OnHalf = System.Windows.Forms.ImeMode.OnHalf,
		Inherit = System.Windows.Forms.ImeMode.Inherit,
	}
	
	public enum TextImageRelation
	{
		Overlay = System.Windows.Forms.TextImageRelation.Overlay,
		ImageAboveText = System.Windows.Forms.TextImageRelation.ImageAboveText,
		TextAboveImage = System.Windows.Forms.TextImageRelation.TextAboveImage,
		ImageBeforeText = System.Windows.Forms.TextImageRelation.ImageBeforeText,
		TextBeforeImage = System.Windows.Forms.TextImageRelation.TextBeforeImage,
	}
	
	public enum AccessibleRole
	{
		None = System.Windows.Forms.AccessibleRole.None,
		TitleBar = System.Windows.Forms.AccessibleRole.TitleBar,
		MenuBar = System.Windows.Forms.AccessibleRole.MenuBar,
		ScrollBar = System.Windows.Forms.AccessibleRole.ScrollBar,
		Grip = System.Windows.Forms.AccessibleRole.Grip,
		Sound = System.Windows.Forms.AccessibleRole.Sound,
		Cursor = System.Windows.Forms.AccessibleRole.Cursor,
		Caret = System.Windows.Forms.AccessibleRole.Caret,
		Alert = System.Windows.Forms.AccessibleRole.Alert,
		Window = System.Windows.Forms.AccessibleRole.Window,
		Client = System.Windows.Forms.AccessibleRole.Client,
		MenuPopup = System.Windows.Forms.AccessibleRole.MenuPopup,
		MenuItem = System.Windows.Forms.AccessibleRole.MenuItem,
		ToolTip = System.Windows.Forms.AccessibleRole.ToolTip,
		Application = System.Windows.Forms.AccessibleRole.Application,
		Document = System.Windows.Forms.AccessibleRole.Document,
		Pane = System.Windows.Forms.AccessibleRole.Pane,
		Chart = System.Windows.Forms.AccessibleRole.Chart,
		Dialog = System.Windows.Forms.AccessibleRole.Dialog,
		Border = System.Windows.Forms.AccessibleRole.Border,
		Grouping = System.Windows.Forms.AccessibleRole.Grouping,
		Separator = System.Windows.Forms.AccessibleRole.Separator,
		ToolBar = System.Windows.Forms.AccessibleRole.ToolBar,
		StatusBar = System.Windows.Forms.AccessibleRole.StatusBar,
		Table = System.Windows.Forms.AccessibleRole.Table,
		ColumnHeader = System.Windows.Forms.AccessibleRole.ColumnHeader,
		RowHeader = System.Windows.Forms.AccessibleRole.RowHeader,
		Column = System.Windows.Forms.AccessibleRole.Column,
		Row = System.Windows.Forms.AccessibleRole.Row,
		Cell = System.Windows.Forms.AccessibleRole.Cell,
		Link = System.Windows.Forms.AccessibleRole.Link,
		HelpBalloon = System.Windows.Forms.AccessibleRole.HelpBalloon,
		Character = System.Windows.Forms.AccessibleRole.Character,
		List = System.Windows.Forms.AccessibleRole.List,
		ListItem = System.Windows.Forms.AccessibleRole.ListItem,
		Outline = System.Windows.Forms.AccessibleRole.Outline,
		OutlineItem = System.Windows.Forms.AccessibleRole.OutlineItem,
		PageTab = System.Windows.Forms.AccessibleRole.PageTab,
		PropertyPage = System.Windows.Forms.AccessibleRole.PropertyPage,
		Indicator = System.Windows.Forms.AccessibleRole.Indicator,
		Graphic = System.Windows.Forms.AccessibleRole.Graphic,
		StaticText = System.Windows.Forms.AccessibleRole.StaticText,
		Text = System.Windows.Forms.AccessibleRole.Text,
		PushButton = System.Windows.Forms.AccessibleRole.PushButton,
		CheckButton = System.Windows.Forms.AccessibleRole.CheckButton,
		RadioButton = System.Windows.Forms.AccessibleRole.RadioButton,
		ComboBox = System.Windows.Forms.AccessibleRole.ComboBox,
		DropList = System.Windows.Forms.AccessibleRole.DropList,
		ProgressBar = System.Windows.Forms.AccessibleRole.ProgressBar,
		Dial = System.Windows.Forms.AccessibleRole.Dial,
		HotkeyField = System.Windows.Forms.AccessibleRole.HotkeyField,
		Slider = System.Windows.Forms.AccessibleRole.Slider,
		SpinButton = System.Windows.Forms.AccessibleRole.SpinButton,
		Diagram = System.Windows.Forms.AccessibleRole.Diagram,
		Animation = System.Windows.Forms.AccessibleRole.Animation,
		Equation = System.Windows.Forms.AccessibleRole.Equation,
		ButtonDropDown = System.Windows.Forms.AccessibleRole.ButtonDropDown,
		ButtonMenu = System.Windows.Forms.AccessibleRole.ButtonMenu,
		ButtonDropDownGrid = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid,
		WhiteSpace = System.Windows.Forms.AccessibleRole.WhiteSpace,
		PageTabList = System.Windows.Forms.AccessibleRole.PageTabList,
		Clock = System.Windows.Forms.AccessibleRole.Clock,
		SplitButton = System.Windows.Forms.AccessibleRole.SplitButton,
		IpAddress = System.Windows.Forms.AccessibleRole.IpAddress,
		OutlineButton = System.Windows.Forms.AccessibleRole.OutlineButton,
		Default = System.Windows.Forms.AccessibleRole.Default,
	}
	
	public enum AnchorStyles
	{
		None = System.Windows.Forms.AnchorStyles.None,
		Top = System.Windows.Forms.AnchorStyles.Top,
		Bottom = System.Windows.Forms.AnchorStyles.Bottom,
		Left = System.Windows.Forms.AnchorStyles.Left,
		Right = System.Windows.Forms.AnchorStyles.Right,
	}
	
	public enum ImageLayout
	{
		None = System.Windows.Forms.ImageLayout.None,
		Tile = System.Windows.Forms.ImageLayout.Tile,
		Center = System.Windows.Forms.ImageLayout.Center,
		Stretch = System.Windows.Forms.ImageLayout.Stretch,
		Zoom = System.Windows.Forms.ImageLayout.Zoom,
	}
	
	public enum DockStyle
	{
		None = System.Windows.Forms.DockStyle.None,
		Top = System.Windows.Forms.DockStyle.Top,
		Bottom = System.Windows.Forms.DockStyle.Bottom,
		Left = System.Windows.Forms.DockStyle.Left,
		Right = System.Windows.Forms.DockStyle.Right,
		Fill = System.Windows.Forms.DockStyle.Fill,
	}
	
	public enum RightToLeft
	{
		No = System.Windows.Forms.RightToLeft.No,
		Yes = System.Windows.Forms.RightToLeft.Yes,
		Inherit = System.Windows.Forms.RightToLeft.Inherit,
	}
	
	public enum CheckState
	{
		Unchecked = System.Windows.Forms.CheckState.Unchecked,
		Checked = System.Windows.Forms.CheckState.Checked,
		Indeterminate = System.Windows.Forms.CheckState.Indeterminate,
	}
	
	public enum Appearance
	{
		Normal = System.Windows.Forms.Appearance.Normal,
		Button = System.Windows.Forms.Appearance.Button,
	}
	
	public enum SelectionMode
	{
		None = System.Windows.Forms.SelectionMode.None,
		One = System.Windows.Forms.SelectionMode.One,
		MultiSimple = System.Windows.Forms.SelectionMode.MultiSimple,
		MultiExtended = System.Windows.Forms.SelectionMode.MultiExtended,
	}
	
	public enum BorderStyle
	{
		None = System.Windows.Forms.BorderStyle.None,
		FixedSingle = System.Windows.Forms.BorderStyle.FixedSingle,
		Fixed3D = System.Windows.Forms.BorderStyle.Fixed3D,
	}
	
	public enum DrawMode
	{
		Normal = System.Windows.Forms.DrawMode.Normal,
		OwnerDrawFixed = System.Windows.Forms.DrawMode.OwnerDrawFixed,
		OwnerDrawVariable = System.Windows.Forms.DrawMode.OwnerDrawVariable,
	}
	
	public enum AutoCompleteMode
	{
		None = System.Windows.Forms.AutoCompleteMode.None,
		Suggest = System.Windows.Forms.AutoCompleteMode.Suggest,
		Append = System.Windows.Forms.AutoCompleteMode.Append,
		SuggestAppend = System.Windows.Forms.AutoCompleteMode.SuggestAppend,
	}
	
	public enum AutoCompleteSource
	{
		FileSystem = System.Windows.Forms.AutoCompleteSource.FileSystem,
		HistoryList = System.Windows.Forms.AutoCompleteSource.HistoryList,
		RecentlyUsedList = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList,
		AllUrl = System.Windows.Forms.AutoCompleteSource.AllUrl,
		AllSystemSources = System.Windows.Forms.AutoCompleteSource.AllSystemSources,
		FileSystemDirectories = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories,
		CustomSource = System.Windows.Forms.AutoCompleteSource.CustomSource,
		None = System.Windows.Forms.AutoCompleteSource.None,
		ListItems = System.Windows.Forms.AutoCompleteSource.ListItems,
	}
	
	public enum ComboBoxStyle
	{
		Simple = System.Windows.Forms.ComboBoxStyle.Simple,
		DropDown = System.Windows.Forms.ComboBoxStyle.DropDown,
		DropDownList = System.Windows.Forms.ComboBoxStyle.DropDownList,
	}
	
	
	public enum MouseButtons
	{
		None = System.Windows.Forms.MouseButtons.None,
		Left = System.Windows.Forms.MouseButtons.Left,
		Right = System.Windows.Forms.MouseButtons.Right,
		Middle = System.Windows.Forms.MouseButtons.Middle,
		XButton1 = System.Windows.Forms.MouseButtons.XButton1,
		XButton2 = System.Windows.Forms.MouseButtons.XButton2,
	}
	
	public enum DataGridViewElementStates
	{
		None = System.Windows.Forms.DataGridViewElementStates.None,
		Displayed = System.Windows.Forms.DataGridViewElementStates.Displayed,
		Frozen = System.Windows.Forms.DataGridViewElementStates.Frozen,
		ReadOnly = System.Windows.Forms.DataGridViewElementStates.ReadOnly,
		Resizable = System.Windows.Forms.DataGridViewElementStates.Resizable,
		ResizableSet = System.Windows.Forms.DataGridViewElementStates.ResizableSet,
		Selected = System.Windows.Forms.DataGridViewElementStates.Selected,
		Visible = System.Windows.Forms.DataGridViewElementStates.Visible,
	}
	
	public enum DataGridViewAutoSizeColumnMode
	{
		NotSet = System.Windows.Forms.DataGridViewAutoSizeColumnMode.NotSet,
		None = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None,
		ColumnHeader = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader,
		AllCellsExceptHeader = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader,
		AllCells = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells,
		DisplayedCellsExceptHeader = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader,
		DisplayedCells = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells,
		Fill = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill,
	}
	
	public enum DataGridViewTriState
	{
		NotSet = System.Windows.Forms.DataGridViewTriState.NotSet,
		True = System.Windows.Forms.DataGridViewTriState.True,
		False = System.Windows.Forms.DataGridViewTriState.False,
	}
	
	public enum DataGridViewColumnSortMode
	{
		NotSortable = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable,
		Automatic = System.Windows.Forms.DataGridViewColumnSortMode.Automatic,
		Programmatic = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic,
	}
	
	public enum AutoValidate
	{
		Disable = System.Windows.Forms.AutoValidate.Disable,
		EnablePreventFocusChange = System.Windows.Forms.AutoValidate.EnablePreventFocusChange,
		EnableAllowFocusChange = System.Windows.Forms.AutoValidate.EnableAllowFocusChange,
		Inherit = System.Windows.Forms.AutoValidate.Inherit,
	}
	
	public enum FormBorderStyle
	{
		None = System.Windows.Forms.FormBorderStyle.None,
		FixedSingle = System.Windows.Forms.FormBorderStyle.FixedSingle,
		Fixed3D = System.Windows.Forms.FormBorderStyle.Fixed3D,
		FixedDialog = System.Windows.Forms.FormBorderStyle.FixedDialog,
		Sizable = System.Windows.Forms.FormBorderStyle.Sizable,
		FixedToolWindow = System.Windows.Forms.FormBorderStyle.FixedToolWindow,
		SizableToolWindow = System.Windows.Forms.FormBorderStyle.SizableToolWindow,
	}
	
	public enum SizeGripStyle
	{
		Auto = System.Windows.Forms.SizeGripStyle.Auto,
		Show = System.Windows.Forms.SizeGripStyle.Show,
		Hide = System.Windows.Forms.SizeGripStyle.Hide,
	}
	
	public enum FormStartPosition
	{
		Manual = System.Windows.Forms.FormStartPosition.Manual,
		CenterScreen = System.Windows.Forms.FormStartPosition.CenterScreen,
		WindowsDefaultLocation = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation,
		WindowsDefaultBounds = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds,
		CenterParent = System.Windows.Forms.FormStartPosition.CenterParent,
	}
	
	public enum FormWindowState
	{
		Normal = System.Windows.Forms.FormWindowState.Normal,
		Minimized = System.Windows.Forms.FormWindowState.Minimized,
		Maximized = System.Windows.Forms.FormWindowState.Maximized,
	}
	
	public enum AutoScaleMode
	{
		None = System.Windows.Forms.AutoScaleMode.None,
		Font = System.Windows.Forms.AutoScaleMode.Font,
		Dpi = System.Windows.Forms.AutoScaleMode.Dpi,
		Inherit = System.Windows.Forms.AutoScaleMode.Inherit,
	}
	
	public enum HorizontalAlignment
	{
		Left = System.Windows.Forms.HorizontalAlignment.Left,
		Right = System.Windows.Forms.HorizontalAlignment.Right,
		Center = System.Windows.Forms.HorizontalAlignment.Center,
	}
	
	public enum CharacterCasing
	{
		Normal = System.Windows.Forms.CharacterCasing.Normal,
		Upper = System.Windows.Forms.CharacterCasing.Upper,
		Lower = System.Windows.Forms.CharacterCasing.Lower,
	}
	
	public enum ScrollBars
	{
		None = System.Windows.Forms.ScrollBars.None,
		Horizontal = System.Windows.Forms.ScrollBars.Horizontal,
		Vertical = System.Windows.Forms.ScrollBars.Vertical,
		Both = System.Windows.Forms.ScrollBars.Both,
	}
	
	public enum Orientation
	{
		Horizontal = System.Windows.Forms.Orientation.Horizontal,
		Vertical = System.Windows.Forms.Orientation.Vertical,
	}
	
	public enum TickStyle
	{
		None = System.Windows.Forms.TickStyle.None,
		TopLeft = System.Windows.Forms.TickStyle.TopLeft,
		BottomRight = System.Windows.Forms.TickStyle.BottomRight,
		Both = System.Windows.Forms.TickStyle.Both,
	}
	public enum MessageBoxButtons
	{
		OK = System.Windows.Forms.MessageBoxButtons.OK,
		OKCancel = System.Windows.Forms.MessageBoxButtons.OKCancel,
		AbortRetryIgnore = System.Windows.Forms.MessageBoxButtons.AbortRetryIgnore,
		YesNoCancel = System.Windows.Forms.MessageBoxButtons.YesNoCancel,
		YesNo = System.Windows.Forms.MessageBoxButtons.YesNo,
		RetryCancel = System.Windows.Forms.MessageBoxButtons.RetryCancel,
	}
	public enum MessageBoxIcon
	{
		None 		= System.Windows.Forms.MessageBoxIcon.None,
		Error 		= System.Windows.Forms.MessageBoxIcon.Error,
		Hand 		= System.Windows.Forms.MessageBoxIcon.Hand,
		Stop 		= System.Windows.Forms.MessageBoxIcon.Stop,
		Question 	= System.Windows.Forms.MessageBoxIcon.Question,
		Exclamation 	= System.Windows.Forms.MessageBoxIcon.Exclamation,
		Warning 	= System.Windows.Forms.MessageBoxIcon.Warning,
		Asterisk 	= System.Windows.Forms.MessageBoxIcon.Asterisk,
		Information 	= System.Windows.Forms.MessageBoxIcon.Information,
	}
	public enum MessageBoxDefaultButton
	{
		Button1 = System.Windows.Forms.MessageBoxDefaultButton.Button1,
		Button2 = System.Windows.Forms.MessageBoxDefaultButton.Button2,
		Button3 = System.Windows.Forms.MessageBoxDefaultButton.Button3,
	}
}

