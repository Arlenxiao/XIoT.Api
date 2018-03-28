using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace XIoT.Api.Web.Controllers.User
{
    /// <summary>
    /// 用户登录
    /// </summary>
    public class LoginController : ApiController
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="user">帐号</param>
        /// <param name="pass">密码</param>
        /// <returns></returns>
        public string Login(String user, String pass)
        {
            return "value";
        }
    }
}
