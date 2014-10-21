<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.LastBx = New System.Windows.Forms.TextBox()
        Me.FirstBx = New System.Windows.Forms.TextBox()
        Me.IDBx = New System.Windows.Forms.TextBox()
        Me.EmailBx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HoursBx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(113, 199)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 26)
        Me.AddBtn.TabIndex = 0
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(194, 199)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 26)
        Me.CloseBtn.TabIndex = 1
        Me.CloseBtn.Text = "Cancel"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'LastBx
        '
        Me.LastBx.Location = New System.Drawing.Point(113, 55)
        Me.LastBx.Name = "LastBx"
        Me.LastBx.Size = New System.Drawing.Size(144, 20)
        Me.LastBx.TabIndex = 2
        '
        'FirstBx
        '
        Me.FirstBx.Location = New System.Drawing.Point(113, 84)
        Me.FirstBx.Name = "FirstBx"
        Me.FirstBx.Size = New System.Drawing.Size(144, 20)
        Me.FirstBx.TabIndex = 3
        '
        'IDBx
        '
        Me.IDBx.Location = New System.Drawing.Point(113, 110)
        Me.IDBx.Name = "IDBx"
        Me.IDBx.Size = New System.Drawing.Size(100, 20)
        Me.IDBx.TabIndex = 4
        '
        'EmailBx
        '
        Me.EmailBx.Location = New System.Drawing.Point(113, 136)
        Me.EmailBx.Name = "EmailBx"
        Me.EmailBx.Size = New System.Drawing.Size(144, 20)
        Me.EmailBx.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Student ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = " "
        '
        'HoursBx
        '
        Me.HoursBx.Location = New System.Drawing.Point(113, 162)
        Me.HoursBx.Name = "HoursBx"
        Me.HoursBx.Size = New System.Drawing.Size(36, 20)
        Me.HoursBx.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Hours"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 237)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.HoursBx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EmailBx)
        Me.Controls.Add(Me.IDBx)
        Me.Controls.Add(Me.FirstBx)
        Me.Controls.Add(Me.LastBx)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Name = "Form2"
        Me.Text = "Adding Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents LastBx As System.Windows.Forms.TextBox
    Friend WithEvents FirstBx As System.Windows.Forms.TextBox
    Friend WithEvents IDBx As System.Windows.Forms.TextBox
    Friend WithEvents EmailBx As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents HoursBx As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
