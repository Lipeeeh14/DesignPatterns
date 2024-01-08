using DesignPatterns.PatternsCriacao.AbstractFactory.Criacao.Interfaces;
using DesignPatterns.PatternsCriacao.AbstractFactory.Produto;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.Criacao.Factories
{
	public class TercaSextaFactory : IFactory
	{
		public TercaSextaFactory()
		{
			ObterRotinaDiaria();
		}

		public void ObterRotinaDiaria()
		{
			Console.WriteLine("Factory Terça e Sexta");

			var dieta = new DietaTercaSexta();
			var treino = new TreinoTercaSexta();

			dieta.ObterAlimentacao();
			treino.ObterTreino();
		}
	}
}
