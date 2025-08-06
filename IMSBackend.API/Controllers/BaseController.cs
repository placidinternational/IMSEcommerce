using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;

namespace IMSBackend.BackendAPI.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{
    private ISender _sender;
    protected ISender Sender => _sender ?? (_sender = HttpContext.RequestServices.GetService<ISender>());
    protected CancellationToken _cancellationToken => CancellationToken.None;

    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("ignore1")]
    public string GetHeader(string key, bool auth = false)
    {
        try
        {
            var valueHeader = Request.Headers.FirstOrDefault(x => x.Key == key);
            return valueHeader.Value.ToString().Replace("Bearer", "").Replace(" ", "").Trim();
        }
        catch (System.Exception)
        {
            return "";
        }
    }

    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("ignore3")]
    public string GetCustomerId()
    {
        try
        {
            Request.Headers.TryGetValue("auth_customer_id", out var customerid);
            return customerid;
        }
        catch (System.Exception)
        {
            throw new Exception("Unable to get customer identification at the moment, try again");
        }
    }


    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("ignore3")]
    public (Guid unique, string role) GetCustomerUniqueId()
    {
        try
        {
            string jwtData = string.Empty;
            Guid _unique = new Guid();
            string _role = string.Empty;
            if (Request.Headers.TryGetValue("Authorization", out var headerAuth))
            {
                jwtData = headerAuth.First().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];

                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(jwtData);
                string json = JsonConvert.SerializeObject(jwtToken);
                var list = jwtToken.Claims.ToList();
                string nameId = list.Where(x => x.Type == "nameid").FirstOrDefault().Value;
                _unique = Guid.Parse(nameId);
                if (list.Where(x => x.Type == "role").FirstOrDefault() != null)
                {
                    _role = Convert.ToString(list.Where(x => x.Type == "role").FirstOrDefault().Value);
                }
            }
            if (_unique == Guid.Empty)
            {
                throw new Exception("Unable to get customer identification at the moment, try again");
            }
            return (_unique, _role);
        }
        catch (System.Exception)
        {
            throw new Exception("Unable to get customer identification at the moment, try again");
        }
    }

    /// <summary>
    /// Get user device information
    /// </summary>
    /// <returns></returns>
    [ApiExplorerSettings(IgnoreApi = true)]
    [NonAction]
    public (string? ipaddress, string? browser, string? device) GetUserDeviceInformation()
    {
        if (Request.Headers.ContainsKey("X-Forwarded-For"))
            return (Request.Headers["X-Forwarded-For"], Request.Headers["User-Agent"].ToString(), Request.Headers["Sec-CH-UA-Model"].ToString());
        else
            return (HttpContext.Connection.RemoteIpAddress?.MapToIPv4().ToString(), Request.Headers["User-Agent"].ToString(), Request.Headers["Sec-CH-UA-Model"].ToString());
    }

}
