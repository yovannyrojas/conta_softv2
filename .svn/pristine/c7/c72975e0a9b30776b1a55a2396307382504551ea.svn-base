Imports Facturacion
Imports Configuracion_Sistema.ini

Public Class logo
    Inherits System.Windows.Forms.Form
    Dim empresa_nom
    Dim empresa_rnc
    Dim empresa_dir
    Dim empresa_tel
    Dim sucur_n
    Dim sucur


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents empresa As System.Windows.Forms.Label
    Friend WithEvents sucursal As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.empresa = New System.Windows.Forms.Label
        Me.sucursal = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SuspendLayout()
        '
        'empresa
        '
        Me.empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empresa.ForeColor = System.Drawing.Color.Blue
        Me.empresa.Location = New System.Drawing.Point(16, 40)
        Me.empresa.Name = "empresa"
        Me.empresa.Size = New System.Drawing.Size(744, 64)
        Me.empresa.TabIndex = 0
        Me.empresa.Text = "1"
        Me.empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sucursal
        '
        Me.sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sucursal.ForeColor = System.Drawing.Color.Blue
        Me.sucursal.Location = New System.Drawing.Point(16, 128)
        Me.sucursal.Name = "sucursal"
        Me.sucursal.Size = New System.Drawing.Size(744, 64)
        Me.sucursal.TabIndex = 1
        Me.sucursal.Text = "AZUA"
        Me.sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 216)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'logo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(776, 224)
        Me.ControlBox = False
        Me.Controls.Add(Me.sucursal)
        Me.Controls.Add(Me.empresa)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "logo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "logo"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub empresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empresa.Click

    End Sub

    Private Sub empresa_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles empresa.DoubleClick
        Dim frm3 As New Seleccionar_Empresa
        frm3.ShowDialog()
        If frm3.bcod.Text = "" Then
            Exit Sub
        End If
        empresa_nom = frm3.emp.Text
        id_empresa = frm3.bcod.Text
        empresa_dir = frm3.dir.Text
        empresa_rnc = frm3.rnc.Text
        empresa_tel = frm3.tel.Text
        frm3 = Nothing

        'esta es la empresa o sucursal seleccionada var public
        modulo = mod_id() 'este es el modulo seleccionado var public
        conecc(usu_id, id_empresa, modulo, idcaja) 'envia los datos para ser usados como publico


        Dim frm4 As New Seleccionar_Sucursal
        frm4.emp.Text = id_empresa
        frm4.ShowDialog()
        If frm4.bcod.Text = "" Then
            Exit Sub
        End If
        sucur = Trim("" & frm4.bcod.Text)
        sucur_n = Trim("" & frm4.emp.Text)
        empresa_dir = Trim("" & frm4.dir.Text)
        empresa_tel = Trim("" & frm4.tel.Text)
        frm4 = Nothing

        datos_empresa(empresa_nom, empresa_dir, empresa_rnc, empresa_tel, idcaja) 'envia los datos de la empresa para ser publicos
        datos_Sucursal(Trim("" & sucur), suc_se)
        ' s1.Text = empresa_nom
        empresa.Text = Trim(emp_id()) & " " & Trim(empresa_nom)
        sucursal.Text = Trim(sucur_n)
        'llamatipofac()

    End Sub
End Class
