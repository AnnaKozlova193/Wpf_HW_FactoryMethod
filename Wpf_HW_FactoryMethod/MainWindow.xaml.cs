using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Wpf_HW_FactoryMethod.Сlasses;

namespace Wpf_HW_FactoryMethod
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

        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            bool finish = true;
            // Создание объекта при генерации чисел
            while (finish)
            {
                Random rnd = new Random();
                int num = rnd.Next(5, 300);
                Creator creator = new Creator();
                IFigure figure;
                figure = creator.CreateFigure(num);
                figure.Draw();
                count++;
                Thread.Sleep(1500);
                if (count == 10)
                {
                    finish = false;
                }
            }
            if (!finish)
            {
                windowShowButton.Close();
            }
        }
    }
}
