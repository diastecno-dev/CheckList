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
    }
}
