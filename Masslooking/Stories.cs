using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masslooking
{
    public class ParentStory
    {
        public int id { get; set; }
        public int owner_id { get; set; }
        public int can_see { get; set; }
        public int date { get; set; }
        public int expires_at { get; set; }
        public bool is_one_time { get; set; }
    }
    public class Replies
    {
        public int count { get; set; }
        public int _new { get; set; }
    }
    public class ClickableArea
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    public class ClickableSticker
    {
        public int id { get; set; }
        public string type { get; set; }
        public List<ClickableArea> clickable_area { get; set; }
        public int owner_id { get; set; }
        public int? story_id { get; set; }
        public string mention { get; set; }
        public string style { get; set; }
        public int? post_owner_id { get; set; }
        public int? post_id { get; set; }
    }
    public class ClickableStickers
    {
        public int original_height { get; set; }
        public int original_width { get; set; }
        public List<ClickableSticker> clickable_stickers { get; set; }
    }
    public class Image
    {
        public int height { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int with_padding { get; set; }
    }
    public class FirstFrame
    {
        public int height { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }
    public class Files
    {
        public string mp4_720 { get; set; }
    }
    public class Video
    {
        public string access_key { get; set; }
        public int can_add { get; set; }
        public int is_private { get; set; }
        public int date { get; set; }
        public string description { get; set; }
        public int duration { get; set; }
        public List<Image> image { get; set; }
        public List<FirstFrame> first_frame { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int id { get; set; }
        public int owner_id { get; set; }
        public string title { get; set; }
        public string player { get; set; }
        public string type { get; set; }
        public int views { get; set; }
        public Files files { get; set; }
    }
    public class Size
    {
        public int height { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public int width { get; set; }
    }
    public class Photo
    {
        public int album_id { get; set; }
        public int date { get; set; }
        public int id { get; set; }
        public int owner_id { get; set; }
        public bool has_tags { get; set; }
        public List<Size> sizes { get; set; }
        public string text { get; set; }
    }
    public class Stories
    {
        public int id { get; set; }
        public int owner_id { get; set; }
        public string access_key { get; set; }
        public int can_comment { get; set; }
        public int can_reply { get; set; }
        public int can_see { get; set; }
        public bool can_like { get; set; }
        public int can_share { get; set; }
        public int can_hide { get; set; }
        public int date { get; set; }
        public int expires_at { get; set; }
        public ParentStory parent_story { get; set; }
        public int parent_story_id { get; set; }
        public int parent_story_owner_id { get; set; }
        public Replies replies { get; set; }
        public bool is_one_time { get; set; }
        public string track_code { get; set; }
        public string type { get; set; }
        public ClickableStickers clickable_stickers { get; set; }
        public Video video { get; set; }
        public bool is_restricted { get; set; }
        public bool no_sound { get; set; }
        public bool need_mute { get; set; }
        public bool mute_reply { get; set; }
        public int can_ask { get; set; }
        public int can_ask_anonymous { get; set; }
        public bool is_owner_pinned { get; set; }
        public Photo photo { get; set; }
    }
    public class Items
    {
        public string type { get; set; }
        public List<Stories> stories { get; set; }
    }
    public class Response
    {
        public int count { get; set; }
        public List<Items> items { get; set; }
    }
    public class Rooter
    {
        public Response response { get; set; }
    }
}
