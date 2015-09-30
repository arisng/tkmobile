using System.Web.Optimization;

namespace TKMobile
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-scrolltofixed.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/datetime").Include(
                "~/Scripts/moment*",
                "~/Scripts/bootstrap-datetimepicker*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/eshopper").Include(
                "~/Scripts/eshopper/*.js",
                "~/Scripts/eshopper/jquery.scrollUp.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/ism").Include(
                "~/Scripts/ism/ism-2.0.1.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/font-awesome.css",
                "~/Content/my-slider.css",
                "~/Content/eshopper/*.css"));

            bundles.Add(new StyleBundle("~/Content/datetime-css").Include(
                "~/Content/bootstrap-datetimepicker.css"));
        }
    }
}
