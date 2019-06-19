using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace CertExtract
{
    public partial class FMain : Form
    {
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CertExtract.cer";
        public FMain()
        {
            InitializeComponent();
            bGenerateCertificate.Text += " (" + filePath + ")";
        }

        private void bRun_Click(object sender, EventArgs e)
        {
            if (tbBinaryData.Text != String.Empty)
            {
                X509Certificate cert = new X509Certificate(Encoding.UTF8.GetBytes(tbBinaryData.Text));
                tbResult.Text = cert.ToString(true);
            }else
            {
                tbResult.Text = "Put your certificate Base64 string!";
            }
        }

        private void bGenerateCertificate_Click(object sender, EventArgs e)
        {            
            X509Certificate cert = new X509Certificate(Encoding.UTF8.GetBytes(tbBinaryData.Text));
            byte[] certData = cert.Export(X509ContentType.Cert);
            X509Certificate newCert = new X509Certificate(certData);            

            File.WriteAllBytes(filePath, cert.Export(X509ContentType.Cert));
            tbResult.Text = filePath + " created!";
        }
    }
}
