Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Newtonsoft.Json
Public Class Form1
    Private Sub btnCreatePDF_Click(sender As Object, e As EventArgs) Handles btnCreatePDF.Click
        Dim PDFcreate As Document = New Document()
        Dim Create As PdfWriter = PdfWriter.GetInstance(PDFcreate, New FileStream("DE ROBLES JR., BONIFACIO.pdf", FileMode.Create))

        PDFcreate.Open()
        PDFcreate.Add(New Paragraph(tbxFname.Text))
        PDFcreate.Add(New Paragraph(tbxAge.Text))
        PDFcreate.Close()
        MessageBox.Show("Resume Created!")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim btnExit As DialogResult

        btnExit = MessageBox.Show("Do you wish to close the Application?", "PDF Resume Creator", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If btnExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
