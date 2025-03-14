using Microsoft.VisualBasic;
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

namespace ejer14
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
        private void CalcularMedia_Click(object sender, RoutedEventArgs e)
        {
            double suma = 0;
            double x, numero;
            string output = "";

            for (x = 1; x <= 10; x = x + 1)
            {
                string input = Interaction.InputBox($"Ingrese {x}o número:", "Entrada de Número");

                if (double.TryParse(input, out numero))
                {
                    suma = suma + numero;
                }
                else
                {
                    output += $"Entrada inválida para el número {x}.\n";
                    x--; // Decrementamos x para repetir la entrada.
                }

            }

            double media = Math.Round(suma / 100, 2);
            output += $"\nLa media de los {x - 1} números ingresados es: {media}";
            ResultadoTextBox.Text = output;
        }
    }
}