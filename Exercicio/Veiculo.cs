using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Veiculo
    {
        public string placa;
        public string numeroMotor;
        public string niv;
        public string renavan;
        public string modelo;
        public string marca;

        public Veiculo(string placa, string modelo) //obrigando a passagem de parametros de placa e modelo
        {
            this.placa = placa;
            this.modelo = modelo;
        }

    }

   
}
