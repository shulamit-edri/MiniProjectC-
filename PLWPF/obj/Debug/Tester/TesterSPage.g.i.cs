﻿#pragma checksum "..\..\..\Tester\TesterSPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B1A228BCC4D9B8F681702D8026CAB59AE31547C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PLWPF.Tester;
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


namespace PLWPF.Tester {
    
    
    /// <summary>
    /// TesterActionPage
    /// </summary>
    public partial class TesterActionPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Tester\TesterSPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GrdButtons;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Tester\TesterSPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtAddTester;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Tester\TesterSPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtRemoveTester;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Tester\TesterSPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtUpdateTester;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/tester/testerspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Tester\TesterSPage.xaml"
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
            this.GrdButtons = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.BtAddTester = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Tester\TesterSPage.xaml"
            this.BtAddTester.Click += new System.Windows.RoutedEventHandler(this.BtAddTester_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtRemoveTester = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Tester\TesterSPage.xaml"
            this.BtRemoveTester.Click += new System.Windows.RoutedEventHandler(this.BtRemoveTester_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtUpdateTester = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Tester\TesterSPage.xaml"
            this.BtUpdateTester.Click += new System.Windows.RoutedEventHandler(this.BtUpdateTester_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

