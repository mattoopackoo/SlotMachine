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
        Me.btnTry = New System.Windows.Forms.Button()
        Me.lblSlotOne = New System.Windows.Forms.Label()
        Me.lblSlotTwo = New System.Windows.Forms.Label()
        Me.lblSlotThree = New System.Windows.Forms.Label()
        Me.picConfetti = New System.Windows.Forms.PictureBox()
        Me.picSlotMachine = New System.Windows.Forms.PictureBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblBalanceAmount = New System.Windows.Forms.Label()
        Me.btnTryAgain = New System.Windows.Forms.Button()
        CType(Me.picConfetti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlotMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTry
        '
        Me.btnTry.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTry.Location = New System.Drawing.Point(253, 337)
        Me.btnTry.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTry.Name = "btnTry"
        Me.btnTry.Size = New System.Drawing.Size(126, 50)
        Me.btnTry.TabIndex = 12
        Me.btnTry.Text = "Try!"
        Me.btnTry.UseVisualStyleBackColor = True
        '
        'lblSlotOne
        '
        Me.lblSlotOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlotOne.ForeColor = System.Drawing.Color.Black
        Me.lblSlotOne.Location = New System.Drawing.Point(154, 181)
        Me.lblSlotOne.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSlotOne.Name = "lblSlotOne"
        Me.lblSlotOne.Size = New System.Drawing.Size(67, 60)
        Me.lblSlotOne.TabIndex = 13
        Me.lblSlotOne.Text = "0"
        '
        'lblSlotTwo
        '
        Me.lblSlotTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlotTwo.Location = New System.Drawing.Point(256, 181)
        Me.lblSlotTwo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSlotTwo.Name = "lblSlotTwo"
        Me.lblSlotTwo.Size = New System.Drawing.Size(77, 60)
        Me.lblSlotTwo.TabIndex = 14
        Me.lblSlotTwo.Text = "0"
        '
        'lblSlotThree
        '
        Me.lblSlotThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlotThree.Location = New System.Drawing.Point(370, 181)
        Me.lblSlotThree.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSlotThree.Name = "lblSlotThree"
        Me.lblSlotThree.Size = New System.Drawing.Size(67, 60)
        Me.lblSlotThree.TabIndex = 15
        Me.lblSlotThree.Text = "0"
        '
        'picConfetti
        '
        Me.picConfetti.Image = Global.SlotMachine.My.Resources.Resources.giphy
        Me.picConfetti.Location = New System.Drawing.Point(82, -15)
        Me.picConfetti.Margin = New System.Windows.Forms.Padding(2)
        Me.picConfetti.Name = "picConfetti"
        Me.picConfetti.Size = New System.Drawing.Size(591, 404)
        Me.picConfetti.TabIndex = 16
        Me.picConfetti.TabStop = False
        Me.picConfetti.Visible = False
        '
        'picSlotMachine
        '
        Me.picSlotMachine.Image = Global.SlotMachine.My.Resources.Resources.mask
        Me.picSlotMachine.Location = New System.Drawing.Point(98, 34)
        Me.picSlotMachine.Margin = New System.Windows.Forms.Padding(2)
        Me.picSlotMachine.Name = "picSlotMachine"
        Me.picSlotMachine.Size = New System.Drawing.Size(506, 353)
        Me.picSlotMachine.TabIndex = 11
        Me.picSlotMachine.TabStop = False
        '
        'btnRestart
        '
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(263, 391)
        Me.btnRestart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(133, 51)
        Me.btnRestart.TabIndex = 17
        Me.btnRestart.Text = "Restart?"
        Me.btnRestart.UseVisualStyleBackColor = True
        Me.btnRestart.Visible = False
        '
        'lblBalance
        '
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(448, 389)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(126, 23)
        Me.lblBalance.TabIndex = 18
        Me.lblBalance.Text = "Balance: 0"
        '
        'lblBalanceAmount
        '
        Me.lblBalanceAmount.AutoSize = True
        Me.lblBalanceAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceAmount.Location = New System.Drawing.Point(541, 391)
        Me.lblBalanceAmount.Name = "lblBalanceAmount"
        Me.lblBalanceAmount.Size = New System.Drawing.Size(36, 25)
        Me.lblBalanceAmount.TabIndex = 19
        Me.lblBalanceAmount.Text = "50"
        '
        'btnTryAgain
        '
        Me.btnTryAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTryAgain.Location = New System.Drawing.Point(73, 391)
        Me.btnTryAgain.Name = "btnTryAgain"
        Me.btnTryAgain.Size = New System.Drawing.Size(170, 51)
        Me.btnTryAgain.TabIndex = 20
        Me.btnTryAgain.Text = "Try Again"
        Me.btnTryAgain.UseVisualStyleBackColor = True
        Me.btnTryAgain.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(856, 439)
        Me.Controls.Add(Me.picConfetti)
        Me.Controls.Add(Me.btnTryAgain)
        Me.Controls.Add(Me.lblBalanceAmount)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblSlotThree)
        Me.Controls.Add(Me.lblSlotTwo)
        Me.Controls.Add(Me.lblSlotOne)
        Me.Controls.Add(Me.btnTry)
        Me.Controls.Add(Me.picSlotMachine)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picConfetti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlotMachine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picSlotMachine As PictureBox
    Friend WithEvents btnTry As Button
    Friend WithEvents lblSlotOne As Label
    Friend WithEvents lblSlotTwo As Label
    Friend WithEvents lblSlotThree As Label
    Friend WithEvents picConfetti As PictureBox
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblBalanceAmount As Label
    Friend WithEvents btnTryAgain As Button
End Class
