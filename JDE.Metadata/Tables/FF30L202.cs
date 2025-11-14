using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L202 - .
/// </summary>
public class FF30L202 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VFVOLID.
        /// </summary>
        public const string VFVOLID = "VFVOLID";

        /// <summary>
        /// VFMMFID.
        /// </summary>
        public const string VFMMFID = "VFMMFID";

        /// <summary>
        /// VFFSCID.
        /// </summary>
        public const string VFFSCID = "VFFSCID";

        /// <summary>
        /// VFDTYPE.
        /// </summary>
        public const string VFDTYPE = "VFDTYPE";

        /// <summary>
        /// VFVOLFAM.
        /// </summary>
        public const string VFVOLFAM = "VFVOLFAM";

        /// <summary>
        /// VFMKEY.
        /// </summary>
        public const string VFMKEY = "VFMKEY";

        /// <summary>
        /// VFUSER.
        /// </summary>
        public const string VFUSER = "VFUSER";

        /// <summary>
        /// VFPID.
        /// </summary>
        public const string VFPID = "VFPID";

        /// <summary>
        /// VFUPMT.
        /// </summary>
        public const string VFUPMT = "VFUPMT";

        /// <summary>
        /// VFURRF.
        /// </summary>
        public const string VFURRF = "VFURRF";

        /// <summary>
        /// VFURAT.
        /// </summary>
        public const string VFURAT = "VFURAT";

        /// <summary>
        /// VFURDT.
        /// </summary>
        public const string VFURDT = "VFURDT";

        /// <summary>
        /// VFMFN.
        /// </summary>
        public const string VFMFN = "VFMFN";

        /// <summary>
        /// VFVDN.
        /// </summary>
        public const string VFVDN = "VFVDN";

        /// <summary>
        /// VFMMFDSC.
        /// </summary>
        public const string VFMMFDSC = "VFMMFDSC";

        /// <summary>
        /// VFVOLUOM.
        /// </summary>
        public const string VFVOLUOM = "VFVOLUOM";

        /// <summary>
        /// VFURCD.
        /// </summary>
        public const string VFURCD = "VFURCD";

        /// <summary>
        /// VFURAB.
        /// </summary>
        public const string VFURAB = "VFURAB";

        /// <summary>
        /// VFUUPMJ.
        /// </summary>
        public const string VFUUPMJ = "VFUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L202";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VFVOLID", "VFVOLID", JdeDataType.Numeric, null, true, true),
        new JdeField("VFMMFID", "VFMMFID", JdeDataType.Numeric, null, true, true),
        new JdeField("VFFSCID", "VFFSCID", JdeDataType.Numeric),
        new JdeField("VFDTYPE", "VFDTYPE", JdeDataType.String, 4, true, true),
        new JdeField("VFVOLFAM", "VFVOLFAM", JdeDataType.Numeric),
        new JdeField("VFMKEY", "VFMKEY", JdeDataType.String, 30),
        new JdeField("VFUSER", "VFUSER", JdeDataType.String, 20),
        new JdeField("VFPID", "VFPID", JdeDataType.String, 20),
        new JdeField("VFUPMT", "VFUPMT", JdeDataType.Numeric),
        new JdeField("VFURRF", "VFURRF", JdeDataType.String, 30),
        new JdeField("VFURAT", "VFURAT", JdeDataType.Numeric),
        new JdeField("VFURDT", "VFURDT", JdeDataType.Numeric),
        new JdeField("VFMFN", "VFMFN", JdeDataType.String, 50),
        new JdeField("VFVDN", "VFVDN", JdeDataType.String, 60),
        new JdeField("VFMMFDSC", "VFMMFDSC", JdeDataType.String, 160),
        new JdeField("VFVOLUOM", "VFVOLUOM", JdeDataType.String, 4),
        new JdeField("VFURCD", "VFURCD", JdeDataType.String, 4),
        new JdeField("VFURAB", "VFURAB", JdeDataType.Numeric),
        new JdeField("VFUUPMJ", "VFUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L202_0", "Primary Key on VFVOLID, VFDTYPE, VFMMFID", new[] { "VFVOLID", "VFDTYPE", "VFMMFID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L202_2", "Index on VFVOLID, VFMMFID, VFDTYPE", new[] { "VFVOLID", "VFMMFID", "VFDTYPE" }),
        new JdeIndex("FF30L202_3", "Index on VFFSCID", new[] { "VFFSCID" }),
        new JdeIndex("FF30L202_4", "Index on VFMMFID, VFVOLID", new[] { "VFMMFID", "VFVOLID" }),
        new JdeIndex("FF30L202_5", "Index on VFMMFID, VFFSCID", new[] { "VFMMFID", "VFFSCID" })
    };
}
