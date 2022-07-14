using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace CheckList
{
    public partial class InstalacaoW7 : Form
    {
        public InstalacaoW7()
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
                chkKlite.Checked = true;
                chkWinrar.Checked = true;
                chkAdobeReader.Checked = true;
                chkAtivador.Checked = true;
            }
            else
            {
                chkOffice.Checked = false;
                chkChrome.Checked = false;
                chkKlite.Checked = false;
                chkWinrar.Checked = false;
                chkAdobeReader.Checked = false;
                chkAtivador.Checked = false;
            }
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            Instalacoes();
        }

        private void Instalacoes()
        {
            InstalarOffice();
            InstalarChrome();
            InstalarKlite();
            InstalarWinrar();
            InstalarAdobeReader();
            //InstalarAtivador();

        }

        private void InstalarOffice()
        {
            if (chkOffice.Checked)
                new Instalacao().InstalarOffice();

        }

        private void InstalarChrome()
        {
            if (chkChrome.Checked)
                new Instalacao().InstalarChrome();
            var teste = "";
            do
            {
                _ = Process.GetProcessesByName("msiexec");
            } while (teste.Length != 0);
                                
        }
        private void InstalarKlite()
        {
            if (chkKlite.Checked)
                new Instalacao().InstalarKlite();

        }
        private void InstalarWinrar()
        {          
            if (chkWinrar.Checked)
                new Instalacao().InstalarWinrar();
        }

        private void InstalarAdobeReader()
        {
            if (chkAdobeReader.Checked)
                new Instalacao().InstalarAdobeReader();
        }
    }
}
