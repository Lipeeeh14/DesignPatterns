using DesignPatterns.PatternsCriacao.AbstractFactory.Produto.Interfaces;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.Produto
{
	public class DietaQuartaSabado : IDieta
	{
		public DietaQuartaSabado()
		{
			ObterAlimentacao();
		}

		public void ObterAlimentacao()
		{
			Console.WriteLine("Dieta de Quarta e Sabado. . .");
		}
	}
}
