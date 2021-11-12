using System;

using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Markup.Xaml;

namespace MyApp
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BuildComponents();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        async void Button_Click(object sender, EventArgs e)
        {
            using (ModalDialog dialog = new ModalDialog(this))
            {
                await dialog.ShowDialog<bool>(this);
            }
        }

        void BuildComponents()
        {
            Button button = new Button();
            button.Content = "Open modal dialog";
            button.HorizontalAlignment = HorizontalAlignment.Center;
            button.Click += Button_Click;

            Content = button;
        }
    }
}