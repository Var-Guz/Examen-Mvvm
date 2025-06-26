using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Examen_Mvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string producto1;

        [ObservableProperty]
        private string producto2;

        [ObservableProperty]
        private string producto3;

        [ObservableProperty]
        private decimal subtotal;

        [ObservableProperty]
        private decimal descuento;

        [ObservableProperty]
        private decimal total;

        [RelayCommand]
        private void Calcular()
        {
            try
            {
                decimal p1 = string.IsNullOrWhiteSpace(Producto1) ? 0 : Convert.ToDecimal(Producto1);
                decimal p2 = string.IsNullOrWhiteSpace(Producto2) ? 0 : Convert.ToDecimal(Producto2);
                decimal p3 = string.IsNullOrWhiteSpace(Producto3) ? 0 : Convert.ToDecimal(Producto3);

                Subtotal = p1 + p2 + p3;

                if (Subtotal >= 10000)
                    Descuento = Subtotal * 0.30m;
                else if (Subtotal >= 5000)
                    Descuento = Subtotal * 0.20m;
                else if (Subtotal >= 1000)
                    Descuento = Subtotal * 0.10m;
                else
                    Descuento = 0;

                Total = Subtotal - Descuento;
            }
            catch (Exception)
            {
                // Aquí puedes agregar una alerta si deseas
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            Producto1 = Producto2 = Producto3 = string.Empty;
            Subtotal = Descuento = Total = 0;
        }
    }

}
