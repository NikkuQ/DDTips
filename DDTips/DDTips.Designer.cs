namespace DDTips
{
    partial class DDTips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DDTips));
            this.btn_Massimizza = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_Curiosita = new System.Windows.Forms.Label();
            this.lb_Sapevi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Massimizza
            // 
            this.btn_Massimizza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Massimizza.Image = ((System.Drawing.Image)(resources.GetObject("btn_Massimizza.Image")));
            this.btn_Massimizza.Location = new System.Drawing.Point(723, 373);
            this.btn_Massimizza.Name = "btn_Massimizza";
            this.btn_Massimizza.Size = new System.Drawing.Size(65, 65);
            this.btn_Massimizza.TabIndex = 0;
            this.btn_Massimizza.UseVisualStyleBackColor = true;
            this.btn_Massimizza.Click += new System.EventHandler(this.btn_Massimizza_Click);
            this.btn_Massimizza.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Massimizza_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_Curiosita
            // 
            this.lb_Curiosita.AutoEllipsis = true;
            this.lb_Curiosita.AutoSize = true;
            this.lb_Curiosita.BackColor = System.Drawing.Color.Transparent;
            this.lb_Curiosita.Font = new System.Drawing.Font("Poor Richard", 34F);
            this.lb_Curiosita.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Curiosita.Location = new System.Drawing.Point(150, 400);
            this.lb_Curiosita.Name = "lb_Curiosita";
            this.lb_Curiosita.Size = new System.Drawing.Size(0, 52);
            this.lb_Curiosita.TabIndex = 1;
            this.lb_Curiosita.UseMnemonic = false;
            // 
            // lb_Sapevi
            // 
            this.lb_Sapevi.AutoSize = true;
            this.lb_Sapevi.BackColor = System.Drawing.Color.Transparent;
            this.lb_Sapevi.Font = new System.Drawing.Font("Poor Richard", 34F, System.Drawing.FontStyle.Bold);
            this.lb_Sapevi.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lb_Sapevi.Location = new System.Drawing.Point(150, 350);
            this.lb_Sapevi.Name = "lb_Sapevi";
            this.lb_Sapevi.Size = new System.Drawing.Size(228, 52);
            this.lb_Sapevi.TabIndex = 2;
            this.lb_Sapevi.Text = "Sapevi che:";
            // 
            // DDTips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Massimizza);
            this.Controls.Add(this.lb_Sapevi);
            this.Controls.Add(this.lb_Curiosita);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DDTips";
            this.Text = "DDTips";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Massimizza;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_Curiosita;
        private System.Windows.Forms.Label lb_Sapevi;
    }
}

