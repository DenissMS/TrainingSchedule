namespace TrainingSchedule
{
    partial class ExerciseEditForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lExerciseNumberOfApproaches = new System.Windows.Forms.Label();
            this.lExerciseNumberOfRepetitions = new System.Windows.Forms.Label();
            this.lExerciseMuscleGroup = new System.Windows.Forms.Label();
            this.lExerciseType = new System.Windows.Forms.Label();
            this.lExerciseName = new System.Windows.Forms.Label();
            this.tbExerciseName = new System.Windows.Forms.TextBox();
            this.cmbExerciseType = new System.Windows.Forms.ComboBox();
            this.cmbExerciseMuscleGroup = new System.Windows.Forms.ComboBox();
            this.nudNumberOfRepetitions = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfApproaches = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfRepetitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfApproaches)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lExerciseNumberOfApproaches
            // 
            this.lExerciseNumberOfApproaches.AutoSize = true;
            this.lExerciseNumberOfApproaches.Location = new System.Drawing.Point(23, 119);
            this.lExerciseNumberOfApproaches.Name = "lExerciseNumberOfApproaches";
            this.lExerciseNumberOfApproaches.Size = new System.Drawing.Size(57, 26);
            this.lExerciseNumberOfApproaches.TabIndex = 7;
            this.lExerciseNumberOfApproaches.Text = "Кол-во \r\nподходов:";
            // 
            // lExerciseNumberOfRepetitions
            // 
            this.lExerciseNumberOfRepetitions.AutoSize = true;
            this.lExerciseNumberOfRepetitions.Location = new System.Drawing.Point(23, 84);
            this.lExerciseNumberOfRepetitions.Name = "lExerciseNumberOfRepetitions";
            this.lExerciseNumberOfRepetitions.Size = new System.Drawing.Size(57, 26);
            this.lExerciseNumberOfRepetitions.TabIndex = 8;
            this.lExerciseNumberOfRepetitions.Text = "Кол-во \r\nповторов:";
            // 
            // lExerciseMuscleGroup
            // 
            this.lExerciseMuscleGroup.AutoSize = true;
            this.lExerciseMuscleGroup.Location = new System.Drawing.Point(2, 59);
            this.lExerciseMuscleGroup.Name = "lExerciseMuscleGroup";
            this.lExerciseMuscleGroup.Size = new System.Drawing.Size(78, 13);
            this.lExerciseMuscleGroup.TabIndex = 9;
            this.lExerciseMuscleGroup.Text = "Группа мышц:";
            // 
            // lExerciseType
            // 
            this.lExerciseType.AutoSize = true;
            this.lExerciseType.Location = new System.Drawing.Point(51, 34);
            this.lExerciseType.Name = "lExerciseType";
            this.lExerciseType.Size = new System.Drawing.Size(29, 13);
            this.lExerciseType.TabIndex = 10;
            this.lExerciseType.Text = "Тип:";
            // 
            // lExerciseName
            // 
            this.lExerciseName.AutoSize = true;
            this.lExerciseName.Location = new System.Drawing.Point(20, 9);
            this.lExerciseName.Name = "lExerciseName";
            this.lExerciseName.Size = new System.Drawing.Size(60, 13);
            this.lExerciseName.TabIndex = 11;
            this.lExerciseName.Text = "Название:";
            // 
            // tbExerciseName
            // 
            this.tbExerciseName.Location = new System.Drawing.Point(86, 9);
            this.tbExerciseName.Name = "tbExerciseName";
            this.tbExerciseName.Size = new System.Drawing.Size(82, 20);
            this.tbExerciseName.TabIndex = 12;
            // 
            // cmbExerciseType
            // 
            this.cmbExerciseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExerciseType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbExerciseType.FormattingEnabled = true;
            this.cmbExerciseType.Location = new System.Drawing.Point(86, 34);
            this.cmbExerciseType.Name = "cmbExerciseType";
            this.cmbExerciseType.Size = new System.Drawing.Size(82, 21);
            this.cmbExerciseType.TabIndex = 13;
            // 
            // cmbExerciseMuscleGroup
            // 
            this.cmbExerciseMuscleGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExerciseMuscleGroup.FormattingEnabled = true;
            this.cmbExerciseMuscleGroup.Location = new System.Drawing.Point(86, 61);
            this.cmbExerciseMuscleGroup.Name = "cmbExerciseMuscleGroup";
            this.cmbExerciseMuscleGroup.Size = new System.Drawing.Size(82, 21);
            this.cmbExerciseMuscleGroup.TabIndex = 14;
            // 
            // nudNumberOfRepetitions
            // 
            this.nudNumberOfRepetitions.Location = new System.Drawing.Point(86, 89);
            this.nudNumberOfRepetitions.Name = "nudNumberOfRepetitions";
            this.nudNumberOfRepetitions.Size = new System.Drawing.Size(82, 20);
            this.nudNumberOfRepetitions.TabIndex = 15;
            // 
            // nudNumberOfApproaches
            // 
            this.nudNumberOfApproaches.Location = new System.Drawing.Point(86, 125);
            this.nudNumberOfApproaches.Name = "nudNumberOfApproaches";
            this.nudNumberOfApproaches.Size = new System.Drawing.Size(82, 20);
            this.nudNumberOfApproaches.TabIndex = 16;
            // 
            // ExerciseEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 191);
            this.Controls.Add(this.nudNumberOfApproaches);
            this.Controls.Add(this.nudNumberOfRepetitions);
            this.Controls.Add(this.cmbExerciseMuscleGroup);
            this.Controls.Add(this.cmbExerciseType);
            this.Controls.Add(this.tbExerciseName);
            this.Controls.Add(this.lExerciseNumberOfApproaches);
            this.Controls.Add(this.lExerciseNumberOfRepetitions);
            this.Controls.Add(this.lExerciseMuscleGroup);
            this.Controls.Add(this.lExerciseType);
            this.Controls.Add(this.lExerciseName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExerciseEditForm";
            this.Text = "ExerciseEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfRepetitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfApproaches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lExerciseNumberOfApproaches;
        private System.Windows.Forms.Label lExerciseNumberOfRepetitions;
        private System.Windows.Forms.Label lExerciseMuscleGroup;
        private System.Windows.Forms.Label lExerciseType;
        private System.Windows.Forms.Label lExerciseName;
        private System.Windows.Forms.TextBox tbExerciseName;
        private System.Windows.Forms.ComboBox cmbExerciseType;
        private System.Windows.Forms.ComboBox cmbExerciseMuscleGroup;
        private System.Windows.Forms.NumericUpDown nudNumberOfRepetitions;
        private System.Windows.Forms.NumericUpDown nudNumberOfApproaches;
    }
}