namespace TrainingSchedule.Forms
{
    partial class UserWeightStatisticsForm
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
            this.dgvUserStatistics = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserStatistics
            // 
            this.dgvUserStatistics.AllowUserToAddRows = false;
            this.dgvUserStatistics.AllowUserToDeleteRows = false;
            this.dgvUserStatistics.AllowUserToOrderColumns = true;
            this.dgvUserStatistics.AllowUserToResizeColumns = false;
            this.dgvUserStatistics.AllowUserToResizeRows = false;
            this.dgvUserStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserStatistics.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvUserStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Weight});
            this.dgvUserStatistics.Location = new System.Drawing.Point(13, 13);
            this.dgvUserStatistics.Name = "dgvUserStatistics";
            this.dgvUserStatistics.ReadOnly = true;
            this.dgvUserStatistics.RowHeadersVisible = false;
            this.dgvUserStatistics.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUserStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUserStatistics.Size = new System.Drawing.Size(259, 206);
            this.dgvUserStatistics.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Weight.HeaderText = "Вес";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // UserWeightStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvUserStatistics);
            this.Name = "UserWeightStatisticsForm";
            this.Text = "Статистика веса";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserStatistics;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
    }
}