using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F157011 - .
/// </summary>
public class F157011 : JdeTable
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
        /// NADL01.
        /// </summary>
        public const string NADL01 = "NADL01";

        /// <summary>
        /// NAURCD.
        /// </summary>
        public const string NAURCD = "NAURCD";

        /// <summary>
        /// NAURDT.
        /// </summary>
        public const string NAURDT = "NAURDT";

        /// <summary>
        /// NAURAT.
        /// </summary>
        public const string NAURAT = "NAURAT";

        /// <summary>
        /// NAURAB.
        /// </summary>
        public const string NAURAB = "NAURAB";

        /// <summary>
        /// NAURRF.
        /// </summary>
        public const string NAURRF = "NAURRF";

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
        /// NAENTJ.
        /// </summary>
        public const string NAENTJ = "NAENTJ";

        /// <summary>
        /// NATORG.
        /// </summary>
        public const string NATORG = "NATORG";
    }

    /// <inheritdoc />
    public override string TableName => "F157011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NAOPTY", "NAOPTY", JdeDataType.String, 8, true, true),
        new JdeField("NADL01", "NADL01", JdeDataType.String, 60),
        new JdeField("NAURCD", "NAURCD", JdeDataType.String, 4),
        new JdeField("NAURDT", "NAURDT", JdeDataType.Numeric),
        new JdeField("NAURAT", "NAURAT", JdeDataType.Numeric),
        new JdeField("NAURAB", "NAURAB", JdeDataType.Numeric),
        new JdeField("NAURRF", "NAURRF", JdeDataType.String, 30),
        new JdeField("NAUSER", "NAUSER", JdeDataType.String, 20),
        new JdeField("NAPID", "NAPID", JdeDataType.String, 20),
        new JdeField("NAUPMJ", "NAUPMJ", JdeDataType.Numeric),
        new JdeField("NAUPMT", "NAUPMT", JdeDataType.Numeric),
        new JdeField("NAJOBN", "NAJOBN", JdeDataType.String, 20),
        new JdeField("NAENTJ", "NAENTJ", JdeDataType.Numeric),
        new JdeField("NATORG", "NATORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F157011_0", "Primary Key on NAOPTY", new[] { "NAOPTY" }, isUnique: true, isPrimaryKey: true)
    };
}
