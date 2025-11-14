using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L203 - .
/// </summary>
public class FF30L203 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FPVOLID.
        /// </summary>
        public const string FPVOLID = "FPVOLID";

        /// <summary>
        /// FPMMFID.
        /// </summary>
        public const string FPMMFID = "FPMMFID";

        /// <summary>
        /// FPDTYPE.
        /// </summary>
        public const string FPDTYPE = "FPDTYPE";

        /// <summary>
        /// FPDFITM.
        /// </summary>
        public const string FPDFITM = "FPDFITM";

        /// <summary>
        /// FPFSCID.
        /// </summary>
        public const string FPFSCID = "FPFSCID";

        /// <summary>
        /// FPDFMCU.
        /// </summary>
        public const string FPDFMCU = "FPDFMCU";

        /// <summary>
        /// FPINDVOL.
        /// </summary>
        public const string FPINDVOL = "FPINDVOL";

        /// <summary>
        /// FPDEPVOL.
        /// </summary>
        public const string FPDEPVOL = "FPDEPVOL";

        /// <summary>
        /// FPTOTVOL.
        /// </summary>
        public const string FPTOTVOL = "FPTOTVOL";

        /// <summary>
        /// FPVOLPER.
        /// </summary>
        public const string FPVOLPER = "FPVOLPER";

        /// <summary>
        /// FPPHID.
        /// </summary>
        public const string FPPHID = "FPPHID";

        /// <summary>
        /// FPEMDCOM.
        /// </summary>
        public const string FPEMDCOM = "FPEMDCOM";

        /// <summary>
        /// FPMKEY.
        /// </summary>
        public const string FPMKEY = "FPMKEY";

        /// <summary>
        /// FPUSER.
        /// </summary>
        public const string FPUSER = "FPUSER";

        /// <summary>
        /// FPPID.
        /// </summary>
        public const string FPPID = "FPPID";

        /// <summary>
        /// FPUPMT.
        /// </summary>
        public const string FPUPMT = "FPUPMT";

        /// <summary>
        /// FPURRF.
        /// </summary>
        public const string FPURRF = "FPURRF";

        /// <summary>
        /// FPURAT.
        /// </summary>
        public const string FPURAT = "FPURAT";

        /// <summary>
        /// FPURAB.
        /// </summary>
        public const string FPURAB = "FPURAB";

        /// <summary>
        /// FPURDT.
        /// </summary>
        public const string FPURDT = "FPURDT";

        /// <summary>
        /// FPVDN.
        /// </summary>
        public const string FPVDN = "FPVDN";

        /// <summary>
        /// FPPHNA.
        /// </summary>
        public const string FPPHNA = "FPPHNA";

        /// <summary>
        /// FPVOLUOM.
        /// </summary>
        public const string FPVOLUOM = "FPVOLUOM";

        /// <summary>
        /// FPUUPMJ.
        /// </summary>
        public const string FPUUPMJ = "FPUUPMJ";

        /// <summary>
        /// FPDFMENDFG.
        /// </summary>
        public const string FPDFMENDFG = "FPDFMENDFG";

        /// <summary>
        /// FPMFN.
        /// </summary>
        public const string FPMFN = "FPMFN";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L203";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FPVOLID", "FPVOLID", JdeDataType.Numeric, null, true, true),
        new JdeField("FPMMFID", "FPMMFID", JdeDataType.Numeric, null, true, true),
        new JdeField("FPDTYPE", "FPDTYPE", JdeDataType.String, 4, true, true),
        new JdeField("FPDFITM", "FPDFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("FPFSCID", "FPFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("FPDFMCU", "FPDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("FPINDVOL", "FPINDVOL", JdeDataType.Numeric),
        new JdeField("FPDEPVOL", "FPDEPVOL", JdeDataType.Numeric),
        new JdeField("FPTOTVOL", "FPTOTVOL", JdeDataType.Numeric),
        new JdeField("FPVOLPER", "FPVOLPER", JdeDataType.Numeric),
        new JdeField("FPPHID", "FPPHID", JdeDataType.Numeric),
        new JdeField("FPEMDCOM", "FPEMDCOM", JdeDataType.String, 4),
        new JdeField("FPMKEY", "FPMKEY", JdeDataType.String, 30),
        new JdeField("FPUSER", "FPUSER", JdeDataType.String, 20),
        new JdeField("FPPID", "FPPID", JdeDataType.String, 20),
        new JdeField("FPUPMT", "FPUPMT", JdeDataType.Numeric),
        new JdeField("FPURRF", "FPURRF", JdeDataType.String, 30),
        new JdeField("FPURAT", "FPURAT", JdeDataType.Numeric),
        new JdeField("FPURAB", "FPURAB", JdeDataType.Numeric),
        new JdeField("FPURDT", "FPURDT", JdeDataType.Numeric),
        new JdeField("FPVDN", "FPVDN", JdeDataType.String, 60),
        new JdeField("FPPHNA", "FPPHNA", JdeDataType.String, 60),
        new JdeField("FPVOLUOM", "FPVOLUOM", JdeDataType.String, 4),
        new JdeField("FPUUPMJ", "FPUUPMJ", JdeDataType.Date),
        new JdeField("FPDFMENDFG", "FPDFMENDFG", JdeDataType.Numeric),
        new JdeField("FPMFN", "FPMFN", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L203_0", "Primary Key on FPVOLID, FPDFMCU, FPFSCID, FPDFITM, FPDTYPE, FPMMFID", new[] { "FPVOLID", "FPDFMCU", "FPFSCID", "FPDFITM", "FPDTYPE", "FPMMFID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L203_2", "Index on FPFSCID", new[] { "FPFSCID" }),
        new JdeIndex("FF30L203_3", "Index on FPVOLID, FPMMFID, FPDFITM, FPDFMCU", new[] { "FPVOLID", "FPMMFID", "FPDFITM", "FPDFMCU" }),
        new JdeIndex("FF30L203_4", "Index on FPPHID, FPFSCID", new[] { "FPPHID", "FPFSCID" }),
        new JdeIndex("FF30L203_5", "Index on FPVOLID, FPFSCID", new[] { "FPVOLID", "FPFSCID" }),
        new JdeIndex("FF30L203_6", "Index on FPVDN, FPFSCID", new[] { "FPVDN", "FPFSCID" }),
        new JdeIndex("FF30L203_7", "Index on FPFSCID, FPVOLID, FPDFMENDFG", new[] { "FPFSCID", "FPVOLID", "FPDFMENDFG" }),
        new JdeIndex("FF30L203_8", "Index on FPPHID, FPDFITM, FPDFMCU, FPFSCID", new[] { "FPPHID", "FPDFITM", "FPDFMCU", "FPFSCID" }),
        new JdeIndex("FF30L203_9", "Index on FPVOLID, FPMMFID, FPDTYPE", new[] { "FPVOLID", "FPMMFID", "FPDTYPE" })
    };
}
