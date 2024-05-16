namespace WindowsFormsApp1
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
            this.buttonMag = new System.Windows.Forms.Button();
            this.buttonCom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMag
            // 
            this.buttonMag.Location = new System.Drawing.Point(237, 135);
            this.buttonMag.Name = "buttonMag";
            this.buttonMag.Size = new System.Drawing.Size(130, 115);
            this.buttonMag.TabIndex = 0;
            this.buttonMag.Text = "Magazie";
            this.buttonMag.UseVisualStyleBackColor = true;
            this.buttonMag.Click += new System.EventHandler(this.buttonMag_Click);
            // 
            // buttonCom
            // 
            this.buttonCom.Location = new System.Drawing.Point(416, 135);
            this.buttonCom.Name = "buttonCom";
            this.buttonCom.Size = new System.Drawing.Size(130, 115);
            this.buttonCom.TabIndex = 1;
            this.buttonCom.Text = "Comanda";
            this.buttonCom.UseVisualStyleBackColor = true;
            this.buttonCom.Click += new System.EventHandler(this.buttonCom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCom);
            this.Controls.Add(this.buttonMag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem magazieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizeazaProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plaseazaComandaToolStripMenuItem;
        private System.Windows.Forms.Button buttonMag;
        private System.Windows.Forms.Button buttonCom;
    }
}

