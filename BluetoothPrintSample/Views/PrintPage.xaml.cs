﻿using BluetoothPrintSample.ViewModels;
using Shiny.BluetoothLE.Central;
using Xamarin.Forms;

namespace BluetoothPrintSample.Views
{
    public partial class PrintPage : ContentPage
    {
        public PrintPage(IPeripheral peripheral)
        {
            InitializeComponent();
            BindingContext = new PrintPageViewModel(peripheral);
        }
    }
}
