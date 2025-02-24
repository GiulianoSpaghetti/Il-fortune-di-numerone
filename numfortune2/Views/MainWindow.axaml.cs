using Avalonia.Controls;
using System.ComponentModel;
using System.Threading.Tasks;

namespace numfortune2.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
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
