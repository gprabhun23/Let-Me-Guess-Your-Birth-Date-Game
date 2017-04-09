﻿/*
 * Created by SharpDevelop.
 * User: Ganesh
 * Date: 4/8/2017
 * Time: 1:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace LetMeGuessYourBirthDate
{
	public partial class GuessYourBirthDate : Form
	{
		SpeechSynthesizer objSys=new SpeechSynthesizer();
		ProcessorEngine pe=new ProcessorEngine();
		private int cardVal1=0,cardVal2=0,cardVal3=0,cardVal4=0,cardVal5=0,bDate=0;
		public GuessYourBirthDate()
		{
			InitializeComponent();
		}
		
		void TbBirthYearKeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled=true;
			}
		}

		void TbBirthYearKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(tbBirthYear.Text!="")
				{
					cbBirthMonth.Focus();
				}
				else
				{
					tbBirthYear.Focus();
				}
			}
		}
		
		void CbBirthMonthEnter(object sender, EventArgs e)
		{
			SendKeys.Send("{F4}");
		}
		
		void TbBirthYearLeave(object sender, EventArgs e)
		{
			if(tbBirthYear.Text!="")
			{
				int bYear=Convert.ToInt32(tbBirthYear.Text);
				if(pe.BetweenbirthYear(bYear))
				{
					cbBirthMonth.Focus();
				}
				else
				{
					pe.ErrorOnWrongBirthYear(objSys,tbBirthYear.Text,1);
					tbBirthYear.ResetText();
					tbBirthYear.Focus();
				}
			}
		}
		
		
		void TbYourLastNameKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(tbYourLastName.Text!="")
				{
					cbGender.Focus();
				}
				else
				{
					tbYourLastName.Focus();
				}
			}
		}
		
		void CbGenderEnter(object sender, EventArgs e)
		{
			SendKeys.Send("{F4}");
		}
		
		void CbGenderKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(cbGender.Text!="")
				{
					tbBirthYear.Focus();
				}
				else
				{
					cbGender.Focus();
				}
			}
		}

		private void nextPage()
		{
			tcGYBDGame.SelectedIndex=(tcGYBDGame.SelectedIndex+1 <tcGYBDGame.TabCount) ? tcGYBDGame.SelectedIndex+1 : tcGYBDGame.SelectedIndex;
		}
		
		private bool ValidateBeforeEnter()
		{
			bool valid=true;
			if(tbYourFirstName.Text!="")
			{
				
			}
			else
			{
				valid=false;
				if(valid
			}
		}
		void CbBirthMonthKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(tbYourFirstName.Text!="" && tbBirthYear.Text!="" && tbYourLastName.Text!="" && cbGender.Text!="" && cbBirthMonth.Text!="")
				{
					pe.InitialSpeech(objSys,cbGender.Text,tbYourFirstName.Text,tbYourLastName.Text,2);
					nextPage();
					btnCard1.Focus();
				}
			}
		}

		void GuessYourBirthDateLoad(object sender, EventArgs e)
		{
			tcGYBDGame.Enabled=false;
			btnCancel.Enabled=false;
		}
		
		void BtnPlayClick(object sender, EventArgs e)
		{
			tcGYBDGame.Enabled=true;
			btnPlay.Enabled=false;
			btnCancel.Enabled=true;
			DataGridView[] dgv=new DataGridView[5];
			dgv[0]=dgvCard1;
			dgv[1]=dgvCard2;
			dgv[2]=dgvCard3;
			dgv[3]=dgvCard4;
		 	dgv[4]=dgvCard5;
			for (int i=1;i<=dgv.Length;i++) {
				dgv[i-1].DataSource=pe.CreateCards(i);
				dgv[i-1].Enabled=false;
				//dgv[i-1].Rows[0].Cells[0].Selected=false;
			}
			tbYourFirstName.Focus();
		}
		
		void BtnExitClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Do you want to exit this game ??","Exit this Game",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
			{
				this.Dispose();
			}
		}
		
		void TbYourFirstNameKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(tbYourFirstName.Text!="")
				{
					tbYourLastName.Focus();
				}
				else
				{
					tbYourFirstName.Focus();
				}
			}
		}
		
		void TbYourFirstNameKeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled=true;
			}
		}
		
		void TbYourLastNameKeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled=true;
			}
		}
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			onCancel();
		}
		private void onCancel()
		{
			dgvCard1.DataSource=null;
			dgvCard2.DataSource=null;
			dgvCard3.DataSource=null;
			dgvCard4.DataSource=null;
			dgvCard5.DataSource=null;
			tbBirthYear.ResetText();
			tbYourFirstName.ResetText();
			tbYourLastName.ResetText();
			cbGender.ResetText();
			cbBirthMonth.ResetText();
			btnPlay.Enabled=true;
			btnCancel.Enabled=false;
			tcGYBDGame.Enabled=false;
			tcGYBDGame.SelectedIndex=0;
			btnPlay.Focus();
		}
	
		void BtnCard1Click(object sender, EventArgs e)
		{
			pe.SpeakDialogue(objSys);
			if(MessageBox.Show("Is your birthdate present in this card ??","Confirm !",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
			{
				cardVal1=pe.getCellValue(dgvCard1);
				nextPage();
				btnCard2.Focus();
			}
			else
			{
				cardVal1=0;
				nextPage();
				btnCard2.Focus();
			}
		}
		
		void BtnCard2Click(object sender, EventArgs e)
		{
			pe.SpeakDialogue(objSys);
			if(MessageBox.Show("Is your birthdate present in this card ??","Confirm !",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
			{
				cardVal2=pe.getCellValue(dgvCard2);
				nextPage();
				btnCard3.Focus();
			}
			else
			{
				cardVal2=0;
				nextPage();
				btnCard3.Focus();
			}
		}
		
		void BtnCard3Click(object sender, EventArgs e)
		{
			pe.SpeakDialogue(objSys);
			if(MessageBox.Show("Is your birthdate present in this card ??","Confirm !",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
			{
				cardVal3=pe.getCellValue(dgvCard3);
				nextPage();
				btnCard4.Focus();
			}
			else
			{
				cardVal3=0;
				nextPage();
				btnCard4.Focus();
			}
		}
		
		void BtnCard4Click(object sender, EventArgs e)
		{
			pe.SpeakDialogue(objSys);
			if(MessageBox.Show("Is your birthdate present in this card ??","Confirm !",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
			{
				cardVal4=pe.getCellValue(dgvCard4);
				nextPage();
				btnEnd.Focus();
			}
			else
			{
				cardVal4=0;
				nextPage();
				btnEnd.Focus();
			}
		}
		
		void BtnEndClick(object sender, EventArgs e)
		{
			pe.SpeakDialogue(objSys);
			if(MessageBox.Show("Are you Sure, Is your birthdate present in this card ??","Confirm !",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
			{
				btnPlay.Focus();
				cardVal5=pe.getCellValue(dgvCard5);
				bDate=pe.yourBirthDateIs(cardVal1,cardVal2,cardVal3,cardVal4,cardVal5);
				pe.EndSpeech(objSys,cbGender.Text,tbYourFirstName.Text,tbYourLastName.Text,bDate,cbBirthMonth.Text,tbBirthYear.Text,2);
				cardVal1=0;
				cardVal2=0;
				cardVal3=0;
				cardVal4=0;
				cardVal5=0;
				onCancel();
			}
			else
			{
				btnPlay.Focus();
				cardVal5=0;
				bDate=pe.yourBirthDateIs(cardVal1,cardVal2,cardVal3,cardVal4,cardVal5);
				pe.EndSpeech(objSys,cbGender.Text,tbYourFirstName.Text,tbYourLastName.Text,bDate,cbBirthMonth.Text,tbBirthYear.Text,2);
				cardVal1=0;
				cardVal2=0;
				cardVal3=0;
				cardVal4=0;
				cardVal5=0;
				onCancel();
			}
		}
		
		void CbGenderLeave(object sender, EventArgs e)
		{
			if(cbGender.Text.Equals(""))
			{
				cbGender.Focus();
			}
		}
		
		void CbBirthMonthLeave(object sender, EventArgs e)
		{
			if(cbBirthMonth.Text.Equals(""))
			{
				cbBirthMonth.Focus();
			}
		}
	}
}
