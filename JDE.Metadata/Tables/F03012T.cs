using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03012T - .
/// </summary>
public class F03012T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ATAN8.
        /// </summary>
        public const string ATAN8 = "ATAN8";

        /// <summary>
        /// ATCO.
        /// </summary>
        public const string ATCO = "ATCO";

        /// <summary>
        /// ATUTP.
        /// </summary>
        public const string ATUTP = "ATUTP";

        /// <summary>
        /// ATCFUC1.
        /// </summary>
        public const string ATCFUC1 = "ATCFUC1";

        /// <summary>
        /// ATCFUC2.
        /// </summary>
        public const string ATCFUC2 = "ATCFUC2";

        /// <summary>
        /// ATCFUC3.
        /// </summary>
        public const string ATCFUC3 = "ATCFUC3";

        /// <summary>
        /// ATCFUS1.
        /// </summary>
        public const string ATCFUS1 = "ATCFUS1";

        /// <summary>
        /// ATCFUS2.
        /// </summary>
        public const string ATCFUS2 = "ATCFUS2";

        /// <summary>
        /// ATCFUS3.
        /// </summary>
        public const string ATCFUS3 = "ATCFUS3";

        /// <summary>
        /// ATCFUDJ.
        /// </summary>
        public const string ATCFUDJ = "ATCFUDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F03012T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ATAN8", "ATAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ATCO", "ATCO", JdeDataType.String, 10, true, true),
        new JdeField("ATUTP", "ATUTP", JdeDataType.String, 2),
        new JdeField("ATCFUC1", "ATCFUC1", JdeDataType.String, 2),
        new JdeField("ATCFUC2", "ATCFUC2", JdeDataType.String, 2),
        new JdeField("ATCFUC3", "ATCFUC3", JdeDataType.String, 2),
        new JdeField("ATCFUS1", "ATCFUS1", JdeDataType.String, 20),
        new JdeField("ATCFUS2", "ATCFUS2", JdeDataType.String, 20),
        new JdeField("ATCFUS3", "ATCFUS3", JdeDataType.String, 20),
        new JdeField("ATCFUDJ", "ATCFUDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03012T_0", "Primary Key on ATAN8, ATCO", new[] { "ATAN8", "ATCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03012T_2", "Index on ATAN8", new[] { "ATAN8" })
    };
}
