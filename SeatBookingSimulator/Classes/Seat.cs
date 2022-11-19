/*
Class: DIT/FT/2B21
Admission Number: P2129187
Name: Jaziel Robin Premraj
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SeatBookingSimulator.Classes
{
    [Serializable]
    internal class Seat
    {
        //This property is used to describe whether the seat "has been selected"
        private bool _bookStatus = false;
        //This property is used to describe that the seat is not bookable at all
        private bool _canBook = false;
        // The _row field is 2 if the object is modelling a seat at row "B".
        private int _row;
        // _column field is 3 if the object is modelling a seat at column 3.
        private int _column;
        private string _person;

        public int Row
        {
            get { return _row; }
            set { _row = value; }
        }
        public int Column
        {
            get { return _column; }
            set { _column = value; }
        }
        public bool CanBook
        {
            get { return _canBook; }
            set { _canBook = value; }
        }
        public bool BookStatus
        {
            get { return _bookStatus; }
            set { _bookStatus = value; }
        }
        public string BookByPerson
        {
            get { return _person; }
            set { _person = value; }
        }
        //ComputeSeatLabel is a method defined inside the Seat class
        //ComputeSeatLabel is "not" a property.
        public string ComputeSeatLabel()
        {
            return ((char)(_row + 64)).ToString() + _column.ToString();
        }//End of ComputeSeatLabel

        public Label GenerateLabel()
        {
            Label labelSeat = new Label();//Instantiate a new Label type object, labelSeat
            labelSeat.Text = this.ComputeSeatLabel();//Set the Text property by using a string
            labelSeat.Location = new Point((60 * (this.Column - 1)) + 60 + (20 * (this.Column - 1)), (60 * (this.Row - 1)) + 60 + (20 * (this.Row - 1)));//Create a Point type object which has x,y coordinate info
            labelSeat.Size = new Size(60, 60);//Create a Size type object which has the width, height info
            labelSeat.TextAlign = ContentAlignment.MiddleCenter;//Align the Text to mid - center
            labelSeat.BorderStyle = BorderStyle.FixedSingle;//Make the border visible
            labelSeat.BackColor = Color.LightBlue;//Set the background color
            labelSeat.Font = new Font("Calibri", 14, FontStyle.Bold);
            labelSeat.ForeColor = Color.Black;
            labelSeat.Tag = new SeatInfo() { Row = this.Row, Column = this.Column };
            labelSeat.BackColor = Color.LightBlue;
            if (this.BookStatus == true)
            {
                labelSeat.BackColor = Color.LightGreen;
            }
            return labelSeat;
        }//End of GenerateLabel
    }//end of Seat class
}//end of Namespace
