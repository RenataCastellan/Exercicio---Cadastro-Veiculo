using Exercicio;
using System.Numerics;

int opcao = 0;

VeiculoDAO vdao = new VeiculoDAO();
do
{
    Console.WriteLine("------ MENU DE OPÇÕES -------");
    Console.WriteLine();
    Console.WriteLine("1 - Cadastrar um veículo");
    Console.WriteLine("2 - Listar todos os veículos");
    Console.WriteLine("3 - Excluir um veículo");
    Console.WriteLine("4 - Consultar um veículo");
    Console.WriteLine("5 - Sair");
    Console.WriteLine();
    Console.Write("Informe sua opção: ");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (opcao == 1)
    {
        Console.WriteLine("CADASTRAR VEICULO");
        Console.WriteLine();
        Console.Write("Informe a placa: ");
        string placa = Console.ReadLine();
        Console.Write("Informe o modelo: ");
        string modelo = Console.ReadLine();
        Veiculo veiculo = new Veiculo(placa, modelo); //obrigando a passagem de valores de placa e modelo
        Console.Write("Informe o numero do motor: ");
        veiculo.numeroMotor = Console.ReadLine();
        Console.Write("Informe o renavan: ");
        veiculo.renavan = Console.ReadLine();
        Console.Write("Informe a marca: ");
        veiculo.marca = Console.ReadLine();

        vdao.Cadastrar(veiculo); 

    }
    else if (opcao == 2)
    {
        Console.WriteLine("LISTAR VEÍCULOS");
        Console.WriteLine();
        List<Veiculo> veiculos = vdao.ListarTodos();
        foreach (Veiculo veiculo in veiculos)
        {
            Console.WriteLine("Modelo" + veiculo.modelo);
            Console.WriteLine("Placa" + veiculo.placa);
            Console.WriteLine();
        }
    }
    else if (opcao == 3)
    {
        
        Console.WriteLine("EXCLUIR VEÍCULO");
        Console.WriteLine();
        Console.Write("Informe a placa: ");
        string placa = Console.ReadLine();
        vdao.Remover(placa);
    }
    else if (opcao == 4)
    {
        Console.WriteLine("BUSCAR VEÍCULO");
        Console.WriteLine();
        Console.Write("Informe a placa: ");
        string placa = Console.ReadLine();
        Veiculo v = vdao.BuscarPlaca(placa);
        
        Console.WriteLine($"Placa {v.placa}");
        Console.WriteLine($"Marca {v.marca}");
        Console.WriteLine($"Modelo {v.modelo}");
        Console.WriteLine($"NIV {v.niv}");
        Console.WriteLine($"Numero do motor {v.numeroMotor}");
        Console.WriteLine($"Renavan/7//77777777777 {v.renavan}");
       
    }

    else
    {
        break;
    }
    Console.WriteLine();
} while (true);


