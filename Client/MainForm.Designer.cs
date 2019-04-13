namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.datasetInfoLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.nodesTextBox = new System.Windows.Forms.TextBox();
            this.checkSurvivalButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.datasetInfoButton = new System.Windows.Forms.Button();
            this.serviceInfoButton = new System.Windows.Forms.Button();
            this.serviceInfoLabel = new System.Windows.Forms.Label();
            this.resultComboBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label1.Location = new System.Drawing.Point(134, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(254, 24);
            label1.TabIndex = 0;
            label1.Text = "Specify patient characteristics";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label2.Location = new System.Drawing.Point(12, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(313, 24);
            label2.TabIndex = 1;
            label2.Text = "1. Age of patient at time of operation:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label3.Location = new System.Drawing.Point(12, 146);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(249, 24);
            label3.TabIndex = 2;
            label3.Text = "2. Patient\'s year of operation:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label4.Location = new System.Drawing.Point(12, 217);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(390, 24);
            label4.TabIndex = 3;
            label4.Text = "3. Number of positive axillary nodes detected:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label5.Location = new System.Drawing.Point(12, 290);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(152, 24);
            label5.TabIndex = 15;
            label5.Text = "4. Survival status:";
            // 
            // datasetInfoLabel
            // 
            this.datasetInfoLabel.AutoSize = true;
            this.datasetInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.datasetInfoLabel.Location = new System.Drawing.Point(227, 457);
            this.datasetInfoLabel.Name = "datasetInfoLabel";
            this.datasetInfoLabel.Size = new System.Drawing.Size(0, 24);
            this.datasetInfoLabel.TabIndex = 4;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ageTextBox.Location = new System.Drawing.Point(414, 76);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(84, 28);
            this.ageTextBox.TabIndex = 5;
            this.ageTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnTextKeyPress);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.yearTextBox.Location = new System.Drawing.Point(414, 146);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(84, 28);
            this.yearTextBox.TabIndex = 6;
            this.yearTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.yearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnTextKeyPress);
            // 
            // nodesTextBox
            // 
            this.nodesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nodesTextBox.Location = new System.Drawing.Point(414, 217);
            this.nodesTextBox.Name = "nodesTextBox";
            this.nodesTextBox.Size = new System.Drawing.Size(84, 28);
            this.nodesTextBox.TabIndex = 7;
            this.nodesTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.nodesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnTextKeyPress);
            // 
            // checkSurvivalButton
            // 
            this.checkSurvivalButton.Enabled = false;
            this.checkSurvivalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkSurvivalButton.Location = new System.Drawing.Point(33, 339);
            this.checkSurvivalButton.Name = "checkSurvivalButton";
            this.checkSurvivalButton.Size = new System.Drawing.Size(169, 39);
            this.checkSurvivalButton.TabIndex = 8;
            this.checkSurvivalButton.Text = "Check survival status";
            this.checkSurvivalButton.UseVisualStyleBackColor = true;
            this.checkSurvivalButton.Click += new System.EventHandler(this.OnCheckButtonClick);
            // 
            // addItemButton
            // 
            this.addItemButton.Enabled = false;
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addItemButton.Location = new System.Drawing.Point(251, 339);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(169, 39);
            this.addItemButton.TabIndex = 9;
            this.addItemButton.Text = "Add to dataset";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // datasetInfoButton
            // 
            this.datasetInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.datasetInfoButton.Location = new System.Drawing.Point(251, 405);
            this.datasetInfoButton.Name = "datasetInfoButton";
            this.datasetInfoButton.Size = new System.Drawing.Size(169, 39);
            this.datasetInfoButton.TabIndex = 10;
            this.datasetInfoButton.Text = "Dataset info";
            this.datasetInfoButton.UseVisualStyleBackColor = true;
            this.datasetInfoButton.Click += new System.EventHandler(this.OnDatasetInfoButtonClick);
            // 
            // serviceInfoButton
            // 
            this.serviceInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.serviceInfoButton.Location = new System.Drawing.Point(33, 405);
            this.serviceInfoButton.Name = "serviceInfoButton";
            this.serviceInfoButton.Size = new System.Drawing.Size(169, 39);
            this.serviceInfoButton.TabIndex = 11;
            this.serviceInfoButton.Text = "Service info";
            this.serviceInfoButton.UseVisualStyleBackColor = true;
            this.serviceInfoButton.Click += new System.EventHandler(this.OnServiceInfoButtonClick);
            // 
            // serviceInfoLabel
            // 
            this.serviceInfoLabel.AutoSize = true;
            this.serviceInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.serviceInfoLabel.Location = new System.Drawing.Point(29, 457);
            this.serviceInfoLabel.Name = "serviceInfoLabel";
            this.serviceInfoLabel.Size = new System.Drawing.Size(0, 24);
            this.serviceInfoLabel.TabIndex = 12;
            // 
            // resultComboBox
            // 
            this.resultComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resultComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.resultComboBox.FormattingEnabled = true;
            this.resultComboBox.Items.AddRange(new object[] {
            "The patient survived 5 years or longer",
            "The patient died within 5 year"});
            this.resultComboBox.Location = new System.Drawing.Point(180, 290);
            this.resultComboBox.Name = "resultComboBox";
            this.resultComboBox.Size = new System.Drawing.Size(318, 26);
            this.resultComboBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 553);
            this.Controls.Add(this.resultComboBox);
            this.Controls.Add(label5);
            this.Controls.Add(this.serviceInfoLabel);
            this.Controls.Add(this.serviceInfoButton);
            this.Controls.Add(this.datasetInfoButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.checkSurvivalButton);
            this.Controls.Add(this.nodesTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.datasetInfoLabel);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 600);
            this.MinimumSize = new System.Drawing.Size(530, 500);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "kNN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datasetInfoLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox nodesTextBox;
        private System.Windows.Forms.Button checkSurvivalButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button datasetInfoButton;
        private System.Windows.Forms.Button serviceInfoButton;
        private System.Windows.Forms.Label serviceInfoLabel;
        private System.Windows.Forms.ComboBox resultComboBox;
    }
}

