//#define debug	//���ڲ��Ե�ģ��
//#undef debug		//�Ѿ���ɵ��㷨��ʹ�÷�����ɾ�����п�ʼ�ġ�//��ע�ͱ�־��

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
    /// Form1 ��ժҪ˵����
    /// </summary>
    /// 

    public class frmMain : System.Windows.Forms.Form
	{
		#region �Զ�����

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
		/// ����������������
		/// 
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMain()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
            this.lblOutput.Text = "Ŀ���ļ�";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput
            // 
            this.lblInput.Location = new System.Drawing.Point(8, 20);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(56, 20);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Դ�ļ�";
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
            this.btnChange.Text = "ת��";
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
            this.btnInput.Text = "��";
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
            this.chkPokemon.Text = "�ڴ�����ǿ��ת����512K -> 256K��";
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
            this.chkTest.Text = "����";
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
            this.grpChangeMode.Text = "ת��ģʽ";
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
            this.grpOutput.Text = "�����ʽ";
            // 
            // lblOutputSize
            // 
            this.lblOutputSize.Location = new System.Drawing.Point(16, 60);
            this.lblOutputSize.Name = "lblOutputSize";
            this.lblOutputSize.Size = new System.Drawing.Size(60, 20);
            this.lblOutputSize.TabIndex = 3;
            this.lblOutputSize.Text = "�����С";
            this.lblOutputSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputFormat
            // 
            this.lblOutputFormat.Location = new System.Drawing.Point(16, 28);
            this.lblOutputFormat.Name = "lblOutputFormat";
            this.lblOutputFormat.Size = new System.Drawing.Size(60, 20);
            this.lblOutputFormat.TabIndex = 2;
            this.lblOutputFormat.Text = "�����ʽ";
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
            this.btnExit.Text = "�˳�";
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
            this.btnAbout.Text = "����";
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
            this.grpM3.Text = "M3 ����ѡ��";
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
            this.lblM3ShortName.Text = "���ļ���";
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
            this.lblM3LongName.Text = "���ļ���";
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
            this.btnM3Rom.Text = "��ӦM3 ROM�ļ�";
            this.btnM3Rom.Click += new System.EventHandler(this.btnM3Rom_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Location = new System.Drawing.Point(3, 17);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(178, 172);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "����д�룬���Եȡ���";
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
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]

		#endregion

		#region ��ʼ��

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

		#region ������ʼ��

		static int NdsCards = 28 + 1;							//֧�ֵ�NDS��¼������������+1��ǰ������ֺ�NDS��¼����������ͬ
		static int GbaCards =  7 + 1;							//֧�ֵ�GBA��¼������������+1��ǰ������ֺ�GBA��¼����������ͬ
		string[][] strLanguageForm = new string[16+1][];		//�������ԣ���+1��ǰ������ֺͽ���������������ͬ
		string[][] strLanguageMessage = new string[24+1][];		//��ʾ��Ϣ���ԣ���+1��ǰ������ֺ���ʾ��Ϣ������������ͬ
		CardType[][] SetupCardType = new CardType[2][];			//��¼����Ϣ����
		int[] UsedSize = new int[10];							//�浵��С��Ϣ

		#endregion

		#region �����ʼ��
		private void StartMain() 
		{
			///	����������ʱ����ʼ��������Ŀ��
			///		��¼������		2��		0ΪDS�浵��1ΪGBA�浵
			///		��¼���б�		1��
			///		����ѡ���б�	3��
			///		ģʽѡ���б�	2��
			///		����ѡ���б�	1��
			///		�����Ϣ��		1��
			///		������Ϣ���	1��
			 
			///	��¼������
			SetupCardType[0] = new CardType[NdsCards];
			SetupCardType[1] = new CardType[GbaCards];

			///	��¼���б�
			SetCardType();

			///	����ѡ���б�
			cboLanguage.Items.AddRange(new object[] {"��������","���w����","English"});
			LanguageText();
			cboLanguage.SelectedIndex = 0;

			///	ģʽѡ���б�
			cboMode.Items.AddRange(new object[] {"NDS","GBA"});
			cboMode.SelectedIndex = 0;

			///	����ѡ���б�
			ChangeMode();

			///	�����Ϣ��
			//ClearMessage();

			///	������Ϣ���
			MyData();
		}

		private void LanguageText() 
		{
			/// ��ʼ��������������
			///	�ڱ��б�������Ŀʱ����Ҫ�޸ġ���ʼ����->��������ʼ����������������У�
			///		string[][] strLanguageForm = new string[16+1][];		//�������ԣ���+1��ǰ������ֺͽ���������������ͬ
			///		string[][] strLanguageMessage = new string[24+1][];		//��ʾ��Ϣ���ԣ���+1��ǰ������ֺ���ʾ��Ϣ������������ͬ

			//��������
			strLanguageForm[0] = new string[]{"��������","���w����","English"};	//˵�������򲻵���
			strLanguageForm[1] = new string[]{"��","���_","Open"};   //btnInput
			strLanguageForm[2] = new string[]{"ת��","�D�Q","Change"};   //btnChange
			strLanguageForm[3] = new string[]{"����","�P��","About"};   //btnAbout
			strLanguageForm[4] = new string[]{"�˳�","�˳�","Exit"};   //btnExit
			strLanguageForm[5] = new string[]{"��ӦM3 ROM�ļ�","����M3 ROM�ļ�","Select M3 ROM"};   //btnM3Rom
			strLanguageForm[6] = new string[]{"����","�yԇ","Test"};   //chkTest
			strLanguageForm[7] = new string[]{"�����ʽѡ��","ݔ����ʽ�x��","Output Type"};   //grpOutput
			strLanguageForm[8] = new string[]{"M3����ѡ��","M3�����x�","M3 Adding"};   //grpM3
			strLanguageForm[9] = new string[]{"ת��ģʽ","�D�Q�Uʽ","Mode"};   //grpChangeMode
			strLanguageForm[10] = new string[]{"Դ�ļ�","Դ�ļ�","Input"};   //lblInput
			strLanguageForm[11] = new string[]{"Ŀ���ļ�","Ŀ���ļ�","Output"};   //lblOutput
			strLanguageForm[12] = new string[]{"�����ʽ","ݔ����ʽ","Type"};   //lblOutputFormat
			strLanguageForm[13] = new string[]{"�����С","ݔ����С","Size"};   //lblOutputSize
			strLanguageForm[14] = new string[]{"���ļ���","���ļ���","Short Name"};   //lblM3ShortName
			strLanguageForm[15] = new string[]{"���ļ���","�L�ļ���","Long Name"};   //lblM3LongName
			strLanguageForm[16] = new string[]{"�ڴ�����ǿ��ת����512K -> 256K��","�ڴ�����ǿ���D�Q��512K -> 256K��","Pokemon Change(512K -> 256K)"};   //chkPokemon

			//��ʾ��Ϣ����                                                 */
			strLanguageMessage[0] = new string[]{"��������","���w����","English"};   //˵�������򲻵���
			strLanguageMessage[1] = new string[]{"��ɣ�","��ɣ�","OK"};   //strChangeOK
			strLanguageMessage[2] = new string[]{"ʧ��!","ʧ����","Fail!"};   //strChangeError
			strLanguageMessage[3] = new string[]{"M3���Ӳ���д��ʧ��!","M3���Ӳ��֌���ʧ����","M3 Adding Error!"};   //strM3AddError
			strLanguageMessage[4] = new string[]{"DSLink���Ӳ���д��ʧ��!","DSLink���Ӳ��֌���ʧ����","DSLink Adding Error!"};   //strDSLinkAddError
			strLanguageMessage[5] = new string[]{"��ѡ��Դ�浵�ļ�","Ո�x���n�ļ�","Please select input save file."};   //strSelectInput
			strLanguageMessage[6] = new string[]{"��ѡ��M3�浵��Ӧ��ROM","Ո�x��M3��n������ROM","Please select M3 ROM"};   //strSelectM3ROM
			strLanguageMessage[7] = new string[]{"���Եȡ�","Ո�Եȡ�","Please wait..."};   //strWait
			strLanguageMessage[8] = new string[]{"ת��ǰ��ʽ��","�D�Qǰ��ʽ��","Input Format:"};   //strMgeInputFormat
			strLanguageMessage[9] = new string[]{"ת�����ʽ��","�D�Q���ʽ��","Output Format:"};   //strMgeOutputFormat
			strLanguageMessage[10] = new string[]{"ת��ǰ��С��","�D�Qǰ��С��","Input Size:"};   //strMgeInputSize
			strLanguageMessage[11] = new string[]{"ת�����С��","�D�Q���С��","Output Size:"};   //strMgeOutputSize
			strLanguageMessage[12] = new string[]{"����д�룬���Եȡ���","���ڌ��룬Ո�Եȡ���","Writting,please Wait..."};   //strMgeWait
			strLanguageMessage[13] = new string[]{"����д��DSLink����...","���ڌ���DSLink����...","Writting DSLink Add..."};   //strMgeDSLinkAdd
			strLanguageMessage[14] = new string[]{"����д��M3����.....","���ڌ���M3����.....","Writting M3 Add....."};   //strMgeM3Add
			strLanguageMessage[15] = new string[]{"д��ɹ���","����ɹ���","OK!"};   //strMgeOK
			strLanguageMessage[16] = new string[]{"ת���ɹ���","�D�Q�ɹ���","Change OK!"};   //strMgeChangeOk
			strLanguageMessage[17] = new string[]{"д��ʧ�ܣ�","����ʧ����","Error!"};   //strMgeError
			strLanguageMessage[18] = new string[]{"Դ�ļ���ȡʧ�ܣ�","Դ�ļ��xȡʧ����","Input Read Error!"};   //strMgeReadError
			strLanguageMessage[19] = new string[]{"δ֪���󣡣�","δ֪�e�`����","Unknown Error!"};   //default
			strLanguageMessage[20] = new string[]{"�������ݿ��ܴ�С��","���Ô������ܴ�С��","Used Data Size��list��"};   //usedSize
			strLanguageMessage[21] = new string[]{"ʹ�ô浵��","ʹ�ô�n��","Use Save��"};   //pokemon
			strLanguageMessage[22] = new string[]{"Ԥת����","�A�D�Q��","First Change:"};   //Ԥת��
			strLanguageMessage[23] = new string[]{"�ڴ�����ǿ��ת����","�ڴ�����ǿ���D�Q��","Pokemon Change:"};   //�ڴ�����ǿ��ת��
			strLanguageMessage[24] = new string[]{"Դ�浵��ʽ����","Դ��n��ʽ�e�`��","Input Error��"};   //Դ�浵����

		}

		#endregion

		#region ��¼����Ϣ��ʼ��
		public struct CardType 
		{
			//��¼����Ϣ�Ľṹ����
			public int CardMode;		//��¼��ģʽ��0ΪNDS��1ΪGBA
			public string CardName;		//��¼������
			public string CardSName;	//��¼�����
			public string CardSaveType;	//��¼��֧�ֵĴ浵��С��ʮλ�ַ�����0Ϊ��֧�֣�1Ϊ֧�֣��ɷ��Ϊ�ַ����飿��
			public int SelectIndex;		//��¼����֧�ֵĴ浵��С��Ĭ�ϵ���Ŀ���
			public int Only256;			//��¼����֧��256K�浵��ʽ��ʶ��1Ϊ��֧��256K��0Ϊ֧���������
			public string CardExt;		//��¼����֧�ִ浵��׺
			public int CardIs;			//������¼����ʶ��1ΪM3,2ΪDSLink��0Ϊ������¼��
			public string CardInfo;		//��¼��˵��

			//��¼����Ϣ�Ĺ��캯��
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
			//�հ׵ĳ�ʼ�����캯��
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
			/// ����¼������֧��
			///	�ڱ��б�������Ŀʱ����Ҫ�޸ġ���ʼ����->��������ʼ����������������У�
			///		static int NdsCards = 26 + 1;		//֧�ֵ�NDS��¼������������+1��ǰ������ֺ�NDS��¼����������ͬ
			///		static int GbaCards =  7 + 1;		//֧�ֵ�GBA��¼������������+1��ǰ������ֺ�GBA��¼����������ͬ
			///		
			///	��׼����otherŲ��0�ţ�����ΪNo select��

			//������NDS��¼���б�
			SetupCardType[0][0] = new CardType(0,"Normal 512K","512K","0000010000",1,0,".sav",0,"ͨ�õ�512K�浵��ʽ�����������¼��ʹ�����ָ�ʽ��");
			SetupCardType[0][1] = new CardType(0,"Acekard+ & Acekard RPG","AK","1110110000",4,0,".nds.sav",0,"slot1�ӿڣ�ʹ��TF��������(RPGר��)�洢����׼�浵��ʽ����ѡ���С��");
			SetupCardType[0][2] = new CardType(0,"Acekard 2","AK2","0000010000",1,0,".sav",0,"slot1�ӿڣ�ʹ��TF���洢����׼512K�浵��ʽ�� ");
			SetupCardType[0][3] = new CardType(0,"CycloDS Evolution","CyDS","0000010000",1,0,".sav",0,"slot1�ӿڣ�ʹ��TF���洢����׼512K�浵��ʽ��  ");
			SetupCardType[0][4] = new CardType(0,"DS FIRE LINK","DSFLK","0000100000",1,1,".sav",0,"DSGBA OEM��Ʒ��slot1+2�ӿڣ�ʹ�����ô洢оƬ����׼256K�浵��ʽ��");
			SetupCardType[0][5] = new CardType(0,"DSGBA","DSGBA","0000100000",1,1,".sav",0,"slot1+2�ӿڣ�ʹ�����ô洢оƬ����׼256K�浵��ʽ��");
			SetupCardType[0][6] = new CardType(0,"DSLink","DSLK","0000010000",1,0,".sav",2,"slot1�ӿڣ�ʹ�����ô洢оƬ���̶���520K���д浵��ʽ��");
			SetupCardType[0][7] = new CardType(0,"DSTT (Top Toy)","DSTT","0000010000",1,0,".sav",0,"slot1�ӿڣ�ʹ��TF���洢����׼512K�浵��ʽ��");
			SetupCardType[0][8] = new CardType(0,"DS-Xtreme 4Gb/16Gb","DSXr","0000100000",1,1,".sav",0,"slot1�ӿڣ�ʹ�����ô洢оƬ����׼256K�浵��ʽ��");
			SetupCardType[0][9] = new CardType(0,"EDGE","EDGE","0000010000",1,0,".sav",0,"slot1�ӿڣ�ʹ��TF���洢����׼512K�浵��ʽ�� ");
			SetupCardType[0][10] = new CardType(0,"EWIN2","EW2","0000110000",2,1,".sav",0,"slot2�ӿڣ�ʹ�����ô洢оƬ����׼�浵��ʽ���°汾���512K���ɰ汾���Ϊ256K��");
			SetupCardType[0][11] = new CardType(0,"EZ Flash 4","EZ4","0000100000",1,1,".sav",0,"slot2�ӿ�DS��GBA˫����¼����ʹ�����ô洢оƬ��DSģʽ����256K��׼�浵��ʽ��");
			SetupCardType[0][12] = new CardType(0,"EZ Flash 5","EZ5","1110110000",4,0,".sav",0,"slot1�ӿڣ�ʹ��TF���洢����׼�浵��ʽ����ѡ���С��");
			SetupCardType[0][13] = new CardType(0,"G6 (Lite)","G6","0000110000",1,0,".0",0,"slot2�ӿ�DS��GBA˫����¼����ʹ�����ô洢оƬ��DSģʽ����256K��512K��׼�浵��ʽ��");
			SetupCardType[0][14] = new CardType(0,"G6 DS Real","G6DSR","0000010000",1,0,".sav",0,"slot1�ӿڣ�ʹ�����ô洢оƬ��512K��׼�浵��ʽ��");
			SetupCardType[0][15] = new CardType(0,"M3 (Lite)","M3","0000110000",1,0,".dat",1,"slot2�ӿ�DS��GBA˫����¼����ʹ��SD��mini SD���洢��DSģʽ����257K��513K���д浵��ʽ��");
			SetupCardType[0][16] = new CardType(0,"M3 DS Real","M3DSR","0000010000",1,0,".sav",0,"slot1�ӿڣ�ʹ��TF���洢��512K��׼�浵��ʽ��");
			SetupCardType[0][17] = new CardType(0,"M3 DS Simply","M3DSS","0000010000",1,0,".sav",0,"slot1�ӿڣ�ʹ��TF���洢��512K��׼�浵��ʽ��");
			SetupCardType[0][18] = new CardType(0,"MK5","MK5","0000100000",1,1,".sav",0,"DSGBA OEM��Ʒ��slot1+2�ӿڣ�ʹ�����ô洢оƬ����׼256K�浵��ʽ��");
			SetupCardType[0][19] = new CardType(0,"N-CARD","NCARD","0000100000",1,1,".sav",0,"DSGBA OEM��Ʒ��slot1+2�ӿڣ�ʹ�����ô洢оƬ����׼256K�浵��ʽ��");
			SetupCardType[0][20] = new CardType(0,"NinjaDS","NjaDS","0000010000",1,0,".sav",0,"slot1�ӿڣ�ʹ�����ô洢оƬ����׼512K�浵��ʽ�� ");
			SetupCardType[0][21] = new CardType(0,"NinjaPass","NjaPa","0000100000",1,1,".sav",0,"slot1�ӿڣ�ʹ�����ô洢оƬ����׼256K�浵��ʽ�� ");
			SetupCardType[0][22] = new CardType(0,"R4","R4","0000010000",1,0,".sav",0,"slot1�ӿڣ�ʹ��TF���洢����׼512K�浵��ʽ�� ");
			SetupCardType[0][23] = new CardType(0,"Super Card (Lite)","SC","0000110000",1,1,".nds.sav",0,"slot2�ӿ�DS��GBA˫����¼����ʹ��SD��mini SD���洢��DSģʽ����256K��512K��׼�浵��ʽ��");
			SetupCardType[0][24] = new CardType(0,"Super Card DS (ONE)","SCDS","1110110000",4,0,".sav",0,"slot1�ӿڣ�ʹ��TF���洢����׼�浵��ʽ��");
			SetupCardType[0][25] = new CardType(0,"SUNNY FLASH","SYFH","0000100000",1,1,".sav",0,"DSGBA OEM��Ʒ��slot1+2�ӿڣ�ʹ�����ô洢оƬ����׼256K�浵��ʽ��");
			SetupCardType[0][26] = new CardType(0,"(EMU) NO$GBA (Raw)","NO$GBA","0000010000",1,0,".sav",0,"PC��ģ������ʹ��512K��׼�浵��ʽ�����е����д浵��ʽ��");
            SetupCardType[0][27] = new CardType(0, "(EMU) DeSmuME", "DeSmuME", "0010010000", 2, 0, ".dsv", 0, "PC��ģ������DeSmuME ���д浵��ʽ��\n\r\n\r��Ȼ�Ƽ���ʹ�ø�ģ�����ĵ��빦�ܣ�");
            SetupCardType[0][28] = new CardType(0,"Other (All Sizes)","OTHER","1111111000",5,1,".sav",0,"���������еĵ�DSģʽ��׼�浵��ʽ����¼����");

			//������GBA��¼���б�
			SetupCardType[1][0] = new CardType(1,"EZ 3IN1","3IN1","0001000000",1,0,".sav",0,"slot2�ӿ�GBA��¼����ʹ�����ô洢оƬ����׼128K�浵��ʽ��");
			SetupCardType[1][1] = new CardType(1,"Elink (Lite)","Elink","1111000000",3,0,".sav",0,"slot2�ӿ�GBA��¼����ʹ�����ô洢оƬ����׼�浵��ʽ��");
			SetupCardType[1][2] = new CardType(1,"EZ4","EZ4","0001000000",1,0,".sav",0,"slot2�ӿ�DS��GBA˫����¼����ʹ�����ô洢оƬ��GBAģʽ����128K��׼�浵��ʽ��");
			SetupCardType[1][3] = new CardType(1,"G6 (Lite)","G6","0001000000",1,0,".0",0,"slot2�ӿ�DS��GBA˫����¼����ʹ�����ô洢оƬ��GBAģʽ����128K��׼�浵��ʽ��");
			SetupCardType[1][4] = new CardType(1,"GBA Expansion Pack","GBAEP","0001000000",1,0,".0",0,"slot2�ӿ�GBA��¼����ʹ�����ô洢оƬ����׼128K�浵��ʽ��");
			SetupCardType[1][5] = new CardType(1,"M3 (Lite)","M3","0001001000",1,0,".dat",1,"slot2�ӿ�DS��GBA˫����¼����ʹ��SD��mini SD���洢��GBAģʽ����129K��1M���д浵��ʽ��");
			SetupCardType[1][6] = new CardType(1,"Super Card (Lite)","SC","0001000000",1,0,".nds.sav",0,"slot2�ӿ�DS��GBA˫����¼����ʹ��SD��mini SD���洢��GBAģʽ����128K��׼�浵��ʽ��");
			SetupCardType[1][7] = new CardType(1,"Other (All Sizes)","OTHER","1111111000",4,0,".sav",0,"���������е�GBAģʽ��׼�浵��ʽ����¼����");

		}

		#endregion

		#endregion

		#region  �ؼ�

		#region   ��ť
		private void btnInput_Click(object sender, System.EventArgs e) 
		{
			///�ļ�������
			txtInput.Text = OpenInputFile();
			ClearMessage();

			///�ò��Գ������Դ�ļ�����
			if(txtInput.Text != "" && chkTest.Checked) 
			{
				StartTest(txtInput.Text);
			}
		}

		private void btnChange_Click(object sender, System.EventArgs e) 
		{
			ClearMessage();

			///�鿴�������������Ϣ�Ƿ�����������������ʼת�����粻�������������ʾ��Ϣ��
			///	1��δָ��Դ�ļ�ʱ
			///	2������ļ�ΪM3��ʽ����δָ��ROM�ļ�ʱ

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

		#region   �б��
		private void cboLanguage_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			LanguageChange();
		}

		private void cboMode_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			ChangeMode();

			if(txtInput.Text != "" && chkTest.Checked)
			{
				StartTest(txtInput.Text);   //���Գ���
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

			ShowMessage("��¼��˵����"+SelectedCardType.CardInfo);		//��ʾ��¼��˵����Ϣ

			if(SelectedCardType.CardIs == 1)
				grpM3.Enabled = true; 
			else
				grpM3.Enabled = false;
		}

		#endregion

		#region   ��ѡ��
		private void chkTest_CheckedChanged(object sender, System.EventArgs e) 
		{
			///�ڹ�ѡ����ѡ���ϵͳ�Զ���Դ�浵���в��ԣ���������ѡ���������Խ��
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
			///�ڴ�����ǿ��ת����ѡ��
			if(chkPokemon.Checked) 
			{
				cboOutputSize.Enabled =false;
				MessageBox.Show("�����ܽ����ڽ����Ϊ512K�Ŀڴ���������/��ʯ�浵\nת����256K�Ĵ浵���������͵�ת���벻Ҫѡ��˹��ܡ�","�ڴ�����ǿ��ת����512K->256K��");
			}
			else 
			{
				cboOutputSize.Enabled =true;
			}	
		}

		#endregion

		#region   ����
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
			///����ؼ��ɷ����Կ���
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

		#region �����Ϣ
		private void ShowMessage(string OutputMessage) 
		{
			///ֱ�������Ϣ
			///

			lblMessage.Text += OutputMessage;
		}

		private void ClearMessage()
		{
			lblMessage.Text = "";
		}

		private void ShowMessage(int OutputMessageID,int myEnter)
		{
			///ת�������е���Ϣ
			///1Ϊǰ����
			///2Ϊ����
			///3Ϊǰ�������
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
			///ת��ǰ�����Ϣ
			///

			int intOutSize = new int();		//Ŀ��浵��С
			
			//���Ŀ��ΪM3��GBA��ʽ1M�浵�������1M�����������intLengthMaxEnd
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
			///Ԥ������Ϣ
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
			///��ȡԴ�浵ʵ�����
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
			//���������ת���޹ص���ʾ��Ϣ

			//ȡ��ϵͳ����
			DateTime myNowDate = DateTime.Now;

			//С���Ϲ����ҳ�Ա��������
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

		#region �ļ������������
		private string OpenInputFile()		//��Դ�浵�ļ�
		{
			///	��Դ�浵�ļ�
			///		�����򿪣�����ֵΪ�ļ���·��ȫ��
			///		��ʧ�ܣ�����ֵΪ��
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

		public string OpenROMFile()			//��M3��Ӧ��ROM�ļ�
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

		private string InputToOutput(string tempFileName)		//����������ļ���
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
			else					//Դ�ļ�Ϊ��ʱ��Ŀ���ļ�ҲҪΪ��
			{
				return ("");
			}
		}

		#endregion

		#region ���ļ���֧��

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]			//kernel32.dllΪ

		public static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)]  string path, [MarshalAs(UnmanagedType.LPTStr)]  StringBuilder shortPath, int shortPathLength);

		public static string ToShortPathName(string longName)
		{
			StringBuilder shortNameBuffer = new StringBuilder(256);

			int bufferSize = shortNameBuffer.Capacity;

			int result = GetShortPathName(longName, shortNameBuffer, bufferSize);

			return shortNameBuffer.ToString();
		}

		#endregion

		#region �û�ѡ��

		#region ����ѡ��
		private void LanguageChange()		//ת���������
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
		private void ChangeMode()      //ת���������б�
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

		private void SetSaveSize()		 //ת����浵����б�
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

		#region ��ȡ�û�������ѡ��
		private CardType SelectedCardType			//�����ѡ��ת������¼����ʽ
		{
			get
			{
				return SetupCardType[SelectedMode][cboOutputFormat.SelectedIndex];
			}
		}

		private int SelectedLanguage		//�����ѡ������
		{
			get
			{
				return cboLanguage.SelectedIndex;
	
			}
		}

		private int SelectedMode			//�����ѡ��ת��ģʽ
		{
			get
			{
				return cboMode.SelectedIndex;
	
			}
		}

		private int SelectedSize			//�����ѡ��ת�����
		{
			get
			{
				return cboOutputSize.SelectedIndex;
	
			}
		}

		private string ReadFileName(string NameType)	//��ȡ�������ı����ڵ���Ϣ
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

		#region  ���ĳ���

		#region  ����ת��
		private void StartChange(bool boolPokemon)
		{
			///
			///�ж�Դ�浵��ʽ��ѡȡ��ͬ��ת����ʽ
			///
			string strNameTemp = "";						//Ԥת����������ʱ�ļ���
			string strNameChange = "";						//����ת���������ļ���
			string strInputName = ReadFileName("InputName");	//Դ�浵�����ļ���
			string strOutputName = ReadFileName("OutputName");	//Ŀ��浵�����ļ�
			string strInputMode = InputFileMode(strInputName);	//Դ�浵��ʽ
			
			//�ж�Դ�浵��ʽ���Բ��ָ�ʽ��Դ�浵����Ԥת��
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

			//��ʽת��
			if(boolPokemon)
			{
				StartPokemonChange(strNameChange,strOutputName);
			}
			else
			{
				MainChange(strNameChange,strOutputName);
			}

			//ɾ��Ԥת����������ʱ�ļ�
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
			///����Դ�ļ��������ת��
			///
			int intAdd = 0;									//���Ӳ��ִ�С
			int intCopyLengh;								//Դ�ļ�����Ҫ�����ݳ���
			int intOutputLenghAdd;							//�ȴ����Ӻ��С ת�����ļ���С�������Ӳ��֣�
			bool IsM3Gba1MB = false;						//��ǣ�Ŀ��Ϊ1M byte��С��M3��ʽ��GBA�浵
			int intOutputLengh = UsedSize[SelectedSize];	//ת�����ļ���С���޸��Ӳ��֣�
			string InputFileType = "";						//Դ�浵��ʽ

			///	M3 GBA 1M byte������������
			///		1��Ŀ���СΪ1M byte
			///		2��Ŀ���ʽΪM3
			///		3��GBAģʽ
			///	��ʱ��ֻ��ȡǰ128K����

			if((intOutputLengh == 1024*1024) && (SelectedCardType.CardIs == 1) && (SelectedMode == 1))
			{
				intOutputLengh = 128*1024;
				IsM3Gba1MB = true;
			}

			///	����ת���󸽼Ӳ��ִ�С��
			///		Ŀ��浵ΪDSLink��ʽ(CardIs=2)ʱ��+8K
			///		Ŀ��浵��ΪM3��ʽ(CardIs=1)ʱ��+1K
			///		Ŀ��浵Ϊ������ʽ(CardIs=0)ʱ��������

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

			intOutputLenghAdd = intOutputLengh + intAdd;	//����ת�����ļ���С

			try
			{
				InputFileType = InputFileMode(InputName);	//�ж�Դ�ļ���ʽ

				FileStream sri = new FileStream(InputName, FileMode.Open, FileAccess.Read);
				FileStream sro = new FileStream(OutputName, FileMode.Create);
				intCopyLengh = (int)sri.Length;

				///	Դ�ļ����Ȳ��Ǳ�׼����ʱ�����������
				///		Դ�ļ���512k��1M֮�䣨����520k����ִ��512k
				///		Դ�ļ���256k��512k֮�䣨����257k����ִ��256k
				///		Դ�ļ���128k��256k֮�䣨����129k����ִ��128k
				///		Դ�ļ���64k��128k֮�䣬ִ��64k
				///		Դ�ļ���8k��64k֮�䣬ִ��8k
				///		Դ�ļ���512B��128k֮�䣬ִ��512B


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

				//	Դ�ļ��е����ݳ��ȴ���Ŀ���ļ�����ʱ����Ŀ���ļ�����Ϊ׼
				if (intCopyLengh > intOutputLengh)
				{
					intCopyLengh = intOutputLengh;
				}
				
				//���ת��ǰ����浵�ļ������͡����
				ShowMessage ( InputFileType, (int)sri.Length, intOutputLenghAdd, IsM3Gba1MB);

				//��Դ�ļ�����д��Ŀ���ļ�
				CopyDataStart ( InputName, sri, sro, intCopyLengh, intOutputLengh, InputFileType, IsM3Gba1MB);

				if (InputFileType == "UnKnown")
				{
					MessageBox.Show("����Դ�浵Ϊδ֪�浵��ʽ������ת����Ĵ浵�����޷�ʹ�á�\n����Դ�浵�ļ��Ƿ���ȷ�ҿ��á�","Դ�浵����");
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

		private void CopyDataStart(string InputName,FileStream sri,FileStream sro,int intCopyLengh,int intOutputLengh,string InputFileType,bool M3Add1M)		//��ʼת��
		{
			///
			///��Դ�浵��Ŀ��浵��������
			///
			try
			{
				myAllControl(false);

				if(CopyData(sri,sro,intCopyLengh,intOutputLengh,InputFileType) == 0)
				{
					ShowMessage(1,2);


                    //	д��M3��DSLINK�ĸ��Ӳ���
                    //		Ŀ��浵ΪM3��ʽ(CardIs=1)ʱ������1K
                    //		Ŀ��浵ΪDSLink��ʽ(CardIs=2)ʱ������8K

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

		private int CopyData(FileStream sri,FileStream sro,int intCopyLengh,int intOutputLengh,string InputFileType)		//��Դ�浵��Ŀ��浵��������
		{
			///
			///��Դ�浵��Ŀ��浵��������
			///

			try
			{
				int i = new int();
				BinaryReader r = new BinaryReader(sri);
				BinaryWriter w = new BinaryWriter(sro);

				///	ת������ĺ��Ĳ���
				///		�������ʽΪUncompressed��ʽ��NO$GBA�浵ʱ������0x4c(76)
				///		�����ʽΪDUC��ʽ��AR�浵ʱ������0x1f4(500)
				///		�����ʽΪEEPROM��ʽ��DSLINK�浵ʱ,ǰ512k�����ݣ�����1024*512����ʱ
				///			Ŀ�꣺512B��ֻ����ǰ512B
				///			Ŀ�꣺���ڵ���8K��ȫ������
				///			��ʱ��ʵ�ʸ��Ƶ������п��ܻ��intCopyLenghС������Ҫ��Ŀ���ļ���0xff��ȫ��intCopyLengh��С
				///		�������ʽΪ������ʽʱ��ֱ�Ӹ�������

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

				//	��Ŀ���ļ���0xff��ȫ����Ҫ�Ĵ�С
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
			///	�ж�Դ�ļ���ʽ
			///
			long intCopyLengh,i;				//Դ�浵���
			string InputFileType = "";		//Դ�浵��ʽ
			string txtNoGba1 = "";			//NO$GBA��һʶ���ַ���
			string txtNoGba2 = "";			//NO$GBA�ڶ�ʶ���ַ���
			string strActionReplay = "";	//Action Replay Max DSʶ���ַ���
            string strDeSmuME = "";         //DeSmuMEʶ���ַ���
            int intNoGba = 0;				//NO$GBA��ʽģʽ���ֱ��

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

                ///	�ж�Դ�浵��ʽ
                ///		1��NO$GBA��ʽ
                ///			a��"UnCo NO$GBA"	532848byte��С��Uncompressed��ʽ����ѹ����ʽ��
                ///			b��"Com NO$GBA"		Compressed��ʽ��ѹ����ʽ��
                ///			c��"UnKnown"		δ֪��ʽ
                ///		2��Action Replay Max DSģʽ
                ///			a��"AR DUC"		AR DUCģʽ
                ///			b��"AR DST"		AR DSTģʽ
                ///		3��DSLinkģʽ
                ///			a��"DSLink EEPROM"	EEPROMģʽ
                ///			b��"DSLink FLASH"	FLASHģʽ
                ///		4��"M3"			M3��ʽ
                ///		5��"Normal"		��׼��ʽ
                ///		6��"DeSmuME"	DeSmuME��ʽ
                ///		7��"UnKnown"	δ֪��ʽ

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

		#region  ����ת��
		private void StartPokemonChange(string InputName,string OutputName)		//�ڴ����ִ浵����ת��
		{
			myAllControl(false);

			ShowMessage(23,2);

			try
			{
				int intLength,flag,intNewTest1,intNewTest2 = new int();
				string InputFileType = InputFileMode(InputName);		//�ж�Դ�ļ���ʽ
				FileStream sr1 = new FileStream(InputName, FileMode.Open, FileAccess.Read);
				BinaryReader r1 = new BinaryReader(sr1);
				intLength = (int)sr1.Length;
				

				if (InputFileType == "UnCo NO$GBA")		//�����ʽ�Ƿ�Ϊ532848byte��С��Uncompressed��ʽ��NO$GBA�浵
				{
					r1.ReadBytes(76);	//0x4c
				}
				if (InputFileType == "AR DUC")			//�����ʽ�Ƿ�ΪDUC��ʽ��AR�浵
				{
					r1.ReadBytes(500);	//0x1F4
				}

				if(intLength >= 512*1024)
				{
					//��ȡ�浵����(4�ֽڶ�ȡ)
					r1.ReadBytes(49392);		//0xc0f0
					intNewTest1 = Convert.ToInt16(sr1.ReadByte()) + Convert.ToInt16(sr1.ReadByte())*256 + Convert.ToInt16(sr1.ReadByte())*256*256 + Convert.ToInt16(sr1.ReadByte())*256*256*256;	//��һ���浵�Ĵ浵����
					r1.ReadBytes(256*1024-4);
					intNewTest2 = Convert.ToInt16(sr1.ReadByte()) + Convert.ToInt16(sr1.ReadByte())*256 + Convert.ToInt16(sr1.ReadByte())*256*256 + Convert.ToInt16(sr1.ReadByte())*256*256*256;	//�ڶ����浵�Ĵ浵����
					sr1.Close();

					intNewTest1 = (intNewTest1<0?0:intNewTest1);
					intNewTest2 = (intNewTest2<0?0:intNewTest2);
					
					if(intNewTest1 != 0 || intNewTest2 != 0)
					{
						//���մ浵�����ж��Ⱥ�˳��
						flag = (intNewTest1>=intNewTest2?1:2);

						//������д���´浵��Ĭ�ϴ浵Ϊʱ�俿��Ĵ浵��ʱ�俿ǰ��Ҳת�������ӡ�.old����׺
						FileStream sr2 = new FileStream(InputName, FileMode.Open, FileAccess.Read);
						BinaryReader r2 = new BinaryReader(sr2);

						if (InputFileType == "UnCo NO$GBA")		//�����ʽ�Ƿ�Ϊ532848byte��С��Uncompressed��ʽ��NO$GBA�浵
						{
							r2.ReadBytes(76);	//0x4c
						}
						if (InputFileType == "AR DUC")			//�����ʽ�Ƿ�ΪDUC��ʽ��AR�浵
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

						//�����Ϣ
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

		private string NOGBACompressedChange(string strInputName)		//Դ�浵ΪCompressed��ʽNO$GBA�浵��Ԥת��
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
				//��ʼת��

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
					MessageBox.Show("NO$GBA�浵Ԥ������ִ�����ת����Ĵ浵����\n\n�޷�����ʹ�á���ȷ��Դ�浵��ʽ��ȷ���������","Ԥ�������");
				}

				return(strOutputName);
			}

			catch
			{
				MessageBox.Show("NO$GBA�浵Ԥ������ִ�����ת����Ĵ浵����\n\n�޷�����ʹ�á���ȷ��Դ�浵��ʽ��ȷ���������","Ԥ�������");
				
				return("");
			}
			finally
			{
			}
		}

		private string ARDSTChange(string strInputName)		//Դ�浵ΪDST��ʽAR�浵��Ԥת��
		{
			try
			{
				int i,cont,j,k;
				int intByteRead = 0;
				byte tempByteRead;
				byte ByteRead;
				int intByteTemp=0;		//��־λ
				int intNum = 0;			//�ֶεĸ���
				int intTimes = 0;		//��ǰ�����ȡ���ֽ�����������־λ

				string strOutputName = strInputName+".temp";

				FileStream sri = new FileStream(strInputName, FileMode.Open, FileAccess.Read);
				FileStream sro = new FileStream(strOutputName, FileMode.Create);
				BinaryReader r = new BinaryReader(sri);
				BinaryWriter w = new BinaryWriter(sro);
			
				ShowMessage("AR DST",(int)sri.Length);
				//��ʼת��

				r.ReadBytes(0x1f8);
				intNum = Convert.ToInt16(r.ReadByte());
				r.ReadBytes(0x3);

				///ÿ8KΪһ���ֶΣ���intNum��
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
				MessageBox.Show("AR DST�浵Ԥ������ִ�����ת����Ĵ浵����\n\n�޷�����ʹ�á���ȷ��Դ�浵��ʽ��ȷ���������","Ԥ�������");
				
				return("");
			}
			finally
			{
			}
		}

		#endregion

		#region ������¼���Ĵ���
		private int M3Adding(string ShortName,string LongName,FileStream sro,int SelectMode,bool M3Add1M)	//M3���ӵ�1k��Ϣ
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

				ShortName = ShortName.Remove(ShortName.Length - 4,4);	//ȥ�����ļ����ĺ�׺

				using (StreamWriter sw = new StreamWriter(sro, UnicodeEncoding.GetEncoding("GB2312")))
				{
					sw.AutoFlush = true;								//�Զ�����
					sw.Write("BOOT\x0000"+ShortName);					//1:д��"BOOT & 0x00"�Լ����ļ���
					for (i = (int)sro.Length; i < LengthMax + 13; i++)	//2:�����ļ����չ�8���ֽ�
					{
						sro.WriteByte(0x20);
					}
					sw.Write(M3SaveMode+"\x0001");						//3:д��"NDS(GBA) & 0x01"
					for (i = 0; i < 20; i++)							//4:д��հ�
					{
						sro.WriteByte(0x00);
					}
					sw.Write(LongName);									//5:д�볤�ļ���
					sw.AutoFlush = false;
					for (i = (int)sro.Length; i < LengthMax + 1024; i++)//6:д�����Ŀհײ���
					{
						sro.WriteByte(0x00);
					}
					sw.Flush();
					if (M3Add1M)
					{
						for (i = 0; i <(1024-129)*1024; i++)			//д��M3 GBA�浵��129K��1M���Ӳ��֣��ɰ汾�浵��
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

		private int DSLinkAdding(string InputName,FileStream sro,string InputMode)	//DSLink ���ӵ�8k��Ϣ
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

        private int DeSmuMEAdding(int intCopyLength, FileStream sro, string InputMode)    //DeSmuME ����
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

        #region ���Գ���
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
			int TestCont = 7;	//	��ʱ���ܸ�Ϊ10
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

				//ShowMessage(intTestLengh.ToString());			//����ר��

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

				//ShowMessage(SaveTestFlag+"\n");  //����ר��

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

		private void ShowTestMap(string strFlag)		//�Բ�ɫ��ʽ������Խ������ʱ��֧��8M�浵�����⣬��ʱ��֧����ȫ��������޸��У�
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

		private string ShowTestText(string strFlag,int intSelectMode)		//������Խ����ʾ
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

		#region DOS����

		private static void DOSCommand(double OutSize,string InputName,string OutputName)		//��ʼת��
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

				intLengthMax = (int)(OutSize*1024.0);	//ת�����ļ���С���޸��Ӳ��֣�
				intLengthMaxEnd = intLengthMax;

				if (intCopyLengh > intLengthMax)				//Դ�ļ����ȴ���Ŀ���ļ�����
				{
					intCopyLengh = intLengthMax;
				}
				if ((intCopyLengh < 524288) && (intCopyLengh > 262144))			//256k��512k֮�䣨257k����ִ��256k
				{
					intCopyLengh = 262144;
				}
				else if ((intCopyLengh < 262144) && (intCopyLengh > 131072))	//128k��256k֮�䣨129k����ִ��128k
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