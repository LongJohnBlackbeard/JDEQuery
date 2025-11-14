using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40316R - .
/// </summary>
public class F40316R : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OPUKID.
        /// </summary>
        public const string OPUKID = "OPUKID";

        /// <summary>
        /// OPREFC.
        /// </summary>
        public const string OPREFC = "OPREFC";

        /// <summary>
        /// OPAN8.
        /// </summary>
        public const string OPAN8 = "OPAN8";

        /// <summary>
        /// OPCS16.
        /// </summary>
        public const string OPCS16 = "OPCS16";

        /// <summary>
        /// OPITM.
        /// </summary>
        public const string OPITM = "OPITM";

        /// <summary>
        /// OPIT16.
        /// </summary>
        public const string OPIT16 = "OPIT16";

        /// <summary>
        /// OPEFTJ.
        /// </summary>
        public const string OPEFTJ = "OPEFTJ";

        /// <summary>
        /// OPEXDJ.
        /// </summary>
        public const string OPEXDJ = "OPEXDJ";

        /// <summary>
        /// OPMNQ.
        /// </summary>
        public const string OPMNQ = "OPMNQ";

        /// <summary>
        /// OPMXQ.
        /// </summary>
        public const string OPMXQ = "OPMXQ";

        /// <summary>
        /// OPUOM.
        /// </summary>
        public const string OPUOM = "OPUOM";

        /// <summary>
        /// OPTXID.
        /// </summary>
        public const string OPTXID = "OPTXID";

        /// <summary>
        /// OPSTPR.
        /// </summary>
        public const string OPSTPR = "OPSTPR";

        /// <summary>
        /// OPOSEQ.
        /// </summary>
        public const string OPOSEQ = "OPOSEQ";

        /// <summary>
        /// OPMCU.
        /// </summary>
        public const string OPMCU = "OPMCU";

        /// <summary>
        /// OPPRIO.
        /// </summary>
        public const string OPPRIO = "OPPRIO";

        /// <summary>
        /// OPOPLT.
        /// </summary>
        public const string OPOPLT = "OPOPLT";

        /// <summary>
        /// OPURCD.
        /// </summary>
        public const string OPURCD = "OPURCD";

        /// <summary>
        /// OPURDT.
        /// </summary>
        public const string OPURDT = "OPURDT";

        /// <summary>
        /// OPURAT.
        /// </summary>
        public const string OPURAT = "OPURAT";

        /// <summary>
        /// OPURAB.
        /// </summary>
        public const string OPURAB = "OPURAB";

        /// <summary>
        /// OPURRF.
        /// </summary>
        public const string OPURRF = "OPURRF";

        /// <summary>
        /// OPUSER.
        /// </summary>
        public const string OPUSER = "OPUSER";

        /// <summary>
        /// OPPID.
        /// </summary>
        public const string OPPID = "OPPID";

        /// <summary>
        /// OPJOBN.
        /// </summary>
        public const string OPJOBN = "OPJOBN";

        /// <summary>
        /// OPUPMJ.
        /// </summary>
        public const string OPUPMJ = "OPUPMJ";

        /// <summary>
        /// OPTDAY.
        /// </summary>
        public const string OPTDAY = "OPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40316R";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OPUKID", "OPUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("OPREFC", "OPREFC", JdeDataType.Numeric),
        new JdeField("OPAN8", "OPAN8", JdeDataType.Numeric),
        new JdeField("OPCS16", "OPCS16", JdeDataType.String, 16),
        new JdeField("OPITM", "OPITM", JdeDataType.Numeric),
        new JdeField("OPIT16", "OPIT16", JdeDataType.String, 16),
        new JdeField("OPEFTJ", "OPEFTJ", JdeDataType.Numeric),
        new JdeField("OPEXDJ", "OPEXDJ", JdeDataType.Numeric),
        new JdeField("OPMNQ", "OPMNQ", JdeDataType.Numeric),
        new JdeField("OPMXQ", "OPMXQ", JdeDataType.Numeric),
        new JdeField("OPUOM", "OPUOM", JdeDataType.String, 4),
        new JdeField("OPTXID", "OPTXID", JdeDataType.Numeric),
        new JdeField("OPSTPR", "OPSTPR", JdeDataType.String, 2),
        new JdeField("OPOSEQ", "OPOSEQ", JdeDataType.Numeric),
        new JdeField("OPMCU", "OPMCU", JdeDataType.String, 24),
        new JdeField("OPPRIO", "OPPRIO", JdeDataType.String, 2),
        new JdeField("OPOPLT", "OPOPLT", JdeDataType.Numeric),
        new JdeField("OPURCD", "OPURCD", JdeDataType.String, 4),
        new JdeField("OPURDT", "OPURDT", JdeDataType.Numeric),
        new JdeField("OPURAT", "OPURAT", JdeDataType.Numeric),
        new JdeField("OPURAB", "OPURAB", JdeDataType.Numeric),
        new JdeField("OPURRF", "OPURRF", JdeDataType.String, 30),
        new JdeField("OPUSER", "OPUSER", JdeDataType.String, 20),
        new JdeField("OPPID", "OPPID", JdeDataType.String, 20),
        new JdeField("OPJOBN", "OPJOBN", JdeDataType.String, 20),
        new JdeField("OPUPMJ", "OPUPMJ", JdeDataType.Numeric),
        new JdeField("OPTDAY", "OPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40316R_0", "Primary Key on OPUKID", new[] { "OPUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40316R_2", "Index on OPAN8, OPCS16, OPITM, OPIT16, OPEXDJ, OPMXQ, OPUOM, OPOPLT, OPUPMJ, OPTDAY", new[] { "OPAN8", "OPCS16", "OPITM", "OPIT16", "OPEXDJ", "OPMXQ", "OPUOM", "OPOPLT", "OPUPMJ", "OPTDAY" })
    };
}
