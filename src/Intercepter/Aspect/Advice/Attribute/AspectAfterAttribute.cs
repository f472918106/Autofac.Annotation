using System.Threading.Tasks;
using Autofac.Annotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Autofac.Aspect.Advice
{

    /// <summary>
    /// 后置通知
    /// </summary>
    public abstract class AspectAfter : AspectInvokeAttribute
    {
        /// <summary>
        /// 后置执行
        /// </summary>
        /// <param name="aspectContext"></param>
        /// <param name="result"></param>
        public abstract Task After(AspectContext aspectContext,object result);

    }

}