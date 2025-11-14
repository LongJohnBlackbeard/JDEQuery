using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB02M - .
/// </summary>
public class F90CB02M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OMCOSTID.
        /// </summary>
        public const string OMCOSTID = "OMCOSTID";

        /// <summary>
        /// OMOPPID.
        /// </summary>
        public const string OMOPPID = "OMOPPID";

        /// <summary>
        /// OMCSTTYP.
        /// </summary>
        public const string OMCSTTYP = "OMCSTTYP";

        /// <summary>
        /// OMCSTDTE.
        /// </summary>
        public const string OMCSTDTE = "OMCSTDTE";

        /// <summary>
        /// OMCTGEXP.
        /// </summary>
        public const string OMCTGEXP = "OMCTGEXP";

        /// <summary>
        /// OMCTGTIM.
        /// </summary>
        public const string OMCTGTIM = "OMCTGTIM";

        /// <summary>
        /// OMPMTMTH.
        /// </summary>
        public const string OMPMTMTH = "OMPMTMTH";

        /// <summary>
        /// OMTIMTYP.
        /// </summary>
        public const string OMTIMTYP = "OMTIMTYP";

        /// <summary>
        /// OMTOTTIM.
        /// </summary>
        public const string OMTOTTIM = "OMTOTTIM";

        /// <summary>
        /// OMTTLEXP.
        /// </summary>
        public const string OMTTLEXP = "OMTTLEXP";

        /// <summary>
        /// OMDSCRP3.
        /// </summary>
        public const string OMDSCRP3 = "OMDSCRP3";

        /// <summary>
        /// OMDSCRP4.
        /// </summary>
        public const string OMDSCRP4 = "OMDSCRP4";

        /// <summary>
        /// OMENTDBY.
        /// </summary>
        public const string OMENTDBY = "OMENTDBY";

        /// <summary>
        /// OMEDATE.
        /// </summary>
        public const string OMEDATE = "OMEDATE";

        /// <summary>
        /// OMEXVAR0.
        /// </summary>
        public const string OMEXVAR0 = "OMEXVAR0";

        /// <summary>
        /// OMEXVAR1.
        /// </summary>
        public const string OMEXVAR1 = "OMEXVAR1";

        /// <summary>
        /// OMEXVAR4.
        /// </summary>
        public const string OMEXVAR4 = "OMEXVAR4";

        /// <summary>
        /// OMEXVAR5.
        /// </summary>
        public const string OMEXVAR5 = "OMEXVAR5";

        /// <summary>
        /// OMEXVAR6.
        /// </summary>
        public const string OMEXVAR6 = "OMEXVAR6";

        /// <summary>
        /// OMEXVAR7.
        /// </summary>
        public const string OMEXVAR7 = "OMEXVAR7";

        /// <summary>
        /// OMEXVAR12.
        /// </summary>
        public const string OMEXVAR12 = "OMEXVAR12";

        /// <summary>
        /// OMEXVAR13.
        /// </summary>
        public const string OMEXVAR13 = "OMEXVAR13";

        /// <summary>
        /// OMEXNM0.
        /// </summary>
        public const string OMEXNM0 = "OMEXNM0";

        /// <summary>
        /// OMEXNM1.
        /// </summary>
        public const string OMEXNM1 = "OMEXNM1";

        /// <summary>
        /// OMEXNM2.
        /// </summary>
        public const string OMEXNM2 = "OMEXNM2";

        /// <summary>
        /// OMEXNMP0.
        /// </summary>
        public const string OMEXNMP0 = "OMEXNMP0";

        /// <summary>
        /// OMEXNMP1.
        /// </summary>
        public const string OMEXNMP1 = "OMEXNMP1";

        /// <summary>
        /// OMEXNMP2.
        /// </summary>
        public const string OMEXNMP2 = "OMEXNMP2";

        /// <summary>
        /// OMEXDT0.
        /// </summary>
        public const string OMEXDT0 = "OMEXDT0";

        /// <summary>
        /// OMEXDT1.
        /// </summary>
        public const string OMEXDT1 = "OMEXDT1";

        /// <summary>
        /// OMEXDT2.
        /// </summary>
        public const string OMEXDT2 = "OMEXDT2";

        /// <summary>
        /// OMSTSUDT.
        /// </summary>
        public const string OMSTSUDT = "OMSTSUDT";

        /// <summary>
        /// OMACTIND.
        /// </summary>
        public const string OMACTIND = "OMACTIND";

        /// <summary>
        /// OMUSER.
        /// </summary>
        public const string OMUSER = "OMUSER";

        /// <summary>
        /// OMPID.
        /// </summary>
        public const string OMPID = "OMPID";

        /// <summary>
        /// OMVID.
        /// </summary>
        public const string OMVID = "OMVID";

        /// <summary>
        /// OMMKEY.
        /// </summary>
        public const string OMMKEY = "OMMKEY";

        /// <summary>
        /// OMUDTTM.
        /// </summary>
        public const string OMUDTTM = "OMUDTTM";

        /// <summary>
        /// OMCRCD.
        /// </summary>
        public const string OMCRCD = "OMCRCD";

        /// <summary>
        /// OMAN8.
        /// </summary>
        public const string OMAN8 = "OMAN8";

        /// <summary>
        /// OMIDLN.
        /// </summary>
        public const string OMIDLN = "OMIDLN";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB02M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OMCOSTID", "OMCOSTID", JdeDataType.Numeric, null, true, true),
        new JdeField("OMOPPID", "OMOPPID", JdeDataType.Numeric),
        new JdeField("OMCSTTYP", "OMCSTTYP", JdeDataType.String, 10),
        new JdeField("OMCSTDTE", "OMCSTDTE", JdeDataType.Date),
        new JdeField("OMCTGEXP", "OMCTGEXP", JdeDataType.String, 10),
        new JdeField("OMCTGTIM", "OMCTGTIM", JdeDataType.String, 10),
        new JdeField("OMPMTMTH", "OMPMTMTH", JdeDataType.String, 10),
        new JdeField("OMTIMTYP", "OMTIMTYP", JdeDataType.String, 10),
        new JdeField("OMTOTTIM", "OMTOTTIM", JdeDataType.Numeric),
        new JdeField("OMTTLEXP", "OMTTLEXP", JdeDataType.Numeric),
        new JdeField("OMDSCRP3", "OMDSCRP3", JdeDataType.String, 510),
        new JdeField("OMDSCRP4", "OMDSCRP4", JdeDataType.String, 3000),
        new JdeField("OMENTDBY", "OMENTDBY", JdeDataType.Numeric),
        new JdeField("OMEDATE", "OMEDATE", JdeDataType.Date),
        new JdeField("OMEXVAR0", "OMEXVAR0", JdeDataType.String, 510),
        new JdeField("OMEXVAR1", "OMEXVAR1", JdeDataType.String, 510),
        new JdeField("OMEXVAR4", "OMEXVAR4", JdeDataType.String, 100),
        new JdeField("OMEXVAR5", "OMEXVAR5", JdeDataType.String, 100),
        new JdeField("OMEXVAR6", "OMEXVAR6", JdeDataType.String, 100),
        new JdeField("OMEXVAR7", "OMEXVAR7", JdeDataType.String, 100),
        new JdeField("OMEXVAR12", "OMEXVAR12", JdeDataType.String, 50),
        new JdeField("OMEXVAR13", "OMEXVAR13", JdeDataType.String, 50),
        new JdeField("OMEXNM0", "OMEXNM0", JdeDataType.Numeric),
        new JdeField("OMEXNM1", "OMEXNM1", JdeDataType.Numeric),
        new JdeField("OMEXNM2", "OMEXNM2", JdeDataType.Numeric),
        new JdeField("OMEXNMP0", "OMEXNMP0", JdeDataType.Numeric),
        new JdeField("OMEXNMP1", "OMEXNMP1", JdeDataType.Numeric),
        new JdeField("OMEXNMP2", "OMEXNMP2", JdeDataType.Numeric),
        new JdeField("OMEXDT0", "OMEXDT0", JdeDataType.Date),
        new JdeField("OMEXDT1", "OMEXDT1", JdeDataType.Date),
        new JdeField("OMEXDT2", "OMEXDT2", JdeDataType.Date),
        new JdeField("OMSTSUDT", "OMSTSUDT", JdeDataType.Date),
        new JdeField("OMACTIND", "OMACTIND", JdeDataType.String, 2),
        new JdeField("OMUSER", "OMUSER", JdeDataType.String, 20),
        new JdeField("OMPID", "OMPID", JdeDataType.String, 20),
        new JdeField("OMVID", "OMVID", JdeDataType.String, 20),
        new JdeField("OMMKEY", "OMMKEY", JdeDataType.String, 30),
        new JdeField("OMUDTTM", "OMUDTTM", JdeDataType.Date),
        new JdeField("OMCRCD", "OMCRCD", JdeDataType.String, 6),
        new JdeField("OMAN8", "OMAN8", JdeDataType.Numeric),
        new JdeField("OMIDLN", "OMIDLN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB02M_0", "Primary Key on OMCOSTID", new[] { "OMCOSTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB02M_2", "Index on OMOPPID", new[] { "OMOPPID" })
    };
}
