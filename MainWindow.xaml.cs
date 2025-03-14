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

namespace ejer7
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

        private void CalcularSalarios_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(NumTrabajadoresTextBox.Text, out double numerotrabajadores))
            {
                double x, salario, horastrabajadas, tarifa, suma;
                suma = 0;
                string output = "";

                for (x = 1; x <= numerotrabajadores; x = x + 1)
                {
                    output += $"Trabajador {x}:\n";

                    // Simulación de entrada de usuario (en WPF, se necesitarían controles adicionales)
                    // Para este ejemplo, usaremos MessageBox para obtener las entradas.
                    string horasInput = Microsoft.VisualBasic.Interaction.InputBox("Horas trabajadas:", $"Trabajador {x}");
                    string tarifaInput = Microsoft.VisualBasic.Interaction.InputBox("Tarifa:", $"Trabajador {x}");

                    if (double.TryParse(horasInput, out horastrabajadas) && double.TryParse(tarifaInput, out tarifa))
                    {
                        salario = horastrabajadas * tarifa;
                        suma = suma + salario;
                        output += $"  Horas: {horastrabajadas}, Tarifa: {tarifa}, Salario: {salario}\n\n";
                    }
                    else
                    {
                        output += "  Entrada inválida.\n\n";
                    }
                }

                output += $"La suma de los salarios es: {suma}";
                OutputTextBox.Text = output;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido de trabajadores.");
            }
        }
    }
}