using DesignPatterns.PatternsCriacao.Builder.Builders;

namespace DesignPatterns.PatternsCriacao.Builder
{
	public class Director
	{
		public static void ConstruirStudio(StudioBuilder builder) 
		{
			builder.EscolherPiso();
			builder.EscolherFinanciamento();
			builder.DefinirValorStudio();
		}
	}
}
