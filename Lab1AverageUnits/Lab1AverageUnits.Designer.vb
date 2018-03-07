<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab1AverageUnits
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
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblAverageDisplay = New System.Windows.Forms.Label()
        Me.txtUnitsPerDay = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.AvgUnitsToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblUnits.Location = New System.Drawing.Point(24, 43)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(93, 47)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AvgUnitsToolTip.SetToolTip(Me.lblUnits, "Shows units per day")
        '
        'lblDays
        '
        Me.lblDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDays.Location = New System.Drawing.Point(449, 44)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(194, 47)
        Me.lblDays.TabIndex = 5
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AvgUnitsToolTip.SetToolTip(Me.lblDays, "Shows The Day To Enter Units")
        '
        'lblAverageDisplay
        '
        Me.lblAverageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAverageDisplay.Location = New System.Drawing.Point(30, 433)
        Me.lblAverageDisplay.Name = "lblAverageDisplay"
        Me.lblAverageDisplay.Size = New System.Drawing.Size(629, 83)
        Me.lblAverageDisplay.TabIndex = 7
        Me.lblAverageDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AvgUnitsToolTip.SetToolTip(Me.lblAverageDisplay, "Displays Result Based On User Input")
        '
        'txtUnitsPerDay
        '
        Me.txtUnitsPerDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtUnitsPerDay.Location = New System.Drawing.Point(30, 110)
        Me.txtUnitsPerDay.Multiline = True
        Me.txtUnitsPerDay.Name = "txtUnitsPerDay"
        Me.txtUnitsPerDay.Size = New System.Drawing.Size(624, 302)
        Me.txtUnitsPerDay.TabIndex = 6
        Me.AvgUnitsToolTip.SetToolTip(Me.txtUnitsPerDay, "Lists Whole Weeks Entered Units ")
        '
        'btnEnter
        '
        Me.btnEnter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEnter.Location = New System.Drawing.Point(30, 585)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(174, 65)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "&Enter"
        Me.AvgUnitsToolTip.SetToolTip(Me.btnEnter, "Click Here To Add More Units and to Get Results")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReset.Location = New System.Drawing.Point(256, 585)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(174, 65)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.AvgUnitsToolTip.SetToolTip(Me.btnReset, "Click Here To Reset The Form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Location = New System.Drawing.Point(484, 585)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(174, 65)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.AvgUnitsToolTip.SetToolTip(Me.btnExit, "Click Here To Exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'AvgUnitsToolTip
        '
        Me.AvgUnitsToolTip.ToolTipTitle = "Average Units Shipped Tips"
        '
        'txtUnits
        '
        Me.txtUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnits.Location = New System.Drawing.Point(118, 44)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(173, 41)
        Me.txtUnits.TabIndex = 1
        Me.AvgUnitsToolTip.SetToolTip(Me.txtUnits, "Enter Unit Per Day")
        '
        'frmLab1AverageUnits
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(693, 691)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtUnitsPerDay)
        Me.Controls.Add(Me.lblAverageDisplay)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblUnits)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLab1AverageUnits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.AvgUnitsToolTip.SetToolTip(Me, "Average Units Shipped Calulator")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents lblAverageDisplay As Label
    Friend WithEvents txtUnitsPerDay As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents AvgUnitsToolTip As ToolTip
    Friend WithEvents txtUnits As TextBox
End Class
