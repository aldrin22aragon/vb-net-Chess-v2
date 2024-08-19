<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.queen = New Chess_v2.ChessBoardCell()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rook = New Chess_v2.ChessBoardCell()
        Me.horse = New Chess_v2.ChessBoardCell()
        Me.bishop = New Chess_v2.ChessBoardCell()
        Me.queenS = New Chess_v2.ChessBoardCell()
        Me.rookS = New Chess_v2.ChessBoardCell()
        Me.horseS = New Chess_v2.ChessBoardCell()
        Me.bishopS = New Chess_v2.ChessBoardCell()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'queen
        '
        Me.queen._CellBgColor = Chess_v2.ChessBoardCell.cellBgColor.NONE
        Me.queen._defaultBgThemeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.queen._highlighted = False
        Me.queen._highlightedType = Chess_v2.ChessBoardCell.MoveType.NONE
        Me.queen._highligtedBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.queen._PeaceColor = Chess_v2.ChessBoardCell.peaceColor.DARK
        Me.queen._PeaceType = Chess_v2.ChessBoardCell.peaceType.QUEEN
        Me.queen.BackColor = System.Drawing.Color.White
        Me.queen.BackgroundImage = CType(resources.GetObject("queen.BackgroundImage"), System.Drawing.Image)
        Me.queen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.queen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.queen.Location = New System.Drawing.Point(18, 16)
        Me.queen.Name = "queen"
        Me.queen.Padding = New System.Windows.Forms.Padding(10)
        Me.queen.Size = New System.Drawing.Size(72, 72)
        Me.queen.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(246, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Okay"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rook
        '
        Me.rook._CellBgColor = Chess_v2.ChessBoardCell.cellBgColor.NONE
        Me.rook._defaultBgThemeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rook._highlighted = False
        Me.rook._highlightedType = Chess_v2.ChessBoardCell.MoveType.NONE
        Me.rook._highligtedBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.rook._PeaceColor = Chess_v2.ChessBoardCell.peaceColor.DARK
        Me.rook._PeaceType = Chess_v2.ChessBoardCell.peaceType.ROOK
        Me.rook.BackColor = System.Drawing.Color.White
        Me.rook.BackgroundImage = CType(resources.GetObject("rook.BackgroundImage"), System.Drawing.Image)
        Me.rook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rook.Location = New System.Drawing.Point(97, 16)
        Me.rook.Name = "rook"
        Me.rook.Padding = New System.Windows.Forms.Padding(10)
        Me.rook.Size = New System.Drawing.Size(72, 72)
        Me.rook.TabIndex = 0
        '
        'horse
        '
        Me.horse._CellBgColor = Chess_v2.ChessBoardCell.cellBgColor.NONE
        Me.horse._defaultBgThemeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.horse._highlighted = False
        Me.horse._highlightedType = Chess_v2.ChessBoardCell.MoveType.NONE
        Me.horse._highligtedBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.horse._PeaceColor = Chess_v2.ChessBoardCell.peaceColor.DARK
        Me.horse._PeaceType = Chess_v2.ChessBoardCell.peaceType.HORSE
        Me.horse.BackColor = System.Drawing.Color.White
        Me.horse.BackgroundImage = CType(resources.GetObject("horse.BackgroundImage"), System.Drawing.Image)
        Me.horse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.horse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.horse.Location = New System.Drawing.Point(176, 16)
        Me.horse.Name = "horse"
        Me.horse.Padding = New System.Windows.Forms.Padding(10)
        Me.horse.Size = New System.Drawing.Size(72, 72)
        Me.horse.TabIndex = 0
        '
        'bishop
        '
        Me.bishop._CellBgColor = Chess_v2.ChessBoardCell.cellBgColor.NONE
        Me.bishop._defaultBgThemeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bishop._highlighted = False
        Me.bishop._highlightedType = Chess_v2.ChessBoardCell.MoveType.NONE
        Me.bishop._highligtedBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bishop._PeaceColor = Chess_v2.ChessBoardCell.peaceColor.DARK
        Me.bishop._PeaceType = Chess_v2.ChessBoardCell.peaceType.BISHOP
        Me.bishop.BackColor = System.Drawing.Color.White
        Me.bishop.BackgroundImage = CType(resources.GetObject("bishop.BackgroundImage"), System.Drawing.Image)
        Me.bishop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bishop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bishop.Location = New System.Drawing.Point(255, 16)
        Me.bishop.Name = "bishop"
        Me.bishop.Padding = New System.Windows.Forms.Padding(10)
        Me.bishop.Size = New System.Drawing.Size(72, 72)
        Me.bishop.TabIndex = 0
        '
        'queenS
        '
        Me.queenS._CellBgColor = Chess_v2.ChessBoardCell.cellBgColor.NONE
        Me.queenS._defaultBgThemeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.queenS._highlighted = False
        Me.queenS._highlightedType = Chess_v2.ChessBoardCell.MoveType.NONE
        Me.queenS._highligtedBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.queenS._PeaceColor = Chess_v2.ChessBoardCell.peaceColor.NONE
        Me.queenS._PeaceType = Chess_v2.ChessBoardCell.peaceType.QUEEN
        Me.queenS.BackColor = System.Drawing.SystemColors.ControlText
        Me.queenS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.queenS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.queenS.Location = New System.Drawing.Point(14, 12)
        Me.queenS.Name = "queenS"
        Me.queenS.Padding = New System.Windows.Forms.Padding(10)
        Me.queenS.Size = New System.Drawing.Size(72, 72)
        Me.queenS.TabIndex = 0
        Me.queenS.Visible = False
        '
        'rookS
        '
        Me.rookS._CellBgColor = Chess_v2.ChessBoardCell.cellBgColor.NONE
        Me.rookS._defaultBgThemeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rookS._highlighted = False
        Me.rookS._highlightedType = Chess_v2.ChessBoardCell.MoveType.NONE
        Me.rookS._highligtedBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.rookS._PeaceColor = Chess_v2.ChessBoardCell.peaceColor.NONE
        Me.rookS._PeaceType = Chess_v2.ChessBoardCell.peaceType.ROOK
        Me.rookS.BackColor = System.Drawing.SystemColors.ControlText
        Me.rookS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rookS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rookS.Location = New System.Drawing.Point(93, 12)
        Me.rookS.Name = "rookS"
        Me.rookS.Padding = New System.Windows.Forms.Padding(10)
        Me.rookS.Size = New System.Drawing.Size(72, 72)
        Me.rookS.TabIndex = 0
        Me.rookS.Visible = False
        '
        'horseS
        '
        Me.horseS._CellBgColor = Chess_v2.ChessBoardCell.cellBgColor.NONE
        Me.horseS._defaultBgThemeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.horseS._highlighted = False
        Me.horseS._highlightedType = Chess_v2.ChessBoardCell.MoveType.NONE
        Me.horseS._highligtedBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.horseS._PeaceColor = Chess_v2.ChessBoardCell.peaceColor.NONE
        Me.horseS._PeaceType = Chess_v2.ChessBoardCell.peaceType.HORSE
        Me.horseS.BackColor = System.Drawing.SystemColors.ControlText
        Me.horseS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.horseS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.horseS.Location = New System.Drawing.Point(172, 12)
        Me.horseS.Name = "horseS"
        Me.horseS.Padding = New System.Windows.Forms.Padding(10)
        Me.horseS.Size = New System.Drawing.Size(72, 72)
        Me.horseS.TabIndex = 0
        Me.horseS.Visible = False
        '
        'bishopS
        '
        Me.bishopS._CellBgColor = Chess_v2.ChessBoardCell.cellBgColor.NONE
        Me.bishopS._defaultBgThemeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bishopS._highlighted = False
        Me.bishopS._highlightedType = Chess_v2.ChessBoardCell.MoveType.NONE
        Me.bishopS._highligtedBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bishopS._PeaceColor = Chess_v2.ChessBoardCell.peaceColor.NONE
        Me.bishopS._PeaceType = Chess_v2.ChessBoardCell.peaceType.BISHOP
        Me.bishopS.BackColor = System.Drawing.SystemColors.ControlText
        Me.bishopS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bishopS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bishopS.Location = New System.Drawing.Point(251, 12)
        Me.bishopS.Name = "bishopS"
        Me.bishopS.Padding = New System.Windows.Forms.Padding(10)
        Me.bishopS.Size = New System.Drawing.Size(72, 72)
        Me.bishopS.TabIndex = 0
        Me.bishopS.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 147)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bishop)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.horse)
        Me.Controls.Add(Me.rook)
        Me.Controls.Add(Me.queen)
        Me.Controls.Add(Me.bishopS)
        Me.Controls.Add(Me.horseS)
        Me.Controls.Add(Me.rookS)
        Me.Controls.Add(Me.queenS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please choose promotion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents queen As ChessBoardCell
    Friend WithEvents Button1 As Button
    Friend WithEvents rook As ChessBoardCell
    Friend WithEvents horse As ChessBoardCell
    Friend WithEvents bishop As ChessBoardCell
    Friend WithEvents queenS As ChessBoardCell
    Friend WithEvents rookS As ChessBoardCell
    Friend WithEvents horseS As ChessBoardCell
    Friend WithEvents bishopS As ChessBoardCell
    Friend WithEvents Label1 As Label
End Class
