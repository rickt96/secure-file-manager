#pragma checksum "..\..\WindowDirectoryEdit.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752182F74EA80E419D622BD3727DBACBCAABD096"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace GestioneFile
{


    /// <summary>
    /// WindowDirectoryEdit
    /// </summary>
    public partial class WindowDirectory : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 11 "..\..\WindowDirectoryEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDirName;

#line default
#line hidden


#line 13 "..\..\WindowDirectoryEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDirDescr;

#line default
#line hidden


#line 14 "..\..\WindowDirectoryEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;

#line default
#line hidden


#line 15 "..\..\WindowDirectoryEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemove;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestioneFile;component/windowdirectoryedit.xaml", System.UriKind.Relative);

#line 1 "..\..\WindowDirectoryEdit.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 8 "..\..\WindowDirectoryEdit.xaml"
                    ((GestioneFile.WindowDirectoryEdit)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);

#line default
#line hidden
                    return;
                case 2:
                    this.txtDirName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.txtDirDescr = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.btnSave = ((System.Windows.Controls.Button)(target));

#line 14 "..\..\WindowDirectoryEdit.xaml"
                    this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.btnRemove = ((System.Windows.Controls.Button)(target));

#line 15 "..\..\WindowDirectoryEdit.xaml"
                    this.btnRemove.Click += new System.Windows.RoutedEventHandler(this.btnRemove_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

