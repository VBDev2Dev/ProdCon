<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWork
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.nudWorkItems = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudCnsumers = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prgWorking = New System.Windows.Forms.ProgressBar()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkingDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TotalTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcessedCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumerProcessingViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.nudWorkItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCnsumers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsumerProcessingViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(120, 132)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'nudWorkItems
        '
        Me.nudWorkItems.Location = New System.Drawing.Point(75, 41)
        Me.nudWorkItems.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudWorkItems.Name = "nudWorkItems"
        Me.nudWorkItems.Size = New System.Drawing.Size(120, 20)
        Me.nudWorkItems.TabIndex = 1
        Me.nudWorkItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudWorkItems.Value = New Decimal(New Integer() {800, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Work Items"
        '
        'nudCnsumers
        '
        Me.nudCnsumers.Location = New System.Drawing.Point(75, 85)
        Me.nudCnsumers.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudCnsumers.Name = "nudCnsumers"
        Me.nudCnsumers.Size = New System.Drawing.Size(120, 20)
        Me.nudCnsumers.TabIndex = 1
        Me.nudCnsumers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCnsumers.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Consumers"
        '
        'prgWorking
        '
        Me.prgWorking.Location = New System.Drawing.Point(11, 192)
        Me.prgWorking.Name = "prgWorking"
        Me.prgWorking.Size = New System.Drawing.Size(282, 23)
        Me.prgWorking.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.prgWorking.TabIndex = 3
        Me.prgWorking.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.WorkingDataGridViewCheckBoxColumn, Me.TotalTimeDataGridViewTextBoxColumn, Me.ProcessedCountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ConsumerProcessingViewBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(332, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(615, 518)
        Me.DataGridView1.TabIndex = 4
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WorkingDataGridViewCheckBoxColumn
        '
        Me.WorkingDataGridViewCheckBoxColumn.DataPropertyName = "Working"
        Me.WorkingDataGridViewCheckBoxColumn.HeaderText = "Working"
        Me.WorkingDataGridViewCheckBoxColumn.Name = "WorkingDataGridViewCheckBoxColumn"
        Me.WorkingDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'TotalTimeDataGridViewTextBoxColumn
        '
        Me.TotalTimeDataGridViewTextBoxColumn.DataPropertyName = "TotalTime"
        Me.TotalTimeDataGridViewTextBoxColumn.HeaderText = "Total Time"
        Me.TotalTimeDataGridViewTextBoxColumn.Name = "TotalTimeDataGridViewTextBoxColumn"
        Me.TotalTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProcessedCountDataGridViewTextBoxColumn
        '
        Me.ProcessedCountDataGridViewTextBoxColumn.DataPropertyName = "ProcessedCount"
        Me.ProcessedCountDataGridViewTextBoxColumn.HeaderText = "Processed Count"
        Me.ProcessedCountDataGridViewTextBoxColumn.Name = "ProcessedCountDataGridViewTextBoxColumn"
        Me.ProcessedCountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConsumerProcessingViewBindingSource
        '
        Me.ConsumerProcessingViewBindingSource.DataSource = GetType(ProdCon.ConsumerProcessingView)
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(8, 246)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(307, 308)
        Me.lblStatus.TabIndex = 5
        '
        'frmWork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 575)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.prgWorking)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudCnsumers)
        Me.Controls.Add(Me.nudWorkItems)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmWork"
        Me.Text = "frmWork"
        CType(Me.nudWorkItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCnsumers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsumerProcessingViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As Button
    Friend WithEvents nudWorkItems As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents nudCnsumers As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents prgWorking As ProgressBar
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WorkingDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TotalTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProcessedCountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConsumerProcessingViewBindingSource As BindingSource
    Friend WithEvents lblStatus As Label
End Class
