namespace CalculatorApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	public void performCalculations(object sender, EventArgs e)
	{
		double result = 0;
		string selectedOperation = operationsList.SelectedItem?.ToString();

		if(double.TryParse(operhand_one.Text, out double first_num) && double.TryParse(operhand_two.Text, out double second_num))
			{
			if(selectedOperation == "Add")
			{
				result = first_num + second_num;
				result_output.Text = result.ToString();
			}
            if (selectedOperation == "Subtract")
            {
                result = first_num - second_num;
                result_output.Text = result.ToString();
            }
            if (selectedOperation == "Multiply")
            {
                result = first_num * second_num;
                result_output.Text = result.ToString();
            }
            if (selectedOperation == "Divide")
            {
                if(second_num == 0)
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


