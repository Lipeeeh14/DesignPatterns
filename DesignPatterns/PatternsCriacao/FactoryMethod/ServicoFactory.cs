using DesignPatterns.PatternsCriacao.FactoryMethod.Enums;
using DesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;

namespace DesignPatterns.PatternsCriacao.FactoryMethod
{
	public abstract class ServicoFactory
	{
		public abstract IServico? CriarProduto(TiposServicosEnum tiposServicos);
	}
}
