﻿#pragma checksum "..\..\..\RoomEditorControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9D21EA40C91E2E2A2B9569F8D71E4AA7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PointOfSale;
using PosControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace PointOfSale {
    
    
    /// <summary>
    /// SeatingRoomEditorControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class SeatingRoomEditorControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\RoomEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\RoomEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\RoomEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxName;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\RoomEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushComboBox comboBoxTicketType;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/PointOfSale;component/roomeditorcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RoomEditorControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
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
            this.textBoxName = ((PosControls.CustomTextBox)(target));
            
            #line 41 "..\..\..\RoomEditorControl.xaml"
            this.textBoxName.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.comboBoxTicketType = ((PosControls.PushComboBox)(target));
            
            #line 42 "..\..\..\RoomEditorControl.xaml"
            this.comboBoxTicketType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTicketType_SelectedIndexChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

