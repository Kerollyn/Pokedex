﻿using Pokedex.Service.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;

namespace Pokedex.ViewModels
{
    public class EditarPokemonPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _navigationService;
        private IPokemonService _pokemonService;

        private PokemonViewModel _pokemon;
        public PokemonViewModel Pokemon
        {
            get { return _pokemon; }
            set { SetProperty(ref _pokemon, value); }
        }

        private string _nomePokemon;
        public string NomePokemon
        {
            get { return _nomePokemon; }
            set { SetProperty(ref _nomePokemon, value); }
        }

        public DelegateCommand SalvarCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    _pokemonService.Atualizar(_pokemon);
                    _navigationService.GoBackAsync();
                });
            }
        }

        public EditarPokemonPageViewModel(INavigationService navigationService,
            IPokemonService pokemonService)
        {
            _navigationService = navigationService;
            _pokemonService = pokemonService;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Pokemon = parameters["pokemon"] as PokemonViewModel;
            NomePokemon = parameters["nomePokemon"].ToString();
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {

        }
    }
}