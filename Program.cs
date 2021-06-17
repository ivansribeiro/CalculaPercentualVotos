using System;

namespace Votos_Eleitores
{
    class Program
    {
        static void Main(string[] args)
        {



            Votos_Validos percValidos = new Votos_Validos();
            Votos_Validos percBrancos = new Votos_Validos();
            Votos_Validos percNulos = new Votos_Validos();



            Console.WriteLine("Informe o tatal de Eleitores");
            string totEleitores = Console.ReadLine();
            double totalEleitores = Convert.ToDouble(totEleitores);

            Console.WriteLine("Informe o total de votos validos");
            string totValidos = Console.ReadLine();
            double totalValidos = Convert.ToDouble(totValidos);

            Console.WriteLine("Informe o total de votos brancos");
            string totBrancos = Console.ReadLine();
            double totalBrancos = Convert.ToDouble(totBrancos);

            Console.WriteLine("Informe o total de votos nulos");
            string totNulos = Console.ReadLine();
            double totalNulos = Convert.ToDouble(totNulos);


            double percentualValidos = percValidos.percValidos(totalEleitores, totalValidos);
            double percentualBrancos = percBrancos.percBrancos(totalEleitores, totalBrancos);
            double percentualNulos = percNulos.percNulos(totalEleitores, totalNulos);

            Console.WriteLine("Votos Validos foram :"+ percentualValidos);
            Console.WriteLine("Votos Brancos foram :" + percentualBrancos);
            Console.WriteLine("Votos Nulos foram :" + percentualNulos);



        }
    }
}
