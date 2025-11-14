using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L920 - .
/// </summary>
public class FF30L920 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHLNDSID.
        /// </summary>
        public const string CHLNDSID = "CHLNDSID";

        /// <summary>
        /// CHDFITM.
        /// </summary>
        public const string CHDFITM = "CHDFITM";

        /// <summary>
        /// CHDFMCU.
        /// </summary>
        public const string CHDFMCU = "CHDFMCU";

        /// <summary>
        /// CHFSCID.
        /// </summary>
        public const string CHFSCID = "CHFSCID";

        /// <summary>
        /// CHDFTPCT.
        /// </summary>
        public const string CHDFTPCT = "CHDFTPCT";

        /// <summary>
        /// CHTPCTTS.
        /// </summary>
        public const string CHTPCTTS = "CHTPCTTS";

        /// <summary>
        /// CHTPCTD.
        /// </summary>
        public const string CHTPCTD = "CHTPCTD";

        /// <summary>
        /// CHURCD.
        /// </summary>
        public const string CHURCD = "CHURCD";

        /// <summary>
        /// CHURDT.
        /// </summary>
        public const string CHURDT = "CHURDT";

        /// <summary>
        /// CHURAT.
        /// </summary>
        public const string CHURAT = "CHURAT";

        /// <summary>
        /// CHURAB.
        /// </summary>
        public const string CHURAB = "CHURAB";

        /// <summary>
        /// CHURRF.
        /// </summary>
        public const string CHURRF = "CHURRF";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHMKEY.
        /// </summary>
        public const string CHMKEY = "CHMKEY";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHUUPMJ.
        /// </summary>
        public const string CHUUPMJ = "CHUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L920";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHLNDSID", "CHLNDSID", JdeDataType.Numeric, null, true, true),
        new JdeField("CHDFITM", "CHDFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CHDFMCU", "CHDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("CHFSCID", "CHFSCID", JdeDataType.Numeric),
        new JdeField("CHDFTPCT", "CHDFTPCT", JdeDataType.Numeric),
        new JdeField("CHTPCTTS", "CHTPCTTS", JdeDataType.String, 4),
        new JdeField("CHTPCTD", "CHTPCTD", JdeDataType.Date),
        new JdeField("CHURCD", "CHURCD", JdeDataType.String, 4),
        new JdeField("CHURDT", "CHURDT", JdeDataType.Numeric),
        new JdeField("CHURAT", "CHURAT", JdeDataType.Numeric),
        new JdeField("CHURAB", "CHURAB", JdeDataType.Numeric),
        new JdeField("CHURRF", "CHURRF", JdeDataType.String, 30),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHMKEY", "CHMKEY", JdeDataType.String, 30),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHUUPMJ", "CHUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L920_0", "Primary Key on CHLNDSID, CHDFITM, CHDFMCU", new[] { "CHLNDSID", "CHDFITM", "CHDFMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L920_2", "Index on CHFSCID", new[] { "CHFSCID" })
    };
}
