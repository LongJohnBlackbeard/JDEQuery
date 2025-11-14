using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09E150 - .
/// </summary>
public class F09E150 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CICCTN.
        /// </summary>
        public const string CICCTN = "CICCTN";

        /// <summary>
        /// CIEMPLOYID.
        /// </summary>
        public const string CIEMPLOYID = "CIEMPLOYID";

        /// <summary>
        /// CICRCRDNUM.
        /// </summary>
        public const string CICRCRDNUM = "CICRCRDNUM";

        /// <summary>
        /// CIPMTMETH.
        /// </summary>
        public const string CIPMTMETH = "CIPMTMETH";

        /// <summary>
        /// CICTLID.
        /// </summary>
        public const string CICTLID = "CICTLID";

        /// <summary>
        /// CITRANSTAT.
        /// </summary>
        public const string CITRANSTAT = "CITRANSTAT";

        /// <summary>
        /// CICHRGTO.
        /// </summary>
        public const string CICHRGTO = "CICHRGTO";

        /// <summary>
        /// CIMCU.
        /// </summary>
        public const string CIMCU = "CIMCU";

        /// <summary>
        /// CISBL.
        /// </summary>
        public const string CISBL = "CISBL";

        /// <summary>
        /// CISBLT.
        /// </summary>
        public const string CISBLT = "CISBLT";

        /// <summary>
        /// CIEXPTYPE.
        /// </summary>
        public const string CIEXPTYPE = "CIEXPTYPE";

        /// <summary>
        /// CIEXPDATE.
        /// </summary>
        public const string CIEXPDATE = "CIEXPDATE";

        /// <summary>
        /// CIEXPAMT.
        /// </summary>
        public const string CIEXPAMT = "CIEXPAMT";

        /// <summary>
        /// CIBILLAMT.
        /// </summary>
        public const string CIBILLAMT = "CIBILLAMT";

        /// <summary>
        /// CIEXPCRCD.
        /// </summary>
        public const string CIEXPCRCD = "CIEXPCRCD";

        /// <summary>
        /// CIBILLCRCD.
        /// </summary>
        public const string CIBILLCRCD = "CIBILLCRCD";

        /// <summary>
        /// CICRR.
        /// </summary>
        public const string CICRR = "CICRR";

        /// <summary>
        /// CIBUSPURP.
        /// </summary>
        public const string CIBUSPURP = "CIBUSPURP";

        /// <summary>
        /// CIDESCCHG.
        /// </summary>
        public const string CIDESCCHG = "CIDESCCHG";

        /// <summary>
        /// CIREASON.
        /// </summary>
        public const string CIREASON = "CIREASON";

        /// <summary>
        /// CIVENDCODE.
        /// </summary>
        public const string CIVENDCODE = "CIVENDCODE";

        /// <summary>
        /// CIVENDNAME.
        /// </summary>
        public const string CIVENDNAME = "CIVENDNAME";

        /// <summary>
        /// CIVSTREET.
        /// </summary>
        public const string CIVSTREET = "CIVSTREET";

        /// <summary>
        /// CIVCITY.
        /// </summary>
        public const string CIVCITY = "CIVCITY";

        /// <summary>
        /// CIVSTATE.
        /// </summary>
        public const string CIVSTATE = "CIVSTATE";

        /// <summary>
        /// CIVZIPCODE.
        /// </summary>
        public const string CIVZIPCODE = "CIVZIPCODE";

        /// <summary>
        /// CIVCOUNTRY.
        /// </summary>
        public const string CIVCOUNTRY = "CIVCOUNTRY";

        /// <summary>
        /// CILOCATN.
        /// </summary>
        public const string CILOCATN = "CILOCATN";

        /// <summary>
        /// CIREFNUMB.
        /// </summary>
        public const string CIREFNUMB = "CIREFNUMB";

        /// <summary>
        /// CIREFDATE1.
        /// </summary>
        public const string CIREFDATE1 = "CIREFDATE1";

        /// <summary>
        /// CITICKNUMB.
        /// </summary>
        public const string CITICKNUMB = "CITICKNUMB";

        /// <summary>
        /// CICLASSERV.
        /// </summary>
        public const string CICLASSERV = "CICLASSERV";

        /// <summary>
        /// CIDESTIN1.
        /// </summary>
        public const string CIDESTIN1 = "CIDESTIN1";

        /// <summary>
        /// CIDESTIN2.
        /// </summary>
        public const string CIDESTIN2 = "CIDESTIN2";

        /// <summary>
        /// CIDESTIN3.
        /// </summary>
        public const string CIDESTIN3 = "CIDESTIN3";

        /// <summary>
        /// CIFMDATE.
        /// </summary>
        public const string CIFMDATE = "CIFMDATE";

        /// <summary>
        /// CITODATE.
        /// </summary>
        public const string CITODATE = "CITODATE";

        /// <summary>
        /// CINUMBDAYS.
        /// </summary>
        public const string CINUMBDAYS = "CINUMBDAYS";

        /// <summary>
        /// CITELNUMB.
        /// </summary>
        public const string CITELNUMB = "CITELNUMB";

        /// <summary>
        /// CITAXAMT.
        /// </summary>
        public const string CITAXAMT = "CITAXAMT";

        /// <summary>
        /// CITAXTYPE.
        /// </summary>
        public const string CITAXTYPE = "CITAXTYPE";

        /// <summary>
        /// CIUNITS.
        /// </summary>
        public const string CIUNITS = "CIUNITS";

        /// <summary>
        /// CIRATE1.
        /// </summary>
        public const string CIRATE1 = "CIRATE1";

        /// <summary>
        /// CIORIGNUMB.
        /// </summary>
        public const string CIORIGNUMB = "CIORIGNUMB";

        /// <summary>
        /// CIADDLCMT.
        /// </summary>
        public const string CIADDLCMT = "CIADDLCMT";

        /// <summary>
        /// CIDESC01.
        /// </summary>
        public const string CIDESC01 = "CIDESC01";

        /// <summary>
        /// CIDESC02.
        /// </summary>
        public const string CIDESC02 = "CIDESC02";

        /// <summary>
        /// CIDESC03.
        /// </summary>
        public const string CIDESC03 = "CIDESC03";

        /// <summary>
        /// CIDESC04.
        /// </summary>
        public const string CIDESC04 = "CIDESC04";

        /// <summary>
        /// CINUMERIC1.
        /// </summary>
        public const string CINUMERIC1 = "CINUMERIC1";

        /// <summary>
        /// CINUMERIC2.
        /// </summary>
        public const string CINUMERIC2 = "CINUMERIC2";

        /// <summary>
        /// CINUMERIC3.
        /// </summary>
        public const string CINUMERIC3 = "CINUMERIC3";

        /// <summary>
        /// CITEXT1.
        /// </summary>
        public const string CITEXT1 = "CITEXT1";

        /// <summary>
        /// CITEXT2.
        /// </summary>
        public const string CITEXT2 = "CITEXT2";

        /// <summary>
        /// CITEXT3.
        /// </summary>
        public const string CITEXT3 = "CITEXT3";

        /// <summary>
        /// CIDATE1.
        /// </summary>
        public const string CIDATE1 = "CIDATE1";

        /// <summary>
        /// CIDATE2.
        /// </summary>
        public const string CIDATE2 = "CIDATE2";

        /// <summary>
        /// CIDATE3.
        /// </summary>
        public const string CIDATE3 = "CIDATE3";

        /// <summary>
        /// CIEXRPTTYP.
        /// </summary>
        public const string CIEXRPTTYP = "CIEXRPTTYP";

        /// <summary>
        /// CIEXRPTNUM.
        /// </summary>
        public const string CIEXRPTNUM = "CIEXRPTNUM";

        /// <summary>
        /// CIDTECRT.
        /// </summary>
        public const string CIDTECRT = "CIDTECRT";

        /// <summary>
        /// CICCRPTYPE.
        /// </summary>
        public const string CICCRPTYPE = "CICCRPTYPE";

        /// <summary>
        /// CICCRPTNUM.
        /// </summary>
        public const string CICCRPTNUM = "CICCRPTNUM";

        /// <summary>
        /// CICCRPTDTE.
        /// </summary>
        public const string CICCRPTDTE = "CICCRPTDTE";

        /// <summary>
        /// CICCFILENO.
        /// </summary>
        public const string CICCFILENO = "CICCFILENO";

        /// <summary>
        /// CICCRECIPN.
        /// </summary>
        public const string CICCRECIPN = "CICCRECIPN";

        /// <summary>
        /// CIGFLAG1.
        /// </summary>
        public const string CIGFLAG1 = "CIGFLAG1";

        /// <summary>
        /// CIGFLAG2.
        /// </summary>
        public const string CIGFLAG2 = "CIGFLAG2";

        /// <summary>
        /// CIGAMOUNT1.
        /// </summary>
        public const string CIGAMOUNT1 = "CIGAMOUNT1";

        /// <summary>
        /// CIGAMOUNT2.
        /// </summary>
        public const string CIGAMOUNT2 = "CIGAMOUNT2";

        /// <summary>
        /// CIGNUMBER1.
        /// </summary>
        public const string CIGNUMBER1 = "CIGNUMBER1";

        /// <summary>
        /// CIGNUMBER2.
        /// </summary>
        public const string CIGNUMBER2 = "CIGNUMBER2";

        /// <summary>
        /// CIGTEXT001.
        /// </summary>
        public const string CIGTEXT001 = "CIGTEXT001";

        /// <summary>
        /// CIGTEXT002.
        /// </summary>
        public const string CIGTEXT002 = "CIGTEXT002";

        /// <summary>
        /// CIGDATE1.
        /// </summary>
        public const string CIGDATE1 = "CIGDATE1";

        /// <summary>
        /// CIGDATE2.
        /// </summary>
        public const string CIGDATE2 = "CIGDATE2";

        /// <summary>
        /// CIGCODE1.
        /// </summary>
        public const string CIGCODE1 = "CIGCODE1";

        /// <summary>
        /// CIGCODE2.
        /// </summary>
        public const string CIGCODE2 = "CIGCODE2";

        /// <summary>
        /// CIEFLAG1.
        /// </summary>
        public const string CIEFLAG1 = "CIEFLAG1";

        /// <summary>
        /// CIEFLAG2.
        /// </summary>
        public const string CIEFLAG2 = "CIEFLAG2";

        /// <summary>
        /// CIEAMOUNT1.
        /// </summary>
        public const string CIEAMOUNT1 = "CIEAMOUNT1";

        /// <summary>
        /// CIEAMOUNT2.
        /// </summary>
        public const string CIEAMOUNT2 = "CIEAMOUNT2";

        /// <summary>
        /// CIENUMBER1.
        /// </summary>
        public const string CIENUMBER1 = "CIENUMBER1";

        /// <summary>
        /// CIENUMBER2.
        /// </summary>
        public const string CIENUMBER2 = "CIENUMBER2";

        /// <summary>
        /// CIETEXT001.
        /// </summary>
        public const string CIETEXT001 = "CIETEXT001";

        /// <summary>
        /// CIETEXT002.
        /// </summary>
        public const string CIETEXT002 = "CIETEXT002";

        /// <summary>
        /// CIEDATE1.
        /// </summary>
        public const string CIEDATE1 = "CIEDATE1";

        /// <summary>
        /// CIEDATE2.
        /// </summary>
        public const string CIEDATE2 = "CIEDATE2";

        /// <summary>
        /// CIECODE1.
        /// </summary>
        public const string CIECODE1 = "CIECODE1";

        /// <summary>
        /// CIECODE2.
        /// </summary>
        public const string CIECODE2 = "CIECODE2";

        /// <summary>
        /// CIPID.
        /// </summary>
        public const string CIPID = "CIPID";

        /// <summary>
        /// CIUSER.
        /// </summary>
        public const string CIUSER = "CIUSER";

        /// <summary>
        /// CIJOBN.
        /// </summary>
        public const string CIJOBN = "CIJOBN";

        /// <summary>
        /// CIUPMT.
        /// </summary>
        public const string CIUPMT = "CIUPMT";

        /// <summary>
        /// CIUPMJ.
        /// </summary>
        public const string CIUPMJ = "CIUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F09E150";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CICCTN", "CICCTN", JdeDataType.String, 40, true, true),
        new JdeField("CIEMPLOYID", "CIEMPLOYID", JdeDataType.Numeric),
        new JdeField("CICRCRDNUM", "CICRCRDNUM", JdeDataType.String, 50),
        new JdeField("CIPMTMETH", "CIPMTMETH", JdeDataType.String, 6),
        new JdeField("CICTLID", "CICTLID", JdeDataType.String, 60),
        new JdeField("CITRANSTAT", "CITRANSTAT", JdeDataType.String, 4),
        new JdeField("CICHRGTO", "CICHRGTO", JdeDataType.String, 60),
        new JdeField("CIMCU", "CIMCU", JdeDataType.String, 24),
        new JdeField("CISBL", "CISBL", JdeDataType.String, 16),
        new JdeField("CISBLT", "CISBLT", JdeDataType.String, 2),
        new JdeField("CIEXPTYPE", "CIEXPTYPE", JdeDataType.String, 8),
        new JdeField("CIEXPDATE", "CIEXPDATE", JdeDataType.Numeric),
        new JdeField("CIEXPAMT", "CIEXPAMT", JdeDataType.Numeric),
        new JdeField("CIBILLAMT", "CIBILLAMT", JdeDataType.Numeric),
        new JdeField("CIEXPCRCD", "CIEXPCRCD", JdeDataType.String, 6),
        new JdeField("CIBILLCRCD", "CIBILLCRCD", JdeDataType.String, 6),
        new JdeField("CICRR", "CICRR", JdeDataType.Numeric),
        new JdeField("CIBUSPURP", "CIBUSPURP", JdeDataType.String, 80),
        new JdeField("CIDESCCHG", "CIDESCCHG", JdeDataType.String, 90),
        new JdeField("CIREASON", "CIREASON", JdeDataType.String, 20),
        new JdeField("CIVENDCODE", "CIVENDCODE", JdeDataType.String, 16),
        new JdeField("CIVENDNAME", "CIVENDNAME", JdeDataType.String, 70),
        new JdeField("CIVSTREET", "CIVSTREET", JdeDataType.String, 80),
        new JdeField("CIVCITY", "CIVCITY", JdeDataType.String, 60),
        new JdeField("CIVSTATE", "CIVSTATE", JdeDataType.String, 40),
        new JdeField("CIVZIPCODE", "CIVZIPCODE", JdeDataType.String, 24),
        new JdeField("CIVCOUNTRY", "CIVCOUNTRY", JdeDataType.String, 60),
        new JdeField("CILOCATN", "CILOCATN", JdeDataType.String, 20),
        new JdeField("CIREFNUMB", "CIREFNUMB", JdeDataType.String, 40),
        new JdeField("CIREFDATE1", "CIREFDATE1", JdeDataType.Numeric),
        new JdeField("CITICKNUMB", "CITICKNUMB", JdeDataType.String, 30),
        new JdeField("CICLASSERV", "CICLASSERV", JdeDataType.String, 30),
        new JdeField("CIDESTIN1", "CIDESTIN1", JdeDataType.String, 40),
        new JdeField("CIDESTIN2", "CIDESTIN2", JdeDataType.String, 40),
        new JdeField("CIDESTIN3", "CIDESTIN3", JdeDataType.String, 40),
        new JdeField("CIFMDATE", "CIFMDATE", JdeDataType.Numeric),
        new JdeField("CITODATE", "CITODATE", JdeDataType.Numeric),
        new JdeField("CINUMBDAYS", "CINUMBDAYS", JdeDataType.Numeric),
        new JdeField("CITELNUMB", "CITELNUMB", JdeDataType.String, 40),
        new JdeField("CITAXAMT", "CITAXAMT", JdeDataType.Numeric),
        new JdeField("CITAXTYPE", "CITAXTYPE", JdeDataType.String, 30),
        new JdeField("CIUNITS", "CIUNITS", JdeDataType.Numeric),
        new JdeField("CIRATE1", "CIRATE1", JdeDataType.Numeric),
        new JdeField("CIORIGNUMB", "CIORIGNUMB", JdeDataType.String, 40),
        new JdeField("CIADDLCMT", "CIADDLCMT", JdeDataType.String, 120),
        new JdeField("CIDESC01", "CIDESC01", JdeDataType.String, 90),
        new JdeField("CIDESC02", "CIDESC02", JdeDataType.String, 90),
        new JdeField("CIDESC03", "CIDESC03", JdeDataType.String, 90),
        new JdeField("CIDESC04", "CIDESC04", JdeDataType.String, 90),
        new JdeField("CINUMERIC1", "CINUMERIC1", JdeDataType.Numeric),
        new JdeField("CINUMERIC2", "CINUMERIC2", JdeDataType.Numeric),
        new JdeField("CINUMERIC3", "CINUMERIC3", JdeDataType.Numeric),
        new JdeField("CITEXT1", "CITEXT1", JdeDataType.String, 80),
        new JdeField("CITEXT2", "CITEXT2", JdeDataType.String, 80),
        new JdeField("CITEXT3", "CITEXT3", JdeDataType.String, 80),
        new JdeField("CIDATE1", "CIDATE1", JdeDataType.Numeric),
        new JdeField("CIDATE2", "CIDATE2", JdeDataType.Numeric),
        new JdeField("CIDATE3", "CIDATE3", JdeDataType.Numeric),
        new JdeField("CIEXRPTTYP", "CIEXRPTTYP", JdeDataType.String, 2),
        new JdeField("CIEXRPTNUM", "CIEXRPTNUM", JdeDataType.String, 20),
        new JdeField("CIDTECRT", "CIDTECRT", JdeDataType.Numeric),
        new JdeField("CICCRPTYPE", "CICCRPTYPE", JdeDataType.String, 50),
        new JdeField("CICCRPTNUM", "CICCRPTNUM", JdeDataType.String, 50),
        new JdeField("CICCRPTDTE", "CICCRPTDTE", JdeDataType.Numeric),
        new JdeField("CICCFILENO", "CICCFILENO", JdeDataType.String, 30),
        new JdeField("CICCRECIPN", "CICCRECIPN", JdeDataType.String, 30),
        new JdeField("CIGFLAG1", "CIGFLAG1", JdeDataType.String, 2),
        new JdeField("CIGFLAG2", "CIGFLAG2", JdeDataType.String, 2),
        new JdeField("CIGAMOUNT1", "CIGAMOUNT1", JdeDataType.Numeric),
        new JdeField("CIGAMOUNT2", "CIGAMOUNT2", JdeDataType.Numeric),
        new JdeField("CIGNUMBER1", "CIGNUMBER1", JdeDataType.Numeric),
        new JdeField("CIGNUMBER2", "CIGNUMBER2", JdeDataType.Numeric),
        new JdeField("CIGTEXT001", "CIGTEXT001", JdeDataType.String, 80),
        new JdeField("CIGTEXT002", "CIGTEXT002", JdeDataType.String, 80),
        new JdeField("CIGDATE1", "CIGDATE1", JdeDataType.Numeric),
        new JdeField("CIGDATE2", "CIGDATE2", JdeDataType.Numeric),
        new JdeField("CIGCODE1", "CIGCODE1", JdeDataType.String, 10),
        new JdeField("CIGCODE2", "CIGCODE2", JdeDataType.String, 20),
        new JdeField("CIEFLAG1", "CIEFLAG1", JdeDataType.String, 2),
        new JdeField("CIEFLAG2", "CIEFLAG2", JdeDataType.String, 2),
        new JdeField("CIEAMOUNT1", "CIEAMOUNT1", JdeDataType.Numeric),
        new JdeField("CIEAMOUNT2", "CIEAMOUNT2", JdeDataType.Numeric),
        new JdeField("CIENUMBER1", "CIENUMBER1", JdeDataType.Numeric),
        new JdeField("CIENUMBER2", "CIENUMBER2", JdeDataType.Numeric),
        new JdeField("CIETEXT001", "CIETEXT001", JdeDataType.String, 80),
        new JdeField("CIETEXT002", "CIETEXT002", JdeDataType.String, 80),
        new JdeField("CIEDATE1", "CIEDATE1", JdeDataType.Numeric),
        new JdeField("CIEDATE2", "CIEDATE2", JdeDataType.Numeric),
        new JdeField("CIECODE1", "CIECODE1", JdeDataType.String, 10),
        new JdeField("CIECODE2", "CIECODE2", JdeDataType.String, 20),
        new JdeField("CIPID", "CIPID", JdeDataType.String, 20),
        new JdeField("CIUSER", "CIUSER", JdeDataType.String, 20),
        new JdeField("CIJOBN", "CIJOBN", JdeDataType.String, 20),
        new JdeField("CIUPMT", "CIUPMT", JdeDataType.Numeric),
        new JdeField("CIUPMJ", "CIUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09E150_0", "Primary Key on CICCTN", new[] { "CICCTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09E150_2", "Index on CIEXPDATE, CIPMTMETH, CIEMPLOYID, CICRCRDNUM, CITRANSTAT, CIEXPTYPE, CIBILLCRCD, CIEXPCRCD, CIVENDNAME", new[] { "CIEXPDATE", "CIPMTMETH", "CIEMPLOYID", "CICRCRDNUM", "CITRANSTAT", "CIEXPTYPE", "CIBILLCRCD", "CIEXPCRCD", "CIVENDNAME" }),
        new JdeIndex("F09E150_3", "Index on SYS_NC00096$, CIPMTMETH, CIEMPLOYID, CICRCRDNUM, CITRANSTAT, CIEXPTYPE, CIBILLCRCD, CIEXPCRCD, CIVENDNAME", new[] { "SYS_NC00096$", "CIPMTMETH", "CIEMPLOYID", "CICRCRDNUM", "CITRANSTAT", "CIEXPTYPE", "CIBILLCRCD", "CIEXPCRCD", "CIVENDNAME" }),
        new JdeIndex("F09E150_4", "Index on CIEMPLOYID, CIPMTMETH, CIEXPCRCD", new[] { "CIEMPLOYID", "CIPMTMETH", "CIEXPCRCD" }),
        new JdeIndex("F09E150_5", "Index on CIEMPLOYID, CICRCRDNUM", new[] { "CIEMPLOYID", "CICRCRDNUM" }),
        new JdeIndex("F09E150_6", "Index on CIDTECRT, CIEXRPTTYP, CIEXRPTNUM", new[] { "CIDTECRT", "CIEXRPTTYP", "CIEXRPTNUM" }),
        new JdeIndex("F09E150_7", "Index on CITRANSTAT, CIEXPDATE, CIEMPLOYID, CIPMTMETH, CICRCRDNUM, CIEXPTYPE, CICCTN, CIDTECRT, CIEXRPTTYP, CIEXRPTNUM", new[] { "CITRANSTAT", "CIEXPDATE", "CIEMPLOYID", "CIPMTMETH", "CICRCRDNUM", "CIEXPTYPE", "CICCTN", "CIDTECRT", "CIEXRPTTYP", "CIEXRPTNUM" })
    };
}
