
namespace Directory_printer
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "Print to text";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "*.*",
            "*.$$$",
            "*.386",
            "*.8svx",
            "*.aac",
            "*.abk",
            "*.accdb",
            "*.ai",
            "*.aiff",
            "*.apk",
            "*.app",
            "*.apx",
            "*.asc",
            "*.asd",
            "*.asm",
            "*.atm",
            "*.avi",
            "*.bak",
            "*.bat",
            "*.bmk",
            "*.bmp",
            "*.c",
            "*.c++",
            "*.cab",
            "*.cdr",
            "*.cfg",
            "*.cmp",
            "*.cpl",
            "*cs",
            "*.csv",
            "*.dbf",
            "*.dcr",
            "*.dif",
            "*.dir",
            "*.doc",
            "*.docm",
            "*.docx",
            "*.dot",
            "*.dotm",
            "*.dotx",
            "*.drv",
            "*.eaac",
            "*.exe",
            "*.faq",
            "*.fla",
            "*.fnt",
            "*.fon",
            "*.gif",
            "*.hlp",
            "*.htm",
            "*.html",
            "*.inf",
            "*.ini",
            "*.j2k",
            "*.jar",
            "*.jp2",
            "*.jpeg",
            "*.jpg",
            "*json",
            "*.lib",
            "*.m4v",
            "*.mdb",
            "*.mht",
            "*.mhtml",
            "*.mid",
            "*.mov",
            "*.mp3",
            "*.mp4",
            "*.mpeg",
            "*.mpg",
            "*.nbi",
            "*.nfo",
            "*.nsf",
            "*.ods",
            "*.odt",
            "*.old",
            "*.pdf",
            "*.pps",
            "*.ppt",
            "*.pptx",
            "*.prn",
            "*.psd",
            "*.pst",
            "*.qt",
            "*.ram",
            "*.rar",
            "*.rec",
            "*.reg",
            "*.rtf",
            "*.sgm",
            "*.sgml",
            "*.swf",
            "*.sys",
            "*.tar",
            "*.tif",
            "*.tiff",
            "*.tmp",
            "*.ttf",
            "*.txt",
            "*.vbs",
            "*.vxd",
            "*.wav",
            "*.wdb",
            "*.wks",
            "*.wmv",
            "*.wps",
            "*.xlam",
            "*.xlk",
            "*.xll",
            "*.xls",
            "*.xlsb",
            "*.xlsm",
            "*.xlsx",
            "*.xltx",
            "*.xml",
            "*.xps",
            "*.zip"});
            this.comboBox1.Location = new System.Drawing.Point(299, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.MouseCaptureChanged += new System.EventHandler(this.comboBox1_MouseCaptureChanged);
            this.comboBox1.MouseHover += new System.EventHandler(this.comboBox1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo di File";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 137);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(439, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 159);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory to txt";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

