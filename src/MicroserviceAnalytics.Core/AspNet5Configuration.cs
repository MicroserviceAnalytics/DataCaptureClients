﻿using System;

namespace MicroserviceAnalytics.Core
{
#if DNXCORE50
    public class AspNet5Configuration : IClientConfiguration
    {
        public string PropertyId { get; }
        public string Key { get; }
        public TimeSpan UploadInterval { get; }
        public string ApiRoot { get; }
        public string CorrelationIdKey { get; }
        public bool EnableCorrelation { get; }
        public bool StripHttpQueryParams { get; }
        public string[] HttpRequestHeaderWhitelist { get; }
        public string[] HttpResponseHeaderWhitelist { get; }
        public string HttpStopwatchKey { get; }
        public bool IsRemoteUpdateEnabled { get; }
        public bool IsCaptureErrorsEnabled { get; }
        public bool IsCaptureSqlEnabled { get; }
        public bool IsCaptureHttpEnabled { get; }
        public bool IsCaptureCustomMetricEnabled { get; }
        public bool IsCaptureLogsEnabled { get; }
    }
#endif
}
