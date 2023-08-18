using System;
using System.Windows.Forms;

namespace NFOReaderApplication
{
	// Token: 0x02000005 RID: 5
	internal static class Program
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000024EA File Offset: 0x000006EA
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ReaderForm());
		}
	}
}
