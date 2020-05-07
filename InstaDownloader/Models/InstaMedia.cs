﻿using InstaDownloader.Utils;

namespace InstaDownloader.Models
{
    // <auto-generated />
    //
    // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
    //
    //    using InstaDownloader;
    //
    //    var welcome = Welcome.FromJson(jsonString);

    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class InstaMedia
    {
        [JsonProperty("graphql")]
        public Graphql Graphql { get; set; }
    }

    public partial class Graphql
    {
        [JsonProperty("shortcode_media")]
        public ShortcodeMedia ShortcodeMedia { get; set; }
    }

    public partial class ShortcodeMedia
    {
        [JsonProperty("__typename")]
        public MediaType Typename { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("shortcode")]
        public string Shortcode { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("gating_info")]
        public object GatingInfo { get; set; }

        [JsonProperty("fact_check_overall_rating")]
        public object FactCheckOverallRating { get; set; }

        [JsonProperty("fact_check_information")]
        public object FactCheckInformation { get; set; }

        [JsonProperty("sensitivity_friction_info")]
        public object SensitivityFrictionInfo { get; set; }

        [JsonProperty("media_overlay_info")]
        public object MediaOverlayInfo { get; set; }

        [JsonProperty("media_preview")]
        public object MediaPreview { get; set; }

        [JsonProperty("display_url")]
        public Uri DisplayUrl { get; set; }

        [JsonProperty("display_resources")]
        public List<DisplayResource> DisplayResources { get; set; }

        [JsonProperty("dash_info")]
        public DashInfo DashInfo { get; set; }

        [JsonProperty("video_url")]
        public string VideoUrl { get; set; }

        [JsonProperty("video_view_count")]
        public int? VideoViewCount { get; set; }

        [JsonProperty("is_video")]
        public bool? IsVideo { get; set; }

        [JsonProperty("tracking_token")]
        public string TrackingToken { get; set; }

        [JsonProperty("edge_media_to_tagged_user")]
        public Edge EdgeMediaToTaggedUser { get; set; }

        [JsonProperty("edge_media_to_caption")]
        public Edge EdgeMediaToCaption { get; set; }

        [JsonProperty("caption_is_edited")]
        public bool? CaptionIsEdited { get; set; }

        [JsonProperty("has_ranked_comments")]
        public bool? HasRankedComments { get; set; }

        [JsonProperty("edge_media_to_parent_comment")]
        public EdgeMediaToParentComment EdgeMediaToParentComment { get; set; }

        [JsonProperty("edge_media_to_hoisted_comment")]
        public Edge EdgeMediaToHoistedComment { get; set; }

        [JsonProperty("edge_media_preview_comment")]
        public EdgeMediaPreview EdgeMediaPreviewComment { get; set; }

        [JsonProperty("comments_disabled")]
        public bool? CommentsDisabled { get; set; }

        [JsonProperty("commenting_disabled_for_viewer")]
        public bool? CommentingDisabledForViewer { get; set; }

        [JsonProperty("taken_at_timestamp")]
        public long TakenAtTimestamp { get; set; }

        [JsonProperty("edge_media_preview_like")]
        public EdgeMediaPreview EdgeMediaPreviewLike { get; set; }

        [JsonProperty("edge_media_to_sponsor_user")]
        public Edge EdgeMediaToSponsorUser { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("viewer_has_liked")]
        public bool? ViewerHasLiked { get; set; }

        [JsonProperty("viewer_has_saved")]
        public bool? ViewerHasSaved { get; set; }

        [JsonProperty("viewer_has_saved_to_collection")]
        public bool? ViewerHasSavedToCollection { get; set; }

        [JsonProperty("viewer_in_photo_of_you")]
        public bool? ViewerInPhotoOfYou { get; set; }

        [JsonProperty("viewer_can_reshare")]
        public bool? ViewerCanReshare { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("is_ad")]
        public bool? IsAd { get; set; }

        [JsonProperty("edge_web_media_to_related_media")]
        public Edge EdgeWebMediaToRelatedMedia { get; set; }

        [JsonProperty("edge_sidecar_to_children")]
        public EdgeSidecarToChildren EdgeSidecarToChildren { get; set; }
    }

    public partial class Dimensions
    {
        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }
    }

    public partial class DisplayResource
    {
        [JsonProperty("src")]
        public Uri Src { get; set; }

        [JsonProperty("config_width")]
        public long ConfigWidth { get; set; }

        [JsonProperty("config_height")]
        public long ConfigHeight { get; set; }
    }

    public partial class DashInfo
    {
        [JsonProperty("is_dash_eligible")]
        public bool IsDashEligible { get; set; }

        [JsonProperty("video_dash_manifest")]
        public string VideoDashManifest { get; set; }

        [JsonProperty("number_of_qualities")]
        public int NumberOfQualities { get; set; }
    }

    public partial class EdgeMediaPreview
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("edges")]
        public List<object> Edges { get; set; }
    }

    public partial class Edge
    {
        [JsonProperty("edges")]
        public List<EdgeMediaToCaptionEdge> Edges { get; set; }
    }

    public partial class EdgeMediaToCaptionEdge
    {
        [JsonProperty("node")]
        public PurpleNode Node { get; set; }
    }

    public partial class PurpleNode
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class EdgeMediaToParentComment
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("page_info")]
        public PageInfo PageInfo { get; set; }

        [JsonProperty("edges")]
        public List<object> Edges { get; set; }
    }

    public partial class PageInfo
    {
        [JsonProperty("has_next_page")]
        public bool? HasNextPage { get; set; }

        [JsonProperty("end_cursor")]
        public object EndCursor { get; set; }
    }

    public partial class EdgeSidecarToChildren
    {
        [JsonProperty("edges")]
        public List<EdgeSidecarToChildrenEdge> Edges { get; set; }
    }

    public partial class EdgeSidecarToChildrenEdge
    {
        [JsonProperty("node")]
        public FluffyNode Node { get; set; }
    }

    public partial class FluffyNode
    {
        [JsonProperty("__typename")]
        public string Typename { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("shortcode")]
        public string Shortcode { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("gating_info")]
        public object GatingInfo { get; set; }

        [JsonProperty("fact_check_overall_rating")]
        public object FactCheckOverallRating { get; set; }

        [JsonProperty("fact_check_information")]
        public object FactCheckInformation { get; set; }

        [JsonProperty("sensitivity_friction_info")]
        public object SensitivityFrictionInfo { get; set; }

        [JsonProperty("media_overlay_info")]
        public object MediaOverlayInfo { get; set; }

        [JsonProperty("media_preview")]
        public string MediaPreview { get; set; }

        [JsonProperty("display_url")]
        public Uri DisplayUrl { get; set; }

        [JsonProperty("display_resources")]
        public List<DisplayResource> DisplayResources { get; set; }

        [JsonProperty("accessibility_caption")]
        public string AccessibilityCaption { get; set; }

        [JsonProperty("is_video")]
        public bool? IsVideo { get; set; }

        [JsonProperty("tracking_token")]
        public string TrackingToken { get; set; }

        [JsonProperty("edge_media_to_tagged_user")]
        public Edge EdgeMediaToTaggedUser { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("has_public_page")]
        public bool? HasPublicPage { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("address_json")]
        public string AddressJson { get; set; }
    }

    public partial class Owner
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("is_verified")]
        public bool? IsVerified { get; set; }

        [JsonProperty("profile_pic_url")]
        public Uri ProfilePicUrl { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("blocked_by_viewer")]
        public bool? BlockedByViewer { get; set; }

        [JsonProperty("restricted_by_viewer")]
        public bool? RestrictedByViewer { get; set; }

        [JsonProperty("followed_by_viewer")]
        public bool? FollowedByViewer { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("has_blocked_viewer")]
        public bool? HasBlockedViewer { get; set; }

        [JsonProperty("is_private")]
        public bool? IsPrivate { get; set; }

        [JsonProperty("is_unpublished")]
        public bool? IsUnpublished { get; set; }

        [JsonProperty("requested_by_viewer")]
        public bool? RequestedByViewer { get; set; }

        [JsonProperty("edge_owner_to_timeline_media")]
        public EdgeOwnerToTimelineMedia EdgeOwnerToTimelineMedia { get; set; }
    }

    public partial class EdgeOwnerToTimelineMedia
    {
        [JsonProperty("count")]
        public long Count { get; set; }
    }

    public partial class InstaMedia
    {
        public static InstaMedia FromJson(string json) => JsonConvert.DeserializeObject<InstaMedia>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this InstaMedia self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}