using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1541BW - .
/// </summary>
public class F1541BW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OWDOCO.
        /// </summary>
        public const string OWDOCO = "OWDOCO";

        /// <summary>
        /// OWMCU.
        /// </summary>
        public const string OWMCU = "OWMCU";

        /// <summary>
        /// OWMCUS.
        /// </summary>
        public const string OWMCUS = "OWMCUS";

        /// <summary>
        /// OWUNIT.
        /// </summary>
        public const string OWUNIT = "OWUNIT";

        /// <summary>
        /// OWDBAN.
        /// </summary>
        public const string OWDBAN = "OWDBAN";

        /// <summary>
        /// OWSTNR.
        /// </summary>
        public const string OWSTNR = "OWSTNR";

        /// <summary>
        /// OWULI.
        /// </summary>
        public const string OWULI = "OWULI";

        /// <summary>
        /// OWPRDC.
        /// </summary>
        public const string OWPRDC = "OWPRDC";

        /// <summary>
        /// OWCTRY.
        /// </summary>
        public const string OWCTRY = "OWCTRY";

        /// <summary>
        /// OWYR.
        /// </summary>
        public const string OWYR = "OWYR";

        /// <summary>
        /// OWAN8.
        /// </summary>
        public const string OWAN8 = "OWAN8";

        /// <summary>
        /// OWCO.
        /// </summary>
        public const string OWCO = "OWCO";

        /// <summary>
        /// OWULI2.
        /// </summary>
        public const string OWULI2 = "OWULI2";

        /// <summary>
        /// OWSH01.
        /// </summary>
        public const string OWSH01 = "OWSH01";

        /// <summary>
        /// OWSH02.
        /// </summary>
        public const string OWSH02 = "OWSH02";

        /// <summary>
        /// OWSH03.
        /// </summary>
        public const string OWSH03 = "OWSH03";

        /// <summary>
        /// OWSH04.
        /// </summary>
        public const string OWSH04 = "OWSH04";

        /// <summary>
        /// OWSH05.
        /// </summary>
        public const string OWSH05 = "OWSH05";

        /// <summary>
        /// OWSH06.
        /// </summary>
        public const string OWSH06 = "OWSH06";

        /// <summary>
        /// OWSH07.
        /// </summary>
        public const string OWSH07 = "OWSH07";

        /// <summary>
        /// OWSH08.
        /// </summary>
        public const string OWSH08 = "OWSH08";

        /// <summary>
        /// OWSH09.
        /// </summary>
        public const string OWSH09 = "OWSH09";

        /// <summary>
        /// OWSH10.
        /// </summary>
        public const string OWSH10 = "OWSH10";

        /// <summary>
        /// OWSH11.
        /// </summary>
        public const string OWSH11 = "OWSH11";

        /// <summary>
        /// OWSH12.
        /// </summary>
        public const string OWSH12 = "OWSH12";

        /// <summary>
        /// OWES01.
        /// </summary>
        public const string OWES01 = "OWES01";

        /// <summary>
        /// OWES02.
        /// </summary>
        public const string OWES02 = "OWES02";

        /// <summary>
        /// OWES03.
        /// </summary>
        public const string OWES03 = "OWES03";

        /// <summary>
        /// OWES04.
        /// </summary>
        public const string OWES04 = "OWES04";

        /// <summary>
        /// OWES05.
        /// </summary>
        public const string OWES05 = "OWES05";

        /// <summary>
        /// OWES06.
        /// </summary>
        public const string OWES06 = "OWES06";

        /// <summary>
        /// OWES07.
        /// </summary>
        public const string OWES07 = "OWES07";

        /// <summary>
        /// OWES08.
        /// </summary>
        public const string OWES08 = "OWES08";

        /// <summary>
        /// OWES09.
        /// </summary>
        public const string OWES09 = "OWES09";

        /// <summary>
        /// OWES10.
        /// </summary>
        public const string OWES10 = "OWES10";

        /// <summary>
        /// OWES11.
        /// </summary>
        public const string OWES11 = "OWES11";

        /// <summary>
        /// OWES12.
        /// </summary>
        public const string OWES12 = "OWES12";

        /// <summary>
        /// OWRM11.
        /// </summary>
        public const string OWRM11 = "OWRM11";

        /// <summary>
        /// OWRM12.
        /// </summary>
        public const string OWRM12 = "OWRM12";

        /// <summary>
        /// OWRM13.
        /// </summary>
        public const string OWRM13 = "OWRM13";

        /// <summary>
        /// OWRM14.
        /// </summary>
        public const string OWRM14 = "OWRM14";

        /// <summary>
        /// OWRM15.
        /// </summary>
        public const string OWRM15 = "OWRM15";

        /// <summary>
        /// OWRM21.
        /// </summary>
        public const string OWRM21 = "OWRM21";

        /// <summary>
        /// OWRM22.
        /// </summary>
        public const string OWRM22 = "OWRM22";

        /// <summary>
        /// OWRM23.
        /// </summary>
        public const string OWRM23 = "OWRM23";

        /// <summary>
        /// OWRM24.
        /// </summary>
        public const string OWRM24 = "OWRM24";

        /// <summary>
        /// OWRM25.
        /// </summary>
        public const string OWRM25 = "OWRM25";

        /// <summary>
        /// OWFLOR.
        /// </summary>
        public const string OWFLOR = "OWFLOR";

        /// <summary>
        /// OWURCD.
        /// </summary>
        public const string OWURCD = "OWURCD";

        /// <summary>
        /// OWURDT.
        /// </summary>
        public const string OWURDT = "OWURDT";

        /// <summary>
        /// OWURAT.
        /// </summary>
        public const string OWURAT = "OWURAT";

        /// <summary>
        /// OWURRF.
        /// </summary>
        public const string OWURRF = "OWURRF";

        /// <summary>
        /// OWUSER.
        /// </summary>
        public const string OWUSER = "OWUSER";

        /// <summary>
        /// OWUPMJ.
        /// </summary>
        public const string OWUPMJ = "OWUPMJ";

        /// <summary>
        /// OWPID.
        /// </summary>
        public const string OWPID = "OWPID";

        /// <summary>
        /// OWJOBN.
        /// </summary>
        public const string OWJOBN = "OWJOBN";

        /// <summary>
        /// OWUPMT.
        /// </summary>
        public const string OWUPMT = "OWUPMT";

        /// <summary>
        /// OWTORG.
        /// </summary>
        public const string OWTORG = "OWTORG";

        /// <summary>
        /// OWENTJ.
        /// </summary>
        public const string OWENTJ = "OWENTJ";

        /// <summary>
        /// OWCRCD.
        /// </summary>
        public const string OWCRCD = "OWCRCD";

        /// <summary>
        /// OWCRR.
        /// </summary>
        public const string OWCRR = "OWCRR";

        /// <summary>
        /// OWCRRM.
        /// </summary>
        public const string OWCRRM = "OWCRRM";
    }

    /// <inheritdoc />
    public override string TableName => "F1541BW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OWDOCO", "OWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("OWMCU", "OWMCU", JdeDataType.String, 24, true, true),
        new JdeField("OWMCUS", "OWMCUS", JdeDataType.String, 24, true, true),
        new JdeField("OWUNIT", "OWUNIT", JdeDataType.String, 16, true, true),
        new JdeField("OWDBAN", "OWDBAN", JdeDataType.Numeric, null, true, true),
        new JdeField("OWSTNR", "OWSTNR", JdeDataType.String, 20, true, true),
        new JdeField("OWULI", "OWULI", JdeDataType.String, 16, true, true),
        new JdeField("OWPRDC", "OWPRDC", JdeDataType.String, 8, true, true),
        new JdeField("OWCTRY", "OWCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("OWYR", "OWYR", JdeDataType.Numeric, null, true, true),
        new JdeField("OWAN8", "OWAN8", JdeDataType.Numeric),
        new JdeField("OWCO", "OWCO", JdeDataType.String, 10),
        new JdeField("OWULI2", "OWULI2", JdeDataType.String, 16),
        new JdeField("OWSH01", "OWSH01", JdeDataType.Numeric),
        new JdeField("OWSH02", "OWSH02", JdeDataType.Numeric),
        new JdeField("OWSH03", "OWSH03", JdeDataType.Numeric),
        new JdeField("OWSH04", "OWSH04", JdeDataType.Numeric),
        new JdeField("OWSH05", "OWSH05", JdeDataType.Numeric),
        new JdeField("OWSH06", "OWSH06", JdeDataType.Numeric),
        new JdeField("OWSH07", "OWSH07", JdeDataType.Numeric),
        new JdeField("OWSH08", "OWSH08", JdeDataType.Numeric),
        new JdeField("OWSH09", "OWSH09", JdeDataType.Numeric),
        new JdeField("OWSH10", "OWSH10", JdeDataType.Numeric),
        new JdeField("OWSH11", "OWSH11", JdeDataType.Numeric),
        new JdeField("OWSH12", "OWSH12", JdeDataType.Numeric),
        new JdeField("OWES01", "OWES01", JdeDataType.Numeric),
        new JdeField("OWES02", "OWES02", JdeDataType.Numeric),
        new JdeField("OWES03", "OWES03", JdeDataType.Numeric),
        new JdeField("OWES04", "OWES04", JdeDataType.Numeric),
        new JdeField("OWES05", "OWES05", JdeDataType.Numeric),
        new JdeField("OWES06", "OWES06", JdeDataType.Numeric),
        new JdeField("OWES07", "OWES07", JdeDataType.Numeric),
        new JdeField("OWES08", "OWES08", JdeDataType.Numeric),
        new JdeField("OWES09", "OWES09", JdeDataType.Numeric),
        new JdeField("OWES10", "OWES10", JdeDataType.Numeric),
        new JdeField("OWES11", "OWES11", JdeDataType.Numeric),
        new JdeField("OWES12", "OWES12", JdeDataType.Numeric),
        new JdeField("OWRM11", "OWRM11", JdeDataType.String, 8),
        new JdeField("OWRM12", "OWRM12", JdeDataType.String, 8),
        new JdeField("OWRM13", "OWRM13", JdeDataType.String, 8),
        new JdeField("OWRM14", "OWRM14", JdeDataType.String, 8),
        new JdeField("OWRM15", "OWRM15", JdeDataType.String, 8),
        new JdeField("OWRM21", "OWRM21", JdeDataType.String, 8),
        new JdeField("OWRM22", "OWRM22", JdeDataType.String, 8),
        new JdeField("OWRM23", "OWRM23", JdeDataType.String, 8),
        new JdeField("OWRM24", "OWRM24", JdeDataType.String, 8),
        new JdeField("OWRM25", "OWRM25", JdeDataType.String, 8),
        new JdeField("OWFLOR", "OWFLOR", JdeDataType.String, 8),
        new JdeField("OWURCD", "OWURCD", JdeDataType.String, 4),
        new JdeField("OWURDT", "OWURDT", JdeDataType.Numeric),
        new JdeField("OWURAT", "OWURAT", JdeDataType.Numeric),
        new JdeField("OWURRF", "OWURRF", JdeDataType.String, 30),
        new JdeField("OWUSER", "OWUSER", JdeDataType.String, 20),
        new JdeField("OWUPMJ", "OWUPMJ", JdeDataType.Numeric),
        new JdeField("OWPID", "OWPID", JdeDataType.String, 20),
        new JdeField("OWJOBN", "OWJOBN", JdeDataType.String, 20),
        new JdeField("OWUPMT", "OWUPMT", JdeDataType.Numeric),
        new JdeField("OWTORG", "OWTORG", JdeDataType.String, 20),
        new JdeField("OWENTJ", "OWENTJ", JdeDataType.Numeric),
        new JdeField("OWCRCD", "OWCRCD", JdeDataType.String, 6),
        new JdeField("OWCRR", "OWCRR", JdeDataType.Numeric),
        new JdeField("OWCRRM", "OWCRRM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1541BW_0", "Primary Key on OWDOCO, OWMCU, OWMCUS, OWUNIT, OWDBAN, OWSTNR, OWULI, OWPRDC, OWCTRY, OWYR", new[] { "OWDOCO", "OWMCU", "OWMCUS", "OWUNIT", "OWDBAN", "OWSTNR", "OWULI", "OWPRDC", "OWCTRY", "OWYR" }, isUnique: true, isPrimaryKey: true)
    };
}
