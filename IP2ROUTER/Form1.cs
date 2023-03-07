using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP2ROUTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            script.Text = "";
            string interfacename= "\toption interface '" + ifname.Text+"'\r\n";
            string targetname;
            string netmaskname = "\toption netmask '" + maskname.Text + "'\r\n";
            string gatewayname= "\toption gateway '" + gwname.Text + "'\r\n\r\n";
            string scripttext = "";

            for (int i = 0; i < ip.Lines.Length; i++)
            {
                string targetip = "\toption target '" + ip.Lines[i] + "'\r\n";
                //script.Text += ("route add -net "+ip.Lines[i]+ " netmask 255.255.255.0 gw "+textBox1.Text+"\r\n");
                scripttext += ("config route\r\n"+targetip+interfacename+netmaskname+gatewayname);
            }
            script.Text = scripttext;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            script.Text = "";
            string scripttext = "";
            string netmasknamename = maskname.Text;
            for (int i = 0; i < ip.Lines.Length; i++)
            {

                string targetip = "\toption target '" + ip.Lines[i] + "'\r\n";
                scripttext += ("route add -net "+ip.Lines[i]+ $" netmask {netmasknamename} gw "+gwname.Text+"\r\n");
                //scripttext += ("config route\r\n" + targetip + interfacename + netmaskname + gatewayname);
            }
            script.Text = scripttext;
        }
    }
}
