using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Sistema conversor de moedas cabuloso---");
            Console.WriteLine("Informe um valor a ser convertido:");

            var valorAserConvertido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão:");
            Console.WriteLine("DOLAR,EURO,YEN,BTC");

            var moedaAlvoParaCoverter = Console.ReadLine();

            var moedaAlvoParaConverter = Console.ReadLine();

            ConvertMoeda(valorAserConvertido, moedaAlvoParaConverter);
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que converte meu numero em Real para um especificado
        /// para converter digite os alvos:
        /// - "DOLAR"
        /// - "EURO"
        /// - "YEN"
        /// - "BTC"
        /// </summary>
        /// <param name="minhaMoeda"></param>
        /// <param name="moedaAlvo"></param>

        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {
            switch (moedaAlvo)
            {
                case "DOLAR":
                    Console.WriteLine(FormataNumeroDeCimaEmDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(FormataNumeroDeCimaEmEuro(minhaMoeda));
                    break;
                default:
                    break;
            }
        }


        /// <summary>
        /// Metodo que converte meu numero em real para dolar
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna o valor informado em Dolar</returns>
        private static string FormataNumeroDeCimaEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
        }

        private static string FormataNumeroDeCimaEmEuro(double meuNumero)
        {
            return (meuNumero / 5.0274).ToString("C3", CultureInfo.CreateSpecificCulture("fr-EU"));

        }
        private static string FormataNumeroDeCimaEmYen(double meuNumero)
        {
            return (meuNumero / 0.0409).ToString("C4", CultureInfo.CreateSpecificCulture("ja-JP"));
        }

        private static string FormataNumeroDeCimaEmBTC(double meuNumero)
        {
            return (meuNumero / 41733.86).ToString("C5", CultureInfo.CreateSpecificCulture("egy-ZA"));
        }


    }
}
