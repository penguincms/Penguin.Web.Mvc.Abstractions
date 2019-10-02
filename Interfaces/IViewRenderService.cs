using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Penguin.Web.Mvc.Abstractions
{
    /// <summary>
    /// Defines a class that renders MVC views to Html strings
    /// </summary>
    public interface IViewRenderService
    {
        #region Methods

        /// <summary>
        /// Renders a view by path, to an HTML string
        /// </summary>
        /// <param name="viewName">The name/path of the view</param>
        /// <param name="ExecutingPath">The executing path of the context in which its being requested</param>
        /// <param name="model">The model to pass into the view</param>
        /// <param name="Get">Should be used to determine whether or not the underlying FindView uses FindView or GetView</param>
        /// <returns>A task containing the result of an async rendering of an MVC view</returns>
        Task<string> RenderToStringAsync(string viewName, string ExecutingPath, object model, bool Get = false);

        #endregion Methods
    }
}
