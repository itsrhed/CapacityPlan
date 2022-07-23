using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CapacityPlanApp.Core.DTO.Response
{
    public class ApiResponse
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public HttpStatusCode Code { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Domain.JsonResult" /> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="code">The code.</param>
        public ApiResponse(object value, HttpStatusCode code)
        {
            Value = value;
            Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CSSResponse"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        public ApiResponse(HttpStatusCode code)
        {
            Code = code;
        }
    }
}
