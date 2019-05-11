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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalc));
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
            resources.ApplyResources(this.TbSquareMeters, "TbSquareMeters");
            this.TbSquareMeters.Name = "TbSquareMeters";
            this.TbSquareMeters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSquareMeters_KeyPress);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // CbSun
            // 
            this.CbSun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CbSun, "CbSun");
            this.CbSun.FormattingEnabled = true;
            this.CbSun.Items.AddRange(new object[] {
            resources.GetString("CbSun.Items"),
            resources.GetString("CbSun.Items1"),
            resources.GetString("CbSun.Items2")});
            this.CbSun.Name = "CbSun";
            // 
            // CbRegion
            // 
            this.CbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CbRegion, "CbRegion");
            this.CbRegion.FormattingEnabled = true;
            this.CbRegion.Items.AddRange(new object[] {
            resources.GetString("CbRegion.Items"),
            resources.GetString("CbRegion.Items1"),
            resources.GetString("CbRegion.Items2"),
            resources.GetString("CbRegion.Items3"),
            resources.GetString("CbRegion.Items4")});
            this.CbRegion.Name = "CbRegion";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CbTypeArea
            // 
            this.CbTypeArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CbTypeArea, "CbTypeArea");
            this.CbTypeArea.FormattingEnabled = true;
            this.CbTypeArea.Items.AddRange(new object[] {
            resources.GetString("CbTypeArea.Items"),
            resources.GetString("CbTypeArea.Items1")});
            this.CbTypeArea.Name = "CbTypeArea";
            // 
            // CbTypePlace
            // 
            this.CbTypePlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CbTypePlace, "CbTypePlace");
            this.CbTypePlace.FormattingEnabled = true;
            this.CbTypePlace.Items.AddRange(new object[] {
            resources.GetString("CbTypePlace.Items"),
            resources.GetString("CbTypePlace.Items1")});
            this.CbTypePlace.Name = "CbTypePlace";
            this.CbTypePlace.SelectedValueChanged += new System.EventHandler(this.CbTypePlace_SelectedValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // CbSlab
            // 
            this.CbSlab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CbSlab, "CbSlab");
            this.CbSlab.FormattingEnabled = true;
            this.CbSlab.Items.AddRange(new object[] {
            resources.GetString("CbSlab.Items"),
            resources.GetString("CbSlab.Items1")});
            this.CbSlab.Name = "CbSlab";
            // 
            // TbWindows
            // 
            resources.ApplyResources(this.TbWindows, "TbWindows");
            this.TbWindows.Name = "TbWindows";
            this.TbWindows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbWindows_KeyPress);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // TbLamps
            // 
            resources.ApplyResources(this.TbLamps, "TbLamps");
            this.TbLamps.Name = "TbLamps";
            this.TbLamps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbLamps_KeyPress);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // CbKindLamps
            // 
            this.CbKindLamps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CbKindLamps, "CbKindLamps");
            this.CbKindLamps.FormattingEnabled = true;
            this.CbKindLamps.Items.AddRange(new object[] {
            resources.GetString("CbKindLamps.Items"),
            resources.GetString("CbKindLamps.Items1")});
            this.CbKindLamps.Name = "CbKindLamps";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // BtnCalc
            // 
            resources.ApplyResources(this.BtnCalc, "BtnCalc");
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnClear
            // 
            resources.ApplyResources(this.BtnClear, "BtnClear");
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TbPeople
            // 
            resources.ApplyResources(this.TbPeople, "TbPeople");
            this.TbPeople.Name = "TbPeople";
            this.TbPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPeople_KeyPress);
            // 
            // TbEletronics
            // 
            resources.ApplyResources(this.TbEletronics, "TbEletronics");
            this.TbEletronics.Name = "TbEletronics";
            this.TbEletronics.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbEletronics_KeyPress);
            // 
            // BtnExit
            // 
            resources.ApplyResources(this.BtnExit, "BtnExit");
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TbNumCurtains
            // 
            resources.ApplyResources(this.TbNumCurtains, "TbNumCurtains");
            this.TbNumCurtains.Name = "TbNumCurtains";
            this.TbNumCurtains.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNumCurtains_KeyPress);
            // 
            // FrmCalc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCalc";
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

