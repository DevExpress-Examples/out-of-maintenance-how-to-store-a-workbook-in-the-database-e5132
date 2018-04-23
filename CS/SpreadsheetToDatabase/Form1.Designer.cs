namespace SpreadsheetToDatabase
{
    partial class Form1
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
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDBLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnDBSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 56);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.SelectedPicture = null;
            this.spreadsheetControl1.SelectedShape = null;
            this.spreadsheetControl1.Size = new System.Drawing.Size(814, 481);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDBLoad);
            this.panelControl1.Controls.Add(this.btnDBSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(814, 56);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDBLoad
            // 
            this.btnDBLoad.Location = new System.Drawing.Point(330, 13);
            this.btnDBLoad.Name = "btnDBLoad";
            this.btnDBLoad.Size = new System.Drawing.Size(122, 23);
            this.btnDBLoad.TabIndex = 1;
            this.btnDBLoad.Text = "Load from Database";
            this.btnDBLoad.Click += new System.EventHandler(this.btnDBLoad_Click);
            // 
            // btnDBSave
            // 
            this.btnDBSave.Location = new System.Drawing.Point(30, 13);
            this.btnDBSave.Name = "btnDBSave";
            this.btnDBSave.Size = new System.Drawing.Size(122, 23);
            this.btnDBSave.TabIndex = 0;
            this.btnDBSave.Text = "Save to Database";
            this.btnDBSave.Click += new System.EventHandler(this.btnDBSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 537);
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDBLoad;
        private DevExpress.XtraEditors.SimpleButton btnDBSave;
    }
}

