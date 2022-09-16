using System;
using System.Collections.Generic;
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
using System.Diagnostics;

namespace SingleBoerseNRW.MVVM.View
{
    /// <summary>
    /// Interaktionslogik für HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void Click_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "http://singleboerse-nrw.de";
            process.Start();






        }

        private void Click_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }


    }
}
