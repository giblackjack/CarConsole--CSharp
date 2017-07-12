namespace CarConsole
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
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnRecirc = new System.Windows.Forms.Button();
            this.btnFreshAir = new System.Windows.Forms.Button();
            this.btnFanFaster = new System.Windows.Forms.Button();
            this.btnFanSlower = new System.Windows.Forms.Button();
            this.btnHotter = new System.Windows.Forms.Button();
            this.btnColder = new System.Windows.Forms.Button();
            this.btnFace = new System.Windows.Forms.Button();
            this.btnFaceFeet = new System.Windows.Forms.Button();
            this.btnFeet = new System.Windows.Forms.Button();
            this.btnFeetWindows = new System.Windows.Forms.Button();
            this.btnWindow = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.trackBarFanSpeed = new System.Windows.Forms.TrackBar();
            this.trackBarTemp = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.textBoxCOMPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFanSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemp)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.PortName = "COM3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusConnected});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusConnected
            // 
            this.toolStripStatusConnected.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusConnected.IsLink = true;
            this.toolStripStatusConnected.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.toolStripStatusConnected.LinkColor = System.Drawing.Color.Red;
            this.toolStripStatusConnected.Name = "toolStripStatusConnected";
            this.toolStripStatusConnected.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusConnected.Text = "Not Connected";
            this.toolStripStatusConnected.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // btnAC
            // 
            this.btnAC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAC.AutoSize = true;
            this.btnAC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAC.BackgroundImage = global::CarConsole.Properties.Resources.ac;
            this.btnAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnAC.Location = new System.Drawing.Point(18, 3);
            this.btnAC.MaximumSize = new System.Drawing.Size(128, 128);
            this.btnAC.MinimumSize = new System.Drawing.Size(128, 128);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(128, 128);
            this.btnAC.TabIndex = 1;
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnRecirc
            // 
            this.btnRecirc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRecirc.AutoSize = true;
            this.btnRecirc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecirc.BackgroundImage = global::CarConsole.Properties.Resources.inair;
            this.btnRecirc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecirc.Location = new System.Drawing.Point(182, 3);
            this.btnRecirc.MaximumSize = new System.Drawing.Size(128, 128);
            this.btnRecirc.MinimumSize = new System.Drawing.Size(128, 128);
            this.btnRecirc.Name = "btnRecirc";
            this.btnRecirc.Size = new System.Drawing.Size(128, 128);
            this.btnRecirc.TabIndex = 2;
            this.btnRecirc.UseVisualStyleBackColor = false;
            this.btnRecirc.Click += new System.EventHandler(this.btnRecirc_Click);
            // 
            // btnFreshAir
            // 
            this.btnFreshAir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFreshAir.AutoSize = true;
            this.btnFreshAir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFreshAir.BackgroundImage = global::CarConsole.Properties.Resources.outair;
            this.btnFreshAir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFreshAir.Location = new System.Drawing.Point(346, 3);
            this.btnFreshAir.MaximumSize = new System.Drawing.Size(128, 128);
            this.btnFreshAir.MinimumSize = new System.Drawing.Size(128, 128);
            this.btnFreshAir.Name = "btnFreshAir";
            this.btnFreshAir.Size = new System.Drawing.Size(128, 128);
            this.btnFreshAir.TabIndex = 3;
            this.btnFreshAir.UseVisualStyleBackColor = false;
            this.btnFreshAir.Click += new System.EventHandler(this.btnFreshAir_Click);
            // 
            // btnFanFaster
            // 
            this.btnFanFaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFanFaster.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFanFaster.BackgroundImage = global::CarConsole.Properties.Resources.fan2;
            this.btnFanFaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFanFaster.Location = new System.Drawing.Point(3, 3);
            this.btnFanFaster.MaximumSize = new System.Drawing.Size(128, 128);
            this.btnFanFaster.MinimumSize = new System.Drawing.Size(128, 128);
            this.btnFanFaster.Name = "btnFanFaster";
            this.btnFanFaster.Size = new System.Drawing.Size(128, 128);
            this.btnFanFaster.TabIndex = 4;
            this.btnFanFaster.UseVisualStyleBackColor = false;
            this.btnFanFaster.Click += new System.EventHandler(this.btnFanFaster_Click);
            // 
            // btnFanSlower
            // 
            this.btnFanSlower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFanSlower.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFanSlower.BackgroundImage = global::CarConsole.Properties.Resources.fan1;
            this.btnFanSlower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFanSlower.Location = new System.Drawing.Point(3, 314);
            this.btnFanSlower.MaximumSize = new System.Drawing.Size(128, 128);
            this.btnFanSlower.MinimumSize = new System.Drawing.Size(128, 128);
            this.btnFanSlower.Name = "btnFanSlower";
            this.btnFanSlower.Size = new System.Drawing.Size(128, 128);
            this.btnFanSlower.TabIndex = 5;
            this.btnFanSlower.UseVisualStyleBackColor = false;
            this.btnFanSlower.Click += new System.EventHandler(this.btnFanSlower_Click);
            // 
            // btnHotter
            // 
            this.btnHotter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHotter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHotter.BackgroundImage = global::CarConsole.Properties.Resources.hot;
            this.btnHotter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHotter.Location = new System.Drawing.Point(3, 3);
            this.btnHotter.MaximumSize = new System.Drawing.Size(128, 128);
            this.btnHotter.MinimumSize = new System.Drawing.Size(128, 128);
            this.btnHotter.Name = "btnHotter";
            this.btnHotter.Size = new System.Drawing.Size(128, 128);
            this.btnHotter.TabIndex = 6;
            this.btnHotter.UseVisualStyleBackColor = false;
            this.btnHotter.Click += new System.EventHandler(this.btnHotter_Click);
            // 
            // btnColder
            // 
            this.btnColder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnColder.BackgroundImage = global::CarConsole.Properties.Resources.cold;
            this.btnColder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnColder.Location = new System.Drawing.Point(3, 314);
            this.btnColder.MaximumSize = new System.Drawing.Size(128, 128);
            this.btnColder.MinimumSize = new System.Drawing.Size(128, 128);
            this.btnColder.Name = "btnColder";
            this.btnColder.Size = new System.Drawing.Size(128, 128);
            this.btnColder.TabIndex = 7;
            this.btnColder.UseVisualStyleBackColor = false;
            this.btnColder.Click += new System.EventHandler(this.btnColder_Click);
            // 
            // btnFace
            // 
            this.btnFace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFace.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFace.BackgroundImage = global::CarConsole.Properties.Resources.face;
            this.btnFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFace.Location = new System.Drawing.Point(17, 3);
            this.btnFace.MaximumSize = new System.Drawing.Size(128, 128);
            this.btnFace.MinimumSize = new System.Drawing.Size(128, 128);
            this.btnFace.Name = "btnFace";
            this.btnFace.Size = new System.Drawing.Size(128, 128);
            this.btnFace.TabIndex = 8;
            this.btnFace.UseVisualStyleBackColor = false;
            this.btnFace.Click += new System.EventHandler(this.btnFace_Click);
            // 
            // btnFaceFeet
            // 
            this.btnFaceFeet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFaceFeet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFaceFeet.BackgroundImage = global::CarConsole.Properties.Resources.face_feet;
            this.btnFaceFeet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFaceFeet.Location = new System.Drawing.Point(180, 3);
            this.btnFaceFeet.MaximumSize = new System.Drawing.Size(128, 128);
            this.btnFaceFeet.MinimumSize = new System.Drawing.Size(128, 128);
            this.btnFaceFeet.Name = "btnFaceFeet";
            this.btnFaceFeet.Size = new System.Drawing.Size(128, 128);
            this.btnFaceFeet.TabIndex = 9;
            this.btnFaceFeet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaceFeet.UseVisualStyleBackColor = false;
            this.btnFaceFeet.Click += new System.EventHandler(this.btnFaceFeet_Click);
            // 
            // btnFeet
            // 
            this.btnFeet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFeet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFeet.BackgroundImage = global::CarConsole.Properties.Resources.feet;
            this.btnFeet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFeet.Location = new System.Drawing.Point(343, 3);
            this.btnFeet.MaximumSize = new System.Drawing.Size(128, 128);
            this.btnFeet.MinimumSize = new System.Drawing.Size(128, 128);
            this.btnFeet.Name = "btnFeet";
            this.btnFeet.Size = new System.Drawing.Size(128, 128);
            this.btnFeet.TabIndex = 10;
            this.btnFeet.UseVisualStyleBackColor = false;
            this.btnFeet.Click += new System.EventHandler(this.btnFeet_Click);
            // 
            // btnFeetWindows
            // 
            this.btnFeetWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFeetWindows.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFeetWindows.BackgroundImage = global::CarConsole.Properties.Resources.feet_windows;
            this.btnFeetWindows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFeetWindows.Location = new System.Drawing.Point(506, 3);
            this.btnFeetWindows.MaximumSize = new System.Drawing.Size(128, 128);
            this.btnFeetWindows.MinimumSize = new System.Drawing.Size(128, 128);
            this.btnFeetWindows.Name = "btnFeetWindows";
            this.btnFeetWindows.Size = new System.Drawing.Size(128, 128);
            this.btnFeetWindows.TabIndex = 11;
            this.btnFeetWindows.UseVisualStyleBackColor = false;
            this.btnFeetWindows.Click += new System.EventHandler(this.btnFeetWindows_Click);
            // 
            // btnWindow
            // 
            this.btnWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnWindow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWindow.BackgroundImage = global::CarConsole.Properties.Resources.windows;
            this.btnWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWindow.Location = new System.Drawing.Point(672, 3);
            this.btnWindow.MaximumSize = new System.Drawing.Size(128, 128);
            this.btnWindow.MinimumSize = new System.Drawing.Size(128, 128);
            this.btnWindow.Name = "btnWindow";
            this.btnWindow.Size = new System.Drawing.Size(128, 128);
            this.btnWindow.TabIndex = 12;
            this.btnWindow.UseVisualStyleBackColor = false;
            this.btnWindow.Click += new System.EventHandler(this.btnWindow_Click);
            // 
            // btnPower
            // 
            this.btnPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPower.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPower.BackgroundImage = global::CarConsole.Properties.Resources.power;
            this.btnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPower.Location = new System.Drawing.Point(510, 3);
            this.btnPower.MaximumSize = new System.Drawing.Size(128, 128);
            this.btnPower.MinimumSize = new System.Drawing.Size(128, 128);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(128, 128);
            this.btnPower.TabIndex = 13;
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // trackBarFanSpeed
            // 
            this.trackBarFanSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.trackBarFanSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarFanSpeed.LargeChange = 1;
            this.trackBarFanSpeed.Location = new System.Drawing.Point(45, 131);
            this.trackBarFanSpeed.Maximum = 4;
            this.trackBarFanSpeed.Name = "trackBarFanSpeed";
            this.trackBarFanSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarFanSpeed.Size = new System.Drawing.Size(45, 177);
            this.trackBarFanSpeed.TabIndex = 16;
            this.trackBarFanSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarFanSpeed.Scroll += new System.EventHandler(this.trackBarFanSpeed_Scroll);
            this.trackBarFanSpeed.ValueChanged += new System.EventHandler(this.trackBarFanSpeed_ValueChanged);
            // 
            // trackBarTemp
            // 
            this.trackBarTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.trackBarTemp.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarTemp.LargeChange = 1;
            this.trackBarTemp.Location = new System.Drawing.Point(41, 131);
            this.trackBarTemp.Maximum = 9;
            this.trackBarTemp.Minimum = 1;
            this.trackBarTemp.Name = "trackBarTemp";
            this.trackBarTemp.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTemp.Size = new System.Drawing.Size(45, 177);
            this.trackBarTemp.TabIndex = 17;
            this.trackBarTemp.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarTemp.Value = 1;
            this.trackBarTemp.ValueChanged += new System.EventHandler(this.trackBarTemp_ValueChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(3, 66);
            this.btnReset.MaximumSize = new System.Drawing.Size(128, 64);
            this.btnReset.MinimumSize = new System.Drawing.Size(128, 64);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 64);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset Connection";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // textBoxCOMPort
            // 
            this.textBoxCOMPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCOMPort.Location = new System.Drawing.Point(3, 28);
            this.textBoxCOMPort.MaximumSize = new System.Drawing.Size(128, 32);
            this.textBoxCOMPort.MinimumSize = new System.Drawing.Size(128, 32);
            this.textBoxCOMPort.Name = "textBoxCOMPort";
            this.textBoxCOMPort.Size = new System.Drawing.Size(128, 26);
            this.textBoxCOMPort.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "COM Port";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnFanSlower, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFanFaster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBarFanSpeed, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(136, 439);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnHotter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.trackBarTemp, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnColder, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(956, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(128, 439);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxCOMPort, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnReset, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(669, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(138, 128);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnPower, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAC, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnRecirc, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnFreshAir, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(136, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(820, 134);
            this.tableLayoutPanel4.TabIndex = 25;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Controls.Add(this.btnWindow, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnFeetWindows, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnFaceFeet, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnFace, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnFeet, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(136, 305);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(820, 134);
            this.tableLayoutPanel5.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "Form1";
            this.Text = "Matt\'s Car Console";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFanSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemp)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusConnected;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnRecirc;
        private System.Windows.Forms.Button btnFreshAir;
        private System.Windows.Forms.Button btnFanFaster;
        private System.Windows.Forms.Button btnFanSlower;
        private System.Windows.Forms.Button btnHotter;
        private System.Windows.Forms.Button btnColder;
        private System.Windows.Forms.Button btnFace;
        private System.Windows.Forms.Button btnFaceFeet;
        private System.Windows.Forms.Button btnFeet;
        private System.Windows.Forms.Button btnFeetWindows;
        private System.Windows.Forms.Button btnWindow;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.TrackBar trackBarFanSpeed;
        private System.Windows.Forms.TrackBar trackBarTemp;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox textBoxCOMPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}

