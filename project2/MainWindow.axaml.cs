using Avalonia.Controls;
using Avalonia.Interactivity;

namespace project2;

public partial class MainWindow : Window
{
    private MainInt window2 = new MainInt();
    public MainWindow()
    {
        InitializeComponent();
        
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        if (Login.Text == "Teacher" && Passwd.Text == "123456")
        {
            window2.Show();
        }
    }
}