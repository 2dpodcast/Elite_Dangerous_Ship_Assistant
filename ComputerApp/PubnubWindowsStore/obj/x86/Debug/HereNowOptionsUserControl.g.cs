﻿#pragma checksum "C:\Users\sirau\Downloads\c-sharp-master\c-sharp-master\windows-store\windows10\PubnubWindowsStore\PubnubWindowsStore\HereNowOptionsUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "114C9ED4E732D2FC571654102DE9DD05"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PubnubWindowsStore
{
    partial class HereNowOptionsUserControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
                    this.chkHereNowShowUUID = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 2:
                {
                    this.chkHereIncludeUserState = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 3:
                {
                    this.btnOK = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\HereNowOptionsUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnOK).Click += this.btnOK_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btnCancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\HereNowOptionsUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCancel).Click += this.btnCancel_Click;
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

