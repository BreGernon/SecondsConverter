namespace SecondsTo
{
    // Breanna Gernon
    // CST-150
    // November 13, 2022
    // I used source code from the our textbook to guide my 
    // TryParse and MessageBoxes.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Set up variables needed, reset the time boxes to zero
            int userInt;
            int timeInt = 0;
            minutesBox.Text = timeInt.ToString();
            hoursBox.Text = timeInt.ToString();
            daysBox.Text = timeInt.ToString();

            //Ensures text is an integer
            if (int.TryParse(userText.Text, out userInt))
            {
                //Reaches this if the integer is less than
                //60 and won't enter the loop.
                if (userInt < 60)
                {
                    MessageBox.Show("Enter a valid integer.");
                }

                //Loops through the number provided to take all seconds
                //into consideration.
                while (userInt > 60)
                {
                    //Sets the minutes box, then empties the userInt
                    //integer so the loop ends.
                    if (userInt >= 60 && userInt < 3600)
                    {
                        timeInt= userInt/60;
                        minutesBox.Text = timeInt.ToString();
                        userInt -= userInt;
                    }

                    //Sets the hours box, then reduces the userInt
                    //integer to continue the loop.
                    else if (userInt >= 3600 && userInt < 86400 )
                    {
                        timeInt = userInt/3600;
                        hoursBox.Text= timeInt.ToString();
                        userInt = userInt % 3600;
                    }

                    //Sets the days box, then reduces the userInt
                    //integer to continue the loop.
                    else if (userInt >= 86400)
                    {
                        timeInt = userInt / 86400;
                        daysBox.Text = timeInt.ToString();
                        userInt = userInt % 86400;
                    }


                }

            }

            //Displays when the item typed is not an integer-
            //enters this if textbox holds double, String, or
            //other objects.
            else
            {
                MessageBox.Show("Enter a valid number.");
            }


        }
    }
}