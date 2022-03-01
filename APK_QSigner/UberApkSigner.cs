using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace APK_QSigner
{
    public class UberApkSigner
    {
        public UberApkSigner()
        {
            if (!File.Exists("signer.jar"))
            {
                WebClient client = new WebClient();
                client.DownloadFile(Constants.uberApkSigner, "signer.jar");
            }
        }

        public bool Sign(string apk, string outputDirectory)
        {
            try
            {
                var signer = new Process();
                signer.StartInfo.FileName = "java";
                signer.StartInfo.Arguments = $"-jar signer.jar -a \"{apk}\" -o {outputDirectory}";
                signer.StartInfo.UseShellExecute = false;
                signer.StartInfo.CreateNoWindow = true;
                signer.Start();
                signer.WaitForExit();
                MessageBox.Show("Signed! Opening the folder... (press OK)", "Signed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start("explorer.exe", Constants.outputDir);
                return true;
            } catch (Exception e)
            {
                return false;
            }
        }
    }
}