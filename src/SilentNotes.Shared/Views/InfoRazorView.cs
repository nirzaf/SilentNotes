#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SilentNotes.Views
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#line 1 "InfoRazorView.cshtml"
using SilentNotes.ViewModels;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "16.9.0.273")]
public partial class InfoRazorView : InfoRazorViewBase
{

#line hidden

#line 2 "InfoRazorView.cshtml"
public InfoViewModel Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(" />\r\n    <base");

WriteAttribute ("href", " href=\"", "\""

#line 7 "InfoRazorView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.HtmlBase

#line default
#line hidden
, false)
);
WriteLiteral(">\r\n    <title>SilentNotes</title>\r\n    <meta");

WriteLiteral(" charset=\"UTF-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1, shrink-to-fit=no, user-scalable=no" +
"\"");

WriteLiteral(">\r\n\r\n    <link");

WriteLiteral(" href=\"bootstrap.min.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"silentnotes.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute ("href", " href=\"", "\""

#line 14 "InfoRazorView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.Theme.DarkMode ? "silentnotes.dark.css" : "silentnotes.light.css"

#line default
#line hidden
, false)
);
WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n\r\n    <script");

WriteAttribute ("src", " src=\"", "\""

#line 16 "InfoRazorView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.HtmlRecource["vuejs"]

#line default
#line hidden
, false)
);
WriteLiteral("></script>\r\n    <script");

WriteAttribute ("src", " src=\"", "\""

#line 17 "InfoRazorView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.HtmlRecource["jqueryjs"]

#line default
#line hidden
, false)
);
WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"silentnotes.js\"");

WriteLiteral("></script>\r\n\r\n    <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n    </style>\r\n    <script>\r\n");


#line 23 "InfoRazorView.cshtml"
        

#line default
#line hidden

#line 23 "InfoRazorView.cshtml"
          WriteLiteral(Model.VueDataBindingScript);

#line default
#line hidden
WriteLiteral("\r\n    </script>\r\n</head>\r\n<body><div");

WriteLiteral(" id=\"vueDataBinding\"");

WriteLiteral(">\r\n    <nav");

WriteLiteral(" id=\"navigation\"");

WriteLiteral(" class=\"d-flex\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" class=\"nav-item mr-auto\"");

WriteLiteral(" v-on:click=\"GoBackCommand\"");

WriteAttribute ("title", " title=\"", "\""

#line 28 "InfoRazorView.cshtml"
                                    , Tuple.Create<string,object,bool> ("", Model.Language["back"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 28 "InfoRazorView.cshtml"
                                                                                                      WriteLiteral(Model.Icon["arrow-left"]);

#line default
#line hidden
WriteLiteral("</button>\r\n    </nav>\r\n\r\n    <div");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"container-fluid p-4\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-4\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" src=\"SilentNotes256.png\"");

WriteLiteral(" class=\"pb-3 img-fluid\"");

WriteLiteral(" />\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"col-sm-8\"");

WriteLiteral(">\r\n                <h1>SilentNotes</h1>\r\n\r\n                <table");

WriteLiteral(" class=\"my-3 table table-sm\"");

WriteLiteral(">\r\n                    <tr>\r\n                        <th");

WriteLiteral(" class=\"\"");

WriteLiteral(">");


#line 42 "InfoRazorView.cshtml"
                                Write(Model.Language["version"]);


#line default
#line hidden
WriteLiteral("</th>\r\n                        <td v-once>{{ VersionFmt }}</td>\r\n                " +
"    </tr>\r\n                    <tr>\r\n                        <th");

WriteLiteral(" class=\"\"");

WriteLiteral(">");


#line 46 "InfoRazorView.cshtml"
                                Write(Model.Language["copyright"]);


#line default
#line hidden
WriteLiteral("</th>\r\n                        <td>Martin Stoeckli - 2017</td>\r\n                 " +
"   </tr>\r\n                    <tr>\r\n                        <th");

WriteLiteral(" class=\"\"");

WriteLiteral(">");


#line 50 "InfoRazorView.cshtml"
                                Write(Model.Language["website"]);


#line default
#line hidden
WriteLiteral("</th>\r\n                        <td><a");

WriteLiteral(" v-on:click=\"OpenHomepageCommand\"");

WriteLiteral(" class=\"a\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">https://www.martinstoeckli.ch/silentnotes</a></td>\r\n                    </tr>\r\n " +
"                   <tr>\r\n                        <th");

WriteLiteral(" class=\"\"");

WriteLiteral(">");


#line 54 "InfoRazorView.cshtml"
                                Write(Model.Language["opensource"]);


#line default
#line hidden
WriteLiteral("</th>\r\n                        <td>");


#line 55 "InfoRazorView.cshtml"
                       Write(Model.Language["opensource_desc"]);


#line default
#line hidden
WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n\r\n                <p>" +
"");


#line 59 "InfoRazorView.cshtml"
              Write(Model.Language["license"]);


#line default
#line hidden
WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div></body>\r\n</html>\r\n");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class InfoRazorViewBase
{

		// This field is OPTIONAL, but used by the default implementation of Generate, Write, WriteAttribute and WriteLiteral
		//
		System.IO.TextWriter __razor_writer;

		// This method is OPTIONAL
		//
		/// <summary>Executes the template and returns the output as a string.</summary>
		/// <returns>The template output.</returns>
		public string GenerateString ()
		{
			using (var sw = new System.IO.StringWriter ()) {
				Generate (sw);
				return sw.ToString ();
			}
		}

		// This method is OPTIONAL, you may choose to implement Write and WriteLiteral without use of __razor_writer
		// and provide another means of invoking Execute.
		//
		/// <summary>Executes the template, writing to the provided text writer.</summary>
		/// <param name="writer">The TextWriter to which to write the template output.</param>
		public void Generate (System.IO.TextWriter writer)
		{
			__razor_writer = writer;
			Execute ();
			__razor_writer = null;
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the template output without HTML escaping it.</summary>
		/// <param name="value">The literal value.</param>
		protected void WriteLiteral (string value)
		{
			__razor_writer.Write (value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the TextWriter without HTML escaping it.</summary>
		/// <param name="writer">The TextWriter to which to write the literal.</param>
		/// <param name="value">The literal value.</param>
		protected static void WriteLiteralTo (System.IO.TextWriter writer, string value)
		{
			writer.Write (value);
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a value to the template output, HTML escaping it if necessary.</summary>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected void Write (object value)
		{
			WriteTo (__razor_writer, value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes an object value to the TextWriter, HTML escaping it if necessary.</summary>
		/// <param name="writer">The TextWriter to which to write the value.</param>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected static void WriteTo (System.IO.TextWriter writer, object value)
		{
			if (value == null)
				return;

			var write = value as Action<System.IO.TextWriter>;
			if (write != null) {
				write (writer);
				return;
			}

			//NOTE: a more sophisticated implementation would write safe and pre-escaped values directly to the
			//instead of double-escaping. See System.Web.IHtmlString in ASP.NET 4.0 for an example of this.
			writer.Write(System.Net.WebUtility.HtmlEncode (value.ToString ()));
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to the template output.
		/// </summary>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		protected void WriteAttribute (string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			WriteAttributeTo (__razor_writer, name, prefix, suffix, values);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to a TextWriter.
		/// </summary>
		/// <param name="writer">The TextWriter to which to write the attribute.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		///<remarks>Used by Razor helpers to write attributes.</remarks>
		protected static void WriteAttributeTo (System.IO.TextWriter writer, string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			// this is based on System.Web.WebPages.WebPageExecutingBase
			// Copyright (c) Microsoft Open Technologies, Inc.
			// Licensed under the Apache License, Version 2.0
			if (values.Length == 0) {
				// Explicitly empty attribute, so write the prefix and suffix
				writer.Write (prefix);
				writer.Write (suffix);
				return;
			}

			bool first = true;
			bool wroteSomething = false;

			for (int i = 0; i < values.Length; i++) {
				Tuple<string,object,bool> attrVal = values [i];
				string attPrefix = attrVal.Item1;
				object value = attrVal.Item2;
				bool isLiteral = attrVal.Item3;

				if (value == null) {
					// Nothing to write
					continue;
				}

				// The special cases here are that the value we're writing might already be a string, or that the
				// value might be a bool. If the value is the bool 'true' we want to write the attribute name instead
				// of the string 'true'. If the value is the bool 'false' we don't want to write anything.
				//
				// Otherwise the value is another object (perhaps an IHtmlString), and we'll ask it to format itself.
				string stringValue;
				bool? boolValue = value as bool?;
				if (boolValue == true) {
					stringValue = name;
				} else if (boolValue == false) {
					continue;
				} else {
					stringValue = value as string;
				}

				if (first) {
					writer.Write (prefix);
					first = false;
				} else {
					writer.Write (attPrefix);
				}

				if (isLiteral) {
					writer.Write (stringValue ?? value);
				} else {
					WriteTo (writer, stringValue ?? value);
				}
				wroteSomething = true;
			}
			if (wroteSomething) {
				writer.Write (suffix);
			}
		}
		// This method is REQUIRED. The generated Razor subclass will override it with the generated code.
		//
		///<summary>Executes the template, writing output to the Write and WriteLiteral methods.</summary>.
		///<remarks>Not intended to be called directly. Call the Generate method instead.</remarks>
		public abstract void Execute ();

}
}
#pragma warning restore 1591
