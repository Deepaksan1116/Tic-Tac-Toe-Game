﻿#pragma checksum "..\..\Mainmenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9A555CCAD1DE84A6D5912A86DCD0B9D089E00150"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Tic_Tac_Toe_Game_WPF;


namespace Tic_Tac_Toe_Game_WPF {
    
    
    /// <summary>
    /// Mainmenu
    /// </summary>
    public partial class Mainmenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\Mainmenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_playername_1;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Mainmenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_playername_2;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Mainmenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_login;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Mainmenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combobox1;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\Mainmenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_play;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\Mainmenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Userprofile_1;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\Mainmenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Userprofile_2;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\Mainmenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Leaderboard;
        
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
            System.Uri resourceLocater = new System.Uri("/Tic_Tac_Toe_Game_WPF;component/mainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Mainmenu.xaml"
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
            this.txt_playername_1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txt_playername_2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btn_login = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\Mainmenu.xaml"
            this.btn_login.Click += new System.Windows.RoutedEventHandler(this.btn_login_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.combobox1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btn_play = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\Mainmenu.xaml"
            this.btn_play.Click += new System.Windows.RoutedEventHandler(this.btn_play_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_Userprofile_1 = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\Mainmenu.xaml"
            this.btn_Userprofile_1.Click += new System.Windows.RoutedEventHandler(this.btn_Userprofile_1_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Userprofile_2 = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\Mainmenu.xaml"
            this.btn_Userprofile_2.Click += new System.Windows.RoutedEventHandler(this.btn_Userprofile_2_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_Leaderboard = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\Mainmenu.xaml"
            this.btn_Leaderboard.Click += new System.Windows.RoutedEventHandler(this.btn_Leaderboard_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

