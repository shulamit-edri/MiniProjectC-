﻿#pragma checksum "..\..\..\Trainee\WindowTrainee.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BA6B48BB896E5C836C1785CFCF7E005A3E8901E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PLWPF.Trainee;
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


namespace PLWPF.Trainee {
    
    
    /// <summary>
    /// WindowTrainee
    /// </summary>
    public partial class WindowTrainee : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Trainee\WindowTrainee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Trainee\WindowTrainee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtAddTrainee;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Trainee\WindowTrainee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtRemoveTrainee;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Trainee\WindowTrainee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtUpadateTrainee;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/trainee/windowtrainee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Trainee\WindowTrainee.xaml"
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
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.BtAddTrainee = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Trainee\WindowTrainee.xaml"
            this.BtAddTrainee.Click += new System.Windows.RoutedEventHandler(this.Button_ClickAddTrainee);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtRemoveTrainee = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Trainee\WindowTrainee.xaml"
            this.BtRemoveTrainee.Click += new System.Windows.RoutedEventHandler(this.Button_ClickRemoveTrainee);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtUpadateTrainee = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Trainee\WindowTrainee.xaml"
            this.BtUpadateTrainee.Click += new System.Windows.RoutedEventHandler(this.Button_ClickUpdateTrainee);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
