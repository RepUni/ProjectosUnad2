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

namespace ejer21
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
            double num1, num2, c, suma, resta, multiplicacion, division;
            c = 0;
            string output = "";

            do
            {
                c = c + 1;
                output += $"PROCESO No{c}:\n";

                string num1Input = Interaction.InputBox("ingrese primer numero: ", $"PROCESO No{c}");

                if (double.TryParse(num1Input, out num1))
                {
                    if (num1 != 0)
                    {
                        string num2Input = Interaction.InputBox("ingrese segundo numero: ", $"PROCESO No{c}");

                        if (double.TryParse(num2Input, out num2))
                        {
                            suma = num1 + num2;
                            resta = num1 - num2;
                            multiplicacion = num1 * num2;
                            division = Math.Round(num1 / num2, 2);

                            output += $"\nLa suma es: {suma}\n";
                            output += $"La resta es : {resta}\n";
                            output += $"La multiplicacion es: {multiplicacion}\n";
                            output += $"La division es: {division}\n\n";
                        }
                        else
                        {
                            output += "Entrada inválida (segundo número). Proceso cancelado.\n\n";
                            break;
                        }
                    }
                }
                else
                {
                    output += "Entrada inválida (primer número). Proceso cancelado.\n\n";
                    break;
                }

            }
            while (num1 != 0);

            output += "\nFINAL DEL PROCESO";
            ResultadoTextBox.Text = output;
        }
    }
}