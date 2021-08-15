Public Class delivery
    Dim envio As Double
    Dim iva As Double
    Dim total As Double
    Dim cargo As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub delivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'asignando elementos en el combobox seleccionado
        cbdoc.Items.Add("Cedula")
        cbdoc.Items.Add("Pasaporte")
        cbpais.Items.Add("Venezuela")
        cbpais.Items.Add("Brasil")
        cbpais.Items.Add("Colombia")
        cbpais.Items.Add("USA")
    End Sub

    Private Sub cbpais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpais.SelectedIndexChanged
        'asignando ciudades dependiendo del pais seleccionado
        Select Case cbpais.Text
            Case "Venezuela"
                cbcity.Items.Clear()
                cbcity.Items.Add("Maracay")
                cbcity.Items.Add("Caracas")
                cbcity.Items.Add("Merida")
                cbcity.Items.Add("Valencia")
            Case "Brasil"
                cbcity.Items.Clear()
                cbcity.Items.Add("Sao Paulo")
                cbcity.Items.Add("Rio de Janeiro")
                cbcity.Items.Add("Curitiba")
                cbcity.Items.Add("Brasilia")
            Case "Colombia"
                cbcity.Items.Clear()
                cbcity.Items.Add("Cali")
                cbcity.Items.Add("Medellin")
                cbcity.Items.Add("Barranquilla")
                cbcity.Items.Add("Bogota")
            Case "USA"
                cbcity.Items.Clear()
                cbcity.Items.Add("New York")
                cbcity.Items.Add("Detroit")
                cbcity.Items.Add("Miami")
                cbcity.Items.Add("Las Vegas")
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            iva = 0.14
            envio = txtmt.Text
            'procedimiento
            If cbpais.Text = "Brasil" Then
                cargo = 0.2
            End If
            If cbpais.Text = "Colombia" Then
                cargo = 0.25
            End If
            If cbpais.Text = "Venezuela" Then
                cargo = 0.15
            End If
            If cbpais.Text = "USA" Then
                cargo = 0.5
            End If
            iva = iva * envio
            cargo = cargo * envio
            total = envio + iva + cargo
            'salida
            txtiva.Text = iva
            txtcg.Text = cargo
            txtotal.Text = total
        Catch ex As Exception
            MsgBox("Faltan datos", vbCritical)
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        For Each control As Windows.Forms.Control In Me.Controls
            If TypeOf control Is GroupBox Then
                For Each controlText As Windows.Forms.Control In Me.GroupBox1.Controls
                    If TypeOf controlText Is TextBox Then
                        CType(controlText, TextBox).Clear()
                    End If
                Next

                For Each controlText As Windows.Forms.Control In Me.GroupBox2.Controls
                    If TypeOf controlText Is TextBox Then
                        CType(controlText, TextBox).Clear()
                    End If
                Next

                For Each controlText As Windows.Forms.Control In Me.GroupBox3.Controls
                    If TypeOf controlText Is TextBox Then
                        CType(controlText, TextBox).Clear()
                    End If
                Next


            End If
        Next
        cbpais.Text = ""
        cbcity.Text = ""
        cbdoc.Text = ""
        txtreporte.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            txtreporte.Clear()
            txtreporte.AppendText("DETALLES DEL ENVIO" & vbNewLine)
            txtreporte.AppendText("**********************************************************" & vbNewLine)
            txtreporte.AppendText("                    Datos del remitente" & vbNewLine & vbNewLine)
            txtreporte.AppendText("Nombre: " & txtname.Text & vbNewLine & vbNewLine)
            txtreporte.AppendText("Apellido: " & txtsurname.Text & vbNewLine & vbNewLine)
            txtreporte.AppendText("Beneficiario: " & txtbneficiario.Text & vbNewLine & vbNewLine)
            txtreporte.AppendText("Monto: " & envio & " $" & vbNewLine & vbNewLine)
            txtreporte.AppendText("Cargo: " & cargo & " $" & vbNewLine & vbNewLine)
            txtreporte.AppendText("IVA: " & iva & " $" & vbNewLine & vbNewLine)
            txtreporte.AppendText("Total: " & total & " $" & vbNewLine & vbNewLine)
        Catch ex As Exception
            MsgBox("Faltan datos", vbCritical)
        End Try

    End Sub
End Class