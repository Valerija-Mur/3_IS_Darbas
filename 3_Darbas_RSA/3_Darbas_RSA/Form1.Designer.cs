
namespace _3_Darbas_RSA
{
    partial class Form1
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
            this.Tekstas_txt = new System.Windows.Forms.TextBox();
            this.Si_btn = new System.Windows.Forms.Button();
            this.de_btn = new System.Windows.Forms.Button();
            this.Sifruotas_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Raktas_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tekstas_txt
            // 
            this.Tekstas_txt.Location = new System.Drawing.Point(12, 111);
            this.Tekstas_txt.Multiline = true;
            this.Tekstas_txt.Name = "Tekstas_txt";
            this.Tekstas_txt.Size = new System.Drawing.Size(246, 210);
            this.Tekstas_txt.TabIndex = 0;
            // 
            // Si_btn
            // 
            this.Si_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Si_btn.Location = new System.Drawing.Point(12, 46);
            this.Si_btn.Name = "Si_btn";
            this.Si_btn.Size = new System.Drawing.Size(246, 59);
            this.Si_btn.TabIndex = 1;
            this.Si_btn.Text = "Šifravimas";
            this.Si_btn.UseVisualStyleBackColor = true;
            this.Si_btn.Click += new System.EventHandler(this.Si_btn_Click);
            // 
            // de_btn
            // 
            this.de_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_btn.Location = new System.Drawing.Point(262, 44);
            this.de_btn.Name = "de_btn";
            this.de_btn.Size = new System.Drawing.Size(246, 59);
            this.de_btn.TabIndex = 3;
            this.de_btn.Text = "Dešifravimas";
            this.de_btn.UseVisualStyleBackColor = true;
            this.de_btn.Click += new System.EventHandler(this.de_btn_Click);
            // 
            // Sifruotas_txt
            // 
            this.Sifruotas_txt.Location = new System.Drawing.Point(264, 111);
            this.Sifruotas_txt.Multiline = true;
            this.Sifruotas_txt.Name = "Sifruotas_txt";
            this.Sifruotas_txt.Size = new System.Drawing.Size(246, 210);
            this.Sifruotas_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Raktas:";
            // 
            // Raktas_txt
            // 
            this.Raktas_txt.Location = new System.Drawing.Point(104, 13);
            this.Raktas_txt.Multiline = true;
            this.Raktas_txt.Name = "Raktas_txt";
            this.Raktas_txt.Size = new System.Drawing.Size(404, 25);
            this.Raktas_txt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 332);
            this.Controls.Add(this.Raktas_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.de_btn);
            this.Controls.Add(this.Sifruotas_txt);
            this.Controls.Add(this.Si_btn);
            this.Controls.Add(this.Tekstas_txt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tekstas_txt;
        private System.Windows.Forms.Button Si_btn;
        private System.Windows.Forms.Button de_btn;
        private System.Windows.Forms.TextBox Sifruotas_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Raktas_txt;
    }
}

