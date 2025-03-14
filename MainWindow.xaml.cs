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

namespace ejer4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtSegundos.Text, out int tiempoSegundos) && tiempoSegundos >= 0)
            {
                int minutos = tiempoSegundos / 60;
                int segundosRestantes = tiempoSegundos % 60;
                lblResultado.Content = $"Equivale a {minutos} minutos y {segundosRestantes} segundos.";
            }
            else
            {
                lblResultado.Content = "Entrada inválida. Ingrese un número positivo.";
            }
        }
    }
}