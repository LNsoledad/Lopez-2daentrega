Module Funciones

    'Encripta una cadena
    Public Function Encriptar(ByVal p_cadenaAencriptar As String) As String
        Dim result As String = String.Empty
        Dim encryted As Byte() = System.Text.Encoding.Unicode.GetBytes(p_cadenaAencriptar)
        result = Convert.ToBase64String(encryted)
        Return result
    End Function


    ' Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
    Public Function DesEncriptar(ByVal p_cadenaAdesencriptar As String) As String
        Dim result As String = String.Empty
        Dim decryted As Byte() = Convert.FromBase64String(p_cadenaAdesencriptar)
        result = System.Text.Encoding.Unicode.GetString(decryted)
        Return result
    End Function

End Module
