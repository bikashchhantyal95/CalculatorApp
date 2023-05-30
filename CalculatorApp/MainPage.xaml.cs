namespace CalculatorApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
    public void performCalculations(object sender, EventArgs e)
    {
        //store result
        //set to 0 initally.
        double result = 0;

        //store selected operation from the picker
        string selectedOperation = operationsList.SelectedItem?.ToString();

        // convert the operhand_one and operhand_two to double and validate it
        if (double.TryParse(operhand_one.Text, out double first_num) && double.TryParse(operhand_two.Text, out double second_num))
        {
            // if selected operation is "Add"
            // perform addition
            if (selectedOperation == "Add")
            {
                result = first_num + second_num;
                result_output.Text = result.ToString();
            }

            // if selected operation is "Subtract"
            // perform addition
            if (selectedOperation == "Subtract")
            {
                result = first_num - second_num;
                result_output.Text = result.ToString();
            }

            // if selected operation is "Multiply"
            // perform addition
            if (selectedOperation == "Multiply")
            {
                result = first_num * second_num;
                result_output.Text = result.ToString();
            }

            // if selected operation is "Divide"
            // perform addition
            if (selectedOperation == "Divide")
            {
                if (second_num == 0)
                {
                    result_output.Text = "Error: Number cannot be divisible by 0.";
                    return;
                }
                result = first_num / second_num;
                result_output.Text = result.ToString();
            }
        }
    }

}


