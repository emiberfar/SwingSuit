﻿#pragma checksum "..\..\..\VentanaModificar\ModificarCliente.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AC28F31AE18280BAE371D5CF8096C0686C24D11F"
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


namespace SwingSuit.VentanaModificar {
    
    
    /// <summary>
    /// ModificarCliente
    /// </summary>
    public partial class ModificarCliente : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\VentanaModificar\ModificarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox id;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\VentanaModificar\ModificarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nombre;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\VentanaModificar\ModificarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox apellido;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\VentanaModificar\ModificarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dni;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\VentanaModificar\ModificarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox direccion;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\VentanaModificar\ModificarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox telefono;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\VentanaModificar\ModificarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Aceptar;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\VentanaModificar\ModificarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Borrar;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\VentanaModificar\ModificarCliente.xaml"
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
            System.Uri resourceLocater = new System.Uri("/SwingSuit;component/ventanamodificar/modificarcliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\VentanaModificar\ModificarCliente.xaml"
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
            this.id = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.nombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.apellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.dni = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.direccion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.telefono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Aceptar = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\VentanaModificar\ModificarCliente.xaml"
            this.Aceptar.Click += new System.Windows.RoutedEventHandler(this.Anadir_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Borrar = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\VentanaModificar\ModificarCliente.xaml"
            this.Borrar.Click += new System.Windows.RoutedEventHandler(this.borrar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Cancelar = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\VentanaModificar\ModificarCliente.xaml"
            this.Cancelar.Click += new System.Windows.RoutedEventHandler(this.atras_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

