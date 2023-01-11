using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruDemoProject.Utilities
{
    public class DataSource
    {
        public static object[] InvalidLoginData()
        {
            string[] dataSet1 = new string[3];
            dataSet1[0] = "KiRan";
            dataSet1[1] = "kiran765";
            dataSet1[2] = "Enter your";



            string[] dataSet2 = new string[3];
            dataSet2[0] = "RadHa";
            dataSet2[1] = "RadHa173";
            dataSet2[2] = "Enter your";

            string[] dataSet3 = new string[3];
            dataSet3[0] = "Raman";
            dataSet3[1] = "RaMAn12";
            dataSet3[2] = "Enter your";




            object[] allDataSet = new object[3]; 
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            allDataSet[2] = dataSet3;

            return allDataSet;
        }
        public static object[] InvalidLoginData1() 
        {
            object[] data = ExcelUtils.GetSheetIntoObjectArray(@"C:\Users\shitalc\Desktop\C#_2022\AutomationProject1\GuruDemoProject\TestData\gurudemo_testdata.xlsx", "InvalidLoginData");
            return data;
        
        }
        public static object[] FlightBookingData1()
        {
            object[] data = ExcelUtils.GetSheetIntoObjectArray(@"C:\Users\shitalc\Desktop\C#_2022\AutomationProject1\GuruDemoProject\TestData\gurudemo_testdata.xlsx", "FlightBooking");
            return data;       
        }

    }
}
