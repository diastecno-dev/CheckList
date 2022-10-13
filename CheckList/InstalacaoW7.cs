using System;
using System.IO;
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
            VerificarProgramasInstalados();

            VerificarBotaoInstalar();

            VerificarChkInstalarTodos();
        }

        private void VerificarProgramasInstalados()
        {
            VerificarOfficeInstalado();
            VerificarPdfInstalado();
            VerificarChromeInstalado();
            VerificarKliteInstalado();
            VerificarWinrarInstalado();
            VerificarAtivadorInstalado();
        }

        private void VerificarOfficeInstalado()
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Microsoft Office"))
                chkOffice.Checked = false;
            else
                chkOffice.Checked = true;
        }
        private void VerificarPdfInstalado()
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Adobe"))
                chkPDF.Checked = false;
            else
                chkPDF.Checked = true;
        }
        private void VerificarChromeInstalado()
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Google"))
                chkNavegador.Checked = false;
            else
                chkNavegador.Checked = true;
        }
        private void VerificarKliteInstalado()
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\K-Lite Codec Pack"))
                chkCodec.Checked = false;
            else
                chkCodec.Checked = true;
        }
        private void VerificarWinrarInstalado()
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\WinRAR"))
                chkWinrar.Checked = false;
            else
                chkWinrar.Checked = true;
        }
        private void VerificarAtivadorInstalado()
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\KMSpico"))
                chkAtivador.Checked = false;
            else
                chkAtivador.Checked = true;
        }

        private void chkInstalarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInstalarTodos.Checked)
            {
                chkOffice.Checked = true;
                chkNavegador.Checked = true;
                chkCodec.Checked = true;
                chkWinrar.Checked = true;
                chkPDF.Checked = true;
                chkAtivador.Checked = true;
            }
            else
            {
                chkOffice.Checked = false;
                chkNavegador.Checked = false;
                chkCodec.Checked = false;
                chkWinrar.Checked = false;
                chkPDF.Checked = false;
                chkAtivador.Checked = false;
            }
            VerificarBotaoInstalar();
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            if (chkAtivador.Checked)
                MessageBox.Show("Você tem antivirus? caso sim, desabilite o antivirus e depois click em OK", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (!backgroundWorkerInstalacao.IsBusy)
            {
                backgroundWorkerInstalacao.RunWorkerAsync();
                EstatosCheckbox();
            }

        }
        private void EstatosCheckbox()
        {

            if (backgroundWorkerInstalacao.IsBusy)
            {
                btnInstalar.Enabled = false;
                chkOffice.Enabled = false;
                chkNavegador.Enabled = false;
                chkCodec.Enabled = false;
                chkWinrar.Enabled = false;
                chkPDF.Enabled = false;
                chkAtivador.Enabled = false;
                chkInstalarTodos.Enabled = false;
                //((Menu)this.Parent).btnW7.Visible = false;
                //((Menu)this.Parent).btnW8.Visible = false;
                //((Menu)this.Parent).btnW10.Visible = false;
                //((Menu)this.Parent).btnInfo.Visible = false;
            }
            else
            {
                btnInstalar.Enabled = true;
                chkOffice.Enabled = true;
                chkPDF.Enabled = true;
                chkNavegador.Enabled = true;
                chkCodec.Enabled = true;
                chkWinrar.Enabled = true;
                chkAtivador.Enabled = true;
                chkInstalarTodos.Enabled = true;
                //((Menu)this.Parent).btnW7.Visible = true;
                //((Menu)this.Parent).btnW8.Visible = true;
                //((Menu)this.Parent).btnW10.Visible = true;
                //((Menu)this.Parent).btnInfo.Visible = true;
            }
        }

        private void Instalacoes()
        {

            if (chkOffice.Checked)
                new Instalacao().InstalarOffice("2010", "w7");
            if (chkOffice.Checked)
                new Instalacao().InstalarPDF("adobe", "w7");
            if (chkNavegador.Checked)
                new Instalacao().InstalarNavegador("chrome", "w7");
            if (chkCodec.Checked)
                new Instalacao().InstalarCodec("klite", "w7");
            if (chkWinrar.Checked)
                new Instalacao().InstalarWinrar("winrar", "w7");
            if (chkAtivador.Checked)
                new Instalacao().InstalarAtivador("kmsPico", "w7");
        }

        private void VerificarBotaoInstalar()
        {
            if (!chkOffice.Checked &&
                !chkNavegador.Checked &&
                !chkCodec.Checked &&
                !chkWinrar.Checked &&
                !chkAtivador.Checked &&
                !chkPDF.Checked)
                btnInstalar.Enabled = false;
            else
                btnInstalar.Enabled = true;
        }
        private void VerificarChkInstalarTodos()
        {
            if (!chkOffice.Checked ||
                !chkPDF.Checked ||
                !chkNavegador.Checked ||
                !chkCodec.Checked ||
                !chkWinrar.Checked ||
                !chkAtivador.Checked)
                chkInstalarTodos.Checked = false;
            else
                chkInstalarTodos.Checked = true;
        }
        private void backgroundWorkerInstalacao_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Instalacoes();
        }

        private void backgroundWorkerInstalacao_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            EstatosCheckbox();
            MessageBox.Show("Instalação concluida", "Instalação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
