﻿#pragma checksum "..\..\..\HomePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A4CA55C9C72BBD6E07715E92219CE91907628338"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Web.WebView2.Wpf;
using PRN212_Assignment;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PRN212_Assignment {
    
    
    /// <summary>
    /// HomePage
    /// </summary>
    public partial class HomePage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHomePage;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCart;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogIn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSignUp;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvBookList;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Project_PRN212;component/homepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\HomePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnHomePage = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.btnCart = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\HomePage.xaml"
            this.btnCart.Click += new System.Windows.RoutedEventHandler(this.btnCart_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnLogIn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\HomePage.xaml"
            this.btnLogIn.Click += new System.Windows.RoutedEventHandler(this.btnLogIn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSignUp = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\HomePage.xaml"
            this.btnSignUp.Click += new System.Windows.RoutedEventHandler(this.btnSignUp_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lvBookList = ((System.Windows.Controls.ListView)(target));
            
            #line 21 "..\..\..\HomePage.xaml"
            this.lvBookList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvBookList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\HomePage.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

