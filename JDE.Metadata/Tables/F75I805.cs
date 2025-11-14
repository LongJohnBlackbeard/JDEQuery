using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I805 - .
/// </summary>
public class F75I805 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GAI75GSTU.
        /// </summary>
        public const string GAI75GSTU = "GAI75GSTU";

        /// <summary>
        /// GAI75TYGST.
        /// </summary>
        public const string GAI75TYGST = "GAI75TYGST";

        /// <summary>
        /// GAI75TXTY.
        /// </summary>
        public const string GAI75TXTY = "GAI75TXTY";

        /// <summary>
        /// GAAID.
        /// </summary>
        public const string GAAID = "GAAID";

        /// <summary>
        /// GAAID0.
        /// </summary>
        public const string GAAID0 = "GAAID0";

        /// <summary>
        /// GAPID.
        /// </summary>
        public const string GAPID = "GAPID";

        /// <summary>
        /// GAJOBN.
        /// </summary>
        public const string GAJOBN = "GAJOBN";

        /// <summary>
        /// GAUPMJ.
        /// </summary>
        public const string GAUPMJ = "GAUPMJ";

        /// <summary>
        /// GAUPMT.
        /// </summary>
        public const string GAUPMT = "GAUPMT";

        /// <summary>
        /// GAUSER.
        /// </summary>
        public const string GAUSER = "GAUSER";

        /// <summary>
        /// GADATF01.
        /// </summary>
        public const string GADATF01 = "GADATF01";

        /// <summary>
        /// GADEPFUT2.
        /// </summary>
        public const string GADEPFUT2 = "GADEPFUT2";

        /// <summary>
        /// GAACTFU1.
        /// </summary>
        public const string GAACTFU1 = "GAACTFU1";

        /// <summary>
        /// GAFLAG.
        /// </summary>
        public const string GAFLAG = "GAFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75I805";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GAI75GSTU", "GAI75GSTU", JdeDataType.Numeric, null, true, true),
        new JdeField("GAI75TYGST", "GAI75TYGST", JdeDataType.String, 8, true, true),
        new JdeField("GAI75TXTY", "GAI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("GAAID", "GAAID", JdeDataType.String, 16),
        new JdeField("GAAID0", "GAAID0", JdeDataType.String, 16),
        new JdeField("GAPID", "GAPID", JdeDataType.String, 20),
        new JdeField("GAJOBN", "GAJOBN", JdeDataType.String, 20),
        new JdeField("GAUPMJ", "GAUPMJ", JdeDataType.Numeric),
        new JdeField("GAUPMT", "GAUPMT", JdeDataType.Numeric),
        new JdeField("GAUSER", "GAUSER", JdeDataType.String, 20),
        new JdeField("GADATF01", "GADATF01", JdeDataType.Numeric),
        new JdeField("GADEPFUT2", "GADEPFUT2", JdeDataType.String, 60),
        new JdeField("GAACTFU1", "GAACTFU1", JdeDataType.String, 2),
        new JdeField("GAFLAG", "GAFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I805_0", "Primary Key on GAI75GSTU, GAI75TYGST, GAI75TXTY", new[] { "GAI75GSTU", "GAI75TYGST", "GAI75TXTY" }, isUnique: true, isPrimaryKey: true)
    };
}
