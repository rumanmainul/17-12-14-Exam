using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace DailyExpenseApp
{
    public partial class DailyExpense : Form
    {
        public DailyExpense()
        {
            InitializeComponent();
        }

        private string filePath = "f://DailyExpense.csv";
        private string dailyExpAmount = "";
        private string expenseCategory = "";
        private string particular = "";
        private void saveButton_Click(object sender, EventArgs e)
        {
            dailyExpAmount = amountTextBox.Text;
            expenseCategory = categoryComboBox.Text;
            particular = particularTextBox.Text;
            FileStream aDailyExpenseFileStream = new FileStream(filePath, FileMode.Append);
            CsvFileWriter aDailyExpenseCsvFileWriter = new CsvFileWriter(aDailyExpenseFileStream);
            List<string> aDailyExpenseList = new List<string>();
            aDailyExpenseList.Add(dailyExpAmount);
            aDailyExpenseList.Add(expenseCategory);
            aDailyExpenseList.Add(particular);
            aDailyExpenseCsvFileWriter.WriteRow(aDailyExpenseList);
            aDailyExpenseFileStream.Close();
            MessageBox.Show("Save Successfully");
        }
        
        private void showExpense_Click(object sender, EventArgs e)
        {
            int sumOfExpense = 0;
            int maxExpense= 0;
            FileStream aReadFileStream = new FileStream(filePath, FileMode.Open);
            CsvFileReader aReadCsvFileReader = new CsvFileReader(aReadFileStream);
            List<string> aExpenseList = new List<string>();
            
            while (aReadCsvFileReader.ReadRow(aExpenseList))
            {
                int allTotalExpense = Convert.ToInt32(aExpenseList[0]);
                sumOfExpense = sumOfExpense + allTotalExpense;
                maxExpense = MaxExpenseCalculate(allTotalExpense, aReadCsvFileReader);
            }
            aReadFileStream.Close();
            totalExpenseTextBox.Text = sumOfExpense.ToString();
            maximumExpenseTextBox.Text = maxExpense.ToString();
            
        }

        private int MaxExpenseCalculate(int allTotalExpense, CsvFileReader aReadCsvFileReader)
        {
            int a = 0;
            List<string> aExpenseList = new List<string>();

            while (aReadCsvFileReader.ReadRow(aExpenseList))
            {
                int expenses = Convert.ToInt32(aExpenseList[0]);
                if (allTotalExpense >= expenses)
                {
                    a = allTotalExpense;
                }
                else
                {
                    a = expenses; 
                }

            }
            return a;
        }


        private void showButton_Click(object sender, EventArgs e)
        {
            string viewCategoryWise= categoryWiseExpComboBox.Text;
            int totalExpOfCategory = 0;
            FileStream aReadFileStream = new FileStream(filePath, FileMode.Open);
            CsvFileReader aReadCsvFileReader = new CsvFileReader(aReadFileStream);
            List<string> aExpenseList = new List<string>();
            detailsListBox.Items.Clear();
            totalCatWiseExpenseTextBox.Clear();
            while (aReadCsvFileReader.ReadRow(aExpenseList))
            {
                string getCategory = aExpenseList[1];
                if (getCategory == viewCategoryWise)
                {
                    detailsListBox.Items.Add("Amount->" + aExpenseList[0] + " Category ->" + aExpenseList[1] +
                                             " Particular->" + aExpenseList[2]);
                    int totalExpense = Convert.ToInt32(aExpenseList[0]);
                    totalExpOfCategory = totalExpOfCategory + totalExpense;
                }
                
            }
            aReadFileStream.Close();
            totalCatWiseExpenseTextBox.Text = totalExpOfCategory.ToString();
        }
    }
}
