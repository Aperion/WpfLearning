using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1;

public partial class Child : UserControl, INotifyPropertyChanged
{
    public Child()
    {
        InitializeComponent();
    }

    public double FanSpeed
    {
        get => (double)GetValue(FanSpeedProperty);
        set
        {
            SetValue(FanSpeedProperty, value);
            OnPropertyChanged();
        }
    }

    public static readonly DependencyProperty FanSpeedProperty =
        DependencyProperty.Register(nameof(FanSpeed),
            typeof(double),
            typeof(Child));

    public double Temperature
    {
        get => (double)GetValue(TemperatureProperty);
        set
        {
            SetValue(TemperatureProperty, value);
            OnPropertyChanged();
        }
    }

    public static readonly DependencyProperty TemperatureProperty =
        DependencyProperty.Register(nameof(Temperature),
            typeof(double),
            typeof(Child));

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
