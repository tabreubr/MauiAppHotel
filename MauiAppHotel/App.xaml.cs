﻿using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto(){
                Descricao = "Suíte de Luxo",
                ValorDiariaAdulto = 200.0,
                ValorDiariaCrianca = 100.0
            },
            new Quarto(){
                Descricao = "Suíte Padrão",
                ValorDiariaAdulto = 100.0,
                ValorDiariaCrianca = 50.0
            },
            new Quarto(){
                Descricao = "Suíte Simples",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 25.0
            },
            new Quarto(){
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 25.0,
                ValorDiariaCrianca = 12.5
            },
        };


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 450;
            window.Height = 850;

            return window;
        }
    }
}