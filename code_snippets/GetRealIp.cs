        protected string GetRealIp()
        {
            return Request.Headers.ContainsKey("X-Forwarded-For") 
                    ? Request.Headers["X-Forwarded-For"].ToString()
                    : HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }
       

