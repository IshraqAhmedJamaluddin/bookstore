
namespace file_organization_project
{
    partial class bookstore
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-209, -81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Name";
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(334, 79);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(193, 27);
            this.filename.TabIndex = 2;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(130, 174);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(111, 29);
            this.create.TabIndex = 3;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(422, 174);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(116, 29);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(130, 243);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(111, 29);
            this.insert.TabIndex = 5;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(422, 243);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(116, 29);
            this.display.TabIndex = 6;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(130, 310);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(111, 29);
            this.search.TabIndex = 7;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(422, 310);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(116, 29);
            this.modify.TabIndex = 8;
            this.modify.Text = "Modify";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(287, 382);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 29);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = ".txt";
            // 
            // bookstore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.search);
            this.Controls.Add(this.display);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.create);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bookstore";
            this.Text = "Bookstore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label3;
    }
}

