﻿#pragma checksum "..\..\..\VentanaEliminar\EliminarCliente.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8C01A7B07B0045860823507C231A775AFFD909DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using SwingSuit.VentanaAnadir;
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


namespace SwingSuit.VentanaEliminar {
    
    
    /// <summary>
    /// EliminarCliente
    /// </summary>
    public partial class EliminarCliente : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\VentanaEliminar\EliminarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid mostrar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\VentanaEliminar\EliminarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox id;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\VentanaEliminar\EliminarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nombre;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\VentanaEliminar\EliminarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button aceptar;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\VentanaEliminar\EliminarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Borrar;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\VentanaEliminar\EliminarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/SwingSuit;component/ventanaeliminar/eliminarcliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\VentanaEliminar\EliminarCliente.xaml"
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
            this.mostrar = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.id = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.nombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.aceptar = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\VentanaEliminar\EliminarCliente.xaml"
            this.aceptar.Click += new System.Windows.RoutedEventHandler(this.Anadir_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Borrar = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\VentanaEliminar\EliminarCliente.xaml"
            this.Borrar.Click += new System.Windows.RoutedEventHandler(this.borrar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Cancelar = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\VentanaEliminar\EliminarCliente.xaml"
            this.Cancelar.Click += new System.Windows.RoutedEventHandler(this.atras_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

