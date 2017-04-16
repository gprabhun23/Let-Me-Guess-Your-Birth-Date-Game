/*
 * Created by SharpDevelop.
 * User: Ganesh
 * Date: 4/8/2017
 * Time: 1:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LetMeGuessYourBirthDate
{
	partial class GuessYourBirthDate
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tcGYBDGame = new System.Windows.Forms.TabControl();
			this.tcYourDetails = new System.Windows.Forms.TabPage();
			this.cbGender = new System.Windows.Forms.ComboBox();
			this.cbBirthMonth = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbBirthYear = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbYourLastName = new System.Windows.Forms.TextBox();
			this.tbYourFirstName = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tcPage1 = new System.Windows.Forms.TabPage();
			this.btnCard1 = new System.Windows.Forms.Button();
			this.dgvCard1 = new System.Windows.Forms.DataGridView();
			this.tcPage2 = new System.Windows.Forms.TabPage();
			this.btnCard2 = new System.Windows.Forms.Button();
			this.dgvCard2 = new System.Windows.Forms.DataGridView();
			this.tcPage3 = new System.Windows.Forms.TabPage();
			this.btnCard3 = new System.Windows.Forms.Button();
			this.dgvCard3 = new System.Windows.Forms.DataGridView();
			this.tcPage4 = new System.Windows.Forms.TabPage();
			this.btnCard4 = new System.Windows.Forms.Button();
			this.dgvCard4 = new System.Windows.Forms.DataGridView();
			this.tcPage5 = new System.Windows.Forms.TabPage();
			this.btnEnd = new System.Windows.Forms.Button();
			this.dgvCard5 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.tcGYBDGame.SuspendLayout();
			this.tcYourDetails.SuspendLayout();
			this.tcPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCard1)).BeginInit();
			this.tcPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCard2)).BeginInit();
			this.tcPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCard3)).BeginInit();
			this.tcPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCard4)).BeginInit();
			this.tcPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCard5)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcGYBDGame
			// 
			this.tcGYBDGame.Controls.Add(this.tcYourDetails);
			this.tcGYBDGame.Controls.Add(this.tcPage1);
			this.tcGYBDGame.Controls.Add(this.tcPage2);
			this.tcGYBDGame.Controls.Add(this.tcPage3);
			this.tcGYBDGame.Controls.Add(this.tcPage4);
			this.tcGYBDGame.Controls.Add(this.tcPage5);
			this.tcGYBDGame.Location = new System.Drawing.Point(12, 12);
			this.tcGYBDGame.Name = "tcGYBDGame";
			this.tcGYBDGame.Padding = new System.Drawing.Point(17, 3);
			this.tcGYBDGame.SelectedIndex = 0;
			this.tcGYBDGame.Size = new System.Drawing.Size(481, 375);
			this.tcGYBDGame.TabIndex = 1;
			// 
			// tcYourDetails
			// 
			this.tcYourDetails.BackColor = System.Drawing.Color.White;
			this.tcYourDetails.Controls.Add(this.cbGender);
			this.tcYourDetails.Controls.Add(this.cbBirthMonth);
			this.tcYourDetails.Controls.Add(this.label10);
			this.tcYourDetails.Controls.Add(this.tbBirthYear);
			this.tcYourDetails.Controls.Add(this.label3);
			this.tcYourDetails.Controls.Add(this.label2);
			this.tcYourDetails.Controls.Add(this.tbYourLastName);
			this.tcYourDetails.Controls.Add(this.tbYourFirstName);
			this.tcYourDetails.Controls.Add(this.label9);
			this.tcYourDetails.Controls.Add(this.label1);
			this.tcYourDetails.Location = new System.Drawing.Point(4, 22);
			this.tcYourDetails.Name = "tcYourDetails";
			this.tcYourDetails.Padding = new System.Windows.Forms.Padding(3);
			this.tcYourDetails.Size = new System.Drawing.Size(473, 349);
			this.tcYourDetails.TabIndex = 0;
			this.tcYourDetails.Text = "YOUR DETAILS";
			// 
			// cbGender
			// 
			this.cbGender.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbGender.FormattingEnabled = true;
			this.cbGender.Items.AddRange(new object[] {
									"MALE",
									"FEMALE"});
			this.cbGender.Location = new System.Drawing.Point(186, 155);
			this.cbGender.Name = "cbGender";
			this.cbGender.Size = new System.Drawing.Size(115, 28);
			this.cbGender.TabIndex = 2;
			this.cbGender.Leave += new System.EventHandler(this.CbGenderLeave);
			this.cbGender.Enter += new System.EventHandler(this.CbGenderEnter);
			this.cbGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbGenderKeyDown);
			// 
			// cbBirthMonth
			// 
			this.cbBirthMonth.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.cbBirthMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBirthMonth.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbBirthMonth.FormattingEnabled = true;
			this.cbBirthMonth.Items.AddRange(new object[] {
									"JAN",
									"FEB",
									"MAR",
									"APR",
									"MAY",
									"JUN",
									"JUL",
									"AUG",
									"SEP",
									"OCT",
									"NOV",
									"DEC"});
			this.cbBirthMonth.Location = new System.Drawing.Point(186, 242);
			this.cbBirthMonth.Name = "cbBirthMonth";
			this.cbBirthMonth.Size = new System.Drawing.Size(100, 28);
			this.cbBirthMonth.TabIndex = 4;
			this.cbBirthMonth.Leave += new System.EventHandler(this.CbBirthMonthLeave);
			this.cbBirthMonth.Enter += new System.EventHandler(this.CbBirthMonthEnter);
			this.cbBirthMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbBirthMonthKeyDown);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(43, 155);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(137, 23);
			this.label10.TabIndex = 7;
			this.label10.Text = "Your Gender";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbBirthYear
			// 
			this.tbBirthYear.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.tbBirthYear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBirthYear.Location = new System.Drawing.Point(186, 199);
			this.tbBirthYear.Name = "tbBirthYear";
			this.tbBirthYear.Size = new System.Drawing.Size(82, 26);
			this.tbBirthYear.TabIndex = 3;
			this.tbBirthYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbBirthYearKeyDown);
			this.tbBirthYear.Leave += new System.EventHandler(this.TbBirthYearLeave);
			this.tbBirthYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbBirthYearKeyPress);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(43, 245);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Your Birth Month";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(43, 199);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Your Birth Year";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbYourLastName
			// 
			this.tbYourLastName.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.tbYourLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbYourLastName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbYourLastName.Location = new System.Drawing.Point(186, 112);
			this.tbYourLastName.Name = "tbYourLastName";
			this.tbYourLastName.Size = new System.Drawing.Size(259, 26);
			this.tbYourLastName.TabIndex = 1;
			this.tbYourLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbYourLastNameKeyDown);
			this.tbYourLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbYourLastNameKeyPress);
			// 
			// tbYourFirstName
			// 
			this.tbYourFirstName.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.tbYourFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbYourFirstName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbYourFirstName.Location = new System.Drawing.Point(186, 70);
			this.tbYourFirstName.Name = "tbYourFirstName";
			this.tbYourFirstName.Size = new System.Drawing.Size(259, 26);
			this.tbYourFirstName.TabIndex = 0;
			this.tbYourFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbYourFirstNameKeyDown);
			this.tbYourFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbYourFirstNameKeyPress);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(6, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(174, 23);
			this.label9.TabIndex = 8;
			this.label9.Text = "Your Last Name";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(17, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Your First Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tcPage1
			// 
			this.tcPage1.Controls.Add(this.btnCard1);
			this.tcPage1.Controls.Add(this.dgvCard1);
			this.tcPage1.Location = new System.Drawing.Point(4, 22);
			this.tcPage1.Name = "tcPage1";
			this.tcPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tcPage1.Size = new System.Drawing.Size(473, 349);
			this.tcPage1.TabIndex = 1;
			this.tcPage1.Text = "CARD 1";
			this.tcPage1.UseVisualStyleBackColor = true;
			// 
			// btnCard1
			// 
			this.btnCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
			this.btnCard1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
			this.btnCard1.ForeColor = System.Drawing.Color.White;
			this.btnCard1.Location = new System.Drawing.Point(150, 285);
			this.btnCard1.Name = "btnCard1";
			this.btnCard1.Size = new System.Drawing.Size(174, 49);
			this.btnCard1.TabIndex = 0;
			this.btnCard1.Text = "NEXT >>";
			this.btnCard1.UseVisualStyleBackColor = false;
			this.btnCard1.Click += new System.EventHandler(this.BtnCard1Click);
			// 
			// dgvCard1
			// 
			this.dgvCard1.AllowUserToAddRows = false;
			this.dgvCard1.AllowUserToDeleteRows = false;
			this.dgvCard1.AllowUserToResizeColumns = false;
			this.dgvCard1.AllowUserToResizeRows = false;
			this.dgvCard1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCard1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvCard1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dgvCard1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCard1.ColumnHeadersVisible = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCard1.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCard1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvCard1.Location = new System.Drawing.Point(96, 43);
			this.dgvCard1.Name = "dgvCard1";
			this.dgvCard1.ReadOnly = true;
			this.dgvCard1.RowHeadersVisible = false;
			this.dgvCard1.RowTemplate.Height = 56;
			this.dgvCard1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvCard1.Size = new System.Drawing.Size(280, 227);
			this.dgvCard1.TabIndex = 1;
			// 
			// tcPage2
			// 
			this.tcPage2.Controls.Add(this.btnCard2);
			this.tcPage2.Controls.Add(this.dgvCard2);
			this.tcPage2.Location = new System.Drawing.Point(4, 22);
			this.tcPage2.Name = "tcPage2";
			this.tcPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tcPage2.Size = new System.Drawing.Size(473, 349);
			this.tcPage2.TabIndex = 2;
			this.tcPage2.Text = "CARD 2";
			this.tcPage2.UseVisualStyleBackColor = true;
			// 
			// btnCard2
			// 
			this.btnCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
			this.btnCard2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
			this.btnCard2.ForeColor = System.Drawing.Color.White;
			this.btnCard2.Location = new System.Drawing.Point(150, 285);
			this.btnCard2.Name = "btnCard2";
			this.btnCard2.Size = new System.Drawing.Size(174, 49);
			this.btnCard2.TabIndex = 0;
			this.btnCard2.Text = "NEXT >>";
			this.btnCard2.UseVisualStyleBackColor = false;
			this.btnCard2.Click += new System.EventHandler(this.BtnCard2Click);
			// 
			// dgvCard2
			// 
			this.dgvCard2.AllowUserToAddRows = false;
			this.dgvCard2.AllowUserToDeleteRows = false;
			this.dgvCard2.AllowUserToResizeColumns = false;
			this.dgvCard2.AllowUserToResizeRows = false;
			this.dgvCard2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCard2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvCard2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCard2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCard2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCard2.ColumnHeadersVisible = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCard2.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvCard2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvCard2.Location = new System.Drawing.Point(96, 43);
			this.dgvCard2.Name = "dgvCard2";
			this.dgvCard2.ReadOnly = true;
			this.dgvCard2.RowHeadersVisible = false;
			this.dgvCard2.RowTemplate.Height = 56;
			this.dgvCard2.Size = new System.Drawing.Size(280, 227);
			this.dgvCard2.TabIndex = 1;
			// 
			// tcPage3
			// 
			this.tcPage3.Controls.Add(this.btnCard3);
			this.tcPage3.Controls.Add(this.dgvCard3);
			this.tcPage3.Location = new System.Drawing.Point(4, 22);
			this.tcPage3.Name = "tcPage3";
			this.tcPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tcPage3.Size = new System.Drawing.Size(473, 349);
			this.tcPage3.TabIndex = 3;
			this.tcPage3.Text = "CARD 3";
			this.tcPage3.UseVisualStyleBackColor = true;
			// 
			// btnCard3
			// 
			this.btnCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
			this.btnCard3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
			this.btnCard3.ForeColor = System.Drawing.Color.White;
			this.btnCard3.Location = new System.Drawing.Point(150, 285);
			this.btnCard3.Name = "btnCard3";
			this.btnCard3.Size = new System.Drawing.Size(174, 49);
			this.btnCard3.TabIndex = 0;
			this.btnCard3.Text = "NEXT >>";
			this.btnCard3.UseVisualStyleBackColor = false;
			this.btnCard3.Click += new System.EventHandler(this.BtnCard3Click);
			// 
			// dgvCard3
			// 
			this.dgvCard3.AllowUserToAddRows = false;
			this.dgvCard3.AllowUserToDeleteRows = false;
			this.dgvCard3.AllowUserToResizeColumns = false;
			this.dgvCard3.AllowUserToResizeRows = false;
			this.dgvCard3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCard3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvCard3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dgvCard3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCard3.ColumnHeadersVisible = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCard3.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvCard3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvCard3.Location = new System.Drawing.Point(96, 43);
			this.dgvCard3.Name = "dgvCard3";
			this.dgvCard3.ReadOnly = true;
			this.dgvCard3.RowHeadersVisible = false;
			this.dgvCard3.RowTemplate.Height = 56;
			this.dgvCard3.Size = new System.Drawing.Size(280, 227);
			this.dgvCard3.TabIndex = 1;
			// 
			// tcPage4
			// 
			this.tcPage4.Controls.Add(this.btnCard4);
			this.tcPage4.Controls.Add(this.dgvCard4);
			this.tcPage4.Location = new System.Drawing.Point(4, 22);
			this.tcPage4.Name = "tcPage4";
			this.tcPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tcPage4.Size = new System.Drawing.Size(473, 349);
			this.tcPage4.TabIndex = 4;
			this.tcPage4.Text = "CARD 4";
			this.tcPage4.UseVisualStyleBackColor = true;
			// 
			// btnCard4
			// 
			this.btnCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
			this.btnCard4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
			this.btnCard4.ForeColor = System.Drawing.Color.White;
			this.btnCard4.Location = new System.Drawing.Point(150, 285);
			this.btnCard4.Name = "btnCard4";
			this.btnCard4.Size = new System.Drawing.Size(174, 49);
			this.btnCard4.TabIndex = 0;
			this.btnCard4.Text = "NEXT >>";
			this.btnCard4.UseVisualStyleBackColor = false;
			this.btnCard4.Click += new System.EventHandler(this.BtnCard4Click);
			// 
			// dgvCard4
			// 
			this.dgvCard4.AllowUserToAddRows = false;
			this.dgvCard4.AllowUserToDeleteRows = false;
			this.dgvCard4.AllowUserToResizeColumns = false;
			this.dgvCard4.AllowUserToResizeRows = false;
			this.dgvCard4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCard4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvCard4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dgvCard4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCard4.ColumnHeadersVisible = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCard4.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvCard4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvCard4.Location = new System.Drawing.Point(96, 43);
			this.dgvCard4.Name = "dgvCard4";
			this.dgvCard4.ReadOnly = true;
			this.dgvCard4.RowHeadersVisible = false;
			this.dgvCard4.RowTemplate.Height = 56;
			this.dgvCard4.Size = new System.Drawing.Size(280, 227);
			this.dgvCard4.TabIndex = 1;
			// 
			// tcPage5
			// 
			this.tcPage5.Controls.Add(this.btnEnd);
			this.tcPage5.Controls.Add(this.dgvCard5);
			this.tcPage5.Location = new System.Drawing.Point(4, 22);
			this.tcPage5.Name = "tcPage5";
			this.tcPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tcPage5.Size = new System.Drawing.Size(473, 349);
			this.tcPage5.TabIndex = 5;
			this.tcPage5.Text = "CARD 5";
			this.tcPage5.UseVisualStyleBackColor = true;
			// 
			// btnEnd
			// 
			this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
			this.btnEnd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
			this.btnEnd.ForeColor = System.Drawing.Color.White;
			this.btnEnd.Location = new System.Drawing.Point(150, 285);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(174, 49);
			this.btnEnd.TabIndex = 0;
			this.btnEnd.Text = "END";
			this.btnEnd.UseVisualStyleBackColor = false;
			this.btnEnd.Click += new System.EventHandler(this.BtnEndClick);
			// 
			// dgvCard5
			// 
			this.dgvCard5.AllowUserToAddRows = false;
			this.dgvCard5.AllowUserToDeleteRows = false;
			this.dgvCard5.AllowUserToResizeColumns = false;
			this.dgvCard5.AllowUserToResizeRows = false;
			this.dgvCard5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCard5.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvCard5.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dgvCard5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCard5.ColumnHeadersVisible = false;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCard5.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvCard5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvCard5.Location = new System.Drawing.Point(96, 43);
			this.dgvCard5.Name = "dgvCard5";
			this.dgvCard5.ReadOnly = true;
			this.dgvCard5.RowHeadersVisible = false;
			this.dgvCard5.RowTemplate.Height = 56;
			this.dgvCard5.Size = new System.Drawing.Size(280, 227);
			this.dgvCard5.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Controls.Add(this.btnCancel);
			this.groupBox1.Controls.Add(this.btnPlay);
			this.groupBox1.Location = new System.Drawing.Point(508, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(198, 360);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
			this.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
			this.btnExit.FlatAppearance.BorderSize = 2;
			this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
			this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Location = new System.Drawing.Point(15, 225);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(168, 44);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "EXIT";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
			this.btnCancel.FlatAppearance.BorderSize = 2;
			this.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(15, 158);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(168, 44);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "CANCEL";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// btnPlay
			// 
			this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
			this.btnPlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
			this.btnPlay.FlatAppearance.BorderSize = 2;
			this.btnPlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(227)))));
			this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlay.ForeColor = System.Drawing.Color.White;
			this.btnPlay.Location = new System.Drawing.Point(15, 92);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(168, 44);
			this.btnPlay.TabIndex = 4;
			this.btnPlay.Text = "PLAY";
			this.btnPlay.UseVisualStyleBackColor = false;
			this.btnPlay.Click += new System.EventHandler(this.BtnPlayClick);
			// 
			// GuessYourBirthDate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ClientSize = new System.Drawing.Size(717, 399);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tcGYBDGame);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "GuessYourBirthDate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LET ME GUESS YOUR BIRTHDATE !";
			this.Load += new System.EventHandler(this.GuessYourBirthDateLoad);
			this.tcGYBDGame.ResumeLayout(false);
			this.tcYourDetails.ResumeLayout(false);
			this.tcYourDetails.PerformLayout();
			this.tcPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCard1)).EndInit();
			this.tcPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCard2)).EndInit();
			this.tcPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCard3)).EndInit();
			this.tcPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCard4)).EndInit();
			this.tcPage5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCard5)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabPage tcPage1;
		private System.Windows.Forms.TabPage tcPage2;
		private System.Windows.Forms.TabPage tcPage3;
		private System.Windows.Forms.TabPage tcPage4;
		private System.Windows.Forms.TabPage tcPage5;
		private System.Windows.Forms.Button btnCard2;
		private System.Windows.Forms.Button btnCard3;
		private System.Windows.Forms.Button btnCard4;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Button btnCard1;
		private System.Windows.Forms.DataGridView dgvCard1;
		private System.Windows.Forms.DataGridView dgvCard2;
		private System.Windows.Forms.DataGridView dgvCard3;
		private System.Windows.Forms.DataGridView dgvCard4;
		private System.Windows.Forms.DataGridView dgvCard5;
		private System.Windows.Forms.TabPage tcYourDetails;
		private System.Windows.Forms.TabControl tcGYBDGame;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox tbYourFirstName;
		private System.Windows.Forms.TextBox tbYourLastName;
		private System.Windows.Forms.ComboBox cbGender;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cbBirthMonth;
		private System.Windows.Forms.TextBox tbBirthYear;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
