Imports System.ComponentModel
Imports System.IO

Public Class OptionsForm
    Private Sub ButtonSelectFolder_Click(sender As Object, e As EventArgs) Handles ButtonSelectFolder.Click
        SelectFolder(TextBoxProjectsPath)
        My.Settings.ProjectsFolderPath = TextBoxProjectsPath.Text
    End Sub

    Private Sub ButtonSelectMacrosFolder_Click(sender As Object, e As EventArgs) Handles ButtonSelectMacrosFolder.Click
        SelectFolder(TextBoxMacrosPath)
        My.Settings.MacrosFolderPath = TextBoxMacrosPath.Text
    End Sub

    Private Sub TextBoxProjectsPath_TextChanged(sender As Object, e As EventArgs) Handles TextBoxProjectsPath.TextChanged
        My.Settings.ProjectsFolderPath = TextBoxProjectsPath.Text
    End Sub

    Private Sub TextBoxMacrosPath_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMacrosPath.TextChanged
        My.Settings.MacrosFolderPath = TextBoxMacrosPath.Text
    End Sub

    Sub SelectFolder(oTextBox As TextBox)
        With FolderBrowserDialog1
            .Description = "Select folder"
            .RootFolder = Environment.SpecialFolder.MyComputer
            .SelectedPath = My.Application.Info.DirectoryPath
            .ShowNewFolderButton = False
            .ShowDialog()
            If DialogResult.OK Then
                oTextBox.Text = .SelectedPath
            End If
        End With
    End Sub

    Private Sub OptionsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBoxProjectsPath.Text = My.Settings.ProjectsFolderPath
        TextBoxMacrosPath.Text = My.Settings.MacrosFolderPath
    End Sub

    Private Sub OptionsForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim FirstNode As TreeNode

        If Directory.Exists(My.Settings.ProjectsFolderPath) Then
            MainForm.TreeViewProjects.BeginUpdate()
            MainForm.TreeViewProjects.Nodes.Clear()
            FirstNode = MainForm.TreeViewProjects.Nodes.Add(My.Settings.ProjectsFolderPath,
                                                   My.Settings.ProjectsFolderPath.Substring(My.Settings.ProjectsFolderPath.LastIndexOf("\") + 1))
            MainForm.LoadDirectory(FirstNode)
            MainForm.TreeViewProjects.EndUpdate()
        End If

        If Directory.Exists(My.Settings.MacrosFolderPath) Then
            MainForm.ListViewCodes.BeginUpdate()
            MainForm.ListViewCodes.Clear()
            MainForm.ListMacros(My.Settings.MacrosFolderPath)
            MainForm.ListViewCodes.EndUpdate()
        End If
    End Sub
End Class