namespace TogglToInvoice.WinApp
{
    partial class MainForm
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
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Syncfusion.Windows.Forms.CaptionLabel captionLabel1 = new Syncfusion.Windows.Forms.CaptionLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTogglApiKey = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tbUserName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cbGroupBy = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tbPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbProjekt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateFrom = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.dtpDateTo = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.tbJednotka = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cbTypCeny = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cbDruhSazby = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cbMena = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chbAutoSave = new System.Windows.Forms.CheckBox();
            this.chbAutoChangePeriod = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveSettings = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnImport = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTogglApiKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGroupBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProjekt)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbJednotka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypCeny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDruhSazby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMena)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 399);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbTogglApiKey, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbUserName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.chbAutoChangePeriod, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.chbAutoSave, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(490, 3);
            this.panel3.Name = "panel3";
            this.tableLayoutPanel1.SetRowSpan(this.panel3, 9);
            this.panel3.Size = new System.Drawing.Size(1, 393);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "API key";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "iDoklad";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toggl";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Client Id";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Client Secret";
            // 
            // tbTogglApiKey
            // 
            this.tbTogglApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTogglApiKey.BeforeTouchSize = new System.Drawing.Size(308, 26);
            this.tbTogglApiKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTogglApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTogglApiKey.Location = new System.Drawing.Point(153, 47);
            this.tbTogglApiKey.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tbTogglApiKey.Name = "tbTogglApiKey";
            this.tbTogglApiKey.Size = new System.Drawing.Size(331, 26);
            this.tbTogglApiKey.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.tbTogglApiKey.TabIndex = 0;
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserName.BeforeTouchSize = new System.Drawing.Size(308, 26);
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUserName.Location = new System.Drawing.Point(153, 127);
            this.tbUserName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(331, 26);
            this.tbUserName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.tbUserName.TabIndex = 1;
            // 
            // cbGroupBy
            // 
            this.cbGroupBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGroupBy.BeforeTouchSize = new System.Drawing.Size(308, 28);
            this.cbGroupBy.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.cbGroupBy.DisplayMember = "Text";
            this.cbGroupBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupBy.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.cbGroupBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbGroupBy.Items.AddRange(new object[] {
            "klientů",
            "projektů"});
            this.cbGroupBy.Location = new System.Drawing.Point(125, 288);
            this.cbGroupBy.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.cbGroupBy.Name = "cbGroupBy";
            this.cbGroupBy.Size = new System.Drawing.Size(308, 28);
            this.cbGroupBy.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cbGroupBy.TabIndex = 0;
            this.cbGroupBy.Text = "projektů";
            this.cbGroupBy.UseBackColor = true;
            this.cbGroupBy.UseMetroButtonColor = true;
            this.cbGroupBy.UseMetroColorsInActiveMode = true;
            this.cbGroupBy.ValueMember = "Value";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.BeforeTouchSize = new System.Drawing.Size(308, 26);
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword.Location = new System.Drawing.Point(153, 167);
            this.tbPassword.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(331, 26);
            this.tbPassword.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(3, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Seskupit podle";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(3, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Projekt";
            // 
            // cbProjekt
            // 
            this.cbProjekt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProjekt.BeforeTouchSize = new System.Drawing.Size(308, 28);
            this.cbProjekt.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.cbProjekt.DisplayMember = "Text";
            this.cbProjekt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjekt.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.cbProjekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbProjekt.Location = new System.Drawing.Point(125, 328);
            this.cbProjekt.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.cbProjekt.Name = "cbProjekt";
            this.cbProjekt.Size = new System.Drawing.Size(308, 28);
            this.cbProjekt.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cbProjekt.TabIndex = 0;
            this.cbProjekt.UseBackColor = true;
            this.cbProjekt.UseMetroButtonColor = true;
            this.cbProjekt.UseMetroColorsInActiveMode = true;
            this.cbProjekt.ValueMember = "Value";
            this.cbProjekt.DropDown += new System.EventHandler(this.OnProjektDropDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(492, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 399);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtpDateFrom, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtpDateTo, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbJednotka, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.cbTypCeny, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbProjekt, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.cbDruhSazby, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbMena, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.cbGroupBy, 1, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(436, 399);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Typ ceny";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label8, 2);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(430, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nastavení importu";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(3, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Datum od";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(3, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Datum do";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(3, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Druh sazby";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateFrom.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dtpDateFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dtpDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtpDateFrom.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtpDateFrom.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtpDateFrom.DropDownImage = null;
            this.dtpDateFrom.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpDateFrom.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpDateFrom.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.dtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(125, 126);
            this.dtpDateFrom.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpDateFrom.MinValue = new System.DateTime(((long)(0)));
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.ShowCheckBox = false;
            this.dtpDateFrom.Size = new System.Drawing.Size(308, 28);
            this.dtpDateFrom.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.dtpDateFrom.TabIndex = 2;
            this.dtpDateFrom.ThemedChildControls = true;
            this.dtpDateFrom.ThemesEnabled = true;
            this.dtpDateFrom.UseBorderStyle = false;
            this.dtpDateFrom.UseCurrentCulture = true;
            this.dtpDateFrom.Value = new System.DateTime(2016, 10, 18, 21, 56, 22, 629);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateTo.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dtpDateTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dtpDateTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtpDateTo.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtpDateTo.DropDownImage = null;
            this.dtpDateTo.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpDateTo.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpDateTo.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.dtpDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(125, 166);
            this.dtpDateTo.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpDateTo.MinValue = new System.DateTime(((long)(0)));
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.ShowCheckBox = false;
            this.dtpDateTo.Size = new System.Drawing.Size(308, 28);
            this.dtpDateTo.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.dtpDateTo.TabIndex = 3;
            this.dtpDateTo.ThemedChildControls = true;
            this.dtpDateTo.ThemesEnabled = true;
            this.dtpDateTo.UseBorderStyle = false;
            this.dtpDateTo.UseCurrentCulture = true;
            this.dtpDateTo.Value = new System.DateTime(2016, 10, 18, 21, 56, 22, 629);
            // 
            // tbJednotka
            // 
            this.tbJednotka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJednotka.BeforeTouchSize = new System.Drawing.Size(308, 26);
            this.tbJednotka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbJednotka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbJednotka.Location = new System.Drawing.Point(125, 247);
            this.tbJednotka.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.tbJednotka.Name = "tbJednotka";
            this.tbJednotka.Size = new System.Drawing.Size(308, 26);
            this.tbJednotka.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.tbJednotka.TabIndex = 5;
            // 
            // cbTypCeny
            // 
            this.cbTypCeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTypCeny.BeforeTouchSize = new System.Drawing.Size(308, 28);
            this.cbTypCeny.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.cbTypCeny.DisplayMember = "Text";
            this.cbTypCeny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypCeny.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.cbTypCeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTypCeny.Items.AddRange(new object[] {
            "s daní",
            "bez daně"});
            this.cbTypCeny.Location = new System.Drawing.Point(125, 48);
            this.cbTypCeny.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.cbTypCeny.Name = "cbTypCeny";
            this.cbTypCeny.Size = new System.Drawing.Size(308, 28);
            this.cbTypCeny.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cbTypCeny.TabIndex = 0;
            this.cbTypCeny.Text = "s daní";
            this.cbTypCeny.UseBackColor = true;
            this.cbTypCeny.UseMetroButtonColor = true;
            this.cbTypCeny.UseMetroColorsInActiveMode = true;
            this.cbTypCeny.ValueMember = "Value";
            // 
            // cbDruhSazby
            // 
            this.cbDruhSazby.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDruhSazby.BeforeTouchSize = new System.Drawing.Size(308, 28);
            this.cbDruhSazby.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.cbDruhSazby.DisplayMember = "Text";
            this.cbDruhSazby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDruhSazby.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.cbDruhSazby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDruhSazby.Items.AddRange(new object[] {
            "snížená ",
            "základní",
            "nulová",
            "snížená 2"});
            this.cbDruhSazby.Location = new System.Drawing.Point(125, 88);
            this.cbDruhSazby.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.cbDruhSazby.Name = "cbDruhSazby";
            this.cbDruhSazby.Size = new System.Drawing.Size(308, 28);
            this.cbDruhSazby.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cbDruhSazby.TabIndex = 1;
            this.cbDruhSazby.Text = "snížená ";
            this.cbDruhSazby.UseBackColor = true;
            this.cbDruhSazby.UseMetroButtonColor = true;
            this.cbDruhSazby.UseMetroColorsInActiveMode = true;
            this.cbDruhSazby.ValueMember = "Value";
            // 
            // cbMena
            // 
            this.cbMena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMena.BeforeTouchSize = new System.Drawing.Size(308, 28);
            this.cbMena.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.cbMena.DisplayMember = "Text";
            this.cbMena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMena.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.cbMena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMena.Location = new System.Drawing.Point(125, 208);
            this.cbMena.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.cbMena.Name = "cbMena";
            this.cbMena.Size = new System.Drawing.Size(308, 28);
            this.cbMena.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cbMena.TabIndex = 4;
            this.cbMena.UseBackColor = true;
            this.cbMena.UseMetroButtonColor = true;
            this.cbMena.UseMetroColorsInActiveMode = true;
            this.cbMena.ValueMember = "Value";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(3, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Měna";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(3, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Jednotka";
            // 
            // chbAutoSave
            // 
            this.chbAutoSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chbAutoSave.AutoSize = true;
            this.chbAutoSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbAutoSave.Location = new System.Drawing.Point(153, 248);
            this.chbAutoSave.Name = "chbAutoSave";
            this.chbAutoSave.Size = new System.Drawing.Size(331, 24);
            this.chbAutoSave.TabIndex = 6;
            this.chbAutoSave.Text = "Automaticky ukládat nastavení při importu";
            this.chbAutoSave.UseVisualStyleBackColor = true;
            // 
            // chbAutoChangePeriod
            // 
            this.chbAutoChangePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chbAutoChangePeriod.AutoSize = true;
            this.chbAutoChangePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbAutoChangePeriod.Location = new System.Drawing.Point(153, 288);
            this.chbAutoChangePeriod.Name = "chbAutoChangePeriod";
            this.chbAutoChangePeriod.Size = new System.Drawing.Size(331, 24);
            this.chbAutoChangePeriod.TabIndex = 6;
            this.chbAutoChangePeriod.Text = "Automaticky posunout časový interval";
            this.chbAutoChangePeriod.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(72)))));
            this.panel4.Controls.Add(this.btnSaveSettings);
            this.panel4.Controls.Add(this.btnImport);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 399);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(928, 73);
            this.panel4.TabIndex = 4;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveSettings.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnSaveSettings.BeforeTouchSize = new System.Drawing.Size(150, 34);
            this.btnSaveSettings.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
            this.btnSaveSettings.IsBackStageButton = false;
            this.btnSaveSettings.Location = new System.Drawing.Point(20, 18);
            this.btnSaveSettings.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(150, 34);
            this.btnSaveSettings.TabIndex = 1;
            this.btnSaveSettings.Text = "Uložit nastavení";
            this.btnSaveSettings.UseVisualStyle = true;
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnImport.BeforeTouchSize = new System.Drawing.Size(197, 34);
            this.btnImport.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.IsBackStageButton = false;
            this.btnImport.Location = new System.Drawing.Point(711, 18);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(197, 34);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import faktur vydaných";
            this.btnImport.UseVisualStyle = true;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.OnImportClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionBarHeight = 50;
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionForeColor = System.Drawing.Color.White;
            captionImage1.BackColor = System.Drawing.Color.Transparent;
            captionImage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Location = new System.Drawing.Point(10, 5);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(40, 40);
            this.CaptionImages.Add(captionImage1);
            captionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            captionLabel1.ForeColor = System.Drawing.Color.White;
            captionLabel1.Location = new System.Drawing.Point(60, 12);
            captionLabel1.Name = "CaptionLabel1";
            captionLabel1.Size = new System.Drawing.Size(160, 24);
            captionLabel1.Text = "Toggl to iDoklad";
            this.CaptionLabels.Add(captionLabel1);
            this.ClientSize = new System.Drawing.Size(928, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(940, 460);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OnLoad);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTogglApiKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGroupBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProjekt)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbJednotka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypCeny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDruhSazby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMena)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbTogglApiKey;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbUserName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpDateFrom;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpDateTo;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.Windows.Forms.ButtonAdv btnImport;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbTypCeny;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbDruhSazby;
        private Syncfusion.Windows.Forms.ButtonAdv btnSaveSettings;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbMena;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt tbJednotka;
        private System.Windows.Forms.CheckBox chbAutoSave;
        private System.Windows.Forms.CheckBox chbAutoChangePeriod;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbGroupBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbProjekt;
    }
}

