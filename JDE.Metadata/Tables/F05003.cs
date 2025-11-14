using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05003 - .
/// </summary>
public class F05003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EVAN8.
        /// </summary>
        public const string EVAN8 = "EVAN8";

        /// <summary>
        /// EVDRQJ.
        /// </summary>
        public const string EVDRQJ = "EVDRQJ";

        /// <summary>
        /// EVRQTI.
        /// </summary>
        public const string EVRQTI = "EVRQTI";

        /// <summary>
        /// EVCOMNT1.
        /// </summary>
        public const string EVCOMNT1 = "EVCOMNT1";

        /// <summary>
        /// EVCONAME.
        /// </summary>
        public const string EVCONAME = "EVCONAME";

        /// <summary>
        /// EVALPH.
        /// </summary>
        public const string EVALPH = "EVALPH";

        /// <summary>
        /// EVATTL.
        /// </summary>
        public const string EVATTL = "EVATTL";

        /// <summary>
        /// EVAR1.
        /// </summary>
        public const string EVAR1 = "EVAR1";

        /// <summary>
        /// EVPH1.
        /// </summary>
        public const string EVPH1 = "EVPH1";

        /// <summary>
        /// EVAR2.
        /// </summary>
        public const string EVAR2 = "EVAR2";

        /// <summary>
        /// EVPH2.
        /// </summary>
        public const string EVPH2 = "EVPH2";

        /// <summary>
        /// EVEML.
        /// </summary>
        public const string EVEML = "EVEML";

        /// <summary>
        /// EVADD1.
        /// </summary>
        public const string EVADD1 = "EVADD1";

        /// <summary>
        /// EVADD2.
        /// </summary>
        public const string EVADD2 = "EVADD2";

        /// <summary>
        /// EVCTY1.
        /// </summary>
        public const string EVCTY1 = "EVCTY1";

        /// <summary>
        /// EVADDS.
        /// </summary>
        public const string EVADDS = "EVADDS";

        /// <summary>
        /// EVADDZ.
        /// </summary>
        public const string EVADDZ = "EVADDZ";

        /// <summary>
        /// EVCTR.
        /// </summary>
        public const string EVCTR = "EVCTR";

        /// <summary>
        /// EVFLGFAX.
        /// </summary>
        public const string EVFLGFAX = "EVFLGFAX";

        /// <summary>
        /// EVFLGEML.
        /// </summary>
        public const string EVFLGEML = "EVFLGEML";

        /// <summary>
        /// EVFLGMAL.
        /// </summary>
        public const string EVFLGMAL = "EVFLGMAL";

        /// <summary>
        /// EVFLGREV.
        /// </summary>
        public const string EVFLGREV = "EVFLGREV";

        /// <summary>
        /// EVDST.
        /// </summary>
        public const string EVDST = "EVDST";

        /// <summary>
        /// EVDESCJTS.
        /// </summary>
        public const string EVDESCJTS = "EVDESCJTS";

        /// <summary>
        /// EVHMCO.
        /// </summary>
        public const string EVHMCO = "EVHMCO";

        /// <summary>
        /// EVEST.
        /// </summary>
        public const string EVEST = "EVEST";

        /// <summary>
        /// EVPAST.
        /// </summary>
        public const string EVPAST = "EVPAST";

        /// <summary>
        /// EVSALY.
        /// </summary>
        public const string EVSALY = "EVSALY";

        /// <summary>
        /// EVPFRQ.
        /// </summary>
        public const string EVPFRQ = "EVPFRQ";

        /// <summary>
        /// EVPPSOW.
        /// </summary>
        public const string EVPPSOW = "EVPPSOW";

        /// <summary>
        /// EVEMPLCON.
        /// </summary>
        public const string EVEMPLCON = "EVEMPLCON";

        /// <summary>
        /// EVCOMNT2.
        /// </summary>
        public const string EVCOMNT2 = "EVCOMNT2";

        /// <summary>
        /// EVAMTINC.
        /// </summary>
        public const string EVAMTINC = "EVAMTINC";

        /// <summary>
        /// EVDR.
        /// </summary>
        public const string EVDR = "EVDR";

        /// <summary>
        /// EVNRDT.
        /// </summary>
        public const string EVNRDT = "EVNRDT";

        /// <summary>
        /// EVAYTDBS0.
        /// </summary>
        public const string EVAYTDBS0 = "EVAYTDBS0";

        /// <summary>
        /// EVAYTDBS1.
        /// </summary>
        public const string EVAYTDBS1 = "EVAYTDBS1";

        /// <summary>
        /// EVAYTDBS2.
        /// </summary>
        public const string EVAYTDBS2 = "EVAYTDBS2";

        /// <summary>
        /// EVAYTDOT0.
        /// </summary>
        public const string EVAYTDOT0 = "EVAYTDOT0";

        /// <summary>
        /// EVAYTDOT1.
        /// </summary>
        public const string EVAYTDOT1 = "EVAYTDOT1";

        /// <summary>
        /// EVAYTDOT2.
        /// </summary>
        public const string EVAYTDOT2 = "EVAYTDOT2";

        /// <summary>
        /// EVAYTDCM0.
        /// </summary>
        public const string EVAYTDCM0 = "EVAYTDCM0";

        /// <summary>
        /// EVAYTDCM1.
        /// </summary>
        public const string EVAYTDCM1 = "EVAYTDCM1";

        /// <summary>
        /// EVAYTDCM2.
        /// </summary>
        public const string EVAYTDCM2 = "EVAYTDCM2";

        /// <summary>
        /// EVAYTDBN0.
        /// </summary>
        public const string EVAYTDBN0 = "EVAYTDBN0";

        /// <summary>
        /// EVAYTDBN1.
        /// </summary>
        public const string EVAYTDBN1 = "EVAYTDBN1";

        /// <summary>
        /// EVAYTDBN2.
        /// </summary>
        public const string EVAYTDBN2 = "EVAYTDBN2";

        /// <summary>
        /// EVAYTDOR0.
        /// </summary>
        public const string EVAYTDOR0 = "EVAYTDOR0";

        /// <summary>
        /// EVAYTDOR1.
        /// </summary>
        public const string EVAYTDOR1 = "EVAYTDOR1";

        /// <summary>
        /// EVAYTDOR2.
        /// </summary>
        public const string EVAYTDOR2 = "EVAYTDOR2";

        /// <summary>
        /// EVAYTDTL0.
        /// </summary>
        public const string EVAYTDTL0 = "EVAYTDTL0";

        /// <summary>
        /// EVAYTDTL1.
        /// </summary>
        public const string EVAYTDTL1 = "EVAYTDTL1";

        /// <summary>
        /// EVAYTDTL2.
        /// </summary>
        public const string EVAYTDTL2 = "EVAYTDTL2";

        /// <summary>
        /// EVUSER.
        /// </summary>
        public const string EVUSER = "EVUSER";

        /// <summary>
        /// EVPID.
        /// </summary>
        public const string EVPID = "EVPID";

        /// <summary>
        /// EVJOBN.
        /// </summary>
        public const string EVJOBN = "EVJOBN";

        /// <summary>
        /// EVUPMJ.
        /// </summary>
        public const string EVUPMJ = "EVUPMJ";

        /// <summary>
        /// EVUPMT.
        /// </summary>
        public const string EVUPMT = "EVUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EVAN8", "EVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EVDRQJ", "EVDRQJ", JdeDataType.Numeric, null, true, true),
        new JdeField("EVRQTI", "EVRQTI", JdeDataType.Numeric, null, true, true),
        new JdeField("EVCOMNT1", "EVCOMNT1", JdeDataType.String, 80),
        new JdeField("EVCONAME", "EVCONAME", JdeDataType.String, 80),
        new JdeField("EVALPH", "EVALPH", JdeDataType.String, 80),
        new JdeField("EVATTL", "EVATTL", JdeDataType.String, 80),
        new JdeField("EVAR1", "EVAR1", JdeDataType.String, 12),
        new JdeField("EVPH1", "EVPH1", JdeDataType.String, 40),
        new JdeField("EVAR2", "EVAR2", JdeDataType.String, 12),
        new JdeField("EVPH2", "EVPH2", JdeDataType.String, 40),
        new JdeField("EVEML", "EVEML", JdeDataType.String, 80),
        new JdeField("EVADD1", "EVADD1", JdeDataType.String, 80),
        new JdeField("EVADD2", "EVADD2", JdeDataType.String, 80),
        new JdeField("EVCTY1", "EVCTY1", JdeDataType.String, 50),
        new JdeField("EVADDS", "EVADDS", JdeDataType.String, 6),
        new JdeField("EVADDZ", "EVADDZ", JdeDataType.String, 24),
        new JdeField("EVCTR", "EVCTR", JdeDataType.String, 6),
        new JdeField("EVFLGFAX", "EVFLGFAX", JdeDataType.String, 2),
        new JdeField("EVFLGEML", "EVFLGEML", JdeDataType.String, 2),
        new JdeField("EVFLGMAL", "EVFLGMAL", JdeDataType.String, 2),
        new JdeField("EVFLGREV", "EVFLGREV", JdeDataType.String, 2),
        new JdeField("EVDST", "EVDST", JdeDataType.Numeric),
        new JdeField("EVDESCJTS", "EVDESCJTS", JdeDataType.String, 60),
        new JdeField("EVHMCO", "EVHMCO", JdeDataType.String, 10),
        new JdeField("EVEST", "EVEST", JdeDataType.String, 2),
        new JdeField("EVPAST", "EVPAST", JdeDataType.String, 2),
        new JdeField("EVSALY", "EVSALY", JdeDataType.String, 2),
        new JdeField("EVPFRQ", "EVPFRQ", JdeDataType.String, 2),
        new JdeField("EVPPSOW", "EVPPSOW", JdeDataType.Numeric),
        new JdeField("EVEMPLCON", "EVEMPLCON", JdeDataType.String, 2),
        new JdeField("EVCOMNT2", "EVCOMNT2", JdeDataType.String, 80),
        new JdeField("EVAMTINC", "EVAMTINC", JdeDataType.Numeric),
        new JdeField("EVDR", "EVDR", JdeDataType.Numeric),
        new JdeField("EVNRDT", "EVNRDT", JdeDataType.Numeric),
        new JdeField("EVAYTDBS0", "EVAYTDBS0", JdeDataType.Numeric),
        new JdeField("EVAYTDBS1", "EVAYTDBS1", JdeDataType.Numeric),
        new JdeField("EVAYTDBS2", "EVAYTDBS2", JdeDataType.Numeric),
        new JdeField("EVAYTDOT0", "EVAYTDOT0", JdeDataType.Numeric),
        new JdeField("EVAYTDOT1", "EVAYTDOT1", JdeDataType.Numeric),
        new JdeField("EVAYTDOT2", "EVAYTDOT2", JdeDataType.Numeric),
        new JdeField("EVAYTDCM0", "EVAYTDCM0", JdeDataType.Numeric),
        new JdeField("EVAYTDCM1", "EVAYTDCM1", JdeDataType.Numeric),
        new JdeField("EVAYTDCM2", "EVAYTDCM2", JdeDataType.Numeric),
        new JdeField("EVAYTDBN0", "EVAYTDBN0", JdeDataType.Numeric),
        new JdeField("EVAYTDBN1", "EVAYTDBN1", JdeDataType.Numeric),
        new JdeField("EVAYTDBN2", "EVAYTDBN2", JdeDataType.Numeric),
        new JdeField("EVAYTDOR0", "EVAYTDOR0", JdeDataType.Numeric),
        new JdeField("EVAYTDOR1", "EVAYTDOR1", JdeDataType.Numeric),
        new JdeField("EVAYTDOR2", "EVAYTDOR2", JdeDataType.Numeric),
        new JdeField("EVAYTDTL0", "EVAYTDTL0", JdeDataType.Numeric),
        new JdeField("EVAYTDTL1", "EVAYTDTL1", JdeDataType.Numeric),
        new JdeField("EVAYTDTL2", "EVAYTDTL2", JdeDataType.Numeric),
        new JdeField("EVUSER", "EVUSER", JdeDataType.String, 20),
        new JdeField("EVPID", "EVPID", JdeDataType.String, 20),
        new JdeField("EVJOBN", "EVJOBN", JdeDataType.String, 20),
        new JdeField("EVUPMJ", "EVUPMJ", JdeDataType.Numeric),
        new JdeField("EVUPMT", "EVUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05003_0", "Primary Key on EVAN8, EVDRQJ, EVRQTI", new[] { "EVAN8", "EVDRQJ", "EVRQTI" }, isUnique: true, isPrimaryKey: true)
    };
}
