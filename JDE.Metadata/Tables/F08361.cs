using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08361 - .
/// </summary>
public class F08361 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NAPLAN.
        /// </summary>
        public const string NAPLAN = "NAPLAN";

        /// <summary>
        /// NADL01.
        /// </summary>
        public const string NADL01 = "NADL01";

        /// <summary>
        /// NAPID.
        /// </summary>
        public const string NAPID = "NAPID";

        /// <summary>
        /// NAUSER.
        /// </summary>
        public const string NAUSER = "NAUSER";

        /// <summary>
        /// NAUPMJ.
        /// </summary>
        public const string NAUPMJ = "NAUPMJ";

        /// <summary>
        /// NAUPMT.
        /// </summary>
        public const string NAUPMT = "NAUPMT";

        /// <summary>
        /// NAJOBN.
        /// </summary>
        public const string NAJOBN = "NAJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08361";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NAPLAN", "NAPLAN", JdeDataType.String, 16, true, true),
        new JdeField("NADL01", "NADL01", JdeDataType.String, 60),
        new JdeField("NAPID", "NAPID", JdeDataType.String, 20),
        new JdeField("NAUSER", "NAUSER", JdeDataType.String, 20),
        new JdeField("NAUPMJ", "NAUPMJ", JdeDataType.Numeric),
        new JdeField("NAUPMT", "NAUPMT", JdeDataType.Numeric),
        new JdeField("NAJOBN", "NAJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08361_0", "Primary Key on NAPLAN", new[] { "NAPLAN" }, isUnique: true, isPrimaryKey: true)
    };
}
