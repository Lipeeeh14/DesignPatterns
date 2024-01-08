using DesignPatterns.PatternsCriacao.AbstractFactory.Produto.Interfaces;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.Produto
{
	public class TreinoSegundaQuinta : ITreino
	{
        public TreinoSegundaQuinta()
        {
			ObterTreino();
		}

        public void ObterTreino()
		{
			Console.WriteLine("Treino Segunda e Quinta Feira. . .");
		}
	}
}
