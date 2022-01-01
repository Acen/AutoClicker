namespace AutoClicker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpClickType = new System.Windows.Forms.GroupBox();
            this.rdbClickDouble = new System.Windows.Forms.CheckBox();
            this.rdbClickRight = new System.Windows.Forms.CheckBox();
            this.rdbClickMiddle = new System.Windows.Forms.CheckBox();
            this.rdbClickLeft = new System.Windows.Forms.CheckBox();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHotkeyRemove = new System.Windows.Forms.Button();
            this.txtHotkey = new System.Windows.Forms.TextBox();
            this.grpCount = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.rdbCount = new System.Windows.Forms.RadioButton();
            this.rdbUntilStopped = new System.Windows.Forms.RadioButton();
            this.grpDelay = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numDelayFixed = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numDelayRangeMax = new System.Windows.Forms.NumericUpDown();
            this.numDelayRangeMin = new System.Windows.Forms.NumericUpDown();
            this.rdbDelayRange = new System.Windows.Forms.RadioButton();
            this.rdbDelayFixed = new System.Windows.Forms.RadioButton();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numRandomHeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numRandomWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numRandomY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numRandomX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numFixedY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numFixedX = new System.Windows.Forms.NumericUpDown();
            this.rdbLocationRandomArea = new System.Windows.Forms.RadioButton();
            this.rdbLocationFixed = new System.Windows.Forms.RadioButton();
            this.rdbLocationRandom = new System.Windows.Forms.RadioButton();
            this.rdbLocationMouse = new System.Windows.Forms.RadioButton();
            this.grpMain.SuspendLayout();
            this.grpSettings.SuspendLayout();
            this.grpClickType.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.grpCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.grpDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayFixed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMin)).BeginInit();
            this.grpLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedX)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.grpSettings);
            this.grpMain.Controls.Add(this.grpClickType);
            this.grpMain.Controls.Add(this.grpControls);
            this.grpMain.Controls.Add(this.grpCount);
            this.grpMain.Controls.Add(this.grpDelay);
            this.grpMain.Controls.Add(this.grpLocation);
            this.grpMain.Location = new System.Drawing.Point(12, 13);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(570, 311);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Click details";
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.btnReset);
            this.grpSettings.Location = new System.Drawing.Point(422, 105);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(142, 112);
            this.grpSettings.TabIndex = 4;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(34, 44);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // grpClickType
            // 
            this.grpClickType.Controls.Add(this.rdbClickDouble);
            this.grpClickType.Controls.Add(this.rdbClickRight);
            this.grpClickType.Controls.Add(this.rdbClickMiddle);
            this.grpClickType.Controls.Add(this.rdbClickLeft);
            this.grpClickType.Location = new System.Drawing.Point(269, 105);
            this.grpClickType.Name = "grpClickType";
            this.grpClickType.Size = new System.Drawing.Size(140, 112);
            this.grpClickType.TabIndex = 2;
            this.grpClickType.TabStop = false;
            this.grpClickType.Text = "Click type";
            // 
            // rdbClickDouble
            // 
            this.rdbClickDouble.AutoSize = true;
            this.rdbClickDouble.Location = new System.Drawing.Point(6, 88);
            this.rdbClickDouble.Name = "rdbClickDouble";
            this.rdbClickDouble.Size = new System.Drawing.Size(60, 17);
            this.rdbClickDouble.TabIndex = 3;
            this.rdbClickDouble.Text = "Double";
            this.rdbClickDouble.UseVisualStyleBackColor = true;
            this.rdbClickDouble.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickRight
            // 
            this.rdbClickRight.AutoSize = true;
            this.rdbClickRight.Location = new System.Drawing.Point(6, 65);
            this.rdbClickRight.Name = "rdbClickRight";
            this.rdbClickRight.Size = new System.Drawing.Size(51, 17);
            this.rdbClickRight.TabIndex = 2;
            this.rdbClickRight.Text = "Right";
            this.rdbClickRight.UseVisualStyleBackColor = true;
            this.rdbClickRight.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickMiddle
            // 
            this.rdbClickMiddle.AutoSize = true;
            this.rdbClickMiddle.Location = new System.Drawing.Point(6, 42);
            this.rdbClickMiddle.Name = "rdbClickMiddle";
            this.rdbClickMiddle.Size = new System.Drawing.Size(57, 17);
            this.rdbClickMiddle.TabIndex = 1;
            this.rdbClickMiddle.Text = "Middle";
            this.rdbClickMiddle.UseVisualStyleBackColor = true;
            this.rdbClickMiddle.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickLeft
            // 
            this.rdbClickLeft.AutoSize = true;
            this.rdbClickLeft.Checked = true;
            this.rdbClickLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdbClickLeft.Location = new System.Drawing.Point(6, 19);
            this.rdbClickLeft.Name = "rdbClickLeft";
            this.rdbClickLeft.Size = new System.Drawing.Size(44, 17);
            this.rdbClickLeft.TabIndex = 0;
            this.rdbClickLeft.Text = "Left";
            this.rdbClickLeft.UseVisualStyleBackColor = true;
            this.rdbClickLeft.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnStop);
            this.grpControls.Controls.Add(this.label11);
            this.grpControls.Controls.Add(this.btnStart);
            this.grpControls.Controls.Add(this.btnHotkeyRemove);
            this.grpControls.Controls.Add(this.txtHotkey);
            this.grpControls.Location = new System.Drawing.Point(269, 20);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(295, 79);
            this.grpControls.TabIndex = 1;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(87, 20);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 25);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Hotkey";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnHotkeyRemove
            // 
            this.btnHotkeyRemove.Location = new System.Drawing.Point(204, 48);
            this.btnHotkeyRemove.Name = "btnHotkeyRemove";
            this.btnHotkeyRemove.Size = new System.Drawing.Size(80, 25);
            this.btnHotkeyRemove.TabIndex = 2;
            this.btnHotkeyRemove.Text = "Clear Hotkey";
            this.btnHotkeyRemove.UseVisualStyleBackColor = true;
            this.btnHotkeyRemove.Click += new System.EventHandler(this.BtnHotkeyRemove_Click);
            // 
            // txtHotkey
            // 
            this.txtHotkey.Location = new System.Drawing.Point(52, 50);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.Size = new System.Drawing.Size(145, 20);
            this.txtHotkey.TabIndex = 0;
            this.txtHotkey.Text = "None";
            this.txtHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHotkey_KeyDown);
            // 
            // grpCount
            // 
            this.grpCount.Controls.Add(this.label1);
            this.grpCount.Controls.Add(this.numCount);
            this.grpCount.Controls.Add(this.rdbCount);
            this.grpCount.Controls.Add(this.rdbUntilStopped);
            this.grpCount.Location = new System.Drawing.Point(6, 223);
            this.grpCount.Name = "grpCount";
            this.grpCount.Size = new System.Drawing.Size(250, 75);
            this.grpCount.TabIndex = 1;
            this.grpCount.TabStop = false;
            this.grpCount.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "clicks";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(104, 44);
            this.numCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(70, 20);
            this.numCount.TabIndex = 2;
            this.numCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCount.ValueChanged += new System.EventHandler(this.CountHandler);
            // 
            // rdbCount
            // 
            this.rdbCount.AutoSize = true;
            this.rdbCount.Location = new System.Drawing.Point(6, 44);
            this.rdbCount.Name = "rdbCount";
            this.rdbCount.Size = new System.Drawing.Size(88, 17);
            this.rdbCount.TabIndex = 1;
            this.rdbCount.Text = "Fixed number";
            this.rdbCount.UseVisualStyleBackColor = true;
            this.rdbCount.CheckedChanged += new System.EventHandler(this.CountHandler);
            // 
            // rdbUntilStopped
            // 
            this.rdbUntilStopped.AutoSize = true;
            this.rdbUntilStopped.Checked = true;
            this.rdbUntilStopped.Location = new System.Drawing.Point(6, 21);
            this.rdbUntilStopped.Name = "rdbUntilStopped";
            this.rdbUntilStopped.Size = new System.Drawing.Size(87, 17);
            this.rdbUntilStopped.TabIndex = 0;
            this.rdbUntilStopped.TabStop = true;
            this.rdbUntilStopped.Text = "Until stopped";
            this.rdbUntilStopped.UseVisualStyleBackColor = true;
            this.rdbUntilStopped.CheckedChanged += new System.EventHandler(this.CountHandler);
            // 
            // grpDelay
            // 
            this.grpDelay.Controls.Add(this.label10);
            this.grpDelay.Controls.Add(this.label9);
            this.grpDelay.Controls.Add(this.numDelayFixed);
            this.grpDelay.Controls.Add(this.label8);
            this.grpDelay.Controls.Add(this.numDelayRangeMax);
            this.grpDelay.Controls.Add(this.numDelayRangeMin);
            this.grpDelay.Controls.Add(this.rdbDelayRange);
            this.grpDelay.Controls.Add(this.rdbDelayFixed);
            this.grpDelay.Location = new System.Drawing.Point(269, 223);
            this.grpDelay.Name = "grpDelay";
            this.grpDelay.Size = new System.Drawing.Size(295, 75);
            this.grpDelay.TabIndex = 1;
            this.grpDelay.TabStop = false;
            this.grpDelay.Text = "Delay";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "ms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "ms";
            // 
            // numDelayFixed
            // 
            this.numDelayFixed.Location = new System.Drawing.Point(96, 20);
            this.numDelayFixed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDelayFixed.Name = "numDelayFixed";
            this.numDelayFixed.Size = new System.Drawing.Size(70, 20);
            this.numDelayFixed.TabIndex = 11;
            this.numDelayFixed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDelayFixed.ValueChanged += new System.EventHandler(this.DelayHandler);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "-";
            // 
            // numDelayRangeMax
            // 
            this.numDelayRangeMax.Location = new System.Drawing.Point(191, 47);
            this.numDelayRangeMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDelayRangeMax.Name = "numDelayRangeMax";
            this.numDelayRangeMax.Size = new System.Drawing.Size(70, 20);
            this.numDelayRangeMax.TabIndex = 9;
            this.numDelayRangeMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDelayRangeMax.ValueChanged += new System.EventHandler(this.DelayHandler);
            // 
            // numDelayRangeMin
            // 
            this.numDelayRangeMin.Location = new System.Drawing.Point(96, 47);
            this.numDelayRangeMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDelayRangeMin.Name = "numDelayRangeMin";
            this.numDelayRangeMin.Size = new System.Drawing.Size(70, 20);
            this.numDelayRangeMin.TabIndex = 8;
            this.numDelayRangeMin.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDelayRangeMin.ValueChanged += new System.EventHandler(this.DelayHandler);
            // 
            // rdbDelayRange
            // 
            this.rdbDelayRange.AutoSize = true;
            this.rdbDelayRange.Location = new System.Drawing.Point(6, 47);
            this.rdbDelayRange.Name = "rdbDelayRange";
            this.rdbDelayRange.Size = new System.Drawing.Size(82, 17);
            this.rdbDelayRange.TabIndex = 1;
            this.rdbDelayRange.Text = "Delay range";
            this.rdbDelayRange.UseVisualStyleBackColor = true;
            this.rdbDelayRange.CheckedChanged += new System.EventHandler(this.DelayHandler);
            // 
            // rdbDelayFixed
            // 
            this.rdbDelayFixed.AutoSize = true;
            this.rdbDelayFixed.Checked = true;
            this.rdbDelayFixed.Location = new System.Drawing.Point(6, 20);
            this.rdbDelayFixed.Name = "rdbDelayFixed";
            this.rdbDelayFixed.Size = new System.Drawing.Size(78, 17);
            this.rdbDelayFixed.TabIndex = 0;
            this.rdbDelayFixed.TabStop = true;
            this.rdbDelayFixed.Text = "Fixed delay";
            this.rdbDelayFixed.UseVisualStyleBackColor = true;
            this.rdbDelayFixed.CheckedChanged += new System.EventHandler(this.DelayHandler);
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.btnSelect);
            this.grpLocation.Controls.Add(this.label6);
            this.grpLocation.Controls.Add(this.numRandomHeight);
            this.grpLocation.Controls.Add(this.label7);
            this.grpLocation.Controls.Add(this.numRandomWidth);
            this.grpLocation.Controls.Add(this.label4);
            this.grpLocation.Controls.Add(this.numRandomY);
            this.grpLocation.Controls.Add(this.label5);
            this.grpLocation.Controls.Add(this.numRandomX);
            this.grpLocation.Controls.Add(this.label3);
            this.grpLocation.Controls.Add(this.numFixedY);
            this.grpLocation.Controls.Add(this.label2);
            this.grpLocation.Controls.Add(this.numFixedX);
            this.grpLocation.Controls.Add(this.rdbLocationRandomArea);
            this.grpLocation.Controls.Add(this.rdbLocationFixed);
            this.grpLocation.Controls.Add(this.rdbLocationRandom);
            this.grpLocation.Controls.Add(this.rdbLocationMouse);
            this.grpLocation.Location = new System.Drawing.Point(6, 20);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(250, 197);
            this.grpLocation.TabIndex = 0;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Location";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(102, 115);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 25);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "Select...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Height";
            // 
            // numRandomHeight
            // 
            this.numRandomHeight.Location = new System.Drawing.Point(167, 169);
            this.numRandomHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRandomHeight.Name = "numRandomHeight";
            this.numRandomHeight.Size = new System.Drawing.Size(70, 20);
            this.numRandomHeight.TabIndex = 14;
            this.numRandomHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numRandomHeight.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Width";
            // 
            // numRandomWidth
            // 
            this.numRandomWidth.Location = new System.Drawing.Point(45, 169);
            this.numRandomWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRandomWidth.Name = "numRandomWidth";
            this.numRandomWidth.Size = new System.Drawing.Size(70, 20);
            this.numRandomWidth.TabIndex = 12;
            this.numRandomWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numRandomWidth.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y";
            // 
            // numRandomY
            // 
            this.numRandomY.Location = new System.Drawing.Point(167, 142);
            this.numRandomY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRandomY.Name = "numRandomY";
            this.numRandomY.Size = new System.Drawing.Size(70, 20);
            this.numRandomY.TabIndex = 10;
            this.numRandomY.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // numRandomX
            // 
            this.numRandomX.Location = new System.Drawing.Point(45, 142);
            this.numRandomX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRandomX.Name = "numRandomX";
            this.numRandomX.Size = new System.Drawing.Size(70, 20);
            this.numRandomX.TabIndex = 8;
            this.numRandomX.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // numFixedY
            // 
            this.numFixedY.Location = new System.Drawing.Point(167, 91);
            this.numFixedY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numFixedY.Name = "numFixedY";
            this.numFixedY.Size = new System.Drawing.Size(70, 20);
            this.numFixedY.TabIndex = 6;
            this.numFixedY.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            // 
            // numFixedX
            // 
            this.numFixedX.Location = new System.Drawing.Point(45, 91);
            this.numFixedX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numFixedX.Name = "numFixedX";
            this.numFixedX.Size = new System.Drawing.Size(70, 20);
            this.numFixedX.TabIndex = 4;
            this.numFixedX.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationRandomArea
            // 
            this.rdbLocationRandomArea.AutoSize = true;
            this.rdbLocationRandomArea.Location = new System.Drawing.Point(6, 118);
            this.rdbLocationRandomArea.Name = "rdbLocationRandomArea";
            this.rdbLocationRandomArea.Size = new System.Drawing.Size(89, 17);
            this.rdbLocationRandomArea.TabIndex = 3;
            this.rdbLocationRandomArea.Text = "Random area";
            this.rdbLocationRandomArea.UseVisualStyleBackColor = true;
            this.rdbLocationRandomArea.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationFixed
            // 
            this.rdbLocationFixed.AutoSize = true;
            this.rdbLocationFixed.Location = new System.Drawing.Point(6, 67);
            this.rdbLocationFixed.Name = "rdbLocationFixed";
            this.rdbLocationFixed.Size = new System.Drawing.Size(90, 17);
            this.rdbLocationFixed.TabIndex = 2;
            this.rdbLocationFixed.Text = "Fixed location";
            this.rdbLocationFixed.UseVisualStyleBackColor = true;
            this.rdbLocationFixed.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationRandom
            // 
            this.rdbLocationRandom.AutoSize = true;
            this.rdbLocationRandom.Location = new System.Drawing.Point(6, 43);
            this.rdbLocationRandom.Name = "rdbLocationRandom";
            this.rdbLocationRandom.Size = new System.Drawing.Size(115, 17);
            this.rdbLocationRandom.TabIndex = 1;
            this.rdbLocationRandom.Text = "Random on screen";
            this.rdbLocationRandom.UseVisualStyleBackColor = true;
            this.rdbLocationRandom.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationMouse
            // 
            this.rdbLocationMouse.AutoSize = true;
            this.rdbLocationMouse.Checked = true;
            this.rdbLocationMouse.Location = new System.Drawing.Point(6, 20);
            this.rdbLocationMouse.Name = "rdbLocationMouse";
            this.rdbLocationMouse.Size = new System.Drawing.Size(97, 17);
            this.rdbLocationMouse.TabIndex = 0;
            this.rdbLocationMouse.TabStop = true;
            this.rdbLocationMouse.Text = "Mouse location";
            this.rdbLocationMouse.UseVisualStyleBackColor = true;
            this.rdbLocationMouse.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 333);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMain.ResumeLayout(false);
            this.grpSettings.ResumeLayout(false);
            this.grpClickType.ResumeLayout(false);
            this.grpClickType.PerformLayout();
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.grpCount.ResumeLayout(false);
            this.grpCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.grpDelay.ResumeLayout(false);
            this.grpDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayFixed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMin)).EndInit();
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.GroupBox grpClickType;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnHotkeyRemove;
        private System.Windows.Forms.TextBox txtHotkey;
        private System.Windows.Forms.GroupBox grpCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.RadioButton rdbCount;
        private System.Windows.Forms.RadioButton rdbUntilStopped;
        private System.Windows.Forms.GroupBox grpDelay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDelayFixed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numDelayRangeMax;
        private System.Windows.Forms.NumericUpDown numDelayRangeMin;
        private System.Windows.Forms.RadioButton rdbDelayRange;
        private System.Windows.Forms.RadioButton rdbDelayFixed;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numRandomHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numRandomWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numRandomY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numRandomX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numFixedY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFixedX;
        private System.Windows.Forms.RadioButton rdbLocationRandomArea;
        private System.Windows.Forms.RadioButton rdbLocationFixed;
        private System.Windows.Forms.RadioButton rdbLocationRandom;
        private System.Windows.Forms.RadioButton rdbLocationMouse;
        private System.Windows.Forms.CheckBox rdbClickDouble;
        private System.Windows.Forms.CheckBox rdbClickRight;
        private System.Windows.Forms.CheckBox rdbClickMiddle;
        private System.Windows.Forms.CheckBox rdbClickLeft;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Button btnReset;
    }
}

