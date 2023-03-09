namespace acojedo_perceptron_app
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TrainBtn = new System.Windows.Forms.Button();
            this.RunBtn = new System.Windows.Forms.Button();
            this.OutputLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(54, 136);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 1;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 27;
            // 
            // TrainBtn
            // 
            this.TrainBtn.Location = new System.Drawing.Point(225, 138);
            this.TrainBtn.Name = "TrainBtn";
            this.TrainBtn.Size = new System.Drawing.Size(75, 23);
            this.TrainBtn.TabIndex = 28;
            this.TrainBtn.Text = "Train";
            this.TrainBtn.UseVisualStyleBackColor = true;
            this.TrainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(353, 96);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(111, 64);
            this.RunBtn.TabIndex = 29;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // OutputLbl
            // 
            this.OutputLbl.AutoSize = true;
            this.OutputLbl.BackColor = System.Drawing.Color.White;
            this.OutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLbl.Location = new System.Drawing.Point(660, 96);
            this.OutputLbl.Name = "OutputLbl";
            this.OutputLbl.Size = new System.Drawing.Size(166, 56);
            this.OutputLbl.TabIndex = 30;
            this.OutputLbl.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Input (0-9)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Epochs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputLbl);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.TrainBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button TrainBtn;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Label OutputLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

