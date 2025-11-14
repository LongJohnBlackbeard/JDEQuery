using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43S001 - .
/// </summary>
public class F43S001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AMSRMALERT.
        /// </summary>
        public const string AMSRMALERT = "AMSRMALERT";

        /// <summary>
        /// AMUSER.
        /// </summary>
        public const string AMUSER = "AMUSER";

        /// <summary>
        /// AMJOBN.
        /// </summary>
        public const string AMJOBN = "AMJOBN";

        /// <summary>
        /// AMUPMJ.
        /// </summary>
        public const string AMUPMJ = "AMUPMJ";

        /// <summary>
        /// AMUPMT.
        /// </summary>
        public const string AMUPMT = "AMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F43S001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AMSRMALERT", "AMSRMALERT", JdeDataType.Numeric, null, true, true),
        new JdeField("AMUSER", "AMUSER", JdeDataType.String, 20),
        new JdeField("AMJOBN", "AMJOBN", JdeDataType.String, 20),
        new JdeField("AMUPMJ", "AMUPMJ", JdeDataType.Numeric),
        new JdeField("AMUPMT", "AMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43S001_0", "Primary Key on AMSRMALERT", new[] { "AMSRMALERT" }, isUnique: true, isPrimaryKey: true)
    };
}
