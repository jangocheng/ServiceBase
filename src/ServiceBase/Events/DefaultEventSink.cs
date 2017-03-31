﻿using Microsoft.Extensions.Logging;
using ServiceBase.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ServiceBase.Events
{
    /// <summary>
    /// Default implementation of the event service. Write events raised to the log.
    /// </summary>
    public class DefaultEventSink : IEventSink
    {
        /// <summary>
        /// The logger
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultEventSink"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public DefaultEventSink(ILogger<DefaultEventService> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Raises the specified event.
        /// </summary>
        /// <param name="evt">The event.</param>
        /// <exception cref="System.ArgumentNullException">evt</exception>
        public virtual Task PersistAsync(Event evt)
        {
            if (evt == null) throw new ArgumentNullException(nameof(evt));

            var json = LogSerializer.Serialize(evt);
            _logger.LogInformation(json);

            return Task.FromResult(0);
        }
    }
}
