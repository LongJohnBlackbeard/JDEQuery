using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08402 - .
/// </summary>
public class F08402 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HAAN8.
        /// </summary>
        public const string HAAN8 = "HAAN8";

        /// <summary>
        /// HAEFTO.
        /// </summary>
        public const string HAEFTO = "HAEFTO";

        /// <summary>
        /// HACCPR.
        /// </summary>
        public const string HACCPR = "HACCPR";

        /// <summary>
        /// HAUSER.
        /// </summary>
        public const string HAUSER = "HAUSER";

        /// <summary>
        /// HAPID.
        /// </summary>
        public const string HAPID = "HAPID";

        /// <summary>
        /// HAUPMJ.
        /// </summary>
        public const string HAUPMJ = "HAUPMJ";

        /// <summary>
        /// HAJOBN.
        /// </summary>
        public const string HAJOBN = "HAJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08402";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HAAN8", "HAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HAEFTO", "HAEFTO", JdeDataType.Numeric),
        new JdeField("HACCPR", "HACCPR", JdeDataType.String, 6),
        new JdeField("HAUSER", "HAUSER", JdeDataType.String, 20),
        new JdeField("HAPID", "HAPID", JdeDataType.String, 20),
        new JdeField("HAUPMJ", "HAUPMJ", JdeDataType.Numeric),
        new JdeField("HAJOBN", "HAJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08402_0", "Primary Key on HAAN8", new[] { "HAAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
