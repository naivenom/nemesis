using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace nemesis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Text = "Parado";
            CheckForIllegalCrossThreadCalls = false;
        }
        Thread myThread = null;

        public void _fuzzingFic(string _host, string _path, string _port, string _ext)
        {
            int port = Int32.Parse(_port);
            
            string[] requestLines = File.ReadAllLines(_path);
            int numeroLineas = requestLines.Length;
            progressBar1.Maximum = numeroLineas;
            progressBar1.Value = 0;
            OutPut.Items.Clear();
            foreach (string line in requestLines)
            {
                IPEndPoint hostRemoto = new IPEndPoint(IPAddress.Parse(_host), port);
                label1.ForeColor = System.Drawing.Color.Green;
                label1.Text = "Fuzzing directorios y ficheros: " + line;
                using (Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    try
                    {
                        sock.Connect(hostRemoto);
                        if (fuzzingFic.Checked == true)
                        {
                            try
                            {
                                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + _host + "/" + line + _ext);
                                myHttpWebRequest.AllowAutoRedirect = false;
                                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                                {
                                    OutPut.Items.Add(new ListViewItem(new String[] { line + _ext, myHttpWebResponse.StatusDescription }));
                                }
                                else if (myHttpWebResponse.StatusCode == HttpStatusCode.MovedPermanently)
                                {
                                    OutPut.Items.Add(new ListViewItem(new String[] { line + _ext, myHttpWebResponse.StatusDescription }));
                                }
                                else if (myHttpWebResponse.StatusCode == HttpStatusCode.Forbidden)
                                {
                                    OutPut.Items.Add(new ListViewItem(new String[] { line + _ext, myHttpWebResponse.StatusDescription }));
                                }
                                myHttpWebResponse.Close();
                            }
                            catch { }
                        }
                        else if (fuzzingDir.Checked == true)
                        {
                            try
                            {
                                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + _host + "/" + line);
                                myHttpWebRequest.AllowAutoRedirect = false;
                                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                                {
                                    OutPut.Items.Add(new ListViewItem(new String[] { line, myHttpWebResponse.StatusDescription }));
                                }
                                else if (myHttpWebResponse.StatusCode == HttpStatusCode.MovedPermanently)
                                {
                                    OutPut.Items.Add(new ListViewItem(new String[] { line, myHttpWebResponse.StatusDescription }));
                                }
                                else if (myHttpWebResponse.StatusCode == HttpStatusCode.Forbidden)
                                {
                                    OutPut.Items.Add(new ListViewItem(new String[] { line, myHttpWebResponse.StatusDescription }));
                                }
                                myHttpWebResponse.Close();
                            }
                            catch { }
                        }

                    }
                    catch  { }
                
                }
                progressBar1.Value ++;
            }
            label1.Text = "Realizado con exito!";
            int _contador = OutPut.Items.Count;
            MessageBox.Show("Escaneo realizado!\nEncontrados " + _contador.ToString() + " ficheros o directorio.", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void scan_Click(object sender, EventArgs e)
        {
            if (ipAddress.Text == string.Empty)
            {
                MessageBox.Show("No se ha introducido ninguna IP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Port.Text == string.Empty)
            {
                MessageBox.Show("No se ha introducido ningun puerto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pathDicc.Text == string.Empty)
            {
                MessageBox.Show("No se ha introducido ninguna ruta del diccionario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (fuzzingFic.Checked)
                {
                    myThread = new Thread(() => _fuzzingFic(ipAddress.Text,pathDicc.Text, Port.Text, ext.Text));
                    myThread.Start();

                    if (myThread.IsAlive == true)
                    {
                        stop.Enabled = true;
                        scan.Enabled = false;
                        ipAddress.Enabled = false;
                    }
                }
                if (fuzzingDir.Checked)
                {
                    myThread = new Thread(() => _fuzzingFic(ipAddress.Text, pathDicc.Text, Port.Text, ext.Text));
                    myThread.Start();

                    if (myThread.IsAlive == true)
                    {
                        stop.Enabled = true;
                        scan.Enabled = false;
                        ipAddress.Enabled = false;
                    }
                }


            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            myThread.Suspend();
            scan.Enabled = true;
            stop.Enabled = false;
            ipAddress.Enabled = true;
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Text = "Parado";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
