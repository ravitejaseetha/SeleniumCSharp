using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlOperationsWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListBox lb;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Timer t = new Timer();
            var actionAfterseconds = 3;
            t.Interval = 1000;
            t.Elapsed += (s, eventargs) =>
            {
                if (actionAfterseconds-- == 0)
                {
                    Dispatcher.Invoke(() => createListbox());
                    Dispatcher.Invoke(() => txtCountownTimer.Text = "--");
                    t.Stop();
                    t.Dispose();
                }
                else
                {
                    Dispatcher.Invoke(() => txtCountownTimer.Text = actionAfterseconds.ToString());
                }
            };
            Dispatcher.Invoke(() => txtCountownTimer.Text = actionAfterseconds.ToString());
            t.Start();
        }


        private void createListbox()
        {
            lb = new ListBox();
            contentArea.Children.Add(lb);
            lb.Name = "DynamicListbox";
            lb.IsEnabled = false;
            lb.Height = 150;
            lb.Width = 100;

            lb.Items.Add("Red");
            lb.Items.Add("Green");
            lb.Items.Add("Yellow");
            lb.Items.Add("Blue");

            lb.SelectedIndex = 1;
            lb.Visibility = System.Windows.Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Timer t = new Timer();
            var actionAfterseconds = 3;
            t.Interval = 1000;
            
                t.Elapsed += (s, eventargs) =>
                {
                    if (actionAfterseconds-- == 0)
                    {
                        Dispatcher.Invoke(() => lb.IsEnabled = true);
                        Dispatcher.Invoke(() => txtCountownTimer.Text = "--");
                        t.Stop();
                        t.Dispose();
                    }
                    else
                    {
                        Dispatcher.Invoke(() => txtCountownTimer.Text = actionAfterseconds.ToString());
                    }
                };
                Dispatcher.Invoke(() => txtCountownTimer.Text = actionAfterseconds.ToString());
            t.Start();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Timer t = new Timer();
            var actionAfterseconds = 3;
            t.Interval = 1000;
            t.Elapsed += (s, eventargs) =>
            {
                if (actionAfterseconds-- == 0)
                {
                    Dispatcher.Invoke(() => contentArea.Children.Remove(lb));
                    Dispatcher.Invoke(() => txtCountownTimer.Text = "--");
                    lb = null;
                    t.Stop();
                    t.Dispose();
                }
                else
                {
                    Dispatcher.Invoke(() => txtCountownTimer.Text = actionAfterseconds.ToString());
                }
            };
            Dispatcher.Invoke(() => txtCountownTimer.Text = actionAfterseconds.ToString());
            t.Start();

        }

    }
}
