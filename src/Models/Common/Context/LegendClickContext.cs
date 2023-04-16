namespace PSC.Blazor.Components.Chartjs.Models.Common;

/// <summary>
/// Legend Click Context.
/// </summary>
public readonly record struct LegendClickContext(
	int LegendIndex,
	string LegendText,
	Guid? ChartId);
