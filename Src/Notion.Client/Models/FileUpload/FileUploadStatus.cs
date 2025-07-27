using System.Runtime.Serialization;

namespace Notion.Client
{
    public enum FileUploadStatus
    {
        [EnumMember(Value = null)]
        Any,

        [EnumMember(Value = "pending")]
        Pending,

        [EnumMember(Value = "uploaded")]
        Uploaded,

        [EnumMember(Value = "expired")]
        Expired,

        [EnumMember(Value = "failed")]
        Failed
    }
}
