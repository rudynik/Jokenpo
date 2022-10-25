using Jokenpo.Enums;

namespace Jokenpo.Interfaces
{
	public interface IRegras
	{
		Jogada[] Vitoria { get; set; }
		Jogada[] CarregarRegras(Jogada jogada);
	}
}
