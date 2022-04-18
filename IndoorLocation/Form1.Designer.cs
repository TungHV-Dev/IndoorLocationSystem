
namespace IndoorLocation
{
    partial class Form1
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
            this.label_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_LogoBK = new System.Windows.Forms.PictureBox();
            this.pictureBox_logoLab = new System.Windows.Forms.PictureBox();
            this.label_remark = new System.Windows.Forms.Label();
            this.label_designedBy = new System.Windows.Forms.Label();
            this.label_instructor = new System.Windows.Forms.Label();
            this.label_studentName = new System.Windows.Forms.Label();
            this.label_teacherName = new System.Windows.Forms.Label();
            this.label_accessPoint = new System.Windows.Forms.Label();
            this.label_passedPoint = new System.Windows.Forms.Label();
            this.label_currentPoint = new System.Windows.Forms.Label();
            this.label_destinationPoint = new System.Windows.Forms.Label();
            this.label_statement = new System.Windows.Forms.Label();
            this.label_displayCurrentPoint = new System.Windows.Forms.Label();
            this.textBox_X_cur = new System.Windows.Forms.TextBox();
            this.textBox_Y_cur = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.panel_X_des = new System.Windows.Forms.Panel();
            this.label_equal = new System.Windows.Forms.Label();
            this.label_des = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.panel_Y_des = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_X_cur = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_Y_cur = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.button_createProcessedData = new System.Windows.Forms.Button();
            this.saveFileDialog_save_data = new System.Windows.Forms.SaveFileDialog();
            this.zedGraphControl_map = new ZedGraph.ZedGraphControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_X_des = new System.Windows.Forms.ComboBox();
            this.comboBox_Y_des = new System.Windows.Forms.ComboBox();
            this.label_barriers = new System.Windows.Forms.Label();
            this.label_StartPoint = new System.Windows.Forms.Label();
            this.pictureBox_StartPoint = new System.Windows.Forms.PictureBox();
            this.pictureBox_barriers = new System.Windows.Forms.PictureBox();
            this.pictureBox_currentPoint = new System.Windows.Forms.PictureBox();
            this.pictureBox_accessPoint = new System.Windows.Forms.PictureBox();
            this.pictureBox_destinationPoint = new System.Windows.Forms.PictureBox();
            this.pictureBox_passedPoint = new System.Windows.Forms.PictureBox();
            this.label_mapType = new System.Windows.Forms.Label();
            this.comboBox_mapType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_nextPos_y = new System.Windows.Forms.TextBox();
            this.textBox_nextPos_x = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LogoBK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logoLab)).BeginInit();
            this.panel_X_des.SuspendLayout();
            this.panel_Y_des.SuspendLayout();
            this.panel_X_cur.SuspendLayout();
            this.panel_Y_cur.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_StartPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barriers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_currentPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_accessPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_destinationPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passedPoint)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.DarkRed;
            this.label_title.Location = new System.Drawing.Point(83, 0);
            this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(995, 60);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "INDOOR LOCATION AND NAVIGATION SYSTEM\nBASED ON BLUETOOTH LOW ENERGY";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Controls.Add(this.label_title, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_LogoBK, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_logoLab, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1162, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox_LogoBK
            // 
            this.pictureBox_LogoBK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_LogoBK.Image = global::IndoorLocation.Properties.Resources.BK;
            this.pictureBox_LogoBK.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_LogoBK.Name = "pictureBox_LogoBK";
            this.pictureBox_LogoBK.Size = new System.Drawing.Size(75, 54);
            this.pictureBox_LogoBK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_LogoBK.TabIndex = 1;
            this.pictureBox_LogoBK.TabStop = false;
            // 
            // pictureBox_logoLab
            // 
            this.pictureBox_logoLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_logoLab.Image = global::IndoorLocation.Properties.Resources.LogoLab;
            this.pictureBox_logoLab.Location = new System.Drawing.Point(1083, 3);
            this.pictureBox_logoLab.Name = "pictureBox_logoLab";
            this.pictureBox_logoLab.Size = new System.Drawing.Size(76, 54);
            this.pictureBox_logoLab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logoLab.TabIndex = 2;
            this.pictureBox_logoLab.TabStop = false;
            // 
            // label_remark
            // 
            this.label_remark.AutoSize = true;
            this.label_remark.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_remark.ForeColor = System.Drawing.Color.DimGray;
            this.label_remark.Location = new System.Drawing.Point(84, 109);
            this.label_remark.Name = "label_remark";
            this.label_remark.Size = new System.Drawing.Size(74, 19);
            this.label_remark.TabIndex = 2;
            this.label_remark.Text = "Remark:";
            this.label_remark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_designedBy
            // 
            this.label_designedBy.AutoSize = true;
            this.label_designedBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_designedBy.ForeColor = System.Drawing.Color.DimGray;
            this.label_designedBy.Location = new System.Drawing.Point(784, 109);
            this.label_designedBy.Name = "label_designedBy";
            this.label_designedBy.Size = new System.Drawing.Size(111, 19);
            this.label_designedBy.TabIndex = 3;
            this.label_designedBy.Text = "Designed by:";
            this.label_designedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_instructor
            // 
            this.label_instructor.AutoSize = true;
            this.label_instructor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_instructor.ForeColor = System.Drawing.Color.DimGray;
            this.label_instructor.Location = new System.Drawing.Point(784, 135);
            this.label_instructor.Name = "label_instructor";
            this.label_instructor.Size = new System.Drawing.Size(99, 19);
            this.label_instructor.TabIndex = 4;
            this.label_instructor.Text = "Supervisor:";
            this.label_instructor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_studentName
            // 
            this.label_studentName.AutoSize = true;
            this.label_studentName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_studentName.ForeColor = System.Drawing.Color.Black;
            this.label_studentName.Location = new System.Drawing.Point(901, 109);
            this.label_studentName.Name = "label_studentName";
            this.label_studentName.Size = new System.Drawing.Size(208, 18);
            this.label_studentName.TabIndex = 5;
            this.label_studentName.Text = "Ha Van Tung – ID: 20173456";
            this.label_studentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_teacherName
            // 
            this.label_teacherName.AutoSize = true;
            this.label_teacherName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_teacherName.ForeColor = System.Drawing.Color.Black;
            this.label_teacherName.Location = new System.Drawing.Point(901, 135);
            this.label_teacherName.Name = "label_teacherName";
            this.label_teacherName.Size = new System.Drawing.Size(127, 18);
            this.label_teacherName.TabIndex = 6;
            this.label_teacherName.Text = "Dr. Le Minh Thuy ";
            this.label_teacherName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_accessPoint
            // 
            this.label_accessPoint.AutoSize = true;
            this.label_accessPoint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accessPoint.ForeColor = System.Drawing.Color.Black;
            this.label_accessPoint.Location = new System.Drawing.Point(199, 110);
            this.label_accessPoint.Name = "label_accessPoint";
            this.label_accessPoint.Size = new System.Drawing.Size(136, 18);
            this.label_accessPoint.TabIndex = 7;
            this.label_accessPoint.Text = "Access Point (AP)";
            this.label_accessPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_passedPoint
            // 
            this.label_passedPoint.AutoSize = true;
            this.label_passedPoint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_passedPoint.ForeColor = System.Drawing.Color.Black;
            this.label_passedPoint.Location = new System.Drawing.Point(380, 109);
            this.label_passedPoint.Name = "label_passedPoint";
            this.label_passedPoint.Size = new System.Drawing.Size(79, 18);
            this.label_passedPoint.TabIndex = 8;
            this.label_passedPoint.Text = "Next Point";
            this.label_passedPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_currentPoint
            // 
            this.label_currentPoint.AutoSize = true;
            this.label_currentPoint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentPoint.ForeColor = System.Drawing.Color.Black;
            this.label_currentPoint.Location = new System.Drawing.Point(199, 136);
            this.label_currentPoint.Name = "label_currentPoint";
            this.label_currentPoint.Size = new System.Drawing.Size(99, 18);
            this.label_currentPoint.TabIndex = 9;
            this.label_currentPoint.Text = "Current Point";
            this.label_currentPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_destinationPoint
            // 
            this.label_destinationPoint.AutoSize = true;
            this.label_destinationPoint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_destinationPoint.ForeColor = System.Drawing.Color.Black;
            this.label_destinationPoint.Location = new System.Drawing.Point(559, 135);
            this.label_destinationPoint.Name = "label_destinationPoint";
            this.label_destinationPoint.Size = new System.Drawing.Size(127, 18);
            this.label_destinationPoint.TabIndex = 10;
            this.label_destinationPoint.Text = "Destination Point";
            this.label_destinationPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_statement
            // 
            this.label_statement.AutoSize = true;
            this.label_statement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statement.ForeColor = System.Drawing.Color.Black;
            this.label_statement.Location = new System.Drawing.Point(804, 203);
            this.label_statement.Name = "label_statement";
            this.label_statement.Size = new System.Drawing.Size(264, 19);
            this.label_statement.TabIndex = 11;
            this.label_statement.Text = "Choose the destination coordinates:";
            this.label_statement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_displayCurrentPoint
            // 
            this.label_displayCurrentPoint.AutoSize = true;
            this.label_displayCurrentPoint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayCurrentPoint.ForeColor = System.Drawing.Color.Black;
            this.label_displayCurrentPoint.Location = new System.Drawing.Point(789, 271);
            this.label_displayCurrentPoint.Name = "label_displayCurrentPoint";
            this.label_displayCurrentPoint.Size = new System.Drawing.Size(310, 19);
            this.label_displayCurrentPoint.TabIndex = 12;
            this.label_displayCurrentPoint.Text = "Current Position (automatically displayed):";
            this.label_displayCurrentPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_X_cur
            // 
            this.textBox_X_cur.BackColor = System.Drawing.Color.White;
            this.textBox_X_cur.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_X_cur.ForeColor = System.Drawing.Color.Black;
            this.textBox_X_cur.Location = new System.Drawing.Point(868, 298);
            this.textBox_X_cur.MaxLength = 7;
            this.textBox_X_cur.Name = "textBox_X_cur";
            this.textBox_X_cur.ReadOnly = true;
            this.textBox_X_cur.Size = new System.Drawing.Size(68, 26);
            this.textBox_X_cur.TabIndex = 15;
            this.textBox_X_cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Y_cur
            // 
            this.textBox_Y_cur.BackColor = System.Drawing.Color.White;
            this.textBox_Y_cur.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Y_cur.ForeColor = System.Drawing.Color.Black;
            this.textBox_Y_cur.Location = new System.Drawing.Point(1018, 298);
            this.textBox_Y_cur.MaxLength = 7;
            this.textBox_Y_cur.Name = "textBox_Y_cur";
            this.textBox_Y_cur.ReadOnly = true;
            this.textBox_Y_cur.Size = new System.Drawing.Size(68, 26);
            this.textBox_Y_cur.TabIndex = 16;
            this.textBox_Y_cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_start.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.SystemColors.Info;
            this.button_start.Location = new System.Drawing.Point(822, 414);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(98, 37);
            this.button_start.TabIndex = 17;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.StartAppEvent);
            // 
            // panel_X_des
            // 
            this.panel_X_des.Controls.Add(this.label_equal);
            this.panel_X_des.Controls.Add(this.label_des);
            this.panel_X_des.Controls.Add(this.label_X);
            this.panel_X_des.Location = new System.Drawing.Point(798, 228);
            this.panel_X_des.Name = "panel_X_des";
            this.panel_X_des.Size = new System.Drawing.Size(70, 31);
            this.panel_X_des.TabIndex = 19;
            // 
            // label_equal
            // 
            this.label_equal.AutoSize = true;
            this.label_equal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_equal.Location = new System.Drawing.Point(46, 4);
            this.label_equal.Name = "label_equal";
            this.label_equal.Size = new System.Drawing.Size(18, 19);
            this.label_equal.TabIndex = 2;
            this.label_equal.Text = "=";
            // 
            // label_des
            // 
            this.label_des.AutoSize = true;
            this.label_des.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_des.Location = new System.Drawing.Point(21, 13);
            this.label_des.Name = "label_des";
            this.label_des.Size = new System.Drawing.Size(29, 16);
            this.label_des.TabIndex = 1;
            this.label_des.Text = "des";
            this.label_des.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X.Location = new System.Drawing.Point(6, 4);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(20, 19);
            this.label_X.TabIndex = 0;
            this.label_X.Text = "X";
            // 
            // panel_Y_des
            // 
            this.panel_Y_des.Controls.Add(this.label1);
            this.panel_Y_des.Controls.Add(this.label2);
            this.panel_Y_des.Controls.Add(this.label3);
            this.panel_Y_des.Location = new System.Drawing.Point(948, 228);
            this.panel_Y_des.Name = "panel_Y_des";
            this.panel_Y_des.Size = new System.Drawing.Size(70, 31);
            this.panel_Y_des.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "des";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Y";
            // 
            // panel_X_cur
            // 
            this.panel_X_cur.Controls.Add(this.label4);
            this.panel_X_cur.Controls.Add(this.label5);
            this.panel_X_cur.Controls.Add(this.label6);
            this.panel_X_cur.Location = new System.Drawing.Point(798, 296);
            this.panel_X_cur.Name = "panel_X_cur";
            this.panel_X_cur.Size = new System.Drawing.Size(70, 31);
            this.panel_X_cur.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "cur";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "X";
            // 
            // panel_Y_cur
            // 
            this.panel_Y_cur.Controls.Add(this.label7);
            this.panel_Y_cur.Controls.Add(this.label8);
            this.panel_Y_cur.Controls.Add(this.label9);
            this.panel_Y_cur.Location = new System.Drawing.Point(948, 296);
            this.panel_Y_cur.Name = "panel_Y_cur";
            this.panel_Y_cur.Size = new System.Drawing.Size(70, 31);
            this.panel_Y_cur.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "cur";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Y";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.Info;
            this.button_exit.Location = new System.Drawing.Point(961, 414);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(98, 37);
            this.button_exit.TabIndex = 27;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.ExitAppEvent);
            // 
            // button_export
            // 
            this.button_export.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_export.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_export.ForeColor = System.Drawing.SystemColors.Info;
            this.button_export.Location = new System.Drawing.Point(822, 512);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(237, 42);
            this.button_export.TabIndex = 29;
            this.button_export.Text = "EXPORT DATA TO EXCEL";
            this.button_export.UseVisualStyleBackColor = false;
            this.button_export.Click += new System.EventHandler(this.ExportDataEvent);
            // 
            // button_createProcessedData
            // 
            this.button_createProcessedData.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_createProcessedData.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_createProcessedData.ForeColor = System.Drawing.SystemColors.Info;
            this.button_createProcessedData.Location = new System.Drawing.Point(822, 461);
            this.button_createProcessedData.Name = "button_createProcessedData";
            this.button_createProcessedData.Size = new System.Drawing.Size(237, 42);
            this.button_createProcessedData.TabIndex = 30;
            this.button_createProcessedData.Text = "CREATE PROCESSED DATA";
            this.button_createProcessedData.UseVisualStyleBackColor = false;
            this.button_createProcessedData.Click += new System.EventHandler(this.CreateProcessedDataEvent);
            // 
            // saveFileDialog_save_data
            // 
            this.saveFileDialog_save_data.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
            // 
            // zedGraphControl_map
            // 
            this.zedGraphControl_map.Location = new System.Drawing.Point(79, 173);
            this.zedGraphControl_map.Name = "zedGraphControl_map";
            this.zedGraphControl_map.ScrollGrace = 0D;
            this.zedGraphControl_map.ScrollMaxX = 0D;
            this.zedGraphControl_map.ScrollMaxY = 0D;
            this.zedGraphControl_map.ScrollMaxY2 = 0D;
            this.zedGraphControl_map.ScrollMinX = 0D;
            this.zedGraphControl_map.ScrollMinY = 0D;
            this.zedGraphControl_map.ScrollMinY2 = 0D;
            this.zedGraphControl_map.Size = new System.Drawing.Size(617, 425);
            this.zedGraphControl_map.TabIndex = 31;
            this.zedGraphControl_map.UseExtendedPrintDialog = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 54);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // comboBox_X_des
            // 
            this.comboBox_X_des.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_X_des.DropDownWidth = 52;
            this.comboBox_X_des.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_X_des.FormattingEnabled = true;
            this.comboBox_X_des.IntegralHeight = false;
            this.comboBox_X_des.Items.AddRange(new object[] {
            "  0.0",
            "  0.5",
            "  1.0",
            "  1.5",
            "  2.0",
            "  2.5",
            "  3.0",
            "  3.5",
            "  4.0",
            "  4.5",
            "  5.0",
            "  5.5",
            "  6.0",
            "  6.5",
            "  7.0"});
            this.comboBox_X_des.Location = new System.Drawing.Point(868, 229);
            this.comboBox_X_des.MaxDropDownItems = 5;
            this.comboBox_X_des.Name = "comboBox_X_des";
            this.comboBox_X_des.Size = new System.Drawing.Size(52, 28);
            this.comboBox_X_des.TabIndex = 33;
            // 
            // comboBox_Y_des
            // 
            this.comboBox_Y_des.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Y_des.DropDownWidth = 52;
            this.comboBox_Y_des.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Y_des.FormattingEnabled = true;
            this.comboBox_Y_des.IntegralHeight = false;
            this.comboBox_Y_des.Items.AddRange(new object[] {
            "  0.0",
            "  0.5",
            "  1.0",
            "  1.5",
            "  2.0",
            "  2.5",
            "  3.0",
            "  3.5",
            "  4.0"});
            this.comboBox_Y_des.Location = new System.Drawing.Point(1018, 229);
            this.comboBox_Y_des.MaxDropDownItems = 5;
            this.comboBox_Y_des.Name = "comboBox_Y_des";
            this.comboBox_Y_des.Size = new System.Drawing.Size(52, 28);
            this.comboBox_Y_des.TabIndex = 34;
            // 
            // label_barriers
            // 
            this.label_barriers.AutoSize = true;
            this.label_barriers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_barriers.ForeColor = System.Drawing.Color.Black;
            this.label_barriers.Location = new System.Drawing.Point(594, 109);
            this.label_barriers.Name = "label_barriers";
            this.label_barriers.Size = new System.Drawing.Size(64, 18);
            this.label_barriers.TabIndex = 36;
            this.label_barriers.Text = "Barriers";
            this.label_barriers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_StartPoint
            // 
            this.label_StartPoint.AutoSize = true;
            this.label_StartPoint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StartPoint.ForeColor = System.Drawing.Color.Black;
            this.label_StartPoint.Location = new System.Drawing.Point(380, 136);
            this.label_StartPoint.Name = "label_StartPoint";
            this.label_StartPoint.Size = new System.Drawing.Size(81, 18);
            this.label_StartPoint.TabIndex = 37;
            this.label_StartPoint.Text = "Start Point";
            this.label_StartPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_StartPoint
            // 
            this.pictureBox_StartPoint.Image = global::IndoorLocation.Properties.Resources.StartPointImage;
            this.pictureBox_StartPoint.Location = new System.Drawing.Point(359, 140);
            this.pictureBox_StartPoint.Name = "pictureBox_StartPoint";
            this.pictureBox_StartPoint.Size = new System.Drawing.Size(15, 11);
            this.pictureBox_StartPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_StartPoint.TabIndex = 38;
            this.pictureBox_StartPoint.TabStop = false;
            // 
            // pictureBox_barriers
            // 
            this.pictureBox_barriers.Image = global::IndoorLocation.Properties.Resources.Barrier;
            this.pictureBox_barriers.Location = new System.Drawing.Point(538, 118);
            this.pictureBox_barriers.Name = "pictureBox_barriers";
            this.pictureBox_barriers.Size = new System.Drawing.Size(50, 6);
            this.pictureBox_barriers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_barriers.TabIndex = 35;
            this.pictureBox_barriers.TabStop = false;
            // 
            // pictureBox_currentPoint
            // 
            this.pictureBox_currentPoint.Image = global::IndoorLocation.Properties.Resources.CurrentPointImage;
            this.pictureBox_currentPoint.Location = new System.Drawing.Point(178, 140);
            this.pictureBox_currentPoint.Name = "pictureBox_currentPoint";
            this.pictureBox_currentPoint.Size = new System.Drawing.Size(15, 11);
            this.pictureBox_currentPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_currentPoint.TabIndex = 11;
            this.pictureBox_currentPoint.TabStop = false;
            // 
            // pictureBox_accessPoint
            // 
            this.pictureBox_accessPoint.Image = global::IndoorLocation.Properties.Resources.AccessPointImage;
            this.pictureBox_accessPoint.Location = new System.Drawing.Point(177, 115);
            this.pictureBox_accessPoint.Name = "pictureBox_accessPoint";
            this.pictureBox_accessPoint.Size = new System.Drawing.Size(16, 10);
            this.pictureBox_accessPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_accessPoint.TabIndex = 10;
            this.pictureBox_accessPoint.TabStop = false;
            // 
            // pictureBox_destinationPoint
            // 
            this.pictureBox_destinationPoint.Image = global::IndoorLocation.Properties.Resources.DestinationPoint;
            this.pictureBox_destinationPoint.Location = new System.Drawing.Point(538, 139);
            this.pictureBox_destinationPoint.Name = "pictureBox_destinationPoint";
            this.pictureBox_destinationPoint.Size = new System.Drawing.Size(15, 11);
            this.pictureBox_destinationPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_destinationPoint.TabIndex = 26;
            this.pictureBox_destinationPoint.TabStop = false;
            // 
            // pictureBox_passedPoint
            // 
            this.pictureBox_passedPoint.Image = global::IndoorLocation.Properties.Resources.PassedPoint;
            this.pictureBox_passedPoint.Location = new System.Drawing.Point(359, 113);
            this.pictureBox_passedPoint.Name = "pictureBox_passedPoint";
            this.pictureBox_passedPoint.Size = new System.Drawing.Size(15, 11);
            this.pictureBox_passedPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_passedPoint.TabIndex = 25;
            this.pictureBox_passedPoint.TabStop = false;
            // 
            // label_mapType
            // 
            this.label_mapType.AutoSize = true;
            this.label_mapType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mapType.ForeColor = System.Drawing.Color.Black;
            this.label_mapType.Location = new System.Drawing.Point(804, 173);
            this.label_mapType.Name = "label_mapType";
            this.label_mapType.Size = new System.Drawing.Size(165, 19);
            this.label_mapType.TabIndex = 39;
            this.label_mapType.Text = "Choose the map type:";
            this.label_mapType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_mapType
            // 
            this.comboBox_mapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mapType.DropDownWidth = 52;
            this.comboBox_mapType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_mapType.FormattingEnabled = true;
            this.comboBox_mapType.IntegralHeight = false;
            this.comboBox_mapType.Items.AddRange(new object[] {
            " 1",
            " 2"});
            this.comboBox_mapType.Location = new System.Drawing.Point(975, 170);
            this.comboBox_mapType.MaxDropDownItems = 5;
            this.comboBox_mapType.Name = "comboBox_mapType";
            this.comboBox_mapType.Size = new System.Drawing.Size(35, 28);
            this.comboBox_mapType.TabIndex = 40;
            this.comboBox_mapType.SelectedIndexChanged += new System.EventHandler(this.SelectMapTypeEvent);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(948, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 31);
            this.panel1.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "nt";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Y";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(798, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 31);
            this.panel2.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(46, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "nt";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "X";
            // 
            // textBox_nextPos_y
            // 
            this.textBox_nextPos_y.BackColor = System.Drawing.Color.White;
            this.textBox_nextPos_y.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nextPos_y.ForeColor = System.Drawing.Color.Black;
            this.textBox_nextPos_y.Location = new System.Drawing.Point(1018, 366);
            this.textBox_nextPos_y.MaxLength = 7;
            this.textBox_nextPos_y.Name = "textBox_nextPos_y";
            this.textBox_nextPos_y.ReadOnly = true;
            this.textBox_nextPos_y.Size = new System.Drawing.Size(68, 26);
            this.textBox_nextPos_y.TabIndex = 25;
            this.textBox_nextPos_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_nextPos_x
            // 
            this.textBox_nextPos_x.BackColor = System.Drawing.Color.White;
            this.textBox_nextPos_x.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nextPos_x.ForeColor = System.Drawing.Color.Black;
            this.textBox_nextPos_x.Location = new System.Drawing.Point(868, 366);
            this.textBox_nextPos_x.MaxLength = 7;
            this.textBox_nextPos_x.Name = "textBox_nextPos_x";
            this.textBox_nextPos_x.ReadOnly = true;
            this.textBox_nextPos_x.Size = new System.Drawing.Size(68, 26);
            this.textBox_nextPos_x.TabIndex = 24;
            this.textBox_nextPos_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(794, 339);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(290, 19);
            this.label16.TabIndex = 23;
            this.label16.Text = "Next Position (automatically displayed):";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox_mapType);
            this.Controls.Add(this.textBox_nextPos_y);
            this.Controls.Add(this.label_mapType);
            this.Controls.Add(this.textBox_nextPos_x);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox_StartPoint);
            this.Controls.Add(this.label_StartPoint);
            this.Controls.Add(this.label_barriers);
            this.Controls.Add(this.pictureBox_barriers);
            this.Controls.Add(this.comboBox_Y_des);
            this.Controls.Add(this.comboBox_X_des);
            this.Controls.Add(this.zedGraphControl_map);
            this.Controls.Add(this.button_createProcessedData);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.pictureBox_currentPoint);
            this.Controls.Add(this.pictureBox_accessPoint);
            this.Controls.Add(this.label_accessPoint);
            this.Controls.Add(this.pictureBox_destinationPoint);
            this.Controls.Add(this.label_currentPoint);
            this.Controls.Add(this.pictureBox_passedPoint);
            this.Controls.Add(this.panel_Y_cur);
            this.Controls.Add(this.panel_X_cur);
            this.Controls.Add(this.panel_Y_des);
            this.Controls.Add(this.panel_X_des);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_Y_cur);
            this.Controls.Add(this.textBox_X_cur);
            this.Controls.Add(this.label_displayCurrentPoint);
            this.Controls.Add(this.label_statement);
            this.Controls.Add(this.label_destinationPoint);
            this.Controls.Add(this.label_passedPoint);
            this.Controls.Add(this.label_teacherName);
            this.Controls.Add(this.label_studentName);
            this.Controls.Add(this.label_instructor);
            this.Controls.Add(this.label_designedBy);
            this.Controls.Add(this.label_remark);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(1200, 675);
            this.MinimumSize = new System.Drawing.Size(1200, 675);
            this.Name = "Form1";
            this.Text = "FinalProject - Ha Van Tung (ID: 20173456)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LogoBK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logoLab)).EndInit();
            this.panel_X_des.ResumeLayout(false);
            this.panel_X_des.PerformLayout();
            this.panel_Y_des.ResumeLayout(false);
            this.panel_Y_des.PerformLayout();
            this.panel_X_cur.ResumeLayout(false);
            this.panel_X_cur.PerformLayout();
            this.panel_Y_cur.ResumeLayout(false);
            this.panel_Y_cur.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_StartPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barriers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_currentPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_accessPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_destinationPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passedPoint)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox_LogoBK;
        private System.Windows.Forms.PictureBox pictureBox_logoLab;
        private System.Windows.Forms.Label label_remark;
        private System.Windows.Forms.Label label_designedBy;
        private System.Windows.Forms.Label label_instructor;
        private System.Windows.Forms.Label label_studentName;
        private System.Windows.Forms.Label label_teacherName;
        private System.Windows.Forms.Label label_accessPoint;
        private System.Windows.Forms.Label label_passedPoint;
        private System.Windows.Forms.Label label_currentPoint;
        private System.Windows.Forms.Label label_destinationPoint;
        private System.Windows.Forms.Label label_statement;
        private System.Windows.Forms.Label label_displayCurrentPoint;
        private System.Windows.Forms.TextBox textBox_X_cur;
        private System.Windows.Forms.TextBox textBox_Y_cur;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Panel panel_X_des;
        private System.Windows.Forms.Label label_des;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_equal;
        private System.Windows.Forms.Panel panel_Y_des;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_X_cur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_Y_cur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox_accessPoint;
        private System.Windows.Forms.PictureBox pictureBox_currentPoint;
        private System.Windows.Forms.PictureBox pictureBox_passedPoint;
        private System.Windows.Forms.PictureBox pictureBox_destinationPoint;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_createProcessedData;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_save_data;
        private ZedGraph.ZedGraphControl zedGraphControl_map;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ComboBox comboBox_X_des;
        private System.Windows.Forms.ComboBox comboBox_Y_des;
        private System.Windows.Forms.PictureBox pictureBox_barriers;
        private System.Windows.Forms.Label label_barriers;
        private System.Windows.Forms.PictureBox pictureBox_StartPoint;
        private System.Windows.Forms.Label label_StartPoint;
        private System.Windows.Forms.Label label_mapType;
        private System.Windows.Forms.ComboBox comboBox_mapType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_nextPos_y;
        private System.Windows.Forms.TextBox textBox_nextPos_x;
        private System.Windows.Forms.Label label16;
    }
}

