using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4211AU - .
/// </summary>
public class F4211AU : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AUDOCO.
        /// </summary>
        public const string AUDOCO = "AUDOCO";

        /// <summary>
        /// AUDCTO.
        /// </summary>
        public const string AUDCTO = "AUDCTO";

        /// <summary>
        /// AUKCOO.
        /// </summary>
        public const string AUKCOO = "AUKCOO";

        /// <summary>
        /// AUCO.
        /// </summary>
        public const string AUCO = "AUCO";

        /// <summary>
        /// AULNID.
        /// </summary>
        public const string AULNID = "AULNID";

        /// <summary>
        /// AULNTY.
        /// </summary>
        public const string AULNTY = "AULNTY";

        /// <summary>
        /// AUSTKT.
        /// </summary>
        public const string AUSTKT = "AUSTKT";

        /// <summary>
        /// AUEMCU.
        /// </summary>
        public const string AUEMCU = "AUEMCU";

        /// <summary>
        /// AUMCU.
        /// </summary>
        public const string AUMCU = "AUMCU";

        /// <summary>
        /// AUDMBU.
        /// </summary>
        public const string AUDMBU = "AUDMBU";

        /// <summary>
        /// AUCRCD.
        /// </summary>
        public const string AUCRCD = "AUCRCD";

        /// <summary>
        /// AUCRDC.
        /// </summary>
        public const string AUCRDC = "AUCRDC";

        /// <summary>
        /// AUAN8.
        /// </summary>
        public const string AUAN8 = "AUAN8";

        /// <summary>
        /// AUSHAN.
        /// </summary>
        public const string AUSHAN = "AUSHAN";

        /// <summary>
        /// AUPA8.
        /// </summary>
        public const string AUPA8 = "AUPA8";

        /// <summary>
        /// AUITM.
        /// </summary>
        public const string AUITM = "AUITM";

        /// <summary>
        /// AULITM.
        /// </summary>
        public const string AULITM = "AULITM";

        /// <summary>
        /// AUAITM.
        /// </summary>
        public const string AUAITM = "AUAITM";

        /// <summary>
        /// AUUOM1.
        /// </summary>
        public const string AUUOM1 = "AUUOM1";

        /// <summary>
        /// AUAFIT.
        /// </summary>
        public const string AUAFIT = "AUAFIT";

        /// <summary>
        /// AUSRP1.
        /// </summary>
        public const string AUSRP1 = "AUSRP1";

        /// <summary>
        /// AUSRP2.
        /// </summary>
        public const string AUSRP2 = "AUSRP2";

        /// <summary>
        /// AUSRP3.
        /// </summary>
        public const string AUSRP3 = "AUSRP3";

        /// <summary>
        /// AUSRP4.
        /// </summary>
        public const string AUSRP4 = "AUSRP4";

        /// <summary>
        /// AUSRP5.
        /// </summary>
        public const string AUSRP5 = "AUSRP5";

        /// <summary>
        /// AUPRP1.
        /// </summary>
        public const string AUPRP1 = "AUPRP1";

        /// <summary>
        /// AUPRP2.
        /// </summary>
        public const string AUPRP2 = "AUPRP2";

        /// <summary>
        /// AUPRP3.
        /// </summary>
        public const string AUPRP3 = "AUPRP3";

        /// <summary>
        /// AUPRP4.
        /// </summary>
        public const string AUPRP4 = "AUPRP4";

        /// <summary>
        /// AUPRP5.
        /// </summary>
        public const string AUPRP5 = "AUPRP5";

        /// <summary>
        /// AUSLSM.
        /// </summary>
        public const string AUSLSM = "AUSLSM";

        /// <summary>
        /// AUSLM2.
        /// </summary>
        public const string AUSLM2 = "AUSLM2";

        /// <summary>
        /// AURCD.
        /// </summary>
        public const string AURCD = "AURCD";

        /// <summary>
        /// AUAEXP.
        /// </summary>
        public const string AUAEXP = "AUAEXP";

        /// <summary>
        /// AUEANC.
        /// </summary>
        public const string AUEANC = "AUEANC";

        /// <summary>
        /// AUUORG.
        /// </summary>
        public const string AUUORG = "AUUORG";

        /// <summary>
        /// AUOQNC.
        /// </summary>
        public const string AUOQNC = "AUOQNC";

        /// <summary>
        /// AUSOQS.
        /// </summary>
        public const string AUSOQS = "AUSOQS";

        /// <summary>
        /// AUDQNC.
        /// </summary>
        public const string AUDQNC = "AUDQNC";

        /// <summary>
        /// AUSOBK.
        /// </summary>
        public const string AUSOBK = "AUSOBK";

        /// <summary>
        /// AUBQNC.
        /// </summary>
        public const string AUBQNC = "AUBQNC";

        /// <summary>
        /// AUSOCN.
        /// </summary>
        public const string AUSOCN = "AUSOCN";

        /// <summary>
        /// AUCQNC.
        /// </summary>
        public const string AUCQNC = "AUCQNC";

        /// <summary>
        /// AUBSBF.
        /// </summary>
        public const string AUBSBF = "AUBSBF";

        /// <summary>
        /// AUPRSU.
        /// </summary>
        public const string AUPRSU = "AUPRSU";

        /// <summary>
        /// AUAUF1.
        /// </summary>
        public const string AUAUF1 = "AUAUF1";

        /// <summary>
        /// AUAUF2.
        /// </summary>
        public const string AUAUF2 = "AUAUF2";

        /// <summary>
        /// AUAUF3.
        /// </summary>
        public const string AUAUF3 = "AUAUF3";

        /// <summary>
        /// AUURCD.
        /// </summary>
        public const string AUURCD = "AUURCD";

        /// <summary>
        /// AUURDT.
        /// </summary>
        public const string AUURDT = "AUURDT";

        /// <summary>
        /// AUURAT.
        /// </summary>
        public const string AUURAT = "AUURAT";

        /// <summary>
        /// AUURAB.
        /// </summary>
        public const string AUURAB = "AUURAB";

        /// <summary>
        /// AUURRF.
        /// </summary>
        public const string AUURRF = "AUURRF";

        /// <summary>
        /// AUUSER.
        /// </summary>
        public const string AUUSER = "AUUSER";

        /// <summary>
        /// AUPID.
        /// </summary>
        public const string AUPID = "AUPID";

        /// <summary>
        /// AUJOBN.
        /// </summary>
        public const string AUJOBN = "AUJOBN";

        /// <summary>
        /// AUUPMJ.
        /// </summary>
        public const string AUUPMJ = "AUUPMJ";

        /// <summary>
        /// AUTDAY.
        /// </summary>
        public const string AUTDAY = "AUTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4211AU";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AUDOCO", "AUDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("AUDCTO", "AUDCTO", JdeDataType.String, 4, true, true),
        new JdeField("AUKCOO", "AUKCOO", JdeDataType.String, 10, true, true),
        new JdeField("AUCO", "AUCO", JdeDataType.String, 10),
        new JdeField("AULNID", "AULNID", JdeDataType.Numeric, null, true, true),
        new JdeField("AULNTY", "AULNTY", JdeDataType.String, 4),
        new JdeField("AUSTKT", "AUSTKT", JdeDataType.String, 2),
        new JdeField("AUEMCU", "AUEMCU", JdeDataType.String, 24),
        new JdeField("AUMCU", "AUMCU", JdeDataType.String, 24),
        new JdeField("AUDMBU", "AUDMBU", JdeDataType.String, 24),
        new JdeField("AUCRCD", "AUCRCD", JdeDataType.String, 6),
        new JdeField("AUCRDC", "AUCRDC", JdeDataType.String, 6),
        new JdeField("AUAN8", "AUAN8", JdeDataType.Numeric),
        new JdeField("AUSHAN", "AUSHAN", JdeDataType.Numeric),
        new JdeField("AUPA8", "AUPA8", JdeDataType.Numeric),
        new JdeField("AUITM", "AUITM", JdeDataType.Numeric),
        new JdeField("AULITM", "AULITM", JdeDataType.String, 50),
        new JdeField("AUAITM", "AUAITM", JdeDataType.String, 50),
        new JdeField("AUUOM1", "AUUOM1", JdeDataType.String, 4),
        new JdeField("AUAFIT", "AUAFIT", JdeDataType.String, 2),
        new JdeField("AUSRP1", "AUSRP1", JdeDataType.String, 6),
        new JdeField("AUSRP2", "AUSRP2", JdeDataType.String, 6),
        new JdeField("AUSRP3", "AUSRP3", JdeDataType.String, 6),
        new JdeField("AUSRP4", "AUSRP4", JdeDataType.String, 6),
        new JdeField("AUSRP5", "AUSRP5", JdeDataType.String, 6),
        new JdeField("AUPRP1", "AUPRP1", JdeDataType.String, 6),
        new JdeField("AUPRP2", "AUPRP2", JdeDataType.String, 6),
        new JdeField("AUPRP3", "AUPRP3", JdeDataType.String, 6),
        new JdeField("AUPRP4", "AUPRP4", JdeDataType.String, 6),
        new JdeField("AUPRP5", "AUPRP5", JdeDataType.String, 6),
        new JdeField("AUSLSM", "AUSLSM", JdeDataType.Numeric),
        new JdeField("AUSLM2", "AUSLM2", JdeDataType.Numeric),
        new JdeField("AURCD", "AURCD", JdeDataType.String, 6),
        new JdeField("AUAEXP", "AUAEXP", JdeDataType.Numeric),
        new JdeField("AUEANC", "AUEANC", JdeDataType.Numeric),
        new JdeField("AUUORG", "AUUORG", JdeDataType.Numeric),
        new JdeField("AUOQNC", "AUOQNC", JdeDataType.Numeric),
        new JdeField("AUSOQS", "AUSOQS", JdeDataType.Numeric),
        new JdeField("AUDQNC", "AUDQNC", JdeDataType.Numeric),
        new JdeField("AUSOBK", "AUSOBK", JdeDataType.Numeric),
        new JdeField("AUBQNC", "AUBQNC", JdeDataType.Numeric),
        new JdeField("AUSOCN", "AUSOCN", JdeDataType.Numeric),
        new JdeField("AUCQNC", "AUCQNC", JdeDataType.Numeric),
        new JdeField("AUBSBF", "AUBSBF", JdeDataType.String, 2),
        new JdeField("AUPRSU", "AUPRSU", JdeDataType.String, 2),
        new JdeField("AUAUF1", "AUAUF1", JdeDataType.String, 50),
        new JdeField("AUAUF2", "AUAUF2", JdeDataType.Numeric),
        new JdeField("AUAUF3", "AUAUF3", JdeDataType.Numeric),
        new JdeField("AUURCD", "AUURCD", JdeDataType.String, 4),
        new JdeField("AUURDT", "AUURDT", JdeDataType.Numeric),
        new JdeField("AUURAT", "AUURAT", JdeDataType.Numeric),
        new JdeField("AUURAB", "AUURAB", JdeDataType.Numeric),
        new JdeField("AUURRF", "AUURRF", JdeDataType.String, 30),
        new JdeField("AUUSER", "AUUSER", JdeDataType.String, 20),
        new JdeField("AUPID", "AUPID", JdeDataType.String, 20),
        new JdeField("AUJOBN", "AUJOBN", JdeDataType.String, 20),
        new JdeField("AUUPMJ", "AUUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("AUTDAY", "AUTDAY", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4211AU_0", "Primary Key on AUDOCO, AUDCTO, AUKCOO, AULNID, AUUPMJ, AUTDAY", new[] { "AUDOCO", "AUDCTO", "AUKCOO", "AULNID", "AUUPMJ", "AUTDAY" }, isUnique: true, isPrimaryKey: true)
    };
}
