namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // IMPLEMENTADO! 
            Console.WriteLine("Digite a placa do veículo para estacionar:\n");
            veiculos.Add(Console.ReadLine());
            Console.WriteLine();
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:\n");
            
            // IMPLEMENTADO! 
            string placa = Console.ReadLine();
            Console.WriteLine();
            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:\n");

                // IMPLEMENTADO! 
                int horas = int.Parse(Console.ReadLine());
                Console.WriteLine();
                
                
                decimal valorTotal = precoInicial + precoPorHora * horas; 

                // IMPLEMENTADO! 
                veiculos.Remove(placa);
                

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}\n");
                
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente \n");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: \n");
                // IMPLEMENTADO! 
                
                foreach (String veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.\n");
            }
        }
    }
}
