using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4012Z - .
/// </summary>
public class F4012Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPEKCO.
        /// </summary>
        public const string SPEKCO = "SPEKCO";

        /// <summary>
        /// SPEDOC.
        /// </summary>
        public const string SPEDOC = "SPEDOC";

        /// <summary>
        /// SPEDCT.
        /// </summary>
        public const string SPEDCT = "SPEDCT";

        /// <summary>
        /// SPEDLN.
        /// </summary>
        public const string SPEDLN = "SPEDLN";

        /// <summary>
        /// SPUITM.
        /// </summary>
        public const string SPUITM = "SPUITM";

        /// <summary>
        /// SPEDSP.
        /// </summary>
        public const string SPEDSP = "SPEDSP";

        /// <summary>
        /// SPDC01.
        /// </summary>
        public const string SPDC01 = "SPDC01";

        /// <summary>
        /// SPLC01.
        /// </summary>
        public const string SPLC01 = "SPLC01";

        /// <summary>
        /// SPQT01.
        /// </summary>
        public const string SPQT01 = "SPQT01";

        /// <summary>
        /// SPDC02.
        /// </summary>
        public const string SPDC02 = "SPDC02";

        /// <summary>
        /// SPLC02.
        /// </summary>
        public const string SPLC02 = "SPLC02";

        /// <summary>
        /// SPQT02.
        /// </summary>
        public const string SPQT02 = "SPQT02";

        /// <summary>
        /// SPDC03.
        /// </summary>
        public const string SPDC03 = "SPDC03";

        /// <summary>
        /// SPLC03.
        /// </summary>
        public const string SPLC03 = "SPLC03";

        /// <summary>
        /// SPQT03.
        /// </summary>
        public const string SPQT03 = "SPQT03";

        /// <summary>
        /// SPDC04.
        /// </summary>
        public const string SPDC04 = "SPDC04";

        /// <summary>
        /// SPLC04.
        /// </summary>
        public const string SPLC04 = "SPLC04";

        /// <summary>
        /// SPQT04.
        /// </summary>
        public const string SPQT04 = "SPQT04";

        /// <summary>
        /// SPDC05.
        /// </summary>
        public const string SPDC05 = "SPDC05";

        /// <summary>
        /// SPLC05.
        /// </summary>
        public const string SPLC05 = "SPLC05";

        /// <summary>
        /// SPQT05.
        /// </summary>
        public const string SPQT05 = "SPQT05";

        /// <summary>
        /// SPDC06.
        /// </summary>
        public const string SPDC06 = "SPDC06";

        /// <summary>
        /// SPLC06.
        /// </summary>
        public const string SPLC06 = "SPLC06";

        /// <summary>
        /// SPQT06.
        /// </summary>
        public const string SPQT06 = "SPQT06";

        /// <summary>
        /// SPDC07.
        /// </summary>
        public const string SPDC07 = "SPDC07";

        /// <summary>
        /// SPLC07.
        /// </summary>
        public const string SPLC07 = "SPLC07";

        /// <summary>
        /// SPQT07.
        /// </summary>
        public const string SPQT07 = "SPQT07";

        /// <summary>
        /// SPDC08.
        /// </summary>
        public const string SPDC08 = "SPDC08";

        /// <summary>
        /// SPLC08.
        /// </summary>
        public const string SPLC08 = "SPLC08";

        /// <summary>
        /// SPQT08.
        /// </summary>
        public const string SPQT08 = "SPQT08";

        /// <summary>
        /// SPDC09.
        /// </summary>
        public const string SPDC09 = "SPDC09";

        /// <summary>
        /// SPLC09.
        /// </summary>
        public const string SPLC09 = "SPLC09";

        /// <summary>
        /// SPQT09.
        /// </summary>
        public const string SPQT09 = "SPQT09";

        /// <summary>
        /// SPDC10.
        /// </summary>
        public const string SPDC10 = "SPDC10";

        /// <summary>
        /// SPLC10.
        /// </summary>
        public const string SPLC10 = "SPLC10";

        /// <summary>
        /// SPQT10.
        /// </summary>
        public const string SPQT10 = "SPQT10";

        /// <summary>
        /// SPTORG.
        /// </summary>
        public const string SPTORG = "SPTORG";

        /// <summary>
        /// SPANTY.
        /// </summary>
        public const string SPANTY = "SPANTY";
    }

    /// <inheritdoc />
    public override string TableName => "F4012Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPEKCO", "SPEKCO", JdeDataType.String, 10, true, true),
        new JdeField("SPEDOC", "SPEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SPEDCT", "SPEDCT", JdeDataType.String, 4, true, true),
        new JdeField("SPEDLN", "SPEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SPUITM", "SPUITM", JdeDataType.String, 52),
        new JdeField("SPEDSP", "SPEDSP", JdeDataType.String, 2),
        new JdeField("SPDC01", "SPDC01", JdeDataType.Numeric),
        new JdeField("SPLC01", "SPLC01", JdeDataType.Numeric),
        new JdeField("SPQT01", "SPQT01", JdeDataType.Numeric),
        new JdeField("SPDC02", "SPDC02", JdeDataType.Numeric),
        new JdeField("SPLC02", "SPLC02", JdeDataType.Numeric),
        new JdeField("SPQT02", "SPQT02", JdeDataType.Numeric),
        new JdeField("SPDC03", "SPDC03", JdeDataType.Numeric),
        new JdeField("SPLC03", "SPLC03", JdeDataType.Numeric),
        new JdeField("SPQT03", "SPQT03", JdeDataType.Numeric),
        new JdeField("SPDC04", "SPDC04", JdeDataType.Numeric),
        new JdeField("SPLC04", "SPLC04", JdeDataType.Numeric),
        new JdeField("SPQT04", "SPQT04", JdeDataType.Numeric),
        new JdeField("SPDC05", "SPDC05", JdeDataType.Numeric),
        new JdeField("SPLC05", "SPLC05", JdeDataType.Numeric),
        new JdeField("SPQT05", "SPQT05", JdeDataType.Numeric),
        new JdeField("SPDC06", "SPDC06", JdeDataType.Numeric),
        new JdeField("SPLC06", "SPLC06", JdeDataType.Numeric),
        new JdeField("SPQT06", "SPQT06", JdeDataType.Numeric),
        new JdeField("SPDC07", "SPDC07", JdeDataType.Numeric),
        new JdeField("SPLC07", "SPLC07", JdeDataType.Numeric),
        new JdeField("SPQT07", "SPQT07", JdeDataType.Numeric),
        new JdeField("SPDC08", "SPDC08", JdeDataType.Numeric),
        new JdeField("SPLC08", "SPLC08", JdeDataType.Numeric),
        new JdeField("SPQT08", "SPQT08", JdeDataType.Numeric),
        new JdeField("SPDC09", "SPDC09", JdeDataType.Numeric),
        new JdeField("SPLC09", "SPLC09", JdeDataType.Numeric),
        new JdeField("SPQT09", "SPQT09", JdeDataType.Numeric),
        new JdeField("SPDC10", "SPDC10", JdeDataType.Numeric),
        new JdeField("SPLC10", "SPLC10", JdeDataType.Numeric),
        new JdeField("SPQT10", "SPQT10", JdeDataType.Numeric),
        new JdeField("SPTORG", "SPTORG", JdeDataType.String, 20),
        new JdeField("SPANTY", "SPANTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4012Z_0", "Primary Key on SPEDOC, SPEKCO, SPEDCT, SPEDLN", new[] { "SPEDOC", "SPEKCO", "SPEDCT", "SPEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
