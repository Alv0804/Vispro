Option Strict On

Public Module ModuleValidasi
    Public Function KodeBukuValid(kode As String) As Boolean
        ' Periksa panjang kode (harus 6 karakter: BK + 4 digit)
        If kode.Length <> 6 Then
            Return False
        End If

        ' Periksa apakah diawali dengan "BK"
        If Not kode.StartsWith("BK") Then
            Return False
        End If

        ' Ekstrak 4 karakter terakhir dan periksa apakah semuanya digit
        Dim digitPart As String = kode.Substring(2)
        Return SemuaDigit(digitPart)
    End Function

    Private Function SemuaDigit(teks As String) As Boolean
        For Each karakter As Char In teks
            If Not Char.IsDigit(karakter) Then
                Return False
            End If
        Next
        Return True
    End Function

End Module
