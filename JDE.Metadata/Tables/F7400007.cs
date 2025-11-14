using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7400007 - .
/// </summary>
public class F7400007 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDMCU.
        /// </summary>
        public const string BDMCU = "BDMCU";

        /// <summary>
        /// BDDCTO.
        /// </summary>
        public const string BDDCTO = "BDDCTO";

        /// <summary>
        /// BDSMAS.
        /// </summary>
        public const string BDSMAS = "BDSMAS";

        /// <summary>
        /// BDN001.
        /// </summary>
        public const string BDN001 = "BDN001";

        /// <summary>
        /// BDTORG.
        /// </summary>
        public const string BDTORG = "BDTORG";

        /// <summary>
        /// BDUSER.
        /// </summary>
        public const string BDUSER = "BDUSER";

        /// <summary>
        /// BDPID.
        /// </summary>
        public const string BDPID = "BDPID";

        /// <summary>
        /// BDJOBN.
        /// </summary>
        public const string BDJOBN = "BDJOBN";

        /// <summary>
        /// BDUPMJ.
        /// </summary>
        public const string BDUPMJ = "BDUPMJ";

        /// <summary>
        /// BDUPMT.
        /// </summary>
        public const string BDUPMT = "BDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F7400007";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDMCU", "BDMCU", JdeDataType.String, 24, true, true),
        new JdeField("BDDCTO", "BDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("BDSMAS", "BDSMAS", JdeDataType.String, 4),
        new JdeField("BDN001", "BDN001", JdeDataType.Numeric),
        new JdeField("BDTORG", "BDTORG", JdeDataType.String, 20),
        new JdeField("BDUSER", "BDUSER", JdeDataType.String, 20),
        new JdeField("BDPID", "BDPID", JdeDataType.String, 20),
        new JdeField("BDJOBN", "BDJOBN", JdeDataType.String, 20),
        new JdeField("BDUPMJ", "BDUPMJ", JdeDataType.Numeric),
        new JdeField("BDUPMT", "BDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7400007_0", "Primary Key on BDMCU, BDDCTO", new[] { "BDMCU", "BDDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
