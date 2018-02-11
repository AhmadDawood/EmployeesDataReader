using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using EmployeesData;

namespace EmployeesDataReader
{
    public partial class ReaderApp : Form
    {
        public ReaderApp()
        {
            InitializeComponent();
        }
        private void ReaderApp_KeyDown(object sender, KeyEventArgs e)
        {
            // When User Press Escape Key Quit the Application.
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
        private void ReaderApp_Shown(object sender, EventArgs e)
        {
            //Load Data in ListBox on startup.
            fillListBox();
            this.lvNames.Focus();
            this.buttonSave.Enabled = false;
            this.buttonPrint.Enabled = false;
        }
        public void fillListBox()
        {
            
            this.UseWaitCursor = true;
            Application.DoEvents();
            
            //code for Filling ListView and displaying Data at startup.
            List<Employee> employeeList;   
            try
            {
                employeeList = EmployeeDB.GetEmployeesNames();
                if (employeeList.Count > 0)
                {
                    Employee employee;
                    lvNames.View = View.Details;
                    lvNames.GridLines = true;

                    lvNames.Columns.Add("ID",0);
                    lvNames.Columns.Add("Employee Name", 130);
                                        
                    for (int i = 0; i < employeeList.Count; i++)
                    {
                        employee = employeeList[i];
                        //Loading Data into Listview for Display
                        lvNames.Items.Add(employee.EmpID.ToString());
                        lvNames.Items[i].SubItems.Add(employee.FirstName + " " + employee.LastName);
                    }
                }
                else
                {
                    MessageBox.Show("There is no Employee Data Available to Display.", 
                        "EmployeeDataReaderApp_fillListBox(): Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EmployeeDataReaderApp_fillListBox(): Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
                this.UseWaitCursor = false;
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // call again like in Form_Shown Event.
            lvNames.Clear();
            fillListBox();
            lvNames.Refresh();
            webBrowser.DocumentText = "N/A";
            this.buttonSave.Enabled = false;
            this.buttonPrint.Enabled = false;
        } 
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvNames.FocusedItem.Index != -1)
                {
                    // Disable Save button when there is no html in web browser.
                    saveFileDialog.Filter = "Web Page (*.html)|*.html|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.Title = "Save as";
                    try
                    {
                        saveFileDialog.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "EmployeeDataReaderApp_buttonSave_Click: Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                      MessageBox.Show("Please select a Person from the ListBox", 
                          "EmployeeDataReaderApp_buttonSave_Click: Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "EmployeeDataReaderApp_buttonSave_Click: Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //Shows Print dialogue.
            webBrowser.ShowPrintDialog();
           
        }
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //Write Report to Html File.
            string sHtml = htmlBuilder();
            string name = saveFileDialog.FileName;
            File.WriteAllText(name, sHtml);   
        }
        private void lvNames_Click(object sender, EventArgs e)
        {
            if (lvNames.FocusedItem.Index != -1)
            {
                //1- Fetch Data from DB
                //2- Builds an HTML String.
                //3- write Html to Web Browser Control for viewing Data.
                this.UseWaitCursor = true;
                Application.DoEvents();
                
                try
                {
                    string sHtml = htmlBuilder(); //method Call
                    webBrowser.DocumentText = sHtml; // Writing html to Web Browser Control in GUI.
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "EmployeeDataReaderApp_lvNames_Click: Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
                this.UseWaitCursor = false;
                this.buttonSave.Enabled = true;
                this.buttonPrint.Enabled = true;
            }
        }
        private string htmlBuilder()
        {
            string sFinal = "";
            //1- Fetch the ID of Employee.
            int empID = Convert.ToInt32(lvNames.SelectedItems[0].Text);
            //2- Prepare Query.
            string sql = @"SELECT e.ID, e.FirstName, e.LastName, d.Designation, d.Department, s.Salary 
                            FROM Employee e
                            Inner Join Designation d on e.ID = d.EmpID
                            Inner Join Salary s on e.ID = s.ID
                            where e.ID = " + empID;
            //3-Execute the query and create a HTML Document.
            List<Employee> employeeList;
            StringBuilder sb = new StringBuilder();

            try
            {
                employeeList = EmployeeDB.GetEmployeesData(sql);
                

                if (employeeList.Count > 0)
                {
                    Employee employee;

                    //Html Report Creation
                    sb.Append("<!DOCTYPE html>");
                    sb.Append("<html >");
                    sb.Append("<head><h2><div>");
                    sb.Append("ABC Company Confidential Employees Report");
                    sb.Append("</div><hr/></h2></head>");
                    sb.Append("<body>");
                    sb.Append("<table border='0px' cellpadding='1' cellspacing='1' bgcolor='lightyellow' style='font-family:courier; font-size:120%'>");
                    sb.Append("<tr>");
                    // Data Part.

                     for (int i = 0; i < employeeList.Count; i++)
                        { 
                        
                        employee = employeeList[i];
                        
                        sb.Append("<td> Employee ID : ");
                        sb.Append(employee.EmpID.ToString());
                        sb.Append("<br>");
                        sb.Append(" Employee Name : ");
                        sb.Append(employee.FirstName.ToString() + " " + employee.LastName.ToString());
                        sb.Append("<br>");
                        sb.Append(" Employee Designation : ");
                        sb.Append(employee.Designation.ToString());
                        sb.Append("<br>");
                        sb.Append(" Employee Department : ");
                        sb.Append(employee.Department.ToString());
                        sb.Append("<br>");
                        sb.Append(" Employee Salary : ");
                        sb.Append(employee.Salary.ToString());
                        sb.Append("<br></td>");
                       } 
                    // End Html tags
                    sb.Append("</table>");
                    sb.Append("</div><hr/>");
                    sb.Append("</body>");
                    sb.Append("</html>");
                    Console.WriteLine(" Value of HtmlBuilder is " + sb.ToString());
                }
                else
                {
                    MessageBox.Show("There is no Employee Data Available to Display.", 
                         "EmployeeDataReaderApp_htmlBuilder(): Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EmployeeDataReaderApp_htmlBuilder(): Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
            return sFinal = sb.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      }
    }