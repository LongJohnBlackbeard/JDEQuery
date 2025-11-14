using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N4040 - .
/// </summary>
public class FD3N4040 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHCYNO.
        /// </summary>
        public const string CHCYNO = "CHCYNO";

        /// <summary>
        /// CHCYCS.
        /// </summary>
        public const string CHCYCS = "CHCYCS";

        /// <summary>
        /// CHPTCRUSER.
        /// </summary>
        public const string CHPTCRUSER = "CHPTCRUSER";

        /// <summary>
        /// CHPTCRDTTM.
        /// </summary>
        public const string CHPTCRDTTM = "CHPTCRDTTM";

        /// <summary>
        /// CHPTUPUSER.
        /// </summary>
        public const string CHPTUPUSER = "CHPTUPUSER";

        /// <summary>
        /// CHPTUPDTTM.
        /// </summary>
        public const string CHPTUPDTTM = "CHPTUPDTTM";

        /// <summary>
        /// CHPTCLUSER.
        /// </summary>
        public const string CHPTCLUSER = "CHPTCLUSER";

        /// <summary>
        /// CHPTCLDTTM.
        /// </summary>
        public const string CHPTCLDTTM = "CHPTCLDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N4040";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHCYNO", "CHCYNO", JdeDataType.Numeric, null, true, true),
        new JdeField("CHCYCS", "CHCYCS", JdeDataType.String, 4),
        new JdeField("CHPTCRUSER", "CHPTCRUSER", JdeDataType.String, 32),
        new JdeField("CHPTCRDTTM", "CHPTCRDTTM", JdeDataType.String, 28),
        new JdeField("CHPTUPUSER", "CHPTUPUSER", JdeDataType.String, 32),
        new JdeField("CHPTUPDTTM", "CHPTUPDTTM", JdeDataType.String, 28),
        new JdeField("CHPTCLUSER", "CHPTCLUSER", JdeDataType.String, 32),
        new JdeField("CHPTCLDTTM", "CHPTCLDTTM", JdeDataType.String, 28)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N4040_0", "Primary Key on CHCYNO", new[] { "CHCYNO" }, isUnique: true, isPrimaryKey: true)
    };
}
