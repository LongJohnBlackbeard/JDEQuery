using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08461 - .
/// </summary>
public class F08461 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R8PHRCAT.
        /// </summary>
        public const string R8PHRCAT = "R8PHRCAT";

        /// <summary>
        /// R8PHRID.
        /// </summary>
        public const string R8PHRID = "R8PHRID";

        /// <summary>
        /// R8LNGP.
        /// </summary>
        public const string R8LNGP = "R8LNGP";

        /// <summary>
        /// R8PHRASE.
        /// </summary>
        public const string R8PHRASE = "R8PHRASE";

        /// <summary>
        /// R8PID.
        /// </summary>
        public const string R8PID = "R8PID";

        /// <summary>
        /// R8USER.
        /// </summary>
        public const string R8USER = "R8USER";

        /// <summary>
        /// R8MKEY.
        /// </summary>
        public const string R8MKEY = "R8MKEY";

        /// <summary>
        /// R8UPMJ.
        /// </summary>
        public const string R8UPMJ = "R8UPMJ";

        /// <summary>
        /// R8UPMT.
        /// </summary>
        public const string R8UPMT = "R8UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08461";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R8PHRCAT", "R8PHRCAT", JdeDataType.String, 20, true, true),
        new JdeField("R8PHRID", "R8PHRID", JdeDataType.String, 20, true, true),
        new JdeField("R8LNGP", "R8LNGP", JdeDataType.String, 4, true, true),
        new JdeField("R8PHRASE", "R8PHRASE", JdeDataType.String, 1000),
        new JdeField("R8PID", "R8PID", JdeDataType.String, 20),
        new JdeField("R8USER", "R8USER", JdeDataType.String, 20),
        new JdeField("R8MKEY", "R8MKEY", JdeDataType.String, 30),
        new JdeField("R8UPMJ", "R8UPMJ", JdeDataType.Numeric),
        new JdeField("R8UPMT", "R8UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08461_0", "Primary Key on R8PHRCAT, R8PHRID, R8LNGP", new[] { "R8PHRCAT", "R8PHRID", "R8LNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
