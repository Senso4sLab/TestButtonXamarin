using System;
using System.Collections.Generic;
using System.Text;
using Test.ViewModels;

namespace Test.Model
{
    public class Item : ExtendedBindingObject
    {
        string name;
        string description;
        bool isButtonVisible;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public bool IsButtonVisible
        {
            get => isButtonVisible;
            set => SetProperty(ref isButtonVisible, value);
        }
    }
}
