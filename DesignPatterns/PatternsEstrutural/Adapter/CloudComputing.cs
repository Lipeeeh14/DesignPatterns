using DesignPatterns.PatternsEstrutural.Adapter.Interfaces;

namespace DesignPatterns.PatternsEstrutural.Adapter
{
	public class CloudComputing
	{
		IAdapter adapter;

		public CloudComputing()
		{
			this.adapter = new Adapter(new BusinessLegado());
		}

		public void ProcessarContas(string mes) 
		{
			var result = this.adapter.ExecutarRotinaContasPagar(mes);

			Console.WriteLine("Processando contas a pagar. . .");
			Thread.Sleep(3000);

			Console.WriteLine(new String('-', 40));

			result = this.adapter.ExecutarRotinaContasReceber(mes);

			Console.WriteLine("Processando contas a receber. . .");
			Thread.Sleep(3000);

			Console.WriteLine("\nProcesso executado.");
		}
	}
}
