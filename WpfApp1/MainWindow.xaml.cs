using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<DataInfo> _dataHolder = new(2)
        {
            new DataInfo(),
            new DataInfo()
        };

        public List<DataInfo> dataHolder
        {
            get => _dataHolder;
            set
            {
                _dataHolder = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            StartTimer();
        }

        private void StartTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            foreach (var data in dataHolder)
            {
                data.FanSpeed = 50 + (new Random().NextDouble() * 0.2 - 0.1);
                data.Temperature = 102 + (new Random().NextDouble() * 0.2 - 0.1);
                // Console.WriteLine($"FanSpeed: {data.FanSpeed} Temperature: {data.Temperature}");
            }
            
            FanSpeed1.Text = dataHolder[1].FanSpeed.ToString();
            Temperature1.Text = dataHolder[1].Temperature.ToString();
        }
    }
}