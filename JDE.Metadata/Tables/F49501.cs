using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49501 - .
/// </summary>
public class F49501 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDPRNB.
        /// </summary>
        public const string RDPRNB = "RDPRNB";

        /// <summary>
        /// RDLNMB.
        /// </summary>
        public const string RDLNMB = "RDLNMB";

        /// <summary>
        /// RDORGN.
        /// </summary>
        public const string RDORGN = "RDORGN";

        /// <summary>
        /// RDANCC.
        /// </summary>
        public const string RDANCC = "RDANCC";

        /// <summary>
        /// RDCARS.
        /// </summary>
        public const string RDCARS = "RDCARS";

        /// <summary>
        /// RDMOT.
        /// </summary>
        public const string RDMOT = "RDMOT";

        /// <summary>
        /// RDFRSC.
        /// </summary>
        public const string RDFRSC = "RDFRSC";

        /// <summary>
        /// RDFRCG.
        /// </summary>
        public const string RDFRCG = "RDFRCG";

        /// <summary>
        /// RDCRCD.
        /// </summary>
        public const string RDCRCD = "RDCRCD";

        /// <summary>
        /// RDFRTP.
        /// </summary>
        public const string RDFRTP = "RDFRTP";

        /// <summary>
        /// RDRTGB.
        /// </summary>
        public const string RDRTGB = "RDRTGB";

        /// <summary>
        /// RDRTUM.
        /// </summary>
        public const string RDRTUM = "RDRTUM";

        /// <summary>
        /// RDDSTN.
        /// </summary>
        public const string RDDSTN = "RDDSTN";

        /// <summary>
        /// RDUMD1.
        /// </summary>
        public const string RDUMD1 = "RDUMD1";

        /// <summary>
        /// RDRTN.
        /// </summary>
        public const string RDRTN = "RDRTN";

        /// <summary>
        /// RDCNMR.
        /// </summary>
        public const string RDCNMR = "RDCNMR";

        /// <summary>
        /// RDLTDT.
        /// </summary>
        public const string RDLTDT = "RDLTDT";

        /// <summary>
        /// RDEFTJ.
        /// </summary>
        public const string RDEFTJ = "RDEFTJ";

        /// <summary>
        /// RDEXDJ.
        /// </summary>
        public const string RDEXDJ = "RDEXDJ";

        /// <summary>
        /// RDURCD.
        /// </summary>
        public const string RDURCD = "RDURCD";

        /// <summary>
        /// RDURDT.
        /// </summary>
        public const string RDURDT = "RDURDT";

        /// <summary>
        /// RDURAT.
        /// </summary>
        public const string RDURAT = "RDURAT";

        /// <summary>
        /// RDURAB.
        /// </summary>
        public const string RDURAB = "RDURAB";

        /// <summary>
        /// RDURRF.
        /// </summary>
        public const string RDURRF = "RDURRF";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDTDAY.
        /// </summary>
        public const string RDTDAY = "RDTDAY";

        /// <summary>
        /// RDTX.
        /// </summary>
        public const string RDTX = "RDTX";

        /// <summary>
        /// RDTXA1.
        /// </summary>
        public const string RDTXA1 = "RDTXA1";

        /// <summary>
        /// RDEXR1.
        /// </summary>
        public const string RDEXR1 = "RDEXR1";

        /// <summary>
        /// RDTAX1.
        /// </summary>
        public const string RDTAX1 = "RDTAX1";

        /// <summary>
        /// RDTXA2.
        /// </summary>
        public const string RDTXA2 = "RDTXA2";

        /// <summary>
        /// RDEXR2.
        /// </summary>
        public const string RDEXR2 = "RDEXR2";
    }

    /// <inheritdoc />
    public override string TableName => "F49501";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDPRNB", "RDPRNB", JdeDataType.Numeric, null, true, true),
        new JdeField("RDLNMB", "RDLNMB", JdeDataType.Numeric, null, true, true),
        new JdeField("RDORGN", "RDORGN", JdeDataType.Numeric),
        new JdeField("RDANCC", "RDANCC", JdeDataType.Numeric),
        new JdeField("RDCARS", "RDCARS", JdeDataType.Numeric),
        new JdeField("RDMOT", "RDMOT", JdeDataType.String, 6),
        new JdeField("RDFRSC", "RDFRSC", JdeDataType.String, 16),
        new JdeField("RDFRCG", "RDFRCG", JdeDataType.Numeric),
        new JdeField("RDCRCD", "RDCRCD", JdeDataType.String, 6),
        new JdeField("RDFRTP", "RDFRTP", JdeDataType.String, 2),
        new JdeField("RDRTGB", "RDRTGB", JdeDataType.String, 2),
        new JdeField("RDRTUM", "RDRTUM", JdeDataType.String, 4),
        new JdeField("RDDSTN", "RDDSTN", JdeDataType.Numeric),
        new JdeField("RDUMD1", "RDUMD1", JdeDataType.String, 4),
        new JdeField("RDRTN", "RDRTN", JdeDataType.Numeric),
        new JdeField("RDCNMR", "RDCNMR", JdeDataType.String, 48),
        new JdeField("RDLTDT", "RDLTDT", JdeDataType.Numeric),
        new JdeField("RDEFTJ", "RDEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RDEXDJ", "RDEXDJ", JdeDataType.Numeric),
        new JdeField("RDURCD", "RDURCD", JdeDataType.String, 4),
        new JdeField("RDURDT", "RDURDT", JdeDataType.Numeric),
        new JdeField("RDURAT", "RDURAT", JdeDataType.Numeric),
        new JdeField("RDURAB", "RDURAB", JdeDataType.Numeric),
        new JdeField("RDURRF", "RDURRF", JdeDataType.String, 30),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDTDAY", "RDTDAY", JdeDataType.Numeric),
        new JdeField("RDTX", "RDTX", JdeDataType.String, 2),
        new JdeField("RDTXA1", "RDTXA1", JdeDataType.String, 20),
        new JdeField("RDEXR1", "RDEXR1", JdeDataType.String, 4),
        new JdeField("RDTAX1", "RDTAX1", JdeDataType.String, 2),
        new JdeField("RDTXA2", "RDTXA2", JdeDataType.String, 20),
        new JdeField("RDEXR2", "RDEXR2", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49501_0", "Primary Key on RDPRNB, RDLNMB, RDEFTJ", new[] { "RDPRNB", "RDLNMB", "RDEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
