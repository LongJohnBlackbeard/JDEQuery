using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75J3001 - .
/// </summary>
public class F75J3001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABUKID.
        /// </summary>
        public const string ABUKID = "ABUKID";

        /// <summary>
        /// ABJ75DENSUPP.
        /// </summary>
        public const string ABJ75DENSUPP = "ABJ75DENSUPP";

        /// <summary>
        /// ABJ75DENBANK.
        /// </summary>
        public const string ABJ75DENBANK = "ABJ75DENBANK";

        /// <summary>
        /// ABUPMJ.
        /// </summary>
        public const string ABUPMJ = "ABUPMJ";

        /// <summary>
        /// ABUPMT.
        /// </summary>
        public const string ABUPMT = "ABUPMT";

        /// <summary>
        /// ABPID.
        /// </summary>
        public const string ABPID = "ABPID";

        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABJOBN.
        /// </summary>
        public const string ABJOBN = "ABJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75J3001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABUKID", "ABUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ABJ75DENSUPP", "ABJ75DENSUPP", JdeDataType.String, 18),
        new JdeField("ABJ75DENBANK", "ABJ75DENBANK", JdeDataType.String, 18),
        new JdeField("ABUPMJ", "ABUPMJ", JdeDataType.Numeric),
        new JdeField("ABUPMT", "ABUPMT", JdeDataType.Numeric),
        new JdeField("ABPID", "ABPID", JdeDataType.String, 20),
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20),
        new JdeField("ABJOBN", "ABJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75J3001_0", "Primary Key on ABUKID", new[] { "ABUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
