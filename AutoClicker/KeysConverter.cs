using System.Text;
using System.Windows.Forms;

namespace AutoClicker
{
	public class KeysConverter
	{
		public static string Convert(Keys keys)
		{
			return ConvertModifiers(keys) + ConvertKeyPart(keys);
		}

		public static string ConvertModifiers(Keys keys)
		{
			StringBuilder output = new StringBuilder();

			if ((keys & Keys.Shift) != 0)
				output.Append("Shift + ");

			if ((keys & Keys.Control) != 0)
				output.Append("Ctrl + ");

			if ((keys & Keys.Alt) != 0)
				output.Append("Alt + ");

			return output.ToString();
		}

		public static string ConvertKeyPart(Keys keys)
		{
			// Trim off the modifiers
			var trimmedKeys = keys & Keys.KeyCode;

			switch (trimmedKeys)
			{
				case Keys.Back:
					return "Backspace";
				case Keys.Return:
					return "Enter";
				case Keys.Capital:
					return "Caps Lock";
				case Keys.PageUp:
					return "Page Up";
				case Keys.PageDown:
					return "Page Down";
				case Keys.PrintScreen:
					return "Print Screen";
				case Keys.D0:
					return "0";
				case Keys.D1:
					return "1";
				case Keys.D2:
					return "2";
				case Keys.D3:
					return "3";
				case Keys.D4:
					return "4";
				case Keys.D5:
					return "5";
				case Keys.D6:
					return "6";
				case Keys.D7:
					return "7";
				case Keys.D8:
					return "8";
				case Keys.D9:
					return "9";
				case Keys.NumPad0:
					return "Num 0";
				case Keys.NumPad1:
					return "Num 1";
				case Keys.NumPad2:
					return "Num 2";
				case Keys.NumPad3:
					return "Num 3";
				case Keys.NumPad4:
					return "Num 4";
				case Keys.NumPad5:
					return "Num 5";
				case Keys.NumPad6:
					return "Num 6";
				case Keys.NumPad7:
					return "Num 7";
				case Keys.NumPad8:
					return "Num 8";
				case Keys.NumPad9:
					return "Num 9";
				case Keys.Multiply:
					return "Num *";
				case Keys.Add:
					return "Num +";
				case Keys.Subtract:
					return "Num -";
				case Keys.Decimal:
					return "Num .";
				case Keys.Divide:
					return "Num /";
				case Keys.NumLock:
					return "Num Lock";
				case Keys.Scroll:
					return "Scroll Lock";
				case Keys.OemSemicolon:
					return ";";
				case Keys.Oemplus:
					return "+";
				case Keys.Oemcomma:
					return ",";
				case Keys.OemMinus:
					return "-";
				case Keys.OemPeriod:
					return ".";
				case Keys.OemQuestion:
					return "?";
				case Keys.Oemtilde:
					return "`";
				case Keys.OemOpenBrackets:
					return "[";
				case Keys.OemPipe:
					return "|";
				case Keys.OemCloseBrackets:
					return "]";
				case Keys.OemQuotes:
					return "'";
				case Keys.OemBackslash:
					return "\\";
				default:
					return trimmedKeys.ToString();
			}
		}
	}
}
