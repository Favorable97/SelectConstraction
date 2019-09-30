namespace SelectConstraction {
    partial class ReportForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ReportTable = new System.Windows.Forms.DataGridView();
            this.ImportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportTable
            // 
            this.ReportTable.AllowUserToAddRows = false;
            this.ReportTable.AllowUserToDeleteRows = false;
            this.ReportTable.AllowUserToResizeRows = false;
            this.ReportTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ReportTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ReportTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportTable.Location = new System.Drawing.Point(0, 0);
            this.ReportTable.Name = "ReportTable";
            this.ReportTable.Size = new System.Drawing.Size(935, 508);
            this.ReportTable.TabIndex = 0;
            // 
            // ImportExcel
            // 
            this.ImportExcel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportExcel.Location = new System.Drawing.Point(0, 514);
            this.ImportExcel.Name = "ImportExcel";
            this.ImportExcel.Size = new System.Drawing.Size(162, 59);
            this.ImportExcel.TabIndex = 1;
            this.ImportExcel.Text = "Импортировать в Excel";
            this.ImportExcel.UseVisualStyleBackColor = true;
            this.ImportExcel.Click += new System.EventHandler(this.ImportExcel_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 616);
            this.Controls.Add(this.ImportExcel);
            this.Controls.Add(this.ReportTable);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportTable;
        private System.Windows.Forms.Button ImportExcel;
    }
}