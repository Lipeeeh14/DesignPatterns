using DesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.PatternsCriacao.FactoryMethod.Services
{
	public class ServicoPremium : IServico
	{
		public ServicoPremium()
		{
			Console.WriteLine("Produto Premium criado com sucesso!");
		}

		public void ExecutaCobrancaServico()
		{
			throw new NotImplementedException();
		}
	}
}
