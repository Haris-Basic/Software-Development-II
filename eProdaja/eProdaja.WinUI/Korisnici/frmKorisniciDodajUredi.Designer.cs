
namespace eProdaja.WinUI.Korisnici
{
    partial class frmKorisniciDodajUredi
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(25, 50);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(256, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(206, 457);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmKorisniciDodajUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtIme);
            this.Name = "frmKorisniciDodajUredi";
            this.Text = "frmKorisniciDodajUredi";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider err;
    }
}