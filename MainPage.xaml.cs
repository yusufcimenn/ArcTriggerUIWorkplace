using System;
using Microsoft.Maui.Controls;

namespace ArcTriggerUIWorkplace;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        // No extra init for now
        //BindingContext = new MainPageViewModel(); // oluştuğunda ViewModel aktarılacak
    }

    // Top actions
    private void OnAutoFetchClicked(object sender, EventArgs e)
    {
        // TODO implement later
    }

    // Symbol and option selectors
    private void OnSymbolChanged(object sender, EventArgs e)
    {
        // TODO implement later
    }

    private void OnCallOptionCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        // TODO implement later
    }

    private void OnPutOptionCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        // TODO implement later
    }

    // Trigger price
    private void OnTriggerPriceTextChanged(object sender, TextChangedEventArgs e)
    {
        // TODO implement later
    }

    private void OnIncreaseTriggerClicked(object sender, EventArgs e)
    {
        // TODO implement later
    }

    private void OnDecreaseTriggerClicked(object sender, EventArgs e)
    {
        // TODO implement later
    }

    // Strike and expiration
    private void OnStrikeChanged(object sender, EventArgs e)
    {
        // TODO implement later
    }

    private void OnExpirationChanged(object sender, EventArgs e)
    {
        // TODO implement later
    }

    // Position size
    private void OnPositionTextChanged(object sender, TextChangedEventArgs e)
    {
        // TODO implement later
    }

    private void OnPositionPresetClicked(object sender, EventArgs e)
    {
        // TODO implement later 2000-5000-10000$
    }

  

    // Stop loss
    private void OnStopLossTextChanged(object sender, TextChangedEventArgs e)
    {
        // TODO implement later
    }

    
    private void OnStopLossPreset(object sender, EventArgs e)
    {
        // TODO implement later   0.2-0.5-1.0 preset
    }

    // Final action
    private void OnCreateOrderClicked(object sender, EventArgs e)
    {
        // TODO implement later
    }
}
