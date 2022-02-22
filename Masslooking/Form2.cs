using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace Masslooking
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var request = new HttpRequest();
            string response = request.Get("https://api.vk.com/method/stories.getbyid?" + "&access_token=" + textBox2.Text + "&v=5.120").ToString();
            request.Close();
            richTextBox1.Text = response.ToString();
        }
    }
}
