using System;
using System.Collections.Generic;
using System.Text;

namespace Votos_Eleitores
{
    class Votos_Validos
    {
       
        public Votos_Validos() { } //criacao da classe

        public double percValidos(double totalEleitores, double validos)
        {
            double percentualValidos;

            percentualValidos = validos  / totalEleitores;
            return percentualValidos;
        }

        public double percBrancos(double totalEleitores, double votosBrancos)
        {
            double percentualBrancos;

            percentualBrancos = votosBrancos / totalEleitores;

            return percentualBrancos;
        }

        public double percNulos(double totalEleitores, double votosNulos)
        {
            double percentualVotosNulos;

            percentualVotosNulos = votosNulos / totalEleitores;

            return percentualVotosNulos;
        }


    }
}
