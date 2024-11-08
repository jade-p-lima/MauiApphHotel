
using MauiApphHotel.Models;

namespace MauiApphHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>()
        {
            new Quarto()
            {
                Descricao = "Suite Super Luxo",
                ValorDiariaAdulto = 110.00,
                ValorDiariaCrianca = 55.00,
            },
             new Quarto()
            {
                Descricao = "Suite Luxo",
                ValorDiariaAdulto = 85.00,
                ValorDiariaCrianca = 45.00,
            }, 
            new Quarto()
            {
                Descricao = "Suite Single",
                ValorDiariaAdulto = 60.00,
                ValorDiariaCrianca = 15.00,
            },
            new Quarto()
            {
                Descricao = "Suite Crise",
                ValorDiariaAdulto = 45.00,
                ValorDiariaCrianca = 15.00,
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height= 600;

            return window;  
        }
    }
}
