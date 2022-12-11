using OpenQA.Selenium;


namespace VideoProject2.Core
{
    public class GlobalVariables
    {
        //Define 'driver' como trigger para os WebElements
        public IWebDriver driver;

        //Define 'Fechar navegador ao final do teste' como padrão
        public bool driverQuit = true;

        //Habilita | Desabilita modo Headless
        public bool headlessTest = false;
    }
}
