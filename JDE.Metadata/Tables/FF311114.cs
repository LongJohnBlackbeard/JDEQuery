using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF311114 - .
/// </summary>
public class FF311114 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCUKID.
        /// </summary>
        public const string PCUKID = "PCUKID";

        /// <summary>
        /// PCMTID.
        /// </summary>
        public const string PCMTID = "PCMTID";

        /// <summary>
        /// PCPRODF31.
        /// </summary>
        public const string PCPRODF31 = "PCPRODF31";

        /// <summary>
        /// PCTRSID.
        /// </summary>
        public const string PCTRSID = "PCTRSID";

        /// <summary>
        /// PCITM.
        /// </summary>
        public const string PCITM = "PCITM";

        /// <summary>
        /// PCCMCU.
        /// </summary>
        public const string PCCMCU = "PCCMCU";

        /// <summary>
        /// PCCPNB.
        /// </summary>
        public const string PCCPNB = "PCCPNB";

        /// <summary>
        /// PCDOCO.
        /// </summary>
        public const string PCDOCO = "PCDOCO";

        /// <summary>
        /// PCDCTO.
        /// </summary>
        public const string PCDCTO = "PCDCTO";

        /// <summary>
        /// PCLNID.
        /// </summary>
        public const string PCLNID = "PCLNID";

        /// <summary>
        /// PCKCOO.
        /// </summary>
        public const string PCKCOO = "PCKCOO";

        /// <summary>
        /// PCSFXO.
        /// </summary>
        public const string PCSFXO = "PCSFXO";

        /// <summary>
        /// PCURCD.
        /// </summary>
        public const string PCURCD = "PCURCD";

        /// <summary>
        /// PCURDT.
        /// </summary>
        public const string PCURDT = "PCURDT";

        /// <summary>
        /// PCURAT.
        /// </summary>
        public const string PCURAT = "PCURAT";

        /// <summary>
        /// PCURRF.
        /// </summary>
        public const string PCURRF = "PCURRF";

        /// <summary>
        /// PCURAB.
        /// </summary>
        public const string PCURAB = "PCURAB";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCUUPMJ.
        /// </summary>
        public const string PCUUPMJ = "PCUUPMJ";

        /// <summary>
        /// PCMKEY.
        /// </summary>
        public const string PCMKEY = "PCMKEY";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";
    }

    /// <inheritdoc />
    public override string TableName => "FF311114";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCUKID", "PCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PCMTID", "PCMTID", JdeDataType.Numeric),
        new JdeField("PCPRODF31", "PCPRODF31", JdeDataType.Numeric),
        new JdeField("PCTRSID", "PCTRSID", JdeDataType.Numeric),
        new JdeField("PCITM", "PCITM", JdeDataType.Numeric),
        new JdeField("PCCMCU", "PCCMCU", JdeDataType.String, 24),
        new JdeField("PCCPNB", "PCCPNB", JdeDataType.Numeric),
        new JdeField("PCDOCO", "PCDOCO", JdeDataType.Numeric),
        new JdeField("PCDCTO", "PCDCTO", JdeDataType.String, 4),
        new JdeField("PCLNID", "PCLNID", JdeDataType.Numeric),
        new JdeField("PCKCOO", "PCKCOO", JdeDataType.String, 10),
        new JdeField("PCSFXO", "PCSFXO", JdeDataType.String, 6),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCURDT", "PCURDT", JdeDataType.Numeric),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCUUPMJ", "PCUUPMJ", JdeDataType.Date),
        new JdeField("PCMKEY", "PCMKEY", JdeDataType.String, 30),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF311114_0", "Primary Key on PCUKID", new[] { "PCUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF311114_2", "Index on PCMTID, PCPRODF31, PCTRSID", new[] { "PCMTID", "PCPRODF31", "PCTRSID" }),
        new JdeIndex("FF311114_3", "Index on PCTRSID", new[] { "PCTRSID" })
    };
}
