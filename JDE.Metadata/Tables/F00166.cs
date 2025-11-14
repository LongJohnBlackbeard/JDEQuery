using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00166 - .
/// </summary>
public class F00166 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GTOBNM.
        /// </summary>
        public const string GTOBNM = "GTOBNM";

        /// <summary>
        /// GTTXKY.
        /// </summary>
        public const string GTTXKY = "GTTXKY";

        /// <summary>
        /// GTMOSEQN.
        /// </summary>
        public const string GTMOSEQN = "GTMOSEQN";

        /// <summary>
        /// GTMODOCTP.
        /// </summary>
        public const string GTMODOCTP = "GTMODOCTP";

        /// <summary>
        /// GTMODL01.
        /// </summary>
        public const string GTMODL01 = "GTMODL01";

        /// <summary>
        /// GTMOAUTHOR.
        /// </summary>
        public const string GTMOAUTHOR = "GTMOAUTHOR";

        /// <summary>
        /// GTCDT.
        /// </summary>
        public const string GTCDT = "GTCDT";

        /// <summary>
        /// GTMOSTATUS.
        /// </summary>
        public const string GTMOSTATUS = "GTMOSTATUS";

        /// <summary>
        /// GTMOEFDTFR.
        /// </summary>
        public const string GTMOEFDTFR = "GTMOEFDTFR";

        /// <summary>
        /// GTMOEFDTTO.
        /// </summary>
        public const string GTMOEFDTTO = "GTMOEFDTTO";

        /// <summary>
        /// GTMOREVDT.
        /// </summary>
        public const string GTMOREVDT = "GTMOREVDT";

        /// <summary>
        /// GTMOCPYLINK.
        /// </summary>
        public const string GTMOCPYLINK = "GTMOCPYLINK";

        /// <summary>
        /// GTMOLNGP.
        /// </summary>
        public const string GTMOLNGP = "GTMOLNGP";

        /// <summary>
        /// GTMCU.
        /// </summary>
        public const string GTMCU = "GTMCU";

        /// <summary>
        /// GTCO.
        /// </summary>
        public const string GTCO = "GTCO";

        /// <summary>
        /// GTAN8.
        /// </summary>
        public const string GTAN8 = "GTAN8";

        /// <summary>
        /// GTSHAN.
        /// </summary>
        public const string GTSHAN = "GTSHAN";

        /// <summary>
        /// GTAN8V.
        /// </summary>
        public const string GTAN8V = "GTAN8V";

        /// <summary>
        /// GTMOEMPL.
        /// </summary>
        public const string GTMOEMPL = "GTMOEMPL";

        /// <summary>
        /// GTDOCO.
        /// </summary>
        public const string GTDOCO = "GTDOCO";

        /// <summary>
        /// GTDCTO.
        /// </summary>
        public const string GTDCTO = "GTDCTO";

        /// <summary>
        /// GTITM.
        /// </summary>
        public const string GTITM = "GTITM";

        /// <summary>
        /// GTLITM.
        /// </summary>
        public const string GTLITM = "GTLITM";

        /// <summary>
        /// GTAITM.
        /// </summary>
        public const string GTAITM = "GTAITM";

        /// <summary>
        /// GTMOCALLNUM.
        /// </summary>
        public const string GTMOCALLNUM = "GTMOCALLNUM";

        /// <summary>
        /// GTMOOPPNUM.
        /// </summary>
        public const string GTMOOPPNUM = "GTMOOPPNUM";

        /// <summary>
        /// GTMOCAMPNUM.
        /// </summary>
        public const string GTMOCAMPNUM = "GTMOCAMPNUM";

        /// <summary>
        /// GTMOCOMPET.
        /// </summary>
        public const string GTMOCOMPET = "GTMOCOMPET";

        /// <summary>
        /// GTVEHN.
        /// </summary>
        public const string GTVEHN = "GTVEHN";

        /// <summary>
        /// GTAID.
        /// </summary>
        public const string GTAID = "GTAID";

        /// <summary>
        /// GTNUMB.
        /// </summary>
        public const string GTNUMB = "GTNUMB";

        /// <summary>
        /// GTDRAW.
        /// </summary>
        public const string GTDRAW = "GTDRAW";

        /// <summary>
        /// GTMOCATCD1.
        /// </summary>
        public const string GTMOCATCD1 = "GTMOCATCD1";

        /// <summary>
        /// GTMOCATCD2.
        /// </summary>
        public const string GTMOCATCD2 = "GTMOCATCD2";

        /// <summary>
        /// GTMOCATCD3.
        /// </summary>
        public const string GTMOCATCD3 = "GTMOCATCD3";

        /// <summary>
        /// GTMOCATCD4.
        /// </summary>
        public const string GTMOCATCD4 = "GTMOCATCD4";

        /// <summary>
        /// GTMOCATCD5.
        /// </summary>
        public const string GTMOCATCD5 = "GTMOCATCD5";

        /// <summary>
        /// GTMOCATCD6.
        /// </summary>
        public const string GTMOCATCD6 = "GTMOCATCD6";

        /// <summary>
        /// GTMOCATCD7.
        /// </summary>
        public const string GTMOCATCD7 = "GTMOCATCD7";

        /// <summary>
        /// GTMOCATCD8.
        /// </summary>
        public const string GTMOCATCD8 = "GTMOCATCD8";

        /// <summary>
        /// GTMOCATCD9.
        /// </summary>
        public const string GTMOCATCD9 = "GTMOCATCD9";

        /// <summary>
        /// GTMOCATCD10.
        /// </summary>
        public const string GTMOCATCD10 = "GTMOCATCD10";

        /// <summary>
        /// GTMOCATCD11.
        /// </summary>
        public const string GTMOCATCD11 = "GTMOCATCD11";

        /// <summary>
        /// GTMOCATCD12.
        /// </summary>
        public const string GTMOCATCD12 = "GTMOCATCD12";

        /// <summary>
        /// GTMOCATCD13.
        /// </summary>
        public const string GTMOCATCD13 = "GTMOCATCD13";

        /// <summary>
        /// GTMOCATCD14.
        /// </summary>
        public const string GTMOCATCD14 = "GTMOCATCD14";

        /// <summary>
        /// GTMOCATCD15.
        /// </summary>
        public const string GTMOCATCD15 = "GTMOCATCD15";

        /// <summary>
        /// GTMOCATCD16.
        /// </summary>
        public const string GTMOCATCD16 = "GTMOCATCD16";

        /// <summary>
        /// GTMOCATCD17.
        /// </summary>
        public const string GTMOCATCD17 = "GTMOCATCD17";

        /// <summary>
        /// GTMOCATCD18.
        /// </summary>
        public const string GTMOCATCD18 = "GTMOCATCD18";

        /// <summary>
        /// GTMOCATCD19.
        /// </summary>
        public const string GTMOCATCD19 = "GTMOCATCD19";

        /// <summary>
        /// GTMOCATCD20.
        /// </summary>
        public const string GTMOCATCD20 = "GTMOCATCD20";

        /// <summary>
        /// GTMOCATCD21.
        /// </summary>
        public const string GTMOCATCD21 = "GTMOCATCD21";

        /// <summary>
        /// GTMOCATCD22.
        /// </summary>
        public const string GTMOCATCD22 = "GTMOCATCD22";

        /// <summary>
        /// GTMOCATCD23.
        /// </summary>
        public const string GTMOCATCD23 = "GTMOCATCD23";

        /// <summary>
        /// GTMOCATCD24.
        /// </summary>
        public const string GTMOCATCD24 = "GTMOCATCD24";

        /// <summary>
        /// GTMOCATCD25.
        /// </summary>
        public const string GTMOCATCD25 = "GTMOCATCD25";

        /// <summary>
        /// GTMOCATCD26.
        /// </summary>
        public const string GTMOCATCD26 = "GTMOCATCD26";

        /// <summary>
        /// GTMOCATCD27.
        /// </summary>
        public const string GTMOCATCD27 = "GTMOCATCD27";

        /// <summary>
        /// GTMOCATCD28.
        /// </summary>
        public const string GTMOCATCD28 = "GTMOCATCD28";

        /// <summary>
        /// GTMOCATCD29.
        /// </summary>
        public const string GTMOCATCD29 = "GTMOCATCD29";

        /// <summary>
        /// GTMOCATCD30.
        /// </summary>
        public const string GTMOCATCD30 = "GTMOCATCD30";

        /// <summary>
        /// GTMODATE1.
        /// </summary>
        public const string GTMODATE1 = "GTMODATE1";

        /// <summary>
        /// GTMODATE2.
        /// </summary>
        public const string GTMODATE2 = "GTMODATE2";

        /// <summary>
        /// GTMODATE3.
        /// </summary>
        public const string GTMODATE3 = "GTMODATE3";

        /// <summary>
        /// GTMODATE4.
        /// </summary>
        public const string GTMODATE4 = "GTMODATE4";

        /// <summary>
        /// GTMODATE5.
        /// </summary>
        public const string GTMODATE5 = "GTMODATE5";

        /// <summary>
        /// GTMOMATH01.
        /// </summary>
        public const string GTMOMATH01 = "GTMOMATH01";

        /// <summary>
        /// GTMOMATH02.
        /// </summary>
        public const string GTMOMATH02 = "GTMOMATH02";

        /// <summary>
        /// GTMOMATH03.
        /// </summary>
        public const string GTMOMATH03 = "GTMOMATH03";

        /// <summary>
        /// GTMOMATH04.
        /// </summary>
        public const string GTMOMATH04 = "GTMOMATH04";

        /// <summary>
        /// GTMOMATH05.
        /// </summary>
        public const string GTMOMATH05 = "GTMOMATH05";

        /// <summary>
        /// GTMOFALPH1.
        /// </summary>
        public const string GTMOFALPH1 = "GTMOFALPH1";

        /// <summary>
        /// GTMOFALPH2.
        /// </summary>
        public const string GTMOFALPH2 = "GTMOFALPH2";

        /// <summary>
        /// GTMOFALPH3.
        /// </summary>
        public const string GTMOFALPH3 = "GTMOFALPH3";

        /// <summary>
        /// GTMOFALPH4.
        /// </summary>
        public const string GTMOFALPH4 = "GTMOFALPH4";

        /// <summary>
        /// GTMOFALPH5.
        /// </summary>
        public const string GTMOFALPH5 = "GTMOFALPH5";

        /// <summary>
        /// GTPID.
        /// </summary>
        public const string GTPID = "GTPID";

        /// <summary>
        /// GTJOBN.
        /// </summary>
        public const string GTJOBN = "GTJOBN";

        /// <summary>
        /// GTUSER.
        /// </summary>
        public const string GTUSER = "GTUSER";

        /// <summary>
        /// GTUPMJ.
        /// </summary>
        public const string GTUPMJ = "GTUPMJ";

        /// <summary>
        /// GTUPMT.
        /// </summary>
        public const string GTUPMT = "GTUPMT";

        /// <summary>
        /// GTSERK.
        /// </summary>
        public const string GTSERK = "GTSERK";

        /// <summary>
        /// GTMOFMN1.
        /// </summary>
        public const string GTMOFMN1 = "GTMOFMN1";

        /// <summary>
        /// GTMOFMN2.
        /// </summary>
        public const string GTMOFMN2 = "GTMOFMN2";

        /// <summary>
        /// GTMOFMN3.
        /// </summary>
        public const string GTMOFMN3 = "GTMOFMN3";

        /// <summary>
        /// GTMOFMN4.
        /// </summary>
        public const string GTMOFMN4 = "GTMOFMN4";

        /// <summary>
        /// GTMOACTVID.
        /// </summary>
        public const string GTMOACTVID = "GTMOACTVID";

        /// <summary>
        /// GTMOFSTR1.
        /// </summary>
        public const string GTMOFSTR1 = "GTMOFSTR1";

        /// <summary>
        /// GTMOFSTR2.
        /// </summary>
        public const string GTMOFSTR2 = "GTMOFSTR2";

        /// <summary>
        /// GTMOFSTR3.
        /// </summary>
        public const string GTMOFSTR3 = "GTMOFSTR3";

        /// <summary>
        /// GTMOFSTR4.
        /// </summary>
        public const string GTMOFSTR4 = "GTMOFSTR4";
    }

    /// <inheritdoc />
    public override string TableName => "F00166";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GTOBNM", "GTOBNM", JdeDataType.String, 20, true, true),
        new JdeField("GTTXKY", "GTTXKY", JdeDataType.String, 508, true, true),
        new JdeField("GTMOSEQN", "GTMOSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("GTMODOCTP", "GTMODOCTP", JdeDataType.String, 12),
        new JdeField("GTMODL01", "GTMODL01", JdeDataType.String, 60),
        new JdeField("GTMOAUTHOR", "GTMOAUTHOR", JdeDataType.String, 80),
        new JdeField("GTCDT", "GTCDT", JdeDataType.Numeric),
        new JdeField("GTMOSTATUS", "GTMOSTATUS", JdeDataType.String, 12),
        new JdeField("GTMOEFDTFR", "GTMOEFDTFR", JdeDataType.Numeric),
        new JdeField("GTMOEFDTTO", "GTMOEFDTTO", JdeDataType.Numeric),
        new JdeField("GTMOREVDT", "GTMOREVDT", JdeDataType.Numeric),
        new JdeField("GTMOCPYLINK", "GTMOCPYLINK", JdeDataType.String, 2),
        new JdeField("GTMOLNGP", "GTMOLNGP", JdeDataType.String, 4),
        new JdeField("GTMCU", "GTMCU", JdeDataType.String, 24),
        new JdeField("GTCO", "GTCO", JdeDataType.String, 10),
        new JdeField("GTAN8", "GTAN8", JdeDataType.Numeric),
        new JdeField("GTSHAN", "GTSHAN", JdeDataType.Numeric),
        new JdeField("GTAN8V", "GTAN8V", JdeDataType.Numeric),
        new JdeField("GTMOEMPL", "GTMOEMPL", JdeDataType.Numeric),
        new JdeField("GTDOCO", "GTDOCO", JdeDataType.Numeric),
        new JdeField("GTDCTO", "GTDCTO", JdeDataType.String, 4),
        new JdeField("GTITM", "GTITM", JdeDataType.Numeric),
        new JdeField("GTLITM", "GTLITM", JdeDataType.String, 50),
        new JdeField("GTAITM", "GTAITM", JdeDataType.String, 50),
        new JdeField("GTMOCALLNUM", "GTMOCALLNUM", JdeDataType.Numeric),
        new JdeField("GTMOOPPNUM", "GTMOOPPNUM", JdeDataType.Numeric),
        new JdeField("GTMOCAMPNUM", "GTMOCAMPNUM", JdeDataType.Numeric),
        new JdeField("GTMOCOMPET", "GTMOCOMPET", JdeDataType.Numeric),
        new JdeField("GTVEHN", "GTVEHN", JdeDataType.Numeric),
        new JdeField("GTAID", "GTAID", JdeDataType.String, 16),
        new JdeField("GTNUMB", "GTNUMB", JdeDataType.Numeric),
        new JdeField("GTDRAW", "GTDRAW", JdeDataType.String, 40),
        new JdeField("GTMOCATCD1", "GTMOCATCD1", JdeDataType.String, 20),
        new JdeField("GTMOCATCD2", "GTMOCATCD2", JdeDataType.String, 20),
        new JdeField("GTMOCATCD3", "GTMOCATCD3", JdeDataType.String, 20),
        new JdeField("GTMOCATCD4", "GTMOCATCD4", JdeDataType.String, 20),
        new JdeField("GTMOCATCD5", "GTMOCATCD5", JdeDataType.String, 20),
        new JdeField("GTMOCATCD6", "GTMOCATCD6", JdeDataType.String, 20),
        new JdeField("GTMOCATCD7", "GTMOCATCD7", JdeDataType.String, 20),
        new JdeField("GTMOCATCD8", "GTMOCATCD8", JdeDataType.String, 20),
        new JdeField("GTMOCATCD9", "GTMOCATCD9", JdeDataType.String, 20),
        new JdeField("GTMOCATCD10", "GTMOCATCD10", JdeDataType.String, 20),
        new JdeField("GTMOCATCD11", "GTMOCATCD11", JdeDataType.String, 20),
        new JdeField("GTMOCATCD12", "GTMOCATCD12", JdeDataType.String, 20),
        new JdeField("GTMOCATCD13", "GTMOCATCD13", JdeDataType.String, 20),
        new JdeField("GTMOCATCD14", "GTMOCATCD14", JdeDataType.String, 20),
        new JdeField("GTMOCATCD15", "GTMOCATCD15", JdeDataType.String, 20),
        new JdeField("GTMOCATCD16", "GTMOCATCD16", JdeDataType.String, 20),
        new JdeField("GTMOCATCD17", "GTMOCATCD17", JdeDataType.String, 20),
        new JdeField("GTMOCATCD18", "GTMOCATCD18", JdeDataType.String, 20),
        new JdeField("GTMOCATCD19", "GTMOCATCD19", JdeDataType.String, 20),
        new JdeField("GTMOCATCD20", "GTMOCATCD20", JdeDataType.String, 20),
        new JdeField("GTMOCATCD21", "GTMOCATCD21", JdeDataType.String, 20),
        new JdeField("GTMOCATCD22", "GTMOCATCD22", JdeDataType.String, 20),
        new JdeField("GTMOCATCD23", "GTMOCATCD23", JdeDataType.String, 20),
        new JdeField("GTMOCATCD24", "GTMOCATCD24", JdeDataType.String, 20),
        new JdeField("GTMOCATCD25", "GTMOCATCD25", JdeDataType.String, 20),
        new JdeField("GTMOCATCD26", "GTMOCATCD26", JdeDataType.String, 20),
        new JdeField("GTMOCATCD27", "GTMOCATCD27", JdeDataType.String, 20),
        new JdeField("GTMOCATCD28", "GTMOCATCD28", JdeDataType.String, 20),
        new JdeField("GTMOCATCD29", "GTMOCATCD29", JdeDataType.String, 20),
        new JdeField("GTMOCATCD30", "GTMOCATCD30", JdeDataType.String, 20),
        new JdeField("GTMODATE1", "GTMODATE1", JdeDataType.Numeric),
        new JdeField("GTMODATE2", "GTMODATE2", JdeDataType.Numeric),
        new JdeField("GTMODATE3", "GTMODATE3", JdeDataType.Numeric),
        new JdeField("GTMODATE4", "GTMODATE4", JdeDataType.Numeric),
        new JdeField("GTMODATE5", "GTMODATE5", JdeDataType.Numeric),
        new JdeField("GTMOMATH01", "GTMOMATH01", JdeDataType.Numeric),
        new JdeField("GTMOMATH02", "GTMOMATH02", JdeDataType.Numeric),
        new JdeField("GTMOMATH03", "GTMOMATH03", JdeDataType.Numeric),
        new JdeField("GTMOMATH04", "GTMOMATH04", JdeDataType.Numeric),
        new JdeField("GTMOMATH05", "GTMOMATH05", JdeDataType.Numeric),
        new JdeField("GTMOFALPH1", "GTMOFALPH1", JdeDataType.String, 20),
        new JdeField("GTMOFALPH2", "GTMOFALPH2", JdeDataType.String, 20),
        new JdeField("GTMOFALPH3", "GTMOFALPH3", JdeDataType.String, 20),
        new JdeField("GTMOFALPH4", "GTMOFALPH4", JdeDataType.String, 60),
        new JdeField("GTMOFALPH5", "GTMOFALPH5", JdeDataType.String, 60),
        new JdeField("GTPID", "GTPID", JdeDataType.String, 20),
        new JdeField("GTJOBN", "GTJOBN", JdeDataType.String, 20),
        new JdeField("GTUSER", "GTUSER", JdeDataType.String, 20),
        new JdeField("GTUPMJ", "GTUPMJ", JdeDataType.Numeric),
        new JdeField("GTUPMT", "GTUPMT", JdeDataType.Numeric),
        new JdeField("GTSERK", "GTSERK", JdeDataType.Numeric),
        new JdeField("GTMOFMN1", "GTMOFMN1", JdeDataType.Numeric),
        new JdeField("GTMOFMN2", "GTMOFMN2", JdeDataType.Numeric),
        new JdeField("GTMOFMN3", "GTMOFMN3", JdeDataType.Numeric),
        new JdeField("GTMOFMN4", "GTMOFMN4", JdeDataType.Numeric),
        new JdeField("GTMOACTVID", "GTMOACTVID", JdeDataType.String, 74),
        new JdeField("GTMOFSTR1", "GTMOFSTR1", JdeDataType.String, 74),
        new JdeField("GTMOFSTR2", "GTMOFSTR2", JdeDataType.String, 74),
        new JdeField("GTMOFSTR3", "GTMOFSTR3", JdeDataType.String, 74),
        new JdeField("GTMOFSTR4", "GTMOFSTR4", JdeDataType.String, 74)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00166_0", "Primary Key on GTOBNM, GTTXKY, GTMOSEQN", new[] { "GTOBNM", "GTTXKY", "GTMOSEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
