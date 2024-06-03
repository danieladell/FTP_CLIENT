using FluentFTP;
using System;
using System.Security.Authentication;

namespace FTP_CLIENT
{
    public partial class Form1 : Form
    {
        Ftp connection;
        public Form1()
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
            textBox4.Text = "Hola01";
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
                    connection.getDirectories(treeView1);
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
                    connection.getDirectories(treeView1);
                }

            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
