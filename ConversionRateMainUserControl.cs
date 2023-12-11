using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trustbank
{
    public partial class ConversionRateMainUserControl : UserControl
    {
        Panel parentContainerPanel;

        public ConversionRateMainUserControl(Panel parentContainerPanel)
        {
            InitializeComponent();
            this.parentContainerPanel = parentContainerPanel;
            fromComboBox.SelectedItem = "PHP";
            toComboBox.SelectedItem = "USD";
            // Get the current date and time
            DateTime currentDateTime = DateTime.Now;

            // Format the date and time as a string
            string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            // Set the label's text to the formatted date and time
            dateTimeLabel.Text = "as of " + formattedDateTime;
        }


        private void UpdateCurrencyLabelsAndImages()
        {
            string fromCurrency = fromComboBox.SelectedItem?.ToString();
            string toCurrency = toComboBox.SelectedItem?.ToString();

            // Update fromCurrencyPictureBox and fromConversionLabel based on fromCurrency

            if (!string.IsNullOrEmpty(fromCurrency))
            {
                string imagePath = GetImagePathForCurrency(fromCurrency); // Implement this method to get the image path

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    fromcurrencyPictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Set the PictureBoxSizeMode to Zoom
                    fromcurrencyPictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Handle the case where the image file doesn't exist or imagePath is empty
                    // Set a default image or display an error message
                }
            }
            else
            {
                // Handle the case where fromCurrency is null or empty
            }

            if (!string.IsNullOrEmpty(toCurrency))
            {
                string imagePath = GetImagePathForCurrency(toCurrency); // Implement this method to get the image path

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    tocurrencyPictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Set the PictureBoxSizeMode to Zoom
                    tocurrencyPictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Handle the case where the image file doesn't exist or imagePath is empty
                    // Set a default image or display an error message
                }
            }
            else
            {
                // Handle the case where fromCurrency is null or empty
            }



            if (fromCurrency == "PHP")
            {
                fromconversionLabel.Text = "Philippine Peso";
            }
            if (fromCurrency == "USD")
            {
                fromconversionLabel.Text = "United States Dollars";
            }
            if (fromCurrency == "GBP")
            {
                fromconversionLabel.Text = "British Pound";
            }
            if (fromCurrency == "EUR")
            {
                fromconversionLabel.Text = "European Dollar";
            }
            if (fromCurrency == "YEN")
            {
                fromconversionLabel.Text = "Japanese Yen";
            }
            if (fromCurrency == "SGD")
            {
                fromconversionLabel.Text = "Singaporean Dollar";
            }


            if (toCurrency == "PHP")
            {
                toconversionLabel.Text = "Philippine Peso";
            }
            if (toCurrency == "USD")
            {
                toconversionLabel.Text = "United States Dollars";
            }
            if (toCurrency == "GBP")
            {
                toconversionLabel.Text = "British Pound";
            }
            if (toCurrency == "EUR")
            {
                toconversionLabel.Text = "European Dollar";
            }
            if (toCurrency == "YEN")
            {
                toconversionLabel.Text = "Japanese Yen";
            }
            if (toCurrency == "SGD")
            {
                toconversionLabel.Text = "Singaporean Dollar";
            }


        }
        private string GetImagePathForCurrency(string currency)
        {
            string imagePath = "";


            switch (currency)
            {
                case "PHP":
                    imagePath = @"C:\Users\ADMIN\Desktop\Program\C#\Trustbank\Resources\philippines.png"; // Replace with your PHP image path
                    break;
                case "USD":
                    imagePath = @"C:\Users\ADMIN\Desktop\Program\C#\Trustbank\Resources\united-states.png"; // Replace with your USD image path
                    break;
                case "SGD":
                    imagePath = @"C:\Users\ADMIN\Desktop\Program\C#\Trustbank\Resources\singapore.png"; // Replace with your USD image path
                    break;
                case "GBP":
                    imagePath = @"C:\Users\ADMIN\Desktop\Program\C#\Trustbank\Resources\united-kingdom.png"; // Replace with your USD image path
                    break;
                case "YEN":
                    imagePath = @"C:\Users\ADMIN\Desktop\Program\C#\Trustbank\Resources\japan.png"; // Replace with your USD image path
                    break;
                case "EUR":
                    imagePath = @"C:\Users\ADMIN\Desktop\Program\C#\Trustbank\Resources\european-union.png"; // Replace with your USD image path
                    break;
                // Add cases for other currencies with their respective image paths
                default:
                    // Set a default image path or handle the case where currency doesn't match
                    break;
            }

            return imagePath;
        }
        private void UpdateConversion()
        {
            string fromCurrency = fromComboBox.SelectedItem?.ToString();
            string toCurrency = toComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(inputBox.Text) && fromCurrency != null && toCurrency != null)
            {
                // Convert input value to decimal
                if (decimal.TryParse(inputBox.Text, out decimal amount))
                {
                    decimal result = PerformConversion(fromCurrency, toCurrency, amount);
                    outputBox.Text = result.ToString();
                }
                else
                {
                    outputBox.Text = "";
                }
            }
            else
            {
                outputBox.Text = "";
            }
        }

        // Your PerformConversion method
        private decimal PerformConversion(string fromCurrency, string toCurrency, decimal amount)
        {
            // Conversion logic here based on fromCurrency and toCurrency
            decimal convertedValue = 0;


            // PHP

            if (fromCurrency == "PHP" && toCurrency == "USD")
            {
                amount = decimal.Parse(inputBox.Text) * 0.018M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 PHP = 0.018 USD";
            }

            if (fromCurrency == "PHP" && toCurrency == "SGD")
            {
                amount = decimal.Parse(inputBox.Text) * 0.024M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 PHP = 0.024 SGD";
            }

            if (fromCurrency == "PHP" && toCurrency == "EUR")
            {
                amount = decimal.Parse(inputBox.Text) * 0.017M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 PHP = 0.017 EUR";
            }

            if (fromCurrency == "PHP" && toCurrency == "GBP")
            {
                amount = decimal.Parse(inputBox.Text) * 0.014M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 PHP = 0.014 GBP";
            }

            if (fromCurrency == "PHP" && toCurrency == "YEN")
            {
                amount = decimal.Parse(inputBox.Text) * 2.62M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 PHP = 2.62 YEN";
            }

            if (fromCurrency == "PHP" && toCurrency == "PHP")
            {
                amount = decimal.Parse(inputBox.Text) * 1;
                convertedValue = amount;
                exchangerateLabel.Text = "1 PHP = 1 PHP";
            }

            // USD

            if (fromCurrency == "USD" && toCurrency == "PHP")
            {
                amount = decimal.Parse(inputBox.Text) * 55.60M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 USD = 55.60 PHP";
            }

            if (fromCurrency == "USD" && toCurrency == "EUR")
            {
                amount = decimal.Parse(inputBox.Text) * 0.93M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 USD = 0.93 EUR";
            }

            if (fromCurrency == "USD" && toCurrency == "SGD")
            {
                amount = decimal.Parse(inputBox.Text) * 1.34M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 USD = 1.34 SGD";
            }

            if (fromCurrency == "USD" && toCurrency == "GBP")
            {
                amount = decimal.Parse(inputBox.Text) * 0.80M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 USD = 0.80 GBP";
            }

            if (fromCurrency == "USD" && toCurrency == "YEN")
            {
                amount = decimal.Parse(inputBox.Text) * 145.39M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 USD = 145.39 YEN";
            }

            if (fromCurrency == "USD" && toCurrency == "USD")
            {
                amount = decimal.Parse(inputBox.Text) * 1;
                convertedValue = amount;
                exchangerateLabel.Text = "1 USD = 1 USD";
            }

            // EUR

            if (fromCurrency == "EUR" && toCurrency == "PHP")
            {
                amount = decimal.Parse(inputBox.Text) * 59.83M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 EUR = 59.83 PHP";
            }

            if (fromCurrency == "EUR" && toCurrency == "EUR")
            {
                amount = decimal.Parse(inputBox.Text) * 1;
                convertedValue = amount;
                exchangerateLabel.Text = "1 EUR = 1 EUR";
            }

            if (fromCurrency == "EUR" && toCurrency == "SGD")
            {
                amount = decimal.Parse(inputBox.Text) * 1.45M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 EUR = 1.45 SGD";
            }

            if (fromCurrency == "EUR" && toCurrency == "GBP")
            {
                amount = decimal.Parse(inputBox.Text) * 0.86M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 EUR = 0.86 GBP";
            }

            if (fromCurrency == "EUR" && toCurrency == "YEN")
            {
                amount = decimal.Parse(inputBox.Text) * 156.54M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 EUR = 156.54 YEN";
            }

            if (fromCurrency == "EUR" && toCurrency == "USD")
            {
                amount = decimal.Parse(inputBox.Text) * 1.08M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 EUR = 1.08 USD";
            }

            // GBP

            if (fromCurrency == "GBP" && toCurrency == "PHP")
            {
                amount = decimal.Parse(inputBox.Text) * 69.70M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 GBP = 69.70 PHP";
            }

            if (fromCurrency == "GBP" && toCurrency == "EUR")
            {
                amount = decimal.Parse(inputBox.Text) * 1.16M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 GBP = 1.16 EUR";
            }

            if (fromCurrency == "GBP" && toCurrency == "SGD")
            {
                amount = decimal.Parse(inputBox.Text) * 1.68M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 GBP = 1.68 SGD";
            }

            if (fromCurrency == "GBP" && toCurrency == "GBP")
            {
                amount = decimal.Parse(inputBox.Text) * 1;
                convertedValue = amount;
                exchangerateLabel.Text = "1 GBP = 1 GBP";
            }

            if (fromCurrency == "GBP" && toCurrency == "YEN")
            {
                amount = decimal.Parse(inputBox.Text) * 182.37M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 GBP = 182.37 YEN";
            }

            if (fromCurrency == "GBP" && toCurrency == "USD")
            {
                amount = decimal.Parse(inputBox.Text) * 1.25M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 GBP = 1.25 USD";
            }

            // SGD

            if (fromCurrency == "SGD" && toCurrency == "PHP")
            {
                amount = decimal.Parse(inputBox.Text) * 41.39M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 SGD = 41.39 PHP";
            }

            if (fromCurrency == "SGD" && toCurrency == "EUR")
            {
                amount = decimal.Parse(inputBox.Text) * 0.69M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 SGD = 0.69 EUR";
            }

            if (fromCurrency == "SGD" && toCurrency == "SGD")
            {
                amount = decimal.Parse(inputBox.Text) * 1;
                convertedValue = amount;
                exchangerateLabel.Text = "1 SGD = 1 SGD";
            }

            if (fromCurrency == "SGD" && toCurrency == "GBP")
            {
                amount = decimal.Parse(inputBox.Text) * 0.59M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 SGD = 0.59 GBP";
            }

            if (fromCurrency == "SGD" && toCurrency == "YEN")
            {
                amount = decimal.Parse(inputBox.Text) * 108.31M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 SGD = 108.31 YEN";
            }

            if (fromCurrency == "SGD" && toCurrency == "USD")
            {
                amount = decimal.Parse(inputBox.Text) * 0.74M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 SGD = 0.74 USD";
            }

            // YEN

            if (fromCurrency == "YEN" && toCurrency == "PHP")
            {
                amount = decimal.Parse(inputBox.Text) * 0.38M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 YEN = 0.38 PHP";
            }

            if (fromCurrency == "YEN" && toCurrency == "EUR")
            {
                amount = decimal.Parse(inputBox.Text) * 0.0064M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 YEN = 0.0064 EUR";
            }

            if (fromCurrency == "YEN" && toCurrency == "SGD")
            {
                amount = decimal.Parse(inputBox.Text) * 0.0092M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 YEN = 0.0092 SGD";
            }

            if (fromCurrency == "YEN" && toCurrency == "GBP")
            {
                amount = decimal.Parse(inputBox.Text) * 0.0055M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 YEN = 0.0055 GBP";
            }

            if (fromCurrency == "YEN" && toCurrency == "YEN")
            {
                amount = decimal.Parse(inputBox.Text) * 1;
                convertedValue = amount;
                exchangerateLabel.Text = "1 YEN = 1 YEN";
            }

            if (fromCurrency == "YEN" && toCurrency == "USD")
            {
                amount = decimal.Parse(inputBox.Text) * 0.0069M;
                convertedValue = amount;
                exchangerateLabel.Text = "1 YEN = 0.0069 USD";
            }

            return convertedValue;

        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateConversion();
            UpdateCurrencyLabelsAndImages();
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            UpdateConversion();
        }

        private void toComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateConversion();
            UpdateCurrencyLabelsAndImages();
        }
    }
}
