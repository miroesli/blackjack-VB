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
        Me.BRestart = New System.Windows.Forms.Button()
        Me.LblCard1 = New System.Windows.Forms.Label()
        Me.BHit = New System.Windows.Forms.Button()
        Me.LblCard2 = New System.Windows.Forms.Label()
        Me.LblCard3 = New System.Windows.Forms.Label()
        Me.LblCard4 = New System.Windows.Forms.Label()
        Me.GBYourHand = New System.Windows.Forms.GroupBox()
        Me.LblYour = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.PBCard5 = New System.Windows.Forms.PictureBox()
        Me.PBCard4 = New System.Windows.Forms.PictureBox()
        Me.PBCard3 = New System.Windows.Forms.PictureBox()
        Me.PBCard2 = New System.Windows.Forms.PictureBox()
        Me.PBCard1 = New System.Windows.Forms.PictureBox()
        Me.LblCard5 = New System.Windows.Forms.Label()
        Me.BPlay = New System.Windows.Forms.Button()
        Me.GBDealerHand = New System.Windows.Forms.GroupBox()
        Me.LblDealer = New System.Windows.Forms.Label()
        Me.LblDealerTotal = New System.Windows.Forms.Label()
        Me.PBCard10 = New System.Windows.Forms.PictureBox()
        Me.PBCard9 = New System.Windows.Forms.PictureBox()
        Me.PBCard8 = New System.Windows.Forms.PictureBox()
        Me.PBCard7 = New System.Windows.Forms.PictureBox()
        Me.PBCard6 = New System.Windows.Forms.PictureBox()
        Me.LblCard6 = New System.Windows.Forms.Label()
        Me.LblCard10 = New System.Windows.Forms.Label()
        Me.LblCard7 = New System.Windows.Forms.Label()
        Me.LblCard9 = New System.Windows.Forms.Label()
        Me.LblCard8 = New System.Windows.Forms.Label()
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.BHold = New System.Windows.Forms.Button()
        Me.LblCash = New System.Windows.Forms.Label()
        Me.GBCash = New System.Windows.Forms.GroupBox()
        Me.Dollar = New System.Windows.Forms.Label()
        Me.GBBid = New System.Windows.Forms.GroupBox()
        Me.NudBet = New System.Windows.Forms.NumericUpDown()
        Me.LblBetBefore = New System.Windows.Forms.Label()
        Me.GBYourHand.SuspendLayout()
        CType(Me.PBCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDealerHand.SuspendLayout()
        CType(Me.PBCard10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCard9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCard8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCard7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCard6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBCash.SuspendLayout()
        Me.GBBid.SuspendLayout()
        CType(Me.NudBet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BRestart
        '
        Me.BRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRestart.Location = New System.Drawing.Point(12, 12)
        Me.BRestart.Name = "BRestart"
        Me.BRestart.Size = New System.Drawing.Size(108, 51)
        Me.BRestart.TabIndex = 0
        Me.BRestart.Text = "Restart"
        Me.BRestart.UseVisualStyleBackColor = True
        '
        'LblCard1
        '
        Me.LblCard1.AutoSize = True
        Me.LblCard1.Location = New System.Drawing.Point(6, 16)
        Me.LblCard1.Name = "LblCard1"
        Me.LblCard1.Size = New System.Drawing.Size(35, 13)
        Me.LblCard1.TabIndex = 1
        Me.LblCard1.Text = "Card1"
        Me.LblCard1.Visible = False
        '
        'BHit
        '
        Me.BHit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BHit.Location = New System.Drawing.Point(12, 12)
        Me.BHit.Name = "BHit"
        Me.BHit.Size = New System.Drawing.Size(108, 51)
        Me.BHit.TabIndex = 3
        Me.BHit.Text = "Hit me!"
        Me.BHit.UseVisualStyleBackColor = True
        Me.BHit.Visible = False
        '
        'LblCard2
        '
        Me.LblCard2.AutoSize = True
        Me.LblCard2.Location = New System.Drawing.Point(109, 16)
        Me.LblCard2.Name = "LblCard2"
        Me.LblCard2.Size = New System.Drawing.Size(35, 13)
        Me.LblCard2.TabIndex = 4
        Me.LblCard2.Text = "Card1"
        Me.LblCard2.Visible = False
        '
        'LblCard3
        '
        Me.LblCard3.AutoSize = True
        Me.LblCard3.Location = New System.Drawing.Point(210, 16)
        Me.LblCard3.Name = "LblCard3"
        Me.LblCard3.Size = New System.Drawing.Size(35, 13)
        Me.LblCard3.TabIndex = 5
        Me.LblCard3.Text = "Card1"
        Me.LblCard3.Visible = False
        '
        'LblCard4
        '
        Me.LblCard4.AutoSize = True
        Me.LblCard4.Location = New System.Drawing.Point(313, 16)
        Me.LblCard4.Name = "LblCard4"
        Me.LblCard4.Size = New System.Drawing.Size(35, 13)
        Me.LblCard4.TabIndex = 6
        Me.LblCard4.Text = "Card1"
        Me.LblCard4.Visible = False
        '
        'GBYourHand
        '
        Me.GBYourHand.BackColor = System.Drawing.Color.Transparent
        Me.GBYourHand.Controls.Add(Me.LblYour)
        Me.GBYourHand.Controls.Add(Me.LblTotal)
        Me.GBYourHand.Controls.Add(Me.PBCard5)
        Me.GBYourHand.Controls.Add(Me.PBCard4)
        Me.GBYourHand.Controls.Add(Me.PBCard3)
        Me.GBYourHand.Controls.Add(Me.PBCard2)
        Me.GBYourHand.Controls.Add(Me.PBCard1)
        Me.GBYourHand.Controls.Add(Me.LblCard1)
        Me.GBYourHand.Controls.Add(Me.LblCard5)
        Me.GBYourHand.Controls.Add(Me.LblCard2)
        Me.GBYourHand.Controls.Add(Me.LblCard4)
        Me.GBYourHand.Controls.Add(Me.LblCard3)
        Me.GBYourHand.Location = New System.Drawing.Point(16, 139)
        Me.GBYourHand.Name = "GBYourHand"
        Me.GBYourHand.Size = New System.Drawing.Size(500, 171)
        Me.GBYourHand.TabIndex = 8
        Me.GBYourHand.TabStop = False
        Me.GBYourHand.Text = "Your Hand"
        Me.GBYourHand.Visible = False
        '
        'LblYour
        '
        Me.LblYour.AutoSize = True
        Me.LblYour.Location = New System.Drawing.Point(6, 142)
        Me.LblYour.Name = "LblYour"
        Me.LblYour.Size = New System.Drawing.Size(59, 13)
        Me.LblYour.TabIndex = 13
        Me.LblYour.Text = "Your Total:"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(91, 142)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(13, 13)
        Me.LblTotal.TabIndex = 9
        Me.LblTotal.Text = "0"
        '
        'PBCard5
        '
        Me.PBCard5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PBCard5.Location = New System.Drawing.Point(419, 32)
        Me.PBCard5.Name = "PBCard5"
        Me.PBCard5.Size = New System.Drawing.Size(72, 96)
        Me.PBCard5.TabIndex = 12
        Me.PBCard5.TabStop = False
        '
        'PBCard4
        '
        Me.PBCard4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PBCard4.Location = New System.Drawing.Point(316, 32)
        Me.PBCard4.Name = "PBCard4"
        Me.PBCard4.Size = New System.Drawing.Size(72, 96)
        Me.PBCard4.TabIndex = 11
        Me.PBCard4.TabStop = False
        '
        'PBCard3
        '
        Me.PBCard3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PBCard3.Location = New System.Drawing.Point(213, 32)
        Me.PBCard3.Name = "PBCard3"
        Me.PBCard3.Size = New System.Drawing.Size(72, 96)
        Me.PBCard3.TabIndex = 10
        Me.PBCard3.TabStop = False
        '
        'PBCard2
        '
        Me.PBCard2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PBCard2.Location = New System.Drawing.Point(112, 32)
        Me.PBCard2.Name = "PBCard2"
        Me.PBCard2.Size = New System.Drawing.Size(72, 96)
        Me.PBCard2.TabIndex = 9
        Me.PBCard2.TabStop = False
        '
        'PBCard1
        '
        Me.PBCard1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PBCard1.Location = New System.Drawing.Point(6, 32)
        Me.PBCard1.Name = "PBCard1"
        Me.PBCard1.Size = New System.Drawing.Size(72, 96)
        Me.PBCard1.TabIndex = 8
        Me.PBCard1.TabStop = False
        '
        'LblCard5
        '
        Me.LblCard5.AutoSize = True
        Me.LblCard5.Location = New System.Drawing.Point(416, 16)
        Me.LblCard5.Name = "LblCard5"
        Me.LblCard5.Size = New System.Drawing.Size(35, 13)
        Me.LblCard5.TabIndex = 7
        Me.LblCard5.Text = "Card1"
        Me.LblCard5.Visible = False
        '
        'BPlay
        '
        Me.BPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPlay.Location = New System.Drawing.Point(12, 12)
        Me.BPlay.Name = "BPlay"
        Me.BPlay.Size = New System.Drawing.Size(108, 51)
        Me.BPlay.TabIndex = 10
        Me.BPlay.Text = "Play!"
        Me.BPlay.UseVisualStyleBackColor = True
        '
        'GBDealerHand
        '
        Me.GBDealerHand.BackColor = System.Drawing.Color.Transparent
        Me.GBDealerHand.Controls.Add(Me.LblDealer)
        Me.GBDealerHand.Controls.Add(Me.LblDealerTotal)
        Me.GBDealerHand.Controls.Add(Me.PBCard10)
        Me.GBDealerHand.Controls.Add(Me.PBCard9)
        Me.GBDealerHand.Controls.Add(Me.PBCard8)
        Me.GBDealerHand.Controls.Add(Me.PBCard7)
        Me.GBDealerHand.Controls.Add(Me.PBCard6)
        Me.GBDealerHand.Controls.Add(Me.LblCard6)
        Me.GBDealerHand.Controls.Add(Me.LblCard10)
        Me.GBDealerHand.Controls.Add(Me.LblCard7)
        Me.GBDealerHand.Controls.Add(Me.LblCard9)
        Me.GBDealerHand.Controls.Add(Me.LblCard8)
        Me.GBDealerHand.Location = New System.Drawing.Point(16, 316)
        Me.GBDealerHand.Name = "GBDealerHand"
        Me.GBDealerHand.Size = New System.Drawing.Size(500, 171)
        Me.GBDealerHand.TabIndex = 13
        Me.GBDealerHand.TabStop = False
        Me.GBDealerHand.Text = "Dealer's Hand"
        Me.GBDealerHand.Visible = False
        '
        'LblDealer
        '
        Me.LblDealer.AutoSize = True
        Me.LblDealer.Location = New System.Drawing.Point(6, 139)
        Me.LblDealer.Name = "LblDealer"
        Me.LblDealer.Size = New System.Drawing.Size(75, 13)
        Me.LblDealer.TabIndex = 16
        Me.LblDealer.Text = "Dealer's Total:"
        '
        'LblDealerTotal
        '
        Me.LblDealerTotal.AutoSize = True
        Me.LblDealerTotal.Location = New System.Drawing.Point(91, 139)
        Me.LblDealerTotal.Name = "LblDealerTotal"
        Me.LblDealerTotal.Size = New System.Drawing.Size(13, 13)
        Me.LblDealerTotal.TabIndex = 9
        Me.LblDealerTotal.Text = "0"
        '
        'PBCard10
        '
        Me.PBCard10.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PBCard10.Location = New System.Drawing.Point(419, 32)
        Me.PBCard10.Name = "PBCard10"
        Me.PBCard10.Size = New System.Drawing.Size(72, 96)
        Me.PBCard10.TabIndex = 12
        Me.PBCard10.TabStop = False
        '
        'PBCard9
        '
        Me.PBCard9.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PBCard9.Location = New System.Drawing.Point(316, 32)
        Me.PBCard9.Name = "PBCard9"
        Me.PBCard9.Size = New System.Drawing.Size(72, 96)
        Me.PBCard9.TabIndex = 11
        Me.PBCard9.TabStop = False
        '
        'PBCard8
        '
        Me.PBCard8.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PBCard8.Location = New System.Drawing.Point(213, 32)
        Me.PBCard8.Name = "PBCard8"
        Me.PBCard8.Size = New System.Drawing.Size(72, 96)
        Me.PBCard8.TabIndex = 10
        Me.PBCard8.TabStop = False
        '
        'PBCard7
        '
        Me.PBCard7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PBCard7.Location = New System.Drawing.Point(112, 32)
        Me.PBCard7.Name = "PBCard7"
        Me.PBCard7.Size = New System.Drawing.Size(72, 96)
        Me.PBCard7.TabIndex = 9
        Me.PBCard7.TabStop = False
        '
        'PBCard6
        '
        Me.PBCard6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PBCard6.Location = New System.Drawing.Point(6, 32)
        Me.PBCard6.Name = "PBCard6"
        Me.PBCard6.Size = New System.Drawing.Size(72, 96)
        Me.PBCard6.TabIndex = 8
        Me.PBCard6.TabStop = False
        '
        'LblCard6
        '
        Me.LblCard6.AutoSize = True
        Me.LblCard6.Location = New System.Drawing.Point(6, 16)
        Me.LblCard6.Name = "LblCard6"
        Me.LblCard6.Size = New System.Drawing.Size(35, 13)
        Me.LblCard6.TabIndex = 1
        Me.LblCard6.Text = "Card1"
        Me.LblCard6.Visible = False
        '
        'LblCard10
        '
        Me.LblCard10.AutoSize = True
        Me.LblCard10.Location = New System.Drawing.Point(416, 16)
        Me.LblCard10.Name = "LblCard10"
        Me.LblCard10.Size = New System.Drawing.Size(35, 13)
        Me.LblCard10.TabIndex = 7
        Me.LblCard10.Text = "Card1"
        Me.LblCard10.Visible = False
        '
        'LblCard7
        '
        Me.LblCard7.AutoSize = True
        Me.LblCard7.Location = New System.Drawing.Point(109, 16)
        Me.LblCard7.Name = "LblCard7"
        Me.LblCard7.Size = New System.Drawing.Size(35, 13)
        Me.LblCard7.TabIndex = 4
        Me.LblCard7.Text = "Card1"
        Me.LblCard7.Visible = False
        '
        'LblCard9
        '
        Me.LblCard9.AutoSize = True
        Me.LblCard9.Location = New System.Drawing.Point(313, 16)
        Me.LblCard9.Name = "LblCard9"
        Me.LblCard9.Size = New System.Drawing.Size(35, 13)
        Me.LblCard9.TabIndex = 6
        Me.LblCard9.Text = "Card1"
        Me.LblCard9.Visible = False
        '
        'LblCard8
        '
        Me.LblCard8.AutoSize = True
        Me.LblCard8.Location = New System.Drawing.Point(210, 16)
        Me.LblCard8.Name = "LblCard8"
        Me.LblCard8.Size = New System.Drawing.Size(35, 13)
        Me.LblCard8.TabIndex = 5
        Me.LblCard8.Text = "Card1"
        Me.LblCard8.Visible = False
        '
        'LblMsg
        '
        Me.LblMsg.AutoSize = True
        Me.LblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMsg.Location = New System.Drawing.Point(126, 25)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(43, 20)
        Me.LblMsg.TabIndex = 14
        Me.LblMsg.Text = "Msg:"
        Me.LblMsg.Visible = False
        '
        'BHold
        '
        Me.BHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BHold.Location = New System.Drawing.Point(16, 70)
        Me.BHold.Name = "BHold"
        Me.BHold.Size = New System.Drawing.Size(104, 34)
        Me.BHold.TabIndex = 15
        Me.BHold.Text = "Hold"
        Me.BHold.UseVisualStyleBackColor = True
        Me.BHold.Visible = False
        '
        'LblCash
        '
        Me.LblCash.AutoSize = True
        Me.LblCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCash.Location = New System.Drawing.Point(23, 17)
        Me.LblCash.Name = "LblCash"
        Me.LblCash.Size = New System.Drawing.Size(36, 20)
        Me.LblCash.TabIndex = 17
        Me.LblCash.Text = "100"
        '
        'GBCash
        '
        Me.GBCash.BackColor = System.Drawing.Color.Green
        Me.GBCash.Controls.Add(Me.Dollar)
        Me.GBCash.Controls.Add(Me.LblCash)
        Me.GBCash.Location = New System.Drawing.Point(408, 12)
        Me.GBCash.Name = "GBCash"
        Me.GBCash.Size = New System.Drawing.Size(114, 50)
        Me.GBCash.TabIndex = 18
        Me.GBCash.TabStop = False
        Me.GBCash.Text = "Ca$h"
        '
        'Dollar
        '
        Me.Dollar.AutoSize = True
        Me.Dollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dollar.Location = New System.Drawing.Point(6, 17)
        Me.Dollar.Name = "Dollar"
        Me.Dollar.Size = New System.Drawing.Size(18, 20)
        Me.Dollar.TabIndex = 18
        Me.Dollar.Text = "$"
        '
        'GBBid
        '
        Me.GBBid.Controls.Add(Me.NudBet)
        Me.GBBid.Location = New System.Drawing.Point(408, 68)
        Me.GBBid.Name = "GBBid"
        Me.GBBid.Size = New System.Drawing.Size(114, 45)
        Me.GBBid.TabIndex = 19
        Me.GBBid.TabStop = False
        Me.GBBid.Text = "Bet:"
        '
        'NudBet
        '
        Me.NudBet.Location = New System.Drawing.Point(6, 16)
        Me.NudBet.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudBet.Name = "NudBet"
        Me.NudBet.Size = New System.Drawing.Size(102, 20)
        Me.NudBet.TabIndex = 21
        Me.NudBet.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LblBetBefore
        '
        Me.LblBetBefore.AutoSize = True
        Me.LblBetBefore.Location = New System.Drawing.Point(12, 107)
        Me.LblBetBefore.Name = "LblBetBefore"
        Me.LblBetBefore.Size = New System.Drawing.Size(143, 13)
        Me.LblBetBefore.TabIndex = 20
        Me.LblBetBefore.Text = "Bet before Playing the game!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(535, 517)
        Me.Controls.Add(Me.LblBetBefore)
        Me.Controls.Add(Me.GBBid)
        Me.Controls.Add(Me.GBCash)
        Me.Controls.Add(Me.BHold)
        Me.Controls.Add(Me.LblMsg)
        Me.Controls.Add(Me.GBDealerHand)
        Me.Controls.Add(Me.BPlay)
        Me.Controls.Add(Me.GBYourHand)
        Me.Controls.Add(Me.BHit)
        Me.Controls.Add(Me.BRestart)
        Me.Name = "Form1"
        Me.Text = "Black Jack"
        Me.GBYourHand.ResumeLayout(False)
        Me.GBYourHand.PerformLayout()
        CType(Me.PBCard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDealerHand.ResumeLayout(False)
        Me.GBDealerHand.PerformLayout()
        CType(Me.PBCard10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCard9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCard8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCard7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCard6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBCash.ResumeLayout(False)
        Me.GBCash.PerformLayout()
        Me.GBBid.ResumeLayout(False)
        CType(Me.NudBet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BRestart As System.Windows.Forms.Button
    Friend WithEvents LblCard1 As System.Windows.Forms.Label
    Friend WithEvents BHit As System.Windows.Forms.Button
    Friend WithEvents LblCard2 As System.Windows.Forms.Label
    Friend WithEvents LblCard3 As System.Windows.Forms.Label
    Friend WithEvents LblCard4 As System.Windows.Forms.Label
    Friend WithEvents GBYourHand As System.Windows.Forms.GroupBox
    Friend WithEvents LblCard5 As System.Windows.Forms.Label
    Friend WithEvents PBCard5 As System.Windows.Forms.PictureBox
    Friend WithEvents PBCard4 As System.Windows.Forms.PictureBox
    Friend WithEvents PBCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents PBCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents PBCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents BPlay As System.Windows.Forms.Button
    Friend WithEvents GBDealerHand As System.Windows.Forms.GroupBox
    Friend WithEvents LblDealerTotal As System.Windows.Forms.Label
    Friend WithEvents PBCard10 As System.Windows.Forms.PictureBox
    Friend WithEvents PBCard9 As System.Windows.Forms.PictureBox
    Friend WithEvents PBCard8 As System.Windows.Forms.PictureBox
    Friend WithEvents PBCard7 As System.Windows.Forms.PictureBox
    Friend WithEvents PBCard6 As System.Windows.Forms.PictureBox
    Friend WithEvents LblCard6 As System.Windows.Forms.Label
    Friend WithEvents LblCard10 As System.Windows.Forms.Label
    Friend WithEvents LblCard7 As System.Windows.Forms.Label
    Friend WithEvents LblCard9 As System.Windows.Forms.Label
    Friend WithEvents LblCard8 As System.Windows.Forms.Label
    Friend WithEvents LblMsg As System.Windows.Forms.Label
    Friend WithEvents BHold As System.Windows.Forms.Button
    Friend WithEvents LblYour As System.Windows.Forms.Label
    Friend WithEvents LblDealer As System.Windows.Forms.Label
    Friend WithEvents LblCash As System.Windows.Forms.Label
    Friend WithEvents GBCash As System.Windows.Forms.GroupBox
    Friend WithEvents GBBid As System.Windows.Forms.GroupBox
    Friend WithEvents LblBetBefore As System.Windows.Forms.Label
    Friend WithEvents NudBet As System.Windows.Forms.NumericUpDown
    Friend WithEvents Dollar As System.Windows.Forms.Label

End Class
