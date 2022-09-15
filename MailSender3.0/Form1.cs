using System.Drawing.Text;
using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.ServiceProcess;
using System.Diagnostics;
using System.Threading;
using System.Text;

namespace MailSender3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            status();
        }

        private void bugreportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void cmd_getFolder_Click(object sender, EventArgs e)
        {
            getFolder();
        }
        private void cmd_getFile_Click(object sender, EventArgs e)
        {
            getFile();
        }

        

        private void getFile(){
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files (*.*) | *.*";
            dlg.Title = "Choose Files";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in dlg.FileNames)
                    txt_attchment.Text = file;
            }

        }
        private void getFolder(){
            FolderBrowserDialog folder_path = new FolderBrowserDialog();
            if (folder_path.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txt_attchment.Text = folder_path.SelectedPath.ToString();
        }

        private void txt_attchment_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmd_txt_getFolder_Click(object sender, EventArgs e)
        {
            getFolder();
        }

        private void cmd_sendTo_Click(object sender, EventArgs e)
        {
            MainCostomizator mainCostomizator = new MainCostomizator();
            mainCostomizator.Show();
            
        }

        private void cmd_sendCc_Click(object sender, EventArgs e)
        {

        }

        private void cmd_send_Click(object sender, EventArgs e)
        {
            send();
        }
        private void send()
        {
            if (txt_attchment.Text == "" || txt_send_To.Text == "" || txt_send_Betreff.Text == "")
            {
                lbl_warn.Text = "Fehler ist aufgetreten ERROR ID10T, Felder An, Anhang und Betreff sind Pflichfelder";
            }
            else
            {
                DirectoryInfo d = new DirectoryInfo(txt_attchment.Text);
                FileInfo[] Files = d.GetFiles();
                string str = "";
                foreach (FileInfo file in Files)
                {
                    var app = new Outlook.Application();
                    Outlook.MailItem mailitem = app.CreateItem(Outlook.OlItemType.olMailItem);
                    mailitem.To = txt_send_To.Text;
                    mailitem.CC = txt_send_Cc.Text;
                    mailitem.Subject = txt_send_Betreff.Text + ": " + file.Name.ToString().Split(".")[0];
                    mailitem.Body = txt_mailBody.Text;
                    mailitem.Attachments.Add(file.FullName);
                    mailitem.Display(false);
                    mailitem.Send();
                }

            }
        
            

        }
        private void status()
        {
            Process[] proc = Process.GetProcessesByName("OUTLOOK");
            if (proc.Length == 0)
            {
                lbl_status.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff0019");
            }
            else
            {
                lbl_status.BackColor = System.Drawing.ColorTranslator.FromHtml("#00ff44");
            }
            

        }

        private void cmd_getOutlookSignature_Click(object sender, EventArgs e)
        {
            Signature();
        }
        private void Signature()
        {
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Signatures";
            string signature = string.Empty;
            DirectoryInfo diInfo = new DirectoryInfo(appDataDir);
            if (diInfo.Exists)
            {
                FileInfo[] fiSignature = diInfo.GetFiles("*.txt");
                if (fiSignature.Length > 0)
                {
                    StreamReader sr = new StreamReader(fiSignature[0].FullName, Encoding.Default);
                    signature = sr.ReadToEnd();
                    if (signature != string.Empty)
                    {
                        string fileName = fiSignature[0].Name.Replace(fiSignature[0].Extension, string.Empty);
                        signature = signature.Replace(fileName + "_files/", appDataDir + "/" + fileName + "_files/");
                        txt_mailBody.Text = signature;
                    }
                }
            }
        }
    }
}