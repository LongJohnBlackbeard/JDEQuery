using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1301P - .
/// </summary>
public class F1301P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FGRTTB.
        /// </summary>
        public const string FGRTTB = "FGRTTB";

        /// <summary>
        /// FGRTGR.
        /// </summary>
        public const string FGRTGR = "FGRTGR";

        /// <summary>
        /// FGNUMB.
        /// </summary>
        public const string FGNUMB = "FGNUMB";

        /// <summary>
        /// FGEFTB.
        /// </summary>
        public const string FGEFTB = "FGEFTB";

        /// <summary>
        /// FGEFTE.
        /// </summary>
        public const string FGEFTE = "FGEFTE";

        /// <summary>
        /// FGERC.
        /// </summary>
        public const string FGERC = "FGERC";

        /// <summary>
        /// FGARPC.
        /// </summary>
        public const string FGARPC = "FGARPC";

        /// <summary>
        /// FGEBRT.
        /// </summary>
        public const string FGEBRT = "FGEBRT";

        /// <summary>
        /// FGRK01.
        /// </summary>
        public const string FGRK01 = "FGRK01";

        /// <summary>
        /// FGRK02.
        /// </summary>
        public const string FGRK02 = "FGRK02";

        /// <summary>
        /// FGRK03.
        /// </summary>
        public const string FGRK03 = "FGRK03";

        /// <summary>
        /// FGRK04.
        /// </summary>
        public const string FGRK04 = "FGRK04";

        /// <summary>
        /// FGRK05.
        /// </summary>
        public const string FGRK05 = "FGRK05";

        /// <summary>
        /// FGRK06.
        /// </summary>
        public const string FGRK06 = "FGRK06";

        /// <summary>
        /// FGRK07.
        /// </summary>
        public const string FGRK07 = "FGRK07";

        /// <summary>
        /// FGRK08.
        /// </summary>
        public const string FGRK08 = "FGRK08";

        /// <summary>
        /// FGRK09.
        /// </summary>
        public const string FGRK09 = "FGRK09";

        /// <summary>
        /// FGRK10.
        /// </summary>
        public const string FGRK10 = "FGRK10";

        /// <summary>
        /// FGLCT.
        /// </summary>
        public const string FGLCT = "FGLCT";

        /// <summary>
        /// FGUSER.
        /// </summary>
        public const string FGUSER = "FGUSER";

        /// <summary>
        /// FGPID.
        /// </summary>
        public const string FGPID = "FGPID";

        /// <summary>
        /// FGJOBN.
        /// </summary>
        public const string FGJOBN = "FGJOBN";

        /// <summary>
        /// FGUPMT.
        /// </summary>
        public const string FGUPMT = "FGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1301P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FGRTTB", "FGRTTB", JdeDataType.String, 6, true, true),
        new JdeField("FGRTGR", "FGRTGR", JdeDataType.String, 6, true, true),
        new JdeField("FGNUMB", "FGNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FGEFTB", "FGEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("FGEFTE", "FGEFTE", JdeDataType.Numeric),
        new JdeField("FGERC", "FGERC", JdeDataType.String, 4, true, true),
        new JdeField("FGARPC", "FGARPC", JdeDataType.Numeric),
        new JdeField("FGEBRT", "FGEBRT", JdeDataType.Numeric),
        new JdeField("FGRK01", "FGRK01", JdeDataType.Numeric),
        new JdeField("FGRK02", "FGRK02", JdeDataType.Numeric),
        new JdeField("FGRK03", "FGRK03", JdeDataType.Numeric),
        new JdeField("FGRK04", "FGRK04", JdeDataType.Numeric),
        new JdeField("FGRK05", "FGRK05", JdeDataType.Numeric),
        new JdeField("FGRK06", "FGRK06", JdeDataType.Numeric),
        new JdeField("FGRK07", "FGRK07", JdeDataType.Numeric),
        new JdeField("FGRK08", "FGRK08", JdeDataType.Numeric),
        new JdeField("FGRK09", "FGRK09", JdeDataType.Numeric),
        new JdeField("FGRK10", "FGRK10", JdeDataType.Numeric),
        new JdeField("FGLCT", "FGLCT", JdeDataType.Numeric),
        new JdeField("FGUSER", "FGUSER", JdeDataType.String, 20),
        new JdeField("FGPID", "FGPID", JdeDataType.String, 20),
        new JdeField("FGJOBN", "FGJOBN", JdeDataType.String, 20),
        new JdeField("FGUPMT", "FGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1301P_0", "Primary Key on FGRTTB, FGRTGR, FGNUMB, FGEFTB, FGERC", new[] { "FGRTTB", "FGRTGR", "FGNUMB", "FGEFTB", "FGERC" }, isUnique: true, isPrimaryKey: true)
    };
}
