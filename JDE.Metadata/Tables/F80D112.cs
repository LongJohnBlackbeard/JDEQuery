using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D112 - .
/// </summary>
public class F80D112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SRAPPNID.
        /// </summary>
        public const string SRAPPNID = "SRAPPNID";

        /// <summary>
        /// SRDESCAP.
        /// </summary>
        public const string SRDESCAP = "SRDESCAP";

        /// <summary>
        /// SRGRID.
        /// </summary>
        public const string SRGRID = "SRGRID";

        /// <summary>
        /// SRPRCSID.
        /// </summary>
        public const string SRPRCSID = "SRPRCSID";

        /// <summary>
        /// SRDTCRTD.
        /// </summary>
        public const string SRDTCRTD = "SRDTCRTD";

        /// <summary>
        /// SRUSER.
        /// </summary>
        public const string SRUSER = "SRUSER";

        /// <summary>
        /// SRPID.
        /// </summary>
        public const string SRPID = "SRPID";

        /// <summary>
        /// SRMKEY.
        /// </summary>
        public const string SRMKEY = "SRMKEY";

        /// <summary>
        /// SRUTIME.
        /// </summary>
        public const string SRUTIME = "SRUTIME";

        /// <summary>
        /// SRURCD.
        /// </summary>
        public const string SRURCD = "SRURCD";

        /// <summary>
        /// SRURDT.
        /// </summary>
        public const string SRURDT = "SRURDT";

        /// <summary>
        /// SRURAB.
        /// </summary>
        public const string SRURAB = "SRURAB";

        /// <summary>
        /// SRURRF.
        /// </summary>
        public const string SRURRF = "SRURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SRAPPNID", "SRAPPNID", JdeDataType.String, 20, true, true),
        new JdeField("SRDESCAP", "SRDESCAP", JdeDataType.String, 60),
        new JdeField("SRGRID", "SRGRID", JdeDataType.String, 40, true, true),
        new JdeField("SRPRCSID", "SRPRCSID", JdeDataType.String, 40, true, true),
        new JdeField("SRDTCRTD", "SRDTCRTD", JdeDataType.Numeric),
        new JdeField("SRUSER", "SRUSER", JdeDataType.String, 20),
        new JdeField("SRPID", "SRPID", JdeDataType.String, 20),
        new JdeField("SRMKEY", "SRMKEY", JdeDataType.String, 30),
        new JdeField("SRUTIME", "SRUTIME", JdeDataType.Date),
        new JdeField("SRURCD", "SRURCD", JdeDataType.String, 4),
        new JdeField("SRURDT", "SRURDT", JdeDataType.Numeric),
        new JdeField("SRURAB", "SRURAB", JdeDataType.Numeric),
        new JdeField("SRURRF", "SRURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D112_0", "Primary Key on SRAPPNID, SRGRID, SRPRCSID", new[] { "SRAPPNID", "SRGRID", "SRPRCSID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F80D112_2", "Index on SRPRCSID, SRGRID", new[] { "SRPRCSID", "SRGRID" })
    };
}
