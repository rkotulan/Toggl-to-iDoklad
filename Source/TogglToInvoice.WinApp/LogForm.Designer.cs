namespace TogglToInvoice.WinApp
{
    partial class LogForm
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
            Syncfusion.Windows.Forms.CaptionLabel captionLabel1 = new Syncfusion.Windows.Forms.CaptionLabel();
            this.ReportGrid = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.gcDate = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
            this.gcSeverity = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
            this.gcMessage = new Syncfusion.Windows.Forms.Grid.GridBoundColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportGrid
            // 
            this.ReportGrid.AllowDragSelectedCols = true;
            this.ReportGrid.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.ReportGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportGrid.EnableAddNew = false;
            this.ReportGrid.EnableEdit = false;
            this.ReportGrid.EnableRemove = false;
            this.ReportGrid.GridBoundColumns.AddRange(new Syncfusion.Windows.Forms.Grid.GridBoundColumn[] {
            this.gcDate,
            this.gcSeverity,
            this.gcMessage});
            this.ReportGrid.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.ReportGrid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.ReportGrid.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.ReportGrid.Location = new System.Drawing.Point(0, 0);
            this.ReportGrid.Name = "ReportGrid";
            this.ReportGrid.OptimizeInsertRemoveCells = true;
            this.ReportGrid.Properties.ForceImmediateRepaint = false;
            this.ReportGrid.Properties.MarkColHeader = false;
            this.ReportGrid.Properties.MarkRowHeader = false;
            this.ReportGrid.Properties.ThemedHeader = true;
            this.ReportGrid.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.ReportGrid.Size = new System.Drawing.Size(746, 551);
            this.ReportGrid.SmartSizeBox = false;
            this.ReportGrid.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.ReportGrid.TabIndex = 0;
            this.ReportGrid.Text = "ReportGrid";
            this.ReportGrid.ThemesEnabled = true;
            this.ReportGrid.UseListChangedEvent = true;
            this.ReportGrid.UseRightToLeftCompatibleTextBox = true;
            // 
            // gcDate
            // 
            this.gcDate.HeaderText = "Datum";
            this.gcDate.Hidden = false;
            this.gcDate.MappingName = "Date";
            this.gcDate.Position = 1;
            this.gcDate.ReadOnly = true;
            this.gcDate.StyleInfo.CellType = "Static";
            this.gcDate.StyleInfo.Format = "G";
            this.gcDate.Width = 200;
            // 
            // gcSeverity
            // 
            this.gcSeverity.HeaderText = "Typ zprávy";
            this.gcSeverity.Hidden = false;
            this.gcSeverity.MappingName = "LogSeverity";
            this.gcSeverity.Position = 2;
            this.gcSeverity.ReadOnly = true;
            this.gcSeverity.Width = 150;
            // 
            // gcMessage
            // 
            this.gcMessage.HeaderText = "Zpráva";
            this.gcMessage.Hidden = false;
            this.gcMessage.MappingName = "Message";
            this.gcMessage.Position = 3;
            this.gcMessage.ReadOnly = true;
            this.gcMessage.StyleInfo.AutoSize = true;
            this.gcMessage.Width = -1;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionBarHeight = 30;
            captionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            captionLabel1.ForeColor = System.Drawing.Color.White;
            captionLabel1.Location = new System.Drawing.Point(10, 4);
            captionLabel1.Name = "lblCaption";
            captionLabel1.Text = "Výsledky importu";
            this.CaptionLabels.Add(captionLabel1);
            this.ClientSize = new System.Drawing.Size(746, 551);
            this.Controls.Add(this.ReportGrid);
            this.Name = "LogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ReportGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid ReportGrid;
        private Syncfusion.Windows.Forms.Grid.GridBoundColumn gcDate;
        private Syncfusion.Windows.Forms.Grid.GridBoundColumn gcSeverity;
        private Syncfusion.Windows.Forms.Grid.GridBoundColumn gcMessage;
    }
}