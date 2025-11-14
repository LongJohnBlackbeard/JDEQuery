using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L708 - .
/// </summary>
public class FF30L708 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PSPSPID.
        /// </summary>
        public const string PSPSPID = "PSPSPID";

        /// <summary>
        /// PSPHID.
        /// </summary>
        public const string PSPHID = "PSPHID";

        /// <summary>
        /// PSPROID.
        /// </summary>
        public const string PSPROID = "PSPROID";

        /// <summary>
        /// PSFSCID.
        /// </summary>
        public const string PSFSCID = "PSFSCID";

        /// <summary>
        /// PSCTPPC.
        /// </summary>
        public const string PSCTPPC = "PSCTPPC";

        /// <summary>
        /// PSCOPPC.
        /// </summary>
        public const string PSCOPPC = "PSCOPPC";

        /// <summary>
        /// PSCSCPC.
        /// </summary>
        public const string PSCSCPC = "PSCSCPC";

        /// <summary>
        /// PSOTPPC.
        /// </summary>
        public const string PSOTPPC = "PSOTPPC";

        /// <summary>
        /// PSURCD.
        /// </summary>
        public const string PSURCD = "PSURCD";

        /// <summary>
        /// PSURDT.
        /// </summary>
        public const string PSURDT = "PSURDT";

        /// <summary>
        /// PSURAT.
        /// </summary>
        public const string PSURAT = "PSURAT";

        /// <summary>
        /// PSURAB.
        /// </summary>
        public const string PSURAB = "PSURAB";

        /// <summary>
        /// PSURRF.
        /// </summary>
        public const string PSURRF = "PSURRF";

        /// <summary>
        /// PSUSER.
        /// </summary>
        public const string PSUSER = "PSUSER";

        /// <summary>
        /// PSPID.
        /// </summary>
        public const string PSPID = "PSPID";

        /// <summary>
        /// PSMKEY.
        /// </summary>
        public const string PSMKEY = "PSMKEY";

        /// <summary>
        /// PSUUPMJ.
        /// </summary>
        public const string PSUUPMJ = "PSUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L708";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PSPSPID", "PSPSPID", JdeDataType.Numeric, null, true, true),
        new JdeField("PSPHID", "PSPHID", JdeDataType.Numeric, null, true, true),
        new JdeField("PSPROID", "PSPROID", JdeDataType.Numeric, null, true, true),
        new JdeField("PSFSCID", "PSFSCID", JdeDataType.Numeric),
        new JdeField("PSCTPPC", "PSCTPPC", JdeDataType.Numeric),
        new JdeField("PSCOPPC", "PSCOPPC", JdeDataType.Numeric),
        new JdeField("PSCSCPC", "PSCSCPC", JdeDataType.Numeric),
        new JdeField("PSOTPPC", "PSOTPPC", JdeDataType.Numeric),
        new JdeField("PSURCD", "PSURCD", JdeDataType.String, 4),
        new JdeField("PSURDT", "PSURDT", JdeDataType.Numeric),
        new JdeField("PSURAT", "PSURAT", JdeDataType.Numeric),
        new JdeField("PSURAB", "PSURAB", JdeDataType.Numeric),
        new JdeField("PSURRF", "PSURRF", JdeDataType.String, 30),
        new JdeField("PSUSER", "PSUSER", JdeDataType.String, 20),
        new JdeField("PSPID", "PSPID", JdeDataType.String, 20),
        new JdeField("PSMKEY", "PSMKEY", JdeDataType.String, 30),
        new JdeField("PSUUPMJ", "PSUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L708_0", "Primary Key on PSPSPID, PSPHID, PSPROID", new[] { "PSPSPID", "PSPHID", "PSPROID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L708_2", "Index on PSFSCID", new[] { "PSFSCID" }),
        new JdeIndex("FF30L708_3", "Index on PSPSPID, PSPROID", new[] { "PSPSPID", "PSPROID" })
    };
}
