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
    public partial class Form3 : Form
    {
        // Class scope variables
        Global global = new Global();
        Color personColor;
        string personBooking = "";
        int personBookingNum = -1;

        // Generate Form3
        public Form3()
        {
            InitializeComponent();
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
        }//End of ButtonLoad_Click

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
        }//End of ButtonSave_Click

        public void GenerateSeats(object sender, EventArgs e)
        {
            global.seatList = new SeatDoubleLinkedList();
            this.panelSeats.Controls.Clear();
            if (TextBox_Row.Text == "" || TextBox_Col.Text == "")
            {
                MessageBox.Show("Input for row and column cannot be empty!");
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

            int x, y;
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
            if (personBooking == "")
            {
                return;
            }

            Label label = (Label)sender;
            SeatInfo seatInfo = (SeatInfo)label.Tag;
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

                int seatSelected = global.personSeatList[personBookingNum];
                Seat leftSeat = global.seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column - 1);
                Seat rightSeat = global.seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column + 1);
                Seat frontSeat = global.seatList.SearchByRowAndColumn(seatInfo.Row - 1, seatInfo.Column);
                Seat backSeat = global.seatList.SearchByRowAndColumn(seatInfo.Row + 1, seatInfo.Column);

                if (seatSelected > 0)
                {
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
                        bool isFrontSeatByPerson = false;
                        if (frontSeat != null && frontSeat.BookByPerson == personBooking)
                        {
                            isFrontSeatByPerson = true;
                        }
                        bool isBackSeatByPerson = false;
                        if (backSeat != null && backSeat.BookByPerson == personBooking)
                        {
                            isBackSeatByPerson = true;
                        }
                        if (isFrontSeatByPerson == false && isBackSeatByPerson == false)
                        {
                            MessageBox.Show("You can only book/unbook adjacent seats!");
                            return;
                        }
                    }
                }
                else
                {
                    if (leftSeat != null && leftSeat.BookStatus == true && leftSeat.BookByPerson != personBooking)
                    {
                        MessageBox.Show("You cannot choose a seat which is adjacent to another seat booked by another person!");
                        return;
                    }
                    else if (rightSeat != null && rightSeat.BookStatus == true && rightSeat.BookByPerson != personBooking)
                    {
                        MessageBox.Show("You cannot choose a seat which is adjacent to another seat booked by another person!");
                        return;
                    }
                    else if (frontSeat != null && frontSeat.BookStatus == true && frontSeat.BookByPerson != personBooking)
                    {
                        MessageBox.Show("You cannot choose a seat which is adjacent to another seat booked by another person!");
                        return;
                    }
                    else if (backSeat != null && backSeat.BookStatus == true && backSeat.BookByPerson != personBooking)
                    {
                        MessageBox.Show("You cannot choose a seat which is adjacent to another seat booked by another person!");
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
                        MessageBox.Show("You can only book/unbook adjacent seats!");
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
            foreach (Control c in this.panelSeats.Controls)
            {
                Label label = (Label)c;
                SeatInfo seatInfo = (SeatInfo)label.Tag;
                Seat seat = global.seatList.SearchByRowAndColumn(seatInfo.Row, seatInfo.Column);

                c.Enabled = false;
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
            }
        }//End of DisableSelectedSeats

        private void EnableAllSeats()
        {
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

        private void DisableSurroundingSeats()
        {
            Int32 row = Convert.ToInt32(TextBox_Row.Text);
            Int32 col = Convert.ToInt32(TextBox_Col.Text);
            for (int x = 1; x <= row; x++)
            {
                for (int y = 1; y <= col; y++)
                {
                    Seat seat = global.seatList.SearchByRowAndColumn(x, y);

                    if (seat != null && seat.BookStatus == true)
                    {
                        Seat frontSeat = global.seatList.SearchByRowAndColumn(x - 1, y);
                        Seat backSeat = global.seatList.SearchByRowAndColumn(x + 1, y);
                        Seat leftSeat = global.seatList.SearchByRowAndColumn(x, y - 1);
                        Seat rightSeat = global.seatList.SearchByRowAndColumn(x, y + 1);
                        if (frontSeat != null && frontSeat.BookStatus == false)
                        {
                            frontSeat.CanBook = false;
                        }
                        if (backSeat != null && backSeat.BookStatus == false)
                        {
                            backSeat.CanBook = false;
                        }
                        if (leftSeat != null && leftSeat.BookStatus == false)
                        {
                            leftSeat.CanBook = false;
                        }
                        if (rightSeat != null && rightSeat.BookStatus == false)
                        {
                            rightSeat.CanBook = false;
                        }
                    }
                }
            }
        }

        private void ButtonA_Click(object sender, EventArgs e)
        {
            DisableSelectedSeats();
            DisableSurroundingSeats();
            Button buttonA = (Button)sender;
            LabelMessage.Text = ("Person A is booking now");
            EnableAllSeats();
            personBooking = "A";
            personBookingNum = 0;
            personColor = buttonA.BackColor;
            if (panelSeats.Controls.Count == 0)
            {
                MessageBox.Show("Please generate seats using the above form before booking.");
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
        }//End of ButtonA_Click

        private void ButtonB_Click(object sender, EventArgs e)
        {
            DisableSelectedSeats();
            DisableSurroundingSeats();
            Button buttonB = (Button)sender;
            LabelMessage.Text = ("Person B is booking now");
            EnableAllSeats();
            personBooking = "B";
            personBookingNum = 1;
            personColor = buttonB.BackColor;
            if (panelSeats.Controls.Count == 0)
            {
                MessageBox.Show("Please generate seats using the above form before booking.");
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
        }//End of ButtonB_Click

        private void ButtonC_Click(object sender, EventArgs e)
        {
            DisableSelectedSeats();
            DisableSurroundingSeats();
            Button buttonC = (Button)sender;
            LabelMessage.Text = ("Person C is booking now");
            EnableAllSeats();
            personBooking = "C";
            personBookingNum = 2;
            personColor = buttonC.BackColor;
            if (panelSeats.Controls.Count == 0)
            {
                MessageBox.Show("Please generate seats using the above form before booking.");
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
        }//End of ButtonC_Click

        private void ButtonD_Click(object sender, EventArgs e)
        {
            DisableSelectedSeats();
            DisableSurroundingSeats();
            Button buttonD = (Button)sender;
            LabelMessage.Text = ("Person D is booking now");
            EnableAllSeats();
            personBooking = "D";
            personBookingNum = 3;
            personColor = buttonD.BackColor;
            if (panelSeats.Controls.Count == 0)
            {
                MessageBox.Show("Please generate seats using the form above before booking.");
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
        }//End of ButtonD_Click

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
            LabelMessage.Text = "";
            global.personSeatList = new List<int> { 0, 0, 0, 0 };
            global.personMaxList = new List<int> { 0, 0, 0, 0 };
            GenerateSeats(sender, e);
        }//End of ButtonReset_Click

        private void ButtonEndSimulation_Click(object sender, EventArgs e)
        {
            DisableSelectedSeats();
            personBookingNum = -1;
            personBooking = "";
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
        }//End of ButtonEndSimulation_Click

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
    }//End of Form3 class
}//End of namespace
