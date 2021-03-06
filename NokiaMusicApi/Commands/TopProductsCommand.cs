// -----------------------------------------------------------------------
// <copyright file="TopProductsCommand.cs" company="Nokia">
// Copyright (c) 2012, Nokia
// All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Nokia.Music.Phone.Internal;
using Nokia.Music.Phone.Internal.Response;
using Nokia.Music.Phone.Types;

namespace Nokia.Music.Phone.Commands
{
    /// <summary>
    /// Gets a chart
    /// </summary>
    internal sealed class TopProductsCommand : SearchCatalogCommand<Product>
    {
        private string _category;

        /// <summary>
        /// Gets or sets the category - only Album and Track charts are available.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Appends the uri subpath and parameters specific to this API method
        /// </summary>
        /// <param name="uri">The base uri</param>
        internal override void AppendUriPath(System.Text.StringBuilder uri)
        {
            uri.AppendFormat("products/charts/{0}/", this._category);
        }

        /// <summary>
        /// Executes the command
        /// </summary>
        protected override void Execute()
        {
            this.ValidateCategory();

            this.RequestHandler.SendRequestAsync(
                this,
                this.MusicClientSettings,
                null,
                new JsonResponseCallback(rawResult => this.CatalogItemResponseHandler(rawResult, ArrayNameItems, Product.FromJToken, Callback)));
        }

        /// <summary>
        /// Ensures that the supplied category is one of the supported types
        /// </summary>
        private void ValidateCategory()
        {
            switch (this.Category)
            {
                case Category.Album:
                case Category.Track:
                    this._category = this.Category.ToString().ToLowerInvariant();
                    break;

                default:
                    throw new ArgumentOutOfRangeException("Category", "Only Album and Track charts are available");
            }
        }
    }
}