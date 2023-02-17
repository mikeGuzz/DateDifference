using System.Xml.Serialization;

namespace DateDifference
{
    public partial class Form1 : Form
    {
        public class Order
        {
            public DateTime First { get; set; }
            public DateTime Second { get; set; }

            public Order() { }
            public Order(DateTime first, DateTime second)
            {
                this.First = first;
                this.Second = second;
            }
        }

        private static readonly string SaveFilePath = @"last.xml";

        public Form1()
        {
            InitializeComponent();

            // try load data
            while (true)
            {
                try
                {
                    if (!File.Exists(SaveFilePath))
                        break;
                    XmlSerializer serializer = new XmlSerializer(typeof(Order));
                    using(Stream stream = File.OpenRead(SaveFilePath))
                    {
                        var ob = serializer.Deserialize(stream);
                        if(ob is Order order)
                        {
                            day1_numeric.Value = order.First.Day;
                            day2_numeric.Value = order.Second.Day;

                            month1_numeric.Value = order.First.Month;
                            month2_numeric.Value = order.Second.Month;

                            year1_numeric.Value = order.First.Year;
                            year2_numeric.Value = order.Second.Year;
                        }
                        else
                        {
                            MessageBox.Show("Data is corrupted", "Fatal error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            stream.Dispose();
                            File.Delete(SaveFilePath);
                            Application.Exit();
                        }
                    }
                    break;
                }
                catch (Exception e)
                {
                    var res = MessageBox.Show(e.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (res == DialogResult.Cancel)
                        break;
                }
            }
        }

        private DateTime DateTimeFromNumeric(NumericUpDown day, NumericUpDown month, NumericUpDown year)
        {
            return new DateTime((int)year.Value, (int)month.Value, (int)day.Value);
        }
        
        private void NormalizeDayNumeric(NumericUpDown day, int month, int year)
        {
            if (day.Value < 1)
            {
                day.Value = 1;
                return;
            }
            var max = DateTime.DaysInMonth(year, month);
            if (day.Value > max)
                day.Value = max;
        }

        private void getResult_button_Click(object sender, EventArgs e)
        {
            var FirstDate = DateTimeFromNumeric(day1_numeric, month1_numeric, year1_numeric);
            var SecondDate = DateTimeFromNumeric(day2_numeric, month2_numeric, year2_numeric);

            // try save data
            while (true)
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Order));
                    using (Stream stream = File.Create(SaveFilePath))
                    {
                        serializer.Serialize(stream, new Order(FirstDate, SecondDate));
                    }
                    break;
                }
                catch (Exception ex)
                {
                    var res = MessageBox.Show($"Something went wrong...\nDetails: {ex.Message}", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    bool flag = false;
                    switch (res)
                    {
                        case DialogResult.Abort:
                            Application.Exit();
                            break;
                        case DialogResult.Ignore:
                            flag = true;
                            break;
                    }
                    if (flag)
                        break;
                }
            }

            MessageBox.Show($"Difference between {FirstDate.ToShortDateString()} and {SecondDate.ToShortDateString()} is {FirstDate - SecondDate}", "Result");
        }

        private void day1_numeric_Leave(object sender, EventArgs e)
        {
            NormalizeDayNumeric((NumericUpDown)sender, (int)month1_numeric.Value, (int)year1_numeric.Value);
        }

        private void day2_numeric_Leave(object sender, EventArgs e)
        {
            NormalizeDayNumeric((NumericUpDown)sender, (int)month2_numeric.Value, (int)year2_numeric.Value);
        }
    }
}