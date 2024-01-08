namespace DesignPatterns.PatternsCriacao.Singleton
{
	public class ContextDB
	{
		private static ContextDB? _instancia;

		private ContextDB() { }

        public static ContextDB Instancia 
		{
			get 
			{
				if (_instancia == null) 
				{
					_instancia = new ContextDB();
					Console.WriteLine("Instância Criada!");
				}
				
				return _instancia;
			} 
		}

		public void ExecutaQuery(string query) 
		{
			Console.WriteLine(query);
		}
	}
}
