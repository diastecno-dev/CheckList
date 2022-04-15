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
            Hide();          
            var instalacaoW7 = new InstalacaoW7(this);
            instalacaoW7.ShowDialog();           
        }

        private void btnW10_Click(object sender, EventArgs e)
        {
            var instalacaoW10 = new InstalacaoW10();
            instalacaoW10.Show();
        }
    }
}
