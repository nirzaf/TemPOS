﻿#pragma checksum "..\..\..\OrderEntryRegisterMenuControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E6CE22186484AFA4329C2463F427F73958790FEA3A07E243F4894F147414AFB7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PosControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TemPOS;
using TemPOS.Types;


namespace TemPOS {
    
    
    /// <summary>
    /// OrderEntryRegisterMenuControl
    /// </summary>
    public partial class OrderEntryRegisterMenuControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\OrderEntryRegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\OrderEntryRegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\OrderEntryRegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonStartRegister;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\OrderEntryRegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonNoSale;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\OrderEntryRegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDeposit;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\OrderEntryRegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDrop;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\OrderEntryRegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPayout;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\OrderEntryRegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonFloat;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\OrderEntryRegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDock;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\OrderEntryRegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonReport;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\OrderEntryRegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCloseOut;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TemPOS;component/orderentryregistermenucontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\OrderEntryRegisterMenuControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mainPane = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.Configuration = ((PosControls.ConfigurationManager)(target));
            return;
            case 3:
            this.buttonStartRegister = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\OrderEntryRegisterMenuControl.xaml"
            this.buttonStartRegister.Click += new System.Windows.RoutedEventHandler(this.buttonStartRegister_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonNoSale = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\OrderEntryRegisterMenuControl.xaml"
            this.buttonNoSale.Click += new System.Windows.RoutedEventHandler(this.buttonNoSale_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonDeposit = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\OrderEntryRegisterMenuControl.xaml"
            this.buttonDeposit.Click += new System.Windows.RoutedEventHandler(this.buttonDeposit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonDrop = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\OrderEntryRegisterMenuControl.xaml"
            this.buttonDrop.Click += new System.Windows.RoutedEventHandler(this.buttonDrop_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonPayout = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\OrderEntryRegisterMenuControl.xaml"
            this.buttonPayout.Click += new System.Windows.RoutedEventHandler(this.buttonPayout_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonFloat = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\OrderEntryRegisterMenuControl.xaml"
            this.buttonFloat.Click += new System.Windows.RoutedEventHandler(this.buttonFloat_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonDock = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\OrderEntryRegisterMenuControl.xaml"
            this.buttonDock.Click += new System.Windows.RoutedEventHandler(this.buttonDock_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.buttonReport = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\OrderEntryRegisterMenuControl.xaml"
            this.buttonReport.Click += new System.Windows.RoutedEventHandler(this.buttonReport_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.buttonCloseOut = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\OrderEntryRegisterMenuControl.xaml"
            this.buttonCloseOut.Click += new System.Windows.RoutedEventHandler(this.buttonCloseOut_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

