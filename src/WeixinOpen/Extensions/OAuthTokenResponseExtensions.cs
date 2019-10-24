﻿using Microsoft.AspNetCore.Authentication.OAuth;
using System;
using System.Collections.Generic;
using System.Text;

namespace Myvas.AspNetCore.Authentication.WeixinOpen.Extensions
{
    internal static class OAuthTokenResponseExtensions
    {
        public static string GetUnionId(this OAuthTokenResponse response)
        {
            return response.Response.Value<string>("unionid");
        }

        public static string GetOpenId(this OAuthTokenResponse response)
        {
            return response.Response.Value<string>("openid");
        }

        public static string GetScope(this OAuthTokenResponse response)
        {
            return response.Response.Value<string>("scope");
        }

        public static string GetErrorCode(this OAuthTokenResponse response)
        {
            return response.Response.Value<string>("errcode");
        }

        public static string GetErrorMsg(this OAuthTokenResponse response)
        {
            return response.Response.Value<string>("errmsg");
        }
    }
}
