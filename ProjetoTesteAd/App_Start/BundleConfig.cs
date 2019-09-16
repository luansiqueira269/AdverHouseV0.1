using System.Web;
using System.Web.Optimization;

namespace ProjetoTesteAd
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
               "~/Scripts/vendor/jquery/jquery.min.js",
               "~/Scripts/vendor/momentjs/moment.min.js",
                "~/Scripts/vendor/datepickerjquery/datepickerjquery.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/scriptscustom").Include(
                  "~/Scripts/adverhousecustom.js"
            ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/vendor/bootstrap/bootstrap.min.css",
                      "~/Content/vendor/datepickerjquery/datepickerjquery.min.css",
                      "~/Content/adverhousecustom.css"));
        }
    }
}
