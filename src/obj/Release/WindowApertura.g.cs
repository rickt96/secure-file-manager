﻿#pragma checksum "..\..\WindowApertura.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AEFC18B0F1E793511542DD079C684DE7CFA9D909"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using GestioneFile;
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


namespace GestioneFile {
    
    
    /// <summary>
    /// WindowApertura
    /// </summary>
    public partial class WindowApertura : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\WindowApertura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_db_path;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\WindowApertura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_carica;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WindowApertura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdb_crea;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WindowApertura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdb_apri;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WindowApertura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_accedi;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\WindowApertura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_error;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\WindowApertura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pwb_password;
        
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
            System.Uri resourceLocater = new System.Uri("/GestioneFile;component/windowapertura.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowApertura.xaml"
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
            
            #line 7 "..\..\WindowApertura.xaml"
            ((GestioneFile.WindowApertura)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_db_path = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\WindowApertura.xaml"
            this.txt_db_path.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_db_path_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_carica = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\WindowApertura.xaml"
            this.btn_carica.Click += new System.Windows.RoutedEventHandler(this.btn_carica_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rdb_crea = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.rdb_apri = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.btn_accedi = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\WindowApertura.xaml"
            this.btn_accedi.Click += new System.Windows.RoutedEventHandler(this.btn_accedi_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lbl_error = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.pwb_password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

