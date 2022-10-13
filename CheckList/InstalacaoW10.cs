using System;
using System.IO;
using System.Windows.Forms;


namespace CheckList
{
    public partial class InstalacaoW10 : Form
    {
        private readonly Menu _formMenu;

        public InstalacaoW10(Menu formMenu)
        {
            InitializeComponent();
            _formMenu = formMenu;
        }

        private void ChkInstalarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInstalarTodos.Checked)
            {
                chkOffice.Checked = true;
                chkNavegador.Checked = true;
                chkCodec.Checked = true;
                chkWinrar.Checked = true;
                chkAtivador.Checked = true;
            }
            else
            {
                chkOffice.Checked = false;
                chkNavegador.Checked = false;
                chkCodec.Checked = false;
                chkWinrar.Checked = false;
                chkAtivador.Checked = false;
            }
            VerificarBotaoInstalar();
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            if (chkAtivador.Checked)
                MessageBox.Show("Desabilite o antivirus e depois click em OK", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                chkAtivador.Enabled = false;
                chkInstalarTodos.Enabled = false;              
                _formMenu.btnW7.Enabled = false;
                _formMenu.btnW10.Enabled = false;
                //((Menu)this.Parent).btnW7.Visible = false;
                //((Menu)this.Parent).btnW8.Visible = false;
                //((Menu)this.Parent).btnW10.Visible = false;
                //((Menu)this.Parent).btnInfo.Visible = false;
            }
            else
            {
                btnInstalar.Enabled = true;
                chkOffice.Enabled = true;
                chkNavegador.Enabled = true;
                chkCodec.Enabled = true;
                chkWinrar.Enabled = true;
                chkAtivador.Enabled = true;
                chkInstalarTodos.Enabled = true;
                _formMenu.btnW7.Enabled = true;
                //((Menu)this.Parent).btnW7.Visible = true;
                //((Menu)this.Parent).btnW8.Visible = true;
                //((Menu)this.Parent).btnW10.Visible = true;
                //((Menu)this.Parent).btnInfo.Visible = true;
            }
        }

        private void Instalacoes()
        {
            InstalacaoW10 formWin10 = (InstalacaoW10)Application.OpenForms["InstalacaoW10"];

            if (chkOffice.Checked)
                new Instalacao().InstalarOffice("2013","w10");
            if (chkNavegador.Checked)
                new Instalacao().InstalarNavegador("chrome","w10");
            if (chkCodec.Checked)
                new Instalacao().InstalarCodec("klite","w10");
            if (chkWinrar.Checked)
                new Instalacao(formWin10).InstalarWinrar("winrar","w10");
            if (chkAtivador.Checked)
                new Instalacao().InstalarAtivador("kmsPico","w10");

        }

       

        private void InstalacaoW10_Load(object sender, EventArgs e)
        {

            VerificarProgramasInstalados();

            VerificarBotaoInstalar();

            VerificarChkInstalarTodos();


        }

        private void VerificarBotaoInstalar()
        {
            if (!chkOffice.Checked &&
                !chkNavegador.Checked &&
                !chkCodec.Checked &&
                !chkWinrar.Checked &&
                !chkAtivador.Checked)
                btnInstalar.Enabled = false;
            else
                btnInstalar.Enabled = true;
        }
        private void VerificarChkInstalarTodos()
        {
            if (!chkOffice.Checked ||
                !chkNavegador.Checked ||
                !chkCodec.Checked ||
                !chkWinrar.Checked ||
                !chkAtivador.Checked)
                chkInstalarTodos.Checked = false;
            else
                chkInstalarTodos.Checked = true;
        }

        private void VerificarProgramasInstalados()
        {
            VerificarOfficeInstalado();
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
        private void ChkWinrar_CheckedChanged(object sender, EventArgs e)
        {
            VerificarBotaoInstalar();
        }

        private void chkOffice_CheckedChanged(object sender, EventArgs e)
        {
            VerificarBotaoInstalar();
        }

        private void chkChrome_CheckedChanged(object sender, EventArgs e)
        {
            VerificarBotaoInstalar();
        }

        private void chkCodec_CheckedChanged(object sender, EventArgs e)
        {
            VerificarBotaoInstalar();
        }

        private void chkAtivador_CheckedChanged(object sender, EventArgs e)
        {
            VerificarBotaoInstalar();
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
