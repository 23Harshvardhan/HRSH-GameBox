#pragma checksum "..\..\..\pages\gamePg.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8B605BA0A46037F05762EA9A4A41BBED3CAA38EDB90837D1E17AA54CF8662511"
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
    /// gamePg
    /// </summary>
    public partial class gamePg : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\pages\gamePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgPoster;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\pages\gamePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblGameName;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\pages\gamePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPlayTime;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\pages\gamePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLastPlayed;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\pages\gamePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPlay;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\pages\gamePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConfig;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\pages\gamePg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLastPlayedValue;
        
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
            System.Uri resourceLocater = new System.Uri("/HRSH-GameBox;component/pages/gamepg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\gamePg.xaml"
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
            
            #line 9 "..\..\..\pages\gamePg.xaml"
            ((HRSH_GameBox.pages.gamePg)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imgPoster = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.lblGameName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblPlayTime = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblLastPlayed = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnPlay = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\pages\gamePg.xaml"
            this.btnPlay.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnPlay_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnConfig = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\pages\gamePg.xaml"
            this.btnConfig.Click += new System.Windows.RoutedEventHandler(this.btnConfig_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblLastPlayedValue = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

