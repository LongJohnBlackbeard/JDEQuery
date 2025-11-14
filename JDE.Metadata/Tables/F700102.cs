using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F700102 - .
/// </summary>
public class F700102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TESY.
        /// </summary>
        public const string TESY = "TESY";

        /// <summary>
        /// TELCTR.
        /// </summary>
        public const string TELCTR = "TELCTR";

        /// <summary>
        /// TEEXR1.
        /// </summary>
        public const string TEEXR1 = "TEEXR1";

        /// <summary>
        /// TEUPMJ.
        /// </summary>
        public const string TEUPMJ = "TEUPMJ";

        /// <summary>
        /// TEUPMT.
        /// </summary>
        public const string TEUPMT = "TEUPMT";

        /// <summary>
        /// TEJOBN.
        /// </summary>
        public const string TEJOBN = "TEJOBN";

        /// <summary>
        /// TEPID.
        /// </summary>
        public const string TEPID = "TEPID";

        /// <summary>
        /// TEUSER.
        /// </summary>
        public const string TEUSER = "TEUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F700102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TESY", "TESY", JdeDataType.String, 8, true, true),
        new JdeField("TELCTR", "TELCTR", JdeDataType.String, 6, true, true),
        new JdeField("TEEXR1", "TEEXR1", JdeDataType.String, 4, true, true),
        new JdeField("TEUPMJ", "TEUPMJ", JdeDataType.Numeric),
        new JdeField("TEUPMT", "TEUPMT", JdeDataType.Numeric),
        new JdeField("TEJOBN", "TEJOBN", JdeDataType.String, 20),
        new JdeField("TEPID", "TEPID", JdeDataType.String, 20),
        new JdeField("TEUSER", "TEUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F700102_0", "Primary Key on TESY, TELCTR, TEEXR1", new[] { "TESY", "TELCTR", "TEEXR1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F700102_2", "Index on TESY, TELCTR", new[] { "TESY", "TELCTR" })
    };
}
