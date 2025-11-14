using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01401 - .
/// </summary>
public class F01401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APAPLNID.
        /// </summary>
        public const string APAPLNID = "APAPLNID";

        /// <summary>
        /// APNAMEP.
        /// </summary>
        public const string APNAMEP = "APNAMEP";

        /// <summary>
        /// APDESCR.
        /// </summary>
        public const string APDESCR = "APDESCR";

        /// <summary>
        /// APAN8.
        /// </summary>
        public const string APAN8 = "APAN8";

        /// <summary>
        /// APJOBN.
        /// </summary>
        public const string APJOBN = "APJOBN";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";

        /// <summary>
        /// APENTDBY.
        /// </summary>
        public const string APENTDBY = "APENTDBY";

        /// <summary>
        /// APMKEY.
        /// </summary>
        public const string APMKEY = "APMKEY";

        /// <summary>
        /// APUDTTM.
        /// </summary>
        public const string APUDTTM = "APUDTTM";

        /// <summary>
        /// APEDATE.
        /// </summary>
        public const string APEDATE = "APEDATE";

        /// <summary>
        /// APUDTU.
        /// </summary>
        public const string APUDTU = "APUDTU";
    }

    /// <inheritdoc />
    public override string TableName => "F01401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APAPLNID", "APAPLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("APNAMEP", "APNAMEP", JdeDataType.String, 200),
        new JdeField("APDESCR", "APDESCR", JdeDataType.String, 3998),
        new JdeField("APAN8", "APAN8", JdeDataType.Numeric),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric),
        new JdeField("APENTDBY", "APENTDBY", JdeDataType.Numeric),
        new JdeField("APMKEY", "APMKEY", JdeDataType.String, 30),
        new JdeField("APUDTTM", "APUDTTM", JdeDataType.Date),
        new JdeField("APEDATE", "APEDATE", JdeDataType.Date),
        new JdeField("APUDTU", "APUDTU", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01401_0", "Primary Key on APAPLNID", new[] { "APAPLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
