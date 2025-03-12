using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectosUnad2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //ejercicio #2
        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtSueldo.Text, out double sueldo))
            {
                if (sueldo >= 0)
                {
                    double descuento, sueldoNeto;

                    if (sueldo <= 1000)
                    {
                        descuento = sueldo * 0.1;
                    }
                    else if (sueldo <= 2000)
                    {
                        descuento = (sueldo - 1000) * 0.05 + (1000 * 0.1);
                    }
                    else
                    {
                        descuento = (sueldo - 2000) * 0.03 + (1000 * 0.05) + (1000 * 0.1);
                    }

                    sueldoNeto = sueldo - descuento;

                    txtDescuento.Text = descuento.ToString("C");
                    txtSueldoNeto.Text = sueldoNeto.ToString("C");
                    lblMensaje.Content = "";
                }
                else
                {
                    lblMensaje.Content = "El sueldo no puede ser negativo.";
                    txtDescuento.Text = "";
                    txtSueldoNeto.Text = "";
                }
            }
            else
            {
                lblMensaje.Content = "Ingrese un valor numérico válido para el sueldo.";
                txtDescuento.Text = "";
                txtSueldoNeto.Text = "";
            }
        }


    }
}