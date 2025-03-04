using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using System;

namespace numfortune2.Views;

public partial class MainView : UserControl
{
    internal static MySqlConnector.MySqlConnection conn = new("server=numeronesoft.ddns.net;user=guest;database=barzellette;port=3306");
    private static MySqlConnector.MySqlCommand cmd;
    private static MySqlConnector.MySqlDataReader reader;
    private static int max=0;
    private static Random rnd;
    private static int id;
    private static ILauncher? launcher=null;
    private static readonly Uri HomePage = new Uri("https://github.com/giulianospaghetti/il-fortune-di-numerone");
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
        tbDoppioni.Text = $"Per avere una barzelletta doppione o chiudi e riapri o premi il pulsante \"Nuovo Biscotto\" {max} volte.";
    }


    public void GetNewCookie_Click(Object sender, RoutedEventArgs e) => cookie.Text = GetCookie();
    public void Info_Click(Object sender, RoutedEventArgs e)
    {
        if (launcher == null)
            launcher = TopLevel.GetTopLevel(this).Launcher;
        launcher.LaunchUriAsync(HomePage);
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

