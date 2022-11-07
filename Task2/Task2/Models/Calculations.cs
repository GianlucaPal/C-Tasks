using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Task2.Models
{
    public class Calculations
    {

        static List<Measurements> Connect(string data)
        {
            List<Measurements> measurements = new List<Measurements>();
            string connectionString = "Data Source=.;Initial Catalog=task2;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT " + data + " FROM tblTask2Data";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var measurement = new Measurements();
                            switch (data)
                            {
                                case "Temperature":
                                    measurement.Temperature = Convert.ToDouble(reader[data].ToString());
                                    measurements.Add(measurement);
                                    break;

                                case "humidity":
                                    measurement.Humidity = Convert.ToDouble(reader[data].ToString());
                                    measurements.Add(measurement);
                                    break;

                                case "Width":
                                    measurement.Width = Convert.ToDouble(reader[data].ToString());
                                    measurements.Add(measurement);
                                    break;

                                case "Weight":
                                    measurement.Weight = Convert.ToDouble(reader[data].ToString());
                                    measurements.Add(measurement);
                                    break;

                                case "Depth":
                                    measurement.Depth = Convert.ToDouble(reader[data].ToString());
                                    measurements.Add(measurement);
                                    break;
                                case "Length":
                                    measurement.length = Convert.ToDouble(reader[data].ToString());
                                    measurements.Add(measurement);
                                    break;
                            }

                        }
                    }

                }
            }
            return measurements;
        }

        //============================================================================================================================
        public static double averageTemp()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Temperature");

            double avg = measurements.Average(X => X.Temperature);

            return avg;
        }

        public static double averageHum()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("humidity");

            double avg = measurements.Average(X => X.Humidity);

            return avg;
        }
        public static double averageWidth()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Width");

            double avg = measurements.Average(X => X.Width);

            return avg;
        }
        public static double averageWeight()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Weight");

            double avg = measurements.Average(X => X.Weight);

            return avg;

        }

        public static double averageLength()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Length");

            double avg = measurements.Average(X => X.length);

            return avg;
        }

        public static double averageDepth()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Depth");

            double avg = measurements.Average(X => X.Depth);

            return avg;
        }
        //============================================================================================================================
        public static double MaxTemp()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Temperature");

            double Max = measurements.Max(X => X.Temperature);

            return Max;
        }

        public static double MaxHum()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("humidity");

            double Max = measurements.Max(X => X.Humidity);

            return Max;
        }
        public static double MaxWidth()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Width");

            double Max = measurements.Max(X => X.Width);

            return Max;
        }
        public static double MaxWeight()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Weight");

            double Max = measurements.Max(X => X.Weight);

            return Max;
        }
        public static double MaxDepth()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Depth");

            double Max = measurements.Max(X => X.Depth);

            return Max;
        }
        public static double MaxLength()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Length");

            double Max = measurements.Max(X => X.length);

            return Max;
        }
        //============================================================================================================================
        public static double MinTemp()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Temperature");

            double Min = measurements.Min(X => X.Temperature);

            return Min;
        }

        public static double MinHum()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("humidity");

            double Min = measurements.Min(X => X.Humidity);

            return Min;
        }
        public static double MinWidth()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Width");

            double Min = measurements.Min(X => X.Width);

            return Min;
        }
        public static double MinWeight()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Weight");

            double Min = measurements.Min(X => X.Weight);

            return Min;
        }
        public static double MinDepth()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Depth");

            double Min = measurements.Min(X => X.Depth);

            return Min;
        }
        public static double MinLength()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Length");

            double Min = measurements.Min(X => X.length);

            return Min;
        }
        //============================================================================================================================
        public static double SumTemp()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Temperature");

            double Sum = measurements.Sum(X => X.Temperature);

            return Sum;
        }

        public static double SumHum()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("humidity");

            double Sum = measurements.Sum(X => X.Humidity);

            return Sum;
        }
        public static double SumWidth()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Width");

            double Sum = measurements.Sum(X => X.Width);

            return Sum;
        }
        public static double SumWeight()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Weight");

            double Sum = measurements.Sum(X => X.Weight);

            return Sum;
        }
        public static double SumDepth()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Depth");

            double Sum = measurements.Sum(X => X.Depth);

            return Sum;
        }
        public static double SumLength()
        {
            List<Measurements> measurements = new List<Measurements>();

            measurements = Connect("Length");

            double Sum = measurements.Sum(X => X.length);

            return Sum;
        }
        //============================================================================================================================

        public static double varianceTemp()
        {
            List<Measurements> measurements = new List<Measurements>();
            measurements = Connect("Temperature");
            if (measurements.Capacity > 1)
            {

                var avg = measurements.Average(X => X.Temperature);

                double sumOfSquares = 0.0;

                foreach (Measurements measuerment in measurements)
                {

                    sumOfSquares += Math.Pow((measuerment.Temperature - avg), 2.0);

                }

                return sumOfSquares / (double)(measurements.Capacity - 1);

            }

            else { return 0.0; }

        }

        public static double varianceHum()
        {
            List<Measurements> measurements = new List<Measurements>();
            measurements = Connect("humidity");
            if (measurements.Capacity > 1)
            {

                var avg = measurements.Average(X => X.Humidity);

                double sumOfSquares = 0.0;

                foreach (Measurements measuerment in measurements)
                {

                    sumOfSquares += Math.Pow((measuerment.Humidity - avg), 2.0);

                }

                return sumOfSquares / (double)(measurements.Capacity - 1);

            }

            else { return 0.0; }

        }

        public static double varianceWidth()
        {
            List<Measurements> measurements = new List<Measurements>();
            measurements = Connect("Width");
            if (measurements.Capacity > 1)
            {

                double avg = measurements.Average(X => X.Width);

                double sumOfSquares = 0.0;

                foreach (Measurements measuerment in measurements)
                {

                    sumOfSquares += Math.Pow((measuerment.Width - avg), 2.0);

                }

                return sumOfSquares / (double)(measurements.Capacity - 1);

            }

            else { return 0.0; }

        }
        public static double varianceWeight()
        {
            List<Measurements> measurements = new List<Measurements>();
            measurements = Connect("Weight");
            if (measurements.Capacity > 1)
            {

                double avg = measurements.Average(X => X.Weight);

                double sumOfSquares = 0.0;

                foreach (Measurements measuerment in measurements)
                {

                    sumOfSquares += Math.Pow((measuerment.Weight - avg), 2.0);

                }

                return sumOfSquares / (double)(measurements.Capacity - 1);

            }

            else { return 0.0; }

        }
        public static double varianceLength()
        {
            List<Measurements> measurements = new List<Measurements>();
            measurements = Connect("Length");
            if (measurements.Capacity > 1)
            {

                double avg = measurements.Average(X => X.length);

                double sumOfSquares = 0.0;

                foreach (Measurements measuerment in measurements)
                {

                    sumOfSquares += Math.Pow((measuerment.length - avg), 2.0);

                }

                return sumOfSquares / (double)(measurements.Capacity - 1);

            }

            else { return 0.0; }

        }
        public static double varianceDepth()
        {
            List<Measurements> measurements = new List<Measurements>();
            measurements = Connect("Depth");
            if (measurements.Capacity > 1)
            {

                double avg = measurements.Average(X => X.Depth);

                double sumOfSquares = 0.0;

                foreach (Measurements measuerment in measurements)
                {

                    sumOfSquares += Math.Pow((measuerment.Depth - avg), 2.0);

                }

                return sumOfSquares / (double)(measurements.Capacity - 1);

            }

            else { return 0.0; }

        }

        //============================================================================================================================

        public static double standardDeviationTemp ()
        {
            
            return Math.Sqrt(varianceTemp());
        }
        public static double standardDeviationHum()
        {
            return Math.Sqrt(varianceHum());
        }
        public static double standardDeviationWeight()
        {
            return Math.Sqrt(varianceWeight());
        }
        public static double standardDeviationWidth()
        {
            return Math.Sqrt(varianceWidth());
        }
        public static double standardDeviationLength()
        {
            return Math.Sqrt(varianceLength());
        }
        public static double standardDeviationDepth()
        {
            return Math.Sqrt(varianceDepth());
        }

    }
}