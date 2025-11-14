using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B424 - .
/// </summary>
public class F76B424 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWB76COID.
        /// </summary>
        public const string SWB76COID = "SWB76COID";

        /// <summary>
        /// SWBRG.
        /// </summary>
        public const string SWBRG = "SWBRG";

        /// <summary>
        /// SWB76ACTT.
        /// </summary>
        public const string SWB76ACTT = "SWB76ACTT";

        /// <summary>
        /// SWCENTYR.
        /// </summary>
        public const string SWCENTYR = "SWCENTYR";

        /// <summary>
        /// SWMNTH.
        /// </summary>
        public const string SWMNTH = "SWMNTH";

        /// <summary>
        /// SWAG.
        /// </summary>
        public const string SWAG = "SWAG";

        /// <summary>
        /// SWSTAM.
        /// </summary>
        public const string SWSTAM = "SWSTAM";

        /// <summary>
        /// SWJOBN.
        /// </summary>
        public const string SWJOBN = "SWJOBN";

        /// <summary>
        /// SWUSER.
        /// </summary>
        public const string SWUSER = "SWUSER";

        /// <summary>
        /// SWPID.
        /// </summary>
        public const string SWPID = "SWPID";

        /// <summary>
        /// SWUPMJ.
        /// </summary>
        public const string SWUPMJ = "SWUPMJ";

        /// <summary>
        /// SWUPMT.
        /// </summary>
        public const string SWUPMT = "SWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B424";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWB76COID", "SWB76COID", JdeDataType.String, 18, true, true),
        new JdeField("SWBRG", "SWBRG", JdeDataType.String, 18, true, true),
        new JdeField("SWB76ACTT", "SWB76ACTT", JdeDataType.String, 6, true, true),
        new JdeField("SWCENTYR", "SWCENTYR", JdeDataType.Numeric, null, true, true),
        new JdeField("SWMNTH", "SWMNTH", JdeDataType.Numeric, null, true, true),
        new JdeField("SWAG", "SWAG", JdeDataType.Numeric),
        new JdeField("SWSTAM", "SWSTAM", JdeDataType.Numeric),
        new JdeField("SWJOBN", "SWJOBN", JdeDataType.String, 20),
        new JdeField("SWUSER", "SWUSER", JdeDataType.String, 20),
        new JdeField("SWPID", "SWPID", JdeDataType.String, 20),
        new JdeField("SWUPMJ", "SWUPMJ", JdeDataType.Numeric),
        new JdeField("SWUPMT", "SWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B424_0", "Primary Key on SWB76COID, SWBRG, SWB76ACTT, SWCENTYR, SWMNTH", new[] { "SWB76COID", "SWBRG", "SWB76ACTT", "SWCENTYR", "SWMNTH" }, isUnique: true, isPrimaryKey: true)
    };
}
