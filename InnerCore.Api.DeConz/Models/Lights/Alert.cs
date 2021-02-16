using System.Runtime.Serialization;

namespace InnerCore.Api.DeConz.Models.Lights
{
    /// <summary>
    /// Possible light alerts
    /// </summary>
    public enum Alert
    {
        /// <summary>
        /// Stop alert
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Alert once
        /// </summary>
        [EnumMember(Value = "select")]
        Once,

        /// <summary>
        /// Alert multiple times
        /// </summary>
        [EnumMember(Value = "lselect")]
        Multiple,

        /// <summary>
        /// Alert once
        /// Possible state when reading
        /// </summary>
        [EnumMember(Value = "alert")]
        Alert
    }
}