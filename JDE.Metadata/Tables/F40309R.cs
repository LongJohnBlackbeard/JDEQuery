using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40309R - .
/// </summary>
public class F40309R : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DYUKID.
        /// </summary>
        public const string DYUKID = "DYUKID";

        /// <summary>
        /// DYREFC.
        /// </summary>
        public const string DYREFC = "DYREFC";

        /// <summary>
        /// DYAN8.
        /// </summary>
        public const string DYAN8 = "DYAN8";

        /// <summary>
        /// DYCS09.
        /// </summary>
        public const string DYCS09 = "DYCS09";

        /// <summary>
        /// DYITM.
        /// </summary>
        public const string DYITM = "DYITM";

        /// <summary>
        /// DYIT09.
        /// </summary>
        public const string DYIT09 = "DYIT09";

        /// <summary>
        /// DYEFTJ.
        /// </summary>
        public const string DYEFTJ = "DYEFTJ";

        /// <summary>
        /// DYEXDJ.
        /// </summary>
        public const string DYEXDJ = "DYEXDJ";

        /// <summary>
        /// DYMNQ.
        /// </summary>
        public const string DYMNQ = "DYMNQ";

        /// <summary>
        /// DYMXQ.
        /// </summary>
        public const string DYMXQ = "DYMXQ";

        /// <summary>
        /// DYUOM.
        /// </summary>
        public const string DYUOM = "DYUOM";

        /// <summary>
        /// DYTXID.
        /// </summary>
        public const string DYTXID = "DYTXID";

        /// <summary>
        /// DYSTPR.
        /// </summary>
        public const string DYSTPR = "DYSTPR";

        /// <summary>
        /// DYOSEQ.
        /// </summary>
        public const string DYOSEQ = "DYOSEQ";

        /// <summary>
        /// DYMCU.
        /// </summary>
        public const string DYMCU = "DYMCU";

        /// <summary>
        /// DYROUT.
        /// </summary>
        public const string DYROUT = "DYROUT";

        /// <summary>
        /// DYMOT.
        /// </summary>
        public const string DYMOT = "DYMOT";

        /// <summary>
        /// DYCARS.
        /// </summary>
        public const string DYCARS = "DYCARS";

        /// <summary>
        /// DYPRIO.
        /// </summary>
        public const string DYPRIO = "DYPRIO";

        /// <summary>
        /// DYLTDT.
        /// </summary>
        public const string DYLTDT = "DYLTDT";

        /// <summary>
        /// DYURCD.
        /// </summary>
        public const string DYURCD = "DYURCD";

        /// <summary>
        /// DYURDT.
        /// </summary>
        public const string DYURDT = "DYURDT";

        /// <summary>
        /// DYURAT.
        /// </summary>
        public const string DYURAT = "DYURAT";

        /// <summary>
        /// DYURAB.
        /// </summary>
        public const string DYURAB = "DYURAB";

        /// <summary>
        /// DYURRF.
        /// </summary>
        public const string DYURRF = "DYURRF";

        /// <summary>
        /// DYUSER.
        /// </summary>
        public const string DYUSER = "DYUSER";

        /// <summary>
        /// DYPID.
        /// </summary>
        public const string DYPID = "DYPID";

        /// <summary>
        /// DYJOBN.
        /// </summary>
        public const string DYJOBN = "DYJOBN";

        /// <summary>
        /// DYUPMJ.
        /// </summary>
        public const string DYUPMJ = "DYUPMJ";

        /// <summary>
        /// DYTDAY.
        /// </summary>
        public const string DYTDAY = "DYTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40309R";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DYUKID", "DYUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("DYREFC", "DYREFC", JdeDataType.Numeric),
        new JdeField("DYAN8", "DYAN8", JdeDataType.Numeric),
        new JdeField("DYCS09", "DYCS09", JdeDataType.String, 16),
        new JdeField("DYITM", "DYITM", JdeDataType.Numeric),
        new JdeField("DYIT09", "DYIT09", JdeDataType.String, 16),
        new JdeField("DYEFTJ", "DYEFTJ", JdeDataType.Numeric),
        new JdeField("DYEXDJ", "DYEXDJ", JdeDataType.Numeric),
        new JdeField("DYMNQ", "DYMNQ", JdeDataType.Numeric),
        new JdeField("DYMXQ", "DYMXQ", JdeDataType.Numeric),
        new JdeField("DYUOM", "DYUOM", JdeDataType.String, 4),
        new JdeField("DYTXID", "DYTXID", JdeDataType.Numeric),
        new JdeField("DYSTPR", "DYSTPR", JdeDataType.String, 2),
        new JdeField("DYOSEQ", "DYOSEQ", JdeDataType.Numeric),
        new JdeField("DYMCU", "DYMCU", JdeDataType.String, 24),
        new JdeField("DYROUT", "DYROUT", JdeDataType.String, 6),
        new JdeField("DYMOT", "DYMOT", JdeDataType.String, 6),
        new JdeField("DYCARS", "DYCARS", JdeDataType.Numeric),
        new JdeField("DYPRIO", "DYPRIO", JdeDataType.String, 2),
        new JdeField("DYLTDT", "DYLTDT", JdeDataType.Numeric),
        new JdeField("DYURCD", "DYURCD", JdeDataType.String, 4),
        new JdeField("DYURDT", "DYURDT", JdeDataType.Numeric),
        new JdeField("DYURAT", "DYURAT", JdeDataType.Numeric),
        new JdeField("DYURAB", "DYURAB", JdeDataType.Numeric),
        new JdeField("DYURRF", "DYURRF", JdeDataType.String, 30),
        new JdeField("DYUSER", "DYUSER", JdeDataType.String, 20),
        new JdeField("DYPID", "DYPID", JdeDataType.String, 20),
        new JdeField("DYJOBN", "DYJOBN", JdeDataType.String, 20),
        new JdeField("DYUPMJ", "DYUPMJ", JdeDataType.Numeric),
        new JdeField("DYTDAY", "DYTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40309R_0", "Primary Key on DYUKID", new[] { "DYUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40309R_2", "Index on DYAN8, DYCS09, DYITM, DYIT09, DYEXDJ, DYMXQ, DYUOM, DYMCU, DYUPMJ, DYTDAY", new[] { "DYAN8", "DYCS09", "DYITM", "DYIT09", "DYEXDJ", "DYMXQ", "DYUOM", "DYMCU", "DYUPMJ", "DYTDAY" })
    };
}
