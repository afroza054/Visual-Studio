﻿#pragma checksum "E:\A FILE OF MUZICC\A_MODULE_1_9\PROJECT ALL\Projects_M2\Afroza_Module_2\Museum\Museum\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "221759594ACF61DB0A56FD1010F4B707"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Museum
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 21
                {
                    this.tblBooks = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // MainPage.xaml line 39
                {
                    this.tObject_Id = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // MainPage.xaml line 41
                {
                    this.tType_of_Object = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 5: // MainPage.xaml line 42
                {
                    this.tPeriod_of_Object = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // MainPage.xaml line 43
                {
                    this.tDescription = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // MainPage.xaml line 49
                {
                    this.first = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.first).Click += this.First_Click;
                }
                break;
            case 8: // MainPage.xaml line 50
                {
                    this.prev = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.prev).Click += this.Prev_Click;
                }
                break;
            case 9: // MainPage.xaml line 51
                {
                    this.next = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.next).Click += this.Next_Click;
                }
                break;
            case 10: // MainPage.xaml line 52
                {
                    this.last = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.last).Click += this.Last_Click;
                }
                break;
            case 11: // MainPage.xaml line 57
                {
                    this.add = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.add).Click += this.Add_Click;
                }
                break;
            case 12: // MainPage.xaml line 58
                {
                    this.edit = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.edit).Click += this.Edit_Click;
                }
                break;
            case 13: // MainPage.xaml line 59
                {
                    this.save = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.save).Click += this.Save_Click;
                }
                break;
            case 14: // MainPage.xaml line 60
                {
                    this.cancel = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.cancel).Click += this.Cancel_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
