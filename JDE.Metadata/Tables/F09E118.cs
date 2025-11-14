using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09E118 - .
/// </summary>
public class F09E118 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PMEXRPTTYP.
        /// </summary>
        public const string PMEXRPTTYP = "PMEXRPTTYP";

        /// <summary>
        /// PMEXPTYPE.
        /// </summary>
        public const string PMEXPTYPE = "PMEXPTYPE";

        /// <summary>
        /// PMEFTJ.
        /// </summary>
        public const string PMEFTJ = "PMEFTJ";

        /// <summary>
        /// PMLOCATN.
        /// </summary>
        public const string PMLOCATN = "PMLOCATN";

        /// <summary>
        /// PMPDBA.
        /// </summary>
        public const string PMPDBA = "PMPDBA";

        /// <summary>
        /// PMUSER.
        /// </summary>
        public const string PMUSER = "PMUSER";

        /// <summary>
        /// PMPID.
        /// </summary>
        public const string PMPID = "PMPID";

        /// <summary>
        /// PMJOBN.
        /// </summary>
        public const string PMJOBN = "PMJOBN";

        /// <summary>
        /// PMUPMJ.
        /// </summary>
        public const string PMUPMJ = "PMUPMJ";

        /// <summary>
        /// PMUPMT.
        /// </summary>
        public const string PMUPMT = "PMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09E118";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMEXRPTTYP", "PMEXRPTTYP", JdeDataType.String, 2, true, true),
        new JdeField("PMEXPTYPE", "PMEXPTYPE", JdeDataType.String, 8, true, true),
        new JdeField("PMEFTJ", "PMEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PMLOCATN", "PMLOCATN", JdeDataType.String, 20),
        new JdeField("PMPDBA", "PMPDBA", JdeDataType.Numeric),
        new JdeField("PMUSER", "PMUSER", JdeDataType.String, 20),
        new JdeField("PMPID", "PMPID", JdeDataType.String, 20),
        new JdeField("PMJOBN", "PMJOBN", JdeDataType.String, 20),
        new JdeField("PMUPMJ", "PMUPMJ", JdeDataType.Numeric),
        new JdeField("PMUPMT", "PMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09E118_0", "Primary Key on PMEXRPTTYP, PMEXPTYPE, PMEFTJ", new[] { "PMEXRPTTYP", "PMEXPTYPE", "PMEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
