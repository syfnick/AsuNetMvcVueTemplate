using System.Web;
using System.Web.Optimization;

namespace AsuNetMvcVueTemplate
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/vuestyles").Include(
                      "~/dist/css/*.css"));

            bundles.Add(new ScriptBundle("~/bundles/vue").Include(
                        "~/dist/js/*.js"));
        }
    }
}
