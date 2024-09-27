namespace ChaveFacil
{
    partial class FrmChaveFacil
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
            this.btnRtrS1 = new System.Windows.Forms.Button();
            this.btnDvlrS1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblS1 = new System.Windows.Forms.Label();
            this.painel2 = new System.Windows.Forms.Panel();
            this.sala2 = new System.Windows.Forms.Label();
            this.btretirars2 = new System.Windows.Forms.Button();
            this.btdevolvers2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.painel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRtrS1
            // 
            this.btnRtrS1.Location = new System.Drawing.Point(11, 74);
            this.btnRtrS1.Name = "btnRtrS1";
            this.btnRtrS1.Size = new System.Drawing.Size(75, 23);
            this.btnRtrS1.TabIndex = 0;
            this.btnRtrS1.Text = "RETIRAR";
            this.btnRtrS1.UseVisualStyleBackColor = true;
            this.btnRtrS1.Click += new System.EventHandler(this.btnRtrS1_Click);
            // 
            // btnDvlrS1
            // 
            this.btnDvlrS1.Enabled = false;
            this.btnDvlrS1.Location = new System.Drawing.Point(91, 73);
            this.btnDvlrS1.Name = "btnDvlrS1";
            this.btnDvlrS1.Size = new System.Drawing.Size(75, 23);
            this.btnDvlrS1.TabIndex = 1;
            this.btnDvlrS1.Text = "DEVOLVER";
            this.btnDvlrS1.UseVisualStyleBackColor = true;
            this.btnDvlrS1.Click += new System.EventHandler(this.btnDvlrS1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.lblS1);
            this.panel1.Controls.Add(this.btnRtrS1);
            this.panel1.Controls.Add(this.btnDvlrS1);
            this.panel1.Location = new System.Drawing.Point(34, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 108);
            this.panel1.TabIndex = 2;
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblS1.Location = new System.Drawing.Point(57, 14);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(70, 17);
            this.lblS1.TabIndex = 2;
            this.lblS1.Text = "SALA 01";
            // 
            // painel2
            // 
            this.painel2.BackColor = System.Drawing.Color.Lime;
            this.painel2.Controls.Add(this.sala2);
            this.painel2.Controls.Add(this.btretirars2);
            this.painel2.Controls.Add(this.btdevolvers2);
            this.painel2.Location = new System.Drawing.Point(243, 55);
            this.painel2.Name = "painel2";
            this.painel2.Size = new System.Drawing.Size(177, 108);
            this.painel2.TabIndex = 3;
            // 
            // sala2
            // 
            this.sala2.AutoSize = true;
            this.sala2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.sala2.Location = new System.Drawing.Point(57, 14);
            this.sala2.Name = "sala2";
            this.sala2.Size = new System.Drawing.Size(70, 17);
            this.sala2.TabIndex = 2;
            this.sala2.Text = "SALA 02";
            // 
            // btretirars2
            // 
            this.btretirars2.Location = new System.Drawing.Point(11, 74);
            this.btretirars2.Name = "btretirars2";
            this.btretirars2.Size = new System.Drawing.Size(75, 23);
            this.btretirars2.TabIndex = 0;
            this.btretirars2.Text = "RETIRAR";
            this.btretirars2.UseVisualStyleBackColor = true;
            this.btretirars2.Click += new System.EventHandler(this.btretirars2_Click);
            // 
            // btdevolvers2
            // 
            this.btdevolvers2.Enabled = false;
            this.btdevolvers2.Location = new System.Drawing.Point(91, 73);
            this.btdevolvers2.Name = "btdevolvers2";
            this.btdevolvers2.Size = new System.Drawing.Size(75, 23);
            this.btdevolvers2.TabIndex = 1;
            this.btdevolvers2.Text = "DEVOLVER";
            this.btdevolvers2.UseVisualStyleBackColor = true;
            this.btdevolvers2.Click += new System.EventHandler(this.btdevolvers2_Click);
            // 
            // FrmChaveFacil
            // 
            this.ClientSize = new System.Drawing.Size(918, 436);
            this.Controls.Add(this.painel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmChaveFacil";
            this.Text = "ChaveFacil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painel2.ResumeLayout(false);
            this.painel2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnRtrS1;
        private System.Windows.Forms.Button btnDvlrS1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblS1;
        private System.Windows.Forms.Panel painel2;
        private System.Windows.Forms.Label sala2;
        private System.Windows.Forms.Button btretirars2;
        private System.Windows.Forms.Button btdevolvers2;
    }
}

