﻿#pragma checksum "..\..\..\pages\homePg.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6297CBDFCBEADA07565E609E903D10D4B1CC1FAA928A5B7610F9139ED8FEEB88"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HRSH_GameBox.pages;
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


namespace HRSH_GameBox.pages {
    
    
    /// <summary>
    /// homePg
    /// </summary>
    public partial class homePg : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\pages\homePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HRSH_GameBox.pages.homePg homePge;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\pages\homePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQuote;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\pages\homePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAuthor;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\pages\homePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRandom;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\pages\homePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddGame;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\pages\homePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRedraw;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\pages\homePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel wrpPnl;
        
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
            System.Uri resourceLocater = new System.Uri("/HRSH-GameBox;component/pages/homepg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\homePg.xaml"
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
            this.homePge = ((HRSH_GameBox.pages.homePg)(target));
            
            #line 9 "..\..\..\pages\homePg.xaml"
            this.homePge.Loaded += new System.Windows.RoutedEventHandler(this.homePge_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblQuote = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblAuthor = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnRandom = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btnAddGame = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\pages\homePg.xaml"
            this.btnAddGame.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnAddGame_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRedraw = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\pages\homePg.xaml"
            this.btnRedraw.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnRedraw_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.wrpPnl = ((System.Windows.Controls.WrapPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

