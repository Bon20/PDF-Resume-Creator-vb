Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Imports Newtonsoft.Json
Public Class Form1
    Dim Openjsonfile As String = File.ReadAllText("info.json")
    Dim resultJson As MyInfo = JsonConvert.DeserializeObject(Of MyInfo)(Openjsonfile)
    Private Sub btnCreatePDF_Click(sender As Object, e As EventArgs) Handles btnCreatePDF.Click
        Dim outputpdfFile As Document = New Document()
        PdfWriter.GetInstance(outputpdfFile, New FileStream("DE ROBLES JR., BONIFACIO.pdf", FileMode.Create))
        outputpdfFile.Open()


        Dim Fname As Paragraph = New Paragraph(resultJson.Fullname)
        Fname.Font.Size = 20
        Fname.Alignment = Element.ALIGN_CENTER
        outputpdfFile.Add(Fname)

        Dim HomeAdd As Paragraph = New Paragraph(resultJson.HomeAddress)
        HomeAdd.Font.Size = 12
        HomeAdd.Alignment = Element.ALIGN_CENTER
        outputpdfFile.Add(HomeAdd)

        Dim Cnum As Paragraph = New Paragraph(resultJson.ContactNumber)
        Cnum.Font.Size = 12
        Cnum.Alignment = Element.ALIGN_CENTER
        outputpdfFile.Add(Cnum)

        Dim Email As Paragraph = New Paragraph(resultJson.EmailAddress & vbLf & vbLf)
        Email.Font.Size = 12
        Email.Alignment = Element.ALIGN_CENTER
        outputpdfFile.Add(Email)

        Dim PersonInfo As Paragraph = New Paragraph("Personal Information")
        PersonInfo.Font.Size = 18
        outputpdfFile.Add(PersonInfo)

        Dim Gender As Paragraph = New Paragraph(vbLf & resultJson.Gender)
        Gender.Font.Size = 12
        outputpdfFile.Add(Gender)

        Dim Age As Paragraph = New Paragraph(resultJson.Age)
        Age.Font.Size = 12
        outputpdfFile.Add(Age)

        Dim DOB As Paragraph = New Paragraph(resultJson.DateofBirth)
        DOB.Font.Size = 12
        outputpdfFile.Add(DOB)

        Dim CivStatus As Paragraph = New Paragraph(resultJson.CivilStatus & vbLf & vbLf)
        CivStatus.Font.Size = 12
        outputpdfFile.Add(CivStatus)

        Dim Myskills As Paragraph = New Paragraph("Skills" & vbLf & vbLf)
        Myskills.Font.Size = 18
        outputpdfFile.Add(Myskills)

        Dim Skills As Paragraph = New Paragraph(resultJson.Skills & vbLf & vbLf)
        Skills.Font.Size = 12
        outputpdfFile.Add(Skills)

        Dim MyEducAttain As Paragraph = New Paragraph("Educational Attainment" & vbLf & vbLf)
        MyEducAttain.Font.Size = 18
        outputpdfFile.Add(MyEducAttain)

        Dim EducAttain As Paragraph = New Paragraph(resultJson.EducationalAttainment & vbLf & vbLf)
        EducAttain.Font.Size = 12
        outputpdfFile.Add(EducAttain)

        Dim MyWExp As Paragraph = New Paragraph("Work Experience" & vbLf & vbLf)
        MyWExp.Font.Size = 18
        outputpdfFile.Add(MyWExp)

        Dim WExp As Paragraph = New Paragraph(resultJson.WorkExperience)
        WExp.Font.Size = 12
        outputpdfFile.Add(WExp)


        outputpdfFile.Close()

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

