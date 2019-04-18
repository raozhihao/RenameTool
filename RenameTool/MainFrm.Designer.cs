namespace RenameTool
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtAddFill = new System.Windows.Forms.TextBox();
            this.btnAddShow = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboAdd = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExtShow = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cboCopy = new System.Windows.Forms.ComboBox();
            this.btnSaveFolder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnReplaceShow = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboReplaceStyle = new System.Windows.Forms.ComboBox();
            this.btnResertUp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFill = new System.Windows.Forms.TextBox();
            this.btnStepShow = new System.Windows.Forms.Button();
            this.npdStart = new System.Windows.Forms.NumericUpDown();
            this.npdStep = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new RenameTool.Models.TreeViewEx();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colGridIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.colgridOldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGridNewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGridType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGridDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.往上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExploer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolDirInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdStep)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnResertUp);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnRename);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(910, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 591);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtAddFill);
            this.groupBox6.Controls.Add(this.btnAddShow);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.cboAdd);
            this.groupBox6.Location = new System.Drawing.Point(12, 144);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(310, 97);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "增加";
            // 
            // txtAddFill
            // 
            this.txtAddFill.Location = new System.Drawing.Point(191, 27);
            this.txtAddFill.Name = "txtAddFill";
            this.txtAddFill.Size = new System.Drawing.Size(113, 21);
            this.txtAddFill.TabIndex = 1;
            this.txtAddFill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddFill_KeyDown);
            // 
            // btnAddShow
            // 
            this.btnAddShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddShow.FlatAppearance.BorderSize = 0;
            this.btnAddShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShow.Location = new System.Drawing.Point(251, 61);
            this.btnAddShow.Name = "btnAddShow";
            this.btnAddShow.Size = new System.Drawing.Size(50, 23);
            this.btnAddShow.TabIndex = 2;
            this.btnAddShow.Text = "预览";
            this.btnAddShow.UseVisualStyleBackColor = false;
            this.btnAddShow.Click += new System.EventHandler(this.btnAddShow_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(156, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "填充";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "方式";
            // 
            // cboAdd
            // 
            this.cboAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboAdd.FormattingEnabled = true;
            this.cboAdd.Items.AddRange(new object[] {
            "无",
            "前缀",
            "后缀",
            "前缀+后缀"});
            this.cboAdd.Location = new System.Drawing.Point(46, 28);
            this.cboAdd.Name = "cboAdd";
            this.cboAdd.Size = new System.Drawing.Size(104, 20);
            this.cboAdd.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtExt);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btnExtShow);
            this.groupBox5.Location = new System.Drawing.Point(10, 274);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 66);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "更改";
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(72, 30);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(163, 21);
            this.txtExt.TabIndex = 0;
            this.txtExt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExt_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "新扩展名";
            // 
            // btnExtShow
            // 
            this.btnExtShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExtShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtShow.FlatAppearance.BorderSize = 0;
            this.btnExtShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtShow.Location = new System.Drawing.Point(253, 28);
            this.btnExtShow.Name = "btnExtShow";
            this.btnExtShow.Size = new System.Drawing.Size(50, 23);
            this.btnExtShow.TabIndex = 1;
            this.btnExtShow.Text = "预览";
            this.btnExtShow.UseVisualStyleBackColor = false;
            this.btnExtShow.Click += new System.EventHandler(this.btnExtShow_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSavePath);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.cboCopy);
            this.groupBox4.Controls.Add(this.btnSaveFolder);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 439);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 93);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "移动";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(48, 61);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(202, 21);
            this.txtSavePath.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(193, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "包含所有子文件";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cboCopy
            // 
            this.cboCopy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboCopy.FormattingEnabled = true;
            this.cboCopy.ItemHeight = 12;
            this.cboCopy.Items.AddRange(new object[] {
            "无",
            "复制",
            "剪切"});
            this.cboCopy.Location = new System.Drawing.Point(48, 26);
            this.cboCopy.Name = "cboCopy";
            this.cboCopy.Size = new System.Drawing.Size(121, 20);
            this.cboCopy.TabIndex = 0;
            // 
            // btnSaveFolder
            // 
            this.btnSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFolder.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveFolder.BackgroundImage = global::RenameTool.Properties.Resources.opened_folder_net;
            this.btnSaveFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveFolder.FlatAppearance.BorderSize = 0;
            this.btnSaveFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFolder.Location = new System.Drawing.Point(264, 59);
            this.btnSaveFolder.Name = "btnSaveFolder";
            this.btnSaveFolder.Size = new System.Drawing.Size(37, 23);
            this.btnSaveFolder.TabIndex = 2;
            this.btnSaveFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveFolder.UseVisualStyleBackColor = false;
            this.btnSaveFolder.Click += new System.EventHandler(this.btnSaveFolder_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "路径";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "方式";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNew);
            this.groupBox3.Controls.Add(this.btnReplaceShow);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.txtOld);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cboReplaceStyle);
            this.groupBox3.Location = new System.Drawing.Point(10, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 87);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "替换";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(193, 55);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(110, 21);
            this.txtNew.TabIndex = 3;
            this.txtNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNew_KeyDown);
            // 
            // btnReplaceShow
            // 
            this.btnReplaceShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReplaceShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplaceShow.FlatAppearance.BorderSize = 0;
            this.btnReplaceShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceShow.Location = new System.Drawing.Point(253, 20);
            this.btnReplaceShow.Name = "btnReplaceShow";
            this.btnReplaceShow.Size = new System.Drawing.Size(50, 23);
            this.btnReplaceShow.TabIndex = 1;
            this.btnReplaceShow.Text = "预览";
            this.btnReplaceShow.UseVisualStyleBackColor = false;
            this.btnReplaceShow.Click += new System.EventHandler(this.btnReplaceShow_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 2;
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(30, 55);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(100, 21);
            this.txtOld.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "将";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "替换为";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "替换方式";
            // 
            // cboReplaceStyle
            // 
            this.cboReplaceStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReplaceStyle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboReplaceStyle.FormattingEnabled = true;
            this.cboReplaceStyle.ItemHeight = 12;
            this.cboReplaceStyle.Items.AddRange(new object[] {
            "普通",
            "正则"});
            this.cboReplaceStyle.Location = new System.Drawing.Point(73, 20);
            this.cboReplaceStyle.Name = "cboReplaceStyle";
            this.cboReplaceStyle.Size = new System.Drawing.Size(57, 20);
            this.cboReplaceStyle.TabIndex = 0;
            // 
            // btnResertUp
            // 
            this.btnResertUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResertUp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnResertUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResertUp.FlatAppearance.BorderSize = 0;
            this.btnResertUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResertUp.Location = new System.Drawing.Point(224, 247);
            this.btnResertUp.Name = "btnResertUp";
            this.btnResertUp.Size = new System.Drawing.Size(89, 26);
            this.btnResertUp.TabIndex = 0;
            this.btnResertUp.Text = "返回上一次";
            this.btnResertUp.UseVisualStyleBackColor = false;
            this.btnResertUp.Click += new System.EventHandler(this.btnResertUp_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(162, 543);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 1;
            this.button3.Text = "全重置";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRename.FlatAppearance.BorderSize = 0;
            this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRename.Location = new System.Drawing.Point(243, 543);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 36);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = " 重命名";
            this.btnRename.UseVisualStyleBackColor = false;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFill);
            this.groupBox2.Controls.Add(this.btnStepShow);
            this.groupBox2.Controls.Add(this.npdStart);
            this.groupBox2.Controls.Add(this.npdStep);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 115);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自动编号";
            // 
            // txtFill
            // 
            this.txtFill.Location = new System.Drawing.Point(193, 17);
            this.txtFill.Name = "txtFill";
            this.txtFill.Size = new System.Drawing.Size(110, 21);
            this.txtFill.TabIndex = 1;
            this.txtFill.Text = "_";
            // 
            // btnStepShow
            // 
            this.btnStepShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStepShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStepShow.FlatAppearance.BorderSize = 0;
            this.btnStepShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStepShow.Location = new System.Drawing.Point(253, 81);
            this.btnStepShow.Name = "btnStepShow";
            this.btnStepShow.Size = new System.Drawing.Size(50, 23);
            this.btnStepShow.TabIndex = 4;
            this.btnStepShow.Text = "预览";
            this.btnStepShow.UseVisualStyleBackColor = false;
            this.btnStepShow.Click += new System.EventHandler(this.btnStepShow_Click);
            // 
            // npdStart
            // 
            this.npdStart.Location = new System.Drawing.Point(48, 49);
            this.npdStart.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.npdStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npdStart.Name = "npdStart";
            this.npdStart.Size = new System.Drawing.Size(90, 21);
            this.npdStart.TabIndex = 2;
            this.npdStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // npdStep
            // 
            this.npdStep.Location = new System.Drawing.Point(216, 49);
            this.npdStep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.npdStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npdStep.Name = "npdStep";
            this.npdStep.Size = new System.Drawing.Size(87, 21);
            this.npdStep.TabIndex = 3;
            this.npdStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 12;
            this.comboBox1.Items.AddRange(new object[] {
            "无",
            "前缀",
            "后缀",
            "前缀+后缀"});
            this.comboBox1.Location = new System.Drawing.Point(48, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "从";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "开始递增";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "填充";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "方式";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnOpenPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 42);
            this.panel1.TabIndex = 1;
            // 
            // txtPath
            // 
            this.txtPath.AllowDrop = true;
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(55, 11);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(750, 21);
            this.txtPath.TabIndex = 1;
            this.txtPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtPath_DragDrop);
            this.txtPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtPath_DragEnter);
            this.txtPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPath_KeyUp);
            this.txtPath.Leave += new System.EventHandler(this.txtPath_Leave);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.Menu;
            this.btnUp.BackgroundImage = global::RenameTool.Properties.Resources.up;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Location = new System.Drawing.Point(18, 11);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(20, 20);
            this.btnUp.TabIndex = 0;
            this.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRefresh.BackgroundImage = global::RenameTool.Properties.Resources.Refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(861, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 20);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPath.BackColor = System.Drawing.SystemColors.Menu;
            this.btnOpenPath.BackgroundImage = global::RenameTool.Properties.Resources.open;
            this.btnOpenPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPath.FlatAppearance.BorderSize = 0;
            this.btnOpenPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPath.Location = new System.Drawing.Point(813, 11);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(37, 23);
            this.btnOpenPath.TabIndex = 2;
            this.btnOpenPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpenPath.UseVisualStyleBackColor = false;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(910, 524);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.arrowImageList = this.imageList2;
            this.treeView1.BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 9.7F);
            this.treeView1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.HotTracking = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ItemHeight = 26;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.NoSelectedHovedFillColor = System.Drawing.Color.Empty;
            this.treeView1.SelectedFillColor = System.Drawing.Color.Empty;
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.SelectNoFocusedFillColor = System.Drawing.Color.Empty;
            this.treeView1.Size = new System.Drawing.Size(181, 524);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "0.bmp");
            this.imageList2.Images.SetKeyName(1, "1.bmp");
            this.imageList2.Images.SetKeyName(2, "2.bmp");
            this.imageList2.Images.SetKeyName(3, "3.bmp");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGridIcon,
            this.colgridOldName,
            this.colGridNewName,
            this.colGridType,
            this.colGridDate});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(725, 524);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // colGridIcon
            // 
            this.colGridIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.colGridIcon.DefaultCellStyle = dataGridViewCellStyle1;
            this.colGridIcon.FillWeight = 16F;
            this.colGridIcon.HeaderText = "";
            this.colGridIcon.MinimumWidth = 40;
            this.colGridIcon.Name = "colGridIcon";
            this.colGridIcon.ReadOnly = true;
            this.colGridIcon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colGridIcon.Width = 40;
            // 
            // colgridOldName
            // 
            this.colgridOldName.HeaderText = "原名称";
            this.colgridOldName.Name = "colgridOldName";
            this.colgridOldName.ReadOnly = true;
            // 
            // colGridNewName
            // 
            this.colGridNewName.HeaderText = "新名称";
            this.colGridNewName.Name = "colGridNewName";
            this.colGridNewName.ReadOnly = true;
            // 
            // colGridType
            // 
            this.colGridType.HeaderText = "类型";
            this.colGridType.Name = "colGridType";
            this.colGridType.ReadOnly = true;
            // 
            // colGridDate
            // 
            this.colGridDate.HeaderText = "创建时间";
            this.colGridDate.Name = "colGridDate";
            this.colGridDate.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.往上ToolStripMenuItem,
            this.toolOpen,
            this.toolRoot,
            this.toolRefresh,
            this.toolStripSeparator1,
            this.tsmExploer,
            this.toolDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 142);
            this.contextMenuStrip1.Text = "操作";
            // 
            // 往上ToolStripMenuItem
            // 
            this.往上ToolStripMenuItem.Image = global::RenameTool.Properties.Resources.up;
            this.往上ToolStripMenuItem.Name = "往上ToolStripMenuItem";
            this.往上ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.往上ToolStripMenuItem.Text = "往上一级";
            this.往上ToolStripMenuItem.Click += new System.EventHandler(this.往上ToolStripMenuItem_Click);
            // 
            // toolOpen
            // 
            this.toolOpen.Image = global::RenameTool.Properties.Resources.opened_folder_net;
            this.toolOpen.Name = "toolOpen";
            this.toolOpen.Size = new System.Drawing.Size(124, 22);
            this.toolOpen.Text = "内部打开";
            this.toolOpen.Click += new System.EventHandler(this.toolOpen_Click_1);
            // 
            // toolRoot
            // 
            this.toolRoot.Image = global::RenameTool.Properties.Resources.inode;
            this.toolRoot.Name = "toolRoot";
            this.toolRoot.Size = new System.Drawing.Size(124, 22);
            this.toolRoot.Text = "往根目录";
            this.toolRoot.Click += new System.EventHandler(this.toolRoot_Click);
            // 
            // toolRefresh
            // 
            this.toolRefresh.Image = global::RenameTool.Properties.Resources.Refresh;
            this.toolRefresh.Name = "toolRefresh";
            this.toolRefresh.Size = new System.Drawing.Size(124, 22);
            this.toolRefresh.Text = "刷新目录";
            this.toolRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // tsmExploer
            // 
            this.tsmExploer.Image = global::RenameTool.Properties.Resources.open;
            this.tsmExploer.Name = "tsmExploer";
            this.tsmExploer.Size = new System.Drawing.Size(124, 22);
            this.tsmExploer.Text = "本机打开";
            this.tsmExploer.Click += new System.EventHandler(this.tsmExploer_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Image = global::RenameTool.Properties.Resources.recycle;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(124, 22);
            this.toolDelete.Text = "删除文件";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolInfo,
            this.toolDirInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(910, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolInfo
            // 
            this.toolInfo.ForeColor = System.Drawing.Color.Red;
            this.toolInfo.Image = global::RenameTool.Properties.Resources.warning;
            this.toolInfo.Name = "toolInfo";
            this.toolInfo.Size = new System.Drawing.Size(16, 17);
            this.toolInfo.Visible = false;
            this.toolInfo.TextChanged += new System.EventHandler(this.toolInfo_TextChanged);
            // 
            // toolDirInfo
            // 
            this.toolDirInfo.ActiveLinkColor = System.Drawing.Color.Black;
            this.toolDirInfo.Name = "toolDirInfo";
            this.toolDirInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // MainFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1240, 591);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 630);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleRename(简单重命名)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdStep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown npdStep;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboReplaceStyle;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button btnReplaceShow;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmExploer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cboCopy;
        private System.Windows.Forms.Button btnSaveFolder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem 往上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolOpen;
        private System.Windows.Forms.ToolStripMenuItem toolRoot;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtAddFill;
        private System.Windows.Forms.Button btnAddShow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExtShow;
        private System.Windows.Forms.DataGridViewImageColumn colGridIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgridOldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGridNewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGridType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGridDate;
        private System.Windows.Forms.NumericUpDown npdStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnStepShow;
        private System.Windows.Forms.ToolStripMenuItem toolRefresh;
        private System.Windows.Forms.Button btnResertUp;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolInfo;
        private Models.TreeViewEx treeView1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripStatusLabel toolDirInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolDelete;
    }
}

