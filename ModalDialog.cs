using System;

using Avalonia.Controls;
using Avalonia.Layout;

namespace MyApp
{
    internal class ModalDialog : Window, IDisposable
    {
        internal ModalDialog(Window parent)
        {
            Owner = parent;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;

            InitializeWindow();

            BuildComponents();
        }

        void IDisposable.Dispose()
        {
        }

        void InitializeWindow()
        {
            Title = "This is a modal dialog";
            Width = 400;
        }

        void Button_Click(object sender, EventArgs e)
        {
            Close(true);
        }

        void BuildComponents()
        {
            Button button = new Button();
            button.Content = "Close dialog";
            button.HorizontalAlignment = HorizontalAlignment.Center;
            button.Click += Button_Click;

            Content = button;
        }
    }
}