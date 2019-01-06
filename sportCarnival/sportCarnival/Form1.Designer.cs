namespace sportCarnival
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ski_btn = new System.Windows.Forms.Button();
            this.fishing_btn = new System.Windows.Forms.Button();
            this.shoot_btn = new System.Windows.Forms.Button();
            this.hockey_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ski_btn
            // 
            this.ski_btn.Location = new System.Drawing.Point(772, 59);
            this.ski_btn.Name = "ski_btn";
            this.ski_btn.Size = new System.Drawing.Size(237, 70);
            this.ski_btn.TabIndex = 0;
            this.ski_btn.Text = "滑雪";
            this.ski_btn.UseVisualStyleBackColor = true;
            this.ski_btn.Click += new System.EventHandler(this.ski_btn_Click);
            // 
            // fishing_btn
            // 
            this.fishing_btn.Location = new System.Drawing.Point(772, 177);
            this.fishing_btn.Name = "fishing_btn";
            this.fishing_btn.Size = new System.Drawing.Size(237, 74);
            this.fishing_btn.TabIndex = 1;
            this.fishing_btn.Text = "釣魚";
            this.fishing_btn.UseVisualStyleBackColor = true;
            this.fishing_btn.Click += new System.EventHandler(this.fishing_btn_Click);
            // 
            // shoot_btn
            // 
            this.shoot_btn.Location = new System.Drawing.Point(772, 302);
            this.shoot_btn.Name = "shoot_btn";
            this.shoot_btn.Size = new System.Drawing.Size(237, 68);
            this.shoot_btn.TabIndex = 2;
            this.shoot_btn.Text = "射擊";
            this.shoot_btn.UseVisualStyleBackColor = true;
            this.shoot_btn.Click += new System.EventHandler(this.shoot_btn_Click);
            // 
            // hockey_btn
            // 
            this.hockey_btn.Location = new System.Drawing.Point(772, 417);
            this.hockey_btn.Name = "hockey_btn";
            this.hockey_btn.Size = new System.Drawing.Size(237, 71);
            this.hockey_btn.TabIndex = 3;
            this.hockey_btn.Text = "桌上曲棍";
            this.hockey_btn.UseVisualStyleBackColor = true;
            this.hockey_btn.Click += new System.EventHandler(this.hockey_btn_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(480, 388);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 151);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 542);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.hockey_btn);
            this.Controls.Add(this.shoot_btn);
            this.Controls.Add(this.fishing_btn);
            this.Controls.Add(this.ski_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ski_btn;
        private System.Windows.Forms.Button fishing_btn;
        private System.Windows.Forms.Button shoot_btn;
        private System.Windows.Forms.Button hockey_btn;
        private System.Windows.Forms.Button button5;
    }
}

