namespace DesignPatterns.PatternsEstrutural.Adapter
{
	public class BusinessLegado
	{
        public string ExecutarRotinaContasPagar(string mes) 
        {
            var result = AcessoFakeSQL.GetDadosPagar(mes);

            Console.WriteLine("\nProcessando regras de negócio. . .");

            Thread.Sleep(3000);

            return result;
        }

		public string ExecutarRotinaContasReceber(string mes)
		{
			var result = AcessoFakeSQL.GetDadosReceber(mes);

			Console.WriteLine("\nProcessando regras de negócio. . .");

			Thread.Sleep(3000);

			return result;
		}
	}

    public class AcessoFakeSQL
    {
        public static string GetDadosPagar(string mes) 
        {
            Dictionary<string, string> dic = new();

            dic.Add("junho", "CNPJ:12345678912341\nRazão Social: Lojas Teste\nValor: 1200.00\nContato: (11) 1231-4563");
            dic.Add("julho", "CNPJ:12345678912341\nRazão Social: Lojas Teste\nValor: 1200.00\nContato: (11) 1231-4563");
            dic.Add("agosto", "CNPJ:12345678912341\nRazão Social: Lojas Teste\nValor: 1200.00\nContato: (11) 1231-4563");
            dic.Add("setembro", "CNPJ:12345678912341\nRazão Social: Lojas Teste\nValor: 1200.00\nContato: (11) 1231-4563");
            dic.Add("outrubro", "CNPJ:12345678912341\nRazão Social: Lojas Teste\nValor: 1200.00\nContato: (11) 1231-4563");

            return dic[mes];
        }

        public static string GetDadosReceber(string mes) 
        {
			Dictionary<string, string> dic = new();

			dic.Add("junho", "CNPJ:12345678912341\nRazão Social: Lojas Teste\nValor: 1200.00\nContato: (11) 1231-4563");
			dic.Add("julho", "CNPJ:12345678912341\nRazão Social: Lojas Teste\nValor: 1200.00\nContato: (11) 1231-4563");
			dic.Add("agosto", "CNPJ:12345678912341\nRazão Social: Lojas Teste\nValor: 1200.00\nContato: (11) 1231-4563");
			dic.Add("setembro", "CNPJ:12345678912341\nRazão Social: Lojas Teste\nValor: 1200.00\nContato: (11) 1231-4563");
			dic.Add("outrubro", "CNPJ:12345678912341\nRazão Social: Lojas Teste\nValor: 1200.00\nContato: (11) 1231-4563");

			return dic[mes];
		}
	}
}
