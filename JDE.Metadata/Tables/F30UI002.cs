using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30UI002 - .
/// </summary>
public class F30UI002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IXITM.
        /// </summary>
        public const string IXITM = "IXITM";

        /// <summary>
        /// IXLLX.
        /// </summary>
        public const string IXLLX = "IXLLX";

        /// <summary>
        /// IXMODE.
        /// </summary>
        public const string IXMODE = "IXMODE";

        /// <summary>
        /// IXCTID.
        /// </summary>
        public const string IXCTID = "IXCTID";

        /// <summary>
        /// IXKIT.
        /// </summary>
        public const string IXKIT = "IXKIT";

        /// <summary>
        /// IXMMCU.
        /// </summary>
        public const string IXMMCU = "IXMMCU";

        /// <summary>
        /// IXCMCU.
        /// </summary>
        public const string IXCMCU = "IXCMCU";

        /// <summary>
        /// IXBQTY.
        /// </summary>
        public const string IXBQTY = "IXBQTY";

        /// <summary>
        /// IXTBM.
        /// </summary>
        public const string IXTBM = "IXTBM";

        /// <summary>
        /// IXUOM.
        /// </summary>
        public const string IXUOM = "IXUOM";

        /// <summary>
        /// IXCPNT.
        /// </summary>
        public const string IXCPNT = "IXCPNT";

        /// <summary>
        /// IXUKID.
        /// </summary>
        public const string IXUKID = "IXUKID";

        /// <summary>
        /// IXLNID.
        /// </summary>
        public const string IXLNID = "IXLNID";

        /// <summary>
        /// IXCPNB.
        /// </summary>
        public const string IXCPNB = "IXCPNB";
    }

    /// <inheritdoc />
    public override string TableName => "F30UI002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IXITM", "IXITM", JdeDataType.Numeric),
        new JdeField("IXLLX", "IXLLX", JdeDataType.Numeric),
        new JdeField("IXMODE", "IXMODE", JdeDataType.String, 2),
        new JdeField("IXCTID", "IXCTID", JdeDataType.String, 30, true, true),
        new JdeField("IXKIT", "IXKIT", JdeDataType.Numeric),
        new JdeField("IXMMCU", "IXMMCU", JdeDataType.String, 24),
        new JdeField("IXCMCU", "IXCMCU", JdeDataType.String, 24),
        new JdeField("IXBQTY", "IXBQTY", JdeDataType.Numeric),
        new JdeField("IXTBM", "IXTBM", JdeDataType.String, 6),
        new JdeField("IXUOM", "IXUOM", JdeDataType.String, 4),
        new JdeField("IXCPNT", "IXCPNT", JdeDataType.Numeric),
        new JdeField("IXUKID", "IXUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("IXLNID", "IXLNID", JdeDataType.Numeric),
        new JdeField("IXCPNB", "IXCPNB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30UI002_0", "Primary Key on IXUKID, IXCTID", new[] { "IXUKID", "IXCTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F30UI002_2", "Index on IXMODE, IXCTID", new[] { "IXMODE", "IXCTID" }),
        new JdeIndex("F30UI002_3", "Index on IXITM, IXMODE, IXCTID", new[] { "IXITM", "IXMODE", "IXCTID" })
    };
}
