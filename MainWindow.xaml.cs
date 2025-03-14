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

namespace ejer9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double ca = 0;
        private double cd = 0;
        private double acumuladas = 0;
        private double acumuladasapro = 0;
        private double acumuladasdesapro = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtNota.Text, out double nota))
            {
                if (nota <= 10.5 && nota >= 0)
                {
                    cd++;
                    acumuladasdesapro += nota;
                }
                else if (nota > 10.5 && nota <= 20)
                {
                    ca++;
                    acumuladasapro += nota;
                }
                acumuladas += nota;

                if (!chkOtraNota.IsChecked.Value)
                {
                    double promedioaprobadas = ca > 0 ? Math.Round(acumuladasapro / ca, 1) : 0;
                    double promediodesaprobadas = cd > 0 ? Math.Round(acumuladasdesapro / cd, 1) : 0;
                    double promedio = (ca + cd) > 0 ? Math.Round(acumuladas / (ca + cd), 1) : 0;

                    lblDesaprobadas.Content = $"Cantidad de notas desaprobadas: {cd}";
                    lblAprobadas.Content = $"Cantidad de notas aprobadas: {ca}";
                    lblPromedioAprobadas.Content = $"Promedio de notas aprobadas: {promedioaprobadas}";
                    lblPromedioDesaprobadas.Content = $"Promedio de notas desaprobadas: {promediodesaprobadas}";
                    lblPromedioFinal.Content = $"Promedio final: {promedio}";
                }
                txtNota.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, introduce una nota válida.");
            }
        }

    }
}