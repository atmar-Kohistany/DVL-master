using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace DVL
{
    class MainViewModel
    {
        private Product _oldProduct;

        public ObservableCollection<Product> Products { get; set; }

        //public Command<Product> Delete
        //{


        //    get
        //    {


        //        return new Command<Product>((product) => { Products.Remove(product); });
        //    }
        //}
        public Command<Product> change
        {


            get
            {


                return new Command<Product>((product) => product.Id = 1);
                //{
                //    //Console.WriteLine("" + product);
                //});
            }
        }


        public MainViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    name="atmar",
                    lastName = "ko",
                    Id = 2,
                },
                new Product
                {
                    name="Mursal",
                    lastName = "jo",
                    Id = 2,

                },
                new Product
                {
                name="Mursal",
                lastName = "jo",
                Id = 3,

            }
            };
        }

        public void HideOrShowProduct(Product product)
        {
            product.IsVisible = true;
            UpdateProduct(product);
            _oldProduct = product;

        }
      

        public void UpdateProduct(Product product)
        {
            if (product.Id == 1||product.Id==2)
            {
              
                var index = Products.IndexOf(product);
                Products.Remove(product);
                Products.Insert(index, product);
            }
           
        }
    }
}
