using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1;

public partial class Child : UserControl
{
    public Child()
    {
        InitializeComponent();
    }

    public double FanSpeed
    {
        get => (double)GetValue(FanSpeedProperty);
        set => SetValue(FanSpeedProperty, value);
    }

    public static readonly DependencyProperty FanSpeedProperty =
        DependencyProperty.Register(nameof(FanSpeed),
            typeof(double),
            typeof(Child),
            new PropertyMetadata((o, args) =>
            {
                if (o is null)
                {
                    Console.WriteLine("trying to set FanSpeed to null");
                    return;
                }

                ((o as Child)!).FanSpeed = (double)args.NewValue;
            }));

    public double Temperature
    {
        get => (double)GetValue(TemperatureProperty);
        set => SetValue(TemperatureProperty, value);
    }

    public static readonly DependencyProperty TemperatureProperty =
        DependencyProperty.Register(nameof(Temperature),
            typeof(double),
            typeof(Child),
            new PropertyMetadata((o, args) =>
            {
                if (o is null)
                {
                    Console.WriteLine("trying to set Temperature to null");
                    return;
                }

                ((o as Child)!).Temperature = (double)args.NewValue;
            }));
}
