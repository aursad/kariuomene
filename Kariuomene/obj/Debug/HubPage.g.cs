﻿

#pragma checksum "C:\Projects\kariuomene\Kariuomene\Kariuomene\HubPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "91935DACC88C22D418371AB868D9AFAE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kariuomene
{
    partial class HubPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 119 "..\..\HubPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.Region_OnItemClick;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 97 "..\..\HubPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.Naujienos_ItemClick;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 152 "..\..\HubPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Search_OnClick;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 153 "..\..\HubPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Refresh_OnClick;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 156 "..\..\HubPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AboutPage_OnClick;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 157 "..\..\HubPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.KurKreiptis_OnClick;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

