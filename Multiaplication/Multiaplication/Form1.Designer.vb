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
        Me.txt_setter = New System.Windows.Forms.TextBox()
        Me.txt_start = New System.Windows.Forms.TextBox()
        Me.txt_endpoint = New System.Windows.Forms.TextBox()
        Me.btb_cal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_setter
        '
        Me.txt_setter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_setter.Location = New System.Drawing.Point(158, 318)
        Me.txt_setter.Name = "txt_setter"
        Me.txt_setter.Size = New System.Drawing.Size(135, 38)
        Me.txt_setter.TabIndex = 0
        '
        'txt_start
        '
        Me.txt_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_start.Location = New System.Drawing.Point(489, 318)
        Me.txt_start.Name = "txt_start"
        Me.txt_start.Size = New System.Drawing.Size(135, 38)
        Me.txt_start.TabIndex = 1
        '
        'txt_endpoint
        '
        Me.txt_endpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endpoint.Location = New System.Drawing.Point(812, 318)
        Me.txt_endpoint.Name = "txt_endpoint"
        Me.txt_endpoint.Size = New System.Drawing.Size(135, 38)
        Me.txt_endpoint.TabIndex = 2
        '
        'btb_cal
        '
        Me.btb_cal.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btb_cal.Location = New System.Drawing.Point(465, 496)
        Me.btb_cal.Name = "btb_cal"
        Me.btb_cal.Size = New System.Drawing.Size(179, 65)
        Me.btb_cal.TabIndex = 3
        Me.btb_cal.Text = "cal"
        Me.btb_cal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "สูตรคูณแม่"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(516, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "เริ่มต้น"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(845, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "สิ้นสุด"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 674)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btb_cal)
        Me.Controls.Add(Me.txt_endpoint)
        Me.Controls.Add(Me.txt_start)
        Me.Controls.Add(Me.txt_setter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_setter As TextBox
    Friend WithEvents txt_start As TextBox
    Friend WithEvents txt_endpoint As TextBox
    Friend WithEvents btb_cal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
