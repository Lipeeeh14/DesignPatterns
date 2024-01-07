using DesignPatterns.PatternsCriacao.FactoryMethod.Enums;

namespace DesignPatterns.PatternsCriacao.FactoryMethod
{
	public class ClientFactory
	{
		public void ExecutarCriacaoProduto()
		{
			var servico = new SelecionaServico();
			var continuar = true;

			while (continuar) 
			{
				Console.WriteLine("Selecione o tipo de serviço:\n");
				Console.WriteLine("0 - Tradicional");
				Console.WriteLine("1 - Premium");
				Console.WriteLine("2 - Master");
				Console.WriteLine("3 - Cobertura");

				Console.WriteLine("Digite o número do serviço que deseja cobrar: ");
				int tipoServico = Convert.ToInt32(Console.ReadLine());

				var servicoProduto = servico.CriarProduto((TiposServicosEnum)tipoServico);

				//servicoProduto!.ExecutaCobrancaServico();

				Console.WriteLine("Deseja calcular outro serviço? (1-Sim ou 2-Não): ");
				int resposta = Convert.ToInt32(Console.ReadLine());

				continuar = resposta == 1;
			}
		}
	}
}
