﻿#pragma checksum "..\..\..\Ventanas\VentanaVentas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D7C9B9B76F56A78593DB48C350FD4902E2773F07"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using SwingSuit;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace SwingSuit {
    
    
    /// <summary>
    /// VentanaVentas
    /// </summary>
    public partial class VentanaVentas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Ventanas\VentanaVentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonMostrar;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Ventanas\VentanaVentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonModificar;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Ventanas\VentanaVentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonEliminar;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Ventanas\VentanaVentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAñadir;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Ventanas\VentanaVentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCerrar;
        
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
            System.Uri resourceLocater = new System.Uri("/SwingSuit;component/ventanas/ventanaventas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ventanas\VentanaVentas.xaml"
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
            this.buttonMostrar = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Ventanas\VentanaVentas.xaml"
            this.buttonMostrar.Click += new System.Windows.RoutedEventHandler(this.buttonMostrar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonModificar = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Ventanas\VentanaVentas.xaml"
            this.buttonModificar.Click += new System.Windows.RoutedEventHandler(this.buttonModificar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Ventanas\VentanaVentas.xaml"
            this.buttonEliminar.Click += new System.Windows.RoutedEventHandler(this.buttonEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonAñadir = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Ventanas\VentanaVentas.xaml"
            this.buttonAñadir.Click += new System.Windows.RoutedEventHandler(this.buttonAñadir_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonCerrar = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\Ventanas\VentanaVentas.xaml"
            this.buttonCerrar.Click += new System.Windows.RoutedEventHandler(this.buttonCerrar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

