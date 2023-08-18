namespace NFOReaderApplication
{
	// Token: 0x02000003 RID: 3
	public partial class ReaderForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002112 File Offset: 0x00000312
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002134 File Offset: 0x00000334
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NFOReaderApplication.ReaderForm));
			this.toolStrip = new global::System.Windows.Forms.ToolStrip();
			this.openToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new global::System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.richTextBox = new global::System.Windows.Forms.RichTextBox();
			this.toolStrip.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.openToolStripButton,
				this.toolStripSeparator,
				this.aboutToolStripButton
			});
			this.toolStrip.Location = new global::System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new global::System.Drawing.Size(684, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			this.toolStrip.ItemClicked += new global::System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
			this.openToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("openToolStripButton.Image");
			this.openToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new global::System.Drawing.Size(23, 22);
			this.openToolStripButton.Text = "&Open";
			this.openToolStripButton.Click += new global::System.EventHandler(this.openToolStripButton_Click);
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new global::System.Drawing.Size(6, 25);
			this.aboutToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.aboutToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("aboutToolStripButton.Image");
			this.aboutToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.aboutToolStripButton.Name = "aboutToolStripButton";
			this.aboutToolStripButton.Size = new global::System.Drawing.Size(23, 22);
			this.aboutToolStripButton.Text = "About";
			this.aboutToolStripButton.Click += new global::System.EventHandler(this.helpToolStripButton_Click);
			this.richTextBox.BackColor = global::System.Drawing.Color.Black;
			this.richTextBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.richTextBox.ForeColor = global::System.Drawing.Color.White;
			this.richTextBox.Location = new global::System.Drawing.Point(0, 25);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.ReadOnly = true;
			this.richTextBox.Size = new global::System.Drawing.Size(684, 437);
			this.richTextBox.TabIndex = 1;
			this.richTextBox.Text = "";
			this.richTextBox.TextChanged += new global::System.EventHandler(this.richTextBox1_TextChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(684, 462);
			base.Controls.Add(this.richTextBox);
			base.Controls.Add(this.toolStrip);
			base.Name = "ReaderForm";
			this.Text = "NFO Reader";
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.ToolStrip toolStrip;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.ToolStripButton openToolStripButton;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.ToolStripButton aboutToolStripButton;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.RichTextBox richTextBox;
	}
}
