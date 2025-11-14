using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0474N1 - .
/// </summary>
public class F0474N1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QBCBNK.
        /// </summary>
        public const string QBCBNK = "QBCBNK";

        /// <summary>
        /// QBWSID.
        /// </summary>
        public const string QBWSID = "QBWSID";

        /// <summary>
        /// QBWEYN.
        /// </summary>
        public const string QBWEYN = "QBWEYN";

        /// <summary>
        /// QBWSIG.
        /// </summary>
        public const string QBWSIG = "QBWSIG";

        /// <summary>
        /// QBWPPN.
        /// </summary>
        public const string QBWPPN = "QBWPPN";

        /// <summary>
        /// QBWPPD.
        /// </summary>
        public const string QBWPPD = "QBWPPD";

        /// <summary>
        /// QBWPKN.
        /// </summary>
        public const string QBWPKN = "QBWPKN";

        /// <summary>
        /// QBWPKE.
        /// </summary>
        public const string QBWPKE = "QBWPKE";

        /// <summary>
        /// QBWFIM.
        /// </summary>
        public const string QBWFIM = "QBWFIM";

        /// <summary>
        /// QBPYIN.
        /// </summary>
        public const string QBPYIN = "QBPYIN";
    }

    /// <inheritdoc />
    public override string TableName => "F0474N1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QBCBNK", "QBCBNK", JdeDataType.String, 40, true, true),
        new JdeField("QBWSID", "QBWSID", JdeDataType.Numeric, null, true, true),
        new JdeField("QBWEYN", "QBWEYN", JdeDataType.String, 2),
        new JdeField("QBWSIG", "QBWSIG", JdeDataType.String, 70),
        new JdeField("QBWPPN", "QBWPPN", JdeDataType.Numeric),
        new JdeField("QBWPPD", "QBWPPD", JdeDataType.Numeric),
        new JdeField("QBWPKN", "QBWPKN", JdeDataType.String, 10),
        new JdeField("QBWPKE", "QBWPKE", JdeDataType.String, 10),
        new JdeField("QBWFIM", "QBWFIM", JdeDataType.String, 60),
        new JdeField("QBPYIN", "QBPYIN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0474N1_0", "Primary Key on QBCBNK, QBWSID", new[] { "QBCBNK", "QBWSID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0474N1_2", "Index on QBWPKN", new[] { "QBWPKN" })
    };
}
