/*
Class: DIT/FT/2B21
Admission Number: P2129187
Name: Jaziel Robin Premraj
*/
using SeatBookingSimulator.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SeatBookingSimulator
{
    public partial class Form1 : Form
    {
        // Class scope variables
        Global global = new Global();
        Color personColor;
        string personBooking = "";
        int personBookingNum = -1;
        bool isEditorMode = false;

        // Generate Form1
        public Form1()
        {
            InitializeComponent();
            TextBox_MaxSeats.BackColor = Color.DarkGray;
            if (panelSeats.Controls.Count == 0)
            {
                ButtonEditorMode.Enabled = false;
            }
            else
            {
                ButtonEditorMode.Enabled = true;
            }
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {

            string filePath;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\..\\..\\Data"));
            openFileDialog.Filter = "Data Files (*.dat)|*.dat";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                BinaryFormatter f = new BinaryFormatter();
                Stream stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);

                if (stream.Length != 0)
                {
                    global = (Global)f.Deserialize(stream);
                }
                stream.Close();
            }

            TextBox_RowDiv.Text = global.rowDivider;
            TextBox_ColDiv.Text = global.colDivider;
            TextBox_Row.Text = global.row;
            TextBox_Col.Text = global.col;
            TextBox_MaxSeats.Text = (global.maxSeats).ToString();
            TextBox_MaxSeats.Enabled = true;
            LabelMessage.Text = global.personBooking;
            GenerateSeatsFromGlobalClass();
            foreach (Control c in this.panelSeats.Controls)
            {
                Label label = (Label)c;
                SeatInfo seatInfo = (SeatInfo)label.Tag;
                Seat seat = global.seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column);
                if (seat != null && seat.BookStatus == true)
                {
                    if (seat.BookByPerson == "A")
                    {
                        c.BackColor = ButtonA.BackColor;
                    }
                    else if (seat.BookByPerson == "B")
                    {
                        c.BackColor = ButtonB.BackColor;
                    }
                    else if (seat.BookByPerson == "C")
                    {
                        c.BackColor = ButtonC.BackColor;
                    }
                    else if (seat.BookByPerson == "D")
                    {
                        c.BackColor = ButtonD.BackColor;
                    }

                    continue;
                }

                if (seat.CanBook)
                {
                    c.BackColor = Color.LightGray;
                }
                else
                {
                    c.BackColor = Color.LightPink;
                }
            }
        }//End of buttonLoad_Click

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\..\\..\\Data"));
            saveFileDialog.Filter = "Data Files (*.dat)|*.dat";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    BinaryFormatter f = new BinaryFormatter();
                    f.Serialize(stream, global);
                    stream.Close();
                }
            }
        }//End of buttonSave_Click

        public void GenerateSeats(object sender, EventArgs e)
        {
            global.seatList = new SeatDoubleLinkedList();
            this.panelSeats.Controls.Clear();
            if (TextBox_Row.Text == "" || TextBox_Col.Text == "")
            {
                MessageBox.Show("Input for row and column cannot be empty!");
                ButtonEditorMode.Enabled = false;
                return;
            }
            Int32 row = 0;
            Int32 col = 0;
            try
            {
                row = Convert.ToInt32(TextBox_Row.Text);
                col = Convert.ToInt32(TextBox_Col.Text);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Input for row and column must be integers!");
                return;
            }
            string dividerRow = TextBox_RowDiv.Text;
            string dividerCol = TextBox_ColDiv.Text;
            string[] divRowList = new string[0];
            string[] divColList = new string[0];

            if (dividerRow != "")
            {
                divRowList = dividerRow.Split(",");
            }
            if (dividerCol != "")
            {
                divColList = dividerCol.Split(",");
            }

            Int32 x, y;
            int seatWidth = 50;
            int seatHeight = 50;
            int divRowIndex = -1;
            int rowShifted = 0;

            if (divRowList.Length > 0)
            {
                divRowIndex = 0;
            }

            for (x = 1; x <= row; x++)
            {
                int divColIndex = -1;
                int colShifted = 0;
                if (divRowList.Length > 0 && divRowIndex < divRowList.Length)
                {
                    try
                    {
                        if (x == Convert.ToInt32(divRowList[divRowIndex]) + 1)
                        {
                            rowShifted++;
                            divRowIndex++;
                        }
                    }
                    catch (FormatException er)
                    {
                        Console.WriteLine(er.Message);
                        MessageBox.Show("Input for row and column dividers cannot be string!");
                        return;
                    }
                }
                if (divColList.Length > 0)
                {
                    divColIndex = 0;
                }
                for (y = 1; y <= col; y++)
                {
                    if (divColList.Length > 0 && divColIndex < divColList.Length)
                    {
                        try
                        {
                            if (y == Convert.ToInt32(divColList[divColIndex]) + 1)
                            {
                                colShifted++;
                                divColIndex++;
                            }
                        }
                        catch (FormatException exception)
                        {
                            Console.WriteLine(exception.Message);
                            MessageBox.Show("Input for row and column dividers cannot be string!");
                            return;
                        }
                    }
                    Label labelSeat = new Label()
                    {
                        Width = seatWidth,
                        Height = seatHeight,
                        Top = (x * (seatHeight + 15) + rowShifted * seatHeight),
                        Left = (y * (seatWidth + 15) + colShifted * seatWidth),
                        BackColor = Color.LightPink
                    };
                    Seat seat = new Seat();
                    seat.Row = x;
                    seat.Column = y;
                    seat.BookByPerson = "";
                    seat.CanBook = true;
                    labelSeat.Click += new System.EventHandler(LabelSeat_Click);
                    labelSeat.Text = seat.ComputeSeatLabel();
                    labelSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    labelSeat.Tag = new SeatInfo() { Row = x, Column = y };
                    labelSeat.Enabled = false;
                    global.seatList.InsertAtEnd(seat);
                    this.panelSeats.Controls.Add(labelSeat);
                };
            }
            ButtonEditorMode.Enabled = true;
        }//End of GenerateSeats

        public void GenerateSeatsFromGlobalClass()
        {
            this.panelSeats.Controls.Clear();
            if (TextBox_Row.Text == "" || TextBox_Col.Text == "")
            {
                return;
            }
            Int32 row = Convert.ToInt32(TextBox_Row.Text);
            Int32 col = Convert.ToInt32(TextBox_Col.Text);
            string dividerRow = TextBox_RowDiv.Text;
            string dividerCol = TextBox_ColDiv.Text;
            string[] divRowList = new string[0];
            string[] divColList = new string[0];
            if (dividerRow != "")
            {
                divRowList = dividerRow.Split(",");
            }
            if (dividerCol != "")
            {
                divColList = dividerCol.Split(",");
            }

            Int32 x, y;
            int seatWidth = 50;
            int seatHeight = 50;
            int divRowIndex = -1;
            int rowShifted = 0;

            if (divRowList.Length > 0)
            {
                divRowIndex = 0;
            }

            for (x = 1; x <= row; x++)
            {
                int divColIndex = -1;
                int colShifted = 0;
                if (divRowList.Length > 0 && divRowIndex < divRowList.Length)
                {
                    if (x == Convert.ToInt32(divRowList[divRowIndex]) + 1)
                    {
                        rowShifted++;
                        divRowIndex++;
                    }
                }
                if (divColList.Length > 0)
                {
                    divColIndex = 0;
                }
                for (y = 1; y <= col; y++)
                {
                    if (divColList.Length > 0 && divColIndex < divColList.Length)
                    {
                        if (y == Convert.ToInt32(divColList[divColIndex]) + 1)
                        {
                            colShifted++;
                            divColIndex++;
                        }
                    }
                    Label labelSeat = new Label()
                    {
                        Width = seatWidth,
                        Height = seatHeight,
                        Top = (x * (seatHeight + 15) + rowShifted * seatHeight),
                        Left = (y * (seatWidth + 15) + colShifted * seatWidth),
                        BackColor = Color.LightPink
                    };
                    Seat seat = global.seatList.SearchByRowAndColumn(x, y);
                    labelSeat.Click += new System.EventHandler(LabelSeat_Click);
                    labelSeat.Text = seat.ComputeSeatLabel();
                    labelSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    labelSeat.Tag = new SeatInfo() { Row = x, Column = y };
                    labelSeat.Enabled = false;
                    this.panelSeats.Controls.Add(labelSeat);
                };
            }
        }//End of GenerateSeatsFromGlobalClass

        private void LabelSeat_Click(object sender, EventArgs e)
        {
            if (isEditorMode)
            {
                Label label2 = (Label)sender;
                SeatInfo seatInfo2 = (SeatInfo)label2.Tag;
                Seat seat2 = global.seatList.SearchByRowAndColumn(seatInfo2.Row, seatInfo2.Column);
                if (seat2.BookStatus)
                {
                    MessageBox.Show("Cannnot enable/disable seat that is taken.");
                    return;
                }

                seat2.CanBook = RadioBtn_enableSeats.Checked;
                if (seat2.CanBook)
                {
                    label2.BackColor = Color.LightGray;
                }
                else
                {
                    label2.BackColor = Color.LightPink;
                }
                return;
            }

            if (personBooking == "")
            {
                return;
            }

            string maxSeatsStr = TextBox_MaxSeats.Text;
            if (maxSeatsStr == "")
            {
                MessageBox.Show("Please set a maximum number of seats first.");
                return;
            }

            Int32 maxSeats;
            try
            {
                maxSeats = Convert.ToInt32(maxSeatsStr);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Max seats cannot be a string!");
                return;
            }
            Label label = (Label)sender;
            SeatInfo seatInfo = (SeatInfo)label.Tag;
            //MessageBox.Show(String.Format("Row {0} Column {1}",seatInfo.Row,seatInfo.Column));
            Seat seat = global.seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column);
            if (seat.CanBook == false)
            {
                MessageBox.Show("Seat is disabled!");
                return;
            }

            if (seat.BookStatus == true && seat.BookByPerson != personBooking)
            {
                MessageBox.Show($"Seat is taken by Person {seat.BookByPerson}.");
                return;
            }

            if (seat.BookStatus == false)
            {
                if (global.personSeatList[personBookingNum] + 1 > maxSeats)
                {
                    MessageBox.Show("Max seats selected!");
                    return;
                }

                int seatSelected = global.personSeatList[personBookingNum];
                if (seatSelected > 0)
                {
                    Seat leftSeat = global.seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column - 1);
                    Seat rightSeat = global.seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column + 1);
                    bool isLeftSeatByPerson = false;
                    if (leftSeat != null && leftSeat.BookByPerson == personBooking)
                    {
                        isLeftSeatByPerson = true;
                    }
                    bool isRightSeatByPerson = false;
                    if (rightSeat != null && rightSeat.BookByPerson == personBooking)
                    {
                        isRightSeatByPerson = true;
                    }
                    if (isRightSeatByPerson == false && isLeftSeatByPerson == false)
                    {
                        MessageBox.Show("You may only book adjacent seats!");
                        return;
                    }
                }

                seat.BookStatus = true;
                label.BackColor = personColor;
                seat.BookByPerson = personBooking;
                global.personSeatList[personBookingNum] += 1;
            }
            else
            {
                int seatSelected = global.personSeatList[personBookingNum];
                if (seatSelected > 0)
                {
                    Seat leftSeat = global.seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column - 1);
                    Seat rightSeat = global.seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column + 1);
                    bool isLeftSeatByPerson = false;
                    if (leftSeat != null && leftSeat.BookByPerson == personBooking)
                    {
                        isLeftSeatByPerson = true;
                    }
                    bool isRightSeatByPerson = false;
                    if (rightSeat != null && rightSeat.BookByPerson == personBooking)
                    {
                        isRightSeatByPerson = true;
                    }
                    if (isRightSeatByPerson == true && isLeftSeatByPerson == true)
                    {
                        MessageBox.Show("You may only book adjacent seats!");
                        return;
                    }
                }
                seat.BookStatus = false;
                label.BackColor = Color.LightGray;
                seat.BookByPerson = "";
                global.personSeatList[personBookingNum] -= 1;
            }
        }//End of LabelSeat_Click

        private void DisableSelectedSeats()
        {
            TextBox_MaxSeats.Enabled = false;
            TextBox_MaxSeats.BackColor = Color.DarkGray;
            foreach (Control c in this.panelSeats.Controls)
            {
                Label label = (Label)c;
                SeatInfo seatInfo = (SeatInfo)label.Tag;
                Seat seat = global.seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column);
                c.Enabled = false;
                if (seat != null && seat.BookStatus == true)
                {
                    c.BackColor = Color.LightPink; // here
                }
            }
        }//End of DisableSelectedSeats

        private void EnableAllSeats()
        {
            TextBox_MaxSeats.Enabled = true;
            TextBox_MaxSeats.BackColor = Color.LightGray;
            foreach (Control c in this.panelSeats.Controls)
            {
                Label label = (Label)c;
                SeatInfo seatInfo = (SeatInfo)label.Tag;
                Seat seat = global.seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column);
                c.Enabled = true;
                if (seat != null && seat.BookStatus == true)
                {
                    continue;
                }

                if (seat.CanBook)
                {
                    c.BackColor = Color.LightGray;
                }
                else
                {
                    c.BackColor = Color.LightPink;
                }
            }
        }//End of EnableAllSeats

        private void ButtonA_Click(object sender, EventArgs e)
        {
            DisableSelectedSeats();
            DisableEditor();
            Button buttonA = (Button)sender;
            LabelMessage.Text = ("Person A is booking now");
            TextBox_MaxSeats.BackColor = Color.LightGray;
            EnableAllSeats();
            personBooking = "A";
            personBookingNum = 0;
            personColor = buttonA.BackColor;
            if (panelSeats.Controls.Count == 0)
            {
                MessageBox.Show("Please generate seats using the above form before booking.");
                TextBox_MaxSeats.Enabled = false;
                TextBox_MaxSeats.BackColor = Color.DarkGray;
                return;
            }
            if (global.personBooking == "A")
            {
                buttonA.Enabled = true;
            }
            else
            {
                buttonA.Enabled = false;
            }
            UpdateMaxSeats();
        }//End of ButtonA_Click

        private void ButtonB_Click(object sender, EventArgs e)
        {
            DisableSelectedSeats();
            DisableEditor();
            Button buttonB = (Button)sender;
            LabelMessage.Text = ("Person B is booking now");
            TextBox_MaxSeats.BackColor = Color.LightGray;
            EnableAllSeats();
            personBooking = "B";
            personBookingNum = 1;
            personColor = buttonB.BackColor;
            if (panelSeats.Controls.Count == 0)
            {
                MessageBox.Show("Please generate seats using the above form before booking.");
                TextBox_MaxSeats.Enabled = false;
                TextBox_MaxSeats.BackColor = Color.DarkGray;
                return;
            }
            if (global.personBooking == "B")
            {
                buttonB.Enabled = true;
            }
            else
            {
                buttonB.Enabled = false;
            }
            UpdateMaxSeats();
        }//End of ButtonB_Click

        private void ButtonC_Click(object sender, EventArgs e)
        {
            DisableSelectedSeats();
            DisableEditor();
            Button buttonC = (Button)sender;
            LabelMessage.Text = ("Person C is booking now");
            TextBox_MaxSeats.BackColor = Color.LightGray;
            EnableAllSeats();
            personBooking = "C";
            personBookingNum = 2;
            personColor = buttonC.BackColor;
            if (panelSeats.Controls.Count == 0)
            {
                MessageBox.Show("Please generate seats using the above form before booking.");
                TextBox_MaxSeats.Enabled = false;
                TextBox_MaxSeats.BackColor = Color.DarkGray;
                return;
            }
            if (global.personBooking == "C")
            {
                buttonC.Enabled = true;
            }
            else
            {
                buttonC.Enabled = false;
            }
            UpdateMaxSeats();
        }//End of ButtonC_Click

        private void ButtonD_Click(object sender, EventArgs e)
        {
            DisableSelectedSeats();
            DisableEditor();
            Button buttonD = (Button)sender;
            LabelMessage.Text = ("Person D is booking now");
            TextBox_MaxSeats.BackColor = Color.LightGray;
            EnableAllSeats();
            personBooking = "D";
            personBookingNum = 3;
            personColor = buttonD.BackColor;
            if (panelSeats.Controls.Count == 0)
            {
                MessageBox.Show("Please generate seats using the form above before booking.");
                TextBox_MaxSeats.Enabled = false;
                TextBox_MaxSeats.BackColor = Color.DarkGray;
                return;
            }
            if (global.personBooking == "D")
            {
                buttonD.Enabled = true;
            }
            else
            {
                buttonD.Enabled = false;
            }
            UpdateMaxSeats();
        }//End of ButtonD_Click

        private void UpdateMaxSeats()
        {
            if (global.personSeatList[personBookingNum] > 0)
            {
                TextBox_MaxSeats.Text = global.personSeatList[personBookingNum].ToString();
            }
            else
            {
                TextBox_MaxSeats.Text = "";
            }
        }//End of UpdateMaxSeats

        private void DisableEditor()
        {
            ButtonEditorMode.Enabled = false;
            RadioBtn_enableSeats.Enabled = false;
            RadioBtn_disableSeats.Enabled = false;
            ButtonEnableAll.Enabled = false;
            ButtonDisableAll.Enabled = false;
        }//End of DisableEditor

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simulation Reset!");
            personBookingNum = -1;
            personBooking = "";
            ButtonA.Enabled = true;
            ButtonA.Text = ("Person A Booking");
            ButtonB.Enabled = true;
            ButtonB.Text = ("Person B Booking");
            ButtonC.Enabled = true;
            ButtonC.Text = ("Person C Booking");
            ButtonD.Enabled = true;
            ButtonD.Text = ("Person D Booking");
            TextBox_MaxSeats.BackColor = Color.DarkGray;
            TextBox_MaxSeats.Enabled = false;
            global.personSeatList = new List<int> { 0, 0, 0, 0 };
            global.personMaxList = new List<int> { 0, 0, 0, 0 };
            GenerateSeats(sender, e);
            ButtonEditorMode.Enabled = true;
            RadioBtn_enableSeats.Enabled = false;
            RadioBtn_disableSeats.Enabled = false;
            ButtonEnableAll.Enabled = false;
            ButtonDisableAll.Enabled = false;
            LabelMessage.Text = "";
        }//End of buttonReset_Click

        private void ButtonEditorMode_Click(object sender, EventArgs e)
        {
            Button editorButton = (Button)sender;
            if (!isEditorMode)
            {
                editorButton.Text = "Exit Editor Mode";
                LabelMessage.Text = ("Seat editor enabled");
                RadioBtn_enableSeats.Enabled = true;
                RadioBtn_disableSeats.Enabled = true;
                ButtonEnableAll.Enabled = true;
                ButtonDisableAll.Enabled = true;
                isEditorMode = true;
                EnableAllSeats();
            }
            else
            {
                editorButton.Text = "Enter Editor Mode";
                RadioBtn_enableSeats.Enabled = false;
                RadioBtn_disableSeats.Enabled = false;
                ButtonEnableAll.Enabled = false;
                ButtonDisableAll.Enabled = false;
                isEditorMode = false;
            }
        }//End of ButtonEditorMode_Click

        private void ButtonEndSimulation_Click(object sender, EventArgs e)
        {
            DisableSelectedSeats();
            personBookingNum = -1;
            personBooking = "";
            TextBox_MaxSeats.Text = "";
            TextBox_MaxSeats.Enabled = false;
            ButtonA.Enabled = false;
            ButtonA.Text = ("Person A finished booking!");
            ButtonB.Enabled = false;
            ButtonB.Text = ("Person B finished booking!");
            ButtonC.Enabled = false;
            ButtonC.Text = ("Person C finished booking!");
            ButtonD.Enabled = false;
            ButtonD.Text = ("Person D finished booking!");
            LabelMessage.Text = "Simulation Ended. Reset Simulation to restart.";
            MessageBox.Show("Simulation Ended.");
        }//End of buttonEndSimulation_Click

        private void ButtonEnableAll_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.panelSeats.Controls)
            {
                Label label = (Label)c;
                SeatInfo seatInfo = (SeatInfo)label.Tag;
                Seat seat = global.seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column);
                if (seat.BookStatus == false)
                {
                    seat.CanBook = true;
                    c.BackColor = Color.LightGray;

                }
            }
            //EnableAllSeats();
        }//End of ButtonEnableAll_Click

        private void ButtonDisableAll_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.panelSeats.Controls)
            {
                Label label = (Label)c;
                SeatInfo seatInfo = (SeatInfo)label.Tag;
                Seat seat = global.seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column);
                if (seat.BookStatus == false)
                {
                    seat.CanBook = false;
                    c.BackColor = Color.LightPink;

                }
            }
        }//End of ButtonDisableAll_Click

        private void MaxSeatsChanged(object sender, EventArgs e)
        {
            if (personBookingNum > -1)
            {
                if (TextBox_MaxSeats.Text != "")
                {
                    Int32 maxSeats = 0;
                    try
                    {
                        maxSeats = Convert.ToInt32(TextBox_MaxSeats.Text);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    global.maxSeats = maxSeats;
                    int personMaxSeat = global.personMaxList[personBookingNum];
                    int seatCreated = global.personSeatList[personBookingNum];
                    if (seatCreated <= maxSeats)
                    {
                        global.personMaxList[personBookingNum] = maxSeats;
                    }
                    else
                    {
                        MessageBox.Show("Selected seats are more than max seats, unselect your seats first.");
                        TextBox_MaxSeats.Text = $"{personMaxSeat}";
                    }
                }
            }
        }//End of MaxSeatsChanged

        private void TextBox_Row_TextChanged(object sender, EventArgs e)
        {
            global.row = ((TextBox)sender).Text;
        }//End of textBox_Row_TextChanged

        private void TextBox_Col_TextChanged(object sender, EventArgs e)
        {
            global.col = ((TextBox)sender).Text;
        }//End of textBox_Col_TextChanged

        private void TextBox_RowDiv_TextChanged(object sender, EventArgs e)
        {
            global.rowDivider = ((TextBox)sender).Text;
        }//End of textBox_RowDiv_TextChanged

        private void TextBox_ColDiv_TextChanged(object sender, EventArgs e)
        {
            global.colDivider = ((TextBox)sender).Text;
        }//End of textBox_ColDiv_TextChanged

        private void LabelMessage_TextChanged(object sender, EventArgs e)
        {
            global.personBooking = ((Label)sender).Text;
        }//End of labelMessage_TextChanged
    }//End of Form1 class
}//End of namespace
