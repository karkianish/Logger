namespace Logger
{
    partial class Logger
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
            this.components = new System.ComponentModel.Container();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lblTimerInterval = new System.Windows.Forms.Label();
            this.textBoxTimerInterval = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnSaveAndAddMore = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTotalEntries = new System.Windows.Forms.Label();
            this.lblEntriesSinceLastStart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(15, 105);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(464, 218);
            this.rtbNotes.TabIndex = 0;
            this.rtbNotes.Text = "";
            // 
            // lblTimerInterval
            // 
            this.lblTimerInterval.AutoSize = true;
            this.lblTimerInterval.Location = new System.Drawing.Point(12, 23);
            this.lblTimerInterval.Name = "lblTimerInterval";
            this.lblTimerInterval.Size = new System.Drawing.Size(134, 13);
            this.lblTimerInterval.TabIndex = 1;
            this.lblTimerInterval.Text = "Timer Interval (in seconds):";
            // 
            // textBoxTimerInterval
            // 
            this.textBoxTimerInterval.Location = new System.Drawing.Point(152, 20);
            this.textBoxTimerInterval.Name = "textBoxTimerInterval";
            this.textBoxTimerInterval.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimerInterval.TabIndex = 2;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(12, 89);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 3;
            this.lblNotes.Text = "Notes";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(269, 20);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "S&et";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.OnClick_BtnSet);
            // 
            // btnSaveAndAddMore
            // 
            this.btnSaveAndAddMore.Location = new System.Drawing.Point(269, 329);
            this.btnSaveAndAddMore.Name = "btnSaveAndAddMore";
            this.btnSaveAndAddMore.Size = new System.Drawing.Size(111, 23);
            this.btnSaveAndAddMore.TabIndex = 5;
            this.btnSaveAndAddMore.Text = "Save && &Add More";
            this.btnSaveAndAddMore.UseVisualStyleBackColor = true;
            this.btnSaveAndAddMore.Click += new System.EventHandler(this.OnClick_BtnSaveAndAddMore);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(407, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnClick_BtnSave);
            // 
            // lblTotalEntries
            // 
            this.lblTotalEntries.AutoSize = true;
            this.lblTotalEntries.Location = new System.Drawing.Point(138, 56);
            this.lblTotalEntries.Name = "lblTotalEntries";
            this.lblTotalEntries.Size = new System.Drawing.Size(13, 13);
            this.lblTotalEntries.TabIndex = 8;
            this.lblTotalEntries.Text = "0";
            // 
            // lblEntriesSinceLastStart
            // 
            this.lblEntriesSinceLastStart.AutoSize = true;
            this.lblEntriesSinceLastStart.Location = new System.Drawing.Point(12, 56);
            this.lblEntriesSinceLastStart.Name = "lblEntriesSinceLastStart";
            this.lblEntriesSinceLastStart.Size = new System.Drawing.Size(120, 13);
            this.lblEntriesSinceLastStart.TabIndex = 9;
            this.lblEntriesSinceLastStart.Text = "Entries Since Last Start:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.OntTick_Timer);
            // 
            // Logger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 387);
            this.Controls.Add(this.lblEntriesSinceLastStart);
            this.Controls.Add(this.lblTotalEntries);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSaveAndAddMore);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.textBoxTimerInterval);
            this.Controls.Add(this.lblTimerInterval);
            this.Controls.Add(this.rtbNotes);
            this.Name = "Logger";
            this.Text = "LogBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label lblTimerInterval;
        private System.Windows.Forms.TextBox textBoxTimerInterval;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnSaveAndAddMore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTotalEntries;
        private System.Windows.Forms.Label lblEntriesSinceLastStart;
        private System.Windows.Forms.Timer timer1;
    }
}

