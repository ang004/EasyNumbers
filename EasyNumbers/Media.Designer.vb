﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Media
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Media))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeros = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.Label()
        Me.cmdCalcular = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese los valores a calcular, separados por medio de una coma (,)"
        '
        'txtNumeros
        '
        Me.txtNumeros.Location = New System.Drawing.Point(54, 52)
        Me.txtNumeros.Name = "txtNumeros"
        Me.txtNumeros.Size = New System.Drawing.Size(411, 20)
        Me.txtNumeros.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Media Aritmetica ="
        '
        'txtResultado
        '
        Me.txtResultado.AutoSize = True
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(281, 124)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(0, 24)
        Me.txtResultado.TabIndex = 4
        '
        'cmdCalcular
        '
        Me.cmdCalcular.BackColor = System.Drawing.Color.CadetBlue
        Me.cmdCalcular.FlatAppearance.BorderSize = 0
        Me.cmdCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCalcular.Location = New System.Drawing.Point(206, 78)
        Me.cmdCalcular.Name = "cmdCalcular"
        Me.cmdCalcular.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalcular.TabIndex = 31
        Me.cmdCalcular.Text = "Calcular"
        Me.cmdCalcular.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(30, 170)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(441, 10)
        Me.FlowLayoutPanel4.TabIndex = 34
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(471, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(22, 180)
        Me.FlowLayoutPanel2.TabIndex = 33
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(30, 180)
        Me.FlowLayoutPanel1.TabIndex = 32
        '
        'Button13
        '
        Me.Button13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.SpringGreen
        Me.Button13.Location = New System.Drawing.Point(36, 141)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 35
        Me.Button13.Text = "<Volver"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Media
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(493, 180)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.cmdCalcular)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumeros)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Media"
        Me.Text = "media"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumeros As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResultado As Label
    Friend WithEvents cmdCalcular As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button13 As System.Windows.Forms.Button
End Class
