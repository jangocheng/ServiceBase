﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace ServiceBase.Logging
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Helper to JSON serialize object data for logging.
    /// </summary>
    public static class LogSerializer
    {
        private static readonly JsonSerializerSettings jsonSettings =
            new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                Formatting = Formatting.Indented
            };

        static LogSerializer()
        {
            jsonSettings.Converters.Add(new StringEnumConverter());
        }

        /// <summary>
        /// Serializes the specified object.
        /// </summary>
        /// <param name="logObject">The object.</param>
        /// <returns></returns>
        public static string Serialize(object logObject)
        {
            return JsonConvert.SerializeObject(logObject, jsonSettings);
        }
    }
}