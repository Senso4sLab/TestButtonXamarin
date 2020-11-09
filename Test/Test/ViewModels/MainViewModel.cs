using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Timers;
using System.Windows.Input;
using Test.Model;
using Xamarin.Forms;

namespace Test.ViewModels
{
    public class MainViewModel : ExtendedBindingObject
    {
        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();

        public ICommand BleCommand { get; set; } 

        Timer timer;
        Random random;
        public MainViewModel()
        {
            timer = new Timer();
            timer.Stop();
            timer.Interval = 10000;
            timer.AutoReset = true;
            timer.Elapsed += AddNewItem;
            timer.Start();
            random = new Random(44324254);

            Items.Add(new Item
            {
                Name = "name1",
                Description = "description1",
                IsButtonVisible = false

            }) ;

            BleCommand = new Command<Item>((item)=>
            {
                App.Current.MainPage.DisplayAlert("Alert", $"The property IsButtonVisible for this {item.Name} Button  is set to true", "OK");
            });

        }

        private void AddNewItem(object sender, ElapsedEventArgs e)
        {            
            
            Items.Add(new Item
            {
                Name = $"name {random.Next(200)}",
                Description = $"description {random.Next(200)}",
                IsButtonVisible = random.Next(0, 1) == 0 ? false : true
            });
           
        }
    }
}
