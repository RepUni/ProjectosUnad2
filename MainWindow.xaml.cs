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

namespace ejer28
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

        private void IngresarEgresos_Click(object sender, RoutedEventArgs e)
        {
            double caja, egreso, cont, totalegresos, restocaja = 0;
            totalegresos = 0;
            caja = 371;
            cont = 0;
            string output = "";

            do
            {
                cont = cont + 1;
                string egresoInput = Interaction.InputBox($"Ingrese {cont} egreso: ", "Entrada de Egreso");

                if (double.TryParse(egresoInput, out egreso))
                {
                    totalegresos = totalegresos + egreso;
                    restocaja = caja - totalegresos;
                }
                else
                {
                    output += "Entrada inválida. Proceso cancelado.\n";
                    break;
                }
            }
            while (egreso != -1);

            output += $"\nEl total de egresos es: {totalegresos + 1}\n";
            output += $"Lo sobrante en caja es: {restocaja - 1}";

            ResultadoTextBox.Text = output;
        }

    }
}