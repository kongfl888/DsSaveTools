using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace DSSaveTools
{
    public class fWii : Form
	{
        private IContainer components = null;

		private OpenFileDialog dialogOpenWiiSave;

		private TextBox txtOpenSave;

		private Button btnOpenSave;

		private Button btnExit;

		private Label lblName;

		private Label lblString;

		private Label lblType;

		private Label lblLanguage;

		private TextBox txtName;

		private TextBox txtType;

		private TextBox txtString;

		private TextBox txtLanguage;

		private Label lblFile;

		private Label lblSize;

		private TextBox txtSize;

		private Label lblWeizhi;

		private TextBox txtWeizhi;

		private Label lblTest;

		private TextBox txtTest;

		private TextBox txtFolder;

		private Label lblFolder;

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.dialogOpenWiiSave = new System.Windows.Forms.OpenFileDialog();
            this.txtOpenSave = new System.Windows.Forms.TextBox();
            this.btnOpenSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblString = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblWeizhi = new System.Windows.Forms.Label();
            this.txtWeizhi = new System.Windows.Forms.TextBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOpenSave
            // 
            this.txtOpenSave.Location = new System.Drawing.Point(80, 16);
            this.txtOpenSave.Name = "txtOpenSave";
            this.txtOpenSave.Size = new System.Drawing.Size(382, 21);
            this.txtOpenSave.TabIndex = 0;
            // 
            // btnOpenSave
            // 
            this.btnOpenSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSave.Location = new System.Drawing.Point(353, 144);
            this.btnOpenSave.Name = "btnOpenSave";
            this.btnOpenSave.Size = new System.Drawing.Size(54, 23);
            this.btnOpenSave.TabIndex = 1;
            this.btnOpenSave.Text = "打开";
            this.btnOpenSave.UseVisualStyleBackColor = true;
            this.btnOpenSave.Click += new System.EventHandler(this.btnOpenSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(413, 144);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "游戏名称";
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(8, 83);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(65, 12);
            this.lblString.TabIndex = 4;
            this.lblString.Text = "标志字符串";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(152, 83);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(29, 12);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "类型";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(373, 51);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(29, 12);
            this.lblLanguage.TabIndex = 6;
            this.lblLanguage.Text = "版本";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 45);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(274, 21);
            this.txtName.TabIndex = 7;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(184, 80);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(162, 21);
            this.txtType.TabIndex = 8;
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(88, 80);
            this.txtString.Name = "txtString";
            this.txtString.ReadOnly = true;
            this.txtString.Size = new System.Drawing.Size(58, 21);
            this.txtString.TabIndex = 9;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(408, 48);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.ReadOnly = true;
            this.txtLanguage.Size = new System.Drawing.Size(54, 21);
            this.txtLanguage.TabIndex = 10;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(8, 19);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(53, 12);
            this.lblFile.TabIndex = 11;
            this.lblFile.Text = "存档文件";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(352, 83);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(53, 12);
            this.lblSize.TabIndex = 12;
            this.lblSize.Text = "存档格数";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(416, 80);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(46, 21);
            this.txtSize.TabIndex = 13;
            // 
            // lblWeizhi
            // 
            this.lblWeizhi.AutoSize = true;
            this.lblWeizhi.Location = new System.Drawing.Point(8, 115);
            this.lblWeizhi.Name = "lblWeizhi";
            this.lblWeizhi.Size = new System.Drawing.Size(101, 12);
            this.lblWeizhi.TabIndex = 14;
            this.lblWeizhi.Text = "标识字符串偏移量";
            // 
            // txtWeizhi
            // 
            this.txtWeizhi.Location = new System.Drawing.Point(128, 112);
            this.txtWeizhi.Name = "txtWeizhi";
            this.txtWeizhi.ReadOnly = true;
            this.txtWeizhi.Size = new System.Drawing.Size(100, 21);
            this.txtWeizhi.TabIndex = 15;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(249, 115);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(89, 12);
            this.lblTest.TabIndex = 16;
            this.lblTest.Text = "是否为标准存档";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(344, 112);
            this.txtTest.Name = "txtTest";
            this.txtTest.ReadOnly = true;
            this.txtTest.Size = new System.Drawing.Size(118, 21);
            this.txtTest.TabIndex = 17;
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(96, 144);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(250, 21);
            this.txtFolder.TabIndex = 18;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(8, 149);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(65, 12);
            this.lblFolder.TabIndex = 19;
            this.lblFolder.Text = "存档全路径";
            // 
            // fWii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 178);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.txtWeizhi);
            this.Controls.Add(this.lblWeizhi);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenSave);
            this.Controls.Add(this.txtOpenSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fWii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WII存档信息提取";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		public fWii()
		{
			this.InitializeComponent();
		}

		private void btnOpenSave_Click(object sender, EventArgs e)
		{
			this.OpenWiiSaveFile();
			this.ReadTest();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void OpenWiiSaveFile()
		{
			string text = "";
			text += "Wii Save Files(*.bin)|*.bin";
			text += "|NGC Save Files(*.gci)|*.gci";
			this.dialogOpenWiiSave.Filter = text;
			if (this.dialogOpenWiiSave.ShowDialog() == DialogResult.OK)
			{
				this.txtOpenSave.Text = this.dialogOpenWiiSave.FileName;
			}
		}

        private void IL_A4Imp(ref string text, ref bool flag, ref char[] array, ref int iHex, ref int intSaveLengh)
        {
            for (int i = 0; i < 4; i++)
            {
                text += array[i].ToString();
            }
            if (flag)
            {
                this.txtString.Text = text;
                this.txtFolder.Text = "\\private\\wii\\title\\" + text + "\\";
                this.txtWeizhi.Text = Convert.ToString(iHex, 16) + "h";
                if (iHex != 61732 && iHex != 0)
                {
                    this.txtTest.Text = "非标准存档";
                }
                else
                {
                    this.txtTest.Text = "标准存档";
                }
                this.myMessage(array);
            }
            else
            {
                this.txtString.Text = "无法识别";
                this.ErrorMessage();
            }
            int SaveFileLength;
            if (array[0].ToString() == "G")
            {
                SaveFileLength = intSaveLengh / 1024 / 8 + 1;
            }
            else
            {
                SaveFileLength = intSaveLengh / 1024 / 128 + 1;
            }
            this.txtSize.Text = SaveFileLength.ToString();
        }


        private void ReadTest()
		{
			int iHex = 0;
			string text = "";
			bool flag = false;
			char[] array = new char[4];
			try
			{
				if (this.dialogOpenWiiSave.FileName != "")
				{
					FileStream fileStream = new FileStream(this.dialogOpenWiiSave.FileName, FileMode.Open, FileAccess.Read);
					int intSaveLengh = (int)fileStream.Length;
					BinaryReader binaryReader = new BinaryReader(fileStream);
					for (int i = 0; i < intSaveLengh / 4; i++)
					{
						array[0] = (char)binaryReader.ReadByte();
						array[1] = (char)binaryReader.ReadByte();
						array[2] = (char)binaryReader.ReadByte();
						array[3] = (char)binaryReader.ReadByte();
						if (flag = this.IsMyString(array))
						{
							iHex = i * 4;
                            ////IL_A4:
                            IL_A4Imp(ref text, ref flag, ref array, ref iHex, ref intSaveLengh);
                            //goto IL_1A4;
                            return;
                        }
					}
                    IL_A4Imp(ref text, ref flag, ref array, ref iHex, ref intSaveLengh);
                }
				//IL_1A4:;
			}
			catch
			{
				this.txtString.Text = "错误！";
				this.ErrorMessage();
			}
		}

		private bool IsMyString(char[] SaveCode)
		{
			for (int i = 0; i < 4; i++)
			{
				if (SaveCode[i] < '0' || (SaveCode[i] > '9' && SaveCode[i] < 'A') || SaveCode[i] > 'Z')
				{
					return false;
				}
			}
			if (SaveCode[0] == 'R' || SaveCode[0] == 'H' || SaveCode[0] == 'E' || SaveCode[0] == 'G')
			{
				if (SaveCode[3] != 'J' && SaveCode[3] != 'E' && SaveCode[3] != 'U')
				{
					if (SaveCode[3] != 'P')
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		private void ErrorMessage()
		{
			this.txtType.Text = "未知";
			this.txtName.Text = "未知游戏";
			this.txtLanguage.Text = "未知";
		}

		private void myMessage(char[] myCode)
		{
			char c = myCode[0];
			switch (c)
			{
			case 'E':
				this.txtType.Text = "N64游戏存档";
				goto IL_7C;
			case 'F':
				break;
			case 'G':
				this.txtType.Text = "NGC游戏存档";
				goto IL_7C;
			case 'H':
				this.txtType.Text = "Wii频道备份";
				goto IL_7C;
			default:
				if (c == 'R')
				{
					this.txtType.Text = "Wii游戏存档";
					goto IL_7C;
				}
				break;
			}
			this.txtType.Text = "未知";
			IL_7C:
			string key;
			switch (key = myCode[1].ToString() + myCode[2].ToString())
			{
			case "4Q":
				this.txtName.Text = "马里奥足球 激情四射";
				goto IL_4CD;
			case "8P":
				this.txtName.Text = "超级纸片马里奥";
				goto IL_4CD;
			case "AJ":
				this.txtName.Text = "wii投票频道";
				goto IL_4CD;
			case "AP":
				this.txtName.Text = "mii选美频道";
				goto IL_4CD;
			case "B4":
				this.txtName.Text = "生化危机4 Wii编辑版";
				goto IL_4CD;
			case "BB":
				this.txtName.Text = "炸弹人大陆";
				goto IL_4CD;
			case "CC":
				this.txtName.Text = "料理妈妈烹饪指南";
				goto IL_4CD;
			case "CD":
				this.txtName.Text = "使命召唤3";
				goto IL_4CD;
			case "DB":
				this.txtName.Text = "龙珠Z 电光火石";
				goto IL_4CD;
			case "DR":
				this.txtName.Text = "水精灵大冒险";
				goto IL_4CD;
			case "ET":
				this.txtName.Text = "绿日达人";
				goto IL_4CD;
			case "F8":
				this.txtName.Text = "FIFA 08";
				goto IL_4CD;
			case "GT":
				this.txtName.Text = "GT赛车职业系列赛";
				goto IL_4CD;
			case "HA":
				this.txtName.Text = "玩玩Wii";
				goto IL_4CD;
			case "IP":
				this.txtName.Text = "海贼王 无尽的冒险";
				goto IL_4CD;
			case "K4":
				this.txtName.Text = "结界师 黑芒楼之影";
				goto IL_4CD;
			case "KD":
				this.txtName.Text = "超执刀 二次执刀";
				goto IL_4CD;
			case "M8":
				this.txtName.Text = "马力欧聚会8";
				goto IL_4CD;
			case "MG":
				this.txtName.Text = "超级马里奥 银河";
				goto IL_4CD;
			case "OD":
				this.txtName.Text = "瓦里奥制造 手舞足蹈";
				goto IL_4CD;
			case "RB":
				this.txtName.Text = "雷曼－疯狂兔子";
				goto IL_4CD;
			case "S5":
				this.txtName.Text = "战国无双 刀";
				goto IL_4CD;
			case "SP":
				this.txtName.Text = "Wii体育";
				goto IL_4CD;
			case "SR":
				this.txtName.Text = "索尼克与神秘指环";
				goto IL_4CD;
			case "TR":
				this.txtName.Text = "目标!!钓鱼大师";
				goto IL_4CD;
			case "WS":
				this.txtName.Text = "马里奥与索尼克在北京奥运会";
				goto IL_4CD;
			case "ZD":
				this.txtName.Text = "塞尔达传说 黎明公主";
				goto IL_4CD;
			default:
			this.txtName.Text = "未知游戏";
            break;
            }
			IL_4CD:
			char c2 = myCode[3];
			if (c2 == 'E')
			{
				this.txtLanguage.Text = "美版";
				return;
			}
			if (c2 == 'J')
			{
				this.txtLanguage.Text = "日版";
				return;
			}
			if (c2 != 'P')
			{
				this.txtLanguage.Text = "未知";
				return;
			}
			this.txtLanguage.Text = "欧版";
		}
	}
}
