using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S70 - .
/// </summary>
public class F74S70 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q0SRTI.
        /// </summary>
        public const string Q0SRTI = "Q0SRTI";

        /// <summary>
        /// Q0SDTI.
        /// </summary>
        public const string Q0SDTI = "Q0SDTI";

        /// <summary>
        /// Q0SYEA.
        /// </summary>
        public const string Q0SYEA = "Q0SYEA";

        /// <summary>
        /// Q0STON.
        /// </summary>
        public const string Q0STON = "Q0STON";

        /// <summary>
        /// Q0STID.
        /// </summary>
        public const string Q0STID = "Q0STID";

        /// <summary>
        /// Q0SCNA.
        /// </summary>
        public const string Q0SCNA = "Q0SCNA";

        /// <summary>
        /// Q0SAAB.
        /// </summary>
        public const string Q0SAAB = "Q0SAAB";

        /// <summary>
        /// Q0SFAD.
        /// </summary>
        public const string Q0SFAD = "Q0SFAD";

        /// <summary>
        /// Q0SFAN.
        /// </summary>
        public const string Q0SFAN = "Q0SFAN";

        /// <summary>
        /// Q0SZCO.
        /// </summary>
        public const string Q0SZCO = "Q0SZCO";

        /// <summary>
        /// Q0SCIT.
        /// </summary>
        public const string Q0SCIT = "Q0SCIT";

        /// <summary>
        /// Q0SACO.
        /// </summary>
        public const string Q0SACO = "Q0SACO";

        /// <summary>
        /// Q0SPNU.
        /// </summary>
        public const string Q0SPNU = "Q0SPNU";

        /// <summary>
        /// Q0SNR1.
        /// </summary>
        public const string Q0SNR1 = "Q0SNR1";

        /// <summary>
        /// Q0SNR2.
        /// </summary>
        public const string Q0SNR2 = "Q0SNR2";

        /// <summary>
        /// Q0SF53.
        /// </summary>
        public const string Q0SF53 = "Q0SF53";

        /// <summary>
        /// Q0CRCD.
        /// </summary>
        public const string Q0CRCD = "Q0CRCD";

        /// <summary>
        /// Q0CRDC.
        /// </summary>
        public const string Q0CRDC = "Q0CRDC";
    }

    /// <inheritdoc />
    public override string TableName => "F74S70";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q0SRTI", "Q0SRTI", JdeDataType.Numeric),
        new JdeField("Q0SDTI", "Q0SDTI", JdeDataType.Numeric),
        new JdeField("Q0SYEA", "Q0SYEA", JdeDataType.Numeric, null, true, true),
        new JdeField("Q0STON", "Q0STON", JdeDataType.Numeric),
        new JdeField("Q0STID", "Q0STID", JdeDataType.String, 18, true, true),
        new JdeField("Q0SCNA", "Q0SCNA", JdeDataType.String, 80),
        new JdeField("Q0SAAB", "Q0SAAB", JdeDataType.String, 4),
        new JdeField("Q0SFAD", "Q0SFAD", JdeDataType.String, 40),
        new JdeField("Q0SFAN", "Q0SFAN", JdeDataType.Numeric),
        new JdeField("Q0SZCO", "Q0SZCO", JdeDataType.Numeric),
        new JdeField("Q0SCIT", "Q0SCIT", JdeDataType.String, 24),
        new JdeField("Q0SACO", "Q0SACO", JdeDataType.String, 6),
        new JdeField("Q0SPNU", "Q0SPNU", JdeDataType.String, 14),
        new JdeField("Q0SNR1", "Q0SNR1", JdeDataType.Numeric),
        new JdeField("Q0SNR2", "Q0SNR2", JdeDataType.Numeric),
        new JdeField("Q0SF53", "Q0SF53", JdeDataType.String, 106),
        new JdeField("Q0CRCD", "Q0CRCD", JdeDataType.String, 6),
        new JdeField("Q0CRDC", "Q0CRDC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S70_0", "Primary Key on Q0STID, Q0SYEA", new[] { "Q0STID", "Q0SYEA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74S70_2", "Index on Q0SYEA, Q0SRTI, Q0STID", new[] { "Q0SYEA", "Q0SRTI", "Q0STID" })
    };
}
