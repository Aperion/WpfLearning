using System.Windows.Controls;

namespace WpfApp1;

public partial class Child : UserControl
{
    public Child()
    {
        InitializeComponent();
    }
    public int FanSpeed { get; set; }
    public double Temperature { get; set; }
}