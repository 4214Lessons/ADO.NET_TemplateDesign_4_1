using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;


namespace ADONETLesson4_ClassicAsynchronous;


public partial class ClassicAsynchronous : Form
{
    IConfigurationRoot? configurationRoot = null;
    string conStr = string.Empty;


    public ClassicAsynchronous()
    {
        InitializeComponent();
        Configure();
    }


    private void Configure()
    {
        string projectPath = Directory.GetCurrentDirectory().Split(@"bin\")[0];
       
        configurationRoot = new ConfigurationBuilder()
            .SetBasePath(projectPath)
            .AddJsonFile("appsettings.json").Build();



        conStr = configurationRoot.GetConnectionString("ConStr");
    }
}