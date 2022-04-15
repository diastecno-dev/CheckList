using System;
using System.Windows.Forms;

namespace CheckList
{
    public partial class InstalacaoW7 : Form
    {
        public Menu Menu { get; set; }

        public InstalacaoW7(Menu menu)
        {
            InitializeComponent();
            Menu = menu;
        }
        

        private void btnVoltar_Click(object sender, EventArgs e)
        {            
            Close();
            Menu.Visible = true;
            
        }
    }
}
