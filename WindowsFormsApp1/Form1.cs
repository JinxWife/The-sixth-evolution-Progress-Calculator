using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //大顆的
        int[] Origin_Big = new int[31]; //起源
        int[] Proficient_Big = new int[31]; //精通
        int[] Strengthen_Big = new int[31]; //強化
        int[] Common_Big = new int[31]; //共用
        //碎片
        int[] Origin_Small = new int[31]; //起源
        int[] Proficient_Small = new int[31]; //精通
        int[] Strengthen_Small = new int[31]; //強化
        int[] Common_Small = new int[31]; //共用

        int total_Origin_Big = 0;
        int total_Proficient_Big = 0;
        int total_Strengthen_Big = 0;
        int total_Common_Big = 0;

        int total_Origin_Small = 0;
        int total_Proficient_Small = 0;
        int total_Strengthen_Small = 0;
        int total_Common_Small = 0;

        int AllTotal_Big = 0;
        int AllTotal_Small = 0;

        float BP, SP = 0;

        int[] nowVersionSet = { 1, 4, 4, 1 };//(當前版本技能數量 依序是起源、精通、強化、共用)

        int Origin1LV = 0, Origin2LV = 0, Origin3LV = 0, Origin4LV = 0, Origin5LV = 0, Origin6LV = 0;
        int Proficient1LV = 0, Proficient2LV = 0, Proficient3LV = 0, Proficient4LV = 0;
        int Strengthen1LV = 0, Strengthen2LV = 0, Strengthen3LV = 0, Strengthen4LV = 0;
        int Common1LV = 0, Common2LV = 0, Common3LV = 0, Common4LV = 0;

        void ReadData()
        {
            Origin_Big[0] = 0; Proficient_Big[0] = 0; Strengthen_Big[0] = 0; Common_Big[0] = 0;
            //大顆1~10
            Origin_Big[1] = 0; Proficient_Big[1] = 3; Strengthen_Big[1] = 4; Common_Big[1] = 7;
            Origin_Big[2] = 1; Proficient_Big[2] = 1; Strengthen_Big[2] = 1; Common_Big[2] = 2;
            Origin_Big[3] = 1; Proficient_Big[3] = 1; Strengthen_Big[3] = 1; Common_Big[3] = 2;
            Origin_Big[4] = 1; Proficient_Big[4] = 1; Strengthen_Big[4] = 1; Common_Big[4] = 2;
            Origin_Big[5] = 2; Proficient_Big[5] = 1; Strengthen_Big[5] = 2; Common_Big[5] = 3;
            Origin_Big[6] = 2; Proficient_Big[6] = 1; Strengthen_Big[6] = 2; Common_Big[6] = 3;
            Origin_Big[7] = 2; Proficient_Big[7] = 1; Strengthen_Big[7] = 2; Common_Big[7] = 3;
            Origin_Big[8] = 3; Proficient_Big[8] = 2; Strengthen_Big[8] = 3; Common_Big[8] = 5;
            Origin_Big[9] = 3; Proficient_Big[9] = 2; Strengthen_Big[9] = 3; Common_Big[9] = 5;
            Origin_Big[10] = 10; Proficient_Big[10] = 5; Strengthen_Big[10] = 8; Common_Big[10] = 14;
            //大顆11~20
            Origin_Big[11] = 3; Proficient_Big[11] = 2; Strengthen_Big[11] = 3; Common_Big[11] = 5;
            Origin_Big[12] = 3; Proficient_Big[12] = 2; Strengthen_Big[12] = 3; Common_Big[12] = 5;
            Origin_Big[13] = 4; Proficient_Big[13] = 2; Strengthen_Big[13] = 3; Common_Big[13] = 6;
            Origin_Big[14] = 4; Proficient_Big[14] = 2; Strengthen_Big[14] = 3; Common_Big[14] = 6;
            Origin_Big[15] = 4; Proficient_Big[15] = 2; Strengthen_Big[15] = 3; Common_Big[15] = 6;
            Origin_Big[16] = 4; Proficient_Big[16] = 2; Strengthen_Big[16] = 3; Common_Big[16] = 6;
            Origin_Big[17] = 4; Proficient_Big[17] = 2; Strengthen_Big[17] = 3; Common_Big[17] = 6;
            Origin_Big[18] = 4; Proficient_Big[18] = 2; Strengthen_Big[18] = 3; Common_Big[18] = 6;
            Origin_Big[19] = 5; Proficient_Big[19] = 3; Strengthen_Big[19] = 4; Common_Big[19] = 7;
            Origin_Big[20] = 15; Proficient_Big[20] = 8; Strengthen_Big[20] = 12; Common_Big[20] = 17;
            //大顆21~30
            Origin_Big[21] = 5; Proficient_Big[21] = 3; Strengthen_Big[21] = 4; Common_Big[21] = 7;
            Origin_Big[22] = 5; Proficient_Big[22] = 3; Strengthen_Big[22] = 4; Common_Big[22] = 7;
            Origin_Big[23] = 5; Proficient_Big[23] = 3; Strengthen_Big[23] = 4; Common_Big[23] = 7;
            Origin_Big[24] = 5; Proficient_Big[24] = 3; Strengthen_Big[24] = 4; Common_Big[24] = 7;
            Origin_Big[25] = 5; Proficient_Big[25] = 3; Strengthen_Big[25] = 4; Common_Big[25] = 7;
            Origin_Big[26] = 6; Proficient_Big[26] = 3; Strengthen_Big[26] = 5; Common_Big[26] = 9;
            Origin_Big[27] = 6; Proficient_Big[27] = 3; Strengthen_Big[27] = 5; Common_Big[27] = 9;
            Origin_Big[28] = 6; Proficient_Big[28] = 3; Strengthen_Big[28] = 5; Common_Big[28] = 9;
            Origin_Big[29] = 7; Proficient_Big[29] = 4; Strengthen_Big[29] = 6; Common_Big[29] = 10;
            Origin_Big[30] = 20; Proficient_Big[30] = 10; Strengthen_Big[30] = 15; Common_Big[30] = 20;

            Origin_Small[0] = 0; Proficient_Small[0] = 0; Strengthen_Small[0] = 0; Common_Small[0] = 0;
            //碎片1~10
            Origin_Small[1] = 0; Proficient_Small[1] = 50; Strengthen_Small[1] = 75; Common_Small[1] = 125;
            Origin_Small[2] = 30; Proficient_Small[2] = 15; Strengthen_Small[2] = 23; Common_Small[2] = 38;
            Origin_Small[3] = 35; Proficient_Small[3] = 18; Strengthen_Small[3] = 27; Common_Small[3] = 44;
            Origin_Small[4] = 40; Proficient_Small[4] = 20; Strengthen_Small[4] = 30; Common_Small[4] = 50;
            Origin_Small[5] = 45; Proficient_Small[5] = 23; Strengthen_Small[5] = 34; Common_Small[5] = 57;
            Origin_Small[6] = 50; Proficient_Small[6] = 25; Strengthen_Small[6] = 38; Common_Small[6] = 63;
            Origin_Small[7] = 55; Proficient_Small[7] = 28; Strengthen_Small[7] = 42; Common_Small[7] = 69;
            Origin_Small[8] = 60; Proficient_Small[8] = 30; Strengthen_Small[8] = 45; Common_Small[8] = 75;
            Origin_Small[9] = 65; Proficient_Small[9] = 33; Strengthen_Small[9] = 49; Common_Small[9] = 82;
            Origin_Small[10] = 200; Proficient_Small[10] = 100; Strengthen_Small[10] = 150; Common_Small[10] = 300;
            //碎片11~20
            Origin_Small[11] = 80; Proficient_Small[11] = 40; Strengthen_Small[11] = 60; Common_Small[11] = 110;
            Origin_Small[12] = 90; Proficient_Small[12] = 45; Strengthen_Small[12] = 68; Common_Small[12] = 124;
            Origin_Small[13] = 100; Proficient_Small[13] = 50; Strengthen_Small[13] = 75; Common_Small[13] = 138;
            Origin_Small[14] = 110; Proficient_Small[14] = 55; Strengthen_Small[14] = 83; Common_Small[14] = 152;
            Origin_Small[15] = 120; Proficient_Small[15] = 60; Strengthen_Small[15] = 90; Common_Small[15] = 165;
            Origin_Small[16] = 130; Proficient_Small[16] = 65; Strengthen_Small[16] = 98; Common_Small[16] = 179;
            Origin_Small[17] = 140; Proficient_Small[17] = 70; Strengthen_Small[17] = 105; Common_Small[17] = 193;
            Origin_Small[18] = 150; Proficient_Small[18] = 75; Strengthen_Small[18] = 113; Common_Small[18] = 207;
            Origin_Small[19] = 160; Proficient_Small[19] = 80; Strengthen_Small[19] = 120; Common_Small[19] = 220;
            Origin_Small[20] = 350; Proficient_Small[20] = 175; Strengthen_Small[20] = 263; Common_Small[20] = 525;
            //碎片21~30
            Origin_Small[21] = 170; Proficient_Small[21] = 85; Strengthen_Small[21] = 128; Common_Small[21] = 234;
            Origin_Small[22] = 180; Proficient_Small[22] = 90; Strengthen_Small[22] = 135; Common_Small[22] = 248;
            Origin_Small[23] = 190; Proficient_Small[23] = 95; Strengthen_Small[23] = 143; Common_Small[23] = 262;
            Origin_Small[24] = 200; Proficient_Small[24] = 100; Strengthen_Small[24] = 150; Common_Small[24] = 275;
            Origin_Small[25] = 210; Proficient_Small[25] = 105; Strengthen_Small[25] = 158; Common_Small[25] = 289;
            Origin_Small[26] = 220; Proficient_Small[26] = 110; Strengthen_Small[26] = 165; Common_Small[26] = 303;
            Origin_Small[27] = 230; Proficient_Small[27] = 115; Strengthen_Small[27] = 173; Common_Small[27] = 317;
            Origin_Small[28] = 240; Proficient_Small[28] = 120; Strengthen_Small[28] = 180; Common_Small[28] = 330;
            Origin_Small[29] = 250; Proficient_Small[29] = 125; Strengthen_Small[29] = 188; Common_Small[29] = 344;
            Origin_Small[30] = 500; Proficient_Small[30] = 250; Strengthen_Small[30] = 375; Common_Small[30] = 750;
        }
        void GetTotal()
        {
            for (int i = 0; i < 31; i++)
            {
                total_Origin_Big += Origin_Big[i];
                total_Proficient_Big += Proficient_Big[i];
                total_Strengthen_Big += Strengthen_Big[i];
                total_Common_Big += Common_Big[i];

                total_Origin_Small += Origin_Small[i];
                total_Proficient_Small += Proficient_Small[i];
                total_Strengthen_Small += Strengthen_Small[i];
                total_Common_Small += Common_Small[i];
            }

            AllTotal_Big = total_Origin_Big* nowVersionSet[0] + total_Proficient_Big* nowVersionSet[1]
                + total_Strengthen_Big* nowVersionSet[2] + total_Common_Big * nowVersionSet[3];

            AllTotal_Small = total_Origin_Small * nowVersionSet[0] + total_Proficient_Small * nowVersionSet[1]
                + total_Strengthen_Small * nowVersionSet[2] + total_Common_Small * nowVersionSet[3];

        }
        void CalculatePercent()
        {
            int Now_Total_Big;
            int Now_Total_Small;

            int[] OriginLV = { Origin1LV, Origin2LV, Origin3LV, Origin4LV, Origin5LV, Origin6LV };
            int[] ProficientLV = { Proficient1LV, Proficient2LV, Proficient3LV, Proficient4LV };
            int[] StrengthenLV = { Strengthen1LV, Strengthen2LV, Strengthen3LV, Strengthen4LV };
            int[] CommonLV = { Common1LV, Common2LV, Common3LV, Common4LV };

            Now_Total_Big = GetNowLVAmount("big", OriginLV, ProficientLV, StrengthenLV, CommonLV);
            Now_Total_Small = GetNowLVAmount("small", OriginLV, ProficientLV, StrengthenLV, CommonLV);

            float Big = (float)Now_Total_Big / (float)AllTotal_Big;
            float Small = (float)Now_Total_Small / (float)AllTotal_Small;

            BP = Big * 100.0f;
            SP = Small * 100.0f;
        }
        int GetNowLVAmount(string kind, int[] nowOriginLV, int[] nowProficientLV, int[] nowStrengthenLV, int[] nowCommonLV)
        {
            int so = 0, sp = 0, ss = 0, sc = 0;

            if (kind == "big")
            {
                for (int i = 0; i < nowVersionSet[0]; i++)
                {
                    for (int j = 0; j <= nowOriginLV[i]; j++)
                    {
                        so += Origin_Big[j];
                    }
                }
                for (int i = 0; i < nowVersionSet[1]; i++)
                {
                    for (int j = 0; j <= nowProficientLV[i]; j++)
                    {
                        sp += Proficient_Big[j];
                    }
                }
                for (int i = 0; i < nowVersionSet[2]; i++)
                {
                    for (int j = 0; j <= nowStrengthenLV[i]; j++)
                    {
                        ss += Strengthen_Big[j];
                    }
                }
                for (int i = 0; i < nowVersionSet[3]; i++)
                {
                    for (int j = 0; j <= nowCommonLV[i]; j++)
                    {
                        sc += Common_Big[j];
                    }
                }

                int SUM = so + sp + ss + sc;
                //MessageBox.Show(SUM.ToString());
                return SUM;
            }
            else if (kind == "small")
            {
                for (int i = 0; i < nowVersionSet[0]; i++)
                {
                    for (int j = 0; j <= nowOriginLV[i]; j++)
                    {
                        so += Origin_Small[j];
                    }
                }
                for (int i = 0; i < nowVersionSet[1]; i++)
                {
                    for (int j = 0; j <= nowProficientLV[i]; j++)
                    {
                        sp += Proficient_Small[j];
                    }
                }
                for (int i = 0; i < nowVersionSet[2]; i++)
                {
                    for (int j = 0; j <= nowStrengthenLV[i]; j++)
                    {
                        ss += Strengthen_Small[j];
                    }
                }
                for (int i = 0; i < nowVersionSet[3]; i++)
                {
                    for (int j = 0; j <= nowCommonLV[i]; j++)
                    {
                        sc += Common_Small[j];
                    }
                }

                int SUM = so + sp + ss + sc;
                return SUM;
            }
            else
                return 0;
        }void RefreshUI()
        {
            label1.Text = Origin1LV.ToString();
            label2.Text = Origin2LV.ToString();
            label3.Text = Origin3LV.ToString();
            label4.Text = Origin4LV.ToString();
            label5.Text = Origin5LV.ToString();
            label6.Text = Origin6LV.ToString();
            label7.Text = Proficient1LV.ToString();
            label8.Text = Proficient2LV.ToString();
            label9.Text = Proficient3LV.ToString();
            label10.Text = Proficient4LV.ToString();
            label11.Text = Strengthen1LV.ToString();
            label12.Text = Strengthen2LV.ToString();
            label13.Text = Strengthen3LV.ToString();
            label14.Text = Strengthen4LV.ToString();
            label15.Text = Common1LV.ToString();
            label16.Text = Common2LV.ToString();
            label17.Text = Common3LV.ToString();
            label18.Text = Common4LV.ToString();

            BigPercent.Text = BP.ToString("#0.00") + "%";
            SmallPercent.Text = SP.ToString("#0.00") + "%";
        }
        void VersionSet_Button()
        {
            switch (nowVersionSet[0]) //起源
            {
                case 1:
                    button2u.Enabled = false;
                    button2d.Enabled = false;
                    button3u.Enabled = false;
                    button3d.Enabled = false;
                    button4u.Enabled = false;
                    button4d.Enabled = false;
                    button5u.Enabled = false;
                    button5d.Enabled = false;
                    button6u.Enabled = false;
                    button6d.Enabled = false;
                    break;
                case 2:
                    button3u.Enabled = false;
                    button3d.Enabled = false;
                    button4u.Enabled = false;
                    button4d.Enabled = false;
                    button5u.Enabled = false;
                    button5d.Enabled = false;
                    button6u.Enabled = false;
                    button6d.Enabled = false;
                    break;
                case 3:
                    button4u.Enabled = false;
                    button4d.Enabled = false;
                    button5u.Enabled = false;
                    button5d.Enabled = false;
                    button6u.Enabled = false;
                    button6d.Enabled = false;
                    break;
                case 4:
                    button5u.Enabled = false;
                    button5d.Enabled = false;
                    button6u.Enabled = false;
                    button6d.Enabled = false;
                    break;
                case 5:
                    button6u.Enabled = false;
                    button6d.Enabled = false;
                    break;
            }
            switch (nowVersionSet[1]) //精通
            {
                case 1:
                    button8u.Enabled = false;
                    button8d.Enabled = false;
                    button9u.Enabled = false;
                    button9d.Enabled = false;
                    button10u.Enabled = false;
                    button10d.Enabled = false;
                    break;
                case 2:
                    button9u.Enabled = false;
                    button9d.Enabled = false;
                    button10u.Enabled = false;
                    button10d.Enabled = false;
                    break;
                case 3:
                    button10u.Enabled = false;
                    button10d.Enabled = false;
                    break;
            }
            switch (nowVersionSet[2]) //強化
            {
                case 1:
                    button12u.Enabled = false;
                    button12d.Enabled = false;
                    button13u.Enabled = false;
                    button13d.Enabled = false;
                    button14u.Enabled = false;
                    button14d.Enabled = false;
                    break;
                case 2:
                    button13u.Enabled = false;
                    button13d.Enabled = false;
                    button14u.Enabled = false;
                    button14d.Enabled = false;
                    break;
                case 3:
                    button14u.Enabled = false;
                    button14d.Enabled = false;
                    break;
            }
            switch (nowVersionSet[3]) //共用
            {
                case 1:
                    button16u.Enabled = false;
                    button16d.Enabled = false;
                    button17u.Enabled = false;
                    button17d.Enabled = false;
                    button18u.Enabled = false;
                    button18d.Enabled = false;
                    break;
                case 2:
                    button17u.Enabled = false;
                    button17d.Enabled = false;
                    button18u.Enabled = false;
                    button18d.Enabled = false;
                    break;
                case 3:
                    button18u.Enabled = false;
                    button18d.Enabled = false;
                    break;
            }


        }
        private void button2u_Click(object sender, EventArgs e)
        {
            if (Origin2LV < 30)
                Origin2LV++;
            RefreshUI();
        }

        private void button2d_Click(object sender, EventArgs e)
        {
            if (Origin2LV > 0)
                Origin2LV--;
            RefreshUI();
        }

        private void button3u_Click(object sender, EventArgs e)
        {
            if (Origin3LV < 30)
                Origin3LV++;
            RefreshUI();
        }

        private void button3d_Click(object sender, EventArgs e)
        {
            if (Origin3LV > 0)
                Origin3LV--;
            RefreshUI();
        }

        private void button4u_Click(object sender, EventArgs e)
        {
            if (Origin4LV < 30)
                Origin4LV++;
            RefreshUI();
        }

        private void button4d_Click(object sender, EventArgs e)
        {
            if (Origin4LV > 0)
                Origin4LV--;
            RefreshUI();
        }

        private void button5u_Click(object sender, EventArgs e)
        {
            if (Origin5LV < 30)
                Origin5LV++;
            RefreshUI();
        }

        private void button5d_Click(object sender, EventArgs e)
        {
            if (Origin5LV > 0)
                Origin5LV--;
            RefreshUI();
        }

        private void button6u_Click(object sender, EventArgs e)
        {
            if (Origin6LV < 30)
                Origin6LV++;
            RefreshUI();
        }

        private void button6d_Click(object sender, EventArgs e)
        {
            if (Origin6LV > 0)
                Origin6LV--;
            RefreshUI();
        }

        private void button8u_Click(object sender, EventArgs e)
        {
            if (Proficient2LV < 30)
                Proficient2LV++;
            RefreshUI();
        }

        private void button8d_Click(object sender, EventArgs e)
        {
            if (Proficient2LV > 0)
                Proficient2LV--;
            RefreshUI();
        }

        private void button9u_Click(object sender, EventArgs e)
        {
            if (Proficient3LV < 30)
                Proficient3LV++;
            RefreshUI();
        }

        private void button9d_Click(object sender, EventArgs e)
        {
            if (Proficient3LV > 0)
                Proficient3LV--;
            RefreshUI();
        }

        private void button10u_Click(object sender, EventArgs e)
        {
            if (Proficient4LV < 30)
                Proficient4LV++;
            RefreshUI();
        }

        private void button10d_Click(object sender, EventArgs e)
        {
            if (Proficient4LV > 0)
                Proficient4LV--;
            RefreshUI();
        }

        private void button12u_Click(object sender, EventArgs e)
        {
            if (Strengthen2LV < 30)
                Strengthen2LV++;
            RefreshUI();
        }

        private void button12d_Click(object sender, EventArgs e)
        {
            if (Strengthen2LV > 0)
                Strengthen2LV--;
            RefreshUI();
        }

        private void button13u_Click(object sender, EventArgs e)
        {
            if (Strengthen3LV < 30)
                Strengthen3LV++;
            RefreshUI();
        }

        private void button13d_Click(object sender, EventArgs e)
        {
            if (Strengthen3LV > 0)
                Strengthen3LV--;
            RefreshUI();
        }

        private void button14u_Click(object sender, EventArgs e)
        {
            if (Strengthen4LV < 30)
                Strengthen4LV++;
            RefreshUI();
        }

        private void button14d_Click(object sender, EventArgs e)
        {
            if (Strengthen4LV > 0)
                Strengthen4LV--;
            RefreshUI();
        }

        private void button16u_Click(object sender, EventArgs e)
        {
            if (Common2LV < 30)
                Common2LV++;
            RefreshUI();
        }

        private void button16d_Click(object sender, EventArgs e)
        {
            if (Common2LV > 0)
                Common2LV--;
            RefreshUI();
        }

        private void button17u_Click(object sender, EventArgs e)
        {
            if (Common3LV < 30)
                Common3LV++;
            RefreshUI();
        }

        private void button17d_Click(object sender, EventArgs e)
        {
            if (Common3LV > 0)
                Common3LV--;
            RefreshUI();
        }

        private void button18u_Click(object sender, EventArgs e)
        {
            if (Common4LV < 30)
                Common4LV++;
            RefreshUI();
        }

        private void button18d_Click(object sender, EventArgs e)
        {
            if (Common4LV > 0)
                Common4LV--;
            RefreshUI();
        }

        
        
        
        public Form1()
        {
            InitializeComponent();         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadData();
            GetTotal();
            CalculatePercent();
            RefreshUI();
            VersionSet_Button();
        }

        private void button1u_Click(object sender, EventArgs e)
        {
            if (Origin1LV < 30)
                Origin1LV++;
            RefreshUI();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Origin1LV > 0)
                Origin1LV--;
            RefreshUI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Proficient1LV < 30)
                Proficient1LV++;
            RefreshUI();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Proficient1LV > 0)
                Proficient1LV--;
            RefreshUI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Strengthen1LV < 30)
                Strengthen1LV++;
            RefreshUI();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Strengthen1LV > 0)
                Strengthen1LV--;
            RefreshUI();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Common1LV < 30)
                Common1LV++;
            RefreshUI();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Common1LV > 0)
                Common1LV--;
            RefreshUI();
        }

        private void button_final_Click(object sender, EventArgs e)
        {
            CalculatePercent();
            RefreshUI();
        }
    }
}
