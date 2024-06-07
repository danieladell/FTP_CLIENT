using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FluentFTP;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FTP_CLIENT
{
    internal class Ftp
    {
        private string serverIp;
        private int serverPort;
        private string username;
        private string password;
        private FtpClient client;


        public Ftp(string serverIp, int serverPort, string username, string password)
        {
            this.serverIp = serverIp;
            this.serverPort = serverPort;
            this.username = username;
            this.password = password;
            client = new FtpClient(this.serverIp, this.username, this.password, serverPort);
        }

        public void ftpConnect() 
        {
           
                client.Config.EncryptionMode = FtpEncryptionMode.Explicit;
                client.Config.ValidateAnyCertificate = true;
                client.Connect();
            
            

        }

        public void getReplies(TextBox console)
        {
            for (int i = client.LastReplies.Count - 1; i >= 0; i--)
            {
                console.Text += client.LastReplies[i].Code + " " + client.LastReplies[i].Message + "\r\n";
                
            }
        }

        public bool isAuthenticated()
        {
            return client.IsAuthenticated;
        }

        public bool isConnected()
        {
            return client.IsConnected;
        }

        public FtpListItem[] getListItems(string path)
        {
            return sortItems(client.GetListing(path));
        }

        public void uploadFile(string path, TextBox console)
        {
            var filePath = string.Empty;
            if (client != null)
            {
                if (isAuthenticated() && isConnected())
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = "c:\\";
                        openFileDialog.Filter = "All files (*.*)|*.*";
                        openFileDialog.FilterIndex = 2;
                        openFileDialog.RestoreDirectory = true;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //Get the path of specified file
                            filePath = openFileDialog.FileName;
                            client.UploadFile(filePath, path + openFileDialog.SafeFileName);
                            console.Text += Ftp.getTime(DateTime.Now) + " File uploaded.\r\n";

                        }
                        else
                        {
                            console.Text += Ftp.getTime(DateTime.Now) + " File upload error.\r\n";
                        }
                    }
                }
            }
        }

        public void downloadFile(string path, TextBox console)
        {
            var filePath = string.Empty;
            if (client != null)
            {
                if (isAuthenticated() && isConnected())
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.InitialDirectory = "c:\\";


                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //Get the path of specified file
                            filePath = saveFileDialog.FileName;
                            client.DownloadFile(filePath, path);
                            console.Text += Ftp.getTime(DateTime.Now) + " File " + path + " downloaded.\r\n";

                        }
                    }
                }
            }
        }

        public FtpListItem[] sortItems(FtpListItem[] items)
        {
            FtpListItem[] sortItems = new FtpListItem[items.Length];
            int count = 0;
            foreach (FtpListItem item in items)
            {
                if (item.Type == FtpObjectType.Directory)
                {
                    sortItems[count] = item;
                    count++;
                }
            }
            foreach(FtpListItem item2 in items)
            {
                if (item2.Type == FtpObjectType.File)
                {
                    sortItems[count] = item2;
                    count++;
                }
            }
            return sortItems;

           
        }
        /*
        public void getDirectories(TreeView tree)
        {

            foreach (FtpListItem item in getListItems(client.GetWorkingDirectory()))
            {
                TreeNode node = new TreeNode(item.Name);
                switch (item.Type)
                 {
                     case FtpObjectType.Directory: 
                        tree.SelectedImageIndex = 0;
                        tree.ImageIndex = 0;
                        tree.Nodes.Add(node);
                        getSubDirectories(item, node);
                         break;
                     case FtpObjectType.File: 
                        tree.SelectedImageIndex = 1;
                        tree.ImageIndex = 1;
                        tree.Nodes.Add(item.Name);
                         break;
                }
            }
        }
        */
        public void getDirectory(TreeView tree, string path)
        {
            TreeNode selectedNode = tree.SelectedNode; ;
            TreeNode node;

            if (tree.Nodes.Count > 0)
            {
                if (selectedNode.Nodes.Count <= 0)
                {
                    foreach (FtpListItem item in getListItems(path))
                    {
                    
                    
                        node = new TreeNode(item.Name);
                        switch (item.Type)
                        {
                            case FtpObjectType.Directory:
                                node.SelectedImageIndex = 0;
                                node.ImageIndex = 0;
                                selectedNode.Nodes.Add(node);
                                break;
                            case FtpObjectType.File:
                                node.SelectedImageIndex = 1;
                                node.ImageIndex = 1;
                                selectedNode.Nodes.Add(node);
                                break;
                        }
                    }  
                }
            }else
            {
                foreach (FtpListItem item in getListItems(path))
                {
                    node = new TreeNode(item.Name);
                    switch (item.Type)
                    {
                        case FtpObjectType.Directory:
                            node.SelectedImageIndex = 0;
                            node.ImageIndex = 0;
                            tree.Nodes.Add(node);
                            break;
                        case FtpObjectType.File:
                            node.SelectedImageIndex = 1;
                            node.ImageIndex = 1;
                            tree.Nodes.Add(node);
                            break;
                    }
                }
            }
            

        }

        /*
        public void getSubDirectories(FtpListItem item, TreeNode node)
        {
            if (getListItems(item.FullName).Length > 0)
            {
                foreach (FtpListItem item2 in getListItems(item.FullName))
                {
                    TreeNode node2 = new TreeNode(item2.Name);
                    switch (item2.Type)
                    {
                        case FtpObjectType.Directory:
                            node.SelectedImageIndex = 1;
                            node.ImageIndex = 1;
                            node.Nodes.Add(node2);
                            getSubDirectories(item2, node2);
                            break;
                        case FtpObjectType.File:
                            node.SelectedImageIndex = 0;
                            node.ImageIndex = 0;
                            node.Nodes.Add(item2.Name);
                            break;
                    }
                }
            }else
            {
                node.SelectedImageIndex = 0;
                node.ImageIndex= 0;
            }
            
            
        }
        */

        public FtpClient getClient()
        {
            return client;
        }

        public void ftpDisconnect() 
        { 
            client.Disconnect(); 
        }
        public static String getTime(DateTime time)
        {
            return time.ToString("HH:mm:ss");
        }

        public void delete(TreeView treeView1, TextBox console)
        {
            if(client.IsConnected && client.IsAuthenticated)
            {
                if(treeView1.SelectedNode.ImageIndex == 0)
                {
                    client.DeleteDirectory(treeView1.SelectedNode.FullPath);
                }
                else
                {
                    client.DeleteFile(treeView1.SelectedNode.FullPath);
                }
            }
            
            
        }
    }
}
