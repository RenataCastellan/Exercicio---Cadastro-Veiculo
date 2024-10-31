using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class VeiculoDAO
    {
        public List<Veiculo> listaVeiculos = new List<Veiculo>();

        public void Cadastrar(Veiculo v)
        {
            listaVeiculos.Add(v);
        }

        public List<Veiculo> ListarTodos()
        {
            return listaVeiculos;
        }

        public void Remover(string placa)
        {
            Veiculo vExcluir = listaVeiculos.First(p => p.placa == placa);
            listaVeiculos.Remove(vExcluir);
        }

        public Veiculo BuscarPlaca(string placa)
        {
            Veiculo veiculo = listaVeiculos.First(p => p.placa == placa);
            return veiculo;
        }
    }
}
