using Prism;
using Prism.Ioc;
using Pokedex.ViewModels;
using Pokedex.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pokedex.Service.Interfaces;
using Pokedex.Service.Impl;
using HelloWorldPrism.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Pokedex
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

           await NavigationService.NavigateAsync("NavigationPage/ListagemPokemonsPage");
          
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register(typeof(IPokemonService), typeof(InMemoryPokemonService));

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<CriarPokemonPage, CriarPokemonPageViewModel>();
            containerRegistry.RegisterForNavigation<DetalhesPokemonPage, DetalhesPokemonPageViewModel>();
            containerRegistry.RegisterForNavigation<EditarPokemonPage, EditarPokemonPageViewModel>();
            containerRegistry.RegisterForNavigation<ListagemPokemonsPage, ListagemPokemonsPageViewModel>();
            
        }
    }
}
