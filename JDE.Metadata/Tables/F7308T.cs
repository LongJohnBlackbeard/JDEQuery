using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7308T - .
/// </summary>
public class F7308T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PEVDBKY.
        /// </summary>
        public const string PEVDBKY = "PEVDBKY";

        /// <summary>
        /// PEVTEVID.
        /// </summary>
        public const string PEVTEVID = "PEVTEVID";

        /// <summary>
        /// PEVTEVPS.
        /// </summary>
        public const string PEVTEVPS = "PEVTEVPS";

        /// <summary>
        /// PEUSER.
        /// </summary>
        public const string PEUSER = "PEUSER";

        /// <summary>
        /// PEPID.
        /// </summary>
        public const string PEPID = "PEPID";

        /// <summary>
        /// PEUPMJ.
        /// </summary>
        public const string PEUPMJ = "PEUPMJ";

        /// <summary>
        /// PEUPMT.
        /// </summary>
        public const string PEUPMT = "PEUPMT";

        /// <summary>
        /// PEJOBN.
        /// </summary>
        public const string PEJOBN = "PEJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F7308T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PEVDBKY", "PEVDBKY", JdeDataType.String, 4, true, true),
        new JdeField("PEVTEVID", "PEVTEVID", JdeDataType.String, 2048),
        new JdeField("PEVTEVPS", "PEVTEVPS", JdeDataType.String, 2048),
        new JdeField("PEUSER", "PEUSER", JdeDataType.String, 20),
        new JdeField("PEPID", "PEPID", JdeDataType.String, 20),
        new JdeField("PEUPMJ", "PEUPMJ", JdeDataType.Numeric),
        new JdeField("PEUPMT", "PEUPMT", JdeDataType.Numeric),
        new JdeField("PEJOBN", "PEJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7308T_0", "Primary Key on PEVDBKY", new[] { "PEVDBKY" }, isUnique: true, isPrimaryKey: true)
    };
}
