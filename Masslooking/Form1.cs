using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Masslooking1;
using Newtonsoft.Json;
using xNet;

namespace Masslooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var request = new HttpRequest();
            string response = request.Get("https://api.vk.com/method/stories.search?q=" + textBox1.Text + "&fields=1&count=" + textBox3.Text + "&access_token=" + textBox2.Text + "&v=5.120").ToString();
            request.Close();
            Rooter rooter;
            rooter = JsonConvert.DeserializeObject<Rooter>(response);
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox2.Text = "По запросу " + textBox1.Text + " было найдено " + rooter.response.count.ToString() + " историй." + "\n";
            for (int i = 0; i < rooter.response.count; i++)
            {
                richTextBox2.Text += "ID " + rooter.response.items[i].stories[0].id.ToString() + "\n";
                richTextBox2.Text += "OWNER_ID " + rooter.response.items[i].stories[0].owner_id.ToString() + "\n";
                CreateLink(rooter.response.items[i].stories[0].id, rooter.response.items[i].stories[0].owner_id);
            }
        }
        private void CreateLink(int id, int owner_id)
        {
            System.Threading.Thread.Sleep(10);
            //richTextBox3.Text += "https://vk.com/id" + owner_id + "?w=story" + owner_id + "_" + id + "\n";
            richTextBox3.Text += "https://vk.com/id" + owner_id + "?w=story" + owner_id + "_" + id + "/Fowner_feed" + owner_id + "\n";
        }

        private void LikeStory()
        {
            var request = new HttpRequest();
            string response = request.Get("https://api.vk.com/method/wall.get?domain=gifkaon&count=100" + "&access_token=" + textBox2.Text + "&v=5.120").ToString();
            //string response = request.Get("https://api.vk.com/method/user.stories.markSeen?" + "access_token=" + textBox2.Text + "&v=5.122").ToString();
            request.Close();
            //richTextBox2.Text = response.ToString();
            Root roott;
            roott = JsonConvert.DeserializeObject<Root>(response);
            for (int i = 0; i < roott.response.count; i++)
            {
                try
                {
                    richTextBox2.Text += roott.response.items[i].text.ToString() + '\n';
                }
                catch (Exception)
                {
                    richTextBox3.Text = "Error";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LikeStory();//int owner_id, int item_id, string access_key
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var request = new HttpRequest();
            string response = request.Get("https://oauth.vk.com/access_token?client_id=" + textBox1.Text + "&client_secret=" + textBox3.Text + "&v=5.122&grant_type=client_credentials").ToString();
            request.Close();
            //textBox1.Text = response.ToString();
        }
    }
}
