<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signUpForm
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
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnCancelSignUp = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.cbPurpose = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(34, 207)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(75, 23)
        Me.btnSignUp.TabIndex = 0
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'btnCancelSignUp
        '
        Me.btnCancelSignUp.Location = New System.Drawing.Point(136, 207)
        Me.btnCancelSignUp.Name = "btnCancelSignUp"
        Me.btnCancelSignUp.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelSignUp.TabIndex = 1
        Me.btnCancelSignUp.Text = "Cancel"
        Me.btnCancelSignUp.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(15, 23)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(56, 22)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(15, 57)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 22)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDob.Location = New System.Drawing.Point(15, 126)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(49, 22)
        Me.lblDob.TabIndex = 4
        Me.lblDob.Text = "Birthday"
        '
        'lblPurpose
        '
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurpose.Location = New System.Drawing.Point(15, 159)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(88, 22)
        Me.lblPurpose.TabIndex = 5
        Me.lblPurpose.Text = "Purpose for App"
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPass.Location = New System.Drawing.Point(15, 91)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(49, 22)
        Me.lblConfirmPass.TabIndex = 6
        Me.lblConfirmPass.Text = "Confirm"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(111, 23)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 22)
        Me.txtUsername.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(111, 56)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtPassword.TabIndex = 8
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Location = New System.Drawing.Point(111, 90)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.Size = New System.Drawing.Size(100, 22)
        Me.txtConfirmPass.TabIndex = 9
        Me.txtConfirmPass.UseSystemPasswordChar = True
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Location = New System.Drawing.Point(111, 125)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(200, 22)
        Me.dtpBirthday.TabIndex = 10
        '
        'cbPurpose
        '
        Me.cbPurpose.FormattingEnabled = True
        Me.cbPurpose.Items.AddRange(New Object() {"Quit Smoking", "Quit Vaping", "Control Nic From Smoking", "Control Nic from Vaping", "Controlling Multiple Nic Sources", "Other (Please specify in this box)"})
        Me.cbPurpose.Location = New System.Drawing.Point(111, 158)
        Me.cbPurpose.Name = "cbPurpose"
        Me.cbPurpose.Size = New System.Drawing.Size(200, 23)
        Me.cbPurpose.TabIndex = 11
        '
        'signUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(4.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbPurpose)
        Me.Controls.Add(Me.dtpBirthday)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblConfirmPass)
        Me.Controls.Add(Me.lblPurpose)
        Me.Controls.Add(Me.lblDob)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnCancelSignUp)
        Me.Controls.Add(Me.btnSignUp)
        Me.Name = "signUpForm"
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnCancelSignUp As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblDob As Label
    Friend WithEvents lblPurpose As Label
    Friend WithEvents lblConfirmPass As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents cbPurpose As ComboBox
End Class
