﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W5_B6_B1_Chuong6_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addNode();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Text.ElementAt(0) == textBox1.Text.ToString().ElementAt(0))
                {
                    TreeNode n = new TreeNode(textBox1.Text + "," + textBox2.Text);
                    n.ImageIndex = 0;
                    node.Nodes.Add(n);
                }
            }
        }
        private void searchNode()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                if (textBox1.Text.Equals(i))
                {
                    if (treeView1.SelectedNode.Name.Equals(i))
                    {
                        
                     }
                }
            }
        }
        private void addNode()
        {
            
            for (char i = 'A'; i <= 'Z'; i++)
            {
                treeView1.Nodes.Add(i.ToString());
            }
        }
        
    }
}
