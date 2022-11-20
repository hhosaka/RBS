using RBS.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RBS.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage() {
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}