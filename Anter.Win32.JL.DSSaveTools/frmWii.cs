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
	/// frmWii ��ժҪ˵����
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
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmWii()
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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
			this.btnOpenSave.Text = "��";
			this.btnOpenSave.Click += new System.EventHandler(this.btnOpenSave_Click);
			// 
			// lblString
			// 
			this.lblString.Location = new System.Drawing.Point(8, 48);
			this.lblString.Name = "lblString";
			this.lblString.Size = new System.Drawing.Size(72, 21);
			this.lblString.TabIndex = 2;
			this.lblString.Text = "��־�ַ���";
			this.lblString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblLanguage
			// 
			this.lblLanguage.Location = new System.Drawing.Point(352, 80);
			this.lblLanguage.Name = "lblLanguage";
			this.lblLanguage.Size = new System.Drawing.Size(48, 21);
			this.lblLanguage.TabIndex = 3;
			this.lblLanguage.Text = "�汾";
			this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(8, 80);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(64, 21);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "��Ϸ����";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblType
			// 
			this.lblType.Location = new System.Drawing.Point(176, 48);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(32, 21);
			this.lblType.TabIndex = 5;
			this.lblType.Text = "����";
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
			this.btnExit.Text = "�˳�";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblFile
			// 
			this.lblFile.Location = new System.Drawing.Point(8, 16);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(64, 21);
			this.lblFile.TabIndex = 11;
			this.lblFile.Text = "�浵�ļ�";
			this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSize
			// 
			this.lblSize.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblSize.Location = new System.Drawing.Point(400, 48);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new System.Drawing.Size(64, 21);
			this.lblSize.TabIndex = 12;
			this.lblSize.Text = "�浵����";
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
			this.lblWeizhi.Text = "��ʶ�ַ���ƫ����";
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
			this.lblTest.Text = "�Ƿ�Ϊ��׼�浵";
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
			this.Text = "WII�浵��⣨���ԣ�";
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

		private void OpenWiiSaveFile()		//��Դ�浵�ļ�
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

		private void ReadTest()		//Ѱ�ұ�ʶ�ַ���
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
							txtTest.Text = "��׼�浵";
						else
							txtTest.Text = "�Ǳ�׼�浵";
						myMessage(charCode);
					}
					else
					{
						txtString.Text = "�޷�ʶ��";
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
				txtString.Text = "����";
				ErrorMessage();
			}
			finally
			{
			}
		}

		private bool IsMyString(char[] SaveCode)	//�ж��Ƿ�Ϊ��ʶ�ַ���
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

		private void ErrorMessage()		//�޷���ȡ��ʶ�ַ�������ʾ
		{
			txtType.Text = "δ֪";
			txtName.Text = "δ֪��Ϸ";
			txtLanguage.Text = "δ֪";
		}

		private void myMessage(char[] myCode)		//���ݱ�ʶ�ַ�����ȡ��Ϣ
		{
			switch(myCode[0])
			{
				case 'H':txtType.Text = "WiiƵ������";break;
				case 'R':txtType.Text = "Wii��Ϸ�浵";break;
				case 'E':txtType.Text = "N64��Ϸ�浵";break;
				case 'G':txtType.Text = "NGC��Ϸ�浵";break;
				default:txtType.Text = "δ֪";break;
			}

			switch(myCode[1].ToString() + myCode[2].ToString())
			{
				case "4Q":txtName.Text = "��������� ��������";break;
				case "8P":txtName.Text = "����ֽƬ�����";break;
				case "AJ":txtName.Text = "wiiͶƱƵ��";break;
				case "AP":txtName.Text = "miiѡ��Ƶ��";break;
				case "B4":txtName.Text = "����Σ��4 Wii�༭��";break;
				case "BB":txtName.Text = "ը���˴�½";break;
				case "CC":txtName.Text = "�����������ָ��";break;
				case "CD":txtName.Text = "ʹ���ٻ�3";break;
				case "DB":txtName.Text = "����Z ����ʯ";break;
				case "DR":txtName.Text = "ˮ�����ð��";break;
				case "ET":txtName.Text = "���մ���";break;
				case "F8":txtName.Text = "FIFA 08";break;
				case "GT":txtName.Text = "GT����ְҵϵ����";break;
				case "HA":txtName.Text = "����Wii";break;
				case "IP":txtName.Text = "������ �޾���ð��";break;
				case "K4":txtName.Text = "���ʦ ��â¥֮Ӱ";break;
				case "KD":txtName.Text = "��ִ�� ����ִ��";break;
				case "M8":txtName.Text = "����ŷ�ۻ�8";break;
				case "MG":txtName.Text = "��������� ����";break;
				case "OD":txtName.Text = "��������� �����㵸";break;
				case "RB":txtName.Text = "�������������";break;
				case "S5":txtName.Text = "ս����˫ ��";break;
				case "SP":txtName.Text = "Wii����";break;
				case "SR":txtName.Text = "�����������ָ��";break;
				case "TR":txtName.Text = "Ŀ��!!�����ʦ";break;
				case "WS":txtName.Text = "�������������ڱ������˻�";break;
				case "ZD":txtName.Text = "�����ﴫ˵ ��������";break;

				default:txtName.Text = "δ֪��Ϸ";break;
			}

			switch(myCode[3])
			{
				case 'J':txtLanguage.Text = "�հ�";break;
				case 'E':txtLanguage.Text = "����";break;
				//case 'U':txtLanguage.Text = "����";break;
				case 'P':txtLanguage.Text = "ŷ��";break;
				default:txtLanguage.Text = "δ֪";break;
			}
		}
	}
}
