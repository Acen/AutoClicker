using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace AutoClicker
{
	public partial class MainForm : Form
	{
		private AutoClicker clicker;
		private Keys hotkey;
		private Win32.FsModifiers hotkeyNodifiers;

		// Have settings stored in appdata instead of next to the executable
		static readonly string appdata_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		static readonly string cfgfolder_path = Path.Combine(appdata_path, "AutoClicker"); // Folder Name
		static readonly string cfgfile_path = Path.Combine(cfgfolder_path, "settings.dat"); // File Name

		public MainForm()
		{
			InitializeComponent();
		}

		private void SaveSettings()
		{
			if (!Directory.Exists(cfgfolder_path))
				Directory.CreateDirectory(cfgfolder_path); // If AutoClicker folder doesn't exist, create one

			using (FileStream fs = File.Open(cfgfile_path, FileMode.Create))
			{
				using (BinaryWriter w = new BinaryWriter(fs))
				{
					// Button type
					w.Write(rdbClickLeft.Checked);

					w.Write(rdbClickMiddle.Checked);

					w.Write(rdbClickRight.Checked);

					w.Write(rdbClickDouble.Checked);

					// Location info
					if (rdbLocationMouse.Checked)
						w.Write((byte)1);

					else if (rdbLocationRandom.Checked)
						w.Write((byte)2);

					else if (rdbLocationFixed.Checked)
						w.Write((byte)3);

					else if (rdbLocationRandomArea.Checked)
						w.Write((byte)4);

					w.Write((int)numFixedX.Value);
					w.Write((int)numFixedY.Value);
					w.Write((int)numRandomX.Value);
					w.Write((int)numRandomY.Value);
					w.Write((int)numRandomWidth.Value);
					w.Write((int)numRandomHeight.Value);

					// Delay info
					if (rdbDelayFixed.Checked)
						w.Write((byte)1);

					else if (rdbDelayRange.Checked)
						w.Write((byte)2);

					w.Write((int)numDelayFixed.Value);
					w.Write((int)numDelayRangeMin.Value);
					w.Write((int)numDelayRangeMax.Value);

					// Count info
					if (rdbUntilStopped.Checked)
						w.Write((byte)1);

					else if (rdbCount.Checked)
						w.Write((byte)2);

					w.Write((int)numCount.Value);

					// Hotkey info
					if (txtHotkey.Text == "None")
						w.Write(0);
					else
						w.Write((int)hotkey);

					// Settings info
					w.Write(CheckBoxStayOnTop.Checked);
				}
			}
		}

		private void LoadSettings()
		{
			long length = new FileInfo(cfgfile_path).Length;
			if (File.Exists(cfgfile_path) && length == 52) // hack to prevent reading out of bounds
			{
				using (FileStream fs = File.Open(cfgfile_path, FileMode.Open))
				{
					using (BinaryReader r = new BinaryReader(fs))
					{
						// Read data
						bool ClickLeft = r.ReadBoolean();
						bool ClickMiddle = r.ReadBoolean();
						bool ClickRight = r.ReadBoolean();
						bool ClickDouble = r.ReadBoolean();

						byte locationType = r.ReadByte();
						int fixedX = r.ReadInt32();
						int fixedY = r.ReadInt32();
						int randomX = r.ReadInt32();
						int randomY = r.ReadInt32();
						int randomWidth = r.ReadInt32();
						int randomHeight = r.ReadInt32();

						byte delayType = r.ReadByte();
						int fixedDelay = r.ReadInt32();
						int rangeDelayMin = r.ReadInt32();
						int rangeDelayMax = r.ReadInt32();

						byte countType = r.ReadByte();
						int count = r.ReadInt32();

						hotkey = (Keys)r.ReadInt32();

						bool StayOnTop = r.ReadBoolean();

						// Apply read data
						rdbClickLeft.Checked = ClickLeft;
						rdbClickMiddle.Checked = ClickMiddle;
						rdbClickRight.Checked = ClickRight;
						rdbClickDouble.Checked = ClickDouble;

						switch (locationType)
						{
							case 1:
								rdbLocationMouse.Checked = true;
								break;
							case 2:
								rdbLocationRandom.Checked = true;
								break;
							case 3:
								rdbLocationFixed.Checked = true;
								break;
							case 4:
								rdbLocationRandomArea.Checked = true;
								break;
						}

						numFixedX.Value = fixedX;
						numFixedY.Value = fixedY;
						numRandomX.Value = randomX;
						numRandomY.Value = randomY;
						numRandomWidth.Value = randomWidth;
						numRandomHeight.Value = randomHeight;

						switch (delayType)
						{
							case 1:
								rdbDelayFixed.Checked = true;
								break;
							case 2:
								rdbDelayRange.Checked = true;
								break;
						}

						numDelayFixed.Value = fixedDelay;
						numDelayRangeMin.Value = rangeDelayMin;
						numDelayRangeMax.Value = rangeDelayMax;

						switch (countType)
						{
							case 1:
								rdbUntilStopped.Checked = true;
								break;
							case 2:
								rdbCount.Checked = true;
								break;
						}

						numCount.Value = count;

						if (hotkey != Keys.None)
						{
							var hotkeyModifiers = hotkey & Keys.Modifiers;

							if ((hotkeyModifiers & Keys.Shift) != 0)
								hotkeyNodifiers |= Win32.FsModifiers.Shift;

							if ((hotkeyModifiers & Keys.Control) != 0)
								hotkeyNodifiers |= Win32.FsModifiers.Control;

							if ((hotkeyModifiers & Keys.Alt) != 0)
								hotkeyNodifiers |= Win32.FsModifiers.Alt;

							SetHotkey();
						}

						CheckBoxStayOnTop.Checked = StayOnTop;
					}
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			clicker = new AutoClicker();
			LoadSettings();
			ClickTypeHandler(null, null);
			LocationHandler(null, null);
			DelayHandler(null, null);
			CountHandler(null, null);

			btnStop.Enabled = false;
			if (txtHotkey.Text == "None") // If we don't have a hotkey set, disable the reset button.
				btnHotkeyRemove.Enabled = false;

			clicker.Finished += HandleFinished;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}

		private void HandleFinished(object sender, EventArgs e)
		{
			EnableControls();
		}

		private void ClickTypeHandler(object sender, EventArgs e)
		{
			bool doubleClick = false, leftClick = false, middleClick = false, rightClick = false;

			if(!rdbClickLeft.Checked && !rdbClickMiddle.Checked && !rdbClickRight.Checked) // Check if any click types are enabled.
				btnStart.Enabled = false;
			else
				btnStart.Enabled = true;

			if (rdbClickLeft.Checked)
				leftClick = true;

			if (rdbClickMiddle.Checked)
				middleClick = true;

			if (rdbClickRight.Checked)
				rightClick = true;

			if (rdbClickDouble.Checked)
				doubleClick = true;

			clicker.UpdateButton(leftClick, middleClick, rightClick, doubleClick);
		}

		private void LocationHandler(object sender, EventArgs e)
		{
			AutoClicker.LocationType locationType;
			int x = -1, y = -1, width = -1, height = -1;

			if (rdbLocationFixed.Checked)
			{
				locationType = AutoClicker.LocationType.Fixed;
				x = (int)numFixedX.Value;
				y = (int)numFixedY.Value;
			}

			else if (rdbLocationMouse.Checked)
				locationType = AutoClicker.LocationType.Cursor;

			else if (rdbLocationRandom.Checked)
				locationType = AutoClicker.LocationType.Random;

			else
			{
				locationType = AutoClicker.LocationType.RandomRange;
				x = (int)numRandomX.Value;
				y = (int)numRandomY.Value;
				width = (int)numRandomWidth.Value;
				height = (int)numRandomHeight.Value;
			}

			// Toggle visibility of controls.
			if (locationType == AutoClicker.LocationType.Fixed)
			{
				numFixedX.Enabled = true;
				numFixedY.Enabled = true;
				btnSelectFixed.Enabled = true;
			}

			else
			{
				numFixedX.Enabled = false;
				numFixedY.Enabled = false;
				btnSelectFixed.Enabled = false;
			}

			if (locationType == AutoClicker.LocationType.RandomRange)
			{
				numRandomX.Enabled = true;
				numRandomY.Enabled = true;
				numRandomWidth.Enabled = true;
				numRandomHeight.Enabled = true;
				btnSelectRandom.Enabled = true;
			}

			else
			{
				numRandomX.Enabled = false;
				numRandomY.Enabled = false;
				numRandomWidth.Enabled = false;
				numRandomHeight.Enabled = false;
				btnSelectRandom.Enabled = false;
			}

			clicker.UpdateLocation(locationType, x, y, width, height);
		}

		private void DelayHandler(object sender, EventArgs e)
		{
			AutoClicker.DelayType delayType;
			int delay, delayRange = -1;

			if (rdbDelayFixed.Checked)
			{
				delayType = AutoClicker.DelayType.Fixed;
				delay = (int)numDelayFixed.Value;
			}

			else
			{
				delayType = AutoClicker.DelayType.Range;
				delay = (int)numDelayRangeMin.Value;
				delayRange = (int)numDelayRangeMax.Value;
			}

			// Toggle visibility of controls.
			if (delayType == AutoClicker.DelayType.Fixed)
			{
				numDelayFixed.Enabled = true;
				numDelayRangeMax.Enabled = false;
				numDelayRangeMin.Enabled = false;
			}

			else
			{
				numDelayFixed.Enabled = false;
				numDelayRangeMax.Enabled = true;
				numDelayRangeMin.Enabled = true;
			}

			clicker.UpdateDelay(delayType, delay, delayRange);
		}

		private void CountHandler(object sender, EventArgs e)
		{
			AutoClicker.CountType countType;
			int count = -1;

			if (rdbCount.Checked)
			{
				countType = AutoClicker.CountType.Fixed;
				count = (int)numCount.Value;
			}

			else
				countType = AutoClicker.CountType.UntilStopped;

			// Toggle visibility of controls.
			if (countType == AutoClicker.CountType.Fixed)
				numCount.Enabled = true;

			else
				numCount.Enabled = false;

			clicker.UpdateCount(countType, count);
		}

		// Wait function
		public void Wait(int time)
		{
			Thread thread = new Thread(delegate ()
			{
				Thread.Sleep(time);
			});
			thread.Start();
			while (thread.IsAlive)
				Application.DoEvents();
		}

		// Handles clicking hotkey to enable clicker
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == Win32.WM_HOTKEY)
			{
				// Ignore the hotkey if the user is editing it.
				if (txtHotkey.Focused)
					return;

				Win32.FsModifiers modifiers = (Win32.FsModifiers)((int)m.LParam & 0xFFFF);
				Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
				if (key == (hotkey & Keys.KeyCode) && modifiers == hotkeyNodifiers && (rdbClickLeft.Checked || rdbClickMiddle.Checked || rdbClickRight.Checked)) // Check if any click types are enabled.
					if (!clicker.IsAlive)
						BtnStart_Click(null, null);
					else
						BtnStop_Click(null, null);
			}
		}

		// Control Buttons
		private void BtnStart_Click(object sender, EventArgs e)
		{	
			clicker.Start();
			DisableControls();
		}

		private void DisableControls()
		{
			grpClickType.Enabled = false;
			grpLocation.Enabled = false;
			grpDelay.Enabled = false;
			grpCount.Enabled = false;
			grpSettings.Enabled = false;

			txtHotkey.Enabled = false;
			lblHotkey.Enabled = false;
			btnHotkeyRemove.Enabled = false;
			btnStart.Enabled = false;
			btnStop.Enabled = true;
			btnReset.Text = "Reset";
		}

		private void BtnStop_Click(object sender, EventArgs e)
		{
			clicker.Stop();
			EnableControls();
		}

		private void EnableControls()
		{
			grpClickType.Enabled = true;
			grpLocation.Enabled = true;
			grpDelay.Enabled = true;
			grpCount.Enabled = true;
			grpSettings.Enabled = true;

			txtHotkey.Enabled = true;
			lblHotkey.Enabled = true;
			if (txtHotkey.Text == "None") // If we don't have a hotkey set, disable the reset button.
				btnHotkeyRemove.Enabled = false;
			else
				btnHotkeyRemove.Enabled = true;
			btnStart.Enabled = true;
			btnStop.Enabled = false;
		}

		private void BtnHotkeyRemove_Click(object sender, EventArgs e)
		{
			UnsetHotkey();
			btnHotkeyRemove.Enabled = false;
		}
		
		private void SetHotkey()
		{
			txtHotkey.Text = KeysConverter.Convert(hotkey);
			Win32.RegisterHotKey(Handle, (int)hotkey, (uint)hotkeyNodifiers, (uint)(hotkey & Keys.KeyCode));
		}

		private void UnsetHotkey()
		{
			txtHotkey.Text = "None";
			Win32.UnregisterHotKey(Handle, (int)hotkey);
		}

		private void TxtHotkey_KeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress = true;
			// Don't want to do anything if only a modifier key is pressed.
			//     Modifiers                                 Asian keys (kana, hanja, kanji etc)       IME related keys (convert etc)           Korean alt (process)  Windows keys
			if (!((e.KeyValue >= 16 && e.KeyValue <= 18) || (e.KeyValue >= 21 && e.KeyValue <= 25) || (e.KeyValue >= 28 && e.KeyValue <= 31) || e.KeyValue == 229 || (e.KeyValue >= 91 && e.KeyValue <= 92)))
			{
				Win32.UnregisterHotKey(Handle, (int)hotkey);
				hotkey = e.KeyData;
				// Extract modifiers
				hotkeyNodifiers = 0;

				if ((e.Modifiers & Keys.Shift) != 0)
					hotkeyNodifiers |= Win32.FsModifiers.Shift;

				if ((e.Modifiers & Keys.Control) != 0)
					hotkeyNodifiers |= Win32.FsModifiers.Control;

				if ((e.Modifiers & Keys.Alt) != 0)
					hotkeyNodifiers |= Win32.FsModifiers.Alt;

				SetHotkey();
				btnHotkeyRemove.Enabled = true;
				txtHotkey.Parent.Focus();
			}
		}

		// Settings Buttons
		private void CheckBoxStayOnTop_Press(object sender, EventArgs e)
		{
			if (CheckBoxStayOnTop.Checked)
                TopMost = true;

            else
				TopMost = false;
		}

		private void BtnReset_Click(object sender, EventArgs e)
		{
			if (btnReset.Text == "Sure?")
			{
				rdbClickLeft.Checked = true;
				rdbClickMiddle.Checked = false;
				rdbClickRight.Checked = false;
				rdbClickDouble.Checked = false;

				rdbLocationMouse.Checked = true;
				numFixedX.Value = 0;
				numFixedY.Value = 0;

				numRandomX.Value = 0;
				numRandomY.Value = 0;
				numRandomWidth.Value = 100;
				numRandomHeight.Value = 100;

				rdbDelayFixed.Checked = true;
				numDelayFixed.Value = 100;
				numDelayRangeMin.Value = 500;
				numDelayRangeMax.Value = 1000;

				rdbUntilStopped.Checked = true;
				numCount.Value = 100;

				CheckBoxStayOnTop.Checked = false;

				UnsetHotkey();

				SaveSettings();
				btnReset.Text = "Reset";
				return;
			}

			btnReset.Text = "Sure?";
			Wait(3000);
			btnReset.Text = "Reset";
        }

		// Location Buttons
		private void BtnSelectRandom_Click(object sender, EventArgs e)
		{
			TopMost = false;
			grpMain.Enabled = false;

			var form = new SelectionForm(this);
			form.Show();
		}

		public void SendRectangle(int X, int Y, int Width, int Height)
		{
			numRandomX.Value = X;
			numRandomY.Value = Y;
			numRandomWidth.Value = Width;
			numRandomHeight.Value = Height;

			CheckBoxStayOnTop_Press(null, null);
			grpMain.Enabled = true;
		}

		private void BtnSelectFixed_Click(object sender, EventArgs e)
		{
			TopMost = false;
			grpMain.Enabled = false;

			var form = new SelectionFormFixed(this);
			form.Show();
		}

		public void SendFixedXY(int X, int Y)
		{
			numFixedX.Value = X;
			numFixedY.Value = Y;

			CheckBoxStayOnTop_Press(null, null);
			grpMain.Enabled = true;
		}
    }
}
