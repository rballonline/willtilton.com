using Nancy;

namespace WillTilton
{
	public class DefaultModule : NancyModule
	{
		public DefaultModule()
		{
			Get["/"] = _ => { return View["Index"]; };
		}
	}
}