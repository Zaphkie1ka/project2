using Avalonia.Controls;
using Avalonia.Interactivity;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using Tmds.DBus.Protocol;

namespace project2;

public partial class MainWindow : Window
{
    private MainInt window2 = new MainInt();
    public MainWindow()
    {
        InitializeComponent();
        Passwd.Text = "123456";
    }
    
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        /*if (Login.Text == "Teacher" && Passwd.Text == "123456")
        {
            window2.Show();
        }*/
    }

    private async void Button_OnClick1(object? sender, RoutedEventArgs e)
    {
        var box = MessageBoxManager.GetMessageBoxStandard("ВНИМАНИЕ", "При нажатии кнопки *да*, ваш пароль сотрется. Продолжить?", ButtonEnum.YesNo);
        var result = await box.ShowAsync();
        if (result == ButtonResult.Yes)
        {
            Passwd.Text = null;
            //window2.Show();
        }
    }
}