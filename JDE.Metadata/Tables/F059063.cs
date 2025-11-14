using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F059063 - .
/// </summary>
public class F059063 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EOAN8.
        /// </summary>
        public const string EOAN8 = "EOAN8";

        /// <summary>
        /// EOLDID.
        /// </summary>
        public const string EOLDID = "EOLDID";

        /// <summary>
        /// EOLDED.
        /// </summary>
        public const string EOLDED = "EOLDED";

        /// <summary>
        /// EOLDBD.
        /// </summary>
        public const string EOLDBD = "EOLDBD";

        /// <summary>
        /// EOLDSH.
        /// </summary>
        public const string EOLDSH = "EOLDSH";

        /// <summary>
        /// EOALPH.
        /// </summary>
        public const string EOALPH = "EOALPH";

        /// <summary>
        /// EOUSER.
        /// </summary>
        public const string EOUSER = "EOUSER";

        /// <summary>
        /// EOPID.
        /// </summary>
        public const string EOPID = "EOPID";

        /// <summary>
        /// EOJOBN.
        /// </summary>
        public const string EOJOBN = "EOJOBN";

        /// <summary>
        /// EOUPMJ.
        /// </summary>
        public const string EOUPMJ = "EOUPMJ";

        /// <summary>
        /// EOUPMT.
        /// </summary>
        public const string EOUPMT = "EOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F059063";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EOAN8", "EOAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EOLDID", "EOLDID", JdeDataType.String, 10, true, true),
        new JdeField("EOLDED", "EOLDED", JdeDataType.Numeric, null, true, true),
        new JdeField("EOLDBD", "EOLDBD", JdeDataType.Numeric),
        new JdeField("EOLDSH", "EOLDSH", JdeDataType.Numeric),
        new JdeField("EOALPH", "EOALPH", JdeDataType.String, 80),
        new JdeField("EOUSER", "EOUSER", JdeDataType.String, 20),
        new JdeField("EOPID", "EOPID", JdeDataType.String, 20),
        new JdeField("EOJOBN", "EOJOBN", JdeDataType.String, 20),
        new JdeField("EOUPMJ", "EOUPMJ", JdeDataType.Numeric),
        new JdeField("EOUPMT", "EOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F059063_0", "Primary Key on EOAN8, EOLDID, EOLDED", new[] { "EOAN8", "EOLDID", "EOLDED" }, isUnique: true, isPrimaryKey: true)
    };
}
