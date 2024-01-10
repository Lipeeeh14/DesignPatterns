using DesignPatterns.PatternsCriacao.Builder.Builders;
using DesignPatterns.PatternsCriacao.Builder.Studios;

namespace DesignPatterns.PatternsCriacao.Builder
{
	public class ClientBuilder
	{
		public void ConsumirDadosStudio() 
		{
			StudioBuilder studioBuilder;
			Studio studio;

			studioBuilder = new Studio24mBuilder();
			Director.ConstruirStudio(studioBuilder);
			studio = studioBuilder.GetStudio();
			ImprimirResultado(studio, "24m");

			studioBuilder = new Studio26mBuilder();
			Director.ConstruirStudio(studioBuilder);
			studio = studioBuilder.GetStudio();
			ImprimirResultado(studio, "26m");

			studioBuilder = new Studio28mBuilder();
			Director.ConstruirStudio(studioBuilder);
			studio = studioBuilder.GetStudio();
			ImprimirResultado(studio, "28m");
		}

		private void ImprimirResultado(Studio studio, string nome)
		{
			Console.WriteLine(new String('-', 40));
			Console.WriteLine($"[*] - Studio {nome}");
			Console.WriteLine("Valor: {0}\nPiso: {1}\nFinanciamento: {2}",
				studio.ValorStudio.ToString("C"),
				studio.Piso,
				studio.TipoFinanciamento);
		}
	}
}
