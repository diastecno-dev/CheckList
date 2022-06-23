using System;
using System.Windows.Forms;

namespace CheckList
{
    public partial class InstalacaoW10 : Form
    {
        public InstalacaoW10()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var menuPrincipal = new Menu();
            menuPrincipal.Show();

            this.Close();
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
            }
            else
            {
                chkOffice.Checked = false;
                chkChrome.Checked = false;
                chkCodec.Checked = false;
                chkWinrar.Checked = false;
                chkAtivador.Checked = false;
            }
        }
    }
}
