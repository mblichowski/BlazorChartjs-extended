using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.Chartjs
{
	public class ChartJsInterop
	{
		private readonly IJSObjectReference _module;

		public ChartJsInterop(IJSObjectReference module)
		{
			_module = module;
		}

		public async ValueTask Setup(DotNetObjectReference<IChartConfig> dotNetObjectRef, IChartConfig Config)
		{
			await _module.InvokeVoidAsync("chartSetup", Config.CanvasId, dotNetObjectRef, Config);
		}

		public async ValueTask AddData(string CanvasId, List<string> labels, int datasetIndex, List<decimal?> data)
		{
			await _module.InvokeVoidAsync("addData", CanvasId, labels, datasetIndex, data);
		}

		public async ValueTask AddNewDataset<T>(string CanvasId, T dataset) where T : class
		{
			await _module.InvokeVoidAsync("addNewDataset", CanvasId, dataset);
		}
	}
}