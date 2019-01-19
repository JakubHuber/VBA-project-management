<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TreeViewProjects = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItemOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListViewCodes = New System.Windows.Forms.ListView()
        Me.ColumnHeaderCodeSnipset = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RichTextBoxCodePeek = New System.Windows.Forms.RichTextBox()
        Me.MainMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeViewProjects
        '
        Me.TreeViewProjects.BackColor = System.Drawing.Color.Lavender
        Me.TreeViewProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeViewProjects.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeViewProjects.ImageIndex = 1
        Me.TreeViewProjects.ImageList = Me.ImageList1
        Me.TreeViewProjects.Location = New System.Drawing.Point(0, 24)
        Me.TreeViewProjects.Name = "TreeViewProjects"
        Me.TreeViewProjects.SelectedImageIndex = 1
        Me.TreeViewProjects.Size = New System.Drawing.Size(273, 364)
        Me.TreeViewProjects.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "FileOther.ico")
        Me.ImageList1.Images.SetKeyName(1, "Folder.ico")
        Me.ImageList1.Images.SetKeyName(2, "Excel.ico")
        Me.ImageList1.Images.SetKeyName(3, "vistex.ico")
        Me.ImageList1.Images.SetKeyName(4, "class.ico")
        Me.ImageList1.Images.SetKeyName(5, "module.ico")
        Me.ImageList1.Images.SetKeyName(6, "form.ico")
        Me.ImageList1.Images.SetKeyName(7, "vba.ico")
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.BackColor = System.Drawing.Color.Orange
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemOptions})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Size = New System.Drawing.Size(940, 24)
        Me.MainMenuStrip.TabIndex = 1
        Me.MainMenuStrip.Text = "MenuStrip1"
        '
        'ToolStripMenuItemOptions
        '
        Me.ToolStripMenuItemOptions.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ToolStripMenuItemOptions.Name = "ToolStripMenuItemOptions"
        Me.ToolStripMenuItemOptions.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItemOptions.Text = "Options"
        '
        'ListViewCodes
        '
        Me.ListViewCodes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderCodeSnipset, Me.ColumnHeaderExtension})
        Me.ListViewCodes.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListViewCodes.FullRowSelect = True
        Me.ListViewCodes.GridLines = True
        Me.ListViewCodes.Location = New System.Drawing.Point(273, 24)
        Me.ListViewCodes.MultiSelect = False
        Me.ListViewCodes.Name = "ListViewCodes"
        Me.ListViewCodes.Size = New System.Drawing.Size(290, 364)
        Me.ListViewCodes.SmallImageList = Me.ImageList1
        Me.ListViewCodes.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewCodes.TabIndex = 2
        Me.ListViewCodes.UseCompatibleStateImageBehavior = False
        Me.ListViewCodes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderCodeSnipset
        '
        Me.ColumnHeaderCodeSnipset.Text = "Code snipset"
        Me.ColumnHeaderCodeSnipset.Width = 100
        '
        'ColumnHeaderExtension
        '
        Me.ColumnHeaderExtension.Text = "Ext"
        '
        'RichTextBoxCodePeek
        '
        Me.RichTextBoxCodePeek.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxCodePeek.Location = New System.Drawing.Point(563, 24)
        Me.RichTextBoxCodePeek.Name = "RichTextBoxCodePeek"
        Me.RichTextBoxCodePeek.Size = New System.Drawing.Size(377, 364)
        Me.RichTextBoxCodePeek.TabIndex = 4
        Me.RichTextBoxCodePeek.Text = ""
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 388)
        Me.Controls.Add(Me.RichTextBoxCodePeek)
        Me.Controls.Add(Me.ListViewCodes)
        Me.Controls.Add(Me.TreeViewProjects)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main form"
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeViewProjects As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents MainMenuStrip As MenuStrip
    Friend WithEvents ToolStripMenuItemOptions As ToolStripMenuItem
    Friend WithEvents ListViewCodes As ListView
    Friend WithEvents ColumnHeaderCodeSnipset As ColumnHeader
    Friend WithEvents ColumnHeaderExtension As ColumnHeader
    Friend WithEvents RichTextBoxCodePeek As RichTextBox
End Class
