using System;
using System.Windows.Forms;

namespace CheckList
{
    public partial class InstalacaoW8 : Form
    {
        public InstalacaoW8()
        {
            InitializeComponent();
        }

        private void chkInstalarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInstalarTodos.Checked)
            {
                chkOffice.Checked = true;
                chkChrome.Checked = true;
                chkCodec.Checked = true;
                chkWinrar.Checked = true;
                chkAtivador.Checked = true;
                chkMenuWindows7.Checked = true;
            }
            else
            {
                chkOffice.Checked = false;
                chkChrome.Checked = false;
                chkCodec.Checked = false;
                chkWinrar.Checked = false;
                chkAtivador.Checked = false;
                chkMenuWindows7.Checked = false;
            }
        }
    }
}
