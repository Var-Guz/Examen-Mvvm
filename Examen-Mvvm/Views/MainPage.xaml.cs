using Microsoft.Maui.Controls;
using Examen_Mvvm.ViewModels;

namespace Examen_Mvvm.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}

