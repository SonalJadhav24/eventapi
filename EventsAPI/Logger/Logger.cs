
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace EventsAPI.Logger
{
    public class Logger : ExceptionLogger
    {
        public Logger()
        {
            var log4NetConfigDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var log4NetConfigFilePath = Path.Combine(log4NetConfigDirectory, "ErrorHandler//log4net.config");
           // log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(log4NetConfigFilePath));
        }
        public override void Log(ExceptionLoggerContext context)
        {
            base.Log(context);
        }
        public override Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken)
        {
            return base.LogAsync(context, cancellationToken);
        }

    }

    public class Handler : IExceptionHandler
    {
        public Handler() { }

        public virtual Task HandleAsync(ExceptionHandlerContext context,
                                    CancellationToken cancellationToken)
        {
            if (!ShouldHandle(context))
            {
                return Task.FromResult(0);
            }
            return HandleAsyncCore(context, cancellationToken);
        }

        public virtual Task HandleAsyncCore(ExceptionHandlerContext context,
                                           CancellationToken cancellationToken)
        {

            HandleCore(context);
            return Task.FromResult(0);
        }

        /// <summary>
        /// Handlecore function to give user defined /customzied webresponse to cliet in case of errors.
        /// </summary>
        /// <param name="context"></param>
        public virtual void HandleCore(ExceptionHandlerContext context)
        {
            var metadata = new
            {
                Message = "An error occurred! " + context.Exception.Message,
                DateTime = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(),
                RequestedURL = context.Request.RequestUri,

            };
            var response = context.Request.CreateResponse(HttpStatusCode.InternalServerError, metadata);
            context.Result = new ResponseMessageResult(response);
        }

        public virtual bool ShouldHandle(ExceptionHandlerContext context)
        {
            return true;
        }
    }
}