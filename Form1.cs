using csvformattingtools;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
namespace Employee_Parser
{
    public class EmployeeParser : Form
  {
    protected DataTable Dataloadedin;
    private bool _filechanged;
    private IContainer components;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem openCSVFileToolStripMenuItem;
    private ToolStripMenuItem formatDataToolStripMenuItem;
    private ToolStripMenuItem saveToKeyWizardCSVFileToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private OpenFileDialog openFileCSV;
    private SaveFileDialog saveFileCSV;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem toolStripMenuItem1;
    private DataGridView Viewer1;

    public EmployeeParser()
    {
            InitializeComponent();
    }

    private void saveToKeyWizardCSVFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!_filechanged)
        return;
      int num = (int)saveFileCSV.ShowDialog();
            Viewer1.DataSource = (object) null;
            Viewer1.Columns.Clear();
    }

    private void formatDataToolStripMenuItem_Click(object sender, EventArgs e)
    {
            Viewer1.DataSource = (object) null;
            Viewer1.Columns.Clear();
            Viewer1.DataSource = (object) Csvformatter.FormatForKeyWizardImport(Dataloadedin);
            _filechanged = true;
    }

    private void openCSVFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (openFileCSV.ShowDialog() != DialogResult.OK)
        return;
      Csvformatter.Checkcommas(openFileCSV.FileName);
            Dataloadedin = Csvformatter.GetCsvFile(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\importthis.csv");
            Viewer1.DataSource = null;
            Viewer1.Columns.Clear();
            Viewer1.DataSource = Dataloadedin;
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void saveFileCSV_FileOk(object sender, CancelEventArgs e)
    {
      Csvformatter.CreateCsvFile(Dataloadedin, saveFileCSV.FileName);
      int num = (int) MessageBox.Show("CSV file created.");
            _filechanged = false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openCSVFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            formatDataToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            saveToKeyWizardCSVFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            openFileCSV = new System.Windows.Forms.OpenFileDialog();
            saveFileCSV = new System.Windows.Forms.SaveFileDialog();
            Viewer1 = new System.Windows.Forms.DataGridView();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(Viewer1)).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(984, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            openCSVFileToolStripMenuItem,
            toolStripSeparator1,
            formatDataToolStripMenuItem,
            toolStripMenuItem1,
            toolStripSeparator2,
            saveToKeyWizardCSVFileToolStripMenuItem,
            toolStripSeparator3,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openCSVFileToolStripMenuItem
            // 
            openCSVFileToolStripMenuItem.Name = "openCSVFileToolStripMenuItem";
            openCSVFileToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            openCSVFileToolStripMenuItem.Text = "Open CSV File";
            openCSVFileToolStripMenuItem.Click += new System.EventHandler(openCSVFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // formatDataToolStripMenuItem
            // 
            formatDataToolStripMenuItem.Name = "formatDataToolStripMenuItem";
            formatDataToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            formatDataToolStripMenuItem.Text = "Format Data";
            formatDataToolStripMenuItem.Click += new System.EventHandler(formatDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(218, 6);
            // 
            // saveToKeyWizardCSVFileToolStripMenuItem
            // 
            saveToKeyWizardCSVFileToolStripMenuItem.Name = "saveToKeyWizardCSVFileToolStripMenuItem";
            saveToKeyWizardCSVFileToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            saveToKeyWizardCSVFileToolStripMenuItem.Text = "Save To Key Wizard CSV File";
            saveToKeyWizardCSVFileToolStripMenuItem.Click += new System.EventHandler(saveToKeyWizardCSVFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(218, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += new System.EventHandler(exitToolStripMenuItem_Click);
            // 
            // saveFileCSV
            // 
            saveFileCSV.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            saveFileCSV.FileOk += new System.ComponentModel.CancelEventHandler(saveFileCSV_FileOk);
            // 
            // Viewer1
            // 
            Viewer1.AllowUserToAddRows = false;
            Viewer1.AllowUserToDeleteRows = false;
            Viewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            Viewer1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            Viewer1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            Viewer1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Viewer1.Location = new System.Drawing.Point(12, 39);
            Viewer1.Name = "Viewer1";
            Viewer1.ReadOnly = true;
            Viewer1.Size = new System.Drawing.Size(960, 299);
            Viewer1.TabIndex = 1;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            toolStripMenuItem1.Text = "Add Email Addresses";
            toolStripMenuItem1.Click += new System.EventHandler(toolStripMenuItem1_Click);
            // 
            // EmployeeParser
            // 
            ClientSize = new System.Drawing.Size(984, 350);
            Controls.Add(Viewer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "EmployeeParser";
            Text = "Employee Parser For Key Wizard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(Viewer1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
        if (openFileCSV.ShowDialog() != DialogResult.OK)
            return;
        var addressdt = Csvformatter.GetCsvFile(openFileCSV.FileName);
            Dataloadedin = Csvformatter.AddAddressessToDataTable(Dataloadedin, addressdt);
        Viewer1.DataSource = Dataloadedin;
        Viewer1.Refresh();
    }
  }
}
