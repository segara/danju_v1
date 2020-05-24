namespace KOASampleCS
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.기본기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.접속상태ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계좌조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조회기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.현재가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.일봉데이터ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조건검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조건식로컬저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조건명리스트호출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lst실시간 = new System.Windows.Forms.ListBox();
            this.lst일반 = new System.Windows.Forms.ListBox();
            this.lst조회 = new System.Windows.Forms.ListBox();
            this.lst에러 = new System.Windows.Forms.ListBox();
            this.lbl일반 = new System.Windows.Forms.Label();
            this.lbl에러 = new System.Windows.Forms.Label();
            this.lbl실시간 = new System.Windows.Forms.Label();
            this.lbl조회 = new System.Windows.Forms.Label();
            this.grp로그 = new System.Windows.Forms.GroupBox();
            this.axKHOpenAPI = new AxKHOpenAPILib.AxKHOpenAPI();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl이름 = new System.Windows.Forms.Label();
            this.lbl아이디 = new System.Windows.Forms.Label();
            this.cbo계좌 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt종목코드 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt조회날짜 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn주문 = new System.Windows.Forms.Button();
            this.cbo매매구분 = new System.Windows.Forms.ComboBox();
            this.cbo거래구분 = new System.Windows.Forms.ComboBox();
            this.txt원주문번호 = new System.Windows.Forms.TextBox();
            this.txt주문가격 = new System.Windows.Forms.TextBox();
            this.txt주문수량 = new System.Windows.Forms.TextBox();
            this.txt주문종목코드 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo조건식 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_조건실시간중지 = new System.Windows.Forms.Button();
            this.btn조건실시간조회 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_조건일반조회 = new System.Windows.Forms.Button();
            this.group실시간등록해제 = new System.Windows.Forms.GroupBox();
            this.btn실시간해제 = new System.Windows.Forms.Button();
            this.btn실시간등록 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt실시간종목코드 = new System.Windows.Forms.TextBox();
            this.btn자동주문 = new System.Windows.Forms.Button();
            this.savedStockDataGridView = new System.Windows.Forms.DataGridView();
            this.idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.itemSearchBtn = new System.Windows.Forms.Button();
            this.itemSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchItemBtn = new System.Windows.Forms.Button();
            this.allAddBtn = new System.Windows.Forms.Button();
            this.favoriteAddBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.favoriteItemCodeTxt = new System.Windows.Forms.TextBox();
            this.danjuCheckDataGridView = new System.Windows.Forms.DataGridView();
            this.danjuItemName = new System.Windows.Forms.Label();
            this.deleteNotDanjuBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.allDanjuVolumeText = new System.Windows.Forms.Label();
            this.allDanjuMoneyText = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.sortBtn = new System.Windows.Forms.Button();
            this.dataStopBtn = new System.Windows.Forms.Button();
            this.reconnectBtn = new System.Windows.Forms.Button();
            this.exceptCheckBox10 = new System.Windows.Forms.CheckBox();
            this.exceptCheckBox20 = new System.Windows.Forms.CheckBox();
            this.exceptCheckBox50 = new System.Windows.Forms.CheckBox();
            this.exceptCheckBox100 = new System.Windows.Forms.CheckBox();
            this.exceptCheckBoxM100 = new System.Windows.Forms.CheckBox();
            this.exceptCheckBoxM50 = new System.Windows.Forms.CheckBox();
            this.exceptCheckBoxM20 = new System.Windows.Forms.CheckBox();
            this.exceptCheckBoxM10 = new System.Windows.Forms.CheckBox();
            this.danjuCombineCheckBox = new System.Windows.Forms.CheckBox();
            this.danjuGridView_단주 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danjuGridView_체결횟수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danjuGridView_합산금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danjuGridView_주기 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danjuGridView_시작시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danjuGridView_종료시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.grp로그.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.group실시간등록해제.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savedStockDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danjuCheckDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기본기능ToolStripMenuItem,
            this.조회기능ToolStripMenuItem,
            this.주문기능ToolStripMenuItem,
            this.조건검색ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1464, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // 기본기능ToolStripMenuItem
            // 
            this.기본기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem,
            this.접속상태ToolStripMenuItem,
            this.계좌조회ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.기본기능ToolStripMenuItem.Name = "기본기능ToolStripMenuItem";
            this.기본기능ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.기본기능ToolStripMenuItem.Text = "기본기능";
            // 
            // 로그인ToolStripMenuItem
            // 
            this.로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            this.로그인ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.로그인ToolStripMenuItem.Text = "로그인";
            this.로그인ToolStripMenuItem.Click += new System.EventHandler(this.로그인ToolStripMenuItem_Click);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // 접속상태ToolStripMenuItem
            // 
            this.접속상태ToolStripMenuItem.Name = "접속상태ToolStripMenuItem";
            this.접속상태ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.접속상태ToolStripMenuItem.Text = "접속상태";
            this.접속상태ToolStripMenuItem.Click += new System.EventHandler(this.접속상태ToolStripMenuItem_Click);
            // 
            // 계좌조회ToolStripMenuItem
            // 
            this.계좌조회ToolStripMenuItem.Name = "계좌조회ToolStripMenuItem";
            this.계좌조회ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.계좌조회ToolStripMenuItem.Text = "계좌조회";
            this.계좌조회ToolStripMenuItem.Click += new System.EventHandler(this.계좌조회ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 조회기능ToolStripMenuItem
            // 
            this.조회기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.현재가ToolStripMenuItem,
            this.일봉데이터ToolStripMenuItem});
            this.조회기능ToolStripMenuItem.Name = "조회기능ToolStripMenuItem";
            this.조회기능ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.조회기능ToolStripMenuItem.Text = "조회기능";
            // 
            // 현재가ToolStripMenuItem
            // 
            this.현재가ToolStripMenuItem.Name = "현재가ToolStripMenuItem";
            this.현재가ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.현재가ToolStripMenuItem.Text = "현재가";
            this.현재가ToolStripMenuItem.Click += new System.EventHandler(this.현재가ToolStripMenuItem_Click);
            // 
            // 일봉데이터ToolStripMenuItem
            // 
            this.일봉데이터ToolStripMenuItem.Name = "일봉데이터ToolStripMenuItem";
            this.일봉데이터ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.일봉데이터ToolStripMenuItem.Text = "일봉데이터";
            this.일봉데이터ToolStripMenuItem.Click += new System.EventHandler(this.일봉데이터ToolStripMenuItem_Click);
            // 
            // 주문기능ToolStripMenuItem
            // 
            this.주문기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주문ToolStripMenuItem});
            this.주문기능ToolStripMenuItem.Name = "주문기능ToolStripMenuItem";
            this.주문기능ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.주문기능ToolStripMenuItem.Text = "주문기능";
            // 
            // 주문ToolStripMenuItem
            // 
            this.주문ToolStripMenuItem.Name = "주문ToolStripMenuItem";
            this.주문ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.주문ToolStripMenuItem.Text = "주문";
            this.주문ToolStripMenuItem.Click += new System.EventHandler(this.주문ToolStripMenuItem_Click);
            // 
            // 조건검색ToolStripMenuItem
            // 
            this.조건검색ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.조건식로컬저장ToolStripMenuItem,
            this.조건명리스트호출ToolStripMenuItem});
            this.조건검색ToolStripMenuItem.Name = "조건검색ToolStripMenuItem";
            this.조건검색ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.조건검색ToolStripMenuItem.Text = "조건검색";
            // 
            // 조건식로컬저장ToolStripMenuItem
            // 
            this.조건식로컬저장ToolStripMenuItem.Name = "조건식로컬저장ToolStripMenuItem";
            this.조건식로컬저장ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.조건식로컬저장ToolStripMenuItem.Text = "조건식 로컬저장";
            this.조건식로컬저장ToolStripMenuItem.Click += new System.EventHandler(this.조건식로컬저장ToolStripMenuItem_Click);
            // 
            // 조건명리스트호출ToolStripMenuItem
            // 
            this.조건명리스트호출ToolStripMenuItem.Name = "조건명리스트호출ToolStripMenuItem";
            this.조건명리스트호출ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.조건명리스트호출ToolStripMenuItem.Text = "조건명 리스트 호출";
            this.조건명리스트호출ToolStripMenuItem.Click += new System.EventHandler(this.조건명리스트호출ToolStripMenuItem_Click);
            // 
            // lst실시간
            // 
            this.lst실시간.FormattingEnabled = true;
            this.lst실시간.HorizontalScrollbar = true;
            this.lst실시간.ItemHeight = 12;
            this.lst실시간.Location = new System.Drawing.Point(805, 85);
            this.lst실시간.Name = "lst실시간";
            this.lst실시간.Size = new System.Drawing.Size(611, 112);
            this.lst실시간.TabIndex = 2;
            // 
            // lst일반
            // 
            this.lst일반.FormattingEnabled = true;
            this.lst일반.HorizontalScrollbar = true;
            this.lst일반.ItemHeight = 12;
            this.lst일반.Location = new System.Drawing.Point(508, 85);
            this.lst일반.Name = "lst일반";
            this.lst일반.Size = new System.Drawing.Size(291, 112);
            this.lst일반.TabIndex = 3;
            // 
            // lst조회
            // 
            this.lst조회.FormattingEnabled = true;
            this.lst조회.HorizontalScrollbar = true;
            this.lst조회.ItemHeight = 12;
            this.lst조회.Location = new System.Drawing.Point(312, 166);
            this.lst조회.Name = "lst조회";
            this.lst조회.Size = new System.Drawing.Size(611, 160);
            this.lst조회.TabIndex = 4;
            // 
            // lst에러
            // 
            this.lst에러.FormattingEnabled = true;
            this.lst에러.HorizontalScrollbar = true;
            this.lst에러.ItemHeight = 12;
            this.lst에러.Location = new System.Drawing.Point(15, 166);
            this.lst에러.Name = "lst에러";
            this.lst에러.Size = new System.Drawing.Size(291, 160);
            this.lst에러.TabIndex = 5;
            // 
            // lbl일반
            // 
            this.lbl일반.AutoSize = true;
            this.lbl일반.Location = new System.Drawing.Point(506, 70);
            this.lbl일반.Name = "lbl일반";
            this.lbl일반.Size = new System.Drawing.Size(29, 12);
            this.lbl일반.TabIndex = 6;
            this.lbl일반.Text = "일반";
            // 
            // lbl에러
            // 
            this.lbl에러.AutoSize = true;
            this.lbl에러.Location = new System.Drawing.Point(11, 151);
            this.lbl에러.Name = "lbl에러";
            this.lbl에러.Size = new System.Drawing.Size(29, 12);
            this.lbl에러.TabIndex = 7;
            this.lbl에러.Text = "에러";
            // 
            // lbl실시간
            // 
            this.lbl실시간.AutoSize = true;
            this.lbl실시간.Location = new System.Drawing.Point(805, 70);
            this.lbl실시간.Name = "lbl실시간";
            this.lbl실시간.Size = new System.Drawing.Size(41, 12);
            this.lbl실시간.TabIndex = 8;
            this.lbl실시간.Text = "실시간";
            // 
            // lbl조회
            // 
            this.lbl조회.AutoSize = true;
            this.lbl조회.Location = new System.Drawing.Point(310, 151);
            this.lbl조회.Name = "lbl조회";
            this.lbl조회.Size = new System.Drawing.Size(29, 12);
            this.lbl조회.TabIndex = 9;
            this.lbl조회.Text = "조회";
            // 
            // grp로그
            // 
            this.grp로그.Controls.Add(this.lbl조회);
            this.grp로그.Controls.Add(this.lbl에러);
            this.grp로그.Controls.Add(this.lst조회);
            this.grp로그.Controls.Add(this.lst에러);
            this.grp로그.Location = new System.Drawing.Point(502, 33);
            this.grp로그.Name = "grp로그";
            this.grp로그.Size = new System.Drawing.Size(940, 338);
            this.grp로그.TabIndex = 10;
            this.grp로그.TabStop = false;
            this.grp로그.Text = "오픈 API 로그";
            // 
            // axKHOpenAPI
            // 
            this.axKHOpenAPI.Enabled = true;
            this.axKHOpenAPI.Location = new System.Drawing.Point(1, 615);
            this.axKHOpenAPI.Name = "axKHOpenAPI";
            this.axKHOpenAPI.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI.OcxState")));
            this.axKHOpenAPI.Size = new System.Drawing.Size(128, 38);
            this.axKHOpenAPI.TabIndex = 11;
            this.axKHOpenAPI.OnReceiveTrData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEventHandler(this.axKHOpenAPI_OnReceiveTrData);
            this.axKHOpenAPI.OnReceiveRealData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEventHandler(this.axKHOpenAPI_OnReceiveRealData);
            this.axKHOpenAPI.OnReceiveMsg += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveMsgEventHandler(this.axKHOpenAPI_OnReceiveMsg);
            this.axKHOpenAPI.OnReceiveChejanData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveChejanDataEventHandler(this.axKHOpenAPI_OnReceiveChejanData);
            this.axKHOpenAPI.OnEventConnect += new AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEventHandler(this.axKHOpenAPI_OnEventConnect);
            this.axKHOpenAPI.OnReceiveRealCondition += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealConditionEventHandler(this.axKHOpenAPI_OnReceiveRealCondition);
            this.axKHOpenAPI.OnReceiveTrCondition += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrConditionEventHandler(this.axKHOpenAPI_OnReceiveTrCondition);
            this.axKHOpenAPI.OnReceiveConditionVer += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveConditionVerEventHandler(this.axKHOpenAPI_OnReceiveConditionVer);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 61);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 12);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "이름 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "아이디 : ";
            // 
            // lbl이름
            // 
            this.lbl이름.AutoSize = true;
            this.lbl이름.Location = new System.Drawing.Point(59, 61);
            this.lbl이름.Name = "lbl이름";
            this.lbl이름.Size = new System.Drawing.Size(0, 12);
            this.lbl이름.TabIndex = 14;
            // 
            // lbl아이디
            // 
            this.lbl아이디.AutoSize = true;
            this.lbl아이디.Location = new System.Drawing.Point(71, 87);
            this.lbl아이디.Name = "lbl아이디";
            this.lbl아이디.Size = new System.Drawing.Size(0, 12);
            this.lbl아이디.TabIndex = 15;
            // 
            // cbo계좌
            // 
            this.cbo계좌.FormattingEnabled = true;
            this.cbo계좌.Location = new System.Drawing.Point(82, 110);
            this.cbo계좌.Name = "cbo계좌";
            this.cbo계좌.Size = new System.Drawing.Size(121, 20);
            this.cbo계좌.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "계좌번호 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "종목코드 :";
            // 
            // txt종목코드
            // 
            this.txt종목코드.Location = new System.Drawing.Point(82, 136);
            this.txt종목코드.Name = "txt종목코드";
            this.txt종목코드.Size = new System.Drawing.Size(75, 21);
            this.txt종목코드.TabIndex = 19;
            this.txt종목코드.Text = "039490";
            this.txt종목코드.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt종목코드_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "조회날짜 (20141226)";
            // 
            // txt조회날짜
            // 
            this.txt조회날짜.Location = new System.Drawing.Point(131, 168);
            this.txt조회날짜.Name = "txt조회날짜";
            this.txt조회날짜.Size = new System.Drawing.Size(72, 21);
            this.txt조회날짜.TabIndex = 21;
            this.txt조회날짜.Text = "20150126";
            this.txt조회날짜.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt조회날짜_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn주문);
            this.groupBox1.Controls.Add(this.cbo매매구분);
            this.groupBox1.Controls.Add(this.cbo거래구분);
            this.groupBox1.Controls.Add(this.txt원주문번호);
            this.groupBox1.Controls.Add(this.txt주문가격);
            this.groupBox1.Controls.Add(this.txt주문수량);
            this.groupBox1.Controls.Add(this.txt주문종목코드);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(14, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 246);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주문입력";
            // 
            // btn주문
            // 
            this.btn주문.Location = new System.Drawing.Point(27, 197);
            this.btn주문.Name = "btn주문";
            this.btn주문.Size = new System.Drawing.Size(198, 30);
            this.btn주문.TabIndex = 12;
            this.btn주문.Text = "주     문";
            this.btn주문.UseVisualStyleBackColor = true;
            this.btn주문.Click += new System.EventHandler(this.btn주문_Click);
            // 
            // cbo매매구분
            // 
            this.cbo매매구분.FormattingEnabled = true;
            this.cbo매매구분.Location = new System.Drawing.Point(84, 78);
            this.cbo매매구분.Name = "cbo매매구분";
            this.cbo매매구분.Size = new System.Drawing.Size(141, 20);
            this.cbo매매구분.TabIndex = 11;
            // 
            // cbo거래구분
            // 
            this.cbo거래구분.FormattingEnabled = true;
            this.cbo거래구분.Location = new System.Drawing.Point(84, 47);
            this.cbo거래구분.Name = "cbo거래구분";
            this.cbo거래구분.Size = new System.Drawing.Size(141, 20);
            this.cbo거래구분.TabIndex = 10;
            // 
            // txt원주문번호
            // 
            this.txt원주문번호.Location = new System.Drawing.Point(84, 159);
            this.txt원주문번호.Name = "txt원주문번호";
            this.txt원주문번호.Size = new System.Drawing.Size(141, 21);
            this.txt원주문번호.TabIndex = 9;
            this.txt원주문번호.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt원주문번호_KeyPress);
            // 
            // txt주문가격
            // 
            this.txt주문가격.Location = new System.Drawing.Point(84, 134);
            this.txt주문가격.Name = "txt주문가격";
            this.txt주문가격.Size = new System.Drawing.Size(141, 21);
            this.txt주문가격.TabIndex = 8;
            this.txt주문가격.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt주문가격_KeyPress);
            // 
            // txt주문수량
            // 
            this.txt주문수량.Location = new System.Drawing.Point(84, 107);
            this.txt주문수량.Name = "txt주문수량";
            this.txt주문수량.Size = new System.Drawing.Size(141, 21);
            this.txt주문수량.TabIndex = 7;
            this.txt주문수량.Text = "10";
            this.txt주문수량.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt주문수량_KeyPress);
            // 
            // txt주문종목코드
            // 
            this.txt주문종목코드.Location = new System.Drawing.Point(84, 20);
            this.txt주문종목코드.Name = "txt주문종목코드";
            this.txt주문종목코드.Size = new System.Drawing.Size(141, 21);
            this.txt주문종목코드.TabIndex = 6;
            this.txt주문종목코드.Text = "039490";
            this.txt주문종목코드.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt주문종목코드_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "원주문번호";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "주문가격";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "주문수량";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "매매구분";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "거래구분";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "종목코드";
            // 
            // cbo조건식
            // 
            this.cbo조건식.FormattingEnabled = true;
            this.cbo조건식.Location = new System.Drawing.Point(64, 19);
            this.cbo조건식.Name = "cbo조건식";
            this.cbo조건식.Size = new System.Drawing.Size(121, 20);
            this.cbo조건식.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_조건실시간중지);
            this.groupBox2.Controls.Add(this.btn조건실시간조회);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btn_조건일반조회);
            this.groupBox2.Controls.Add(this.cbo조건식);
            this.groupBox2.Location = new System.Drawing.Point(275, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 134);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "조건검색";
            // 
            // btn_조건실시간중지
            // 
            this.btn_조건실시간중지.Location = new System.Drawing.Point(110, 91);
            this.btn_조건실시간중지.Name = "btn_조건실시간중지";
            this.btn_조건실시간중지.Size = new System.Drawing.Size(75, 23);
            this.btn_조건실시간중지.TabIndex = 27;
            this.btn_조건실시간중지.Text = "실시간중지";
            this.btn_조건실시간중지.UseVisualStyleBackColor = true;
            this.btn_조건실시간중지.Click += new System.EventHandler(this.btn_조건실시간중지_Click);
            // 
            // btn조건실시간조회
            // 
            this.btn조건실시간조회.Location = new System.Drawing.Point(110, 53);
            this.btn조건실시간조회.Name = "btn조건실시간조회";
            this.btn조건실시간조회.Size = new System.Drawing.Size(75, 23);
            this.btn조건실시간조회.TabIndex = 26;
            this.btn조건실시간조회.Text = "실시간조회";
            this.btn조건실시간조회.UseVisualStyleBackColor = true;
            this.btn조건실시간조회.Click += new System.EventHandler(this.btn조건실시간조회_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "조건식 : ";
            // 
            // btn_조건일반조회
            // 
            this.btn_조건일반조회.Location = new System.Drawing.Point(18, 53);
            this.btn_조건일반조회.Name = "btn_조건일반조회";
            this.btn_조건일반조회.Size = new System.Drawing.Size(75, 23);
            this.btn_조건일반조회.TabIndex = 25;
            this.btn_조건일반조회.Text = "일반조회";
            this.btn_조건일반조회.UseVisualStyleBackColor = true;
            this.btn_조건일반조회.Click += new System.EventHandler(this.btn_조건일반조회_Click);
            // 
            // group실시간등록해제
            // 
            this.group실시간등록해제.Controls.Add(this.btn실시간해제);
            this.group실시간등록해제.Controls.Add(this.btn실시간등록);
            this.group실시간등록해제.Controls.Add(this.label13);
            this.group실시간등록해제.Controls.Add(this.txt실시간종목코드);
            this.group실시간등록해제.Location = new System.Drawing.Point(275, 207);
            this.group실시간등록해제.Name = "group실시간등록해제";
            this.group실시간등록해제.Size = new System.Drawing.Size(212, 100);
            this.group실시간등록해제.TabIndex = 25;
            this.group실시간등록해제.TabStop = false;
            this.group실시간등록해제.Text = "실시간 등록 해제";
            // 
            // btn실시간해제
            // 
            this.btn실시간해제.Location = new System.Drawing.Point(131, 70);
            this.btn실시간해제.Name = "btn실시간해제";
            this.btn실시간해제.Size = new System.Drawing.Size(75, 23);
            this.btn실시간해제.TabIndex = 29;
            this.btn실시간해제.Text = "실시간해제";
            this.btn실시간해제.UseVisualStyleBackColor = true;
            this.btn실시간해제.Click += new System.EventHandler(this.btn실시간해제_Click);
            // 
            // btn실시간등록
            // 
            this.btn실시간등록.Location = new System.Drawing.Point(8, 70);
            this.btn실시간등록.Name = "btn실시간등록";
            this.btn실시간등록.Size = new System.Drawing.Size(75, 23);
            this.btn실시간등록.TabIndex = 28;
            this.btn실시간등록.Text = "실시간등록";
            this.btn실시간등록.UseVisualStyleBackColor = true;
            this.btn실시간등록.Click += new System.EventHandler(this.btn실시간등록_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 26;
            this.label13.Text = "종목코드 : ";
            // 
            // txt실시간종목코드
            // 
            this.txt실시간종목코드.Location = new System.Drawing.Point(8, 44);
            this.txt실시간종목코드.Name = "txt실시간종목코드";
            this.txt실시간종목코드.Size = new System.Drawing.Size(198, 21);
            this.txt실시간종목코드.TabIndex = 0;
            // 
            // btn자동주문
            // 
            this.btn자동주문.Location = new System.Drawing.Point(275, 333);
            this.btn자동주문.Name = "btn자동주문";
            this.btn자동주문.Size = new System.Drawing.Size(206, 29);
            this.btn자동주문.TabIndex = 26;
            this.btn자동주문.Text = "자동주문 시작";
            this.btn자동주문.UseVisualStyleBackColor = true;
            this.btn자동주문.Click += new System.EventHandler(this.btn자동주문_Click);
            // 
            // savedStockDataGridView
            // 
            this.savedStockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.savedStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.savedStockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idx,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.savedStockDataGridView.Location = new System.Drawing.Point(14, 475);
            this.savedStockDataGridView.Name = "savedStockDataGridView";
            this.savedStockDataGridView.RowHeadersVisible = false;
            this.savedStockDataGridView.RowHeadersWidth = 82;
            this.savedStockDataGridView.RowTemplate.Height = 23;
            this.savedStockDataGridView.Size = new System.Drawing.Size(467, 150);
            this.savedStockDataGridView.TabIndex = 27;
            this.savedStockDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.savedStockDataGridView_CellContentClick);
            // 
            // idx
            // 
            this.idx.HeaderText = "idx";
            this.idx.MinimumWidth = 10;
            this.idx.Name = "idx";
            this.idx.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "종목명";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "현재가";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "등락율";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "대비";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "거래량";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.itemSearchBtn);
            this.groupBox3.Controls.Add(this.itemSearchTextBox);
            this.groupBox3.Controls.Add(this.searchItemBtn);
            this.groupBox3.Controls.Add(this.allAddBtn);
            this.groupBox3.Controls.Add(this.favoriteAddBtn);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.favoriteItemCodeTxt);
            this.groupBox3.Location = new System.Drawing.Point(269, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 100);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "관심종목등록";
            // 
            // itemSearchBtn
            // 
            this.itemSearchBtn.Location = new System.Drawing.Point(191, 40);
            this.itemSearchBtn.Name = "itemSearchBtn";
            this.itemSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.itemSearchBtn.TabIndex = 32;
            this.itemSearchBtn.Text = "검색";
            this.itemSearchBtn.UseVisualStyleBackColor = true;
            this.itemSearchBtn.Click += new System.EventHandler(this.itemSearchBtn_Click);
            // 
            // itemSearchTextBox
            // 
            this.itemSearchTextBox.Location = new System.Drawing.Point(191, 15);
            this.itemSearchTextBox.Name = "itemSearchTextBox";
            this.itemSearchTextBox.Size = new System.Drawing.Size(75, 21);
            this.itemSearchTextBox.TabIndex = 31;
            // 
            // searchItemBtn
            // 
            this.searchItemBtn.Location = new System.Drawing.Point(87, 71);
            this.searchItemBtn.Name = "searchItemBtn";
            this.searchItemBtn.Size = new System.Drawing.Size(90, 23);
            this.searchItemBtn.TabIndex = 30;
            this.searchItemBtn.Text = "특정조건등록";
            this.searchItemBtn.UseVisualStyleBackColor = true;
            this.searchItemBtn.Click += new System.EventHandler(this.searchItemBtn_Click);
            // 
            // allAddBtn
            // 
            this.allAddBtn.Location = new System.Drawing.Point(6, 71);
            this.allAddBtn.Name = "allAddBtn";
            this.allAddBtn.Size = new System.Drawing.Size(75, 23);
            this.allAddBtn.TabIndex = 29;
            this.allAddBtn.Text = "전종목등록";
            this.allAddBtn.UseVisualStyleBackColor = true;
            this.allAddBtn.Click += new System.EventHandler(this.allAddBtn_Click);
            // 
            // favoriteAddBtn
            // 
            this.favoriteAddBtn.Location = new System.Drawing.Point(102, 39);
            this.favoriteAddBtn.Name = "favoriteAddBtn";
            this.favoriteAddBtn.Size = new System.Drawing.Size(75, 23);
            this.favoriteAddBtn.TabIndex = 28;
            this.favoriteAddBtn.Text = "등록";
            this.favoriteAddBtn.UseVisualStyleBackColor = true;
            this.favoriteAddBtn.Click += new System.EventHandler(this.favoriteAddBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "종목코드 : ";
            // 
            // favoriteItemCodeTxt
            // 
            this.favoriteItemCodeTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.favoriteItemCodeTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.favoriteItemCodeTxt.Location = new System.Drawing.Point(102, 14);
            this.favoriteItemCodeTxt.Name = "favoriteItemCodeTxt";
            this.favoriteItemCodeTxt.Size = new System.Drawing.Size(75, 21);
            this.favoriteItemCodeTxt.TabIndex = 0;
            // 
            // danjuCheckDataGridView
            // 
            this.danjuCheckDataGridView.AllowUserToAddRows = false;
            this.danjuCheckDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danjuCheckDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danjuCheckDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.danjuGridView_단주,
            this.danjuGridView_체결횟수,
            this.danjuGridView_합산금액,
            this.danjuGridView_주기,
            this.danjuGridView_시작시간,
            this.danjuGridView_종료시간});
            this.danjuCheckDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.danjuCheckDataGridView.Location = new System.Drawing.Point(508, 475);
            this.danjuCheckDataGridView.Name = "danjuCheckDataGridView";
            this.danjuCheckDataGridView.RowHeadersVisible = false;
            this.danjuCheckDataGridView.RowHeadersWidth = 82;
            this.danjuCheckDataGridView.RowTemplate.Height = 23;
            this.danjuCheckDataGridView.Size = new System.Drawing.Size(551, 150);
            this.danjuCheckDataGridView.TabIndex = 31;
            // 
            // danjuItemName
            // 
            this.danjuItemName.AutoSize = true;
            this.danjuItemName.Location = new System.Drawing.Point(717, 445);
            this.danjuItemName.Name = "danjuItemName";
            this.danjuItemName.Size = new System.Drawing.Size(41, 12);
            this.danjuItemName.TabIndex = 32;
            this.danjuItemName.Text = "종목명";
            // 
            // deleteNotDanjuBtn
            // 
            this.deleteNotDanjuBtn.Location = new System.Drawing.Point(710, 408);
            this.deleteNotDanjuBtn.Name = "deleteNotDanjuBtn";
            this.deleteNotDanjuBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteNotDanjuBtn.TabIndex = 30;
            this.deleteNotDanjuBtn.Text = "미단주삭제";
            this.deleteNotDanjuBtn.UseVisualStyleBackColor = true;
            this.deleteNotDanjuBtn.Click += new System.EventHandler(this.deleteNotDanjuBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(812, 445);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 33;
            this.label15.Text = "총단주량 : ";
            // 
            // allDanjuVolumeText
            // 
            this.allDanjuVolumeText.AutoSize = true;
            this.allDanjuVolumeText.Location = new System.Drawing.Point(903, 445);
            this.allDanjuVolumeText.Name = "allDanjuVolumeText";
            this.allDanjuVolumeText.Size = new System.Drawing.Size(11, 12);
            this.allDanjuVolumeText.TabIndex = 34;
            this.allDanjuVolumeText.Text = "0";
            // 
            // allDanjuMoneyText
            // 
            this.allDanjuMoneyText.AutoSize = true;
            this.allDanjuMoneyText.Location = new System.Drawing.Point(1023, 445);
            this.allDanjuMoneyText.Name = "allDanjuMoneyText";
            this.allDanjuMoneyText.Size = new System.Drawing.Size(11, 12);
            this.allDanjuMoneyText.TabIndex = 35;
            this.allDanjuMoneyText.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(938, 445);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 36;
            this.label16.Text = "총거래금 : ";
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(791, 408);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 37;
            this.sortBtn.Text = "정렬";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // dataStopBtn
            // 
            this.dataStopBtn.Location = new System.Drawing.Point(893, 408);
            this.dataStopBtn.Name = "dataStopBtn";
            this.dataStopBtn.Size = new System.Drawing.Size(75, 23);
            this.dataStopBtn.TabIndex = 38;
            this.dataStopBtn.Text = "데이터중지";
            this.dataStopBtn.UseVisualStyleBackColor = true;
            this.dataStopBtn.Click += new System.EventHandler(this.dataStopBtn_Click);
            // 
            // reconnectBtn
            // 
            this.reconnectBtn.Location = new System.Drawing.Point(974, 408);
            this.reconnectBtn.Name = "reconnectBtn";
            this.reconnectBtn.Size = new System.Drawing.Size(75, 23);
            this.reconnectBtn.TabIndex = 39;
            this.reconnectBtn.Text = "데이터연결";
            this.reconnectBtn.UseVisualStyleBackColor = true;
            this.reconnectBtn.Click += new System.EventHandler(this.reconnectBtn_Click);
            // 
            // exceptCheckBox10
            // 
            this.exceptCheckBox10.AutoSize = true;
            this.exceptCheckBox10.Location = new System.Drawing.Point(1084, 418);
            this.exceptCheckBox10.Name = "exceptCheckBox10";
            this.exceptCheckBox10.Size = new System.Drawing.Size(36, 16);
            this.exceptCheckBox10.TabIndex = 40;
            this.exceptCheckBox10.Text = "10";
            this.exceptCheckBox10.UseVisualStyleBackColor = true;
            this.exceptCheckBox10.CheckedChanged += new System.EventHandler(this.exceptCheckBox10_CheckedChanged);
            // 
            // exceptCheckBox20
            // 
            this.exceptCheckBox20.AutoSize = true;
            this.exceptCheckBox20.Location = new System.Drawing.Point(1084, 440);
            this.exceptCheckBox20.Name = "exceptCheckBox20";
            this.exceptCheckBox20.Size = new System.Drawing.Size(36, 16);
            this.exceptCheckBox20.TabIndex = 41;
            this.exceptCheckBox20.Text = "20";
            this.exceptCheckBox20.UseVisualStyleBackColor = true;
            this.exceptCheckBox20.CheckedChanged += new System.EventHandler(this.exceptCheckBox20_CheckedChanged);
            // 
            // exceptCheckBox50
            // 
            this.exceptCheckBox50.AutoSize = true;
            this.exceptCheckBox50.Location = new System.Drawing.Point(1084, 462);
            this.exceptCheckBox50.Name = "exceptCheckBox50";
            this.exceptCheckBox50.Size = new System.Drawing.Size(36, 16);
            this.exceptCheckBox50.TabIndex = 42;
            this.exceptCheckBox50.Text = "50";
            this.exceptCheckBox50.UseVisualStyleBackColor = true;
            this.exceptCheckBox50.CheckedChanged += new System.EventHandler(this.exceptCheckBox50_CheckedChanged);
            // 
            // exceptCheckBox100
            // 
            this.exceptCheckBox100.AutoSize = true;
            this.exceptCheckBox100.Location = new System.Drawing.Point(1084, 484);
            this.exceptCheckBox100.Name = "exceptCheckBox100";
            this.exceptCheckBox100.Size = new System.Drawing.Size(42, 16);
            this.exceptCheckBox100.TabIndex = 43;
            this.exceptCheckBox100.Text = "100";
            this.exceptCheckBox100.UseVisualStyleBackColor = true;
            this.exceptCheckBox100.CheckedChanged += new System.EventHandler(this.exceptCheckBox100_CheckedChanged);
            // 
            // exceptCheckBoxM100
            // 
            this.exceptCheckBoxM100.AutoSize = true;
            this.exceptCheckBoxM100.Location = new System.Drawing.Point(1126, 484);
            this.exceptCheckBoxM100.Name = "exceptCheckBoxM100";
            this.exceptCheckBoxM100.Size = new System.Drawing.Size(48, 16);
            this.exceptCheckBoxM100.TabIndex = 47;
            this.exceptCheckBoxM100.Text = "-100";
            this.exceptCheckBoxM100.UseVisualStyleBackColor = true;
            this.exceptCheckBoxM100.CheckedChanged += new System.EventHandler(this.exceptCheckBoxM100_CheckedChanged);
            // 
            // exceptCheckBoxM50
            // 
            this.exceptCheckBoxM50.AutoSize = true;
            this.exceptCheckBoxM50.Location = new System.Drawing.Point(1126, 462);
            this.exceptCheckBoxM50.Name = "exceptCheckBoxM50";
            this.exceptCheckBoxM50.Size = new System.Drawing.Size(42, 16);
            this.exceptCheckBoxM50.TabIndex = 46;
            this.exceptCheckBoxM50.Text = "-50";
            this.exceptCheckBoxM50.UseVisualStyleBackColor = true;
            this.exceptCheckBoxM50.CheckedChanged += new System.EventHandler(this.exceptCheckBoxM50_CheckedChanged);
            // 
            // exceptCheckBoxM20
            // 
            this.exceptCheckBoxM20.AutoSize = true;
            this.exceptCheckBoxM20.Location = new System.Drawing.Point(1126, 440);
            this.exceptCheckBoxM20.Name = "exceptCheckBoxM20";
            this.exceptCheckBoxM20.Size = new System.Drawing.Size(42, 16);
            this.exceptCheckBoxM20.TabIndex = 45;
            this.exceptCheckBoxM20.Text = "-20";
            this.exceptCheckBoxM20.UseVisualStyleBackColor = true;
            this.exceptCheckBoxM20.CheckedChanged += new System.EventHandler(this.exceptCheckBoxM20_CheckedChanged);
            // 
            // exceptCheckBoxM10
            // 
            this.exceptCheckBoxM10.AutoSize = true;
            this.exceptCheckBoxM10.Location = new System.Drawing.Point(1126, 418);
            this.exceptCheckBoxM10.Name = "exceptCheckBoxM10";
            this.exceptCheckBoxM10.Size = new System.Drawing.Size(42, 16);
            this.exceptCheckBoxM10.TabIndex = 44;
            this.exceptCheckBoxM10.Text = "-10";
            this.exceptCheckBoxM10.UseVisualStyleBackColor = true;
            this.exceptCheckBoxM10.CheckedChanged += new System.EventHandler(this.exceptCheckBoxM10_CheckedChanged);
            // 
            // danjuCombineCheckBox
            // 
            this.danjuCombineCheckBox.AutoSize = true;
            this.danjuCombineCheckBox.Location = new System.Drawing.Point(710, 383);
            this.danjuCombineCheckBox.Name = "danjuCombineCheckBox";
            this.danjuCombineCheckBox.Size = new System.Drawing.Size(96, 16);
            this.danjuCombineCheckBox.TabIndex = 48;
            this.danjuCombineCheckBox.Text = "단주묶어보기";
            this.danjuCombineCheckBox.UseVisualStyleBackColor = true;
            this.danjuCombineCheckBox.CheckedChanged += new System.EventHandler(this.danjuCombineCheckBox_CheckedChanged);
            // 
            // danjuGridView_단주
            // 
            this.danjuGridView_단주.HeaderText = "단주";
            this.danjuGridView_단주.MinimumWidth = 10;
            this.danjuGridView_단주.Name = "danjuGridView_단주";
            this.danjuGridView_단주.ReadOnly = true;
            // 
            // danjuGridView_체결횟수
            // 
            this.danjuGridView_체결횟수.HeaderText = "체결횟수";
            this.danjuGridView_체결횟수.MinimumWidth = 10;
            this.danjuGridView_체결횟수.Name = "danjuGridView_체결횟수";
            this.danjuGridView_체결횟수.ReadOnly = true;
            // 
            // danjuGridView_합산금액
            // 
            this.danjuGridView_합산금액.HeaderText = "합산금액";
            this.danjuGridView_합산금액.MinimumWidth = 10;
            this.danjuGridView_합산금액.Name = "danjuGridView_합산금액";
            this.danjuGridView_합산금액.ReadOnly = true;
            // 
            // danjuGridView_주기
            // 
            this.danjuGridView_주기.HeaderText = "주기";
            this.danjuGridView_주기.MinimumWidth = 10;
            this.danjuGridView_주기.Name = "danjuGridView_주기";
            this.danjuGridView_주기.ReadOnly = true;
            // 
            // danjuGridView_시작시간
            // 
            this.danjuGridView_시작시간.HeaderText = "시작시간";
            this.danjuGridView_시작시간.MinimumWidth = 10;
            this.danjuGridView_시작시간.Name = "danjuGridView_시작시간";
            this.danjuGridView_시작시간.ReadOnly = true;
            // 
            // danjuGridView_종료시간
            // 
            this.danjuGridView_종료시간.HeaderText = "종료시간";
            this.danjuGridView_종료시간.MinimumWidth = 10;
            this.danjuGridView_종료시간.Name = "danjuGridView_종료시간";
            this.danjuGridView_종료시간.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 635);
            this.Controls.Add(this.danjuCombineCheckBox);
            this.Controls.Add(this.exceptCheckBoxM100);
            this.Controls.Add(this.exceptCheckBoxM50);
            this.Controls.Add(this.exceptCheckBoxM20);
            this.Controls.Add(this.exceptCheckBoxM10);
            this.Controls.Add(this.exceptCheckBox100);
            this.Controls.Add(this.exceptCheckBox50);
            this.Controls.Add(this.exceptCheckBox20);
            this.Controls.Add(this.exceptCheckBox10);
            this.Controls.Add(this.reconnectBtn);
            this.Controls.Add(this.dataStopBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.allDanjuMoneyText);
            this.Controls.Add(this.allDanjuVolumeText);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.deleteNotDanjuBtn);
            this.Controls.Add(this.danjuItemName);
            this.Controls.Add(this.danjuCheckDataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.savedStockDataGridView);
            this.Controls.Add(this.btn자동주문);
            this.Controls.Add(this.group실시간등록해제);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt조회날짜);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt종목코드);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo계좌);
            this.Controls.Add(this.lbl아이디);
            this.Controls.Add(this.lbl이름);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.axKHOpenAPI);
            this.Controls.Add(this.lbl실시간);
            this.Controls.Add(this.lbl일반);
            this.Controls.Add(this.lst일반);
            this.Controls.Add(this.lst실시간);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.grp로그);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "키움 오픈 API C# 예제 ( www.sbcn.co.kr )";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grp로그.ResumeLayout(false);
            this.grp로그.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.group실시간등록해제.ResumeLayout(false);
            this.group실시간등록해제.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savedStockDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danjuCheckDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 기본기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 접속상태ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계좌조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조회기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 현재가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 일봉데이터ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문ToolStripMenuItem;
        private System.Windows.Forms.ListBox lst실시간;
        private System.Windows.Forms.ListBox lst일반;
        private System.Windows.Forms.ListBox lst조회;
        private System.Windows.Forms.ListBox lst에러;
        private System.Windows.Forms.Label lbl일반;
        private System.Windows.Forms.Label lbl에러;
        private System.Windows.Forms.Label lbl실시간;
        private System.Windows.Forms.Label lbl조회;
        private System.Windows.Forms.GroupBox grp로그;
        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl이름;
        private System.Windows.Forms.Label lbl아이디;
        private System.Windows.Forms.ComboBox cbo계좌;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt종목코드;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt조회날짜;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo매매구분;
        private System.Windows.Forms.ComboBox cbo거래구분;
        private System.Windows.Forms.TextBox txt원주문번호;
        private System.Windows.Forms.TextBox txt주문가격;
        private System.Windows.Forms.TextBox txt주문수량;
        private System.Windows.Forms.TextBox txt주문종목코드;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn주문;
        private System.Windows.Forms.ToolStripMenuItem 조건검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조건식로컬저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조건명리스트호출ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbo조건식;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_조건실시간중지;
        private System.Windows.Forms.Button btn조건실시간조회;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_조건일반조회;
        private System.Windows.Forms.GroupBox group실시간등록해제;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt실시간종목코드;
        private System.Windows.Forms.Button btn실시간등록;
        private System.Windows.Forms.Button btn실시간해제;
        private System.Windows.Forms.Button btn자동주문;
        private System.Windows.Forms.DataGridView savedStockDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button favoriteAddBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox favoriteItemCodeTxt;
        private System.Windows.Forms.DataGridView danjuCheckDataGridView;
        private System.Windows.Forms.Label danjuItemName;
        private System.Windows.Forms.Button allAddBtn;
        private System.Windows.Forms.Button deleteNotDanjuBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label allDanjuVolumeText;
        private System.Windows.Forms.Label allDanjuMoneyText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button dataStopBtn;
        private System.Windows.Forms.Button reconnectBtn;
        private System.Windows.Forms.CheckBox exceptCheckBox10;
        private System.Windows.Forms.CheckBox exceptCheckBox20;
        private System.Windows.Forms.CheckBox exceptCheckBox50;
        private System.Windows.Forms.CheckBox exceptCheckBox100;
        private System.Windows.Forms.CheckBox exceptCheckBoxM100;
        private System.Windows.Forms.CheckBox exceptCheckBoxM50;
        private System.Windows.Forms.CheckBox exceptCheckBoxM20;
        private System.Windows.Forms.CheckBox exceptCheckBoxM10;
        private System.Windows.Forms.Button searchItemBtn;
        private System.Windows.Forms.Button itemSearchBtn;
        private System.Windows.Forms.TextBox itemSearchTextBox;
        private System.Windows.Forms.CheckBox danjuCombineCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn danjuGridView_단주;
        private System.Windows.Forms.DataGridViewTextBoxColumn danjuGridView_체결횟수;
        private System.Windows.Forms.DataGridViewTextBoxColumn danjuGridView_합산금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn danjuGridView_주기;
        private System.Windows.Forms.DataGridViewTextBoxColumn danjuGridView_시작시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn danjuGridView_종료시간;
    }
}

