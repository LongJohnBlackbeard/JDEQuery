using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01RS12W - .
/// </summary>
public class F01RS12W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRSESSID.
        /// </summary>
        public const string TRSESSID = "TRSESSID";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRROLEDESC.
        /// </summary>
        public const string TRROLEDESC = "TRROLEDESC";

        /// <summary>
        /// TREV01.
        /// </summary>
        public const string TREV01 = "TREV01";
    }

    /// <inheritdoc />
    public override string TableName => "F01RS12W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRSESSID", "TRSESSID", JdeDataType.String, 64, true, true),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20, true, true),
        new JdeField("TRROLEDESC", "TRROLEDESC", JdeDataType.String, 510),
        new JdeField("TREV01", "TREV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01RS12W_0", "Primary Key on TRSESSID, TRUSER", new[] { "TRSESSID", "TRUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
