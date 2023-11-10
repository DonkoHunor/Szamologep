using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace szamologep
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
			int sz1 = Convert.ToInt32(szam1.Text);
			int sz2 = Convert.ToInt32(szam2.Text);
			eredmenyLabel.Content = sz1 + sz2;
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			int sz1 = Convert.ToInt32(szam1.Text);
			int sz2 = Convert.ToInt32(szam2.Text);
			eredmenyLabel.Content = sz1 - sz2;
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			int sz1 = Convert.ToInt32(szam1.Text);
			int sz2 = Convert.ToInt32(szam2.Text);
			eredmenyLabel.Content = sz1 * sz2;
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			double sz1 = Convert.ToInt32(szam1.Text);
			double sz2 = Convert.ToInt32(szam2.Text);
			eredmenyLabel.Content = Math.Round(sz1 / sz2, 2);
		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			int sz1 = Convert.ToInt32(szam1.Text);
			int sz2 = Convert.ToInt32(szam2.Text);
			eredmenyLabel.Content = sz1 % sz2;
		}

		private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			int sz1 = Convert.ToInt32(szam1.Text);
			int sz2 = Convert.ToInt32(szam2.Text);
			eredmenyLabel.Content = sz1 + sz2;
		}

		private void szam1_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
		}
	}
}
