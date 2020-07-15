namespace MameTools
{
    partial class FormTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTools));
            this.buttonMoveFound = new System.Windows.Forms.Button();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.buttonMoveNotFound = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonSkipExt = new System.Windows.Forms.RadioButton();
            this.radioButtonFullName = new System.Windows.Forms.RadioButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonListFolder = new System.Windows.Forms.Button();
            this.buttonSource = new System.Windows.Forms.Button();
            this.buttonDest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMoveFound
            // 
            this.buttonMoveFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveFound.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveFound.Image")));
            this.buttonMoveFound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMoveFound.Location = new System.Drawing.Point(7, 401);
            this.buttonMoveFound.Name = "buttonMoveFound";
            this.buttonMoveFound.Size = new System.Drawing.Size(169, 80);
            this.buttonMoveFound.TabIndex = 0;
            this.buttonMoveFound.Text = "Move found";
            this.buttonMoveFound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMoveFound.UseVisualStyleBackColor = true;
            this.buttonMoveFound.Click += new System.EventHandler(this.buttonMoveFound_Click);
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(16, 53);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(440, 20);
            this.textBoxSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Roms folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination Roms folder:";
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(12, 94);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(444, 20);
            this.textBoxDestination.TabIndex = 3;
            // 
            // buttonMoveNotFound
            // 
            this.buttonMoveNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveNotFound.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveNotFound.Image")));
            this.buttonMoveNotFound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMoveNotFound.Location = new System.Drawing.Point(182, 401);
            this.buttonMoveNotFound.Name = "buttonMoveNotFound";
            this.buttonMoveNotFound.Size = new System.Drawing.Size(169, 80);
            this.buttonMoveNotFound.TabIndex = 5;
            this.buttonMoveNotFound.Text = "Move not found";
            this.buttonMoveNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMoveNotFound.UseVisualStyleBackColor = true;
            this.buttonMoveNotFound.Click += new System.EventHandler(this.buttonMoveNotFound_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rom list: (separate by line)";
            // 
            // radioButtonSkipExt
            // 
            this.radioButtonSkipExt.AutoSize = true;
            this.radioButtonSkipExt.Checked = true;
            this.radioButtonSkipExt.Location = new System.Drawing.Point(462, 134);
            this.radioButtonSkipExt.Name = "radioButtonSkipExt";
            this.radioButtonSkipExt.Size = new System.Drawing.Size(95, 17);
            this.radioButtonSkipExt.TabIndex = 8;
            this.radioButtonSkipExt.TabStop = true;
            this.radioButtonSkipExt.Text = "Skip Extension";
            this.radioButtonSkipExt.UseVisualStyleBackColor = true;
            // 
            // radioButtonFullName
            // 
            this.radioButtonFullName.AutoSize = true;
            this.radioButtonFullName.Location = new System.Drawing.Point(462, 157);
            this.radioButtonFullName.Name = "radioButtonFullName";
            this.radioButtonFullName.Size = new System.Drawing.Size(72, 17);
            this.radioButtonFullName.TabIndex = 9;
            this.radioButtonFullName.Text = "Full Name";
            this.radioButtonFullName.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 134);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(444, 261);
            this.richTextBox.TabIndex = 11;
            this.richTextBox.Text = "";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(418, 398);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(13, 13);
            this.labelCount.TabIndex = 12;
            this.labelCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Count:";
            // 
            // buttonListFolder
            // 
            this.buttonListFolder.Location = new System.Drawing.Point(462, 222);
            this.buttonListFolder.Name = "buttonListFolder";
            this.buttonListFolder.Size = new System.Drawing.Size(135, 80);
            this.buttonListFolder.TabIndex = 14;
            this.buttonListFolder.Text = "<< List a folder";
            this.buttonListFolder.UseVisualStyleBackColor = true;
            this.buttonListFolder.Click += new System.EventHandler(this.buttonListFolder_Click);
            // 
            // buttonSource
            // 
            this.buttonSource.Location = new System.Drawing.Point(462, 52);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(78, 20);
            this.buttonSource.TabIndex = 15;
            this.buttonSource.Text = "...";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // buttonDest
            // 
            this.buttonDest.Location = new System.Drawing.Point(462, 93);
            this.buttonDest.Name = "buttonDest";
            this.buttonDest.Size = new System.Drawing.Size(78, 20);
            this.buttonDest.TabIndex = 16;
            this.buttonDest.Text = "...";
            this.buttonDest.UseVisualStyleBackColor = true;
            this.buttonDest.Click += new System.EventHandler(this.buttonDest_Click);
            // 
            // FormTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 493);
            this.Controls.Add(this.buttonDest);
            this.Controls.Add(this.buttonSource);
            this.Controls.Add(this.buttonListFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.radioButtonFullName);
            this.Controls.Add(this.radioButtonSkipExt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMoveNotFound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.buttonMoveFound);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTools";
            this.Text = "MAME Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMoveFound;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Button buttonMoveNotFound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonSkipExt;
        private System.Windows.Forms.RadioButton radioButtonFullName;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonListFolder;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.Button buttonDest;
    }
}

