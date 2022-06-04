using System;
using System.Collections.Generic;
using System.Linq;

namespace ConversorNumeroRomanoParaArabico
{
    public class ConvertXToN
    {
        Dictionary<string, int> numbers = new Dictionary<string, int>();

        public ConvertXToN()
        {
            numbers.Add("", 0);
            numbers.Add("I", 1);
            numbers.Add("V", 5);
            numbers.Add("X", 10);
            numbers.Add("L", 50);
            numbers.Add("C", 100);
            numbers.Add("D", 500);
            numbers.Add("M", 1000);
        }

        public int ConverterParaDecimal(string numeroRomano)
        {
            int resultado = 0;
            int letraAtual = 0;
            int proxima = 0;

            if (numeroRomano.Length == 1)
                return numbers[numeroRomano];
            else
                for (int i = 0; i < numeroRomano.Length; i++)
                {
                    letraAtual = Convert.ToInt32(numbers.FirstOrDefault(x => x.Key == numeroRomano[i].ToString()).Value);

                    if (i != numeroRomano.Length - 1)
                        proxima = Convert.ToInt32(numbers.FirstOrDefault(x => x.Key == numeroRomano[i + 1].ToString()).Value);

                    if (letraAtual >= proxima)
                        resultado += letraAtual;
                    else
                        resultado -= letraAtual;
                }

            return resultado;
        }

        public string ConverterParaRomano(int numeroDecimal)
        {
            string resultado = "";

            const string i = "I";
            const string v = "V";
            const string x = "X";
            const string l = "L";
            const string c = "C";
            const string d = "D";
            const string m = "M";

            while (numeroDecimal > 0)
            {
                if (numeroDecimal >= 1000)
                {
                    resultado += m;
                    numeroDecimal -= 1000;
                }
                else if (numeroDecimal >= 500)
                {
                    if (numeroDecimal >= 900)
                    {
                        resultado += c;
                        resultado += m;
                        numeroDecimal -= 900;
                    }
                    else
                    {
                        resultado += d;
                        numeroDecimal -= 500;
                    }
                }
                else if (numeroDecimal >= 100)
                {
                    if (numeroDecimal >= 400)
                    {
                        resultado += c;
                        resultado += d;
                        numeroDecimal -= 400;
                    }
                    else
                    {
                        resultado += c;
                        numeroDecimal -= 100;
                    }
                }
                else if (numeroDecimal >= 50)
                {
                    if (numeroDecimal >= 90)
                    {
                        resultado += x;
                        resultado += c;
                        numeroDecimal -= 90;
                    }
                    else
                    {
                        resultado += l;
                        numeroDecimal -= 50;
                    }
                }
                else if (numeroDecimal >= 10)
                {
                    if (numeroDecimal.Equals(40))
                    {
                        resultado += x;
                        resultado += l;
                        numeroDecimal = 0;
                    }
                    else
                    {
                        resultado += x;
                        numeroDecimal -= 10;
                    }
                }
                else if (numeroDecimal >= 5)
                {
                    if (numeroDecimal.Equals(9))
                    {
                        resultado += i;
                        resultado += x;
                        numeroDecimal = 0;
                    }
                    else
                    {
                        resultado += v;
                        numeroDecimal -= 5;
                    }
                }
                else
                {
                    resultado += i;
                    if (numeroDecimal.Equals(4))
                        numeroDecimal += 1;
                    else
                        numeroDecimal -= 1;
                }
            }

            return resultado;
        }
    }
}
