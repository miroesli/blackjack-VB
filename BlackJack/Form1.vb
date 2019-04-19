Public Class Form1
    Dim Randnum As Integer
    Dim Counter As Integer
    Dim CounterDealer As Integer
    Dim Cards(5) As Integer
    Dim DealerCards(5) As Integer
    Dim Keepgoing As Boolean
    Dim Bet As Integer
    Dim Suit As Integer

    Public Function Rand(ByVal Low As Long, ByVal High As Long) As Long
        Randomize()
        Rand = Int((High - Low + 1) * Rnd()) + Low
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Counter = 0
        CounterDealer = 0
    End Sub

    Private Sub BPlay_Click_1(sender As System.Object, e As System.EventArgs) Handles BPlay.Click
        Bet = NudBet.Value
        If CInt(LblCash.Text) <= 0 Then
            MsgBox("You're drunk and you've lost all your moneyz.. go home (voice inside your head)")
            Close()
        End If
        If NudBet.Value >= 1000 Then
            MsgBox("You maximum you can bet is $1000 sorry.")
        End If
        If NudBet.Value < 1 Then
            MsgBox("You must bet at least $1... Idiot.")
        End If
        If NudBet.Value > CInt(LblCash.Text) Then
            MsgBox("You don't have that much moneyz..")
        Else
            LblCash.Text = LblCash.Text - Bet
            If Not NudBet.Value = "0" Then
                BHit.Visible = True
                GBYourHand.Visible = True
                GBDealerHand.Visible = True
                DealerCards(0) = Rand(1, 13)
                If DealerCards(0) >= 11 Then
                    DealerCards(0) = 10
                End If
                LblCard6.Text = DealerCards(0)
                LblDealerTotal.Text = (DealerCards(0) + DealerCards(1) + DealerCards(2) + DealerCards(3) + DealerCards(4))
                LblCard6.Visible = True
                If LblCard6.Text = 0 Then
                    LblCard6.Visible = False
                End If
                CounterDealer += 1
                CardPics(PBCard6, LblCard6)
                BRestart.Visible = False
                BPlay.Visible = False
                LblBetBefore.Visible = False
                NudBet.Enabled = False
            End If
        End If
    End Sub

    Private Sub BRestart_Click(sender As System.Object, e As System.EventArgs) Handles BRestart.Click
        Counter = 0
        CounterDealer = 0
        Bet = NudBet.Value
        LblTotal.Text = 0
        Cards(0) = 0
        Cards(1) = 0
        Cards(2) = 0
        Cards(3) = 0
        Cards(4) = 0
        DealerCards(1) = 0
        DealerCards(2) = 0
        DealerCards(3) = 0
        DealerCards(4) = 0
        LblCard1.Visible = False
        LblCard2.Visible = False
        LblCard3.Visible = False
        LblCard4.Visible = False
        LblCard5.Visible = False
        LblCard7.Visible = False
        LblCard8.Visible = False
        LblCard9.Visible = False
        LblCard10.Visible = False
        If CInt(LblCash.Text) <= 0 Then
            MsgBox("You're drunk and you've lost all your moneyz.. go home (voice inside your head)")
            Close()
            Return
        End If
        If NudBet.Value >= 1000 Then
            MsgBox("You maximum you can bet is $1000 sorry.")
        End If
        If NudBet.Value > CInt(LblCash.Text) Then
            MsgBox("You don't have that much moneyz..")
            NudBet.Value = CInt(LblCash.Text)
        Else
            LblCash.Text = LblCash.Text - Bet
            If Not NudBet.Value = "0" Then
                BHit.Visible = True
                GBYourHand.Visible = True
                GBDealerHand.Visible = True
                DealerCards(0) = Rand(1, 13)
                If DealerCards(0) >= 11 Then
                    DealerCards(0) = 10
                End If
                LblCard6.Text = DealerCards(0)
                LblDealerTotal.Text = (DealerCards(0) + DealerCards(1) + DealerCards(2) + DealerCards(3) + DealerCards(4))
                LblCard6.Visible = True
                If LblCard6.Text = 0 Then
                    LblCard6.Visible = False
                End If
                CounterDealer += 1
                CardPics(PBCard6, LblCard6)
                BRestart.Visible = False
                BPlay.Visible = False
                LblBetBefore.Visible = False
                NudBet.Enabled = False
                BRestart.Visible = False
                LblMsg.Visible = False
                BHit.Visible = True
                PBCard1.BackgroundImage = Nothing
                PBCard2.BackgroundImage = Nothing
                PBCard3.BackgroundImage = Nothing
                PBCard4.BackgroundImage = Nothing
                PBCard5.BackgroundImage = Nothing
                PBCard7.BackgroundImage = Nothing
                PBCard8.BackgroundImage = Nothing
                PBCard9.BackgroundImage = Nothing
                PBCard10.BackgroundImage = Nothing
                NudBet.Enabled = False
            End If
        End If
    End Sub

    Public Sub CardPics(picturebox As PictureBox, Cardnum As Label)
        Suit = Rand(1, 4)
        If Suit = 1 Then
            If Cardnum.Text = 1 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.Ace_clubs_
            ElseIf Cardnum.Text = 2 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._2_clubs_
            ElseIf Cardnum.Text = 3 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._3_clubs_
            ElseIf Cardnum.Text = 4 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._4_clubs_
            ElseIf Cardnum.Text = 5 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._5_clubs_
            ElseIf Cardnum.Text = 6 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._6_clubs_
            ElseIf Cardnum.Text = 7 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._7_clubs_
            ElseIf Cardnum.Text = 8 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._8_clubs_
            ElseIf Cardnum.Text = 9 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._9_clubs_
            ElseIf Cardnum.Text = 10 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._10_clubs_
            ElseIf Cardnum.Text = 11 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.Jack_clubs_
            ElseIf Cardnum.Text = 12 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.Queen_clubs_
            ElseIf Cardnum.Text = 13 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.King_clubs_
            End If
        ElseIf Suit = 2 Then
            If Cardnum.Text = 1 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.Ace_spades_
            ElseIf Cardnum.Text = 2 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._2_spades_
            ElseIf Cardnum.Text = 3 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._3_spades_
            ElseIf Cardnum.Text = 4 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._4_spades_
            ElseIf Cardnum.Text = 5 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._5_spades_
            ElseIf Cardnum.Text = 6 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._6_spades_
            ElseIf Cardnum.Text = 7 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._7_spades_
            ElseIf Cardnum.Text = 8 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._8_spades_
            ElseIf Cardnum.Text = 9 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._9_spades_
            ElseIf Cardnum.Text = 10 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._10_spades_
            ElseIf Cardnum.Text = 11 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.Jack_spades_
            ElseIf Cardnum.Text = 12 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.Queen_spades_
            ElseIf Cardnum.Text = 13 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.King_spades_
            End If
        ElseIf Suit = 3 Then
            If Cardnum.Text = 1 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.Ace_hearts_
            ElseIf Cardnum.Text = 2 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._2_hearts_
            ElseIf Cardnum.Text = 3 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._3_hearts_
            ElseIf Cardnum.Text = 4 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._4_hearts_
            ElseIf Cardnum.Text = 5 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._5_hearts_
            ElseIf Cardnum.Text = 6 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._6_hearts_
            ElseIf Cardnum.Text = 7 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._7_hearts_
            ElseIf Cardnum.Text = 8 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._8_hearts_
            ElseIf Cardnum.Text = 9 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._9_hearts_
            ElseIf Cardnum.Text = 10 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._10_hearts_
            ElseIf Cardnum.Text = 11 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.Jack_hearts_
            ElseIf Cardnum.Text = 12 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.Queen_hearts_
            ElseIf Cardnum.Text = 13 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.King_hearts_
            End If
        ElseIf Suit = 4 Then
            If Cardnum.Text = 1 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.Ace_diamonds_
            ElseIf Cardnum.Text = 2 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._2_diamonds_
            ElseIf Cardnum.Text = 3 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._3_diamonds_
            ElseIf Cardnum.Text = 4 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._4_diamonds_
            ElseIf Cardnum.Text = 5 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._5_diamonds_
            ElseIf Cardnum.Text = 6 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._6_diamonds_
            ElseIf Cardnum.Text = 7 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._7_diamonds_
            ElseIf Cardnum.Text = 8 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._8_diamonds_
            ElseIf Cardnum.Text = 9 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._9_diamonds_
            ElseIf Cardnum.Text = 10 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources._10_diamonds_
            ElseIf Cardnum.Text = 11 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.Jack_diamonds_
            ElseIf Cardnum.Text = 12 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.Queen_diamonds_
            ElseIf Cardnum.Text = 13 Then
                picturebox.BackgroundImage = WindowsApplication1.My.Resources.King_diamonds_
            End If
        End If
    End Sub
    Private Sub BHit_Click(sender As System.Object, e As System.EventArgs) Handles BHit.Click
        BHold.Visible = True
        If Counter < Cards.Length - 1 Then
            Cards(Counter) = Rand(1, 13)
            If Cards(Counter) >= 11 Then
                Cards(Counter) = 10
            End If
            LblCard1.Text = Cards(0)
            LblCard2.Text = Cards(1)
            LblCard3.Text = Cards(2)
            LblCard4.Text = Cards(3)
            LblCard5.Text = Cards(4)
            LblTotal.Text = (Cards(0) + Cards(1) + Cards(2) + Cards(3) + Cards(4))
            If Counter = 0 Then
                CardPics(PBCard1, LblCard1)
            ElseIf Counter = 1 Then
                CardPics(PBCard2, LblCard2)
            ElseIf Counter = 2 Then
                CardPics(PBCard3, LblCard3)
            ElseIf Counter = 3 Then
                CardPics(PBCard4, LblCard4)
            ElseIf Counter = 4 Then
                CardPics(PBCard5, LblCard5)
            End If
            If Counter = 0 Then
                LblCard1.Visible = True
            ElseIf Counter = 1 Then
                LblCard2.Visible = True
            ElseIf Counter = 2 Then
                LblCard3.Visible = True
            ElseIf Counter = 3 Then
                LblCard4.Visible = True
            ElseIf Counter = 4 Then
                LblCard5.Visible = True
            End If
            Counter += 1 'Shortened from -Counter = Counter + 1-'
            If Counter = 5 And CInt(LblTotal.Text) < 21 Then
                LblTotal.Text = 21
            End If
            If CInt(LblTotal.Text) >= 22 Then
                LblMsg.Visible = True
                LblMsg.Text = ("You lose.")
                BRestart.Visible = True
                BHit.Visible = False
                BHold.Visible = False
                NudBet.Enabled = True
                NudBet.Maximum = CInt(LblCash.Text)
                If CInt(LblCash.Text) <= 0 Then
                    MsgBox("You're drunk and you've lost all your moneyz.. go home (voice inside your head)")
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub BHold_Click(sender As System.Object, e As System.EventArgs) Handles BHold.Click
        GBDealerHand.Visible = True
        CounterDealer = 0
        Keepgoing = True
        While Keepgoing = True
            If CounterDealer < DealerCards.Length - 2 Then
                DealerCards(CounterDealer) = Rand(1, 13)
                If DealerCards(CounterDealer) >= 11 Then
                    DealerCards(CounterDealer) = 10
                End If
                LblCard7.Text = DealerCards(1)
                LblCard8.Text = DealerCards(2)
                LblCard9.Text = DealerCards(3)
                LblCard10.Text = DealerCards(4)
                LblDealerTotal.Text = (DealerCards(0) + DealerCards(1) + DealerCards(2) + DealerCards(3) + DealerCards(4))
                LblCard7.Visible = True
                LblCard8.Visible = True
                LblCard9.Visible = True
                LblCard10.Visible = True
                If LblCard7.Text = 0 Then
                    LblCard7.Visible = False
                End If
                If LblCard8.Text = 0 Then
                    LblCard8.Visible = False
                End If
                If LblCard9.Text = 0 Then
                    LblCard9.Visible = False
                End If
                If LblCard10.Text = 0 Then
                    LblCard10.Visible = False
                End If
                CounterDealer += 1 'Shortened from -Counter = Counter + 1-'
                If CounterDealer = 5 And CInt(LblDealerTotal.Text) < 21 Then
                    LblDealerTotal.Text = 21
                End If
                CardPics(PBCard7, LblCard7)
                CardPics(PBCard8, LblCard8)
                CardPics(PBCard9, LblCard9)
                CardPics(PBCard10, LblCard10)
                If CInt(LblDealerTotal.Text) > 16 Then
                    Keepgoing = False
                    BHold.Visible = False
                    If CInt(LblTotal.Text) > CInt(LblDealerTotal.Text) Then
                        LblMsg.Visible = True
                        LblMsg.Text = "You Win!"
                        BRestart.Visible = True
                        BHit.Visible = False
                        NudBet.Enabled = True
                        LblCash.Text = CInt(LblCash.Text) + NudBet.Value * 2
                        NudBet.Maximum = CInt(LblCash.Text)
                    ElseIf CInt(LblTotal.Text) = 21 And CInt(LblTotal.Text) > CInt(LblDealerTotal.Text) Then
                        LblMsg.Visible = True
                        LblMsg.Text = "Blackjack!"
                        BRestart.Visible = True
                        BHit.Visible = False
                        NudBet.Enabled = True
                        LblCash.Text = CInt(LblCash.Text) + NudBet.Value * 2
                        NudBet.Maximum = CInt(LblCash.Text)
                    ElseIf CInt(LblTotal.Text) = 21 And CInt(LblTotal.Text) = CInt(LblDealerTotal.Text) Then
                        LblMsg.Visible = True
                        LblMsg.Text = "Unlucky... the dealer got 21 too."
                        BRestart.Visible = True
                        BHit.Visible = False
                        NudBet.Enabled = True
                        NudBet.Maximum = CInt(LblCash.Text)
                    ElseIf CInt(LblTotal.Text) < CInt(LblDealerTotal.Text) And CInt(LblDealerTotal.Text) < 22 Then
                        LblMsg.Visible = True
                        LblMsg.Text = "You lose..."
                        BRestart.Visible = True
                        BHit.Visible = False
                        NudBet.Enabled = True
                        NudBet.Maximum = CInt(LblCash.Text)
                        If CInt(LblCash.Text) <= 0 Then
                            MsgBox("You're drunk and you've lost all your moneyz.. go home (voice inside your head)")
                            Close()
                        End If
                    ElseIf CInt(LblTotal.Text) = CInt(LblDealerTotal.Text) Then
                        LblMsg.Visible = True
                        LblMsg.Text = "At least you kept your money."
                        BRestart.Visible = True
                        BHit.Visible = False
                        NudBet.Enabled = True
                        LblCash.Text = CInt(LblCash.Text) + NudBet.Value
                        NudBet.Maximum = CInt(LblCash.Text)
                    ElseIf CInt(LblTotal.Text) < CInt(LblDealerTotal.Text) And CInt(LblDealerTotal.Text) > 21 Then
                        LblMsg.Visible = True
                        LblMsg.Text = "You Win!"
                        BRestart.Visible = True
                        BHit.Visible = False
                        NudBet.Enabled = True
                        LblCash.Text = CInt(LblCash.Text) + NudBet.Value * 2
                        NudBet.Maximum = CInt(LblCash.Text)
                    ElseIf CInt(LblTotal.Text) = 21 And CInt(LblDealerTotal.Text) < CInt(LblTotal.Text) Then
                        LblMsg.Visible = True
                        LblMsg.Text = "You Win!"
                        BRestart.Visible = True
                        BHit.Visible = False
                        NudBet.Enabled = True
                        NudBet.Maximum = CInt(LblCash.Text)
                        LblCash.Text = CInt(LblCash.Text) + NudBet.Value * 2
                    End If
                End If
            End If
        End While
    End Sub

    Private Sub NudBet_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NudBet.ValueChanged
    End Sub

    Private Sub GBYourHand_Enter(sender As System.Object, e As System.EventArgs) Handles GBYourHand.Enter

    End Sub
End Class
