using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherMVC.Services
{
	public interface ITokenService
	{
		public Task<TokenResponse> GetToken(string scope);
	}
}
