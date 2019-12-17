namespace MoveButton
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Реквизит");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Кнопка");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Элементы управления", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Справочники");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Документы");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Константы");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ВыполнитьКодЭски = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(688, -1);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "Реквизит";
            treeNode7.Text = "Реквизит";
            treeNode8.Name = "Кнопка";
            treeNode8.Text = "Кнопка";
            treeNode9.Name = "ЭлементыУправления";
            treeNode9.Text = "Элементы управления";
            treeNode10.Name = "Справочники";
            treeNode10.Text = "Справочники";
            treeNode11.Name = "Документы";
            treeNode11.Text = "Документы";
            treeNode12.Name = "Константы";
            treeNode12.Text = "Константы";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(211, 452);
            this.treeView1.TabIndex = 6;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.DragLeave += new System.EventHandler(this.treeView1_DragLeave);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // ВыполнитьКодЭски
            // 
            this.ВыполнитьКодЭски.Location = new System.Drawing.Point(123, 315);
            this.ВыполнитьКодЭски.Name = "ВыполнитьКодЭски";
            this.ВыполнитьКодЭски.Size = new System.Drawing.Size(513, 23);
            this.ВыполнитьКодЭски.TabIndex = 7;
            this.ВыполнитьКодЭски.Text = "ПО этой кнопке выполнить функцию 1С возвращенное значение показать в MessageBox";
            this.ВыполнитьКодЭски.UseVisualStyleBackColor = true;
            this.ВыполнитьКодЭски.Click += new System.EventHandler(this.ВыполнитьКодЭски_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 454);
            this.Controls.Add(this.ВыполнитьКодЭски);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button ВыполнитьКодЭски;
    }
}

