Imports System.IO


Public Class FLeerArchivoTXT

    Private Sub BTPulsar_Click(sender As Object, e As EventArgs) Handles BTPulsar.Click

        ' utiliza el que quieras prefiero el listbox

        'listbox()

        textbox()

    End Sub

    Public Sub textbox()


        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)

            Dim Contenido As String = ""
            Dim intermedio As String = ""

            Try

                While sr.Peek() <> -1

                    Contenido = sr.ReadLine()

                    intermedio = intermedio + Contenido + Chr(13)

                End While

                TXTArchivotexto.Text = intermedio

            Catch ex As Exception

                MessageBox.Show(ex.ToString())

            End Try

            sr.Close()

        End If

    End Sub

    Public Sub listbox()

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)

            Dim Contenido As String = ""

            Try

                While sr.Peek() <> -1

                    Contenido = sr.ReadLine()

                    LArchivotexto.Items.Add(Contenido)

                End While

            Catch ex As Exception

                MessageBox.Show(ex.ToString())

            End Try

            sr.Close()

        End If

    End Sub

End Class
