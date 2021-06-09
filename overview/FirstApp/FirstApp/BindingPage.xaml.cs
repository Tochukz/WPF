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
using System.Windows.Shapes;

namespace FirstApp
{
	/// <summary>
	/// Interaction logic for BindingPage.xaml
	/// </summary>
	public partial class BindingPage : Window
	{
		public BindingPage()
		{
			InitializeComponent();

			// create data source
			Person person = new Person();

			// make data source available for binding
			this.DataContext = person;

		}

		protected void elipseMouseUp(object sender, MouseButtonEventArgs args )
		{
			MessageBox.Show("You clicked on the elipse");
		}
	}
}
