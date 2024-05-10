//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.1.1+7b00c0d
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "siteNavigationProperties"
	/// <summary>Site Navigation Properties</summary>
	public partial interface ISiteNavigationProperties : IPublishedElement
	{
		/// <summary>Main Navigation</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.1+7b00c0d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.NavigationItem> MainNavigation { get; }
	}

	/// <summary>Site Navigation Properties</summary>
	[PublishedModel("siteNavigationProperties")]
	public partial class SiteNavigationProperties : PublishedElementModel, ISiteNavigationProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.1+7b00c0d")]
		public new const string ModelTypeAlias = "siteNavigationProperties";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.1+7b00c0d")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.1+7b00c0d")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.1+7b00c0d")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<SiteNavigationProperties, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public SiteNavigationProperties(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Main Navigation: Add the links for the main navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.1+7b00c0d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mainNavigation")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.NavigationItem> MainNavigation => GetMainNavigation(this, _publishedValueFallback);

		/// <summary>Static getter for Main Navigation</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.1.1+7b00c0d")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.NavigationItem> GetMainNavigation(ISiteNavigationProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.NavigationItem>>(publishedValueFallback, "mainNavigation");
	}
}
