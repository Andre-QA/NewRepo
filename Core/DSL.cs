using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace VideoProject2.Core
{

    public class DSL : GlobalVariables
    {
        #region Funções de Manipulação

        public static void Espere(int time) => Thread.Sleep(time);

        public void LimparCampo(string element) => driver.FindElement(By.XPath(element)).Clear();
        public void ClicaFora() => driver.FindElement(By.XPath("//html")).Click();

        public void EsperaElemento(string element, int seconds = 90)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until((d) => { return d.FindElement(By.XPath(element)); });
        }

        public void EsperaElementoSumir(string element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
            wait.Until(d => d.FindElements(By.XPath(element)).Count == 0);

        }

        public bool ValidaElementoExistente(string xPath)
        {
            try
            { driver.FindElement(By.XPath(xPath)); return true; }
            catch (NoSuchElementException) { return false; }

        }


        #endregion

        #region Funções de Interação
        public void EscreveTexto(string xpath, string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }

        public void ClicaElemento(string element)
        {
            driver.FindElement(By.XPath(element)).Click();
        }

        public void ValidaDados(string xpath, string value)
        {
            Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value));
        }
        #endregion

        #region Funções de Atribuição

        public static string GeraNomeAleatorio()
        {
            var rnd = new Random();
            string[] nome = { "Ricardo", "Rodrigo", "Ana", "Catarina", "Maria" };
            string[] sobrenome = { "Oliveira", "Silva", "Santos", "Linhares", "Mota" };
            string nomeCompleto = nome[rnd.Next(nome.Length)] + " " + sobrenome[rnd.Next(sobrenome.Length)];
            //Console.WriteLine();
            return nomeCompleto;

        }

        #endregion


    }
}
