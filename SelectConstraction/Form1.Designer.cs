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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListWithRequests = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelWithElementForAddRequest = new System.Windows.Forms.Panel();
            this.NameRequest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddSelectToDB = new System.Windows.Forms.Button();
            this.Request = new System.Windows.Forms.RichTextBox();
            this.AddRequest = new System.Windows.Forms.Button();
            this.ChooseRequest = new System.Windows.Forms.Button();
            this.PanelWithArg = new System.Windows.Forms.Panel();
            this.DoRequest = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.Departments = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.ListWithRequests.SelectedIndexChanged += new System.EventHandler(this.ListWithRequests_SelectedIndexChanged);
            this.ListWithRequests.DoubleClick += new System.EventHandler(this.ListWithRequests_DoubleClick);
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
            this.PanelWithElementForAddRequest.Location = new System.Drawing.Point(515, 1);
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
            this.AddRequest.Location = new System.Drawing.Point(122, 194);
            this.AddRequest.Name = "AddRequest";
            this.AddRequest.Size = new System.Drawing.Size(110, 54);
            this.AddRequest.TabIndex = 3;
            this.AddRequest.Text = "Добавить запрос";
            this.AddRequest.UseVisualStyleBackColor = true;
            this.AddRequest.Click += new System.EventHandler(this.AddRequest_Click);
            // 
            // ChooseRequest
            // 
            this.ChooseRequest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseRequest.Location = new System.Drawing.Point(8, 194);
            this.ChooseRequest.Name = "ChooseRequest";
            this.ChooseRequest.Size = new System.Drawing.Size(97, 54);
            this.ChooseRequest.TabIndex = 4;
            this.ChooseRequest.Text = "Выбрать запрос";
            this.ChooseRequest.UseVisualStyleBackColor = true;
            this.ChooseRequest.Click += new System.EventHandler(this.ChooseRequst_Click);
            // 
            // PanelWithArg
            // 
            this.PanelWithArg.AutoSize = true;
            this.PanelWithArg.Controls.Add(this.DoRequest);
            this.PanelWithArg.Location = new System.Drawing.Point(8, 255);
            this.PanelWithArg.Name = "PanelWithArg";
            this.PanelWithArg.Size = new System.Drawing.Size(395, 99);
            this.PanelWithArg.TabIndex = 5;
            this.PanelWithArg.Visible = false;
            // 
            // DoRequest
            // 
            this.DoRequest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoRequest.Location = new System.Drawing.Point(4, 41);
            this.DoRequest.Name = "DoRequest";
            this.DoRequest.Size = new System.Drawing.Size(120, 47);
            this.DoRequest.TabIndex = 6;
            this.DoRequest.Text = "Выполнить";
            this.DoRequest.UseVisualStyleBackColor = true;
            this.DoRequest.Click += new System.EventHandler(this.DoRequest_Click);
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(366, 196);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(110, 52);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(252, 196);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(82, 52);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // Departments
            // 
            this.Departments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Departments.FormattingEnabled = true;
            this.Departments.Location = new System.Drawing.Point(379, 20);
            this.Departments.Name = "Departments";
            this.Departments.Size = new System.Drawing.Size(121, 21);
            this.Departments.TabIndex = 6;
            this.Departments.SelectedIndexChanged += new System.EventHandler(this.Departments_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(296, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отдел";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(873, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Departments);
            this.Controls.Add(this.PanelWithArg);
            this.Controls.Add(this.ChooseRequest);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddRequest);
            this.Controls.Add(this.PanelWithElementForAddRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListWithRequests);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button ChooseRequest;
        private System.Windows.Forms.TextBox NameRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelWithArg;
        private System.Windows.Forms.Button DoRequest;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ComboBox Departments;
        private System.Windows.Forms.Label label4;
    }
}

