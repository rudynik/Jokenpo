using Jokenpo.Enums;
using Jokenpo.Implementacoes;
using Jokenpo.Models;
using System;

namespace Jokenpo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var regrasClassico = new Regras();

			var jogadorClassico1 = new Jogador { Nome = "João", Jogada = Jogada.Papel };
			var jogadorClassico2 = new Jogador { Nome = "Maria", Jogada = Jogada.Pedra };
			var jogadorClassico3 = new Jogador { Nome = "José", Jogada = Jogada.Pedra };

			var resultadoClassico = JogoJokenpo.Jogar(regrasClassico, jogadorClassico1, jogadorClassico2, jogadorClassico3);

			Console.WriteLine("Jokenpo clássico");
			Console.WriteLine(resultadoClassico);

			var regrasComLagarto = new RegrasComLagarto();

			var jogadorComLagarto1 = new Jogador { Nome = "João", Jogada = Jogada.Papel };
			var jogadorComLagarto2 = new Jogador { Nome = "Maria", Jogada = Jogada.Lagarto };
			var jogadorComLagarto3 = new Jogador { Nome = "José", Jogada = Jogada.Papel };

			var resultadoComLagarto = JogoJokenpo.Jogar(regrasComLagarto, jogadorComLagarto1, jogadorComLagarto2, jogadorComLagarto3);

			Console.WriteLine("Jokenpo com lagarto");
			Console.WriteLine(resultadoComLagarto);

			var regrasComSpock = new RegrasComSpock();

			var jogadorComSpock1 = new Jogador { Nome = "João", Jogada = Jogada.Tesoura };
			var jogadorComSpock2 = new Jogador { Nome = "Maria", Jogada = Jogada.Pedra };
			var jogadorComSpock3 = new Jogador { Nome = "José", Jogada = Jogada.Spock };

			var resultadoComSpock = JogoJokenpo.Jogar(regrasComSpock, jogadorComSpock1, jogadorComSpock2, jogadorComSpock3);

			Console.WriteLine("Jokenpo com spock");
			Console.WriteLine(resultadoComSpock);

			Console.ReadLine();
		}
	}
}
