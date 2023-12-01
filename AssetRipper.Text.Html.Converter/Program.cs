﻿using System.Net;
using System.Text;

namespace AssetRipper.Text.Html.Converter;

internal static class Program
{
	private const string DefaultHtmlString = """
		<html>
			<body>
				<h1>Hello, <a href="https://github.com/AngleSharp/AngleSharp" v-if="true">AngleSharp</a>!</h1>
			</body>
		</html>
		""";

	private const string HtmlFormName = "Html";

	static void Main(string[] args)
	{
		WebApplicationBuilder builder = WebApplication.CreateSlimBuilder(args);

		builder.WebHost.UseKestrelHttpsConfiguration();

		WebApplication app = builder.Build();

		app.UseHttpsRedirection();

		app.MapGet("/", () => Results.Redirect("/Edit"));

		app.MapGet("/Edit", () =>
		{
			StringWriter writer = new();
			BuildEdit(writer, DefaultHtmlString);
			return Results.Text(writer.ToString(), "text/html", Encoding.UTF8);
		});

		app.MapPost("/Edit", async (context) =>
		{
			string html = (string?)context.Request.Form[HtmlFormName] ?? DefaultHtmlString;
			StringWriter writer = new();
			BuildEdit(writer, html);
			context.Response.ContentType = "text/html";
			await context.Response.WriteAsync(writer.ToString());
		});

		app.MapPost("/Result", async (context) =>
		{
			string html = (string?)context.Request.Form[HtmlFormName] ?? DefaultHtmlString;
			StringWriter writer = new();
			BuildResult(writer, html);
			context.Response.ContentType = "text/html";
			await context.Response.WriteAsync(writer.ToString());
		});

		app.Run();
	}

	private static void BuildEdit(TextWriter writer, string html)
	{
		using (new Html(writer).WithLang("en").End())
		{
			WriteHead(writer, "HTML Converter");
			using (new Body(writer).WithCustomAttribute("data-bs-theme", "dark").End())
			{
				using (new Form(writer).WithAction("/Result").WithMethod("post").End())
				{
					using (new Textarea(writer).WithName(HtmlFormName).WithClass("bg-dark-subtle rounded-3 p-2")
						.WithStyle("width: 100%; height: 90%")
						.End())
					{
						writer.Write(WebUtility.HtmlEncode(html));
					}
					using (new Div(writer).WithClass("text-center").End())
					{
						new Input(writer).WithClass("btn btn-primary").WithType("submit").WithValue("Submit").Close();
					}
				}
				Bootstrap.WriteScriptReference(writer);
			}
		}
	}

	private static void BuildResult(TextWriter writer, string html)
	{
		using (new Html(writer).WithLang("en").End())
		{
			WriteHead(writer, "HTML Converter Result");
			using (new Body(writer).WithCustomAttribute("data-bs-theme", "dark").End())
			{
				using (new Pre(writer).WithClass("bg-dark-subtle rounded-3 p-2").End())
				{
					writer.Write(WebUtility.HtmlEncode(ConvertToCSharp(html)));
				}
				using (new Form(writer).WithAction("/Edit").WithMethod("post").End())
				{
					new Input(writer).WithType("hidden").WithName(HtmlFormName).WithValue(WebUtility.HtmlEncode(html)).Close();
					using (new Div(writer).WithClass("text-center").End())
					{
						new Input(writer).WithClass("btn btn-secondary").WithType("submit").WithValue("Go Back").Close();
					}
				}
				Bootstrap.WriteScriptReference(writer);
			}
		}

		static string ConvertToCSharp(string html)
		{
			try
			{
				return HtmlConverter.Convert(html);
			}
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}
	}

	private static void WriteHead(TextWriter writer, string title)
	{
		using (new Head(writer).End())
		{
			new Meta(writer).WithCharset("utf-8").Close();
			new Meta(writer).WithName("viewport").WithContent("width=device-width, initial-scale=1.0").Close();
			using (new Title(writer).End())
			{
				writer.Write(title);
			}
			Bootstrap.WriteStyleSheetReference(writer);
		}
	}
}
