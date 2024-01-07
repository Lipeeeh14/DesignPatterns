using DesignPatterns.PatternsCriacao.FactoryMethod.Enums;
using DesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;
using DesignPatterns.PatternsCriacao.FactoryMethod.Services;

namespace DesignPatterns.PatternsCriacao.FactoryMethod
{
	public class SelecionaServico : ServicoFactory
	{
		public override IServico? CriarProduto(TiposServicosEnum tiposServicos)
		{
			// É possível utilizar outras formas de implementação, utilizando Dictionary, por exemplo.

			return tiposServicos switch
			{
				TiposServicosEnum.tradicional => new ServicoTradicional(),
				TiposServicosEnum.premium => new ServicoPremium(),
				TiposServicosEnum.master => new ServicoMaster(),
				TiposServicosEnum.cobertura => new ServicoCobertura(),
				_ => null,
			};
		}
	}
}
