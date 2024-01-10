namespace DesignPatterns.PatternsCriacao.Builder.Studios
{
	public class Studio
	{
		public string Piso { get; set; } = string.Empty;
		public string TipoFinanciamento { get; set; } = string.Empty;
        public decimal ValorStudio { get; set; }

		public void DefinirValorStudio(decimal valor)
			=> ValorStudio = valor;

		public void EscolherFinanciamento(string financiamento)
			=> TipoFinanciamento = financiamento;

		public void EscolherPiso(string piso)
			=> Piso = piso;
	}
}
