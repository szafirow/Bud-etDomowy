﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ten kod został wygenerowany przez narzędzie.
'     Wersja wykonawcza:4.0.30319.42000
'
'     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
'     kod zostanie ponownie wygenerowany.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Ta klasa została automatycznie wygenerowana za pomocą klasy StronglyTypedResourceBuilder
    'przez narzędzie, takie jak ResGen lub Visual Studio.
    'Aby dodać lub usunąć członka, edytuj plik .ResX, a następnie ponownie uruchom ResGen
    'z opcją /str lub ponownie utwórz projekt VS.
    '''<summary>
    '''  Klasa zasobu wymagająca zdefiniowania typu do wyszukiwania zlokalizowanych ciągów itd.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''Zwraca buforowane wystąpienie ResourceManager używane przez tę klasę.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("BudzetDomowy.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Przesłania właściwość CurrentUICulture bieżącego wątku dla wszystkich
        '''  przypadków przeszukiwania zasobów za pomocą tej klasy zasobów wymagającej zdefiniowania typu.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Wyszukuje zlokalizowany zasób typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property add() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("add", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Wyszukuje zlokalizowany zasób typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property back() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("back", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Wyszukuje zlokalizowany zasób typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property del() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("del", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Wyszukuje zlokalizowany zasób typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property edit() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("edit", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Wyszukuje zlokalizowany zasób typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property excel() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("excel", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Wyszukuje zlokalizowany zasób typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property logo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("logo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Wyszukuje zlokalizowany zasób typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property pdf() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("pdf", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Wyszukuje zlokalizowany zasób typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property reload() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("reload", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Wyszukuje zlokalizowany zasób typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property slownik_budzet_domowy() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("slownik_budzet-domowy", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
