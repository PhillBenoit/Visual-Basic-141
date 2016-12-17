﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Namespace Global.VB8_BMI_Phone

    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
    Partial Public Class App
        Implements Global.Windows.UI.Xaml.Markup.IXamlMetadataProvider
        Private _provider As Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlTypeInfoProvider

        Public Function GetXamlType(type as Global.System.Type) As Global.Windows.UI.Xaml.Markup.IXamlType Implements Global.Windows.UI.Xaml.Markup.IXamlMetadataProvider.GetXamlType
            If _provider Is Nothing
                _provider = new Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlTypeInfoProvider()
            End If
            Return _provider.GetXamlTypeByType(type)
        End Function

        Public Function GetXamlType(fullName As String) As Global.Windows.UI.Xaml.Markup.IXamlType Implements Global.Windows.UI.Xaml.Markup.IXamlMetadataProvider.GetXamlType
            if _provider Is Nothing
                _provider = New Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlTypeInfoProvider()
            End If
            return _provider.GetXamlTypeByName(fullName)
        End Function

        Public Function GetXmlnsDefinitions() As Global.Windows.UI.Xaml.Markup.XmlnsDefinition() Implements Global.Windows.UI.Xaml.Markup.IXamlMetadataProvider.GetXmlnsDefinitions
            Return New Global.Windows.UI.Xaml.Markup.XmlnsDefinition() {}
        End Function
    End Class

End Namespace

Namespace Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _    
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Class XamlTypeInfoProvider
        Public Function GetXamlTypeByType(ByVal type As Global.System.Type) As Global.Windows.UI.Xaml.Markup.IXamlType
            Dim xamlType As Global.Windows.UI.Xaml.Markup.IXamlType = Nothing
            If _xamlTypeCacheByType.TryGetValue(type, xamlType) Then
                Return xamlType
            End If
            Dim typeIndex As Integer = LookupTypeIndexByType(type)
            If typeIndex <> -1 Then
                xamlType = CreateXamlType(typeIndex)
            End If
            If xamlType IsNot Nothing Then
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType)
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType)
            End If
            Return xamlType
        End Function

        Public Function GetXamlTypeByName(ByVal typeName As String) As Global.Windows.UI.Xaml.Markup.IXamlType
            If String.IsNullOrEmpty(typeName) Then
                Return Nothing
            End If
            Dim xamlType As Global.Windows.UI.Xaml.Markup.IXamlType = Nothing
            If _xamlTypeCacheByName.TryGetValue(typeName, xamlType) Then
                Return xamlType
            End If
            Dim typeIndex As Integer = LookupTypeIndexByName(typeName)
            if typeIndex <> -1 Then
                xamlType = CreateXamlType(typeIndex)
            End If
            if xamlType IsNot Nothing
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType)
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType)
            End If
            Return xamlType
        End Function

        Public Function GetMemberByLongName(ByVal longMemberName As String) As Global.Windows.UI.Xaml.Markup.IXamlMember
            If String.IsNullOrEmpty(longMemberName) Then
                Return Nothing
            End If
            Dim xamlMember As Global.Windows.UI.Xaml.Markup.IXamlMember = Nothing
            If _xamlMembers.TryGetValue(longMemberName, xamlMember) Then
                Return xamlMember
            End If
            xamlMember = CreateXamlMember(longMemberName)
            If xamlMember IsNot Nothing Then
                _xamlMembers.Add(longMemberName, xamlMember)
            End If
            Return xamlMember
        End Function

        Private _xamlTypeCacheByName As New Global.System.Collections.Generic.Dictionary(Of String, Global.Windows.UI.Xaml.Markup.IXamlType)()
        Private _xamlTypeCacheByType As New Global.System.Collections.Generic.Dictionary(Of Global.System.Type, Global.Windows.UI.Xaml.Markup.IXamlType)()
        Private _xamlMembers As New Global.System.Collections.Generic.Dictionary(Of String, Global.Windows.UI.Xaml.Markup.IXamlMember)()

        Private _typeNameTable(2) As String
        Private _typeTable(2) As Global.System.Type

        Private Sub InitTypeTables()
            _typeNameTable(0) = "VB8_BMI_Phone.MainPage"
            _typeNameTable(1) = "Windows.UI.Xaml.Controls.Page"
            _typeNameTable(2) = "Windows.UI.Xaml.Controls.UserControl"
            _typeTable(0) = GetType(Global.VB8_BMI_Phone.MainPage)
            _typeTable(1) = GetType(Global.Windows.UI.Xaml.Controls.Page)
            _typeTable(2) = GetType(Global.Windows.UI.Xaml.Controls.UserControl)
        End Sub

        Private Function LookupTypeIndexByName(ByVal typeName As String) As Integer
            If _typeNameTable(0) Is Nothing
                InitTypeTables()
            End If
            For i As Integer = 0 To _typeNameTable.Length - 1
                If 0 = String.CompareOrdinal(_typeNameTable(i), typeName) Then
                    Return i
                End If
            Next i
            Return -1
        End Function

        Private Function LookupTypeIndexByType(ByVal type As Global.System.Type) As Integer
            If _typeTable(0) Is Nothing
                InitTypeTables()
            End If
            For i As Integer = 0 To _typeTable.Length - 1
                If Global.System.Type.Equals(type, _typeTable(i)) Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Private Function Activate_0_MainPage() As Global.System.Object
            Return New Global.VB8_BMI_Phone.MainPage()
        End Function


        Private Function CreateXamlType(ByVal typeIndex As Integer) As Global.Windows.UI.Xaml.Markup.IXamlType
            Dim xamlType As Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlSystemBaseType = Nothing
            Dim userType As Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlUserType
            Dim typeName As String = _typeNameTable(typeIndex)
            Dim type As Global.System.Type = _typeTable(typeIndex)

            Select Case typeIndex
            Case 0     ' VB8_BMI_Phone.MainPage
                userType = New Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlUserType(Me, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"))
                userType.Activator = AddressOf Activate_0_MainPage
                userType.SetIsLocalType()
                xamlType = userType

            Case 1     ' Windows.UI.Xaml.Controls.Page
                xamlType = New Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlSystemBaseType(typeName, type)

            Case 2     ' Windows.UI.Xaml.Controls.UserControl
                xamlType = New Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlSystemBaseType(typeName, type)

            End Select
            Return xamlType
        End Function



        Private Function CreateXamlMember(ByVal longMemberName As String) As XamlMember
            Dim xamlMember As Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlMember = Nothing
            ' No Local Properties
            Return xamlMember
        End Function

    End Class

        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _    
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Class XamlSystemBaseType
        Implements Global.Windows.UI.Xaml.Markup.IXamlType
        Private _fullName As String
        Private _underlyingType As Global.System.Type

        Public Sub New(ByVal fullName As String, ByVal underlyingType As Global.System.Type)
            _fullName = fullName
            _underlyingType = underlyingType
        End Sub

        Public ReadOnly Property UnderlyingType As Global.System.Type Implements Global.Windows.UI.Xaml.Markup.IXamlType.UnderlyingType
            Get
                Return _underlyingType
            End Get
        End Property

        Public Overridable ReadOnly Property FullName() As String Implements Global.Windows.UI.Xaml.Markup.IXamlType.FullName
            Get
                Return _fullName
            End Get
        End Property

        Public Overridable ReadOnly Property BaseType() As Global.Windows.UI.Xaml.Markup.IXamlType Implements Global.Windows.UI.Xaml.Markup.IXamlType.BaseType
            Get
                Throw New Global.System.NotImplementedException()
            End Get
        End Property

        Public Overridable ReadOnly Property ContentProperty() As Global.Windows.UI.Xaml.Markup.IXamlMember Implements Global.Windows.UI.Xaml.Markup.IXamlType.ContentProperty
            Get
                Throw New Global.System.NotImplementedException()
            End Get
        End Property

        Public Overridable Function GetMember(ByVal name As String) As Global.Windows.UI.Xaml.Markup.IXamlMember Implements Global.Windows.UI.Xaml.Markup.IXamlType.GetMember
            Throw New Global.System.NotImplementedException()
        End Function

        Public Overridable ReadOnly Property IsArray() As Boolean Implements Global.Windows.UI.Xaml.Markup.IXamlType.IsArray
            Get
                Throw New Global.System.NotImplementedException()
            End Get
        End Property

        Public Overridable ReadOnly Property IsCollection() As Boolean Implements Global.Windows.UI.Xaml.Markup.IXamlType.IsCollection
            Get
                Throw New Global.System.NotImplementedException()
            End Get
        End Property
        Public Overridable ReadOnly Property IsConstructible() As Boolean Implements Global.Windows.UI.Xaml.Markup.IXamlType.IsConstructible
            Get
                Throw New Global.System.NotImplementedException()
            End Get
        End Property

        Public Overridable ReadOnly Property IsDictionary() As Boolean Implements Global.Windows.UI.Xaml.Markup.IXamlType.IsDictionary
            Get
                Throw New Global.System.NotImplementedException()
            End Get
        End Property

        Public Overridable ReadOnly Property IsMarkupExtension() As Boolean Implements Global.Windows.UI.Xaml.Markup.IXamlType.IsMarkupExtension
            Get
                Throw New Global.System.NotImplementedException()
            End Get
        End Property

        Public Overridable  ReadOnly Property IsBindable() As Boolean Implements Global.Windows.UI.Xaml.Markup.IXamlType.IsBindable
            Get
                Throw New Global.System.NotImplementedException()
            End Get
        End Property

        Public Overridable ReadOnly Property ItemType() As Global.Windows.UI.Xaml.Markup.IXamlType Implements Global.Windows.UI.Xaml.Markup.IXamlType.ItemType
            Get
                Throw New Global.System.NotImplementedException()
            End Get
        End Property

        Public Overridable ReadOnly Property KeyType() As Global.Windows.UI.Xaml.Markup.IXamlType Implements Global.Windows.UI.Xaml.Markup.IXamlType.KeyType
            Get
                Throw New Global.System.NotImplementedException()
            End Get
        End Property

        Public Overridable Function ActivateInstance() As Global.System.Object Implements Global.Windows.UI.Xaml.Markup.IXamlType.ActivateInstance
            Throw New Global.System.NotImplementedException()
        End Function

        Public Overridable Sub AddToMap(ByVal instance As Global.System.Object, ByVal key As Global.System.Object, ByVal item As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IXamlType.AddToMap
            Throw New Global.System.NotImplementedException()
        End Sub

        Public Overridable Sub AddToVector(ByVal instance As Global.System.Object, ByVal item As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IXamlType.AddToVector
            Throw New Global.System.NotImplementedException()
        End Sub

        Public Overridable Sub RunInitializer() Implements Global.Windows.UI.Xaml.Markup.IXamlType.RunInitializer
            Throw New Global.System.NotImplementedException()
        End Sub

        Public Overridable Function CreateFromString(ByVal input As String) As Global.System.Object Implements Global.Windows.UI.Xaml.Markup.IXamlType.CreateFromString
            Throw New Global.System.NotImplementedException()
        End Function

        Public Overridable  ReadOnly Property IsReturnTypeStub() As Boolean
            Get
                Throw New Global.System.NotImplementedException()
            End Get
        End Property

        Public Overridable  ReadOnly Property IsLocalType() As Boolean
            Get
                Throw New Global.System.NotImplementedException()
            End Get
        End Property
    End Class

    Friend Delegate Function Activator() As Global.System.Object
    Friend Delegate Sub AddToCollection(instance As Global.System.Object, item As Global.System.Object)
    Friend Delegate Sub AddToDictionary(instance As Global.System.Object, key As Global.System.Object, item As Global.System.Object)

        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _    
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Class XamlUserType
        Inherits Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlSystemBaseType
        Private _provider As Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlTypeInfoProvider
        Private _baseType As Global.Windows.UI.Xaml.Markup.IXamlType
        Private _isArray As Boolean
        Private _isMarkupExtension As Boolean
        Private _isBindable As Boolean
        Private _isReturnTypeStub As Boolean
        Private _isLocalType As Boolean

        Private _contentPropertyName As String
        Private _itemTypeName As String
        Private _keyTypeName As String
        Private _memberNames As Dictionary(Of String, String)
        Private _enumValues As Dictionary(Of String, Global.System.Object)

        Public Sub New(ByVal provider As Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlTypeInfoProvider, ByVal fullName As String, ByVal fullType As Global.System.Type, ByVal baseType As Global.Windows.UI.Xaml.Markup.IXamlType)
            MyBase.New(fullName, fullType)
            _provider = provider
            _baseType = baseType
        End Sub

        ' --- Interface methods ----

        Public Overrides ReadOnly Property BaseType() As Global.Windows.UI.Xaml.Markup.IXamlType
            Get
                Return _baseType
            End Get
        End Property

        Public Overrides ReadOnly Property IsArray() As Boolean
            Get
                Return _isArray
            End Get
        End Property

        Public Overrides ReadOnly Property IsCollection() As Boolean
            Get
                Return CollectionAdd <> Nothing
            End Get
        End Property

        Public Overrides ReadOnly Property IsConstructible() As Boolean
            Get
                Return Activator <> Nothing
            End Get
        End Property

        Public Overrides ReadOnly Property IsDictionary() As Boolean
            Get
                Return DictionaryAdd <> Nothing
            End Get
        End Property

        Public Overrides ReadOnly Property IsMarkupExtension() As Boolean
            Get
                Return _isMarkupExtension
            End Get
        End Property

        Public Overrides ReadOnly Property IsBindable() as Boolean
            Get
                Return _isBindable
            End Get
        End Property

        Public Overrides ReadOnly Property ContentProperty() As Global.Windows.UI.Xaml.Markup.IXamlMember
            Get
                Return _provider.GetMemberByLongName(_contentPropertyName)
            End Get
        End Property

        Public Overrides ReadOnly Property ItemType() As Global.Windows.UI.Xaml.Markup.IXamlType
            Get
                Return _provider.GetXamlTypeByName(_itemTypeName)
            End Get
        End Property

        Public Overrides ReadOnly Property KeyType() As Global.Windows.UI.Xaml.Markup.IXamlType
            Get
                Return _provider.GetXamlTypeByName(_keyTypeName)
            End Get
        End Property

        Public Overrides Function GetMember(ByVal name As String) As Global.Windows.UI.Xaml.Markup.IXamlMember
            If _memberNames Is Nothing Then
                Return Nothing
            End If
            Dim longName As String = Nothing
            If _memberNames.TryGetValue(name, longName) Then
                Return _provider.GetMemberByLongName(longName)
            End If
            Return Nothing
        End Function

        Public Overrides Function ActivateInstance() As Global.System.Object
            Return Activator.Invoke()
        End Function

        Public Overrides Sub AddToMap(ByVal instance As Global.System.Object, ByVal key As Global.System.Object, ByVal item As Global.System.Object)
            DictionaryAdd.Invoke(instance, key, item)
        End Sub

        Public Overrides Sub AddToVector(ByVal instance As Global.System.Object, ByVal item As Global.System.Object)
            CollectionAdd.Invoke(instance, item)
        End Sub

        Public Overrides Sub RunInitializer()
            Global.System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle)
        End Sub

        Public Overrides Function CreateFromString(ByVal input As String) As Global.System.Object
            If  Not _enumValues Is Nothing Then
                Dim returnValue As Int32 = 0

                Dim valueParts As String() = input.Split(New [Char]() {","c})

                For Each valuePart As String In valueParts
                    Dim partValue As Global.System.Object = Nothing
                    Dim enumFieldValue As Int32 = 0
                    Try
                        If _enumValues.TryGetValue(valuePart.Trim(), partValue) Then
                            enumFieldValue = Convert.ToInt32(partValue)
                        Else
                            Try
                                enumFieldValue = Convert.ToInt32(valuePart.Trim())
                            Catch ex As FormatException
                                For Each key As String In _enumValues.Keys
                                    If String.Compare(valuePart.Trim(), key, Global.System.StringComparison.OrdinalIgnoreCase) = 0 Then
                                        If _enumValues.TryGetValue(key.Trim(), partValue) Then
                                            enumFieldValue = Convert.ToInt32(partValue)
                                        End If
                                        Exit For
                                    End If
                                Next
                            End Try
                        End If

                        returnValue = returnValue Or enumFieldValue

                    Catch ex As Exception
                        Throw New ArgumentException(input, FullName)
                    End Try
                Next valuePart

                Return returnValue

            End If
            Throw New ArgumentException(input, FullName)
        End Function

        ' ---- End of Interface Methods

        Public Overrides ReadOnly Property IsReturnTypeStub() As Boolean
            Get
                Return _isReturnTypeStub
            End Get
        End Property

        Public Overrides ReadOnly Property IsLocalType() As Boolean
            Get
                Return _isLocalType
            End Get
        End Property

        Public Property Activator() As Activator
        Public Property CollectionAdd() As AddToCollection
        Public Property DictionaryAdd() As AddToDictionary

        Public Sub SetContentPropertyName(ByVal contentPropertyName As String)
            _contentPropertyName = contentPropertyName
        End Sub

        Public Sub SetIsArray()
            _isArray = True
        End Sub

        Public Sub SetIsMarkupExtension()
            _isMarkupExtension = True
        End Sub

        Public Sub SetIsBindable()
            _isBindable = True
        End Sub

        Public Sub SetIsReturnTypeStub()
            _isReturnTypeStub = True
        End Sub

        Public Sub SetIsLocalType()
            _isLocalType = True
        End Sub

        Public Sub SetItemTypeName(ByVal itemTypeName As String)
            _itemTypeName = itemTypeName
        End Sub

        Public Sub SetKeyTypeName(ByVal keyTypeName As String)
            _keyTypeName = keyTypeName
        End Sub

        Public Sub AddMemberName(ByVal shortName As String)
            If _memberNames Is Nothing Then
                _memberNames = New Global.System.Collections.Generic.Dictionary(Of String,String)()
            End If
            _memberNames.Add(shortName, FullName + "." +shortName)
        End Sub

        Public Sub AddEnumValue(ByVal name As String, ByVal value As Global.System.Object)
            If _enumValues Is Nothing Then
                _enumValues = New Global.System.Collections.Generic.Dictionary(Of String,Global.System.Object)()
            End If
            _enumValues.Add(name, value)
        End Sub
    End Class

    Friend Delegate Function Getter(ByVal instance As Global.System.Object) As Global.System.Object
    Friend Delegate Sub Setter(ByVal instance As Global.System.Object, ByVal value As Global.System.Object)

        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _    
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Class XamlMember
        Implements Global.Windows.UI.Xaml.Markup.IXamlMember
        Private _provider As Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlTypeInfoProvider
        Private _name As String
        Private _isAttachable As Boolean
        Private _isDependencyProperty As Boolean
        Private _isReadOnly As Boolean

        Private _typeName As String
        Private _targetTypeName As String

        Public Sub New(ByVal provider As Global.VB8_BMI_Phone.VB8_BMI_Phone_XamlTypeInfo.XamlTypeInfoProvider, ByVal name As String, ByVal typeName As String)
            _name = name
            _typeName = typeName
            _provider = provider
        End Sub

        Public ReadOnly Property Name() As String Implements Global.Windows.UI.Xaml.Markup.IXamlMember.Name
            Get
                Return _name
            End Get
        End Property

        Public ReadOnly Property Type() As Global.Windows.UI.Xaml.Markup.IXamlType Implements Global.Windows.UI.Xaml.Markup.IXamlMember.Type
            Get
                Return _provider.GetXamlTypeByName(_typeName)
            End Get
        End Property

        Public Sub SetTargetTypeName(targetTypeName as String)
            _targetTypeName = targetTypeName
        End Sub
        Public ReadOnly Property TargetType() As Global.Windows.UI.Xaml.Markup.IXamlType Implements Global.Windows.UI.Xaml.Markup.IXamlMember.TargetType
            Get
                Return _provider.GetXamlTypeByName(_targetTypeName)
            End Get
        End Property

        Public Sub SetIsAttachable()
            _isAttachable = True
        End Sub
        Public ReadOnly Property IsAttachable() As Boolean Implements Global.Windows.UI.Xaml.Markup.IXamlMember.IsAttachable
            Get
                Return _isAttachable
            End Get
        End Property

        Public Sub SetIsDependencyProperty()
            _isDependencyProperty = True
        End Sub

        Public ReadOnly Property IsDependencyProperty() As Boolean Implements Global.Windows.UI.Xaml.Markup.IXamlMember.IsDependencyProperty
            Get
                Return _isDependencyProperty
            End Get
        End Property

        Public Sub SetIsReadOnly()
            _isReadOnly = True
        End Sub

        Public ReadOnly Property IsReadOnly() As Boolean Implements Global.Windows.UI.Xaml.Markup.IXamlMember.IsReadOnly
            Get
                Return _isReadOnly
            End Get
        End Property

        Public Property Getter() As Getter
        Public Function GetValue(ByVal instance As Global.System.Object) As Global.System.Object Implements Global.Windows.UI.Xaml.Markup.IXamlMember.GetValue
            If Getter IsNot Nothing Then
                Return Getter.Invoke(instance)
            Else
                Throw New Global.System.InvalidOperationException("GetValue")
            End If
        End Function

        Public Property Setter() As Setter
        Public Sub SetValue(ByVal instance As Global.System.Object, ByVal value As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IXamlMember.SetValue
            If Setter IsNot Nothing Then
                Setter.Invoke(instance, value)
            Else
                Throw New Global.System.InvalidOperationException("SetValue")
            End If
        End Sub
    End Class
End Namespace




