﻿#pragma checksum "..\..\..\Pages\ChocolateOutputPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6EB2FEFA1C9B9D92888DF6340983057CB4B5C5C1C05E8B05EEEB11C07D755821"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WPFChocolate.Pages;


namespace WPFChocolate.Pages {
    
    
    /// <summary>
    /// ChocolateOutputPage
    /// </summary>
    public partial class ChocolateOutputPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 25 "..\..\..\Pages\ChocolateOutputPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFilter;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\ChocolateOutputPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFitter;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\ChocolateOutputPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSort;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\ChocolateOutputPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvProducts;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Pages\ChocolateOutputPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblFinderProduct;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Pages\ChocolateOutputPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button toOrder;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Pages\ChocolateOutputPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddData;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Pages\ChocolateOutputPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changeToOrderPage;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFChocolate;component/pages/chocolateoutputpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ChocolateOutputPage.xaml"
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
            
            #line 9 "..\..\..\Pages\ChocolateOutputPage.xaml"
            ((WPFChocolate.Pages.ChocolateOutputPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\Pages\ChocolateOutputPage.xaml"
            this.tbFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbFilter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbFitter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\..\Pages\ChocolateOutputPage.xaml"
            this.cbFitter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbFitter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\Pages\ChocolateOutputPage.xaml"
            this.cbSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lvProducts = ((System.Windows.Controls.ListView)(target));
            
            #line 41 "..\..\..\Pages\ChocolateOutputPage.xaml"
            this.lvProducts.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListView_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tblFinderProduct = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.toOrder = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\Pages\ChocolateOutputPage.xaml"
            this.toOrder.Click += new System.Windows.RoutedEventHandler(this.toOrder_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddData = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\Pages\ChocolateOutputPage.xaml"
            this.AddData.Click += new System.Windows.RoutedEventHandler(this.AddData_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.changeToOrderPage = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\Pages\ChocolateOutputPage.xaml"
            this.changeToOrderPage.Click += new System.Windows.RoutedEventHandler(this.changeToOrderPage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 54 "..\..\..\Pages\ChocolateOutputPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.addToOrder_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

