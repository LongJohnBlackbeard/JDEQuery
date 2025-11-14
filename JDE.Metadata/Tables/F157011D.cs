using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F157011D - .
/// </summary>
public class F157011D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NAOPTY.
        /// </summary>
        public const string NAOPTY = "NAOPTY";

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
    public override string TableName => "F157011D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NAOPTY", "NAOPTY", JdeDataType.String, 8, true, true),
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
        new JdeIndex("F157011D_0", "Primary Key on NAOPTY, NALNGP", new[] { "NAOPTY", "NALNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
