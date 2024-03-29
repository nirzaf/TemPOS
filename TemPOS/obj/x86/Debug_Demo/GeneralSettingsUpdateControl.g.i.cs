﻿#pragma checksum "..\..\..\GeneralSettingsUpdateControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D2EE045F61F8E499B0E5F04203A4770844ADBD68EB8DAE603465F5536872C921"
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
    /// GeneralSettingsUpdateControl
    /// </summary>
    public partial class GeneralSettingsUpdateControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\GeneralSettingsUpdateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\GeneralSettingsUpdateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\GeneralSettingsUpdateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollViewer dragScrollViewer;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\GeneralSettingsUpdateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.FlowDocumentScrollViewer flowDocumentScroll;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\GeneralSettingsUpdateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonVersionCheck;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\GeneralSettingsUpdateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonUpdate;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\GeneralSettingsUpdateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressBar;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\GeneralSettingsUpdateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton radioButtonAutoUpdateIsEnabled;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\GeneralSettingsUpdateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushRadioButton radioButtonAutoUpdateIsNotEnabled;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\GeneralSettingsUpdateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxServer;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\GeneralSettingsUpdateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxPort;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\GeneralSettingsUpdateControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonSave;
        
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
            System.Uri resourceLocater = new System.Uri("/TemPOS;component/generalsettingsupdatecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GeneralSettingsUpdateControl.xaml"
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
            
            #line 13 "..\..\..\GeneralSettingsUpdateControl.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dragScrollViewer = ((PosControls.DragScrollViewer)(target));
            return;
            case 5:
            this.flowDocumentScroll = ((System.Windows.Controls.FlowDocumentScrollViewer)(target));
            return;
            case 6:
            this.buttonVersionCheck = ((PosControls.TextBlockButton)(target));
            
            #line 43 "..\..\..\GeneralSettingsUpdateControl.xaml"
            this.buttonVersionCheck.Click += new System.Windows.RoutedEventHandler(this.buttonVersionCheck_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonUpdate = ((PosControls.TextBlockButton)(target));
            
            #line 44 "..\..\..\GeneralSettingsUpdateControl.xaml"
            this.buttonUpdate.Click += new System.Windows.RoutedEventHandler(this.buttonUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.progressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 9:
            this.radioButtonAutoUpdateIsEnabled = ((PosControls.PushRadioButton)(target));
            
            #line 54 "..\..\..\GeneralSettingsUpdateControl.xaml"
            this.radioButtonAutoUpdateIsEnabled.SelectionGained += new System.EventHandler(this.radioButtonAutoUpdateIsEnabled_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 10:
            this.radioButtonAutoUpdateIsNotEnabled = ((PosControls.PushRadioButton)(target));
            
            #line 55 "..\..\..\GeneralSettingsUpdateControl.xaml"
            this.radioButtonAutoUpdateIsNotEnabled.SelectionGained += new System.EventHandler(this.radioButtonAutoUpdateIsNotEnabled_SelectionGained);
            
            #line default
            #line hidden
            return;
            case 11:
            this.textBoxServer = ((PosControls.CustomTextBox)(target));
            
            #line 57 "..\..\..\GeneralSettingsUpdateControl.xaml"
            this.textBoxServer.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxServer_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.textBoxPort = ((PosControls.CustomTextBox)(target));
            
            #line 58 "..\..\..\GeneralSettingsUpdateControl.xaml"
            this.textBoxPort.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxPort_TextChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.buttonSave = ((PosControls.TextBlockButton)(target));
            
            #line 59 "..\..\..\GeneralSettingsUpdateControl.xaml"
            this.buttonSave.Click += new System.Windows.RoutedEventHandler(this.buttonSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

