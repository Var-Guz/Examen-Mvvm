﻿namespace Examen_Mvvm.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.MainViewModel();
        }
    }

}
