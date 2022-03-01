using System.ComponentModel;

namespace APK_QSigner
{
    partial class SignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.dropHereAPK = new System.Windows.Forms.Label();
            this.browseLbl = new System.Windows.Forms.Label();
            this.apkFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // dropHereAPK
            // 
            this.dropHereAPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dropHereAPK.Location = new System.Drawing.Point(162, 188);
            this.dropHereAPK.Name = "dropHereAPK";
            this.dropHereAPK.Size = new System.Drawing.Size(506, 48);
            this.dropHereAPK.TabIndex = 0;
            this.dropHereAPK.Text = "Drag and drop the APK here";
            // 
            // browseLbl
            // 
            this.browseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.browseLbl.Location = new System.Drawing.Point(268, 378);
            this.browseLbl.Name = "browseLbl";
            this.browseLbl.Size = new System.Drawing.Size(259, 30);
            this.browseLbl.TabIndex = 1;
            this.browseLbl.Text = "...or click here to browse\r\n";
            this.browseLbl.Click += new System.EventHandler(this.browseLbl_Click);
            this.browseLbl.MouseEnter += new System.EventHandler(this.browseLbl_MouseEnter);
            this.browseLbl.MouseLeave += new System.EventHandler(this.browseLbl_MouseLeave);
            // 
            // SignForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.browseLbl);
            this.Controls.Add(this.dropHereAPK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SignForm";
            this.Text = "SignForm";
            this.Load += new System.EventHandler(this.SignForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SignForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SignForm_DragEnter);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.OpenFileDialog apkFileDialog;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.Label browseLbl;

        private System.Windows.Forms.Label dropHereAPK;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}