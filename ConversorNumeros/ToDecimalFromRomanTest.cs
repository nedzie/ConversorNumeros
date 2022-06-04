using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversorNumeroRomanoParaArabico;

namespace ConversorNumeros
{
    [TestClass]
    public class ToDecimalFromRomanTest
    {
        private ConvertXToN conversor;

        public ToDecimalFromRomanTest()
        {
            conversor = new();
        }

        [TestMethod]
        public void Teste()
        {
            for (int i = 0; i < 3999; i++)
            {
                string s = ToRoman(i);
                ToDecimal(s, i);
            }
        }

        public string ToRoman(int numero)
        {
            return conversor.ConverterParaRomano(numero);
        }
        public void ToDecimal(string letraRecebida, int numeroConvertido)
        {
            var resultado = conversor.ConverterParaDecimal(letraRecebida);

            Assert.AreEqual(numeroConvertido, resultado);
        }



        public void ToRoman(string padraoRomano, int numeroRecebido)
        {
            var resultadoConversao = conversor.ConverterParaRomano(numeroRecebido);

            Assert.AreEqual(padraoRomano, resultadoConversao);
        }

        
    }
}
