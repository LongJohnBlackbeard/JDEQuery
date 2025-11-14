using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B116W - .
/// </summary>
public class F03B116W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ILDTAI.
        /// </summary>
        public const string ILDTAI = "ILDTAI";

        /// <summary>
        /// ILAN8.
        /// </summary>
        public const string ILAN8 = "ILAN8";

        /// <summary>
        /// ILKCO.
        /// </summary>
        public const string ILKCO = "ILKCO";

        /// <summary>
        /// ILDOC.
        /// </summary>
        public const string ILDOC = "ILDOC";

        /// <summary>
        /// ILDCT.
        /// </summary>
        public const string ILDCT = "ILDCT";

        /// <summary>
        /// ILDIGJ.
        /// </summary>
        public const string ILDIGJ = "ILDIGJ";

        /// <summary>
        /// ILIVD.
        /// </summary>
        public const string ILIVD = "ILIVD";

        /// <summary>
        /// ILDGJ.
        /// </summary>
        public const string ILDGJ = "ILDGJ";

        /// <summary>
        /// ILCH6.
        /// </summary>
        public const string ILCH6 = "ILCH6";

        /// <summary>
        /// ILAAR.
        /// </summary>
        public const string ILAAR = "ILAAR";

        /// <summary>
        /// ILAARE.
        /// </summary>
        public const string ILAARE = "ILAARE";

        /// <summary>
        /// ILAARN.
        /// </summary>
        public const string ILAARN = "ILAARN";

        /// <summary>
        /// ILAA.
        /// </summary>
        public const string ILAA = "ILAA";

        /// <summary>
        /// ILUSER.
        /// </summary>
        public const string ILUSER = "ILUSER";

        /// <summary>
        /// ILUKID.
        /// </summary>
        public const string ILUKID = "ILUKID";

        /// <summary>
        /// ILCFAMT1.
        /// </summary>
        public const string ILCFAMT1 = "ILCFAMT1";

        /// <summary>
        /// ILCFAMT2.
        /// </summary>
        public const string ILCFAMT2 = "ILCFAMT2";
    }

    /// <inheritdoc />
    public override string TableName => "F03B116W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ILDTAI", "ILDTAI", JdeDataType.String, 20, true, true),
        new JdeField("ILAN8", "ILAN8", JdeDataType.Numeric),
        new JdeField("ILKCO", "ILKCO", JdeDataType.String, 10, true, true),
        new JdeField("ILDOC", "ILDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ILDCT", "ILDCT", JdeDataType.String, 4, true, true),
        new JdeField("ILDIGJ", "ILDIGJ", JdeDataType.Numeric),
        new JdeField("ILIVD", "ILIVD", JdeDataType.Numeric),
        new JdeField("ILDGJ", "ILDGJ", JdeDataType.Numeric),
        new JdeField("ILCH6", "ILCH6", JdeDataType.String, 2),
        new JdeField("ILAAR", "ILAAR", JdeDataType.Numeric),
        new JdeField("ILAARE", "ILAARE", JdeDataType.Numeric),
        new JdeField("ILAARN", "ILAARN", JdeDataType.Numeric),
        new JdeField("ILAA", "ILAA", JdeDataType.Numeric),
        new JdeField("ILUSER", "ILUSER", JdeDataType.String, 20, true, true),
        new JdeField("ILUKID", "ILUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ILCFAMT1", "ILCFAMT1", JdeDataType.Numeric),
        new JdeField("ILCFAMT2", "ILCFAMT2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B116W_0", "Primary Key on ILUSER, ILUKID, ILKCO, ILDOC, ILDCT, ILDTAI", new[] { "ILUSER", "ILUKID", "ILKCO", "ILDOC", "ILDCT", "ILDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
