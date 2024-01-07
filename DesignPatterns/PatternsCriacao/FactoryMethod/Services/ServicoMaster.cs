using DesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.PatternsCriacao.FactoryMethod.Services
{
	public class ServicoMaster : IServico
	{
        public ServicoMaster()
        {
			Console.WriteLine("Produto Master criado com sucesso!");
		}

        public void ExecutaCobrancaServico()
		{
			throw new NotImplementedException();
		}
	}
}
