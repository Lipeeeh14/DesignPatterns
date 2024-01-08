using DesignPatterns.PatternsCriacao.AbstractFactory.Produto.Interfaces;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.Produto
{
	public class TreinoTercaSexta : ITreino
	{
        public TreinoTercaSexta()
        {
			ObterTreino();
		}

        public void ObterTreino()
		{
			Console.WriteLine("Treino Terça e Sexta Feira. . .");
		}
	}
}
