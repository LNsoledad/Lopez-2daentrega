Imports System.Data.SqlClient

Public Class BackUp1

    Dim conexion As New SqlConnection("SERVER=MAURO; DATABASE=Prueba_Proyecto;Integrated Security=True")


    Private Sub btnBACKUP_Click(sender As Object, e As EventArgs) Handles btnBACKUP.Click
        If MsgBox("Desea realizar la copia de seguridad", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "COPIA") Then

            Dim nombre_backup As String = "ProyectoNuevo_" & Now.Day & "_" & Now.Month & "_" & Now.Year & "_" & Now.Hour & "_" & Now.Minute & "_" & Now.Second

            Dim conexion As SqlConnection = New SqlConnection(My.Settings.Prueba_Proyecto)

            Dim destino_backup As String = "A:\FACULTAD\Taller II_2018\copias de seguridad\"

            Dim cmd As New SqlCommand("BACKUP DATABASE Prueba_Proyecto TO DISK= '" & destino_backup & "" & nombre_backup & "' ", conexion)

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("el backUp se realizo correctamente", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
                MessageBox.Show("el backUp no se realizo correctamente", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            conexion.Close()
        End If

        'Dim nombre_copia As String
        'nombre_copia = (Date.Today.Day.ToString & "." & Date.Today.Month.ToString & "-" & Date.Today.Year.ToString & "-" & Date.Now.Hour.ToString & "-" & Date.Now.Minute.ToString & "-" & Date.Now.Second.ToString & "Copia_Seguridad.bak")

        ''Dim comando_consulta As String = "BACKUP DATABASE [Prueba_Proyecto] TO  DISK = N'A:\FACULTAD\Taller II_2018\copias de seguridad\Prueba_Proyecto.bak' WITH NOFORMAT, NOINIT,  NAME = N'Prueba_Proyecto-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
        'Dim comando_consulta As String = "BACKUP DATABASE [Prueba_Proyecto] TO  DISK = N'A:\FACULTAD\Taller II_2018\copias de seguridad\" & nombre_copia & "' WITH NOFORMAT, NOINIT,  NAME = N'Prueba_Proyecto-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"

        'Dim cmd As SqlCommand = New SqlCommand(comando_consulta, conexion)

        'Try
        '    If MsgBox("¿Desea realizar la copia de seguridad de la base de datos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CerrarAplicacion") Then
        '        conexion.Open()
        '        cmd.ExecuteNonQuery()
        '        MsgBox("La copia ha sido generada correctamente!", MsgBoxStyle.Information, "BACK UP")
        '        MsgBox("Si desea realizar otra copia de seguridad vuelva a elegir la opcion de realizar backUp,gracias", MsgBoxStyle.Information, "Sugerencia")
        '        Me.Close()
        '    End If
        'Catch ex As Exception
        '    MsgBox("Disculpe,si desea realizar otra copia de seguridad ,entonces cierre el formulario y vuelva a abrirlo", MsgBoxStyle.Information, "Sugerencia")
        'Finally
        '    conexion.Close()
        '    conexion.Dispose()

        'End Try
    End Sub


End Class