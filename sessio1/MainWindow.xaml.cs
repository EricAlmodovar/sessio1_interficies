using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sessio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid elmeuGrid = new Grid();
            this.Content = elmeuGrid;

            Button elmeuBtn = new Button();
            elmeuBtn.Height = 50;
            elmeuBtn.Width = 110;
            elmeuBtn.Background = Brushes.Black;
            //elmeuGrid.Children.Add(elmeuBtn);
            
            WrapPanel elmeuWrapPanel = new WrapPanel();

            TextBlock elmeuTextBlock = new TextBlock();
            elmeuTextBlock.Text = "SIUU ";
            elmeuWrapPanel.Children.Add(elmeuTextBlock);
            elmeuTextBlock.Foreground = Brushes.Red;

            TextBlock elmeuTextBlock2 = new TextBlock();
            elmeuTextBlock2.Text = "PLIMPLIMPLOM ";
            elmeuWrapPanel.Children.Add(elmeuTextBlock2);
            elmeuTextBlock2.Foreground = Brushes.Green;

            TextBlock elmeuTextBlock3 = new TextBlock();
            elmeuTextBlock3.Text = "INVITAMEMARITOO";
            elmeuWrapPanel.Children.Add(elmeuTextBlock3);
            elmeuTextBlock3.Foreground = Brushes.Purple;

            elmeuBtn.Content = elmeuWrapPanel;
            elmeuGrid.Children.Add(elmeuBtn);

            

        }
    }
}
