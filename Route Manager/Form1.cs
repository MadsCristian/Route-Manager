using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Route_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }


        public void GetDefaultGateway()
        {

            foreach (NetworkInterface f in NetworkInterface.GetAllNetworkInterfaces())
                if (f.OperationalStatus == OperationalStatus.Up)
                    foreach (GatewayIPAddressInformation d in f.GetIPProperties().GatewayAddresses)
                        localip.Text = (d.Address.ToString());
        }




        private void DetectWiFi()
        {
            if (comboBoxCableOrWiFi.SelectedIndex == 0)
            {
                localip.Text = GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            }
            else if (comboBoxCableOrWiFi.SelectedIndex == 1)
            {
                GetDefaultGateway();



            }

            else if (comboBoxCableOrWiFi.SelectedIndex == -1)
            {
                MessageBox.Show("You must select your connection!");
                return;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            DetectWiFi();


            if (ComboBoxPermanent.SelectedIndex == 0)
            {
                DebugText.Text = ("route -p add " + HostIP.Text + " " + localip.Text);

                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cmd.StartInfo.Arguments = "/C route -p add " + HostIP.Text + " " + localip.Text;
                cmd.Start();
                //Process.Start("cmd", "/C route -p add " + HostIP.Text + " " + localip.Text);

            }
            else if (ComboBoxPermanent.SelectedIndex == 1)
            {
                DebugText.Text = ("route add " + HostIP.Text + " " + localip.Text);

                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cmd.StartInfo.Arguments = "/C route add " + HostIP.Text + " " + localip.Text;
                cmd.Start();


            }

            else if (ComboBoxPermanent.SelectedIndex == -1)
            {
                MessageBox.Show("You must select if you want the route to be permanent!");
                return;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
