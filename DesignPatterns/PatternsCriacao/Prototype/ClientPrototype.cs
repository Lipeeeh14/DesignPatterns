namespace DesignPatterns.PatternsCriacao.Prototype
{
	public class ClientPrototype
	{
		public void ConsumirServico() 
		{
			GerenciadorVendasStudio gerenciador = new();

			gerenciador["24m"] = new Studio("24m^2", "EmpEmpreendimentos", 180000.00M);
			gerenciador["26m"] = new Studio("26m^2", "FinanFinanciamentos", 210000.00M);
			gerenciador["28m"] = new Studio("28m^2", "ImaImóveis", 250000.00M);

			StudioModel studio24Clone1 = gerenciador["24m"].Clone();
			StudioModel studio24Clone2 = gerenciador["24m"].Clone();

			StudioModel studio26Clone1 = gerenciador["26m"].Clone();
			StudioModel studio26Clone2 = gerenciador["26m"].Clone();

			StudioModel studio28Clone1 = gerenciador["28m"].Clone();
			StudioModel studio28Clone2 = gerenciador["28m"].Clone();
		}
	}
}
