﻿using System.Web;
using System.Web.Optimization;

namespace BarbisanBruegger
{
	public class BundleConfig
	{
		// Weitere Informationen zur Bündelung finden Sie unter https://go.microsoft.com/fwlink/?LinkId=301862.
		public static void RegisterBundles( BundleCollection bundles )
		{
			bundles.Add( new ScriptBundle( "~/bundles/jquery" ).Include(
						"~/Scripts/jquery-{version}.js" ) );

			bundles.Add( new ScriptBundle( "~/bundles/jqueryval" ).Include(
						"~/Scripts/jquery.validate*" ) );

            bundles.Add(new ScriptBundle("~/bundles/jquery-easing").Include(
                        "~/Scripts/jquery.easing.{version}.js"));

            // Verwenden Sie die Entwicklungsversion von Modernizr zum Entwickeln und Erweitern Ihrer Kenntnisse. Wenn Sie dann
            // bereit ist für die Produktion, verwenden Sie das Buildtool unter https://modernizr.com, um nur die benötigten Tests auszuwählen.
            bundles.Add( new ScriptBundle( "~/bundles/modernizr" ).Include(
						"~/Scripts/modernizr-*" ) );

			bundles.Add( new ScriptBundle( "~/bundles/bootstrap" ).Include(
                      "~/Scripts/scrolling-nav.js",
                      "~/Scripts/bootstrap.js" ) );

            bundles.Add(new ScriptBundle("~/bundles/scrolling-nav").Include(
                      "~/Scripts/scrolling-nav.js"));

            bundles.Add( new StyleBundle( "~/Content/css" ).Include(
					  "~/Content/bootstrap.css",
                      "~/Content/site.css" ) );

		}
	}
}
