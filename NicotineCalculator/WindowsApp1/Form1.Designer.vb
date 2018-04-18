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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblLiquid = New System.Windows.Forms.Label()
        Me.txtLiquid = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.txtMgml = New System.Windows.Forms.TextBox()
        Me.txtCostML = New System.Windows.Forms.TextBox()
        Me.txtSizeOfBottle = New System.Windows.Forms.TextBox()
        Me.txtCostOfBottle = New System.Windows.Forms.TextBox()
        Me.lblMgml = New System.Windows.Forms.Label()
        Me.lblEfficiency = New System.Windows.Forms.Label()
        Me.lblCostMl = New System.Windows.Forms.Label()
        Me.lblSizeOfBottle = New System.Windows.Forms.Label()
        Me.LblCostOfBottle = New System.Windows.Forms.Label()
        Me.cbEfficiency = New System.Windows.Forms.ComboBox()
        Me.lblNicotineAnswer = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblNicotine = New System.Windows.Forms.Label()
        Me.lblCostAnswer = New System.Windows.Forms.Label()
        Me.lblCig = New System.Windows.Forms.Label()
        Me.lblCigAnswer = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCostCalculator = New System.Windows.Forms.Button()
        Me.lblCostPerMgNic = New System.Windows.Forms.Label()
        Me.lblCostPerMgNicAnswer = New System.Windows.Forms.Label()
        Me.btnCalcCostMl = New System.Windows.Forms.Button()
        Me.lblMl = New System.Windows.Forms.Label()
        Me.lblMgMlLabel = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblMlLabel = New System.Windows.Forms.Label()
        Me.lblDollarsCostOfBottle = New System.Windows.Forms.Label()
        Me.lblCostMlLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLiquid
        '
        Me.lblLiquid.AutoSize = True
        Me.lblLiquid.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiquid.Location = New System.Drawing.Point(21, 22)
        Me.lblLiquid.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblLiquid.Name = "lblLiquid"
        Me.lblLiquid.Size = New System.Drawing.Size(129, 20)
        Me.lblLiquid.TabIndex = 0
        Me.lblLiquid.Text = "Liquid Vaped"
        '
        'txtLiquid
        '
        Me.txtLiquid.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiquid.Location = New System.Drawing.Point(221, 16)
        Me.txtLiquid.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtLiquid.Name = "txtLiquid"
        Me.txtLiquid.Size = New System.Drawing.Size(109, 29)
        Me.txtLiquid.TabIndex = 1
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(221, 405)
        Me.btn1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(175, 56)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "&Calculate"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'txtMgml
        '
        Me.txtMgml.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMgml.Location = New System.Drawing.Point(221, 63)
        Me.txtMgml.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMgml.Name = "txtMgml"
        Me.txtMgml.Size = New System.Drawing.Size(109, 29)
        Me.txtMgml.TabIndex = 2
        '
        'txtCostML
        '
        Me.txtCostML.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostML.Location = New System.Drawing.Point(221, 158)
        Me.txtCostML.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCostML.Name = "txtCostML"
        Me.txtCostML.Size = New System.Drawing.Size(109, 29)
        Me.txtCostML.TabIndex = 4
        '
        'txtSizeOfBottle
        '
        Me.txtSizeOfBottle.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSizeOfBottle.Location = New System.Drawing.Point(221, 205)
        Me.txtSizeOfBottle.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtSizeOfBottle.Name = "txtSizeOfBottle"
        Me.txtSizeOfBottle.Size = New System.Drawing.Size(109, 29)
        Me.txtSizeOfBottle.TabIndex = 5
        Me.txtSizeOfBottle.Visible = False
        '
        'txtCostOfBottle
        '
        Me.txtCostOfBottle.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostOfBottle.Location = New System.Drawing.Point(221, 251)
        Me.txtCostOfBottle.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCostOfBottle.Name = "txtCostOfBottle"
        Me.txtCostOfBottle.Size = New System.Drawing.Size(109, 29)
        Me.txtCostOfBottle.TabIndex = 6
        Me.txtCostOfBottle.Visible = False
        '
        'lblMgml
        '
        Me.lblMgml.AutoSize = True
        Me.lblMgml.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMgml.Location = New System.Drawing.Point(21, 68)
        Me.lblMgml.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMgml.Name = "lblMgml"
        Me.lblMgml.Size = New System.Drawing.Size(59, 20)
        Me.lblMgml.TabIndex = 9
        Me.lblMgml.Text = "MG/ML"
        '
        'lblEfficiency
        '
        Me.lblEfficiency.AutoSize = True
        Me.lblEfficiency.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEfficiency.Location = New System.Drawing.Point(21, 115)
        Me.lblEfficiency.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEfficiency.Name = "lblEfficiency"
        Me.lblEfficiency.Size = New System.Drawing.Size(189, 20)
        Me.lblEfficiency.TabIndex = 10
        Me.lblEfficiency.Text = "Effeciency of Vape"
        '
        'lblCostMl
        '
        Me.lblCostMl.AutoSize = True
        Me.lblCostMl.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostMl.Location = New System.Drawing.Point(21, 165)
        Me.lblCostMl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCostMl.Name = "lblCostMl"
        Me.lblCostMl.Size = New System.Drawing.Size(79, 20)
        Me.lblCostMl.TabIndex = 11
        Me.lblCostMl.Text = "Cost/ML"
        '
        'lblSizeOfBottle
        '
        Me.lblSizeOfBottle.AutoSize = True
        Me.lblSizeOfBottle.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSizeOfBottle.Location = New System.Drawing.Point(21, 212)
        Me.lblSizeOfBottle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSizeOfBottle.Name = "lblSizeOfBottle"
        Me.lblSizeOfBottle.Size = New System.Drawing.Size(149, 20)
        Me.lblSizeOfBottle.TabIndex = 12
        Me.lblSizeOfBottle.Text = "Size Of Bottle"
        Me.lblSizeOfBottle.Visible = False
        '
        'LblCostOfBottle
        '
        Me.LblCostOfBottle.AutoSize = True
        Me.LblCostOfBottle.Font = New System.Drawing.Font("Source Code Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostOfBottle.Location = New System.Drawing.Point(23, 256)
        Me.LblCostOfBottle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblCostOfBottle.Name = "LblCostOfBottle"
        Me.LblCostOfBottle.Size = New System.Drawing.Size(149, 20)
        Me.LblCostOfBottle.TabIndex = 13
        Me.LblCostOfBottle.Text = "Cost Of Bottle"
        Me.LblCostOfBottle.Visible = False
        '
        'cbEfficiency
        '
        Me.cbEfficiency.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEfficiency.FormattingEnabled = True
        Me.cbEfficiency.Items.AddRange(New Object() {"10", "20", "30", "40", "50"})
        Me.cbEfficiency.Location = New System.Drawing.Point(221, 110)
        Me.cbEfficiency.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cbEfficiency.Name = "cbEfficiency"
        Me.cbEfficiency.Size = New System.Drawing.Size(109, 30)
        Me.cbEfficiency.TabIndex = 3
        '
        'lblNicotineAnswer
        '
        Me.lblNicotineAnswer.AutoSize = True
        Me.lblNicotineAnswer.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNicotineAnswer.Location = New System.Drawing.Point(745, 32)
        Me.lblNicotineAnswer.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNicotineAnswer.Name = "lblNicotineAnswer"
        Me.lblNicotineAnswer.Size = New System.Drawing.Size(0, 21)
        Me.lblNicotineAnswer.TabIndex = 16
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(582, 67)
        Me.lblCost.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(84, 21)
        Me.lblCost.TabIndex = 17
        Me.lblCost.Text = "Cost Today"
        '
        'lblNicotine
        '
        Me.lblNicotine.AutoSize = True
        Me.lblNicotine.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNicotine.Location = New System.Drawing.Point(582, 32)
        Me.lblNicotine.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNicotine.Name = "lblNicotine"
        Me.lblNicotine.Size = New System.Drawing.Size(69, 21)
        Me.lblNicotine.TabIndex = 18
        Me.lblNicotine.Text = "Nicotine:"
        '
        'lblCostAnswer
        '
        Me.lblCostAnswer.AutoSize = True
        Me.lblCostAnswer.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostAnswer.Location = New System.Drawing.Point(745, 67)
        Me.lblCostAnswer.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCostAnswer.Name = "lblCostAnswer"
        Me.lblCostAnswer.Size = New System.Drawing.Size(0, 21)
        Me.lblCostAnswer.TabIndex = 19
        '
        'lblCig
        '
        Me.lblCig.AutoSize = True
        Me.lblCig.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCig.Location = New System.Drawing.Point(582, 104)
        Me.lblCig.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCig.Name = "lblCig"
        Me.lblCig.Size = New System.Drawing.Size(107, 21)
        Me.lblCig.TabIndex = 20
        Me.lblCig.Text = "Cig equivalent"
        '
        'lblCigAnswer
        '
        Me.lblCigAnswer.AutoSize = True
        Me.lblCigAnswer.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCigAnswer.Location = New System.Drawing.Point(745, 104)
        Me.lblCigAnswer.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCigAnswer.Name = "lblCigAnswer"
        Me.lblCigAnswer.Size = New System.Drawing.Size(0, 21)
        Me.lblCigAnswer.TabIndex = 21
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(586, 430)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(175, 31)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "E&XIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCostCalculator
        '
        Me.btnCostCalculator.Location = New System.Drawing.Point(376, 158)
        Me.btnCostCalculator.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnCostCalculator.Name = "btnCostCalculator"
        Me.btnCostCalculator.Size = New System.Drawing.Size(119, 29)
        Me.btnCostCalculator.TabIndex = 23
        Me.btnCostCalculator.Text = "Cost/ML Calc"
        Me.btnCostCalculator.UseVisualStyleBackColor = True
        '
        'lblCostPerMgNic
        '
        Me.lblCostPerMgNic.AutoSize = True
        Me.lblCostPerMgNic.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerMgNic.Location = New System.Drawing.Point(582, 144)
        Me.lblCostPerMgNic.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCostPerMgNic.Name = "lblCostPerMgNic"
        Me.lblCostPerMgNic.Size = New System.Drawing.Size(135, 21)
        Me.lblCostPerMgNic.TabIndex = 25
        Me.lblCostPerMgNic.Text = "Cost Per MG of Nic"
        '
        'lblCostPerMgNicAnswer
        '
        Me.lblCostPerMgNicAnswer.AutoSize = True
        Me.lblCostPerMgNicAnswer.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerMgNicAnswer.Location = New System.Drawing.Point(745, 144)
        Me.lblCostPerMgNicAnswer.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCostPerMgNicAnswer.Name = "lblCostPerMgNicAnswer"
        Me.lblCostPerMgNicAnswer.Size = New System.Drawing.Size(0, 21)
        Me.lblCostPerMgNicAnswer.TabIndex = 26
        '
        'btnCalcCostMl
        '
        Me.btnCalcCostMl.Font = New System.Drawing.Font("DaunPenh", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcCostMl.Location = New System.Drawing.Point(221, 293)
        Me.btnCalcCostMl.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnCalcCostMl.Name = "btnCalcCostMl"
        Me.btnCalcCostMl.Size = New System.Drawing.Size(175, 62)
        Me.btnCalcCostMl.TabIndex = 27
        Me.btnCalcCostMl.Text = "Calculate Cost/ML"
        Me.btnCalcCostMl.UseVisualStyleBackColor = True
        Me.btnCalcCostMl.Visible = False
        '
        'lblMl
        '
        Me.lblMl.AutoSize = True
        Me.lblMl.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMl.Location = New System.Drawing.Point(331, 23)
        Me.lblMl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMl.Name = "lblMl"
        Me.lblMl.Size = New System.Drawing.Size(24, 22)
        Me.lblMl.TabIndex = 28
        Me.lblMl.Text = "ml"
        '
        'lblMgMlLabel
        '
        Me.lblMgMlLabel.AutoSize = True
        Me.lblMgMlLabel.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMgMlLabel.Location = New System.Drawing.Point(331, 73)
        Me.lblMgMlLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMgMlLabel.Name = "lblMgMlLabel"
        Me.lblMgMlLabel.Size = New System.Drawing.Size(45, 22)
        Me.lblMgMlLabel.TabIndex = 29
        Me.lblMgMlLabel.Text = "mg/ml"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(333, 120)
        Me.lblPercent.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(21, 22)
        Me.lblPercent.TabIndex = 30
        Me.lblPercent.Text = "%"
        '
        'lblMlLabel
        '
        Me.lblMlLabel.AutoSize = True
        Me.lblMlLabel.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMlLabel.Location = New System.Drawing.Point(333, 217)
        Me.lblMlLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMlLabel.Name = "lblMlLabel"
        Me.lblMlLabel.Size = New System.Drawing.Size(24, 22)
        Me.lblMlLabel.TabIndex = 31
        Me.lblMlLabel.Text = "ml"
        Me.lblMlLabel.Visible = False
        '
        'lblDollarsCostOfBottle
        '
        Me.lblDollarsCostOfBottle.AutoSize = True
        Me.lblDollarsCostOfBottle.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollarsCostOfBottle.Location = New System.Drawing.Point(333, 261)
        Me.lblDollarsCostOfBottle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDollarsCostOfBottle.Name = "lblDollarsCostOfBottle"
        Me.lblDollarsCostOfBottle.Size = New System.Drawing.Size(16, 22)
        Me.lblDollarsCostOfBottle.TabIndex = 32
        Me.lblDollarsCostOfBottle.Text = "$"
        Me.lblDollarsCostOfBottle.Visible = False
        '
        'lblCostMlLabel
        '
        Me.lblCostMlLabel.AutoSize = True
        Me.lblCostMlLabel.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostMlLabel.Location = New System.Drawing.Point(331, 170)
        Me.lblCostMlLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCostMlLabel.Name = "lblCostMlLabel"
        Me.lblCostMlLabel.Size = New System.Drawing.Size(35, 22)
        Me.lblCostMlLabel.TabIndex = 33
        Me.lblCostMlLabel.Text = "$/ml"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources._05_512
        Me.PictureBox1.Location = New System.Drawing.Point(27, 318)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 480)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCostMlLabel)
        Me.Controls.Add(Me.lblDollarsCostOfBottle)
        Me.Controls.Add(Me.lblMlLabel)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblMgMlLabel)
        Me.Controls.Add(Me.lblMl)
        Me.Controls.Add(Me.btnCalcCostMl)
        Me.Controls.Add(Me.lblCostPerMgNicAnswer)
        Me.Controls.Add(Me.lblCostPerMgNic)
        Me.Controls.Add(Me.btnCostCalculator)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCigAnswer)
        Me.Controls.Add(Me.lblCig)
        Me.Controls.Add(Me.lblCostAnswer)
        Me.Controls.Add(Me.lblNicotine)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblNicotineAnswer)
        Me.Controls.Add(Me.cbEfficiency)
        Me.Controls.Add(Me.LblCostOfBottle)
        Me.Controls.Add(Me.lblSizeOfBottle)
        Me.Controls.Add(Me.lblCostMl)
        Me.Controls.Add(Me.lblEfficiency)
        Me.Controls.Add(Me.lblMgml)
        Me.Controls.Add(Me.txtCostOfBottle)
        Me.Controls.Add(Me.txtSizeOfBottle)
        Me.Controls.Add(Me.txtCostML)
        Me.Controls.Add(Me.txtMgml)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtLiquid)
        Me.Controls.Add(Me.lblLiquid)
        Me.Font = New System.Drawing.Font("DaunPenh", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "Nicotine Intake Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLiquid As Label
    Friend WithEvents txtLiquid As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents txtMgml As TextBox
    Friend WithEvents txtCostML As TextBox
    Friend WithEvents txtSizeOfBottle As TextBox
    Friend WithEvents txtCostOfBottle As TextBox
    Friend WithEvents lblMgml As Label
    Friend WithEvents lblEfficiency As Label
    Friend WithEvents lblCostMl As Label
    Friend WithEvents lblSizeOfBottle As Label
    Friend WithEvents LblCostOfBottle As Label
    Friend WithEvents cbEfficiency As ComboBox
    Friend WithEvents lblNicotineAnswer As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblNicotine As Label
    Friend WithEvents lblCostAnswer As Label
    Friend WithEvents lblCig As Label
    Friend WithEvents lblCigAnswer As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCostCalculator As Button
    Friend WithEvents lblCostPerMgNic As Label
    Friend WithEvents lblCostPerMgNicAnswer As Label
    Friend WithEvents btnCalcCostMl As Button
    Friend WithEvents lblMl As Label
    Friend WithEvents lblMgMlLabel As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblMlLabel As Label
    Friend WithEvents lblDollarsCostOfBottle As Label
    Friend WithEvents lblCostMlLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
