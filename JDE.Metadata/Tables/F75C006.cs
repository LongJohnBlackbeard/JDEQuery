using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C006 - .
/// </summary>
public class F75C006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NACO.
        /// </summary>
        public const string NACO = "NACO";

        /// <summary>
        /// NAC75ACST.
        /// </summary>
        public const string NAC75ACST = "NAC75ACST";

        /// <summary>
        /// NAC75MOD.
        /// </summary>
        public const string NAC75MOD = "NAC75MOD";

        /// <summary>
        /// NAJOBN.
        /// </summary>
        public const string NAJOBN = "NAJOBN";

        /// <summary>
        /// NAPID.
        /// </summary>
        public const string NAPID = "NAPID";

        /// <summary>
        /// NAUPMT.
        /// </summary>
        public const string NAUPMT = "NAUPMT";

        /// <summary>
        /// NAUPMJ.
        /// </summary>
        public const string NAUPMJ = "NAUPMJ";

        /// <summary>
        /// NAUSER.
        /// </summary>
        public const string NAUSER = "NAUSER";

        /// <summary>
        /// NADL01.
        /// </summary>
        public const string NADL01 = "NADL01";

        /// <summary>
        /// NAMATH01.
        /// </summary>
        public const string NAMATH01 = "NAMATH01";

        /// <summary>
        /// NAFLAG.
        /// </summary>
        public const string NAFLAG = "NAFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75C006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NACO", "NACO", JdeDataType.String, 10, true, true),
        new JdeField("NAC75ACST", "NAC75ACST", JdeDataType.String, 120),
        new JdeField("NAC75MOD", "NAC75MOD", JdeDataType.String, 2),
        new JdeField("NAJOBN", "NAJOBN", JdeDataType.String, 20),
        new JdeField("NAPID", "NAPID", JdeDataType.String, 20),
        new JdeField("NAUPMT", "NAUPMT", JdeDataType.Numeric),
        new JdeField("NAUPMJ", "NAUPMJ", JdeDataType.Numeric),
        new JdeField("NAUSER", "NAUSER", JdeDataType.String, 20),
        new JdeField("NADL01", "NADL01", JdeDataType.String, 60),
        new JdeField("NAMATH01", "NAMATH01", JdeDataType.Numeric),
        new JdeField("NAFLAG", "NAFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C006_0", "Primary Key on NACO", new[] { "NACO" }, isUnique: true, isPrimaryKey: true)
    };
}
