using NUnit.Framework;
using OpenQA.Selenium;
using VideoProject2.Core;

namespace VideoProject2
{
    class BuscaCep : Begin
    {
        [Test]
        public void Teste()
        {
            driver.FindElement(By.Id("endereco")).SendKeys("30492040");
            driver.FindElement(By.Id("btn_pesquisar")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id=\'resultado-DNEC\']/tbody/tr/td[1]")).Text, Does.Contain("Rua Ernani Agricola"));

        }
    }
}
