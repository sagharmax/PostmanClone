namespace Postman.UI;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        // Validate the URL
        try
        {
            systemStatus.Text = "Calling API...";

            // Sample code - replace with the actual API call
            await Task.Delay(2000);

            systemStatus.Text = "Ready";
        }
        catch (Exception exception)
        {
            resultsText.Text = "Error: " + exception.Message;
            systemStatus.Text = "Error";
        }
    }
}
