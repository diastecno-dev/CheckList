using System;
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

        //private void ActiveButton(Button frmAtivo)
        //{

        //    foreach (Control ctrl in pnlMenu.Controls)
        //        ctrl.ForeColor = Color.White;

        //    frmAtivo.ForeColor = Color.Red;
        //}           

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnW8_Click(object sender, EventArgs e)
        {
            // ActiveButton(btnW8);
            var formW8 = new InstalacaoW10();
            FormShow(formW8);
        }
    }
}
