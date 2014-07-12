using System.Web;
using System.Web.Optimization;

namespace prjGridJson
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/assets/js/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/assets/js/jquery-ui-1.10.3.custom.js",
                        "~/assets/js/i18n/jquery.ui.datepicker-pt-BR.js"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                        "~/assets/js/knockout-3.0.0.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/assets/js/jquery.unobtrusive*",
                        "~/assets/js/jquery.validate*",
                        "~/assets/js/additional-methods.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/assets/js/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/jqGrid").Include(
                        "~/assets/js/jquery.jqGrid.js",
                        "~/assets/js/i18n/grid.locale-pt-br.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/assets/js/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootbox").Include(
                        "~/assets/js/bootbox.js"));

            bundles.Add(new ScriptBundle("~/bundles/mask").Include(
                        "~/assets/js/mask.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/assets/css/site.css"));
            bundles.Add(new StyleBundle("~/assets/css/ui").Include("~/assets/css/ui.jqgrid.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/assets/css/jquery-ui/themes/base/jquery.ui.all.css"));

            bundles.Add(new StyleBundle("~/css/bootstrap").Include(
                       "~/assets/css/bootstrap.css",
                       "~/assets/css/bootstrap-theme.css"
            ));

            bundles.Add(new StyleBundle("~/css/select2").Include(
                       "~/assets/css/select2.css",
                       "~/assets/css/select2-bootstrap.css"
            ));

            bundles.Add(new ScriptBundle("~/bundles/select2").Include(
                        "~/assets/js/select2.js",
                        "~/assets/js/i18n/select2_locale_pt-BR.js"));
        }
    }
}