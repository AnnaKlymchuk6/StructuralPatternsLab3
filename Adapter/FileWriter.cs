using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace StructuralPatternsLab.Adapter
{
	class FileWriter
	{
		private string path;

		public FileWriter(string path)
		{
			this.path = path;
		}

		public void Write(string message)
		{
			File.AppendAllText(path, message);
		}

		public void WriteLine(string message)
		{
			File.AppendAllText(path, message + "\n");
		}
	}
}
