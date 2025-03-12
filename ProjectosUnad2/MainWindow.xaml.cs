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

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtHoras.Text, out double horasTrabajadas) &&
                double.TryParse(txtTarifa.Text, out double tarifa))
            {
                if (horasTrabajadas >= 0)
                {
                    double salario;
                    if (horasTrabajadas <= 40)
                    {
                        salario = horasTrabajadas * tarifa;
                    }
                    else
                    {
                        double horasExtra = horasTrabajadas - 40;
                        double tarifaExtra = tarifa * 1.5;
                        salario = (40 * tarifa) + (horasExtra * tarifaExtra);
                    }
                    txtSalario.Text = salario.ToString("C"); // Formatear como moneda
                    lblMensaje.Content = ""; // Limpiar mensajes de error
                }
                else
                {
                    lblMensaje.Content = "Las horas trabajadas no pueden ser negativas.";
                    txtSalario.Text = "";
                }
            }
            else
            {
                lblMensaje.Content = "Ingrese valores numéricos válidos.";
                txtSalario.Text = "";
            }
        }


    }
}