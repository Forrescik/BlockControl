﻿// Sebastian De GambeBlockControlBlockControl2015

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BlockControl
{
    public class MyComboBox : ComboBox, IMyControls
    {
        public static readonly RoutedEvent ValueChangedEvent = EventManager.RegisterRoutedEvent("ValueChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MyComboBox));

        public event RoutedEventHandler ValueChanged
        {
            add { AddHandler(ValueChangedEvent, value); }
            remove { RemoveHandler(ValueChangedEvent, value); }
        }

        protected virtual bool RaiseCustomEvent()
        {
            RoutedEventArgs eventArg = new RoutedEventArgs(MyComboBox.ValueChangedEvent);
            RaiseEvent(eventArg);
            return eventArg.Handled;
        }

        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            e.Handled = RaiseCustomEvent();
            base.OnPreviewTextInput(e);
        }

        protected override void OnPreviewMouseDown(MouseButtonEventArgs e)
        {
            e.Handled = RaiseCustomEvent();
            base.OnPreviewMouseDown(e);
        }

        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            e.Handled = RaiseCustomEvent();
            base.OnPreviewKeyDown(e);
        }
    }
}