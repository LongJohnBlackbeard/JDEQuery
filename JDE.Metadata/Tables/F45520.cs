using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F45520 - .
/// </summary>
public class F45520 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHDOCO.
        /// </summary>
        public const string PHDOCO = "PHDOCO";

        /// <summary>
        /// PHDCTO.
        /// </summary>
        public const string PHDCTO = "PHDCTO";

        /// <summary>
        /// PHCO.
        /// </summary>
        public const string PHCO = "PHCO";

        /// <summary>
        /// PHPRCLST.
        /// </summary>
        public const string PHPRCLST = "PHPRCLST";

        /// <summary>
        /// PHPLDESC.
        /// </summary>
        public const string PHPLDESC = "PHPLDESC";

        /// <summary>
        /// PHEXDJ.
        /// </summary>
        public const string PHEXDJ = "PHEXDJ";

        /// <summary>
        /// PHEFTJ.
        /// </summary>
        public const string PHEFTJ = "PHEFTJ";

        /// <summary>
        /// PHAN8.
        /// </summary>
        public const string PHAN8 = "PHAN8";

        /// <summary>
        /// PHPLFINAL.
        /// </summary>
        public const string PHPLFINAL = "PHPLFINAL";

        /// <summary>
        /// PHASN.
        /// </summary>
        public const string PHASN = "PHASN";

        /// <summary>
        /// PHMCU.
        /// </summary>
        public const string PHMCU = "PHMCU";

        /// <summary>
        /// PHPTC.
        /// </summary>
        public const string PHPTC = "PHPTC";

        /// <summary>
        /// PHRYIN.
        /// </summary>
        public const string PHRYIN = "PHRYIN";

        /// <summary>
        /// PHCRCD.
        /// </summary>
        public const string PHCRCD = "PHCRCD";

        /// <summary>
        /// PHPLCTL1.
        /// </summary>
        public const string PHPLCTL1 = "PHPLCTL1";

        /// <summary>
        /// PHPLCTL2.
        /// </summary>
        public const string PHPLCTL2 = "PHPLCTL2";

        /// <summary>
        /// PHPLCTL3.
        /// </summary>
        public const string PHPLCTL3 = "PHPLCTL3";

        /// <summary>
        /// PHPLCTL4.
        /// </summary>
        public const string PHPLCTL4 = "PHPLCTL4";

        /// <summary>
        /// PHPLCTL5.
        /// </summary>
        public const string PHPLCTL5 = "PHPLCTL5";

        /// <summary>
        /// PHURCD.
        /// </summary>
        public const string PHURCD = "PHURCD";

        /// <summary>
        /// PHURDT.
        /// </summary>
        public const string PHURDT = "PHURDT";

        /// <summary>
        /// PHURAT.
        /// </summary>
        public const string PHURAT = "PHURAT";

        /// <summary>
        /// PHURAB.
        /// </summary>
        public const string PHURAB = "PHURAB";

        /// <summary>
        /// PHURRF.
        /// </summary>
        public const string PHURRF = "PHURRF";

        /// <summary>
        /// PHPID.
        /// </summary>
        public const string PHPID = "PHPID";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHJOBN.
        /// </summary>
        public const string PHJOBN = "PHJOBN";

        /// <summary>
        /// PHUPMJ.
        /// </summary>
        public const string PHUPMJ = "PHUPMJ";

        /// <summary>
        /// PHUPMT.
        /// </summary>
        public const string PHUPMT = "PHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F45520";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHDOCO", "PHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PHDCTO", "PHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PHCO", "PHCO", JdeDataType.String, 10),
        new JdeField("PHPRCLST", "PHPRCLST", JdeDataType.String, 20),
        new JdeField("PHPLDESC", "PHPLDESC", JdeDataType.String, 60),
        new JdeField("PHEXDJ", "PHEXDJ", JdeDataType.Numeric),
        new JdeField("PHEFTJ", "PHEFTJ", JdeDataType.Numeric),
        new JdeField("PHAN8", "PHAN8", JdeDataType.Numeric),
        new JdeField("PHPLFINAL", "PHPLFINAL", JdeDataType.String, 2),
        new JdeField("PHASN", "PHASN", JdeDataType.String, 16),
        new JdeField("PHMCU", "PHMCU", JdeDataType.String, 24),
        new JdeField("PHPTC", "PHPTC", JdeDataType.String, 6),
        new JdeField("PHRYIN", "PHRYIN", JdeDataType.String, 2),
        new JdeField("PHCRCD", "PHCRCD", JdeDataType.String, 6),
        new JdeField("PHPLCTL1", "PHPLCTL1", JdeDataType.String, 30),
        new JdeField("PHPLCTL2", "PHPLCTL2", JdeDataType.String, 30),
        new JdeField("PHPLCTL3", "PHPLCTL3", JdeDataType.String, 30),
        new JdeField("PHPLCTL4", "PHPLCTL4", JdeDataType.String, 30),
        new JdeField("PHPLCTL5", "PHPLCTL5", JdeDataType.String, 30),
        new JdeField("PHURCD", "PHURCD", JdeDataType.String, 4),
        new JdeField("PHURDT", "PHURDT", JdeDataType.Numeric),
        new JdeField("PHURAT", "PHURAT", JdeDataType.Numeric),
        new JdeField("PHURAB", "PHURAB", JdeDataType.Numeric),
        new JdeField("PHURRF", "PHURRF", JdeDataType.String, 30),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHUPMT", "PHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F45520_0", "Primary Key on PHDOCO, PHDCTO", new[] { "PHDOCO", "PHDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
