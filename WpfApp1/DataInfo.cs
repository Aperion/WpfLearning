using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfApp1;

public class DataInfo : INotifyPropertyChanged
{
    private double _fanSpeed;
    private double _temperature;

    public DataInfo()
    {
        FanSpeed = 0.0;
        Temperature = 0.0;
    }

    public double FanSpeed
    {
        get => _fanSpeed;
        set
        {
            // Console.WriteLine($"{RuntimeHelpers.GetHashCode(this)}: Setting Fan Speed to {value}");
            _fanSpeed = value;
            OnPropertyChanged();
        }
    }

    public double Temperature
    {
        get => _temperature;
        set
        {
            // Console.WriteLine($"{RuntimeHelpers.GetHashCode(this)}: Setting Temperature to {value} ");
            _temperature = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}