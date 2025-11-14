using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB05A - .
/// </summary>
public class F90CB05A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OPSMEID.
        /// </summary>
        public const string OPSMEID = "OPSMEID";

        /// <summary>
        /// OPPBLTY.
        /// </summary>
        public const string OPPBLTY = "OPPBLTY";

        /// <summary>
        /// OPSLCYID.
        /// </summary>
        public const string OPSLCYID = "OPSLCYID";

        /// <summary>
        /// OPPBRNG.
        /// </summary>
        public const string OPPBRNG = "OPPBRNG";

        /// <summary>
        /// OPMTCLS.
        /// </summary>
        public const string OPMTCLS = "OPMTCLS";

        /// <summary>
        /// OPFUNLVL.
        /// </summary>
        public const string OPFUNLVL = "OPFUNLVL";

        /// <summary>
        /// OPFUNEXC.
        /// </summary>
        public const string OPFUNEXC = "OPFUNEXC";

        /// <summary>
        /// OPWONLST.
        /// </summary>
        public const string OPWONLST = "OPWONLST";

        /// <summary>
        /// OPRQDSTP.
        /// </summary>
        public const string OPRQDSTP = "OPRQDSTP";

        /// <summary>
        /// OPSCNAME.
        /// </summary>
        public const string OPSCNAME = "OPSCNAME";

        /// <summary>
        /// OPACTPLN.
        /// </summary>
        public const string OPACTPLN = "OPACTPLN";

        /// <summary>
        /// OPENTDBY.
        /// </summary>
        public const string OPENTDBY = "OPENTDBY";

        /// <summary>
        /// OPEDATE.
        /// </summary>
        public const string OPEDATE = "OPEDATE";

        /// <summary>
        /// OPEXVAR0.
        /// </summary>
        public const string OPEXVAR0 = "OPEXVAR0";

        /// <summary>
        /// OPEXVAR1.
        /// </summary>
        public const string OPEXVAR1 = "OPEXVAR1";

        /// <summary>
        /// OPEXVAR2.
        /// </summary>
        public const string OPEXVAR2 = "OPEXVAR2";

        /// <summary>
        /// OPEXVAR3.
        /// </summary>
        public const string OPEXVAR3 = "OPEXVAR3";

        /// <summary>
        /// OPEXVAR4.
        /// </summary>
        public const string OPEXVAR4 = "OPEXVAR4";

        /// <summary>
        /// OPEXVAR5.
        /// </summary>
        public const string OPEXVAR5 = "OPEXVAR5";

        /// <summary>
        /// OPEXVAR6.
        /// </summary>
        public const string OPEXVAR6 = "OPEXVAR6";

        /// <summary>
        /// OPEXVAR7.
        /// </summary>
        public const string OPEXVAR7 = "OPEXVAR7";

        /// <summary>
        /// OPEXNM0.
        /// </summary>
        public const string OPEXNM0 = "OPEXNM0";

        /// <summary>
        /// OPEXNM1.
        /// </summary>
        public const string OPEXNM1 = "OPEXNM1";

        /// <summary>
        /// OPEXNM2.
        /// </summary>
        public const string OPEXNM2 = "OPEXNM2";

        /// <summary>
        /// OPEXNMP0.
        /// </summary>
        public const string OPEXNMP0 = "OPEXNMP0";

        /// <summary>
        /// OPEXNMP1.
        /// </summary>
        public const string OPEXNMP1 = "OPEXNMP1";

        /// <summary>
        /// OPEXNMP2.
        /// </summary>
        public const string OPEXNMP2 = "OPEXNMP2";

        /// <summary>
        /// OPEXDT0.
        /// </summary>
        public const string OPEXDT0 = "OPEXDT0";

        /// <summary>
        /// OPEXDT1.
        /// </summary>
        public const string OPEXDT1 = "OPEXDT1";

        /// <summary>
        /// OPEXDT2.
        /// </summary>
        public const string OPEXDT2 = "OPEXDT2";

        /// <summary>
        /// OPSTSUDT.
        /// </summary>
        public const string OPSTSUDT = "OPSTSUDT";

        /// <summary>
        /// OPACTIND.
        /// </summary>
        public const string OPACTIND = "OPACTIND";

        /// <summary>
        /// OPUSER.
        /// </summary>
        public const string OPUSER = "OPUSER";

        /// <summary>
        /// OPPID.
        /// </summary>
        public const string OPPID = "OPPID";

        /// <summary>
        /// OPVID.
        /// </summary>
        public const string OPVID = "OPVID";

        /// <summary>
        /// OPMKEY.
        /// </summary>
        public const string OPMKEY = "OPMKEY";

        /// <summary>
        /// OPUDTTM.
        /// </summary>
        public const string OPUDTTM = "OPUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB05A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OPSMEID", "OPSMEID", JdeDataType.Numeric),
        new JdeField("OPPBLTY", "OPPBLTY", JdeDataType.Numeric),
        new JdeField("OPSLCYID", "OPSLCYID", JdeDataType.Numeric, null, true, true),
        new JdeField("OPPBRNG", "OPPBRNG", JdeDataType.Numeric),
        new JdeField("OPMTCLS", "OPMTCLS", JdeDataType.Numeric),
        new JdeField("OPFUNLVL", "OPFUNLVL", JdeDataType.Numeric),
        new JdeField("OPFUNEXC", "OPFUNEXC", JdeDataType.String, 2),
        new JdeField("OPWONLST", "OPWONLST", JdeDataType.String, 2),
        new JdeField("OPRQDSTP", "OPRQDSTP", JdeDataType.String, 2),
        new JdeField("OPSCNAME", "OPSCNAME", JdeDataType.String, 100),
        new JdeField("OPACTPLN", "OPACTPLN", JdeDataType.Numeric),
        new JdeField("OPENTDBY", "OPENTDBY", JdeDataType.Numeric),
        new JdeField("OPEDATE", "OPEDATE", JdeDataType.Date),
        new JdeField("OPEXVAR0", "OPEXVAR0", JdeDataType.String, 510),
        new JdeField("OPEXVAR1", "OPEXVAR1", JdeDataType.String, 510),
        new JdeField("OPEXVAR2", "OPEXVAR2", JdeDataType.String, 510),
        new JdeField("OPEXVAR3", "OPEXVAR3", JdeDataType.String, 510),
        new JdeField("OPEXVAR4", "OPEXVAR4", JdeDataType.String, 100),
        new JdeField("OPEXVAR5", "OPEXVAR5", JdeDataType.String, 100),
        new JdeField("OPEXVAR6", "OPEXVAR6", JdeDataType.String, 100),
        new JdeField("OPEXVAR7", "OPEXVAR7", JdeDataType.String, 100),
        new JdeField("OPEXNM0", "OPEXNM0", JdeDataType.Numeric),
        new JdeField("OPEXNM1", "OPEXNM1", JdeDataType.Numeric),
        new JdeField("OPEXNM2", "OPEXNM2", JdeDataType.Numeric),
        new JdeField("OPEXNMP0", "OPEXNMP0", JdeDataType.Numeric),
        new JdeField("OPEXNMP1", "OPEXNMP1", JdeDataType.Numeric),
        new JdeField("OPEXNMP2", "OPEXNMP2", JdeDataType.Numeric),
        new JdeField("OPEXDT0", "OPEXDT0", JdeDataType.Date),
        new JdeField("OPEXDT1", "OPEXDT1", JdeDataType.Date),
        new JdeField("OPEXDT2", "OPEXDT2", JdeDataType.Date),
        new JdeField("OPSTSUDT", "OPSTSUDT", JdeDataType.Date),
        new JdeField("OPACTIND", "OPACTIND", JdeDataType.String, 2),
        new JdeField("OPUSER", "OPUSER", JdeDataType.String, 20),
        new JdeField("OPPID", "OPPID", JdeDataType.String, 20),
        new JdeField("OPVID", "OPVID", JdeDataType.String, 20),
        new JdeField("OPMKEY", "OPMKEY", JdeDataType.String, 30),
        new JdeField("OPUDTTM", "OPUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB05A_0", "Primary Key on OPSLCYID", new[] { "OPSLCYID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB05A_2", "Index on OPSMEID, OPPBLTY, OPACTIND", new[] { "OPSMEID", "OPPBLTY", "OPACTIND" }),
        new JdeIndex("F90CB05A_3", "Index on OPSMEID, OPACTIND, OPFUNLVL, OPPBLTY", new[] { "OPSMEID", "OPACTIND", "OPFUNLVL", "OPPBLTY" }),
        new JdeIndex("F90CB05A_4", "Index on OPSMEID, OPACTIND, OPSCNAME", new[] { "OPSMEID", "OPACTIND", "OPSCNAME" })
    };
}
