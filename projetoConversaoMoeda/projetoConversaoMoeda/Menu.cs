using System;
using System.Globalization;

namespace projetoConversaoMoeda
{
    public class Menu
    {
        public static void MenuOpcoes()
        {
            Conversoes conversoes = new Conversoes();

            Console.WriteLine("Código de conversão de moedas");
            Console.WriteLine("Opções de conversão: " + Environment.NewLine +
                "1 - Real" + Environment.NewLine +
                "2 - Dolar" + Environment.NewLine +
                "3 - Euro" + Environment.NewLine +
                "4 - Iene" + Environment.NewLine +
                "5 - Libra Esterlina" + Environment.NewLine +
                "Digite a opção, entre 1 e 5");

            Console.Write("DE: ");
            int opcaoDe = int.Parse(Console.ReadLine());
            Console.Write("PARA: ");
            int opcaoPara = int.Parse(Console.ReadLine());

            Console.Write(Environment.NewLine + "Digite o valor para ser convertido: ");
            double valorDigitado = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            if (opcaoDe == 1)
            {
                if (opcaoPara == 2)
                {
                    conversoes.RealParaDolar(valorDigitado);
                }
                else if (opcaoPara == 3)
                {
                    conversoes.RealParaEuro(valorDigitado);
                }
                else if (opcaoPara == 4)
                {
                    conversoes.RealParaIene(valorDigitado);
                }
                else if (opcaoPara == 5)
                {
                    conversoes.RealParaLibra(valorDigitado);
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }

            }

            else if (opcaoDe == 2)
            {
                if (opcaoPara == 1)
                {
                    conversoes.DolarParaReal(valorDigitado);
                }
                else if (opcaoPara == 3)
                {
                    conversoes.DolarParaEuro(valorDigitado);
                }
                else if (opcaoPara == 4)
                {
                    conversoes.DolarParaIene(valorDigitado);
                }
                else if (opcaoPara == 5)
                {
                    conversoes.DolarParaLibra(valorDigitado);
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }

            else if (opcaoDe == 3)
            {
                if (opcaoPara == 1)
                {
                    conversoes.EuroParaReal(valorDigitado);
                }
                else if (opcaoPara == 2)
                {
                    conversoes.EuroParaDolar(valorDigitado);
                }
                else if (opcaoPara == 4)
                {
                    conversoes.EuroParaIene(valorDigitado);
                }
                else if (opcaoPara == 5)
                {
                    conversoes.EuroParaLibra(valorDigitado);
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
            else if (opcaoDe == 4)
            {
                if (opcaoPara == 1)
                {
                    conversoes.IeneParaReal(valorDigitado);
                }
                else if (opcaoPara == 2)
                {
                    conversoes.IeneParaDolar(valorDigitado);

                }

                else if (opcaoPara == 3)
                {
                    conversoes.IeneParaEuro(valorDigitado);
                }
                else if (opcaoPara == 5)
                {
                    conversoes.IeneParaLibra(valorDigitado);
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
            else if (opcaoDe == 5)
            {
                if (opcaoPara == 1)
                {
                    conversoes.LibraParaReal(valorDigitado);
                }
                else if (opcaoPara == 2)
                {
                    conversoes.LibraParaDolar(valorDigitado);
                }
                else if (opcaoPara == 3)
                {
                    conversoes.LibraParaEuro(valorDigitado);
                }
                else if (opcaoPara == 4)
                {
                    conversoes.LibraParaIene(valorDigitado);
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }

        }

    }
}

