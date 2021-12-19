using System;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WhatsAppAPIHelper
{
    public class MainRequestModel
    {
        public recipient_type_enum recipient_type { get; set; }
        public string to { get; set; }
        public mainRequest_type_enum type { get; set; }
        public bool preview_url { get; set; }
        public Text text { get; set; }
        public Media audio { get; set; }
        public Media document { get; set; }
        public Media image { get; set; }
        public Media sticker { get; set; }
        public Media video { get; set; }
        public Contacts contacts { get; set; }
        public Location location { get; set; }
        public Interactive interactive { get; set; }

    }

    public class Interactive
    {
        public interactive_type_enum type { get; set; }
        public Header header { get; set; }
        public Body body { get; set; }
        public Footer footer { get; set; }
        public Action action { get; set; }

    }

    public class Action
    {
        public string button { get; set; }
        public List<Section> sections { get; set; }
    }
    public class Button
    {
        public button_type_enum type { get; set; }
        public string title { get; set; }
        public string id { get; set; }

    }
    public class Section
    {
        public string title { get; set; }
        public List<Row> rows { get; set; }

    }
    public class Row
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
    public class Header
    {
        public header_type_enum type { get; set; }
        public Text text { get; set; }
        public Media Video { get; set; }
        public Media image { get; set; }
        public Media document { get; set; }
    }

    public class Body
    {
        public string text { get; set; }
    }

    public class Footer
    {
        public Text text { get; set; }
    }

    public class Media
    {
        public string id { get; set; }
        public string link { get; set; }
        public string caption { get; set; }
        public string filename { get; set; }
        public string provider { get; set; }
    }

    public class Text
    {
        public string body { get; set; }
    }

    public class Contacts
    {
        public Addresses addresses { get; set; }
        public string birthday { get; set; }
        public Emails emails { get; set; }
        public Name name { get; set; }
        public Org org { get; set; }
        public Phone phone { get; set; }

    }
    public class urls
    {
        public string URL { get; set; }
        public addresses_type_enum type { get; set; }
    }
    public class Location
    {
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }
    public class Name
    {
        public string formatted_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string middle_name { get; set; }
        public string suffix { get; set; }
        public string prefix { get; set; }
    }
    public class Org
    {
        public string company { get; set; }
        public string department { get; set; }
        public string title { get; set; }
    }
    public class Phone
    {
        public string phone { get; set; }
        public phone_type_enum type { get; set; }
        public string wa_id { get; set; }
    }
    public class Emails
    {
        public string email { get; set; }
        public addresses_type_enum type { get; set; }
        public Emails emails { get; set; }
    }

    public class Addresses
    {
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public addresses_type_enum type { get; set; }

    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum button_type_enum
    {
        [EnumMember(Value = "reply")]
        reply
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum phone_type_enum
    {
        [EnumMember(Value = "CELL")]
        CELL,
        [EnumMember(Value = "MAIN")]
        MAIN,
        [EnumMember(Value = "IPHONE")]
        IPHONE,
        [EnumMember(Value = "HOME")]
        HOME,
        [EnumMember(Value = "WORK")]
        WORK
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum addresses_type_enum
    {
        [EnumMember(Value = "HOME")]
        HOME,
        [EnumMember(Value = "WORK")]
        WORK,
       
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum header_type_enum
    {
        [EnumMember(Value = "text")]
        text,
        [EnumMember(Value = "video")]
        video,
        [EnumMember(Value = "image")]
        image,
        [EnumMember(Value = "document")]
        document
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum interactive_type_enum
    {
        [EnumMember(Value = "list")]
        list,
        [EnumMember(Value = "button")]
        button,
        [EnumMember(Value = "product")]
        product,
        [EnumMember(Value = "product_list")]
        product_list
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum recipient_type_enum
    {
        [EnumMember(Value = "individual")]
        individual
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum mainRequest_type_enum
    {
        [EnumMember(Value = "audio")]
        audio,
        [EnumMember(Value = "contact")]
        contact,
        [EnumMember(Value = "document")]
        document,
        [EnumMember(Value = "image")]
        image,
        [EnumMember(Value = "location")]
        location,
        [EnumMember(Value = "sticker")]
        sticker,
        [EnumMember(Value = "template")]
        template,
        [EnumMember(Value = "text")]
        text,
        [EnumMember(Value = "video")]
        video,
        [EnumMember(Value = "interactive")]
        interactive,
    }
}