using Avalonia.Controls;
using System.ComponentModel;
using System.Globalization;
using System.Threading.Tasks;

namespace numfortune2.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {   
        CultureInfo.DefaultThreadCurrentCulture = new("it-IT");
        InitializeComponent();
    }

    protected override void OnClosing(WindowClosingEventArgs e)
    {
        try
        {
            MainView.conn.Close();
        } catch (MySqlConnector.MySqlException ex)
        {
            ;
        }
    }
}
