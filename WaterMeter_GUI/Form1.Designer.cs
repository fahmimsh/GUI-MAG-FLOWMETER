
namespace WaterMeter_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialComToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataLogsheetAirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataInputSerialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.standardControl7 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl6 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl1 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl2 = new SymbolFactoryDotNet.StandardControl();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.standardControl3 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl4 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl5 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl8 = new SymbolFactoryDotNet.StandardControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl8)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialComToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // serialComToolStripMenuItem
            // 
            this.serialComToolStripMenuItem.Name = "serialComToolStripMenuItem";
            this.serialComToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.serialComToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.serialComToolStripMenuItem.Text = "SerialCom";
            this.serialComToolStripMenuItem.Click += new System.EventHandler(this.serialComToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataLogsheetAirToolStripMenuItem,
            this.dataInputSerialToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // dataLogsheetAirToolStripMenuItem
            // 
            this.dataLogsheetAirToolStripMenuItem.Name = "dataLogsheetAirToolStripMenuItem";
            this.dataLogsheetAirToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.dataLogsheetAirToolStripMenuItem.Text = "Data Logsheet Air";
            this.dataLogsheetAirToolStripMenuItem.Click += new System.EventHandler(this.dataLogsheetAirToolStripMenuItem_Click);
            // 
            // dataInputSerialToolStripMenuItem
            // 
            this.dataInputSerialToolStripMenuItem.Name = "dataInputSerialToolStripMenuItem";
            this.dataInputSerialToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.dataInputSerialToolStripMenuItem.Text = "Data Input Serial";
            this.dataInputSerialToolStripMenuItem.Click += new System.EventHandler(this.dataInputSerialToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(78, 20);
            this.toolStripStatusLabel1.Text = "Command";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 49);
            this.button1.TabIndex = 15;
            this.button1.Text = "RUN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // standardControl7
            // 
            this.standardControl7.AnalogIntValue1 = ((short)(0));
            this.standardControl7.AnalogValue1 = 0D;
            this.standardControl7.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.AnalogIntegerColorFill;
            this.standardControl7.BackColor = System.Drawing.Color.Transparent;
            this.standardControl7.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl7.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl7.BlinkColor = System.Drawing.Color.Aqua;
            this.standardControl7.BlinkSpeed = SymbolFactoryNetEngine.BlinkSpeedOptions.Fast_400;
            this.standardControl7.Category = "1PIPE.cat2";
            this.standardControl7.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl7.DebugData"));
            this.standardControl7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl7.Location = new System.Drawing.Point(254, 252);
            this.standardControl7.Name = "standardControl7";
            this.standardControl7.Size = new System.Drawing.Size(80, 22);
            this.standardControl7.SymbolHandle = ((long)(2078383901));
            this.standardControl7.TabIndex = 19;
            // 
            // standardControl6
            // 
            this.standardControl6.AnalogIntValue1 = ((short)(0));
            this.standardControl6.AnalogValue1 = 0D;
            this.standardControl6.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.AnalogIntegerColorFill;
            this.standardControl6.BackColor = System.Drawing.Color.Transparent;
            this.standardControl6.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl6.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl6.BlinkColor = System.Drawing.Color.Aqua;
            this.standardControl6.BlinkSpeed = SymbolFactoryNetEngine.BlinkSpeedOptions.Fast_400;
            this.standardControl6.Category = "1PIPE.cat2";
            this.standardControl6.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl6.DebugData"));
            this.standardControl6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl6.Location = new System.Drawing.Point(204, 116);
            this.standardControl6.Name = "standardControl6";
            this.standardControl6.Size = new System.Drawing.Size(40, 40);
            this.standardControl6.SymbolHandle = ((long)(630871749));
            this.standardControl6.TabIndex = 18;
            // 
            // standardControl1
            // 
            this.standardControl1.AnalogIntValue1 = ((short)(0));
            this.standardControl1.AnalogValue1 = 0D;
            this.standardControl1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.AnalogIntegerColorFill;
            this.standardControl1.BackColor = System.Drawing.Color.Transparent;
            this.standardControl1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl1.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.standardControl1.Category = "1PMP.cat2";
            this.standardControl1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl1.DebugData"));
            this.standardControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.standardControl1.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.standardControl1.Location = new System.Drawing.Point(12, 206);
            this.standardControl1.Name = "standardControl1";
            this.standardControl1.Size = new System.Drawing.Size(242, 123);
            this.standardControl1.SymbolHandle = ((long)(1138097156));
            this.standardControl1.TabIndex = 14;
            // 
            // standardControl2
            // 
            this.standardControl2.AnalogIntValue1 = ((short)(0));
            this.standardControl2.AnalogValue1 = 0D;
            this.standardControl2.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.AnalogIntegerColorFill;
            this.standardControl2.BackColor = System.Drawing.Color.Transparent;
            this.standardControl2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl2.BlinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.standardControl2.Category = "1FLW.cat2";
            this.standardControl2.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl2.DebugData"));
            this.standardControl2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.standardControl2.Location = new System.Drawing.Point(298, 35);
            this.standardControl2.Name = "standardControl2";
            this.standardControl2.Size = new System.Drawing.Size(114, 114);
            this.standardControl2.SymbolHandle = ((long)(1277576936));
            this.standardControl2.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(320, 68);
            this.listBox1.TabIndex = 21;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(21, 78);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 27);
            this.numericUpDown1.TabIndex = 24;
            // 
            // standardControl3
            // 
            this.standardControl3.AnalogIntValue1 = ((short)(0));
            this.standardControl3.AnalogValue1 = 0D;
            this.standardControl3.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.AnalogIntegerColorFill;
            this.standardControl3.BackColor = System.Drawing.Color.Transparent;
            this.standardControl3.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl3.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl3.BlinkColor = System.Drawing.Color.Aqua;
            this.standardControl3.BlinkSpeed = SymbolFactoryNetEngine.BlinkSpeedOptions.Fast_400;
            this.standardControl3.Category = "1PIPE.cat2";
            this.standardControl3.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl3.DebugData"));
            this.standardControl3.FillColor = System.Drawing.Color.Aqua;
            this.standardControl3.Location = new System.Drawing.Point(204, 147);
            this.standardControl3.Name = "standardControl3";
            this.standardControl3.Rotation = SymbolFactoryNetEngine.RotationOptions.Rotate90;
            this.standardControl3.Size = new System.Drawing.Size(20, 80);
            this.standardControl3.SymbolHandle = ((long)(2078383901));
            this.standardControl3.TabIndex = 26;
            // 
            // standardControl4
            // 
            this.standardControl4.AnalogIntValue1 = ((short)(0));
            this.standardControl4.AnalogValue1 = 0D;
            this.standardControl4.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.AnalogIntegerColorFill;
            this.standardControl4.BackColor = System.Drawing.Color.Transparent;
            this.standardControl4.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl4.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl4.BlinkColor = System.Drawing.Color.Aqua;
            this.standardControl4.BlinkSpeed = SymbolFactoryNetEngine.BlinkSpeedOptions.Fast_400;
            this.standardControl4.Category = "1PIPE.cat2";
            this.standardControl4.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl4.DebugData"));
            this.standardControl4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl4.Location = new System.Drawing.Point(239, 116);
            this.standardControl4.Name = "standardControl4";
            this.standardControl4.Size = new System.Drawing.Size(80, 20);
            this.standardControl4.SymbolHandle = ((long)(2078383901));
            this.standardControl4.TabIndex = 28;
            // 
            // standardControl5
            // 
            this.standardControl5.AnalogIntValue1 = ((short)(0));
            this.standardControl5.AnalogValue1 = 0D;
            this.standardControl5.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.AnalogIntegerColorFill;
            this.standardControl5.BackColor = System.Drawing.Color.Transparent;
            this.standardControl5.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl5.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl5.BlinkColor = System.Drawing.Color.Aqua;
            this.standardControl5.BlinkSpeed = SymbolFactoryNetEngine.BlinkSpeedOptions.Fast_400;
            this.standardControl5.Category = "1PIPE.cat2";
            this.standardControl5.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl5.DebugData"));
            this.standardControl5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl5.Location = new System.Drawing.Point(390, 115);
            this.standardControl5.Name = "standardControl5";
            this.standardControl5.Size = new System.Drawing.Size(80, 20);
            this.standardControl5.SymbolHandle = ((long)(2078383901));
            this.standardControl5.TabIndex = 29;
            // 
            // standardControl8
            // 
            this.standardControl8.AnalogIntValue1 = ((short)(0));
            this.standardControl8.AnalogValue1 = 0D;
            this.standardControl8.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.AnalogIntegerColorFill;
            this.standardControl8.BackColor = System.Drawing.Color.Transparent;
            this.standardControl8.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl8.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl8.BlinkColor = System.Drawing.Color.Aqua;
            this.standardControl8.BlinkSpeed = SymbolFactoryNetEngine.BlinkSpeedOptions.Fast_400;
            this.standardControl8.Category = "1PIPE.cat2";
            this.standardControl8.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl8.DebugData"));
            this.standardControl8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl8.Location = new System.Drawing.Point(464, 115);
            this.standardControl8.Name = "standardControl8";
            this.standardControl8.Size = new System.Drawing.Size(80, 20);
            this.standardControl8.SymbolHandle = ((long)(2078383901));
            this.standardControl8.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.standardControl8);
            this.panel1.Controls.Add(this.standardControl2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.standardControl5);
            this.panel1.Controls.Add(this.standardControl1);
            this.panel1.Controls.Add(this.standardControl4);
            this.panel1.Controls.Add(this.standardControl6);
            this.panel1.Controls.Add(this.standardControl3);
            this.panel1.Controls.Add(this.standardControl7);
            this.panel1.Location = new System.Drawing.Point(4, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 387);
            this.panel1.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Location = new System.Drawing.Point(386, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 30);
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Location = new System.Drawing.Point(307, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 30);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Liter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Liter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Liter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Hasil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "INPUT DATA";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(323, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(560, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 100);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(560, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 281);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LOG Data";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(323, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 44;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(5, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(320, 244);
            this.listBox2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaterMeterMerapi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialComToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataLogsheetAirToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private SymbolFactoryDotNet.StandardControl standardControl7;
        private SymbolFactoryDotNet.StandardControl standardControl6;
        private SymbolFactoryDotNet.StandardControl standardControl1;
        private SymbolFactoryDotNet.StandardControl standardControl2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private SymbolFactoryDotNet.StandardControl standardControl3;
        private System.Windows.Forms.ToolStripMenuItem dataInputSerialToolStripMenuItem;
        private SymbolFactoryDotNet.StandardControl standardControl4;
        private SymbolFactoryDotNet.StandardControl standardControl5;
        private SymbolFactoryDotNet.StandardControl standardControl8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

