using System;
using System.IO;

namespace Task1_1
{
	public class WriterToFile
	{
		public void Write(string path, string text)
		{
			File.AppendAllText(path, text);
		}

		public void Write(string path, string text, bool ifExist)
		{
			if (!ifExist)
			{
				File.WriteAllText(path, text);
			}
			else
			{
				Write(path, text);
			}
		}
	}
}
