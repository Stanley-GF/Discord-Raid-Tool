using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form1 : Form
    {
        private DiscordSocketClient _client;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cxFlatGroupBox9.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            _client = new DiscordSocketClient();

            textBox1.PasswordChar = '*';
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));

            foreach (SocketTextChannel chan in guild.TextChannels)
            {


                try
                {
                    await chan.DeleteAsync();

                }
                catch (Exception)
                {



                }

            }
            MessageBox.Show("Done ! ");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox4.Text);
            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));


            for (int i = 0; i < number; i++)
            {
                try
                {
                    await guild.CreateTextChannelAsync(textBox2.Text.Replace(' ', '-'));
                }

                catch (Exception)
                {


                }

            }
        }





        private async void button7_Click(object sender, EventArgs e)
        {

            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
            try
            {
                foreach (var item in guild.Roles)
                {
                    await item.DeleteAsync();
                }
                MessageBox.Show("Done !");

            }
            catch (Exception)
            {

                
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }



        private void button9_Click(object sender, EventArgs e)
        {

        }

        private async void button10_Click(object sender, EventArgs e)
        {

            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
            try
            {
                foreach (var user in guild.Users)
                {
                    await user.ModifyAsync(x => {
                        x.Nickname = textBox9.Text;
                    });
                }
                MessageBox.Show("Done !");

            }
            catch (Exception)
            {


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        
        }

        private async void button1_Click(object sender, EventArgs e)
        {


            try
            {
                cxFlatGroupBox9.Visible = true;
                button1.Enabled = false;
                textBox1.Enabled = false;
                await _client.LoginAsync(TokenType.Bot, textBox1.Text);
                await _client.StartAsync();
                System.Threading.Thread.Sleep(3500);
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label4.Text = "Total guild : " + _client.Guilds.Count;
                label3.Text = "Created at : " + _client.CurrentUser.CreatedAt;
                label2.Text = "ID : " + _client.CurrentUser.Id;
                label1.Text = "Name : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator;

                if (_client.CurrentUser.GetAvatarUrl() == null)
                {
                    pictureBox1.Load("https://cdn.discordapp.com/attachments/727993439748227182/749232311001677854/gGWDJSghKgd8QAAAABJRU5ErkJggg.png");

                }
                else
                {
                    pictureBox1.Load(_client.CurrentUser.GetAvatarUrl().ToString());

                }


                foreach (var item in _client.Guilds)
                {
                    try
                    {
                        comboBox1.Items.Add(item.Name.ToString() + @"|" + item.Id.ToString());
                    }
                    catch (Exception)
                    {




                    }
                }


            }
            catch (Exception)
            {


            }
        }

        private async void cxFlatRoundButton1_Click(object sender, EventArgs e)
        {

            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
            try
            {
                foreach (SocketUser user in guild.Users)
                {
                    await guild.AddBanAsync(user, 0, cxFlatTextBox6.Text);
                }
                MessageBox.Show("Done !");

            }
            catch (Exception)
            {


            }
        }

        private async void cxFlatRoundButton1_Click_1(object sender, EventArgs e)
        {
            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));

            foreach (SocketTextChannel chan in guild.TextChannels)
            {


                try
                {
                    await chan.DeleteAsync();

                }
                catch (Exception)
                {



                }

            }
            MessageBox.Show("Done ! ");
        }

        private async void cxFlatRoundButton2_Click(object sender, EventArgs e)
        {

            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));

            foreach (SocketVoiceChannel chan in guild.VoiceChannels)
            {


                try
                {
                    await chan.DeleteAsync();

                }
                catch (Exception)
                {



                }

            }
            MessageBox.Show("Done !");
        }

        private async void cxFlatRoundButton3_Click(object sender, EventArgs e)
        {
            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
            try
            {
                foreach (var user in guild.Users)
                {
                    await user.ModifyAsync(x => {
                        x.Nickname = textBox9.Text;
                    });
                }
                MessageBox.Show("Done !");

            }
            catch (Exception)
            {


            }
        }

        private async void cxFlatRoundButton4_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox4.Text);
            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));


            for (int i = 0; i < number; i++)
            {
                try
                {
                    await guild.CreateTextChannelAsync(textBox2.Text.Replace(' ', '-'));
                }

                catch (Exception)
                {


                }

            }
        }

        private async void cxFlatRoundButton5_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(cxFlatTextBox2.Text);
            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
            for (int i = 0; i < number; i++)
            {
                try
                {
                    await guild.CreateRoleAsync(cxFlatTextBox3.Text);
                }

                catch (Exception)
                {


                }

            }
            MessageBox.Show("done :)");
        }

        private async void cxFlatRoundButton6_Click(object sender, EventArgs e)
        {
            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
            try
            {
                foreach (var item in guild.Roles)
                {
                    await item.DeleteAsync();
                }
                MessageBox.Show("Done !");

            }
            catch (Exception)
            {


            }
        }

        private async void cxFlatRoundButton7_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(cxFlatTextBox4.Text);
            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));


            for (int i = 0; i < number; i++)
            {
                try
                {
                    await guild.CreateVoiceChannelAsync(cxFlatTextBox5.Text);
                }

                catch (Exception)
                {


                }

            }
        }

        private async void cxFlatRoundButton8_Click(object sender, EventArgs e)
        {

            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
            try
            {
                foreach (var user in guild.Users)
                {
                    await user.SendMessageAsync(cxFlatTextBox1.Text);
                }
            }
            catch (Exception)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

            string arg = comboBox1.Text;
            string separator = @"|";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();

            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));

            label9.Visible = true;
            label9.Text = "Name : " + guild.Name;
            label12.Visible = true;

            label16.Visible = true;
            label17.Visible = true;
            label12.Text = "ID : " + guild.Id.ToString();
            label16.Text = "Total Channel : " + guild.TextChannels.Count() + guild.VoiceChannels.Count().ToString();
            label17.Text = guild.CreatedAt.ToString();
            if (guild.IconUrl == null)
            {
                pictureBox2.Load("https://cdn.discordapp.com/attachments/727993439748227182/749232311001677854/gGWDJSghKgd8QAAAABJRU5ErkJggg.png");
            }
            else
            {
                pictureBox2.Load(guild.IconUrl.ToString());
            }
        }

        private void rainbowButton1_Click(object sender, EventArgs e)
        {

        }

        private void cxFlatButton1_Click(object sender, EventArgs e)
        {
            _client.SetGameAsync(cxFlatTextBox7.Text);
        }
    }
}
