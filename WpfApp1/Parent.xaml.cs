﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1;

public partial class Parent : UserControl, INotifyPropertyChanged
{
    public Parent()
    {
        InitializeComponent();
    }
    
    public DataInfo Data
    {
        get => (DataInfo)GetValue(DataProperty);
        set
        {
            Console.WriteLine("Setting Data");
            SetValue(DataProperty, value);
            OnPropertyChanged();
        }
    }

    public static readonly DependencyProperty DataProperty =
        DependencyProperty.Register(nameof(Data),
            typeof(DataInfo),
            typeof(Parent),
            new PropertyMetadata(new DataInfo(), (o, args) =>
            {
                if(o is null)
                {
                    Console.WriteLine("trying to set Data to null");
                    return;
                }
                
                ((o as Parent)!).Data = (DataInfo)args.NewValue;
            }));


    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}