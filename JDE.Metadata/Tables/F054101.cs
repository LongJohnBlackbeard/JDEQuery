using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F054101 - .
/// </summary>
public class F054101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHAN8.
        /// </summary>
        public const string EHAN8 = "EHAN8";

        /// <summary>
        /// EHPAN8.
        /// </summary>
        public const string EHPAN8 = "EHPAN8";

        /// <summary>
        /// EHMLNM.
        /// </summary>
        public const string EHMLNM = "EHMLNM";

        /// <summary>
        /// EHGNNM.
        /// </summary>
        public const string EHGNNM = "EHGNNM";

        /// <summary>
        /// EHMDNM.
        /// </summary>
        public const string EHMDNM = "EHMDNM";

        /// <summary>
        /// EHIMN.
        /// </summary>
        public const string EHIMN = "EHIMN";

        /// <summary>
        /// EHSRNM.
        /// </summary>
        public const string EHSRNM = "EHSRNM";

        /// <summary>
        /// EHPRNM.
        /// </summary>
        public const string EHPRNM = "EHPRNM";

        /// <summary>
        /// EHHMCU.
        /// </summary>
        public const string EHHMCU = "EHHMCU";

        /// <summary>
        /// EHJBCX.
        /// </summary>
        public const string EHJBCX = "EHJBCX";

        /// <summary>
        /// EHSPRVN.
        /// </summary>
        public const string EHSPRVN = "EHSPRVN";

        /// <summary>
        /// EHBSCDTL.
        /// </summary>
        public const string EHBSCDTL = "EHBSCDTL";

        /// <summary>
        /// EHTAX.
        /// </summary>
        public const string EHTAX = "EHTAX";

        /// <summary>
        /// EHADD1.
        /// </summary>
        public const string EHADD1 = "EHADD1";

        /// <summary>
        /// EHADD2.
        /// </summary>
        public const string EHADD2 = "EHADD2";

        /// <summary>
        /// EHADD3.
        /// </summary>
        public const string EHADD3 = "EHADD3";

        /// <summary>
        /// EHADD4.
        /// </summary>
        public const string EHADD4 = "EHADD4";

        /// <summary>
        /// EHCTY1.
        /// </summary>
        public const string EHCTY1 = "EHCTY1";

        /// <summary>
        /// EHADDS.
        /// </summary>
        public const string EHADDS = "EHADDS";

        /// <summary>
        /// EHADDZ.
        /// </summary>
        public const string EHADDZ = "EHADDZ";

        /// <summary>
        /// EHCTR.
        /// </summary>
        public const string EHCTR = "EHCTR";

        /// <summary>
        /// EHCO.
        /// </summary>
        public const string EHCO = "EHCO";

        /// <summary>
        /// EHCOUN.
        /// </summary>
        public const string EHCOUN = "EHCOUN";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHJOBN.
        /// </summary>
        public const string EHJOBN = "EHJOBN";

        /// <summary>
        /// EHUPMJ.
        /// </summary>
        public const string EHUPMJ = "EHUPMJ";

        /// <summary>
        /// EHUPMT.
        /// </summary>
        public const string EHUPMT = "EHUPMT";

        /// <summary>
        /// EHESIGN.
        /// </summary>
        public const string EHESIGN = "EHESIGN";

        /// <summary>
        /// EHMUMJ.
        /// </summary>
        public const string EHMUMJ = "EHMUMJ";

        /// <summary>
        /// EHMUMT.
        /// </summary>
        public const string EHMUMT = "EHMUMT";

        /// <summary>
        /// EHUPID.
        /// </summary>
        public const string EHUPID = "EHUPID";

        /// <summary>
        /// EHRELA.
        /// </summary>
        public const string EHRELA = "EHRELA";

        /// <summary>
        /// EHDOB.
        /// </summary>
        public const string EHDOB = "EHDOB";

        /// <summary>
        /// EHSEX.
        /// </summary>
        public const string EHSEX = "EHSEX";

        /// <summary>
        /// EHDEPTAX.
        /// </summary>
        public const string EHDEPTAX = "EHDEPTAX";

        /// <summary>
        /// EHHSG.
        /// </summary>
        public const string EHHSG = "EHHSG";

        /// <summary>
        /// EHEMP.
        /// </summary>
        public const string EHEMP = "EHEMP";

        /// <summary>
        /// EHFTS.
        /// </summary>
        public const string EHFTS = "EHFTS";

        /// <summary>
        /// EHSCA.
        /// </summary>
        public const string EHSCA = "EHSCA";

        /// <summary>
        /// EHDSBF.
        /// </summary>
        public const string EHDSBF = "EHDSBF";

        /// <summary>
        /// EHDSBD.
        /// </summary>
        public const string EHDSBD = "EHDSBD";

        /// <summary>
        /// EHMCDT.
        /// </summary>
        public const string EHMCDT = "EHMCDT";

        /// <summary>
        /// EHDTDH.
        /// </summary>
        public const string EHDTDH = "EHDTDH";

        /// <summary>
        /// EHEMAL.
        /// </summary>
        public const string EHEMAL = "EHEMAL";

        /// <summary>
        /// EHEV01.
        /// </summary>
        public const string EHEV01 = "EHEV01";

        /// <summary>
        /// EHEV02.
        /// </summary>
        public const string EHEV02 = "EHEV02";

        /// <summary>
        /// EHDL01.
        /// </summary>
        public const string EHDL01 = "EHDL01";

        /// <summary>
        /// EHDL02.
        /// </summary>
        public const string EHDL02 = "EHDL02";

        /// <summary>
        /// EHMATH01.
        /// </summary>
        public const string EHMATH01 = "EHMATH01";

        /// <summary>
        /// EHMATH02.
        /// </summary>
        public const string EHMATH02 = "EHMATH02";
    }

    /// <inheritdoc />
    public override string TableName => "F054101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHAN8", "EHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EHPAN8", "EHPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EHMLNM", "EHMLNM", JdeDataType.String, 80),
        new JdeField("EHGNNM", "EHGNNM", JdeDataType.String, 50),
        new JdeField("EHMDNM", "EHMDNM", JdeDataType.String, 50),
        new JdeField("EHIMN", "EHIMN", JdeDataType.String, 2),
        new JdeField("EHSRNM", "EHSRNM", JdeDataType.String, 50),
        new JdeField("EHPRNM", "EHPRNM", JdeDataType.String, 40),
        new JdeField("EHHMCU", "EHHMCU", JdeDataType.String, 24),
        new JdeField("EHJBCX", "EHJBCX", JdeDataType.String, 60),
        new JdeField("EHSPRVN", "EHSPRVN", JdeDataType.String, 60),
        new JdeField("EHBSCDTL", "EHBSCDTL", JdeDataType.String, 60),
        new JdeField("EHTAX", "EHTAX", JdeDataType.String, 40),
        new JdeField("EHADD1", "EHADD1", JdeDataType.String, 80),
        new JdeField("EHADD2", "EHADD2", JdeDataType.String, 80),
        new JdeField("EHADD3", "EHADD3", JdeDataType.String, 80),
        new JdeField("EHADD4", "EHADD4", JdeDataType.String, 80),
        new JdeField("EHCTY1", "EHCTY1", JdeDataType.String, 50),
        new JdeField("EHADDS", "EHADDS", JdeDataType.String, 6),
        new JdeField("EHADDZ", "EHADDZ", JdeDataType.String, 24),
        new JdeField("EHCTR", "EHCTR", JdeDataType.String, 6),
        new JdeField("EHCO", "EHCO", JdeDataType.String, 10),
        new JdeField("EHCOUN", "EHCOUN", JdeDataType.String, 50),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHJOBN", "EHJOBN", JdeDataType.String, 20),
        new JdeField("EHUPMJ", "EHUPMJ", JdeDataType.Numeric),
        new JdeField("EHUPMT", "EHUPMT", JdeDataType.Numeric),
        new JdeField("EHESIGN", "EHESIGN", JdeDataType.String, 32, true, true),
        new JdeField("EHMUMJ", "EHMUMJ", JdeDataType.Numeric),
        new JdeField("EHMUMT", "EHMUMT", JdeDataType.Numeric),
        new JdeField("EHUPID", "EHUPID", JdeDataType.String, 20),
        new JdeField("EHRELA", "EHRELA", JdeDataType.String, 2),
        new JdeField("EHDOB", "EHDOB", JdeDataType.Numeric),
        new JdeField("EHSEX", "EHSEX", JdeDataType.String, 2),
        new JdeField("EHDEPTAX", "EHDEPTAX", JdeDataType.String, 40),
        new JdeField("EHHSG", "EHHSG", JdeDataType.String, 2),
        new JdeField("EHEMP", "EHEMP", JdeDataType.String, 2),
        new JdeField("EHFTS", "EHFTS", JdeDataType.String, 2),
        new JdeField("EHSCA", "EHSCA", JdeDataType.String, 60),
        new JdeField("EHDSBF", "EHDSBF", JdeDataType.String, 2),
        new JdeField("EHDSBD", "EHDSBD", JdeDataType.Numeric),
        new JdeField("EHMCDT", "EHMCDT", JdeDataType.Numeric),
        new JdeField("EHDTDH", "EHDTDH", JdeDataType.Numeric),
        new JdeField("EHEMAL", "EHEMAL", JdeDataType.String, 512),
        new JdeField("EHEV01", "EHEV01", JdeDataType.String, 2),
        new JdeField("EHEV02", "EHEV02", JdeDataType.String, 2),
        new JdeField("EHDL01", "EHDL01", JdeDataType.String, 60),
        new JdeField("EHDL02", "EHDL02", JdeDataType.String, 60),
        new JdeField("EHMATH01", "EHMATH01", JdeDataType.Numeric),
        new JdeField("EHMATH02", "EHMATH02", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F054101_0", "Primary Key on EHAN8, EHPAN8, EHESIGN", new[] { "EHAN8", "EHPAN8", "EHESIGN" }, isUnique: true, isPrimaryKey: true)
    };
}
