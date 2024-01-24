Public Class ChessBoardCell
    'Name Format _12 '_YX
    'cell sorting format
    '11 12 13 14
    '21 22 23 24
    '31 32 33 34
    '41 42 43 44

    Event aaaa_CellClick(sender As ChessBoardCell)
    Private type As peaceType = peaceType.NONE
    Private color_ As peaceColor = peaceColor.NONE
    Private cellColor As cellBgColor = cellBgColor.NONE
    Private defaultCellColor As Color = Color.FromArgb(0, 120, 0)
    Private defaultHighligthtKain As Color = Color.FromArgb(100, Color.Red.R, Color.Red.G, Color.Red.B)
    Private defaultHighligthtSupport As Color = Color.FromArgb(100, Color.Green.R, Color.Green.G, Color.Green.B)
    Private defaultHighligthtInRook As Color = Color.FromArgb(100, Color.Violet.R, Color.Violet.G, Color.Violet.B)
    Private defaultMoveType As MoveType = ChessBoardCell.MoveType.NONE
    Private defaultAlpha As Integer = 200
    Private darkPawnStartingY As Integer = 2
    Private lightPawnStartingY As Integer = 7
    Private allCellBoardCellNames As List(Of String) = New List(Of String)("_88,_87,_86,_85,_84,_83,_82,_81,_78,_77,_76,_75,_74,_73,_72,_71,_68,_67,_66,_65,_64,_63,_62,_61,_58,_57,_56,_55,_54,_53,_52,_51,_48,_47,_46,_45,_44,_43,_42,_41,_38,_37,_36,_35,_34,_33,_32,_31,_28,_27,_26,_25,_24,_23,_22,_21,_18,_17,_16,_15,_14,_13,_12,_11".Split(","))

    Sub New()
        InitializeComponent()
        setImageChanged()
    End Sub
    Sub setImageChanged()
        Dim name As String = ""
        Dim tint As String = IIf(_PeaceColor = peaceColor.DARK, "d", "l")
        Select Case _PeaceType
            Case peaceType.BISHOP
                name = String.Concat("Chess_b", tint, "t60.png")
            Case peaceType.HORSE
                name = String.Concat("Chess_n", tint, "t60.png")
            Case peaceType.KING
                name = String.Concat("Chess_k", tint, "t60.png")
            Case peaceType.PAWN
                name = String.Concat("Chess_p", tint, "t60.png")
            Case peaceType.QUEEN
                name = String.Concat("Chess_q", tint, "t60.png")
            Case peaceType.ROOK
                name = String.Concat("Chess_r", tint, "t60.png")
        End Select
        If name <> "" And _PeaceColor <> peaceColor.NONE Then
            Me.BackgroundImage = ImageList1.Images(name)
        Else
            Me.BackgroundImage = Nothing
        End If
    End Sub
    Sub setBackColorChanged()
        If _CellBgColor = cellBgColor.DARK Then
            Me.BackColor = Me._defaultBgThemeColor
        Else
            Me.BackColor = Color.White
        End If
    End Sub
    Private Sub ChessBoardCell_Click(sender As Object, e As EventArgs) Handles Me.Click, Panel1.Click
        RaiseEvent aaaa_CellClick(Me)
    End Sub
    Function getMoves(name As String) As List(Of MoveProperty)
        Dim list As New List(Of MoveProperty)
        Dim mainPoint As Point = convertNameToPoint(name)
        Select Case Me._PeaceType
            Case peaceType.BISHOP
                getBishopMoves(list, mainPoint)
            Case peaceType.ROOK
                getRookMoves(list, mainPoint)
            Case peaceType.QUEEN
                getQueenMoves(list, mainPoint)
            Case peaceType.KING
                getKingMoves(list, mainPoint)
            Case peaceType.HORSE
                getHorseMoves(list, mainPoint)
            Case peaceType.PAWN
                getPawnMoves(list, mainPoint)
        End Select
        Return list
    End Function
    Sub getPawnMoves(ByRef list As List(Of MoveProperty), mainPoint As Point)
        Dim aaa As String = ""
        Dim cell As ChessBoardCell = convertToChessBoardcell(mainPoint)
        Dim addListWhenExistingRL = Sub(ByRef list_ As List(Of MoveProperty), ByRef cellPoint As Point)
                                        Dim cell_ As ChessBoardCell = convertToChessBoardcell(cellPoint)
                                        If cell_ IsNot Nothing Then
                                            If Testing_form.passedPawn IsNot Nothing AndAlso Testing_form.passedPawn.Name = cell_.Name Then
                                                list_.Add(New MoveProperty(convertPointToName(cellPoint), MoveType.KAIN))
                                            ElseIf (cell_._PeaceType <> peaceType.NONE And cell_._PeaceColor <> peaceColor.NONE And cell_._PeaceColor <> Me._PeaceColor) Then
                                                list_.Add(New MoveProperty(convertPointToName(cellPoint), MoveType.KAIN))
                                            ElseIf (cell_._PeaceType <> peaceType.NONE And cell_._PeaceColor <> peaceColor.NONE And cell_._PeaceColor = Me._PeaceColor) Then
                                                list_.Add(New MoveProperty(convertPointToName(cellPoint), MoveType.SUPPORT))
                                            End If
                                        End If
                                    End Sub
        Dim addListWhenExistingForward = Sub(ByRef _list As List(Of MoveProperty), ByRef cellPoint As Point)
                                             Dim _cell As ChessBoardCell = convertToChessBoardcell(cellPoint)
                                             If _cell IsNot Nothing Then
                                                 If _cell._PeaceType = peaceType.NONE Then
                                                     _list.Add(New MoveProperty(convertPointToName(cellPoint), MoveType.MOVEONLY))
                                                 End If
                                             End If
                                         End Sub
        If cell IsNot Nothing Then
            If cell._PeaceColor = peaceColor.DARK Then
                addListWhenExistingRL(list, movePointLocation(mainPoint, movement.GO_DOWN, movement.GO_LEFT))
                addListWhenExistingRL(list, movePointLocation(mainPoint, movement.GO_DOWN, movement.GO_RIGHT))
                Dim lastCOunt As Integer = list.Count
                addListWhenExistingForward(list, movePointLocation(mainPoint, movement.GO_DOWN))
                If lastCOunt <> list.Count And mainPoint.Y = darkPawnStartingY Then
                    addListWhenExistingForward(list, movePointLocation(mainPoint, movement.GO_DOWN, movement.GO_DOWN))
                End If
            ElseIf cell._PeaceColor = peaceColor.LIGHT Then
                addListWhenExistingRL(list, movePointLocation(mainPoint, movement.GO_UP, movement.GO_LEFT))
                addListWhenExistingRL(list, movePointLocation(mainPoint, movement.GO_UP, movement.GO_RIGHT))
                Dim lastCOunt As Integer = list.Count
                addListWhenExistingForward(list, movePointLocation(mainPoint, movement.GO_UP))
                If lastCOunt <> list.Count And mainPoint.Y = lightPawnStartingY Then
                    addListWhenExistingForward(list, movePointLocation(mainPoint, movement.GO_UP, movement.GO_UP))
                End If
            End If
        End If
    End Sub
    Sub getHorseMoves(ByRef list As List(Of MoveProperty), mainPoint As Point)
        Dim horse = Sub(ByRef _list As List(Of MoveProperty), ByRef cellPoint As Point)
                        Dim cell As ChessBoardCell = convertToChessBoardcell(cellPoint)
                        If cell IsNot Nothing Then
                            If cell._PeaceType = peaceType.NONE Then
                                _list.Add(New MoveProperty(convertPointToName(cellPoint), MoveType.MOVEONLY))
                            ElseIf cell._PeaceType <> Nothing And cell._PeaceColor <> Me._PeaceColor Then
                                _list.Add(New MoveProperty(convertPointToName(cellPoint), MoveType.KAIN))
                            ElseIf cell._PeaceType <> Nothing And cell._PeaceColor = Me._PeaceColor Then
                                _list.Add(New MoveProperty(convertPointToName(cellPoint), MoveType.SUPPORT))
                            End If
                        End If
                    End Sub
        horse(list, movePointLocation(mainPoint, movement.GO_DOWN, movement.GO_DOWN, movement.GO_LEFT))
        horse(list, movePointLocation(mainPoint, movement.GO_DOWN, movement.GO_DOWN, movement.GO_RIGHT))
        horse(list, movePointLocation(mainPoint, movement.GO_UP, movement.GO_UP, movement.GO_LEFT))
        horse(list, movePointLocation(mainPoint, movement.GO_UP, movement.GO_UP, movement.GO_RIGHT))
        horse(list, movePointLocation(mainPoint, movement.GO_LEFT, movement.GO_LEFT, movement.GO_UP))
        horse(list, movePointLocation(mainPoint, movement.GO_LEFT, movement.GO_LEFT, movement.GO_DOWN))
        horse(list, movePointLocation(mainPoint, movement.GO_RIGHT, movement.GO_RIGHT, movement.GO_UP))
        horse(list, movePointLocation(mainPoint, movement.GO_RIGHT, movement.GO_RIGHT, movement.GO_DOWN))
    End Sub
    Sub getKingMoves(ByRef list As List(Of MoveProperty), mainPoint As Point)
        rook(list, movePointLocation(mainPoint, movement.GO_UP))
        rook(list, movePointLocation(mainPoint, movement.GO_DOWN))
        rook(list, movePointLocation(mainPoint, movement.GO_LEFT))
        rook(list, movePointLocation(mainPoint, movement.GO_RIGHT))
        bishop(list, movePointLocation(mainPoint, movement.GO_UP, movement.GO_RIGHT))
        bishop(list, movePointLocation(mainPoint, movement.GO_DOWN, movement.GO_RIGHT))
        bishop(list, movePointLocation(mainPoint, movement.GO_UP, movement.GO_LEFT))
        bishop(list, movePointLocation(mainPoint, movement.GO_DOWN, movement.GO_LEFT))
        Dim cl As ChessBoardCell = convertToChessBoardcell(mainPoint)
        If cl._PeaceColor = peaceColor.LIGHT And Testing_form.lightKing IsNot Nothing Then
            If Testing_form.lightRookRight IsNot Nothing Then
                Dim one As ChessBoardCell = cl.convertToChessBoardcell(cl.movePointLocation(mainPoint, movement.GO_RIGHT))
                Dim two As ChessBoardCell = cl.convertToChessBoardcell(cl.movePointLocation(mainPoint, movement.GO_RIGHT, movement.GO_RIGHT))
                If one._PeaceType = peaceType.NONE AndAlso two._PeaceType = peaceType.NONE Then
                    list.Add(New MoveProperty(two.Name, MoveType.IN_ROOK))
                End If
            End If
            If Testing_form.lightRookLeft IsNot Nothing Then
                Dim one As ChessBoardCell = cl.convertToChessBoardcell(cl.movePointLocation(mainPoint, movement.GO_LEFT))
                Dim two As ChessBoardCell = cl.convertToChessBoardcell(cl.movePointLocation(mainPoint, movement.GO_LEFT, movement.GO_LEFT))
                If one._PeaceType = peaceType.NONE AndAlso two._PeaceType = peaceType.NONE Then
                    list.Add(New MoveProperty(two.Name, MoveType.IN_ROOK))
                End If
            End If
        ElseIf cl._PeaceColor = peaceColor.DARK AndAlso Testing_form.darkKing IsNot Nothing Then
            If Testing_form.darkRookRight IsNot Nothing Then
                Dim one As ChessBoardCell = cl.convertToChessBoardcell(cl.movePointLocation(mainPoint, movement.GO_RIGHT))
                Dim two As ChessBoardCell = cl.convertToChessBoardcell(cl.movePointLocation(mainPoint, movement.GO_RIGHT, movement.GO_RIGHT))
                If one._PeaceType = peaceType.NONE AndAlso two._PeaceType = peaceType.NONE Then
                    list.Add(New MoveProperty(two.Name, MoveType.IN_ROOK))
                End If
            End If
            If Testing_form.darkRookLeft IsNot Nothing Then
                Dim one As ChessBoardCell = cl.convertToChessBoardcell(cl.movePointLocation(mainPoint, movement.GO_LEFT))
                Dim two As ChessBoardCell = cl.convertToChessBoardcell(cl.movePointLocation(mainPoint, movement.GO_LEFT, movement.GO_LEFT))
                If one._PeaceType = peaceType.NONE AndAlso two._PeaceType = peaceType.NONE Then
                    list.Add(New MoveProperty(two.Name, MoveType.IN_ROOK))
                End If
            End If
        End If
    End Sub
    Sub getQueenMoves(ByRef list As List(Of MoveProperty), mainPoint As Point)
        Dim u As Point = mainPoint
        Dim d As Point = mainPoint
        Dim l As Point = mainPoint
        Dim r As Point = mainPoint
        Dim ul As Point = mainPoint
        Dim ur As Point = mainPoint
        Dim ll As Point = mainPoint
        Dim lr As Point = mainPoint
        While True
            Dim lastCount As Integer = list.Count
            u = movePointLocation(u, movement.GO_UP)
            d = movePointLocation(d, movement.GO_DOWN)
            l = movePointLocation(l, movement.GO_LEFT)
            r = movePointLocation(r, movement.GO_RIGHT)
            rook(list, u)
            rook(list, d)
            rook(list, l)
            rook(list, r)
            ur = movePointLocation(ur, movement.GO_UP, movement.GO_RIGHT)
            lr = movePointLocation(lr, movement.GO_DOWN, movement.GO_RIGHT)
            ul = movePointLocation(ul, movement.GO_UP, movement.GO_LEFT)
            ll = movePointLocation(ll, movement.GO_DOWN, movement.GO_LEFT)
            bishop(list, ur)
            bishop(list, lr)
            bishop(list, ul)
            bishop(list, ll)
            Dim a As New TextBox
            If lastCount = list.Count Then
                Exit While
            End If
        End While
    End Sub
    Sub getRookMoves(ByRef list As List(Of MoveProperty), mainPoint As Point)
        Dim u As Point = mainPoint
        Dim d As Point = mainPoint
        Dim l As Point = mainPoint
        Dim r As Point = mainPoint
        While True
            u = movePointLocation(u, movement.GO_UP)
            d = movePointLocation(d, movement.GO_DOWN)
            l = movePointLocation(l, movement.GO_LEFT)
            r = movePointLocation(r, movement.GO_RIGHT)
            Dim lastCount As Integer = list.Count
            rook(list, u)
            rook(list, d)
            rook(list, l)
            rook(list, r)
            If lastCount = list.Count Then
                Exit While
            End If
        End While
    End Sub
    Sub getBishopMoves(ByRef list As List(Of MoveProperty), mainPoint As Point)
        Dim ur As Point = mainPoint
        Dim lr As Point = mainPoint
        Dim ul As Point = mainPoint
        Dim ll As Point = mainPoint
        While True
            ur = movePointLocation(ur, movement.GO_UP, movement.GO_RIGHT)
            lr = movePointLocation(lr, movement.GO_DOWN, movement.GO_RIGHT)
            ul = movePointLocation(ul, movement.GO_UP, movement.GO_LEFT)
            ll = movePointLocation(ll, movement.GO_DOWN, movement.GO_LEFT)
            Dim lastCount As Integer = list.Count
            bishop(list, ur)
            bishop(list, lr)
            bishop(list, ul)
            bishop(list, ll)
            If list.Count = lastCount Then
                Exit While
            End If
        End While
    End Sub
    Sub rook(ByRef _list As List(Of MoveProperty), ByRef cellPoint As Point)
        Dim _cell As ChessBoardCell = convertToChessBoardcell(cellPoint)
        If _cell IsNot Nothing Then
            If _cell._PeaceType = peaceType.NONE Then
                _list.Add(New MoveProperty(convertPointToName(cellPoint), MoveType.MOVEONLY))
            ElseIf (_cell._PeaceType <> peaceType.NONE And _cell._PeaceColor <> Me._PeaceColor) Then
                _list.Add(New MoveProperty(convertPointToName(cellPoint), MoveType.KAIN))
                cellPoint = New Point(-2000, -2000)
            ElseIf (_cell._PeaceType <> peaceType.NONE And _cell._PeaceColor = Me._PeaceColor) Then
                _list.Add(New MoveProperty(convertPointToName(cellPoint), MoveType.SUPPORT))
                cellPoint = New Point(-2000, -2000)
            Else
                cellPoint = New Point(-2000, -2000)
            End If
        End If
    End Sub
    Sub bishop(ByRef _list As List(Of MoveProperty), ByRef _ur As Point)
        Dim _cUr As ChessBoardCell = convertToChessBoardcell(_ur)
        If _cUr IsNot Nothing Then
            If _cUr._PeaceType = peaceType.NONE Then
                _list.Add(New MoveProperty(convertPointToName(_ur), MoveType.MOVEONLY))
            ElseIf (_cUr._PeaceType <> peaceType.NONE And _cUr._PeaceColor <> peaceColor.NONE And _cUr._PeaceColor <> Me._PeaceColor) Then
                _list.Add(New MoveProperty(convertPointToName(_ur), MoveType.KAIN))
                _ur = New Point(-2000, -2000)
            ElseIf (_cUr._PeaceType <> peaceType.NONE And _cUr._PeaceColor <> peaceColor.NONE And _cUr._PeaceColor = Me._PeaceColor) Then
                _list.Add(New MoveProperty(convertPointToName(_ur), MoveType.SUPPORT))
                _ur = New Point(-2000, -2000)
            Else
                _ur = New Point(-2000, -2000)
            End If
        End If
    End Sub
#Region "Utensils"
    Class MoveProperty
        Public cellName As String = ""
        Public moveType As MoveType = MoveType.NONE
        Sub New(cellName As String, moveType As MoveType)
            Me.cellName = cellName
            Me.moveType = moveType
        End Sub
    End Class
    Property _highligtedBorderColor As Color
        Get
            Return Panel1.BackColor
        End Get
        Set(value As Color)
            Me.defaultHighligthtKain = value
            Panel1.BackColor = Color.FromArgb(defaultAlpha, value.R, value.G, value.B)
        End Set
    End Property
    Property _highlightedType As MoveType
        Get
            Return Me.defaultMoveType
        End Get
        Set(value As MoveType)
            Select Case value
                Case MoveType.KAIN
                    Panel1.BackColor = Color.FromArgb(defaultAlpha, defaultHighligthtKain.R, defaultHighligthtKain.G, defaultHighligthtKain.B)
                Case MoveType.MOVEONLY
                    Panel1.BackColor = Color.FromArgb(defaultAlpha, 0, 0, 0)
                Case MoveType.SUPPORT
                    Panel1.BackColor = Color.FromArgb(defaultAlpha, defaultHighligthtSupport.R, defaultHighligthtSupport.G, defaultHighligthtSupport.B)
                Case MoveType.IN_ROOK
                    Panel1.BackColor = Color.FromArgb(defaultAlpha, defaultHighligthtInRook.R, defaultHighligthtInRook.G, defaultHighligthtInRook.B)
                Case MoveType.NONE
            End Select
            Me.defaultMoveType = value
        End Set
    End Property
    Property _highlighted As Boolean
        Get
            Return Panel1.Visible
        End Get
        Set(value As Boolean)

            Panel1.Visible = value
        End Set
    End Property
    Function movePointLocation(point As Point, ParamArray movements() As movement) As Point
        For Each i As movement In movements
            Select Case i
                Case movement.GO_DOWN
                    point = New Point(point.X, point.Y + 1)
                Case movement.GO_UP
                    point = New Point(point.X, point.Y - 1)
                Case movement.GO_LEFT
                    point = New Point(point.X - 1, point.Y)
                Case movement.GO_RIGHT
                    point = New Point(point.X + 1, point.Y)
            End Select
        Next
        Return (point)
    End Function
    Function convertToChessBoardcell(p As Point) As ChessBoardCell
        Dim res As ChessBoardCell = Nothing
        Try
            res = CType(Me.ParentForm.Controls(convertPointToName(p)), ChessBoardCell)
        Catch ex As Exception
        End Try
        Return res
    End Function
    Function convertToChessBoardcell(name As String) As ChessBoardCell
        Dim res As ChessBoardCell = Nothing
        Try
            res = CType(Me.ParentForm.Controls(name), ChessBoardCell)
        Catch ex As Exception
        End Try
        Return res
    End Function
    Function convertPointToName(point As Point) As String
        Return String.Concat("_", point.Y, point.X)
    End Function
    Function convertNameToPoint(name As String) As Point
        Return New Point(name.Substring(2, 1), name.Substring(1, 1))
    End Function
    Property _defaultBgThemeColor As Color
        Get
            Return Me.defaultCellColor
        End Get
        Set(value As Color)
            Me.defaultCellColor = value
            setBackColorChanged()
        End Set
    End Property
    Property _CellBgColor As cellBgColor
        Get
            Return Me.cellColor
        End Get
        Set(value As cellBgColor)
            Me.cellColor = value
            setBackColorChanged()
        End Set
    End Property
    Property _PeaceType As peaceType
        Get
            Return Me.type
        End Get
        Set(value As peaceType)
            Me.type = value
            setImageChanged()
        End Set
    End Property
    Property _PeaceColor As peaceColor
        Get
            Return Me.color_
        End Get
        Set(value As peaceColor)
            Me.color_ = value
            setImageChanged()
        End Set
    End Property
    Enum movement As Integer
        GO_UP = 1
        GO_DOWN = 2
        GO_RIGHT = 3
        GO_LEFT = 4
    End Enum
    Enum MoveType As Integer
        NONE = 0
        KAIN = 1
        MOVEONLY = 2
        SUPPORT = 3
        IN_ROOK = 4
    End Enum
    Enum cellBgColor As Integer
        NONE = 0
        DARK = 1
        LIGHT = 2
    End Enum
    Enum peaceType As Integer
        NONE = 0
        PAWN = 1
        ROOK = 2
        HORSE = 3
        BISHOP = 4
        QUEEN = 5
        KING = 6
    End Enum
    Enum peaceColor As Integer
        NONE = 0
        DARK = 1
        LIGHT = 2
    End Enum

#End Region
End Class
