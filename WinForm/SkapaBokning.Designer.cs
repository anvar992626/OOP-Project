
namespace WinForm
{
    partial class SkapaBokning
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
            this.listBoxListaAvBöcker = new System.Windows.Forms.ListBox();
            this.textBoxMedlemId = new System.Windows.Forms.TextBox();
            this.textBoxAntalDagar = new System.Windows.Forms.TextBox();
            this.dateTimePickerFrån = new System.Windows.Forms.DateTimePicker();
            this.buttonLäggaTill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxListaAvBöcker
            // 
            this.listBoxListaAvBöcker.FormattingEnabled = true;
            this.listBoxListaAvBöcker.ItemHeight = 20;
            this.listBoxListaAvBöcker.Location = new System.Drawing.Point(14, 48);
            this.listBoxListaAvBöcker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxListaAvBöcker.Name = "listBoxListaAvBöcker";
            this.listBoxListaAvBöcker.Size = new System.Drawing.Size(325, 284);
            this.listBoxListaAvBöcker.TabIndex = 0;
            // 
            // textBoxMedlemId
            // 
            this.textBoxMedlemId.Location = new System.Drawing.Point(423, 72);
            this.textBoxMedlemId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMedlemId.Name = "textBoxMedlemId";
            this.textBoxMedlemId.Size = new System.Drawing.Size(155, 27);
            this.textBoxMedlemId.TabIndex = 1;
            // 
            // textBoxAntalDagar
            // 
            this.textBoxAntalDagar.Location = new System.Drawing.Point(423, 231);
            this.textBoxAntalDagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAntalDagar.Name = "textBoxAntalDagar";
            this.textBoxAntalDagar.Size = new System.Drawing.Size(155, 27);
            this.textBoxAntalDagar.TabIndex = 2;
            // 
            // dateTimePickerFrån
            // 
            this.dateTimePickerFrån.Location = new System.Drawing.Point(423, 149);
            this.dateTimePickerFrån.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerFrån.Name = "dateTimePickerFrån";
            this.dateTimePickerFrån.Size = new System.Drawing.Size(228, 27);
            this.dateTimePickerFrån.TabIndex = 3;
            // 
            // buttonLäggaTill
            // 
            this.buttonLäggaTill.Location = new System.Drawing.Point(423, 305);
            this.buttonLäggaTill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLäggaTill.Name = "buttonLäggaTill";
            this.buttonLäggaTill.Size = new System.Drawing.Size(114, 31);
            this.buttonLäggaTill.TabIndex = 4;
            this.buttonLäggaTill.Text = "Skapa bokning";
            this.buttonLäggaTill.UseVisualStyleBackColor = true;
            this.buttonLäggaTill.Click += new System.EventHandler(this.buttonLäggaTill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ange medlemsnummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ange startdatum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ange antal dagar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tillgängliga böcker:";
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(14, 374);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(94, 29);
            this.btnTillbaka.TabIndex = 9;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // SkapaBokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 415);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLäggaTill);
            this.Controls.Add(this.dateTimePickerFrån);
            this.Controls.Add(this.textBoxAntalDagar);
            this.Controls.Add(this.textBoxMedlemId);
            this.Controls.Add(this.listBoxListaAvBöcker);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SkapaBokning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkapaBokning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxListaAvBöcker;
        private System.Windows.Forms.TextBox textBoxMedlemId;
        private System.Windows.Forms.TextBox textBoxAntalDagar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrån;
        private System.Windows.Forms.Button buttonLäggaTill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTillbaka;
    }
}