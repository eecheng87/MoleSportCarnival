namespace sportCarnival
{
    partial class SkiingForm
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
            this.labelQ = new System.Windows.Forms.Label();
            this.mypanel = new System.Windows.Forms.Panel();
            this.ansLabel = new System.Windows.Forms.Label();
            this.mypanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.BackColor = System.Drawing.Color.Gray;
            this.labelQ.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ.Location = new System.Drawing.Point(574, 13);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(96, 43);
            this.labelQ.TabIndex = 0;
            this.labelQ.Text = "題目:";
            // 
            // mypanel
            // 
            this.mypanel.Controls.Add(this.ansLabel);
            this.mypanel.Location = new System.Drawing.Point(-1, 1);
            this.mypanel.Name = "mypanel";
            this.mypanel.Size = new System.Drawing.Size(1400, 700);
            this.mypanel.TabIndex = 1;
            // 
            // ansLabel
            // 
            this.ansLabel.AutoSize = true;
            this.ansLabel.BackColor = System.Drawing.Color.Gray;
            this.ansLabel.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansLabel.Location = new System.Drawing.Point(811, 12);
            this.ansLabel.Name = "ansLabel";
            this.ansLabel.Size = new System.Drawing.Size(96, 43);
            this.ansLabel.TabIndex = 0;
            this.ansLabel.Text = "完成:";
            // 
            // SkiingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.mypanel);
            this.Name = "SkiingForm";
            this.Text = "SkiingForm";
            this.Load += new System.EventHandler(this.SkiingForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SkiingForm_KeyDown);
            this.mypanel.ResumeLayout(false);
            this.mypanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Panel mypanel;
        private System.Windows.Forms.Label ansLabel;
    }
}