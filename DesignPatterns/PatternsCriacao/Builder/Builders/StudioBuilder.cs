using DesignPatterns.PatternsCriacao.Builder.Studios;

namespace DesignPatterns.PatternsCriacao.Builder.Builders
{
	public abstract class StudioBuilder
	{
		// É possível construir classes específicas que herdam dessa classe genérica
		// e o builder de cada uma delas faça a criação do objeto
		protected Studio studio = new();

		public Studio GetStudio() => studio;

		public abstract void EscolherPiso();
		public abstract void EscolherFinanciamento();
		public abstract void DefinirValorStudio();
	}
}
