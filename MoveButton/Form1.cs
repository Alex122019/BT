using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoveButton
{
    public partial class Form1 : Form
    {

        public Form1()
        {
           

            InitializeComponent();
        }
        bool isDrag = false;
        
        private void treeView1_DragLeave(object sender, EventArgs e)
        {
            isDrag = true;

        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            TreeNode treeView1Node = ((TreeView)sender).GetNodeAt(pt);
            treeView1.SelectedNode = treeView1Node;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                string FBC = treeView1.SelectedNode.Text;
                if (FBC == "Кнопка")
                {
                    MyButton btn = new MyButton();
                    btn.Name = "НоваяКнопка";
                    btn.SetBounds(e.X, e.Y, 135, 25);
                    btn.Text = "Новая кнопка";
                    //   btn.Click += new EventHandler(this.myButton1_Click);
                    this.Controls.Add(btn);
                }
                if (FBC == "Реквизит")
                {
                    РеквизитКакЮзерКОнтрол btn = new РеквизитКакЮзерКОнтрол();
                    btn.Name = "НовыйРеквизит";
                    btn.SetBounds(e.X, e.Y, 430, 25);
                    btn.Text = "Новый реквизит";
                    //   btn.Click += new EventHandler(this.myButton1_Click);
                    this.Controls.Add(btn);
                }
                isDrag = false;
            }
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DoDragDrop(e.Item, DragDropEffects.Move);
            else if (e.Button == MouseButtons.Right)
                DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void ВыполнитьКодЭски_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сюда сообщение");
        }
    }
}
