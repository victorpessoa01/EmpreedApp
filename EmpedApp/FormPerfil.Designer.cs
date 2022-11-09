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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfil));
            this.bntSair = new System.Windows.Forms.Button();
            this.bntMenu = new System.Windows.Forms.Button();
            this.labeltext = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
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
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
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
            this.bntMenu.Click += new System.EventHandler(this.bntMenu_Click);
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.BackColor = System.Drawing.Color.Transparent;
            this.labeltext.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltext.Location = new System.Drawing.Point(172, 287);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(727, 207);
            this.labeltext.TabIndex = 5;
            this.labeltext.Text = resources.GetString("labeltext.Text");
            this.labeltext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labeltext.Click += new System.EventHandler(this.labeltext_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.Transparent;
            this.labelA.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(314, 169);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(0, 23);
            this.labelA.TabIndex = 6;
            this.labelA.Click += new System.EventHandler(this.labelA_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.Color.Transparent;
            this.labelB.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(314, 226);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(0, 23);
            this.labelB.TabIndex = 7;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.Black;
            this.labelNome.Location = new System.Drawing.Point(230, 114);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(0, 23);
            this.labelNome.TabIndex = 8;
            // 
            // FormPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmpedApp.Properties.Resources._4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labeltext);
            this.Controls.Add(this.bntMenu);
            this.Controls.Add(this.bntSair);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPerfil";
            this.Load += new System.EventHandler(this.FormPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntMenu;
        private System.Windows.Forms.Label labeltext;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelNome;
    }
}