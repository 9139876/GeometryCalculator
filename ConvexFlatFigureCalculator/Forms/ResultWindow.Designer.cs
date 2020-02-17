namespace ConvexFlatFigureCalculator
{
    partial class ResultWindow
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
            this.ShapeBox = new System.Windows.Forms.PictureBox();
            this.Btn_Calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SquareBox = new System.Windows.Forms.TextBox();
            this.RBtn_sot = new System.Windows.Forms.RadioButton();
            this.RBtn_M2 = new System.Windows.Forms.RadioButton();
            this.ResultBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShapeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShapeBox
            // 
            this.ShapeBox.Location = new System.Drawing.Point(13, 13);
            this.ShapeBox.Name = "ShapeBox";
            this.ShapeBox.Size = new System.Drawing.Size(400, 400);
            this.ShapeBox.TabIndex = 0;
            this.ShapeBox.TabStop = false;
            // 
            // Btn_Calc
            // 
            this.Btn_Calc.Location = new System.Drawing.Point(625, 85);
            this.Btn_Calc.Name = "Btn_Calc";
            this.Btn_Calc.Size = new System.Drawing.Size(75, 23);
            this.Btn_Calc.TabIndex = 1;
            this.Btn_Calc.Text = "Расчет";
            this.Btn_Calc.UseVisualStyleBackColor = true;
            this.Btn_Calc.Click += new System.EventHandler(this.Btn_Calc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Площадь";
            // 
            // SquareBox
            // 
            this.SquareBox.Location = new System.Drawing.Point(601, 13);
            this.SquareBox.Name = "SquareBox";
            this.SquareBox.Size = new System.Drawing.Size(100, 20);
            this.SquareBox.TabIndex = 3;
            this.SquareBox.Text = "1";
            // 
            // RBtn_sot
            // 
            this.RBtn_sot.AutoSize = true;
            this.RBtn_sot.Checked = true;
            this.RBtn_sot.Location = new System.Drawing.Point(546, 39);
            this.RBtn_sot.Name = "RBtn_sot";
            this.RBtn_sot.Size = new System.Drawing.Size(55, 17);
            this.RBtn_sot.TabIndex = 4;
            this.RBtn_sot.TabStop = true;
            this.RBtn_sot.Text = "Сотки";
            this.RBtn_sot.UseVisualStyleBackColor = true;
            this.RBtn_sot.CheckedChanged += new System.EventHandler(this.RBtn_sot_CheckedChanged);
            // 
            // RBtn_M2
            // 
            this.RBtn_M2.AutoSize = true;
            this.RBtn_M2.Location = new System.Drawing.Point(546, 62);
            this.RBtn_M2.Name = "RBtn_M2";
            this.RBtn_M2.Size = new System.Drawing.Size(123, 17);
            this.RBtn_M2.TabIndex = 5;
            this.RBtn_M2.Text = "Квадратные метры";
            this.RBtn_M2.UseVisualStyleBackColor = true;
            this.RBtn_M2.CheckedChanged += new System.EventHandler(this.RBtn_M2_CheckedChanged);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(426, 114);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(274, 299);
            this.ResultBox.TabIndex = 6;
            // 
            // ResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 425);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.RBtn_M2);
            this.Controls.Add(this.RBtn_sot);
            this.Controls.Add(this.SquareBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Calc);
            this.Controls.Add(this.ShapeBox);
            this.Name = "ResultWindow";
            this.Text = "Расчет";
            ((System.ComponentModel.ISupportInitialize)(this.ShapeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ShapeBox;
        private System.Windows.Forms.Button Btn_Calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SquareBox;
        private System.Windows.Forms.RadioButton RBtn_sot;
        private System.Windows.Forms.RadioButton RBtn_M2;
        private System.Windows.Forms.TextBox ResultBox;
    }
}