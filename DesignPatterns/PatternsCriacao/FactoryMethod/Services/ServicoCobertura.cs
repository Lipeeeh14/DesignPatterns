using DesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.PatternsCriacao.FactoryMethod.Services
{
	public class ServicoCobertura : IServico
	{
        public ServicoCobertura()
        {
			Console.WriteLine("Produto Cobertura criado com sucesso!");
		}

        public void ExecutaCobrancaServico()
		{
			throw new NotImplementedException();
		}
	}
}
