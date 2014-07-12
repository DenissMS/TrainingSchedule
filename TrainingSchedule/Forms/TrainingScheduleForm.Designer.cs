namespace TrainingSchedule
{
    partial class TrainingScheduleForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.mcTrainingCalendar = new System.Windows.Forms.MonthCalendar();
            this.lUserName = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.lWeight = new System.Windows.Forms.Label();
            this.lHeight = new System.Windows.Forms.Label();
            this.lExerciseName = new System.Windows.Forms.Label();
            this.lUserHeightValue = new System.Windows.Forms.Label();
            this.lUserWeightValue = new System.Windows.Forms.Label();
            this.lbExercisesList = new System.Windows.Forms.ListBox();
            this.gbExercises = new System.Windows.Forms.GroupBox();
            this.lExerciseNumberOfApproachesValue = new System.Windows.Forms.Label();
            this.lExerciseNumberOfRepetitionsValue = new System.Windows.Forms.Label();
            this.lExerciseMuscleGroupValue = new System.Windows.Forms.Label();
            this.lExerciseTypeValue = new System.Windows.Forms.Label();
            this.lExerciseNameValue = new System.Windows.Forms.Label();
            this.lExerciseNumberOfApproaches = new System.Windows.Forms.Label();
            this.lExerciseNumberOfRepetitions = new System.Windows.Forms.Label();
            this.lExerciseMuscleGroup = new System.Windows.Forms.Label();
            this.lExerciseType = new System.Windows.Forms.Label();
            this.btnRemoveExercise = new System.Windows.Forms.Button();
            this.btnCreateTraining = new System.Windows.Forms.Button();
            this.btnEditExercise = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.gbExercises.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Enabled = false;
            this.btnAddExercise.Location = new System.Drawing.Point(402, 206);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(75, 23);
            this.btnAddExercise.TabIndex = 0;
            this.btnAddExercise.Text = "Добавить";
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // mcTrainingCalendar
            // 
            this.mcTrainingCalendar.BackColor = System.Drawing.Color.White;
            this.mcTrainingCalendar.Enabled = false;
            this.mcTrainingCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(250)));
            this.mcTrainingCalendar.Location = new System.Drawing.Point(402, 9);
            this.mcTrainingCalendar.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.mcTrainingCalendar.Name = "mcTrainingCalendar";
            this.mcTrainingCalendar.ShowToday = false;
            this.mcTrainingCalendar.TabIndex = 1;
            this.mcTrainingCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcTrainingCalendar_DateSelected);
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUserName.Location = new System.Drawing.Point(13, 13);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(26, 25);
            this.lUserName.TabIndex = 2;
            this.lUserName.Text = "--";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(483, 206);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(83, 23);
            this.btnEditProfile.TabIndex = 3;
            this.btnEditProfile.Text = "Профиль";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // lWeight
            // 
            this.lWeight.AutoSize = true;
            this.lWeight.Location = new System.Drawing.Point(17, 72);
            this.lWeight.Name = "lWeight";
            this.lWeight.Size = new System.Drawing.Size(29, 13);
            this.lWeight.TabIndex = 4;
            this.lWeight.Text = "Вес:";
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(17, 47);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(34, 13);
            this.lHeight.TabIndex = 5;
            this.lHeight.Text = "Рост:";
            // 
            // lExerciseName
            // 
            this.lExerciseName.AutoSize = true;
            this.lExerciseName.Location = new System.Drawing.Point(24, 26);
            this.lExerciseName.Name = "lExerciseName";
            this.lExerciseName.Size = new System.Drawing.Size(60, 13);
            this.lExerciseName.TabIndex = 6;
            this.lExerciseName.Text = "Название:";
            // 
            // lUserHeightValue
            // 
            this.lUserHeightValue.AutoSize = true;
            this.lUserHeightValue.Location = new System.Drawing.Point(57, 47);
            this.lUserHeightValue.Name = "lUserHeightValue";
            this.lUserHeightValue.Size = new System.Drawing.Size(13, 13);
            this.lUserHeightValue.TabIndex = 7;
            this.lUserHeightValue.Text = "--";
            // 
            // lUserWeightValue
            // 
            this.lUserWeightValue.AutoSize = true;
            this.lUserWeightValue.Location = new System.Drawing.Point(57, 72);
            this.lUserWeightValue.Name = "lUserWeightValue";
            this.lUserWeightValue.Size = new System.Drawing.Size(13, 13);
            this.lUserWeightValue.TabIndex = 8;
            this.lUserWeightValue.Text = "--";
            // 
            // lbExercisesList
            // 
            this.lbExercisesList.Enabled = false;
            this.lbExercisesList.FormattingEnabled = true;
            this.lbExercisesList.Location = new System.Drawing.Point(232, 9);
            this.lbExercisesList.Name = "lbExercisesList";
            this.lbExercisesList.Size = new System.Drawing.Size(158, 277);
            this.lbExercisesList.TabIndex = 10;
            this.lbExercisesList.SelectedIndexChanged += new System.EventHandler(this.lbExercisesList_SelectedIndexChanged);
            // 
            // gbExercises
            // 
            this.gbExercises.Controls.Add(this.lExerciseNumberOfApproachesValue);
            this.gbExercises.Controls.Add(this.lExerciseNumberOfRepetitionsValue);
            this.gbExercises.Controls.Add(this.lExerciseMuscleGroupValue);
            this.gbExercises.Controls.Add(this.lExerciseTypeValue);
            this.gbExercises.Controls.Add(this.lExerciseNameValue);
            this.gbExercises.Controls.Add(this.lExerciseNumberOfApproaches);
            this.gbExercises.Controls.Add(this.lExerciseNumberOfRepetitions);
            this.gbExercises.Controls.Add(this.lExerciseMuscleGroup);
            this.gbExercises.Controls.Add(this.lExerciseType);
            this.gbExercises.Controls.Add(this.lExerciseName);
            this.gbExercises.Location = new System.Drawing.Point(12, 101);
            this.gbExercises.Name = "gbExercises";
            this.gbExercises.Size = new System.Drawing.Size(214, 185);
            this.gbExercises.TabIndex = 11;
            this.gbExercises.TabStop = false;
            this.gbExercises.Text = "Упражнение";
            // 
            // lExerciseNumberOfApproachesValue
            // 
            this.lExerciseNumberOfApproachesValue.AutoSize = true;
            this.lExerciseNumberOfApproachesValue.Location = new System.Drawing.Point(90, 149);
            this.lExerciseNumberOfApproachesValue.Name = "lExerciseNumberOfApproachesValue";
            this.lExerciseNumberOfApproachesValue.Size = new System.Drawing.Size(13, 13);
            this.lExerciseNumberOfApproachesValue.TabIndex = 11;
            this.lExerciseNumberOfApproachesValue.Text = "--";
            // 
            // lExerciseNumberOfRepetitionsValue
            // 
            this.lExerciseNumberOfRepetitionsValue.AutoSize = true;
            this.lExerciseNumberOfRepetitionsValue.Location = new System.Drawing.Point(90, 114);
            this.lExerciseNumberOfRepetitionsValue.Name = "lExerciseNumberOfRepetitionsValue";
            this.lExerciseNumberOfRepetitionsValue.Size = new System.Drawing.Size(13, 13);
            this.lExerciseNumberOfRepetitionsValue.TabIndex = 10;
            this.lExerciseNumberOfRepetitionsValue.Text = "--";
            // 
            // lExerciseMuscleGroupValue
            // 
            this.lExerciseMuscleGroupValue.AutoSize = true;
            this.lExerciseMuscleGroupValue.Location = new System.Drawing.Point(90, 76);
            this.lExerciseMuscleGroupValue.Name = "lExerciseMuscleGroupValue";
            this.lExerciseMuscleGroupValue.Size = new System.Drawing.Size(13, 13);
            this.lExerciseMuscleGroupValue.TabIndex = 9;
            this.lExerciseMuscleGroupValue.Text = "--";
            // 
            // lExerciseTypeValue
            // 
            this.lExerciseTypeValue.AutoSize = true;
            this.lExerciseTypeValue.Location = new System.Drawing.Point(90, 51);
            this.lExerciseTypeValue.Name = "lExerciseTypeValue";
            this.lExerciseTypeValue.Size = new System.Drawing.Size(13, 13);
            this.lExerciseTypeValue.TabIndex = 8;
            this.lExerciseTypeValue.Text = "--";
            // 
            // lExerciseNameValue
            // 
            this.lExerciseNameValue.AutoSize = true;
            this.lExerciseNameValue.Location = new System.Drawing.Point(90, 26);
            this.lExerciseNameValue.Name = "lExerciseNameValue";
            this.lExerciseNameValue.Size = new System.Drawing.Size(13, 13);
            this.lExerciseNameValue.TabIndex = 7;
            this.lExerciseNameValue.Text = "--";
            // 
            // lExerciseNumberOfApproaches
            // 
            this.lExerciseNumberOfApproaches.AutoSize = true;
            this.lExerciseNumberOfApproaches.Location = new System.Drawing.Point(27, 136);
            this.lExerciseNumberOfApproaches.Name = "lExerciseNumberOfApproaches";
            this.lExerciseNumberOfApproaches.Size = new System.Drawing.Size(57, 26);
            this.lExerciseNumberOfApproaches.TabIndex = 6;
            this.lExerciseNumberOfApproaches.Text = "Кол-во \r\nподходов:";
            // 
            // lExerciseNumberOfRepetitions
            // 
            this.lExerciseNumberOfRepetitions.AutoSize = true;
            this.lExerciseNumberOfRepetitions.Location = new System.Drawing.Point(27, 101);
            this.lExerciseNumberOfRepetitions.Name = "lExerciseNumberOfRepetitions";
            this.lExerciseNumberOfRepetitions.Size = new System.Drawing.Size(57, 26);
            this.lExerciseNumberOfRepetitions.TabIndex = 6;
            this.lExerciseNumberOfRepetitions.Text = "Кол-во \r\nповторов:";
            // 
            // lExerciseMuscleGroup
            // 
            this.lExerciseMuscleGroup.AutoSize = true;
            this.lExerciseMuscleGroup.Location = new System.Drawing.Point(6, 76);
            this.lExerciseMuscleGroup.Name = "lExerciseMuscleGroup";
            this.lExerciseMuscleGroup.Size = new System.Drawing.Size(78, 13);
            this.lExerciseMuscleGroup.TabIndex = 6;
            this.lExerciseMuscleGroup.Text = "Группа мышц:";
            // 
            // lExerciseType
            // 
            this.lExerciseType.AutoSize = true;
            this.lExerciseType.Location = new System.Drawing.Point(55, 51);
            this.lExerciseType.Name = "lExerciseType";
            this.lExerciseType.Size = new System.Drawing.Size(29, 13);
            this.lExerciseType.TabIndex = 6;
            this.lExerciseType.Text = "Тип:";
            // 
            // btnRemoveExercise
            // 
            this.btnRemoveExercise.Enabled = false;
            this.btnRemoveExercise.Location = new System.Drawing.Point(402, 264);
            this.btnRemoveExercise.Name = "btnRemoveExercise";
            this.btnRemoveExercise.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveExercise.TabIndex = 12;
            this.btnRemoveExercise.Text = "Удалить";
            this.btnRemoveExercise.UseVisualStyleBackColor = true;
            this.btnRemoveExercise.Click += new System.EventHandler(this.btnRemoveExercise_Click);
            // 
            // btnCreateTraining
            // 
            this.btnCreateTraining.Enabled = false;
            this.btnCreateTraining.Location = new System.Drawing.Point(402, 177);
            this.btnCreateTraining.Name = "btnCreateTraining";
            this.btnCreateTraining.Size = new System.Drawing.Size(164, 23);
            this.btnCreateTraining.TabIndex = 13;
            this.btnCreateTraining.Text = "Создать тренировку";
            this.btnCreateTraining.UseVisualStyleBackColor = true;
            this.btnCreateTraining.Click += new System.EventHandler(this.btnCreateTraining_Click);
            // 
            // btnEditExercise
            // 
            this.btnEditExercise.Enabled = false;
            this.btnEditExercise.Location = new System.Drawing.Point(402, 235);
            this.btnEditExercise.Name = "btnEditExercise";
            this.btnEditExercise.Size = new System.Drawing.Size(75, 23);
            this.btnEditExercise.TabIndex = 14;
            this.btnEditExercise.Text = "Изменить";
            this.btnEditExercise.UseVisualStyleBackColor = true;
            this.btnEditExercise.Click += new System.EventHandler(this.btnEditExercise_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Enabled = false;
            this.btnClearAll.Location = new System.Drawing.Point(483, 264);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(83, 23);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Очистить все";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Enabled = false;
            this.btnStatistics.Location = new System.Drawing.Point(483, 235);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(83, 23);
            this.btnStatistics.TabIndex = 16;
            this.btnStatistics.Text = "Статистика";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // TrainingScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 297);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnEditExercise);
            this.Controls.Add(this.btnCreateTraining);
            this.Controls.Add(this.btnRemoveExercise);
            this.Controls.Add(this.gbExercises);
            this.Controls.Add(this.lbExercisesList);
            this.Controls.Add(this.lUserWeightValue);
            this.Controls.Add(this.lUserHeightValue);
            this.Controls.Add(this.lHeight);
            this.Controls.Add(this.lWeight);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.mcTrainingCalendar);
            this.Controls.Add(this.btnAddExercise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TrainingScheduleForm";
            this.Text = "График и схемы тренировок";
            this.gbExercises.ResumeLayout(false);
            this.gbExercises.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.MonthCalendar mcTrainingCalendar;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Label lWeight;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.Label lExerciseName;
        private System.Windows.Forms.Label lUserHeightValue;
        private System.Windows.Forms.Label lUserWeightValue;
        private System.Windows.Forms.ListBox lbExercisesList;
        private System.Windows.Forms.GroupBox gbExercises;
        private System.Windows.Forms.Label lExerciseMuscleGroup;
        private System.Windows.Forms.Label lExerciseType;
        private System.Windows.Forms.Label lExerciseNumberOfRepetitions;
        private System.Windows.Forms.Label lExerciseNumberOfApproaches;
        private System.Windows.Forms.Label lExerciseTypeValue;
        private System.Windows.Forms.Label lExerciseNameValue;
        private System.Windows.Forms.Label lExerciseNumberOfApproachesValue;
        private System.Windows.Forms.Label lExerciseNumberOfRepetitionsValue;
        private System.Windows.Forms.Label lExerciseMuscleGroupValue;
        private System.Windows.Forms.Button btnRemoveExercise;
        private System.Windows.Forms.Button btnCreateTraining;
        private System.Windows.Forms.Button btnEditExercise;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnStatistics;
    }
}

