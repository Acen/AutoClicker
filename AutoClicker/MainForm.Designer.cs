namespace AutoClicker
{
    partial class MainForm
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.grpChance = new System.Windows.Forms.GroupBox();
            this.lblChance = new System.Windows.Forms.Label();
            this.lblChancePercent = new System.Windows.Forms.Label();
            this.numChance = new System.Windows.Forms.NumericUpDown();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.CheckBoxDarkMode = new System.Windows.Forms.CheckBox();
            this.CheckBoxStayOnTop = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpClickType = new System.Windows.Forms.GroupBox();
            this.rdbClickDouble = new System.Windows.Forms.CheckBox();
            this.rdbClickRight = new System.Windows.Forms.CheckBox();
            this.rdbClickMiddle = new System.Windows.Forms.CheckBox();
            this.rdbClickLeft = new System.Windows.Forms.CheckBox();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblHotkey = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHotkeyRemove = new System.Windows.Forms.Button();
            this.txtHotkey = new System.Windows.Forms.TextBox();
            this.grpCount = new System.Windows.Forms.GroupBox();
            this.lblCountClicks = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.rdbCount = new System.Windows.Forms.RadioButton();
            this.rdbUntilStopped = new System.Windows.Forms.RadioButton();
            this.grpDelay = new System.Windows.Forms.GroupBox();
            this.lblDelayMS_2 = new System.Windows.Forms.Label();
            this.lblDelayMS_1 = new System.Windows.Forms.Label();
            this.numDelayFixed = new System.Windows.Forms.NumericUpDown();
            this.lblDelayDash = new System.Windows.Forms.Label();
            this.numDelayRangeMax = new System.Windows.Forms.NumericUpDown();
            this.numDelayRangeMin = new System.Windows.Forms.NumericUpDown();
            this.rdbDelayRange = new System.Windows.Forms.RadioButton();
            this.rdbDelayFixed = new System.Windows.Forms.RadioButton();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.btnSelectRandomAtCursor = new System.Windows.Forms.Button();
            this.lblRandomAtCursorY = new System.Windows.Forms.Label();
            this.numRandomAtCursorY = new System.Windows.Forms.NumericUpDown();
            this.lblRandomAtCursorX = new System.Windows.Forms.Label();
            this.numRandomAtCursorX = new System.Windows.Forms.NumericUpDown();
            this.rdbLocationRandomAtCursor = new System.Windows.Forms.RadioButton();
            this.btnSelectFixed = new System.Windows.Forms.Button();
            this.btnSelectRandom = new System.Windows.Forms.Button();
            this.lblRandomHeight = new System.Windows.Forms.Label();
            this.numRandomHeight = new System.Windows.Forms.NumericUpDown();
            this.lblRandomWidth = new System.Windows.Forms.Label();
            this.numRandomWidth = new System.Windows.Forms.NumericUpDown();
            this.lblRandomY = new System.Windows.Forms.Label();
            this.numRandomY = new System.Windows.Forms.NumericUpDown();
            this.lblRandomX = new System.Windows.Forms.Label();
            this.numRandomX = new System.Windows.Forms.NumericUpDown();
            this.lblFixedY = new System.Windows.Forms.Label();
            this.numFixedY = new System.Windows.Forms.NumericUpDown();
            this.lblFixedX = new System.Windows.Forms.Label();
            this.numFixedX = new System.Windows.Forms.NumericUpDown();
            this.rdbLocationRandomArea = new System.Windows.Forms.RadioButton();
            this.rdbLocationFixed = new System.Windows.Forms.RadioButton();
            this.rdbLocationRandom = new System.Windows.Forms.RadioButton();
            this.rdbLocationMouse = new System.Windows.Forms.RadioButton();
            this.grpMain.SuspendLayout();
            this.grpChance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChance)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.numRandomAtCursorY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomAtCursorX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedX)).BeginInit();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.grpChance);
            this.grpMain.Controls.Add(this.grpSettings);
            this.grpMain.Controls.Add(this.grpClickType);
            this.grpMain.Controls.Add(this.grpControls);
            this.grpMain.Controls.Add(this.grpCount);
            this.grpMain.Controls.Add(this.grpDelay);
            this.grpMain.Controls.Add(this.grpLocation);
            this.grpMain.Location = new System.Drawing.Point(10, 4);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(565, 386);
            this.grpMain.Text = "Click details";
            // 
            // grpChance
            // 
            this.grpChance.Controls.Add(this.lblChance);
            this.grpChance.Controls.Add(this.lblChancePercent);
            this.grpChance.Controls.Add(this.numChance);
            this.grpChance.Location = new System.Drawing.Point(6, 300);
            this.grpChance.Name = "grpChance";
            this.grpChance.Size = new System.Drawing.Size(250, 75);
            this.grpChance.Text = "Chance";
            // 
            // lblChance
            // 
            this.lblChance.Location = new System.Drawing.Point(6, 22);
            //this.lblChance.Name = "lblChance";
            this.lblChance.Size = new System.Drawing.Size(115, 13);
            this.lblChance.Text = "Chance to click mouse";
            // 
            // lblChancePercent
            // 
            this.lblChancePercent.Location = new System.Drawing.Point(181, 21);
            //this.lblChancePercent.Name = "lblChancePercent";
            this.lblChancePercent.Size = new System.Drawing.Size(20, 13);
            this.lblChancePercent.Text = "%";
            // 
            // numChance
            // 
            this.numChance.Location = new System.Drawing.Point(127, 19);
            this.numChance.Minimum = 1;
            this.numChance.Name = "numChance";
            this.numChance.Size = new System.Drawing.Size(48, 20);
            this.numChance.Value = 100;
            this.numChance.ValueChanged += new System.EventHandler(this.ChanceHandler);
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.CheckBoxDarkMode);
            this.grpSettings.Controls.Add(this.CheckBoxStayOnTop);
            this.grpSettings.Controls.Add(this.btnReset);
            this.grpSettings.Location = new System.Drawing.Point(421, 101);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(138, 112);
            this.grpSettings.Text = "Settings";
            // 
            // CheckBoxDarkMode
            // 
            this.CheckBoxDarkMode.Location = new System.Drawing.Point(32, 20);
            this.CheckBoxDarkMode.Name = "CheckBoxDarkMode";
            this.CheckBoxDarkMode.Size = new System.Drawing.Size(92, 17);
            this.CheckBoxDarkMode.Text = "Dark Mode";
            this.CheckBoxDarkMode.CheckedChanged += new System.EventHandler(this.CheckBoxDarkMode_Press);
            // 
            // CheckBoxStayOnTop
            // 
            this.CheckBoxStayOnTop.Location = new System.Drawing.Point(26, 49);
            this.CheckBoxStayOnTop.Name = "CheckBoxStayOnTop";
            this.CheckBoxStayOnTop.Size = new System.Drawing.Size(92, 17);
            this.CheckBoxStayOnTop.Text = "Always on top";
            this.CheckBoxStayOnTop.CheckedChanged += new System.EventHandler(this.CheckBoxStayOnTop_Press);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(34, 74);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // grpClickType
            // 
            this.grpClickType.Controls.Add(this.rdbClickDouble);
            this.grpClickType.Controls.Add(this.rdbClickRight);
            this.grpClickType.Controls.Add(this.rdbClickMiddle);
            this.grpClickType.Controls.Add(this.rdbClickLeft);
            this.grpClickType.Location = new System.Drawing.Point(269, 101);
            this.grpClickType.Name = "grpClickType";
            this.grpClickType.Size = new System.Drawing.Size(139, 112);
            this.grpClickType.Text = "Click type";
            // 
            // rdbClickDouble
            // 
            this.rdbClickDouble.Location = new System.Drawing.Point(6, 88);
            this.rdbClickDouble.Name = "rdbClickDouble";
            this.rdbClickDouble.Size = new System.Drawing.Size(60, 17);
            this.rdbClickDouble.Text = "Double";
            this.rdbClickDouble.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickRight
            // 
            this.rdbClickRight.Location = new System.Drawing.Point(6, 65);
            this.rdbClickRight.Name = "rdbClickRight";
            this.rdbClickRight.Size = new System.Drawing.Size(51, 17);
            this.rdbClickRight.Text = "Right";
            this.rdbClickRight.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            this.rdbClickRight.CheckedChanged += new System.EventHandler(this.ControlsHandler);
            // 
            // rdbClickMiddle
            // 
            this.rdbClickMiddle.Location = new System.Drawing.Point(6, 42);
            this.rdbClickMiddle.Name = "rdbClickMiddle";
            this.rdbClickMiddle.Size = new System.Drawing.Size(57, 17);
            this.rdbClickMiddle.Text = "Middle";
            this.rdbClickMiddle.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            this.rdbClickMiddle.CheckedChanged += new System.EventHandler(this.ControlsHandler);
            // 
            // rdbClickLeft
            // 
            this.rdbClickLeft.Checked = true;
            this.rdbClickLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdbClickLeft.Location = new System.Drawing.Point(6, 19);
            this.rdbClickLeft.Name = "rdbClickLeft";
            this.rdbClickLeft.Size = new System.Drawing.Size(44, 17);
            this.rdbClickLeft.Text = "Left";
            this.rdbClickLeft.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            this.rdbClickLeft.CheckedChanged += new System.EventHandler(this.ControlsHandler);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnStop);
            this.grpControls.Controls.Add(this.lblHotkey);
            this.grpControls.Controls.Add(this.btnStart);
            this.grpControls.Controls.Add(this.btnHotkeyRemove);
            this.grpControls.Controls.Add(this.txtHotkey);
            this.grpControls.Location = new System.Drawing.Point(269, 16);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(290, 79);
            this.grpControls.Text = "Controls";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(87, 20);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 25);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // lblHotkey
            // 
            this.lblHotkey.Location = new System.Drawing.Point(6, 53);
            //this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(41, 13);
            this.lblHotkey.Text = "Hotkey";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnHotkeyRemove
            // 
            this.btnHotkeyRemove.Location = new System.Drawing.Point(204, 48);
            this.btnHotkeyRemove.Name = "btnHotkeyRemove";
            this.btnHotkeyRemove.Size = new System.Drawing.Size(80, 25);
            this.btnHotkeyRemove.Text = "Clear Hotkey";
            this.btnHotkeyRemove.Click += new System.EventHandler(this.BtnHotkeyRemove_Click);
            this.btnHotkeyRemove.Click += new System.EventHandler(this.ControlsHandler);
            // 
            // txtHotkey
            // 
            this.txtHotkey.Location = new System.Drawing.Point(52, 50);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.ReadOnly = true;
            this.txtHotkey.ShortcutsEnabled = false;
            this.txtHotkey.Size = new System.Drawing.Size(145, 20);
            this.txtHotkey.Text = "None";
            this.txtHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHotkey_KeyDown);
            this.txtHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlsHandler);
            // 
            // grpCount
            // 
            this.grpCount.Controls.Add(this.lblCountClicks);
            this.grpCount.Controls.Add(this.numCount);
            this.grpCount.Controls.Add(this.rdbCount);
            this.grpCount.Controls.Add(this.rdbUntilStopped);
            this.grpCount.Location = new System.Drawing.Point(269, 300);
            this.grpCount.Name = "grpCount";
            this.grpCount.Size = new System.Drawing.Size(290, 75);
            this.grpCount.Text = "Count";
            // 
            // lblCountClicks
            // 
            this.lblCountClicks.Location = new System.Drawing.Point(182, 51);
            //this.lblCountClicks.Name = "lblCountClicks";
            this.lblCountClicks.Size = new System.Drawing.Size(34, 13);
            this.lblCountClicks.Text = "clicks";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(104, 48);
            this.numCount.Maximum = 1000000;
            this.numCount.Minimum = 1;
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(70, 20);
            this.numCount.Value = 100;
            this.numCount.ValueChanged += new System.EventHandler(this.CountHandler);
            // 
            // rdbCount
            // 
            this.rdbCount.Location = new System.Drawing.Point(6, 48);
            this.rdbCount.Name = "rdbCount";
            this.rdbCount.Size = new System.Drawing.Size(88, 17);
            this.rdbCount.Text = "Fixed number";
            this.rdbCount.CheckedChanged += new System.EventHandler(this.CountHandler);
            // 
            // rdbUntilStopped
            // 
            this.rdbUntilStopped.Checked = true;
            this.rdbUntilStopped.Location = new System.Drawing.Point(6, 21);
            this.rdbUntilStopped.Name = "rdbUntilStopped";
            this.rdbUntilStopped.Size = new System.Drawing.Size(87, 17);
            this.rdbUntilStopped.Text = "Until stopped";
            this.rdbUntilStopped.CheckedChanged += new System.EventHandler(this.CountHandler);
            // 
            // grpDelay
            // 
            this.grpDelay.Controls.Add(this.lblDelayMS_2);
            this.grpDelay.Controls.Add(this.lblDelayMS_1);
            this.grpDelay.Controls.Add(this.numDelayFixed);
            this.grpDelay.Controls.Add(this.lblDelayDash);
            this.grpDelay.Controls.Add(this.numDelayRangeMax);
            this.grpDelay.Controls.Add(this.numDelayRangeMin);
            this.grpDelay.Controls.Add(this.rdbDelayRange);
            this.grpDelay.Controls.Add(this.rdbDelayFixed);
            this.grpDelay.Location = new System.Drawing.Point(269, 219);
            this.grpDelay.Name = "grpDelay";
            this.grpDelay.Size = new System.Drawing.Size(290, 75);
            this.grpDelay.Text = "Delay";
            // 
            // lblDelayMS_2
            // 
            this.lblDelayMS_2.Location = new System.Drawing.Point(269, 49);
            //this.lblDelayMS_2.Name = "lblDelayMS_2";
            this.lblDelayMS_2.Size = new System.Drawing.Size(20, 13);
            this.lblDelayMS_2.Text = "ms";
            // 
            // lblDelayMS_1
            // 
            this.lblDelayMS_1.Location = new System.Drawing.Point(174, 22);
            //this.lblDelayMS_1.Name = "lblDelayMS_1";
            this.lblDelayMS_1.Size = new System.Drawing.Size(20, 13);
            this.lblDelayMS_1.Text = "ms";
            // 
            // numDelayFixed
            // 
            this.numDelayFixed.Location = new System.Drawing.Point(96, 20);
            this.numDelayFixed.Maximum = 1000000;
            this.numDelayFixed.Name = "numDelayFixed";
            this.numDelayFixed.Size = new System.Drawing.Size(70, 20);
            this.numDelayFixed.Value = 100;
            this.numDelayFixed.ValueChanged += new System.EventHandler(this.DelayHandler);
            // 
            // lblDelayDash
            // 
            this.lblDelayDash.Location = new System.Drawing.Point(174, 49);
            //this.lblDelayDash.Name = "lblDelayDash";
            this.lblDelayDash.Size = new System.Drawing.Size(10, 13);
            this.lblDelayDash.Text = "-";
            // 
            // numDelayRangeMax
            // 
            this.numDelayRangeMax.Location = new System.Drawing.Point(191, 47);
            this.numDelayRangeMax.Maximum = 1000000;
            this.numDelayRangeMax.Name = "numDelayRangeMax";
            this.numDelayRangeMax.Size = new System.Drawing.Size(70, 20);
            this.numDelayRangeMax.Value = 1000;
            this.numDelayRangeMax.ValueChanged += new System.EventHandler(this.DelayHandler);
            // 
            // numDelayRangeMin
            // 
            this.numDelayRangeMin.Location = new System.Drawing.Point(96, 47);
            this.numDelayRangeMin.Maximum = 1000000;
            this.numDelayRangeMin.Name = "numDelayRangeMin";
            this.numDelayRangeMin.Size = new System.Drawing.Size(70, 20);
            this.numDelayRangeMin.Value = 500;
            this.numDelayRangeMin.ValueChanged += new System.EventHandler(this.DelayHandler);
            // 
            // rdbDelayRange
            // 
            this.rdbDelayRange.Location = new System.Drawing.Point(6, 47);
            this.rdbDelayRange.Name = "rdbDelayRange";
            this.rdbDelayRange.Size = new System.Drawing.Size(82, 17);
            this.rdbDelayRange.Text = "Delay range";
            this.rdbDelayRange.CheckedChanged += new System.EventHandler(this.DelayHandler);
            // 
            // rdbDelayFixed
            // 
            this.rdbDelayFixed.Checked = true;
            this.rdbDelayFixed.Location = new System.Drawing.Point(6, 20);
            this.rdbDelayFixed.Name = "rdbDelayFixed";
            this.rdbDelayFixed.Size = new System.Drawing.Size(78, 17);
            this.rdbDelayFixed.Text = "Fixed delay";
            this.rdbDelayFixed.CheckedChanged += new System.EventHandler(this.DelayHandler);
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.btnSelectRandomAtCursor);
            this.grpLocation.Controls.Add(this.lblRandomAtCursorY);
            this.grpLocation.Controls.Add(this.numRandomAtCursorY);
            this.grpLocation.Controls.Add(this.lblRandomAtCursorX);
            this.grpLocation.Controls.Add(this.numRandomAtCursorX);
            this.grpLocation.Controls.Add(this.rdbLocationRandomAtCursor);
            this.grpLocation.Controls.Add(this.btnSelectFixed);
            this.grpLocation.Controls.Add(this.btnSelectRandom);
            this.grpLocation.Controls.Add(this.lblRandomHeight);
            this.grpLocation.Controls.Add(this.numRandomHeight);
            this.grpLocation.Controls.Add(this.lblRandomWidth);
            this.grpLocation.Controls.Add(this.numRandomWidth);
            this.grpLocation.Controls.Add(this.lblRandomY);
            this.grpLocation.Controls.Add(this.numRandomY);
            this.grpLocation.Controls.Add(this.lblRandomX);
            this.grpLocation.Controls.Add(this.numRandomX);
            this.grpLocation.Controls.Add(this.lblFixedY);
            this.grpLocation.Controls.Add(this.numFixedY);
            this.grpLocation.Controls.Add(this.lblFixedX);
            this.grpLocation.Controls.Add(this.numFixedX);
            this.grpLocation.Controls.Add(this.rdbLocationRandomArea);
            this.grpLocation.Controls.Add(this.rdbLocationFixed);
            this.grpLocation.Controls.Add(this.rdbLocationRandom);
            this.grpLocation.Controls.Add(this.rdbLocationMouse);
            this.grpLocation.Location = new System.Drawing.Point(6, 16);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(250, 278);
            this.grpLocation.Text = "Location";
            // 
            // btnSelectRandomAtCursor
            // 
            this.btnSelectRandomAtCursor.Location = new System.Drawing.Point(147, 211);
            this.btnSelectRandomAtCursor.Name = "btnSelectRandomAtCursor";
            this.btnSelectRandomAtCursor.Size = new System.Drawing.Size(75, 25);
            this.btnSelectRandomAtCursor.Text = "Select...";
            this.btnSelectRandomAtCursor.Click += new System.EventHandler(this.BtnSelectRandomAtCursor_Click);
            // 
            // lblRandomAtCursorY
            // 
            this.lblRandomAtCursorY.Location = new System.Drawing.Point(152, 244);
            //this.lblRandomAtCursorY.Name = "lblRandomAtCursorY";
            this.lblRandomAtCursorY.Size = new System.Drawing.Size(14, 13);
            this.lblRandomAtCursorY.Text = "Y";
            // 
            // numRandomAtCursorY
            // 
            this.numRandomAtCursorY.Location = new System.Drawing.Point(170, 242);
            this.numRandomAtCursorY.Maximum = 1000000;
            this.numRandomAtCursorY.Name = "numRandomAtCursorY";
            this.numRandomAtCursorY.Size = new System.Drawing.Size(70, 20);
            this.numRandomAtCursorY.Value = 50;
            this.numRandomAtCursorY.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // lblRandomAtCursorX
            // 
            this.lblRandomAtCursorX.Location = new System.Drawing.Point(30, 244);
            //this.lblRandomAtCursorX.Name = "lblRandomAtCursorX";
            this.lblRandomAtCursorX.Size = new System.Drawing.Size(14, 13);
            this.lblRandomAtCursorX.Text = "X";
            // 
            // numRandomAtCursorX
            // 
            this.numRandomAtCursorX.Location = new System.Drawing.Point(48, 242);
            this.numRandomAtCursorX.Maximum = 1000000;
            this.numRandomAtCursorX.Name = "numRandomAtCursorX";
            this.numRandomAtCursorX.Size = new System.Drawing.Size(70, 20);
            this.numRandomAtCursorX.Value = 50;
            this.numRandomAtCursorX.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationRandomAtCursor
            // 
            this.rdbLocationRandomAtCursor.Location = new System.Drawing.Point(6, 215);
            this.rdbLocationRandomAtCursor.Name = "rdbLocationRandomAtCursor";
            this.rdbLocationRandomAtCursor.Size = new System.Drawing.Size(135, 17);
            this.rdbLocationRandomAtCursor.Text = "Random area at mouse";
            this.rdbLocationRandomAtCursor.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // btnSelectFixed
            // 
            this.btnSelectFixed.Location = new System.Drawing.Point(101, 70);
            this.btnSelectFixed.Name = "btnSelectFixed";
            this.btnSelectFixed.Size = new System.Drawing.Size(75, 25);
            this.btnSelectFixed.Text = "Select...";
            this.btnSelectFixed.Click += new System.EventHandler(this.BtnSelectFixed_Click);
            // 
            // btnSelectRandom
            // 
            this.btnSelectRandom.Location = new System.Drawing.Point(101, 127);
            this.btnSelectRandom.Name = "btnSelectRandom";
            this.btnSelectRandom.Size = new System.Drawing.Size(75, 25);
            this.btnSelectRandom.Text = "Select...";
            this.btnSelectRandom.Click += new System.EventHandler(this.BtnSelectRandom_Click);
            // 
            // lblRandomHeight
            // 
            this.lblRandomHeight.Location = new System.Drawing.Point(123, 187);
            //this.lblRandomHeight.Name = "lblRandomHeight";
            this.lblRandomHeight.Size = new System.Drawing.Size(38, 13);
            this.lblRandomHeight.Text = "Height";
            // 
            // numRandomHeight
            // 
            this.numRandomHeight.Location = new System.Drawing.Point(167, 185);
            this.numRandomHeight.Maximum = 1000000;
            this.numRandomHeight.Name = "numRandomHeight";
            this.numRandomHeight.Size = new System.Drawing.Size(70, 20);
            this.numRandomHeight.Value = 100;
            this.numRandomHeight.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // lblRandomWidth
            // 
            this.lblRandomWidth.Location = new System.Drawing.Point(6, 189);
            //this.lblRandomWidth.Name = "lblRandomWidth";
            this.lblRandomWidth.Size = new System.Drawing.Size(35, 13);
            this.lblRandomWidth.Text = "Width";
            // 
            // numRandomWidth
            // 
            this.numRandomWidth.Location = new System.Drawing.Point(45, 185);
            this.numRandomWidth.Maximum = 1000000;
            this.numRandomWidth.Name = "numRandomWidth";
            this.numRandomWidth.Size = new System.Drawing.Size(70, 20);
            this.numRandomWidth.Value = 100;
            this.numRandomWidth.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // lblRandomY
            // 
            this.lblRandomY.Location = new System.Drawing.Point(149, 160);
            //this.lblRandomY.Name = "lblRandomY";
            this.lblRandomY.Size = new System.Drawing.Size(14, 13);
            this.lblRandomY.Text = "Y";
            // 
            // numRandomY
            // 
            this.numRandomY.Location = new System.Drawing.Point(167, 158);
            this.numRandomY.Maximum = 1000000;
            this.numRandomY.Name = "numRandomY";
            this.numRandomY.Size = new System.Drawing.Size(70, 20);
            this.numRandomY.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // lblRandomX
            // 
            this.lblRandomX.Location = new System.Drawing.Point(27, 162);
            //this.lblRandomX.Name = "lblRandomX";
            this.lblRandomX.Size = new System.Drawing.Size(14, 13);
            this.lblRandomX.Text = "X";
            // 
            // numRandomX
            // 
            this.numRandomX.Location = new System.Drawing.Point(45, 158);
            this.numRandomX.Maximum = 1000000;
            this.numRandomX.Name = "numRandomX";
            this.numRandomX.Size = new System.Drawing.Size(70, 20);
            this.numRandomX.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // lblFixedY
            // 
            this.lblFixedY.Location = new System.Drawing.Point(149, 103);
            //this.lblFixedY.Name = "lblFixedY";
            this.lblFixedY.Size = new System.Drawing.Size(14, 13);
            this.lblFixedY.Text = "Y";
            // 
            // numFixedY
            // 
            this.numFixedY.Location = new System.Drawing.Point(167, 101);
            this.numFixedY.Maximum = 1000000;
            this.numFixedY.Name = "numFixedY";
            this.numFixedY.Size = new System.Drawing.Size(70, 20);
            this.numFixedY.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // lblFixedX
            // 
            this.lblFixedX.Location = new System.Drawing.Point(27, 103);
            //this.lblFixedX.Name = "lblFixedX";
            this.lblFixedX.Size = new System.Drawing.Size(14, 13);
            this.lblFixedX.Text = "X";
            // 
            // numFixedX
            // 
            this.numFixedX.Location = new System.Drawing.Point(45, 101);
            this.numFixedX.Maximum = 1000000;
            this.numFixedX.Name = "numFixedX";
            this.numFixedX.Size = new System.Drawing.Size(70, 20);
            this.numFixedX.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationRandomArea
            // 
            this.rdbLocationRandomArea.Location = new System.Drawing.Point(6, 131);
            this.rdbLocationRandomArea.Name = "rdbLocationRandomArea";
            this.rdbLocationRandomArea.Size = new System.Drawing.Size(89, 17);
            this.rdbLocationRandomArea.Text = "Random area";
            this.rdbLocationRandomArea.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationFixed
            // 
            this.rdbLocationFixed.Location = new System.Drawing.Point(6, 74);
            this.rdbLocationFixed.Name = "rdbLocationFixed";
            this.rdbLocationFixed.Size = new System.Drawing.Size(90, 17);
            this.rdbLocationFixed.Text = "Fixed location";
            this.rdbLocationFixed.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationRandom
            // 
            this.rdbLocationRandom.Location = new System.Drawing.Point(6, 47);
            this.rdbLocationRandom.Name = "rdbLocationRandom";
            this.rdbLocationRandom.Size = new System.Drawing.Size(115, 17);
            this.rdbLocationRandom.Text = "Random on screen";
            this.rdbLocationRandom.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationMouse
            // 
            this.rdbLocationMouse.Checked = true;
            this.rdbLocationMouse.Location = new System.Drawing.Point(6, 20);
            this.rdbLocationMouse.Name = "rdbLocationMouse";
            this.rdbLocationMouse.Size = new System.Drawing.Size(97, 17);
            this.rdbLocationMouse.Text = "Mouse location";
            this.rdbLocationMouse.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(585, 399);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayFixed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomAtCursorY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomAtCursorX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedX)).EndInit();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.GroupBox grpClickType;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnHotkeyRemove;
        private System.Windows.Forms.TextBox txtHotkey;
        private System.Windows.Forms.GroupBox grpCount;
        private System.Windows.Forms.Label lblCountClicks;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.RadioButton rdbCount;
        private System.Windows.Forms.RadioButton rdbUntilStopped;
        private System.Windows.Forms.GroupBox grpDelay;
        private System.Windows.Forms.Label lblDelayMS_2;
        private System.Windows.Forms.Label lblDelayMS_1;
        private System.Windows.Forms.NumericUpDown numDelayFixed;
        private System.Windows.Forms.Label lblDelayDash;
        private System.Windows.Forms.NumericUpDown numDelayRangeMax;
        private System.Windows.Forms.NumericUpDown numDelayRangeMin;
        private System.Windows.Forms.RadioButton rdbDelayRange;
        private System.Windows.Forms.RadioButton rdbDelayFixed;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.Label lblRandomHeight;
        private System.Windows.Forms.NumericUpDown numRandomHeight;
        private System.Windows.Forms.Label lblRandomWidth;
        private System.Windows.Forms.NumericUpDown numRandomWidth;
        private System.Windows.Forms.Label lblRandomY;
        private System.Windows.Forms.NumericUpDown numRandomY;
        private System.Windows.Forms.Label lblRandomX;
        private System.Windows.Forms.NumericUpDown numRandomX;
        private System.Windows.Forms.Label lblFixedY;
        private System.Windows.Forms.NumericUpDown numFixedY;
        private System.Windows.Forms.Label lblFixedX;
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
        private System.Windows.Forms.Label lblHotkey;
        private System.Windows.Forms.Button btnSelectRandom;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox CheckBoxStayOnTop;
        private System.Windows.Forms.CheckBox CheckBoxDarkMode;
        private System.Windows.Forms.Button btnSelectRandomAtCursor;
        private System.Windows.Forms.Label lblRandomAtCursorY;
        private System.Windows.Forms.NumericUpDown numRandomAtCursorY;
        private System.Windows.Forms.Label lblRandomAtCursorX;
        private System.Windows.Forms.NumericUpDown numRandomAtCursorX;
        private System.Windows.Forms.RadioButton rdbLocationRandomAtCursor;
        private System.Windows.Forms.GroupBox grpChance;
        private System.Windows.Forms.Label lblChancePercent;
        private System.Windows.Forms.NumericUpDown numChance;
        private System.Windows.Forms.Label lblChance;
        private System.Windows.Forms.Button btnSelectFixed;
    }
}

