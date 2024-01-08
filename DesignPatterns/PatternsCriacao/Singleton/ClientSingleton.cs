namespace DesignPatterns.PatternsCriacao.Singleton
{
	public class ClientSingleton
	{
		public void ConsumirDB() 
		{
			var instancia = ContextDB.Instancia;
			instancia.ExecutaQuery("SELECT * FROM Pessoa;");

			instancia = ContextDB.Instancia;
			instancia.ExecutaQuery("SELECT * FROM Usuario;");

			instancia = ContextDB.Instancia;
			instancia.ExecutaQuery("SELECT * FROM Aluno;");
		}
	}
}
