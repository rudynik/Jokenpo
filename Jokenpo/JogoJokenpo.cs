using Jokenpo.Interfaces;
using Jokenpo.Models;
using System.Collections.Generic;
using System.Linq;

namespace Jokenpo
{
    public static class JogoJokenpo
    {
        public static string Jogar(IRegras regras, params Jogador[] jogadores)
        {
            {
                if (jogadores.Count() < 2)
                    return "Necessário Pelo menos dois Jogadores no jogo";

                var mesmoNome = jogadores.GroupBy(x => x.Nome);

                if (mesmoNome.Any(x => x.Count() > 1))
                    return "Necessário Jogadores com nomes diferentes!";

                var maisDeUmGanhador = new List<Jogador>();

                foreach (var jogador in jogadores)
                {
                    var adversarios = jogadores.Where(x => x.Nome != jogador.Nome).Select(x => x.Jogada);

                    var regra = regras.CarregarRegras(jogador.Jogada);

                    if (!regra.Any())
                        return $"Nenhuma regra criada para jogada {jogador.Jogada} do jogador {jogador.Nome}";

                    if (!regra.Except(adversarios).Any())
                        maisDeUmGanhador.Add(jogador);
                }

                if (maisDeUmGanhador.Count > 1 || !maisDeUmGanhador.Any())
                    return "O jogo terminou Empatado";

                var vencedor = maisDeUmGanhador.First();

                return $"O jogador {vencedor.Nome} Ganhou!";
            }
        }
    }
}
