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

namespace Projeto
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        SolidColorBrush claro = new SolidColorBrush();
        SolidColorBrush azul = new SolidColorBrush();
        SolidColorBrush escuro = new SolidColorBrush();
        object active;

        public MainWindow()
        {
            InitializeComponent();
            claro.Color = Color.FromRgb(161, 221, 223);
            azul.Color = Color.FromRgb(187, 209, 217);
            escuro.Color = Color.FromRgb(108, 145, 146);
        }

        Home Casa = new Home();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grid.Visibility = Visibility.Hidden;
            logo.Visibility = Visibility.Hidden;
            screen.Visibility = Visibility.Visible;
            screen.Content = Casa;
            buttons.Visibility = Visibility.Visible;
            homerec.Fill = azul;
            active = homerec;
        }

        private void clear_all()
        {
            loanrec.Fill = escuro;
            homerec.Fill = escuro;
            itemrec.Fill = escuro;
            personrec.Fill = escuro;
            openrec.Fill = escuro;
            searchrec.Fill = escuro;
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            GC.Collect();
            Close();
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

    /*    private void Loan_MouseEnter(object sender, MouseEventArgs e)
        {
            Rectangle btn = sender as Rectangle;
            if(!active.Equals(sender))
                btn.Fill = claro;
        }

        private void Loan_MouseLeave(object sender, MouseEventArgs e)
        {
            Rectangle btn = sender as Rectangle;
            if (!active.Equals(sender))
                btn.Fill = escuro;
        }

        private void Loan_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!active.Equals(sender))
            {
                clear_all();
                loanrec.Fill = azul;
                active = sender;
            }
        }   */

        private void Homerec_MouseLeave(object sender, MouseEventArgs e)
        {
            Rectangle btn = sender as Rectangle;
            if (!active.Equals(sender))
            btn.Fill = escuro;
        }

        private void Homerec_MouseEnter(object sender, MouseEventArgs e)
        {
            Rectangle btn = sender as Rectangle;
            if (!active.Equals(sender))
            btn.Fill = claro;
        }

        private void Homerec_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!active.Equals(sender))
            {
                clear_all();
                homerec.Fill = azul;
                active = sender;
            }
        }

        private void Loanrec_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!active.Equals(sender))
            {
                clear_all();
                loanrec.Fill = azul;
                active = sender;
            }
        }

        private void Itemrec_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!active.Equals(sender))
            {
                clear_all();
                itemrec.Fill = azul;
                active = sender;
            }
        }

        private void Personrec_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!active.Equals(sender))
            {
                clear_all();
                personrec.Fill = azul;
                active = sender;
            }
        }

        private void Searchrec_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!active.Equals(sender))
            {
                clear_all();
                searchrec.Fill = azul;
                active = sender;
            }
        }

        private void Openrec_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!active.Equals(sender))
            {
                clear_all();
                openrec.Fill = azul;
                active = sender;
            }
        }
    }
}
