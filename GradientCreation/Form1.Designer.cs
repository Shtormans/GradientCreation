namespace GradientCreation
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
            this.startButton = new System.Windows.Forms.Button();
            this.secondColorEnter = new System.Windows.Forms.TextBox();
            this.firstColorLabel = new System.Windows.Forms.Label();
            this.secondColorLabel = new System.Windows.Forms.Label();
            this.firstColorEnter = new System.Windows.Forms.TextBox();
            this.firstColorLook = new System.Windows.Forms.Button();
            this.secondColorLook = new System.Windows.Forms.Button();
            this.gradientPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(387, 181);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 46);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // secondColorEnter
            // 
            this.secondColorEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondColorEnter.Location = new System.Drawing.Point(150, 226);
            this.secondColorEnter.Name = "secondColorEnter";
            this.secondColorEnter.Size = new System.Drawing.Size(125, 30);
            this.secondColorEnter.TabIndex = 2;
            this.secondColorEnter.Text = "255, 255, 255";
            this.secondColorEnter.TextChanged += new System.EventHandler(this.SecondColorEnter_TextChanged);
            // 
            // firstColorLabel
            // 
            this.firstColorLabel.AutoSize = true;
            this.firstColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstColorLabel.Location = new System.Drawing.Point(12, 164);
            this.firstColorLabel.Name = "firstColorLabel";
            this.firstColorLabel.Size = new System.Drawing.Size(101, 25);
            this.firstColorLabel.TabIndex = 3;
            this.firstColorLabel.Text = "First Color";
            // 
            // secondColorLabel
            // 
            this.secondColorLabel.AutoSize = true;
            this.secondColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondColorLabel.Location = new System.Drawing.Point(12, 229);
            this.secondColorLabel.Name = "secondColorLabel";
            this.secondColorLabel.Size = new System.Drawing.Size(132, 25);
            this.secondColorLabel.TabIndex = 4;
            this.secondColorLabel.Text = "Second Color";
            // 
            // firstColorEnter
            // 
            this.firstColorEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstColorEnter.Location = new System.Drawing.Point(150, 159);
            this.firstColorEnter.Name = "firstColorEnter";
            this.firstColorEnter.Size = new System.Drawing.Size(125, 30);
            this.firstColorEnter.TabIndex = 1;
            this.firstColorEnter.Text = "0, 0, 0";
            this.firstColorEnter.TextChanged += new System.EventHandler(this.FirstColorEnter_TextChanged);
            // 
            // firstColorLook
            // 
            this.firstColorLook.BackColor = System.Drawing.Color.Black;
            this.firstColorLook.Enabled = false;
            this.firstColorLook.FlatAppearance.BorderSize = 0;
            this.firstColorLook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstColorLook.Location = new System.Drawing.Point(296, 159);
            this.firstColorLook.Name = "firstColorLook";
            this.firstColorLook.Size = new System.Drawing.Size(30, 30);
            this.firstColorLook.TabIndex = 5;
            this.firstColorLook.UseVisualStyleBackColor = false;
            // 
            // secondColorLook
            // 
            this.secondColorLook.BackColor = System.Drawing.Color.White;
            this.secondColorLook.Enabled = false;
            this.secondColorLook.FlatAppearance.BorderSize = 0;
            this.secondColorLook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondColorLook.Location = new System.Drawing.Point(296, 226);
            this.secondColorLook.Name = "secondColorLook";
            this.secondColorLook.Size = new System.Drawing.Size(30, 30);
            this.secondColorLook.TabIndex = 6;
            this.secondColorLook.UseVisualStyleBackColor = false;
            // 
            // gradientPicture
            // 
            this.gradientPicture.Location = new System.Drawing.Point(0, 0);
            this.gradientPicture.Name = "gradientPicture";
            this.gradientPicture.Size = new System.Drawing.Size(100, 50);
            this.gradientPicture.TabIndex = 7;
            this.gradientPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPicture);
            this.Controls.Add(this.secondColorLook);
            this.Controls.Add(this.firstColorLook);
            this.Controls.Add(this.secondColorLabel);
            this.Controls.Add(this.firstColorLabel);
            this.Controls.Add(this.secondColorEnter);
            this.Controls.Add(this.firstColorEnter);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox secondColorEnter;
        private System.Windows.Forms.Label firstColorLabel;
        private System.Windows.Forms.Label secondColorLabel;
        private System.Windows.Forms.TextBox firstColorEnter;
        private System.Windows.Forms.Button firstColorLook;
        private System.Windows.Forms.Button secondColorLook;
        private System.Windows.Forms.PictureBox gradientPicture;
    }
}

