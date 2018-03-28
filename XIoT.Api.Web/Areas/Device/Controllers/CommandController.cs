using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace XIoT.Api.Web.Areas.Device.Controllers
{
    /// <summary>
    /// 设备指令
    /// </summary>
    public class CommandController : ApiController
    {
        /// <summary>
        /// 设备公共指令
        /// </summary>
        /// <param name="token">令牌</param>
        /// <param name="did">设备编码</param>
        /// <param name="cmd">设备指令</param>
        /// <returns></returns>
        public string Write(String token, String did, String cmd)
        {
            return "value";
        }
    }
}
