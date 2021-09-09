using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsInCsharp
{
    public class GenericClasse<T>
    {
        T variabileGenerica;
        int variabileInteger;
        public GenericClasse(T _variabileGenerica, int _variabileInteger)
        {
            variabileGenerica = _variabileGenerica;
            variabileInteger = _variabileInteger;
        }

        public string stampaVariabile()
        {
            return "Variabile di tipo qualsiasi : " + variabileGenerica + " " + variabileInteger;
        }
    }

    public class GenericaClasse2<T, R>
    {
        T varGen1;
        R varGen2;

        public GenericaClasse2(T _varGen1, R _varGen2)
        {
            varGen1 = _varGen1;
            varGen2 = _varGen2;
        }

        public string StampaVariabili()
        {
            return $"Variabile 1: {varGen1} Variabile 2 : {varGen2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericClasse<int> oggettoGenerico = new GenericClasse<int>(123, 456);
            Console.WriteLine(oggettoGenerico.stampaVariabile());

            GenericClasse<string> oggettoGenerico2 = new GenericClasse<string>("asdf", 456);
            Console.WriteLine(oggettoGenerico2.stampaVariabile());

            GenericClasse<char> oggettoGenerico3 = new GenericClasse<char>('C', 456);
            Console.WriteLine(oggettoGenerico3.stampaVariabile());

            Console.WriteLine("\nMetodo Generico: ");
            string c = GenericMetodo<string>("Ciao", "Salve");
            Console.WriteLine(c);

            Console.WriteLine("\nClasse generica con due parametri: ");
            GenericaClasse2<int, string> oggGen1 = new GenericaClasse2<int, string>(123, "asdfg");
            Console.WriteLine(oggGen1.StampaVariabili());

            Console.ReadKey();
        }

        private static T GenericMetodo<T>(T a, T b)
        {
            return a;
        }
    }
}
