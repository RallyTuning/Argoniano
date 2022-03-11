Imports System.IO
Imports System.Linq.Expressions
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions

Module Mdl_Funzioni

#Region " Threads "

    Private Delegate Sub InvokeThreadSafeMethodDelegate(ByVal C As Control, ByVal M As Expression(Of Action))
    Private Delegate Function InvokeThreadSafeFunctionDelegate(Of T)(ByVal C As Control, ByVal F As Expression(Of Func(Of T))) As T

    <Extension()>
    Friend Sub InvocaMetodoSicuro(ByVal C As Control, ByVal M As Expression(Of Action))
        If C.InvokeRequired Then
            Dim D = New InvokeThreadSafeMethodDelegate(AddressOf InvocaMetodoSicuro)
            C.Invoke(D, C, M)
        Else
            M.Compile().DynamicInvoke()
        End If
    End Sub

    <Extension()>
    Friend Function InvocaFunzioneSicuro(Of T)(ByVal C As Control, ByVal F As Expression(Of Func(Of T))) As T
        If C.InvokeRequired Then
            Dim D = New InvokeThreadSafeFunctionDelegate(Of T)(AddressOf InvocaFunzioneSicuro)
            Return DirectCast(C.Invoke(D, C, F), T)
        Else
            Return DirectCast(F.Compile().DynamicInvoke(), T)
        End If
    End Function

    <Extension()>
    Friend Sub DoubleBuffering(ByVal Controllo As Control, ByVal Abilita As Boolean)
        Dim DoubleBufferPropertyInfo = Controllo.[GetType]().GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        DoubleBufferPropertyInfo.SetValue(Controllo, Abilita, Nothing)
    End Sub

    <Extension()>
    Friend Function ToSize(ByVal Valore As Long, ByVal Optional Decimali As Integer = 0) As String
        Try
            Dim SizeSuffixes As String() = {"byte", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"}

            Dim Mag As Integer = CInt(Math.Floor(Math.Log(Valore, 1024)))
            Dim AdjustedSize = Math.Round(Valore / Math.Pow(1024, Mag), Decimali)
            Return String.Format("{0} {1}", AdjustedSize, SizeSuffixes(Mag))
        Catch ex As Exception
            Return "0 bytes"
        End Try
    End Function

#End Region


    Sub New()


    End Sub

    Friend Function PulisciFatture(PathFile As String) As List(Of String)
        Try
            Dim TmpLst As New List(Of String)

            Using FS As New FileStream(PathFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                Using SR As New StreamReader(FS, Encoding.Default)
                    Dim TheFile As New StringBuilder

                    TheFile.Append(SR.ReadToEnd)

                    Dim NewSB1, NewSB2, NewSB3, NewSB4 As New StringBuilder
                    NewSB1.Append(Regex.Replace(TheFile.ToString, "<\?xml version([\s\S]*?)\<\/.*?FatturaElettronica>", String.Empty))
                    NewSB2.Append(Regex.Replace(NewSB1.ToString, "<p:FatturaElettronica([\s\S]*?)\<\/p:FatturaElettronica>", String.Empty))
                    NewSB3.Append(Regex.Replace(NewSB2.ToString, "<FatturaElettronicaHeader>([\s\S]*?)\<\/q1:FatturaElettronica>", String.Empty))
                    NewSB4.Append(Regex.Replace(NewSB3.ToString, "<NS1:FatturaElettronica([\s\S]*?)\<\/NS1:FatturaElettronica>", String.Empty))

                    Dim TempSplit() As String = NewSB4.ToString.Split(Environment.NewLine)

                    For L As Integer = 0 To TempSplit.Count - 1
                        Dim LineaElab As String = TempSplit(L).Trim

                        If Not String.IsNullOrWhiteSpace(LineaElab) Then TmpLst.Add(LineaElab)
                    Next
                End Using
            End Using

            Return TmpLst
        Catch ex As Exception
            Return New List(Of String)
        End Try
    End Function

End Module
