using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;

namespace Erable.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Exit_OnPointerPressed(object? sender, PointerPressedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void About_OnPointerPressed(object? sender, PointerPressedEventArgs e)
        {
            About about = new();
            about.ShowDialog(this);
            
        }
    }
}