using System;
using System.Globalization;
namespace projetoConversaoMoeda
{
    internal class Conversoes
    {
        Dictionary<Moedas, decimal> ValoresDasMoedasEmReais = new Dictionary<Moedas, decimal>()
        {
 
            {Moedas.dolar, 4.5000M }, //em real
            {Moedas.euro, 6.2000M },
            {Moedas.iene, 0.0520M },
            {Moedas.libra_esterlina, 6.9500M}
        };

 
        public int MyProperty { get; set; }

        public double ValorReal { get; set; }
        public double ValorDolar { get; set; }



        //Conversões de real para: 

        public decimal RealParaDolar(decimal ValorReal)
        {
            decimal resultado = ValorReal / ValoresDasMoedasEmReais[Moedas.dolar];
            Console.WriteLine($"O valor de {ValorReal.ToString("C4", CultureInfo.CurrentCulture)} em {Moedas.dolar} é  {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))}.");
            return resultado;
        }

        public decimal RealParaEuro(decimal ValorReal)
        {


            decimal resultado = ValorReal / ValoresDasMoedasEmReais[Moedas.euro];
            Console.WriteLine($"O valor de {ValorReal.ToString("C4", CultureInfo.CurrentCulture)} em {Moedas.euro} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))}.");
            return resultado;
        }

        public decimal RealParaIene(decimal ValorReal)
        {

            decimal resultado = ValorReal / ValoresDasMoedasEmReais[Moedas.iene];
            Console.WriteLine($"O valor de {ValorReal.ToString("C4", CultureInfo.CurrentCulture)} em {Moedas.iene} é  {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))}.");
            return resultado;
        }

        public decimal RealParaLibra(decimal ValorReal)
        {

            decimal resultado = ValorReal / ValoresDasMoedasEmReais[Moedas.libra_esterlina];
            Console.WriteLine($"O valor de {ValorReal.ToString("C4", CultureInfo.CurrentCulture)} em {Moedas.libra_esterlina} é ACHAR CODIGO LIBRA {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))}.");
            return resultado;

        }

        //Conversões de dolar para:

        public decimal DolarParaReal(decimal ValorDolar)
        {
            decimal resultado = ValorDolar * ValoresDasMoedasEmReais[Moedas.dolar];
            Console.WriteLine($"O valor de {ValorDolar.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))} em {Moedas.real} é {resultado.ToString("C4", CultureInfo.CurrentCulture)}.");
            return resultado;
        }

        public decimal DolarParaEuro(decimal ValorDolar)
        {
            decimal resultado = ValorDolar * 0.7258M;
            Console.WriteLine($"O valor de {ValorDolar.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))} em {Moedas.euro} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("eu-EU"))}.");
            return resultado;
        }

        public decimal DolarParaIene(decimal ValorDolar)
        {
            decimal resultado = ValorDolar * 86.5385M;
            Console.WriteLine($"O valor de {ValorDolar.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))} em {Moedas.iene} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))}.");
            return resultado;

        }
        
        public decimal DolarParaLibra(decimal ValorDolar)
        {
            decimal resultado = ValorDolar * 0.6475M;
            Console.WriteLine($"O valor de {ValorDolar.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))} em {Moedas.libra_esterlina} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))}.");
            return resultado;
        }

        //De euro para:

        public decimal EuroParaReal(decimal ValorEuro)
        {
            decimal resultado = ValorEuro * ValoresDasMoedasEmReais[Moedas.euro];
            Console.WriteLine($"O valor de {ValorEuro.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))} em {Moedas.real} é {resultado.ToString("C4", CultureInfo.CurrentCulture)}.");
            return resultado;
        }
        public decimal EuroParaDolar(decimal ValorEuro)
        {
            decimal resultado = ValorEuro * 1.3778M;
            Console.WriteLine($"O valor de {ValorEuro.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))} em {Moedas.dolar} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))}.");
            return resultado;
        }

        public decimal EuroParaIene(decimal ValorEuro)
        {
            decimal resultado = ValorEuro * 119.2308M;
            Console.WriteLine($"O valor de {ValorEuro.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))} em {Moedas.iene} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))}.");
            return resultado;
        }

        public decimal EuroParaLibra(decimal ValorEuro)
        {
            decimal resultado = ValorEuro * 0.8921M;
            Console.WriteLine($"O valor de {ValorEuro.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))} em {Moedas.libra_esterlina} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))}.");
            return resultado;
        }


        //De iene para:

        public decimal IeneParaReal(decimal ValorIene)
        {
            decimal resultado = ValorIene * ValoresDasMoedasEmReais[Moedas.iene];
            Console.WriteLine($"O valor de {ValorIene.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))} em {Moedas.real} é {resultado.ToString("C4", CultureInfo.CurrentCulture)}.");
            return resultado;
        }

        public decimal IeneParaDolar(decimal ValorIene)
        {
            decimal resultado = ValorIene * 0.0116M;
            Console.WriteLine($"O valor de {ValorIene.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))} em {Moedas.dolar} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))}.");
            return resultado;
        }

        public decimal IeneParaEuro(decimal ValorIene)
        {
            decimal resultado = ValorIene * 0.0084M;
            Console.WriteLine($"O valor de {ValorIene.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))} em {Moedas.dolar} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))}.");
            return resultado;
        }

        public decimal IeneParaLibra(decimal ValorIene)
        {
            decimal resultado = ValorIene * 0.0075M;
            Console.WriteLine($"O valor de {ValorIene.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))} em {Moedas.libra_esterlina} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))}.");
            return resultado;
        }

        //De libra esterlina para:

        public decimal LibraParaReal(decimal ValorLibra)
        {
            decimal resultado = ValorLibra * ValoresDasMoedasEmReais[Moedas.libra_esterlina];
            Console.WriteLine($"O valor de {ValorLibra.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))} em {Moedas.real} é {resultado.ToString("C4", CultureInfo.CurrentCulture)}.");
            return resultado;
        }
        public decimal LibraParaDolar(decimal ValorLibra)
        {
            decimal resultado = ValorLibra * 1.5444M;
            Console.WriteLine($"O valor de {ValorLibra.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))} em {Moedas.dolar} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))}.");
            return resultado;
        }

        public decimal LibraParaEuro(decimal ValorLibra)
        {
            decimal resultado = ValorLibra * 1.1210M;
            Console.WriteLine($"O valor de {ValorLibra.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))} em {Moedas.euro} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))}.");
            return resultado;
        }
        public decimal LibraParaIene(decimal ValorLibra)
        {
            decimal resultado = ValorLibra * 133.6538M;
            Console.WriteLine($"O valor de {ValorLibra.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))} em {Moedas.iene} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))}.");
            return resultado;
        }
    }
}
