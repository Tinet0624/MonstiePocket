
namespace MonstiePocket
{
    partial class FrmMonstieGallery
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
            this.btnAddMonstie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMonstie
            // 
            this.btnAddMonstie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddMonstie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMonstie.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddMonstie.Location = new System.Drawing.Point(12, 12);
            this.btnAddMonstie.Name = "btnAddMonstie";
            this.btnAddMonstie.Size = new System.Drawing.Size(71, 37);
            this.btnAddMonstie.TabIndex = 27;
            this.btnAddMonstie.Text = "Add";
            this.btnAddMonstie.UseVisualStyleBackColor = false;
            this.btnAddMonstie.Click += new System.EventHandler(this.btnAddMonstie_Click);
            // 
            // FrmMonstieGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(428, 433);
            this.Controls.Add(this.btnAddMonstie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMonstieGallery";
            this.Text = "frmMonstieGallery";
            this.Load += new System.EventHandler(this.frmMonstieGallery_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMonstie;
    }
}