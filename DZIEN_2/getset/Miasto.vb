Public Class Miasto
    Private nazwa As String
    Private woj As String
    Private stolica As Boolean
    Private liczbamieszk As Long

    Public Sub New(nazwa As String, woj As String, stolica As Boolean, liczbamieszk As Long)
        Me.nazwa = nazwa
        Me.woj = woj
        Me.stolica = stolica
        Me.liczbamieszk = liczbamieszk
    End Sub

    Public Sub setNazwa(ByVal naz As Double)
        nazwa = naz
    End Sub

    Public Sub setWoj(ByVal wj As Double)
        woj = wj
    End Sub

    Public Sub setStolica(ByVal stol As Double)
        stolica = stol
    End Sub

    Public Sub setLiczba(ByVal lb As Double)
        liczbamieszk = lb
    End Sub


    Public Function getNazwa()
        Return nazwa
    End Function

    Public Function getWoj()
        Return woj
    End Function

    Public Function getStolica()
        Return stolica
    End Function

    Public Function getLiczba()
        Return liczbamieszk
    End Function

End Class
