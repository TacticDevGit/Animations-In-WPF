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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Animations
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

		private void Button_MouseEnter(object sender, MouseEventArgs e)
		{

			var button = sender as Button;
			var WidthAnimation = new DoubleAnimation() { To = 130, Duration = TimeSpan.FromSeconds(0.3) };
			var HeightAnimation = new DoubleAnimation() { To = 150, Duration = TimeSpan.FromSeconds(0.3) };

			button.BeginAnimation(Button.WidthProperty, WidthAnimation);
			button.BeginAnimation(Button.HeightProperty, HeightAnimation);
		}

		private void Button_MouseLeave(object sender, MouseEventArgs e)
		{

			var button = sender as Button;
			var WidthAnimation = new DoubleAnimation() { To = 100, Duration = TimeSpan.FromSeconds(0.3) };
			var HeightAnimation = new DoubleAnimation() { To = 120, Duration = TimeSpan.FromSeconds(0.3) };

			button.BeginAnimation(Button.WidthProperty, WidthAnimation);
			button.BeginAnimation(Button.HeightProperty, HeightAnimation);
		}
	}
}
