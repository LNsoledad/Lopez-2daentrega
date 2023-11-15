Imports System.Text.RegularExpressions

Module Validacion


    'PARA VALIDAR INGRESO DE NUMEROS EN TEXT BOX
    Public Sub validarSoloNumeros(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        '// e captura el caracter que el usuario esta tecleando
        '// si el caracter presionado es numero
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            ''//Habilitamos la escritura
        ElseIf Char.IsControl(e.KeyChar) Then '//SIRVE PARA HABILITAR LA TECLA BORRAR EN CASO QUE SE DESEE CORREGIR
            e.Handled = False
        Else
            e.Handled = True

        End If
        If e.Handled = True Then
            MsgBox("Ingrese solo números", MsgBoxStyle.Critical, "ERROR")
        End If

    End Sub

    'PARA VALIDAR SOLO LETRAS
    Public Sub validarSoloLetras(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        ElseIf Char.IsControl(e.KeyChar) Then 'SIRVE PARA HABILITAR LA TECLA BORRAR EN CASO QUE SE DESEE CORREGIR
            e.Handled = False
        Else
            e.Handled = False

        End If
        If e.Handled = True Then
            MsgBox("INGRESE SOLO LETRAS", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    'PARA VALIDAR INGRESO DE NUMEROS Y LETRAS DIRECCION
    Public Sub validarNumerosYLetras1(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'Permite apretar la tecla para borrar
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then 'permite apretar la tecla espaciadora
            e.Handled = False
        Else
            e.Handled = True
            'MsgBox("INGRESE solo numero y letras", MsgBoxStyle.Critical, "ERROR")
        End If

    End Sub



    'PARA VALIDAR INGRESO DE NUMEROS Y LETRAS CONTRASEÑA
    Public Sub validarNumerosYLetras(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'Permite apretar la tecla para borrar
            e.Handled = False
            'ElseIf Char.IsSeparator(e.KeyChar) Then
            'e.Handled = False
        Else
            e.Handled = True
            MsgBox("INGRESE solo numero y letras", MsgBoxStyle.Critical, "ERROR")
        End If

    End Sub

    'PARA QUE CONVIERTA LA PRIMERA LETRA DE UN STRING EN MAYUSCULA
    Public Function PrimeraLetraEnMayuscula(ByVal p_string As String) As String
        Return StrConv(p_string, VbStrConv.ProperCase)
    End Function

    'PARA VALIDAR DECIMALES
    Public Sub validarSoloDecimales(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal paramTxt As TextBox)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf InStr(paramTxt.Text, ",") Then
            e.KeyChar = ""
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            If e.Handled = True Then
                MsgBox("INGRESE solo decimal", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Public Function ValidarCampoDecimal(CajaDeTexto As TextBox) As Boolean

        Try
            Dim d As Decimal = Convert.ToDecimal(CajaDeTexto.Text)
            Return True
        Catch ex As Exception

            'CajaDeTexto.Clear()
            CajaDeTexto.Focus()
            'CajaDeTexto.Text = "0"
            'CajaDeTexto.Select(0, CajaDeTexto.Text.Length)

            Return False
        End Try
    End Function

    '-----------------------------------------------------------------------------------------------------------------------

    Public Sub cambiarColor(ByVal e As System.EventArgs, ByVal tabla As DataGridView)
        tabla.RowsDefaultCellStyle.BackColor = Color.GreenYellow
        tabla.AlternatingRowsDefaultCellStyle.BackColor = Color.White

    End Sub


    'validar correo electronico
    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)

    End Function

    '//La siguiente funcion usa una funcion predefinida que toma un argumento.
    '//devuelve true si pudo convertir el paramero en numero entero
    'Se utiliza en facturacion
    Public Function ValidarCampoEntero(CajaDeTexto As TextBox) As Boolean
        Try
            Dim d As Integer = Convert.ToInt32(CajaDeTexto.Text)
            Return True
        Catch ex As Exception

            CajaDeTexto.Text = "0"
            CajaDeTexto.Select(0, CajaDeTexto.Text.Length)
            Return False
        End Try
    End Function



    '---------------------------------AVISOS:VENTANAS-----------------------------------
    Public Sub AccionErronea(ByVal p_mensaje As String)

        'Instancio un tipo de botos que se llama YesNo
        Dim btnOK As MessageBoxButtons = MessageBoxButtons.OK

        'Instancio valores por defecto para el titulo
        Dim titulo As String = "ATENCION, OPERACION INCORRECTA!"

        MessageBox.Show(p_mensaje, titulo, btnOK, MessageBoxIcon.Error)

    End Sub 'Fin de accionErronea


    Public Function EstaUdSeguro(p_mensaje As String) As Boolean

        '//Instancio un tipo de botos que se llama YesNo
        Dim btnSiNo As MessageBoxButtons = MessageBoxButtons.YesNo

        '//Instancio valores por defecto para el titulo
        Dim titulo As String = "Atencion Por favor!"

        ''//Instancio una variable que capta o guarda el resultado de la eleccion del usuario por sí o por no
        Dim resultado As DialogResult

        resultado = MessageBox.Show(p_mensaje, titulo, btnSiNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If (resultado = System.Windows.Forms.DialogResult.Yes) Then

            Return True

        Else

            Return False

        End If

    End Function  ''//Fin de estaUdSeguro()
    '------------------------------------------------------------------------------------------------------------

    '--------------------------VALIDAR USUARIO------------------------------------
    Dim objUsuario As Eusuarios = New Eusuarios
    Public Function validarUsuario(ByVal p_user As String) As Boolean

        Return objUsuario.existeUsuario(p_user)
    End Function

    '--------------------------VALIDAR CONTRASEÑA-------------------------
    Public Function validarClave(ByVal p_user As String, ByVal p_clave As String) As Boolean
        If objUsuario.existeUsuario(p_user) Then
            Return objUsuario.coincideClave(objUsuario.dbuscarUsuario(p_user), p_clave)
        Else
            Return False
        End If
    End Function




#Region "Otras validaciones"


    Public Function ValidarClave1(ByVal valor As TextBox) As Boolean
        ' Si su longitud es menor de 8 caracteres, no es válida.
        If (valor.Text.Length < 8) Then
            MessageBox.Show("La Clave debe tener más de 8 Caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            valor.Focus()
        End If


        Dim existeNumeros, existeLetraMayuscula, existeLetras As Boolean

        ' Ya solo queda verificar si al menos hay
        ' un número y una letra en mayúscula.
        '
        For Each c As Char In valor.Text

            If (Char.IsDigit(c)) Then
                existeNumeros = True
                Continue For
            End If

            If (Char.IsLower(c)) Then
                existeLetras = True
                Continue For
            End If

            If (Char.IsUpper(c)) Then
                existeLetraMayuscula = True
                Continue For
            End If

        Next

        If ((existeNumeros) And (existeLetras) And (existeLetraMayuscula)) Then
            Return True
        Else
            MessageBox.Show("La clave debe estar compuesta de letras minusculas, mayusculas y numeros(Uno o mas de ellos)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            valor.Focus()
        End If
    End Function


#End Region


End Module
