//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.12.2
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "chooseUsSection"
	/// <summary>Choose Us Section</summary>
	public partial interface IChooseUsSection : IPublishedContent
	{
		/// <summary>Choose Us Features</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.ChooseUsItem> ChooseUsFeatures { get; }

		/// <summary>Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		global::Umbraco.Core.Models.PublishedContent.IPublishedContent ChooseUsImage { get; }

		/// <summary>Subtitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		string ChooseUsSubtitle { get; }

		/// <summary>Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		string ChooseUsTitle { get; }

		/// <summary>Shoe Choose Us Section</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		bool ShoeChooseUsSection { get; }
	}

	/// <summary>Choose Us Section</summary>
	[PublishedModel("chooseUsSection")]
	public partial class ChooseUsSection : PublishedContentModel, IChooseUsSection
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public new const string ModelTypeAlias = "chooseUsSection";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ChooseUsSection, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ChooseUsSection(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Choose Us Features
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		[ImplementPropertyType("chooseUsFeatures")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.ChooseUsItem> ChooseUsFeatures => GetChooseUsFeatures(this);

		/// <summary>Static getter for Choose Us Features</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public static global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.ChooseUsItem> GetChooseUsFeatures(IChooseUsSection that) => that.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.ChooseUsItem>>("chooseUsFeatures");

		///<summary>
		/// Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		[ImplementPropertyType("chooseUsImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent ChooseUsImage => GetChooseUsImage(this);

		/// <summary>Static getter for Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public static global::Umbraco.Core.Models.PublishedContent.IPublishedContent GetChooseUsImage(IChooseUsSection that) => that.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("chooseUsImage");

		///<summary>
		/// Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		[ImplementPropertyType("chooseUsSubtitle")]
		public string ChooseUsSubtitle => GetChooseUsSubtitle(this);

		/// <summary>Static getter for Subtitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public static string GetChooseUsSubtitle(IChooseUsSection that) => that.Value<string>("chooseUsSubtitle");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		[ImplementPropertyType("chooseUsTitle")]
		public string ChooseUsTitle => GetChooseUsTitle(this);

		/// <summary>Static getter for Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public static string GetChooseUsTitle(IChooseUsSection that) => that.Value<string>("chooseUsTitle");

		///<summary>
		/// Shoe Choose Us Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		[ImplementPropertyType("shoeChooseUsSection")]
		public bool ShoeChooseUsSection => GetShoeChooseUsSection(this);

		/// <summary>Static getter for Shoe Choose Us Section</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public static bool GetShoeChooseUsSection(IChooseUsSection that) => that.Value<bool>("shoeChooseUsSection");
	}
}
