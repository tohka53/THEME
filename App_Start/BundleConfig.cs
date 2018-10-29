using System.Web.Optimization;

namespace Theme
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include(
                      "~/Content/assets/css/style.css",
                      "~/Content/assets/css/widget.css",
                      "~/Content/bower_components/bootstrap/css/bootstrap.min.css",
                      "~/Content/assets/pages/waves/css/waves.min.css",
                      "~/Content/assets/icon/feather/css/feather.css"

                ));
  


                                           bundles.Add(new ScriptBundle("~/bundles/js").Include(



                                                "~/Content/bower_components/jquery/js/jquery.min.js",
                                                "~/Content/bower_components/jquery-ui/js/jquery-ui.min.js",
                                               "~/Content/bower_components/popper.js/js/popper.min.js",
                                                "~/Content/bower_components/bootstrap/js/bootstrap.min.js",
                                                "~/Content/assets/pages/waves/js/waves.min.js",
                                               "~/Content/bower_components/jquery-slimscroll/js/jquery.slimscroll.js",
                                                "~/Content/assets/pages/chart/float/jquery.flot.js",
                                                "~/Content/assets/pages/chart/float/jquery.flot.categories.js",
                                                 "~/Content/assets/pages/chart/float/curvedLines.js",
                                                 "~/Content/assets/pages/chart/float/jquery.flot.tooltip.min.js",
                                                  "~/Content/assets/pages/widget/amchart/amcharts.js",
                                                  "~/Content/assets/pages/widget/amchart/serial.js",
                                                  "~/Content/assets/pages/widget/amchart/light.js",
                                                  "~/Content/assets/js/pcoded.min.js",
                                                  "~/Content/assets/js/vertical/vertical-layout.min.js",
                                                  "~/Content/assets/pages/dashboard/custom-dashboard.min.js",
                                                  "~/Content/assets/js/script.min.js"


                                               ));

        }
    }
}
