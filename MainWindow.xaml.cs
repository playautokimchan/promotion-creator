using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace PromotionCreator
{
	/// <summary>
	/// MainWindow.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
            GetScreen();
        }

        private void GetScreen()
        {
            string dir = Directory.GetCurrentDirectory();
            this.PromotionScreen.Navigate(new Uri(String.Format("file:///{0}/index.html", dir)));
        }

        private void Renewal_Click(object sender, RoutedEventArgs e)
        {
            this.GetScreen();
        }

        private void CreateInputBox_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
