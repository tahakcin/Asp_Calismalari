﻿
namespace RouteYapilanmasi.Constraints
{
	public class CustomConstraint : IRouteConstraint
	{
		public bool Match(HttpContext? httpContext,
			IRouter? route,
			string routeKey,
			RouteValueDictionary values,
			RouteDirection routeDirection)
		{
			var idvalue = values[routeKey];
			return true;
		}
	}
}
