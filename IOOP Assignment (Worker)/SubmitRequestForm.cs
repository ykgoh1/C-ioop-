using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment__Worker_
{
    public partial class SubmitRequestForm : Form
    {
        private string userId;
        public SubmitRequestForm(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //Close this form when btnClose is clicked
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // List to hold the selected services
            List<ServiceSelection> selectedServices = new List<ServiceSelection>();

            // Validate each textbox for each service and add to the list if valid
            if (cbPrintingA4BW.Checked)
            {
                if (int.TryParse(txtPA4BW.Text, out int amountPrintingBW) && amountPrintingBW > 0)
                {
                    selectedServices.Add(new ServiceSelection
                    {
                        ServiceName = "Printing A4 – Black and White",
                        Amount = amountPrintingBW,
                        Size = "A4"
                    });
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount for Printing A4 – Black and White.");
                    return;
                }
            }

            if (cbPrintingA4C.Checked)
            {
                if (int.TryParse(txtPA4C.Text, out int amountPrintingColor) && amountPrintingColor > 0)
                {
                    selectedServices.Add(new ServiceSelection
                    {
                        ServiceName = "Printing A4 – Color",
                        Amount = amountPrintingColor,
                        Size = "A4"
                    });
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount for Printing A4 – Color.");
                    return;
                }
            }

            if (cbBindingCB.Checked)
            {
                if (int.TryParse(txtBCB.Text, out int amountBindingComb) && amountBindingComb > 0)
                {
                    selectedServices.Add(new ServiceSelection
                    {
                        ServiceName = "Binding – Comb Binding",
                        Amount = amountBindingComb,
                        Size = "n/a"
                    });
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount for Binding – Comb Binding.");
                    return;
                }
            }

            if (cbBindingTC.Checked)
            {
                if (int.TryParse(txtBTC.Text, out int amountBindingThick) && amountBindingThick > 0)
                {
                    selectedServices.Add(new ServiceSelection
                    {
                        ServiceName = "Binding – Thick Cover",
                        Amount = amountBindingThick,
                        Size = "n/a"
                    });
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount for Binding – Thick Cover.");
                    return;
                }
            }

            if (cbPrintingPA0.Checked)
            {
                if (int.TryParse(txtPPA0.Text, out int amountPosterA0) && amountPosterA0 > 0)
                {
                    selectedServices.Add(new ServiceSelection
                    {
                        ServiceName = "Printing - Poster",
                        Amount = amountPosterA0,
                        Size = "A0"
                    });
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount for Printing - Poster (A0).");
                    return;
                }
            }

            if (cbPrintingPA1.Checked)
            {
                if (int.TryParse(txtPPA1.Text, out int amountPosterA1) && amountPosterA1 > 0)
                {
                    selectedServices.Add(new ServiceSelection
                    {
                        ServiceName = "Printing - Poster",
                        Amount = amountPosterA1,
                        Size = "A1"
                    });
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount for Printing - Poster (A1).");
                    return;
                }
            }

            if (cbPrintingPA2.Checked)
            {
                if (int.TryParse(txtPPA2.Text, out int amountPosterA2) && amountPosterA2 > 0)
                {
                    selectedServices.Add(new ServiceSelection
                    {
                        ServiceName = "Printing - Poster",
                        Amount = amountPosterA2,
                        Size = "A2"
                    });
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount for Printing - Poster (A2).");
                    return;
                }
            }

            if (cbPrintingPA3.Checked)
            {
                if (int.TryParse(txtPPA3.Text, out int amountPosterA3) && amountPosterA3 > 0)
                {
                    selectedServices.Add(new ServiceSelection
                    {
                        ServiceName = "Printing - Poster",
                        Amount = amountPosterA3,
                        Size = "A3"
                    });
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount for Printing - Poster (A3).");
                    return;
                }
            }

            // Proceed if at least 1 service is selected
            if (selectedServices.Count > 0)
            {
                // Calculate fees using PriceCalculator class
                PriceCalculator calculator = new PriceCalculator();
                bool isUrgent = cbUrgent.Checked;
                List<ServiceFee> fees = calculator.CalculateFees(selectedServices, isUrgent);

                // Open the RequestConfirmationForm and pass the calculated fees
                RequestConfirmationForm confirmationForm = new RequestConfirmationForm(fees, userId, isUrgent);
                confirmationForm.Show();
            }
            else
            {
                MessageBox.Show("Please select at least one service."); //Show when btnSubmit is clicked without selecting any service
            }
        }

        private void cbPrintingA4BW_CheckedChanged(object sender, EventArgs e)
        {
            lblPA4BW.Visible = cbPrintingA4BW.Checked; //show label only when the checkbox is checked
            txtPA4BW.Visible = cbPrintingA4BW.Checked; //show textbox only when the checkbox is checked
        }

        private void cbPrintingA4C_CheckedChanged(object sender, EventArgs e)
        {
            lblPA4C.Visible = cbPrintingA4C.Checked; //show label only when the checkbox is checked
            txtPA4C.Visible = cbPrintingA4C.Checked; //show textbox only when the checkbox is checked
        }

        private void cbBindingCB_CheckedChanged(object sender, EventArgs e)
        {
            lblBCB.Visible = cbBindingCB.Checked; //show label only when the checkbox is checked
            txtBCB.Visible = cbBindingCB.Checked; //show textbox only when the checkbox is checked
        }

        private void cbBindingTC_CheckedChanged(object sender, EventArgs e)
        {
            lblBTC.Visible = cbBindingTC.Checked; //show label only when the checkbox is checked
            txtBTC.Visible = cbBindingTC.Checked; //show textbox only when the checkbox is checked
        }

        private void cbPrintingPA0_CheckedChanged(object sender, EventArgs e)
        {
            lblPPA0.Visible = cbPrintingPA0.Checked; //show label only when the checkbox is checked
            txtPPA0.Visible = cbPrintingPA0.Checked; //show textbox only when the checkbox is checked
        }

        private void cbPrintingPA1_CheckedChanged(object sender, EventArgs e)
        {
            lblPPA1.Visible = cbPrintingPA1.Checked; //show label only when the checkbox is checked
            txtPPA1.Visible = cbPrintingPA1.Checked; //show textbox only when the checkbox is checked
        }

        private void cbPrintingPA2_CheckedChanged(object sender, EventArgs e)
        {
            lblPPA2.Visible = cbPrintingPA2.Checked; //show label only when the checkbox is checked
            txtPPA2.Visible = cbPrintingPA2.Checked; //show textbox only when the checkbox is checked
        }

        private void cbPrintingPA3_CheckedChanged(object sender, EventArgs e)
        {
            lblPPA3.Visible = cbPrintingPA3.Checked; //show label only when the checkbox is checked
            txtPPA3.Visible = cbPrintingPA3.Checked; //show textbox only when the checkbox is checked
        }
    }
}
