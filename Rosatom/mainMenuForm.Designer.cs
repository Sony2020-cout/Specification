namespace Rosatom
{
    partial class mainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rosatomDataSet = new Rosatom.RosatomDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.insertSpecButton = new System.Windows.Forms.Button();
            this.editSpecButton = new System.Windows.Forms.Button();
            this.deleteSpecButton = new System.Windows.Forms.Button();
            this.specDGW = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expanseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailSpecBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameSpecTB = new System.Windows.Forms.TextBox();
            this.costSpecTB = new System.Windows.Forms.TextBox();
            this.SpecId1TB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.insertDocButton = new System.Windows.Forms.Button();
            this.deleteDocButton = new System.Windows.Forms.Button();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.docDGV = new System.Windows.Forms.DataGridView();
            this.sPECIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterDocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.specIdTB = new System.Windows.Forms.TextBox();
            this.numDocTB = new System.Windows.Forms.TextBox();
            this.dateDocTB = new System.Windows.Forms.TextBox();
            this.noteDocRTB = new System.Windows.Forms.RichTextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailSpecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logsTableAdapter = new Rosatom.RosatomDataSetTableAdapters.LogsTableAdapter();
            this.detail_SpecTableAdapter = new Rosatom.RosatomDataSetTableAdapters.Detail_SpecTableAdapter();
            this.master_DocTableAdapter = new Rosatom.RosatomDataSetTableAdapters.Master_DocTableAdapter();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosatomDataSet)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailSpecBindingSource1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDocBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailSpecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расчет документов по спецификации";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.helpButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 690);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(484, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Выгрузить Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.backButton.Location = new System.Drawing.Point(814, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(140, 45);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.flowLayoutPanel3.Controls.Add(this.dataGridView3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(18, 389);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(460, 252);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.personDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.logsBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(441, 233);
            this.dataGridView3.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // personDataGridViewTextBoxColumn
            // 
            this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            this.personDataGridViewTextBoxColumn.HeaderText = "Person";
            this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn1
            // 
            this.noteDataGridViewTextBoxColumn1.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn1.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn1.Name = "noteDataGridViewTextBoxColumn1";
            // 
            // logsBindingSource1
            // 
            this.logsBindingSource1.DataMember = "Logs";
            this.logsBindingSource1.DataSource = this.rosatomDataSet;
            // 
            // rosatomDataSet
            // 
            this.rosatomDataSet.DataSetName = "RosatomDataSet";
            this.rosatomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(18, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Логи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Список спецификаций";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(502, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Список документов";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.flowLayoutPanel2.Controls.Add(this.insertSpecButton);
            this.flowLayoutPanel2.Controls.Add(this.editSpecButton);
            this.flowLayoutPanel2.Controls.Add(this.deleteSpecButton);
            this.flowLayoutPanel2.Controls.Add(this.specDGW);
            this.flowLayoutPanel2.Controls.Add(this.nameSpecTB);
            this.flowLayoutPanel2.Controls.Add(this.costSpecTB);
            this.flowLayoutPanel2.Controls.Add(this.SpecId1TB);
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(15, 68);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(463, 283);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // insertSpecButton
            // 
            this.insertSpecButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.insertSpecButton.Location = new System.Drawing.Point(3, 3);
            this.insertSpecButton.Name = "insertSpecButton";
            this.insertSpecButton.Size = new System.Drawing.Size(75, 23);
            this.insertSpecButton.TabIndex = 8;
            this.insertSpecButton.Text = "Добавить";
            this.insertSpecButton.UseVisualStyleBackColor = true;
            this.insertSpecButton.Click += new System.EventHandler(this.insertSpecButton_Click);
            // 
            // editSpecButton
            // 
            this.editSpecButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.editSpecButton.Location = new System.Drawing.Point(84, 3);
            this.editSpecButton.Name = "editSpecButton";
            this.editSpecButton.Size = new System.Drawing.Size(94, 23);
            this.editSpecButton.TabIndex = 7;
            this.editSpecButton.Text = "Редактировать";
            this.editSpecButton.UseVisualStyleBackColor = true;
            this.editSpecButton.Click += new System.EventHandler(this.editSpecButton_Click);
            // 
            // deleteSpecButton
            // 
            this.deleteSpecButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteSpecButton.Location = new System.Drawing.Point(184, 3);
            this.deleteSpecButton.Name = "deleteSpecButton";
            this.deleteSpecButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSpecButton.TabIndex = 6;
            this.deleteSpecButton.Text = "Удалить";
            this.deleteSpecButton.UseVisualStyleBackColor = true;
            this.deleteSpecButton.Click += new System.EventHandler(this.deleteSpecButton_Click);
            // 
            // specDGW
            // 
            this.specDGW.AutoGenerateColumns = false;
            this.specDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.expanseDataGridViewTextBoxColumn,
            this.specidDataGridViewTextBoxColumn});
            this.specDGW.DataSource = this.detailSpecBindingSource1;
            this.specDGW.Location = new System.Drawing.Point(3, 32);
            this.specDGW.Name = "specDGW";
            this.specDGW.Size = new System.Drawing.Size(444, 150);
            this.specDGW.TabIndex = 5;
            this.specDGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.specDGW_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // expanseDataGridViewTextBoxColumn
            // 
            this.expanseDataGridViewTextBoxColumn.DataPropertyName = "expanse";
            this.expanseDataGridViewTextBoxColumn.HeaderText = "expanse";
            this.expanseDataGridViewTextBoxColumn.Name = "expanseDataGridViewTextBoxColumn";
            // 
            // specidDataGridViewTextBoxColumn
            // 
            this.specidDataGridViewTextBoxColumn.DataPropertyName = "spec_id";
            this.specidDataGridViewTextBoxColumn.HeaderText = "spec_id";
            this.specidDataGridViewTextBoxColumn.Name = "specidDataGridViewTextBoxColumn";
            // 
            // detailSpecBindingSource1
            // 
            this.detailSpecBindingSource1.DataMember = "Detail_Spec";
            this.detailSpecBindingSource1.DataSource = this.rosatomDataSet;
            // 
            // nameSpecTB
            // 
            this.nameSpecTB.Location = new System.Drawing.Point(3, 188);
            this.nameSpecTB.Name = "nameSpecTB";
            this.nameSpecTB.Size = new System.Drawing.Size(135, 20);
            this.nameSpecTB.TabIndex = 10;
            this.nameSpecTB.Text = "Введите наименование";
            this.nameSpecTB.Click += new System.EventHandler(this.nameSpecTB_Click);
            // 
            // costSpecTB
            // 
            this.costSpecTB.Location = new System.Drawing.Point(144, 188);
            this.costSpecTB.Name = "costSpecTB";
            this.costSpecTB.Size = new System.Drawing.Size(100, 20);
            this.costSpecTB.TabIndex = 11;
            this.costSpecTB.Text = "Введите сумму";
            this.costSpecTB.Click += new System.EventHandler(this.costSpecTB_Click);
            // 
            // SpecId1TB
            // 
            this.SpecId1TB.Location = new System.Drawing.Point(250, 188);
            this.SpecId1TB.Name = "SpecId1TB";
            this.SpecId1TB.Size = new System.Drawing.Size(132, 20);
            this.SpecId1TB.TabIndex = 12;
            this.SpecId1TB.Text = "Введите номер спец-ии";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.flowLayoutPanel1.Controls.Add(this.insertDocButton);
            this.flowLayoutPanel1.Controls.Add(this.deleteDocButton);
            this.flowLayoutPanel1.Controls.Add(this.amountTB);
            this.flowLayoutPanel1.Controls.Add(this.docDGV);
            this.flowLayoutPanel1.Controls.Add(this.specIdTB);
            this.flowLayoutPanel1.Controls.Add(this.numDocTB);
            this.flowLayoutPanel1.Controls.Add(this.dateDocTB);
            this.flowLayoutPanel1.Controls.Add(this.noteDocRTB);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(505, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(557, 283);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // insertDocButton
            // 
            this.insertDocButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.insertDocButton.Location = new System.Drawing.Point(3, 3);
            this.insertDocButton.Name = "insertDocButton";
            this.insertDocButton.Size = new System.Drawing.Size(75, 23);
            this.insertDocButton.TabIndex = 8;
            this.insertDocButton.Text = "Добавить";
            this.insertDocButton.UseVisualStyleBackColor = true;
            this.insertDocButton.Click += new System.EventHandler(this.insertDocButton_Click);
            // 
            // deleteDocButton
            // 
            this.deleteDocButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteDocButton.Location = new System.Drawing.Point(84, 3);
            this.deleteDocButton.Name = "deleteDocButton";
            this.deleteDocButton.Size = new System.Drawing.Size(75, 23);
            this.deleteDocButton.TabIndex = 6;
            this.deleteDocButton.Text = "Удалить";
            this.deleteDocButton.UseVisualStyleBackColor = true;
            this.deleteDocButton.Click += new System.EventHandler(this.deleteDocButton_Click);
            // 
            // amountTB
            // 
            this.amountTB.Location = new System.Drawing.Point(165, 3);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(138, 20);
            this.amountTB.TabIndex = 12;
            // 
            // docDGV
            // 
            this.docDGV.AutoGenerateColumns = false;
            this.docDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.docDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sPECIDDataGridViewTextBoxColumn1,
            this.numberDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.docDGV.DataSource = this.masterDocBindingSource1;
            this.docDGV.Location = new System.Drawing.Point(3, 32);
            this.docDGV.Name = "docDGV";
            this.docDGV.Size = new System.Drawing.Size(539, 150);
            this.docDGV.TabIndex = 5;
            this.docDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.docDGV_CellClick);
            // 
            // sPECIDDataGridViewTextBoxColumn1
            // 
            this.sPECIDDataGridViewTextBoxColumn1.DataPropertyName = "SPEC_ID";
            this.sPECIDDataGridViewTextBoxColumn1.HeaderText = "SPEC_ID";
            this.sPECIDDataGridViewTextBoxColumn1.Name = "sPECIDDataGridViewTextBoxColumn1";
            this.sPECIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "createdAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "createdAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // masterDocBindingSource1
            // 
            this.masterDocBindingSource1.DataMember = "Master_Doc";
            this.masterDocBindingSource1.DataSource = this.rosatomDataSet;
            // 
            // specIdTB
            // 
            this.specIdTB.Location = new System.Drawing.Point(3, 188);
            this.specIdTB.Name = "specIdTB";
            this.specIdTB.Size = new System.Drawing.Size(136, 20);
            this.specIdTB.TabIndex = 11;
            this.specIdTB.Text = "Введите номер спец-ии";
            // 
            // numDocTB
            // 
            this.numDocTB.Location = new System.Drawing.Point(145, 188);
            this.numDocTB.Name = "numDocTB";
            this.numDocTB.Size = new System.Drawing.Size(100, 20);
            this.numDocTB.TabIndex = 9;
            this.numDocTB.Text = "Введите номер";
            this.numDocTB.Click += new System.EventHandler(this.numDocTB_Click);
            // 
            // dateDocTB
            // 
            this.dateDocTB.Location = new System.Drawing.Point(251, 188);
            this.dateDocTB.Name = "dateDocTB";
            this.dateDocTB.Size = new System.Drawing.Size(100, 20);
            this.dateDocTB.TabIndex = 9;
            this.dateDocTB.Text = "Введите дату";
            this.dateDocTB.Click += new System.EventHandler(this.dateDocTB_Click);
            // 
            // noteDocRTB
            // 
            this.noteDocRTB.Location = new System.Drawing.Point(357, 188);
            this.noteDocRTB.Name = "noteDocRTB";
            this.noteDocRTB.Size = new System.Drawing.Size(185, 71);
            this.noteDocRTB.TabIndex = 10;
            this.noteDocRTB.Text = "Введите примечание";
            this.noteDocRTB.Click += new System.EventHandler(this.noteDocRTB_Click);
            // 
            // closeButton
            // 
            this.closeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.closeButton.Location = new System.Drawing.Point(960, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(139, 45);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.helpButton.Location = new System.Drawing.Point(669, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(139, 45);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "Справка";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // detail_SpecTableAdapter
            // 
            this.detail_SpecTableAdapter.ClearBeforeFill = true;
            // 
            // master_DocTableAdapter
            // 
            this.master_DocTableAdapter.ClearBeforeFill = true;
            // 
            // mainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 690);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainMenuForm";
            this.Text = "ВНИИА Росатом";
            this.Load += new System.EventHandler(this.mainMenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosatomDataSet)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailSpecBindingSource1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDocBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailSpecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button deleteSpecButton;
        private System.Windows.Forms.Button editSpecButton;
        private System.Windows.Forms.Button insertSpecButton;
        private System.Windows.Forms.DataGridView specDGW;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button deleteDocButton;
        private System.Windows.Forms.Button insertDocButton;
        private System.Windows.Forms.DataGridView docDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numDocTB;
        private System.Windows.Forms.TextBox dateDocTB;
        private System.Windows.Forms.RichTextBox noteDocRTB;
        private System.Windows.Forms.TextBox nameSpecTB;
        private System.Windows.Forms.TextBox costSpecTB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private RosatomDataSetTableAdapters.LogsTableAdapter logsTableAdapter;
        private System.Windows.Forms.BindingSource detailBindingSource1;
      
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource detailSpecBindingSource;
        private RosatomDataSetTableAdapters.Detail_SpecTableAdapter detail_SpecTableAdapter;
        private System.Windows.Forms.BindingSource masterDocBindingSource;
        private RosatomDataSetTableAdapters.Master_DocTableAdapter master_DocTableAdapter;
        private System.Windows.Forms.TextBox specIdTB;
        private System.Windows.Forms.TextBox SpecId1TB;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expanseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detailSpecBindingSource1;
        private RosatomDataSet rosatomDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPECIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource masterDocBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource logsBindingSource1;
        private System.Windows.Forms.TextBox amountTB;
    }
}