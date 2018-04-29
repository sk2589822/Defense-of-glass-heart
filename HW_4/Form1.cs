using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace HW_4
{
    public partial class Form1 : Form
    {
        bool readed, poisoned=false;
        int roll;
        int min , sec , cd , hp;
        int destiny_count;
        int quake_count,quake_time;
        int hp_down;
        int anarchy_count;
        int slow_count;
        int heart_break=100;
        Point origin;
        Bitmap poison = new Bitmap("poisoned.png");
        Bitmap money = new Bitmap("money.jpg");
        Bitmap down = new Bitmap("down.jpg");
        Bitmap geau = new Bitmap("geau.jpg");
        Bitmap heart_r2b = new Bitmap("heart_ready_to_break.png");
        Bitmap heart_b = new Bitmap("heart_break.png");
        Bitmap Yang_d = new Bitmap("Yang_die.jpg");
        string[] Yang_dictionary = new string[] { "689", "9.2", "2016唯一支持連勝文","唯有勝文，勝過英文","無限期支持勝文酸宗痛", "馬芙丸", "死亡之握",
                                                  "一個總統，施政滿意度只剩18%，就可以下台了","馬卡茸", "Ma the bumbler", "油電雙掌", "終極統一","水母腦",
                                                  "總統，你是我的巧克力","猿人", "西海岸","抓到了，柯P又失言，請退選", "柯文哲有良知的話，就該退選","下去領500",
                                                  "ゴミ丼","?","?","?","?"};
        List<Label> fall = new List<Label>();

        public Form1()
        {
            InitializeComponent();
        }

        //Menu load
        private void Menu_Load()
        {

            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Menu_BGM.wav");
            Player.PlayLooping();
            panel_Menu.Visible = true;
            timer_load.Enabled = true;
            label_instruction.Visible = false;
            panel_Instruction.Visible = false;
            timer_instruction.Enabled = false;
            panel_Game.Visible = false;
            timer_gameover.Enabled = false;
            pictureBox_Yang_die.Visible = false;
            MediaPlayer_damage.settings.autoStart = false;
            MediaPlayer_damage.settings.volume = 100;
            MediaPlayer_skill.settings.autoStart = false;
            MediaPlayer_skill.settings.volume = 100;
            MediaPlayer_event.settings.autoStart = false;
            MediaPlayer_event.settings.volume = 100;
            pic_title.Top = -250;
            pic_Yang.Height = 0;
            min = 0;
            sec = 0;
            cd = 0;
            hp = 300;
            roll = 1;
            quake_count = -1;
            destiny_count = -1;
            anarchy_count = -1;
            slow_count = -1;
            label_gameover.Text = "";
            pictureBox_destiny.Height = 500;
            pictureBox_destiny.Width = 1000;
            label_hp.ForeColor = Color.Crimson;
            pictureBox_hp.BackColor = Color.Red;
            poisoned = false;
            pictureBox_show.Image = null;

            //改圖
            Color de = heart_r2b.GetPixel(0, 0);
            for (int i = 0; i < heart_r2b.Width; i++)
            {
                for (int j = 0; j < heart_r2b.Height; j++)
                {
                    if (heart_r2b.GetPixel(i, j) != de)
                    {
                        Yang_d.SetPixel(i + 830, j + 500, heart_r2b.GetPixel(i, j));
                    }
                }
            }
        }

        //Instruction load
        private void Instruction_Load()
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Instruction_BGM.wav");
            Player.PlayLooping();
            label_instruction.Text = "你必須輸入和酸民們的相同的字串來抵銷它們\n\n";
            label_instruction.Text += "在此遊戲中，為了防止楊智凱那顆脆弱的玻璃心被酸民們的酸言酸語擊碎\n\n";
            label_instruction.Text += "同學們認為機不可失，決定化身為正義的酸民，對楊智凱展開反擊\n\n";
            label_instruction.Text += "苦撐至今，KMT風波不斷——太陽花學運、馬王政爭等等，現在甚至連個候選人都喬不好\n\n";
            label_instruction.Text += "只好忍氣吞聲，畢竟留得青山在，不怕沒柴燒，反擊的號角總有一天會響起的\n\n";
            label_instruction.Text += "對此，很多同學都無法忍受，但是怕在家玩電腦玩到一半突然被麥當勞歡樂送\n\n";
            label_instruction.Text += "身為一個資深689，每次吃飯看新聞時，總是在宣揚他們的馬區長的豐功偉業\n\n";
            label_instruction.Text += "資工系二年級有一位來自大甲的孩子，名叫楊智凱\n\n";

            label_instruction.Top = -430;
            timer_instruction.Enabled = true;
            panel_Menu.Visible = false;
            panel_Instruction.Visible = true;
            label_instruction.Visible = true;

        }

        //Gmae load
        private void Gmae_Load()
        {
            panel_Menu.Visible = false;
            panel_Instruction.Visible = false;
            panel_Game.Width = 1600;
            panel_Game.Height = 1000;
            panel_Game.Visible = true;
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Game_BGM.wav");
            Player.PlayLooping();
            min = 0;
            sec = 0;
            cd = 0;
            hp = 300;
            label_Livetime.Text = String.Format("{0:00}", min) + ":" + String.Format("{0:00}", sec);
            timer_time.Enabled = true;
            label_CD.Text = "共用冷卻：" + String.Format("{0:00}", cd) + "秒";
            timer_Make_word.Enabled = true;
            timer_word_fall.Enabled = true;
            pictureBox_hp.Width = 300;
            button_skill_anarchy.Enabled = true;
            button_skill_destiny.Enabled = true;
            button_skill_earthquake.Enabled = true;
            button_skill_slow.Enabled = true;
            pictureBox_show.Image = null;
            label_skill.Text = "";
            label_state.Text = "";
            label_hp.Text = hp + " ／ 300";
            label_Deadline.Top = 900;
            poisoned = false;
            label_Deadline.SendToBack();
            pictureBox_show.SendToBack();
            label_skill.SendToBack();

            textBox_Type.Focus();
        }

        //Load
        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("記得開喇叭，音量調小聲一點");
            //去背
            pic_Yang.Image = new Bitmap("Yang.jpg");
            Bitmap title = new Bitmap("Title.png");
            for (int i = 235; i <= 255; i++)
            {
                title.MakeTransparent(Color.FromArgb(i, i, i));
            }
            pic_title.Image = title;


            pictureBox_Yang_die.Image = Yang_d;
            //改紫色
            for (int i = 0; i < 512; i++)
            {
                for (int j = 0; j < 512; j++)
                {
                    if (poison.GetPixel(i, j) != poison.GetPixel(0, 0))
                    {
                        poison.SetPixel(i, j, Color.Purple);
                    }
                }
            } 

            Menu_Load();
            origin = new Point(this.Left, this.Top);
        }

        //Load Timer
        private void timer_load_Tick(object sender, EventArgs e)
        {
            if(pic_title.Top<0)
            {
                pic_title.Top++;
            }
            else if (pic_Yang.Height < 480)
            {
                pic_Yang.Height+=2;
            }
            else
            {
                timer_load.Enabled = false;
            }
        }

        //遊戲說明
        private void button_Instruction_Click(object sender, EventArgs e)
        {
            Instruction_Load();
        }

        //故事下降的Timer
        private void timer_instruction_Tick(object sender, EventArgs e)
        {
            if(label_instruction.Top<=30)
            {
                label_instruction.Top+=roll;
            }
            else
            {
                readed = true;
                timer_instruction.Enabled = false;       
            }
        }

        //快轉
        private void button_Skip_MouseDown(object sender, MouseEventArgs e)
        {
            timer_instruction.Interval = 1;
            roll = 3;
        }

        //正常速度
        private void button_Skip_MouseUp(object sender, MouseEventArgs e)
        {
            timer_instruction.Interval = 50;
            roll = 1;
        }

        //回主畫面
        private void button_Back_to_Menu_Click(object sender, EventArgs e)
        {
            button_Back_to_Menu2.Visible = false;
            Menu_Load();
        }

        //開始遊戲
        private void button_Start_Click(object sender, EventArgs e)
        {
            if(!readed)
            {
                MessageBox.Show("沒看完遊戲說明也想玩？");
            }
            else
            {
                Gmae_Load();   
            }
            
        }

        //產生字
        private void timer_Make_word_Tick(object sender, EventArgs e)
        {
            Random ran1 = new Random(Guid.NewGuid().GetHashCode());
            Random ran2 = new Random(Guid.NewGuid().GetHashCode());
            int num=Yang_dictionary.Count();
            int r = ran1.Next(num);

            Label label_tmp=new Label();
            label_tmp.Text = Yang_dictionary[r];
            label_tmp.Top = -10;
            label_tmp.Left = ran2.Next(800);
            label_tmp.Name = label_tmp.Text;
            label_tmp.Font = new Font("華康中圓體", 14);
            label_tmp.AutoSize = true;
            label_tmp.BringToFront();
            panel_Game.Controls.Add(label_tmp);
            fall.Add(label_tmp);
        }

        //掉落字
        private void timer_word_fall_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < fall.Count; i++)
            {
                if(fall[i].Text=="HP-20")
                {
                    if (timer_anarchy.Enabled)
                    {
                        fall[i].Top-=2;
                    }
                    fall[i].Top--;
                    if(label_Deadline.Top-fall[i].Top>=50)
                    {
                        panel_Game.Controls.RemoveByKey(fall[i].Name);
                        fall.RemoveAt(i);
                    }
                }
                else
                {
                    fall[i].Top++;
                    if (fall[i].Top + 20 >= label_Deadline.Top)
                    {
                        fall[i].ForeColor = Color.Red;
                        fall[i].Text = "HP-20";
                        HP_down(20);
                    }
                }
            }
        }

        //輸入
        private void textBox_Type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool cor = false;
                string input = textBox_Type.Text;
                textBox_Type.Text = "";
                
                if (input == "楊智凱衝到學校盛了一整罐中水喝")
                {
                    if(poisoned)
                    {
                        cor = true;
                        label_hp.ForeColor = Color.Crimson;
                        pictureBox_hp.BackColor = Color.Red;
                        poisoned = false;
                        pictureBox_show.Image = new Bitmap("heal.jpg");
                        MediaPlayer_event.URL = "Heal.wav";
                        MediaPlayer_event.Ctlcontrols.play();
                        label_state.Text = "智凱解毒成功，高興";
                    }
                }
                else
                {
                    for(int i=0;i<fall.Count;i++)
                    {
                        if(input==fall[i].Text)
                        {
                            cor = true;
                            panel_Game.Controls.RemoveByKey(fall[i].Text);
                            fall.RemoveAt(i);
                            if (input == "?")
                            {
                                Random ran = new Random(Guid.NewGuid().GetHashCode());
                                int r = ran.Next(4);
                                switch (r)
                                {
                                    case 0:
                                        poisoned = true;
                                        pictureBox_show.Image = poison;
                                        label_state.Text = "智凱中毒了！ \n快輸入「楊智凱衝到學校\n盛了一整罐中水喝」來解毒";
                                        MediaPlayer_event.URL = "Poison.wav";
                                        MediaPlayer_event.Ctlcontrols.play();
                                        label_hp.ForeColor = Color.Purple;
                                        pictureBox_hp.BackColor = Color.Purple;
                                        break;
                                    case 1:
                                        label_state.Text = "智凱感念你的大恩大德\n決定表演拿手絕活給你看\n智凱使出了「假摔」，HP-30";
                                        HP_down(30);
                                        MediaPlayer_event.URL = "fall_down.wav";
                                        MediaPlayer_event.Ctlcontrols.play();
                                        pictureBox_show.Image = down;
                                        
                                        break;
                                    case 2:
                                        label_state.Text = "智凱的錢又被室友偷了\n智凱傷心，HP-10";
                                        HP_down(10);
                                        MediaPlayer_event.URL = "money.wav";
                                        MediaPlayer_event.Ctlcontrols.play();
                                        pictureBox_show.Image = money;
                                        
                                        break;
                                    case 3:
                                        label_state.Text = "智凱裝會，自己使用了技能";
                                        MediaPlayer_event.URL = "clap.wav";
                                        MediaPlayer_event.Ctlcontrols.play();
                                        int r1 = ran.Next(4);
                                        if (r1 == 0)
                                        {
                                            button_skill_slow_Click(sender, e);
                                        }
                                        else if (r1 == 1)
                                        {
                                            button_skill_destiny_Click(sender, e);
                                        }
                                        else if (r1 == 2)
                                        {
                                            button_skill_earthquake_Click(sender, e);
                                        }
                                        else
                                        {
                                            button_anarchy_Click(sender, e);
                                        }
                                        pictureBox_show.Image = geau;
                                        break;
                                }
                            }
                            else
                            {
                                MediaPlayer_answer.URL = "correct.wav";
                                MediaPlayer_answer.Ctlcontrols.play();
                            }
                            break;
                        }
                    }
                    if (!cor)
                    {
                        MediaPlayer_answer.URL = "incorrect.wav";
                        MediaPlayer_answer.Ctlcontrols.play();
                    }
                }
            }
        }

        //扣HP
        private void HP_down(int damage)
        {
            timer_hp_down.Enabled = true;
            hp_down += damage;
            MediaPlayer_damage.URL = "HP_down.wav";
            MediaPlayer_damage.Ctlcontrols.play();

        }

        //扣HP Timer
        private void timer_hp_down_Tick(object sender, EventArgs e)
        {
            if(hp_down>0)
            {
                hp--;
                label_hp.Text = hp + " ／ 300";
                pictureBox_hp.Width--;
                hp_down--;
                if(hp==0)
                {
                    timer_hp_down.Enabled = false;
                    Gameover();
                }
            }
            else
            {
                timer_hp_down.Enabled = false;   
            }
        }

        //使用技能
        private bool skill_use()
        {
            textBox_Type.Focus();
            if (!timer_CD.Enabled)
            {
                cd = 15;
                label_CD.Text = "共用冷卻：" + String.Format("{0:00}", cd) + "秒";
                timer_CD.Enabled = true;
                return true;
            }
            else
            {
                label_CDNotOK.Visible = true;
                return false;
            }
        }

        //緩速光波
        private void button_skill_slow_Click(object sender, EventArgs e)
        {
            if(skill_use())
            {
                label_skill.Text = "智凱對你使用了「緩速光波」\n被緩速的你\n覺得身邊的一切都動的無比快速";
                slow_count = 3;
                timer_word_fall.Interval /= 4;
            } 
        }

        //預知未來
        private void button_skill_destiny_Click(object sender, EventArgs e)
        {
            if (skill_use())
            {
                label_skill.Text = "智凱使用了「預知未來」\n看到了5秒後會有大地震\n急忙地把你壓到桌子下避難\n視野因此損失了一大半\n";
                pictureBox_destiny.Visible = true;
                destiny_count = 5;
            }
        }

        //天崩地裂
        private void button_skill_earthquake_Click(object sender, EventArgs e)
        {
            if (skill_use())
            {
                quake_count = 3;
                label_skill.Text = "智凱為了使出「天崩地裂」\n正在集氣……";
            }
        }

        //天崩地裂 Timer
        private void timer_quake_Tick(object sender, EventArgs e)
        {
            if (quake_time > 0)
            {
                Random ran = new Random(Guid.NewGuid().GetHashCode());
                Point new_location = new Point(origin.X + ran.Next(150), origin.Y + ran.Next(150));
                new_location.X -= ran.Next(150);
                new_location.Y -= ran.Next(150);
                this.Location = new System.Drawing.Point(new_location.X, new_location.Y);
                quake_time--;
            }
            else
            {
                this.Location = new System.Drawing.Point(origin.X, origin.Y);
                timer_quake.Enabled = false;
                label_skill.Font = new Font(label_skill.Font.Name, 16);
                label_skill.Text = "智凱筋疲力盡，HP-30";
                HP_down(30);
            }
        }

        //無法無天
        private void button_anarchy_Click(object sender, EventArgs e)
        {
            if (skill_use())
            {
                label_skill.Text = "智凱再也受不了LAR\n失心瘋的智凱不顧你的勸阻\n硬是往前要跟酸民們拚個你死我活\n智凱與酸民間的距離不斷縮短\n";
                anarchy_count = 200;
                timer_anarchy.Enabled = true;
            }
        }

        //無法無天 Timer
        private void timer_anarchy_Tick(object sender, EventArgs e)
        {
            if(anarchy_count>0)
            {
                label_Deadline.Top--;
                anarchy_count--;
            }
            else if(anarchy_count==0)
            {
                label_skill.Text += "但在路上卻跌了個狗吃屎\nHP-30";
                HP_down(30);
                timer_anarchy.Enabled = false;
                anarchy_count = -1;
            }
        }

        //冷卻Timer
        private void timer_CD_Tick(object sender, EventArgs e)
        {
            cd--;
            label_CD.Text = "共用冷卻：" + String.Format("{0:00}", cd) + "秒";
            if (cd == 0)
            {
                label_skill.Text = "";
                timer_CD.Enabled = false;
                label_CDNotOK.Visible = false;
            }
        }

        //時間Timer
        private void timer_time_Tick(object sender, EventArgs e)
        {
            //存活時間
            sec++;
            if(sec%10==0)
            {
                timer_Make_word.Interval -= 200;
            }
            if(sec==60)
            {
                min++;
                sec = 0;
            }
            label_Livetime.Text = String.Format("{0:00}", min) + ":" + String.Format("{0:00}", sec);

            //中毒扣HP
            if(poisoned)
            {
                HP_down(5);
            }

            //緩速光波倒數
            if (slow_count>0)
            {
                slow_count--;
            }
            else if (slow_count==0)
            {
                slow_count = -1;
                label_skill.Text = "緩速解除了\n由於緩速光波施法極需注意力\n智凱腦細胞死了一大票，HP-40";
                timer_word_fall.Interval *=4;
                HP_down(40);
            }

            //預知未來倒數
            if (destiny_count > 0)
            {
                label_skill.Text += destiny_count + "……";
                destiny_count--;
            }
            else if (destiny_count==0)
            {
                destiny_count = -1;
                pictureBox_destiny.Visible = false;
                label_skill.Text = "可是什麼都沒發生\n你從桌子底下爬出\n氣沖沖的給了智凱一拳\n智凱痛哭流涕，身心受到嚴重傷害\nHP-50";
                HP_down(50);
            }
            //天崩地裂倒數
            if(quake_count>0)
            {
                label_skill.Text += quake_count + "……";
                quake_count--;
            }
            else if(quake_count==0)
            {
                MediaPlayer_skill.URL = "quake.wav";
                MediaPlayer_skill.Ctlcontrols.play();
                quake_count = -1;
                label_skill.Font = new Font(label_skill.Font.Name, 36);
                label_skill.Text = "天崩地裂！";
                quake_time = 500;
                timer_quake.Enabled = true;
            }

        }

        //遊戲結束
         private void Gameover()
        {
             System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Victory.wav");
             Player.PlayLooping();

             timer_gameover.Enabled = true;
             timer_Make_word.Enabled = false;
             timer_word_fall.Enabled = false;
             timer_time.Enabled = false;
             timer_CD.Enabled = false;
             pictureBox_Yang_die.Visible = true;
             pictureBox_Yang_die.Height = 0;
             pictureBox_Yang_die.Top = 800;
             button_skill_anarchy.Enabled = false;
             button_skill_destiny.Enabled = false;
             button_skill_earthquake.Enabled = false;
             button_skill_slow.Enabled = false;


             while(fall.Count>0)
             {
                 panel_Game.Controls.RemoveByKey(fall[0].Name);
                 fall.RemoveAt(0);
             }
        }

        //遊戲結束 Timer
         private void timer_gameover_Tick(object sender, EventArgs e)
         {
             if(panel_Game.Height>100)
             {
                 panel_Game.Height-=2;
                 if (panel_Game.Height <= 800 && pictureBox_Yang_die.Height<576)
                 {
                     pictureBox_Yang_die.Height+=2;
                     pictureBox_Yang_die.Top-=2;
                 }
             }
             else if(heart_break>0)
             {
                 heart_break--;
             }
             else 
             {
                 label_gameover.Text = "你沒有守護好智凱的玻璃心，KMT下次總統大選又少了一票，嗚呼哀哉\n";
                 timer_gameover.Enabled = false;
                 //改圖
                 Yang_d = new Bitmap("Yang_die.jpg");
                 Color de = heart_b.GetPixel(0, 0);
                 for (int i = 0; i < heart_b.Width; i++)
                 {
                     for (int j = 0; j < heart_b.Height; j++)
                     {
                         if (heart_b.GetPixel(i, j) != de)
                         {
                             Yang_d.SetPixel(i + 830, j + 500, heart_b.GetPixel(i, j));
                         }
                     }
                 }
                 MediaPlayer_event.URL = "broke.wav";
                 MediaPlayer_event.Ctlcontrols.play();
                 pictureBox_Yang_die.Image = Yang_d;
                 button_Back_to_Menu2.Visible = true;
             }
         }
    }
}
