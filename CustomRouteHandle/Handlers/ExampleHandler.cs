﻿namespace CustomRouteHandle.Handlers
{
	public class ExampleHandler
	{
		public RequestDelegate Handler() {




			return async c =>
			{
				await c.Response.WriteAsync("Hello world!");
			}; 
		}
	}
}
