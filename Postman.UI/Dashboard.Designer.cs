namespace Postman.UI;

partial class Dashboard
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        formHeader = new Label();
        apiLabel = new Label();
        apiText = new TextBox();
        callApi = new Button();
        resultsText = new TextBox();
        statusStrip = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        resultsLabel = new Label();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // formHeader
        // 
        formHeader.AutoSize = true;
        formHeader.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
        formHeader.Location = new Point(12, 9);
        formHeader.Name = "formHeader";
        formHeader.Size = new Size(372, 70);
        formHeader.TabIndex = 0;
        formHeader.Text = "Postman Clone";
        // 
        // apiLabel
        // 
        apiLabel.AutoSize = true;
        apiLabel.Location = new Point(12, 79);
        apiLabel.Name = "apiLabel";
        apiLabel.Size = new Size(81, 48);
        apiLabel.TabIndex = 1;
        apiLabel.Text = "API:";
        // 
        // apiText
        // 
        apiText.BorderStyle = BorderStyle.FixedSingle;
        apiText.Location = new Point(99, 76);
        apiText.Name = "apiText";
        apiText.Size = new Size(1371, 55);
        apiText.TabIndex = 2;
        // 
        // callApi
        // 
        callApi.Location = new Point(1476, 76);
        callApi.Name = "callApi";
        callApi.Size = new Size(112, 55);
        callApi.TabIndex = 3;
        callApi.Text = "Go";
        callApi.UseVisualStyleBackColor = true;
        callApi.Click += callApi_Click;
        // 
        // resultsText
        // 
        resultsText.BackColor = Color.White;
        resultsText.BorderStyle = BorderStyle.FixedSingle;
        resultsText.Location = new Point(12, 198);
        resultsText.Multiline = true;
        resultsText.Name = "resultsText";
        resultsText.ReadOnly = true;
        resultsText.ScrollBars = ScrollBars.Both;
        resultsText.Size = new Size(1576, 618);
        resultsText.TabIndex = 4;
        // 
        // statusStrip
        // 
        statusStrip.BackColor = Color.Transparent;
        statusStrip.ImageScalingSize = new Size(24, 24);
        statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
        statusStrip.Location = new Point(0, 819);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(1600, 45);
        statusStrip.TabIndex = 5;
        statusStrip.Text = "SystemStatus";
        // 
        // systemStatus
        // 
        systemStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        systemStatus.Name = "systemStatus";
        systemStatus.Size = new Size(92, 38);
        systemStatus.Text = "Ready";
        // 
        // resultsLabel
        // 
        resultsLabel.AutoSize = true;
        resultsLabel.Location = new Point(12, 147);
        resultsLabel.Name = "resultsLabel";
        resultsLabel.Size = new Size(131, 48);
        resultsLabel.TabIndex = 6;
        resultsLabel.Text = "Results";
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(20F, 48F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1600, 864);
        Controls.Add(resultsLabel);
        Controls.Add(statusStrip);
        Controls.Add(resultsText);
        Controls.Add(callApi);
        Controls.Add(apiText);
        Controls.Add(apiLabel);
        Controls.Add(formHeader);
        Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(6);
        Name = "Dashboard";
        Text = "Postman Clone by SagharMax";
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label formHeader;
    private Label apiLabel;
    private TextBox apiText;
    private Button callApi;
    private TextBox resultsText;
    private StatusStrip statusStrip;
    private Label resultsLabel;
    private ToolStripStatusLabel systemStatus;
}
