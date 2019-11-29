using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace WriteToCSVFile
{
    public class Employee
    {
        public enum Designation
        {
            HardearEngineer,
            Webdeveloper,
            Softwareengineer,
            Businessanalyst,
            Systemsanalyst,
            Technicalsupport
        };
        public enum Department
        {
            AccountsandFinance,
            HR,
            Salesandmarketing,
            Infrastructures,
            Researchanddevelopment,
            IT
        };
        public static void Main(string[] args)
        {
            insertData();
            Console.WriteLine("Done");
        }
        public static void insertData()
        {

            var list = new List<Object>();


            string[] empName = { "Ramesh", "Rani", "Bhavesh", "Bishnu", "Chethan" };

            string[] compName = { "HP", "Lenovo", "Samsung", "Asus", "Acer" };
            int[] compid = { 10, 20, 30, 40, 50 };



            StringBuilder csvcontent = new StringBuilder();

            csvcontent.AppendLine("employee_Id,employee_name,designation,department,company_ID,company_Name");
            int empId = 100;

            try
            {
                string csvPath = @"E:\data-structures\Daily_Tasks\ismail\finalEmp.csv";

                int j = 1;
                while (j <= 5)
                {
                    int i = 1;
                    while (i <= 200)
                    {
                        
                        if (i % 2 == 0)
                        {
                            csvcontent.AppendLine(++empId + "," + empName[0] + "," + Designation.Webdeveloper + "," + Department.AccountsandFinance + "," + compid[0] + "," + compName[2]);
                            list.Add(csvcontent.ToString());
                            csvcontent.AppendLine(++empId + "," + empName[2] + "," + Designation.Businessanalyst + "," + Department.IT + "," + compid[2] + "," + compName[1]);
                            list.Add(csvcontent.ToString());
                            csvcontent.AppendLine(++empId + "," + empName[1] + "," + Designation.HardearEngineer + "," + Department.Infrastructures + "," + compid[1] + "," + compName[3]);
                            list.Add(csvcontent.ToString());
                        }
                        else
                        {
                            csvcontent.AppendLine(++empId + "," + empName[4] + "," + Designation.Systemsanalyst + "," + Department.Researchanddevelopment + "," + compid[4] + "," + compName[4]);
                            list.Add(csvcontent.ToString());
                            csvcontent.AppendLine(++empId + "," + empName[3] + "," + Designation.Technicalsupport + "," + Department.Salesandmarketing + "," + compid[3] + "," + compName[0]);
                            list.Add(csvcontent.ToString());
                        }
                        i++;

                    }
                    j++;
                }


                File.AppendAllText(csvPath, csvcontent.ToString());



            }
            catch (Exception ex)
            {
                Console.WriteLine("content is not able written" + ex.Message);
            }

        }
    }
}

