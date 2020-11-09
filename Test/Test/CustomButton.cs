using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Test
{
    public class CustomButton :Button
    {
        public static readonly BindableProperty IsEnableButtonProperty = BindableProperty.Create("IsEnableButton", typeof(bool), typeof(CustomButton), defaultValue:true, propertyChanged: OnEventNameChanged);
       
        public bool IsEnableButton
        {
            get { return (bool)GetValue(IsEnableButtonProperty); }
            set { SetValue(IsEnableButtonProperty, value); }
        }

        static void OnEventNameChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if(bindable is Button custtomButton)
            {
                var command = bindable.GetValue(CommandProperty) as ICommand;

                if(command != null)
                    (command as Command).ChangeCanExecute();
            }             
        }
    }
}
