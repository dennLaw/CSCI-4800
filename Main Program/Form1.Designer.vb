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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClrCmpBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.EmailBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowCompletedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowIncompletedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowFlaggedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowUnflaggedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLessThan30HrsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowMoreThan30HrsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.ImportBtn = New System.Windows.Forms.Button()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ShowAllBtn = New System.Windows.Forms.Button()
        Me.LastCl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstCl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailCl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusCl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlaggedCl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ClrCmpBtn)
        Me.Panel1.Controls.Add(Me.ClearBtn)
        Me.Panel1.Controls.Add(Me.EmailBtn)
        Me.Panel1.Controls.Add(Me.DeleteBtn)
        Me.Panel1.Controls.Add(Me.AddBtn)
        Me.Panel1.Controls.Add(Me.DG)
        Me.Panel1.Location = New System.Drawing.Point(53, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 443)
        Me.Panel1.TabIndex = 6
        '
        'ClrCmpBtn
        '
        Me.ClrCmpBtn.Location = New System.Drawing.Point(682, 389)
        Me.ClrCmpBtn.Name = "ClrCmpBtn"
        Me.ClrCmpBtn.Size = New System.Drawing.Size(75, 42)
        Me.ClrCmpBtn.TabIndex = 5
        Me.ClrCmpBtn.Text = "Clear Completed"
        Me.ClrCmpBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(601, 389)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(75, 42)
        Me.ClearBtn.TabIndex = 4
        Me.ClearBtn.Text = "Clear Selected"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'EmailBtn
        '
        Me.EmailBtn.Location = New System.Drawing.Point(520, 389)
        Me.EmailBtn.Name = "EmailBtn"
        Me.EmailBtn.Size = New System.Drawing.Size(75, 42)
        Me.EmailBtn.TabIndex = 3
        Me.EmailBtn.Text = "Email"
        Me.EmailBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(94, 389)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBtn.TabIndex = 2
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(13, 389)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddBtn.TabIndex = 1
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'DG
        '
        Me.DG.AllowUserToResizeColumns = False
        Me.DG.AllowUserToResizeRows = False
        Me.DG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LastCl, Me.FirstCl, Me.IDCl, Me.hours, Me.EmailCl, Me.StatusCl, Me.FlaggedCl})
        Me.DG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DG.Location = New System.Drawing.Point(13, 32)
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(744, 350)
        Me.DG.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ImportBtn)
        Me.Panel2.Controls.Add(Me.ShowAllBtn)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(53, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 94)
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Roster"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(770, 46)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.AutoSize = False
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowAllToolStripMenuItem, Me.ShowCompletedToolStripMenuItem, Me.ShowIncompletedToolStripMenuItem, Me.ShowFlaggedToolStripMenuItem, Me.ShowUnflaggedToolStripMenuItem, Me.ShowLessThan30HrsToolStripMenuItem, Me.ShowMoreThan30HrsToolStripMenuItem})
        Me.FilterToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(94, 27)
        Me.FilterToolStripMenuItem.Text = "Filter"
        '
        'ShowAllToolStripMenuItem
        '
        Me.ShowAllToolStripMenuItem.Name = "ShowAllToolStripMenuItem"
        Me.ShowAllToolStripMenuItem.Size = New System.Drawing.Size(323, 28)
        Me.ShowAllToolStripMenuItem.Text = "Show All"
        '
        'ShowCompletedToolStripMenuItem
        '
        Me.ShowCompletedToolStripMenuItem.Name = "ShowCompletedToolStripMenuItem"
        Me.ShowCompletedToolStripMenuItem.Size = New System.Drawing.Size(323, 28)
        Me.ShowCompletedToolStripMenuItem.Text = "Show Completed"
        '
        'ShowIncompletedToolStripMenuItem
        '
        Me.ShowIncompletedToolStripMenuItem.Name = "ShowIncompletedToolStripMenuItem"
        Me.ShowIncompletedToolStripMenuItem.Size = New System.Drawing.Size(323, 28)
        Me.ShowIncompletedToolStripMenuItem.Text = "Show Incompleted"
        '
        'ShowFlaggedToolStripMenuItem
        '
        Me.ShowFlaggedToolStripMenuItem.Name = "ShowFlaggedToolStripMenuItem"
        Me.ShowFlaggedToolStripMenuItem.Size = New System.Drawing.Size(323, 28)
        Me.ShowFlaggedToolStripMenuItem.Text = "Show Flagged"
        '
        'ShowUnflaggedToolStripMenuItem
        '
        Me.ShowUnflaggedToolStripMenuItem.Name = "ShowUnflaggedToolStripMenuItem"
        Me.ShowUnflaggedToolStripMenuItem.Size = New System.Drawing.Size(323, 28)
        Me.ShowUnflaggedToolStripMenuItem.Text = "Show Unflagged"
        '
        'ShowLessThan30HrsToolStripMenuItem
        '
        Me.ShowLessThan30HrsToolStripMenuItem.Name = "ShowLessThan30HrsToolStripMenuItem"
        Me.ShowLessThan30HrsToolStripMenuItem.Size = New System.Drawing.Size(323, 28)
        Me.ShowLessThan30HrsToolStripMenuItem.Text = "Show Less Than 30 hrs."
        '
        'ShowMoreThan30HrsToolStripMenuItem
        '
        Me.ShowMoreThan30HrsToolStripMenuItem.Name = "ShowMoreThan30HrsToolStripMenuItem"
        Me.ShowMoreThan30HrsToolStripMenuItem.Size = New System.Drawing.Size(323, 28)
        Me.ShowMoreThan30HrsToolStripMenuItem.Text = "Show More Than 30 hrs."
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(831, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 38)
        Me.Label2.TabIndex = 2
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "Table1"
        '
        'ImportBtn
        '
        Me.ImportBtn.Location = New System.Drawing.Point(682, 3)
        Me.ImportBtn.Name = "ImportBtn"
        Me.ImportBtn.Size = New System.Drawing.Size(85, 43)
        Me.ImportBtn.TabIndex = 2
        Me.ImportBtn.Text = "Import"
        Me.ImportBtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ShowAllBtn
        '
        Me.ShowAllBtn.Location = New System.Drawing.Point(94, 3)
        Me.ShowAllBtn.Name = "ShowAllBtn"
        Me.ShowAllBtn.Size = New System.Drawing.Size(98, 32)
        Me.ShowAllBtn.TabIndex = 2
        Me.ShowAllBtn.Text = "Show All"
        Me.ShowAllBtn.UseVisualStyleBackColor = True
        '
        'LastCl
        '
        Me.LastCl.HeaderText = "Last"
        Me.LastCl.Name = "LastCl"
        Me.LastCl.ReadOnly = True
        Me.LastCl.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FirstCl
        '
        Me.FirstCl.HeaderText = "First"
        Me.FirstCl.Name = "FirstCl"
        Me.FirstCl.ReadOnly = True
        Me.FirstCl.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'IDCl
        '
        Me.IDCl.HeaderText = "MyID"
        Me.IDCl.Name = "IDCl"
        Me.IDCl.ReadOnly = True
        Me.IDCl.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'hours
        '
        Me.hours.HeaderText = "Hours"
        Me.hours.Name = "hours"
        Me.hours.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'EmailCl
        '
        Me.EmailCl.HeaderText = "Email"
        Me.EmailCl.Name = "EmailCl"
        Me.EmailCl.ReadOnly = True
        Me.EmailCl.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'StatusCl
        '
        Me.StatusCl.HeaderText = "Status"
        Me.StatusCl.Name = "StatusCl"
        Me.StatusCl.ReadOnly = True
        Me.StatusCl.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FlaggedCl
        '
        Me.FlaggedCl.HeaderText = "Flagged"
        Me.FlaggedCl.Name = "FlaggedCl"
        Me.FlaggedCl.ReadOnly = True
        Me.FlaggedCl.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(899, 649)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Roster"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowCompletedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowIncompletedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowFlaggedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowUnflaggedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowLessThan30HrsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ClrCmpBtn As System.Windows.Forms.Button
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents EmailBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ImportBtn As System.Windows.Forms.Button
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ShowAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ShowMoreThan30HrsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowAllBtn As System.Windows.Forms.Button
    Friend WithEvents LastCl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstCl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hours As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailCl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusCl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlaggedCl As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
