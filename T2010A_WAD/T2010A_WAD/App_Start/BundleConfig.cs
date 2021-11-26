using System.Web;
using System.Web.Optimization;

namespace T2010A_WAD
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

            //Add css adminLTE
            bundles.Add(new StyleBundle("~/AdminLTE/css").Include(
                       "~/Content/plugins/fontawesome-free/css/all.min.css",
                       "~/Content/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                       "~/Content/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                       "~/Content/plugins/jqvmap/jqvmap.min.css",
                       "~/Content/dist/css/adminlte.min.css",
                       "~/Content/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                       "~/Content/plugins/daterangepicker/daterangepicker.css",
                       "~/Content/plugins/summernote/summernote-bs4.min.css"
                       ));
            // add js adminLTE

            bundles.Add(new StyleBundle("~/AdminLTE/js").Include(
                         "~/Content/plugins/jquery/jquery.min.js",
                         "~/Content/plugins/jquery-ui/jquery-ui.min.js",
                         "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js",
                         "~/Content/plugins/chart.js/Chart.min.js",
                         "~/Content/plugins/sparklines/sparkline.js",
                         "~/Content/plugins/jqvmap/jquery.vmap.min.js",
                         "~/Content/plugins/jqvmap/maps/jquery.vmap.usa.js",
                         "~/Content/plugins/jquery-knob/jquery.knob.min.js",
                         "~/Content/plugins/moment/moment.min.js",
                         "~/Content/plugins/daterangepicker/daterangepicker.js",
                         "~/Content/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                         "~/Content/plugins/summernote/summernote-bs4.min.js",
                         "~/Content/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                         "~/Content/dist/js/adminlte.js",
                         "~/Content/dist/js/demo.js",
                         "~/Content/dist/js/pages/dashboard.js"
                ));
        }
    }
}
