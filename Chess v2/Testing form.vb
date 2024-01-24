Public Class Testing_form
    Dim previousSelectedCell As ChessBoardCell = Nothing
    Public passedPawn As ChessBoardCell = Nothing

    Public lightKing As ChessBoardCell = Nothing
    Public lightRookRight As ChessBoardCell = Nothing
    Public lightRookLeft As ChessBoardCell = Nothing

    Public darkKing As ChessBoardCell = Nothing
    Public darkRookRight As ChessBoardCell = Nothing
    Public darkRookLeft As ChessBoardCell = Nothing

    Sub setBoard()
        lightKing = _85
        lightRookRight = _88
        lightRookLeft = _81
        darkKing = _15
        darkRookRight = _18
        darkRookLeft = _11
        previousSelectedCell = Nothing
        passedPawn = Nothing
    End Sub
    Private Sub Testing_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setBoard()
    End Sub
    Class PreviusVAlue
        Public name As String
        Public peaceType As ChessBoardCell.peaceType
        Public peaceColor As ChessBoardCell.peaceColor
        Sub New(name As String, peaceType As ChessBoardCell.peaceType, peaceColor As ChessBoardCell.peaceColor)
            Me.name = name
            Me.peaceType = peaceType
            Me.peaceColor = peaceColor
        End Sub
    End Class
    Private Sub _11_aaaa_CellClick(currentSelected As ChessBoardCell) Handles _88.aaaa_CellClick, _87.aaaa_CellClick, _86.aaaa_CellClick, _85.aaaa_CellClick, _84.aaaa_CellClick, _83.aaaa_CellClick, _82.aaaa_CellClick, _81.aaaa_CellClick, _78.aaaa_CellClick, _77.aaaa_CellClick, _76.aaaa_CellClick, _75.aaaa_CellClick, _74.aaaa_CellClick, _73.aaaa_CellClick, _72.aaaa_CellClick, _71.aaaa_CellClick, _68.aaaa_CellClick, _67.aaaa_CellClick, _66.aaaa_CellClick, _65.aaaa_CellClick, _64.aaaa_CellClick, _63.aaaa_CellClick, _62.aaaa_CellClick, _61.aaaa_CellClick, _58.aaaa_CellClick, _57.aaaa_CellClick, _56.aaaa_CellClick, _55.aaaa_CellClick, _54.aaaa_CellClick, _53.aaaa_CellClick, _52.aaaa_CellClick, _51.aaaa_CellClick, _48.aaaa_CellClick, _47.aaaa_CellClick, _46.aaaa_CellClick, _45.aaaa_CellClick, _44.aaaa_CellClick, _43.aaaa_CellClick, _42.aaaa_CellClick, _41.aaaa_CellClick, _38.aaaa_CellClick, _37.aaaa_CellClick, _36.aaaa_CellClick, _35.aaaa_CellClick, _34.aaaa_CellClick, _33.aaaa_CellClick, _32.aaaa_CellClick, _31.aaaa_CellClick, _28.aaaa_CellClick, _27.aaaa_CellClick, _26.aaaa_CellClick, _25.aaaa_CellClick, _24.aaaa_CellClick, _23.aaaa_CellClick, _22.aaaa_CellClick, _21.aaaa_CellClick, _18.aaaa_CellClick, _17.aaaa_CellClick, _16.aaaa_CellClick, _15.aaaa_CellClick, _14.aaaa_CellClick, _13.aaaa_CellClick, _12.aaaa_CellClick, _11.aaaa_CellClick
        Dim removeHighlights = Sub()
                                   For Each i As Control In Me.Controls
                                       Dim tpy As String = i.GetType.Name
                                       If tpy = "ChessBoardCell" Then
                                           Dim cl As ChessBoardCell = i
                                           cl._highlighted = False
                                           cl.BorderStyle = BorderStyle.None
                                       End If
                                   Next
                               End Sub
        Dim setHighlights = Sub()
                                Dim a As List(Of ChessBoardCell.MoveProperty) = currentSelected.getMoves(currentSelected.Name)
                                removeHighlights()
                                For Each i As ChessBoardCell.MoveProperty In a
                                    Dim b As ChessBoardCell = CType(Me.Controls(i.cellName), ChessBoardCell)
                                    b._highlightedType = i.moveType
                                    b._highlighted = True
                                Next
                                currentSelected.BorderStyle = BorderStyle.FixedSingle
                                previousSelectedCell = currentSelected
                            End Sub
        If previousSelectedCell Is Nothing Then
            setHighlights()
        Else
            If currentSelected._highlighted And currentSelected._highlightedType <> ChessBoardCell.MoveType.SUPPORT Then
                Dim positivePassedPawn As Boolean = False
                'loop this history backward
                Dim history As New List(Of PreviusVAlue)
                Dim addToHistory = Sub(cel As ChessBoardCell, ByRef history_ As List(Of PreviusVAlue))
                                       history_.Add(New PreviusVAlue(cel.Name, cel._PeaceType, cel._PeaceColor))
                                   End Sub
                'CHECK IF PAWN PASSED
                If previousSelectedCell._PeaceType = ChessBoardCell.peaceType.PAWN Then 'P A W N
                    Dim senderY As Integer = currentSelected.convertNameToPoint(currentSelected.Name).Y
                    Dim selectedY As Integer = previousSelectedCell.convertNameToPoint(previousSelectedCell.Name).Y
                    Dim moveCOunt As Integer = Math.Abs(senderY - selectedY)
                    If moveCOunt = 2 Then
                        Dim f = Function(mov As ChessBoardCell.movement)
                                    Return currentSelected.convertToChessBoardcell(currentSelected.movePointLocation(currentSelected.convertNameToPoint(currentSelected.Name), mov))
                                End Function
                        Dim left As ChessBoardCell = f(ChessBoardCell.movement.GO_LEFT)
                        Dim right As ChessBoardCell = f(ChessBoardCell.movement.GO_RIGHT)
                        If left IsNot Nothing AndAlso left._PeaceColor <> ChessBoardCell.peaceColor.NONE AndAlso
                                    left._PeaceColor <> currentSelected._PeaceColor AndAlso
                                    left._PeaceType = ChessBoardCell.peaceType.PAWN Then
                            positivePassedPawn = True
                        End If
                        If right IsNot Nothing AndAlso right._PeaceColor <> ChessBoardCell.peaceColor.NONE AndAlso
                                    right._PeaceColor <> currentSelected._PeaceColor AndAlso
                                    right._PeaceType = ChessBoardCell.peaceType.PAWN Then
                            positivePassedPawn = True
                        End If
                        If positivePassedPawn Then
                            If previousSelectedCell._PeaceColor = ChessBoardCell.peaceColor.LIGHT Then
                                passedPawn = f(ChessBoardCell.movement.GO_DOWN)
                            ElseIf previousSelectedCell._PeaceColor = ChessBoardCell.peaceColor.DARK Then
                                passedPawn = f(ChessBoardCell.movement.GO_UP)
                            End If
                        End If
                    End If
                End If
                'PASS PAWN VALIDATIONS
                If previousSelectedCell._PeaceType = ChessBoardCell.peaceType.PAWN AndAlso passedPawn IsNot Nothing AndAlso passedPawn.Name = currentSelected.Name Then
                    If previousSelectedCell._PeaceColor = ChessBoardCell.peaceColor.LIGHT Then
                        Dim aa As ChessBoardCell = currentSelected.convertToChessBoardcell(currentSelected.movePointLocation(currentSelected.convertNameToPoint(currentSelected.Name), ChessBoardCell.movement.GO_DOWN))
                        addToHistory(aa, history)
                        aa._PeaceColor = ChessBoardCell.peaceColor.NONE
                        aa._PeaceType = ChessBoardCell.peaceType.NONE
                    ElseIf previousSelectedCell._PeaceColor = ChessBoardCell.peaceColor.DARK Then
                        Dim aa As ChessBoardCell = currentSelected.convertToChessBoardcell(currentSelected.movePointLocation(currentSelected.convertNameToPoint(currentSelected.Name), ChessBoardCell.movement.GO_UP))
                        addToHistory(aa, history)
                        aa._PeaceColor = ChessBoardCell.peaceColor.NONE
                        aa._PeaceType = ChessBoardCell.peaceType.NONE
                    End If
                End If
                'CLEAR IN ROOK WHEN 
                If previousSelectedCell._PeaceType = ChessBoardCell.peaceType.ROOK Or previousSelectedCell._PeaceType = ChessBoardCell.peaceType.KING Then
                    Select Case previousSelectedCell.Name
                        Case "_85"
                            lightKing = Nothing
                        Case "_88"
                            lightRookRight = Nothing
                        Case "_81"
                            lightRookLeft = Nothing
                        Case "_15"
                            darkKing = Nothing
                        Case "_18"
                            darkRookRight = Nothing
                        Case "_11"
                            darkRookLeft = Nothing
                    End Select
                End If
                'PERFORM VALID MOVEMENT
                addToHistory(currentSelected, history)
                currentSelected._PeaceColor = previousSelectedCell._PeaceColor
                currentSelected._PeaceType = previousSelectedCell._PeaceType
                addToHistory(previousSelectedCell, history)
                previousSelectedCell._PeaceColor = ChessBoardCell.peaceColor.NONE
                previousSelectedCell._PeaceType = ChessBoardCell.peaceType.NONE
                'PAWN PROMOTIONS
                If currentSelected._PeaceType = ChessBoardCell.peaceType.PAWN Then
                    Dim pawnLocation As Point = currentSelected.convertNameToPoint(currentSelected.Name)
                    If currentSelected._PeaceColor = ChessBoardCell.peaceColor.LIGHT And pawnLocation.Y = 1 Then
                        addToHistory(currentSelected, history)
                        choosePromotion(currentSelected)
                    ElseIf currentSelected._PeaceColor = ChessBoardCell.peaceColor.DARK And pawnLocation.Y = 8 Then
                        addToHistory(currentSelected, history)
                        choosePromotion(currentSelected)
                    End If
                End If
                'PERFORM IN ROOK
                If currentSelected._highlightedType = ChessBoardCell.MoveType.IN_ROOK Then
                    If currentSelected._PeaceColor = ChessBoardCell.peaceColor.LIGHT Then
                        If currentSelected.Name = "_87" Then
                            addToHistory(currentSelected.convertToChessBoardcell("_88"), history)
                            currentSelected.convertToChessBoardcell("_88")._PeaceColor = ChessBoardCell.peaceColor.NONE
                            currentSelected.convertToChessBoardcell("_88")._PeaceType = ChessBoardCell.peaceType.NONE

                            addToHistory(currentSelected.convertToChessBoardcell("_86"), history)
                            currentSelected.convertToChessBoardcell("_86")._PeaceType = ChessBoardCell.peaceType.ROOK
                            currentSelected.convertToChessBoardcell("_86")._PeaceColor = ChessBoardCell.peaceColor.LIGHT
                        ElseIf currentSelected.Name = "_83" Then
                            addToHistory(currentSelected.convertToChessBoardcell("_81"), history)
                            currentSelected.convertToChessBoardcell("_81")._PeaceColor = ChessBoardCell.peaceColor.NONE
                            currentSelected.convertToChessBoardcell("_81")._PeaceType = ChessBoardCell.peaceType.NONE

                            addToHistory(currentSelected.convertToChessBoardcell("_84"), history)
                            currentSelected.convertToChessBoardcell("_84")._PeaceType = ChessBoardCell.peaceType.ROOK
                            currentSelected.convertToChessBoardcell("_84")._PeaceColor = ChessBoardCell.peaceColor.LIGHT
                        End If
                    ElseIf currentSelected._PeaceColor = ChessBoardCell.peaceColor.DARK Then
                        If currentSelected.Name = "_13" Then
                            addToHistory(currentSelected.convertToChessBoardcell("_11"), history)
                            currentSelected.convertToChessBoardcell("_11")._PeaceColor = ChessBoardCell.peaceColor.NONE
                            currentSelected.convertToChessBoardcell("_11")._PeaceType = ChessBoardCell.peaceType.NONE

                            addToHistory(currentSelected.convertToChessBoardcell("_14"), history)
                            currentSelected.convertToChessBoardcell("_14")._PeaceType = ChessBoardCell.peaceType.ROOK
                            currentSelected.convertToChessBoardcell("_14")._PeaceColor = ChessBoardCell.peaceColor.DARK
                        ElseIf currentSelected.Name = "_17" Then
                            addToHistory(currentSelected.convertToChessBoardcell("_18"), history)
                            currentSelected.convertToChessBoardcell("_18")._PeaceColor = ChessBoardCell.peaceColor.NONE
                            currentSelected.convertToChessBoardcell("_18")._PeaceType = ChessBoardCell.peaceType.NONE

                            addToHistory(currentSelected.convertToChessBoardcell("_16"), history)
                            currentSelected.convertToChessBoardcell("_16")._PeaceType = ChessBoardCell.peaceType.ROOK
                            currentSelected.convertToChessBoardcell("_16")._PeaceColor = ChessBoardCell.peaceColor.DARK
                        End If
                    End If
                End If
                removeHighlights()
                previousSelectedCell = Nothing
                If Not positivePassedPawn Then
                    passedPawn = Nothing
                End If
            Else
                setHighlights()
            End If
        End If
    End Sub
    Function gertMoves(color As ChessBoardCell.peaceColor) As List(Of ChessBoardCell.MoveProperty)
        Dim allCellBoardCellNames As List(Of String) = New List(Of String)("_88,_87,_86,_85,_84,_83,_82,_81,_78,_77,_76,_75,_74,_73,_72,_71,_68,_67,_66,_65,_64,_63,_62,_61,_58,_57,_56,_55,_54,_53,_52,_51,_48,_47,_46,_45,_44,_43,_42,_41,_38,_37,_36,_35,_34,_33,_32,_31,_28,_27,_26,_25,_24,_23,_22,_21,_18,_17,_16,_15,_14,_13,_12,_11".Split(","))
        Dim res As New List(Of ChessBoardCell.MoveProperty)
        For Each i As String In allCellBoardCellNames
            Dim cell As ChessBoardCell = Me.Controls(i)
            If cell._PeaceColor = color Then
                res.AddRange(cell.getMoves(cell.Name))
            End If
        Next
        Return res
    End Function
    Sub choosePromotion(cell As ChessBoardCell)
        Form2.defaultColor = cell._PeaceColor
        If Form2.ShowDialog() = DialogResult.OK Then
            cell._PeaceColor = Form2.selected._PeaceColor
            cell._PeaceType = Form2.selected._PeaceType
        End If
    End Sub
    Private Sub _11_MouseEnter(sender As Object, e As EventArgs) Handles _88.MouseEnter, _87.MouseEnter, _86.MouseEnter, _85.MouseEnter, _84.MouseEnter, _83.MouseEnter, _82.MouseEnter, _81.MouseEnter, _78.MouseEnter, _77.MouseEnter, _76.MouseEnter, _75.MouseEnter, _74.MouseEnter, _73.MouseEnter, _72.MouseEnter, _71.MouseEnter, _68.MouseEnter, _67.MouseEnter, _66.MouseEnter, _65.MouseEnter, _64.MouseEnter, _63.MouseEnter, _62.MouseEnter, _61.MouseEnter, _58.MouseEnter, _57.MouseEnter, _56.MouseEnter, _55.MouseEnter, _54.MouseEnter, _53.MouseEnter, _52.MouseEnter, _51.MouseEnter, _48.MouseEnter, _47.MouseEnter, _46.MouseEnter, _45.MouseEnter, _44.MouseEnter, _43.MouseEnter, _42.MouseEnter, _41.MouseEnter, _38.MouseEnter, _37.MouseEnter, _36.MouseEnter, _35.MouseEnter, _34.MouseEnter, _33.MouseEnter, _32.MouseEnter, _31.MouseEnter, _28.MouseEnter, _27.MouseEnter, _26.MouseEnter, _25.MouseEnter, _24.MouseEnter, _23.MouseEnter, _22.MouseEnter, _21.MouseEnter, _18.MouseEnter, _17.MouseEnter, _16.MouseEnter, _15.MouseEnter, _14.MouseEnter, _13.MouseEnter, _12.MouseEnter, _11.MouseEnter
        Label1.Text = sender.name
    End Sub

End Class