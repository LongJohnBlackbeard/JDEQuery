using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98311 - .
/// </summary>
public class F98311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DHPID.
        /// </summary>
        public const string DHPID = "DHPID";

        /// <summary>
        /// DHVERS.
        /// </summary>
        public const string DHVERS = "DHVERS";

        /// <summary>
        /// DHSQN.
        /// </summary>
        public const string DHSQN = "DHSQN";

        /// <summary>
        /// DHTXT1.
        /// </summary>
        public const string DHTXT1 = "DHTXT1";
    }

    /// <inheritdoc />
    public override string TableName => "F98311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DHPID", "DHPID", JdeDataType.String, 20, true, true),
        new JdeField("DHVERS", "DHVERS", JdeDataType.String, 20, true, true),
        new JdeField("DHSQN", "DHSQN", JdeDataType.Numeric, null, true, true),
        new JdeField("DHTXT1", "DHTXT1", JdeDataType.String, 100)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98311_0", "Primary Key on DHPID, DHVERS, DHSQN", new[] { "DHPID", "DHVERS", "DHSQN" }, isUnique: true, isPrimaryKey: true)
    };
}
