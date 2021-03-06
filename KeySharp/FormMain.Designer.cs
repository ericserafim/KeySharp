
namespace KeySharp
{
  partial class FormMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.Exit = new System.Windows.Forms.ToolStripMenuItem();
      this.grid = new System.Windows.Forms.DataGridView();
      this.gridDetail = new System.Windows.Forms.DataGridView();
      this.MainMenu = new System.Windows.Forms.MenuStrip();
      this.DeviceScanMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
      this.MainMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Text = "notifyIcon1";
      this.notifyIcon1.Visible = true;
      this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
      // 
      // Exit
      // 
      this.Exit.Name = "Exit";
      this.Exit.Size = new System.Drawing.Size(93, 22);
      this.Exit.Text = "Exit";
      this.Exit.Click += new System.EventHandler(this.Exit_Click);
      // 
      // grid
      // 
      this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid.Location = new System.Drawing.Point(12, 38);
      this.grid.MultiSelect = false;
      this.grid.Name = "grid";
      this.grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.grid.Size = new System.Drawing.Size(512, 118);
      this.grid.TabIndex = 1;
      this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
      // 
      // gridDetail
      // 
      this.gridDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridDetail.Location = new System.Drawing.Point(12, 172);
      this.gridDetail.MultiSelect = false;
      this.gridDetail.Name = "gridDetail";
      this.gridDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.gridDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gridDetail.Size = new System.Drawing.Size(512, 198);
      this.gridDetail.TabIndex = 2;
      // 
      // MainMenu
      // 
      this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeviceScanMenu});
      this.MainMenu.Location = new System.Drawing.Point(0, 0);
      this.MainMenu.Name = "MainMenu";
      this.MainMenu.Size = new System.Drawing.Size(536, 24);
      this.MainMenu.TabIndex = 3;
      this.MainMenu.Text = "menuStrip1";
      // 
      // DeviceScanMenu
      // 
      this.DeviceScanMenu.Name = "DeviceScanMenu";
      this.DeviceScanMenu.Size = new System.Drawing.Size(82, 20);
      this.DeviceScanMenu.Text = "Device Scan";
      this.DeviceScanMenu.Click += new System.EventHandler(this.DeviceScanMenu_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(536, 385);
      this.Controls.Add(this.MainMenu);
      this.Controls.Add(this.gridDetail);
      this.Controls.Add(this.grid);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.MainMenu;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MaximizeBox = false;
      this.Name = "FormMain";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Keysharp mapping";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Resize += new System.EventHandler(this.Form1_Resize);
      this.contextMenuStrip1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
      this.MainMenu.ResumeLayout(false);
      this.MainMenu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.NotifyIcon notifyIcon1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem Exit;
    private System.Windows.Forms.DataGridView grid;
    private System.Windows.Forms.DataGridView gridDetail;
    private System.Windows.Forms.MenuStrip MainMenu;
    private System.Windows.Forms.ToolStripMenuItem DeviceScanMenu;
  }
}

