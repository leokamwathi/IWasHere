﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
 Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
Partial Friend NotInheritable Class MySettings
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
    
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
    
    Public Shared ReadOnly Property [Default]() As MySettings
        Get
            
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property eventid() As Integer
        Get
            Return CType(Me("eventid"),Integer)
        End Get
        Set
            Me("eventid") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("http://check-in.fluxcess")>  _
    Public Property checkinserver() As String
        Get
            Return CType(Me("checkinserver"),String)
        End Get
        Set
            Me("checkinserver") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Keynote1")>  _
    Public Property actionid() As String
        Get
            Return CType(Me("actionid"),String)
        End Get
        Set
            Me("actionid") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("online")>  _
    Public Property onoffline() As String
        Get
            Return CType(Me("onoffline"),String)
        End Get
        Set
            Me("onoffline") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property httpusername() As String
        Get
            Return CType(Me("httpusername"),String)
        End Get
        Set
            Me("httpusername") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property httppassword() As String
        Get
            Return CType(Me("httppassword"),String)
        End Get
        Set
            Me("httppassword") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("636363")>  _
    Public Property bgcolor() As String
        Get
            Return CType(Me("bgcolor"),String)
        End Get
        Set
            Me("bgcolor") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property bgpic() As String
        Get
            Return CType(Me("bgpic"),String)
        End Get
        Set
            Me("bgpic") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("ffffff")>  _
    Public Property forecolor() As String
        Get
            Return CType(Me("forecolor"),String)
        End Get
        Set
            Me("forecolor") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
    Public Property qrcodestyle() As String
        Get
            Return CType(Me("qrcodestyle"),String)
        End Get
        Set
            Me("qrcodestyle") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Action Title")>  _
    Public Property actiontitle() As String
        Get
            Return CType(Me("actiontitle"),String)
        End Get
        Set
            Me("actiontitle") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("http://admin.fluxcess")>  _
    Public Property adminurl() As String
        Get
            Return CType(Me("adminurl"),String)
        End Get
        Set
            Me("adminurl") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property adminurlusername() As String
        Get
            Return CType(Me("adminurlusername"),String)
        End Get
        Set
            Me("adminurlusername") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property adminurlpassword() As String
        Get
            Return CType(Me("adminurlpassword"),String)
        End Get
        Set
            Me("adminurlpassword") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("E5262626")>  _
    Public Property popupbackgroundcolor() As String
        Get
            Return CType(Me("popupbackgroundcolor"),String)
        End Get
        Set
            Me("popupbackgroundcolor") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Herzlich Willkommen,")>  _
    Public Property labelcontentThankyou() As String
        Get
            Return CType(Me("labelcontentThankyou"),String)
        End Get
        Set
            Me("labelcontentThankyou") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("FFFFFFFF")>  _
    Public Property popupforegroundcolor() As String
        Get
            Return CType(Me("popupforegroundcolor"),String)
        End Get
        Set
            Me("popupforegroundcolor") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("guest_id")>  _
    Public Property checkinsearchfieldname() As String
        Get
            Return CType(Me("checkinsearchfieldname"),String)
        End Get
        Set
            Me("checkinsearchfieldname") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("in")>  _
    Public Property applicationmode() As String
        Get
            Return CType(Me("applicationmode"),String)
        End Get
        Set
            Me("applicationmode") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Bitte scannen Sie Ihr Ticket!")>  _
    Public Property labelcontentInitialText() As String
        Get
            Return CType(Me("labelcontentInitialText"),String)
        End Get
        Set
            Me("labelcontentInitialText") = value
        End Set
    End Property
End Class

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.IWasHere.MySettings
            Get
                Return Global.IWasHere.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
