Public Class Form2
    Public selected As ChessBoardCell = Nothing
    Public defaultColor As ChessBoardCell.peaceColor = ChessBoardCell.peaceColor.NONE
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        queen._PeaceColor = defaultColor
        rook._PeaceColor = defaultColor
        horse._PeaceColor = defaultColor
        bishop._PeaceColor = defaultColor
        showBorders(False)
    End Sub
    Sub showBorders(show As Boolean)
        queenS.Visible = show
        rookS.Visible = show
        horseS.Visible = show
        bishopS.Visible = show
        Dim a As BorderStyle = IIf(show, BorderStyle.Fixed3D, BorderStyle.None)
        queen.BorderStyle = a
        rook.BorderStyle = a
        horse.BorderStyle = a
        bishop.BorderStyle = a
    End Sub
    Private Sub bishop_Click(sender As Object, e As EventArgs) Handles rook.Click, queen.Click, horse.Click, bishop.Click
        showBorders(False)
        selected = CType(sender, ChessBoardCell)
        Me.Controls(selected.Name & "S").Visible = True
        selected.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.DialogResult <> DialogResult.OK Then
            e.Cancel = True
            MsgBox("Please select promotion.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If selected IsNot Nothing Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MsgBox("Please select promotion")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    'Sub createBoard()
    '    Dim height As Integer = 50
    '    Dim base As Integer = 10
    '    Dim constructor As String = ""
    '    Dim frin As String = ""
    '    Dim prop As String = ""
    '    Dim aad As String = ""
    '    Dim counter As Integer = 10
    '    For i As Integer = 1 To 8
    '        For n As Integer = 1 To 8
    '            Dim nm As String = String.Concat("_", i, n)
    '            constructor = String.Concat(constructor, vbNewLine, "Me.", nm, " = New Chess_v2.ChessBoardCell()")
    '            frin = String.Concat(frin, vbNewLine, "Friend WithEvents ", nm, " As ChessBoardCell")
    '            Dim pnl As New Chess_v2.ChessBoardCell()
    '            pnl.Name = String.Concat("MyPanel", i, n)
    '            pnl.Size = New Size(height, height)
    '            If i = 1 And n = 1 Then
    '                pnl.Top = base
    '                pnl.Left = base
    '            Else
    '                pnl.Top = (i * height) + 8
    '                pnl.Left = (n * height) + 8
    '            End If
    '            aad = String.Concat(aad, vbNewLine, "Me.Controls.Add(Me.", nm, ")")
    '            prop = String.Concat(prop, vbNewLine, "  '
    '                                '", nm, "
    '                                '", vbNewLine, "Me.", nm, ".Location = New System.Drawing.Point(", pnl.Left, ", ", pnl.Top, ")
    '                                Me.", nm, ".Name = """, nm, """
    '                                Me.", nm, ".Size = New System.Drawing.Size(", height, ", ", height, ")
    '                                Me.", nm, ".TabIndex = ", counter)
    '            pnl.BorderStyle = BorderStyle.FixedSingle
    '            pnl._PeaceColor = ChessBoardCell.peaceColor.light
    '            pnl._PeaceType = ChessBoardCell.peaceType.horse
    '            Me.Controls.Add(pnl)
    '            counter += 1
    '        Next
    '    Next
    'End Sub
End Class