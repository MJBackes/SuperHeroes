using System.Web;
using System.Web.Optimization;

namespace SuperHeroes
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

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                      "~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/home").Include("~/Content/home.css"));
            bundles.Add(new StyleBundle("~/Content/edit").Include("~/Content/edit.css"));
            bundles.Add(new StyleBundle("~/Content/heroes").Include("~/Content/heroes.css"));
            bundles.Add(new StyleBundle("~/Content/delete").Include("~/Content/delete.css"));
            bundles.Add(new StyleBundle("~/Content/create").Include("~/Content/create.css"));
        }
    }
}
