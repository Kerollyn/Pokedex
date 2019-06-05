using Pokedex.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Pokedex.Service.Interfaces
{
    public interface IPokemonService
    {
        ObservableCollection<PokemonViewModel> Todos();
        void Inserir(PokemonViewModel pokemon);
        void Atualizar(PokemonViewModel pokemon);
        void Excluir(PokemonViewModel pokemon);
    }
}
