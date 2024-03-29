﻿#pragma checksum "..\..\..\CouponEditorDetailsControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "401641CF0D7F31E91159D251E7EBED9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
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
    /// CouponEditorDetailsControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class CouponEditorDetailsControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PointOfSale.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxName;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxAmount;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton radioButtonIsPercentage;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton radioButtonIsNotPercentage;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton radioButtonIsActive;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton radioButtonIsNotActive;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushComboBox comboBoxCouponExclusionSelection;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton radioButtonApplyToAll;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton radioButtonIsNotApplyToAll;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton radioButtonIsThirdParty;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton radioButtonIsNotThirdParty;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxAmountLimit;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\CouponEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxLimitPerTicket;
        
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
            System.Uri resourceLocater = new System.Uri("/PointOfSale;component/couponeditordetailscontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CouponEditorDetailsControl.xaml"
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
            this.Configuration = ((PointOfSale.ConfigurationManager)(target));
            return;
            case 3:
            this.textBoxName = ((PosControls.CustomTextBox)(target));
            
            #line 76 "..\..\..\CouponEditorDetailsControl.xaml"
            this.textBoxName.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBoxAmount = ((PosControls.CustomTextBox)(target));
            
            #line 77 "..\..\..\CouponEditorDetailsControl.xaml"
            this.textBoxAmount.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxAmount_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.radioButtonIsPercentage = ((PosControls.PushRadioButton)(target));
            
            #line 79 "..\..\..\CouponEditorDetailsControl.xaml"
            this.radioButtonIsPercentage.SelectionGained += new System.EventHandler(this.radioButtonIsPercentage_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 6:
            this.radioButtonIsNotPercentage = ((PosControls.PushRadioButton)(target));
            
            #line 80 "..\..\..\CouponEditorDetailsControl.xaml"
            this.radioButtonIsNotPercentage.SelectionGained += new System.EventHandler(this.radioButtonIsPercentage_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 7:
            this.radioButtonIsActive = ((PosControls.PushRadioButton)(target));
            
            #line 83 "..\..\..\CouponEditorDetailsControl.xaml"
            this.radioButtonIsActive.SelectionGained += new System.EventHandler(this.radioButtonIsActive_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 8:
            this.radioButtonIsNotActive = ((PosControls.PushRadioButton)(target));
            
            #line 84 "..\..\..\CouponEditorDetailsControl.xaml"
            this.radioButtonIsNotActive.SelectionGained += new System.EventHandler(this.radioButtonIsActive_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 9:
            this.comboBoxCouponExclusionSelection = ((PosControls.PushComboBox)(target));
            
            #line 86 "..\..\..\CouponEditorDetailsControl.xaml"
            this.comboBoxCouponExclusionSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxCouponExclusionSelection_SelectedIndexChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.radioButtonApplyToAll = ((PosControls.PushRadioButton)(target));
            
            #line 88 "..\..\..\CouponEditorDetailsControl.xaml"
            this.radioButtonApplyToAll.SelectionGained += new System.EventHandler(this.radioButtonApplyToAll_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 11:
            this.radioButtonIsNotApplyToAll = ((PosControls.PushRadioButton)(target));
            
            #line 89 "..\..\..\CouponEditorDetailsControl.xaml"
            this.radioButtonIsNotApplyToAll.SelectionGained += new System.EventHandler(this.radioButtonApplyToAll_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 12:
            this.radioButtonIsThirdParty = ((PosControls.PushRadioButton)(target));
            
            #line 92 "..\..\..\CouponEditorDetailsControl.xaml"
            this.radioButtonIsThirdParty.SelectionGained += new System.EventHandler(this.radioButtonIsThirdParty_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 13:
            this.radioButtonIsNotThirdParty = ((PosControls.PushRadioButton)(target));
            
            #line 93 "..\..\..\CouponEditorDetailsControl.xaml"
            this.radioButtonIsNotThirdParty.SelectionGained += new System.EventHandler(this.radioButtonIsThirdParty_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 14:
            this.textBoxAmountLimit = ((PosControls.CustomTextBox)(target));
            
            #line 95 "..\..\..\CouponEditorDetailsControl.xaml"
            this.textBoxAmountLimit.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxAmountLimit_TextChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.textBoxLimitPerTicket = ((PosControls.CustomTextBox)(target));
            
            #line 96 "..\..\..\CouponEditorDetailsControl.xaml"
            this.textBoxLimitPerTicket.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxLimitPerTicket_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

