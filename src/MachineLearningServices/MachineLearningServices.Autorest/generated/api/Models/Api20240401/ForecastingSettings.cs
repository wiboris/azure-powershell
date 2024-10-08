// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Forecasting specific parameters.</summary>
    public partial class ForecastingSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IForecastingSettings,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IForecastingSettingsInternal
    {

        /// <summary>Backing field for <see cref="CountryOrRegionForHoliday" /> property.</summary>
        private string _countryOrRegionForHoliday;

        /// <summary>
        /// Country or region for holidays for forecasting tasks.
        /// These should be ISO 3166 two-letter country/region codes, for example 'US' or 'GB'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string CountryOrRegionForHoliday { get => this._countryOrRegionForHoliday; set => this._countryOrRegionForHoliday = value; }

        /// <summary>Backing field for <see cref="CvStepSize" /> property.</summary>
        private int? _cvStepSize;

        /// <summary>
        /// Number of periods between the origin time of one CV fold and the next fold. For
        /// example, if `CVStepSize` = 3 for daily data, the origin time for each fold will be
        /// three days apart.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? CvStepSize { get => this._cvStepSize; set => this._cvStepSize = value; }

        /// <summary>Backing field for <see cref="FeatureLag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureLags? _featureLag;

        /// <summary>Flag for generating lags for the numeric features with 'auto' or null.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureLags? FeatureLag { get => this._featureLag; set => this._featureLag = value; }

        /// <summary>Backing field for <see cref="ForecastHorizon" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IForecastHorizon _forecastHorizon;

        /// <summary>The desired maximum forecast horizon in units of time-series frequency.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IForecastHorizon ForecastHorizon { get => (this._forecastHorizon = this._forecastHorizon ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ForecastHorizon()); set => this._forecastHorizon = value; }

        /// <summary>[Required] Set forecast horizon value selection mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastHorizonMode? ForecastHorizonMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IForecastHorizonInternal)ForecastHorizon).Mode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IForecastHorizonInternal)ForecastHorizon).Mode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastHorizonMode)""); }

        /// <summary>Backing field for <see cref="Frequency" /> property.</summary>
        private string _frequency;

        /// <summary>
        /// When forecasting, this parameter represents the period with which the forecast is desired, for example daily, weekly,
        /// yearly, etc. The forecast frequency is dataset frequency by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Frequency { get => this._frequency; set => this._frequency = value; }

        /// <summary>Internal Acessors for ForecastHorizon</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IForecastHorizon Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IForecastingSettingsInternal.ForecastHorizon { get => (this._forecastHorizon = this._forecastHorizon ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ForecastHorizon()); set { {_forecastHorizon = value;} } }

        /// <summary>Internal Acessors for Seasonality</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISeasonality Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IForecastingSettingsInternal.Seasonality { get => (this._seasonality = this._seasonality ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.Seasonality()); set { {_seasonality = value;} } }

        /// <summary>Internal Acessors for TargetLag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITargetLags Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IForecastingSettingsInternal.TargetLag { get => (this._targetLag = this._targetLag ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.TargetLags()); set { {_targetLag = value;} } }

        /// <summary>Internal Acessors for TargetRollingWindowSize</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITargetRollingWindowSize Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IForecastingSettingsInternal.TargetRollingWindowSize { get => (this._targetRollingWindowSize = this._targetRollingWindowSize ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.TargetRollingWindowSize()); set { {_targetRollingWindowSize = value;} } }

        /// <summary>Backing field for <see cref="Seasonality" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISeasonality _seasonality;

        /// <summary>
        /// Set time series seasonality as an integer multiple of the series frequency.
        /// If seasonality is set to 'auto', it will be inferred.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISeasonality Seasonality { get => (this._seasonality = this._seasonality ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.Seasonality()); set => this._seasonality = value; }

        /// <summary>[Required] Seasonality mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SeasonalityMode? SeasonalityMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISeasonalityInternal)Seasonality).Mode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISeasonalityInternal)Seasonality).Mode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SeasonalityMode)""); }

        /// <summary>Backing field for <see cref="ShortSeriesHandlingConfig" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ShortSeriesHandlingConfiguration? _shortSeriesHandlingConfig;

        /// <summary>The parameter defining how if AutoML should handle short time series.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ShortSeriesHandlingConfiguration? ShortSeriesHandlingConfig { get => this._shortSeriesHandlingConfig; set => this._shortSeriesHandlingConfig = value; }

        /// <summary>Backing field for <see cref="TargetAggregateFunction" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetAggregationFunction? _targetAggregateFunction;

        /// <summary>
        /// The function to be used to aggregate the time series target column to conform to a user specified frequency.
        /// If the TargetAggregateFunction is set i.e. not 'None', but the freq parameter is not set, the error is raised. The possible
        /// target aggregation functions are: "sum", "max", "min" and "mean".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetAggregationFunction? TargetAggregateFunction { get => this._targetAggregateFunction; set => this._targetAggregateFunction = value; }

        /// <summary>Backing field for <see cref="TargetLag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITargetLags _targetLag;

        /// <summary>The number of past periods to lag from the target column.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITargetLags TargetLag { get => (this._targetLag = this._targetLag ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.TargetLags()); set => this._targetLag = value; }

        /// <summary>[Required] Set target lags mode - Auto/Custom</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetLagsMode? TargetLagMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITargetLagsInternal)TargetLag).Mode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITargetLagsInternal)TargetLag).Mode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetLagsMode)""); }

        /// <summary>Backing field for <see cref="TargetRollingWindowSize" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITargetRollingWindowSize _targetRollingWindowSize;

        /// <summary>
        /// The number of past periods used to create a rolling window average of the target column.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITargetRollingWindowSize TargetRollingWindowSize { get => (this._targetRollingWindowSize = this._targetRollingWindowSize ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.TargetRollingWindowSize()); set => this._targetRollingWindowSize = value; }

        /// <summary>[Required] TargetRollingWindowSiz detection mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetRollingWindowSizeMode? TargetRollingWindowSizeMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITargetRollingWindowSizeInternal)TargetRollingWindowSize).Mode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITargetRollingWindowSizeInternal)TargetRollingWindowSize).Mode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetRollingWindowSizeMode)""); }

        /// <summary>Backing field for <see cref="TimeColumnName" /> property.</summary>
        private string _timeColumnName;

        /// <summary>
        /// The name of the time column. This parameter is required when forecasting to specify the datetime column in the input data
        /// used for building the time series and inferring its frequency.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string TimeColumnName { get => this._timeColumnName; set => this._timeColumnName = value; }

        /// <summary>Backing field for <see cref="TimeSeriesIdColumnName" /> property.</summary>
        private string[] _timeSeriesIdColumnName;

        /// <summary>
        /// The names of columns used to group a timeseries. It can be used to create multiple series.
        /// If grain is not defined, the data set is assumed to be one time-series. This parameter is used with task type forecasting.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string[] TimeSeriesIdColumnName { get => this._timeSeriesIdColumnName; set => this._timeSeriesIdColumnName = value; }

        /// <summary>Backing field for <see cref="UseStl" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.UseStl? _useStl;

        /// <summary>Configure STL Decomposition of the time-series target column.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.UseStl? UseStl { get => this._useStl; set => this._useStl = value; }

        /// <summary>Creates an new <see cref="ForecastingSettings" /> instance.</summary>
        public ForecastingSettings()
        {

        }
    }
    /// Forecasting specific parameters.
    public partial interface IForecastingSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Country or region for holidays for forecasting tasks.
        /// These should be ISO 3166 two-letter country/region codes, for example 'US' or 'GB'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Country or region for holidays for forecasting tasks.
        These should be ISO 3166 two-letter country/region codes, for example 'US' or 'GB'.",
        SerializedName = @"countryOrRegionForHolidays",
        PossibleTypes = new [] { typeof(string) })]
        string CountryOrRegionForHoliday { get; set; }
        /// <summary>
        /// Number of periods between the origin time of one CV fold and the next fold. For
        /// example, if `CVStepSize` = 3 for daily data, the origin time for each fold will be
        /// three days apart.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of periods between the origin time of one CV fold and the next fold. For
        example, if `CVStepSize` = 3 for daily data, the origin time for each fold will be
        three days apart.",
        SerializedName = @"cvStepSize",
        PossibleTypes = new [] { typeof(int) })]
        int? CvStepSize { get; set; }
        /// <summary>Flag for generating lags for the numeric features with 'auto' or null.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag for generating lags for the numeric features with 'auto' or null.",
        SerializedName = @"featureLags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureLags) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureLags? FeatureLag { get; set; }
        /// <summary>[Required] Set forecast horizon value selection mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"[Required] Set forecast horizon value selection mode.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastHorizonMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastHorizonMode? ForecastHorizonMode { get; set; }
        /// <summary>
        /// When forecasting, this parameter represents the period with which the forecast is desired, for example daily, weekly,
        /// yearly, etc. The forecast frequency is dataset frequency by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When forecasting, this parameter represents the period with which the forecast is desired, for example daily, weekly, yearly, etc. The forecast frequency is dataset frequency by default.",
        SerializedName = @"frequency",
        PossibleTypes = new [] { typeof(string) })]
        string Frequency { get; set; }
        /// <summary>[Required] Seasonality mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"[Required] Seasonality mode.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SeasonalityMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SeasonalityMode? SeasonalityMode { get; set; }
        /// <summary>The parameter defining how if AutoML should handle short time series.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The parameter defining how if AutoML should handle short time series.",
        SerializedName = @"shortSeriesHandlingConfig",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ShortSeriesHandlingConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ShortSeriesHandlingConfiguration? ShortSeriesHandlingConfig { get; set; }
        /// <summary>
        /// The function to be used to aggregate the time series target column to conform to a user specified frequency.
        /// If the TargetAggregateFunction is set i.e. not 'None', but the freq parameter is not set, the error is raised. The possible
        /// target aggregation functions are: "sum", "max", "min" and "mean".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The function to be used to aggregate the time series target column to conform to a user specified frequency.
        If the TargetAggregateFunction is set i.e. not 'None', but the freq parameter is not set, the error is raised. The possible target aggregation functions are: ""sum"", ""max"", ""min"" and ""mean"".",
        SerializedName = @"targetAggregateFunction",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetAggregationFunction) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetAggregationFunction? TargetAggregateFunction { get; set; }
        /// <summary>[Required] Set target lags mode - Auto/Custom</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"[Required] Set target lags mode - Auto/Custom",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetLagsMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetLagsMode? TargetLagMode { get; set; }
        /// <summary>[Required] TargetRollingWindowSiz detection mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"[Required] TargetRollingWindowSiz detection mode.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetRollingWindowSizeMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetRollingWindowSizeMode? TargetRollingWindowSizeMode { get; set; }
        /// <summary>
        /// The name of the time column. This parameter is required when forecasting to specify the datetime column in the input data
        /// used for building the time series and inferring its frequency.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the time column. This parameter is required when forecasting to specify the datetime column in the input data used for building the time series and inferring its frequency.",
        SerializedName = @"timeColumnName",
        PossibleTypes = new [] { typeof(string) })]
        string TimeColumnName { get; set; }
        /// <summary>
        /// The names of columns used to group a timeseries. It can be used to create multiple series.
        /// If grain is not defined, the data set is assumed to be one time-series. This parameter is used with task type forecasting.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The names of columns used to group a timeseries. It can be used to create multiple series.
        If grain is not defined, the data set is assumed to be one time-series. This parameter is used with task type forecasting.",
        SerializedName = @"timeSeriesIdColumnNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] TimeSeriesIdColumnName { get; set; }
        /// <summary>Configure STL Decomposition of the time-series target column.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Configure STL Decomposition of the time-series target column.",
        SerializedName = @"useStl",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.UseStl) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.UseStl? UseStl { get; set; }

    }
    /// Forecasting specific parameters.
    internal partial interface IForecastingSettingsInternal

    {
        /// <summary>
        /// Country or region for holidays for forecasting tasks.
        /// These should be ISO 3166 two-letter country/region codes, for example 'US' or 'GB'.
        /// </summary>
        string CountryOrRegionForHoliday { get; set; }
        /// <summary>
        /// Number of periods between the origin time of one CV fold and the next fold. For
        /// example, if `CVStepSize` = 3 for daily data, the origin time for each fold will be
        /// three days apart.
        /// </summary>
        int? CvStepSize { get; set; }
        /// <summary>Flag for generating lags for the numeric features with 'auto' or null.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureLags? FeatureLag { get; set; }
        /// <summary>The desired maximum forecast horizon in units of time-series frequency.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IForecastHorizon ForecastHorizon { get; set; }
        /// <summary>[Required] Set forecast horizon value selection mode.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastHorizonMode? ForecastHorizonMode { get; set; }
        /// <summary>
        /// When forecasting, this parameter represents the period with which the forecast is desired, for example daily, weekly,
        /// yearly, etc. The forecast frequency is dataset frequency by default.
        /// </summary>
        string Frequency { get; set; }
        /// <summary>
        /// Set time series seasonality as an integer multiple of the series frequency.
        /// If seasonality is set to 'auto', it will be inferred.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISeasonality Seasonality { get; set; }
        /// <summary>[Required] Seasonality mode.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SeasonalityMode? SeasonalityMode { get; set; }
        /// <summary>The parameter defining how if AutoML should handle short time series.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ShortSeriesHandlingConfiguration? ShortSeriesHandlingConfig { get; set; }
        /// <summary>
        /// The function to be used to aggregate the time series target column to conform to a user specified frequency.
        /// If the TargetAggregateFunction is set i.e. not 'None', but the freq parameter is not set, the error is raised. The possible
        /// target aggregation functions are: "sum", "max", "min" and "mean".
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetAggregationFunction? TargetAggregateFunction { get; set; }
        /// <summary>The number of past periods to lag from the target column.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITargetLags TargetLag { get; set; }
        /// <summary>[Required] Set target lags mode - Auto/Custom</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetLagsMode? TargetLagMode { get; set; }
        /// <summary>
        /// The number of past periods used to create a rolling window average of the target column.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITargetRollingWindowSize TargetRollingWindowSize { get; set; }
        /// <summary>[Required] TargetRollingWindowSiz detection mode.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TargetRollingWindowSizeMode? TargetRollingWindowSizeMode { get; set; }
        /// <summary>
        /// The name of the time column. This parameter is required when forecasting to specify the datetime column in the input data
        /// used for building the time series and inferring its frequency.
        /// </summary>
        string TimeColumnName { get; set; }
        /// <summary>
        /// The names of columns used to group a timeseries. It can be used to create multiple series.
        /// If grain is not defined, the data set is assumed to be one time-series. This parameter is used with task type forecasting.
        /// </summary>
        string[] TimeSeriesIdColumnName { get; set; }
        /// <summary>Configure STL Decomposition of the time-series target column.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.UseStl? UseStl { get; set; }

    }
}