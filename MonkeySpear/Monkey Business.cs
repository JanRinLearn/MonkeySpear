﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeySpear
{
    public partial class Form1 : Form
    {

        public string print;
        static Random _random = new Random();
        public static string output = "";

        public Form1()
        {
            InitializeComponent();
            MonkeyBusinessUI.Library.words.Add("to");
            MonkeyBusinessUI.Library.words.Add("be");
            MonkeyBusinessUI.Library.words.Add("or");
            MonkeyBusinessUI.Library.words.Add("not");
            MonkeyBusinessUI.Library.words.Add("that");
            MonkeyBusinessUI.Library.words.Add("is");
            MonkeyBusinessUI.Library.words.Add("the");
            MonkeyBusinessUI.Library.words.Add("question");
            MonkeyBusinessUI.Library.words.Add("whether");
            MonkeyBusinessUI.Library.words.Add("tis");
            MonkeyBusinessUI.Library.words.Add("nobler");
            MonkeyBusinessUI.Library.words.Add("in");
            MonkeyBusinessUI.Library.words.Add("mind");
            MonkeyBusinessUI.Library.words.Add("suffer");
            MonkeyBusinessUI.Library.words.Add("slings");
            MonkeyBusinessUI.Library.words.Add("and");
            MonkeyBusinessUI.Library.words.Add("arrows");
            MonkeyBusinessUI.Library.words.Add("outrageous");
            MonkeyBusinessUI.Library.words.Add("fortune");
            MonkeyBusinessUI.Library.words.Add("take");
            MonkeyBusinessUI.Library.words.Add("arms");
            MonkeyBusinessUI.Library.words.Add("against");
            MonkeyBusinessUI.Library.words.Add("a");
            MonkeyBusinessUI.Library.words.Add("sea");
            MonkeyBusinessUI.Library.words.Add("troubles");
            MonkeyBusinessUI.Library.words.Add("by");
            MonkeyBusinessUI.Library.words.Add("opposing");
            MonkeyBusinessUI.Library.words.Add("end");
            MonkeyBusinessUI.Library.words.Add("of");
            MonkeyBusinessUI.Library.words.Add("them");
            MonkeyBusinessUI.Library.words.Add("die");
            MonkeyBusinessUI.Library.words.Add("sleep");
            MonkeyBusinessUI.Library.words.Add("no");
            MonkeyBusinessUI.Library.words.Add("more");
            MonkeyBusinessUI.Library.words.Add("say");
            MonkeyBusinessUI.Library.words.Add("we");
            MonkeyBusinessUI.Library.words.Add("heartache");
            MonkeyBusinessUI.Library.words.Add("thousand");
            MonkeyBusinessUI.Library.words.Add("natural");
            MonkeyBusinessUI.Library.words.Add("shocks");
            MonkeyBusinessUI.Library.words.Add("flesh");
            MonkeyBusinessUI.Library.words.Add("heir");
            MonkeyBusinessUI.Library.words.Add("consummation");
            MonkeyBusinessUI.Library.words.Add("devoutly");
            MonkeyBusinessUI.Library.words.Add("wished");
            MonkeyBusinessUI.Library.words.Add("perchance");
            MonkeyBusinessUI.Library.words.Add("dream");
            MonkeyBusinessUI.Library.words.Add("ay");
            MonkeyBusinessUI.Library.words.Add("there");
            MonkeyBusinessUI.Library.words.Add("rub");



        }

        public bool cancelButton = false;
        public int counter = 0;

        private void start_btn_Click(object sender, EventArgs e)
        {
            counter = 0;
            counterW.ResetText();
            word_count.Text = "";
            OutputLabel.ResetText();
            cancelButton = false;

            while (cancelButton == false)
            {
                start_btn.Enabled = false;
               
                    eventH(sender, e);

                    MonkeyBusinessUI.Interpreter(print, MonkeyBusinessUI.Library.words);


                
            }
          
            if (cancelButton == true)
                foreach (string word in MonkeyBusinessUI.Library.wordsFound)
                {
                    word_count.Text += word + " ";

                }
            /*word_count.Text += "\n";*/




        }

        private void eventH(object sender, EventArgs e)
        {
            
            print = Randomizer();
            
            OutputLabel.Text += "\n";

            foreach (char a in print)
            {
                OutputLabel.Text += a;

                OutputLabel.Refresh();

                counterW.Text = counter++.ToString();

            }

            output = "";
        }
        

        protected void Print(string random)
        {
            foreach (char a in print)
            {
                OutputLabel.Text += a;
                OutputLabel.Refresh();
                DoEvents();
            }
        }

        public static void DoEvents()
        {
            Application.DoEvents();
        }

        public static char GetLetter()
        {
            int number = _random.Next(0, 26);
            char letter = (char)('a' + number);
            DoEvents();
            return letter;
        }

        public string Randomizer()
        {

            while (output.Length < 110)
            {
                output += GetLetter();
                DoEvents();
            }
            return output;
        }



        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cancelButton = true;
            start_btn.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutputLabel.ResetText();
            word_count.ResetText();
            counterW.ResetText();
            counter = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
