using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186601 - .
/// </summary>
public class F186601 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MTLRSBAT.
        /// </summary>
        public const string MTLRSBAT = "MTLRSBAT";

        /// <summary>
        /// MTLRSBSC.
        /// </summary>
        public const string MTLRSBSC = "MTLRSBSC";

        /// <summary>
        /// MTLRSSID.
        /// </summary>
        public const string MTLRSSID = "MTLRSSID";

        /// <summary>
        /// MTLRSMSC.
        /// </summary>
        public const string MTLRSMSC = "MTLRSMSC";

        /// <summary>
        /// MTUSER.
        /// </summary>
        public const string MTUSER = "MTUSER";

        /// <summary>
        /// MTPID.
        /// </summary>
        public const string MTPID = "MTPID";

        /// <summary>
        /// MTJOBN.
        /// </summary>
        public const string MTJOBN = "MTJOBN";

        /// <summary>
        /// MTUPMJ.
        /// </summary>
        public const string MTUPMJ = "MTUPMJ";

        /// <summary>
        /// MTTDAY.
        /// </summary>
        public const string MTTDAY = "MTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F186601";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MTLRSBAT", "MTLRSBAT", JdeDataType.Numeric, null, true, true),
        new JdeField("MTLRSBSC", "MTLRSBSC", JdeDataType.String, 10),
        new JdeField("MTLRSSID", "MTLRSSID", JdeDataType.Numeric),
        new JdeField("MTLRSMSC", "MTLRSMSC", JdeDataType.String, 10),
        new JdeField("MTUSER", "MTUSER", JdeDataType.String, 20),
        new JdeField("MTPID", "MTPID", JdeDataType.String, 20),
        new JdeField("MTJOBN", "MTJOBN", JdeDataType.String, 20),
        new JdeField("MTUPMJ", "MTUPMJ", JdeDataType.Numeric),
        new JdeField("MTTDAY", "MTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186601_0", "Primary Key on MTLRSBAT", new[] { "MTLRSBAT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F186601_2", "Index on MTLRSBSC, MTLRSSID", new[] { "MTLRSBSC", "MTLRSSID" })
    };
}
