﻿#pragma checksum "G:\Dropbox\Visual Studio 2012\Projects\Calendar Converter\Calendar Converter\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EB9B8398E307AAE41A614D197DA60442"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MC.Phone.Ads;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Calendar_Converter {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox dateBox;
        
        internal System.Windows.Controls.TextBox monthBox;
        
        internal System.Windows.Controls.TextBox yearBox;
        
        internal Microsoft.Phone.Controls.TimePicker timePicker;
        
        internal Microsoft.Phone.Controls.ListPicker BCADPicker;
        
        internal System.Windows.Controls.Button calculateJulianButton;
        
        internal System.Windows.Controls.TextBlock JulianDateIs;
        
        internal System.Windows.Controls.TextBlock ShowJulianDate;
        
        internal System.Windows.Controls.TextBox julianDate;
        
        internal System.Windows.Controls.Button calculateButton;
        
        internal System.Windows.Controls.TextBlock GregDateIs;
        
        internal System.Windows.Controls.TextBlock ShowGregDate;
        
        internal System.Windows.Controls.TextBlock ShowGregTime;
        
        internal MC.Phone.Ads.AdControl AdBasic;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Calendar%20Converter;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.dateBox = ((System.Windows.Controls.TextBox)(this.FindName("dateBox")));
            this.monthBox = ((System.Windows.Controls.TextBox)(this.FindName("monthBox")));
            this.yearBox = ((System.Windows.Controls.TextBox)(this.FindName("yearBox")));
            this.timePicker = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("timePicker")));
            this.BCADPicker = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("BCADPicker")));
            this.calculateJulianButton = ((System.Windows.Controls.Button)(this.FindName("calculateJulianButton")));
            this.JulianDateIs = ((System.Windows.Controls.TextBlock)(this.FindName("JulianDateIs")));
            this.ShowJulianDate = ((System.Windows.Controls.TextBlock)(this.FindName("ShowJulianDate")));
            this.julianDate = ((System.Windows.Controls.TextBox)(this.FindName("julianDate")));
            this.calculateButton = ((System.Windows.Controls.Button)(this.FindName("calculateButton")));
            this.GregDateIs = ((System.Windows.Controls.TextBlock)(this.FindName("GregDateIs")));
            this.ShowGregDate = ((System.Windows.Controls.TextBlock)(this.FindName("ShowGregDate")));
            this.ShowGregTime = ((System.Windows.Controls.TextBlock)(this.FindName("ShowGregTime")));
            this.AdBasic = ((MC.Phone.Ads.AdControl)(this.FindName("AdBasic")));
        }
    }
}

