﻿#pragma checksum "..\..\AddList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7CA73A06BCB14AD72221F26E5803472B99969C52"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SimpleList;
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


namespace SimpleList {
    
    
    /// <summary>
    /// AddList
    /// </summary>
    public partial class AddList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\AddList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid backM;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoHome;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPerson;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox myNames;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowPeople;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResetList;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveLastG;
        
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
            System.Uri resourceLocater = new System.Uri("/SimpleList;component/addlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddList.xaml"
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
            this.backM = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.addName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.GoHome = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\AddList.xaml"
            this.GoHome.Click += new System.Windows.RoutedEventHandler(this.GoHome_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddPerson = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\AddList.xaml"
            this.AddPerson.Click += new System.Windows.RoutedEventHandler(this.AddPerson_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.myNames = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.ShowPeople = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\AddList.xaml"
            this.ShowPeople.Click += new System.Windows.RoutedEventHandler(this.ShowPeople_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ResetList = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\AddList.xaml"
            this.ResetList.Click += new System.Windows.RoutedEventHandler(this.ResetList_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RemoveLastG = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\AddList.xaml"
            this.RemoveLastG.Click += new System.Windows.RoutedEventHandler(this.RemoveLastG_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

