﻿#pragma checksum "..\..\UCDonneesComm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2C1BDFDEB9170DD6CD15C44F3D5BEC50088A72FC5D69B7FC62B97B565A12F56A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using UIL;


namespace UIL {
    
    
    /// <summary>
    /// UCDonneesComm
    /// </summary>
    public partial class UCDonneesComm : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\UCDonneesComm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbOrdre;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\UCDonneesComm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbElement;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UCDonneesComm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Annee;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\UCDonneesComm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem NbUnites;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\UCDonneesComm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem PrixMoyenPar1000;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\UCDonneesComm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgVente;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\UCDonneesComm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn colAnnee;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\UCDonneesComm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn colNbUnite;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\UCDonneesComm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn colPrix;
        
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
            System.Uri resourceLocater = new System.Uri("/UIL;component/ucdonneescomm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UCDonneesComm.xaml"
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
            this.cbOrdre = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\UCDonneesComm.xaml"
            this.cbOrdre.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbOrdre_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbElement = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\UCDonneesComm.xaml"
            this.cbElement.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbElement_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Annee = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 4:
            this.NbUnites = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 5:
            this.PrixMoyenPar1000 = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 6:
            this.dgVente = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.colAnnee = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.colNbUnite = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 9:
            this.colPrix = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
