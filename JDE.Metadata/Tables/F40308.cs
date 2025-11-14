using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40308 - .
/// </summary>
public class F40308 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GSAN8.
        /// </summary>
        public const string GSAN8 = "GSAN8";

        /// <summary>
        /// GSCS08.
        /// </summary>
        public const string GSCS08 = "GSCS08";

        /// <summary>
        /// GSITM.
        /// </summary>
        public const string GSITM = "GSITM";

        /// <summary>
        /// GSIT08.
        /// </summary>
        public const string GSIT08 = "GSIT08";

        /// <summary>
        /// GSEFTJ.
        /// </summary>
        public const string GSEFTJ = "GSEFTJ";

        /// <summary>
        /// GSEXDJ.
        /// </summary>
        public const string GSEXDJ = "GSEXDJ";

        /// <summary>
        /// GSMNQ.
        /// </summary>
        public const string GSMNQ = "GSMNQ";

        /// <summary>
        /// GSMXQ.
        /// </summary>
        public const string GSMXQ = "GSMXQ";

        /// <summary>
        /// GSUOM.
        /// </summary>
        public const string GSUOM = "GSUOM";

        /// <summary>
        /// GSTXID.
        /// </summary>
        public const string GSTXID = "GSTXID";

        /// <summary>
        /// GSSTPR.
        /// </summary>
        public const string GSSTPR = "GSSTPR";

        /// <summary>
        /// GSFRGD.
        /// </summary>
        public const string GSFRGD = "GSFRGD";

        /// <summary>
        /// GSTHGD.
        /// </summary>
        public const string GSTHGD = "GSTHGD";

        /// <summary>
        /// GSFRMP.
        /// </summary>
        public const string GSFRMP = "GSFRMP";

        /// <summary>
        /// GSTHRP.
        /// </summary>
        public const string GSTHRP = "GSTHRP";

        /// <summary>
        /// GSEXDP.
        /// </summary>
        public const string GSEXDP = "GSEXDP";

        /// <summary>
        /// GSURCD.
        /// </summary>
        public const string GSURCD = "GSURCD";

        /// <summary>
        /// GSURDT.
        /// </summary>
        public const string GSURDT = "GSURDT";

        /// <summary>
        /// GSURAT.
        /// </summary>
        public const string GSURAT = "GSURAT";

        /// <summary>
        /// GSURAB.
        /// </summary>
        public const string GSURAB = "GSURAB";

        /// <summary>
        /// GSURRF.
        /// </summary>
        public const string GSURRF = "GSURRF";

        /// <summary>
        /// GSUSER.
        /// </summary>
        public const string GSUSER = "GSUSER";

        /// <summary>
        /// GSPID.
        /// </summary>
        public const string GSPID = "GSPID";

        /// <summary>
        /// GSJOBN.
        /// </summary>
        public const string GSJOBN = "GSJOBN";

        /// <summary>
        /// GSUPMJ.
        /// </summary>
        public const string GSUPMJ = "GSUPMJ";

        /// <summary>
        /// GSTDAY.
        /// </summary>
        public const string GSTDAY = "GSTDAY";

        /// <summary>
        /// GSOSEQ.
        /// </summary>
        public const string GSOSEQ = "GSOSEQ";
    }

    /// <inheritdoc />
    public override string TableName => "F40308";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GSAN8", "GSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("GSCS08", "GSCS08", JdeDataType.String, 16, true, true),
        new JdeField("GSITM", "GSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("GSIT08", "GSIT08", JdeDataType.String, 16, true, true),
        new JdeField("GSEFTJ", "GSEFTJ", JdeDataType.Numeric),
        new JdeField("GSEXDJ", "GSEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("GSMNQ", "GSMNQ", JdeDataType.Numeric),
        new JdeField("GSMXQ", "GSMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("GSUOM", "GSUOM", JdeDataType.String, 4, true, true),
        new JdeField("GSTXID", "GSTXID", JdeDataType.Numeric),
        new JdeField("GSSTPR", "GSSTPR", JdeDataType.String, 2),
        new JdeField("GSFRGD", "GSFRGD", JdeDataType.String, 6),
        new JdeField("GSTHGD", "GSTHGD", JdeDataType.String, 6),
        new JdeField("GSFRMP", "GSFRMP", JdeDataType.Numeric),
        new JdeField("GSTHRP", "GSTHRP", JdeDataType.Numeric),
        new JdeField("GSEXDP", "GSEXDP", JdeDataType.Numeric),
        new JdeField("GSURCD", "GSURCD", JdeDataType.String, 4),
        new JdeField("GSURDT", "GSURDT", JdeDataType.Numeric),
        new JdeField("GSURAT", "GSURAT", JdeDataType.Numeric),
        new JdeField("GSURAB", "GSURAB", JdeDataType.Numeric),
        new JdeField("GSURRF", "GSURRF", JdeDataType.String, 30),
        new JdeField("GSUSER", "GSUSER", JdeDataType.String, 20),
        new JdeField("GSPID", "GSPID", JdeDataType.String, 20),
        new JdeField("GSJOBN", "GSJOBN", JdeDataType.String, 20),
        new JdeField("GSUPMJ", "GSUPMJ", JdeDataType.Numeric),
        new JdeField("GSTDAY", "GSTDAY", JdeDataType.Numeric),
        new JdeField("GSOSEQ", "GSOSEQ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40308_0", "Primary Key on GSAN8, GSCS08, GSITM, GSIT08, GSEXDJ, GSUOM, GSMXQ", new[] { "GSAN8", "GSCS08", "GSITM", "GSIT08", "GSEXDJ", "GSUOM", "GSMXQ" }, isUnique: true, isPrimaryKey: true)
    };
}
