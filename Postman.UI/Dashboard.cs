using Postman.Library;

namespace Postman.UI;

public partial class Dashboard : Form
{
    private readonly IApiAccess _apiAccess = new ApiAccess();
    public Dashboard()
    {
        InitializeComponent();
        httpVerbSelection.SelectedItem = "GET";
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API...";
        resultsText.Text = string.Empty;
        // Validate the URL
        if (_apiAccess.IsValidUrl(apiText.Text) == false)
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        HttpAction action;
        if (Enum.TryParse(httpVerbSelection.SelectedItem!.ToString(), out action) == false)
        {
            systemStatus.Text = "Invalid HTTP Verb";
            return;
        }

        try
        {
            resultsText.Text = await _apiAccess.CallApiAsync(apiText.Text, bodyText.Text, action);
            callData.SelectedTab = resultsTab;
            resultsTab.Focus();

            systemStatus.Text = "Ready";
        }
        catch (Exception exception)
        {
            resultsText.Text = "Error: " + exception.Message;
            systemStatus.Text = "Error";
        }
    }
}
