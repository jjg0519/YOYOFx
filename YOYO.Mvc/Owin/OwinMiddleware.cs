﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YOYO.Owin.Pipeline;

namespace YOYO.Mvc.Owin
{
    public class OwinMiddleware : PipelineComponent
    {

        public override async Task Invoke(IDictionary<string, object> requestEnvironment, Func<IDictionary<string, object>, Task> next)
        {
            

        }

    }
}