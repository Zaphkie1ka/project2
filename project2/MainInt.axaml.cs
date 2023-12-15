using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MySql.Data.MySqlClient;
using project2.Models;

namespace project2;

public partial class MainInt : Window
{
    private List<Student> _student;
    private List<Schedule> _schedule;

    public MainInt()
    {
        InitializeComponent();
    }

    private void UpdateBD()
    {
        _student = new List<Student>();
        _schedule = new List<Schedule>();
        DBHelper db = new DBHelper();
        using (var connection = new MySqlConnection(db._connectionString.ConnectionString))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * From Student";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        _student.Add(new Student
                        {
                            ID = reader.GetInt32("ID"),
                            Name = reader.GetString("Name"),
                            Contact = reader.GetInt32("Contact"),
                            Passport = reader.GetInt32("Passport"),
                            Address = reader.GetString("Address")
                        });
                    }
                }
                command.CommandText = "SELECT * From Schedule";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        _schedule.Add(new Schedule
                        {
                            ID = reader.GetInt32("ID"),
                            Name = reader.GetString("Name"),
                            Time = reader.GetString("Time")
                        });
                    }
                }
                connection.Close();
            }
            Student.ItemsSource = _student;
            Schedule.ItemsSource = _schedule;
            
        }
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Panel1.IsVisible = false;
        Panel2.IsVisible = false;
        Panel3.IsVisible = false;
        /*if (splitView.IsPaneOpen == true)
        {
            splitView.IsPaneOpen = false;
        }
        else
            splitView.IsPaneOpen = true;*/
    }

    private void Button_OnClick1(object? sender, RoutedEventArgs e)
    {
        Panel1.IsVisible = true;
        Panel2.IsVisible = false;
        Panel3.IsVisible = false;
    }

    private void Button_OnClick2(object? sender, RoutedEventArgs e)
    {
        Panel1.IsVisible = false;
        Panel2.IsVisible = true;
        Panel3.IsVisible = false;
    }

    private void Button_OnClick3(object? sender, RoutedEventArgs e)
    {
        Panel1.IsVisible = false;
        Panel2.IsVisible = false;
        Panel3.IsVisible = true;
    }

    
}