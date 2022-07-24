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
        Me.lblAge = New System.Windows.Forms.Label()
        Me.tbxAge = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreatePDF
        '
        Me.btnCreatePDF.Location = New System.Drawing.Point(128, 150)
        Me.btnCreatePDF.Name = "btnCreatePDF"
        Me.btnCreatePDF.Size = New System.Drawing.Size(94, 29)
        Me.btnCreatePDF.TabIndex = 0
        Me.btnCreatePDF.Text = "Create"
        Me.btnCreatePDF.UseVisualStyleBackColor = True
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
        Me.tbxFname.Location = New System.Drawing.Point(128, 41)
        Me.tbxFname.Name = "tbxFname"
        Me.tbxFname.Size = New System.Drawing.Size(212, 27)
        Me.tbxFname.TabIndex = 2
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAge.Location = New System.Drawing.Point(12, 80)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(51, 28)
        Me.lblAge.TabIndex = 1
        Me.lblAge.Text = "Age:"
        '
        'tbxAge
        '
        Me.tbxAge.Location = New System.Drawing.Point(128, 84)
        Me.tbxAge.Name = "tbxAge"
        Me.tbxAge.Size = New System.Drawing.Size(212, 27)
        Me.tbxAge.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(246, 150)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 496)
        Me.Controls.Add(Me.tbxAge)
        Me.Controls.Add(Me.tbxFname)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCreatePDF)
        Me.Name = "Form1"
        Me.Text = "PDF Resume Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreatePDF As Button
    Friend WithEvents lblFname As Label
    Friend WithEvents tbxFname As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents tbxAge As TextBox
    Friend WithEvents btnExit As Button
End Class
