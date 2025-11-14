using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T014 - .
/// </summary>
public class F75T014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SBCO.
        /// </summary>
        public const string SBCO = "SBCO";

        /// <summary>
        /// SB75TDSI.
        /// </summary>
        public const string SB75TDSI = "SB75TDSI";

        /// <summary>
        /// SB75TAUC.
        /// </summary>
        public const string SB75TAUC = "SB75TAUC";

        /// <summary>
        /// SB75TYMD.
        /// </summary>
        public const string SB75TYMD = "SB75TYMD";

        /// <summary>
        /// SB75TDCT.
        /// </summary>
        public const string SB75TDCT = "SB75TDCT";

        /// <summary>
        /// SB75TGFC.
        /// </summary>
        public const string SB75TGFC = "SB75TGFC";

        /// <summary>
        /// SB75TTXT.
        /// </summary>
        public const string SB75TTXT = "SB75TTXT";

        /// <summary>
        /// SB75TUIP.
        /// </summary>
        public const string SB75TUIP = "SB75TUIP";

        /// <summary>
        /// SB75TGRF.
        /// </summary>
        public const string SB75TGRF = "SB75TGRF";

        /// <summary>
        /// SB75TGSF.
        /// </summary>
        public const string SB75TGSF = "SB75TGSF";

        /// <summary>
        /// SBUSER.
        /// </summary>
        public const string SBUSER = "SBUSER";

        /// <summary>
        /// SBPID.
        /// </summary>
        public const string SBPID = "SBPID";

        /// <summary>
        /// SBJOBN.
        /// </summary>
        public const string SBJOBN = "SBJOBN";

        /// <summary>
        /// SBUPMJ.
        /// </summary>
        public const string SBUPMJ = "SBUPMJ";

        /// <summary>
        /// SBTDAY.
        /// </summary>
        public const string SBTDAY = "SBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SBCO", "SBCO", JdeDataType.String, 10, true, true),
        new JdeField("SB75TDSI", "SB75TDSI", JdeDataType.String, 10, true, true),
        new JdeField("SB75TAUC", "SB75TAUC", JdeDataType.String, 20, true, true),
        new JdeField("SB75TYMD", "SB75TYMD", JdeDataType.Numeric, null, true, true),
        new JdeField("SB75TDCT", "SB75TDCT", JdeDataType.String, 6, true, true),
        new JdeField("SB75TGFC", "SB75TGFC", JdeDataType.String, 4, true, true),
        new JdeField("SB75TTXT", "SB75TTXT", JdeDataType.String, 2, true, true),
        new JdeField("SB75TUIP", "SB75TUIP", JdeDataType.String, 4),
        new JdeField("SB75TGRF", "SB75TGRF", JdeDataType.Numeric),
        new JdeField("SB75TGSF", "SB75TGSF", JdeDataType.Numeric),
        new JdeField("SBUSER", "SBUSER", JdeDataType.String, 20),
        new JdeField("SBPID", "SBPID", JdeDataType.String, 20),
        new JdeField("SBJOBN", "SBJOBN", JdeDataType.String, 20),
        new JdeField("SBUPMJ", "SBUPMJ", JdeDataType.Numeric),
        new JdeField("SBTDAY", "SBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T014_0", "Primary Key on SBCO, SB75TDSI, SB75TAUC, SB75TYMD, SB75TDCT, SB75TGFC, SB75TTXT", new[] { "SBCO", "SB75TDSI", "SB75TAUC", "SB75TYMD", "SB75TDCT", "SB75TGFC", "SB75TTXT" }, isUnique: true, isPrimaryKey: true)
    };
}
