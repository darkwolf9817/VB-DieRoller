<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Label1 = New Label()
        Label2 = New Label()
        OutBox = New ListBox()
        CmbDieType = New ComboBox()
        NumBoxDice = New NumericUpDown()
        BtnRoll = New Button()
        GrpStats = New GroupBox()
        Rdo4d6 = New RadioButton()
        Rdo3d6 = New RadioButton()
        BtnAbilityRoll = New Button()
        BtnClear = New Button()
        CType(NumBoxDice, ComponentModel.ISupportInitialize).BeginInit()
        GrpStats.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 11)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 25)
        Label1.TabIndex = 0
        Label1.Text = "Num Dice: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 76)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 25)
        Label2.TabIndex = 1
        Label2.Text = "Die Type: "
        ' 
        ' OutBox
        ' 
        OutBox.FormattingEnabled = True
        OutBox.ItemHeight = 25
        OutBox.Location = New Point(12, 165)
        OutBox.Name = "OutBox"
        OutBox.Size = New Size(1129, 154)
        OutBox.TabIndex = 2
        ' 
        ' CmbDieType
        ' 
        CmbDieType.FormattingEnabled = True
        CmbDieType.Items.AddRange(New Object() {"D20", "D12", "D10", "D8", "D6", "D4", "D100"})
        CmbDieType.Location = New Point(111, 73)
        CmbDieType.Name = "CmbDieType"
        CmbDieType.Size = New Size(401, 33)
        CmbDieType.TabIndex = 4
        ' 
        ' NumBoxDice
        ' 
        NumBoxDice.Location = New Point(121, 9)
        NumBoxDice.Name = "NumBoxDice"
        NumBoxDice.Size = New Size(391, 31)
        NumBoxDice.TabIndex = 5
        ' 
        ' BtnRoll
        ' 
        BtnRoll.Location = New Point(1019, 7)
        BtnRoll.Name = "BtnRoll"
        BtnRoll.Size = New Size(122, 33)
        BtnRoll.TabIndex = 6
        BtnRoll.Text = "Roll"
        BtnRoll.UseVisualStyleBackColor = True
        ' 
        ' GrpStats
        ' 
        GrpStats.Controls.Add(Rdo4d6)
        GrpStats.Controls.Add(Rdo3d6)
        GrpStats.Location = New Point(590, 9)
        GrpStats.Name = "GrpStats"
        GrpStats.Size = New Size(254, 125)
        GrpStats.TabIndex = 7
        GrpStats.TabStop = False
        GrpStats.Text = "Ability Roll Controls"
        ' 
        ' Rdo4d6
        ' 
        Rdo4d6.AutoSize = True
        Rdo4d6.Location = New Point(6, 90)
        Rdo4d6.Name = "Rdo4d6"
        Rdo4d6.Size = New Size(64, 29)
        Rdo4d6.TabIndex = 1
        Rdo4d6.TabStop = True
        Rdo4d6.Text = "4d6"
        Rdo4d6.UseVisualStyleBackColor = True
        ' 
        ' Rdo3d6
        ' 
        Rdo3d6.AutoSize = True
        Rdo3d6.Location = New Point(6, 30)
        Rdo3d6.Name = "Rdo3d6"
        Rdo3d6.Size = New Size(64, 29)
        Rdo3d6.TabIndex = 0
        Rdo3d6.TabStop = True
        Rdo3d6.Text = "3d6"
        Rdo3d6.UseVisualStyleBackColor = True
        ' 
        ' BtnAbilityRoll
        ' 
        BtnAbilityRoll.Location = New Point(1019, 97)
        BtnAbilityRoll.Name = "BtnAbilityRoll"
        BtnAbilityRoll.Size = New Size(122, 33)
        BtnAbilityRoll.TabIndex = 8
        BtnAbilityRoll.Text = "Ability Roll"
        BtnAbilityRoll.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(1019, 52)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(122, 33)
        BtnClear.TabIndex = 9
        BtnClear.Text = "Clear Output"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1153, 331)
        Controls.Add(BtnClear)
        Controls.Add(BtnAbilityRoll)
        Controls.Add(GrpStats)
        Controls.Add(BtnRoll)
        Controls.Add(NumBoxDice)
        Controls.Add(CmbDieType)
        Controls.Add(OutBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "FrmMain"
        Text = "VB Die Roller"
        CType(NumBoxDice, ComponentModel.ISupportInitialize).EndInit()
        GrpStats.ResumeLayout(False)
        GrpStats.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OutBox As ListBox
    Friend WithEvents CmbDieType As ComboBox
    Friend WithEvents NumBoxDice As NumericUpDown
    Friend WithEvents BtnRoll As Button
    Friend WithEvents GrpStats As GroupBox
    Friend WithEvents Rdo4d6 As RadioButton
    Friend WithEvents Rdo3d6 As RadioButton
    Friend WithEvents BtnAbilityRoll As Button
    Friend WithEvents BtnClear As Button
End Class
