using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Windows.Forms;

namespace CheckList
{
    public class Instalacao
    {
        private Menu menu;
        private InstalacaoW7 instalacaoW7;
        private InstalacaoW8 instalacaoW8;
        private InstalacaoW10 instalacaoW10;

        public Instalacao(Menu menu)
        {
            this.menu = menu;
        }
        public Instalacao(InstalacaoW7 instalacaoW7)
        {
            this.instalacaoW7 = instalacaoW7;
        }
        public Instalacao(InstalacaoW8 instalacaoW8)
        {
            this.instalacaoW8 = instalacaoW8;
        }
        public Instalacao(InstalacaoW10 instalacaoW10)
        {
            this.instalacaoW10 = instalacaoW10;
        }

        public Instalacao()
        {
        }

        public void InstalarOffice(string versao, string windows)
        {

            switch (versao)
            {
                case "2010":

                    InversaoChkOffice(windows, true);

                    new Parametros().InstalarOffice7();
                    Thread.Sleep(3000);

                    while (Process.GetProcessesByName("setup").Length != 0)
                    {
                        //int cont = 0;
                        //Thread.Sleep(3000);
                        //cont += 1;
                    }

                    if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + @"\Programs\Microsoft Office 2010"))
                    {
                        File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + @"\Programs\Microsoft Office 2010\Word 2010.lnk", Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + @"\Word.lnk", true);
                        File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + @"\Programs\Microsoft Office 2010\Excel 2010.lnk", Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + @"\Excel.lnk", true);
                        File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + @"\Programs\Microsoft Office 2010\PowerPoint 2010.lnk", Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + @"\PowerPoint.lnk", true);
                    }

                    InversaoChkOffice(windows, false);

                    break;

                case "2013":

                    InversaoChkOffice(windows, true);

                    new Parametros().InstalarOffice10();
                    Thread.Sleep(3000);



                    while (Process.GetProcessesByName("setup").Length != 0)
                    {

                    }
                    if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + @"\Programs\Microsoft Office 2013"))
                    {
                        File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + @"\Programs\Microsoft Office 2013\Word 2013.lnk", Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + @"\Word.lnk", true);
                        File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + @"\Programs\Microsoft Office 2013\Excel 2013.lnk", Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + @"\Excel.lnk", true);
                        File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + @"\Programs\Microsoft Office 2013\PowerPoint 2013.lnk", Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + @"\PowerPoint.lnk", true);
                    }

                    InversaoChkOffice(windows, false);


                    break;

                default:

                    MessageBox.Show("Office foi selecionado porem sem escolha de versão");
                    break;
            }

        }


        public void InstalarNavegador(string navegador, string windows)
        {
            switch (navegador)
            {
                case "chrome":

                    InversaoChkNavegador(windows, true);

                    new Parametros().InstalarChrome();
                    Thread.Sleep(3000);


                    while (Process.GetProcessesByName("setup").Length != 0)
                    {

                    }
                    InversaoChkNavegador(windows, false);

                    break;

                default:

                    MessageBox.Show("Navegador foi selecionado porém sem escolha de versão");
                    break;

            }

        }

        public void InstalarCodec(string codec, string windows)
        {
            switch (codec)
            {
                case "klite":

                    InversaoChkCodec(windows, true);

                    new Parametros().InstalarKlite10();
                    Thread.Sleep(3000);



                    while (Process.GetProcessesByName("klitecodec").Length != 0)
                    {

                    }
                    InversaoChkCodec(windows, false);

                    break;

                default:

                    MessageBox.Show("Codec foi selecionado porem sem escolha de versão");
                    break;
            }


        }
        public void InstalarWinrar(string compactador, string windows)
        {
            switch (compactador)
            {
                case "winrar":
                    InversaoChkWinrar(windows, true);

                    new Parametros().InstalarWinrar10();
                    Thread.Sleep(3000);

                    while (Process.GetProcessesByName("winrarx64").Length != 0) { }

                    InversaoChkWinrar(windows, false);

                    break;

                default:

                    MessageBox.Show("Codec foi selecionado porem sem escolha de versão");
                    break;
            }
        }

        public void InstalarAtivador(string ativador, string windows)
        {
            switch (ativador)
            {
                case "kmsPico":

                    InversaoChkAtivador(windows, true);

                    if (File.Exists(System.IO.Path.GetTempPath() + "KMSpico.exe"))
                    {
                        File.Delete(System.IO.Path.GetTempPath() + "KMSpico.exe");
                        Thread.Sleep(5000);
                        ZipFile.ExtractToDirectory(@"Apps\Windows10_11\Ativador\KMSpico2021WIN11.zip", Path.GetTempPath());
                        Thread.Sleep(5000);
                        new Parametros().InstalarAtivador10();
                        Thread.Sleep(5000);
                    }
                    else
                    {
                        ZipFile.ExtractToDirectory(@"Apps\Windows10_11\Ativador\KMSpico2021WIN11.zip", Path.GetTempPath());
                        Thread.Sleep(5000);
                        new Parametros().InstalarAtivador10();
                        Thread.Sleep(5000);
                    }

                    while (Process.GetProcessesByName("KMSpico.exe").Length != 0 || Process.GetProcessesByName("KMSpico.tmp").Length != 0)
                    {

                    }
                    InversaoChkAtivador(windows, false);

                    break;
            }
        }

        public void InstalarPDF(string pdf, string windows)
        {
            switch (pdf)
            {
                case "adobe":

                    InversaoChkPDF(windows, true);

                    new Parametros().InstalarAdobeReader();
                    Thread.Sleep(5000);

                    while (Process.GetProcessesByName("AdobeReader").Length != 0)
                    {

                    }
                    InversaoChkPDF(windows, false);
                    break;
            }
        }

        private void InversaoChkOffice(string windows, bool status)
        {
            if (windows == "w7" && status == true)
                instalacaoW7.pbLoadingOffice.Visible = true;

            if (windows == "w8" && status == true)
            {
                //instalacaoW8.pbLoadingOffice.Visible = true;
            }

            if (windows == "w10" && status == true)
                instalacaoW10.pbLoadingOffice.Visible = true;

            if (windows == "w7" && status == false)
            {
                instalacaoW7.pbLoadingOffice.Visible = false;
                instalacaoW7.chkOffice.Checked = false;
            }

            if (windows == "w8" && status == false)
            {
                //instalacaoW8.pbLoadingOffice.Visible = false;
                //instalacaoW8.chkOffice.Checked = false;
            }

            if (windows == "w10" && status == false)
            {
                instalacaoW10.pbLoadingOffice.Visible = false;
                instalacaoW10.chkOffice.Checked = false;
            }
        }

        private void InversaoChkNavegador(string windows, bool status)
        {
            if (windows == "w7" && status == true)
                instalacaoW7.pbLoadingNavegador.Visible = true;

            if (windows == "w8" && status == true)
            {
                //instalacaoW8.pbLoadingNavegador.Visible = true;
            }

            if (windows == "w10" && status == true)
                instalacaoW10.pbLoadingNavegador.Visible = true;

            if (windows == "w7" && status == false)
            {
                instalacaoW7.pbLoadingNavegador.Visible = false;
                instalacaoW7.chkNavegador.Checked = false;
            }

            if (windows == "w8" && status == false)
            {
                //instalacaoW8.pbLoadingNavegador.Visible = false;
                //instalacaoW8.chkNavegador.Checked = false;
            }

            if (windows == "w10" && status == false)
            {
                instalacaoW10.pbLoadingNavegador.Visible = false;
                instalacaoW10.chkNavegador.Checked = false;
            }
        }

        private void InversaoChkCodec(string windows, bool status)
        {
            if (windows == "w7" && status == true)
                instalacaoW7.pbLoadingCodec.Visible = true;

            if (windows == "w8" && status == true)
            {
                //instalacaoW8.pbLoadingCodec.Visible = true;
            }

            if (windows == "w10" && status == true)
                instalacaoW10.pbLoadingCodec.Visible = true;

            if (windows == "w7" && status == false)
            {
                instalacaoW7.pbLoadingCodec.Visible = false;
                instalacaoW7.chkCodec.Checked = false;
            }

            if (windows == "w8" && status == false)
            {
                //instalacaoW8.pbLoadingCodec.Visible = false;
                //instalacaoW8.chkCodec.Checked = false;
            }

            if (windows == "w10" && status == false)
            {
                instalacaoW10.pbLoadingCodec.Visible = false;
                instalacaoW10.chkCodec.Checked = false;
            }
        }

        private void InversaoChkWinrar(string windows, bool status)
        {
            if (windows == "w7" && status == true)
                instalacaoW7.pbLoadingWinrar.Visible = true;

            if (windows == "w8" && status == true)
            {
                //instalacaoW8.pbLoadingWinrar.Visible = true;
            }

            if (windows == "w10" && status == true)
                instalacaoW10.pbLoadingWinrar.Invoke((MethodInvoker)delegate { instalacaoW10.pbLoadingWinrar.Visible = true; });

            if (windows == "w7" && status == false)
            {
                instalacaoW7.pbLoadingWinrar.Visible = false;
                instalacaoW7.chkWinrar.Checked = false;
            }

            if (windows == "w8" && status == false)
            {
                //instalacaoW8.pbLoadingWinrar.Visible = false;
                //instalacaoW8.chkWinrar.Checked = false;
            }

            if (windows == "w10" && status == false)
            {
                instalacaoW10.pbLoadingWinrar.Invoke((MethodInvoker)delegate { instalacaoW10.pbLoadingWinrar.Visible = false; });
                instalacaoW10.chkWinrar.Invoke((MethodInvoker)delegate { instalacaoW10.chkWinrar.Checked = false; });
                //instalacaoW10.pbLoadingWinrar.Visible = false;
                //instalacaoW10.chkWinrar.Checked = false;
            }
        }

        private void InversaoChkPDF(string windows, bool status)
        {
            if (windows == "w7" && status == true)
                instalacaoW7.pbLoadingPDF.Visible = true;

            if (windows == "w8" && status == true)
            {
                //instalacaoW8.pbLoadingPDF.Visible = true;
            }

            if (windows == "w10" && status == true)
                //instalacaoW10.pbLoadingPDF.Visible = true;

                if (windows == "w7" && status == false)
                {
                    instalacaoW7.pbLoadingPDF.Visible = false;
                    instalacaoW7.chkPDF.Checked = false;
                }

            if (windows == "w8" && status == false)
            {
                //instalacaoW8.pbLoadingPDF.Visible = false;
                //instalacaoW8.chkPDF.Checked = false;
            }

            if (windows == "w10" && status == false)
            {
                //instalacaoW10.pbLoadingPDF.Visible = false;
                //instalacaoW10.chkPDF.Checked = false;
            }
        }

        private void InversaoChkAtivador(string windows, bool status)
        {
            if (windows == "w7" && status == true)
                instalacaoW7.pbLoadingAtivador.Visible = true;

            if (windows == "w8" && status == true)
            {
                //instalacaoW8.pbLoadingAtivador.Visible = true;
            }

            if (windows == "w10" && status == true)
                instalacaoW10.pbLoadingAtivador.Visible = true;

            if (windows == "w7" && status == false)
            {
                instalacaoW7.pbLoadingAtivador.Visible = false;
                instalacaoW7.chkAtivador.Checked = false;
            }

            if (windows == "w8" && status == false)
            {
                //instalacaoW8.pbLoadingAtivador.Visible = false;
                //instalacaoW8.chkAtivador.Checked = false;
            }

            if (windows == "w10" && status == false)
            {
                instalacaoW10.pbLoadingAtivador.Visible = false;
                instalacaoW10.chkAtivador.Checked = false;
            }
        }

    }
}
