using DesignPatterns.PatternsCriacao.Builder.Studios;

namespace DesignPatterns.PatternsCriacao.Builder.Builders
{
	public class Studio24mBuilder : StudioBuilder
	{
		public Studio24mBuilder()
		{
		}

		public override void DefinirValorStudio()
			=> studio.DefinirValorStudio(100000.00M);

		public override void EscolherFinanciamento()
			=> studio.EscolherFinanciamento("FinaMovelFinanciamentos");

		public override void EscolherPiso()
			=> studio.EscolherPiso("Cerâmica");
	}
}
