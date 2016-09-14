using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

namespace Anter.Win32.JL.DSSaveTools
{
	/// <summary>
	/// frmWii 的摘要说明。
	/// </summary>
	public class frmWii : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog dialogOpenWiiSave;
		private System.Windows.Forms.TextBox txtOpenSave;
		private System.Windows.Forms.Button btnOpenSave;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblString;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Label lblLanguage;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.TextBox txtString;
		private System.Windows.Forms.TextBox txtLanguage;
		private System.Windows.Forms.Label lblFile;
		private System.Windows.Forms.Label lblSize;
		private System.Windows.Forms.TextBox txtSize;
		private System.Windows.Forms.Label lblWeizhi;
		private System.Windows.Forms.TextBox txtWeizhi;
		private System.Windows.Forms.Label lblTest;
		private System.Windows.Forms.TextBox txtTest;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmWii()
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
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.dialogOpenWiiSave = new System.Windows.Forms.OpenFileDialog();
			this.txtOpenSave = new System.Windows.Forms.TextBox();
			this.btnOpenSave = new System.Windows.Forms.Button();
			this.lblString = new System.Windows.Forms.Label();
			this.lblLanguage = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtType = new System.Windows.Forms.TextBox();
			this.txtString = new System.Windows.Forms.TextBox();
			this.txtLanguage = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblFile = new System.Windows.Forms.Label();
			this.lblSize = new System.Windows.Forms.Label();
			this.txtSize = new System.Windows.Forms.TextBox();
			this.lblWeizhi = new System.Windows.Forms.Label();
			this.txtWeizhi = new System.Windows.Forms.TextBox();
			this.lblTest = new System.Windows.Forms.Label();
			this.txtTest = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtOpenSave
			// 
			this.txtOpenSave.Location = new System.Drawing.Point(80, 16);
			this.txtOpenSave.Name = "txtOpenSave";
			this.txtOpenSave.Size = new System.Drawing.Size(448, 21);
			this.txtOpenSave.TabIndex = 0;
			this.txtOpenSave.Text = "";
			// 
			// btnOpenSave
			// 
			this.btnOpenSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOpenSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenSave.Location = new System.Drawing.Point(472, 80);
			this.btnOpenSave.Name = "btnOpenSave";
			this.btnOpenSave.Size = new System.Drawing.Size(56, 24);
			this.btnOpenSave.TabIndex = 1;
			this.btnOpenSave.Text = "打开";
			this.btnOpenSave.Click += new System.EventHandler(this.btnOpenSave_Click);
			// 
			// lblString
			// 
			this.lblString.Location = new System.Drawing.Point(8, 48);
			this.lblString.Name = "lblString";
			this.lblString.Size = new System.Drawing.Size(72, 21);
			this.lblString.TabIndex = 2;
			this.lblString.Text = "标志字符串";
			this.lblString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblLanguage
			// 
			this.lblLanguage.Location = new System.Drawing.Point(352, 80);
			this.lblLanguage.Name = "lblLanguage";
			this.lblLanguage.Size = new System.Drawing.Size(48, 21);
			this.lblLanguage.TabIndex = 3;
			this.lblLanguage.Text = "版本";
			this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(8, 80);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(64, 21);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "游戏名称";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblType
			// 
			this.lblType.Location = new System.Drawing.Point(176, 48);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(32, 21);
			this.lblType.TabIndex = 5;
			this.lblType.Text = "类型";
			this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(80, 80);
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(264, 21);
			this.txtName.TabIndex = 6;
			this.txtName.Text = "";
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(216, 48);
			this.txtType.Name = "txtType";
			this.txtType.ReadOnly = true;
			this.txtType.Size = new System.Drawing.Size(152, 21);
			this.txtType.TabIndex = 7;
			this.txtType.Text = "";
			// 
			// txtString
			// 
			this.txtString.Location = new System.Drawing.Point(88, 48);
			this.txtString.Name = "txtString";
			this.txtString.ReadOnly = true;
			this.txtString.Size = new System.Drawing.Size(56, 21);
			this.txtString.TabIndex = 8;
			this.txtString.Text = "";
			// 
			// txtLanguage
			// 
			this.txtLanguage.Location = new System.Drawing.Point(400, 80);
			this.txtLanguage.Name = "txtLanguage";
			this.txtLanguage.ReadOnly = true;
			this.txtLanguage.Size = new System.Drawing.Size(56, 21);
			this.txtLanguage.TabIndex = 9;
			this.txtLanguage.Text = "";
			// 
			// btnExit
			// 
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Location = new System.Drawing.Point(472, 112);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(56, 24);
			this.btnExit.TabIndex = 10;
			this.btnExit.Text = "退出";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblFile
			// 
			this.lblFile.Location = new System.Drawing.Point(8, 16);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(64, 21);
			this.lblFile.TabIndex = 11;
			this.lblFile.Text = "存档文件";
			this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSize
			// 
			this.lblSize.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblSize.Location = new System.Drawing.Point(400, 48);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new System.Drawing.Size(64, 21);
			this.lblSize.TabIndex = 12;
			this.lblSize.Text = "存档格数";
			this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtSize
			// 
			this.txtSize.Location = new System.Drawing.Point(464, 48);
			this.txtSize.Name = "txtSize";
			this.txtSize.ReadOnly = true;
			this.txtSize.Size = new System.Drawing.Size(64, 21);
			this.txtSize.TabIndex = 13;
			this.txtSize.Text = "";
			// 
			// lblWeizhi
			// 
			this.lblWeizhi.Location = new System.Drawing.Point(8, 112);
			this.lblWeizhi.Name = "lblWeizhi";
			this.lblWeizhi.Size = new System.Drawing.Size(112, 24);
			this.lblWeizhi.TabIndex = 14;
			this.lblWeizhi.Text = "标识字符串偏移量";
			this.lblWeizhi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtWeizhi
			// 
			this.txtWeizhi.Location = new System.Drawing.Point(128, 112);
			this.txtWeizhi.Name = "txtWeizhi";
			this.txtWeizhi.ReadOnly = true;
			this.txtWeizhi.Size = new System.Drawing.Size(88, 21);
			this.txtWeizhi.TabIndex = 15;
			this.txtWeizhi.Text = "";
			// 
			// lblTest
			// 
			this.lblTest.Location = new System.Drawing.Point(240, 112);
			this.lblTest.Name = "lblTest";
			this.lblTest.Size = new System.Drawing.Size(96, 24);
			this.lblTest.TabIndex = 16;
			this.lblTest.Text = "是否为标准存档";
			this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtTest
			// 
			this.txtTest.Location = new System.Drawing.Point(344, 112);
			this.txtTest.Name = "txtTest";
			this.txtTest.ReadOnly = true;
			this.txtTest.Size = new System.Drawing.Size(88, 21);
			this.txtTest.TabIndex = 17;
			this.txtTest.Text = "";
			// 
			// frmWii
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(544, 146);
			this.Controls.Add(this.txtTest);
			this.Controls.Add(this.lblTest);
			this.Controls.Add(this.txtWeizhi);
			this.Controls.Add(this.lblWeizhi);
			this.Controls.Add(this.txtSize);
			this.Controls.Add(this.lblSize);
			this.Controls.Add(this.lblFile);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtLanguage);
			this.Controls.Add(this.txtString);
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblType);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblLanguage);
			this.Controls.Add(this.lblString);
			this.Controls.Add(this.btnOpenSave);
			this.Controls.Add(this.txtOpenSave);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(552, 180);
			this.MinimumSize = new System.Drawing.Size(552, 180);
			this.Name = "frmWii";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "WII存档检测（测试）";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOpenSave_Click(object sender, System.EventArgs e)
		{
			OpenWiiSaveFile();
			ReadTest();
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void OpenWiiSaveFile()		//打开源存档文件
		{
			string OpenFilter = "";
			OpenFilter += "Wii Save Files(*.bin)|*.bin";
			OpenFilter += "|NGC Save Files(*.gci)|*.gci";
			dialogOpenWiiSave.Filter = OpenFilter;
			if (dialogOpenWiiSave.ShowDialog() == DialogResult.OK)
			{
				txtOpenSave.Text = dialogOpenWiiSave.FileName;
			}
		}

		private void ReadTest()		//寻找标识字符串
		{
			int i = 0;
			int SaveFileLength;
			int iHex = new int();
			string strCode = "";
			bool flag = false;
			char[] charCode = new char[4];
			try
			{
				if(dialogOpenWiiSave.FileName != "")
				{
					FileStream sri = new FileStream(dialogOpenWiiSave.FileName, FileMode.Open, FileAccess.Read);
					int intSaveLengh = (int)sri.Length;
					BinaryReader r = new BinaryReader(sri);

					for(i=0;i<intSaveLengh/4;i++)
					{
						charCode[0] = (char)r.ReadByte();
						charCode[1] = (char)r.ReadByte();
						charCode[2] = (char)r.ReadByte();
						charCode[3] = (char)r.ReadByte();

						flag = IsMyString(charCode);

						if(flag)
						{
							iHex = i*4;
							break;
						}
					}

					for(i=0;i<4;i++)
					{
						strCode += charCode[i].ToString();
					}

					if(flag)
					{
						txtString.Text =strCode;
						txtWeizhi.Text = Convert.ToString(iHex,16)+"h";
						if(iHex == 61732 || iHex == 0)
							txtTest.Text = "标准存档";
						else
							txtTest.Text = "非标准存档";
						myMessage(charCode);
					}
					else
					{
						txtString.Text = "无法识别";
						ErrorMessage();
					}

					if(charCode[0].ToString() == "G")
						SaveFileLength = intSaveLengh/1024/8+1;
					else
						SaveFileLength = intSaveLengh/1024/128+1;
					txtSize.Text = SaveFileLength.ToString();
				}
			}
			catch
			{
				txtString.Text = "错误！";
				ErrorMessage();
			}
			finally
			{
			}
		}

		private bool IsMyString(char[] SaveCode)	//判断是否为标识字符串
		{
			for(int i = 0;i < 4;i++)
			{
				if((int)SaveCode[i]<48||((int)SaveCode[i]>57&&(int)SaveCode[i]<65)||(int)SaveCode[i]>90)
				{
					return(false);
				}
			}

			if ((SaveCode[0] == 'R' || SaveCode[0] == 'H' || SaveCode[0] == 'E' || SaveCode[0] == 'G') && 
				(SaveCode[3] == 'J' || SaveCode[3] == 'E' || SaveCode[3] == 'U' || SaveCode[3] == 'P'))
			{
				return(true);
			}

			return(false);
		}

		private void ErrorMessage()		//无法读取标识字符串的提示
		{
			txtType.Text = "未知";
			txtName.Text = "未知游戏";
			txtLanguage.Text = "未知";
		}

		private void myMessage(char[] myCode)		//根据标识字符串提取信息
		{
			switch(myCode[0])
			{
				case 'H':txtType.Text = "Wii频道备份";break;
				case 'R':txtType.Text = "Wii游戏存档";break;
				case 'E':txtType.Text = "N64游戏存档";break;
				case 'G':txtType.Text = "NGC游戏存档";break;
				default:txtType.Text = "未知";break;
			}

			switch(myCode[1].ToString() + myCode[2].ToString())
			{
				case "4Q":txtName.Text = "马里奥足球 激情四射";break;
				case "8P":txtName.Text = "超级纸片马里奥";break;
				case "AJ":txtName.Text = "wii投票频道";break;
				case "AP":txtName.Text = "mii选美频道";break;
				case "B4":txtName.Text = "生化危机4 Wii编辑版";break;
				case "BB":txtName.Text = "炸弹人大陆";break;
				case "CC":txtName.Text = "料理妈妈烹饪指南";break;
				case "CD":txtName.Text = "使命召唤3";break;
				case "DB":txtName.Text = "龙珠Z 电光火石";break;
				case "DR":txtName.Text = "水精灵大冒险";break;
				case "ET":txtName.Text = "绿日达人";break;
				case "F8":txtName.Text = "FIFA 08";break;
				case "GT":txtName.Text = "GT赛车职业系列赛";break;
				case "HA":txtName.Text = "玩玩Wii";break;
				case "IP":txtName.Text = "海贼王 无尽的冒险";break;
				case "K4":txtName.Text = "结界师 黑芒楼之影";break;
				case "KD":txtName.Text = "超执刀 二次执刀";break;
				case "M8":txtName.Text = "马力欧聚会8";break;
				case "MG":txtName.Text = "超级马里奥 银河";break;
				case "OD":txtName.Text = "瓦里奥制造 手舞足蹈";break;
				case "RB":txtName.Text = "雷曼－疯狂兔子";break;
				case "S5":txtName.Text = "战国无双 刀";break;
				case "SP":txtName.Text = "Wii体育";break;
				case "SR":txtName.Text = "索尼克与神秘指环";break;
				case "TR":txtName.Text = "目标!!钓鱼大师";break;
				case "WS":txtName.Text = "马里奥与索尼克在北京奥运会";break;
				case "ZD":txtName.Text = "塞尔达传说 黎明公主";break;

				default:txtName.Text = "未知游戏";break;
			}

			switch(myCode[3])
			{
				case 'J':txtLanguage.Text = "日版";break;
				case 'E':txtLanguage.Text = "美版";break;
				//case 'U':txtLanguage.Text = "美版";break;
				case 'P':txtLanguage.Text = "欧版";break;
				default:txtLanguage.Text = "未知";break;
			}
		}
	}
}
