﻿// -----------------------------------------------------------------------
// <copyright file="IMusicClient.cs" company="Nokia">
// Copyright (c) 2012, Nokia
// All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Nokia.Music.Phone.Commands;
using Nokia.Music.Phone.Types;

namespace Nokia.Music.Phone
{
    /// <summary>
    /// Defines the Nokia Music API
    /// </summary>
    public partial interface IMusicClient
    {
        /// <summary>
        /// Searches for an Artist
        /// </summary>
        /// <param name="callback">The callback to use when the API call has completed</param>
        /// <param name="searchTerm">The search term.</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void SearchArtists(Action<ListResponse<Artist>> callback, string searchTerm, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets artist search suggestions.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="searchTerm">The search term.</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetArtistSearchSuggestions(Action<ListResponse<string>> callback, string searchTerm, int itemsPerPage = 3);

        /// <summary>
        /// Gets artists that originate around a specified location
        /// </summary>
        /// <param name="callback">The callback to use when the API call has completed</param>
        /// <param name="latitude">The latitude to search around</param>
        /// <param name="longitude">The longitude to search around</param>
        /// <param name="maxdistance">The max distance (in KM) around the location to search</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetArtistsAroundLocation(Action<ListResponse<Artist>> callback, double latitude, double longitude, int maxdistance = 10, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets the top artists
        /// </summary>
        /// <param name="callback">The callback to use when the API call has completed</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetTopArtists(Action<ListResponse<Artist>> callback, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets the top artists for a genre
        /// </summary>
        /// <param name="callback">The callback to use when the API call has completed</param>
        /// <param name="id">The genre to get results for.</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetTopArtistsForGenre(Action<ListResponse<Artist>> callback, string id, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets the top artists for a genre
        /// </summary>
        /// <param name="callback">The callback to use when the API call has completed</param>
        /// <param name="genre">The genre to get results for.</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetTopArtistsForGenre(Action<ListResponse<Artist>> callback, Genre genre, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets similar artists for an artist.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="id">The artist id.</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetSimilarArtists(Action<ListResponse<Artist>> callback, string id, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets similar artists for an artist.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="artist">The artist.</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetSimilarArtists(Action<ListResponse<Artist>> callback, Artist artist, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets products by an artist.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="id">The artist id.</param>
        /// <param name="category">The category.</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetArtistProducts(Action<ListResponse<Product>> callback, string id, Category? category = null, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets products by an artist.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="artist">The artist.</param>
        /// <param name="category">The category.</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetArtistProducts(Action<ListResponse<Product>> callback, Artist artist, Category? category = null, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets a product by product id.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="id">The product id.</param>
        void GetProduct(Action<Response<Product>> callback, string id);

        /// <summary>
        /// Gets similar products for the supplied product id.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="id">The product id.</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetSimilarProducts(Action<ListResponse<Product>> callback, string id, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets a chart
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="category">The category - only Album and Track charts are available.</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetTopProducts(Action<ListResponse<Product>> callback, Category category, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets a list of new releases
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="category">The category - only Album and Track lists are available.</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetNewReleases(Action<ListResponse<Product>> callback, Category category, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets the available genres
        /// </summary>
        /// <param name="callback">The callback to use when the API call has completed</param>
        void GetGenres(Action<ListResponse<Genre>> callback);

        /// <summary>
        /// Searches Nokia Music
        /// </summary>
        /// <param name="callback">The callback to use when the API call has completed</param>
        /// <param name="searchTerm">The search term.</param>
        /// <param name="category">The category.</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void Search(Action<ListResponse<MusicItem>> callback, string searchTerm, Category? category = null, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets search suggestions.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="searchTerm">The search term.</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetSearchSuggestions(Action<ListResponse<string>> callback, string searchTerm, int itemsPerPage = 3);

        /// <summary>
        /// Gets the Mix Groups available
        /// </summary>
        /// <param name="callback">The callback to use when the API call has completed</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetMixGroups(Action<ListResponse<MixGroup>> callback, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets the Mix Groups available
        /// </summary>
        /// <param name="callback">The callback to use when the API call has completed</param>
        /// <param name="exclusiveTag">The exclusive tag</param>
        /// <param name="startIndex">The zero-based start index to fetch items from (e.g. to get the second page of 10 items, pass in 10).</param>
        /// <param name="itemsPerPage">The number of items to fetch.</param>
        void GetMixGroups(Action<ListResponse<MixGroup>> callback, string exclusiveTag, int startIndex = MusicClient.DefaultStartIndex, int itemsPerPage = MusicClient.DefaultItemsPerPage);

        /// <summary>
        /// Gets the Mixes available in a group
        /// </summary>
        /// <param name="callback">The callback to use when the API call has completed</param>
        /// <param name="id">The mix group id.</param>
        void GetMixes(Action<ListResponse<Mix>> callback, string id);

        /// <summary>
        /// Gets the Mixes available in a group
        /// </summary>
        /// <param name="callback">The callback to use when the API call has completed</param>
        /// <param name="id">The mix group id.</param>
        /// <param name="exclusiveTag">The exclusive tag.</param>
        void GetMixes(Action<ListResponse<Mix>> callback, string id, string exclusiveTag);

        /// <summary>
        /// Gets the Mixes available in a group
        /// </summary>
        /// <param name="callback">The callback to use when the API call has completed</param>
        /// <param name="group">The mix group.</param>
        /// <param name="exclusiveTag">The exclusive tag.</param>
        void GetMixes(Action<ListResponse<Mix>> callback, MixGroup group, string exclusiveTag);

        /// <summary>
        /// Gets the Mixes available in a group
        /// </summary>
        /// <param name="callback">The callback to use when the API call has completed</param>
        /// <param name="group">The mix group.</param>
        void GetMixes(Action<ListResponse<Mix>> callback, MixGroup group);
    }
}
