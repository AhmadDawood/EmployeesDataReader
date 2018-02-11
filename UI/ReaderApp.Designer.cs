namespace EmployeesDataReader
{
    partial class ReaderApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderApp));
            this.panelUI = new System.Windows.Forms.Panel();
            this.lvNames = new System.Windows.Forms.ListView();
            this.pictureBoxCompany = new System.Windows.Forms.PictureBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUI
            // 
            this.panelUI.Controls.Add(this.buttonExit);
            this.panelUI.Controls.Add(this.lvNames);
            this.panelUI.Controls.Add(this.pictureBoxCompany);
            this.panelUI.Controls.Add(this.buttonPrint);
            this.panelUI.Controls.Add(this.buttonSave);
            this.panelUI.Controls.Add(this.buttonRefresh);
            this.panelUI.Controls.Add(this.webBrowser);
            this.panelUI.Location = new System.Drawing.Point(4, 12);
            this.panelUI.Name = "panelUI";
            this.panelUI.Size = new System.Drawing.Size(830, 535);
            this.panelUI.TabIndex = 0;
            // 
            // lvNames
            // 
            this.lvNames.FullRowSelect = true;
            this.lvNames.Location = new System.Drawing.Point(3, 98);
            this.lvNames.Name = "lvNames";
            this.lvNames.Size = new System.Drawing.Size(143, 422);
            this.lvNames.TabIndex = 1;
            this.lvNames.UseCompatibleStateImageBehavior = false;
            this.lvNames.Click += new System.EventHandler(this.lvNames_Click);
            // 
            // pictureBoxCompany
            // 
            this.pictureBoxCompany.Image = global::EmployeesDataReader.Properties.Resources.AbcCompanyLogo;
            this.pictureBoxCompany.Location = new System.Drawing.Point(31, 23);
            this.pictureBoxCompany.Name = "pictureBoxCompany";
            this.pictureBoxCompany.Size = new System.Drawing.Size(237, 46);
            this.pictureBoxCompany.TabIndex = 1;
            this.pictureBoxCompany.TabStop = false;
            // 
            // buttonPrint
            // 
            this.buttonPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.Location = new System.Drawing.Point(527, 12);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(108, 71);
            this.buttonPrint.TabIndex = 4;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSave.Image = global::EmployeesDataReader.Properties.Resources.Save_as_icon;
            this.buttonSave.Location = new System.Drawing.Point(413, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(108, 71);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRefresh.Image = global::EmployeesDataReader.Properties.Resources.Button_Refresh_icon;
            this.buttonRefresh.Location = new System.Drawing.Point(299, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 71);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(152, 98);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(597, 422);
            this.webBrowser.TabIndex = 6;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(641, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 71);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ReaderApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 559);
            this.Controls.Add(this.panelUI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ReaderApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees Data Reader App";
            this.Shown += new System.EventHandler(this.ReaderApp_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReaderApp_KeyDown);
            this.panelUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUI;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PictureBox pictureBoxCompany;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListView lvNames;
        private System.Windows.Forms.Button buttonExit;

    }
}