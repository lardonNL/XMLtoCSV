namespace XMLtoCSV
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
            this.SelectXML_Button = new System.Windows.Forms.Button();
            this.SelectXSLT_Button = new System.Windows.Forms.Button();
            this.XMLDirectory_Textbox = new System.Windows.Forms.TextBox();
            this.XSLTDirectory_Textbox = new System.Windows.Forms.TextBox();
            this.CSVFile_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Convert_Button = new System.Windows.Forms.Button();
            this.XML_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.XSLT_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // SelectXML_Button
            // 
            this.SelectXML_Button.Location = new System.Drawing.Point(13, 13);
            this.SelectXML_Button.Name = "SelectXML_Button";
            this.SelectXML_Button.Size = new System.Drawing.Size(110, 23);
            this.SelectXML_Button.TabIndex = 0;
            this.SelectXML_Button.Text = "Select XML File";
            this.SelectXML_Button.UseVisualStyleBackColor = true;
            this.SelectXML_Button.Click += new System.EventHandler(this.SelectXML_Button_Click);
            // 
            // SelectXSLT_Button
            // 
            this.SelectXSLT_Button.Location = new System.Drawing.Point(13, 43);
            this.SelectXSLT_Button.Name = "SelectXSLT_Button";
            this.SelectXSLT_Button.Size = new System.Drawing.Size(110, 23);
            this.SelectXSLT_Button.TabIndex = 1;
            this.SelectXSLT_Button.Text = "Select XSLT File";
            this.SelectXSLT_Button.UseVisualStyleBackColor = true;
            this.SelectXSLT_Button.Click += new System.EventHandler(this.SelectXSLT_Button_Click);
            // 
            // XMLDirectory_Textbox
            // 
            this.XMLDirectory_Textbox.Location = new System.Drawing.Point(130, 13);
            this.XMLDirectory_Textbox.Name = "XMLDirectory_Textbox";
            this.XMLDirectory_Textbox.ReadOnly = true;
            this.XMLDirectory_Textbox.Size = new System.Drawing.Size(391, 20);
            this.XMLDirectory_Textbox.TabIndex = 2;
            // 
            // XSLTDirectory_Textbox
            // 
            this.XSLTDirectory_Textbox.Location = new System.Drawing.Point(130, 45);
            this.XSLTDirectory_Textbox.Name = "XSLTDirectory_Textbox";
            this.XSLTDirectory_Textbox.ReadOnly = true;
            this.XSLTDirectory_Textbox.Size = new System.Drawing.Size(391, 20);
            this.XSLTDirectory_Textbox.TabIndex = 3;
            // 
            // CSVFile_TextBox
            // 
            this.CSVFile_TextBox.Location = new System.Drawing.Point(130, 72);
            this.CSVFile_TextBox.Name = "CSVFile_TextBox";
            this.CSVFile_TextBox.Size = new System.Drawing.Size(391, 20);
            this.CSVFile_TextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name CSV file";
            // 
            // Convert_Button
            // 
            this.Convert_Button.Location = new System.Drawing.Point(446, 98);
            this.Convert_Button.Name = "Convert_Button";
            this.Convert_Button.Size = new System.Drawing.Size(75, 23);
            this.Convert_Button.TabIndex = 6;
            this.Convert_Button.Text = "Convert";
            this.Convert_Button.UseVisualStyleBackColor = true;
            this.Convert_Button.Click += new System.EventHandler(this.Convert_Button_Click);
            // 
            // XML_OpenFileDialog
            // 
            this.XML_OpenFileDialog.FileName = "openFileDialog1";
            // 
            // XSLT_OpenFileDialog
            // 
            this.XSLT_OpenFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 133);
            this.Controls.Add(this.Convert_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CSVFile_TextBox);
            this.Controls.Add(this.XSLTDirectory_Textbox);
            this.Controls.Add(this.XMLDirectory_Textbox);
            this.Controls.Add(this.SelectXSLT_Button);
            this.Controls.Add(this.SelectXML_Button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "A2A to CSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectXML_Button;
        private System.Windows.Forms.Button SelectXSLT_Button;
        private System.Windows.Forms.TextBox XMLDirectory_Textbox;
        private System.Windows.Forms.TextBox XSLTDirectory_Textbox;
        private System.Windows.Forms.TextBox CSVFile_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Convert_Button;
        private System.Windows.Forms.OpenFileDialog XML_OpenFileDialog;
        private System.Windows.Forms.OpenFileDialog XSLT_OpenFileDialog;
    }
}

