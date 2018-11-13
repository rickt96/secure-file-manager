﻿#pragma checksum "..\..\WindowOpen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8FC4922259F7B8AD9CDF1DFA083BAFA067FB5FB1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using SecureFileManager;
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


namespace SecureFileManager {
    
    
    /// <summary>
    /// WindowOpen
    /// </summary>
    public partial class WindowOpen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblError;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpen;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteFile;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pwbPasswd;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilePath;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFileDialog;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLength;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCreationDate;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLastEdit;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbCreate;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\WindowOpen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbOpen;
        
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
            System.Uri resourceLocater = new System.Uri("/SecureFileManager;component/windowopen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowOpen.xaml"
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
            
            #line 12 "..\..\WindowOpen.xaml"
            ((SecureFileManager.WindowOpen)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblError = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnOpen = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\WindowOpen.xaml"
            this.btnOpen.Click += new System.Windows.RoutedEventHandler(this.btnOpen_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDeleteFile = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\WindowOpen.xaml"
            this.btnDeleteFile.Click += new System.Windows.RoutedEventHandler(this.btnDeleteFile_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.pwbPasswd = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.txtFilePath = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\WindowOpen.xaml"
            this.txtFilePath.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtFilePath_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnFileDialog = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\WindowOpen.xaml"
            this.btnFileDialog.Click += new System.Windows.RoutedEventHandler(this.btnFileDialog_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblLength = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblCreationDate = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.lblLastEdit = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.rdbCreate = ((System.Windows.Controls.RadioButton)(target));
            
            #line 42 "..\..\WindowOpen.xaml"
            this.rdbCreate.Click += new System.Windows.RoutedEventHandler(this.switchRdbMode_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.rdbOpen = ((System.Windows.Controls.RadioButton)(target));
            
            #line 43 "..\..\WindowOpen.xaml"
            this.rdbOpen.Click += new System.Windows.RoutedEventHandler(this.switchRdbMode_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

