﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        List<DataInfo> dataHolder = new List<DataInfo>() {
            new DataInfo(),
            new DataInfo()
        };
        
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
            for (int i = 0; i < dataHolder.Count; i++)
            {
                var data = dataHolder[i];
                data.FanSpeed = 50 + (new Random().NextDouble() * 0.2 - 0.1);
                data.Temperature = 102 + (new Random().NextDouble() * 0.2 - 0.1);
                dataHolder[i] = data; // Replace the modified struct back into the list
            }
        }
    }
}