namespace SwarmDog
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exportDr = new System.Windows.Forms.SaveFileDialog();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslSummary = new System.Windows.Forms.ToolStripStatusLabel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddNode = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteNode = new System.Windows.Forms.ToolStripButton();
            this.tsbCopyNode = new System.Windows.Forms.ToolStripButton();
            this.tsbAutoCashout = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ethereumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peersCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequePeersCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sentChequeCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sentChequeAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedChequeCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveChequeAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalUncashedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyMapsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeersCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequePeersCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SentChequeCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SentChequeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedChequeCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveChequeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalUncashedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsNode = new System.Windows.Forms.BindingSource(this.components);
            this.tsbStart = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNode)).BeginInit();
            this.SuspendLayout();
            // 
            // exportDr
            // 
            this.exportDr.FileName = "swarm.csv";
            this.exportDr.Filter = "csv文件(*.csv)|*.csv|所有文件(*.*)|*.*";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSummary});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1066, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslSummary
            // 
            this.tslSummary.Name = "tslSummary";
            this.tslSummary.Size = new System.Drawing.Size(68, 17);
            this.tslSummary.Text = "当前合计：";
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddNode,
            this.tsbDeleteNode,
            this.tsbCopyNode,
            this.tsbStart,
            this.tsbAutoCashout,
            this.tsbExport
            });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1066, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddNode
            // 
            this.tsbAddNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddNode.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddNode.Image")));
            this.tsbAddNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNode.Name = "tsbAddNode";
            this.tsbAddNode.Size = new System.Drawing.Size(60, 22);
            this.tsbAddNode.Text = "添加节点";
            this.tsbAddNode.Click += new System.EventHandler(this.tsbAddNode_Click);
            // 
            // tsbDeleteNode
            // 
            this.tsbDeleteNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteNode.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteNode.Image")));
            this.tsbDeleteNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteNode.Name = "tsbDeleteNode";
            this.tsbDeleteNode.Size = new System.Drawing.Size(60, 22);
            this.tsbDeleteNode.Text = "删除节点";
            this.tsbDeleteNode.Click += new System.EventHandler(this.tsbDeleteNode_Click);
            // 
            // tsbCopyNode
            // 
            this.tsbCopyNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCopyNode.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopyNode.Image")));
            this.tsbCopyNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopyNode.Name = "tsbCopyNode";
            this.tsbCopyNode.Size = new System.Drawing.Size(60, 22);
            this.tsbCopyNode.Text = "复制节点";
            this.tsbCopyNode.Click += new System.EventHandler(this.tsbCopyNode_Click);
            // 
            // tsbAutoCashout
            // 
            this.tsbAutoCashout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAutoCashout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAutoCashout.Image")));
            this.tsbAutoCashout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAutoCashout.Name = "tsbAutoCashout";
            this.tsbAutoCashout.Size = new System.Drawing.Size(84, 22);
            this.tsbAutoCashout.Text = "停止自动兑换";
            this.tsbAutoCashout.Click += new System.EventHandler(this.tsbAutoCashout_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(72, 22);
            this.tsbExport.Text = "导出EXCEL";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(1066, 559);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 57;
            // 
            // ipDataGridViewTextBoxColumn1
            // 
            this.ipDataGridViewTextBoxColumn1.DataPropertyName = "Ip";
            this.ipDataGridViewTextBoxColumn1.HeaderText = "Ip";
            this.ipDataGridViewTextBoxColumn1.Name = "ipDataGridViewTextBoxColumn1";
            this.ipDataGridViewTextBoxColumn1.Width = 57;
            // 
            // portDataGridViewTextBoxColumn1
            // 
            this.portDataGridViewTextBoxColumn1.DataPropertyName = "Port";
            this.portDataGridViewTextBoxColumn1.HeaderText = "Port";
            this.portDataGridViewTextBoxColumn1.Name = "portDataGridViewTextBoxColumn1";
            this.portDataGridViewTextBoxColumn1.Width = 56;
            // 
            // ethereumDataGridViewTextBoxColumn
            // 
            this.ethereumDataGridViewTextBoxColumn.DataPropertyName = "Ethereum";
            this.ethereumDataGridViewTextBoxColumn.HeaderText = "Ethereum";
            this.ethereumDataGridViewTextBoxColumn.Name = "ethereumDataGridViewTextBoxColumn";
            this.ethereumDataGridViewTextBoxColumn.ReadOnly = true;
            this.ethereumDataGridViewTextBoxColumn.Width = 57;
            // 
            // totalBalanceDataGridViewTextBoxColumn
            // 
            this.totalBalanceDataGridViewTextBoxColumn.DataPropertyName = "TotalBalance";
            this.totalBalanceDataGridViewTextBoxColumn.HeaderText = "TotalBalance";
            this.totalBalanceDataGridViewTextBoxColumn.Name = "totalBalanceDataGridViewTextBoxColumn";
            this.totalBalanceDataGridViewTextBoxColumn.Width = 57;
            // 
            // availableBalanceDataGridViewTextBoxColumn
            // 
            this.availableBalanceDataGridViewTextBoxColumn.DataPropertyName = "AvailableBalance";
            this.availableBalanceDataGridViewTextBoxColumn.HeaderText = "AvailableBalance";
            this.availableBalanceDataGridViewTextBoxColumn.Name = "availableBalanceDataGridViewTextBoxColumn";
            this.availableBalanceDataGridViewTextBoxColumn.Width = 57;
            // 
            // remarkDataGridViewTextBoxColumn1
            // 
            this.remarkDataGridViewTextBoxColumn1.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn1.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn1.Name = "remarkDataGridViewTextBoxColumn1";
            this.remarkDataGridViewTextBoxColumn1.Width = 57;
            // 
            // peersCountDataGridViewTextBoxColumn
            // 
            this.peersCountDataGridViewTextBoxColumn.DataPropertyName = "PeersCount";
            this.peersCountDataGridViewTextBoxColumn.HeaderText = "PeersCount";
            this.peersCountDataGridViewTextBoxColumn.Name = "peersCountDataGridViewTextBoxColumn";
            this.peersCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.peersCountDataGridViewTextBoxColumn.Width = 56;
            // 
            // chequePeersCountDataGridViewTextBoxColumn
            // 
            this.chequePeersCountDataGridViewTextBoxColumn.DataPropertyName = "ChequePeersCount";
            this.chequePeersCountDataGridViewTextBoxColumn.HeaderText = "ChequePeersCount";
            this.chequePeersCountDataGridViewTextBoxColumn.Name = "chequePeersCountDataGridViewTextBoxColumn";
            this.chequePeersCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.chequePeersCountDataGridViewTextBoxColumn.Width = 57;
            // 
            // sentChequeCountDataGridViewTextBoxColumn
            // 
            this.sentChequeCountDataGridViewTextBoxColumn.DataPropertyName = "SentChequeCount";
            this.sentChequeCountDataGridViewTextBoxColumn.HeaderText = "SentChequeCount";
            this.sentChequeCountDataGridViewTextBoxColumn.Name = "sentChequeCountDataGridViewTextBoxColumn";
            this.sentChequeCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.sentChequeCountDataGridViewTextBoxColumn.Width = 57;
            // 
            // sentChequeAmountDataGridViewTextBoxColumn
            // 
            this.sentChequeAmountDataGridViewTextBoxColumn.DataPropertyName = "SentChequeAmount";
            this.sentChequeAmountDataGridViewTextBoxColumn.HeaderText = "SentChequeAmount";
            this.sentChequeAmountDataGridViewTextBoxColumn.Name = "sentChequeAmountDataGridViewTextBoxColumn";
            this.sentChequeAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.sentChequeAmountDataGridViewTextBoxColumn.Width = 57;
            // 
            // receivedChequeCountDataGridViewTextBoxColumn
            // 
            this.receivedChequeCountDataGridViewTextBoxColumn.DataPropertyName = "ReceivedChequeCount";
            this.receivedChequeCountDataGridViewTextBoxColumn.HeaderText = "ReceivedChequeCount";
            this.receivedChequeCountDataGridViewTextBoxColumn.Name = "receivedChequeCountDataGridViewTextBoxColumn";
            this.receivedChequeCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.receivedChequeCountDataGridViewTextBoxColumn.Width = 57;
            // 
            // receiveChequeAmountDataGridViewTextBoxColumn
            // 
            this.receiveChequeAmountDataGridViewTextBoxColumn.DataPropertyName = "ReceiveChequeAmount";
            this.receiveChequeAmountDataGridViewTextBoxColumn.HeaderText = "ReceiveChequeAmount";
            this.receiveChequeAmountDataGridViewTextBoxColumn.Name = "receiveChequeAmountDataGridViewTextBoxColumn";
            this.receiveChequeAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiveChequeAmountDataGridViewTextBoxColumn.Width = 56;
            // 
            // totalUncashedAmountDataGridViewTextBoxColumn
            // 
            this.totalUncashedAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalUncashedAmount";
            this.totalUncashedAmountDataGridViewTextBoxColumn.HeaderText = "TotalUncashedAmount";
            this.totalUncashedAmountDataGridViewTextBoxColumn.Name = "totalUncashedAmountDataGridViewTextBoxColumn";
            this.totalUncashedAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalUncashedAmountDataGridViewTextBoxColumn.Width = 57;
            // 
            // constructorDataGridViewTextBoxColumn
            // 
            this.constructorDataGridViewTextBoxColumn.DataPropertyName = "Constructor";
            this.constructorDataGridViewTextBoxColumn.HeaderText = "Constructor";
            this.constructorDataGridViewTextBoxColumn.Name = "constructorDataGridViewTextBoxColumn";
            this.constructorDataGridViewTextBoxColumn.ReadOnly = true;
            this.constructorDataGridViewTextBoxColumn.Width = 57;
            // 
            // propertyMapsDataGridViewTextBoxColumn
            // 
            this.propertyMapsDataGridViewTextBoxColumn.DataPropertyName = "PropertyMaps";
            this.propertyMapsDataGridViewTextBoxColumn.HeaderText = "PropertyMaps";
            this.propertyMapsDataGridViewTextBoxColumn.Name = "propertyMapsDataGridViewTextBoxColumn";
            this.propertyMapsDataGridViewTextBoxColumn.ReadOnly = true;
            this.propertyMapsDataGridViewTextBoxColumn.Width = 57;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 57;
            // 
            // chequesDataGridViewTextBoxColumn
            // 
            this.chequesDataGridViewTextBoxColumn.DataPropertyName = "Cheques";
            this.chequesDataGridViewTextBoxColumn.HeaderText = "Cheques";
            this.chequesDataGridViewTextBoxColumn.Name = "chequesDataGridViewTextBoxColumn";
            this.chequesDataGridViewTextBoxColumn.Width = 57;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbLog);
            this.splitContainer1.Size = new System.Drawing.Size(1066, 559);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 16;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AutoGenerateColumns = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ipDataGridViewTextBoxColumn,
            this.portDataGridViewTextBoxColumn,
            this.Address,
            this.TotalBalance,
            this.AvailableBalance,
            this.PeersCount,
            this.ChequePeersCount,
            this.SentChequeCount,
            this.SentChequeAmount,
            this.ReceivedChequeCount,
            this.ReceiveChequeAmount,
            this.TotalUncashedAmount,
            this.remarkDataGridViewTextBoxColumn});
            this.grid.DataSource = this.bsNode;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1066, 390);
            this.grid.TabIndex = 6;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Ethereum";
            this.Address.HeaderText = "以太坊地址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // TotalBalance
            // 
            this.TotalBalance.DataPropertyName = "TotalBalance";
            dataGridViewCellStyle31.Format = "N0";
            this.TotalBalance.DefaultCellStyle = dataGridViewCellStyle31;
            this.TotalBalance.HeaderText = "合计余额";
            this.TotalBalance.Name = "TotalBalance";
            // 
            // AvailableBalance
            // 
            this.AvailableBalance.DataPropertyName = "AvailableBalance";
            dataGridViewCellStyle32.Format = "N0";
            this.AvailableBalance.DefaultCellStyle = dataGridViewCellStyle32;
            this.AvailableBalance.HeaderText = "可用余额";
            this.AvailableBalance.Name = "AvailableBalance";
            // 
            // PeersCount
            // 
            this.PeersCount.DataPropertyName = "PeersCount";
            this.PeersCount.FillWeight = 63.81359F;
            this.PeersCount.HeaderText = "连接数";
            this.PeersCount.Name = "PeersCount";
            this.PeersCount.ReadOnly = true;
            // 
            // ChequePeersCount
            // 
            this.ChequePeersCount.DataPropertyName = "ChequePeersCount";
            this.ChequePeersCount.FillWeight = 63.81359F;
            this.ChequePeersCount.HeaderText = "交互节点数";
            this.ChequePeersCount.Name = "ChequePeersCount";
            this.ChequePeersCount.ReadOnly = true;
            // 
            // SentChequeCount
            // 
            this.SentChequeCount.DataPropertyName = "SentChequeCount";
            this.SentChequeCount.FillWeight = 63.81359F;
            this.SentChequeCount.HeaderText = "发出支票数";
            this.SentChequeCount.Name = "SentChequeCount";
            this.SentChequeCount.ReadOnly = true;
            // 
            // SentChequeAmount
            // 
            this.SentChequeAmount.DataPropertyName = "SentChequeAmount";
            dataGridViewCellStyle33.Format = "N0";
            dataGridViewCellStyle33.NullValue = null;
            this.SentChequeAmount.DefaultCellStyle = dataGridViewCellStyle33;
            this.SentChequeAmount.FillWeight = 63.81359F;
            this.SentChequeAmount.HeaderText = "发送金额";
            this.SentChequeAmount.Name = "SentChequeAmount";
            this.SentChequeAmount.ReadOnly = true;
            // 
            // ReceivedChequeCount
            // 
            this.ReceivedChequeCount.DataPropertyName = "ReceivedChequeCount";
            this.ReceivedChequeCount.FillWeight = 63.81359F;
            this.ReceivedChequeCount.HeaderText = "收到支票数";
            this.ReceivedChequeCount.Name = "ReceivedChequeCount";
            this.ReceivedChequeCount.ReadOnly = true;
            // 
            // ReceiveChequeAmount
            // 
            this.ReceiveChequeAmount.DataPropertyName = "ReceiveChequeAmount";
            dataGridViewCellStyle34.Format = "N0";
            this.ReceiveChequeAmount.DefaultCellStyle = dataGridViewCellStyle34;
            this.ReceiveChequeAmount.FillWeight = 63.81359F;
            this.ReceiveChequeAmount.HeaderText = "接收金额";
            this.ReceiveChequeAmount.Name = "ReceiveChequeAmount";
            this.ReceiveChequeAmount.ReadOnly = true;
            // 
            // TotalUncashedAmount
            // 
            this.TotalUncashedAmount.DataPropertyName = "TotalUncashedAmount";
            dataGridViewCellStyle35.Format = "N0";
            this.TotalUncashedAmount.DefaultCellStyle = dataGridViewCellStyle35;
            this.TotalUncashedAmount.HeaderText = "待兑金额";
            this.TotalUncashedAmount.Name = "TotalUncashedAmount";
            this.TotalUncashedAmount.ReadOnly = true;
            // 
            // rtbLog
            // 
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(1066, 163);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle36.NullValue = null;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle36;
            this.nameDataGridViewTextBoxColumn.FillWeight = 50F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "节点名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ipDataGridViewTextBoxColumn
            // 
            this.ipDataGridViewTextBoxColumn.DataPropertyName = "Ip";
            this.ipDataGridViewTextBoxColumn.FillWeight = 50F;
            this.ipDataGridViewTextBoxColumn.HeaderText = "节点地址";
            this.ipDataGridViewTextBoxColumn.Name = "ipDataGridViewTextBoxColumn";
            // 
            // portDataGridViewTextBoxColumn
            // 
            this.portDataGridViewTextBoxColumn.DataPropertyName = "Port";
            this.portDataGridViewTextBoxColumn.FillWeight = 35F;
            this.portDataGridViewTextBoxColumn.HeaderText = "端口号";
            this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.FillWeight = 127.6272F;
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // bsNode
            // 
            this.bsNode.AllowNew = true;
            this.bsNode.DataSource = typeof(SwarmDog.Node);
            this.bsNode.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // tsbStart
            // 
            this.tsbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStart.Image = ((System.Drawing.Image)(resources.GetObject("tsbStart.Image")));
            this.tsbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStart.Name = "tsbStart";
            this.tsbStart.Size = new System.Drawing.Size(60, 22);
            this.tsbStart.Text = "停止监控";
            this.tsbStart.Click += new System.EventHandler(this.tsbStart_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 606);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMain";
            this.Text = "SwarmDog";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsNode;
        private System.Windows.Forms.SaveFileDialog exportDr;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslSummary;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddNode;
        private System.Windows.Forms.ToolStripButton tsbDeleteNode;
        private System.Windows.Forms.ToolStripButton tsbCopyNode;
        private System.Windows.Forms.ToolStripButton tsbAutoCashout;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ethereumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn peersCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequePeersCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentChequeCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentChequeAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedChequeCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiveChequeAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalUncashedAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyMapsDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeersCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequePeersCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SentChequeCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SentChequeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedChequeCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveChequeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalUncashedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ToolStripButton tsbStart;
    }
}

