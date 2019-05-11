using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Air_2
{
    public partial class FrmCalc : Form
    {

        int ValueRegion, TypePlace, Slab, TypeArea, Sun, SqrMeters, Windows, Curtains, Lamps, TypeLamps, People, Eletronics, TotalSqr,TotalWindows,TotalLamps,TotalBtu,TotalEletronics,TotalPeople;

        const string Alert = "You really need exit?";
        const string Info = "Information!";
        public FrmCalc()
        {
            InitializeComponent();
        }

        //ENGLISH: Begin of function for enable only numbers in fields in manual input // PORTUGUÊS: Início da função que habilita apenas numeros nos campos de entrada manual

        private void TbSquareMeters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            TbSquareMeters.MaxLength = 3;
        }

        private void TbWindows_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            TbWindows.MaxLength = 2;
        }

        private void TbNumCurtains_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TbLamps_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            TbLamps.MaxLength = 2;
        }

        private void TbPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            TbPeople.MaxLength = 2;
        }

        private void TbEletronics_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            TbEletronics.MaxLength = 2;
        }
        //ENGLISH: End of function that allows only numbers in manual input fields//PORTUGUÊS Fim da função que permite apenas números em campos de entrada manual 
        private void BtnClear_Click(object sender, EventArgs e)
        {
            //ENGLISH: Commands to clear all information entered by the user//PORTUGUÊS: Comandos para limpar todas as informações inseridas pelo usuário

            if (MessageBox.Show("You want clear all fields?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                MessageBox.Show("Operation Canceled",Info,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {
                CbRegion.SelectedIndex = -1;
                CbTypePlace.SelectedIndex = -1;
                CbSlab.SelectedIndex = -1;
                CbTypeArea.SelectedIndex = -1;
                CbSun.SelectedIndex = -1;
                TbSquareMeters.Text = "";
                TbWindows.Text = "";
                TbNumCurtains.Text ="";
                TbLamps.Text = "";
                CbKindLamps.SelectedIndex = -1;
                TbPeople.Text = "";
                TbEletronics.Text = "";
            }
        }

        private void CbTypePlace_SelectedValueChanged(object sender, EventArgs e)
        {
            if(CbTypePlace.SelectedIndex == 1)
            {
                CbSlab.SelectedIndex = 0;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want exit?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            

            if(CbRegion.SelectedIndex == 0)
            {
                ValueRegion = 100; //South-Sul
            }

            else if (CbRegion.SelectedIndex == 1)
            {
                ValueRegion = 150;//Southeast-Suldeste
            }

            else if (CbRegion.SelectedIndex == 2)
            {
                ValueRegion = 400;//North-Norte
            }

            else if (CbRegion.SelectedIndex == 3)
            {
                ValueRegion = 500;//Northeast-Nordeste
            }

            else if (CbRegion.SelectedIndex == 4)
            {
                ValueRegion = 200;//Midwest-Centro-Oeste
            }

            else
            {
                MessageBox.Show("You need choise one region!", Info, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(CbTypePlace.SelectedIndex == 0)
            {
                TypePlace = 200;//House-Casa
            }

            else if(CbTypePlace.SelectedIndex == 1)
            {
                TypePlace = 100; //Apartment-Apartamento
            }

            else
            {
                MessageBox.Show("You need choise Type of Place!", Info, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(CbSlab.SelectedIndex == 0)
            {
                Slab = 0; //With Slab-Com laje
            }

            else if(CbSlab.SelectedIndex == 1)
            {
                Slab = 200;//Without Slab-Sem Laje
            }

            else
            {
                MessageBox.Show("You need inform, if place have slab!", Info, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(CbTypeArea.SelectedIndex== 0)
            {
                TypeArea = 600; //Residential/Residêncial
            }

            else if (CbTypeArea.SelectedIndex == 1)
            {
                TypeArea = 800;//Commercial/Comercial
            }

            else
            {
                MessageBox.Show("You need inform the type of area", Info, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(CbSun.SelectedIndex == 0)
            {
                Sun = 0;//Sun in morning - Sol de manhã
            }

            else if(CbSun.SelectedIndex == 1)
            {
                Sun = 200;//Sun in afternoon - sol de tarde
            }

            else if(CbSun.SelectedIndex == 2)
            {
                Sun = 250;//Sun all day -  Sol todo dia
            }

            else
            {
                MessageBox.Show("You need inform incidence of sun in place!", Info, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqrMeters = int.Parse(TbSquareMeters.Text);        
            Windows = int.Parse(TbWindows.Text);
            Curtains = int.Parse(TbNumCurtains.Text);
            Lamps = int.Parse(TbLamps.Text);

            if (CbKindLamps.SelectedIndex == 0)
            {
                TypeLamps = 100; // Cold Lamps
            }

            else if(CbKindLamps.SelectedIndex == 1)
            {
                TypeLamps = 300;//Hot Lamps
            }

            else
            {
                MessageBox.Show("You need inform the type of lamps!", Info, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            People = int.Parse(TbPeople.Text);
            Eletronics = int.Parse(TbEletronics.Text);

            TotalSqr = SqrMeters * TypeArea; 
            TotalWindows = (Windows* 300) - (Curtains * 150);
            TotalLamps = TypeLamps * Lamps;
            TotalPeople = People * 150;
            TotalEletronics = Eletronics * 150;

            TotalBtu = TotalSqr + TotalWindows + TotalLamps + TotalPeople + TotalEletronics + ValueRegion + Sun + Slab+TypePlace;

            MessageBox.Show("TotalBtu :" + TotalBtu);
        } 
    }
}