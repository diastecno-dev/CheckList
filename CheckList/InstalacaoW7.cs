using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList
{
    public partial class InstalacaoW7 : Form
    {
        public InstalacaoW7()
        {
            InitializeComponent();
        }

        private void InstalacaoW7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menuPrincipal = new Menu();
            menuPrincipal.Show();
            this.Close();
        }
    }
}
