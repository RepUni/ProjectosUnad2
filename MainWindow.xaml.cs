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

namespace ejer8
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
            if (int.TryParse(txtMinutos.Text, out int tiempo) && tiempo >= 0)
            {
                int dias = tiempo / 1440; // 1440 minutos en un día
                int minutosRestantes = tiempo % 1440;
                int horas = minutosRestantes / 60;
                int minutosFinales = minutosRestantes % 60;

                lblResultado.Content = $"Equivale a {dias} días, {horas} horas y {minutosFinales} minutos.";
                lblDetalles.Content = $"Detalles: {tiempo} minutos son {dias} días, {minutosRestantes} minutos restantes, {horas} horas y {minutosFinales} minutos finales.";
            }
            else
            {
                lblResultado.Content = "El tiempo no puede ser negativo o no válido.";
                lblDetalles.Content = ""; // Limpiar el label de detalles si hay un error
            }
        }
    }
}