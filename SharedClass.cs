using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Configuration;
using System.Web;
using System.IO;
using System.Transactions;
using CsvHelper;
using CsvHelper.Configuration;


namespace GradAssessment
{
   public class SharedClass
    {
       
        public bool CheckIfNameIsValid(string name)
        {
            //checks if only alphabets was inputted
            if (!Regex.IsMatch(name, "^[a-zA-Z]*$"))
            {
               MessageBox.Show("Please input alphabets only");
                return false;
            }
            {
                return true;
            }
           
        
           
        }

        //gets the percentage match for the two names
        public int GetPercentageMatch(string name1,string name2)
        {
            //joins the two names together with matches
            string str = name1.ToLower() + "matches" + name2.ToLower();
            int count =0;
            string counter = "";

            //while loop repeats until string is empty
            while (str.Length>0)
            {
            //checks if character equals another character in the string
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0]==str[i])
                    {
                        count++;
                      
                    }
                }
            
             //joins all counters in a string
                counter = counter + count;
                count = 0;

                //removes all instances of the character that was checked above from the string 
                str = Regex.Replace(str, str[0].ToString(), "");

            }

            // varible declaration
            string sum = "";
            int revCount;
            int middleNum;
            int counts = 0;

            while (counter.Length > 2)
            {
                revCount = (counter.Length) - 1;
                middleNum = 0;

                //checks if lenght of string is even or odd to get the middle number      
                if (((counter.Length) % 2) == 0)
                {
                    middleNum = counter.Length / 2;
                }
                else
                {
                    middleNum = (counter.Length - 1) / 2;
                }

                for (int i = 0; i < middleNum; i++)
                {
                    //add the first and last number 
                    sum = sum + ((Int32.Parse(counter[i].ToString())) + (Int32.Parse(counter[revCount - i].ToString())));

                }

                if (((counter.Length) % 2) == 1)
                {
                    //inserts the middle number at the end if the length was odd
                    sum = sum + counter[middleNum];
                }
                counter = (sum);
                sum = "";

                counts++;
            }
            //converts string to an Int and returns the value
            return (Int32.Parse(counter));
        }

        public string CheckIfGoodMatch(string name1, string name2,int perc)
        {
            string gMatch = "";
            if (perc > 80)
            {
                gMatch = (name1 + " matches " + name2 + " " + perc + "%, good match");
            }
            else
            {
                gMatch = (name1 + " matches " + name2 + " " + perc + "%");
            }
            return gMatch;
        }

        public void ReadCsv(string path)
        {
            
            string[] csvLines = System.IO.File.ReadAllLines(path);
            string[,] array = new string[csvLines.Length, 2];
            string[] row;
            string tempName;
            string tempGender;

            var males = new List<string>();
            var females = new List<string>();

            for (int i = 0; i < csvLines.Length-1; i++)
            {
                row = csvLines[i].Split(",");
                if (row.Length != 2)
                {
                    MessageBox.Show("Please upload a valid CSV file");
                }
                else
                {
                    tempName = row[0].Remove(0, 1);
                    tempGender = row[1].Remove(1, 1);

                    if (CheckIfNameIsValid(tempName)) { 

                    if (tempGender.ToLower() == "m")
                    {
                        males.Add(tempName);
                    }
                    else
                    if (tempGender.ToLower() == "f")
                    {
                        females.Add(tempName);
                    }
                    else
                    {
                        MessageBox.Show("Please upload a valid CSV file");
                    }
                }

                }
            }

           males = RemoveDuplicates(males);
           females = RemoveDuplicates(females);
           
            string[,] goodmatchArr = new string[(males.Count * females.Count),5];
            string[] testpr = new string[males.Count * females.Count];
            int c = 0;
            for (int i = 0; i <males.Count; i++)
            {
                for (int j = 0; j < females.Count; j++)
                {
                    testpr[c] = GetPercentageMatch(males[i], females[i]).ToString();
                    goodmatchArr[c,0] = CheckIfGoodMatch(males[i],females[j],GetPercentageMatch(males[i], females[j]));
                    goodmatchArr[c,1] = GetPercentageMatch(males[i], females[j]).ToString();
                    goodmatchArr[c,2] = CheckIfGoodMatch(females[j],males[i], GetPercentageMatch(females[j], males[i]));
                    goodmatchArr[c,3] = GetPercentageMatch(females[j], males[i]).ToString();
                    goodmatchArr[c,4] = ((GetPercentageMatch(males[i], females[j])+GetPercentageMatch(females[j], males[i]))/2).ToString();
                    c++;
                }
            }
            SortArrayByIndex(goodmatchArr, 1);
          
        }

        public List<string> RemoveDuplicates (List<string> templst)
        {
            for (int i = 0; i <templst.Count; i++)
            {
                for (int j = 0; j < templst.Count; j++)
                {
                    if (i!=j) {
                        if (templst[i] == templst[j])
                        {
                            templst.RemoveAt(j);
                        }
                    }
                }
            }

            return templst;
        }

        public void SortArrayByIndex(string[,] sortedArray ,int index)
        {
            int length = sortedArray.GetLength(0);
            string temp = "";
            int c = 0;
            var finalArr = new List<string>();
            for (int i = 0; i <= (length-1); i++)
            {
                for (int j = 0; j <= (length-i-1); j++)
                {
                    if (Int32.Parse(sortedArray[j,index])> Int32.Parse(sortedArray[j+1, index]))
                    {
                        int k = 0;
                   //     for (int k = 0; k < 5; k++)
                    //    {
                            temp = sortedArray[j, k];
                            sortedArray[j, k] = sortedArray[j+1, k];
                            sortedArray[j+1, k] = temp;
                     //   }
                       
                    }

                }
            }

            for (int m = 0; m < length; m++)
            {
                finalArr.Add(sortedArray[m, 0]);
            }
            WriteToTextFile(finalArr);
        }


        public void WriteToTextFile(List<string> printedArray)
        {
            
            using (StreamWriter writer = new StreamWriter("output.txt", true))
            {
                for (int i = 0; i < printedArray.Count; i++)
                {
                    writer.WriteLine(printedArray[i]);
                }
               
            }
          
        }
         
    }
}
