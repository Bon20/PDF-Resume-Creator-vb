<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCreatePDF = New System.Windows.Forms.Button()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.tbxFname = New System.Windows.Forms.TextBox()
        Me.lblHomeAdd = New System.Windows.Forms.Label()
        Me.tbxHomeAdd = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCnum = New System.Windows.Forms.Label()
        Me.tbxCnum = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.tbxEmail = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.tbxGender = New System.Windows.Forms.TextBox()
        Me.tbxAge = New System.Windows.Forms.TextBox()
        Me.lblSkills = New System.Windows.Forms.Label()
        Me.tbxSkills = New System.Windows.Forms.TextBox()
        Me.lblWExp = New System.Windows.Forms.Label()
        Me.tbxWExp = New System.Windows.Forms.TextBox()
        Me.lblEducAttain = New System.Windows.Forms.Label()
        Me.tbxEducAttain = New System.Windows.Forms.TextBox()
        Me.lblPInfo = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.tbxDOB = New System.Windows.Forms.TextBox()
        Me.lblCivStatus = New System.Windows.Forms.Label()
        Me.tbxCivStatus = New System.Windows.Forms.TextBox()
        Me.lblAppSig = New System.Windows.Forms.Label()
        Me.tbxAppSig = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCreatePDF
        '
        Me.btnCreatePDF.BackColor = System.Drawing.Color.Lime
        Me.btnCreatePDF.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCreatePDF.Location = New System.Drawing.Point(712, 574)
        Me.btnCreatePDF.Name = "btnCreatePDF"
        Me.btnCreatePDF.Size = New System.Drawing.Size(124, 52)
        Me.btnCreatePDF.TabIndex = 0
        Me.btnCreatePDF.Text = "Create"
        Me.btnCreatePDF.UseVisualStyleBackColor = False
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFname.Location = New System.Drawing.Point(12, 37)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(104, 28)
        Me.lblFname.TabIndex = 1
        Me.lblFname.Text = "Full Name:"
        '
        'tbxFname
        '
        Me.tbxFname.Location = New System.Drawing.Point(171, 37)
        Me.tbxFname.Name = "tbxFname"
        Me.tbxFname.ReadOnly = True
        Me.tbxFname.Size = New System.Drawing.Size(212, 27)
        Me.tbxFname.TabIndex = 2
        '
        'lblHomeAdd
        '
        Me.lblHomeAdd.AutoSize = True
        Me.lblHomeAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHomeAdd.Location = New System.Drawing.Point(12, 70)
        Me.lblHomeAdd.Name = "lblHomeAdd"
        Me.lblHomeAdd.Size = New System.Drawing.Size(144, 28)
        Me.lblHomeAdd.TabIndex = 1
        Me.lblHomeAdd.Text = "Home Address:"
        '
        'tbxHomeAdd
        '
        Me.tbxHomeAdd.Location = New System.Drawing.Point(171, 70)
        Me.tbxHomeAdd.Name = "tbxHomeAdd"
        Me.tbxHomeAdd.ReadOnly = True
        Me.tbxHomeAdd.Size = New System.Drawing.Size(212, 27)
        Me.tbxHomeAdd.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(860, 574)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 52)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblCnum
        '
        Me.lblCnum.AutoSize = True
        Me.lblCnum.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCnum.Location = New System.Drawing.Point(12, 103)
        Me.lblCnum.Name = "lblCnum"
        Me.lblCnum.Size = New System.Drawing.Size(161, 28)
        Me.lblCnum.TabIndex = 1
        Me.lblCnum.Text = "Contact Number:"
        '
        'tbxCnum
        '
        Me.tbxCnum.Location = New System.Drawing.Point(171, 103)
        Me.tbxCnum.Name = "tbxCnum"
        Me.tbxCnum.ReadOnly = True
        Me.tbxCnum.Size = New System.Drawing.Size(212, 27)
        Me.tbxCnum.TabIndex = 2
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEmail.Location = New System.Drawing.Point(12, 137)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(138, 28)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email Address:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGender.Location = New System.Drawing.Point(11, 236)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(80, 28)
        Me.lblGender.TabIndex = 1
        Me.lblGender.Text = "Gender:"
        '
        'tbxEmail
        '
        Me.tbxEmail.Location = New System.Drawing.Point(171, 137)
        Me.tbxEmail.Name = "tbxEmail"
        Me.tbxEmail.ReadOnly = True
        Me.tbxEmail.Size = New System.Drawing.Size(212, 27)
        Me.tbxEmail.TabIndex = 2
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAge.Location = New System.Drawing.Point(11, 269)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(51, 28)
        Me.lblAge.TabIndex = 1
        Me.lblAge.Text = "Age:"
        '
        'tbxGender
        '
        Me.tbxGender.Location = New System.Drawing.Point(170, 236)
        Me.tbxGender.Name = "tbxGender"
        Me.tbxGender.ReadOnly = True
        Me.tbxGender.Size = New System.Drawing.Size(212, 27)
        Me.tbxGender.TabIndex = 2
        '
        'tbxAge
        '
        Me.tbxAge.Location = New System.Drawing.Point(170, 269)
        Me.tbxAge.Name = "tbxAge"
        Me.tbxAge.ReadOnly = True
        Me.tbxAge.Size = New System.Drawing.Size(212, 27)
        Me.tbxAge.TabIndex = 2
        '
        'lblSkills
        '
        Me.lblSkills.AutoSize = True
        Me.lblSkills.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSkills.Location = New System.Drawing.Point(12, 380)
        Me.lblSkills.Name = "lblSkills"
        Me.lblSkills.Size = New System.Drawing.Size(60, 28)
        Me.lblSkills.TabIndex = 1
        Me.lblSkills.Text = "Skills:"
        Me.lblSkills.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbxSkills
        '
        Me.tbxSkills.Location = New System.Drawing.Point(170, 384)
        Me.tbxSkills.Multiline = True
        Me.tbxSkills.Name = "tbxSkills"
        Me.tbxSkills.ReadOnly = True
        Me.tbxSkills.Size = New System.Drawing.Size(213, 138)
        Me.tbxSkills.TabIndex = 2
        '
        'lblWExp
        '
        Me.lblWExp.AutoSize = True
        Me.lblWExp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblWExp.Location = New System.Drawing.Point(545, 185)
        Me.lblWExp.Name = "lblWExp"
        Me.lblWExp.Size = New System.Drawing.Size(161, 28)
        Me.lblWExp.TabIndex = 1
        Me.lblWExp.Text = "Work Experience:"
        Me.lblWExp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbxWExp
        '
        Me.tbxWExp.Location = New System.Drawing.Point(729, 189)
        Me.tbxWExp.Multiline = True
        Me.tbxWExp.Name = "tbxWExp"
        Me.tbxWExp.ReadOnly = True
        Me.tbxWExp.Size = New System.Drawing.Size(255, 138)
        Me.tbxWExp.TabIndex = 2
        '
        'lblEducAttain
        '
        Me.lblEducAttain.AutoSize = True
        Me.lblEducAttain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEducAttain.Location = New System.Drawing.Point(485, 37)
        Me.lblEducAttain.Name = "lblEducAttain"
        Me.lblEducAttain.Size = New System.Drawing.Size(221, 28)
        Me.lblEducAttain.TabIndex = 1
        Me.lblEducAttain.Text = "Educational Attainment:"
        Me.lblEducAttain.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbxEducAttain
        '
        Me.tbxEducAttain.Location = New System.Drawing.Point(729, 41)
        Me.tbxEducAttain.Multiline = True
        Me.tbxEducAttain.Name = "tbxEducAttain"
        Me.tbxEducAttain.ReadOnly = True
        Me.tbxEducAttain.Size = New System.Drawing.Size(255, 138)
        Me.tbxEducAttain.TabIndex = 2
        '
        'lblPInfo
        '
        Me.lblPInfo.AutoSize = True
        Me.lblPInfo.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPInfo.Location = New System.Drawing.Point(75, 187)
        Me.lblPInfo.Name = "lblPInfo"
        Me.lblPInfo.Size = New System.Drawing.Size(247, 31)
        Me.lblPInfo.TabIndex = 5
        Me.lblPInfo.Text = "Personal Information:"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDOB.Location = New System.Drawing.Point(11, 302)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(126, 28)
        Me.lblDOB.TabIndex = 1
        Me.lblDOB.Text = "Date of Birth:"
        '
        'tbxDOB
        '
        Me.tbxDOB.Location = New System.Drawing.Point(170, 302)
        Me.tbxDOB.Name = "tbxDOB"
        Me.tbxDOB.ReadOnly = True
        Me.tbxDOB.Size = New System.Drawing.Size(212, 27)
        Me.tbxDOB.TabIndex = 2
        '
        'lblCivStatus
        '
        Me.lblCivStatus.AutoSize = True
        Me.lblCivStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCivStatus.Location = New System.Drawing.Point(11, 335)
        Me.lblCivStatus.Name = "lblCivStatus"
        Me.lblCivStatus.Size = New System.Drawing.Size(111, 28)
        Me.lblCivStatus.TabIndex = 1
        Me.lblCivStatus.Text = "Civil Status:"
        '
        'tbxCivStatus
        '
        Me.tbxCivStatus.Location = New System.Drawing.Point(170, 335)
        Me.tbxCivStatus.Name = "tbxCivStatus"
        Me.tbxCivStatus.ReadOnly = True
        Me.tbxCivStatus.Size = New System.Drawing.Size(212, 27)
        Me.tbxCivStatus.TabIndex = 2
        '
        'lblAppSig
        '
        Me.lblAppSig.AutoSize = True
        Me.lblAppSig.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAppSig.Location = New System.Drawing.Point(517, 369)
        Me.lblAppSig.Name = "lblAppSig"
        Me.lblAppSig.Size = New System.Drawing.Size(189, 28)
        Me.lblAppSig.TabIndex = 1
        Me.lblAppSig.Text = "Applicant Signature:"
        '
        'tbxAppSig
        '
        Me.tbxAppSig.Location = New System.Drawing.Point(729, 370)
        Me.tbxAppSig.Name = "tbxAppSig"
        Me.tbxAppSig.ReadOnly = True
        Me.tbxAppSig.Size = New System.Drawing.Size(255, 27)
        Me.tbxAppSig.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(1024, 650)
        Me.Controls.Add(Me.lblPInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tbxEducAttain)
        Me.Controls.Add(Me.tbxWExp)
        Me.Controls.Add(Me.tbxSkills)
        Me.Controls.Add(Me.lblEducAttain)
        Me.Controls.Add(Me.tbxAge)
        Me.Controls.Add(Me.lblWExp)
        Me.Controls.Add(Me.tbxCivStatus)
        Me.Controls.Add(Me.tbxDOB)
        Me.Controls.Add(Me.tbxAppSig)
        Me.Controls.Add(Me.tbxGender)
        Me.Controls.Add(Me.lblSkills)
        Me.Controls.Add(Me.tbxCnum)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.tbxHomeAdd)
        Me.Controls.Add(Me.lblCivStatus)
        Me.Controls.Add(Me.tbxEmail)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblAppSig)
        Me.Controls.Add(Me.lblCnum)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.tbxFname)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblHomeAdd)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.btnCreatePDF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDF Resume Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreatePDF As Button
    Friend WithEvents lblFname As Label
    Friend WithEvents tbxFname As TextBox
    Friend WithEvents lblHomeAdd As Label
    Friend WithEvents tbxHomeAdd As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCnum As Label
    Friend WithEvents tbxCnum As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents tbxEmail As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents tbxGender As TextBox
    Friend WithEvents tbxAge As TextBox
    Friend WithEvents lblSkills As Label
    Friend WithEvents tbxSkills As TextBox
    Friend WithEvents lblWExp As Label
    Friend WithEvents tbxWExp As TextBox
    Friend WithEvents lblEducAttain As Label
    Friend WithEvents tbxEducAttain As TextBox
    Friend WithEvents lblPInfo As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents tbxDOB As TextBox
    Friend WithEvents lblCivStatus As Label
    Friend WithEvents tbxCivStatus As TextBox
    Friend WithEvents lblAppSig As Label
    Friend WithEvents tbxAppSig As TextBox
End Class
