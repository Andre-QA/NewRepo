using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace VideoProject2.Core
{
    public class Begin : DSL
    {
        #region Codigo do Abre Navegador
        private void AbreNavegador()
        {
            var headlessMode = new ChromeOptions();
            headlessMode.AddArgument("window-size=1366x768");
            headlessMode.AddArgument("disk-cache-size=0");
            headlessMode.AddArgument("headless");

            var devMode = new ChromeOptions();
            devMode.AddArgument("disk-cache-size=0");
            devMode.AddArgument("start-maximized");

            if (headlessTest) { driver = new ChromeDriver(headlessMode); }
            else { driver = new ChromeDriver(devMode); driverQuit = false; }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        #endregion

        #region Setup
        [SetUp]
        public void InicioTeste()
        {
           AbreNavegador();
           driver.Navigate().GoToUrl("http://www.buscacep.correios.com.br");
            
        }
        #endregion

        #region Tear Down
        [TearDown]
        public void TearDown()
        {
            if (driverQuit) driver.Quit();
        }
        #endregion
    }
}