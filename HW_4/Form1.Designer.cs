namespace HW_4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Instruction = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_instruction = new System.Windows.Forms.Label();
            this.timer_instruction = new System.Windows.Forms.Timer(this.components);
            this.button_Skip = new System.Windows.Forms.Button();
            this.button_Back_to_Menu = new System.Windows.Forms.Button();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.pic_title = new System.Windows.Forms.PictureBox();
            this.pic_Yang = new System.Windows.Forms.PictureBox();
            this.panel_Instruction = new System.Windows.Forms.Panel();
            this.panel_Game = new System.Windows.Forms.Panel();
            this.pictureBox_destiny = new System.Windows.Forms.PictureBox();
            this.label_skill = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.label_CDNotOK = new System.Windows.Forms.Label();
            this.label_Deadline = new System.Windows.Forms.Label();
            this.pictureBox_show = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_hp = new System.Windows.Forms.PictureBox();
            this.label_CD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_hp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.button_skill_anarchy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Livetime = new System.Windows.Forms.Label();
            this.button_skill_earthquake = new System.Windows.Forms.Button();
            this.button_skill_destiny = new System.Windows.Forms.Button();
            this.button_skill_slow = new System.Windows.Forms.Button();
            this.MediaPlayer_damage = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer_load = new System.Windows.Forms.Timer(this.components);
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.timer_CD = new System.Windows.Forms.Timer(this.components);
            this.timer_Make_word = new System.Windows.Forms.Timer(this.components);
            this.timer_quake = new System.Windows.Forms.Timer(this.components);
            this.timer_hp_down = new System.Windows.Forms.Timer(this.components);
            this.timer_anarchy = new System.Windows.Forms.Timer(this.components);
            this.timer_word_fall = new System.Windows.Forms.Timer(this.components);
            this.timer_gameover = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Yang_die = new System.Windows.Forms.PictureBox();
            this.button_Back_to_Menu2 = new System.Windows.Forms.Button();
            this.label_gameover = new System.Windows.Forms.Label();
            this.MediaPlayer_skill = new AxWMPLib.AxWindowsMediaPlayer();
            this.MediaPlayer_event = new AxWMPLib.AxWindowsMediaPlayer();
            this.MediaPlayer_answer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Yang)).BeginInit();
            this.panel_Instruction.SuspendLayout();
            this.panel_Game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_destiny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer_damage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yang_die)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer_skill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer_event)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer_answer)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Instruction
            // 
            this.button_Instruction.Font = new System.Drawing.Font("華康中圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Instruction.Location = new System.Drawing.Point(101, 761);
            this.button_Instruction.Name = "button_Instruction";
            this.button_Instruction.Size = new System.Drawing.Size(200, 50);
            this.button_Instruction.TabIndex = 0;
            this.button_Instruction.Text = "遊戲說明";
            this.button_Instruction.UseVisualStyleBackColor = true;
            this.button_Instruction.Click += new System.EventHandler(this.button_Instruction_Click);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("華康中圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Start.Location = new System.Drawing.Point(101, 846);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(200, 50);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "遊戲開始";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_instruction
            // 
            this.label_instruction.AutoSize = true;
            this.label_instruction.Font = new System.Drawing.Font("華康中圓體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_instruction.Location = new System.Drawing.Point(27, 22);
            this.label_instruction.Name = "label_instruction";
            this.label_instruction.Size = new System.Drawing.Size(0, 27);
            this.label_instruction.TabIndex = 1;
            // 
            // timer_instruction
            // 
            this.timer_instruction.Interval = 50;
            this.timer_instruction.Tick += new System.EventHandler(this.timer_instruction_Tick);
            // 
            // button_Skip
            // 
            this.button_Skip.Font = new System.Drawing.Font("華康中圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Skip.Location = new System.Drawing.Point(67, 59);
            this.button_Skip.Name = "button_Skip";
            this.button_Skip.Size = new System.Drawing.Size(200, 50);
            this.button_Skip.TabIndex = 2;
            this.button_Skip.Text = "快轉";
            this.button_Skip.UseVisualStyleBackColor = true;
            this.button_Skip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Skip_MouseDown);
            this.button_Skip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Skip_MouseUp);
            // 
            // button_Back_to_Menu
            // 
            this.button_Back_to_Menu.Font = new System.Drawing.Font("華康中圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Back_to_Menu.Location = new System.Drawing.Point(67, 138);
            this.button_Back_to_Menu.Name = "button_Back_to_Menu";
            this.button_Back_to_Menu.Size = new System.Drawing.Size(200, 50);
            this.button_Back_to_Menu.TabIndex = 2;
            this.button_Back_to_Menu.Text = "回主畫面";
            this.button_Back_to_Menu.UseVisualStyleBackColor = true;
            this.button_Back_to_Menu.Click += new System.EventHandler(this.button_Back_to_Menu_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.pic_title);
            this.panel_Menu.Controls.Add(this.button_Instruction);
            this.panel_Menu.Controls.Add(this.pic_Yang);
            this.panel_Menu.Controls.Add(this.button_Start);
            this.panel_Menu.Location = new System.Drawing.Point(590, 12);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(400, 954);
            this.panel_Menu.TabIndex = 3;
            // 
            // pic_title
            // 
            this.pic_title.Location = new System.Drawing.Point(3, 3);
            this.pic_title.Name = "pic_title";
            this.pic_title.Size = new System.Drawing.Size(397, 157);
            this.pic_title.TabIndex = 7;
            this.pic_title.TabStop = false;
            // 
            // pic_Yang
            // 
            this.pic_Yang.BackColor = System.Drawing.Color.Transparent;
            this.pic_Yang.Location = new System.Drawing.Point(50, 166);
            this.pic_Yang.Name = "pic_Yang";
            this.pic_Yang.Size = new System.Drawing.Size(300, 450);
            this.pic_Yang.TabIndex = 6;
            this.pic_Yang.TabStop = false;
            // 
            // panel_Instruction
            // 
            this.panel_Instruction.Controls.Add(this.button_Skip);
            this.panel_Instruction.Controls.Add(this.button_Back_to_Menu);
            this.panel_Instruction.Location = new System.Drawing.Point(1302, 756);
            this.panel_Instruction.Name = "panel_Instruction";
            this.panel_Instruction.Size = new System.Drawing.Size(270, 194);
            this.panel_Instruction.TabIndex = 4;
            this.panel_Instruction.Visible = false;
            // 
            // panel_Game
            // 
            this.panel_Game.BackColor = System.Drawing.Color.Transparent;
            this.panel_Game.Controls.Add(this.pictureBox_destiny);
            this.panel_Game.Controls.Add(this.label_skill);
            this.panel_Game.Controls.Add(this.label_state);
            this.panel_Game.Controls.Add(this.label_CDNotOK);
            this.panel_Game.Controls.Add(this.label_Deadline);
            this.panel_Game.Controls.Add(this.pictureBox_show);
            this.panel_Game.Controls.Add(this.label3);
            this.panel_Game.Controls.Add(this.pictureBox_hp);
            this.panel_Game.Controls.Add(this.label_CD);
            this.panel_Game.Controls.Add(this.label4);
            this.panel_Game.Controls.Add(this.label_hp);
            this.panel_Game.Controls.Add(this.label2);
            this.panel_Game.Controls.Add(this.textBox_Type);
            this.panel_Game.Controls.Add(this.button_skill_anarchy);
            this.panel_Game.Controls.Add(this.label1);
            this.panel_Game.Controls.Add(this.label_Livetime);
            this.panel_Game.Controls.Add(this.button_skill_earthquake);
            this.panel_Game.Controls.Add(this.button_skill_destiny);
            this.panel_Game.Controls.Add(this.button_skill_slow);
            this.panel_Game.Controls.Add(this.MediaPlayer_damage);
            this.panel_Game.Location = new System.Drawing.Point(0, 0);
            this.panel_Game.Name = "panel_Game";
            this.panel_Game.Size = new System.Drawing.Size(50, 50);
            this.panel_Game.TabIndex = 5;
            this.panel_Game.Visible = false;
            // 
            // pictureBox_destiny
            // 
            this.pictureBox_destiny.BackColor = System.Drawing.Color.Black;
            this.pictureBox_destiny.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_destiny.Name = "pictureBox_destiny";
            this.pictureBox_destiny.Size = new System.Drawing.Size(10, 10);
            this.pictureBox_destiny.TabIndex = 16;
            this.pictureBox_destiny.TabStop = false;
            this.pictureBox_destiny.Visible = false;
            // 
            // label_skill
            // 
            this.label_skill.AutoSize = true;
            this.label_skill.Font = new System.Drawing.Font("華康中圓體", 14F);
            this.label_skill.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_skill.Location = new System.Drawing.Point(1084, 599);
            this.label_skill.Name = "label_skill";
            this.label_skill.Size = new System.Drawing.Size(0, 19);
            this.label_skill.TabIndex = 15;
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Font = new System.Drawing.Font("華康中圓體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_state.Location = new System.Drawing.Point(1069, 455);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(0, 24);
            this.label_state.TabIndex = 14;
            // 
            // label_CDNotOK
            // 
            this.label_CDNotOK.AutoSize = true;
            this.label_CDNotOK.Font = new System.Drawing.Font("華康中圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_CDNotOK.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label_CDNotOK.Location = new System.Drawing.Point(1420, 622);
            this.label_CDNotOK.Name = "label_CDNotOK";
            this.label_CDNotOK.Size = new System.Drawing.Size(136, 16);
            this.label_CDNotOK.TabIndex = 13;
            this.label_CDNotOK.Text = "冷卻時間尚未結束";
            this.label_CDNotOK.Visible = false;
            // 
            // label_Deadline
            // 
            this.label_Deadline.AutoSize = true;
            this.label_Deadline.Font = new System.Drawing.Font("華康中圓體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Deadline.ForeColor = System.Drawing.Color.Indigo;
            this.label_Deadline.Location = new System.Drawing.Point(3, 900);
            this.label_Deadline.Name = "label_Deadline";
            this.label_Deadline.Size = new System.Drawing.Size(1022, 22);
            this.label_Deadline.TabIndex = 12;
            this.label_Deadline.Text = "————————————————————智凱玻璃心最後防線—————————————————";
            // 
            // pictureBox_show
            // 
            this.pictureBox_show.Location = new System.Drawing.Point(1066, 115);
            this.pictureBox_show.Name = "pictureBox_show";
            this.pictureBox_show.Size = new System.Drawing.Size(300, 300);
            this.pictureBox_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_show.TabIndex = 11;
            this.pictureBox_show.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("華康中圓體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(1408, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "楊智凱存活時間";
            // 
            // pictureBox_hp
            // 
            this.pictureBox_hp.BackColor = System.Drawing.Color.Red;
            this.pictureBox_hp.Location = new System.Drawing.Point(1271, 793);
            this.pictureBox_hp.Name = "pictureBox_hp";
            this.pictureBox_hp.Size = new System.Drawing.Size(301, 30);
            this.pictureBox_hp.TabIndex = 9;
            this.pictureBox_hp.TabStop = false;
            // 
            // label_CD
            // 
            this.label_CD.AutoSize = true;
            this.label_CD.Font = new System.Drawing.Font("華康中圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_CD.Location = new System.Drawing.Point(1427, 178);
            this.label_CD.Name = "label_CD";
            this.label_CD.Size = new System.Drawing.Size(120, 16);
            this.label_CD.TabIndex = 8;
            this.label_CD.Text = "共用冷卻：00秒";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("華康中圓體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(1267, 717);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "楊智凱的玻璃心生命值";
            // 
            // label_hp
            // 
            this.label_hp.AutoSize = true;
            this.label_hp.Font = new System.Drawing.Font("華康中圓體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_hp.ForeColor = System.Drawing.Color.Crimson;
            this.label_hp.Location = new System.Drawing.Point(1267, 756);
            this.label_hp.Name = "label_hp";
            this.label_hp.Size = new System.Drawing.Size(109, 19);
            this.label_hp.TabIndex = 7;
            this.label_hp.Text = "300 ／ 300";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("華康中圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(1268, 858);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "輸入";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Font = new System.Drawing.Font("華康中圓體", 12F);
            this.textBox_Type.Location = new System.Drawing.Point(1271, 894);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(291, 23);
            this.textBox_Type.TabIndex = 5;
            this.textBox_Type.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Type_KeyDown);
            // 
            // button_skill_anarchy
            // 
            this.button_skill_anarchy.Font = new System.Drawing.Font("華康中圓體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_skill_anarchy.Location = new System.Drawing.Point(1411, 501);
            this.button_skill_anarchy.Name = "button_skill_anarchy";
            this.button_skill_anarchy.Size = new System.Drawing.Size(151, 90);
            this.button_skill_anarchy.TabIndex = 4;
            this.button_skill_anarchy.Text = "無法無天";
            this.button_skill_anarchy.UseVisualStyleBackColor = true;
            this.button_skill_anarchy.Click += new System.EventHandler(this.button_anarchy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("華康中圓體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(1459, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "技能";
            // 
            // label_Livetime
            // 
            this.label_Livetime.AutoSize = true;
            this.label_Livetime.Font = new System.Drawing.Font("華康中圓體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Livetime.ForeColor = System.Drawing.Color.LightCoral;
            this.label_Livetime.Location = new System.Drawing.Point(1449, 63);
            this.label_Livetime.Name = "label_Livetime";
            this.label_Livetime.Size = new System.Drawing.Size(0, 21);
            this.label_Livetime.TabIndex = 2;
            // 
            // button_skill_earthquake
            // 
            this.button_skill_earthquake.Font = new System.Drawing.Font("華康中圓體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_skill_earthquake.Location = new System.Drawing.Point(1411, 405);
            this.button_skill_earthquake.Name = "button_skill_earthquake";
            this.button_skill_earthquake.Size = new System.Drawing.Size(151, 90);
            this.button_skill_earthquake.TabIndex = 1;
            this.button_skill_earthquake.Text = "天崩地裂";
            this.button_skill_earthquake.UseVisualStyleBackColor = true;
            this.button_skill_earthquake.Click += new System.EventHandler(this.button_skill_earthquake_Click);
            // 
            // button_skill_destiny
            // 
            this.button_skill_destiny.Font = new System.Drawing.Font("華康中圓體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_skill_destiny.Location = new System.Drawing.Point(1411, 309);
            this.button_skill_destiny.Name = "button_skill_destiny";
            this.button_skill_destiny.Size = new System.Drawing.Size(151, 90);
            this.button_skill_destiny.TabIndex = 1;
            this.button_skill_destiny.Text = "預知未來";
            this.button_skill_destiny.UseVisualStyleBackColor = true;
            this.button_skill_destiny.Click += new System.EventHandler(this.button_skill_destiny_Click);
            // 
            // button_skill_slow
            // 
            this.button_skill_slow.Font = new System.Drawing.Font("華康中圓體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_skill_slow.Location = new System.Drawing.Point(1411, 213);
            this.button_skill_slow.Name = "button_skill_slow";
            this.button_skill_slow.Size = new System.Drawing.Size(151, 90);
            this.button_skill_slow.TabIndex = 1;
            this.button_skill_slow.Text = "緩速光波";
            this.button_skill_slow.UseVisualStyleBackColor = true;
            this.button_skill_slow.Click += new System.EventHandler(this.button_skill_slow_Click);
            // 
            // MediaPlayer_damage
            // 
            this.MediaPlayer_damage.Enabled = true;
            this.MediaPlayer_damage.Location = new System.Drawing.Point(1138, 3);
            this.MediaPlayer_damage.Name = "MediaPlayer_damage";
            this.MediaPlayer_damage.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer_damage.OcxState")));
            this.MediaPlayer_damage.Size = new System.Drawing.Size(75, 56);
            this.MediaPlayer_damage.TabIndex = 0;
            this.MediaPlayer_damage.Visible = false;
            // 
            // timer_load
            // 
            this.timer_load.Interval = 5;
            this.timer_load.Tick += new System.EventHandler(this.timer_load_Tick);
            // 
            // timer_time
            // 
            this.timer_time.Interval = 1000;
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // timer_CD
            // 
            this.timer_CD.Interval = 1000;
            this.timer_CD.Tick += new System.EventHandler(this.timer_CD_Tick);
            // 
            // timer_Make_word
            // 
            this.timer_Make_word.Interval = 5000;
            this.timer_Make_word.Tick += new System.EventHandler(this.timer_Make_word_Tick);
            // 
            // timer_quake
            // 
            this.timer_quake.Interval = 10;
            this.timer_quake.Tick += new System.EventHandler(this.timer_quake_Tick);
            // 
            // timer_hp_down
            // 
            this.timer_hp_down.Interval = 1;
            this.timer_hp_down.Tick += new System.EventHandler(this.timer_hp_down_Tick);
            // 
            // timer_anarchy
            // 
            this.timer_anarchy.Interval = 20;
            this.timer_anarchy.Tick += new System.EventHandler(this.timer_anarchy_Tick);
            // 
            // timer_word_fall
            // 
            this.timer_word_fall.Interval = 50;
            this.timer_word_fall.Tick += new System.EventHandler(this.timer_word_fall_Tick);
            // 
            // timer_gameover
            // 
            this.timer_gameover.Interval = 1;
            this.timer_gameover.Tick += new System.EventHandler(this.timer_gameover_Tick);
            // 
            // pictureBox_Yang_die
            // 
            this.pictureBox_Yang_die.Location = new System.Drawing.Point(462, 224);
            this.pictureBox_Yang_die.Name = "pictureBox_Yang_die";
            this.pictureBox_Yang_die.Size = new System.Drawing.Size(1024, 576);
            this.pictureBox_Yang_die.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Yang_die.TabIndex = 8;
            this.pictureBox_Yang_die.TabStop = false;
            // 
            // button_Back_to_Menu2
            // 
            this.button_Back_to_Menu2.Font = new System.Drawing.Font("華康中圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Back_to_Menu2.Location = new System.Drawing.Point(1372, 144);
            this.button_Back_to_Menu2.Name = "button_Back_to_Menu2";
            this.button_Back_to_Menu2.Size = new System.Drawing.Size(200, 50);
            this.button_Back_to_Menu2.TabIndex = 2;
            this.button_Back_to_Menu2.Text = "回主畫面";
            this.button_Back_to_Menu2.UseVisualStyleBackColor = true;
            this.button_Back_to_Menu2.Visible = false;
            this.button_Back_to_Menu2.Click += new System.EventHandler(this.button_Back_to_Menu_Click);
            // 
            // label_gameover
            // 
            this.label_gameover.AutoSize = true;
            this.label_gameover.Font = new System.Drawing.Font("華康中圓體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_gameover.Location = new System.Drawing.Point(30, 86);
            this.label_gameover.Name = "label_gameover";
            this.label_gameover.Size = new System.Drawing.Size(0, 22);
            this.label_gameover.TabIndex = 9;
            // 
            // MediaPlayer_skill
            // 
            this.MediaPlayer_skill.Enabled = true;
            this.MediaPlayer_skill.Location = new System.Drawing.Point(1255, 36);
            this.MediaPlayer_skill.Name = "MediaPlayer_skill";
            this.MediaPlayer_skill.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer_skill.OcxState")));
            this.MediaPlayer_skill.Size = new System.Drawing.Size(75, 23);
            this.MediaPlayer_skill.TabIndex = 10;
            this.MediaPlayer_skill.Visible = false;
            // 
            // MediaPlayer_event
            // 
            this.MediaPlayer_event.Enabled = true;
            this.MediaPlayer_event.Location = new System.Drawing.Point(1255, 74);
            this.MediaPlayer_event.Name = "MediaPlayer_event";
            this.MediaPlayer_event.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer_event.OcxState")));
            this.MediaPlayer_event.Size = new System.Drawing.Size(75, 23);
            this.MediaPlayer_event.TabIndex = 11;
            this.MediaPlayer_event.Visible = false;
            // 
            // MediaPlayer_answer
            // 
            this.MediaPlayer_answer.Enabled = true;
            this.MediaPlayer_answer.Location = new System.Drawing.Point(1255, 115);
            this.MediaPlayer_answer.Name = "MediaPlayer_answer";
            this.MediaPlayer_answer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer_answer.OcxState")));
            this.MediaPlayer_answer.Size = new System.Drawing.Size(75, 23);
            this.MediaPlayer_answer.TabIndex = 12;
            this.MediaPlayer_answer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1584, 962);
            this.Controls.Add(this.MediaPlayer_answer);
            this.Controls.Add(this.MediaPlayer_event);
            this.Controls.Add(this.MediaPlayer_skill);
            this.Controls.Add(this.label_gameover);
            this.Controls.Add(this.button_Back_to_Menu2);
            this.Controls.Add(this.pictureBox_Yang_die);
            this.Controls.Add(this.panel_Game);
            this.Controls.Add(this.panel_Instruction);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.label_instruction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "守護玻璃心";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Yang)).EndInit();
            this.panel_Instruction.ResumeLayout(false);
            this.panel_Game.ResumeLayout(false);
            this.panel_Game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_destiny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer_damage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yang_die)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer_skill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer_event)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer_answer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Instruction;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_instruction;
        private System.Windows.Forms.Timer timer_instruction;
        private System.Windows.Forms.Button button_Skip;
        private System.Windows.Forms.Button button_Back_to_Menu;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Instruction;
        private System.Windows.Forms.Panel panel_Game;
        private System.Windows.Forms.PictureBox pic_Yang;
        private System.Windows.Forms.PictureBox pic_title;
        private System.Windows.Forms.Timer timer_load;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer_damage;
        private System.Windows.Forms.Label label_Livetime;
        private System.Windows.Forms.Button button_skill_slow;
        private System.Windows.Forms.Timer timer_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_skill_earthquake;
        private System.Windows.Forms.Button button_skill_destiny;
        private System.Windows.Forms.Button button_skill_anarchy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.Label label_hp;
        private System.Windows.Forms.Label label_CD;
        private System.Windows.Forms.Timer timer_CD;
        private System.Windows.Forms.PictureBox pictureBox_hp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Deadline;
        private System.Windows.Forms.PictureBox pictureBox_show;
        private System.Windows.Forms.Label label_CDNotOK;
        private System.Windows.Forms.Timer timer_Make_word;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label_skill;
        private System.Windows.Forms.Timer timer_quake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer_hp_down;
        private System.Windows.Forms.Timer timer_anarchy;
        private System.Windows.Forms.PictureBox pictureBox_destiny;
        private System.Windows.Forms.Timer timer_word_fall;
        private System.Windows.Forms.Timer timer_gameover;
        private System.Windows.Forms.PictureBox pictureBox_Yang_die;
        private System.Windows.Forms.Button button_Back_to_Menu2;
        private System.Windows.Forms.Label label_gameover;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer_skill;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer_event;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer_answer;
    }
}

