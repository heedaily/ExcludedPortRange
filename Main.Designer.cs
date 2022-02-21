
namespace ExcludedPortRange
{
  partial class Main
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
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.gbType = new System.Windows.Forms.GroupBox();
      this.rbUDP = new System.Windows.Forms.RadioButton();
      this.rbTCP = new System.Windows.Forms.RadioButton();
      this.lblStartPort = new System.Windows.Forms.Label();
      this.txtStartPort = new System.Windows.Forms.TextBox();
      this.lblEndPort = new System.Windows.Forms.Label();
      this.txtEndPort = new System.Windows.Forms.TextBox();
      this.btnDeleteExclude = new System.Windows.Forms.Button();
      this.txtInfo = new System.Windows.Forms.TextBox();
      this.btnCreateExclude = new System.Windows.Forms.Button();
      this.lblInfo = new System.Windows.Forms.Label();
      this.gbType.SuspendLayout();
      this.SuspendLayout();
      // 
      // gbType
      // 
      this.gbType.Controls.Add(this.rbUDP);
      this.gbType.Controls.Add(this.rbTCP);
      this.gbType.Location = new System.Drawing.Point(12, 12);
      this.gbType.Name = "gbType";
      this.gbType.Size = new System.Drawing.Size(382, 57);
      this.gbType.TabIndex = 0;
      this.gbType.TabStop = false;
      this.gbType.Text = "Type";
      // 
      // rbUDP
      // 
      this.rbUDP.AutoSize = true;
      this.rbUDP.Location = new System.Drawing.Point(79, 24);
      this.rbUDP.Name = "rbUDP";
      this.rbUDP.Size = new System.Drawing.Size(58, 19);
      this.rbUDP.TabIndex = 2;
      this.rbUDP.TabStop = true;
      this.rbUDP.Text = "UDP";
      this.rbUDP.UseVisualStyleBackColor = true;
      // 
      // rbTCP
      // 
      this.rbTCP.AutoSize = true;
      this.rbTCP.Location = new System.Drawing.Point(17, 24);
      this.rbTCP.Name = "rbTCP";
      this.rbTCP.Size = new System.Drawing.Size(56, 19);
      this.rbTCP.TabIndex = 1;
      this.rbTCP.TabStop = true;
      this.rbTCP.Text = "TCP";
      this.rbTCP.UseVisualStyleBackColor = true;
      // 
      // lblStartPort
      // 
      this.lblStartPort.AutoSize = true;
      this.lblStartPort.Location = new System.Drawing.Point(16, 84);
      this.lblStartPort.Name = "lblStartPort";
      this.lblStartPort.Size = new System.Drawing.Size(69, 15);
      this.lblStartPort.TabIndex = 1;
      this.lblStartPort.Text = "Start Port";
      // 
      // txtStartPort
      // 
      this.txtStartPort.Location = new System.Drawing.Point(91, 78);
      this.txtStartPort.Name = "txtStartPort";
      this.txtStartPort.Size = new System.Drawing.Size(107, 25);
      this.txtStartPort.TabIndex = 2;
      // 
      // lblEndPort
      // 
      this.lblEndPort.AutoSize = true;
      this.lblEndPort.Location = new System.Drawing.Point(212, 81);
      this.lblEndPort.Name = "lblEndPort";
      this.lblEndPort.Size = new System.Drawing.Size(64, 15);
      this.lblEndPort.TabIndex = 3;
      this.lblEndPort.Text = "End Port";
      // 
      // txtEndPort
      // 
      this.txtEndPort.Location = new System.Drawing.Point(287, 78);
      this.txtEndPort.Name = "txtEndPort";
      this.txtEndPort.Size = new System.Drawing.Size(107, 25);
      this.txtEndPort.TabIndex = 4;
      // 
      // btnDeleteExclude
      // 
      this.btnDeleteExclude.Location = new System.Drawing.Point(12, 118);
      this.btnDeleteExclude.Name = "btnDeleteExclude";
      this.btnDeleteExclude.Size = new System.Drawing.Size(186, 30);
      this.btnDeleteExclude.TabIndex = 5;
      this.btnDeleteExclude.Text = "Delete Exclude";
      this.btnDeleteExclude.UseVisualStyleBackColor = true;
      this.btnDeleteExclude.Click += new System.EventHandler(this.btnDeleteExclude_Click);
      // 
      // txtInfo
      // 
      this.txtInfo.Location = new System.Drawing.Point(12, 184);
      this.txtInfo.Multiline = true;
      this.txtInfo.Name = "txtInfo";
      this.txtInfo.ReadOnly = true;
      this.txtInfo.Size = new System.Drawing.Size(382, 67);
      this.txtInfo.TabIndex = 6;
      this.txtInfo.Text = "netsh int ipv4 show excludedportrange protocol=tcp\r\nnetsh int ipv4 show excludedp" +
    "ortrange protocol=udp";
      // 
      // btnCreateExclude
      // 
      this.btnCreateExclude.Location = new System.Drawing.Point(215, 118);
      this.btnCreateExclude.Name = "btnCreateExclude";
      this.btnCreateExclude.Size = new System.Drawing.Size(179, 30);
      this.btnCreateExclude.TabIndex = 7;
      this.btnCreateExclude.Text = "Create Exclude";
      this.btnCreateExclude.UseVisualStyleBackColor = true;
      this.btnCreateExclude.Click += new System.EventHandler(this.btnCreateExclude_Click);
      // 
      // lblInfo
      // 
      this.lblInfo.AutoSize = true;
      this.lblInfo.Location = new System.Drawing.Point(12, 156);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(126, 15);
      this.lblInfo.TabIndex = 8;
      this.lblInfo.Text = "Confirm Command";
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(409, 263);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.btnCreateExclude);
      this.Controls.Add(this.txtInfo);
      this.Controls.Add(this.btnDeleteExclude);
      this.Controls.Add(this.txtEndPort);
      this.Controls.Add(this.lblEndPort);
      this.Controls.Add(this.txtStartPort);
      this.Controls.Add(this.lblStartPort);
      this.Controls.Add(this.gbType);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Main";
      this.Text = "ExcludedPortRange";
      this.gbType.ResumeLayout(false);
      this.gbType.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox gbType;
    private System.Windows.Forms.RadioButton rbUDP;
    private System.Windows.Forms.RadioButton rbTCP;
    private System.Windows.Forms.Label lblStartPort;
    private System.Windows.Forms.TextBox txtStartPort;
    private System.Windows.Forms.Label lblEndPort;
    private System.Windows.Forms.TextBox txtEndPort;
    private System.Windows.Forms.Button btnDeleteExclude;
    private System.Windows.Forms.TextBox txtInfo;
    private System.Windows.Forms.Button btnCreateExclude;
    private System.Windows.Forms.Label lblInfo;
  }
}

