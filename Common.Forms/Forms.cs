using System;
namespace Common.Forms
{
	public partial class Forms : System.Windows.Forms.Form
	{
		public new DialogResult ShowDialog()
		{
			return (DialogResult)base.ShowDialog();	
		}
		public new DialogResult ShowDialog(IWin32Window owner)
		{
			return (DialogResult)base.ShowDialog(owner);	
		}
	}
}

