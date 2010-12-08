using System;
namespace Common.Forms
{
	public partial class Form : System.Windows.Forms.Form
	{
		public new Common.Forms.DialogResult ShowDialog()
		{
			return (Common.Forms.DialogResult)base.ShowDialog();	
		}
		public new Common.Forms.DialogResult ShowDialog(IWin32Window owner)
		{
			return (Common.Forms.DialogResult)base.ShowDialog(owner);	
		}
	}
}

