//Grading ID: S6889
//Assignment: Program #1
//Due Date: 11 Feb 20
//Course Section: CIS199-75 Spring 2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //event handler for the user to calculate the flooring estimate via button
        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double SQUARE_FEET = 9.0,  //constant for dividing square feet to get square yards
                         WASTE = 0.1,  //constant for adding 10% to the estimate
                         PADDING = 2.50,  //constant for the price of padding
                         LABOR = 4.25,  //constant for the price of labor
                         FIRST_ROOM = 75.00;  //constant for the first room fee
            double width = double.Parse(widthTextBox.Text),  //variable for the user-entered room width assigned widthTextBox value
                   length = double.Parse(lengthTextBox.Text),  //variable for the user-entered room length assigned lengthTextBox value
                   carpet = double.Parse(carpetPriceTextBox.Text),  //variable for the user-entered carpet cost assignedCarpetPriceTextBox value
                   squareYards,  //variable to hold the size of the room in yards
                   carpetCost,  //variable for the carpet cost
                   paddingCost,  //variable for the padding cost
                   laborCost,  //variable for the labor cost
                   totalCost;  //variable for the total cost
            int padding = int.Parse(paddingTextBox.Text),  //variable for the user-entered layers of padding
                firstRoom = int.Parse(firstRoomTextBox.Text);  //variable for whether this is the first room in the estimate

            //determine the room size in square yards
            squareYards = (width * length) / SQUARE_FEET;

            //determine the carpet cost
            carpetCost = (squareYards * carpet) + ((squareYards * carpet) * WASTE);

            //determine the padding cost
            paddingCost = (squareYards * PADDING) + ((squareYards * PADDING) * WASTE);

            //determine the labor cost
            if (firstRoom == 0)
                laborCost = squareYards * LABOR;
            else
                laborCost = (squareYards * LABOR) + FIRST_ROOM;

            //calculate the total cost
            totalCost = carpetCost + paddingCost + laborCost;

            //display the results to the user in each output label
            yardsOutputLabel.Text = $"{squareYards:f1}";
            carpetOutputLabel.Text = $"{carpetCost:c}";
            paddingOutputLabel.Text = $"{paddingCost:c}";
            laborOutputLabel.Text = $"{laborCost:c}";
            totalOutputLabel.Text = $"{totalCost:c}";
        }
    }
}
