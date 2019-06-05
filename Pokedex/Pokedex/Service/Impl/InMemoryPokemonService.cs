using Pokedex.Service.Interfaces;
using Pokedex.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Pokedex.Service.Impl
{
    public class InMemoryPokemonService : IPokemonService
    {
        private static ObservableCollection<PokemonViewModel> _pokemons = new ObservableCollection<PokemonViewModel>();

        public InMemoryPokemonService()
        {
        }

        public void Atualizar(PokemonViewModel pokemon)
        {

        }

        public void Excluir(PokemonViewModel pokemon)
        {
            _pokemons.Remove(pokemon);
        }

        public void Inserir(PokemonViewModel pokemon)
        {
            _pokemons.Add(pokemon);
        }

        public ObservableCollection<PokemonViewModel> Todos()
        {
            if (_pokemons.Count == 0)
            {
                _pokemons.Add(new PokemonViewModel
                {
                    Numero = 1,
                    Nome = "Bulbassauro"
                });
            }
            return _pokemons;
        }
    }
}