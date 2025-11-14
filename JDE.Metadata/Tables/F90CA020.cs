using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA020 - .
/// </summary>
public class F90CA020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTPSAN8.
        /// </summary>
        public const string TTPSAN8 = "TTPSAN8";

        /// <summary>
        /// TTCNLNID.
        /// </summary>
        public const string TTCNLNID = "TTCNLNID";

        /// <summary>
        /// TTDCRCD.
        /// </summary>
        public const string TTDCRCD = "TTDCRCD";

        /// <summary>
        /// TTIMSG.
        /// </summary>
        public const string TTIMSG = "TTIMSG";

        /// <summary>
        /// TTSMEID.
        /// </summary>
        public const string TTSMEID = "TTSMEID";

        /// <summary>
        /// TTALRTF.
        /// </summary>
        public const string TTALRTF = "TTALRTF";

        /// <summary>
        /// TTSTSCOD.
        /// </summary>
        public const string TTSTSCOD = "TTSTSCOD";

        /// <summary>
        /// TTINACTD.
        /// </summary>
        public const string TTINACTD = "TTINACTD";

        /// <summary>
        /// TTSVCNT.
        /// </summary>
        public const string TTSVCNT = "TTSVCNT";

        /// <summary>
        /// TTPAFLG.
        /// </summary>
        public const string TTPAFLG = "TTPAFLG";

        /// <summary>
        /// TTENTDBY.
        /// </summary>
        public const string TTENTDBY = "TTENTDBY";

        /// <summary>
        /// TTEDATE.
        /// </summary>
        public const string TTEDATE = "TTEDATE";

        /// <summary>
        /// TTEXVAR0.
        /// </summary>
        public const string TTEXVAR0 = "TTEXVAR0";

        /// <summary>
        /// TTEXVAR1.
        /// </summary>
        public const string TTEXVAR1 = "TTEXVAR1";

        /// <summary>
        /// TTEXVAR2.
        /// </summary>
        public const string TTEXVAR2 = "TTEXVAR2";

        /// <summary>
        /// TTEXVAR3.
        /// </summary>
        public const string TTEXVAR3 = "TTEXVAR3";

        /// <summary>
        /// TTEXVAR4.
        /// </summary>
        public const string TTEXVAR4 = "TTEXVAR4";

        /// <summary>
        /// TTEXVAR5.
        /// </summary>
        public const string TTEXVAR5 = "TTEXVAR5";

        /// <summary>
        /// TTEXVAR6.
        /// </summary>
        public const string TTEXVAR6 = "TTEXVAR6";

        /// <summary>
        /// TTEXVAR7.
        /// </summary>
        public const string TTEXVAR7 = "TTEXVAR7";

        /// <summary>
        /// TTEXVAR8.
        /// </summary>
        public const string TTEXVAR8 = "TTEXVAR8";

        /// <summary>
        /// TTEXVAR9.
        /// </summary>
        public const string TTEXVAR9 = "TTEXVAR9";

        /// <summary>
        /// TTEXVAR10.
        /// </summary>
        public const string TTEXVAR10 = "TTEXVAR10";

        /// <summary>
        /// TTEXVAR11.
        /// </summary>
        public const string TTEXVAR11 = "TTEXVAR11";

        /// <summary>
        /// TTEXVAR12.
        /// </summary>
        public const string TTEXVAR12 = "TTEXVAR12";

        /// <summary>
        /// TTEXVAR13.
        /// </summary>
        public const string TTEXVAR13 = "TTEXVAR13";

        /// <summary>
        /// TTEXVAR14.
        /// </summary>
        public const string TTEXVAR14 = "TTEXVAR14";

        /// <summary>
        /// TTEXNM0.
        /// </summary>
        public const string TTEXNM0 = "TTEXNM0";

        /// <summary>
        /// TTEXNM1.
        /// </summary>
        public const string TTEXNM1 = "TTEXNM1";

        /// <summary>
        /// TTEXNM2.
        /// </summary>
        public const string TTEXNM2 = "TTEXNM2";

        /// <summary>
        /// TTEXNM3.
        /// </summary>
        public const string TTEXNM3 = "TTEXNM3";

        /// <summary>
        /// TTEXNM4.
        /// </summary>
        public const string TTEXNM4 = "TTEXNM4";

        /// <summary>
        /// TTEXNMP0.
        /// </summary>
        public const string TTEXNMP0 = "TTEXNMP0";

        /// <summary>
        /// TTEXNMP1.
        /// </summary>
        public const string TTEXNMP1 = "TTEXNMP1";

        /// <summary>
        /// TTEXNMP2.
        /// </summary>
        public const string TTEXNMP2 = "TTEXNMP2";

        /// <summary>
        /// TTEXNMP3.
        /// </summary>
        public const string TTEXNMP3 = "TTEXNMP3";

        /// <summary>
        /// TTEXNMP4.
        /// </summary>
        public const string TTEXNMP4 = "TTEXNMP4";

        /// <summary>
        /// TTEXDT0.
        /// </summary>
        public const string TTEXDT0 = "TTEXDT0";

        /// <summary>
        /// TTEXDT1.
        /// </summary>
        public const string TTEXDT1 = "TTEXDT1";

        /// <summary>
        /// TTEXDT2.
        /// </summary>
        public const string TTEXDT2 = "TTEXDT2";

        /// <summary>
        /// TTEXDT3.
        /// </summary>
        public const string TTEXDT3 = "TTEXDT3";

        /// <summary>
        /// TTEXDT4.
        /// </summary>
        public const string TTEXDT4 = "TTEXDT4";

        /// <summary>
        /// TTSTSUDT.
        /// </summary>
        public const string TTSTSUDT = "TTSTSUDT";

        /// <summary>
        /// TTACTIND.
        /// </summary>
        public const string TTACTIND = "TTACTIND";

        /// <summary>
        /// TTUSER.
        /// </summary>
        public const string TTUSER = "TTUSER";

        /// <summary>
        /// TTPID.
        /// </summary>
        public const string TTPID = "TTPID";

        /// <summary>
        /// TTVID.
        /// </summary>
        public const string TTVID = "TTVID";

        /// <summary>
        /// TTMKEY.
        /// </summary>
        public const string TTMKEY = "TTMKEY";

        /// <summary>
        /// TTUDTTM.
        /// </summary>
        public const string TTUDTTM = "TTUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTPSAN8", "TTPSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TTCNLNID", "TTCNLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TTDCRCD", "TTDCRCD", JdeDataType.String, 6),
        new JdeField("TTIMSG", "TTIMSG", JdeDataType.String, 2),
        new JdeField("TTSMEID", "TTSMEID", JdeDataType.Numeric),
        new JdeField("TTALRTF", "TTALRTF", JdeDataType.String, 2),
        new JdeField("TTSTSCOD", "TTSTSCOD", JdeDataType.String, 10),
        new JdeField("TTINACTD", "TTINACTD", JdeDataType.Date),
        new JdeField("TTSVCNT", "TTSVCNT", JdeDataType.String, 24),
        new JdeField("TTPAFLG", "TTPAFLG", JdeDataType.String, 2),
        new JdeField("TTENTDBY", "TTENTDBY", JdeDataType.Numeric),
        new JdeField("TTEDATE", "TTEDATE", JdeDataType.Date),
        new JdeField("TTEXVAR0", "TTEXVAR0", JdeDataType.String, 510),
        new JdeField("TTEXVAR1", "TTEXVAR1", JdeDataType.String, 510),
        new JdeField("TTEXVAR2", "TTEXVAR2", JdeDataType.String, 510),
        new JdeField("TTEXVAR3", "TTEXVAR3", JdeDataType.String, 510),
        new JdeField("TTEXVAR4", "TTEXVAR4", JdeDataType.String, 100),
        new JdeField("TTEXVAR5", "TTEXVAR5", JdeDataType.String, 100),
        new JdeField("TTEXVAR6", "TTEXVAR6", JdeDataType.String, 100),
        new JdeField("TTEXVAR7", "TTEXVAR7", JdeDataType.String, 100),
        new JdeField("TTEXVAR8", "TTEXVAR8", JdeDataType.String, 100),
        new JdeField("TTEXVAR9", "TTEXVAR9", JdeDataType.String, 100),
        new JdeField("TTEXVAR10", "TTEXVAR10", JdeDataType.String, 100),
        new JdeField("TTEXVAR11", "TTEXVAR11", JdeDataType.String, 100),
        new JdeField("TTEXVAR12", "TTEXVAR12", JdeDataType.String, 50),
        new JdeField("TTEXVAR13", "TTEXVAR13", JdeDataType.String, 50),
        new JdeField("TTEXVAR14", "TTEXVAR14", JdeDataType.String, 50),
        new JdeField("TTEXNM0", "TTEXNM0", JdeDataType.Numeric),
        new JdeField("TTEXNM1", "TTEXNM1", JdeDataType.Numeric),
        new JdeField("TTEXNM2", "TTEXNM2", JdeDataType.Numeric),
        new JdeField("TTEXNM3", "TTEXNM3", JdeDataType.Numeric),
        new JdeField("TTEXNM4", "TTEXNM4", JdeDataType.Numeric),
        new JdeField("TTEXNMP0", "TTEXNMP0", JdeDataType.Numeric),
        new JdeField("TTEXNMP1", "TTEXNMP1", JdeDataType.Numeric),
        new JdeField("TTEXNMP2", "TTEXNMP2", JdeDataType.Numeric),
        new JdeField("TTEXNMP3", "TTEXNMP3", JdeDataType.Numeric),
        new JdeField("TTEXNMP4", "TTEXNMP4", JdeDataType.Numeric),
        new JdeField("TTEXDT0", "TTEXDT0", JdeDataType.Date),
        new JdeField("TTEXDT1", "TTEXDT1", JdeDataType.Date),
        new JdeField("TTEXDT2", "TTEXDT2", JdeDataType.Date),
        new JdeField("TTEXDT3", "TTEXDT3", JdeDataType.Date),
        new JdeField("TTEXDT4", "TTEXDT4", JdeDataType.Date),
        new JdeField("TTSTSUDT", "TTSTSUDT", JdeDataType.Date),
        new JdeField("TTACTIND", "TTACTIND", JdeDataType.String, 2),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTVID", "TTVID", JdeDataType.String, 20),
        new JdeField("TTMKEY", "TTMKEY", JdeDataType.String, 30),
        new JdeField("TTUDTTM", "TTUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA020_0", "Primary Key on TTPSAN8, TTCNLNID", new[] { "TTPSAN8", "TTCNLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
