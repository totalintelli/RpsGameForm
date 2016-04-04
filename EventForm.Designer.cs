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
            this.btn_bo = new System.Windows.Forms.Button();
            this.btn_bawi = new System.Windows.Forms.Button();
            this.btn_gawi = new System.Windows.Forms.Button();
            this.leftPicBox = new System.Windows.Forms.PictureBox();
            this.rightPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_result);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rightPicBox);
            this.groupBox1.Controls.Add(this.leftPicBox);
            this.groupBox1.Controls.Add(this.btn_bo);
            this.groupBox1.Controls.Add(this.btn_bawi);
            this.groupBox1.Controls.Add(this.btn_gawi);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "가위바위보";
            // 
            // btn_bo
            // 
            this.btn_bo.Location = new System.Drawing.Point(199, 20);
            this.btn_bo.Name = "btn_bo";
            this.btn_bo.Size = new System.Drawing.Size(54, 23);
            this.btn_bo.TabIndex = 2;
            this.btn_bo.Text = "보";
            this.btn_bo.UseVisualStyleBackColor = true;
            this.btn_bo.Click += new System.EventHandler(this.btn_clicked);
            // 
            // btn_bawi
            // 
            this.btn_bawi.Location = new System.Drawing.Point(105, 20);
            this.btn_bawi.Name = "btn_bawi";
            this.btn_bawi.Size = new System.Drawing.Size(58, 23);
            this.btn_bawi.TabIndex = 1;
            this.btn_bawi.Text = "바위";
            this.btn_bawi.UseVisualStyleBackColor = true;
            this.btn_bawi.Click += new System.EventHandler(this.btn_clicked);
            // 
            // btn_gawi
            // 
            this.btn_gawi.Location = new System.Drawing.Point(6, 20);
            this.btn_gawi.Name = "btn_gawi";
            this.btn_gawi.Size = new System.Drawing.Size(57, 23);
            this.btn_gawi.TabIndex = 0;
            this.btn_gawi.Text = "가위";
            this.btn_gawi.UseVisualStyleBackColor = true;
            this.btn_gawi.Click += new System.EventHandler(this.btn_clicked);
            // 
            // leftPicBox
            // 
            this.leftPicBox.Location = new System.Drawing.Point(6, 49);
            this.leftPicBox.Name = "leftPicBox";
            this.leftPicBox.Size = new System.Drawing.Size(97, 76);
            this.leftPicBox.TabIndex = 3;
            this.leftPicBox.TabStop = false;
            // 
            // rightPicBox
            // 
            this.rightPicBox.Location = new System.Drawing.Point(153, 49);
            this.rightPicBox.Name = "rightPicBox";
            this.rightPicBox.Size = new System.Drawing.Size(100, 76);
            this.rightPicBox.TabIndex = 4;
            this.rightPicBox.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "COM";
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
            ((System.ComponentModel.ISupportInitialize)(this.leftPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_bawi;
        private System.Windows.Forms.Button btn_gawi;
        private System.Windows.Forms.Button btn_bo;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox rightPicBox;
        private System.Windows.Forms.PictureBox leftPicBox;
    }
}

