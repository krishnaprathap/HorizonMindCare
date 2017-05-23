using System.Web.Optimization;
namespace HorizonMindCare
{
    public class BootstrapBundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/library/mvchelper").Include("~/Scripts/plugins/rrdl-theme/rrdl-dls-theme-1.3.6.9.min.js"));
            bundles.Add(new StyleBundle("~/Content/allcss").Include("~/Content/extras/*.css"));


            bundles.Add(new StyleBundle("~/Content/alljs").Include("~/Scripts/*.js"));




        }
    }
}
