namespace EmpedApp
{
    partial class FormPerfil
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
            this.bntSair = new System.Windows.Forms.Button();
            this.bntMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntSair
            // 
            this.bntSair.BackColor = System.Drawing.Color.Transparent;
            this.bntSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSair.Location = new System.Drawing.Point(829, 584);
            this.bntSair.Margin = new System.Windows.Forms.Padding(2);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(163, 54);
            this.bntSair.TabIndex = 3;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = false;
            // 
            // bntMenu
            // 
            this.bntMenu.BackColor = System.Drawing.Color.Transparent;
            this.bntMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMenu.ForeColor = System.Drawing.Color.White;
            this.bntMenu.Location = new System.Drawing.Point(72, 584);
            this.bntMenu.Margin = new System.Windows.Forms.Padding(2);
            this.bntMenu.Name = "bntMenu";
            this.bntMenu.Size = new System.Drawing.Size(160, 54);
            this.bntMenu.TabIndex = 4;
            this.bntMenu.Text = "Menu";
            this.bntMenu.UseVisualStyleBackColor = false;
            // 
            // FormPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmpedApp.Properties.Resources._4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.bntMenu);
            this.Controls.Add(this.bntSair);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPerfil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntMenu;
    }
}