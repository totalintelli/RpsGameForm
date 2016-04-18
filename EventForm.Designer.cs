namespace RpsGameForm
{
    partial class EventForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PbRight = new System.Windows.Forms.PictureBox();
            this.PbLeft = new System.Windows.Forms.PictureBox();
            this.BtnBo = new System.Windows.Forms.Button();
            this.BtnBawi = new System.Windows.Forms.Button();
            this.BtnGawi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_result);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PbRight);
            this.groupBox1.Controls.Add(this.PbLeft);
            this.groupBox1.Controls.Add(this.BtnBo);
            this.groupBox1.Controls.Add(this.BtnBawi);
            this.groupBox1.Controls.Add(this.BtnGawi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "가위바위보";
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(73, 157);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(75, 12);
            this.lb_result.TabIndex = 7;
            this.lb_result.Text = "승부 결과는?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "COM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player";
            // 
            // PbRight
            // 
            this.PbRight.Location = new System.Drawing.Point(153, 49);
            this.PbRight.Name = "PbRight";
            this.PbRight.Size = new System.Drawing.Size(100, 76);
            this.PbRight.TabIndex = 4;
            this.PbRight.TabStop = false;
            // 
            // PbLeft
            // 
            this.PbLeft.Location = new System.Drawing.Point(6, 49);
            this.PbLeft.Name = "PbLeft";
            this.PbLeft.Size = new System.Drawing.Size(97, 76);
            this.PbLeft.TabIndex = 3;
            this.PbLeft.TabStop = false;
            // 
            // BtnBo
            // 
            this.BtnBo.Location = new System.Drawing.Point(199, 20);
            this.BtnBo.Name = "BtnBo";
            this.BtnBo.Size = new System.Drawing.Size(54, 23);
            this.BtnBo.TabIndex = 2;
            this.BtnBo.Text = "보";
            this.BtnBo.UseVisualStyleBackColor = true;
            this.BtnBo.Click += new System.EventHandler(this.btn_clicked);
            // 
            // BtnBawi
            // 
            this.BtnBawi.Location = new System.Drawing.Point(105, 20);
            this.BtnBawi.Name = "BtnBawi";
            this.BtnBawi.Size = new System.Drawing.Size(58, 23);
            this.BtnBawi.TabIndex = 1;
            this.BtnBawi.Text = "바위";
            this.BtnBawi.UseVisualStyleBackColor = true;
            this.BtnBawi.Click += new System.EventHandler(this.btn_clicked);
            // 
            // BtnGawi
            // 
            this.BtnGawi.Location = new System.Drawing.Point(6, 20);
            this.BtnGawi.Name = "BtnGawi";
            this.BtnGawi.Size = new System.Drawing.Size(57, 23);
            this.BtnGawi.TabIndex = 0;
            this.BtnGawi.Text = "가위";
            this.BtnGawi.UseVisualStyleBackColor = true;
            this.BtnGawi.Click += new System.EventHandler(this.btn_clicked);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "EventForm";
            this.Text = "가위바위보 게임기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBawi;
        private System.Windows.Forms.Button BtnGawi;
        private System.Windows.Forms.Button BtnBo;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbRight;
        private System.Windows.Forms.PictureBox PbLeft;
    }
}

