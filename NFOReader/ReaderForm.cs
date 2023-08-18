using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NFOReaderApplication
{
	// Token: 0x02000003 RID: 3
	public partial class ReaderForm : Form
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002075 File Offset: 0x00000275
		public ReaderForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002083 File Offset: 0x00000283
		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002085 File Offset: 0x00000285
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002087 File Offset: 0x00000287
		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000208C File Offset: 0x0000028C
		private void openToolStripButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "NFO Files|*.nfo|DIZ Files|*.diz|All files|*.*";
			openFileDialog.FilterIndex = 1;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.richTextBox.Clear();
				string fileName = openFileDialog.FileName;
				StreamReader streamReader = File.OpenText(fileName);
				string arg;
				while ((arg = streamReader.ReadLine()) != null)
				{
					RichTextBox richTextBox = this.richTextBox;
					richTextBox.Text = richTextBox.Text + arg + '\n';
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020FD File Offset: 0x000002FD
		private void helpToolStripButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("NRO Reader\nFreeware\nhttp://www.nforeader.com", "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}
}
