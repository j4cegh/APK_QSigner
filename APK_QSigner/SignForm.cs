﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace APK_QSigner
{
    public partial class SignForm : Form
    {
        private UberApkSigner signer;
        public SignForm()
        {
            InitializeComponent();
        }

        private void SignForm_Load(object sender, EventArgs e)
        {
            Text = "APK QSigner";
            var icon = ResourceManager.GetImageFromResources("icon");
            Icon = ResourceManager.BitmapToIcon(icon);
            BackColor = ColorTranslator.FromHtml("#171717");
            dropHereAPK.ForeColor = Color.White;
            browseLbl.ForeColor = Color.White;
            signer = new UberApkSigner();

        }
        
        #region Enter/Leave animation for browseLbl
        private void browseLbl_MouseEnter(object sender, EventArgs e)
        {
            browseLbl.ForeColor = Color.OrangeRed;
            browseLbl.Cursor = Cursors.Hand;
        }

        private void browseLbl_MouseLeave(object sender, EventArgs e)
        {
            browseLbl.ForeColor = Color.White;
        }
#endregion
        private void browseLbl_Click(object sender, EventArgs e)
        {
            apkFileDialog = new OpenFileDialog();
            apkFileDialog.DefaultExt = ".apk";
            apkFileDialog.Filter = "Android Package (.apk)|*.apk";
            if (apkFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = apkFileDialog.FileName;
                signer.Sign(filePath, Constants.outputDir);
                GC.Collect();
            }
        }
        
        #region Drag and drop
        private void SignForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void SignForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files[0].EndsWith(".apk"))
            {
                signer.Sign(files[0], Constants.outputDir);
                GC.Collect();
            }
        }
        #endregion

        
    }
}