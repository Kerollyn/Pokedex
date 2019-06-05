using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokedex.ViewModels
{
    public class DetalhesPokemonPageViewModel : BindableBase, INavigationAware
    {
        private PokemonViewModel _pokemon;
        public PokemonViewModel Pokemon
        {
            get { return _pokemon; }
            set { SetProperty(ref _pokemon, value); }
        }


        public DetalhesPokemonPageViewModel()
        {

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Pokemon = parameters["pokemon"] as PokemonViewModel;
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}

