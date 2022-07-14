using System.Configuration;
using System.Diagnostics;

namespace CheckList
{
    public class Instalacao
    {
        public void InstalarOffice()
        {
            Process.Start(ConfigurationManager.AppSettings["Office2010"], ConfigurationManager.AppSettings["Office2010Parametro"]);
        }
        public void InstalarChrome()
        {
            Process.Start(ConfigurationManager.AppSettings["Chrome"], ConfigurationManager.AppSettings["ChromeParametro"]);
        }
        public void InstalarKlite()
        {
            Process.Start(ConfigurationManager.AppSettings["Klite"], ConfigurationManager.AppSettings["KliteParametro"]);
        }
        public void InstalarWinrar()
        {
            Process.Start(ConfigurationManager.AppSettings["Winrar"], ConfigurationManager.AppSettings["WinrarParametro"]);
        }

        public void InstalarAdobeReader()
        {
            Process.Start(ConfigurationManager.AppSettings["AdobeReader"], ConfigurationManager.AppSettings["AdobeReaderParametro"]);
        }
    }
}
