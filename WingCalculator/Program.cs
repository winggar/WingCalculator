namespace WingCalculator;

using System.Text.Json;
using WingCalculator.Forms;

internal static class Program
{
	private static string ConfigPath { get; } = @"config.json";
	private static Config Config { get; set; }

	/// <summary>
	///  The main entry point for the application.
	/// </summary>
	[STAThread]
	private static void Main()
	{
		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		ApplicationConfiguration.Initialize();
		
		if (File.Exists(ConfigPath))
		{
			Config = JsonSerializer.Deserialize<Config>(File.ReadAllText(ConfigPath));
		}
		else
		{
			Config = new();
		}

		Application.ApplicationExit += OnExit;

		Application.Run(new MainForm(Config));
	}

	private static void OnExit(object sender, EventArgs e) => File.WriteAllText(ConfigPath, JsonSerializer.Serialize(Config));
}