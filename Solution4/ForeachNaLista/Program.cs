using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            listadeDecimais();
            Console.ReadKey();
        }
        /// <summary>
        ///  Mostra listas de datas definidas
        /// </summary>
        /// 
        private static void listadatetime()
        {
            var minhalista = new List<DateTime>();
            minhalista.Add(new DateTime(2019, 9, 17));
            minhalista.Add(new DateTime(2019, 9, 18));
            minhalista.Add(new DateTime(2019, 9, 19));

            minhalista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MMM/dd")));

            Console.ReadKey();


        }

        /// <summary>
        /// Mostra lista de String definidas
        /// </summary>

        private static void listaString()
        {
            var minhalista = new List<string>();

            minhalista.Add("Xiaomi");
            minhalista.Add("Iphone");
            minhalista.Add("Samsung");
            minhalista.Add("Nokia");
            //
            minhalista.ForEach(i => Console.WriteLine(i));

            foreach (var item in minhalista)
            {
                Console.WriteLine(item);

                Console.ReadKey();
            }
        }
        /// <summary>
        /// metodo que mostra os numeros inteiros 
        /// </summary>
        private static void listadeInteiros()
        {
            var minhalista = new List<int>();

            minhalista.Add(17);
            minhalista.Add(18);
            minhalista.Add(19);
            minhalista.Add(20);
            minhalista.Add(21);

            minhalista.ForEach(meuNumero => Console.WriteLine(meuNumero));

        }
        /// <summary>
        /// minha lista de numeros decimais
        /// </summary>
        private static void listadeDecimais()
        {
            var minhalista = new List<double>();
            minhalista.Add(3.75);
            minhalista.Add(4.98);
            minhalista.Add(2.42);
            minhalista.Add(0.05);
            minhalista.Add(6.66);

            minhalista.ForEach(meudecimal => Console.WriteLine(meudecimal.ToString("C2") + " " + formataNumeroDecimalEmDolar(meudecimal)));
            minhalista.ForEach(meudecimal => Console.WriteLine(meudecimal.ToString("C3") + " " + formataNumeroDecimalEmEuro(meudecimal)));
            minhalista.ForEach(meudecimal => Console.WriteLine(meudecimal.ToString("C4") + " " + formataNumeroDecimalEmYen(meudecimal)));
            minhalista.ForEach(meudecimal => Console.WriteLine(meudecimal.ToString("C5") + " " + formataNumeroDecimalEmBtc(meudecimal)));
        }
        private static string formataNumeroDecimalEmDolar(double meuNumero)

        {
            return (meuNumero / 4.5008).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
        }
        /// <summary>
        /// Metodo que converte meu número em Real para Dólar
        /// </summary>
        /// <param name="meuNumero">Meu numero em real</param>
        /// <returns>Retorna meu numero formatado em Dólar</returns>

        private static string formataNumeroDecimalEmEuro(double meuNumero)
        {
            /// <summary>
            /// Metodo que converte meu número em Real para Euro
            /// </summary>
            /// <param name="meuNumero">Meu numero em real</param>
            /// <returns>Retorna meu numero formatado em Dólar</returns>

            return (meuNumero / 5.0274).ToString("C3", CultureInfo.CreateSpecificCulture("fr-EU"))
                .Replace("$","Euro");
        }
        /// <summary>
        /// Metodo que converte meu número em Real para Yen
        /// </summary>
        /// <param name="meuNumero">Meu numero em real</param>
        /// <returns>Retorna meu numero formatado em Yen</returns>

        private static string formataNumeroDecimalEmYen(double meuNumero)
        {
            return (meuNumero / 0.0409).ToString("C4", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        /// <summary>
        /// Metodo que converte meu número em Real para Bitcoin
        /// </summary>
        /// <param name="meuNumero">Meu numero em real</param>
        /// <returns>Retorna meu numero formatado em Bitcoin</returns>

        private static string formataNumeroDecimalEmBtc(double meuNumero)
        {
            return (meuNumero / 41733.86).ToString("C5", CultureInfo.CreateSpecificCulture("egy-ZA"));
        }

    }
}

