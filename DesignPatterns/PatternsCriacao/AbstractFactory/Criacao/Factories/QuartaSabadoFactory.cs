using DesignPatterns.PatternsCriacao.AbstractFactory.Criacao.Interfaces;
using DesignPatterns.PatternsCriacao.AbstractFactory.Produto;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.Criacao.Factories
{
	public class QuartaSabadoFactory : IFactory
	{
		public QuartaSabadoFactory()
		{
			ObterRotinaDiaria();
		}

		public void ObterRotinaDiaria()
		{
			Console.WriteLine("Factory Quarta e Sábado");

			var dieta = new DietaQuartaSabado();
			var treino = new TreinoQuartaSabado();

			dieta.ObterAlimentacao();
			treino.ObterTreino();
		}
	}
}
