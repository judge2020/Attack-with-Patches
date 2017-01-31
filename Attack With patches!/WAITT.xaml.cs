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
using MahApps.Metro.Controls;

namespace Attack_With_patches_
{
	/// <summary>
	/// Interaction logic for WAITT.xaml
	/// </summary>
	public partial class WAITT : UserControl
	{
		private int timer = 5;
		public WAITT()
		{
			InitializeComponent();
			button.IsEnabled = false;
		}
	}
}
