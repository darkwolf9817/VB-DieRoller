Public Class FrmMain
    Private Sub BtnRoll_Click(sender As Object, e As EventArgs) Handles BtnRoll.Click
        Dim NumDice = Integer.Parse(NumBoxDice.Value)
        Dim DieRoll = Roll(NumDice, CmbDieType.SelectedItem)

        OutBox.Items.Add($"You just rolled {DieRoll}!")
    End Sub

    Private Sub BtnAbilityRoll_Click(sender As Object, e As EventArgs) Handles BtnAbilityRoll.Click
        Dim Result As Integer = RollAbility(Rdo3d6.Checked, Rdo4d6.Checked)
        Dim Method As String
        If Rdo3d6.Checked Then
            Method = "3d6"
        ElseIf Rdo4d6.Checked Then
            Method = "4d6"
        Else
            Method = "Undefined"
        End If
        OutBox.Items.Add($"Rolling ability using the {Method} method. Result: {Result}!!")
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        NumBoxDice.Value = 0
        CmbDieType.SelectedValue = ""
        Rdo3d6.Checked = False
        Rdo4d6.Checked = False
        OutBox.Items.Clear()
    End Sub

    Private Function Roll(NumDice As Integer, DieType As String) As Integer
        Dim NumSides As Integer = GetSides(DieType)
        Dim TotalRoll As Integer
        Dim Die As Integer
        For i As Integer = 1 To NumDice
            Die = (Rnd() * NumSides) + 1
            If Die > NumSides Then
                Die = NumSides
            End If
            TotalRoll += Die
        Next
        Return TotalRoll
    End Function

    Private Function GetSides(DieType As String) As Integer
        Dim NumSides As Integer
        Select Case DieType
            Case "D20"
                NumSides = 20
            Case "D12"
                NumSides = 12
            Case "D10"
                NumSides = 10
            Case "D8"
                NumSides = 8
            Case "D6"
                NumSides = 6
            Case "D4"
                NumSides = 4
            Case "D100"
                NumSides = 100
        End Select
        Return NumSides
    End Function

    Private Function RollAbility(M1 As Boolean, M2 As Boolean) As Integer
        Dim NumDice, Die, TotalRoll As Integer
        Dim DieList As List(Of Integer) = New List(Of Integer)
        If M1 Then
            NumDice = 3

            For i As Integer = 1 To NumDice
                Die = (Rnd() * 6) + 1
                If Die > 6 Then
                    Die = 6
                End If
                TotalRoll += Die
            Next
        ElseIf M2 Then
            NumDice = 4

            For j As Integer = 1 To NumDice
                Die = (Rnd() * 6) + 1
                DieList.Add(Die)
            Next
            DieList.Sort()
            DieList.Remove(0)
            TotalRoll = DieList.Sum()
        Else
            MessageBox.Show("Please select one of the Radio Buttons")
        End If

        Return TotalRoll
    End Function
End Class
