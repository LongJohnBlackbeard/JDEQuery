using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S90 - .
/// </summary>
public class F74S90 : JdeTable
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
        /// Q0SSTA.
        /// </summary>
        public const string Q0SSTA = "Q0SSTA";

        /// <summary>
        /// Q0SFLO.
        /// </summary>
        public const string Q0SFLO = "Q0SFLO";

        /// <summary>
        /// Q0SDOO.
        /// </summary>
        public const string Q0SDOO = "Q0SDOO";

        /// <summary>
        /// Q0SZCO.
        /// </summary>
        public const string Q0SZCO = "Q0SZCO";

        /// <summary>
        /// Q0SCIT.
        /// </summary>
        public const string Q0SCIT = "Q0SCIT";

        /// <summary>
        /// Q0ST91.
        /// </summary>
        public const string Q0ST91 = "Q0ST91";

        /// <summary>
        /// Q0SNR9.
        /// </summary>
        public const string Q0SNR9 = "Q0SNR9";

        /// <summary>
        /// Q0SSTY.
        /// </summary>
        public const string Q0SSTY = "Q0SSTY";

        /// <summary>
        /// Q0SACO.
        /// </summary>
        public const string Q0SACO = "Q0SACO";

        /// <summary>
        /// Q0SPNU.
        /// </summary>
        public const string Q0SPNU = "Q0SPNU";

        /// <summary>
        /// Q0DS40.
        /// </summary>
        public const string Q0DS40 = "Q0DS40";

        /// <summary>
        /// Q0SDNU.
        /// </summary>
        public const string Q0SDNU = "Q0SDNU";

        /// <summary>
        /// Q0SFL2.
        /// </summary>
        public const string Q0SFL2 = "Q0SFL2";

        /// <summary>
        /// Q0CRCD.
        /// </summary>
        public const string Q0CRCD = "Q0CRCD";

        /// <summary>
        /// Q0CRDC.
        /// </summary>
        public const string Q0CRDC = "Q0CRDC";

        /// <summary>
        /// Q0SDPE.
        /// </summary>
        public const string Q0SDPE = "Q0SDPE";

        /// <summary>
        /// Q0AR1.
        /// </summary>
        public const string Q0AR1 = "Q0AR1";

        /// <summary>
        /// Q0PH1.
        /// </summary>
        public const string Q0PH1 = "Q0PH1";
    }

    /// <inheritdoc />
    public override string TableName => "F74S90";

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
        new JdeField("Q0SSTA", "Q0SSTA", JdeDataType.String, 4),
        new JdeField("Q0SFLO", "Q0SFLO", JdeDataType.String, 4),
        new JdeField("Q0SDOO", "Q0SDOO", JdeDataType.String, 4),
        new JdeField("Q0SZCO", "Q0SZCO", JdeDataType.Numeric),
        new JdeField("Q0SCIT", "Q0SCIT", JdeDataType.String, 24),
        new JdeField("Q0ST91", "Q0ST91", JdeDataType.Numeric),
        new JdeField("Q0SNR9", "Q0SNR9", JdeDataType.Numeric),
        new JdeField("Q0SSTY", "Q0SSTY", JdeDataType.String, 2),
        new JdeField("Q0SACO", "Q0SACO", JdeDataType.String, 6),
        new JdeField("Q0SPNU", "Q0SPNU", JdeDataType.String, 14),
        new JdeField("Q0DS40", "Q0DS40", JdeDataType.String, 80),
        new JdeField("Q0SDNU", "Q0SDNU", JdeDataType.Numeric),
        new JdeField("Q0SFL2", "Q0SFL2", JdeDataType.String, 4),
        new JdeField("Q0CRCD", "Q0CRCD", JdeDataType.String, 6),
        new JdeField("Q0CRDC", "Q0CRDC", JdeDataType.String, 6),
        new JdeField("Q0SDPE", "Q0SDPE", JdeDataType.String, 4, true, true),
        new JdeField("Q0AR1", "Q0AR1", JdeDataType.String, 12),
        new JdeField("Q0PH1", "Q0PH1", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S90_0", "Primary Key on Q0STID, Q0SYEA, Q0SDPE", new[] { "Q0STID", "Q0SYEA", "Q0SDPE" }, isUnique: true, isPrimaryKey: true)
    };
}
