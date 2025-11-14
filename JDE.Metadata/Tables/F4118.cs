using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4118 - .
/// </summary>
public class F4118 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CNAN8.
        /// </summary>
        public const string CNAN8 = "CNAN8";

        /// <summary>
        /// CNSHAN.
        /// </summary>
        public const string CNSHAN = "CNSHAN";

        /// <summary>
        /// CNITM.
        /// </summary>
        public const string CNITM = "CNITM";

        /// <summary>
        /// CNMCU.
        /// </summary>
        public const string CNMCU = "CNMCU";

        /// <summary>
        /// CNCO.
        /// </summary>
        public const string CNCO = "CNCO";

        /// <summary>
        /// CNUORG.
        /// </summary>
        public const string CNUORG = "CNUORG";

        /// <summary>
        /// CNUM.
        /// </summary>
        public const string CNUM = "CNUM";

        /// <summary>
        /// CNRKCO.
        /// </summary>
        public const string CNRKCO = "CNRKCO";

        /// <summary>
        /// CNRORN.
        /// </summary>
        public const string CNRORN = "CNRORN";

        /// <summary>
        /// CNRCTO.
        /// </summary>
        public const string CNRCTO = "CNRCTO";

        /// <summary>
        /// CNRLLN.
        /// </summary>
        public const string CNRLLN = "CNRLLN";

        /// <summary>
        /// CNCUTY.
        /// </summary>
        public const string CNCUTY = "CNCUTY";

        /// <summary>
        /// CNDEDT.
        /// </summary>
        public const string CNDEDT = "CNDEDT";

        /// <summary>
        /// CNDERT.
        /// </summary>
        public const string CNDERT = "CNDERT";

        /// <summary>
        /// CNCUAM.
        /// </summary>
        public const string CNCUAM = "CNCUAM";

        /// <summary>
        /// CNRFQT.
        /// </summary>
        public const string CNRFQT = "CNRFQT";

        /// <summary>
        /// CNRFAM.
        /// </summary>
        public const string CNRFAM = "CNRFAM";

        /// <summary>
        /// CNCRCD.
        /// </summary>
        public const string CNCRCD = "CNCRCD";

        /// <summary>
        /// CNCRR.
        /// </summary>
        public const string CNCRR = "CNCRR";

        /// <summary>
        /// CNFDRT.
        /// </summary>
        public const string CNFDRT = "CNFDRT";

        /// <summary>
        /// CNFDAA.
        /// </summary>
        public const string CNFDAA = "CNFDAA";

        /// <summary>
        /// CNFRFR.
        /// </summary>
        public const string CNFRFR = "CNFRFR";

        /// <summary>
        /// CNFRFA.
        /// </summary>
        public const string CNFRFA = "CNFRFA";

        /// <summary>
        /// CNCLFG.
        /// </summary>
        public const string CNCLFG = "CNCLFG";

        /// <summary>
        /// CNURAT.
        /// </summary>
        public const string CNURAT = "CNURAT";

        /// <summary>
        /// CNURCD.
        /// </summary>
        public const string CNURCD = "CNURCD";

        /// <summary>
        /// CNURC1.
        /// </summary>
        public const string CNURC1 = "CNURC1";

        /// <summary>
        /// CNURDT.
        /// </summary>
        public const string CNURDT = "CNURDT";

        /// <summary>
        /// CNURAB.
        /// </summary>
        public const string CNURAB = "CNURAB";

        /// <summary>
        /// CNURRF.
        /// </summary>
        public const string CNURRF = "CNURRF";

        /// <summary>
        /// CNCTQT.
        /// </summary>
        public const string CNCTQT = "CNCTQT";

        /// <summary>
        /// CNCMDT.
        /// </summary>
        public const string CNCMDT = "CNCMDT";

        /// <summary>
        /// CNCMUM.
        /// </summary>
        public const string CNCMUM = "CNCMUM";

        /// <summary>
        /// CNCTCD.
        /// </summary>
        public const string CNCTCD = "CNCTCD";

        /// <summary>
        /// CNCM01.
        /// </summary>
        public const string CNCM01 = "CNCM01";

        /// <summary>
        /// CNCM02.
        /// </summary>
        public const string CNCM02 = "CNCM02";

        /// <summary>
        /// CNCM03.
        /// </summary>
        public const string CNCM03 = "CNCM03";

        /// <summary>
        /// CNCM04.
        /// </summary>
        public const string CNCM04 = "CNCM04";

        /// <summary>
        /// CNCM05.
        /// </summary>
        public const string CNCM05 = "CNCM05";

        /// <summary>
        /// CNUSER.
        /// </summary>
        public const string CNUSER = "CNUSER";

        /// <summary>
        /// CNPID.
        /// </summary>
        public const string CNPID = "CNPID";

        /// <summary>
        /// CNJOBN.
        /// </summary>
        public const string CNJOBN = "CNJOBN";

        /// <summary>
        /// CNUPMJ.
        /// </summary>
        public const string CNUPMJ = "CNUPMJ";

        /// <summary>
        /// CNTDAY.
        /// </summary>
        public const string CNTDAY = "CNTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4118";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CNAN8", "CNAN8", JdeDataType.Numeric),
        new JdeField("CNSHAN", "CNSHAN", JdeDataType.Numeric),
        new JdeField("CNITM", "CNITM", JdeDataType.Numeric),
        new JdeField("CNMCU", "CNMCU", JdeDataType.String, 24),
        new JdeField("CNCO", "CNCO", JdeDataType.String, 10),
        new JdeField("CNUORG", "CNUORG", JdeDataType.Numeric),
        new JdeField("CNUM", "CNUM", JdeDataType.String, 4),
        new JdeField("CNRKCO", "CNRKCO", JdeDataType.String, 10, true, true),
        new JdeField("CNRORN", "CNRORN", JdeDataType.String, 16, true, true),
        new JdeField("CNRCTO", "CNRCTO", JdeDataType.String, 4, true, true),
        new JdeField("CNRLLN", "CNRLLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CNCUTY", "CNCUTY", JdeDataType.Numeric),
        new JdeField("CNDEDT", "CNDEDT", JdeDataType.Numeric),
        new JdeField("CNDERT", "CNDERT", JdeDataType.Numeric),
        new JdeField("CNCUAM", "CNCUAM", JdeDataType.Numeric),
        new JdeField("CNRFQT", "CNRFQT", JdeDataType.Numeric),
        new JdeField("CNRFAM", "CNRFAM", JdeDataType.Numeric),
        new JdeField("CNCRCD", "CNCRCD", JdeDataType.String, 6),
        new JdeField("CNCRR", "CNCRR", JdeDataType.Numeric),
        new JdeField("CNFDRT", "CNFDRT", JdeDataType.Numeric),
        new JdeField("CNFDAA", "CNFDAA", JdeDataType.Numeric),
        new JdeField("CNFRFR", "CNFRFR", JdeDataType.Numeric),
        new JdeField("CNFRFA", "CNFRFA", JdeDataType.Numeric),
        new JdeField("CNCLFG", "CNCLFG", JdeDataType.String, 2),
        new JdeField("CNURAT", "CNURAT", JdeDataType.Numeric),
        new JdeField("CNURCD", "CNURCD", JdeDataType.String, 4),
        new JdeField("CNURC1", "CNURC1", JdeDataType.String, 6),
        new JdeField("CNURDT", "CNURDT", JdeDataType.Numeric),
        new JdeField("CNURAB", "CNURAB", JdeDataType.Numeric),
        new JdeField("CNURRF", "CNURRF", JdeDataType.String, 30),
        new JdeField("CNCTQT", "CNCTQT", JdeDataType.Numeric),
        new JdeField("CNCMDT", "CNCMDT", JdeDataType.Numeric),
        new JdeField("CNCMUM", "CNCMUM", JdeDataType.String, 4),
        new JdeField("CNCTCD", "CNCTCD", JdeDataType.String, 4),
        new JdeField("CNCM01", "CNCM01", JdeDataType.String, 2),
        new JdeField("CNCM02", "CNCM02", JdeDataType.String, 2),
        new JdeField("CNCM03", "CNCM03", JdeDataType.String, 2),
        new JdeField("CNCM04", "CNCM04", JdeDataType.String, 2),
        new JdeField("CNCM05", "CNCM05", JdeDataType.String, 2),
        new JdeField("CNUSER", "CNUSER", JdeDataType.String, 20),
        new JdeField("CNPID", "CNPID", JdeDataType.String, 20),
        new JdeField("CNJOBN", "CNJOBN", JdeDataType.String, 20),
        new JdeField("CNUPMJ", "CNUPMJ", JdeDataType.Numeric),
        new JdeField("CNTDAY", "CNTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4118_0", "Primary Key on CNRKCO, CNRORN, CNRCTO, CNRLLN", new[] { "CNRKCO", "CNRORN", "CNRCTO", "CNRLLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4118_1", "Index on CNAN8, CNITM, CNMCU, CNDEDT", new[] { "CNAN8", "CNITM", "CNMCU", "CNDEDT" })
    };
}
