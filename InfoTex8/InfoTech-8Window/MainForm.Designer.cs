namespace InfoTech_8Window
{
    partial class MainForm
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
            this.InstantTechnics = new System.Windows.Forms.Button();
            this.FastTechnics = new System.Windows.Forms.Button();
            this.SlowTechnics = new System.Windows.Forms.Button();
            this.AddHouse = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // InstantTechnics
            // 
            this.InstantTechnics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstantTechnics.Location = new System.Drawing.Point(738, 12);
            this.InstantTechnics.Name = "InstantTechnics";
            this.InstantTechnics.Size = new System.Drawing.Size(202, 35);
            this.InstantTechnics.TabIndex = 9;
            this.InstantTechnics.Text = "Быстрый техник";
            this.InstantTechnics.UseVisualStyleBackColor = true;
            this.InstantTechnics.Click += new System.EventHandler(this.AddFastTechnic_Click);
            // 
            // FastTechnics
            // 
            this.FastTechnics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FastTechnics.Location = new System.Drawing.Point(525, 12);
            this.FastTechnics.Name = "FastTechnics";
            this.FastTechnics.Size = new System.Drawing.Size(207, 35);
            this.FastTechnics.TabIndex = 8;
            this.FastTechnics.Text = "Обычный техник";
            this.FastTechnics.UseVisualStyleBackColor = true;
            this.FastTechnics.Click += new System.EventHandler(this.AddAverageTechnic_Click);
            // 
            // SlowTechnics
            // 
            this.SlowTechnics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlowTechnics.Location = new System.Drawing.Point(309, 12);
            this.SlowTechnics.Name = "SlowTechnics";
            this.SlowTechnics.Size = new System.Drawing.Size(210, 35);
            this.SlowTechnics.TabIndex = 7;
            this.SlowTechnics.Text = "Медленный техник";
            this.SlowTechnics.UseVisualStyleBackColor = true;
            this.SlowTechnics.Click += new System.EventHandler(this.AddSlowTechnic_Click);
            // 
            // AddHouse
            // 
            this.AddHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddHouse.Location = new System.Drawing.Point(8, 12);
            this.AddHouse.Name = "AddHouse";
            this.AddHouse.Size = new System.Drawing.Size(253, 35);
            this.AddHouse.TabIndex = 6;
            this.AddHouse.Text = "Новый квадрокоптер";
            this.AddHouse.UseVisualStyleBackColor = true;
            this.AddHouse.Click += new System.EventHandler(this.AddQuadcopter_Click);
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Location = new System.Drawing.Point(8, 53);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(935, 575);
            this.Panel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 632);
            this.Controls.Add(this.AddHouse);
            this.Controls.Add(this.InstantTechnics);
            this.Controls.Add(this.FastTechnics);
            this.Controls.Add(this.SlowTechnics);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Text = "Quadcopters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InstantTechnics;
        private System.Windows.Forms.Button FastTechnics;
        private System.Windows.Forms.Button SlowTechnics;
        private System.Windows.Forms.Button AddHouse;
        private System.Windows.Forms.FlowLayoutPanel Panel;
    }
}

