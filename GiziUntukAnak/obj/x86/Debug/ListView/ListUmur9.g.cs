﻿#pragma checksum "C:\Users\Herdi\Documents\GitHub\GiziUntukAnak\GiziUntukAnak\ListView\ListUmur9.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BAC82C2951865EBE19FEAAA1630FF684"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GiziUntukAnak.ListView
{
    partial class ListUmur9 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.splitView1 = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.iconListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 35 "..\..\..\ListView\ListUmur9.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.iconListBox).SelectionChanged += this.iconListBox_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.BerandaListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 4:
                {
                    this.polaListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 5:
                {
                    this.kalkulatorListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6:
                {
                    this.TentangListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 7:
                {
                    this.btnHamburger = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\ListView\ListUmur9.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnHamburger).Click += this.btnHamburger_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

