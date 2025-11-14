using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G32W - .
/// </summary>
public class F52G32W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PGJOBS.
        /// </summary>
        public const string PGJOBS = "PGJOBS";

        /// <summary>
        /// PGBPGC.
        /// </summary>
        public const string PGBPGC = "PGBPGC";

        /// <summary>
        /// PGEFTB.
        /// </summary>
        public const string PGEFTB = "PGEFTB";

        /// <summary>
        /// PGEFTE.
        /// </summary>
        public const string PGEFTE = "PGEFTE";
    }

    /// <inheritdoc />
    public override string TableName => "F52G32W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PGJOBS", "PGJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PGBPGC", "PGBPGC", JdeDataType.String, 6, true, true),
        new JdeField("PGEFTB", "PGEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("PGEFTE", "PGEFTE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G32W_0", "Primary Key on PGJOBS, PGBPGC, PGEFTB", new[] { "PGJOBS", "PGBPGC", "PGEFTB" }, isUnique: true, isPrimaryKey: true)
    };
}
