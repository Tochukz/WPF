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
	/// Interaction logic for DataTemplatePage.xaml
	/// </summary>
	public partial class DataTemplatePage : Window
	{
		public static System.Collections.Generic.List<Todo> myTodoList;

		public DataTemplatePage()
		{
			InitializeComponent();

			myTodoList = new List<Todo> {
			  new Todo { TaskName = "Study", Description = "Read C++ Book", Priority = 3 },
			  new Todo { TaskName = "Play", Description = "Play Piano", Priority = 2 },
			  new Todo { TaskName = "Code", Description = "Program K-medics Clinics", Priority = 1}
			};

			this.DataContext = this;
		}
	}
}
