Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FormRealizarBackUp


    Dim miconexion As SqlConnection
    'evento del boton examinar
    Private Sub btnexaminar_click(sender As System.Object, e As System.EventArgs) Handles btnEXAMINAR.Click
        'abre dialogo para buscar ubicacion para guardar la copia
        FolderBrowserDialog1.ShowDialog()
        'carga el textbox con el nombre de la ruta seleccionada
        tbxRUTA.Text = FolderBrowserDialog1.SelectedPath & "\"
    End Sub
    'evento al presionar boton backup
    Private Sub btnbackup_click(sender As System.Object, e As System.EventArgs) Handles btnBACKUP.Click
        ''nombre de ruta de conexion
        'Dim c As String = "data source=MAURO; initial catalog=Prueba_Proyecto; integrated security=true"
        ''nombre de la base de datos
        'Dim bd As String = "Prueba_Proyecto"

        Dim concatenando As String = Me.tbxRUTA.Text + Me.tbxNOMBRE.Text + ".bak"

        If Me.tbxRUTA.Text = "" Or Me.tbxNOMBRE.Text = "" Then
            MsgBox("Por favor, debe completar los campos", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        Else
            If MsgBox("¿Desea realizar la copia de seguridad de la base de datos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "COPIA") Then

                Dim nombre_backup As String = tbxNOMBRE.Text & "_" & Now.Day & "_" & Now.Month & "_" & Now.Year & "_" & Now.Hour & "_" & Now.Minute & "_" & Now.Second

                Dim conexion As SqlConnection = New SqlConnection(My.Settings.Prueba_Proyecto)

                Dim destino_backup As String = tbxRUTA.Text

                Dim cmd As New SqlCommand("BACKUP DATABASE Prueba_Proyecto TO DISK= '" & destino_backup & "" & nombre_backup & "' ", conexion)

                Try
                    conexion.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("El backUp se realizo correctamente", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MessageBox.Show("El backUp no se realizo correctamente", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                conexion.Close()
                tbxRUTA.Clear()
                tbxNOMBRE.Clear()
            End If

        End If

    End Sub

    Private Sub frmbackup_load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tip()
        tbxRUTA.ReadOnly = True
        'direccion del servidor
        tbxSERVIDOR.Text = "DL INFORMATICA"
        tbxSERVIDOR.ReadOnly = True
        'npmbre de la base de datos
        tbxBASE.Text = "Prueba_Proyecto"
        tbxBASE.ReadOnly = True
    End Sub

    Sub tip()
        ToolTip1.SetToolTip(tbxBASE, "El nombre de la Base de Datos del cual se realiza la copia.")
        ToolTip1.SetToolTip(tbxRUTA, "Unidad de Disco en la cual se guaradará la copia.")
        ToolTip1.SetToolTip(tbxSERVIDOR, "Nombre del Servidor")
        ToolTip1.SetToolTip(tbxNOMBRE, "Debe escribir el nombre que tendrá el archivo que se va a generar.")
    End Sub


    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            tbxSERVIDOR.Clear()
            tbxBASE.Clear()
            tbxRUTA.Clear()
            tbxNOMBRE.Clear()
            Me.Close()

        End If
    End Sub


End Class