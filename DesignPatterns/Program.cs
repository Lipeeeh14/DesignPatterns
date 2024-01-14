using DesignPatterns.PatternsCriacao.AbstractFactory;
using DesignPatterns.PatternsCriacao.Builder;
using DesignPatterns.PatternsCriacao.FactoryMethod;
using DesignPatterns.PatternsCriacao.Prototype;
using DesignPatterns.PatternsCriacao.Singleton;
using DesignPatterns.PatternsEstrutural.Adapter;

// Criação

//ClientFactory clientFactory = new();
//clientFactory.ExecutarCriacaoProduto();

//ClientAbstractFactory clientAbstractFactory = new();
//clientAbstractFactory.ConsultarRotinaAluno();

//ClientSingleton clientSingleton = new();
//clientSingleton.ConsumirDB();

//ClientBuilder client = new();
//client.ConsumirDadosStudio();

//ClientPrototype client = new();
//client.ConsumirServico();

// Estrutural

CloudComputing cloud = new();

cloud.ProcessarContas("setembro");