Imports System.ComponentModel
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Text.RegularExpressions

Public Class MainForm
    Dim xlApp As Excel.Application
    Dim VbaKeyNames As String

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FirstNode As TreeNode
        Dim oWorkingArea = Screen.FromControl(Me).WorkingArea

        If Directory.Exists(My.Settings.ProjectsFolderPath) Then
            TreeViewProjects.BeginUpdate()
            TreeViewProjects.Nodes.Clear()
            FirstNode = TreeViewProjects.Nodes.Add(My.Settings.ProjectsFolderPath,
                                                   My.Settings.ProjectsFolderPath.Substring(My.Settings.ProjectsFolderPath.LastIndexOf("\") + 1))
            LoadDirectory(FirstNode)
            TreeViewProjects.EndUpdate()
        End If

        If Directory.Exists(My.Settings.MacrosFolderPath) Then
            ListViewCodes.BeginUpdate()
            ListViewCodes.Items.Clear()
            ListMacros(My.Settings.MacrosFolderPath)
            ListViewCodes.EndUpdate()
        End If

        'VBA special key names
        getVBASpecialKeyNames

        Me.Top = oWorkingArea.Top
        Me.Left = oWorkingArea.Left
        Me.Height = My.Computer.Screen.WorkingArea.Height
        Me.Width = My.Computer.Screen.WorkingArea.Width / 2
    End Sub

    Sub getVBASpecialKeyNames()
        Dim vTemp As String() = My.Resources.VBA_special_key_names.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        VbaKeyNames = Join(vTemp, "|")
    End Sub

    Sub ListMacros(FolderPath As String)
        Dim FilesArray As String()
        Dim oFile As String
        Dim oFileInfo As FileInfo
        Dim oListItem As ListViewItem


        FilesArray = Directory.GetFiles(FolderPath)
        For Each oFile In FilesArray
            oFileInfo = My.Computer.FileSystem.GetFileInfo(oFile)
            If oFileInfo.Extension = ".bas" Or oFileInfo.Extension = ".cls" Then
                oListItem = ListViewCodes.Items.Add(oFileInfo.FullName, oFileInfo.Name.Substring(0, oFileInfo.Name.Length - 4),
                                                    getImageNumberByFileExtension(oFileInfo.Extension))
                oListItem.SubItems.Add(oFileInfo.Extension)
            End If

        Next
        '-1 ustala szerokosc kolumny do najszerszego elementu, -2 ustala do szerokosci naglowka
        If ListViewCodes.Items.Count > 0 Then
            If ListViewCodes.Columns.Count = 0 Then
                ListViewCodes.Columns.Add("Code snipset", 100)
                ListViewCodes.Columns.Add("Ext", 40)
            End If
            ListViewCodes.Columns.Item(0).Width = -1
            ListViewCodes.Columns.Item(1).Width = -1
            ListViewCodes.Width = ListViewCodes.Columns.Item(0).Width + ListViewCodes.Columns.Item(1).Width + 8

        End If
    End Sub

    Sub LoadDirectory(oNode As TreeNode)
        Dim Dir As String
        Dim oFile As String
        Dim oFileInfo As FileInfo
        Dim NextNode As TreeNode
        Dim ChildNode As TreeNode

        For Each Dir In Directory.GetDirectories(oNode.Name)
            NextNode = oNode.Nodes.Add(Dir, Dir.Substring(Dir.LastIndexOf("\") + 1), 1)
            NextNode.SelectedImageIndex = NextNode.ImageIndex
            LoadDirectory(NextNode)

            For Each oFile In My.Computer.FileSystem.GetFiles(NextNode.Name)
                oFileInfo = My.Computer.FileSystem.GetFileInfo(oFile)
                ChildNode = NextNode.Nodes.Add(oFileInfo.FullName, oFileInfo.Name, getImageNumberByFileExtension(oFileInfo.Extension))
                ChildNode.SelectedImageIndex = ChildNode.ImageIndex
            Next
        Next
    End Sub

    Function getImageNumberByFileExtension(FileExtension As String) As Integer
        Select Case True
            Case FileExtension Like ".xl*"
                Return 2
            Case FileExtension Like ".txt"
                Return 3
            Case FileExtension Like ".cls"
                Return 4
            Case FileExtension Like ".bas"
                Return 5
            Case Else
                Return 0
        End Select

    End Function

    Private Sub ToolStripMenuItemOptions_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemOptions.Click
        OptionsForm.ShowDialog()
        'TODO: Pole przeszukiwania treeview
        'TODO: Zapisywanie zmian w pliku bas?
        'TODO: Kopiowanie snipcoda do aktywnego projektu?
        'TODO: Menu podręczne do kopiowania kodu
    End Sub

    Private Sub ListViewCodes_Click(sender As Object, e As EventArgs) Handles ListViewCodes.Click
        Dim RegexPattern As String = VbaKeyNames
        Dim TextMatches As MatchCollection
        Dim options As RegexOptions
        Dim vLine As Long

        RichTextBoxCodePeek.LoadFile(sender.selecteditems(0).name, RichTextBoxStreamType.PlainText)
        options = RegexOptions.Multiline

        TextMatches = Regex.Matches(RichTextBoxCodePeek.Text, RegexPattern, options)

        If TextMatches.Count > 0 Then
            For Each oMatch As Match In TextMatches
                With RichTextBoxCodePeek
                    .SelectionStart = oMatch.Index
                    .SelectionLength = oMatch.Length
                    .SelectionColor = Color.Blue
                End With
            Next
        End If

        RegexPattern = "'"
        options = RegexOptions.Multiline
        TextMatches = Regex.Matches(RichTextBoxCodePeek.Text, RegexPattern, options)
        If TextMatches.Count > 0 Then
            For Each oMatch As Match In TextMatches
                With RichTextBoxCodePeek
                    .SelectionStart = oMatch.Index
                    vLine = .GetLineFromCharIndex(oMatch.Index)
                    .SelectionLength = .GetFirstCharIndexFromLine(vLine + 1) - 1 - .SelectionStart
                    .SelectionColor = Color.Green
                End With
            Next
        End If

    End Sub

    Private Sub TreeViewProjects_DoubleClick(sender As Object, e As EventArgs) Handles TreeViewProjects.DoubleClick
        If Path.GetExtension(sender.selectednode.name) Like "*xl*" Then
            OpenExcelFile(sender.selectednode.name)
        End If
    End Sub

    Private Sub OpenExcelFile(filePath As String)
        Dim OpenedWorkbook As Excel.Workbook

        If xlApp Is Nothing Then
            xlApp = New Excel.Application
        End If
        xlApp.Visible = True
        OpenedWorkbook = xlApp.Workbooks.Open(filePath)

    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Czy potrzebne jest wychodzenie z applikacji, co z otwartymi workbookami?
        'xlApp.Quit()
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
        Catch ex As Exception
            xlApp = Nothing
        End Try

    End Sub
End Class
