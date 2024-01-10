namespace DesignPatterns.PatternsCriacao.Builder.Builders
{
	public class Studio28mBuilder : StudioBuilder
	{
		public override void DefinirValorStudio()
			=> studio.DefinirValorStudio(250000.00M);

		public override void EscolherFinanciamento()
			=> studio.EscolherFinanciamento("FinanciaFinanciamentos");

		public override void EscolherPiso()
			=> studio.EscolherPiso("Vinilico");
	}
}
