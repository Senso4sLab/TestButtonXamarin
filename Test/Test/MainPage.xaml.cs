using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ViewModels;
using Xamarin.Forms;

namespace Test
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel VM => BindingContext as MainViewModel;
        public MainPage()
        {            
            InitializeComponent();
            this.BindingContext = new MainViewModel();
        }
    }
}
