using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DVL
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var product = e.Item as Product;
            if (BindingContext is MainViewModel vm) vm.HideOrShowProduct(product);
        }


        private void Button_OnClicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var product = btn.BindingContext as Product;
            var vm = BindingContext as MainViewModel;
            //vm.Delete.Execute(product);
        }



        //private void BtnAprovar_OnClicked(object sender, EventArgs e)
        //{
        //       var t = new Product
        //       {
        //           Id = 1
        //       };
        //   }
        //private void BtnAprovar_OnClicked(object sender, EventArgs e)
        //{
        //    var btn = sender as Button;
        //    var product = btn.BindingContext as Product;
        //    var vm = BindingContext as MainViewModel;
        //    vm.change.Execute(product.Id = 2);
        //}

        private void BtnNegar_OnClicked(object sender, EventArgs e)
	    {
	        var btn = sender as Button;
	        var product = btn.BindingContext as Product;
	        var vm = BindingContext as MainViewModel;
	        vm.change.Execute(product.Id=1);
	        vm.change.Execute(product.name="disapprove");
        }

	    private void BtnAprovar_OnClicked(object sender, EventArgs e)
	    {
	        var btn = sender as Button;
	            var product = btn.BindingContext as Product;
	            var vm = BindingContext as MainViewModel;
	           vm.change.Execute(product.Id=2);
	        vm.change.Execute(product.name="approve");
        }
    }
}
