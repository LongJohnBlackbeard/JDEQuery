using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F054101W - .
/// </summary>
public class F054101W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EPAN8.
        /// </summary>
        public const string EPAN8 = "EPAN8";

        /// <summary>
        /// EPPAN8.
        /// </summary>
        public const string EPPAN8 = "EPPAN8";

        /// <summary>
        /// EPMLNM.
        /// </summary>
        public const string EPMLNM = "EPMLNM";

        /// <summary>
        /// EPGNNM.
        /// </summary>
        public const string EPGNNM = "EPGNNM";

        /// <summary>
        /// EPMDNM.
        /// </summary>
        public const string EPMDNM = "EPMDNM";

        /// <summary>
        /// EPIMN.
        /// </summary>
        public const string EPIMN = "EPIMN";

        /// <summary>
        /// EPSRNM.
        /// </summary>
        public const string EPSRNM = "EPSRNM";

        /// <summary>
        /// EPPRNM.
        /// </summary>
        public const string EPPRNM = "EPPRNM";

        /// <summary>
        /// EPHMCU.
        /// </summary>
        public const string EPHMCU = "EPHMCU";

        /// <summary>
        /// EPJBCX.
        /// </summary>
        public const string EPJBCX = "EPJBCX";

        /// <summary>
        /// EPSPRVN.
        /// </summary>
        public const string EPSPRVN = "EPSPRVN";

        /// <summary>
        /// EPBSCDTL.
        /// </summary>
        public const string EPBSCDTL = "EPBSCDTL";

        /// <summary>
        /// EPTAX.
        /// </summary>
        public const string EPTAX = "EPTAX";

        /// <summary>
        /// EPADD1.
        /// </summary>
        public const string EPADD1 = "EPADD1";

        /// <summary>
        /// EPADD2.
        /// </summary>
        public const string EPADD2 = "EPADD2";

        /// <summary>
        /// EPADD3.
        /// </summary>
        public const string EPADD3 = "EPADD3";

        /// <summary>
        /// EPADD4.
        /// </summary>
        public const string EPADD4 = "EPADD4";

        /// <summary>
        /// EPCTY1.
        /// </summary>
        public const string EPCTY1 = "EPCTY1";

        /// <summary>
        /// EPADDS.
        /// </summary>
        public const string EPADDS = "EPADDS";

        /// <summary>
        /// EPADDZ.
        /// </summary>
        public const string EPADDZ = "EPADDZ";

        /// <summary>
        /// EPCTR.
        /// </summary>
        public const string EPCTR = "EPCTR";

        /// <summary>
        /// EPCO.
        /// </summary>
        public const string EPCO = "EPCO";

        /// <summary>
        /// EPCOUN.
        /// </summary>
        public const string EPCOUN = "EPCOUN";

        /// <summary>
        /// EPUPMT.
        /// </summary>
        public const string EPUPMT = "EPUPMT";

        /// <summary>
        /// EPESIGN.
        /// </summary>
        public const string EPESIGN = "EPESIGN";

        /// <summary>
        /// EPMUMJ.
        /// </summary>
        public const string EPMUMJ = "EPMUMJ";

        /// <summary>
        /// EPMUMT.
        /// </summary>
        public const string EPMUMT = "EPMUMT";

        /// <summary>
        /// EPUPID.
        /// </summary>
        public const string EPUPID = "EPUPID";

        /// <summary>
        /// EPRELA.
        /// </summary>
        public const string EPRELA = "EPRELA";

        /// <summary>
        /// EPDOB.
        /// </summary>
        public const string EPDOB = "EPDOB";

        /// <summary>
        /// EPSEX.
        /// </summary>
        public const string EPSEX = "EPSEX";

        /// <summary>
        /// EPDEPTAX.
        /// </summary>
        public const string EPDEPTAX = "EPDEPTAX";

        /// <summary>
        /// EPHSG.
        /// </summary>
        public const string EPHSG = "EPHSG";

        /// <summary>
        /// EPEMP.
        /// </summary>
        public const string EPEMP = "EPEMP";

        /// <summary>
        /// EPFTS.
        /// </summary>
        public const string EPFTS = "EPFTS";

        /// <summary>
        /// EPSCA.
        /// </summary>
        public const string EPSCA = "EPSCA";

        /// <summary>
        /// EPDSBF.
        /// </summary>
        public const string EPDSBF = "EPDSBF";

        /// <summary>
        /// EPDSBD.
        /// </summary>
        public const string EPDSBD = "EPDSBD";

        /// <summary>
        /// EPDTDH.
        /// </summary>
        public const string EPDTDH = "EPDTDH";

        /// <summary>
        /// EPMCDT.
        /// </summary>
        public const string EPMCDT = "EPMCDT";

        /// <summary>
        /// EPACFL.
        /// </summary>
        public const string EPACFL = "EPACFL";

        /// <summary>
        /// EPPID.
        /// </summary>
        public const string EPPID = "EPPID";

        /// <summary>
        /// EPUSER.
        /// </summary>
        public const string EPUSER = "EPUSER";

        /// <summary>
        /// EPJOBN.
        /// </summary>
        public const string EPJOBN = "EPJOBN";

        /// <summary>
        /// EPUPMJ.
        /// </summary>
        public const string EPUPMJ = "EPUPMJ";

        /// <summary>
        /// EPEMAL.
        /// </summary>
        public const string EPEMAL = "EPEMAL";

        /// <summary>
        /// EPEV01.
        /// </summary>
        public const string EPEV01 = "EPEV01";

        /// <summary>
        /// EPEV02.
        /// </summary>
        public const string EPEV02 = "EPEV02";

        /// <summary>
        /// EPDL01.
        /// </summary>
        public const string EPDL01 = "EPDL01";

        /// <summary>
        /// EPDL02.
        /// </summary>
        public const string EPDL02 = "EPDL02";

        /// <summary>
        /// EPMATH01.
        /// </summary>
        public const string EPMATH01 = "EPMATH01";

        /// <summary>
        /// EPMATH02.
        /// </summary>
        public const string EPMATH02 = "EPMATH02";
    }

    /// <inheritdoc />
    public override string TableName => "F054101W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EPAN8", "EPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EPPAN8", "EPPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EPMLNM", "EPMLNM", JdeDataType.String, 80),
        new JdeField("EPGNNM", "EPGNNM", JdeDataType.String, 50),
        new JdeField("EPMDNM", "EPMDNM", JdeDataType.String, 50),
        new JdeField("EPIMN", "EPIMN", JdeDataType.String, 2),
        new JdeField("EPSRNM", "EPSRNM", JdeDataType.String, 50),
        new JdeField("EPPRNM", "EPPRNM", JdeDataType.String, 40),
        new JdeField("EPHMCU", "EPHMCU", JdeDataType.String, 24),
        new JdeField("EPJBCX", "EPJBCX", JdeDataType.String, 60),
        new JdeField("EPSPRVN", "EPSPRVN", JdeDataType.String, 60),
        new JdeField("EPBSCDTL", "EPBSCDTL", JdeDataType.String, 60),
        new JdeField("EPTAX", "EPTAX", JdeDataType.String, 40),
        new JdeField("EPADD1", "EPADD1", JdeDataType.String, 80),
        new JdeField("EPADD2", "EPADD2", JdeDataType.String, 80),
        new JdeField("EPADD3", "EPADD3", JdeDataType.String, 80),
        new JdeField("EPADD4", "EPADD4", JdeDataType.String, 80),
        new JdeField("EPCTY1", "EPCTY1", JdeDataType.String, 50),
        new JdeField("EPADDS", "EPADDS", JdeDataType.String, 6),
        new JdeField("EPADDZ", "EPADDZ", JdeDataType.String, 24),
        new JdeField("EPCTR", "EPCTR", JdeDataType.String, 6),
        new JdeField("EPCO", "EPCO", JdeDataType.String, 10),
        new JdeField("EPCOUN", "EPCOUN", JdeDataType.String, 50),
        new JdeField("EPUPMT", "EPUPMT", JdeDataType.Numeric),
        new JdeField("EPESIGN", "EPESIGN", JdeDataType.String, 32),
        new JdeField("EPMUMJ", "EPMUMJ", JdeDataType.Numeric),
        new JdeField("EPMUMT", "EPMUMT", JdeDataType.Numeric),
        new JdeField("EPUPID", "EPUPID", JdeDataType.String, 20),
        new JdeField("EPRELA", "EPRELA", JdeDataType.String, 2),
        new JdeField("EPDOB", "EPDOB", JdeDataType.Numeric),
        new JdeField("EPSEX", "EPSEX", JdeDataType.String, 2),
        new JdeField("EPDEPTAX", "EPDEPTAX", JdeDataType.String, 40),
        new JdeField("EPHSG", "EPHSG", JdeDataType.String, 2),
        new JdeField("EPEMP", "EPEMP", JdeDataType.String, 2),
        new JdeField("EPFTS", "EPFTS", JdeDataType.String, 2),
        new JdeField("EPSCA", "EPSCA", JdeDataType.String, 60),
        new JdeField("EPDSBF", "EPDSBF", JdeDataType.String, 2),
        new JdeField("EPDSBD", "EPDSBD", JdeDataType.Numeric),
        new JdeField("EPDTDH", "EPDTDH", JdeDataType.Numeric),
        new JdeField("EPMCDT", "EPMCDT", JdeDataType.Numeric),
        new JdeField("EPACFL", "EPACFL", JdeDataType.String, 2),
        new JdeField("EPPID", "EPPID", JdeDataType.String, 20),
        new JdeField("EPUSER", "EPUSER", JdeDataType.String, 20),
        new JdeField("EPJOBN", "EPJOBN", JdeDataType.String, 20),
        new JdeField("EPUPMJ", "EPUPMJ", JdeDataType.Numeric),
        new JdeField("EPEMAL", "EPEMAL", JdeDataType.String, 512),
        new JdeField("EPEV01", "EPEV01", JdeDataType.String, 2),
        new JdeField("EPEV02", "EPEV02", JdeDataType.String, 2),
        new JdeField("EPDL01", "EPDL01", JdeDataType.String, 60),
        new JdeField("EPDL02", "EPDL02", JdeDataType.String, 60),
        new JdeField("EPMATH01", "EPMATH01", JdeDataType.Numeric),
        new JdeField("EPMATH02", "EPMATH02", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F054101W_0", "Primary Key on EPAN8, EPPAN8", new[] { "EPAN8", "EPPAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F054101W_2", "Index on EPAN8, SYS_NC00053$", new[] { "EPAN8", "SYS_NC00053$" }),
        new JdeIndex("F054101W_3", "Index on EPAN8, EPACFL", new[] { "EPAN8", "EPACFL" }),
        new JdeIndex("F054101W_4", "Index on EPAN8, EPPAN8, EPACFL", new[] { "EPAN8", "EPPAN8", "EPACFL" }),
        new JdeIndex("F054101W_5", "Index on EPAN8, EPPAN8, EPESIGN", new[] { "EPAN8", "EPPAN8", "EPESIGN" })
    };
}
