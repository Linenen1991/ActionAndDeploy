namespace ActionAndDeploy
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listbox_Stack = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_AddItem = new System.Windows.Forms.TextBox();
            this.btn_Pop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbox_Stack
            // 
            this.listbox_Stack.FormattingEnabled = true;
            this.listbox_Stack.ItemHeight = 15;
            this.listbox_Stack.Location = new System.Drawing.Point(12, 73);
            this.listbox_Stack.Name = "listbox_Stack";
            this.listbox_Stack.Size = new System.Drawing.Size(155, 379);
            this.listbox_Stack.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stack";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(173, 392);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(122, 60);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Push";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_AddItem
            // 
            this.tb_AddItem.Location = new System.Drawing.Point(173, 361);
            this.tb_AddItem.Name = "tb_AddItem";
            this.tb_AddItem.Size = new System.Drawing.Size(122, 25);
            this.tb_AddItem.TabIndex = 3;
            // 
            // btn_Pop
            // 
            this.btn_Pop.Location = new System.Drawing.Point(173, 9);
            this.btn_Pop.Name = "btn_Pop";
            this.btn_Pop.Size = new System.Drawing.Size(122, 60);
            this.btn_Pop.TabIndex = 4;
            this.btn_Pop.Text = "Pop";
            this.btn_Pop.UseVisualStyleBackColor = true;
            this.btn_Pop.Click += new System.EventHandler(this.btn_Pop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 464);
            this.Controls.Add(this.btn_Pop);
            this.Controls.Add(this.tb_AddItem);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_Stack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_Stack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_AddItem;
        private System.Windows.Forms.Button btn_Pop;
    }
}

