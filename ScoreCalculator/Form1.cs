using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int total = 0;
        int count = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(txtScore.Text);

            total += score;
            count += 1;
            int average = total / count;

            txtScoreTotal.Text = total.ToString();
            txtScoreCount.Text = count.ToString();
            txtAverage.Text = average.ToString();

            txtScore.Focus();

            catch (FormatException)
            {
              MessageBox.Show(
             "Invalid numeric format. Please check all entries.",
              "Entry Error");
            }
            catch (OverflowException)
           {
             MessageBox.Show(
             "Overflow error. Please enter smaller values.",
               "Entry Error");
            }
            catch (DivideByZeroException)
           
         
            
           catch (Exception ex)
          {
         MessageBox.Show(ex.Message + "\n\n" +
         ex.GetType().ToString() + "\n" +
         ex.StackTrace, "Exception")
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            count = 0;

            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";

            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            {
                public bool IsValidData()
               {
                  return
            // Validate the score text box
                  IsPresent(txtScore, "score") &&
                  IsInteger(txtScore, "score") &&
                  IsWithinRange(txtScore, "score", 0, 100) &&
                };
            }
        public bool IsPresent(TextBox txtScore, string name)
            {
              if (txtScore.Text == "")
              {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
              }
              return true;
         }

        public bool IsInteger(TextBox txtScore, string name)
             {
 ;
          if (int.TryParse(txtScore.Text, out number))
              {
                return true;
              }
          else
              {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                 return false;
              }
 }
        public bool IsWithinRange(TextBox textBox, string name,
 
         private void calculateAverage()
        {
            int average = total / count;
            txtAverage.Text = average.ToString();
             
        }
}     
