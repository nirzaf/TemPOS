﻿#pragma checksum "..\..\..\TicketTypeFilterControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CBA7F7AE9DCA3B03524338AD392FAD164795A363017C7FEBC0BB9570ADB3F8A0"
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
    /// TicketTypeFilterControl
    /// </summary>
    public partial class TicketTypeFilterControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\..\TicketTypeFilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 3 "..\..\..\TicketTypeFilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\TicketTypeFilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton buttonNoneToggle;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\TicketTypeFilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton buttonDineInToggle;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\TicketTypeFilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton buttonCarryOutToggle;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\TicketTypeFilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton buttonDeliveryToggle;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\TicketTypeFilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton buttonDriveThruToggle;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\TicketTypeFilterControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton buttonCateringToggle;
        
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
            System.Uri resourceLocater = new System.Uri("/TemPOS;component/tickettypefiltercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TicketTypeFilterControl.xaml"
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
            this.buttonNoneToggle = ((PosControls.PushRadioButton)(target));
            
            #line 9 "..\..\..\TicketTypeFilterControl.xaml"
            this.buttonNoneToggle.SelectionGained += new System.EventHandler(this.buttonNoneToggle_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonDineInToggle = ((PosControls.PushRadioButton)(target));
            
            #line 10 "..\..\..\TicketTypeFilterControl.xaml"
            this.buttonDineInToggle.SelectionGained += new System.EventHandler(this.buttonDineInToggle_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonCarryOutToggle = ((PosControls.PushRadioButton)(target));
            
            #line 11 "..\..\..\TicketTypeFilterControl.xaml"
            this.buttonCarryOutToggle.SelectionGained += new System.EventHandler(this.buttonCarryOutToggle_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonDeliveryToggle = ((PosControls.PushRadioButton)(target));
            
            #line 12 "..\..\..\TicketTypeFilterControl.xaml"
            this.buttonDeliveryToggle.SelectionGained += new System.EventHandler(this.buttonDeliveryToggle_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonDriveThruToggle = ((PosControls.PushRadioButton)(target));
            
            #line 13 "..\..\..\TicketTypeFilterControl.xaml"
            this.buttonDriveThruToggle.SelectionGained += new System.EventHandler(this.buttonDriveThruToggle_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonCateringToggle = ((PosControls.PushRadioButton)(target));
            
            #line 14 "..\..\..\TicketTypeFilterControl.xaml"
            this.buttonCateringToggle.SelectionGained += new System.EventHandler(this.buttonCateringToggle_SelectionGained);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

