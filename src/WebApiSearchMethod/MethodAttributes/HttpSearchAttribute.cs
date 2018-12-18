using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Routing;

namespace WebApiSearchMethod.MethodAttributes
{
    /// <summary>
    /// Identifies an action that supports the HTTP SEARCH method
    /// </summary>
    public class HttpSearchAttribute : HttpMethodAttribute
    {

        private static readonly IEnumerable<string> SupportedMethods = new[] { "SEARCH" };

        public HttpSearchAttribute() : base(SupportedMethods)
        {
        }

        public HttpSearchAttribute(string template) : base(SupportedMethods, template)
        {
            if (string.IsNullOrWhiteSpace(template))
            {
                throw new ArgumentNullException(nameof(template));
            }
        }
    }
}
