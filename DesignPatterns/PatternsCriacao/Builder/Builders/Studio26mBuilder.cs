namespace DesignPatterns.PatternsCriacao.Builder.Builders
{
	public class Studio26mBuilder : StudioBuilder
	{
		public override void DefinirValorStudio()
			=> studio.DefinirValorStudio(190000.00M);

		public override void EscolherFinanciamento()
			=> studio.EscolherFinanciamento("TesteFinanciamentos");

		public override void EscolherPiso()
			=> studio.EscolherPiso("Porcelanato");
	}
}
