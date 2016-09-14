//#define debug	//正在测试的模块
//#undef debug		//已经完成的算法。使用方法：删除本行开始的“//”注释标志。

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Anter.Win32.JL.DSSaveTools
{
    /// <summary>
    /// Form1 的摘要说明。
    /// </summary>
    /// 

    public class frmMain : System.Windows.Forms.Form
	{
		#region 自动代码

		private System.Windows.Forms.Button btnInput;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnM3Rom;
		private System.Windows.Forms.Button btnWii;

		private System.Windows.Forms.CheckBox chkTest;
		private System.Windows.Forms.CheckBox chkPokemon;

		private System.Windows.Forms.ComboBox cboLanguage;
		private System.Windows.Forms.ComboBox cboMode;
		private System.Windows.Forms.ComboBox cboOutputFormat;
		private System.Windows.Forms.ComboBox cboOutputSize;

		private System.Windows.Forms.GroupBox grpFile;
		private System.Windows.Forms.GroupBox grpTest;
		private System.Windows.Forms.GroupBox grpLanguage;
		private System.Windows.Forms.GroupBox grpOutput;
		private System.Windows.Forms.GroupBox grpControl;
		private System.Windows.Forms.GroupBox grpM3;
		private System.Windows.Forms.GroupBox grpMessage;
		private System.Windows.Forms.GroupBox grpChangeMode;
		private System.Windows.Forms.GroupBox groupChkBox;

		private System.Windows.Forms.Label lblInput;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Label lblOutputFormat;
		private System.Windows.Forms.Label lblOutputSize;
		private System.Windows.Forms.Label lblTest512B;
		private System.Windows.Forms.Label lblTest512K;
		private System.Windows.Forms.Label lblTest256K;
		private System.Windows.Forms.Label lblTest128K;
		private System.Windows.Forms.Label lblTest64K;
		private System.Windows.Forms.Label lblTest8K;
		private System.Windows.Forms.Label lblTestEEPROM;
		private System.Windows.Forms.Label lblTest1M;
		private System.Windows.Forms.Label lblM3ShortName;
		private System.Windows.Forms.Label lblM3LongName;
		private System.Windows.Forms.Label lblMessage;

		private System.Windows.Forms.OpenFileDialog dialogOpenSaveFile;
		private System.Windows.Forms.OpenFileDialog dialogOpenROM;

		private System.Windows.Forms.PictureBox picName;

		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.TextBox txtM3ShortName;
		private System.Windows.Forms.TextBox txtM3LongName;

		/// <summary>
		/// 必需的设计器变量。
		/// 
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMain()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.chkPokemon = new System.Windows.Forms.CheckBox();
            this.grpTest = new System.Windows.Forms.GroupBox();
            this.chkTest = new System.Windows.Forms.CheckBox();
            this.lblTest128K = new System.Windows.Forms.Label();
            this.lblTest8K = new System.Windows.Forms.Label();
            this.lblTest64K = new System.Windows.Forms.Label();
            this.lblTest1M = new System.Windows.Forms.Label();
            this.lblTest512K = new System.Windows.Forms.Label();
            this.lblTest256K = new System.Windows.Forms.Label();
            this.lblTest512B = new System.Windows.Forms.Label();
            this.lblTestEEPROM = new System.Windows.Forms.Label();
            this.grpChangeMode = new System.Windows.Forms.GroupBox();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.grpLanguage = new System.Windows.Forms.GroupBox();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblOutputSize = new System.Windows.Forms.Label();
            this.lblOutputFormat = new System.Windows.Forms.Label();
            this.cboOutputSize = new System.Windows.Forms.ComboBox();
            this.cboOutputFormat = new System.Windows.Forms.ComboBox();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.btnWii = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.grpM3 = new System.Windows.Forms.GroupBox();
            this.txtM3ShortName = new System.Windows.Forms.TextBox();
            this.lblM3ShortName = new System.Windows.Forms.Label();
            this.txtM3LongName = new System.Windows.Forms.TextBox();
            this.lblM3LongName = new System.Windows.Forms.Label();
            this.btnM3Rom = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpMessage = new System.Windows.Forms.GroupBox();
            this.dialogOpenSaveFile = new System.Windows.Forms.OpenFileDialog();
            this.dialogOpenROM = new System.Windows.Forms.OpenFileDialog();
            this.picName = new System.Windows.Forms.PictureBox();
            this.groupChkBox = new System.Windows.Forms.GroupBox();
            this.grpFile.SuspendLayout();
            this.grpTest.SuspendLayout();
            this.grpChangeMode.SuspendLayout();
            this.grpLanguage.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpControl.SuspendLayout();
            this.grpM3.SuspendLayout();
            this.grpMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).BeginInit();
            this.groupChkBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFile
            // 
            this.grpFile.Controls.Add(this.lblOutput);
            this.grpFile.Controls.Add(this.lblInput);
            this.grpFile.Controls.Add(this.btnChange);
            this.grpFile.Controls.Add(this.btnInput);
            this.grpFile.Controls.Add(this.txtOutput);
            this.grpFile.Controls.Add(this.txtInput);
            this.grpFile.Location = new System.Drawing.Point(12, 76);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(504, 92);
            this.grpFile.TabIndex = 0;
            this.grpFile.TabStop = false;
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(8, 56);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(56, 20);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "目标文件";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput
            // 
            this.lblInput.Location = new System.Drawing.Point(8, 20);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(56, 20);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "源文件";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChange
            // 
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Location = new System.Drawing.Point(444, 55);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(48, 24);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "转换";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnInput
            // 
            this.btnInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.Location = new System.Drawing.Point(444, 20);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(48, 24);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "打开";
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(64, 56);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(372, 21);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(64, 20);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(372, 21);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // chkPokemon
            // 
            this.chkPokemon.Location = new System.Drawing.Point(16, 16);
            this.chkPokemon.Name = "chkPokemon";
            this.chkPokemon.Size = new System.Drawing.Size(224, 20);
            this.chkPokemon.TabIndex = 6;
            this.chkPokemon.Text = "口袋妖怪强制转换（512K -> 256K）";
            this.chkPokemon.CheckedChanged += new System.EventHandler(this.chkPokemon_CheckedChanged);
            // 
            // grpTest
            // 
            this.grpTest.Controls.Add(this.chkTest);
            this.grpTest.Controls.Add(this.lblTest128K);
            this.grpTest.Controls.Add(this.lblTest8K);
            this.grpTest.Controls.Add(this.lblTest64K);
            this.grpTest.Controls.Add(this.lblTest1M);
            this.grpTest.Controls.Add(this.lblTest512K);
            this.grpTest.Controls.Add(this.lblTest256K);
            this.grpTest.Controls.Add(this.lblTest512B);
            this.grpTest.Controls.Add(this.lblTestEEPROM);
            this.grpTest.Location = new System.Drawing.Point(12, 172);
            this.grpTest.Name = "grpTest";
            this.grpTest.Size = new System.Drawing.Size(504, 40);
            this.grpTest.TabIndex = 1;
            this.grpTest.TabStop = false;
            // 
            // chkTest
            // 
            this.chkTest.Location = new System.Drawing.Point(13, 14);
            this.chkTest.Name = "chkTest";
            this.chkTest.Size = new System.Drawing.Size(60, 20);
            this.chkTest.TabIndex = 14;
            this.chkTest.Text = "测试";
            this.chkTest.CheckedChanged += new System.EventHandler(this.chkTest_CheckedChanged);
            // 
            // lblTest128K
            // 
            this.lblTest128K.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTest128K.Location = new System.Drawing.Point(232, 16);
            this.lblTest128K.Name = "lblTest128K";
            this.lblTest128K.Size = new System.Drawing.Size(50, 16);
            this.lblTest128K.TabIndex = 9;
            this.lblTest128K.Text = "128K";
            this.lblTest128K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTest8K
            // 
            this.lblTest8K.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTest8K.Location = new System.Drawing.Point(128, 16);
            this.lblTest8K.Name = "lblTest8K";
            this.lblTest8K.Size = new System.Drawing.Size(50, 16);
            this.lblTest8K.TabIndex = 11;
            this.lblTest8K.Text = "8K";
            this.lblTest8K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTest64K
            // 
            this.lblTest64K.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTest64K.Location = new System.Drawing.Point(180, 16);
            this.lblTest64K.Name = "lblTest64K";
            this.lblTest64K.Size = new System.Drawing.Size(50, 16);
            this.lblTest64K.TabIndex = 10;
            this.lblTest64K.Text = "64K";
            this.lblTest64K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTest1M
            // 
            this.lblTest1M.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTest1M.Location = new System.Drawing.Point(388, 16);
            this.lblTest1M.Name = "lblTest1M";
            this.lblTest1M.Size = new System.Drawing.Size(50, 16);
            this.lblTest1M.TabIndex = 13;
            this.lblTest1M.Text = "1M";
            this.lblTest1M.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTest512K
            // 
            this.lblTest512K.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTest512K.Location = new System.Drawing.Point(336, 16);
            this.lblTest512K.Name = "lblTest512K";
            this.lblTest512K.Size = new System.Drawing.Size(50, 16);
            this.lblTest512K.TabIndex = 7;
            this.lblTest512K.Text = "512K";
            this.lblTest512K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTest256K
            // 
            this.lblTest256K.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTest256K.Location = new System.Drawing.Point(284, 16);
            this.lblTest256K.Name = "lblTest256K";
            this.lblTest256K.Size = new System.Drawing.Size(50, 16);
            this.lblTest256K.TabIndex = 8;
            this.lblTest256K.Text = "256K";
            this.lblTest256K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTest512B
            // 
            this.lblTest512B.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTest512B.Location = new System.Drawing.Point(76, 16);
            this.lblTest512B.Name = "lblTest512B";
            this.lblTest512B.Size = new System.Drawing.Size(50, 16);
            this.lblTest512B.TabIndex = 6;
            this.lblTest512B.Text = "512B";
            this.lblTest512B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTestEEPROM
            // 
            this.lblTestEEPROM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTestEEPROM.Location = new System.Drawing.Point(444, 16);
            this.lblTestEEPROM.Name = "lblTestEEPROM";
            this.lblTestEEPROM.Size = new System.Drawing.Size(50, 16);
            this.lblTestEEPROM.TabIndex = 12;
            this.lblTestEEPROM.Text = "EEPROM";
            this.lblTestEEPROM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpChangeMode
            // 
            this.grpChangeMode.Controls.Add(this.cboMode);
            this.grpChangeMode.Location = new System.Drawing.Point(336, 16);
            this.grpChangeMode.Name = "grpChangeMode";
            this.grpChangeMode.Size = new System.Drawing.Size(72, 56);
            this.grpChangeMode.TabIndex = 2;
            this.grpChangeMode.TabStop = false;
            this.grpChangeMode.Text = "转换模式";
            // 
            // cboMode
            // 
            this.cboMode.BackColor = System.Drawing.SystemColors.Window;
            this.cboMode.Location = new System.Drawing.Point(8, 24);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(56, 20);
            this.cboMode.TabIndex = 0;
            this.cboMode.SelectedIndexChanged += new System.EventHandler(this.cboMode_SelectedIndexChanged);
            // 
            // grpLanguage
            // 
            this.grpLanguage.Controls.Add(this.cboLanguage);
            this.grpLanguage.Location = new System.Drawing.Point(412, 16);
            this.grpLanguage.Name = "grpLanguage";
            this.grpLanguage.Size = new System.Drawing.Size(104, 56);
            this.grpLanguage.TabIndex = 3;
            this.grpLanguage.TabStop = false;
            this.grpLanguage.Text = "Language";
            // 
            // cboLanguage
            // 
            this.cboLanguage.BackColor = System.Drawing.SystemColors.Window;
            this.cboLanguage.Location = new System.Drawing.Point(8, 24);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(88, 20);
            this.cboLanguage.TabIndex = 0;
            this.cboLanguage.SelectedIndexChanged += new System.EventHandler(this.cboLanguage_SelectedIndexChanged);
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblOutputSize);
            this.grpOutput.Controls.Add(this.lblOutputFormat);
            this.grpOutput.Controls.Add(this.cboOutputSize);
            this.grpOutput.Controls.Add(this.cboOutputFormat);
            this.grpOutput.Location = new System.Drawing.Point(12, 216);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(316, 96);
            this.grpOutput.TabIndex = 4;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "输出格式";
            // 
            // lblOutputSize
            // 
            this.lblOutputSize.Location = new System.Drawing.Point(16, 60);
            this.lblOutputSize.Name = "lblOutputSize";
            this.lblOutputSize.Size = new System.Drawing.Size(60, 20);
            this.lblOutputSize.TabIndex = 3;
            this.lblOutputSize.Text = "输出大小";
            this.lblOutputSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputFormat
            // 
            this.lblOutputFormat.Location = new System.Drawing.Point(16, 28);
            this.lblOutputFormat.Name = "lblOutputFormat";
            this.lblOutputFormat.Size = new System.Drawing.Size(60, 20);
            this.lblOutputFormat.TabIndex = 2;
            this.lblOutputFormat.Text = "输出格式";
            this.lblOutputFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboOutputSize
            // 
            this.cboOutputSize.Location = new System.Drawing.Point(100, 60);
            this.cboOutputSize.Name = "cboOutputSize";
            this.cboOutputSize.Size = new System.Drawing.Size(196, 20);
            this.cboOutputSize.TabIndex = 1;
            // 
            // cboOutputFormat
            // 
            this.cboOutputFormat.Location = new System.Drawing.Point(100, 28);
            this.cboOutputFormat.Name = "cboOutputFormat";
            this.cboOutputFormat.Size = new System.Drawing.Size(196, 20);
            this.cboOutputFormat.TabIndex = 0;
            this.cboOutputFormat.SelectedIndexChanged += new System.EventHandler(this.cboOutputFormat_SelectedIndexChanged);
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.btnWii);
            this.grpControl.Controls.Add(this.btnExit);
            this.grpControl.Controls.Add(this.btnAbout);
            this.grpControl.Location = new System.Drawing.Point(288, 408);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(228, 48);
            this.grpControl.TabIndex = 6;
            this.grpControl.TabStop = false;
            // 
            // btnWii
            // 
            this.btnWii.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWii.Location = new System.Drawing.Point(12, 16);
            this.btnWii.Name = "btnWii";
            this.btnWii.Size = new System.Drawing.Size(60, 24);
            this.btnWii.TabIndex = 2;
            this.btnWii.Text = "WII";
            this.btnWii.Click += new System.EventHandler(this.btnWii_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(156, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 24);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(84, 16);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(60, 24);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "关于";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // grpM3
            // 
            this.grpM3.Controls.Add(this.txtM3ShortName);
            this.grpM3.Controls.Add(this.lblM3ShortName);
            this.grpM3.Controls.Add(this.txtM3LongName);
            this.grpM3.Controls.Add(this.lblM3LongName);
            this.grpM3.Controls.Add(this.btnM3Rom);
            this.grpM3.Enabled = false;
            this.grpM3.Location = new System.Drawing.Point(12, 320);
            this.grpM3.Name = "grpM3";
            this.grpM3.Size = new System.Drawing.Size(316, 88);
            this.grpM3.TabIndex = 7;
            this.grpM3.TabStop = false;
            this.grpM3.Text = "M3 附加选项";
            // 
            // txtM3ShortName
            // 
            this.txtM3ShortName.Location = new System.Drawing.Point(80, 20);
            this.txtM3ShortName.Name = "txtM3ShortName";
            this.txtM3ShortName.ReadOnly = true;
            this.txtM3ShortName.Size = new System.Drawing.Size(120, 21);
            this.txtM3ShortName.TabIndex = 11;
            // 
            // lblM3ShortName
            // 
            this.lblM3ShortName.Location = new System.Drawing.Point(8, 20);
            this.lblM3ShortName.Name = "lblM3ShortName";
            this.lblM3ShortName.Size = new System.Drawing.Size(68, 24);
            this.lblM3ShortName.TabIndex = 9;
            this.lblM3ShortName.Text = "短文件名";
            this.lblM3ShortName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtM3LongName
            // 
            this.txtM3LongName.Location = new System.Drawing.Point(80, 56);
            this.txtM3LongName.Name = "txtM3LongName";
            this.txtM3LongName.ReadOnly = true;
            this.txtM3LongName.Size = new System.Drawing.Size(224, 21);
            this.txtM3LongName.TabIndex = 12;
            // 
            // lblM3LongName
            // 
            this.lblM3LongName.Location = new System.Drawing.Point(8, 56);
            this.lblM3LongName.Name = "lblM3LongName";
            this.lblM3LongName.Size = new System.Drawing.Size(68, 24);
            this.lblM3LongName.TabIndex = 10;
            this.lblM3LongName.Text = "长文件名";
            this.lblM3LongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnM3Rom
            // 
            this.btnM3Rom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnM3Rom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM3Rom.Location = new System.Drawing.Point(204, 20);
            this.btnM3Rom.Name = "btnM3Rom";
            this.btnM3Rom.Size = new System.Drawing.Size(100, 24);
            this.btnM3Rom.TabIndex = 6;
            this.btnM3Rom.Text = "对应M3 ROM文件";
            this.btnM3Rom.Click += new System.EventHandler(this.btnM3Rom_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Location = new System.Drawing.Point(3, 17);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(178, 172);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "正在写入，请稍等……";
            // 
            // grpMessage
            // 
            this.grpMessage.Controls.Add(this.lblMessage);
            this.grpMessage.Location = new System.Drawing.Point(332, 216);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Size = new System.Drawing.Size(184, 192);
            this.grpMessage.TabIndex = 8;
            this.grpMessage.TabStop = false;
            // 
            // picName
            // 
            this.picName.Image = ((System.Drawing.Image)(resources.GetObject("picName.Image")));
            this.picName.Location = new System.Drawing.Point(12, 16);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(316, 56);
            this.picName.TabIndex = 9;
            this.picName.TabStop = false;
            // 
            // groupChkBox
            // 
            this.groupChkBox.Controls.Add(this.chkPokemon);
            this.groupChkBox.Location = new System.Drawing.Point(12, 408);
            this.groupChkBox.Name = "groupChkBox";
            this.groupChkBox.Size = new System.Drawing.Size(268, 48);
            this.groupChkBox.TabIndex = 7;
            this.groupChkBox.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(520, 461);
            this.Controls.Add(this.grpMessage);
            this.Controls.Add(this.grpM3);
            this.Controls.Add(this.grpControl);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpChangeMode);
            this.Controls.Add(this.grpTest);
            this.Controls.Add(this.grpFile);
            this.Controls.Add(this.grpLanguage);
            this.Controls.Add(this.picName);
            this.Controls.Add(this.groupChkBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(536, 500);
            this.MinimumSize = new System.Drawing.Size(536, 500);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DS Save Tools";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            this.grpTest.ResumeLayout(false);
            this.grpChangeMode.ResumeLayout(false);
            this.grpLanguage.ResumeLayout(false);
            this.grpOutput.ResumeLayout(false);
            this.grpControl.ResumeLayout(false);
            this.grpM3.ResumeLayout(false);
            this.grpM3.PerformLayout();
            this.grpMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picName)).EndInit();
            this.groupChkBox.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]

		#endregion

		#region 初始化

		#region Main

		static void Main(string[] args)
		{
			if (args.Length == 3)
			{
				double OutSize = Convert.ToDouble(args[0]);
				string InputName = args[1];
				string OutputName = args[2];

				DOSCommand(OutSize,InputName,OutputName);
			}
			else
			{
				Application.Run(new frmMain());
			}
		}

		#endregion

		#region 变量初始化

		static int NdsCards = 28 + 1;							//支持的NDS烧录卡的数量，“+1”前面的数字和NDS烧录卡最大序号相同
		static int GbaCards =  7 + 1;							//支持的GBA烧录卡的数量，“+1”前面的数字和GBA烧录卡最大序号相同
		string[][] strLanguageForm = new string[16+1][];		//界面语言，“+1”前面的数字和界面语言最大序号相同
		string[][] strLanguageMessage = new string[24+1][];		//提示信息语言，“+1”前面的数字和提示信息语言最大序号相同
		CardType[][] SetupCardType = new CardType[2][];			//烧录卡信息数据
		int[] UsedSize = new int[10];							//存档大小信息

		#endregion

		#region 界面初始化
		private void StartMain() 
		{
			///	启动主窗口时，初始化以下项目：
			///		烧录卡数组		2行		0为DS存档，1为GBA存档
			///		烧录卡列表		1行
			///		语言选择列表	3行
			///		模式选择列表	2行
			///		类型选择列表	1行
			///		输出信息框		1行
			///		附加信息输出	1行
			 
			///	烧录卡数组
			SetupCardType[0] = new CardType[NdsCards];
			SetupCardType[1] = new CardType[GbaCards];

			///	烧录卡列表
			SetCardType();

			///	语言选择列表
			cboLanguage.Items.AddRange(new object[] {"简体中文","繁體中文","English"});
			LanguageText();
			cboLanguage.SelectedIndex = 0;

			///	模式选择列表
			cboMode.Items.AddRange(new object[] {"NDS","GBA"});
			cboMode.SelectedIndex = 0;

			///	类型选择列表
			ChangeMode();

			///	输出信息框
			//ClearMessage();

			///	附加信息输出
			MyData();
		}

		private void LanguageText() 
		{
			/// 初始化界面语言数组
			///	在本列表增计项目时，需要修改“初始化”->“变量初始化”里面的下面两行：
			///		string[][] strLanguageForm = new string[16+1][];		//界面语言，“+1”前面的数字和界面语言最大序号相同
			///		string[][] strLanguageMessage = new string[24+1][];		//提示信息语言，“+1”前面的数字和提示信息语言最大序号相同

			//界面语言
			strLanguageForm[0] = new string[]{"简体中文","繁體中文","English"};	//说明，程序不调用
			strLanguageForm[1] = new string[]{"打开","打開","Open"};   //btnInput
			strLanguageForm[2] = new string[]{"转换","轉換","Change"};   //btnChange
			strLanguageForm[3] = new string[]{"关于","關于","About"};   //btnAbout
			strLanguageForm[4] = new string[]{"退出","退出","Exit"};   //btnExit
			strLanguageForm[5] = new string[]{"对应M3 ROM文件","對應M3 ROM文件","Select M3 ROM"};   //btnM3Rom
			strLanguageForm[6] = new string[]{"测试","測試","Test"};   //chkTest
			strLanguageForm[7] = new string[]{"输出格式选择","輸出格式選擇","Output Type"};   //grpOutput
			strLanguageForm[8] = new string[]{"M3附加选项","M3附加選項","M3 Adding"};   //grpM3
			strLanguageForm[9] = new string[]{"转换模式","轉換糢式","Mode"};   //grpChangeMode
			strLanguageForm[10] = new string[]{"源文件","源文件","Input"};   //lblInput
			strLanguageForm[11] = new string[]{"目标文件","目標文件","Output"};   //lblOutput
			strLanguageForm[12] = new string[]{"输出格式","輸出格式","Type"};   //lblOutputFormat
			strLanguageForm[13] = new string[]{"输出大小","輸出大小","Size"};   //lblOutputSize
			strLanguageForm[14] = new string[]{"短文件名","短文件名","Short Name"};   //lblM3ShortName
			strLanguageForm[15] = new string[]{"长文件名","長文件名","Long Name"};   //lblM3LongName
			strLanguageForm[16] = new string[]{"口袋妖怪强制转换（512K -> 256K）","口袋妖怪强制轉換（512K -> 256K）","Pokemon Change(512K -> 256K)"};   //chkPokemon

			//提示信息语言                                                 */
			strLanguageMessage[0] = new string[]{"简体中文","繁體中文","English"};   //说明，程序不调用
			strLanguageMessage[1] = new string[]{"完成！","完成！","OK"};   //strChangeOK
			strLanguageMessage[2] = new string[]{"失败!","失敗！","Fail!"};   //strChangeError
			strLanguageMessage[3] = new string[]{"M3附加部分写入失败!","M3附加部分寫入失敗！","M3 Adding Error!"};   //strM3AddError
			strLanguageMessage[4] = new string[]{"DSLink附加部分写入失败!","DSLink附加部分寫入失敗！","DSLink Adding Error!"};   //strDSLinkAddError
			strLanguageMessage[5] = new string[]{"请选择源存档文件","請選擇存檔文件","Please select input save file."};   //strSelectInput
			strLanguageMessage[6] = new string[]{"请选择M3存档对应的ROM","請選擇M3存檔對應的ROM","Please select M3 ROM"};   //strSelectM3ROM
			strLanguageMessage[7] = new string[]{"请稍等…","請稍等…","Please wait..."};   //strWait
			strLanguageMessage[8] = new string[]{"转换前格式：","轉換前格式：","Input Format:"};   //strMgeInputFormat
			strLanguageMessage[9] = new string[]{"转换后格式：","轉換后格式：","Output Format:"};   //strMgeOutputFormat
			strLanguageMessage[10] = new string[]{"转换前大小：","轉換前大小：","Input Size:"};   //strMgeInputSize
			strLanguageMessage[11] = new string[]{"转换后大小：","轉換后大小：","Output Size:"};   //strMgeOutputSize
			strLanguageMessage[12] = new string[]{"正在写入，请稍等……","正在寫入，請稍等……","Writting,please Wait..."};   //strMgeWait
			strLanguageMessage[13] = new string[]{"正在写入DSLink附加...","正在寫入DSLink附加...","Writting DSLink Add..."};   //strMgeDSLinkAdd
			strLanguageMessage[14] = new string[]{"正在写入M3附加.....","正在寫入M3附加.....","Writting M3 Add....."};   //strMgeM3Add
			strLanguageMessage[15] = new string[]{"写入成功！","寫入成功！","OK!"};   //strMgeOK
			strLanguageMessage[16] = new string[]{"转换成功！","轉換成功！","Change OK!"};   //strMgeChangeOk
			strLanguageMessage[17] = new string[]{"写入失败！","寫入失敗！","Error!"};   //strMgeError
			strLanguageMessage[18] = new string[]{"源文件读取失败！","源文件讀取失敗！","Input Read Error!"};   //strMgeReadError
			strLanguageMessage[19] = new string[]{"未知错误！！","未知錯誤！！","Unknown Error!"};   //default
			strLanguageMessage[20] = new string[]{"有用数据可能大小：","有用數據可能大小：","Used Data Size：list："};   //usedSize
			strLanguageMessage[21] = new string[]{"使用存档：","使用存檔：","Use Save："};   //pokemon
			strLanguageMessage[22] = new string[]{"预转换：","預轉換：","First Change:"};   //预转换
			strLanguageMessage[23] = new string[]{"口袋妖怪强制转换：","口袋妖怪强制轉換：","Pokemon Change:"};   //口袋妖怪强制转换
			strLanguageMessage[24] = new string[]{"源存档格式错误！","源存檔格式錯誤！","Input Error！"};   //源存档错误

		}

		#endregion

		#region 烧录卡信息初始化
		public struct CardType 
		{
			//烧录卡信息的结构定义
			public int CardMode;		//烧录卡模式：0为NDS，1为GBA
			public string CardName;		//烧录卡名称
			public string CardSName;	//烧录卡简称
			public string CardSaveType;	//烧录卡支持的存档大小：十位字符串，0为不支持，1为支持（可否改为字符数组？）
			public int SelectIndex;		//烧录卡所支持的存档大小中默认的项目序号
			public int Only256;			//烧录卡仅支持256K存档格式标识，1为仅支持256K，0为支持其它体积
			public string CardExt;		//烧录卡所支持存档后缀
			public int CardIs;			//特殊烧录卡标识：1为M3,2为DSLink，0为其他烧录卡
			public string CardInfo;		//烧录卡说明

			//烧录卡信息的构造函数
			public CardType(int CardModeI,string CardNameI,string CardSNameI,string CardSaveTypeI,int SelectIndexI,int Only256I,string CardExtI,int CardIsI,string CardInfoI) 
			{
				CardMode = CardModeI;
				CardName = CardNameI;
				CardSName = CardSNameI;
				CardSaveType = CardSaveTypeI;
				SelectIndex = SelectIndexI;
				Only256 =Only256I;
				CardExt = CardExtI;
				CardIs = CardIsI;
				CardInfo = CardInfoI;
			}

			
			/************************************
			//空白的初始化构造函数
			public CardType() 
			{
				CardMode = 0;
				CardName = "No Name";
				CardSName = "None";
				CardSaveType = "0000000";
				SelectIndex = "0";
				CardExt = ".None";
				CardIs = 0;
				CardInfo = "Null";
			}
			*************************************/
		}

		private void SetCardType() 
		{
			/// 对烧录卡进行支持
			///	在本列表增计项目时，需要修改“初始化”->“变量初始化”里面的下面两行：
			///		static int NdsCards = 26 + 1;		//支持的NDS烧录卡的数量，“+1”前面的数字和NDS烧录卡最大序号相同
			///		static int GbaCards =  7 + 1;		//支持的GBA烧录卡的数量，“+1”前面的数字和GBA烧录卡最大序号相同
			///		
			///	（准备把other挪到0号，改名为No select）

			//以下是NDS烧录卡列表
			SetupCardType[0][0] = new CardType(0,"Normal 512K","512K","0000010000",1,0,".sav",0,"通用的512K存档格式，大多数新烧录卡使用这种格式。");
			SetupCardType[0][1] = new CardType(0,"Acekard+ & Acekard RPG","AK","1110110000",4,0,".nds.sav",0,"slot1接口，使用TF卡和内置(RPG专有)存储，标准存档格式，需选择大小。");
			SetupCardType[0][2] = new CardType(0,"Acekard 2","AK2","0000010000",1,0,".sav",0,"slot1接口，使用TF卡存储，标准512K存档格式。 ");
			SetupCardType[0][3] = new CardType(0,"CycloDS Evolution","CyDS","0000010000",1,0,".sav",0,"slot1接口，使用TF卡存储，标准512K存档格式。  ");
			SetupCardType[0][4] = new CardType(0,"DS FIRE LINK","DSFLK","0000100000",1,1,".sav",0,"DSGBA OEM产品，slot1+2接口，使用内置存储芯片，标准256K存档格式。");
			SetupCardType[0][5] = new CardType(0,"DSGBA","DSGBA","0000100000",1,1,".sav",0,"slot1+2接口，使用内置存储芯片，标准256K存档格式。");
			SetupCardType[0][6] = new CardType(0,"DSLink","DSLK","0000010000",1,0,".sav",2,"slot1接口，使用内置存储芯片，固定的520K特有存档格式。");
			SetupCardType[0][7] = new CardType(0,"DSTT (Top Toy)","DSTT","0000010000",1,0,".sav",0,"slot1接口，使用TF卡存储，标准512K存档格式。");
			SetupCardType[0][8] = new CardType(0,"DS-Xtreme 4Gb/16Gb","DSXr","0000100000",1,1,".sav",0,"slot1接口，使用内置存储芯片，标准256K存档格式。");
			SetupCardType[0][9] = new CardType(0,"EDGE","EDGE","0000010000",1,0,".sav",0,"slot1接口，使用TF卡存储，标准512K存档格式。 ");
			SetupCardType[0][10] = new CardType(0,"EWIN2","EW2","0000110000",2,1,".sav",0,"slot2接口，使用内置存储芯片，标准存档格式，新版本体积512K，旧版本体积为256K。");
			SetupCardType[0][11] = new CardType(0,"EZ Flash 4","EZ4","0000100000",1,1,".sav",0,"slot2接口DS和GBA双用烧录卡，使用内置存储芯片，DS模式采用256K标准存档格式。");
			SetupCardType[0][12] = new CardType(0,"EZ Flash 5","EZ5","1110110000",4,0,".sav",0,"slot1接口，使用TF卡存储，标准存档格式，需选择大小。");
			SetupCardType[0][13] = new CardType(0,"G6 (Lite)","G6","0000110000",1,0,".0",0,"slot2接口DS和GBA双用烧录卡，使用内置存储芯片，DS模式采用256K或512K标准存档格式。");
			SetupCardType[0][14] = new CardType(0,"G6 DS Real","G6DSR","0000010000",1,0,".sav",0,"slot1接口，使用内置存储芯片，512K标准存档格式。");
			SetupCardType[0][15] = new CardType(0,"M3 (Lite)","M3","0000110000",1,0,".dat",1,"slot2接口DS和GBA双用烧录卡，使用SD或mini SD卡存储，DS模式采用257K或513K特有存档格式。");
			SetupCardType[0][16] = new CardType(0,"M3 DS Real","M3DSR","0000010000",1,0,".sav",0,"slot1接口，使用TF卡存储，512K标准存档格式。");
			SetupCardType[0][17] = new CardType(0,"M3 DS Simply","M3DSS","0000010000",1,0,".sav",0,"slot1接口，使用TF卡存储，512K标准存档格式。");
			SetupCardType[0][18] = new CardType(0,"MK5","MK5","0000100000",1,1,".sav",0,"DSGBA OEM产品，slot1+2接口，使用内置存储芯片，标准256K存档格式。");
			SetupCardType[0][19] = new CardType(0,"N-CARD","NCARD","0000100000",1,1,".sav",0,"DSGBA OEM产品，slot1+2接口，使用内置存储芯片，标准256K存档格式。");
			SetupCardType[0][20] = new CardType(0,"NinjaDS","NjaDS","0000010000",1,0,".sav",0,"slot1接口，使用内置存储芯片，标准512K存档格式。 ");
			SetupCardType[0][21] = new CardType(0,"NinjaPass","NjaPa","0000100000",1,1,".sav",0,"slot1接口，使用内置存储芯片，标准256K存档格式。 ");
			SetupCardType[0][22] = new CardType(0,"R4","R4","0000010000",1,0,".sav",0,"slot1接口，使用TF卡存储，标准512K存档格式。 ");
			SetupCardType[0][23] = new CardType(0,"Super Card (Lite)","SC","0000110000",1,1,".nds.sav",0,"slot2接口DS和GBA双用烧录卡，使用SD或mini SD卡存储，DS模式采用256K或512K标准存档格式。");
			SetupCardType[0][24] = new CardType(0,"Super Card DS (ONE)","SCDS","1110110000",4,0,".sav",0,"slot1接口，使用TF卡存储，标准存档格式。");
			SetupCardType[0][25] = new CardType(0,"SUNNY FLASH","SYFH","0000100000",1,1,".sav",0,"DSGBA OEM产品，slot1+2接口，使用内置存储芯片，标准256K存档格式。");
			SetupCardType[0][26] = new CardType(0,"(EMU) NO$GBA (Raw)","NO$GBA","0000010000",1,0,".sav",0,"PC用模拟器，使用512K标准存档格式或自有的特有存档格式。");
            SetupCardType[0][27] = new CardType(0, "(EMU) DeSmuME", "DeSmuME", "0010010000", 2, 0, ".dsv", 0, "PC用模拟器，DeSmuME 特有存档格式。\n\r\n\r仍然推荐你使用该模拟器的导入功能！");
            SetupCardType[0][28] = new CardType(0,"Other (All Sizes)","OTHER","1111111000",5,1,".sav",0,"适用于所有的的DS模式标准存档格式的烧录卡。");

			//以下是GBA烧录卡列表
			SetupCardType[1][0] = new CardType(1,"EZ 3IN1","3IN1","0001000000",1,0,".sav",0,"slot2接口GBA烧录卡，使用内置存储芯片，标准128K存档格式。");
			SetupCardType[1][1] = new CardType(1,"Elink (Lite)","Elink","1111000000",3,0,".sav",0,"slot2接口GBA烧录卡，使用内置存储芯片，标准存档格式。");
			SetupCardType[1][2] = new CardType(1,"EZ4","EZ4","0001000000",1,0,".sav",0,"slot2接口DS和GBA双用烧录卡，使用内置存储芯片，GBA模式采用128K标准存档格式。");
			SetupCardType[1][3] = new CardType(1,"G6 (Lite)","G6","0001000000",1,0,".0",0,"slot2接口DS和GBA双用烧录卡，使用内置存储芯片，GBA模式采用128K标准存档格式。");
			SetupCardType[1][4] = new CardType(1,"GBA Expansion Pack","GBAEP","0001000000",1,0,".0",0,"slot2接口GBA烧录卡，使用内置存储芯片，标准128K存档格式。");
			SetupCardType[1][5] = new CardType(1,"M3 (Lite)","M3","0001001000",1,0,".dat",1,"slot2接口DS和GBA双用烧录卡，使用SD或mini SD卡存储，GBA模式采用129K或1M特有存档格式。");
			SetupCardType[1][6] = new CardType(1,"Super Card (Lite)","SC","0001000000",1,0,".nds.sav",0,"slot2接口DS和GBA双用烧录卡，使用SD或mini SD卡存储，GBA模式采用128K标准存档格式。");
			SetupCardType[1][7] = new CardType(1,"Other (All Sizes)","OTHER","1111111000",4,0,".sav",0,"适用于所有的GBA模式标准存档格式的烧录卡。");

		}

		#endregion

		#endregion

		#region  控件

		#region   按钮
		private void btnInput_Click(object sender, System.EventArgs e) 
		{
			///文件名处理
			txtInput.Text = OpenInputFile();
			ClearMessage();

			///用测试程序测试源文件类型
			if(txtInput.Text != "" && chkTest.Checked) 
			{
				StartTest(txtInput.Text);
			}
		}

		private void btnChange_Click(object sender, System.EventArgs e) 
		{
			ClearMessage();

			///查看主界面输入的信息是否完整，如完整，则开始转换，如不完整，分情况提示信息：
			///	1、未指定源文件时
			///	2、输出文件为M3格式，但未指定ROM文件时

			if(txtInput.Text == "") 
			{
				ShowMessageBox(5,"Error");
			}
			else if(SelectedCardType.CardIs == 1 && txtM3ShortName.Text == "") 
			{
				ShowMessageBox(6,"Error");	
			}
			else 
			{
				StartChange(chkPokemon.Checked);
			}
		}
		
		private void btnAbout_Click(object sender, System.EventArgs e) 
		{
			frmAbout AbtForm = new frmAbout();
			if(AbtForm.ShowDialog(this) == DialogResult.OK) 
			{
				//We would apply changes here since the user accepted them
			}
			AbtForm.Dispose();
		}

		private void btnExit_Click(object sender, System.EventArgs e) 
		{
			Close();
		}

		private void btnM3Rom_Click(object sender, System.EventArgs e) 
		{
			string strM3RomName = OpenROMFile();
			if(strM3RomName != "")
			{
				FileInfo fi = new FileInfo(strM3RomName);
				txtM3LongName.Text = fi.Name;
				txtM3ShortName.Text = ToShortPathName(fi.Name.ToString());
			}
		}

		private void btnWii_Click(object sender, System.EventArgs e) 
		{
			frmWii WiiForm = new frmWii();
			if(WiiForm.ShowDialog(this) == DialogResult.OK) 
			{
				//We would apply changes here since the user accepted them
			}
			WiiForm.Dispose();
		}

		#endregion

		#region   列表框
		private void cboLanguage_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			LanguageChange();
		}

		private void cboMode_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			ChangeMode();

			if(txtInput.Text != "" && chkTest.Checked)
			{
				StartTest(txtInput.Text);   //测试程序
			}
		}

		private void cboOutputFormat_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtOutput.Text = InputToOutput(txtInput.Text);

			SetSaveSize();
			if(SelectedCardType.Only256 == 1)
			{
				chkPokemon.Enabled = true;
			}
			else
			{
				chkPokemon.Enabled = false;
			}

			ClearMessage();

			ShowMessage("烧录卡说明："+SelectedCardType.CardInfo);		//显示烧录卡说明信息

			if(SelectedCardType.CardIs == 1)
				grpM3.Enabled = true; 
			else
				grpM3.Enabled = false;
		}

		#endregion

		#region   复选框
		private void chkTest_CheckedChanged(object sender, System.EventArgs e) 
		{
			///在勾选本复选框后，系统自动对源存档进行测试，除掉本复选框后，清除测试结果
			if(chkTest.Checked && txtInput.Text != "") 
			{
				StartTest(txtInput.Text);
			}
			else 
			{
				ShowTestMap("00000000");
			}
		}

		private void chkPokemon_CheckedChanged(object sender, System.EventArgs e) 
		{
			///口袋妖怪强制转换复选框
			if(chkPokemon.Checked) 
			{
				cboOutputSize.Enabled =false;
				MessageBox.Show("本功能仅限于将体积为512K的口袋妖怪珍珠/钻石存档\n转换成256K的存档，其它类型的转换请不要选择此功能。","口袋妖怪强制转换（512K->256K）");
			}
			else 
			{
				cboOutputSize.Enabled =true;
			}	
		}

		#endregion

		#region   其他
		private void frmMain_Load(object sender, System.EventArgs e) 
		{
			StartMain();
		}

		private void txtInput_TextChanged(object sender, System.EventArgs e) 
		{
			txtOutput.Text = InputToOutput(txtInput.Text);
		}

		private void myAllControl (bool boolOnOff) 
		{
			///界面控件可访问性控制
			grpFile.Enabled = boolOnOff;
			grpTest.Enabled = boolOnOff;
			grpOutput.Enabled = boolOnOff;
			grpMessage.Enabled = boolOnOff;
			grpControl.Enabled = boolOnOff;
			grpM3.Enabled = boolOnOff;

			if(boolOnOff && SelectedCardType.CardIs == 1)
				grpM3.Enabled = true;
			else
				grpM3.Enabled = false;
		}

		#endregion

		#endregion

		#region 输出信息
		private void ShowMessage(string OutputMessage) 
		{
			///直接输出信息
			///

			lblMessage.Text += OutputMessage;
		}

		private void ClearMessage()
		{
			lblMessage.Text = "";
		}

		private void ShowMessage(int OutputMessageID,int myEnter)
		{
			///转换过程中的信息
			///1为前换行
			///2为后换行
			///3为前后均换行
			if ( myEnter == 1 || myEnter == 3) 
			{
				ShowMessage("\n");
			}

			ShowMessage(strLanguageMessage[OutputMessageID][SelectedLanguage]);

			if ( myEnter == 2 || myEnter == 3)
			{
				ShowMessage("\n");
			}
		}

		private void ShowMessage(string InputType,int sriLength,int intLengthMaxEnd,bool IsM3Gba1MB)
		{
			///转换前后的信息
			///

			int intOutSize = new int();		//目标存档大小
			
			//如果目标为M3的GBA格式1M存档，输出“1M”，否则输出intLengthMaxEnd
			if ( IsM3Gba1MB)
			{
				intOutSize = 1024 * 1024;
			}
			else
			{
				intOutSize = intLengthMaxEnd;
			}

			ShowMessage ( strLanguageMessage[ 8][SelectedLanguage] + InputType + "\n");
			ShowMessage ( strLanguageMessage[10][SelectedLanguage] + SizeMessage (sriLength) + "\n");
			ShowMessage ( strLanguageMessage[ 9][SelectedLanguage] + SelectedCardType.CardSName + "\n");
			ShowMessage ( strLanguageMessage[11][SelectedLanguage] + SizeMessage (intOutSize) + " \n");
			ShowMessage ( 12, 0);

		}

		private void ShowMessage(string InputType,int sriLength)
		{
			///预处理信息
			///
			ShowMessage ( strLanguageMessage[22][SelectedLanguage] + "\n");
			ShowMessage ( strLanguageMessage[ 8][SelectedLanguage] + InputType + "\n");
			ShowMessage ( strLanguageMessage[10][SelectedLanguage] + SizeMessage(sriLength) + "\n");
			ShowMessage ( "----------------\n");
		}

		private void ShowMessageBox(int MessageID,string MessageHead)
		{
			MessageBox.Show(strLanguageMessage[MessageID][SelectedLanguage],MessageHead);
		}

		private string SizeMessage(int OutputSize)
		{
			///获取源存档实际体积
			string PrintSize;

			if ( OutputSize < 1024)
			{
				PrintSize = OutputSize.ToString() + " Byte";
			}
			else if ( OutputSize < 1024 * 1024)
			{
				OutputSize = OutputSize / 1024;
				PrintSize = OutputSize.ToString() + " KB";
			}
			else
			{
				OutputSize = OutputSize / 1024 / 1024;
				PrintSize = OutputSize.ToString() + " MB";
			}
			return PrintSize;	
		}

		private void MyData()
		{
			//输出部分与转换无关的提示信息

			//取得系统日期
			DateTime myNowDate = DateTime.Now;

			//小蚂蚁工作室成员生日提醒
			if ( myNowDate.Month == 8 && myNowDate.Day == 23 )
			{
				ShowMessage ( "Happy Birthday To chtpalnn!" );
			}
			else if ( myNowDate.Month == 8 && myNowDate.Day == 26 )
			{
				ShowMessage ( "Happy Birthday To ANTer!" );
			}
		}
		
		#endregion

		#region 文件输入输出操作
		private string OpenInputFile()		//打开源存档文件
		{
			///	打开源存档文件
			///		正常打开，返回值为文件带路径全名
			///		打开失败，返回值为空
			///		

			string OpenFilter = "";
			//OpenFilter += "All Save Files(*.sav;*.bak;*.dat;*.0;*.1;*.2;*.dss;*.dst;*.duc)|*.sav;*.bak;*.dat;*.0;*.1;*.2;*.dss;*.dst;*.duc|";
			OpenFilter += "All Save Files(*.sav;*.bak;*.dat;*.0;*.1;*.2;*.dst;*.dsv;*.duc)|*.sav;*.bak;*.dat;*.0;*.1;*.2;*.dst;*.dsv;*.duc|";
			OpenFilter += "Save Files(*.sav)|*.sav|";
			OpenFilter += "R4 & M3DSS Save BackUp Files(*.bak)|*.bak|";
			OpenFilter += "M3 Save Files(*.dat)|*.dat|";
			OpenFilter += "SC & AK Save Files(*.nds.sav)|*.nds.sav|";
			OpenFilter += "G6 Save Files(*.0;*.1;*.2)|*.0;*.1;*.2|";
			//OpenFilter += "Action Replay Max DS Save Files(*.dss;*.dst;*.duc)|*.dss;*.dst;*.duc|";
			OpenFilter += "Action Replay Max DS Save Files(*.dst;*.duc)|*.dst;*.duc|";
            OpenFilter += "DeSmuME Save Files(*.dsv)|*.dsv|";
            OpenFilter += "All Files(*.*)|*.*";

			dialogOpenSaveFile.Filter = OpenFilter;

			if (dialogOpenSaveFile.ShowDialog() == DialogResult.OK)
			{
				return(dialogOpenSaveFile.FileName);
			}
			else
			{
				return("");
			}
		}

		public string OpenROMFile()			//打开M3对应的ROM文件
		{
			string OpenFilter = "";

			OpenFilter += "DS & GBA ROM Files(*.nds;*.gba)|*.nds;*.gba|";
			OpenFilter += "DS ROM Files(*.nds)|*.nds|";
			OpenFilter += "GBA ROM Files(*.gba)|*.gba|";
			OpenFilter += "All Files(*.*)|*.*";

			dialogOpenROM.Filter = OpenFilter;

			if (dialogOpenROM.ShowDialog() == DialogResult.OK)
			{
				return(dialogOpenROM.FileName);
			}
			else
			{
				return("");
			}
		}

		private string InputToOutput(string tempFileName)		//产生输出的文件名
		{
			if (tempFileName != "")
			{
				int strIndex = tempFileName.LastIndexOf('.');

				if(strIndex >= 0)
				{
					tempFileName = tempFileName.Substring(0,strIndex);
				}
				return (tempFileName + "." + SelectedCardType.CardSName + SelectedCardType.CardExt);
			}
			else					//源文件为空时，目标文件也要为空
			{
				return ("");
			}
		}

		#endregion

		#region 短文件名支持

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]			//kernel32.dll为

		public static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)]  string path, [MarshalAs(UnmanagedType.LPTStr)]  StringBuilder shortPath, int shortPathLength);

		public static string ToShortPathName(string longName)
		{
			StringBuilder shortNameBuffer = new StringBuilder(256);

			int bufferSize = shortNameBuffer.Capacity;

			int result = GetShortPathName(longName, shortNameBuffer, bufferSize);

			return shortNameBuffer.ToString();
		}

		#endregion

		#region 用户选择

		#region 类型选择
		private void LanguageChange()		//转变界面语言
		{
			btnInput.Text = strLanguageForm[1][SelectedLanguage];
			btnChange.Text = strLanguageForm[2][SelectedLanguage];
			btnAbout.Text = strLanguageForm[3][SelectedLanguage];
			btnExit.Text = strLanguageForm[4][SelectedLanguage];
			btnM3Rom.Text = strLanguageForm[5][SelectedLanguage];
			chkTest.Text = strLanguageForm[6][SelectedLanguage];
			grpOutput.Text = strLanguageForm[7][SelectedLanguage];
			grpM3.Text = strLanguageForm[8][SelectedLanguage];
			grpChangeMode.Text = strLanguageForm[9][SelectedLanguage];
			lblInput.Text = strLanguageForm[10][SelectedLanguage];
			lblOutput.Text = strLanguageForm[11][SelectedLanguage];
			lblOutputFormat.Text = strLanguageForm[12][SelectedLanguage];
			lblOutputSize.Text = strLanguageForm[13][SelectedLanguage];
			lblM3ShortName.Text = strLanguageForm[14][SelectedLanguage];
			lblM3LongName.Text = strLanguageForm[15][SelectedLanguage];
			chkPokemon.Text = strLanguageForm[16][SelectedLanguage];
		}
		private void ChangeMode()      //转换后类型列表
		{
			int i = new int();

			cboOutputFormat.Items.Clear();

			for ( i = 0 ; i < SetupCardType[SelectedMode].Length ; i++ )
			{
				cboOutputFormat.Items.Add ( SetupCardType[SelectedMode][i].CardName );
			}

			cboOutputFormat.Refresh();
			cboOutputFormat.SelectedIndex = 0;
		}

		private void SetSaveSize()		 //转换后存档体积列表
		{
			int[] SizeList = new int[10]{(int)(0.5*1024),8*1024,64*1024,128*1024,256*1024,512*1024,1024*1024,2*1024*1024,4*1024*1024,8*1024*1024};
			string[] SizeName = new string[10]{"512 Byte (4K bit)","8K Byte (64K bit)","64K Byte (512K bit)","128K Byte (1M bit)","256K Byte (2M bit)","512K Byte (4M bit)","1M Byte (8M bit)","2M Byte (16M bit)","4M Byte (32M bit)","8M Byte (64M bit)"};
			int UsedIndex = 0;
			int i;
			string SaveSize = "";

			for(i=0;i<10;i++)
			{
				UsedSize[i] = 0;
			}

			cboOutputSize.Items.Clear();

			SaveSize = SelectedCardType.CardSaveType;

			for(i=0;i<10;i++)
			{
				if(SaveSize[i] == '1')
				{
					cboOutputSize.Items.Add(SizeName[i]);
					UsedSize[UsedIndex++] = SizeList[i];
				}
			}

			cboOutputSize.Refresh();
			cboOutputSize.SelectedIndex = SelectedCardType.SelectIndex - 1;
		}

		#endregion

		#region 获取用户所做的选择
		private CardType SelectedCardType			//获得所选择转换的烧录卡格式
		{
			get
			{
				return SetupCardType[SelectedMode][cboOutputFormat.SelectedIndex];
			}
		}

		private int SelectedLanguage		//获得所选择语言
		{
			get
			{
				return cboLanguage.SelectedIndex;
	
			}
		}

		private int SelectedMode			//获得所选择转换模式
		{
			get
			{
				return cboMode.SelectedIndex;
	
			}
		}

		private int SelectedSize			//获得所选择转换体积
		{
			get
			{
				return cboOutputSize.SelectedIndex;
	
			}
		}

		private string ReadFileName(string NameType)	//读取界面上文本框内的信息
		{
			switch (NameType)
			{
				case "InputName":
					return(txtInput.Text);
				case "OutputName":
					return(txtOutput.Text);
				case "M3LongName":
					return(txtM3LongName.Text);
				case "M3ShortName":
					return(txtM3ShortName.Text);
				default:
					return("Error!");
			}

		}

		#endregion

		#endregion

		#region  核心程序

		#region  正常转换
		private void StartChange(bool boolPokemon)
		{
			///
			///判断源存档格式，选取不同的转换方式
			///
			string strNameTemp = "";						//预转换的完整临时文件名
			string strNameChange = "";						//用以转换的完整文件名
			string strInputName = ReadFileName("InputName");	//源存档完整文件名
			string strOutputName = ReadFileName("OutputName");	//目标存档完整文件
			string strInputMode = InputFileMode(strInputName);	//源存档格式
			
			//判断源存档格式，对部分格式的源存档进行预转换
			if(strInputMode == "Com NO$GBA")
			{
				strNameTemp = NOGBACompressedChange ( strInputName );
				strNameChange = strNameTemp;
			}
			else if ( strInputMode == "AR DST")
			{
				strNameTemp = ARDSTChange ( strInputName );
				strNameChange = strNameTemp;
			}
			else
			{
				strNameChange = strInputName;
			}

			//正式转换
			if(boolPokemon)
			{
				StartPokemonChange(strNameChange,strOutputName);
			}
			else
			{
				MainChange(strNameChange,strOutputName);
			}

			//删除预转换产生的临时文件
#if debug
#else
			if( strNameTemp != "")
			{
				File.Delete(strNameTemp);
			}
#endif
		}

		private void MainChange(string InputName,string OutputName)
		{
			///
			///分析源文件，分情况转换
			///
			int intAdd = 0;									//附加部分大小
			int intCopyLengh;								//源文件中需要的数据长度
			int intOutputLenghAdd;							//先处理附加后大小 转换后文件大小（含附加部分）
			bool IsM3Gba1MB = false;						//标记：目标为1M byte大小的M3格式的GBA存档
			int intOutputLengh = UsedSize[SelectedSize];	//转换后文件大小（无附加部分）
			string InputFileType = "";						//源存档格式

			///	M3 GBA 1M byte的三个条件：
			///		1、目标大小为1M byte
			///		2、目标格式为M3
			///		3、GBA模式
			///	此时，只读取前128K数据

			if((intOutputLengh == 1024*1024) && (SelectedCardType.CardIs == 1) && (SelectedMode == 1))
			{
				intOutputLengh = 128*1024;
				IsM3Gba1MB = true;
			}

			///	计算转换后附加部分大小：
			///		目标存档为DSLink格式(CardIs=2)时，+8K
			///		目标存档后为M3格式(CardIs=1)时，+1K
			///		目标存档为其他格式(CardIs=0)时，不调整

			if(SelectedCardType.CardIs == 2)
			{
				intAdd = 8*1024;
			}
			else if(SelectedCardType.CardIs == 1)
			{
				intAdd = 1024;
			}
			else
			{
				intAdd = 0;
			}

			intOutputLenghAdd = intOutputLengh + intAdd;	//计算转换后文件大小

			try
			{
				InputFileType = InputFileMode(InputName);	//判断源文件格式

				FileStream sri = new FileStream(InputName, FileMode.Open, FileAccess.Read);
				FileStream sro = new FileStream(OutputName, FileMode.Create);
				intCopyLengh = (int)sri.Length;

				///	源文件长度不是标准长度时，分情况处理：
				///		源文件在512k到1M之间（比如520k），执行512k
				///		源文件在256k到512k之间（比如257k），执行256k
				///		源文件在128k到256k之间（比如129k），执行128k
				///		源文件在64k到128k之间，执行64k
				///		源文件在8k到64k之间，执行8k
				///		源文件在512B到128k之间，执行512B


				if ((intCopyLengh < 1024*1024) && (intCopyLengh > 512*1024))
				{
					intCopyLengh = 512*1024;
				}
				else if ((intCopyLengh < 512*1024) && (intCopyLengh > 256*1024))
				{
					intCopyLengh = 256*1024;
				}
				else if ((intCopyLengh < 256*1024) && (intCopyLengh > 128*1024))
				{
					intCopyLengh = 128*1024;
				}
				else if ((intCopyLengh < 128*1024) && (intCopyLengh > 64*1024))
				{
					intCopyLengh = 64*1024;
				}
				else if ((intCopyLengh < 64*1024) && (intCopyLengh > 8*1024))
				{
					intCopyLengh = 8*1024;
				}
				else if ((intCopyLengh < 8*1024) && (intCopyLengh > 512))
				{
					intCopyLengh = 512;
				}

				//	源文件中的数据长度大于目标文件长度时，以目标文件长度为准
				if (intCopyLengh > intOutputLengh)
				{
					intCopyLengh = intOutputLengh;
				}
				
				//输出转换前、后存档文件的类型、体积
				ShowMessage ( InputFileType, (int)sri.Length, intOutputLenghAdd, IsM3Gba1MB);

				//将源文件数据写入目标文件
				CopyDataStart ( InputName, sri, sro, intCopyLengh, intOutputLengh, InputFileType, IsM3Gba1MB);

				if (InputFileType == "UnKnown")
				{
					MessageBox.Show("由于源存档为未知存档格式，所以转换后的存档可能无法使用。\n请检查源存档文件是否正确且可用。","源存档错误");
				}
			}
			catch
			{
                Debug.WriteLine("MainChange error!");
			}
			finally
			{
			}
		}

		private void CopyDataStart(string InputName,FileStream sri,FileStream sro,int intCopyLengh,int intOutputLengh,string InputFileType,bool M3Add1M)		//开始转换
		{
			///
			///由源存档向目标存档复制数据
			///
			try
			{
				myAllControl(false);

				if(CopyData(sri,sro,intCopyLengh,intOutputLengh,InputFileType) == 0)
				{
					ShowMessage(1,2);


                    //	写入M3和DSLINK的附加部分
                    //		目标存档为M3格式(CardIs=1)时，附加1K
                    //		目标存档为DSLink格式(CardIs=2)时，附加8K

                    if (SelectedCardType.CardIs == 1)
                    {
                        ShowMessage(14, 0);

                        if (M3Adding(ReadFileName("M3ShortName"), ReadFileName("M3LongName"), sro, SelectedMode, M3Add1M) == 0)
                        {
                            ShowMessage(1, 2);
                        }
                        else
                        {
                            ShowMessage(3, 3);
                        }

                    }
                    else if (SelectedCardType.CardIs == 2)
                    {
                        ShowMessage(13, 0);

                        if (DSLinkAdding(InputName, sro, InputFileType) == 0)
                        {
                            ShowMessage(1, 2);
                        }
                        else
                        {
                            ShowMessage(4, 3);
                        }
                    }
                    else if (SelectedCardType.CardSName == "DeSmuME")
                    {
                        if (DeSmuMEAdding(intCopyLengh, sro, InputFileType) == 0)
                        {
                            ShowMessage(1, 2);
                        }
                        else
                        {
                            ShowMessage(2, 2);
                        }
                    }
				}
				else
				{
					ShowMessage(2,2);
					ShowMessageBox(17, "Error!");
				}

				sro.Close();

				ShowMessage(16,2);
				ShowMessageBox(16,"OK");
			}
			catch (Exception ex)
			{
                Debug.WriteLine("CopyDataStart exception: " + ex.ToString());

            }
			finally
			{
				myAllControl(true);
			}
		}

		private int CopyData(FileStream sri,FileStream sro,int intCopyLengh,int intOutputLengh,string InputFileType)		//由源存档向目标存档复制数据
		{
			///
			///由源存档向目标存档复制数据
			///

			try
			{
				int i = new int();
				BinaryReader r = new BinaryReader(sri);
				BinaryWriter w = new BinaryWriter(sro);

				///	转换程序的核心部分
				///		当输入格式为Uncompressed格式的NO$GBA存档时，跳过0x4c(76)
				///		输入格式为DUC格式的AR存档时，跳过0x1f4(500)
				///		输入格式为EEPROM格式的DSLINK存档时,前512k无数据，跳过1024*512，此时
				///			目标：512B，只复制前512B
				///			目标：大于等于8K，全部复制
				///			此时，实际复制的数据有可能会比intCopyLengh小，所以要把目标文件用0xff补全到intCopyLengh大小
				///		当输入格式为其它格式时，直接复制数据

				if (InputFileType == "UnCo NO$GBA")
				{
					r.ReadBytes(76);
					w.Write(r.ReadBytes(intCopyLengh), 0, intCopyLengh);
				}
				else if (InputFileType == "AR DUC")	
				{
					r.ReadBytes(500);
					w.Write(r.ReadBytes(intCopyLengh), 0, intCopyLengh);
				}
				else if (InputFileType == "DSLink EEPROM")
				{
					r.ReadBytes(512*1024);

					if (intOutputLengh == 512)
					{
						w.Write(r.ReadBytes(512), 0, 512);
					}
					else
					{
						w.Write(r.ReadBytes(8*1024), 0, 8*1024);
					}

					for (i = 8192; i < intCopyLengh; i++)
					{
						sro.WriteByte(0xff);
					}
				}
				else
				{
					w.Write(r.ReadBytes(intCopyLengh), 0, intCopyLengh);
				}

				//	把目标文件用0xff补全到需要的大小
				for (i = intCopyLengh; i < intOutputLengh; i++)
				{
					sro.WriteByte(0xff);
				}
				sri.Close();

				return(0);
			}
			catch(Exception ex)
			{
                Debug.WriteLine("CopyData exception: " + ex.ToString());
                return (1);
			}
			finally
			{
			}
		}

		private string InputFileMode(string strInputName)
		{
			///
			///	判断源文件格式
			///
			long intCopyLengh,i;				//源存档体积
			string InputFileType = "";		//源存档格式
			string txtNoGba1 = "";			//NO$GBA第一识别字符串
			string txtNoGba2 = "";			//NO$GBA第二识别字符串
			string strActionReplay = "";	//Action Replay Max DS识别字符串
            string strDeSmuME = "";         //DeSmuME识别字符串
            int intNoGba = 0;				//NO$GBA格式模式区分标记

			try
			{
				FileStream sri = new FileStream(strInputName, FileMode.Open, FileAccess.Read);
				BinaryReader r = new BinaryReader(sri);

				intCopyLengh = (int)sri.Length;

				for(i=1;i<=31;i++)
				{
					txtNoGba1 += r.ReadChar().ToString();
				}
				r.ReadBytes(16*2+1);
				for(i=1;i<=4;i++)
				{
					txtNoGba2 += r.ReadChar().ToString();
				}
				intNoGba = Convert.ToInt16(r.ReadByte());

				strActionReplay = new string(txtNoGba1.ToCharArray(0,4));

                if ((intCopyLengh - sri.Position - 14) > 0)
                {
                    long _pos = sri.Position;
                    for (long j = 0; j < (intCopyLengh - _pos - 14); j++)
                    {
                        if (sri.Position < intCopyLengh)
                            r.ReadByte();
                    }

                    for (int z = 0; z < 12; z++)
                    {
                        strDeSmuME += r.ReadChar().ToString();
                    }
                }

                ///	判断源存档格式
                ///		1、NO$GBA格式
                ///			a、"UnCo NO$GBA"	532848byte大小的Uncompressed格式（非压缩格式）
                ///			b、"Com NO$GBA"		Compressed格式（压缩格式）
                ///			c、"UnKnown"		未知格式
                ///		2、Action Replay Max DS模式
                ///			a、"AR DUC"		AR DUC模式
                ///			b、"AR DST"		AR DST模式
                ///		3、DSLink模式
                ///			a、"DSLink EEPROM"	EEPROM模式
                ///			b、"DSLink FLASH"	FLASH模式
                ///		4、"M3"			M3格式
                ///		5、"Normal"		标准格式
                ///		6、"DeSmuME"	DeSmuME格式
                ///		7、"UnKnown"	未知格式

                if (txtNoGba1 == "NocashGbaBackupMediaSavDataFile" && txtNoGba2 == "SRAM")
                {
                    if (intCopyLengh == 520 * 1024 + 368 && intNoGba == 0)
                    {
                        InputFileType = "UnCo NO$GBA";
                    }
                    else if (intNoGba == 1)
                    {
                        InputFileType = "Com NO$GBA";
                    }
                    else
                    {
                        InputFileType = "UnKnown";
                    }
                }
                else if (strActionReplay == "ARDS")
                {
                    if (intCopyLengh == 1012 || intCopyLengh == 8692 || intCopyLengh == 66036 || intCopyLengh == 262644)
                    {
                        InputFileType = "AR DUC";
                    }
                    else
                    {
                        InputFileType = "AR DST";
                    }
                }
                else if (strDeSmuME.ToUpper() == "DESMUME SAVE")
                {
                    InputFileType = "DeSmuME";
                }
                else if (intCopyLengh == 520 * 1024)
                {
                    if (Test(0, strInputName) == "33333300")
                    {
                        InputFileType = "DSLink EEPROM";
                    }
                    else
                    {
                        InputFileType = "DSLink FLASH";
                    }
                }
                else if ((intCopyLengh == 129 * 1024) || (intCopyLengh == 257 * 1024) || (intCopyLengh == 513 * 1024))
                {
                    InputFileType = "M3";
                }
                else if ((intCopyLengh == 0.5 * 1024) || (intCopyLengh == 8 * 1024) || (intCopyLengh == 64 * 1024) || (intCopyLengh == 128 * 1024) || (intCopyLengh == 256 * 1024) || (intCopyLengh == 512 * 1024) || (intCopyLengh == 1024 * 1024))
                {
                    InputFileType = "Normal";
                }
                else
                {
                    InputFileType = "UnKnown";
                }

				sri.Close();
			}
			catch (Exception ex)
            {
                Debug.WriteLine("InputFileMode Exception: " + ex.ToString());
            }
			finally{}

			return(InputFileType);
		}

		#endregion

		#region  特殊转换
		private void StartPokemonChange(string InputName,string OutputName)		//口袋妖怪存档特殊转换
		{
			myAllControl(false);

			ShowMessage(23,2);

			try
			{
				int intLength,flag,intNewTest1,intNewTest2 = new int();
				string InputFileType = InputFileMode(InputName);		//判断源文件格式
				FileStream sr1 = new FileStream(InputName, FileMode.Open, FileAccess.Read);
				BinaryReader r1 = new BinaryReader(sr1);
				intLength = (int)sr1.Length;
				

				if (InputFileType == "UnCo NO$GBA")		//输入格式是否为532848byte大小的Uncompressed格式的NO$GBA存档
				{
					r1.ReadBytes(76);	//0x4c
				}
				if (InputFileType == "AR DUC")			//输入格式是否为DUC格式的AR存档
				{
					r1.ReadBytes(500);	//0x1F4
				}

				if(intLength >= 512*1024)
				{
					//读取存档次数(4字节读取)
					r1.ReadBytes(49392);		//0xc0f0
					intNewTest1 = Convert.ToInt16(sr1.ReadByte()) + Convert.ToInt16(sr1.ReadByte())*256 + Convert.ToInt16(sr1.ReadByte())*256*256 + Convert.ToInt16(sr1.ReadByte())*256*256*256;	//第一个存档的存档次数
					r1.ReadBytes(256*1024-4);
					intNewTest2 = Convert.ToInt16(sr1.ReadByte()) + Convert.ToInt16(sr1.ReadByte())*256 + Convert.ToInt16(sr1.ReadByte())*256*256 + Convert.ToInt16(sr1.ReadByte())*256*256*256;	//第二个存档的存档次数
					sr1.Close();

					intNewTest1 = (intNewTest1<0?0:intNewTest1);
					intNewTest2 = (intNewTest2<0?0:intNewTest2);
					
					if(intNewTest1 != 0 || intNewTest2 != 0)
					{
						//按照存档次数判断先后顺序
						flag = (intNewTest1>=intNewTest2?1:2);

						//把数据写入新存档，默认存档为时间靠后的存档，时间靠前的也转换，但加“.old”后缀
						FileStream sr2 = new FileStream(InputName, FileMode.Open, FileAccess.Read);
						BinaryReader r2 = new BinaryReader(sr2);

						if (InputFileType == "UnCo NO$GBA")		//输入格式是否为532848byte大小的Uncompressed格式的NO$GBA存档
						{
							r2.ReadBytes(76);	//0x4c
						}
						if (InputFileType == "AR DUC")			//输入格式是否为DUC格式的AR存档
						{
							r2.ReadBytes(500);	//0x1F4
						}

						FileStream sro1 = new FileStream(OutputName, FileMode.Create);
						BinaryWriter w1 = new BinaryWriter(sro1);

						FileStream sro2 = new FileStream(OutputName + ".old", FileMode.Create);
						BinaryWriter w2 = new BinaryWriter(sro2);

						if(flag == 1)
						{
							w1.Write(r2.ReadBytes(256*1024),0,256*1024);
							w2.Write(r2.ReadBytes(256*1024),0,256*1024);
						}
						else
						{
							w2.Write(r2.ReadBytes(256*1024),0,256*1024);
							w1.Write(r2.ReadBytes(256*1024),0,256*1024);
						}

						sr2.Close();
						w1.Close();
						w2.Close();

						//输出信息
						ShowMessage("Input: "+InputFileType+"\n");
						ShowMessage("1: "+intNewTest1.ToString()+" times\n");
						ShowMessage("2: "+intNewTest2.ToString()+" times\n");
						ShowMessage(21,0);
						ShowMessage(flag.ToString());
						ShowMessage(16,3);
						ShowMessageBox(16,"OK");
					}
					else
					{
						ShowMessage(24,0);
					}
				}
				else
				{
					ShowMessage("Error:Input Save mast >512k!");
				}
			}
			catch
			{
				ShowMessage(2,2);
				ShowMessageBox(17, "Error!");
			}
			finally
			{
				myAllControl(true);
			}

		}

		private string NOGBACompressedChange(string strInputName)		//源存档为Compressed格式NO$GBA存档的预转换
		{
			try
			{
				int i,cont;
				int MainCont = 0;
				int intByteRead = 0;
				byte tempByteRead;

				string strOutputName = strInputName+".temp";

				FileStream sri = new FileStream(strInputName, FileMode.Open, FileAccess.Read);
				FileStream sro = new FileStream(strOutputName, FileMode.Create);
				BinaryReader r = new BinaryReader(sri);
				BinaryWriter w = new BinaryWriter(sro);

				ShowMessage("Com NOGBA",(int)sri.Length);
				//开始转换

				r.ReadBytes(0x50);

				do
				{
					intByteRead =  Convert.ToInt16(r.ReadByte());

					if(intByteRead > 0x80)
					{

						tempByteRead = r.ReadByte();
						
						cont = intByteRead-0x80;
						MainCont += cont;

						for (i = 0; i < cont; i++)		//0x81-0xff
						{
							sro.WriteByte(tempByteRead);
						}
					}
					else if (intByteRead == 0x80)
					{
						tempByteRead = r.ReadByte();

						cont = Convert.ToInt16(r.ReadByte()) + Convert.ToInt16(r.ReadByte())*256;
						MainCont += cont;

						for (i = 0; i < cont; i++)		//0x80
						{
							sro.WriteByte(tempByteRead);
						}
					}
					else if (intByteRead < 0x80 &&intByteRead != 0x00)
					{
						cont = intByteRead;
						MainCont += cont;

						for (i = 0; i < cont; i++)		//0x01-0x7f
						{
							sro.WriteByte(r.ReadByte());
						}
					}
					else if (intByteRead == 0x00)		//0x00
					{
						break;
					}
				}while(MainCont < 512*1024);

				sri.Close();
				sro.Close();

				if(MainCont != 512*1024)
				{
					MessageBox.Show("NO$GBA存档预处理出现错误，你转换后的存档可能\n\n无法正常使用。请确认源存档格式正确且完好无误。","预处理错误");
				}

				return(strOutputName);
			}

			catch
			{
				MessageBox.Show("NO$GBA存档预处理出现错误，你转换后的存档可能\n\n无法正常使用。请确认源存档格式正确且完好无误。","预处理错误");
				
				return("");
			}
			finally
			{
			}
		}

		private string ARDSTChange(string strInputName)		//源存档为DST格式AR存档的预转换
		{
			try
			{
				int i,cont,j,k;
				int intByteRead = 0;
				byte tempByteRead;
				byte ByteRead;
				int intByteTemp=0;		//标志位
				int intNum = 0;			//分段的个数
				int intTimes = 0;		//当前段需读取的字节数，包含标志位

				string strOutputName = strInputName+".temp";

				FileStream sri = new FileStream(strInputName, FileMode.Open, FileAccess.Read);
				FileStream sro = new FileStream(strOutputName, FileMode.Create);
				BinaryReader r = new BinaryReader(sri);
				BinaryWriter w = new BinaryWriter(sro);
			
				ShowMessage("AR DST",(int)sri.Length);
				//开始转换

				r.ReadBytes(0x1f8);
				intNum = Convert.ToInt16(r.ReadByte());
				r.ReadBytes(0x3);

				///每8K为一个分段，共intNum段
				for(j=0;j<intNum;j++)
				{	
					r.ReadBytes(6);
					intTimes =  Convert.ToInt16(r.ReadByte()) * 256 + Convert.ToInt16(r.ReadByte());
					intByteTemp =  Convert.ToInt16(r.ReadByte());

					for( k = 1;k < intTimes;k++)
					{
						ByteRead = r.ReadByte();

						intByteRead =  Convert.ToInt16(ByteRead);

						if(intByteRead == intByteTemp)
						{
							cont = Convert.ToInt16(r.ReadByte()) + 1;
							k++;

							tempByteRead = r.ReadByte();
							k++;

							for (i = 0; i < cont; i++)
							{
								sro.WriteByte(tempByteRead);
							}
						}
						else
						{
							sro.WriteByte(ByteRead);
						}
					}
				}

				sri.Close();
				sro.Close();

				return(strOutputName);
			}

			catch
			{
				MessageBox.Show("AR DST存档预处理出现错误，你转换后的存档可能\n\n无法正常使用。请确认源存档格式正确且完好无误。","预处理错误");
				
				return("");
			}
			finally
			{
			}
		}

		#endregion

		#region 特殊烧录卡的处理
		private int M3Adding(string ShortName,string LongName,FileStream sro,int SelectMode,bool M3Add1M)	//M3附加的1k信息
		{
			string M3SaveMode = "";

			if(SelectMode == 0)
			{
				M3SaveMode = "NDS";
			}
			else if(SelectMode == 1)
			{
				M3SaveMode = "GBA";
			}
			else
			{
				return(1);
			}

			try
			{
				int i, LengthMax;

				if (sro.Length == 512*1024 || sro.Length == 256*1024 || sro.Length == 128*1024)
				{
					LengthMax = (int)sro.Length;
				}
				else
				{
					LengthMax = 256*1024;
				}

				ShortName = ShortName.Remove(ShortName.Length - 4,4);	//去掉短文件名的后缀

				using (StreamWriter sw = new StreamWriter(sro, UnicodeEncoding.GetEncoding("GB2312")))
				{
					sw.AutoFlush = true;								//自动更新
					sw.Write("BOOT\x0000"+ShortName);					//1:写入"BOOT & 0x00"以及短文件名
					for (i = (int)sro.Length; i < LengthMax + 13; i++)	//2:将短文件名凑够8个字节
					{
						sro.WriteByte(0x20);
					}
					sw.Write(M3SaveMode+"\x0001");						//3:写入"NDS(GBA) & 0x01"
					for (i = 0; i < 20; i++)							//4:写入空白
					{
						sro.WriteByte(0x00);
					}
					sw.Write(LongName);									//5:写入长文件名
					sw.AutoFlush = false;
					for (i = (int)sro.Length; i < LengthMax + 1024; i++)//6:写入最后的空白部分
					{
						sro.WriteByte(0x00);
					}
					sw.Flush();
					if (M3Add1M)
					{
						for (i = 0; i <(1024-129)*1024; i++)			//写入M3 GBA存档的129K至1M附加部分（旧版本存档）
						{
							sro.WriteByte(0x00);
						}
					}
					sw.Flush();
					sw.Close();
				}
				return(0);
			}
			catch
			{
				return(1);
			}
		}

		private int DSLinkAdding(string InputName,FileStream sro,string InputMode)	//DSLink 附加的8k信息
		{
			int i,x;
			int lengthMax = 8*1024;

			try
			{
				FileStream sri = new FileStream(InputName, FileMode.Open, FileAccess.Read);
				x = (int)sri.Length;
				BinaryReader r = new BinaryReader(sri);
				BinaryWriter w = new BinaryWriter(sro);

				if(InputMode == "DSLink EEPROM")
				{
					r.ReadBytes(512*1024);
				}

				if (x > lengthMax)
				{
					x = lengthMax;
				}

				w.Write(r.ReadBytes(x), 0, x);
				
				for (i = x; i < lengthMax; i++)
				{
					sro.WriteByte(0xff);
				}

				r.Close();
				w.Close();

				return(0);
			}
			catch
			{
				return(1);
			}
		}

        private int DeSmuMEAdding(int intCopyLength, FileStream sro, string InputMode)    //DeSmuME 附加
        {
            try
            {
                BinaryWriter w = new BinaryWriter(sro);

                byte[] bb;

                switch (intCopyLength)
                {
                    case 64 * 1024:
                        bb = new byte[] { 0x7C, 0x3C, 0x2D, 0x2D, 0x53, 0x6E, 0x69, 0x70, 0x20, 0x61, 0x62, 0x6F, 0x76
                            , 0x65, 0x20, 0x68, 0x65, 0x72, 0x65, 0x20, 0x74, 0x6F, 0x20, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x20
                            , 0x61, 0x20, 0x72, 0x61, 0x77, 0x20, 0x73, 0x61, 0x76, 0x20, 0x62, 0x79, 0x20, 0x65, 0x78, 0x63, 0x6C
                            , 0x75, 0x64, 0x69, 0x6E, 0x67, 0x20, 0x74, 0x68, 0x69, 0x73, 0x20, 0x44, 0x65, 0x53, 0x6D, 0x75, 0x4D
                            , 0x45, 0x20, 0x73, 0x61, 0x76, 0x65, 0x64, 0x61, 0x74, 0x61, 0x20, 0x66, 0x6F, 0x6F, 0x74, 0x65, 0x72, 0x3A
                            , 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x03, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00
                            , 0x7C, 0x2D, 0x44, 0x45, 0x53, 0x4D, 0x55, 0x4D, 0x45, 0x20, 0x53, 0x41, 0x56, 0x45, 0x2D, 0x7C };
                        break;
                    default:
                        bb = new byte[] { 0x7C, 0x3C, 0x2D, 0x2D, 0x53, 0x6E, 0x69, 0x70, 0x20, 0x61, 0x62, 0x6F, 0x76
                            , 0x65, 0x20, 0x68, 0x65, 0x72, 0x65, 0x20, 0x74, 0x6F, 0x20, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x20
                            , 0x61, 0x20, 0x72, 0x61, 0x77, 0x20, 0x73, 0x61, 0x76, 0x20, 0x62, 0x79, 0x20, 0x65, 0x78, 0x63, 0x6C
                            , 0x75, 0x64, 0x69, 0x6E, 0x67, 0x20, 0x74, 0x68, 0x69, 0x73, 0x20, 0x44, 0x65, 0x53, 0x6D, 0x75, 0x4D
                            , 0x45, 0x20, 0x73, 0x61, 0x76, 0x65, 0x64, 0x61, 0x74, 0x61, 0x20, 0x66, 0x6F, 0x6F, 0x74, 0x65, 0x72, 0x3A
                            , 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x08, 0x00, 0x06, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00
                            , 0x7C, 0x2D, 0x44, 0x45, 0x53, 0x4D, 0x55, 0x4D, 0x45, 0x20, 0x53, 0x41, 0x56, 0x45, 0x2D, 0x7C };
                        break;
                }
                //for(int i=0;i<)
                w.Seek(0, SeekOrigin.End);
                for (int i = 0; i < bb.Length; i++)
                {
                    w.Write(bb[i]);
                }
                
                w.Close();

                return (0);
            }
            catch
            {
                return (1);
            }
        }

        #endregion

        #region 测试程序
        private void StartTest(string strInputName)
		{
			string strInputMode = InputFileMode(strInputName);
			string strNameTemp = "";
			string strFlagTest = Test(0,strInputName);
			try
			{
				if(strInputMode == "Com NO$GBA")
				{
					strNameTemp = NOGBACompressedChange(strInputName);
					strFlagTest = Test(0,strNameTemp);
					File.Delete(strNameTemp);
				}
				else if(strInputMode == "UnCo NO$GBA")
				{
					strFlagTest = Test(0x4c,strInputName);
				}
				else if(strInputMode == "AR DST")
				{
					strNameTemp = ARDSTChange(strInputName);
					strFlagTest = Test(0,strNameTemp);
					File.Delete(strNameTemp);
				}
				else if(strInputMode == "AR DUC")
				{
					strFlagTest = Test(0x1f4,strInputName);
				}

				if(strFlagTest == "33333300")
				{
					strFlagTest = Test(512*1024,strInputName);
				}

				ShowTestMap(strFlagTest);

				ClearMessage();
				if(strFlagTest != "00000000")
				{
					ShowMessage(20,2);
					ShowMessage(ShowTestText(strFlagTest,SelectedMode)+"\n");
				}
				else
				{
					ShowMessageBox(18,"Test Error!");
				}
			}
			catch
			{
			}
			finally
			{
			}
		}

		private string Test(int intPassData,string strInputName)		//OK
		{
			int i,j,intTestLengh;
			int[] intFlag = new int[11];
			string SaveTestFlag = "";
			string FlagEEPROM = "0";
			double TestYellow = 15.0/16.0;
			int[] intTestSize = new int[11]{0,(int)(0.5*1024),8*1024,64*1024,128*1024,256*1024,512*1024,1024*1024,2*1024*1024,4*1024*1024,8*1024*1024};
			int TestCont = 7;	//	暂时不能改为10
			byte byteRead;

			try
			{
				FileStream sri = new FileStream(strInputName, FileMode.Open, FileAccess.Read);
				intTestLengh = (int)sri.Length;
				BinaryReader r = new BinaryReader(sri);

				if(intTestLengh == 520*1024+368)
				{
					intPassData = 76;
				}
				
				if(intPassData != 0)
				{
					r.ReadBytes(intPassData);
					intTestLengh -= intPassData;

					if(intPassData == 512*1024)
					{
						FlagEEPROM = "1";
					}
				}

				//ShowMessage(intTestLengh.ToString());			//测试专用

				for(j = 1;j <= TestCont;j++)
				{
					if(intTestLengh >= intTestSize[j])
					{
						for (i = intTestSize[j-1]+1;i <= intTestSize[j];i++)
						{
							byteRead = r.ReadByte();

							if((byteRead == 0xff) || (byteRead == 0x00))
							{
								intFlag[j]++;
							}
						}

						if (intFlag[j] == intTestSize[j]-intTestSize[j-1])
						{
							SaveTestFlag += "3";
						}
						else if (intFlag[j] >= (intTestSize[j]-intTestSize[j-1])*TestYellow)
						{
							SaveTestFlag += "2";
						}
						else
						{
							SaveTestFlag += "1";
						}
					}
					else
					{
						SaveTestFlag += "0";
					}
				}

				SaveTestFlag += FlagEEPROM;
				r.Close();
				sri.Close();

				//ShowMessage(SaveTestFlag+"\n");  //测试专用

				return(SaveTestFlag);
			}
			catch
			{
				return("00000000");
			}
			finally
			{
			}
		}

		private void ShowTestMap(string strFlag)		//以彩色方式输出测试结果，暂时不支持8M存档（另外，暂时不支持完全面向对象，修改中）
		{
			int i;
			int FlagLength= strFlag.Length;
			Color[] FlagColor = new Color[8];
			Color[] FlagColorMode = new Color[4];
			FlagColorMode[0] = System.Drawing.SystemColors.Control;
			FlagColorMode[1] = System.Drawing.Color.OrangeRed;
			FlagColorMode[2] = System.Drawing.Color.Yellow;
			FlagColorMode[3] = System.Drawing.Color.GreenYellow;

			for(i = 0;i < FlagLength;i++)
			{
				FlagColor[i] = FlagColorMode[int.Parse(strFlag[i].ToString())];
			}

			lblTest512B.BackColor = FlagColor[0];
			lblTest8K.BackColor = FlagColor[1];
			lblTest64K.BackColor = FlagColor[2];
			lblTest128K.BackColor = FlagColor[3];
			lblTest256K.BackColor = FlagColor[4];
			lblTest512K.BackColor = FlagColor[5];
			lblTest1M.BackColor = FlagColor[6];
			lblTestEEPROM.BackColor = FlagColor[7];
		}

		private string ShowTestText(string strFlag,int intSelectMode)		//输出测试结果提示
		{
			int i = new int();
			int testMin = 1,testMax = 6;
			string strTest = "";
			bool flag = true;
			string[] strTestSize = new string[8]{"0","512B","8K","64K","128K","256K","512K","1M"};

			for (i = 6;i >= 0;i--)
			{
				if((strFlag[i]=='3'||strFlag[i]=='0') && flag)
				{
					testMax=i-1;
				}
				else if(strFlag[i]=='2')
				{
					testMin=i;
					flag = false;
				}
				else if(strFlag[i]=='1')
				{
					testMin=i;
					break;
				}
			}

			if(testMax<testMin)
			{
				testMax=testMin;
			}

			for(i=testMin;i<=testMax;i++)
			{
				strTest += strTestSize[i+1]+" ";
			}

			if(intSelectMode == 0)
			{
				strTest = strTest.Replace("128K","256K");
				strTest = strTest.Replace("256K 256K","256K");
			}

			return(strTest);
		}

		#endregion

		#region DOS程序

		private static void DOSCommand(double OutSize,string InputName,string OutputName)		//开始转换
		{
			int i,intCopyLengh,intLengthMax,intLengthMaxEnd;

			if(InputName == OutputName)
			{
				InputName = OutputName+".out";
			}
			try
			{
				FileStream sri = new FileStream(InputName, FileMode.Open, FileAccess.Read);
				FileStream sro = new FileStream(OutputName, FileMode.Create);
				intCopyLengh = (int)sri.Length;
				BinaryReader r = new BinaryReader(sri);
				BinaryWriter w = new BinaryWriter(sro);

				intLengthMax = (int)(OutSize*1024.0);	//转换后文件大小（无附加部分）
				intLengthMaxEnd = intLengthMax;

				if (intCopyLengh > intLengthMax)				//源文件长度大于目标文件长度
				{
					intCopyLengh = intLengthMax;
				}
				if ((intCopyLengh < 524288) && (intCopyLengh > 262144))			//256k到512k之间（257k），执行256k
				{
					intCopyLengh = 262144;
				}
				else if ((intCopyLengh < 262144) && (intCopyLengh > 131072))	//128k到256k之间（129k），执行128k
				{
					intCopyLengh = 131072;
				}
				w.Write(r.ReadBytes(intCopyLengh), 0, intCopyLengh);

				for (i = intCopyLengh; i < intLengthMax; i++)
				{
					sro.WriteByte(0xff);
				}

				sri.Close();
				sro.Close();
			}
			catch (Exception ex)
			{
                Debug.WriteLine("DOSCommand Exception: " + ex.ToString());
            }
			finally
			{
			}
		}

		#endregion

		private void txtOutput_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		#endregion
	}
}