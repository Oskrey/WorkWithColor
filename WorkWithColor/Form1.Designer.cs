
namespace WorkWithColor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonVertical = new System.Windows.Forms.Button();
            this.buttonHorizontal = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelOriginalColor = new System.Windows.Forms.Label();
            this.pictureBoxOrigColor = new System.Windows.Forms.PictureBox();
            this.labelDesiredColor = new System.Windows.Forms.Label();
            this.pictureBoxDesirColor = new System.Windows.Forms.PictureBox();
            this.textBoxSettingsColor1 = new System.Windows.Forms.TextBox();
            this.textBoxSettingsColor2 = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.labelBlue = new System.Windows.Forms.Label();
            this.trackBarAdmittance = new System.Windows.Forms.TrackBar();
            this.labelAdmittance = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxAdmittance = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesirColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAdmittance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(14, -2);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(30, 22);
            this.buttonPlus.TabIndex = 1;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(14, 26);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(30, 22);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonDefault
            // 
            this.buttonDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDefault.Location = new System.Drawing.Point(14, 54);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(30, 22);
            this.buttonDefault.TabIndex = 1;
            this.buttonDefault.Text = "D";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeft.Location = new System.Drawing.Point(14, 82);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 22);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.Text = "<-";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.Location = new System.Drawing.Point(14, 110);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 22);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.Text = "->";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonVertical
            // 
            this.buttonVertical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVertical.Location = new System.Drawing.Point(14, 138);
            this.buttonVertical.Name = "buttonVertical";
            this.buttonVertical.Size = new System.Drawing.Size(30, 22);
            this.buttonVertical.TabIndex = 1;
            this.buttonVertical.Text = "|";
            this.buttonVertical.UseVisualStyleBackColor = true;
            this.buttonVertical.Click += new System.EventHandler(this.buttonVertical_Click);
            // 
            // buttonHorizontal
            // 
            this.buttonHorizontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHorizontal.Location = new System.Drawing.Point(14, 166);
            this.buttonHorizontal.Name = "buttonHorizontal";
            this.buttonHorizontal.Size = new System.Drawing.Size(30, 22);
            this.buttonHorizontal.TabIndex = 1;
            this.buttonHorizontal.Text = "--";
            this.buttonHorizontal.UseVisualStyleBackColor = true;
            this.buttonHorizontal.Click += new System.EventHandler(this.buttonVertical_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(14, 194);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(30, 22);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open..";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save as..";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelOriginalColor
            // 
            this.labelOriginalColor.AutoSize = true;
            this.labelOriginalColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOriginalColor.Location = new System.Drawing.Point(47, -1);
            this.labelOriginalColor.Name = "labelOriginalColor";
            this.labelOriginalColor.Size = new System.Drawing.Size(103, 16);
            this.labelOriginalColor.TabIndex = 3;
            this.labelOriginalColor.Text = "Original Color";
            // 
            // pictureBoxOrigColor
            // 
            this.pictureBoxOrigColor.BackColor = System.Drawing.Color.Azure;
            this.pictureBoxOrigColor.Location = new System.Drawing.Point(50, 27);
            this.pictureBoxOrigColor.Name = "pictureBoxOrigColor";
            this.pictureBoxOrigColor.Size = new System.Drawing.Size(52, 47);
            this.pictureBoxOrigColor.TabIndex = 4;
            this.pictureBoxOrigColor.TabStop = false;
            // 
            // labelDesiredColor
            // 
            this.labelDesiredColor.AutoSize = true;
            this.labelDesiredColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDesiredColor.Location = new System.Drawing.Point(47, 86);
            this.labelDesiredColor.Name = "labelDesiredColor";
            this.labelDesiredColor.Size = new System.Drawing.Size(104, 16);
            this.labelDesiredColor.TabIndex = 3;
            this.labelDesiredColor.Text = "Desired Color";
            // 
            // pictureBoxDesirColor
            // 
            this.pictureBoxDesirColor.BackColor = System.Drawing.Color.Azure;
            this.pictureBoxDesirColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDesirColor.Location = new System.Drawing.Point(50, 114);
            this.pictureBoxDesirColor.Name = "pictureBoxDesirColor";
            this.pictureBoxDesirColor.Size = new System.Drawing.Size(52, 47);
            this.pictureBoxDesirColor.TabIndex = 4;
            this.pictureBoxDesirColor.TabStop = false;
            this.pictureBoxDesirColor.Click += new System.EventHandler(this.pictureBoxDesirColor_Click);
            // 
            // textBoxSettingsColor1
            // 
            this.textBoxSettingsColor1.Location = new System.Drawing.Point(132, 56);
            this.textBoxSettingsColor1.Name = "textBoxSettingsColor1";
            this.textBoxSettingsColor1.Size = new System.Drawing.Size(227, 20);
            this.textBoxSettingsColor1.TabIndex = 5;
            // 
            // textBoxSettingsColor2
            // 
            this.textBoxSettingsColor2.Location = new System.Drawing.Point(132, 143);
            this.textBoxSettingsColor2.Name = "textBoxSettingsColor2";
            this.textBoxSettingsColor2.Size = new System.Drawing.Size(227, 20);
            this.textBoxSettingsColor2.TabIndex = 5;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDraw.Location = new System.Drawing.Point(379, 27);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(77, 49);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(132, 206);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(227, 45);
            this.trackBarRed.TabIndex = 6;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRed.Location = new System.Drawing.Point(129, 184);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(37, 16);
            this.labelRed.TabIndex = 3;
            this.labelRed.Text = "Red";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGreen.Location = new System.Drawing.Point(129, 254);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(50, 16);
            this.labelGreen.TabIndex = 3;
            this.labelGreen.Text = "Green";
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(132, 277);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(227, 45);
            this.trackBarGreen.TabIndex = 6;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBlue.Location = new System.Drawing.Point(129, 325);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(39, 16);
            this.labelBlue.TabIndex = 3;
            this.labelBlue.Text = "Blue";
            // 
            // trackBarAdmittance
            // 
            this.trackBarAdmittance.Location = new System.Drawing.Point(132, 417);
            this.trackBarAdmittance.Maximum = 100;
            this.trackBarAdmittance.Minimum = 5;
            this.trackBarAdmittance.Name = "trackBarAdmittance";
            this.trackBarAdmittance.Size = new System.Drawing.Size(227, 45);
            this.trackBarAdmittance.TabIndex = 6;
            this.trackBarAdmittance.Value = 5;
            // 
            // labelAdmittance
            // 
            this.labelAdmittance.AutoSize = true;
            this.labelAdmittance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdmittance.Location = new System.Drawing.Point(129, 392);
            this.labelAdmittance.Name = "labelAdmittance";
            this.labelAdmittance.Size = new System.Drawing.Size(85, 16);
            this.labelAdmittance.TabIndex = 3;
            this.labelAdmittance.Text = "Admittance";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(132, 344);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(227, 45);
            this.trackBarBlue.TabIndex = 6;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(379, 206);
            this.textBoxRed.Multiline = true;
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(77, 29);
            this.textBoxRed.TabIndex = 7;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(379, 277);
            this.textBoxGreen.Multiline = true;
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(77, 29);
            this.textBoxGreen.TabIndex = 7;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Location = new System.Drawing.Point(379, 344);
            this.textBoxBlue.Multiline = true;
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(77, 29);
            this.textBoxBlue.TabIndex = 7;
            // 
            // textBoxAdmittance
            // 
            this.textBoxAdmittance.Location = new System.Drawing.Point(379, 417);
            this.textBoxAdmittance.Multiline = true;
            this.textBoxAdmittance.Name = "textBoxAdmittance";
            this.textBoxAdmittance.Size = new System.Drawing.Size(77, 29);
            this.textBoxAdmittance.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.textBoxAdmittance);
            this.panel1.Controls.Add(this.pictureBoxOrigColor);
            this.panel1.Controls.Add(this.textBoxBlue);
            this.panel1.Controls.Add(this.buttonPlus);
            this.panel1.Controls.Add(this.textBoxGreen);
            this.panel1.Controls.Add(this.buttonDraw);
            this.panel1.Controls.Add(this.textBoxRed);
            this.panel1.Controls.Add(this.buttonMinus);
            this.panel1.Controls.Add(this.trackBarBlue);
            this.panel1.Controls.Add(this.buttonDefault);
            this.panel1.Controls.Add(this.trackBarAdmittance);
            this.panel1.Controls.Add(this.buttonLeft);
            this.panel1.Controls.Add(this.trackBarGreen);
            this.panel1.Controls.Add(this.buttonRight);
            this.panel1.Controls.Add(this.trackBarRed);
            this.panel1.Controls.Add(this.buttonVertical);
            this.panel1.Controls.Add(this.textBoxSettingsColor2);
            this.panel1.Controls.Add(this.buttonHorizontal);
            this.panel1.Controls.Add(this.textBoxSettingsColor1);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.labelAdmittance);
            this.panel1.Controls.Add(this.labelOriginalColor);
            this.panel1.Controls.Add(this.pictureBoxDesirColor);
            this.panel1.Controls.Add(this.labelRed);
            this.panel1.Controls.Add(this.labelBlue);
            this.panel1.Controls.Add(this.labelGreen);
            this.panel1.Controls.Add(this.labelDesiredColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(469, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 479);
            this.panel1.TabIndex = 9;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBoxMain.ErrorImage = null;
            this.pictureBoxMain.InitialImage = null;
            this.pictureBoxMain.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(123, 130);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 9;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBoxMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 479);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(929, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesirColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAdmittance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonVertical;
        private System.Windows.Forms.Button buttonHorizontal;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelOriginalColor;
        private System.Windows.Forms.PictureBox pictureBoxOrigColor;
        private System.Windows.Forms.Label labelDesiredColor;
        private System.Windows.Forms.PictureBox pictureBoxDesirColor;
        private System.Windows.Forms.TextBox textBoxSettingsColor1;
        private System.Windows.Forms.TextBox textBoxSettingsColor2;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.TrackBar trackBarAdmittance;
        private System.Windows.Forms.Label labelAdmittance;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxAdmittance;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
    }
}

