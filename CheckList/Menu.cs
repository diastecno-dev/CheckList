using System;
using System.Windows.Forms;

namespace CheckList
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnW7_Click(object sender, EventArgs e)
        {
            var instalacaoW7 = new InstalacaoW7();
            instalacaoW7.Show();
           


           
        }

        private void btnW10_Click(object sender, EventArgs e)
        {
            var instalacaoW10 = new InstalacaoW10();
            instalacaoW10.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnW7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
