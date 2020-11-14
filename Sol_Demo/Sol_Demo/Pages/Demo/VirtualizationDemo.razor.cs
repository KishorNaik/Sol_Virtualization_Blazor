using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Sol_Demo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class VirtualizationDemo
    {
        private const float itemHeight = 50;
        private const int totalForecastCount = 10000;

        #region Private Property

        private string ItemStyle { get => $"height: {itemHeight}px"; }

        private float ItemHeight { get => itemHeight; }

        private String CellLoadingText { get => "Loading..."; }

        private WeatherForecast[] forecasts { get; set; }

        #endregion Private Property

        #region Public Property

        [Inject]
        public WeatherForecastService ForecastService { get; set; }

        #endregion Public Property

        #region Private Methhod

        private async ValueTask<ItemsProviderResult<WeatherForecast>> LoadForecast(ItemsProviderRequest request)
        {
            var numForecasts = Math.Min(request.Count, totalForecastCount - request.StartIndex);
            var forecasts = await ForecastService.GetForecastAsync(request.StartIndex, numForecasts);

            return new ItemsProviderResult<WeatherForecast>(forecasts, totalForecastCount);
        }

        #endregion Private Methhod
    }
}