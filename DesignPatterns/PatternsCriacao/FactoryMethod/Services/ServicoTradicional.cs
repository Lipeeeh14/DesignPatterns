using DesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.PatternsCriacao.FactoryMethod.Services
{
	public class ServicoTradicional : IServico
	{
        public ServicoTradicional()
        {
			Console.WriteLine("Produto Tradicional criado com sucesso!");
		}

        public void ExecutaCobrancaServico()
		{
			throw new NotImplementedException();
		}
	}
}
