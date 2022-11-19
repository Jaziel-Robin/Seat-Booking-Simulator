namespace SeatBookingSimulator
{
    partial class Form3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonGenerateSeats = new System.Windows.Forms.Button();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.panelSeats = new System.Windows.Forms.Panel();
            this.screen = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_Row = new System.Windows.Forms.TextBox();
            this.TextBox_Col = new System.Windows.Forms.TextBox();
            this.TextBox_RowDiv = new System.Windows.Forms.TextBox();
            this.TextBox_ColDiv = new System.Windows.Forms.TextBox();
            this.ButtonA = new System.Windows.Forms.Button();
            this.ButtonB = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonD = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonEndSimulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonGenerateSeats
            // 
            this.ButtonGenerateSeats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonGenerateSeats.Location = new System.Drawing.Point(21, 199);
            this.ButtonGenerateSeats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonGenerateSeats.Name = "ButtonGenerateSeats";
            this.ButtonGenerateSeats.Size = new System.Drawing.Size(255, 33);
            this.ButtonGenerateSeats.TabIndex = 0;
            this.ButtonGenerateSeats.Text = "Generate seats";
            this.ButtonGenerateSeats.UseVisualStyleBackColor = true;
            this.ButtonGenerateSeats.Click += new System.EventHandler(this.GenerateSeats);
            // 
            // LabelMessage
            // 
            this.LabelMessage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelMessage.Location = new System.Drawing.Point(28, 521);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(248, 114);
            this.LabelMessage.TabIndex = 1;
            this.LabelMessage.TextChanged += new System.EventHandler(this.LabelMessage_TextChanged);
            // 
            // panelSeats
            // 
            this.panelSeats.AutoScroll = true;
            this.panelSeats.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSeats.Location = new System.Drawing.Point(306, 58);
            this.panelSeats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(1221, 845);
            this.panelSeats.TabIndex = 2;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.Info;
            this.screen.Location = new System.Drawing.Point(520, 14);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(559, 40);
            this.screen.TabIndex = 0;
            this.screen.Text = "Screen";
            this.screen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonSave.Location = new System.Drawing.Point(168, 4);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(108, 45);
            this.ButtonSave.TabIndex = 3;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonLoad.Location = new System.Drawing.Point(21, 4);
            this.ButtonLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(108, 45);
            this.ButtonLoad.TabIndex = 4;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seats  per row";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Row divider(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Column divider(s)";
            // 
            // TextBox_Row
            // 
            this.TextBox_Row.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Row.Location = new System.Drawing.Point(156, 70);
            this.TextBox_Row.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Row.Name = "TextBox_Row";
            this.TextBox_Row.Size = new System.Drawing.Size(120, 27);
            this.TextBox_Row.TabIndex = 6;
            this.TextBox_Row.TextChanged += new System.EventHandler(this.TextBox_Row_TextChanged);
            // 
            // TextBox_Col
            // 
            this.TextBox_Col.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Col.Location = new System.Drawing.Point(156, 103);
            this.TextBox_Col.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Col.Name = "TextBox_Col";
            this.TextBox_Col.Size = new System.Drawing.Size(120, 27);
            this.TextBox_Col.TabIndex = 6;
            this.TextBox_Col.TextChanged += new System.EventHandler(this.TextBox_Col_TextChanged);
            // 
            // TextBox_RowDiv
            // 
            this.TextBox_RowDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_RowDiv.Location = new System.Drawing.Point(156, 136);
            this.TextBox_RowDiv.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_RowDiv.Name = "TextBox_RowDiv";
            this.TextBox_RowDiv.Size = new System.Drawing.Size(120, 27);
            this.TextBox_RowDiv.TabIndex = 6;
            this.TextBox_RowDiv.TextChanged += new System.EventHandler(this.TextBox_RowDiv_TextChanged);
            // 
            // TextBox_ColDiv
            // 
            this.TextBox_ColDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_ColDiv.Location = new System.Drawing.Point(156, 168);
            this.TextBox_ColDiv.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_ColDiv.Name = "TextBox_ColDiv";
            this.TextBox_ColDiv.Size = new System.Drawing.Size(120, 27);
            this.TextBox_ColDiv.TabIndex = 6;
            this.TextBox_ColDiv.TextChanged += new System.EventHandler(this.TextBox_ColDiv_TextChanged);
            // 
            // ButtonA
            // 
            this.ButtonA.BackColor = System.Drawing.Color.Gold;
            this.ButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonA.Location = new System.Drawing.Point(30, 248);
            this.ButtonA.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonA.Name = "ButtonA";
            this.ButtonA.Size = new System.Drawing.Size(241, 27);
            this.ButtonA.TabIndex = 7;
            this.ButtonA.Text = "Person A Booking";
            this.ButtonA.UseVisualStyleBackColor = false;
            this.ButtonA.Click += new System.EventHandler(this.ButtonA_Click);
            // 
            // ButtonB
            // 
            this.ButtonB.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonB.Location = new System.Drawing.Point(30, 295);
            this.ButtonB.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonB.Name = "ButtonB";
            this.ButtonB.Size = new System.Drawing.Size(241, 27);
            this.ButtonB.TabIndex = 7;
            this.ButtonB.Text = "Person B Booking";
            this.ButtonB.UseVisualStyleBackColor = false;
            this.ButtonB.Click += new System.EventHandler(this.ButtonB_Click);
            // 
            // ButtonC
            // 
            this.ButtonC.BackColor = System.Drawing.Color.Crimson;
            this.ButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonC.Location = new System.Drawing.Point(30, 341);
            this.ButtonC.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(241, 27);
            this.ButtonC.TabIndex = 7;
            this.ButtonC.Text = "Person C Booking";
            this.ButtonC.UseVisualStyleBackColor = false;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // ButtonD
            // 
            this.ButtonD.BackColor = System.Drawing.Color.Teal;
            this.ButtonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonD.Location = new System.Drawing.Point(30, 387);
            this.ButtonD.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonD.Name = "ButtonD";
            this.ButtonD.Size = new System.Drawing.Size(241, 27);
            this.ButtonD.TabIndex = 7;
            this.ButtonD.Text = "Person D Booking";
            this.ButtonD.UseVisualStyleBackColor = false;
            this.ButtonD.Click += new System.EventHandler(this.ButtonD_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.BackColor = System.Drawing.Color.Silver;
            this.ButtonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonReset.Location = new System.Drawing.Point(30, 482);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(241, 27);
            this.ButtonReset.TabIndex = 7;
            this.ButtonReset.Text = "Reset Simulation";
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonEndSimulation
            // 
            this.ButtonEndSimulation.BackColor = System.Drawing.Color.Silver;
            this.ButtonEndSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonEndSimulation.Location = new System.Drawing.Point(30, 432);
            this.ButtonEndSimulation.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEndSimulation.Name = "ButtonEndSimulation";
            this.ButtonEndSimulation.Size = new System.Drawing.Size(241, 27);
            this.ButtonEndSimulation.TabIndex = 8;
            this.ButtonEndSimulation.Text = "End Simulation";
            this.ButtonEndSimulation.UseVisualStyleBackColor = false;
            this.ButtonEndSimulation.Click += new System.EventHandler(this.ButtonEndSimulation_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1539, 911);
            this.Controls.Add(this.ButtonEndSimulation);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonD);
            this.Controls.Add(this.ButtonC);
            this.Controls.Add(this.ButtonB);
            this.Controls.Add(this.ButtonA);
            this.Controls.Add(this.TextBox_ColDiv);
            this.Controls.Add(this.TextBox_RowDiv);
            this.Controls.Add(this.TextBox_Col);
            this.Controls.Add(this.TextBox_Row);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.ButtonGenerateSeats);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "Safe Distance Smart Mode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonGenerateSeats;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Panel panelSeats;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_Row;
        private System.Windows.Forms.TextBox TextBox_Col;
        private System.Windows.Forms.TextBox TextBox_RowDiv;
        private System.Windows.Forms.TextBox TextBox_ColDiv;
        private System.Windows.Forms.Button ButtonA;
        private System.Windows.Forms.Button ButtonB;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ButtonD;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Label screen;
        private System.Windows.Forms.Button ButtonEndSimulation;
    }
}
