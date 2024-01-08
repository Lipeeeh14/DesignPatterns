using DesignPatterns.PatternsCriacao.AbstractFactory.Produto.Interfaces;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.Produto
{
	public class TreinoQuartaSabado : ITreino
	{
		public TreinoQuartaSabado()
		{
			ObterTreino();
		}

		public void ObterTreino()
		{
			Console.WriteLine("Treino Quarta e Sábado. . .");
		}
	}
}
