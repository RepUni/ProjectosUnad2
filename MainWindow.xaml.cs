﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ejer11
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
            if (double.TryParse(txtPrecio.Text, out double precio) &&
                double.TryParse(txtArticulos.Text, out double numeroArticulos))
            {
                double precioVenta = precio * numeroArticulos;
                double iva = Math.Round(precioVenta * 0.15, 2);
                double precioBruto = precioVenta + iva;
                double descuento = precioBruto >= 50 ? Math.Round((precioBruto * 5) / 100, 2) : 0;
                double totalPagar = precioBruto - descuento;

                lblPrecioVenta.Content = $"Precio de venta: {precioVenta}";
                lblIVA.Content = $"Impuesto sobre el valor añadido (IVA): {iva}";
                lblPrecioBruto.Content = $"Precio bruto: {precioBruto}";
                lblDescuento.Content = $"Descuento: {descuento}";
                lblTotalPagar.Content = $"Total a pagar: {totalPagar}";

            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }
    }
}