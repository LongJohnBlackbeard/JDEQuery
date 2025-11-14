using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05103 - .
/// </summary>
public class F05103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AMSCLE.
        /// </summary>
        public const string AMSCLE = "AMSCLE";

        /// <summary>
        /// AMSCLL.
        /// </summary>
        public const string AMSCLL = "AMSCLL";

        /// <summary>
        /// AMSCLH.
        /// </summary>
        public const string AMSCLH = "AMSCLH";

        /// <summary>
        /// AMDL01.
        /// </summary>
        public const string AMDL01 = "AMDL01";

        /// <summary>
        /// AMUSER.
        /// </summary>
        public const string AMUSER = "AMUSER";

        /// <summary>
        /// AMPID.
        /// </summary>
        public const string AMPID = "AMPID";

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
    public override string TableName => "F05103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AMSCLE", "AMSCLE", JdeDataType.String, 20, true, true),
        new JdeField("AMSCLL", "AMSCLL", JdeDataType.Numeric),
        new JdeField("AMSCLH", "AMSCLH", JdeDataType.Numeric),
        new JdeField("AMDL01", "AMDL01", JdeDataType.String, 60),
        new JdeField("AMUSER", "AMUSER", JdeDataType.String, 20),
        new JdeField("AMPID", "AMPID", JdeDataType.String, 20),
        new JdeField("AMJOBN", "AMJOBN", JdeDataType.String, 20),
        new JdeField("AMUPMJ", "AMUPMJ", JdeDataType.Numeric),
        new JdeField("AMUPMT", "AMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05103_0", "Primary Key on AMSCLE", new[] { "AMSCLE" }, isUnique: true, isPrimaryKey: true)
    };
}
