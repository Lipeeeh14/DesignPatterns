using DesignPatterns.PatternsCriacao.AbstractFactory.Criacao.Interfaces;
using DesignPatterns.PatternsCriacao.AbstractFactory.Produto;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.Criacao.Factories
{
	public class SegundaQuintaFactory : IFactory
	{
        public SegundaQuintaFactory()
        {
			ObterRotinaDiaria();
        }

        public void ObterRotinaDiaria()
		{
			Console.WriteLine("Factory Segunda e Quinta");

			var dieta = new DietaSegundaQuinta();
			var treino = new TreinoSegundaQuinta();

			dieta.ObterAlimentacao();
			treino.ObterTreino();
		}
	}
}
