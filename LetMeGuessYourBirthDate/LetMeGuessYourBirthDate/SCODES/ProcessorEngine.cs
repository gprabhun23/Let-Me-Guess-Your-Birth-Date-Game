/*
 * Created by SharpDevelop.
 * User: Ganesh
 * Date: 4/8/2017
 * Time: 4:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Speech;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace LetMeGuessYourBirthDate
{
	/// <summary>
	/// Description of ProcessorEngine.
	/// </summary>
	public class ProcessorEngine
	{
		DateTime dtNow=DateTime.Now;
		public ProcessorEngine()
		{
			
		}
		private int[] SelectCardData(int cardId)
		{
			int[] cardItems=new int[15];
			if(cardId==1)
			{
				cardItems=new int[]{ 1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31 };
			}
			else if(cardId==2)
			{
				cardItems=new int[]{ 2,3,6,7,10,11,14,15,18,19,22,23,26,27,30,31 };
			}
			else if(cardId==3)
			{
				cardItems=new int[]{ 4,5,6,7,12,13,14,15,20,21,22,23,28,29,30,31 };
			}
			else if(cardId==4)
			{
				cardItems=new int[]{ 8,9,10,11,12,13,14,15,24,25,26,27,28,29,30,31 };
			}
			else if(cardId==5)
			{
				cardItems=new int[]{ 16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31 };
			}
			return cardItems;
		}
		public DataTable CreateCards(int cardId)
		{
			int[] cardArr=SelectCardData(cardId);
			DataTable dt=new DataTable();
			dt.Columns.Add("A");
			dt.Columns.Add("B");
			dt.Columns.Add("C");
			dt.Columns.Add("D");
			dt.Rows.Add(cardArr[0],cardArr[1],cardArr[2],cardArr[3]);
			dt.Rows.Add(cardArr[4],cardArr[5],cardArr[6],cardArr[7]);
			dt.Rows.Add(cardArr[8],cardArr[9],cardArr[10],cardArr[11]);
			dt.Rows.Add(cardArr[12],cardArr[13],cardArr[14],cardArr[15]);
			return dt;
		}
		private int getBirthMonth(string month)
		{
			int num=0;
			switch (month) {
				case "JAN":
					num=1;
					break;
				case "FEB":
					num=2;
					break;
				case "MAR":
					num=3;
					break;
				case "APR":
					num=4;
					break;
				case "MAY":
					num=5;
					break;
				case "JUN":
					num=6;
					break;
				case "JUL":
					num=7;
					break;
				case "AUG":
					num=8;
					break;
				case "SEP":
					num=9;
					break;
				case "OCT":
					num=10;
					break;
				case "NOV":
					num=11;
					break;
				case "DEC":
					num=12;
					break;
			}
			return num;
		}
		public int getCellValue(System.Windows.Forms.DataGridView dgv)
		{
			System.Windows.Forms.DataGridViewCell dgvRow=dgv.FirstDisplayedCell;
			int val=Convert.ToInt32(dgvRow.Value.ToString());
			return val;
		}
		public int yourBirthDateIs(int val1,int val2,int val3,int val4,int val5)
		{
			return val1+val2+val3+val4+val5;
		}
		public void SpeakDialogue(SpeechSynthesizer objs)
		{
			objs.Speak("Is your birthdate present in this card , Please Confirm By Clicking Yes or No Button");
		}
		public bool BetweenbirthYear(int bYear)
		{
			if(bYear > 1900 && bYear <= dtNow.Year)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool ErrorOnWrongBirthYear(SpeechSynthesizer objs,string st,int speachRate)
		{
			objs.Rate=speachRate;
			objs.Speak("You have Entered a Wrong Birth Year "+st+"");
			return true;
		}
		
		private string MrOrMrs(string gender)
		{
			string st="";
			if(gender.Equals("MALE"))
			{
				st="Mister";
			}
			else
			{
				st="Miss";
			}
			return st;
		}
		
		public bool InitialSpeech(SpeechSynthesizer objSys,string genderDetails,string firstName,string lastName,int speachRate)
		{
			objSys.Rate=speachRate;
			objSys.Speak("Hello "+MrOrMrs(genderDetails)+" "+firstName+" "+lastName+" Welcome to Let me Guess your Birth Date GAME");
			objSys.Speak("Now you can find 5 cards , Just check weather your birthdate is present in each and every card, the press next button and verify your answer in yes or no dialogue");
			return true;
		}
		public bool EndSpeech(SpeechSynthesizer objSys,string genderDetails,string firstName,string lastName,int bDate,string birthMonth,string birthYear,int speachRate)
		{
			objSys.Rate=speachRate;
			objSys.Speak("Hello "+MrOrMrs(genderDetails)+" "+firstName+" "+lastName+", You Born On "+bDate+" "+birthMonth+" "+birthYear+" ");
			int month=getBirthMonth(birthMonth);
			if(DateTime.Now.Month==month && DateTime.Now.Date.Day==bDate)
			{
				int years=DateTime.Now.Year-Convert.ToInt32(birthYear);
				objSys.Speak("Hello "+MrOrMrs(genderDetails)+"  "+firstName+" "+lastName+", You have completed "+years+" Years today, Happy Birthday to you");
			}
			return true;
		}
		public void DisableSelected(System.Windows.Forms.DataGridView dgv)
		{
			dgv.ClearSelection();
		}
		public void PlaySpeech(SpeechSynthesizer objSys)
		{
			objSys.Speak("Hi, Let's Play the Game ");
		}
		public void OnLoad(SpeechSynthesizer objSys)
		{
			DateTime dtVal=DateTime.Now;
			string weekDay=dtVal.ToString("dddd");
			if(dtVal.Hour>=44 && dtVal.Hour <= 11)
			{
				objSys.Speak("Good Morning, Today is "+weekDay+"");
			}
			else if(dtVal.Hour>=12 && dtNow.Hour <=13)
			{
				objSys.Speak("Good Noon, Today is "+weekDay+"");
			}
			else if(dtVal.Hour>=14 && dtNow.Hour <=15)
			{
				objSys.Speak("Good After Noon, Today is "+weekDay+"");
			}
			else if(dtVal.Hour>=16 && dtNow.Hour <=17)
			{
				objSys.Speak("Good Evening, Today is "+weekDay+"");
			}
			else
			{
				objSys.Speak("Good Night, Today is "+weekDay+"");
			}
		}
		public bool ValidateBeforeEnter(SpeechSynthesizer objSys,TextBox tbYourFirstName,TextBox tbYourLastName,TextBox tbBirthYear,ComboBox cbGender,ComboBox cbBirthMonth)
		{
			bool valid=true;
			if(tbYourFirstName.Text!="")
			{
				
			}
			else
			{
				objSys.Speak("Please Enter Your First Name");
				if(valid!=false)
				{
					valid=false;
				}
			}
			if(tbYourLastName.Text!="")
			{
				
			}
			else
			{
				objSys.Speak("Please Enter Your Last Name");
				if(valid!=false)
				{
					valid=false;
				}
			}
			if(tbBirthYear.Text!="")
			{
				
			}
			else
			{
				objSys.Speak("Please Enter Valid Birth Year");
				if(valid!=false)
				{
					valid=false;
				}
			}
			if(cbGender.Text!="")
			{
				
			}
			else
			{
				objSys.Speak("Please Select Valid Gender");
				if(valid!=false)
				{
					valid=false;
				}
			}
			if(cbBirthMonth.Text!="")
			{
				
			}
			else
			{
				objSys.Speak("Please Select Birth Month");
				if(valid!=false)
				{
					valid=false;
				}
			}
			return valid;
		}
	}
}
