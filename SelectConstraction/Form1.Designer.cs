namespace SelectConstraction {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.ListWithRequests = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelWithElementForAddRequest = new System.Windows.Forms.Panel();
            this.NameRequest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddSelectToDB = new System.Windows.Forms.Button();
            this.Request = new System.Windows.Forms.RichTextBox();
            this.AddRequest = new System.Windows.Forms.Button();
            this.DoRequst = new System.Windows.Forms.Button();
            this.PanelWithArg = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelWithElementForAddRequest.SuspendLayout();
            this.PanelWithArg.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListWithRequests
            // 
            this.ListWithRequests.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListWithRequests.FormattingEnabled = true;
            this.ListWithRequests.ItemHeight = 20;
            this.ListWithRequests.Location = new System.Drawing.Point(8, 46);
            this.ListWithRequests.Name = "ListWithRequests";
            this.ListWithRequests.Size = new System.Drawing.Size(255, 144);
            this.ListWithRequests.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Названия запросов";
            // 
            // PanelWithElementForAddRequest
            // 
            this.PanelWithElementForAddRequest.Controls.Add(this.NameRequest);
            this.PanelWithElementForAddRequest.Controls.Add(this.label3);
            this.PanelWithElementForAddRequest.Controls.Add(this.label2);
            this.PanelWithElementForAddRequest.Controls.Add(this.AddSelectToDB);
            this.PanelWithElementForAddRequest.Controls.Add(this.Request);
            this.PanelWithElementForAddRequest.Location = new System.Drawing.Point(406, 0);
            this.PanelWithElementForAddRequest.Name = "PanelWithElementForAddRequest";
            this.PanelWithElementForAddRequest.Size = new System.Drawing.Size(355, 474);
            this.PanelWithElementForAddRequest.TabIndex = 2;
            this.PanelWithElementForAddRequest.Visible = false;
            // 
            // NameRequest
            // 
            this.NameRequest.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameRequest.Location = new System.Drawing.Point(130, 13);
            this.NameRequest.Name = "NameRequest";
            this.NameRequest.Size = new System.Drawing.Size(139, 27);
            this.NameRequest.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Содержимое запроса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя запроса:";
            // 
            // AddSelectToDB
            // 
            this.AddSelectToDB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSelectToDB.Location = new System.Drawing.Point(241, 427);
            this.AddSelectToDB.Name = "AddSelectToDB";
            this.AddSelectToDB.Size = new System.Drawing.Size(106, 41);
            this.AddSelectToDB.TabIndex = 1;
            this.AddSelectToDB.Text = "Добавить";
            this.AddSelectToDB.UseVisualStyleBackColor = true;
            this.AddSelectToDB.Click += new System.EventHandler(this.AddSelectToDB_Click);
            // 
            // Request
            // 
            this.Request.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Request.Location = new System.Drawing.Point(3, 79);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(344, 342);
            this.Request.TabIndex = 0;
            this.Request.Text = "";
            // 
            // AddRequest
            // 
            this.AddRequest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRequest.Location = new System.Drawing.Point(203, 194);
            this.AddRequest.Name = "AddRequest";
            this.AddRequest.Size = new System.Drawing.Size(146, 51);
            this.AddRequest.TabIndex = 3;
            this.AddRequest.Text = "Добавить запрос";
            this.AddRequest.UseVisualStyleBackColor = true;
            this.AddRequest.Click += new System.EventHandler(this.AddRequest_Click);
            // 
            // DoRequst
            // 
            this.DoRequst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoRequst.Location = new System.Drawing.Point(8, 194);
            this.DoRequst.Name = "DoRequst";
            this.DoRequst.Size = new System.Drawing.Size(146, 54);
            this.DoRequst.TabIndex = 4;
            this.DoRequst.Text = "Выполнить запрос";
            this.DoRequst.UseVisualStyleBackColor = true;
            // 
            // PanelWithArg
            // 
            this.PanelWithArg.Controls.Add(this.button1);
            this.PanelWithArg.Location = new System.Drawing.Point(8, 255);
            this.PanelWithArg.Name = "PanelWithArg";
            this.PanelWithArg.Size = new System.Drawing.Size(395, 219);
            this.PanelWithArg.TabIndex = 5;
            this.PanelWithArg.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(756, 472);
            this.Controls.Add(this.PanelWithArg);
            this.Controls.Add(this.DoRequst);
            this.Controls.Add(this.AddRequest);
            this.Controls.Add(this.PanelWithElementForAddRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListWithRequests);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelWithElementForAddRequest.ResumeLayout(false);
            this.PanelWithElementForAddRequest.PerformLayout();
            this.PanelWithArg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListWithRequests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelWithElementForAddRequest;
        private System.Windows.Forms.Button AddSelectToDB;
        private System.Windows.Forms.RichTextBox Request;
        private System.Windows.Forms.Button AddRequest;
        private System.Windows.Forms.Button DoRequst;
        private System.Windows.Forms.TextBox NameRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelWithArg;
        private System.Windows.Forms.Button button1;
    }
}

