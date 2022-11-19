/*
Class: DIT/FT/2B21
Admission Number: P2129187
Name: Jaziel Robin Premraj
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace SeatBookingSimulator.Classes
{
    [Serializable]
    internal class Global
    {
        public SeatDoubleLinkedList seatList { get; set; }
        public List<int> personSeatList { get; set; }
        public List<int> personMaxList { get; set; }
        public string row { get; set; }
        public string col { get; set; }
        public string rowDivider { get; set; }
        public string colDivider { get; set; }
        public int maxSeats { get; set; }
        public string personBooking { get; set; }

        public Global()
        {
            seatList = new SeatDoubleLinkedList();
            personSeatList = new List<int> { 0, 0, 0, 0 };
            personMaxList = new List<int> { 0, 0, 0, 0 };
        }//End of constructor
    }//End of class
}//End of namespace
