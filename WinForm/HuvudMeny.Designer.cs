namespace WinForm
{
    partial class HuvudMeny
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
            this.ExpeditApplikationen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSkapaBokning = new System.Windows.Forms.Button();
            this.btnÅterLämning = new System.Windows.Forms.Button();
            this.btnLoggaUt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExpeditApplikationen
            // 
            this.ExpeditApplikationen.AutoSize = true;
            this.ExpeditApplikationen.Location = new System.Drawing.Point(329, 40);
            this.ExpeditApplikationen.Name = "ExpeditApplikationen";
            this.ExpeditApplikationen.Size = new System.Drawing.Size(152, 20);
            this.ExpeditApplikationen.TabIndex = 0;
            this.ExpeditApplikationen.Text = "ExpeditApplikationen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // btnSkapaBokning
            // 
            this.btnSkapaBokning.Location = new System.Drawing.Point(294, 113);
            this.btnSkapaBokning.Name = "btnSkapaBokning";
            this.btnSkapaBokning.Size = new System.Drawing.Size(222, 68);
            this.btnSkapaBokning.TabIndex = 3;
            this.btnSkapaBokning.Text = "Skapa Bokning";
            this.btnSkapaBokning.UseVisualStyleBackColor = true;
            this.btnSkapaBokning.Click += new System.EventHandler(this.btnSkapaBokning_Click);
            // 
            // btnÅterLämning
            // 
            this.btnÅterLämning.Location = new System.Drawing.Point(294, 216);
            this.btnÅterLämning.Name = "btnÅterLämning";
            this.btnÅterLämning.Size = new System.Drawing.Size(222, 68);
            this.btnÅterLämning.TabIndex = 4;
            this.btnÅterLämning.Text = "Återlämning";
            this.btnÅterLämning.UseVisualStyleBackColor = true;
            this.btnÅterLämning.Click += new System.EventHandler(this.btnÅterLämning_Click_1);
            // 
            // btnLoggaUt
            // 
            this.btnLoggaUt.Location = new System.Drawing.Point(12, 387);
            this.btnLoggaUt.Name = "btnLoggaUt";
            this.btnLoggaUt.Size = new System.Drawing.Size(134, 52);
            this.btnLoggaUt.TabIndex = 5;
            this.btnLoggaUt.Text = "Logga ut";
            this.btnLoggaUt.UseVisualStyleBackColor = true;
            this.btnLoggaUt.Click += new System.EventHandler(this.btnLoggaUt_Click);
            // 
            // HuvudMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.btnLoggaUt);
            this.Controls.Add(this.btnÅterLämning);
            this.Controls.Add(this.btnSkapaBokning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExpeditApplikationen);
            this.Name = "HuvudMeny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HuvudMeny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExpeditApplikationen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSkapaBokning;
        private System.Windows.Forms.Button btnÅterLämning;
        private System.Windows.Forms.Button btnLoggaUt;
    }
}