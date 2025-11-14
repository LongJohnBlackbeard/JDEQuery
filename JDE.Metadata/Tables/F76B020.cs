using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B020 - .
/// </summary>
public class F76B020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DBB76LECO.
        /// </summary>
        public const string DBB76LECO = "DBB76LECO";

        /// <summary>
        /// DBAN8.
        /// </summary>
        public const string DBAN8 = "DBAN8";

        /// <summary>
        /// DBB76DETY.
        /// </summary>
        public const string DBB76DETY = "DBB76DETY";

        /// <summary>
        /// DBUSER.
        /// </summary>
        public const string DBUSER = "DBUSER";

        /// <summary>
        /// DBPID.
        /// </summary>
        public const string DBPID = "DBPID";

        /// <summary>
        /// DBJOBN.
        /// </summary>
        public const string DBJOBN = "DBJOBN";

        /// <summary>
        /// DBUPMJ.
        /// </summary>
        public const string DBUPMJ = "DBUPMJ";

        /// <summary>
        /// DBUPMT.
        /// </summary>
        public const string DBUPMT = "DBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DBB76LECO", "DBB76LECO", JdeDataType.String, 10, true, true),
        new JdeField("DBAN8", "DBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DBB76DETY", "DBB76DETY", JdeDataType.String, 2),
        new JdeField("DBUSER", "DBUSER", JdeDataType.String, 20),
        new JdeField("DBPID", "DBPID", JdeDataType.String, 20),
        new JdeField("DBJOBN", "DBJOBN", JdeDataType.String, 20),
        new JdeField("DBUPMJ", "DBUPMJ", JdeDataType.Numeric),
        new JdeField("DBUPMT", "DBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B020_0", "Primary Key on DBB76LECO, DBAN8", new[] { "DBB76LECO", "DBAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
