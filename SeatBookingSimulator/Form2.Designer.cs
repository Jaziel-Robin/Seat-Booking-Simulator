namespace SeatBookingSimulator
{
    partial class Form2
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
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_Row = new System.Windows.Forms.TextBox();
            this.TextBox_Col = new System.Windows.Forms.TextBox();
            this.TextBox_RowDiv = new System.Windows.Forms.TextBox();
            this.TextBox_ColDiv = new System.Windows.Forms.TextBox();
            this.TextBox_MaxSeats = new System.Windows.Forms.TextBox();
            this.ButtonA = new System.Windows.Forms.Button();
            this.ButtonB = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonD = new System.Windows.Forms.Button();
            this.ButtonEndSimulation = new System.Windows.Forms.Button();
            this.manualEditor = new System.Windows.Forms.GroupBox();
            this.RadioBtn_disableSeats = new System.Windows.Forms.RadioButton();
            this.RadioBtn_enableSeats = new System.Windows.Forms.RadioButton();
            this.ButtonDisableAll = new System.Windows.Forms.Button();
            this.ButtonEnableAll = new System.Windows.Forms.Button();
            this.ButtonEditorMode = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonUndo = new System.Windows.Forms.Button();
            this.ButtonRedo = new System.Windows.Forms.Button();
            this.ButtonSafeDistance = new System.Windows.Forms.Button();
            this.manualEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonGenerateSeats
            // 
            this.ButtonGenerateSeats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonGenerateSeats.Location = new System.Drawing.Point(21, 233);
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
            this.LabelMessage.Location = new System.Drawing.Point(33, 788);
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
            this.label1.Location = new System.Drawing.Point(21, 104);
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
            this.label2.Location = new System.Drawing.Point(21, 137);
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
            this.label3.Location = new System.Drawing.Point(21, 170);
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
            this.label4.Location = new System.Drawing.Point(21, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Column divider(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 323);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Max Seats";
            // 
            // TextBox_Row
            // 
            this.TextBox_Row.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Row.Location = new System.Drawing.Point(156, 104);
            this.TextBox_Row.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Row.Name = "TextBox_Row";
            this.TextBox_Row.Size = new System.Drawing.Size(120, 27);
            this.TextBox_Row.TabIndex = 6;
            this.TextBox_Row.TextChanged += new System.EventHandler(this.TextBox_Row_TextChanged);
            // 
            // TextBox_Col
            // 
            this.TextBox_Col.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Col.Location = new System.Drawing.Point(156, 137);
            this.TextBox_Col.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Col.Name = "TextBox_Col";
            this.TextBox_Col.Size = new System.Drawing.Size(120, 27);
            this.TextBox_Col.TabIndex = 6;
            this.TextBox_Col.TextChanged += new System.EventHandler(this.TextBox_Col_TextChanged);
            // 
            // TextBox_RowDiv
            // 
            this.TextBox_RowDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_RowDiv.Location = new System.Drawing.Point(156, 170);
            this.TextBox_RowDiv.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_RowDiv.Name = "TextBox_RowDiv";
            this.TextBox_RowDiv.Size = new System.Drawing.Size(120, 27);
            this.TextBox_RowDiv.TabIndex = 6;
            this.TextBox_RowDiv.TextChanged += new System.EventHandler(this.TextBox_RowDiv_TextChanged);
            // 
            // TextBox_ColDiv
            // 
            this.TextBox_ColDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_ColDiv.Location = new System.Drawing.Point(156, 202);
            this.TextBox_ColDiv.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_ColDiv.Name = "TextBox_ColDiv";
            this.TextBox_ColDiv.Size = new System.Drawing.Size(120, 27);
            this.TextBox_ColDiv.TabIndex = 6;
            this.TextBox_ColDiv.TextChanged += new System.EventHandler(this.TextBox_ColDiv_TextChanged);
            // 
            // TextBox_MaxSeats
            // 
            this.TextBox_MaxSeats.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBox_MaxSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_MaxSeats.Enabled = false;
            this.TextBox_MaxSeats.Location = new System.Drawing.Point(126, 319);
            this.TextBox_MaxSeats.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_MaxSeats.Name = "TextBox_MaxSeats";
            this.TextBox_MaxSeats.Size = new System.Drawing.Size(150, 27);
            this.TextBox_MaxSeats.TabIndex = 6;
            this.TextBox_MaxSeats.TextChanged += new System.EventHandler(this.MaxSeatsChanged);
            // 
            // ButtonA
            // 
            this.ButtonA.BackColor = System.Drawing.Color.Gold;
            this.ButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonA.Location = new System.Drawing.Point(35, 362);
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
            this.ButtonB.Location = new System.Drawing.Point(35, 409);
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
            this.ButtonC.Location = new System.Drawing.Point(35, 455);
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
            this.ButtonD.Location = new System.Drawing.Point(35, 501);
            this.ButtonD.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonD.Name = "ButtonD";
            this.ButtonD.Size = new System.Drawing.Size(241, 27);
            this.ButtonD.TabIndex = 7;
            this.ButtonD.Text = "Person D Booking";
            this.ButtonD.UseVisualStyleBackColor = false;
            this.ButtonD.Click += new System.EventHandler(this.ButtonD_Click);
            // 
            // ButtonEndSimulation
            // 
            this.ButtonEndSimulation.BackColor = System.Drawing.Color.Silver;
            this.ButtonEndSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonEndSimulation.Location = new System.Drawing.Point(35, 544);
            this.ButtonEndSimulation.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEndSimulation.Name = "ButtonEndSimulation";
            this.ButtonEndSimulation.Size = new System.Drawing.Size(241, 27);
            this.ButtonEndSimulation.TabIndex = 7;
            this.ButtonEndSimulation.Text = "End Simulation";
            this.ButtonEndSimulation.UseVisualStyleBackColor = false;
            this.ButtonEndSimulation.Click += new System.EventHandler(this.ButtonEndSimulation_Click);
            // 
            // manualEditor
            // 
            this.manualEditor.Controls.Add(this.RadioBtn_disableSeats);
            this.manualEditor.Controls.Add(this.RadioBtn_enableSeats);
            this.manualEditor.Controls.Add(this.ButtonDisableAll);
            this.manualEditor.Controls.Add(this.ButtonEnableAll);
            this.manualEditor.Controls.Add(this.ButtonEditorMode);
            this.manualEditor.Location = new System.Drawing.Point(35, 576);
            this.manualEditor.Margin = new System.Windows.Forms.Padding(2);
            this.manualEditor.Name = "manualEditor";
            this.manualEditor.Padding = new System.Windows.Forms.Padding(2);
            this.manualEditor.Size = new System.Drawing.Size(241, 160);
            this.manualEditor.TabIndex = 8;
            this.manualEditor.TabStop = false;
            this.manualEditor.Text = "Manual Editor";
            // 
            // RadioBtn_disableSeats
            // 
            this.RadioBtn_disableSeats.AutoSize = true;
            this.RadioBtn_disableSeats.Enabled = false;
            this.RadioBtn_disableSeats.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioBtn_disableSeats.Location = new System.Drawing.Point(129, 66);
            this.RadioBtn_disableSeats.Margin = new System.Windows.Forms.Padding(2);
            this.RadioBtn_disableSeats.Name = "RadioBtn_disableSeats";
            this.RadioBtn_disableSeats.Size = new System.Drawing.Size(80, 24);
            this.RadioBtn_disableSeats.TabIndex = 1;
            this.RadioBtn_disableSeats.Text = "Disable";
            this.RadioBtn_disableSeats.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_enableSeats
            // 
            this.RadioBtn_enableSeats.AutoSize = true;
            this.RadioBtn_enableSeats.Checked = true;
            this.RadioBtn_enableSeats.Enabled = false;
            this.RadioBtn_enableSeats.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioBtn_enableSeats.Location = new System.Drawing.Point(41, 66);
            this.RadioBtn_enableSeats.Margin = new System.Windows.Forms.Padding(2);
            this.RadioBtn_enableSeats.Name = "RadioBtn_enableSeats";
            this.RadioBtn_enableSeats.Size = new System.Drawing.Size(76, 24);
            this.RadioBtn_enableSeats.TabIndex = 1;
            this.RadioBtn_enableSeats.TabStop = true;
            this.RadioBtn_enableSeats.Text = "Enable";
            this.RadioBtn_enableSeats.UseVisualStyleBackColor = true;
            // 
            // ButtonDisableAll
            // 
            this.ButtonDisableAll.Enabled = false;
            this.ButtonDisableAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonDisableAll.Location = new System.Drawing.Point(69, 126);
            this.ButtonDisableAll.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDisableAll.Name = "ButtonDisableAll";
            this.ButtonDisableAll.Size = new System.Drawing.Size(101, 27);
            this.ButtonDisableAll.TabIndex = 0;
            this.ButtonDisableAll.Text = "Disable All";
            this.ButtonDisableAll.UseVisualStyleBackColor = true;
            this.ButtonDisableAll.Click += new System.EventHandler(this.ButtonDisableAll_Click);
            // 
            // ButtonEnableAll
            // 
            this.ButtonEnableAll.Enabled = false;
            this.ButtonEnableAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonEnableAll.Location = new System.Drawing.Point(69, 94);
            this.ButtonEnableAll.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEnableAll.Name = "ButtonEnableAll";
            this.ButtonEnableAll.Size = new System.Drawing.Size(101, 27);
            this.ButtonEnableAll.TabIndex = 0;
            this.ButtonEnableAll.Text = "Enable All";
            this.ButtonEnableAll.UseVisualStyleBackColor = true;
            this.ButtonEnableAll.Click += new System.EventHandler(this.ButtonEnableAll_Click);
            // 
            // ButtonEditorMode
            // 
            this.ButtonEditorMode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonEditorMode.Location = new System.Drawing.Point(34, 34);
            this.ButtonEditorMode.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEditorMode.Name = "ButtonEditorMode";
            this.ButtonEditorMode.Size = new System.Drawing.Size(173, 27);
            this.ButtonEditorMode.TabIndex = 0;
            this.ButtonEditorMode.Text = "Enter Editor Mode";
            this.ButtonEditorMode.UseVisualStyleBackColor = true;
            this.ButtonEditorMode.Click += new System.EventHandler(this.ButtonEditorMode_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.BackColor = System.Drawing.Color.Silver;
            this.ButtonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonReset.Location = new System.Drawing.Point(35, 748);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(241, 27);
            this.ButtonReset.TabIndex = 7;
            this.ButtonReset.Text = "Reset Simulation";
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonUndo
            // 
            this.ButtonUndo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonUndo.Location = new System.Drawing.Point(59, 60);
            this.ButtonUndo.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonUndo.Name = "ButtonUndo";
            this.ButtonUndo.Size = new System.Drawing.Size(70, 27);
            this.ButtonUndo.TabIndex = 9;
            this.ButtonUndo.Text = "Undo";
            this.ButtonUndo.UseVisualStyleBackColor = true;
            // 
            // ButtonRedo
            // 
            this.ButtonRedo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonRedo.Location = new System.Drawing.Point(168, 60);
            this.ButtonRedo.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonRedo.Name = "ButtonRedo";
            this.ButtonRedo.Size = new System.Drawing.Size(70, 27);
            this.ButtonRedo.TabIndex = 9;
            this.ButtonRedo.Text = "Redo";
            this.ButtonRedo.UseVisualStyleBackColor = true;
            // 
            // ButtonSafeDistance
            // 
            this.ButtonSafeDistance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonSafeDistance.Location = new System.Drawing.Point(21, 274);
            this.ButtonSafeDistance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSafeDistance.Name = "ButtonSafeDistance";
            this.ButtonSafeDistance.Size = new System.Drawing.Size(255, 33);
            this.ButtonSafeDistance.TabIndex = 10;
            this.ButtonSafeDistance.Text = "Setup Safe Distance Mode";
            this.ButtonSafeDistance.UseVisualStyleBackColor = true;
            this.ButtonSafeDistance.Click += new System.EventHandler(this.ButtonSafeDistance_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1539, 911);
            this.Controls.Add(this.ButtonSafeDistance);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.ButtonRedo);
            this.Controls.Add(this.ButtonUndo);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.manualEditor);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonEndSimulation);
            this.Controls.Add(this.ButtonD);
            this.Controls.Add(this.ButtonC);
            this.Controls.Add(this.ButtonB);
            this.Controls.Add(this.ButtonA);
            this.Controls.Add(this.TextBox_MaxSeats);
            this.Controls.Add(this.TextBox_ColDiv);
            this.Controls.Add(this.TextBox_RowDiv);
            this.Controls.Add(this.TextBox_Col);
            this.Controls.Add(this.TextBox_Row);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.ButtonGenerateSeats);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Safe Distance Mode";
            this.manualEditor.ResumeLayout(false);
            this.manualEditor.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_Row;
        private System.Windows.Forms.TextBox TextBox_Col;
        private System.Windows.Forms.TextBox TextBox_RowDiv;
        private System.Windows.Forms.TextBox TextBox_ColDiv;
        private System.Windows.Forms.TextBox TextBox_MaxSeats;
        private System.Windows.Forms.Button ButtonA;
        private System.Windows.Forms.Button ButtonB;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ButtonD;
        private System.Windows.Forms.Button ButtonEndSimulation;
        private System.Windows.Forms.GroupBox manualEditor;
        private System.Windows.Forms.RadioButton RadioBtn_disableSeats;
        private System.Windows.Forms.RadioButton RadioBtn_enableSeats;
        private System.Windows.Forms.Button ButtonDisableAll;
        private System.Windows.Forms.Button ButtonEnableAll;
        private System.Windows.Forms.Button ButtonEditorMode;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonUndo;
        private System.Windows.Forms.Button ButtonRedo;
        private System.Windows.Forms.Label screen;
        private System.Windows.Forms.Button ButtonSafeDistance;
    }
}
