using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class CaesarCipher : Form
    {
        public CaesarCipher()
        {
            InitializeComponent();
            
            // to selct the defualt valu for commbo boxes
            comboBoxEnc.SelectedIndex = 0;
            comboBoxDec.SelectedIndex = 0;
        }

        //==================== interface react ===================
        private void radoKey_CheckedChanged(object sender, EventArgs e)
        {
            // if radoKey select
            comboBoxDec.Enabled = true;
        }

        private void radoAll_CheckedChanged(object sender, EventArgs e)
        {
            // if radoAll select
            comboBoxDec.Enabled = false;
        }

        private void radoBest_CheckedChanged(object sender, EventArgs e)
        {
            // if radoBest select
            comboBoxDec.Enabled = false;
        }

        // ########## MENU ############
        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clear all to default
                //text areas
            txtaPlan.Clear();
            txtaCiph.Clear();
            txtaOut.Clear();
                // radeo btn
            radoSps.Checked = true;
            radoKey.Checked = true;
                //comboBoxes
            comboBoxEnc.SelectedIndex = 0;
            comboBoxDec.SelectedIndex = 0;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About box1 = new About();
            box1.ShowDialog();
        }



        //=========================== Buttins =======================

        //####################
        //##### btn Enc ######
        //####################
        private void btnEnc_Click(object sender, EventArgs e)
        {
            txtaOut.Clear();
            int intK = comboBoxEnc.SelectedIndex;
            string strPT = txtaPlan.Text;

            // check if no spaces slected
            if (radoNOSps.Checked == true){
               strPT = strPT.Replace(" ", string.Empty);
            }

            // calling Enc function
            string strCT = Enc(strPT, intK);

            //out but cipher
            txtaOut.AppendText(strCT);
        }

        //###################
        //##### btn Dec #####
        //###################
        private void btnDec_Click(object sender, EventArgs e)
        {
            txtaOut.Clear();

            //////// Dec with Key //////////////
            if (radoKey.Checked == true)
            {
                int intK = comboBoxDec.SelectedIndex;
                string strCT = txtaCiph.Text;

                // calling DecK function
                string strPT = DecK(strCT, intK);

                //out but cipher
                txtaOut.AppendText(strPT);
            }

            /////// Dec All ///////////////////
            if (radoAll.Checked == true)
            {
                string strCT = txtaCiph.Text;
                this.DecAll(strCT);
            }

            /////// Dec Best //////////////////
            if (radoBest.Checked == true)
            {
                string strCT = txtaCiph.Text;
                this.DecBest(strCT);
            }
        }

    //========================================================
    //===================== All Functions ====================
    //========================================================
        //---------------- Encoding -------------------------
        public string Enc (string strPT, int intK){
            strPT = strPT.ToLower();
            char[] buffer = strPT.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (letter != ' ')
                {
                    letter = (char)(letter + intK);
                    //overflow
                    //if (letter > 'Z') {
                    //  letter = (char)(letter - 26);
                    //}
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                }
                buffer[i] = letter;
            }
            string strCT = new string(buffer);
            return strCT;
        }// Enc

        //----------------- Decoding ------------------------
        //################## Decoding with Key ##############
        public string DecK(string strCT, int intK) {
            strCT = strCT.ToLower();
            char[] buffer = strCT.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (letter != ' ')
                {
                    letter = (char)(letter - intK);
                    //overflow
                    if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                }
                buffer[i] = letter;
            }
            string strPT = new string(buffer);
            return strPT;
        }

        //################## Decoding All ###################
        public void DecAll(string strCT) {
            for (int i = 0; i < 26; i++)
            {
                // calling DecK function
                string strPT = DecK(strCT, i);
                //out but cipher
                txtaOut.AppendText("=============== KEY " + i + " ================" + System.Environment.NewLine);
                txtaOut.AppendText(strPT + System.Environment.NewLine + System.Environment.NewLine);
            }
        }

        //################## Decoding Best ###################
        public void DecBest(string strCT) {
            List<ans> listAns = new List<ans>();
            // fulling the list with all possible answer
            for (int i = 0; i < 26; i++)
            {
                // calling DecK function
                string strPT = DecK(strCT, i);
                // creat ans object
                ans temp = new ans(i, 0, strPT);
                listAns.Add(temp);
            }

            //just for cheking if list is working
            //txtaOut.AppendText(listAns[2].getstrTxt() + listAns[2].getintId() + listAns[2].getintPoints());
            
            // space or not
            int intSpsCount = 0;
            for (int i = 0; i < strCT.Length; i++ ) {
                if (strCT[i].Equals(' ')) { intSpsCount++; }
            }

            // test for cout of space
            //txtaOut.AppendText(intSpsCount.ToString());
            if (intSpsCount == 0) { this.noSpase(listAns); }
            if (intSpsCount > 0) { this.Space(listAns); }
        }

        //%%%%%%%%%%%% function for spaces and no spaces %%%%%%%%%%%%%%%
            //&&&&&&&&& space &&&&&&&&&&&&&&&&&&
        public void Space(List<ans> lstAns) {
            //outer for to go throw all answer
            for (int i = 0; i < 26; i++) {
                string[] subStrings = lstAns[i].getstrTxt().Split(' ');
                // loop to go throw all subStrings
                for (int j = 0; j < subStrings.Count(); j++ ) {
                    //One-Letter Words
                    if (subStrings[j].Equals("a")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("i")) { lstAns[i].setintPoints(1); }
                    //Most Frequent Two-Letter Words
                    if (subStrings[j].Equals("of")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("to")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("in")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("it")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("is")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("be")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("as")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("at")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("so")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("we")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("he")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("by")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("or")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("on")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("do")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("if")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("me")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("my")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("up")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("an")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("go")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("no")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("us")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("am")) { lstAns[i].setintPoints(1); }
                    //Most Frequent Three-Letter Words
                    if (subStrings[j].Equals("the")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("and")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("for")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("are")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("but")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("not")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("you")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("all")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("any")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("can")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("had")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("her")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("was")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("one")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("our")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("out")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("day")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("get")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("has")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("him")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("how")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("man")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("new")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("now")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("old")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("see")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("two")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("way")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("who")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("boy")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("did")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("its")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("let")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("put")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("say")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("she")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("too")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("use")) { lstAns[i].setintPoints(1); }
                    //Most Frequent Four-Letter Words
                    if (subStrings[j].Equals("that")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("with")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("this")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("will")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("your")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("from")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("they")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("know")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("want")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("been")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("good")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("much")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("some")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Equals("time")) { lstAns[i].setintPoints(1); }
                    //Most Common Doubles
                    if (subStrings[j].Contains("ss")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("ee")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("tt")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("ff")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("ll")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("mm")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("oo")) { lstAns[i].setintPoints(1); }
                    //Digraphs
                    if (subStrings[j].Contains("th")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("er")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("on")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("an")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("re")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("he")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("in")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("ed")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("nd")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("ha")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("at")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("en")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("es")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("of")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("or")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("nt")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("ea")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("ti")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("to")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("it")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("st")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("io")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("le")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("is")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("ou")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("ar")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("as")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("de")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("rt")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("ve")) { lstAns[i].setintPoints(1); }
                    //Trigraphs
                    if (subStrings[j].Contains("the")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("and")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("tha")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("ent")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("ion")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("tio")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("for")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("nde")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("has")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("nce")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("edt")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("tis")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("oft")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("sth")) { lstAns[i].setintPoints(1); }
                    if (subStrings[j].Contains("men")) { lstAns[i].setintPoints(1); }
                }//iner loop
            }//outer loop

            ans best = new ans(-1, -1, "");
            // loop throw list and return best points
            for (int k = 0; k < 26; k++ ) {
                if (lstAns[k].getintPoints() > best.getintPoints()) { best = lstAns[k]; }
            
            }// for best points

            if (best.getintPoints() == 0) { txtaOut.AppendText("####  SORRY COULDN'T FIND BEST ANSWER. TRY OTHER OPTIONS ####"); }
            else
            {
                txtaOut.AppendText("KEY for BEST Answer:  " + best.getintId() + System.Environment.NewLine);
                txtaOut.AppendText("POINTS for BEST Answer:  " + best.getintPoints() + System.Environment.NewLine);
                txtaOut.AppendText("PLANTEXT for BEST Answer:  " + best.getstrTxt() + System.Environment.NewLine);
            }
        }

            //&&&&&&&& no space &&&&&&&&&&&&&&&&
        public void noSpase(List<ans> lstAns) {
           // int ECount = 0;
           // int tempE = 0;
           // ans best = new ans(-1, -1, "");

            //outer for to go throw all answer
            for (int i = 0; i < 26; i++) {
                /*
                tempE = 0;
                //loop throw cipher text and count e
                foreach (char temp in lstAns[i].getstrTxt()) {
                    if (char.Equals(temp, 'e')) { tempE++; }
                }
                if (tempE > ECount){
                    ECount = tempE;
                    best = lstAns[i];
                }
                */
                //Most Common Doubles
                if (lstAns[i].getstrTxt().Contains("ss")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("ee")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("tt")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("ff")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("ll")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("mm")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("oo")) { lstAns[i].setintPoints(1); }
                //Digraphs
                if (lstAns[i].getstrTxt().Contains("th")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("er")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("on")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("an")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("re")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("he")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("in")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("ed")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("nd")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("ha")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("at")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("en")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("es")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("of")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("or")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("nt")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("ea")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("ti")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("to")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("it")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("st")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("io")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("le")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("is")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("ou")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("ar")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("as")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("de")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("rt")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("ve")) { lstAns[i].setintPoints(1); }
                //Trigraphs
                if (lstAns[i].getstrTxt().Contains("the")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("and")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("tha")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("ent")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("ion")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("tio")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("for")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("nde")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("has")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("nce")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("edt")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("tis")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("oft")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("sth")) { lstAns[i].setintPoints(1); }
                if (lstAns[i].getstrTxt().Contains("men")) { lstAns[i].setintPoints(1); }
            }//outer loop

            ans best = new ans(-1, -1, "");
            // loop throw list and return best points
            for (int k = 0; k < 26; k++)
            {
                if (lstAns[k].getintPoints() > best.getintPoints()) { best = lstAns[k]; }

            }// for best points

            if (best.getintPoints() == 0) { txtaOut.AppendText("####  SORRY COULDN'T FIND BEST ANSWER. TRY OTHER OPTIONS ####"); }
            else
            {
                txtaOut.AppendText("KEY for BEST Answer:  " + best.getintId() + System.Environment.NewLine);
                txtaOut.AppendText("POINTS for BEST Answer:  " + best.getintPoints() + System.Environment.NewLine);
                txtaOut.AppendText("PLANTEXT for BEST Answer:  " + best.getstrTxt() + System.Environment.NewLine);
            }
        }


    }// mian class
}// namespace





//================== class ans ==================

public class ans {
    int intId;
    int intPoints;
    string strTxt;

    public ans(int id, int pont, string txt) {
        intId = id;
        intPoints = pont;
        strTxt = txt;
    }
    public int getintId() { return intId; }
    public int getintPoints() { return intPoints; }
    public string getstrTxt() { return strTxt; }
    public void setintPoints(int pont) { intPoints = intPoints + pont; }
}