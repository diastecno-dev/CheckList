using System;
using System.Drawing;
using System.Windows.Forms;

namespace CheckList
{
    public partial class Menu : Form
    {
        private Form frmAtivo;
        public Menu()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            pnlForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        { 
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        private void ActiveButton(Button frmAtivo)
        {

            foreach (Control ctrl in pnlMenu.Controls)
                ctrl.ForeColor = Color.Black;

            frmAtivo.ForeColor = Color.White;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var menuPrincipal = new Menu();
            menuPrincipal.Show();

            //this.Close();
        }

        private void btnW8_Click(object sender, EventArgs e)
        {
            ActiveButton(btnW8);
            var formW8 = new InstalacaoW8();
            FormShow(formW8);
        }

        private void btnW7_Click(object sender, EventArgs e)
        {
            ActiveButton(btnW7);
            var formW7 = new InstalacaoW7();
            FormShow(formW7);
        }

        private void btnW10_Click(object sender, EventArgs e)
        {
            ActiveButton(btnW10);
            var formW10 = new InstalacaoW10();
            FormShow(formW10);
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
