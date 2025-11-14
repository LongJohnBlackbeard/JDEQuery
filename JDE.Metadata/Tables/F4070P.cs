using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4070P - .
/// </summary>
public class F4070P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SNUKID.
        /// </summary>
        public const string SNUKID = "SNUKID";

        /// <summary>
        /// SNASN.
        /// </summary>
        public const string SNASN = "SNASN";

        /// <summary>
        /// SNOSEQ.
        /// </summary>
        public const string SNOSEQ = "SNOSEQ";

        /// <summary>
        /// SNANPS.
        /// </summary>
        public const string SNANPS = "SNANPS";

        /// <summary>
        /// SNAST.
        /// </summary>
        public const string SNAST = "SNAST";

        /// <summary>
        /// SNURCD.
        /// </summary>
        public const string SNURCD = "SNURCD";

        /// <summary>
        /// SNURDT.
        /// </summary>
        public const string SNURDT = "SNURDT";

        /// <summary>
        /// SNURAT.
        /// </summary>
        public const string SNURAT = "SNURAT";

        /// <summary>
        /// SNURAB.
        /// </summary>
        public const string SNURAB = "SNURAB";

        /// <summary>
        /// SNURRF.
        /// </summary>
        public const string SNURRF = "SNURRF";

        /// <summary>
        /// SNEFTJ.
        /// </summary>
        public const string SNEFTJ = "SNEFTJ";

        /// <summary>
        /// SNEXDJ.
        /// </summary>
        public const string SNEXDJ = "SNEXDJ";

        /// <summary>
        /// SNINHT.
        /// </summary>
        public const string SNINHT = "SNINHT";

        /// <summary>
        /// SNTIER.
        /// </summary>
        public const string SNTIER = "SNTIER";

        /// <summary>
        /// SNUSER.
        /// </summary>
        public const string SNUSER = "SNUSER";

        /// <summary>
        /// SNPID.
        /// </summary>
        public const string SNPID = "SNPID";

        /// <summary>
        /// SNJOBN.
        /// </summary>
        public const string SNJOBN = "SNJOBN";

        /// <summary>
        /// SNUPMJ.
        /// </summary>
        public const string SNUPMJ = "SNUPMJ";

        /// <summary>
        /// SNTDAY.
        /// </summary>
        public const string SNTDAY = "SNTDAY";

        /// <summary>
        /// SNSCTYPE.
        /// </summary>
        public const string SNSCTYPE = "SNSCTYPE";

        /// <summary>
        /// SNSTPRCF.
        /// </summary>
        public const string SNSTPRCF = "SNSTPRCF";

        /// <summary>
        /// SNSKIPTO.
        /// </summary>
        public const string SNSKIPTO = "SNSKIPTO";

        /// <summary>
        /// SNSKIPEND.
        /// </summary>
        public const string SNSKIPEND = "SNSKIPEND";
    }

    /// <inheritdoc />
    public override string TableName => "F4070P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SNUKID", "SNUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SNASN", "SNASN", JdeDataType.String, 16, true, true),
        new JdeField("SNOSEQ", "SNOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SNANPS", "SNANPS", JdeDataType.Numeric, null, true, true),
        new JdeField("SNAST", "SNAST", JdeDataType.String, 16),
        new JdeField("SNURCD", "SNURCD", JdeDataType.String, 4),
        new JdeField("SNURDT", "SNURDT", JdeDataType.Numeric),
        new JdeField("SNURAT", "SNURAT", JdeDataType.Numeric),
        new JdeField("SNURAB", "SNURAB", JdeDataType.Numeric),
        new JdeField("SNURRF", "SNURRF", JdeDataType.String, 30),
        new JdeField("SNEFTJ", "SNEFTJ", JdeDataType.Numeric),
        new JdeField("SNEXDJ", "SNEXDJ", JdeDataType.Numeric),
        new JdeField("SNINHT", "SNINHT", JdeDataType.String, 2),
        new JdeField("SNTIER", "SNTIER", JdeDataType.Numeric),
        new JdeField("SNUSER", "SNUSER", JdeDataType.String, 20),
        new JdeField("SNPID", "SNPID", JdeDataType.String, 20),
        new JdeField("SNJOBN", "SNJOBN", JdeDataType.String, 20),
        new JdeField("SNUPMJ", "SNUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SNTDAY", "SNTDAY", JdeDataType.Numeric),
        new JdeField("SNSCTYPE", "SNSCTYPE", JdeDataType.Numeric),
        new JdeField("SNSTPRCF", "SNSTPRCF", JdeDataType.String, 2),
        new JdeField("SNSKIPTO", "SNSKIPTO", JdeDataType.Numeric),
        new JdeField("SNSKIPEND", "SNSKIPEND", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4070P_0", "Primary Key on SNASN, SNOSEQ, SNANPS, SNUPMJ, SNUKID", new[] { "SNASN", "SNOSEQ", "SNANPS", "SNUPMJ", "SNUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4070P_2", "Index on SNAST, SNASN", new[] { "SNAST", "SNASN" }),
        new JdeIndex("F4070P_3", "Index on SNAST", new[] { "SNAST" }),
        new JdeIndex("F4070P_4", "Index on SNANPS, SNOSEQ, SNEFTJ, SNEXDJ", new[] { "SNANPS", "SNOSEQ", "SNEFTJ", "SNEXDJ" }),
        new JdeIndex("F4070P_5", "Index on SNASN, SNOSEQ, SNEFTJ, SNEXDJ", new[] { "SNASN", "SNOSEQ", "SNEFTJ", "SNEXDJ" }),
        new JdeIndex("F4070P_6", "Index on SNASN, SNANPS", new[] { "SNASN", "SNANPS" }),
        new JdeIndex("F4070P_7", "Index on SNAST, SNASN, SNANPS", new[] { "SNAST", "SNASN", "SNANPS" }),
        new JdeIndex("F4070P_8", "Index on SNASN, SNSCTYPE", new[] { "SNASN", "SNSCTYPE" })
    };
}
