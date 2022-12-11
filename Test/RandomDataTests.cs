using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoProject2.Core;

namespace VideoProject2.Test
{
    public class RandomDataTests : DSL
    {
        [Test]

        public void RandomData()
        {
            string nome = GeraNomeAleatorio();
            Console.WriteLine(nome);


        }
    }
}
