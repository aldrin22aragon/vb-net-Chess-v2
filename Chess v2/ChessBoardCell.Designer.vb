<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChessBoardCell
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChessBoardCell))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Chess_bdt60.png")
        Me.ImageList1.Images.SetKeyName(1, "Chess_blt60.png")
        Me.ImageList1.Images.SetKeyName(2, "Chess_kdt60.png")
        Me.ImageList1.Images.SetKeyName(3, "Chess_klt60.png")
        Me.ImageList1.Images.SetKeyName(4, "Chess_ndt60.png")
        Me.ImageList1.Images.SetKeyName(5, "Chess_nlt60.png")
        Me.ImageList1.Images.SetKeyName(6, "Chess_pdt60.png")
        Me.ImageList1.Images.SetKeyName(7, "Chess_plt60.png")
        Me.ImageList1.Images.SetKeyName(8, "Chess_qdt60.png")
        Me.ImageList1.Images.SetKeyName(9, "Chess_qlt60.png")
        Me.ImageList1.Images.SetKeyName(10, "Chess_rdt60.png")
        Me.ImageList1.Images.SetKeyName(11, "Chess_rlt60.png")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(52, 44)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Visible = False
        '
        'ChessBoardCell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "ChessBoardCell"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(72, 64)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel1 As Panel
End Class
