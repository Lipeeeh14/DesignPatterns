using DesignPatterns.PatternsCriacao.AbstractFactory.Criacao.Factories;
using DesignPatterns.PatternsCriacao.AbstractFactory.Criacao.Interfaces;
using DesignPatterns.PatternsCriacao.FactoryMethod.Enums;
using DesignPatterns.PatternsCriacao.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsCriacao.AbstractFactory
{
	public class ClientAbstractFactory
	{
		public void ConsultarRotinaAluno() 
		{
			var continuar = true;

			while (continuar) 
			{
				Console.WriteLine("Selecione a rotina desejada:\n");
				Console.WriteLine("1 - Segunda e Quinta");
				Console.WriteLine("2 - Terça e Sexta");
				Console.WriteLine("3 - Quarta e Sábado");

				Console.WriteLine("Digite o número da rotina que deseja: ");
				int opcao = Convert.ToInt32(Console.ReadLine());

				switch (opcao)
				{
					case 1:
						_ = new SegundaQuintaFactory();
						break;
					case 2:
						_ = new TercaSextaFactory();
						break;
					case 3:
						_ = new QuartaSabadoFactory();
						break;
					default:
						break;
				}

				Console.WriteLine("Deseja selecionar outra rotina? (1-Sim ou 2-Não): ");
				int resposta = Convert.ToInt32(Console.ReadLine());

				continuar = resposta == 1;
			}
		}
	}
}
