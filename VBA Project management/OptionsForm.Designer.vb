<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSelectFolder = New System.Windows.Forms.Button()
        Me.TextBoxProjectsPath = New System.Windows.Forms.TextBox()
        Me.TextBoxMacrosPath = New System.Windows.Forms.TextBox()
        Me.ButtonSelectMacrosFolder = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Projects main path"
        '
        'ButtonSelectFolder
        '
        Me.ButtonSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSelectFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonSelectFolder.Location = New System.Drawing.Point(488, 6)
        Me.ButtonSelectFolder.Name = "ButtonSelectFolder"
        Me.ButtonSelectFolder.Size = New System.Drawing.Size(35, 24)
        Me.ButtonSelectFolder.TabIndex = 1
        Me.ButtonSelectFolder.Text = "[.]"
        Me.ButtonSelectFolder.UseVisualStyleBackColor = True
        '
        'TextBoxProjectsPath
        '
        Me.TextBoxProjectsPath.Location = New System.Drawing.Point(149, 6)
        Me.TextBoxProjectsPath.Name = "TextBoxProjectsPath"
        Me.TextBoxProjectsPath.Size = New System.Drawing.Size(333, 24)
        Me.TextBoxProjectsPath.TabIndex = 2
        '
        'TextBoxMacrosPath
        '
        Me.TextBoxMacrosPath.Location = New System.Drawing.Point(149, 40)
        Me.TextBoxMacrosPath.Name = "TextBoxMacrosPath"
        Me.TextBoxMacrosPath.Size = New System.Drawing.Size(333, 24)
        Me.TextBoxMacrosPath.TabIndex = 5
        '
        'ButtonSelectMacrosFolder
        '
        Me.ButtonSelectMacrosFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSelectMacrosFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonSelectMacrosFolder.Location = New System.Drawing.Point(488, 40)
        Me.ButtonSelectMacrosFolder.Name = "ButtonSelectMacrosFolder"
        Me.ButtonSelectMacrosFolder.Size = New System.Drawing.Size(35, 24)
        Me.ButtonSelectMacrosFolder.TabIndex = 4
        Me.ButtonSelectMacrosFolder.Text = "[.]"
        Me.ButtonSelectMacrosFolder.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Macros path"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'OptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 83)
        Me.Controls.Add(Me.TextBoxMacrosPath)
        Me.Controls.Add(Me.ButtonSelectMacrosFolder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxProjectsPath)
        Me.Controls.Add(Me.ButtonSelectFolder)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OptionsForm"
        Me.Text = "OptionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonSelectFolder As Button
    Friend WithEvents TextBoxProjectsPath As TextBox
    Friend WithEvents TextBoxMacrosPath As TextBox
    Friend WithEvents ButtonSelectMacrosFolder As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
