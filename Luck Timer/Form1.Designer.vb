<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.lbl = New System.Windows.Forms.Label
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.txt2 = New System.Windows.Forms.TextBox
        Me.btn = New System.Windows.Forms.Button
        Me.grb = New System.Windows.Forms.GroupBox
        Me.lblrights = New System.Windows.Forms.Label
        Me.grb.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmr
        '
        Me.tmr.Interval = 1000
        '
        'lbl
        '
        Me.lbl.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.lbl.Font = New System.Drawing.Font("Arial", 300.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl.Location = New System.Drawing.Point(12, 9)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(468, 448)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "0"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.Color.Black
        Me.txt1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.ForeColor = System.Drawing.Color.White
        Me.txt1.Location = New System.Drawing.Point(7, 23)
        Me.txt1.MaxLength = 1
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(29, 39)
        Me.txt1.TabIndex = 1
        Me.txt1.Text = "0"
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2
        '
        Me.txt2.BackColor = System.Drawing.Color.Black
        Me.txt2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.ForeColor = System.Drawing.Color.White
        Me.txt2.Location = New System.Drawing.Point(110, 23)
        Me.txt2.MaxLength = 1
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(29, 39)
        Me.txt2.TabIndex = 2
        Me.txt2.Text = "0"
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn
        '
        Me.btn.BackColor = System.Drawing.Color.Black
        Me.btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.Location = New System.Drawing.Point(41, 23)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(64, 39)
        Me.btn.TabIndex = 0
        Me.btn.Text = "OK"
        Me.btn.UseVisualStyleBackColor = False
        '
        'grb
        '
        Me.grb.Controls.Add(Me.txt1)
        Me.grb.Controls.Add(Me.btn)
        Me.grb.Controls.Add(Me.txt2)
        Me.grb.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb.Location = New System.Drawing.Point(174, 0)
        Me.grb.Name = "grb"
        Me.grb.Size = New System.Drawing.Size(145, 68)
        Me.grb.TabIndex = 0
        Me.grb.TabStop = False
        '
        'lblrights
        '
        Me.lblrights.AutoSize = True
        Me.lblrights.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblrights.Location = New System.Drawing.Point(132, 441)
        Me.lblrights.Name = "lblrights"
        Me.lblrights.Size = New System.Drawing.Size(229, 16)
        Me.lblrights.TabIndex = 2
        Me.lblrights.Text = "Designed by : Eslam Abdullah 2012"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(492, 466)
        Me.Controls.Add(Me.lblrights)
        Me.Controls.Add(Me.grb)
        Me.Controls.Add(Me.lbl)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Luck Timer"
        Me.grb.ResumeLayout(False)
        Me.grb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents grb As System.Windows.Forms.GroupBox
    Friend WithEvents lblrights As System.Windows.Forms.Label

End Class
