using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A39 - .
/// </summary>
public class F79A39 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UM79AGESID.
        /// </summary>
        public const string UM79AGESID = "UM79AGESID";

        /// <summary>
        /// UMUM.
        /// </summary>
        public const string UMUM = "UMUM";

        /// <summary>
        /// UMRUM.
        /// </summary>
        public const string UMRUM = "UMRUM";

        /// <summary>
        /// UMCONV.
        /// </summary>
        public const string UMCONV = "UMCONV";

        /// <summary>
        /// UMPID.
        /// </summary>
        public const string UMPID = "UMPID";

        /// <summary>
        /// UMUSER.
        /// </summary>
        public const string UMUSER = "UMUSER";

        /// <summary>
        /// UMJOBN.
        /// </summary>
        public const string UMJOBN = "UMJOBN";

        /// <summary>
        /// UMUPMJ.
        /// </summary>
        public const string UMUPMJ = "UMUPMJ";

        /// <summary>
        /// UMTDAY.
        /// </summary>
        public const string UMTDAY = "UMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79A39";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UM79AGESID", "UM79AGESID", JdeDataType.Numeric, null, true, true),
        new JdeField("UMUM", "UMUM", JdeDataType.String, 4, true, true),
        new JdeField("UMRUM", "UMRUM", JdeDataType.String, 4, true, true),
        new JdeField("UMCONV", "UMCONV", JdeDataType.Numeric),
        new JdeField("UMPID", "UMPID", JdeDataType.String, 20),
        new JdeField("UMUSER", "UMUSER", JdeDataType.String, 20),
        new JdeField("UMJOBN", "UMJOBN", JdeDataType.String, 20),
        new JdeField("UMUPMJ", "UMUPMJ", JdeDataType.Numeric),
        new JdeField("UMTDAY", "UMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A39_0", "Primary Key on UM79AGESID, UMUM, UMRUM", new[] { "UM79AGESID", "UMUM", "UMRUM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A39_2", "Unique Index on UM79AGESID, UMRUM, UMUM", new[] { "UM79AGESID", "UMRUM", "UMUM" }, isUnique: true),
        new JdeIndex("F79A39_3", "Index on UMUM, UMRUM", new[] { "UMUM", "UMRUM" }),
        new JdeIndex("F79A39_4", "Index on UMRUM, UMUM", new[] { "UMRUM", "UMUM" })
    };
}
