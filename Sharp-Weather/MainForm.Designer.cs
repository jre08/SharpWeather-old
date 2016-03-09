
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
//
// Created by SharpDevelop.
// User: edenfield-john
// Date: 10/6/2015
// Time: 4:10 PM
// 
// To change this template use Tools | Options | Coding | Edit Standard Headers.
//
partial class MainForm : System.Windows.Forms.Form
{

	/// <summary>
	/// Designer variable used to keep track of non-visual components.
	/// </summary>
	private System.ComponentModel.IContainer components;

	/// <summary>
	/// Disposes resources used by the form.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing) {
			if (components != null) {
				components.Dispose();
			}
		}
		base.Dispose(disposing);
	}

	/// <summary>
	/// This method is required for Windows Forms designer support.
	/// Do not change the method contents inside the source code editor. The Forms designer might
	/// not be able to load this method if it was changed manually.
	/// </summary>
	private void InitializeComponent()
	{
		this.panel1 = new System.Windows.Forms.Panel();
		this.picboxN1 = new System.Windows.Forms.PictureBox();
		this.picboxD1 = new System.Windows.Forms.PictureBox();
		this.lblN1pop = new System.Windows.Forms.Label();
		this.lblD1pop = new System.Windows.Forms.Label();
		this.lblN1desc = new System.Windows.Forms.Label();
		this.lblD1desc = new System.Windows.Forms.Label();
		this.lblN1 = new System.Windows.Forms.Label();
		this.lblD1 = new System.Windows.Forms.Label();
		this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.picboxN2 = new System.Windows.Forms.PictureBox();
		this.picboxD2 = new System.Windows.Forms.PictureBox();
		this.lblN2pop = new System.Windows.Forms.Label();
		this.lblD2pop = new System.Windows.Forms.Label();
		this.lblN2desc = new System.Windows.Forms.Label();
		this.lblD2desc = new System.Windows.Forms.Label();
		this.lblN2 = new System.Windows.Forms.Label();
		this.lblD2 = new System.Windows.Forms.Label();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.picboxN3 = new System.Windows.Forms.PictureBox();
		this.picboxD3 = new System.Windows.Forms.PictureBox();
		this.lblN3pop = new System.Windows.Forms.Label();
		this.lblD3pop = new System.Windows.Forms.Label();
		this.lblN3desc = new System.Windows.Forms.Label();
		this.lblD3desc = new System.Windows.Forms.Label();
		this.lblN3 = new System.Windows.Forms.Label();
		this.lblD3 = new System.Windows.Forms.Label();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.picboxN4 = new System.Windows.Forms.PictureBox();
		this.picboxD4 = new System.Windows.Forms.PictureBox();
		this.lblN4pop = new System.Windows.Forms.Label();
		this.lblD4pop = new System.Windows.Forms.Label();
		this.lblN4desc = new System.Windows.Forms.Label();
		this.lblD4desc = new System.Windows.Forms.Label();
		this.lblN4 = new System.Windows.Forms.Label();
		this.lblD4 = new System.Windows.Forms.Label();
		this.pictureBox4 = new System.Windows.Forms.PictureBox();
		this.WEBmapbrowser = new System.Windows.Forms.WebBrowser();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.button3 = new System.Windows.Forms.Button();
		this.tabPage4 = new System.Windows.Forms.TabPage();
		this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
		this.panel5 = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.pictureBox2 = new System.Windows.Forms.PictureBox();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.panel6 = new System.Windows.Forms.Panel();
		this.pictureBox3 = new System.Windows.Forms.PictureBox();
		this.pictureBox5 = new System.Windows.Forms.PictureBox();
		this.label8 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.panel7 = new System.Windows.Forms.Panel();
		this.pictureBox6 = new System.Windows.Forms.PictureBox();
		this.pictureBox7 = new System.Windows.Forms.PictureBox();
		this.label14 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.label18 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.panel8 = new System.Windows.Forms.Panel();
		this.pictureBox8 = new System.Windows.Forms.PictureBox();
		this.pictureBox9 = new System.Windows.Forms.PictureBox();
		this.label20 = new System.Windows.Forms.Label();
		this.label21 = new System.Windows.Forms.Label();
		this.label22 = new System.Windows.Forms.Label();
		this.label23 = new System.Windows.Forms.Label();
		this.label24 = new System.Windows.Forms.Label();
		this.label25 = new System.Windows.Forms.Label();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.picboxN1)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD1)).BeginInit();
		this.flowLayoutPanel1.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.picboxN2)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD2)).BeginInit();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.picboxN3)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD3)).BeginInit();
		this.Panel4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.picboxN4)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD4)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.tabPage2.SuspendLayout();
		this.tabPage4.SuspendLayout();
		this.flowLayoutPanel2.SuspendLayout();
		this.panel5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
		this.panel6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
		this.panel7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
		this.panel8.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
		this.SuspendLayout();
		// 
		// panel1
		// 
		this.panel1.AutoScroll = true;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.picboxN1);
		this.panel1.Controls.Add(this.picboxD1);
		this.panel1.Controls.Add(this.lblN1pop);
		this.panel1.Controls.Add(this.lblD1pop);
		this.panel1.Controls.Add(this.lblN1desc);
		this.panel1.Controls.Add(this.lblD1desc);
		this.panel1.Controls.Add(this.lblN1);
		this.panel1.Controls.Add(this.lblD1);
		this.panel1.Location = new System.Drawing.Point(3, 3);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(289, 372);
		this.panel1.TabIndex = 1;
		// 
		// picboxN1
		// 
		this.picboxN1.Location = new System.Drawing.Point(3, 221);
		this.picboxN1.Name = "picboxN1";
		this.picboxN1.Size = new System.Drawing.Size(100, 50);
		this.picboxN1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxN1.TabIndex = 1;
		this.picboxN1.TabStop = false;
		// 
		// picboxD1
		// 
		this.picboxD1.Location = new System.Drawing.Point(3, 28);
		this.picboxD1.Name = "picboxD1";
		this.picboxD1.Size = new System.Drawing.Size(100, 50);
		this.picboxD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxD1.TabIndex = 1;
		this.picboxD1.TabStop = false;
		// 
		// lblN1pop
		// 
		this.lblN1pop.AutoSize = true;
		this.lblN1pop.Location = new System.Drawing.Point(0, 330);
		this.lblN1pop.Name = "lblN1pop";
		this.lblN1pop.Size = new System.Drawing.Size(124, 13);
		this.lblN1pop.TabIndex = 0;
		this.lblN1pop.Text = "Chance of Precepitation:";
		// 
		// lblD1pop
		// 
		this.lblD1pop.AutoSize = true;
		this.lblD1pop.Location = new System.Drawing.Point(3, 137);
		this.lblD1pop.Name = "lblD1pop";
		this.lblD1pop.Size = new System.Drawing.Size(124, 13);
		this.lblD1pop.TabIndex = 0;
		this.lblD1pop.Text = "Chance of Precepitation:";
		// 
		// lblN1desc
		// 
		this.lblN1desc.Location = new System.Drawing.Point(0, 274);
		this.lblN1desc.Name = "lblN1desc";
		this.lblN1desc.Size = new System.Drawing.Size(173, 56);
		this.lblN1desc.TabIndex = 0;
		this.lblN1desc.Text = "Night one Desc.";
		// 
		// lblD1desc
		// 
		this.lblD1desc.Location = new System.Drawing.Point(3, 81);
		this.lblD1desc.Name = "lblD1desc";
		this.lblD1desc.Size = new System.Drawing.Size(173, 56);
		this.lblD1desc.TabIndex = 0;
		this.lblD1desc.Text = "Day one Desc.";
		// 
		// lblN1
		// 
		this.lblN1.AutoSize = true;
		this.lblN1.Location = new System.Drawing.Point(3, 205);
		this.lblN1.Name = "lblN1";
		this.lblN1.Size = new System.Drawing.Size(38, 13);
		this.lblN1.TabIndex = 0;
		this.lblN1.Text = "Night1";
		// 
		// lblD1
		// 
		this.lblD1.AutoSize = true;
		this.lblD1.Location = new System.Drawing.Point(3, 12);
		this.lblD1.Name = "lblD1";
		this.lblD1.Size = new System.Drawing.Size(32, 13);
		this.lblD1.TabIndex = 0;
		this.lblD1.Text = "Day1";
		// 
		// flowLayoutPanel1
		// 
		this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
		this.flowLayoutPanel1.AutoScroll = true;
		this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.flowLayoutPanel1.Controls.Add(this.panel1);
		this.flowLayoutPanel1.Controls.Add(this.Panel2);
		this.flowLayoutPanel1.Controls.Add(this.Panel3);
		this.flowLayoutPanel1.Controls.Add(this.Panel4);
		this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 6);
		this.flowLayoutPanel1.Name = "flowLayoutPanel1";
		this.flowLayoutPanel1.Size = new System.Drawing.Size(316, 477);
		this.flowLayoutPanel1.TabIndex = 2;
		// 
		// Panel2
		// 
		this.Panel2.AutoScroll = true;
		this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel2.Controls.Add(this.picboxN2);
		this.Panel2.Controls.Add(this.picboxD2);
		this.Panel2.Controls.Add(this.lblN2pop);
		this.Panel2.Controls.Add(this.lblD2pop);
		this.Panel2.Controls.Add(this.lblN2desc);
		this.Panel2.Controls.Add(this.lblD2desc);
		this.Panel2.Controls.Add(this.lblN2);
		this.Panel2.Controls.Add(this.lblD2);
		this.Panel2.Location = new System.Drawing.Point(3, 381);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(289, 372);
		this.Panel2.TabIndex = 1;
		// 
		// picboxN2
		// 
		this.picboxN2.Location = new System.Drawing.Point(3, 221);
		this.picboxN2.Name = "picboxN2";
		this.picboxN2.Size = new System.Drawing.Size(100, 50);
		this.picboxN2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxN2.TabIndex = 1;
		this.picboxN2.TabStop = false;
		// 
		// picboxD2
		// 
		this.picboxD2.Location = new System.Drawing.Point(3, 28);
		this.picboxD2.Name = "picboxD2";
		this.picboxD2.Size = new System.Drawing.Size(100, 50);
		this.picboxD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxD2.TabIndex = 1;
		this.picboxD2.TabStop = false;
		// 
		// lblN2pop
		// 
		this.lblN2pop.AutoSize = true;
		this.lblN2pop.Location = new System.Drawing.Point(0, 330);
		this.lblN2pop.Name = "lblN2pop";
		this.lblN2pop.Size = new System.Drawing.Size(124, 13);
		this.lblN2pop.TabIndex = 0;
		this.lblN2pop.Text = "Chance of Precepitation:";
		// 
		// lblD2pop
		// 
		this.lblD2pop.AutoSize = true;
		this.lblD2pop.Location = new System.Drawing.Point(3, 137);
		this.lblD2pop.Name = "lblD2pop";
		this.lblD2pop.Size = new System.Drawing.Size(124, 13);
		this.lblD2pop.TabIndex = 0;
		this.lblD2pop.Text = "Chance of Precepitation:";
		// 
		// lblN2desc
		// 
		this.lblN2desc.Location = new System.Drawing.Point(0, 274);
		this.lblN2desc.Name = "lblN2desc";
		this.lblN2desc.Size = new System.Drawing.Size(173, 56);
		this.lblN2desc.TabIndex = 0;
		this.lblN2desc.Text = "Night 2 Desc.";
		// 
		// lblD2desc
		// 
		this.lblD2desc.Location = new System.Drawing.Point(3, 81);
		this.lblD2desc.Name = "lblD2desc";
		this.lblD2desc.Size = new System.Drawing.Size(173, 56);
		this.lblD2desc.TabIndex = 0;
		this.lblD2desc.Text = "Day 2 Desc.";
		// 
		// lblN2
		// 
		this.lblN2.AutoSize = true;
		this.lblN2.Location = new System.Drawing.Point(3, 205);
		this.lblN2.Name = "lblN2";
		this.lblN2.Size = new System.Drawing.Size(38, 13);
		this.lblN2.TabIndex = 0;
		this.lblN2.Text = "Night2";
		// 
		// lblD2
		// 
		this.lblD2.AutoSize = true;
		this.lblD2.Location = new System.Drawing.Point(3, 12);
		this.lblD2.Name = "lblD2";
		this.lblD2.Size = new System.Drawing.Size(32, 13);
		this.lblD2.TabIndex = 0;
		this.lblD2.Text = "Day2";
		// 
		// Panel3
		// 
		this.Panel3.AutoScroll = true;
		this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel3.Controls.Add(this.picboxN3);
		this.Panel3.Controls.Add(this.picboxD3);
		this.Panel3.Controls.Add(this.lblN3pop);
		this.Panel3.Controls.Add(this.lblD3pop);
		this.Panel3.Controls.Add(this.lblN3desc);
		this.Panel3.Controls.Add(this.lblD3desc);
		this.Panel3.Controls.Add(this.lblN3);
		this.Panel3.Controls.Add(this.lblD3);
		this.Panel3.Location = new System.Drawing.Point(3, 759);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(289, 372);
		this.Panel3.TabIndex = 2;
		// 
		// picboxN3
		// 
		this.picboxN3.Location = new System.Drawing.Point(3, 221);
		this.picboxN3.Name = "picboxN3";
		this.picboxN3.Size = new System.Drawing.Size(100, 50);
		this.picboxN3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxN3.TabIndex = 1;
		this.picboxN3.TabStop = false;
		// 
		// picboxD3
		// 
		this.picboxD3.Location = new System.Drawing.Point(3, 28);
		this.picboxD3.Name = "picboxD3";
		this.picboxD3.Size = new System.Drawing.Size(100, 50);
		this.picboxD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxD3.TabIndex = 1;
		this.picboxD3.TabStop = false;
		// 
		// lblN3pop
		// 
		this.lblN3pop.AutoSize = true;
		this.lblN3pop.Location = new System.Drawing.Point(0, 330);
		this.lblN3pop.Name = "lblN3pop";
		this.lblN3pop.Size = new System.Drawing.Size(124, 13);
		this.lblN3pop.TabIndex = 0;
		this.lblN3pop.Text = "Chance of Precepitation:";
		// 
		// lblD3pop
		// 
		this.lblD3pop.AutoSize = true;
		this.lblD3pop.Location = new System.Drawing.Point(3, 137);
		this.lblD3pop.Name = "lblD3pop";
		this.lblD3pop.Size = new System.Drawing.Size(124, 13);
		this.lblD3pop.TabIndex = 0;
		this.lblD3pop.Text = "Chance of Precepitation:";
		// 
		// lblN3desc
		// 
		this.lblN3desc.Location = new System.Drawing.Point(0, 274);
		this.lblN3desc.Name = "lblN3desc";
		this.lblN3desc.Size = new System.Drawing.Size(173, 56);
		this.lblN3desc.TabIndex = 0;
		this.lblN3desc.Text = "Night 3 Desc.";
		// 
		// lblD3desc
		// 
		this.lblD3desc.Location = new System.Drawing.Point(3, 81);
		this.lblD3desc.Name = "lblD3desc";
		this.lblD3desc.Size = new System.Drawing.Size(173, 56);
		this.lblD3desc.TabIndex = 0;
		this.lblD3desc.Text = "Day 3 Desc.";
		// 
		// lblN3
		// 
		this.lblN3.AutoSize = true;
		this.lblN3.Location = new System.Drawing.Point(3, 205);
		this.lblN3.Name = "lblN3";
		this.lblN3.Size = new System.Drawing.Size(38, 13);
		this.lblN3.TabIndex = 0;
		this.lblN3.Text = "Night3";
		// 
		// lblD3
		// 
		this.lblD3.AutoSize = true;
		this.lblD3.Location = new System.Drawing.Point(3, 12);
		this.lblD3.Name = "lblD3";
		this.lblD3.Size = new System.Drawing.Size(32, 13);
		this.lblD3.TabIndex = 0;
		this.lblD3.Text = "Day3";
		// 
		// Panel4
		// 
		this.Panel4.AutoScroll = true;
		this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel4.Controls.Add(this.picboxN4);
		this.Panel4.Controls.Add(this.picboxD4);
		this.Panel4.Controls.Add(this.lblN4pop);
		this.Panel4.Controls.Add(this.lblD4pop);
		this.Panel4.Controls.Add(this.lblN4desc);
		this.Panel4.Controls.Add(this.lblD4desc);
		this.Panel4.Controls.Add(this.lblN4);
		this.Panel4.Controls.Add(this.lblD4);
		this.Panel4.Location = new System.Drawing.Point(3, 1137);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(289, 372);
		this.Panel4.TabIndex = 3;
		// 
		// picboxN4
		// 
		this.picboxN4.Location = new System.Drawing.Point(3, 221);
		this.picboxN4.Name = "picboxN4";
		this.picboxN4.Size = new System.Drawing.Size(100, 50);
		this.picboxN4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxN4.TabIndex = 1;
		this.picboxN4.TabStop = false;
		// 
		// picboxD4
		// 
		this.picboxD4.Location = new System.Drawing.Point(3, 28);
		this.picboxD4.Name = "picboxD4";
		this.picboxD4.Size = new System.Drawing.Size(100, 50);
		this.picboxD4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxD4.TabIndex = 1;
		this.picboxD4.TabStop = false;
		// 
		// lblN4pop
		// 
		this.lblN4pop.AutoSize = true;
		this.lblN4pop.Location = new System.Drawing.Point(0, 330);
		this.lblN4pop.Name = "lblN4pop";
		this.lblN4pop.Size = new System.Drawing.Size(124, 13);
		this.lblN4pop.TabIndex = 0;
		this.lblN4pop.Text = "Chance of Precepitation:";
		// 
		// lblD4pop
		// 
		this.lblD4pop.AutoSize = true;
		this.lblD4pop.Location = new System.Drawing.Point(3, 137);
		this.lblD4pop.Name = "lblD4pop";
		this.lblD4pop.Size = new System.Drawing.Size(124, 13);
		this.lblD4pop.TabIndex = 0;
		this.lblD4pop.Text = "Chance of Precepitation:";
		// 
		// lblN4desc
		// 
		this.lblN4desc.Location = new System.Drawing.Point(0, 274);
		this.lblN4desc.Name = "lblN4desc";
		this.lblN4desc.Size = new System.Drawing.Size(173, 56);
		this.lblN4desc.TabIndex = 0;
		this.lblN4desc.Text = "Night 4 Desc.";
		// 
		// lblD4desc
		// 
		this.lblD4desc.Location = new System.Drawing.Point(3, 81);
		this.lblD4desc.Name = "lblD4desc";
		this.lblD4desc.Size = new System.Drawing.Size(173, 56);
		this.lblD4desc.TabIndex = 0;
		this.lblD4desc.Text = "Day 4 Desc.";
		// 
		// lblN4
		// 
		this.lblN4.AutoSize = true;
		this.lblN4.Location = new System.Drawing.Point(3, 205);
		this.lblN4.Name = "lblN4";
		this.lblN4.Size = new System.Drawing.Size(38, 13);
		this.lblN4.TabIndex = 0;
		this.lblN4.Text = "Night4";
		// 
		// lblD4
		// 
		this.lblD4.AutoSize = true;
		this.lblD4.Location = new System.Drawing.Point(3, 12);
		this.lblD4.Name = "lblD4";
		this.lblD4.Size = new System.Drawing.Size(32, 13);
		this.lblD4.TabIndex = 0;
		this.lblD4.Text = "Day4";
		// 
		// pictureBox4
		// 
		this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
		this.pictureBox4.Location = new System.Drawing.Point(337, 9);
		this.pictureBox4.Name = "pictureBox4";
		this.pictureBox4.Size = new System.Drawing.Size(672, 474);
		this.pictureBox4.TabIndex = 1;
		this.pictureBox4.TabStop = false;
		// 
		// WEBmapbrowser
		// 
		this.WEBmapbrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
		this.WEBmapbrowser.Location = new System.Drawing.Point(6, 6);
		this.WEBmapbrowser.MinimumSize = new System.Drawing.Size(20, 20);
		this.WEBmapbrowser.Name = "WEBmapbrowser";
		this.WEBmapbrowser.Size = new System.Drawing.Size(987, 466);
		this.WEBmapbrowser.TabIndex = 3;
		// 
		// tabControl1
		// 
		this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.TabPage3);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Controls.Add(this.tabPage4);
		this.tabControl1.Location = new System.Drawing.Point(12, 12);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(1023, 525);
		this.tabControl1.TabIndex = 4;
		// 
		// tabPage1
		// 
		this.tabPage1.Controls.Add(this.flowLayoutPanel1);
		this.tabPage1.Controls.Add(this.pictureBox4);
		this.tabPage1.Location = new System.Drawing.Point(4, 22);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(1015, 499);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "4 Day Forecast";
		this.tabPage1.UseVisualStyleBackColor = true;
		// 
		// TabPage3
		// 
		this.TabPage3.Controls.Add(this.gMapControl);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(999, 501);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "10 Day Forecast";
		this.TabPage3.UseVisualStyleBackColor = true;
		// 
		// gMapControl
		// 
		this.gMapControl.Bearing = 0F;
		this.gMapControl.CanDragMap = true;
		this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
		this.gMapControl.GrayScaleMode = false;
		this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
		this.gMapControl.LevelsKeepInMemmory = 5;
		this.gMapControl.Location = new System.Drawing.Point(22, 17);
		this.gMapControl.MarkersEnabled = true;
		this.gMapControl.MaxZoom = 17;
		this.gMapControl.MinZoom = 3;
		this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
		this.gMapControl.Name = "gMapControl";
		this.gMapControl.NegativeMode = false;
		this.gMapControl.PolygonsEnabled = true;
		this.gMapControl.RetryLoadTile = 0;
		this.gMapControl.RoutesEnabled = true;
		this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
		this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
		this.gMapControl.ShowTileGridLines = false;
		this.gMapControl.Size = new System.Drawing.Size(964, 469);
		this.gMapControl.TabIndex = 0;
		this.gMapControl.Zoom = 3D;
		this.gMapControl.Load += new System.EventHandler(this.GMapControlLoad);
		// 
		// tabPage2
		// 
		this.tabPage2.Controls.Add(this.WEBmapbrowser);
		this.tabPage2.Location = new System.Drawing.Point(4, 22);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(999, 501);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "Radar Map";
		this.tabPage2.UseVisualStyleBackColor = true;
		// 
		// Button1
		// 
		this.Button1.Location = new System.Drawing.Point(16, 541);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 5;
		this.Button1.Text = "Button1";
		this.Button1.UseVisualStyleBackColor = true;
		// 
		// Button2
		// 
		this.Button2.Location = new System.Drawing.Point(107, 541);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(75, 23);
		this.Button2.TabIndex = 5;
		this.Button2.Text = "Button1";
		this.Button2.UseVisualStyleBackColor = true;
		// 
		// label1
		// 
		this.label1.Location = new System.Drawing.Point(188, 541);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(827, 23);
		this.label1.TabIndex = 6;
		this.label1.Text = "label1";
		// 
		// button3
		// 
		this.button3.Location = new System.Drawing.Point(657, 3);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(69, 25);
		this.button3.TabIndex = 7;
		this.button3.Text = "button3";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(this.Button3Click);
		// 
		// tabPage4
		// 
		this.tabPage4.Controls.Add(this.flowLayoutPanel2);
		this.tabPage4.Location = new System.Drawing.Point(4, 22);
		this.tabPage4.Name = "tabPage4";
		this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage4.Size = new System.Drawing.Size(1015, 499);
		this.tabPage4.TabIndex = 3;
		this.tabPage4.Text = "tabPage4";
		this.tabPage4.UseVisualStyleBackColor = true;
		// 
		// flowLayoutPanel2
		// 
		this.flowLayoutPanel2.AutoScroll = true;
		this.flowLayoutPanel2.Controls.Add(this.panel5);
		this.flowLayoutPanel2.Controls.Add(this.panel6);
		this.flowLayoutPanel2.Controls.Add(this.panel7);
		this.flowLayoutPanel2.Controls.Add(this.panel8);
		this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 6);
		this.flowLayoutPanel2.Name = "flowLayoutPanel2";
		this.flowLayoutPanel2.Size = new System.Drawing.Size(997, 401);
		this.flowLayoutPanel2.TabIndex = 0;
		this.flowLayoutPanel2.WrapContents = false;
		// 
		// panel5
		// 
		this.panel5.AutoScroll = true;
		this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel5.Controls.Add(this.pictureBox1);
		this.panel5.Controls.Add(this.pictureBox2);
		this.panel5.Controls.Add(this.label2);
		this.panel5.Controls.Add(this.label3);
		this.panel5.Controls.Add(this.label4);
		this.panel5.Controls.Add(this.label5);
		this.panel5.Controls.Add(this.label6);
		this.panel5.Controls.Add(this.label7);
		this.panel5.Location = new System.Drawing.Point(3, 3);
		this.panel5.Name = "panel5";
		this.panel5.Size = new System.Drawing.Size(289, 372);
		this.panel5.TabIndex = 2;
		// 
		// pictureBox1
		// 
		this.pictureBox1.Location = new System.Drawing.Point(3, 221);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(100, 50);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox1.TabIndex = 1;
		this.pictureBox1.TabStop = false;
		// 
		// pictureBox2
		// 
		this.pictureBox2.Location = new System.Drawing.Point(3, 28);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new System.Drawing.Size(100, 50);
		this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox2.TabIndex = 1;
		this.pictureBox2.TabStop = false;
		// 
		// label2
		// 
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(0, 330);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(124, 13);
		this.label2.TabIndex = 0;
		this.label2.Text = "Chance of Precepitation:";
		// 
		// label3
		// 
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(3, 137);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(124, 13);
		this.label3.TabIndex = 0;
		this.label3.Text = "Chance of Precepitation:";
		// 
		// label4
		// 
		this.label4.Location = new System.Drawing.Point(0, 274);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(173, 56);
		this.label4.TabIndex = 0;
		this.label4.Text = "Night one Desc.";
		// 
		// label5
		// 
		this.label5.Location = new System.Drawing.Point(3, 0);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(173, 56);
		this.label5.TabIndex = 0;
		this.label5.Text = "Day one Desc.";
		// 
		// label6
		// 
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(3, 205);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(38, 13);
		this.label6.TabIndex = 0;
		this.label6.Text = "Night1";
		// 
		// label7
		// 
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(3, 12);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(32, 13);
		this.label7.TabIndex = 0;
		this.label7.Text = "Day1";
		// 
		// panel6
		// 
		this.panel6.AutoScroll = true;
		this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel6.Controls.Add(this.pictureBox3);
		this.panel6.Controls.Add(this.pictureBox5);
		this.panel6.Controls.Add(this.label8);
		this.panel6.Controls.Add(this.label9);
		this.panel6.Controls.Add(this.label10);
		this.panel6.Controls.Add(this.label11);
		this.panel6.Controls.Add(this.label12);
		this.panel6.Controls.Add(this.label13);
		this.panel6.Location = new System.Drawing.Point(298, 3);
		this.panel6.Name = "panel6";
		this.panel6.Size = new System.Drawing.Size(289, 372);
		this.panel6.TabIndex = 3;
		// 
		// pictureBox3
		// 
		this.pictureBox3.Location = new System.Drawing.Point(3, 221);
		this.pictureBox3.Name = "pictureBox3";
		this.pictureBox3.Size = new System.Drawing.Size(100, 50);
		this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox3.TabIndex = 1;
		this.pictureBox3.TabStop = false;
		// 
		// pictureBox5
		// 
		this.pictureBox5.Location = new System.Drawing.Point(3, 28);
		this.pictureBox5.Name = "pictureBox5";
		this.pictureBox5.Size = new System.Drawing.Size(100, 50);
		this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox5.TabIndex = 1;
		this.pictureBox5.TabStop = false;
		// 
		// label8
		// 
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(0, 330);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(124, 13);
		this.label8.TabIndex = 0;
		this.label8.Text = "Chance of Precepitation:";
		// 
		// label9
		// 
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(3, 137);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(124, 13);
		this.label9.TabIndex = 0;
		this.label9.Text = "Chance of Precepitation:";
		// 
		// label10
		// 
		this.label10.Location = new System.Drawing.Point(0, 274);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(173, 56);
		this.label10.TabIndex = 0;
		this.label10.Text = "Night one Desc.";
		// 
		// label11
		// 
		this.label11.Location = new System.Drawing.Point(3, 0);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(173, 56);
		this.label11.TabIndex = 0;
		this.label11.Text = "Day one Desc.";
		// 
		// label12
		// 
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(3, 205);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(38, 13);
		this.label12.TabIndex = 0;
		this.label12.Text = "Night1";
		// 
		// label13
		// 
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(3, 12);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(32, 13);
		this.label13.TabIndex = 0;
		this.label13.Text = "Day1";
		// 
		// panel7
		// 
		this.panel7.AutoScroll = true;
		this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel7.Controls.Add(this.pictureBox6);
		this.panel7.Controls.Add(this.pictureBox7);
		this.panel7.Controls.Add(this.label14);
		this.panel7.Controls.Add(this.label15);
		this.panel7.Controls.Add(this.label16);
		this.panel7.Controls.Add(this.label17);
		this.panel7.Controls.Add(this.label18);
		this.panel7.Controls.Add(this.label19);
		this.panel7.Location = new System.Drawing.Point(593, 3);
		this.panel7.Name = "panel7";
		this.panel7.Size = new System.Drawing.Size(289, 372);
		this.panel7.TabIndex = 4;
		// 
		// pictureBox6
		// 
		this.pictureBox6.Location = new System.Drawing.Point(3, 221);
		this.pictureBox6.Name = "pictureBox6";
		this.pictureBox6.Size = new System.Drawing.Size(100, 50);
		this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox6.TabIndex = 1;
		this.pictureBox6.TabStop = false;
		// 
		// pictureBox7
		// 
		this.pictureBox7.Location = new System.Drawing.Point(3, 28);
		this.pictureBox7.Name = "pictureBox7";
		this.pictureBox7.Size = new System.Drawing.Size(100, 50);
		this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox7.TabIndex = 1;
		this.pictureBox7.TabStop = false;
		// 
		// label14
		// 
		this.label14.AutoSize = true;
		this.label14.Location = new System.Drawing.Point(0, 330);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(124, 13);
		this.label14.TabIndex = 0;
		this.label14.Text = "Chance of Precepitation:";
		// 
		// label15
		// 
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(3, 137);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(124, 13);
		this.label15.TabIndex = 0;
		this.label15.Text = "Chance of Precepitation:";
		// 
		// label16
		// 
		this.label16.Location = new System.Drawing.Point(0, 274);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(173, 56);
		this.label16.TabIndex = 0;
		this.label16.Text = "Night one Desc.";
		// 
		// label17
		// 
		this.label17.Location = new System.Drawing.Point(3, 0);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(173, 56);
		this.label17.TabIndex = 0;
		this.label17.Text = "Day one Desc.";
		// 
		// label18
		// 
		this.label18.AutoSize = true;
		this.label18.Location = new System.Drawing.Point(3, 205);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(38, 13);
		this.label18.TabIndex = 0;
		this.label18.Text = "Night1";
		// 
		// label19
		// 
		this.label19.AutoSize = true;
		this.label19.Location = new System.Drawing.Point(3, 12);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(32, 13);
		this.label19.TabIndex = 0;
		this.label19.Text = "Day1";
		// 
		// panel8
		// 
		this.panel8.AutoScroll = true;
		this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel8.Controls.Add(this.pictureBox8);
		this.panel8.Controls.Add(this.pictureBox9);
		this.panel8.Controls.Add(this.label20);
		this.panel8.Controls.Add(this.label21);
		this.panel8.Controls.Add(this.label22);
		this.panel8.Controls.Add(this.label23);
		this.panel8.Controls.Add(this.label24);
		this.panel8.Controls.Add(this.label25);
		this.panel8.Location = new System.Drawing.Point(888, 3);
		this.panel8.Name = "panel8";
		this.panel8.Size = new System.Drawing.Size(289, 372);
		this.panel8.TabIndex = 5;
		// 
		// pictureBox8
		// 
		this.pictureBox8.Location = new System.Drawing.Point(3, 221);
		this.pictureBox8.Name = "pictureBox8";
		this.pictureBox8.Size = new System.Drawing.Size(100, 50);
		this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox8.TabIndex = 1;
		this.pictureBox8.TabStop = false;
		// 
		// pictureBox9
		// 
		this.pictureBox9.Location = new System.Drawing.Point(3, 28);
		this.pictureBox9.Name = "pictureBox9";
		this.pictureBox9.Size = new System.Drawing.Size(100, 50);
		this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox9.TabIndex = 1;
		this.pictureBox9.TabStop = false;
		// 
		// label20
		// 
		this.label20.AutoSize = true;
		this.label20.Location = new System.Drawing.Point(0, 330);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(124, 13);
		this.label20.TabIndex = 0;
		this.label20.Text = "Chance of Precepitation:";
		// 
		// label21
		// 
		this.label21.AutoSize = true;
		this.label21.Location = new System.Drawing.Point(3, 137);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(124, 13);
		this.label21.TabIndex = 0;
		this.label21.Text = "Chance of Precepitation:";
		// 
		// label22
		// 
		this.label22.Location = new System.Drawing.Point(0, 274);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(173, 56);
		this.label22.TabIndex = 0;
		this.label22.Text = "Night one Desc.";
		// 
		// label23
		// 
		this.label23.Location = new System.Drawing.Point(3, 0);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(173, 56);
		this.label23.TabIndex = 0;
		this.label23.Text = "Day one Desc.";
		// 
		// label24
		// 
		this.label24.AutoSize = true;
		this.label24.Location = new System.Drawing.Point(3, 205);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(38, 13);
		this.label24.TabIndex = 0;
		this.label24.Text = "Night1";
		// 
		// label25
		// 
		this.label25.AutoSize = true;
		this.label25.Location = new System.Drawing.Point(3, 12);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(32, 13);
		this.label25.TabIndex = 0;
		this.label25.Text = "Day1";
		// 
		// MainForm
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoScroll = true;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.ClientSize = new System.Drawing.Size(1031, 574);
		this.Controls.Add(this.button3);
		this.Controls.Add(this.label1);
		this.Controls.Add(this.Button2);
		this.Controls.Add(this.Button1);
		this.Controls.Add(this.tabControl1);
		this.Name = "MainForm";
		this.Text = "weatherVB";
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.picboxN1)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD1)).EndInit();
		this.flowLayoutPanel1.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.picboxN2)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD2)).EndInit();
		this.Panel3.ResumeLayout(false);
		this.Panel3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.picboxN3)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD3)).EndInit();
		this.Panel4.ResumeLayout(false);
		this.Panel4.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.picboxN4)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD4)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.TabPage3.ResumeLayout(false);
		this.tabPage2.ResumeLayout(false);
		this.tabPage4.ResumeLayout(false);
		this.flowLayoutPanel2.ResumeLayout(false);
		this.panel5.ResumeLayout(false);
		this.panel5.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
		this.panel6.ResumeLayout(false);
		this.panel6.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
		this.panel7.ResumeLayout(false);
		this.panel7.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
		this.panel8.ResumeLayout(false);
		this.panel8.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
		this.ResumeLayout(false);

	}
	private System.Windows.Forms.TabPage tabPage2;
	private System.Windows.Forms.TabPage tabPage1;
	private System.Windows.Forms.TabControl tabControl1;
	private System.Windows.Forms.WebBrowser WEBmapbrowser;
	private System.Windows.Forms.PictureBox pictureBox4;
	private System.Windows.Forms.Label lblD1pop;
	private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	private System.Windows.Forms.Label lblD1desc;
	private System.Windows.Forms.Panel panel1;
	private System.Windows.Forms.PictureBox picboxD1;
	private System.Windows.Forms.Label lblD1;
	private PictureBox picboxN1;
	private Label lblN1pop;
	private Label lblN1desc;
	private Label lblN1;
	private Panel Panel2;
	private PictureBox picboxN2;
	private PictureBox picboxD2;
	private Label lblN2pop;
	private Label lblD2pop;
	private Label lblN2desc;
	private Label lblD2desc;
	private Label lblN2;
	private Label lblD2;
	private Panel Panel3;
	private PictureBox picboxN3;
	private PictureBox picboxD3;
	private Label lblN3pop;
	private Label lblD3pop;
	private Label lblN3desc;
	private Label lblD3desc;
	private Label lblN3;
	private Label lblD3;
	private Panel Panel4;
	private PictureBox picboxN4;
	private PictureBox picboxD4;
	private Label lblN4pop;
	private Label lblD4pop;
	private Label lblN4desc;
	private Label lblD4desc;
	private Label lblN4;
	private Label lblD4;
	internal TabPage TabPage3;
	internal Button Button1;
	internal Button Button2;
	private GMap.NET.WindowsForms.GMapControl gMapControl;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Button button3;
	private System.Windows.Forms.TabPage tabPage4;
	private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
	private System.Windows.Forms.Panel panel5;
	private System.Windows.Forms.PictureBox pictureBox1;
	private System.Windows.Forms.PictureBox pictureBox2;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.Label label5;
	private System.Windows.Forms.Label label6;
	private System.Windows.Forms.Label label7;
	private System.Windows.Forms.Panel panel6;
	private System.Windows.Forms.PictureBox pictureBox3;
	private System.Windows.Forms.PictureBox pictureBox5;
	private System.Windows.Forms.Label label8;
	private System.Windows.Forms.Label label9;
	private System.Windows.Forms.Label label10;
	private System.Windows.Forms.Label label11;
	private System.Windows.Forms.Label label12;
	private System.Windows.Forms.Label label13;
	private System.Windows.Forms.Panel panel7;
	private System.Windows.Forms.PictureBox pictureBox6;
	private System.Windows.Forms.PictureBox pictureBox7;
	private System.Windows.Forms.Label label14;
	private System.Windows.Forms.Label label15;
	private System.Windows.Forms.Label label16;
	private System.Windows.Forms.Label label17;
	private System.Windows.Forms.Label label18;
	private System.Windows.Forms.Label label19;
	private System.Windows.Forms.Panel panel8;
	private System.Windows.Forms.PictureBox pictureBox8;
	private System.Windows.Forms.PictureBox pictureBox9;
	private System.Windows.Forms.Label label20;
	private System.Windows.Forms.Label label21;
	private System.Windows.Forms.Label label22;
	private System.Windows.Forms.Label label23;
	private System.Windows.Forms.Label label24;
	private System.Windows.Forms.Label label25;
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
