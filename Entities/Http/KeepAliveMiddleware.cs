using System;
using System.Threading.Tasks;
using ECommerce.Data.Core;
using ECommerce.Data.Core.Data;
using System.Web;
using Microsoft.AspNetCore.Http;
using HttpContext = System.Web.HttpContext;

namespace ECommerce.Data.Entities.Http
{
    /// <summary>
    /// Represents middleware that checks whether request is for keep alive
    /// </summary>
    public class KeepAliveMiddleware
    {
        #region Fields

        private readonly RequestDelegate _next;

        #endregion

        #region Ctor

        public KeepAliveMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Invoke middleware actions
        /// </summary>
        /// <param name="context">HTTP context</param>
        /// <param name="webHelper">Web helper</param>
        /// <returns>Task</returns>
        public async Task Invoke(Microsoft.AspNetCore.Http.HttpContext context, IWebHelper webHelper)
        {
            //TODO test. ensure that no guest record is created

            //whether database is installed
            if (!DataSettingsManager.DatabaseIsInstalled)
            {
                //keep alive page requested (we ignore it to prevent creating a guest customer records)
                var keepAliveUrl = $"{webHelper.GetStoreLocation()}{NopHttpDefaults.KeepAlivePath}";
                if (webHelper.GetThisPageUrl(false).StartsWith(keepAliveUrl, StringComparison.InvariantCultureIgnoreCase))
                    return;
            }

            //or call the next middleware in the request pipeline
            await _next(context);
        }

        #endregion
    }
}