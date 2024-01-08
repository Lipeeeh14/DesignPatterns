using DesignPatterns.PatternsCriacao.AbstractFactory.Produto.Interfaces;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.Produto
{
	public class DietaSegundaQuinta : IDieta
	{
		public DietaSegundaQuinta()
		{
			ObterAlimentacao();
		}

		public void ObterAlimentacao()
		{
			Console.WriteLine("Dieta de Segunda e Quinta Feira. . .");
		}
	}
}
