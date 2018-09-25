﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcularRectangulo_Click(object sender, RoutedEventArgs e)
        {
            float baserectangulo = float.Parse(BaseRectangulo.Text);
            float alturarectangulo = float.Parse(AlturaRectangulo.Text);

  
            float resultado = baserectangulo * alturarectangulo;

            ResultadoRectangulo.Text = resultado.ToString() + "U²";


        }

        private void CalcularTriangulo_Click(object sender, RoutedEventArgs e)
        {
            float basetriangulo = float.Parse(BaseTriangulo.Text);
            float alturatriangulo = float.Parse(AlturaTriangulo.Text);

            float resultado = (basetriangulo * alturatriangulo) / 2;

            ResultadoTriangulo.Text = resultado.ToString() + "U²";
        }

        private void CalcularCirculo_Click(object sender, RoutedEventArgs e)
        {
            float radiocirculo = float.Parse(RadioCirculo.Text);
            float pi = Convert.ToSingle(Math.PI);

            float resultado = pi*(radiocirculo * radiocirculo);

            ResultadoCirculo.Text = resultado.ToString() + "U²";
        }

        private void CalcularTrapecio_Click(object sender, RoutedEventArgs e)
        {
            float basemayor = float.Parse(BaseMayorTrapecio.Text);
            float basemenor = float.Parse(BaseMenorTrapecio.Text);
            float altura = float.Parse(AlturaTrapecio.Text);

            float resultado = (basemayor * basemenor * altura) / 2;

            ResultadoTrapecio.Text = resultado.ToString() + "U²";
        }
    }
}