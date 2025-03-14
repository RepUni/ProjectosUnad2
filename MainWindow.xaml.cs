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

namespace ejer20
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
        private void IniciarProcesos_Click(object sender, RoutedEventArgs e)
        {
            double numero, c, cubo, raizcuadrada;
            c = 0;
            string output = "";

            do
            {
                c = c + 1;
                output += $"PROCESO No{c}:\n";

                string numeroInput = Interaction.InputBox("ingrese un numero: ", $"PROCESO No{c}");

                if (double.TryParse(numeroInput, out numero))
                {
                    if (numero != 0)
                    {
                        cubo = Math.Pow(numero, 3);
                        raizcuadrada = Math.Round(Math.Pow(numero, 0.5), 2);

                        output += $"El cubo es: {cubo}\n";
                        output += $"La raiz cuadrada es: {raizcuadrada}\n\n";
                    }
                }
                else
                {
                    output += "Entrada inválida. Proceso cancelado.\n\n";
                    break;
                }

            }
            while (numero != 0);

            output += "\nFINAL DEL PROCESO";
            ResultadoTextBox.Text = output;
        }
    }
}