namespace IUSDatasources {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialogXml = new System.Windows.Forms.OpenFileDialog();
            this.btnParseFile = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tvXML = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(87, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(343, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(69, 20);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Select File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialogXml
            // 
            this.openFileDialogXml.FileName = "openFileDialogXml";
            // 
            // btnParseFile
            // 
            this.btnParseFile.Location = new System.Drawing.Point(436, 11);
            this.btnParseFile.Name = "btnParseFile";
            this.btnParseFile.Size = new System.Drawing.Size(68, 21);
            this.btnParseFile.TabIndex = 2;
            this.btnParseFile.Text = "Parse XML";
            this.btnParseFile.UseVisualStyleBackColor = true;
            this.btnParseFile.Click += new System.EventHandler(this.btnParseFile_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(87, 39);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(35, 13);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "label1";
            // 
            // tvXML
            // 
            this.tvXML.Location = new System.Drawing.Point(12, 66);
            this.tvXML.Name = "tvXML";
            this.tvXML.Size = new System.Drawing.Size(492, 386);
            this.tvXML.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 464);
            this.Controls.Add(this.tvXML);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnParseFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtFileName);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogXml;
        private System.Windows.Forms.Button btnParseFile;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TreeView tvXML;

    }
}

