
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
		this.picboxN4 = new System.Windows.Forms.PictureBox();
		this.lblN4pop = new System.Windows.Forms.Label();
		this.picboxN3 = new System.Windows.Forms.PictureBox();
		this.lblN4 = new System.Windows.Forms.Label();
		this.lblN3pop = new System.Windows.Forms.Label();
		this.picboxN2 = new System.Windows.Forms.PictureBox();
		this.lblN2pop = new System.Windows.Forms.Label();
		this.lblN3 = new System.Windows.Forms.Label();
		this.picboxN1 = new System.Windows.Forms.PictureBox();
		this.lblN2 = new System.Windows.Forms.Label();
		this.picboxD4 = new System.Windows.Forms.PictureBox();
		this.picboxD3 = new System.Windows.Forms.PictureBox();
		this.lblD4pop = new System.Windows.Forms.Label();
		this.picboxD2 = new System.Windows.Forms.PictureBox();
		this.lblD3pop = new System.Windows.Forms.Label();
		this.lblD4 = new System.Windows.Forms.Label();
		this.picboxD1 = new System.Windows.Forms.PictureBox();
		this.lblD2pop = new System.Windows.Forms.Label();
		this.lblD3 = new System.Windows.Forms.Label();
		this.lblN1pop = new System.Windows.Forms.Label();
		this.lblD1pop = new System.Windows.Forms.Label();
		this.lblD2 = new System.Windows.Forms.Label();
		this.lblN1 = new System.Windows.Forms.Label();
		this.lblD1 = new System.Windows.Forms.Label();
		this.WEBmapbrowser = new System.Windows.Forms.WebBrowser();
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.gMap = new GMap.NET.WindowsForms.GMapControl();
		this.panel16 = new System.Windows.Forms.Panel();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.panel15 = new System.Windows.Forms.Panel();
		this.panel8 = new System.Windows.Forms.Panel();
		this.night10Pic = new System.Windows.Forms.PictureBox();
		this.day10Pic = new System.Windows.Forms.PictureBox();
		this.night10cop = new System.Windows.Forms.Label();
		this.day10cop = new System.Windows.Forms.Label();
		this.Night10Desc = new System.Windows.Forms.Label();
		this.day10Desc = new System.Windows.Forms.Label();
		this.night10Label = new System.Windows.Forms.Label();
		this.day10Label = new System.Windows.Forms.Label();
		this.panel11 = new System.Windows.Forms.Panel();
		this.night9Pic = new System.Windows.Forms.PictureBox();
		this.day9Pic = new System.Windows.Forms.PictureBox();
		this.night9cop = new System.Windows.Forms.Label();
		this.day9cop = new System.Windows.Forms.Label();
		this.Night9Desc = new System.Windows.Forms.Label();
		this.day9Desc = new System.Windows.Forms.Label();
		this.night9Label = new System.Windows.Forms.Label();
		this.day9Label = new System.Windows.Forms.Label();
		this.panel13 = new System.Windows.Forms.Panel();
		this.night7Pic = new System.Windows.Forms.PictureBox();
		this.day7Pic = new System.Windows.Forms.PictureBox();
		this.night7cop = new System.Windows.Forms.Label();
		this.day7cop = new System.Windows.Forms.Label();
		this.Night7Desc = new System.Windows.Forms.Label();
		this.day7Desc = new System.Windows.Forms.Label();
		this.night7Label = new System.Windows.Forms.Label();
		this.day7Label = new System.Windows.Forms.Label();
		this.panel10 = new System.Windows.Forms.Panel();
		this.night6Pic = new System.Windows.Forms.PictureBox();
		this.day6Pic = new System.Windows.Forms.PictureBox();
		this.night6cop = new System.Windows.Forms.Label();
		this.day6cop = new System.Windows.Forms.Label();
		this.Night6Desc = new System.Windows.Forms.Label();
		this.day6Desc = new System.Windows.Forms.Label();
		this.night6Label = new System.Windows.Forms.Label();
		this.day6Label = new System.Windows.Forms.Label();
		this.panel14 = new System.Windows.Forms.Panel();
		this.night8Pic = new System.Windows.Forms.PictureBox();
		this.day8Pic = new System.Windows.Forms.PictureBox();
		this.night8cop = new System.Windows.Forms.Label();
		this.day8cop = new System.Windows.Forms.Label();
		this.Night8Desc = new System.Windows.Forms.Label();
		this.day8Desc = new System.Windows.Forms.Label();
		this.night8Label = new System.Windows.Forms.Label();
		this.day8Label = new System.Windows.Forms.Label();
		this.panel12 = new System.Windows.Forms.Panel();
		this.night5Pic = new System.Windows.Forms.PictureBox();
		this.day5Pic = new System.Windows.Forms.PictureBox();
		this.night5cop = new System.Windows.Forms.Label();
		this.day5cop = new System.Windows.Forms.Label();
		this.Night5Desc = new System.Windows.Forms.Label();
		this.day5Desc = new System.Windows.Forms.Label();
		this.night5Label = new System.Windows.Forms.Label();
		this.day5Label = new System.Windows.Forms.Label();
		this.panel9 = new System.Windows.Forms.Panel();
		this.night4Pic = new System.Windows.Forms.PictureBox();
		this.day4Pic = new System.Windows.Forms.PictureBox();
		this.night4cop = new System.Windows.Forms.Label();
		this.day4cop = new System.Windows.Forms.Label();
		this.Night4Desc = new System.Windows.Forms.Label();
		this.day4Desc = new System.Windows.Forms.Label();
		this.night4Label = new System.Windows.Forms.Label();
		this.day4Label = new System.Windows.Forms.Label();
		this.panel7 = new System.Windows.Forms.Panel();
		this.night3Pic = new System.Windows.Forms.PictureBox();
		this.day3Pic = new System.Windows.Forms.PictureBox();
		this.night3cop = new System.Windows.Forms.Label();
		this.day3cop = new System.Windows.Forms.Label();
		this.Night3Desc = new System.Windows.Forms.Label();
		this.day3Desc = new System.Windows.Forms.Label();
		this.night3Label = new System.Windows.Forms.Label();
		this.day3Label = new System.Windows.Forms.Label();
		this.panel6 = new System.Windows.Forms.Panel();
		this.night2Pic = new System.Windows.Forms.PictureBox();
		this.day2Pic = new System.Windows.Forms.PictureBox();
		this.night2cop = new System.Windows.Forms.Label();
		this.day2cop = new System.Windows.Forms.Label();
		this.Night2Desc = new System.Windows.Forms.Label();
		this.day2Desc = new System.Windows.Forms.Label();
		this.night2Label = new System.Windows.Forms.Label();
		this.day2Label = new System.Windows.Forms.Label();
		this.panel5 = new System.Windows.Forms.Panel();
		this.night1Pic = new System.Windows.Forms.PictureBox();
		this.day1Pic = new System.Windows.Forms.PictureBox();
		this.night1cop = new System.Windows.Forms.Label();
		this.day1cop = new System.Windows.Forms.Label();
		this.Night1Desc = new System.Windows.Forms.Label();
		this.day1Desc = new System.Windows.Forms.Label();
		this.night1Label = new System.Windows.Forms.Label();
		this.day1Label = new System.Windows.Forms.Label();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.label1 = new System.Windows.Forms.Label();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.picboxN4)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxN3)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxN2)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxN1)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD4)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD3)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD2)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD1)).BeginInit();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.panel16.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.panel15.SuspendLayout();
		this.panel8.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.night10Pic)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.day10Pic)).BeginInit();
		this.panel11.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.night9Pic)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.day9Pic)).BeginInit();
		this.panel13.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.night7Pic)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.day7Pic)).BeginInit();
		this.panel10.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.night6Pic)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.day6Pic)).BeginInit();
		this.panel14.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.night8Pic)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.day8Pic)).BeginInit();
		this.panel12.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.night5Pic)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.day5Pic)).BeginInit();
		this.panel9.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.night4Pic)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.day4Pic)).BeginInit();
		this.panel7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.night3Pic)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.day3Pic)).BeginInit();
		this.panel6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.night2Pic)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.day2Pic)).BeginInit();
		this.panel5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.night1Pic)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.day1Pic)).BeginInit();
		this.tabPage2.SuspendLayout();
		this.SuspendLayout();
		// 
		// panel1
		// 
		this.panel1.AutoScroll = true;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.picboxN4);
		this.panel1.Controls.Add(this.lblN4pop);
		this.panel1.Controls.Add(this.picboxN3);
		this.panel1.Controls.Add(this.lblN4);
		this.panel1.Controls.Add(this.lblN3pop);
		this.panel1.Controls.Add(this.picboxN2);
		this.panel1.Controls.Add(this.lblN2pop);
		this.panel1.Controls.Add(this.lblN3);
		this.panel1.Controls.Add(this.picboxN1);
		this.panel1.Controls.Add(this.lblN2);
		this.panel1.Controls.Add(this.picboxD4);
		this.panel1.Controls.Add(this.picboxD3);
		this.panel1.Controls.Add(this.lblD4pop);
		this.panel1.Controls.Add(this.picboxD2);
		this.panel1.Controls.Add(this.lblD3pop);
		this.panel1.Controls.Add(this.lblD4);
		this.panel1.Controls.Add(this.picboxD1);
		this.panel1.Controls.Add(this.lblD2pop);
		this.panel1.Controls.Add(this.lblD3);
		this.panel1.Controls.Add(this.lblN1pop);
		this.panel1.Controls.Add(this.lblD1pop);
		this.panel1.Controls.Add(this.lblD2);
		this.panel1.Controls.Add(this.lblN1);
		this.panel1.Controls.Add(this.lblD1);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(997, 219);
		this.panel1.TabIndex = 1;
		// 
		// picboxN4
		// 
		this.picboxN4.Location = new System.Drawing.Point(773, 127);
		this.picboxN4.Name = "picboxN4";
		this.picboxN4.Size = new System.Drawing.Size(100, 50);
		this.picboxN4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxN4.TabIndex = 1;
		this.picboxN4.TabStop = false;
		// 
		// lblN4pop
		// 
		this.lblN4pop.AutoSize = true;
		this.lblN4pop.Location = new System.Drawing.Point(760, 180);
		this.lblN4pop.Name = "lblN4pop";
		this.lblN4pop.Size = new System.Drawing.Size(124, 13);
		this.lblN4pop.TabIndex = 0;
		this.lblN4pop.Text = "Chance of Precepitation:";
		// 
		// picboxN3
		// 
		this.picboxN3.Location = new System.Drawing.Point(563, 127);
		this.picboxN3.Name = "picboxN3";
		this.picboxN3.Size = new System.Drawing.Size(100, 50);
		this.picboxN3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxN3.TabIndex = 1;
		this.picboxN3.TabStop = false;
		// 
		// lblN4
		// 
		this.lblN4.AutoSize = true;
		this.lblN4.Location = new System.Drawing.Point(773, 111);
		this.lblN4.Name = "lblN4";
		this.lblN4.Size = new System.Drawing.Size(38, 13);
		this.lblN4.TabIndex = 0;
		this.lblN4.Text = "Night4";
		// 
		// lblN3pop
		// 
		this.lblN3pop.AutoSize = true;
		this.lblN3pop.Location = new System.Drawing.Point(551, 180);
		this.lblN3pop.Name = "lblN3pop";
		this.lblN3pop.Size = new System.Drawing.Size(124, 13);
		this.lblN3pop.TabIndex = 0;
		this.lblN3pop.Text = "Chance of Precepitation:";
		// 
		// picboxN2
		// 
		this.picboxN2.Location = new System.Drawing.Point(349, 127);
		this.picboxN2.Name = "picboxN2";
		this.picboxN2.Size = new System.Drawing.Size(100, 50);
		this.picboxN2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxN2.TabIndex = 1;
		this.picboxN2.TabStop = false;
		// 
		// lblN2pop
		// 
		this.lblN2pop.AutoSize = true;
		this.lblN2pop.Location = new System.Drawing.Point(338, 180);
		this.lblN2pop.Name = "lblN2pop";
		this.lblN2pop.Size = new System.Drawing.Size(124, 13);
		this.lblN2pop.TabIndex = 0;
		this.lblN2pop.Text = "Chance of Precepitation:";
		// 
		// lblN3
		// 
		this.lblN3.AutoSize = true;
		this.lblN3.Location = new System.Drawing.Point(563, 111);
		this.lblN3.Name = "lblN3";
		this.lblN3.Size = new System.Drawing.Size(38, 13);
		this.lblN3.TabIndex = 0;
		this.lblN3.Text = "Night3";
		// 
		// picboxN1
		// 
		this.picboxN1.Location = new System.Drawing.Point(158, 127);
		this.picboxN1.Name = "picboxN1";
		this.picboxN1.Size = new System.Drawing.Size(100, 50);
		this.picboxN1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxN1.TabIndex = 1;
		this.picboxN1.TabStop = false;
		// 
		// lblN2
		// 
		this.lblN2.AutoSize = true;
		this.lblN2.Location = new System.Drawing.Point(349, 111);
		this.lblN2.Name = "lblN2";
		this.lblN2.Size = new System.Drawing.Size(38, 13);
		this.lblN2.TabIndex = 0;
		this.lblN2.Text = "Night2";
		// 
		// picboxD4
		// 
		this.picboxD4.Location = new System.Drawing.Point(773, 30);
		this.picboxD4.Name = "picboxD4";
		this.picboxD4.Size = new System.Drawing.Size(100, 50);
		this.picboxD4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxD4.TabIndex = 1;
		this.picboxD4.TabStop = false;
		// 
		// picboxD3
		// 
		this.picboxD3.Location = new System.Drawing.Point(563, 30);
		this.picboxD3.Name = "picboxD3";
		this.picboxD3.Size = new System.Drawing.Size(100, 50);
		this.picboxD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxD3.TabIndex = 1;
		this.picboxD3.TabStop = false;
		// 
		// lblD4pop
		// 
		this.lblD4pop.AutoSize = true;
		this.lblD4pop.Location = new System.Drawing.Point(759, 83);
		this.lblD4pop.Name = "lblD4pop";
		this.lblD4pop.Size = new System.Drawing.Size(124, 13);
		this.lblD4pop.TabIndex = 0;
		this.lblD4pop.Text = "Chance of Precepitation:";
		// 
		// picboxD2
		// 
		this.picboxD2.Location = new System.Drawing.Point(349, 30);
		this.picboxD2.Name = "picboxD2";
		this.picboxD2.Size = new System.Drawing.Size(100, 50);
		this.picboxD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxD2.TabIndex = 1;
		this.picboxD2.TabStop = false;
		// 
		// lblD3pop
		// 
		this.lblD3pop.AutoSize = true;
		this.lblD3pop.Location = new System.Drawing.Point(549, 83);
		this.lblD3pop.Name = "lblD3pop";
		this.lblD3pop.Size = new System.Drawing.Size(124, 13);
		this.lblD3pop.TabIndex = 0;
		this.lblD3pop.Text = "Chance of Precepitation:";
		// 
		// lblD4
		// 
		this.lblD4.AutoSize = true;
		this.lblD4.Location = new System.Drawing.Point(773, 14);
		this.lblD4.Name = "lblD4";
		this.lblD4.Size = new System.Drawing.Size(32, 13);
		this.lblD4.TabIndex = 0;
		this.lblD4.Text = "Day4";
		// 
		// picboxD1
		// 
		this.picboxD1.Location = new System.Drawing.Point(158, 30);
		this.picboxD1.Name = "picboxD1";
		this.picboxD1.Size = new System.Drawing.Size(100, 50);
		this.picboxD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picboxD1.TabIndex = 1;
		this.picboxD1.TabStop = false;
		// 
		// lblD2pop
		// 
		this.lblD2pop.AutoSize = true;
		this.lblD2pop.Location = new System.Drawing.Point(334, 83);
		this.lblD2pop.Name = "lblD2pop";
		this.lblD2pop.Size = new System.Drawing.Size(124, 13);
		this.lblD2pop.TabIndex = 0;
		this.lblD2pop.Text = "Chance of Precepitation:";
		// 
		// lblD3
		// 
		this.lblD3.AutoSize = true;
		this.lblD3.Location = new System.Drawing.Point(563, 14);
		this.lblD3.Name = "lblD3";
		this.lblD3.Size = new System.Drawing.Size(32, 13);
		this.lblD3.TabIndex = 0;
		this.lblD3.Text = "Day3";
		// 
		// lblN1pop
		// 
		this.lblN1pop.AutoSize = true;
		this.lblN1pop.Location = new System.Drawing.Point(144, 180);
		this.lblN1pop.Name = "lblN1pop";
		this.lblN1pop.Size = new System.Drawing.Size(124, 13);
		this.lblN1pop.TabIndex = 0;
		this.lblN1pop.Text = "Chance of Precepitation:";
		// 
		// lblD1pop
		// 
		this.lblD1pop.AutoSize = true;
		this.lblD1pop.Location = new System.Drawing.Point(147, 83);
		this.lblD1pop.Name = "lblD1pop";
		this.lblD1pop.Size = new System.Drawing.Size(124, 13);
		this.lblD1pop.TabIndex = 0;
		this.lblD1pop.Text = "Chance of Precepitation:";
		// 
		// lblD2
		// 
		this.lblD2.AutoSize = true;
		this.lblD2.Location = new System.Drawing.Point(349, 14);
		this.lblD2.Name = "lblD2";
		this.lblD2.Size = new System.Drawing.Size(32, 13);
		this.lblD2.TabIndex = 0;
		this.lblD2.Text = "Day2";
		// 
		// lblN1
		// 
		this.lblN1.AutoSize = true;
		this.lblN1.Location = new System.Drawing.Point(158, 111);
		this.lblN1.Name = "lblN1";
		this.lblN1.Size = new System.Drawing.Size(38, 13);
		this.lblN1.TabIndex = 0;
		this.lblN1.Text = "Night1";
		// 
		// lblD1
		// 
		this.lblD1.AutoSize = true;
		this.lblD1.Location = new System.Drawing.Point(189, 14);
		this.lblD1.Name = "lblD1";
		this.lblD1.Size = new System.Drawing.Size(32, 13);
		this.lblD1.TabIndex = 0;
		this.lblD1.Text = "Day1";
		// 
		// WEBmapbrowser
		// 
		this.WEBmapbrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
		this.WEBmapbrowser.Location = new System.Drawing.Point(6, 6);
		this.WEBmapbrowser.MinimumSize = new System.Drawing.Size(20, 20);
		this.WEBmapbrowser.Name = "WEBmapbrowser";
		this.WEBmapbrowser.Size = new System.Drawing.Size(991, 566);
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
		this.tabControl1.Location = new System.Drawing.Point(12, 12);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(1011, 627);
		this.tabControl1.TabIndex = 4;
		// 
		// tabPage1
		// 
		this.tabPage1.Controls.Add(this.gMap);
		this.tabPage1.Controls.Add(this.panel16);
		this.tabPage1.Location = new System.Drawing.Point(4, 22);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(1003, 601);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "4 Day Forecast";
		this.tabPage1.UseVisualStyleBackColor = true;
		// 
		// gMap
		// 
		this.gMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
		this.gMap.Bearing = 0F;
		this.gMap.CanDragMap = true;
		this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
		this.gMap.GrayScaleMode = false;
		this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
		this.gMap.LevelsKeepInMemmory = 5;
		this.gMap.Location = new System.Drawing.Point(7, 228);
		this.gMap.MarkersEnabled = true;
		this.gMap.MaxZoom = 17;
		this.gMap.MinZoom = 3;
		this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
		this.gMap.Name = "gMap";
		this.gMap.NegativeMode = false;
		this.gMap.PolygonsEnabled = true;
		this.gMap.RetryLoadTile = 0;
		this.gMap.RoutesEnabled = true;
		this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
		this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
		this.gMap.ShowTileGridLines = false;
		this.gMap.Size = new System.Drawing.Size(990, 350);
		this.gMap.TabIndex = 2;
		this.gMap.Zoom = 3D;
		this.gMap.Load += new System.EventHandler(this.GMapLoad);
		// 
		// panel16
		// 
		this.panel16.AutoScroll = true;
		this.panel16.AutoScrollMargin = new System.Drawing.Size(20, 0);
		this.panel16.Controls.Add(this.panel1);
		this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
		this.panel16.Location = new System.Drawing.Point(3, 3);
		this.panel16.Name = "panel16";
		this.panel16.Size = new System.Drawing.Size(997, 219);
		this.panel16.TabIndex = 3;
		// 
		// TabPage3
		// 
		this.TabPage3.Controls.Add(this.panel15);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(1003, 601);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "10 Day Forecast";
		this.TabPage3.UseVisualStyleBackColor = true;
		// 
		// panel15
		// 
		this.panel15.AutoScroll = true;
		this.panel15.AutoScrollMargin = new System.Drawing.Size(20, 1000);
		this.panel15.Controls.Add(this.panel8);
		this.panel15.Controls.Add(this.panel11);
		this.panel15.Controls.Add(this.panel13);
		this.panel15.Controls.Add(this.panel10);
		this.panel15.Controls.Add(this.panel14);
		this.panel15.Controls.Add(this.panel12);
		this.panel15.Controls.Add(this.panel9);
		this.panel15.Controls.Add(this.panel7);
		this.panel15.Controls.Add(this.panel6);
		this.panel15.Controls.Add(this.panel5);
		this.panel15.Location = new System.Drawing.Point(3, 3);
		this.panel15.Name = "panel15";
		this.panel15.Size = new System.Drawing.Size(996, 400);
		this.panel15.TabIndex = 2;
		// 
		// panel8
		// 
		this.panel8.AutoScroll = true;
		this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel8.Controls.Add(this.night10Pic);
		this.panel8.Controls.Add(this.day10Pic);
		this.panel8.Controls.Add(this.night10cop);
		this.panel8.Controls.Add(this.day10cop);
		this.panel8.Controls.Add(this.Night10Desc);
		this.panel8.Controls.Add(this.day10Desc);
		this.panel8.Controls.Add(this.night10Label);
		this.panel8.Controls.Add(this.day10Label);
		this.panel8.Location = new System.Drawing.Point(2661, 3);
		this.panel8.Name = "panel8";
		this.panel8.Size = new System.Drawing.Size(289, 318);
		this.panel8.TabIndex = 5;
		// 
		// night10Pic
		// 
		this.night10Pic.Location = new System.Drawing.Point(3, 211);
		this.night10Pic.Name = "night10Pic";
		this.night10Pic.Size = new System.Drawing.Size(100, 50);
		this.night10Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.night10Pic.TabIndex = 1;
		this.night10Pic.TabStop = false;
		// 
		// day10Pic
		// 
		this.day10Pic.Location = new System.Drawing.Point(0, 28);
		this.day10Pic.Name = "day10Pic";
		this.day10Pic.Size = new System.Drawing.Size(100, 50);
		this.day10Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.day10Pic.TabIndex = 1;
		this.day10Pic.TabStop = false;
		// 
		// night10cop
		// 
		this.night10cop.AutoSize = true;
		this.night10cop.Location = new System.Drawing.Point(0, 276);
		this.night10cop.Name = "night10cop";
		this.night10cop.Size = new System.Drawing.Size(124, 13);
		this.night10cop.TabIndex = 0;
		this.night10cop.Text = "Chance of Precepitation:";
		// 
		// day10cop
		// 
		this.day10cop.AutoSize = true;
		this.day10cop.Location = new System.Drawing.Point(3, 93);
		this.day10cop.Name = "day10cop";
		this.day10cop.Size = new System.Drawing.Size(124, 13);
		this.day10cop.TabIndex = 0;
		this.day10cop.Text = "Chance of Precepitation:";
		// 
		// Night10Desc
		// 
		this.Night10Desc.Location = new System.Drawing.Point(106, 211);
		this.Night10Desc.Name = "Night10Desc";
		this.Night10Desc.Size = new System.Drawing.Size(173, 56);
		this.Night10Desc.TabIndex = 0;
		this.Night10Desc.Text = "Night one Desc.";
		// 
		// day10Desc
		// 
		this.day10Desc.Location = new System.Drawing.Point(106, 28);
		this.day10Desc.Name = "day10Desc";
		this.day10Desc.Size = new System.Drawing.Size(173, 56);
		this.day10Desc.TabIndex = 0;
		this.day10Desc.Text = "Day one Desc.";
		// 
		// night10Label
		// 
		this.night10Label.AutoSize = true;
		this.night10Label.Location = new System.Drawing.Point(3, 195);
		this.night10Label.Name = "night10Label";
		this.night10Label.Size = new System.Drawing.Size(44, 13);
		this.night10Label.TabIndex = 0;
		this.night10Label.Text = "Night10";
		// 
		// day10Label
		// 
		this.day10Label.AutoSize = true;
		this.day10Label.Location = new System.Drawing.Point(3, 12);
		this.day10Label.Name = "day10Label";
		this.day10Label.Size = new System.Drawing.Size(38, 13);
		this.day10Label.TabIndex = 0;
		this.day10Label.Text = "Day10";
		// 
		// panel11
		// 
		this.panel11.AutoScroll = true;
		this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel11.Controls.Add(this.night9Pic);
		this.panel11.Controls.Add(this.day9Pic);
		this.panel11.Controls.Add(this.night9cop);
		this.panel11.Controls.Add(this.day9cop);
		this.panel11.Controls.Add(this.Night9Desc);
		this.panel11.Controls.Add(this.day9Desc);
		this.panel11.Controls.Add(this.night9Label);
		this.panel11.Controls.Add(this.day9Label);
		this.panel11.Location = new System.Drawing.Point(2366, 3);
		this.panel11.Name = "panel11";
		this.panel11.Size = new System.Drawing.Size(289, 318);
		this.panel11.TabIndex = 5;
		// 
		// night9Pic
		// 
		this.night9Pic.Location = new System.Drawing.Point(3, 211);
		this.night9Pic.Name = "night9Pic";
		this.night9Pic.Size = new System.Drawing.Size(100, 50);
		this.night9Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.night9Pic.TabIndex = 1;
		this.night9Pic.TabStop = false;
		// 
		// day9Pic
		// 
		this.day9Pic.Location = new System.Drawing.Point(0, 28);
		this.day9Pic.Name = "day9Pic";
		this.day9Pic.Size = new System.Drawing.Size(100, 50);
		this.day9Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.day9Pic.TabIndex = 1;
		this.day9Pic.TabStop = false;
		// 
		// night9cop
		// 
		this.night9cop.AutoSize = true;
		this.night9cop.Location = new System.Drawing.Point(0, 276);
		this.night9cop.Name = "night9cop";
		this.night9cop.Size = new System.Drawing.Size(124, 13);
		this.night9cop.TabIndex = 0;
		this.night9cop.Text = "Chance of Precepitation:";
		// 
		// day9cop
		// 
		this.day9cop.AutoSize = true;
		this.day9cop.Location = new System.Drawing.Point(0, 93);
		this.day9cop.Name = "day9cop";
		this.day9cop.Size = new System.Drawing.Size(124, 13);
		this.day9cop.TabIndex = 0;
		this.day9cop.Text = "Chance of Precepitation:";
		// 
		// Night9Desc
		// 
		this.Night9Desc.Location = new System.Drawing.Point(106, 211);
		this.Night9Desc.Name = "Night9Desc";
		this.Night9Desc.Size = new System.Drawing.Size(173, 56);
		this.Night9Desc.TabIndex = 0;
		this.Night9Desc.Text = "Night one Desc.";
		// 
		// day9Desc
		// 
		this.day9Desc.Location = new System.Drawing.Point(106, 28);
		this.day9Desc.Name = "day9Desc";
		this.day9Desc.Size = new System.Drawing.Size(173, 56);
		this.day9Desc.TabIndex = 0;
		this.day9Desc.Text = "Day one Desc.";
		// 
		// night9Label
		// 
		this.night9Label.AutoSize = true;
		this.night9Label.Location = new System.Drawing.Point(3, 195);
		this.night9Label.Name = "night9Label";
		this.night9Label.Size = new System.Drawing.Size(38, 13);
		this.night9Label.TabIndex = 0;
		this.night9Label.Text = "Night9";
		// 
		// day9Label
		// 
		this.day9Label.AutoSize = true;
		this.day9Label.Location = new System.Drawing.Point(3, 12);
		this.day9Label.Name = "day9Label";
		this.day9Label.Size = new System.Drawing.Size(32, 13);
		this.day9Label.TabIndex = 0;
		this.day9Label.Text = "Day9";
		// 
		// panel13
		// 
		this.panel13.AutoScroll = true;
		this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel13.Controls.Add(this.night7Pic);
		this.panel13.Controls.Add(this.day7Pic);
		this.panel13.Controls.Add(this.night7cop);
		this.panel13.Controls.Add(this.day7cop);
		this.panel13.Controls.Add(this.Night7Desc);
		this.panel13.Controls.Add(this.day7Desc);
		this.panel13.Controls.Add(this.night7Label);
		this.panel13.Controls.Add(this.day7Label);
		this.panel13.Location = new System.Drawing.Point(1774, 3);
		this.panel13.Name = "panel13";
		this.panel13.Size = new System.Drawing.Size(289, 318);
		this.panel13.TabIndex = 5;
		// 
		// night7Pic
		// 
		this.night7Pic.Location = new System.Drawing.Point(0, 205);
		this.night7Pic.Name = "night7Pic";
		this.night7Pic.Size = new System.Drawing.Size(100, 50);
		this.night7Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.night7Pic.TabIndex = 1;
		this.night7Pic.TabStop = false;
		// 
		// day7Pic
		// 
		this.day7Pic.Location = new System.Drawing.Point(0, 28);
		this.day7Pic.Name = "day7Pic";
		this.day7Pic.Size = new System.Drawing.Size(100, 50);
		this.day7Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.day7Pic.TabIndex = 1;
		this.day7Pic.TabStop = false;
		// 
		// night7cop
		// 
		this.night7cop.AutoSize = true;
		this.night7cop.Location = new System.Drawing.Point(0, 270);
		this.night7cop.Name = "night7cop";
		this.night7cop.Size = new System.Drawing.Size(124, 13);
		this.night7cop.TabIndex = 0;
		this.night7cop.Text = "Chance of Precepitation:";
		// 
		// day7cop
		// 
		this.day7cop.AutoSize = true;
		this.day7cop.Location = new System.Drawing.Point(0, 93);
		this.day7cop.Name = "day7cop";
		this.day7cop.Size = new System.Drawing.Size(124, 13);
		this.day7cop.TabIndex = 0;
		this.day7cop.Text = "Chance of Precepitation:";
		// 
		// Night7Desc
		// 
		this.Night7Desc.Location = new System.Drawing.Point(103, 205);
		this.Night7Desc.Name = "Night7Desc";
		this.Night7Desc.Size = new System.Drawing.Size(173, 56);
		this.Night7Desc.TabIndex = 0;
		this.Night7Desc.Text = "Night one Desc.";
		// 
		// day7Desc
		// 
		this.day7Desc.Location = new System.Drawing.Point(106, 28);
		this.day7Desc.Name = "day7Desc";
		this.day7Desc.Size = new System.Drawing.Size(173, 56);
		this.day7Desc.TabIndex = 0;
		this.day7Desc.Text = "Day one Desc.";
		// 
		// night7Label
		// 
		this.night7Label.AutoSize = true;
		this.night7Label.Location = new System.Drawing.Point(0, 189);
		this.night7Label.Name = "night7Label";
		this.night7Label.Size = new System.Drawing.Size(38, 13);
		this.night7Label.TabIndex = 0;
		this.night7Label.Text = "Night7";
		// 
		// day7Label
		// 
		this.day7Label.AutoSize = true;
		this.day7Label.Location = new System.Drawing.Point(3, 12);
		this.day7Label.Name = "day7Label";
		this.day7Label.Size = new System.Drawing.Size(32, 13);
		this.day7Label.TabIndex = 0;
		this.day7Label.Text = "Day7";
		// 
		// panel10
		// 
		this.panel10.AutoScroll = true;
		this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel10.Controls.Add(this.night6Pic);
		this.panel10.Controls.Add(this.day6Pic);
		this.panel10.Controls.Add(this.night6cop);
		this.panel10.Controls.Add(this.day6cop);
		this.panel10.Controls.Add(this.Night6Desc);
		this.panel10.Controls.Add(this.day6Desc);
		this.panel10.Controls.Add(this.night6Label);
		this.panel10.Controls.Add(this.day6Label);
		this.panel10.Location = new System.Drawing.Point(1479, 3);
		this.panel10.Name = "panel10";
		this.panel10.Size = new System.Drawing.Size(289, 318);
		this.panel10.TabIndex = 5;
		// 
		// night6Pic
		// 
		this.night6Pic.Location = new System.Drawing.Point(0, 205);
		this.night6Pic.Name = "night6Pic";
		this.night6Pic.Size = new System.Drawing.Size(100, 50);
		this.night6Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.night6Pic.TabIndex = 1;
		this.night6Pic.TabStop = false;
		// 
		// day6Pic
		// 
		this.day6Pic.Location = new System.Drawing.Point(0, 28);
		this.day6Pic.Name = "day6Pic";
		this.day6Pic.Size = new System.Drawing.Size(100, 50);
		this.day6Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.day6Pic.TabIndex = 1;
		this.day6Pic.TabStop = false;
		// 
		// night6cop
		// 
		this.night6cop.AutoSize = true;
		this.night6cop.Location = new System.Drawing.Point(0, 270);
		this.night6cop.Name = "night6cop";
		this.night6cop.Size = new System.Drawing.Size(124, 13);
		this.night6cop.TabIndex = 0;
		this.night6cop.Text = "Chance of Precepitation:";
		// 
		// day6cop
		// 
		this.day6cop.AutoSize = true;
		this.day6cop.Location = new System.Drawing.Point(3, 93);
		this.day6cop.Name = "day6cop";
		this.day6cop.Size = new System.Drawing.Size(124, 13);
		this.day6cop.TabIndex = 0;
		this.day6cop.Text = "Chance of Precepitation:";
		// 
		// Night6Desc
		// 
		this.Night6Desc.Location = new System.Drawing.Point(102, 205);
		this.Night6Desc.Name = "Night6Desc";
		this.Night6Desc.Size = new System.Drawing.Size(173, 56);
		this.Night6Desc.TabIndex = 0;
		this.Night6Desc.Text = "Night one Desc.";
		// 
		// day6Desc
		// 
		this.day6Desc.Location = new System.Drawing.Point(106, 28);
		this.day6Desc.Name = "day6Desc";
		this.day6Desc.Size = new System.Drawing.Size(173, 56);
		this.day6Desc.TabIndex = 0;
		this.day6Desc.Text = "Day one Desc.";
		// 
		// night6Label
		// 
		this.night6Label.AutoSize = true;
		this.night6Label.Location = new System.Drawing.Point(0, 189);
		this.night6Label.Name = "night6Label";
		this.night6Label.Size = new System.Drawing.Size(38, 13);
		this.night6Label.TabIndex = 0;
		this.night6Label.Text = "Night6";
		// 
		// day6Label
		// 
		this.day6Label.AutoSize = true;
		this.day6Label.Location = new System.Drawing.Point(3, 12);
		this.day6Label.Name = "day6Label";
		this.day6Label.Size = new System.Drawing.Size(32, 13);
		this.day6Label.TabIndex = 0;
		this.day6Label.Text = "Day6";
		// 
		// panel14
		// 
		this.panel14.AutoScroll = true;
		this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel14.Controls.Add(this.night8Pic);
		this.panel14.Controls.Add(this.day8Pic);
		this.panel14.Controls.Add(this.night8cop);
		this.panel14.Controls.Add(this.day8cop);
		this.panel14.Controls.Add(this.Night8Desc);
		this.panel14.Controls.Add(this.day8Desc);
		this.panel14.Controls.Add(this.night8Label);
		this.panel14.Controls.Add(this.day8Label);
		this.panel14.Location = new System.Drawing.Point(2069, 3);
		this.panel14.Name = "panel14";
		this.panel14.Size = new System.Drawing.Size(289, 318);
		this.panel14.TabIndex = 5;
		// 
		// night8Pic
		// 
		this.night8Pic.Location = new System.Drawing.Point(2, 205);
		this.night8Pic.Name = "night8Pic";
		this.night8Pic.Size = new System.Drawing.Size(100, 50);
		this.night8Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.night8Pic.TabIndex = 1;
		this.night8Pic.TabStop = false;
		// 
		// day8Pic
		// 
		this.day8Pic.Location = new System.Drawing.Point(0, 28);
		this.day8Pic.Name = "day8Pic";
		this.day8Pic.Size = new System.Drawing.Size(100, 50);
		this.day8Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.day8Pic.TabIndex = 1;
		this.day8Pic.TabStop = false;
		// 
		// night8cop
		// 
		this.night8cop.AutoSize = true;
		this.night8cop.Location = new System.Drawing.Point(0, 270);
		this.night8cop.Name = "night8cop";
		this.night8cop.Size = new System.Drawing.Size(124, 13);
		this.night8cop.TabIndex = 0;
		this.night8cop.Text = "Chance of Precepitation:";
		// 
		// day8cop
		// 
		this.day8cop.AutoSize = true;
		this.day8cop.Location = new System.Drawing.Point(2, 93);
		this.day8cop.Name = "day8cop";
		this.day8cop.Size = new System.Drawing.Size(124, 13);
		this.day8cop.TabIndex = 0;
		this.day8cop.Text = "Chance of Precepitation:";
		// 
		// Night8Desc
		// 
		this.Night8Desc.Location = new System.Drawing.Point(105, 205);
		this.Night8Desc.Name = "Night8Desc";
		this.Night8Desc.Size = new System.Drawing.Size(173, 56);
		this.Night8Desc.TabIndex = 0;
		this.Night8Desc.Text = "Night one Desc.";
		// 
		// day8Desc
		// 
		this.day8Desc.Location = new System.Drawing.Point(106, 28);
		this.day8Desc.Name = "day8Desc";
		this.day8Desc.Size = new System.Drawing.Size(173, 56);
		this.day8Desc.TabIndex = 0;
		this.day8Desc.Text = "Day one Desc.";
		// 
		// night8Label
		// 
		this.night8Label.AutoSize = true;
		this.night8Label.Location = new System.Drawing.Point(2, 189);
		this.night8Label.Name = "night8Label";
		this.night8Label.Size = new System.Drawing.Size(38, 13);
		this.night8Label.TabIndex = 0;
		this.night8Label.Text = "Night8";
		// 
		// day8Label
		// 
		this.day8Label.AutoSize = true;
		this.day8Label.Location = new System.Drawing.Point(3, 12);
		this.day8Label.Name = "day8Label";
		this.day8Label.Size = new System.Drawing.Size(32, 13);
		this.day8Label.TabIndex = 0;
		this.day8Label.Text = "Day8";
		// 
		// panel12
		// 
		this.panel12.AutoScroll = true;
		this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel12.Controls.Add(this.night5Pic);
		this.panel12.Controls.Add(this.day5Pic);
		this.panel12.Controls.Add(this.night5cop);
		this.panel12.Controls.Add(this.day5cop);
		this.panel12.Controls.Add(this.Night5Desc);
		this.panel12.Controls.Add(this.day5Desc);
		this.panel12.Controls.Add(this.night5Label);
		this.panel12.Controls.Add(this.day5Label);
		this.panel12.Location = new System.Drawing.Point(1184, 3);
		this.panel12.Name = "panel12";
		this.panel12.Size = new System.Drawing.Size(289, 318);
		this.panel12.TabIndex = 5;
		// 
		// night5Pic
		// 
		this.night5Pic.Location = new System.Drawing.Point(3, 205);
		this.night5Pic.Name = "night5Pic";
		this.night5Pic.Size = new System.Drawing.Size(100, 50);
		this.night5Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.night5Pic.TabIndex = 1;
		this.night5Pic.TabStop = false;
		// 
		// day5Pic
		// 
		this.day5Pic.Location = new System.Drawing.Point(0, 28);
		this.day5Pic.Name = "day5Pic";
		this.day5Pic.Size = new System.Drawing.Size(100, 50);
		this.day5Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.day5Pic.TabIndex = 1;
		this.day5Pic.TabStop = false;
		// 
		// night5cop
		// 
		this.night5cop.AutoSize = true;
		this.night5cop.Location = new System.Drawing.Point(0, 270);
		this.night5cop.Name = "night5cop";
		this.night5cop.Size = new System.Drawing.Size(124, 13);
		this.night5cop.TabIndex = 0;
		this.night5cop.Text = "Chance of Precepitation:";
		// 
		// day5cop
		// 
		this.day5cop.AutoSize = true;
		this.day5cop.Location = new System.Drawing.Point(3, 93);
		this.day5cop.Name = "day5cop";
		this.day5cop.Size = new System.Drawing.Size(124, 13);
		this.day5cop.TabIndex = 0;
		this.day5cop.Text = "Chance of Precepitation:";
		// 
		// Night5Desc
		// 
		this.Night5Desc.Location = new System.Drawing.Point(106, 205);
		this.Night5Desc.Name = "Night5Desc";
		this.Night5Desc.Size = new System.Drawing.Size(173, 56);
		this.Night5Desc.TabIndex = 0;
		this.Night5Desc.Text = "Night one Desc.";
		// 
		// day5Desc
		// 
		this.day5Desc.Location = new System.Drawing.Point(106, 28);
		this.day5Desc.Name = "day5Desc";
		this.day5Desc.Size = new System.Drawing.Size(173, 56);
		this.day5Desc.TabIndex = 0;
		this.day5Desc.Text = "Day one Desc.";
		// 
		// night5Label
		// 
		this.night5Label.AutoSize = true;
		this.night5Label.Location = new System.Drawing.Point(3, 189);
		this.night5Label.Name = "night5Label";
		this.night5Label.Size = new System.Drawing.Size(38, 13);
		this.night5Label.TabIndex = 0;
		this.night5Label.Text = "Night5";
		// 
		// day5Label
		// 
		this.day5Label.AutoSize = true;
		this.day5Label.Location = new System.Drawing.Point(3, 12);
		this.day5Label.Name = "day5Label";
		this.day5Label.Size = new System.Drawing.Size(32, 13);
		this.day5Label.TabIndex = 0;
		this.day5Label.Text = "Day5";
		// 
		// panel9
		// 
		this.panel9.AutoScroll = true;
		this.panel9.AutoScrollMinSize = new System.Drawing.Size(100, 100);
		this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel9.Controls.Add(this.night4Pic);
		this.panel9.Controls.Add(this.day4Pic);
		this.panel9.Controls.Add(this.night4cop);
		this.panel9.Controls.Add(this.day4cop);
		this.panel9.Controls.Add(this.Night4Desc);
		this.panel9.Controls.Add(this.day4Desc);
		this.panel9.Controls.Add(this.night4Label);
		this.panel9.Controls.Add(this.day4Label);
		this.panel9.Location = new System.Drawing.Point(889, 3);
		this.panel9.Name = "panel9";
		this.panel9.Size = new System.Drawing.Size(289, 318);
		this.panel9.TabIndex = 5;
		// 
		// night4Pic
		// 
		this.night4Pic.Location = new System.Drawing.Point(0, 205);
		this.night4Pic.Name = "night4Pic";
		this.night4Pic.Size = new System.Drawing.Size(100, 50);
		this.night4Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.night4Pic.TabIndex = 1;
		this.night4Pic.TabStop = false;
		// 
		// day4Pic
		// 
		this.day4Pic.Location = new System.Drawing.Point(0, 28);
		this.day4Pic.Name = "day4Pic";
		this.day4Pic.Size = new System.Drawing.Size(100, 50);
		this.day4Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.day4Pic.TabIndex = 1;
		this.day4Pic.TabStop = false;
		// 
		// night4cop
		// 
		this.night4cop.AutoSize = true;
		this.night4cop.Location = new System.Drawing.Point(0, 270);
		this.night4cop.Name = "night4cop";
		this.night4cop.Size = new System.Drawing.Size(124, 13);
		this.night4cop.TabIndex = 0;
		this.night4cop.Text = "Chance of Precepitation:";
		// 
		// day4cop
		// 
		this.day4cop.AutoSize = true;
		this.day4cop.Location = new System.Drawing.Point(3, 93);
		this.day4cop.Name = "day4cop";
		this.day4cop.Size = new System.Drawing.Size(124, 13);
		this.day4cop.TabIndex = 0;
		this.day4cop.Text = "Chance of Precepitation:";
		// 
		// Night4Desc
		// 
		this.Night4Desc.Location = new System.Drawing.Point(105, 199);
		this.Night4Desc.Name = "Night4Desc";
		this.Night4Desc.Size = new System.Drawing.Size(173, 56);
		this.Night4Desc.TabIndex = 0;
		this.Night4Desc.Text = "Night one Desc.";
		// 
		// day4Desc
		// 
		this.day4Desc.Location = new System.Drawing.Point(106, 28);
		this.day4Desc.Name = "day4Desc";
		this.day4Desc.Size = new System.Drawing.Size(173, 56);
		this.day4Desc.TabIndex = 0;
		this.day4Desc.Text = "Day one Desc.";
		// 
		// night4Label
		// 
		this.night4Label.AutoSize = true;
		this.night4Label.Location = new System.Drawing.Point(0, 189);
		this.night4Label.Name = "night4Label";
		this.night4Label.Size = new System.Drawing.Size(38, 13);
		this.night4Label.TabIndex = 0;
		this.night4Label.Text = "Night4";
		// 
		// day4Label
		// 
		this.day4Label.AutoSize = true;
		this.day4Label.Location = new System.Drawing.Point(3, 12);
		this.day4Label.Name = "day4Label";
		this.day4Label.Size = new System.Drawing.Size(32, 13);
		this.day4Label.TabIndex = 0;
		this.day4Label.Text = "Day4";
		// 
		// panel7
		// 
		this.panel7.AutoScroll = true;
		this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel7.Controls.Add(this.night3Pic);
		this.panel7.Controls.Add(this.day3Pic);
		this.panel7.Controls.Add(this.night3cop);
		this.panel7.Controls.Add(this.day3cop);
		this.panel7.Controls.Add(this.Night3Desc);
		this.panel7.Controls.Add(this.day3Desc);
		this.panel7.Controls.Add(this.night3Label);
		this.panel7.Controls.Add(this.day3Label);
		this.panel7.Location = new System.Drawing.Point(594, 3);
		this.panel7.Name = "panel7";
		this.panel7.Size = new System.Drawing.Size(289, 318);
		this.panel7.TabIndex = 4;
		// 
		// night3Pic
		// 
		this.night3Pic.Location = new System.Drawing.Point(0, 205);
		this.night3Pic.Name = "night3Pic";
		this.night3Pic.Size = new System.Drawing.Size(100, 50);
		this.night3Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.night3Pic.TabIndex = 1;
		this.night3Pic.TabStop = false;
		// 
		// day3Pic
		// 
		this.day3Pic.Location = new System.Drawing.Point(3, 28);
		this.day3Pic.Name = "day3Pic";
		this.day3Pic.Size = new System.Drawing.Size(100, 50);
		this.day3Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.day3Pic.TabIndex = 1;
		this.day3Pic.TabStop = false;
		// 
		// night3cop
		// 
		this.night3cop.AutoSize = true;
		this.night3cop.Location = new System.Drawing.Point(0, 270);
		this.night3cop.Name = "night3cop";
		this.night3cop.Size = new System.Drawing.Size(124, 13);
		this.night3cop.TabIndex = 0;
		this.night3cop.Text = "Chance of Precepitation:";
		// 
		// day3cop
		// 
		this.day3cop.AutoSize = true;
		this.day3cop.Location = new System.Drawing.Point(3, 93);
		this.day3cop.Name = "day3cop";
		this.day3cop.Size = new System.Drawing.Size(124, 13);
		this.day3cop.TabIndex = 0;
		this.day3cop.Text = "Chance of Precepitation:";
		// 
		// Night3Desc
		// 
		this.Night3Desc.Location = new System.Drawing.Point(103, 205);
		this.Night3Desc.Name = "Night3Desc";
		this.Night3Desc.Size = new System.Drawing.Size(173, 56);
		this.Night3Desc.TabIndex = 0;
		this.Night3Desc.Text = "Night one Desc.";
		// 
		// day3Desc
		// 
		this.day3Desc.Location = new System.Drawing.Point(107, 28);
		this.day3Desc.Name = "day3Desc";
		this.day3Desc.Size = new System.Drawing.Size(173, 56);
		this.day3Desc.TabIndex = 0;
		this.day3Desc.Text = "Day one Desc.";
		// 
		// night3Label
		// 
		this.night3Label.AutoSize = true;
		this.night3Label.Location = new System.Drawing.Point(0, 189);
		this.night3Label.Name = "night3Label";
		this.night3Label.Size = new System.Drawing.Size(38, 13);
		this.night3Label.TabIndex = 0;
		this.night3Label.Text = "Night3";
		// 
		// day3Label
		// 
		this.day3Label.AutoSize = true;
		this.day3Label.Location = new System.Drawing.Point(3, 12);
		this.day3Label.Name = "day3Label";
		this.day3Label.Size = new System.Drawing.Size(32, 13);
		this.day3Label.TabIndex = 0;
		this.day3Label.Text = "Day3";
		// 
		// panel6
		// 
		this.panel6.AutoScroll = true;
		this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel6.Controls.Add(this.night2Pic);
		this.panel6.Controls.Add(this.day2Pic);
		this.panel6.Controls.Add(this.night2cop);
		this.panel6.Controls.Add(this.day2cop);
		this.panel6.Controls.Add(this.Night2Desc);
		this.panel6.Controls.Add(this.day2Desc);
		this.panel6.Controls.Add(this.night2Label);
		this.panel6.Controls.Add(this.day2Label);
		this.panel6.Location = new System.Drawing.Point(302, 3);
		this.panel6.Name = "panel6";
		this.panel6.Size = new System.Drawing.Size(289, 318);
		this.panel6.TabIndex = 3;
		// 
		// night2Pic
		// 
		this.night2Pic.Location = new System.Drawing.Point(3, 205);
		this.night2Pic.Name = "night2Pic";
		this.night2Pic.Size = new System.Drawing.Size(100, 50);
		this.night2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.night2Pic.TabIndex = 1;
		this.night2Pic.TabStop = false;
		// 
		// day2Pic
		// 
		this.day2Pic.Location = new System.Drawing.Point(3, 28);
		this.day2Pic.Name = "day2Pic";
		this.day2Pic.Size = new System.Drawing.Size(100, 50);
		this.day2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.day2Pic.TabIndex = 1;
		this.day2Pic.TabStop = false;
		// 
		// night2cop
		// 
		this.night2cop.AutoSize = true;
		this.night2cop.Location = new System.Drawing.Point(3, 274);
		this.night2cop.Name = "night2cop";
		this.night2cop.Size = new System.Drawing.Size(124, 13);
		this.night2cop.TabIndex = 0;
		this.night2cop.Text = "Chance of Precepitation:";
		// 
		// day2cop
		// 
		this.day2cop.AutoSize = true;
		this.day2cop.Location = new System.Drawing.Point(3, 93);
		this.day2cop.Name = "day2cop";
		this.day2cop.Size = new System.Drawing.Size(124, 13);
		this.day2cop.TabIndex = 0;
		this.day2cop.Text = "Chance of Precepitation:";
		// 
		// Night2Desc
		// 
		this.Night2Desc.Location = new System.Drawing.Point(109, 205);
		this.Night2Desc.Name = "Night2Desc";
		this.Night2Desc.Size = new System.Drawing.Size(173, 56);
		this.Night2Desc.TabIndex = 0;
		this.Night2Desc.Text = "Night one Desc.";
		// 
		// day2Desc
		// 
		this.day2Desc.Location = new System.Drawing.Point(109, 28);
		this.day2Desc.Name = "day2Desc";
		this.day2Desc.Size = new System.Drawing.Size(173, 56);
		this.day2Desc.TabIndex = 0;
		this.day2Desc.Text = "Day one Desc.";
		// 
		// night2Label
		// 
		this.night2Label.AutoSize = true;
		this.night2Label.Location = new System.Drawing.Point(3, 189);
		this.night2Label.Name = "night2Label";
		this.night2Label.Size = new System.Drawing.Size(38, 13);
		this.night2Label.TabIndex = 0;
		this.night2Label.Text = "Night2";
		// 
		// day2Label
		// 
		this.day2Label.AutoSize = true;
		this.day2Label.Location = new System.Drawing.Point(3, 12);
		this.day2Label.Name = "day2Label";
		this.day2Label.Size = new System.Drawing.Size(32, 13);
		this.day2Label.TabIndex = 0;
		this.day2Label.Text = "Day2";
		// 
		// panel5
		// 
		this.panel5.AutoScroll = true;
		this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel5.Controls.Add(this.night1Pic);
		this.panel5.Controls.Add(this.day1Pic);
		this.panel5.Controls.Add(this.night1cop);
		this.panel5.Controls.Add(this.day1cop);
		this.panel5.Controls.Add(this.Night1Desc);
		this.panel5.Controls.Add(this.day1Desc);
		this.panel5.Controls.Add(this.night1Label);
		this.panel5.Controls.Add(this.day1Label);
		this.panel5.Location = new System.Drawing.Point(7, 3);
		this.panel5.Name = "panel5";
		this.panel5.Size = new System.Drawing.Size(289, 318);
		this.panel5.TabIndex = 2;
		// 
		// night1Pic
		// 
		this.night1Pic.Location = new System.Drawing.Point(3, 205);
		this.night1Pic.Name = "night1Pic";
		this.night1Pic.Size = new System.Drawing.Size(100, 50);
		this.night1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.night1Pic.TabIndex = 1;
		this.night1Pic.TabStop = false;
		// 
		// day1Pic
		// 
		this.day1Pic.Location = new System.Drawing.Point(3, 28);
		this.day1Pic.Name = "day1Pic";
		this.day1Pic.Size = new System.Drawing.Size(100, 50);
		this.day1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.day1Pic.TabIndex = 1;
		this.day1Pic.TabStop = false;
		// 
		// night1cop
		// 
		this.night1cop.AutoSize = true;
		this.night1cop.Location = new System.Drawing.Point(3, 274);
		this.night1cop.Name = "night1cop";
		this.night1cop.Size = new System.Drawing.Size(124, 13);
		this.night1cop.TabIndex = 0;
		this.night1cop.Text = "Chance of Precepitation:";
		// 
		// day1cop
		// 
		this.day1cop.AutoSize = true;
		this.day1cop.Location = new System.Drawing.Point(3, 93);
		this.day1cop.Name = "day1cop";
		this.day1cop.Size = new System.Drawing.Size(124, 13);
		this.day1cop.TabIndex = 0;
		this.day1cop.Text = "Chance of Precepitation:";
		// 
		// Night1Desc
		// 
		this.Night1Desc.Location = new System.Drawing.Point(109, 205);
		this.Night1Desc.Name = "Night1Desc";
		this.Night1Desc.Size = new System.Drawing.Size(173, 56);
		this.Night1Desc.TabIndex = 0;
		this.Night1Desc.Text = "Night one Desc.";
		// 
		// day1Desc
		// 
		this.day1Desc.Location = new System.Drawing.Point(111, 28);
		this.day1Desc.Name = "day1Desc";
		this.day1Desc.Size = new System.Drawing.Size(173, 56);
		this.day1Desc.TabIndex = 0;
		this.day1Desc.Text = "Day one Desc.";
		// 
		// night1Label
		// 
		this.night1Label.AutoSize = true;
		this.night1Label.Location = new System.Drawing.Point(3, 189);
		this.night1Label.Name = "night1Label";
		this.night1Label.Size = new System.Drawing.Size(38, 13);
		this.night1Label.TabIndex = 0;
		this.night1Label.Text = "Night1";
		// 
		// day1Label
		// 
		this.day1Label.AutoSize = true;
		this.day1Label.Location = new System.Drawing.Point(3, 12);
		this.day1Label.Name = "day1Label";
		this.day1Label.Size = new System.Drawing.Size(32, 13);
		this.day1Label.TabIndex = 0;
		this.day1Label.Text = "Day1";
		// 
		// tabPage2
		// 
		this.tabPage2.Controls.Add(this.WEBmapbrowser);
		this.tabPage2.Location = new System.Drawing.Point(4, 22);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(1003, 601);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "Radar Map";
		this.tabPage2.UseVisualStyleBackColor = true;
		// 
		// label1
		// 
		this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
		this.label1.Location = new System.Drawing.Point(12, 644);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(1004, 23);
		this.label1.TabIndex = 6;
		this.label1.Text = "label1";
		// 
		// MainForm
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoScroll = true;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.ClientSize = new System.Drawing.Size(1027, 676);
		this.Controls.Add(this.label1);
		this.Controls.Add(this.tabControl1);
		this.Name = "MainForm";
		this.Text = "weatherVB";
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.picboxN4)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxN3)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxN2)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxN1)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD4)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD3)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD2)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.picboxD1)).EndInit();
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.panel16.ResumeLayout(false);
		this.TabPage3.ResumeLayout(false);
		this.panel15.ResumeLayout(false);
		this.panel8.ResumeLayout(false);
		this.panel8.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.night10Pic)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.day10Pic)).EndInit();
		this.panel11.ResumeLayout(false);
		this.panel11.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.night9Pic)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.day9Pic)).EndInit();
		this.panel13.ResumeLayout(false);
		this.panel13.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.night7Pic)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.day7Pic)).EndInit();
		this.panel10.ResumeLayout(false);
		this.panel10.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.night6Pic)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.day6Pic)).EndInit();
		this.panel14.ResumeLayout(false);
		this.panel14.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.night8Pic)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.day8Pic)).EndInit();
		this.panel12.ResumeLayout(false);
		this.panel12.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.night5Pic)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.day5Pic)).EndInit();
		this.panel9.ResumeLayout(false);
		this.panel9.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.night4Pic)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.day4Pic)).EndInit();
		this.panel7.ResumeLayout(false);
		this.panel7.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.night3Pic)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.day3Pic)).EndInit();
		this.panel6.ResumeLayout(false);
		this.panel6.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.night2Pic)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.day2Pic)).EndInit();
		this.panel5.ResumeLayout(false);
		this.panel5.PerformLayout();
		((System.ComponentModel.ISupportInitialize)(this.night1Pic)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.day1Pic)).EndInit();
		this.tabPage2.ResumeLayout(false);
		this.ResumeLayout(false);

	}
	private System.Windows.Forms.TabPage tabPage2;
	private System.Windows.Forms.TabPage tabPage1;
	private System.Windows.Forms.TabControl tabControl1;
	private System.Windows.Forms.WebBrowser WEBmapbrowser;
	private System.Windows.Forms.Label lblD1pop;
	private System.Windows.Forms.Panel panel1;
	private System.Windows.Forms.PictureBox picboxD1;
	private System.Windows.Forms.Label lblD1;
	private PictureBox picboxN1;
	private Label lblN1pop;
	private Label lblN1;
	private PictureBox picboxN2;
	private PictureBox picboxD2;
	private Label lblN2pop;
	private Label lblD2pop;
	private Label lblN2;
	private Label lblD2;
	private PictureBox picboxN3;
	private PictureBox picboxD3;
	private Label lblN3pop;
	private Label lblD3pop;
	private Label lblN3;
	private Label lblD3;
	private PictureBox picboxN4;
	private PictureBox picboxD4;
	private Label lblN4pop;
	private Label lblD4pop;
	private Label lblN4;
	private Label lblD4;
	internal TabPage TabPage3;
	private GMap.NET.WindowsForms.GMapControl gMap;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Panel panel5;
	private System.Windows.Forms.PictureBox night1Pic;
	private System.Windows.Forms.PictureBox day1Pic;
	private System.Windows.Forms.Label night1cop;
	private System.Windows.Forms.Label day1cop;
	private System.Windows.Forms.Label Night1Desc;
	private System.Windows.Forms.Label day1Desc;
	private System.Windows.Forms.Label night1Label;
	private System.Windows.Forms.Label day1Label;
	private System.Windows.Forms.Panel panel6;
	private System.Windows.Forms.PictureBox night2Pic;
	private System.Windows.Forms.PictureBox day2Pic;
	private System.Windows.Forms.Label night2cop;
	private System.Windows.Forms.Label day2cop;
	private System.Windows.Forms.Label Night2Desc;
	private System.Windows.Forms.Label day2Desc;
	private System.Windows.Forms.Label night2Label;
	private System.Windows.Forms.Label day2Label;
	private System.Windows.Forms.Panel panel7;
	private System.Windows.Forms.PictureBox night3Pic;
	private System.Windows.Forms.PictureBox day3Pic;
	private System.Windows.Forms.Label night3cop;
	private System.Windows.Forms.Label day3cop;
	private System.Windows.Forms.Label Night3Desc;
	private System.Windows.Forms.Label day3Desc;
	private System.Windows.Forms.Label night3Label;
	private System.Windows.Forms.Label day3Label;
	private System.Windows.Forms.Panel panel8;
	private System.Windows.Forms.PictureBox night10Pic;
	private System.Windows.Forms.PictureBox day10Pic;
	private System.Windows.Forms.Label night10cop;
	private System.Windows.Forms.Label day10cop;
	private System.Windows.Forms.Label Night10Desc;
	private System.Windows.Forms.Label day10Desc;
	private System.Windows.Forms.Label night10Label;
	private System.Windows.Forms.Label day10Label;
	private System.Windows.Forms.Panel panel9;
	private System.Windows.Forms.PictureBox night4Pic;
	private System.Windows.Forms.PictureBox day4Pic;
	private System.Windows.Forms.Label night4cop;
	private System.Windows.Forms.Label day4cop;
	private System.Windows.Forms.Label Night4Desc;
	private System.Windows.Forms.Label day4Desc;
	private System.Windows.Forms.Label night4Label;
	private System.Windows.Forms.Label day4Label;
	private System.Windows.Forms.Panel panel12;
	private System.Windows.Forms.PictureBox night5Pic;
	private System.Windows.Forms.PictureBox day5Pic;
	private System.Windows.Forms.Label night5cop;
	private System.Windows.Forms.Label day5cop;
	private System.Windows.Forms.Label Night5Desc;
	private System.Windows.Forms.Label day5Desc;
	private System.Windows.Forms.Label night5Label;
	private System.Windows.Forms.Label day5Label;
	private System.Windows.Forms.Panel panel10;
	private System.Windows.Forms.PictureBox night6Pic;
	private System.Windows.Forms.PictureBox day6Pic;
	private System.Windows.Forms.Label night6cop;
	private System.Windows.Forms.Label day6cop;
	private System.Windows.Forms.Label Night6Desc;
	private System.Windows.Forms.Label day6Desc;
	private System.Windows.Forms.Label night6Label;
	private System.Windows.Forms.Label day6Label;
	private System.Windows.Forms.Panel panel13;
	private System.Windows.Forms.PictureBox night7Pic;
	private System.Windows.Forms.PictureBox day7Pic;
	private System.Windows.Forms.Label night7cop;
	private System.Windows.Forms.Label day7cop;
	private System.Windows.Forms.Label Night7Desc;
	private System.Windows.Forms.Label day7Desc;
	private System.Windows.Forms.Label night7Label;
	private System.Windows.Forms.Label day7Label;
	private System.Windows.Forms.Panel panel14;
	private System.Windows.Forms.PictureBox night8Pic;
	private System.Windows.Forms.PictureBox day8Pic;
	private System.Windows.Forms.Label night8cop;
	private System.Windows.Forms.Label day8cop;
	private System.Windows.Forms.Label Night8Desc;
	private System.Windows.Forms.Label day8Desc;
	private System.Windows.Forms.Label night8Label;
	private System.Windows.Forms.Label day8Label;
	private System.Windows.Forms.Panel panel11;
	private System.Windows.Forms.PictureBox night9Pic;
	private System.Windows.Forms.PictureBox day9Pic;
	private System.Windows.Forms.Label night9cop;
	private System.Windows.Forms.Label day9cop;
	private System.Windows.Forms.Label Night9Desc;
	private System.Windows.Forms.Label day9Desc;
	private System.Windows.Forms.Label night9Label;
	private System.Windows.Forms.Label day9Label;
	private System.Windows.Forms.Panel panel16;
	private System.Windows.Forms.Panel panel15;
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
