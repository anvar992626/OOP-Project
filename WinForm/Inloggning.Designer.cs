namespace WinForm
{
    partial class Inloggning
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxAnvändarNamn = new System.Windows.Forms.TextBox();
            this.txtboxtLösenord = new System.Windows.Forms.TextBox();
            this.buttonLoggaIn = new System.Windows.Forms.Button();
            this.buttonAvbryt = new System.Windows.Forms.Button();
            this.labelAnställningsnummer = new System.Windows.Forms.Label();
            this.labelLösenord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expeditapplikation";
            // 
            // txtboxAnvändarNamn
            // 
            this.txtboxAnvändarNamn.Location = new System.Drawing.Point(175, 111);
            this.txtboxAnvändarNamn.Name = "txtboxAnvändarNamn";
            this.txtboxAnvändarNamn.Size = new System.Drawing.Size(176, 27);
            this.txtboxAnvändarNamn.TabIndex = 3;
            // 
            // txtboxtLösenord
            // 
            this.txtboxtLösenord.Location = new System.Drawing.Point(175, 185);
            this.txtboxtLösenord.Name = "txtboxtLösenord";
            this.txtboxtLösenord.Size = new System.Drawing.Size(176, 27);
            this.txtboxtLösenord.TabIndex = 4;
            // 
            // buttonLoggaIn
            // 
            this.buttonLoggaIn.Location = new System.Drawing.Point(374, 293);
            this.buttonLoggaIn.Name = "buttonLoggaIn";
            this.buttonLoggaIn.Size = new System.Drawing.Size(131, 60);
            this.buttonLoggaIn.TabIndex = 5;
            this.buttonLoggaIn.Text = "Logga in";
            this.buttonLoggaIn.UseVisualStyleBackColor = true;
            this.buttonLoggaIn.Click += new System.EventHandler(this.buttonLoggaIn_Click);
            // 
            // buttonAvbryt
            // 
            this.buttonAvbryt.Location = new System.Drawing.Point(12, 293);
            this.buttonAvbryt.Name = "buttonAvbryt";
            this.buttonAvbryt.Size = new System.Drawing.Size(131, 60);
            this.buttonAvbryt.TabIndex = 6;
            this.buttonAvbryt.Text = "Avsluta";
            this.buttonAvbryt.UseVisualStyleBackColor = true;
            this.buttonAvbryt.Click += new System.EventHandler(this.buttonAvbryt_Click);
            // 
            // labelAnställningsnummer
            // 
            this.labelAnställningsnummer.AutoSize = true;
            this.labelAnställningsnummer.Location = new System.Drawing.Point(175, 88);
            this.labelAnställningsnummer.Name = "labelAnställningsnummer";
            this.labelAnställningsnummer.Size = new System.Drawing.Size(147, 20);
            this.labelAnställningsnummer.TabIndex = 7;
            this.labelAnställningsnummer.Text = "Anställningsnummer:";
            // 
            // labelLösenord
            // 
            this.labelLösenord.AutoSize = true;
            this.labelLösenord.Location = new System.Drawing.Point(175, 162);
            this.labelLösenord.Name = "labelLösenord";
            this.labelLösenord.Size = new System.Drawing.Size(73, 20);
            this.labelLösenord.TabIndex = 8;
            this.labelLösenord.Text = "Lösenord:";
            // 
            // Inloggning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 365);
            this.Controls.Add(this.labelLösenord);
            this.Controls.Add(this.labelAnställningsnummer);
            this.Controls.Add(this.buttonAvbryt);
            this.Controls.Add(this.buttonLoggaIn);
            this.Controls.Add(this.txtboxtLösenord);
            this.Controls.Add(this.txtboxAnvändarNamn);
            this.Controls.Add(this.label1);
            this.Name = "Inloggning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inloggning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxAnvändarNamn;
        private System.Windows.Forms.TextBox txtboxtLösenord;
        private System.Windows.Forms.Button buttonLoggaIn;
        private System.Windows.Forms.Button buttonAvbryt;
        private System.Windows.Forms.Label labelAnställningsnummer;
        private System.Windows.Forms.Label labelLösenord;
    }
}
