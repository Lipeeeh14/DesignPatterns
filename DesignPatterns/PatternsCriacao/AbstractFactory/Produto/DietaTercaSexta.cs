using DesignPatterns.PatternsCriacao.AbstractFactory.Produto.Interfaces;

namespace DesignPatterns.PatternsCriacao.AbstractFactory.Produto
{
	public class DietaTercaSexta : IDieta
	{
		public DietaTercaSexta()
		{
			ObterAlimentacao();
		}

		public void ObterAlimentacao()
		{
			Console.WriteLine("Dieta de Terça e Sexta Feira. . .");
		}
	}
}
