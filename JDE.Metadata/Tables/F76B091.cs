using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B091 - .
/// </summary>
public class F76B091 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LOB76UF.
        /// </summary>
        public const string LOB76UF = "LOB76UF";

        /// <summary>
        /// LOUFURL.
        /// </summary>
        public const string LOUFURL = "LOUFURL";

        /// <summary>
        /// LOUSER.
        /// </summary>
        public const string LOUSER = "LOUSER";

        /// <summary>
        /// LOPID.
        /// </summary>
        public const string LOPID = "LOPID";

        /// <summary>
        /// LOUPMJ.
        /// </summary>
        public const string LOUPMJ = "LOUPMJ";

        /// <summary>
        /// LOTDAY.
        /// </summary>
        public const string LOTDAY = "LOTDAY";

        /// <summary>
        /// LOJOBN.
        /// </summary>
        public const string LOJOBN = "LOJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B091";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LOB76UF", "LOB76UF", JdeDataType.String, 6, true, true),
        new JdeField("LOUFURL", "LOUFURL", JdeDataType.String, 250),
        new JdeField("LOUSER", "LOUSER", JdeDataType.String, 20),
        new JdeField("LOPID", "LOPID", JdeDataType.String, 20),
        new JdeField("LOUPMJ", "LOUPMJ", JdeDataType.Numeric),
        new JdeField("LOTDAY", "LOTDAY", JdeDataType.Numeric),
        new JdeField("LOJOBN", "LOJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B091_0", "Primary Key on LOB76UF", new[] { "LOB76UF" }, isUnique: true, isPrimaryKey: true)
    };
}
