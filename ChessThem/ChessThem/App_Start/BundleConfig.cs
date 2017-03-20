using System.Web.Optimization;

namespace ChessThem
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/scripts/jquery").Include("~/Scripts/jquery-{version}.js"));
			bundles.Add(new ScriptBundle("~/scripts/jquery-validate").Include("~/Scripts/jquery.validate*"));
			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/scripts/modernizr").Include("~/Scripts/modernizr-*"));
			bundles.Add(new ScriptBundle("~/scripts/bootstrap").Include("~/Scripts/bootstrap.js", "~/Scripts/respond.js"));
			bundles.Add(new ScriptBundle("~/scripts/signalr").Include("~/Scripts/jquery.signalR-*"));
			bundles.Add(new ScriptBundle("~/scripts/custom").IncludeDirectory("~/Javascript", "*.js", true));

			bundles.Add(new StyleBundle("~/styles/bootstrap").Include("~/Content/bootstrap.css"));
			bundles.Add(new StyleBundle("~/styles/custom").IncludeDirectory("~/Less", "*.css", true));
		}
	}
}
