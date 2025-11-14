using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07800 - .
/// </summary>
public class F07800 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JEIDYE.
        /// </summary>
        public const string JEIDYE = "JEIDYE";

        /// <summary>
        /// JEDTEY.
        /// </summary>
        public const string JEDTEY = "JEDTEY";

        /// <summary>
        /// JEAN8.
        /// </summary>
        public const string JEAN8 = "JEAN8";

        /// <summary>
        /// JECHGO.
        /// </summary>
        public const string JECHGO = "JECHGO";

        /// <summary>
        /// JEUPMJ.
        /// </summary>
        public const string JEUPMJ = "JEUPMJ";

        /// <summary>
        /// JEUPMT.
        /// </summary>
        public const string JEUPMT = "JEUPMT";

        /// <summary>
        /// JEPID.
        /// </summary>
        public const string JEPID = "JEPID";

        /// <summary>
        /// JEJOBN.
        /// </summary>
        public const string JEJOBN = "JEJOBN";

        /// <summary>
        /// JEUSER.
        /// </summary>
        public const string JEUSER = "JEUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07800";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JEIDYE", "JEIDYE", JdeDataType.String, 20, true, true),
        new JdeField("JEDTEY", "JEDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JEAN8", "JEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JECHGO", "JECHGO", JdeDataType.String, 2),
        new JdeField("JEUPMJ", "JEUPMJ", JdeDataType.Numeric),
        new JdeField("JEUPMT", "JEUPMT", JdeDataType.Numeric),
        new JdeField("JEPID", "JEPID", JdeDataType.String, 20),
        new JdeField("JEJOBN", "JEJOBN", JdeDataType.String, 20),
        new JdeField("JEUSER", "JEUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07800_0", "Primary Key on JEIDYE, JEDTEY, JEAN8", new[] { "JEIDYE", "JEDTEY", "JEAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07800_2", "Index on JEIDYE, JEDTEY, JECHGO", new[] { "JEIDYE", "JEDTEY", "JECHGO" })
    };
}
