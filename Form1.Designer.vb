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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtSmallestRectangle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumberOfRectangles = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(239, 176)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 39
        Me.btnClear.Text = "C&lear"
        '
        'txtSmallestRectangle
        '
        Me.txtSmallestRectangle.Location = New System.Drawing.Point(214, 134)
        Me.txtSmallestRectangle.Name = "txtSmallestRectangle"
        Me.txtSmallestRectangle.ReadOnly = True
        Me.txtSmallestRectangle.Size = New System.Drawing.Size(100, 20)
        Me.txtSmallestRectangle.TabIndex = 47
        Me.txtSmallestRectangle.TabStop = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(65, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 23)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Smallest Rectangle: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumberOfRectangles
        '
        Me.txtNumberOfRectangles.Location = New System.Drawing.Point(214, 108)
        Me.txtNumberOfRectangles.Name = "txtNumberOfRectangles"
        Me.txtNumberOfRectangles.ReadOnly = True
        Me.txtNumberOfRectangles.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfRectangles.TabIndex = 45
        Me.txtNumberOfRectangles.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(54, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 23)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Number of Rectangles: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(214, 82)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(100, 20)
        Me.txtArea.TabIndex = 43
        Me.txtArea.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(148, 176)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 38
        Me.btnExit.Text = "E&xit"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(57, 176)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 37
        Me.btnCalculate.Text = "&Calculate"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(214, 56)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 36
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(214, 30)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 35
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(117, 80)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 23)
        Me.label3.TabIndex = 42
        Me.label3.Text = "Area:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(117, 54)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 23)
        Me.label2.TabIndex = 41
        Me.label2.Text = "Width:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(117, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(64, 23)
        Me.label1.TabIndex = 40
        Me.label1.Text = "Length:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(369, 226)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtSmallestRectangle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumberOfRectangles)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rectangle Area"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtSmallestRectangle As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfRectangles As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Private WithEvents btnExit As System.Windows.Forms.Button
    Private WithEvents btnCalculate As System.Windows.Forms.Button
    Private WithEvents txtWidth As System.Windows.Forms.TextBox
    Private WithEvents txtLength As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
