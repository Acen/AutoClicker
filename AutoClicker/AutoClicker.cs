using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
	class AutoClicker
	{
		#region "Button"
		private bool leftClick;
		private bool middleClick;
		private bool rightClick;
		private bool doubleClick;
		#endregion

		#region "Location"
		public enum LocationType
		{
			Cursor,
			Fixed,
			Random,
			RandomRange,
			RandomAtCursor
		}

		private LocationType locationType;
		private int x;
		private int y;
		private int width;
		private int height;
		#endregion

		#region "Delay"
		public enum DelayType
		{
			Fixed,
			Range
		}

		private DelayType delayType;
		private int delay;
		private int delayRange;
		#endregion

		#region "Count"
		public enum CountType
		{
			Fixed,
			UntilStopped
		}

		private CountType countType;
		private int count;
		#endregion

		#region "Chance"
		private int chance;
        #endregion

        Thread Clicker;
        readonly static Random rnd = new Random();

		public EventHandler<EventArgs> Finished;

		private void Click()
		{
			//System.Diagnostics.Debug.Print("Click() started");
			
			int remaining = count;

			int nextDelay = delay;

			bool CheckedMousePos = false;

			int RandomAtCursorOriginalX = 0;
			int RandomAtCursorOriginalY = 0;

			//System.Diagnostics.Debug.Print("Count type: {0}, count: {1}", countType, count);
			while (countType == CountType.UntilStopped || remaining > 0)
			{
				Click:
				if (!IsAlive)
					return;

				// ちょっと寝る
				if (delayType == DelayType.Range)
					nextDelay = rnd.Next(delay, delayRange);

				Thread.Sleep(nextDelay);
				//System.Diagnostics.Debug.Print("Had a nap");

				// perform chance check
				if (chance != 100 && (rnd.Next(100) > chance))
                {
					remaining--;
					//System.Diagnostics.Debug.Print("Chance failed to click");
					goto Click;
				}

				List<Win32.INPUT> inputs = new List<Win32.INPUT>();

				// Move the mouse if required.
				if (locationType == LocationType.Fixed)
				{
					Win32.INPUT input = new Win32.INPUT
					{
						mi = new Win32.MOUSEINPUT
						{
							dx = Win32.CalculateAbsoluteCoordinateX(x),
							dy = Win32.CalculateAbsoluteCoordinateY(y),
							dwFlags = Win32.MouseEventFlags.Move | Win32.MouseEventFlags.Absolute
						}
					};
					inputs.Add(input);
				}

				else if (locationType == LocationType.Random)
				{
					Win32.INPUT input = new Win32.INPUT
					{
						mi = new Win32.MOUSEINPUT
						{
							dx = rnd.Next(65536),
							dy = rnd.Next(65536),
							dwFlags = Win32.MouseEventFlags.Move | Win32.MouseEventFlags.Absolute
						}
					};
					inputs.Add(input);
				}

				else if (locationType == LocationType.RandomRange)
				{
					Win32.INPUT input = new Win32.INPUT
					{
						mi = new Win32.MOUSEINPUT
						{
							dx = Win32.CalculateAbsoluteCoordinateX(rnd.Next(x, x + width)),
							dy = Win32.CalculateAbsoluteCoordinateY(rnd.Next(y, y + height)),
							dwFlags = Win32.MouseEventFlags.Move | Win32.MouseEventFlags.Absolute
						}
					};
					inputs.Add(input);
				}

				else if (locationType == LocationType.RandomAtCursor)
                {
					if (!CheckedMousePos)
					{
						RandomAtCursorOriginalX = Cursor.Position.X;
						RandomAtCursorOriginalY = Cursor.Position.Y;

						CheckedMousePos = true;
					}

					Win32.INPUT input = new Win32.INPUT
					{
						mi = new Win32.MOUSEINPUT
						{
							dx = Win32.CalculateAbsoluteCoordinateX(rnd.Next(RandomAtCursorOriginalX - x, RandomAtCursorOriginalX + x)),
							dy = Win32.CalculateAbsoluteCoordinateY(rnd.Next(RandomAtCursorOriginalY - y, RandomAtCursorOriginalY + y)),
							dwFlags = Win32.MouseEventFlags.Move | Win32.MouseEventFlags.Absolute
						}
					};
					inputs.Add(input);
                }
				//System.Diagnostics.Debug.Print("Move command added");

				// マウスをクリック
				for (int i = 0; i < (doubleClick ? 2 : 1); i++)
				{
					// Add a delay if it's a double click.
					if (i == 1)
						Thread.Sleep(50);

					if (leftClick)
					{
						Win32.INPUT leftclick = new Win32.INPUT
						{
							mi = new Win32.MOUSEINPUT
							{
								dwFlags = Win32.MouseEventFlags.LeftDown | Win32.MouseEventFlags.LeftUp
							}
						};
						inputs.Add(leftclick);
					}

					if (middleClick)
					{
						Win32.INPUT middleclick = new Win32.INPUT
						{
							mi = new Win32.MOUSEINPUT
							{
								dwFlags = Win32.MouseEventFlags.MiddleDown | Win32.MouseEventFlags.MiddleUp
							}
						};
						inputs.Add(middleclick);
					}

					if (rightClick)
					{
						Win32.INPUT rightclick = new Win32.INPUT
						{
							mi = new Win32.MOUSEINPUT
							{
								dwFlags = Win32.MouseEventFlags.RightDown | Win32.MouseEventFlags.RightUp
							}
						};
						inputs.Add(rightclick);
					}
				}
				//System.Diagnostics.Debug.Print("Click commands added");

				Win32.SendInput((uint)inputs.Count, inputs.ToArray(), Marshal.SizeOf(new Win32.INPUT()));
				//System.Diagnostics.Debug.Print("Command sent");

				remaining--;
			}
			Finished?.Invoke(this, null);
		}

		public bool IsAlive
		{
			get
			{
				if (Clicker == null)
					return false;

				return Clicker.IsAlive;
			}
		}

		public void Start()
		{
            Clicker = new Thread(Click)
            {
                IsBackground = true
            };
            Clicker.Start();
		}

		public void Stop()
		{
			if (Clicker != null)
				Clicker.Abort();
		}

		public void UpdateButton(bool tmpLeftClick, bool tmpMiddleClick, bool tmpRightClick, bool tmpDoubleClick)
		{
			leftClick = tmpLeftClick;
			middleClick = tmpMiddleClick;
			rightClick = tmpRightClick;
			doubleClick = tmpDoubleClick;
		}

		public void UpdateLocation(LocationType tmpLocationType, int tmpX, int tmpY, int tmpWidth, int tmpHeight)
		{
			locationType = tmpLocationType;
			x = tmpX;
			y = tmpY;
			width = tmpWidth;
			height = tmpHeight;
		}

		public void UpdateDelay(DelayType tmpDelayType, int tmpDelay, int tmpDelayRange)
		{
			delayType = tmpDelayType;
			delay = tmpDelay;
			delayRange = tmpDelayRange;
		}

		public void UpdateCount(CountType tmpCountType, int tmpCount)
		{
			countType = tmpCountType;
			count = tmpCount;
		}

		public void UpdateChance(int tmpChance)
		{
			chance = tmpChance;
		}
	}
}
