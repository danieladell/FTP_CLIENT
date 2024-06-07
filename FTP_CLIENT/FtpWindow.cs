using FluentFTP;
using System;
using System.IO;
using System.Security.Authentication;
using static System.Net.WebRequestMethods;

namespace FTP_CLIENT
{
    public partial class FtpWindow : Form
    {
        Ftp connection;
        public FtpWindow()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void conButton_Click(object sender, EventArgs e)
        {
            int port = 21;
            textBox1.Text = "127.0.0.1";
            textBox3.Text = "ftps_test";
            if (int.TryParse(textBox2.Text, out port))
                connection = new Ftp(textBox1.Text, port, textBox3.Text, textBox4.Text);
                //connection = new Ftp();
            if (connection != null)
            {
                try
                {

                    connection.ftpConnect();

                }
                catch (FluentFTP.Exceptions.FtpAuthenticationException)
                {
                    console.Text += Ftp.getTime(DateTime.Now) + " Username or password incorrect." + "\r\n";
                    connection.ftpDisconnect();

                }
                catch (IOException)
                {
                    console.Text += Ftp.getTime(DateTime.Now) + " Can't connect to the server." + "\r\n";
                }
                if (connection.isAuthenticated() && connection.isConnected())
                {
                    console.Text += Ftp.getTime(DateTime.Now) + " Connected to server " + connection.getClient().Host + "..." + "\r\n" + 
                        Ftp.getTime(DateTime.Now) + " Using authentication type TLS.\r\n"
                            + Ftp.getTime(DateTime.Now) + " Login successful, " + textBox3.Text + ".\r\n";
                    treeView1.Nodes.Clear(); 
                    connection.getDirectory(treeView1, connection.getClient().GetWorkingDirectory());

                    //connection.getReplies(console);
                }

            }
        }
        private void disButton_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                if (connection.isConnected())
                {
                    treeView1.Nodes.Clear();
                    connection.ftpDisconnect();
                    console.Text += Ftp.getTime(DateTime.Now) + " Disconnected from server.\r\n";
                }
                else
                {
                    console.Text += Ftp.getTime(DateTime.Now) + " Not connected to server.\r\n";
                }
            }
            else
            {
                console.Text += Ftp.getTime(DateTime.Now) + " Not connected to server.\r\n";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                if (connection.isAuthenticated() && connection.isConnected())
                {
                    treeView1.Nodes.Clear();
                    connection.getDirectory(treeView1, connection.getClient().GetWorkingDirectory());

                }

            }

        }

        private void upButton_Click(Object sender, EventArgs e)
        {
            connection.uploadFile(connection.getClient().GetWorkingDirectory(), console);
            treeView1.Nodes.Clear();
            connection.getDirectory(treeView1, connection.getClient().GetWorkingDirectory());
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode.ImageIndex != 1)
            {
                connection.getDirectory(treeView1, treeView1.SelectedNode.FullPath);
            }
          
            label6.Text = "FILE PATH: " + connection.getClient().GetWorkingDirectory() + treeView1.SelectedNode.FullPath;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void downButton_Click(object sender, EventArgs e)
        {
            connection.downloadFile(treeView1.SelectedNode.FullPath, console);
        }

        public void delButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this file?", "WARNING! FILE DELETE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                connection.delete(treeView1, console);
            }
            
        }
    }
}
