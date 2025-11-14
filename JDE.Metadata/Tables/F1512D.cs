using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1512D - .
/// </summary>
public class F1512D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NAGLC.
        /// </summary>
        public const string NAGLC = "NAGLC";

        /// <summary>
        /// NAMCU.
        /// </summary>
        public const string NAMCU = "NAMCU";

        /// <summary>
        /// NALNGP.
        /// </summary>
        public const string NALNGP = "NALNGP";

        /// <summary>
        /// NADL01.
        /// </summary>
        public const string NADL01 = "NADL01";

        /// <summary>
        /// NAUSER.
        /// </summary>
        public const string NAUSER = "NAUSER";

        /// <summary>
        /// NAPID.
        /// </summary>
        public const string NAPID = "NAPID";

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

        /// <summary>
        /// NATORG.
        /// </summary>
        public const string NATORG = "NATORG";

        /// <summary>
        /// NAENTJ.
        /// </summary>
        public const string NAENTJ = "NAENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1512D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NAGLC", "NAGLC", JdeDataType.String, 8, true, true),
        new JdeField("NAMCU", "NAMCU", JdeDataType.String, 24, true, true),
        new JdeField("NALNGP", "NALNGP", JdeDataType.String, 4, true, true),
        new JdeField("NADL01", "NADL01", JdeDataType.String, 60),
        new JdeField("NAUSER", "NAUSER", JdeDataType.String, 20),
        new JdeField("NAPID", "NAPID", JdeDataType.String, 20),
        new JdeField("NAUPMJ", "NAUPMJ", JdeDataType.Numeric),
        new JdeField("NAUPMT", "NAUPMT", JdeDataType.Numeric),
        new JdeField("NAJOBN", "NAJOBN", JdeDataType.String, 20),
        new JdeField("NATORG", "NATORG", JdeDataType.String, 20),
        new JdeField("NAENTJ", "NAENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1512D_0", "Primary Key on NAGLC, NAMCU, NALNGP", new[] { "NAGLC", "NAMCU", "NALNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
