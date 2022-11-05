Imports Configuracion_Sistema.Coneccion
Imports Configuracion_Sistema.ini
Public Class agenda
    Inherits System.Windows.Forms.Form
    Dim id
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents hora As System.Windows.Forms.Label
    Friend WithEvents th As System.Windows.Forms.Timer
    Friend WithEvents fec As System.Windows.Forms.MonthCalendar
    Friend WithEvents ev As System.Windows.Forms.TextBox
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(agenda))
        Me.fec = New System.Windows.Forms.MonthCalendar
        Me.Label1 = New System.Windows.Forms.Label
        Me.ev = New System.Windows.Forms.TextBox
        Me.hora = New System.Windows.Forms.Label
        Me.th = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'fec
        '
        Me.fec.Location = New System.Drawing.Point(8, 24)
        Me.fec.Name = "fec"
        Me.fec.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Agenda"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ev
        '
        Me.ev.Location = New System.Drawing.Point(8, 184)
        Me.ev.Multiline = True
        Me.ev.Name = "ev"
        Me.ev.Size = New System.Drawing.Size(170, 208)
        Me.ev.TabIndex = 3
        Me.ev.Text = ""
        '
        'hora
        '
        Me.hora.BackColor = System.Drawing.SystemColors.Highlight
        Me.hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hora.ForeColor = System.Drawing.Color.White
        Me.hora.Location = New System.Drawing.Point(8, 416)
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(170, 40)
        Me.hora.TabIndex = 4
        Me.hora.Text = "00:00:00"
        Me.hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'th
        '
        Me.th.Interval = 1000
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.ImageIndex = 6
        Me.Button8.ImageList = Me.ImageList1
        Me.Button8.Location = New System.Drawing.Point(104, 392)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(24, 24)
        Me.Button8.TabIndex = 36
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.ImageIndex = 2
        Me.Button6.ImageList = Me.ImageList1
        Me.Button6.Location = New System.Drawing.Point(56, 392)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 24)
        Me.Button6.TabIndex = 35
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.ImageIndex = 5
        Me.Button7.ImageList = Me.ImageList1
        Me.Button7.Location = New System.Drawing.Point(32, 392)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(24, 24)
        Me.Button7.TabIndex = 33
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.ImageIndex = 11
        Me.Button5.ImageList = Me.ImageList1
        Me.Button5.Location = New System.Drawing.Point(80, 392)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 24)
        Me.Button5.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ImageIndex = 8
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(128, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 24)
        Me.Button1.TabIndex = 36
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ImageIndex = 0
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(8, 392)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 24)
        Me.Button2.TabIndex = 33
        '
        'agenda
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(240, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.hora)
        Me.Controls.Add(Me.ev)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fec)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "agenda"
        Me.ShowInTaskbar = False
        Me.Text = "agenda"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub agenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        revisahora()
    End Sub

    Private Sub revisahora()
        ponhora()
        th.Enabled = True 'abrir hora
    End Sub
    Private Sub th_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles th.Tick
        ponhora()
    End Sub
    Private Sub ponhora()
        Dim mer, h, m
        If Now.Hour > 12 Then
            mer = "p.m."
            h = Now.Hour - 12
        Else
            mer = "a.m."
            h = Now.Hour
        End If
        If Now.Minute < 10 Then
            m = "0" & Now.Minute
        Else
            m = Now.Minute
        End If

        hora.Text = h & ":" & m & " " & mer
    End Sub
    Private Sub agrega()
        Dim dbset As New DataSet
        creadb("gen_agenda", "select * from gen_agenda where id_evento= " & id, dbset)
        creadb("gen_parametros", "select * from gen_parametros", dbset)

        Dim NewRow As DataRow = dbset.Tables("gen_agenda").NewRow
        NewRow("emp_codigo") = emp_id()
        NewRow("id_evento") = dbset.Tables("gen_parametros").Rows(0)("evento_sec") + 1
        NewRow("evento") = "" & RTrim(ev.Text)
        NewRow("usu_codigo") = usu_id()
        NewRow("eve_fecha") = fec.TodayDate
        dbset.Tables("gen_agenda").Rows.Add(NewRow)
        salvadb("gen_agenda", dbset)
        dbset.Tables("gen_parametros").Rows(0).BeginEdit()
        dbset.Tables("gen_parametros").Rows(0)("evento_sec") = dbset.Tables("gen_parametros").Rows(0)("evento_sec") + 1
        dbset.Tables("gen_parametros").Rows(0).EndEdit()
        salvadb("gen_parametros", dbset)
        NewRow = Nothing
        dbset = Nothing
        ev.Focus()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        agrega()
    End Sub
    Private Sub limpia()
        id = 0
        ev.Text = ""
        ev.Focus()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
