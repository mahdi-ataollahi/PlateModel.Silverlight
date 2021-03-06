﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace PlateModel.Silverlight.Assets.Behaviors
{
    public class SelectAllBehavior : Behavior<Control>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.GotFocus += new RoutedEventHandler(AssociatedObject_GotFocus);
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.GotFocus -= new RoutedEventHandler(AssociatedObject_GotFocus);
        }

        void AssociatedObject_GotFocus(object sender, RoutedEventArgs e)
        {
            if (AssociatedObject != null)
            {
                if (AssociatedObject is TextBox)
                    ((TextBox)AssociatedObject).SelectAll();
                else if (AssociatedObject is PasswordBox)
                    ((PasswordBox)AssociatedObject).SelectAll();
            }
        }
    }
}
