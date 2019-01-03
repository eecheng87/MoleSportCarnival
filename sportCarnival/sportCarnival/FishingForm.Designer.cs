namespace sportCarnival
{
    partial class FishingForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.point = new System.Windows.Forms.Label();
            this.life = new System.Windows.Forms.Label();
            this.quit_btn = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.instruct = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.point.Location = new System.Drawing.Point(1032, 26);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(85, 31);
            this.point.TabIndex = 0;
            this.point.Text = "label1";
            // 
            // life
            // 
            this.life.AutoSize = true;
            this.life.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.life.Location = new System.Drawing.Point(1037, 65);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(85, 31);
            this.life.TabIndex = 1;
            this.life.Text = "label1";
            // 
            // quit_btn
            // 
            this.quit_btn.AutoSize = true;
            this.quit_btn.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_btn.Location = new System.Drawing.Point(1178, 9);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(30, 33);
            this.quit_btn.TabIndex = 2;
            this.quit_btn.Text = "X";
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(1147, 13);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(25, 28);
            this.instruction.TabIndex = 3;
            this.instruction.Text = "?";
            this.instruction.Click += new System.EventHandler(this.instruction_Click);
            // 
            // instruct
            // 
            this.instruct.BackColor = System.Drawing.SystemColors.WindowText;
            this.instruct.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.instruct.ForeColor = System.Drawing.SystemColors.Info;
            this.instruct.Location = new System.Drawing.Point(287, 100);
            this.instruct.Multiline = true;
            this.instruct.Name = "instruct";
            this.instruct.Size = new System.Drawing.Size(600, 317);
            this.instruct.TabIndex = 4;
            this.instruct.Text = "遊戲說明:\r\n按空白鍵控制魚竿升降\r\n中途記得躲避障礙物, 否則\r\n魚餌會減少, 另外記得吊起\r\n符合題目要求的魚, 當魚餌\r\n用光遊戲就結束, 祝你好運\r\n";
            this.instruct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.instruct.Click += new System.EventHandler(this.instruct_Click);
            // 
            // FishingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 712);
            this.Controls.Add(this.instruct);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.life);
            this.Controls.Add(this.point);
            this.Name = "FishingForm";
            this.Text = "FishingForm";
            this.Load += new System.EventHandler(this.FishingForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FishingForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Label life;
        private System.Windows.Forms.Label quit_btn;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.TextBox instruct;
    }
}