<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAirbnb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAirbnb))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.picAirbnb = New System.Windows.Forms.PictureBox()
        CType(Me.picAirbnb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHeading.Location = New System.Drawing.Point(529, 29)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(322, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Orlando AirBnB"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.Location = New System.Drawing.Point(604, 80)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(173, 17)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "Only $X.XX per night"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNumber.Location = New System.Drawing.Point(495, 195)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(176, 22)
        Me.lblNumber.TabIndex = 2
        Me.lblNumber.Text = "Number of Nights:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCost.Location = New System.Drawing.Point(495, 281)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(123, 22)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "Cost of Stay:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New System.Drawing.Point(778, 281)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(63, 22)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "$X.XX"
        '
        'btnCost
        '
        Me.btnCost.Location = New System.Drawing.Point(495, 365)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(108, 49)
        Me.btnCost.TabIndex = 5
        Me.btnCost.Text = "Display Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(636, 365)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 49)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(777, 365)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 49)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(778, 192)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(40, 27)
        Me.txtNights.TabIndex = 8
        '
        'picAirbnb
        '
        Me.picAirbnb.Image = CType(resources.GetObject("picAirbnb.Image"), System.Drawing.Image)
        Me.picAirbnb.Location = New System.Drawing.Point(12, 12)
        Me.picAirbnb.Name = "picAirbnb"
        Me.picAirbnb.Size = New System.Drawing.Size(440, 452)
        Me.picAirbnb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAirbnb.TabIndex = 9
        Me.picAirbnb.TabStop = False
        '
        'frmAirbnb
        '
        Me.AcceptButton = Me.btnCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(919, 476)
        Me.Controls.Add(Me.picAirbnb)
        Me.Controls.Add(Me.txtNights)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmAirbnb"
        Me.Text = "AirBnB Reservations"
        CType(Me.picAirbnb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNights As TextBox
    Friend WithEvents picAirbnb As PictureBox
End Class
