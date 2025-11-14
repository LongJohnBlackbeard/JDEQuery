using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q404 - .
/// </summary>
public class F43Q404 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RJEVNU.
        /// </summary>
        public const string RJEVNU = "RJEVNU";

        /// <summary>
        /// RJDCTO.
        /// </summary>
        public const string RJDCTO = "RJDCTO";

        /// <summary>
        /// RJKCOO.
        /// </summary>
        public const string RJKCOO = "RJKCOO";

        /// <summary>
        /// RJBIDNUM.
        /// </summary>
        public const string RJBIDNUM = "RJBIDNUM";

        /// <summary>
        /// RJAN8.
        /// </summary>
        public const string RJAN8 = "RJAN8";

        /// <summary>
        /// RJRSNT.
        /// </summary>
        public const string RJRSNT = "RJRSNT";

        /// <summary>
        /// RJRCD.
        /// </summary>
        public const string RJRCD = "RJRCD";

        /// <summary>
        /// RJEMAILNFY.
        /// </summary>
        public const string RJEMAILNFY = "RJEMAILNFY";

        /// <summary>
        /// RJURCD.
        /// </summary>
        public const string RJURCD = "RJURCD";

        /// <summary>
        /// RJURDT.
        /// </summary>
        public const string RJURDT = "RJURDT";

        /// <summary>
        /// RJURAT.
        /// </summary>
        public const string RJURAT = "RJURAT";

        /// <summary>
        /// RJURAB.
        /// </summary>
        public const string RJURAB = "RJURAB";

        /// <summary>
        /// RJURRF.
        /// </summary>
        public const string RJURRF = "RJURRF";

        /// <summary>
        /// RJTORG.
        /// </summary>
        public const string RJTORG = "RJTORG";

        /// <summary>
        /// RJUSER.
        /// </summary>
        public const string RJUSER = "RJUSER";

        /// <summary>
        /// RJPID.
        /// </summary>
        public const string RJPID = "RJPID";

        /// <summary>
        /// RJJOBN.
        /// </summary>
        public const string RJJOBN = "RJJOBN";

        /// <summary>
        /// RJUPMJ.
        /// </summary>
        public const string RJUPMJ = "RJUPMJ";

        /// <summary>
        /// RJTDAY.
        /// </summary>
        public const string RJTDAY = "RJTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q404";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RJEVNU", "RJEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("RJDCTO", "RJDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RJKCOO", "RJKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RJBIDNUM", "RJBIDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("RJAN8", "RJAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RJRSNT", "RJRSNT", JdeDataType.String, 4),
        new JdeField("RJRCD", "RJRCD", JdeDataType.String, 6),
        new JdeField("RJEMAILNFY", "RJEMAILNFY", JdeDataType.String, 2),
        new JdeField("RJURCD", "RJURCD", JdeDataType.String, 4),
        new JdeField("RJURDT", "RJURDT", JdeDataType.Numeric),
        new JdeField("RJURAT", "RJURAT", JdeDataType.Numeric),
        new JdeField("RJURAB", "RJURAB", JdeDataType.Numeric),
        new JdeField("RJURRF", "RJURRF", JdeDataType.String, 30),
        new JdeField("RJTORG", "RJTORG", JdeDataType.String, 20),
        new JdeField("RJUSER", "RJUSER", JdeDataType.String, 20),
        new JdeField("RJPID", "RJPID", JdeDataType.String, 20),
        new JdeField("RJJOBN", "RJJOBN", JdeDataType.String, 20),
        new JdeField("RJUPMJ", "RJUPMJ", JdeDataType.Numeric),
        new JdeField("RJTDAY", "RJTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q404_0", "Primary Key on RJEVNU, RJDCTO, RJKCOO, RJBIDNUM, RJAN8", new[] { "RJEVNU", "RJDCTO", "RJKCOO", "RJBIDNUM", "RJAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q404_2", "Index on RJEVNU, RJDCTO, RJKCOO, RJAN8, RJBIDNUM", new[] { "RJEVNU", "RJDCTO", "RJKCOO", "RJAN8", "RJBIDNUM" })
    };
}
