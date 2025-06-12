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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().Trim().ToUpper();

            veiculos.Add(placa);

            Console.WriteLine($"Veículo com placa {placa} adicionado com sucesso!");
            
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
                string placa = Console.ReadLine().Trim().ToUpper();

            // Verifica se o veículo existe

            if (veiculos.Any(x => x == placa))

            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    int horas = Convert.ToInt32(Console.ReadLine());

                    decimal valorTotal = precoInicial + (precoPorHora * horas);

                    Console.WriteLine($"Preço Inicial R$ {precoInicial:F2}, + preço por hora R$ {precoPorHora:F2}, = Valor Total {valorTotal}");

                 // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                 // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                 // *IMPLEMENTE AQUI*

                 veiculos.RemoveAll(x => x.Trim().ToUpper() == placa.Trim().ToUpper());

          
                    // TODO: Remover a placa digitada da lista de veículos
                    // *IMPLEMENTE AQUI*

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
                  
            }

            else

            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*

                 for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"Carro nº {i + 1}: Placa {veiculos[i]}");
                }

               
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
