using System;
using System.Globalization;
namespace projetoConversaoMoeda
{
    internal class Conversoes
    {
        Dictionary<Moedas, double> ValoresDasMoedasEmReais = new Dictionary<Moedas, double>()
        {
 
            {Moedas.dolar, 4.5000 }, //em real
            {Moedas.euro, 6.2000 },
            {Moedas.iene, 0.0520 },
            {Moedas.libra_esterlina, 6.9500}
        };

 
        public int MyProperty { get; set; }

        public double ValorReal { get; set; }
        public double ValorDolar { get; set; }


        //Conversões de real para: 
        public double RealParaDolar(double ValorReal)
        {
            double resultado = ValorReal / ValoresDasMoedasEmReais[Moedas.dolar];
            Console.WriteLine($"O valor de {ValorReal.ToString("C4", CultureInfo.CurrentCulture)} em {Moedas.dolar} é  {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))}.");
            return resultado;
        }

        public double RealParaEuro(double ValorReal)
        {


            double resultado = ValorReal / ValoresDasMoedasEmReais[Moedas.euro];
            Console.WriteLine($"O valor de {ValorReal.ToString("C4", CultureInfo.CurrentCulture)} em {Moedas.euro} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))}.");
            return resultado;
        }

        public double RealParaIene(double ValorReal)
        {

            double resultado = ValorReal / ValoresDasMoedasEmReais[Moedas.iene];
            Console.WriteLine($"O valor de {ValorReal.ToString("C4", CultureInfo.CurrentCulture)} em {Moedas.iene} é  {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))}.");
            return resultado;
        }

        public double RealParaLibra(double ValorReal)
        {

            double resultado = ValorReal / ValoresDasMoedasEmReais[Moedas.libra_esterlina];
            Console.WriteLine($"O valor de {ValorReal.ToString("C4", CultureInfo.CurrentCulture)} em {Moedas.libra_esterlina} é ACHAR CODIGO LIBRA {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))}.");
            return resultado;

        }

        //Conversões de dolar para:

        public double DolarParaReal(double ValorDolar)
        {
            double resultado = ValorDolar * ValoresDasMoedasEmReais[Moedas.dolar];
            Console.WriteLine($"O valor de {ValorDolar.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))} em {Moedas.real} é {resultado.ToString("C4", CultureInfo.CurrentCulture)}.");
            return resultado;
        }

        public double DolarParaEuro(double ValorDolar)
        {
            double resultado = ValorDolar * 0.7258;
            Console.WriteLine($"O valor de {ValorDolar.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))} em {Moedas.euro} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("eu-EU"))}.");
            return resultado;
        }

        public double DolarParaIene(double ValorDolar)
        {
            double resultado = ValorDolar * 86.5385;
            Console.WriteLine($"O valor de {ValorDolar.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))} em {Moedas.iene} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))}.");
            return resultado;

        }
        
        public double DolarParaLibra(double ValorDolar)
        {
            double resultado = ValorDolar * 0.6475;
            Console.WriteLine($"O valor de {ValorDolar.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))} em {Moedas.libra_esterlina} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))}.");
            return resultado;
        }

        //De euro para:

        public double EuroParaReal(double ValorEuro)
        {
            double resultado = ValorEuro * ValoresDasMoedasEmReais[Moedas.euro];
            Console.WriteLine($"O valor de {ValorEuro.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))} em {Moedas.real} é {resultado.ToString("C4", CultureInfo.CurrentCulture)}.");
            return resultado;
        }
        public double EuroParaDolar(double ValorEuro)
        {
            double resultado = ValorEuro * 1.3778;
            Console.WriteLine($"O valor de {ValorEuro.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))} em {Moedas.dolar} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))}.");
            return resultado;
        }

        public double EuroParaIene(double ValorEuro)
        {
            double resultado = ValorEuro * 119.2308;
            Console.WriteLine($"O valor de {ValorEuro.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))} em {Moedas.iene} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))}.");
            return resultado;
        }

        public double EuroParaLibra(double ValorEuro)
        {
            double resultado = ValorEuro * 0.8921;
            Console.WriteLine($"O valor de {ValorEuro.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))} em {Moedas.libra_esterlina} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))}.");
            return resultado;
        }


        //De iene para:

        public double IeneParaReal(double ValorIene)
        {
            double resultado = ValorIene * ValoresDasMoedasEmReais[Moedas.iene];
            Console.WriteLine($"O valor de {ValorIene.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))} em {Moedas.real} é {resultado.ToString("C4", CultureInfo.CurrentCulture)}.");
            return resultado;
        }

        public double IeneParaDolar(double ValorIene)
        {
            double resultado = ValorIene * 0.0116;
            Console.WriteLine($"O valor de {ValorIene.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))} em {Moedas.dolar} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))}.");
            return resultado;
        }

        public double IeneParaEuro(double ValorIene)
        {
            double resultado = ValorIene * 0.0084;
            Console.WriteLine($"O valor de {ValorIene.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))} em {Moedas.dolar} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))}.");
            return resultado;
        }

        public double IeneParaLibra(double ValorIene)
        {
            double resultado = ValorIene * 0.0075;
            Console.WriteLine($"O valor de {ValorIene.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))} em {Moedas.libra_esterlina} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))}.");
            return resultado;
        }

        //De libra esterlina para:

        public double LibraParaReal(double ValorLibra)
        {
            double resultado = ValorLibra * ValoresDasMoedasEmReais[Moedas.libra_esterlina];
            Console.WriteLine($"O valor de {ValorLibra.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))} em {Moedas.real} é {resultado.ToString("C4", CultureInfo.CurrentCulture)}.");
            return resultado;
        }
        public double LibraParaDolar(double ValorLibra)
        {
            double resultado = ValorLibra * 1.5444;
            Console.WriteLine($"O valor de {ValorLibra.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))} em {Moedas.dolar} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("us-US"))}.");
            return resultado;
        }

        public double LibraParaEuro(double ValorLibra)
        {
            double resultado = ValorLibra * 1.1210;
            Console.WriteLine($"O valor de {ValorLibra.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))} em {Moedas.euro} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("fr-FR"))}.");
            return resultado;
        }
        public double LibraParaIene(double ValorLibra)
        {
            double resultado = ValorLibra * 133.6538;
            Console.WriteLine($"O valor de {ValorLibra.ToString("C4", CultureInfo.CreateSpecificCulture("en-GB"))} em {Moedas.iene} é {resultado.ToString("C4", CultureInfo.CreateSpecificCulture("ja-JA"))}.");
            return resultado;
        }
    }
}
