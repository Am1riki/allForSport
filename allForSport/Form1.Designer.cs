
namespace allForSport
{
    partial class ModeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeForm));
            this.adminButton = new System.Windows.Forms.Button();
            this.ModerButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.Transparent;
            this.adminButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminButton.BackgroundImage")));
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButton.FlatAppearance.BorderSize = 0;
            this.adminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.adminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.ForeColor = System.Drawing.Color.Black;
            this.adminButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.adminButton.Location = new System.Drawing.Point(0, 1);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(262, 486);
            this.adminButton.TabIndex = 0;
            this.adminButton.Text = "Administrator";
            this.adminButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.adminButton.UseVisualStyleBackColor = false;
            // 
            // ModerButton
            // 
            this.ModerButton.BackColor = System.Drawing.Color.Transparent;
            this.ModerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ModerButton.BackgroundImage")));
            this.ModerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModerButton.FlatAppearance.BorderSize = 0;
            this.ModerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ModerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ModerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModerButton.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModerButton.Location = new System.Drawing.Point(258, 1);
            this.ModerButton.Name = "ModerButton";
            this.ModerButton.Size = new System.Drawing.Size(262, 486);
            this.ModerButton.TabIndex = 1;
            this.ModerButton.Text = "Personnel";
            this.ModerButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ModerButton.UseVisualStyleBackColor = false;
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.Transparent;
            this.userButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userButton.BackgroundImage")));
            this.userButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.userButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.Location = new System.Drawing.Point(518, 1);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(261, 486);
            this.userButton.TabIndex = 2;
            this.userButton.Text = "User";
            this.userButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // ModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 490);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.ModerButton);
            this.Controls.Add(this.adminButton);
            this.Name = "ModeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button ModerButton;
        private System.Windows.Forms.Button userButton;
    }
}

