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
        PDFcreate.Add(New Paragraph(tbxHomeAdd.Text))
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Openjsonfile As String = File.ReadAllText("info.json")
        Dim resultJson As MyInfo = JsonConvert.DeserializeObject(Of MyInfo)(Openjsonfile)
        'Dim outputpdfFile As Document = New Document()
        'PdfWriter.GetInstance(outputpdfFile, New FileStream("DE ROBLES JR., BONIFACIO.pdf", FileMode.Create))
        'outputpdfFile.Open()
        tbxFname.Text = resultJson.Fullname
        tbxHomeAdd.Text = resultJson.HomeAddress
        tbxCnum.Text = resultJson.ContactNumber
        tbxEmail.Text = resultJson.EmailAddress
        tbxGender.Text = resultJson.Gender
        tbxAge.Text = resultJson.Age
        tbxDOB.Text = resultJson.DateofBirth
        tbxCivStatus.Text = resultJson.CivilStatus
        tbxSkills.Text = resultJson.Skills
        tbxEducAttain.Text = resultJson.EducationalAttainment
        tbxWExp.Text = resultJson.WorkExperience
        tbxAppSig.Text = resultJson.ApplicantSignature
    End Sub
    Public Class MyInfo
        Public Property Fullname As String
        Public Property HomeAddress As String
        Public Property ContactNumber As String
        Public Property EmailAddress As String
        Public Property Gender As String
        Public Property Age As String
        Public Property DateofBirth As String
        Public Property CivilStatus As String
        Public Property Skills As String
        Public Property EducationalAttainment As String
        Public Property WorkExperience As String
        Public Property ApplicantSignature As String

    End Class
End Class

