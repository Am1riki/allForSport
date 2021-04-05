
namespace allForSport
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.adressBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.advButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adressBox
            // 
            this.adressBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressBox.Location = new System.Drawing.Point(12, 80);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(609, 29);
            this.adressBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "АДРЕС ПОЛУЧАТЕЛЯ";
            // 
            // advButton1
            // 
            this.advButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advButton1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advButton1.Location = new System.Drawing.Point(12, 136);
            this.advButton1.Name = "advButton1";
            this.advButton1.Size = new System.Drawing.Size(261, 38);
            this.advButton1.TabIndex = 27;
            this.advButton1.Text = "ОФОРМИТЬ ДОСТАВКУ";
            this.advButton1.UseVisualStyleBackColor = true;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(633, 356);
            this.Controls.Add(this.advButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adressBox);
            this.DoubleBuffered = true;
            this.Name = "Form14";
            this.Text = "ДОСТАВКА";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adressBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button advButton1;
    }
}