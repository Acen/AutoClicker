using System.Drawing;
using System.Windows.Forms;

namespace AutoClicker
{
	public partial class SelectionForm : Form
	{
		public bool ButtonDown;

		public Point ClickPoint = new Point();
		public Point CurrentTopLeft = new Point();
		public Point CurrentBottomRight = new Point();

		public int RectangleHeight = new int();
		public int RectangleWidth = new int();
		readonly Graphics g;
		readonly Pen BlackPen = new Pen(Color.Black, 5);
		readonly Pen EraserPen = new Pen(Color.FromArgb(051, 153, 255), 5);

		private MainForm instanceRef;

		public MainForm InstanceRef
		{
			get
			{
				return instanceRef;
			}
			set
			{
				instanceRef = value;
			}
		}

		public SelectionForm(MainForm instanceRef)
		{
			TopMost = true;
			InitializeComponent();
			InstanceRef = instanceRef;
			MouseDown += HandleMouseClick;
			MouseMove += HandleMouseMove;
			MouseUp += HandleMouseUp;

			Left = 0;
			Top = 0;
			var width = 0;
			var height = 0;
			var screens = Screen.AllScreens;
			foreach (var screen in screens)
			{
				height = screen.Bounds.Height;
				width = screen.Bounds.Width;
			}

			Width = width;
			Height = height;

			g = CreateGraphics();
		}

		private void HandleMouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons)
			{
				ClickPoint = new Point(MousePosition.X, MousePosition.Y);
				ButtonDown = true;
			}
		}

		private void HandleMouseUp(object sender, MouseEventArgs e)
		{
			instanceRef.SendRectangle(CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);
			Close();
		}

		private void HandleMouseMove(object sender, MouseEventArgs e)
		{
			if (ButtonDown)
				DrawSelection();
		}

		private void DrawSelection()
		{
			//Erase the previous rectangle
			g.DrawRectangle(EraserPen, CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);

			//Calculate X Coordinates
			if (Cursor.Position.X < ClickPoint.X)
			{
				CurrentTopLeft.X = Cursor.Position.X;
				CurrentBottomRight.X = ClickPoint.X;
			}
			else
			{
				CurrentTopLeft.X = ClickPoint.X;
				CurrentBottomRight.X = Cursor.Position.X;
			}

			//Calculate Y Coordinates
			if (Cursor.Position.Y < ClickPoint.Y)
			{
				CurrentTopLeft.Y = Cursor.Position.Y;
				CurrentBottomRight.Y = ClickPoint.Y;
			}
			else
			{
				CurrentTopLeft.Y = ClickPoint.Y;
				CurrentBottomRight.Y = Cursor.Position.Y;
			}

			//Draw a new rectangle
			g.DrawRectangle(BlackPen, CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);
		}
	}

	public partial class SelectionFormFixed : Form
	{
		public bool ButtonDown;
		public Point ClickPointFixed = new Point();

		private MainForm instanceRef;

		public MainForm InstanceRef
		{
			get
			{
				return instanceRef;
			}
			set
			{
				instanceRef = value;
			}
		}

		public SelectionFormFixed(MainForm instanceRef)
		{
			TopMost = true;
			InitializeComponent();
			InstanceRef = instanceRef;
			MouseDown += HandleMouseClick;
			MouseUp += HandleMouseUp;

			Left = 0;
			Top = 0;
			var width = 0;
			var height = 0;
			var screens = Screen.AllScreens;
			foreach (var screen in screens)
			{
				height = screen.Bounds.Height;
				width = screen.Bounds.Width;
			}

			Width = width;
			Height = height;
		}

        private void HandleMouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons)
			{
				ClickPointFixed = new Point(MousePosition.X, MousePosition.Y);
				ButtonDown = true;
			}
		}

		private void HandleMouseUp(object sender, MouseEventArgs e)
		{
			instanceRef.SendFixedXY(MousePosition.X, MousePosition.Y);
			Close();
		}
	}
}
