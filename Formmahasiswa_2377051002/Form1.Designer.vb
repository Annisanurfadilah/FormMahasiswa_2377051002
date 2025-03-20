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
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.lblGRADE = New System.Windows.Forms.Label()
        Me.lblUAS = New System.Windows.Forms.Label()
        Me.lblUTS = New System.Windows.Forms.Label()
        Me.lblTugas = New System.Windows.Forms.Label()
        Me.btnNilai = New System.Windows.Forms.Label()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.lblJenisKelamin = New System.Windows.Forms.Label()
        Me.rbP = New System.Windows.Forms.RadioButton()
        Me.rbL = New System.Windows.Forms.RadioButton()
        Me.cbJurusan = New System.Windows.Forms.ComboBox()
        Me.cbFakultas = New System.Windows.Forms.ComboBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.lblFakultas = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNIP = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.dgnip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgnama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjeniskelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgmatkul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dggrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUAS
        '
        Me.txtUAS.Location = New System.Drawing.Point(313, 216)
        Me.txtUAS.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(43, 20)
        Me.txtUAS.TabIndex = 59
        '
        'txtUTS
        '
        Me.txtUTS.Location = New System.Drawing.Point(224, 216)
        Me.txtUTS.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(43, 20)
        Me.txtUTS.TabIndex = 58
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(131, 216)
        Me.txtTugas.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(42, 20)
        Me.txtTugas.TabIndex = 57
        '
        'lblGRADE
        '
        Me.lblGRADE.AutoSize = True
        Me.lblGRADE.Location = New System.Drawing.Point(370, 218)
        Me.lblGRADE.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGRADE.Name = "lblGRADE"
        Me.lblGRADE.Size = New System.Drawing.Size(57, 13)
        Me.lblGRADE.TabIndex = 56
        Me.lblGRADE.Text = "- GRADE -"
        '
        'lblUAS
        '
        Me.lblUAS.AutoSize = True
        Me.lblUAS.Location = New System.Drawing.Point(280, 218)
        Me.lblUAS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUAS.Name = "lblUAS"
        Me.lblUAS.Size = New System.Drawing.Size(29, 13)
        Me.lblUAS.TabIndex = 55
        Me.lblUAS.Text = "UAS"
        '
        'lblUTS
        '
        Me.lblUTS.AutoSize = True
        Me.lblUTS.Location = New System.Drawing.Point(187, 218)
        Me.lblUTS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUTS.Name = "lblUTS"
        Me.lblUTS.Size = New System.Drawing.Size(29, 13)
        Me.lblUTS.TabIndex = 54
        Me.lblUTS.Text = "UTS"
        '
        'lblTugas
        '
        Me.lblTugas.AutoSize = True
        Me.lblTugas.Location = New System.Drawing.Point(89, 218)
        Me.lblTugas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTugas.Name = "lblTugas"
        Me.lblTugas.Size = New System.Drawing.Size(37, 13)
        Me.lblTugas.TabIndex = 53
        Me.lblTugas.Text = "Tugas"
        '
        'btnNilai
        '
        Me.btnNilai.AutoSize = True
        Me.btnNilai.Location = New System.Drawing.Point(9, 218)
        Me.btnNilai.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnNilai.Name = "btnNilai"
        Me.btnNilai.Size = New System.Drawing.Size(27, 13)
        Me.btnNilai.TabIndex = 52
        Me.btnNilai.Text = "Nilai"
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(30, 255)
        Me.btnProses.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(121, 21)
        Me.btnProses.TabIndex = 51
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'lblJenisKelamin
        '
        Me.lblJenisKelamin.AutoSize = True
        Me.lblJenisKelamin.Location = New System.Drawing.Point(9, 96)
        Me.lblJenisKelamin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJenisKelamin.Name = "lblJenisKelamin"
        Me.lblJenisKelamin.Size = New System.Drawing.Size(71, 13)
        Me.lblJenisKelamin.TabIndex = 50
        Me.lblJenisKelamin.Text = "Jenis Kelamin"
        '
        'rbP
        '
        Me.rbP.AutoSize = True
        Me.rbP.Location = New System.Drawing.Point(181, 93)
        Me.rbP.Margin = New System.Windows.Forms.Padding(2)
        Me.rbP.Name = "rbP"
        Me.rbP.Size = New System.Drawing.Size(79, 17)
        Me.rbP.TabIndex = 49
        Me.rbP.TabStop = True
        Me.rbP.Text = "Perempuan"
        Me.rbP.UseVisualStyleBackColor = True
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.Location = New System.Drawing.Point(92, 93)
        Me.rbL.Margin = New System.Windows.Forms.Padding(2)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(68, 17)
        Me.rbL.TabIndex = 48
        Me.rbL.TabStop = True
        Me.rbL.Text = "Laki-Laki"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'cbJurusan
        '
        Me.cbJurusan.FormattingEnabled = True
        Me.cbJurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.cbJurusan.Location = New System.Drawing.Point(92, 172)
        Me.cbJurusan.Margin = New System.Windows.Forms.Padding(2)
        Me.cbJurusan.Name = "cbJurusan"
        Me.cbJurusan.Size = New System.Drawing.Size(285, 21)
        Me.cbJurusan.TabIndex = 47
        '
        'cbFakultas
        '
        Me.cbFakultas.FormattingEnabled = True
        Me.cbFakultas.Location = New System.Drawing.Point(92, 129)
        Me.cbFakultas.Margin = New System.Windows.Forms.Padding(2)
        Me.cbFakultas.Name = "cbFakultas"
        Me.cbFakultas.Size = New System.Drawing.Size(285, 21)
        Me.cbFakultas.TabIndex = 46
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(92, 56)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(285, 20)
        Me.txtNama.TabIndex = 45
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(92, 19)
        Me.txtNIP.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(285, 20)
        Me.txtNIP.TabIndex = 44
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Location = New System.Drawing.Point(9, 172)
        Me.lblJurusan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(44, 13)
        Me.lblJurusan.TabIndex = 43
        Me.lblJurusan.Text = "Jurusan"
        '
        'lblFakultas
        '
        Me.lblFakultas.AutoSize = True
        Me.lblFakultas.Location = New System.Drawing.Point(9, 134)
        Me.lblFakultas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFakultas.Name = "lblFakultas"
        Me.lblFakultas.Size = New System.Drawing.Size(47, 13)
        Me.lblFakultas.TabIndex = 42
        Me.lblFakultas.Text = "Fakultas"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(9, 60)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(35, 13)
        Me.lblNama.TabIndex = 41
        Me.lblNama.Text = "Nama"
        '
        'lblNIP
        '
        Me.lblNIP.AutoSize = True
        Me.lblNIP.Location = New System.Drawing.Point(9, 21)
        Me.lblNIP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNIP.Name = "lblNIP"
        Me.lblNIP.Size = New System.Drawing.Size(25, 13)
        Me.lblNIP.TabIndex = 40
        Me.lblNIP.Text = "NIP"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnclose)
        Me.Panel3.Controls.Add(Me.btndelete)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Controls.Add(Me.btnnew)
        Me.Panel3.Location = New System.Drawing.Point(10, 292)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(646, 48)
        Me.Panel3.TabIndex = 60
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.LightCoral
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(347, 11)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(279, 24)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(181, 13)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(149, 24)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(89, 13)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(87, 24)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(2, 13)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(82, 24)
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvdata)
        Me.Panel2.Location = New System.Drawing.Point(12, 351)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 116)
        Me.Panel2.TabIndex = 61
        '
        'dgvdata
        '
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgnip, Me.dgnama, Me.dgjeniskelamin, Me.dgjurusan, Me.dgmatkul, Me.dggrade})
        Me.dgvdata.Location = New System.Drawing.Point(7, 2)
        Me.dgvdata.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.RowTemplate.Height = 24
        Me.dgvdata.Size = New System.Drawing.Size(637, 107)
        Me.dgvdata.TabIndex = 4
        '
        'dgnip
        '
        Me.dgnip.HeaderText = "NIP"
        Me.dgnip.Name = "dgnip"
        '
        'dgnama
        '
        Me.dgnama.HeaderText = "Nama"
        Me.dgnama.Name = "dgnama"
        '
        'dgjeniskelamin
        '
        Me.dgjeniskelamin.HeaderText = "Jenis Kelamin"
        Me.dgjeniskelamin.Name = "dgjeniskelamin"
        '
        'dgjurusan
        '
        Me.dgjurusan.HeaderText = "Jurusan"
        Me.dgjurusan.Name = "dgjurusan"
        '
        'dgmatkul
        '
        Me.dgmatkul.HeaderText = "Mata Kuliah"
        Me.dgmatkul.Name = "dgmatkul"
        '
        'dggrade
        '
        Me.dggrade.HeaderText = "GRADE"
        Me.dggrade.Name = "dggrade"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 476)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtUAS)
        Me.Controls.Add(Me.txtUTS)
        Me.Controls.Add(Me.txtTugas)
        Me.Controls.Add(Me.lblGRADE)
        Me.Controls.Add(Me.lblUAS)
        Me.Controls.Add(Me.lblUTS)
        Me.Controls.Add(Me.lblTugas)
        Me.Controls.Add(Me.btnNilai)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.lblJenisKelamin)
        Me.Controls.Add(Me.rbP)
        Me.Controls.Add(Me.rbL)
        Me.Controls.Add(Me.cbJurusan)
        Me.Controls.Add(Me.cbFakultas)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.lblJurusan)
        Me.Controls.Add(Me.lblFakultas)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNIP)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUAS As System.Windows.Forms.TextBox
    Friend WithEvents txtUTS As System.Windows.Forms.TextBox
    Friend WithEvents txtTugas As System.Windows.Forms.TextBox
    Friend WithEvents lblGRADE As System.Windows.Forms.Label
    Friend WithEvents lblUAS As System.Windows.Forms.Label
    Friend WithEvents lblUTS As System.Windows.Forms.Label
    Friend WithEvents lblTugas As System.Windows.Forms.Label
    Friend WithEvents btnNilai As System.Windows.Forms.Label
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents lblJenisKelamin As System.Windows.Forms.Label
    Friend WithEvents rbP As System.Windows.Forms.RadioButton
    Friend WithEvents rbL As System.Windows.Forms.RadioButton
    Friend WithEvents cbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents cbFakultas As System.Windows.Forms.ComboBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNIP As System.Windows.Forms.TextBox
    Friend WithEvents lblJurusan As System.Windows.Forms.Label
    Friend WithEvents lblFakultas As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblNIP As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvdata As System.Windows.Forms.DataGridView
    Friend WithEvents dgnip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgnama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjeniskelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgmatkul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dggrade As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
