using NUnit.Framework;
using VideoProject2.Page;

namespace VideoProject2.Test
{
     class ValidaCepTest : ValidaCepPage
    {
        [Test]
        
        public void ValidaCep()
        {
            PreencheCep();
            ClicaBtnBusca();
            ValidaResultado();


        }
        [Test]

        public void ValidarResultadoTotal()
        {
            PreencheCep();
            ClicaBtnBusca();
            ValidaResultadoTotal();
        }

        [Test]
        public void ValidaMultiplosCenarios()
        {
            ValidaMultiplosCeps();
        }
    }
}
