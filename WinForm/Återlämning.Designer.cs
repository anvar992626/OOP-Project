
namespace WinForm
{
    partial class Återlämning
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
            this.dataGridViewAktivaBokningar = new System.Windows.Forms.DataGridView();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnÅterlämna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktivaBokningar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAktivaBokningar
            // 
            this.dataGridViewAktivaBokningar.AllowUserToResizeColumns = false;
            this.dataGridViewAktivaBokningar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAktivaBokningar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAktivaBokningar.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewAktivaBokningar.Name = "dataGridViewAktivaBokningar";
            this.dataGridViewAktivaBokningar.RowHeadersWidth = 51;
            this.dataGridViewAktivaBokningar.RowTemplate.Height = 29;
            this.dataGridViewAktivaBokningar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAktivaBokningar.Size = new System.Drawing.Size(776, 336);
            this.dataGridViewAktivaBokningar.TabIndex = 0;
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(12, 409);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(94, 29);
            this.btnTillbaka.TabIndex = 1;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aktiva bokningar:";
            // 
            // btnÅterlämna
            // 
            this.btnÅterlämna.Location = new System.Drawing.Point(694, 409);
            this.btnÅterlämna.Name = "btnÅterlämna";
            this.btnÅterlämna.Size = new System.Drawing.Size(94, 29);
            this.btnÅterlämna.TabIndex = 3;
            this.btnÅterlämna.Text = "Återlämna";
            this.btnÅterlämna.UseVisualStyleBackColor = true;
            this.btnÅterlämna.Click += new System.EventHandler(this.btnÅterlämna_Click);
            // 
            // Återlämning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnÅterlämna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.dataGridViewAktivaBokningar);
            this.Name = "Återlämning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Återlämning";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktivaBokningar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAktivaBokningar;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnÅterlämna;
    }
}