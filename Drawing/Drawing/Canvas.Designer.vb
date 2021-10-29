<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Canvas
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
        Me.picDrawing = New System.Windows.Forms.PictureBox()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnBlack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDrawing
        '
        Me.picDrawing.Image = Global.Drawing.My.Resources.Resources.blankCanvas
        Me.picDrawing.Location = New System.Drawing.Point(4, 9)
        Me.picDrawing.Name = "picDrawing"
        Me.picDrawing.Size = New System.Drawing.Size(738, 601)
        Me.picDrawing.TabIndex = 0
        Me.picDrawing.TabStop = False
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(177, 616)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(80, 33)
        Me.btnRed.TabIndex = 1
        Me.btnRed.Text = "Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'btnGreen
        '
        Me.btnGreen.Location = New System.Drawing.Point(323, 616)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(80, 33)
        Me.btnGreen.TabIndex = 2
        Me.btnGreen.Text = "Green"
        Me.btnGreen.UseVisualStyleBackColor = True
        '
        'btnBlue
        '
        Me.btnBlue.Location = New System.Drawing.Point(479, 614)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(80, 35)
        Me.btnBlue.TabIndex = 3
        Me.btnBlue.Text = "Blue"
        Me.btnBlue.UseVisualStyleBackColor = True
        '
        'btnBlack
        '
        Me.btnBlack.Location = New System.Drawing.Point(37, 610)
        Me.btnBlack.Name = "btnBlack"
        Me.btnBlack.Size = New System.Drawing.Size(79, 38)
        Me.btnBlack.TabIndex = 4
        Me.btnBlack.Text = "Black"
        Me.btnBlack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(625, 616)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 34)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Canvas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 653)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBlack)
        Me.Controls.Add(Me.btnBlue)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.btnRed)
        Me.Controls.Add(Me.picDrawing)
        Me.Name = "Canvas"
        Me.Text = "Canvas"
        CType(Me.picDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picDrawing As PictureBox
    Friend WithEvents btnRed As Button
    Friend WithEvents btnGreen As Button
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnBlack As Button
    Friend WithEvents btnClear As Button
End Class
