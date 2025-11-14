using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T015 - .
/// </summary>
public class F75T015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SL75TUIP.
        /// </summary>
        public const string SL75TUIP = "SL75TUIP";

        /// <summary>
        /// SL75TGRF.
        /// </summary>
        public const string SL75TGRF = "SL75TGRF";

        /// <summary>
        /// SL75TGSF.
        /// </summary>
        public const string SL75TGSF = "SL75TGSF";

        /// <summary>
        /// SLUSER.
        /// </summary>
        public const string SLUSER = "SLUSER";

        /// <summary>
        /// SLPID.
        /// </summary>
        public const string SLPID = "SLPID";

        /// <summary>
        /// SLJOBN.
        /// </summary>
        public const string SLJOBN = "SLJOBN";

        /// <summary>
        /// SLUPMJ.
        /// </summary>
        public const string SLUPMJ = "SLUPMJ";

        /// <summary>
        /// SLTDAY.
        /// </summary>
        public const string SLTDAY = "SLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SL75TUIP", "SL75TUIP", JdeDataType.String, 4, true, true),
        new JdeField("SL75TGRF", "SL75TGRF", JdeDataType.Numeric, null, true, true),
        new JdeField("SL75TGSF", "SL75TGSF", JdeDataType.Numeric, null, true, true),
        new JdeField("SLUSER", "SLUSER", JdeDataType.String, 20),
        new JdeField("SLPID", "SLPID", JdeDataType.String, 20),
        new JdeField("SLJOBN", "SLJOBN", JdeDataType.String, 20),
        new JdeField("SLUPMJ", "SLUPMJ", JdeDataType.Numeric),
        new JdeField("SLTDAY", "SLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T015_0", "Primary Key on SL75TUIP, SL75TGRF, SL75TGSF", new[] { "SL75TUIP", "SL75TGRF", "SL75TGSF" }, isUnique: true, isPrimaryKey: true)
    };
}
