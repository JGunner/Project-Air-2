namespace Project_Air_2
{
    partial class FrmCalc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbSquareMeters = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbSun = new System.Windows.Forms.ComboBox();
            this.CbRegion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbTypeArea = new System.Windows.Forms.ComboBox();
            this.CbTypePlace = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbSlab = new System.Windows.Forms.ComboBox();
            this.TbWindows = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbLamps = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CbKindLamps = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TbPeople = new System.Windows.Forms.TextBox();
            this.TbEletronics = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TbNumCurtains = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbSquareMeters
            // 
            this.TbSquareMeters.Location = new System.Drawing.Point(317, 164);
            this.TbSquareMeters.Name = "TbSquareMeters";
            this.TbSquareMeters.Size = new System.Drawing.Size(121, 23);
            this.TbSquareMeters.TabIndex = 6;
            this.TbSquareMeters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSquareMeters_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Size of the place in m²:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Region where air conditioning will be installed:";
            // 
            // CbSun
            // 
            this.CbSun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbSun.FormattingEnabled = true;
            this.CbSun.Items.AddRange(new object[] {
            "In morning",
            "In Aftermoon",
            "All Day"});
            this.CbSun.Location = new System.Drawing.Point(317, 132);
            this.CbSun.Name = "CbSun";
            this.CbSun.Size = new System.Drawing.Size(121, 24);
            this.CbSun.TabIndex = 5;
            // 
            // CbRegion
            // 
            this.CbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRegion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbRegion.FormattingEnabled = true;
            this.CbRegion.Items.AddRange(new object[] {
            "South",
            "Southeast",
            "North",
            "Northeast",
            "Midwest"});
            this.CbRegion.Location = new System.Drawing.Point(317, 12);
            this.CbRegion.Name = "CbRegion";
            this.CbRegion.Size = new System.Drawing.Size(121, 24);
            this.CbRegion.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Incidence of sun in place:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Type of place:";
            // 
            // CbTypeArea
            // 
            this.CbTypeArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTypeArea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbTypeArea.FormattingEnabled = true;
            this.CbTypeArea.Items.AddRange(new object[] {
            "Residential",
            "Commercial"});
            this.CbTypeArea.Location = new System.Drawing.Point(317, 102);
            this.CbTypeArea.Name = "CbTypeArea";
            this.CbTypeArea.Size = new System.Drawing.Size(121, 24);
            this.CbTypeArea.TabIndex = 4;
            // 
            // CbTypePlace
            // 
            this.CbTypePlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTypePlace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbTypePlace.FormattingEnabled = true;
            this.CbTypePlace.Items.AddRange(new object[] {
            "House",
            "Apartment"});
            this.CbTypePlace.Location = new System.Drawing.Point(317, 41);
            this.CbTypePlace.Name = "CbTypePlace";
            this.CbTypePlace.Size = new System.Drawing.Size(121, 24);
            this.CbTypePlace.TabIndex = 2;
            this.CbTypePlace.SelectedValueChanged += new System.EventHandler(this.CbTypePlace_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Type of area:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Has slab:";
            // 
            // CbSlab
            // 
            this.CbSlab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSlab.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbSlab.FormattingEnabled = true;
            this.CbSlab.ItemHeight = 16;
            this.CbSlab.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CbSlab.Location = new System.Drawing.Point(317, 72);
            this.CbSlab.Name = "CbSlab";
            this.CbSlab.Size = new System.Drawing.Size(121, 24);
            this.CbSlab.TabIndex = 3;
            // 
            // TbWindows
            // 
            this.TbWindows.Location = new System.Drawing.Point(317, 193);
            this.TbWindows.Name = "TbWindows";
            this.TbWindows.Size = new System.Drawing.Size(121, 23);
            this.TbWindows.TabIndex = 7;
            this.TbWindows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbWindows_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Number of windows:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Number of curtains:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Number of lamps:";
            // 
            // TbLamps
            // 
            this.TbLamps.Location = new System.Drawing.Point(317, 254);
            this.TbLamps.Name = "TbLamps";
            this.TbLamps.Size = new System.Drawing.Size(121, 23);
            this.TbLamps.TabIndex = 9;
            this.TbLamps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbLamps_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Type of lamp:";
            // 
            // CbKindLamps
            // 
            this.CbKindLamps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbKindLamps.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbKindLamps.FormattingEnabled = true;
            this.CbKindLamps.Items.AddRange(new object[] {
            "Hot",
            "Cold"});
            this.CbKindLamps.Location = new System.Drawing.Point(317, 284);
            this.CbKindLamps.Name = "CbKindLamps";
            this.CbKindLamps.Size = new System.Drawing.Size(121, 24);
            this.CbKindLamps.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Number of people staying in place:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Number of electronics:";
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(21, 387);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 13;
            this.BtnCalc.Text = "Calculate";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(177, 387);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 14;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TbPeople
            // 
            this.TbPeople.Location = new System.Drawing.Point(317, 319);
            this.TbPeople.Name = "TbPeople";
            this.TbPeople.Size = new System.Drawing.Size(121, 23);
            this.TbPeople.TabIndex = 11;
            this.TbPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPeople_KeyPress);
            // 
            // TbEletronics
            // 
            this.TbEletronics.Location = new System.Drawing.Point(317, 348);
            this.TbEletronics.Name = "TbEletronics";
            this.TbEletronics.Size = new System.Drawing.Size(121, 23);
            this.TbEletronics.TabIndex = 12;
            this.TbEletronics.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbEletronics_KeyPress);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(331, 387);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(77, 23);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TbNumCurtains
            // 
            this.TbNumCurtains.Location = new System.Drawing.Point(317, 223);
            this.TbNumCurtains.Name = "TbNumCurtains";
            this.TbNumCurtains.Size = new System.Drawing.Size(121, 23);
            this.TbNumCurtains.TabIndex = 34;
            this.TbNumCurtains.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNumCurtains_KeyPress);
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(450, 424);
            this.Controls.Add(this.TbNumCurtains);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TbEletronics);
            this.Controls.Add(this.TbPeople);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CbKindLamps);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TbLamps);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbWindows);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbSquareMeters);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbSun);
            this.Controls.Add(this.CbRegion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbTypeArea);
            this.Controls.Add(this.CbTypePlace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbSlab);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbSquareMeters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbSun;
        private System.Windows.Forms.ComboBox CbRegion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbTypeArea;
        private System.Windows.Forms.ComboBox CbTypePlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbSlab;
        private System.Windows.Forms.TextBox TbWindows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbLamps;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbKindLamps;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TbPeople;
        private System.Windows.Forms.TextBox TbEletronics;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TbNumCurtains;
    }
}

