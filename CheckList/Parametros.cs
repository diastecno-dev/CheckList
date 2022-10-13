using System.Configuration;
using System.Diagnostics;

namespace CheckList
{
    public class Parametros
    {
        public void InstalarOffice7()
        {
            Process.Start(ConfigurationManager.AppSettings["Office2010"], ConfigurationManager.AppSettings["OfficeParametro"]);
        }
        public void InstalarOffice10()
        {
            Process.Start(ConfigurationManager.AppSettings["Office2013"], ConfigurationManager.AppSettings["OfficeParametro"]);
        }
        public void InstalarChrome()
        {
            Process.Start(ConfigurationManager.AppSettings["Chrome"], ConfigurationManager.AppSettings["ChromeParametro"]);
        }
        public void InstalarKlite7()
        {
            Process.Start(ConfigurationManager.AppSettings["Klite7"], ConfigurationManager.AppSettings["KliteParametro"]);
        }
        public void InstalarKlite10()
        {
            Process.Start(ConfigurationManager.AppSettings["Klite10"], ConfigurationManager.AppSettings["KliteParametro"]);
        }
        public void InstalarWinrar7()
        {
            Process.Start(ConfigurationManager.AppSettings["Winrar7"], ConfigurationManager.AppSettings["WinrarParametro"]);
        }
        public void InstalarWinrar10()
        {
            Process.Start(ConfigurationManager.AppSettings["Winrar10"], ConfigurationManager.AppSettings["WinrarParametro"]);
        }
        public void InstalarAdobeReader()
        {
            Process.Start(ConfigurationManager.AppSettings["AdobeReader"], ConfigurationManager.AppSettings["AdobeReaderParametro"]);
        }
        public void InstalarAtivador7()
        {
            string temp = System.IO.Path.GetTempPath();
            Process.Start($"{temp}\\KMSpico.exe", ConfigurationManager.AppSettings["AtivadorParametro"]);
        }
        public void InstalarAtivador10()
        {
            string temp = System.IO.Path.GetTempPath();
            Process.Start($"{temp}KMSpico.exe", ConfigurationManager.AppSettings["AtivadorParametro"]);
        }
    }
}
