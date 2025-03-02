using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using System;

namespace numfortune2.Views;

public partial class MainView : UserControl
{
    public static MySqlConnector.MySqlConnection conn = new("server=numeronesoft.ddns.net;user=guest;database=barzellette;port=3306");
    public static MySqlConnector.MySqlCommand cmd;
    public static MySqlConnector.MySqlDataReader reader;
    public static int max;
    public static Random rnd;
    public static int id;
    public MainView()
    {

        InitializeComponent();
        try
        {
            conn.Open();
        }
        catch (MySqlConnector.MySqlException ex)
        {
            cookie.Text = ex.Message;
            btnCookie.IsEnabled = false;
            return;

        }
        cmd = new("SELECT MAX(ID) FROM Barzellette", conn);
        try
        {
            reader = cmd.ExecuteReader();
            reader.Read();
            max = reader.GetInt32(0);
            reader.Close();
        }
        catch (MySqlConnector.MySqlException ex)
        {
            cookie.Text = ex.Message;
            return;
        }
        rnd = new();
        cookie.Text = GetCookie();
    }


    public void GetNewCookie_Click(Object sender, RoutedEventArgs e) => cookie.Text = GetCookie();
    public void Info_Click(Object sender, RoutedEventArgs e)
    {
        ILauncher launcher = TopLevel.GetTopLevel(this).Launcher;
        launcher.LaunchUriAsync(new Uri("https://github.com/giulianospaghetti/il-fortune-di-numerone"));
    }

    private String GetCookie()
    {
        string s;
        id = rnd.Next(1, max);
        try
        {
            cmd = new($"SELECT Testo FROM Barzellette WHERE ID = {id}", conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            s = reader.GetString(0);
            reader.Close();
        }
        catch (MySqlConnector.MySqlException ex)
        {
            s = ex.Message;
            btnCookie.IsEnabled = false;
        }
        return s;
    }
}

