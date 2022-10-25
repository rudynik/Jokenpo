using Jokenpo.Enums;
using Jokenpo.Interfaces;
using System;

namespace Jokenpo.Implementacoes
{
    public class RegrasComLagarto : IRegras
    {
        public Jogada[] Vitoria { get; set; }

        public Jogada[] CarregarRegras(Jogada jogada)
        {
            switch (jogada)
            {
                case Jogada.Pedra:
                    Vitoria = new Jogada[] { Jogada.Tesoura, Jogada.Lagarto };
                    return Vitoria;
                case Jogada.Papel:
                    Vitoria = new Jogada[] { Jogada.Pedra };
                    return Vitoria;
                case Jogada.Tesoura:
                    Vitoria = new Jogada[] { Jogada.Papel, Jogada.Lagarto };
                    return Vitoria;
				case Jogada.Lagarto:
					Vitoria = new Jogada[] { Jogada.Papel };
					return Vitoria;
				default:
                    return Array.Empty<Jogada>();
            }
        }
    }
}
