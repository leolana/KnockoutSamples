using System.Web;
using System.Web.Optimization;

namespace ProjetoKnockout
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Assets/js/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Assets/js/jquery-ui.js"));

            bundles.Add(new StyleBundle("~/Bootstrap/css").Include(
                        "~/Assets/css/bootstrap.css",
                         "~/Assets/css/bootstrap-theme.css"
            ));

            bundles.Add(new StyleBundle("~/Main/css").Include(
                        "~/Assets/css/dashboard.css",
                        "~/Assets/css/main.css"
            ));

            bundles.Add(new StyleBundle("~/jqueryui/css").Include(
                        "~/Assets/css/jquery-ui.css"));

            bundles.Add(new ScriptBundle("~/Bootstrap/js").Include(
                        "~/Assets/js/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Knockout/js").Include(
                        "~/Assets/js/knockout-3.1.0.js"));
        }
    }
}