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
            this.labelQ.Location = new System.Drawing.Point(430, 10);
            this.labelQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(76, 35);
            this.labelQ.TabIndex = 0;
            this.labelQ.Text = "題目:";
            // 
            // mypanel
            // 
            this.mypanel.Controls.Add(this.ansLabel);
            this.mypanel.Location = new System.Drawing.Point(-1, 1);
            this.mypanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mypanel.Name = "mypanel";
            this.mypanel.Size = new System.Drawing.Size(1050, 560);
            this.mypanel.TabIndex = 1;
            // 
            // ansLabel
            // 
            this.ansLabel.AutoSize = true;
            this.ansLabel.BackColor = System.Drawing.Color.Gray;
            this.ansLabel.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansLabel.Location = new System.Drawing.Point(608, 10);
            this.ansLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ansLabel.Name = "ansLabel";
            this.ansLabel.Size = new System.Drawing.Size(76, 35);
            this.ansLabel.TabIndex = 0;
            this.ansLabel.Text = "完成:";
            // 
            // SkiingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 522);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.mypanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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