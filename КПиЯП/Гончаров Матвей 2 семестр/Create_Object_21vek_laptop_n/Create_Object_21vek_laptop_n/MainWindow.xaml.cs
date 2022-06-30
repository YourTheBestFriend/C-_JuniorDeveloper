using System;
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

namespace Create_Object_21vek_laptop_n
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        // Make 
        private void GridSplitter_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            textboxcash.Text = cashslider.Value.ToString();
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textboxcash.Text = Math.Round(cashslider.Value, 2).ToString();
        }

        // May you create object or not?
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // give toolkit proizv
            // proizv
            if (proizv_1.IsChecked == false && proizv_2.IsChecked == false && proizv_3.IsChecked == false && proizv_4.IsChecked == false && proizv_5.IsChecked == false && proizv_6.IsChecked == false && proizv_8.IsChecked == false)
            { 
                my_the_best_rich_box.AppendText("Ошибка в секции Производители");
            }
            else
            {
                // size screen
                if (size_1.IsChecked == false && size_2.IsChecked == false && size_3.IsChecked == false)
                {
                    my_the_best_rich_box.AppendText("Ошибка в секции Разрешение экрана");
                }
                else 
                {
                    // processor
                    if (proc_1.IsChecked == false && proc_2.IsChecked == false && proc_3.IsChecked == false)
                    {
                        my_the_best_rich_box.AppendText("Ошибка в секции Процессор");
                    }
                    else
                    {
                        my_the_best_rich_box.AppendText("Тут типо создан объект, ошибок не возникло");
                    }
                } 
            }
        }

        private void textboxcash_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
