using DesignPatterns.PatternsCriacao.AbstractFactory;
using DesignPatterns.PatternsCriacao.Builder;
using DesignPatterns.PatternsCriacao.FactoryMethod;
using DesignPatterns.PatternsCriacao.Singleton;

//ClientFactory clientFactory = new();
//clientFactory.ExecutarCriacaoProduto();

//ClientAbstractFactory clientAbstractFactory = new();
//clientAbstractFactory.ConsultarRotinaAluno();

//ClientSingleton clientSingleton = new();
//clientSingleton.ConsumirDB();

ClientBuilder client = new();
client.ConsumirDadosStudio();