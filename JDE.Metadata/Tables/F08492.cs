using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08492 - .
/// </summary>
public class F08492 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EONURC.
        /// </summary>
        public const string EONURC = "EONURC";

        /// <summary>
        /// EOAN8.
        /// </summary>
        public const string EOAN8 = "EOAN8";

        /// <summary>
        /// EOEEOM.
        /// </summary>
        public const string EOEEOM = "EOEEOM";

        /// <summary>
        /// EOSEX.
        /// </summary>
        public const string EOSEX = "EOSEX";

        /// <summary>
        /// EOPID.
        /// </summary>
        public const string EOPID = "EOPID";

        /// <summary>
        /// EOUSER.
        /// </summary>
        public const string EOUSER = "EOUSER";

        /// <summary>
        /// EOMKEY.
        /// </summary>
        public const string EOMKEY = "EOMKEY";

        /// <summary>
        /// EOUPMJ.
        /// </summary>
        public const string EOUPMJ = "EOUPMJ";

        /// <summary>
        /// EOUPMT.
        /// </summary>
        public const string EOUPMT = "EOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08492";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EONURC", "EONURC", JdeDataType.Numeric, null, true, true),
        new JdeField("EOAN8", "EOAN8", JdeDataType.Numeric),
        new JdeField("EOEEOM", "EOEEOM", JdeDataType.String, 4),
        new JdeField("EOSEX", "EOSEX", JdeDataType.String, 2),
        new JdeField("EOPID", "EOPID", JdeDataType.String, 20),
        new JdeField("EOUSER", "EOUSER", JdeDataType.String, 20),
        new JdeField("EOMKEY", "EOMKEY", JdeDataType.String, 30),
        new JdeField("EOUPMJ", "EOUPMJ", JdeDataType.Numeric),
        new JdeField("EOUPMT", "EOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08492_0", "Primary Key on EONURC", new[] { "EONURC" }, isUnique: true, isPrimaryKey: true)
    };
}
