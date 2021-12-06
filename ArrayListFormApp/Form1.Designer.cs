
namespace ArrayListFormApp
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_List = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.listbox_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(12, 41);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 0;
            this.btn_Remove.Text = "Sil";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(12, 70);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "Düzenle";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(12, 99);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Ara";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_List
            // 
            this.btn_List.Location = new System.Drawing.Point(12, 128);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(75, 23);
            this.btn_List.TabIndex = 0;
            this.btn_List.Text = "Listele";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(12, 157);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Çıkış";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(104, 14);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(154, 20);
            this.txt_item.TabIndex = 1;
            // 
            // listbox_list
            // 
            this.listbox_list.FormattingEnabled = true;
            this.listbox_list.Location = new System.Drawing.Point(104, 40);
            this.listbox_list.Name = "listbox_list";
            this.listbox_list.Size = new System.Drawing.Size(154, 134);
            this.listbox_list.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 191);
            this.Controls.Add(this.listbox_list);
            this.Controls.Add(this.txt_item);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.ListBox listbox_list;
    }
}

