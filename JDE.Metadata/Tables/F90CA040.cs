using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA040 - .
/// </summary>
public class F90CA040 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EEEMAN8.
        /// </summary>
        public const string EEEMAN8 = "EEEMAN8";

        /// <summary>
        /// EEENUM.
        /// </summary>
        public const string EEENUM = "EEENUM";

        /// <summary>
        /// EEDPTCD.
        /// </summary>
        public const string EEDPTCD = "EEDPTCD";

        /// <summary>
        /// EEACTIV.
        /// </summary>
        public const string EEACTIV = "EEACTIV";

        /// <summary>
        /// EEHDATE.
        /// </summary>
        public const string EEHDATE = "EEHDATE";

        /// <summary>
        /// EEEXTV.
        /// </summary>
        public const string EEEXTV = "EEEXTV";

        /// <summary>
        /// EEDPTCNT.
        /// </summary>
        public const string EEDPTCNT = "EEDPTCNT";

        /// <summary>
        /// EEAGTNO.
        /// </summary>
        public const string EEAGTNO = "EEAGTNO";

        /// <summary>
        /// EEISEF.
        /// </summary>
        public const string EEISEF = "EEISEF";

        /// <summary>
        /// EEENTDBY.
        /// </summary>
        public const string EEENTDBY = "EEENTDBY";

        /// <summary>
        /// EEEDATE.
        /// </summary>
        public const string EEEDATE = "EEEDATE";

        /// <summary>
        /// EEEXVAR0.
        /// </summary>
        public const string EEEXVAR0 = "EEEXVAR0";

        /// <summary>
        /// EEEXVAR1.
        /// </summary>
        public const string EEEXVAR1 = "EEEXVAR1";

        /// <summary>
        /// EEEXVAR2.
        /// </summary>
        public const string EEEXVAR2 = "EEEXVAR2";

        /// <summary>
        /// EEEXVAR3.
        /// </summary>
        public const string EEEXVAR3 = "EEEXVAR3";

        /// <summary>
        /// EEEXVAR4.
        /// </summary>
        public const string EEEXVAR4 = "EEEXVAR4";

        /// <summary>
        /// EEEXVAR5.
        /// </summary>
        public const string EEEXVAR5 = "EEEXVAR5";

        /// <summary>
        /// EEEXVAR6.
        /// </summary>
        public const string EEEXVAR6 = "EEEXVAR6";

        /// <summary>
        /// EEEXVAR7.
        /// </summary>
        public const string EEEXVAR7 = "EEEXVAR7";

        /// <summary>
        /// EEEXVAR8.
        /// </summary>
        public const string EEEXVAR8 = "EEEXVAR8";

        /// <summary>
        /// EEEXVAR9.
        /// </summary>
        public const string EEEXVAR9 = "EEEXVAR9";

        /// <summary>
        /// EEEXVAR10.
        /// </summary>
        public const string EEEXVAR10 = "EEEXVAR10";

        /// <summary>
        /// EEEXVAR11.
        /// </summary>
        public const string EEEXVAR11 = "EEEXVAR11";

        /// <summary>
        /// EEEXVAR12.
        /// </summary>
        public const string EEEXVAR12 = "EEEXVAR12";

        /// <summary>
        /// EEEXVAR13.
        /// </summary>
        public const string EEEXVAR13 = "EEEXVAR13";

        /// <summary>
        /// EEEXVAR14.
        /// </summary>
        public const string EEEXVAR14 = "EEEXVAR14";

        /// <summary>
        /// EEEXNM0.
        /// </summary>
        public const string EEEXNM0 = "EEEXNM0";

        /// <summary>
        /// EEEXNM1.
        /// </summary>
        public const string EEEXNM1 = "EEEXNM1";

        /// <summary>
        /// EEEXNM2.
        /// </summary>
        public const string EEEXNM2 = "EEEXNM2";

        /// <summary>
        /// EEEXNM3.
        /// </summary>
        public const string EEEXNM3 = "EEEXNM3";

        /// <summary>
        /// EEEXNM4.
        /// </summary>
        public const string EEEXNM4 = "EEEXNM4";

        /// <summary>
        /// EEEXNMP0.
        /// </summary>
        public const string EEEXNMP0 = "EEEXNMP0";

        /// <summary>
        /// EEEXNMP1.
        /// </summary>
        public const string EEEXNMP1 = "EEEXNMP1";

        /// <summary>
        /// EEEXNMP2.
        /// </summary>
        public const string EEEXNMP2 = "EEEXNMP2";

        /// <summary>
        /// EEEXNMP3.
        /// </summary>
        public const string EEEXNMP3 = "EEEXNMP3";

        /// <summary>
        /// EEEXNMP4.
        /// </summary>
        public const string EEEXNMP4 = "EEEXNMP4";

        /// <summary>
        /// EEEXDT0.
        /// </summary>
        public const string EEEXDT0 = "EEEXDT0";

        /// <summary>
        /// EEEXDT1.
        /// </summary>
        public const string EEEXDT1 = "EEEXDT1";

        /// <summary>
        /// EEEXDT2.
        /// </summary>
        public const string EEEXDT2 = "EEEXDT2";

        /// <summary>
        /// EEEXDT3.
        /// </summary>
        public const string EEEXDT3 = "EEEXDT3";

        /// <summary>
        /// EEEXDT4.
        /// </summary>
        public const string EEEXDT4 = "EEEXDT4";

        /// <summary>
        /// EESTSUDT.
        /// </summary>
        public const string EESTSUDT = "EESTSUDT";

        /// <summary>
        /// EEACTIND.
        /// </summary>
        public const string EEACTIND = "EEACTIND";

        /// <summary>
        /// EEUSER.
        /// </summary>
        public const string EEUSER = "EEUSER";

        /// <summary>
        /// EEPID.
        /// </summary>
        public const string EEPID = "EEPID";

        /// <summary>
        /// EEVID.
        /// </summary>
        public const string EEVID = "EEVID";

        /// <summary>
        /// EEMKEY.
        /// </summary>
        public const string EEMKEY = "EEMKEY";

        /// <summary>
        /// EEUDTTM.
        /// </summary>
        public const string EEUDTTM = "EEUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA040";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EEEMAN8", "EEEMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EEENUM", "EEENUM", JdeDataType.String, 40),
        new JdeField("EEDPTCD", "EEDPTCD", JdeDataType.String, 10),
        new JdeField("EEACTIV", "EEACTIV", JdeDataType.String, 2),
        new JdeField("EEHDATE", "EEHDATE", JdeDataType.Date),
        new JdeField("EEEXTV", "EEEXTV", JdeDataType.String, 2),
        new JdeField("EEDPTCNT", "EEDPTCNT", JdeDataType.String, 2),
        new JdeField("EEAGTNO", "EEAGTNO", JdeDataType.Numeric),
        new JdeField("EEISEF", "EEISEF", JdeDataType.String, 2),
        new JdeField("EEENTDBY", "EEENTDBY", JdeDataType.Numeric),
        new JdeField("EEEDATE", "EEEDATE", JdeDataType.Date),
        new JdeField("EEEXVAR0", "EEEXVAR0", JdeDataType.String, 510),
        new JdeField("EEEXVAR1", "EEEXVAR1", JdeDataType.String, 510),
        new JdeField("EEEXVAR2", "EEEXVAR2", JdeDataType.String, 510),
        new JdeField("EEEXVAR3", "EEEXVAR3", JdeDataType.String, 510),
        new JdeField("EEEXVAR4", "EEEXVAR4", JdeDataType.String, 100),
        new JdeField("EEEXVAR5", "EEEXVAR5", JdeDataType.String, 100),
        new JdeField("EEEXVAR6", "EEEXVAR6", JdeDataType.String, 100),
        new JdeField("EEEXVAR7", "EEEXVAR7", JdeDataType.String, 100),
        new JdeField("EEEXVAR8", "EEEXVAR8", JdeDataType.String, 100),
        new JdeField("EEEXVAR9", "EEEXVAR9", JdeDataType.String, 100),
        new JdeField("EEEXVAR10", "EEEXVAR10", JdeDataType.String, 100),
        new JdeField("EEEXVAR11", "EEEXVAR11", JdeDataType.String, 100),
        new JdeField("EEEXVAR12", "EEEXVAR12", JdeDataType.String, 50),
        new JdeField("EEEXVAR13", "EEEXVAR13", JdeDataType.String, 50),
        new JdeField("EEEXVAR14", "EEEXVAR14", JdeDataType.String, 50),
        new JdeField("EEEXNM0", "EEEXNM0", JdeDataType.Numeric),
        new JdeField("EEEXNM1", "EEEXNM1", JdeDataType.Numeric),
        new JdeField("EEEXNM2", "EEEXNM2", JdeDataType.Numeric),
        new JdeField("EEEXNM3", "EEEXNM3", JdeDataType.Numeric),
        new JdeField("EEEXNM4", "EEEXNM4", JdeDataType.Numeric),
        new JdeField("EEEXNMP0", "EEEXNMP0", JdeDataType.Numeric),
        new JdeField("EEEXNMP1", "EEEXNMP1", JdeDataType.Numeric),
        new JdeField("EEEXNMP2", "EEEXNMP2", JdeDataType.Numeric),
        new JdeField("EEEXNMP3", "EEEXNMP3", JdeDataType.Numeric),
        new JdeField("EEEXNMP4", "EEEXNMP4", JdeDataType.Numeric),
        new JdeField("EEEXDT0", "EEEXDT0", JdeDataType.Date),
        new JdeField("EEEXDT1", "EEEXDT1", JdeDataType.Date),
        new JdeField("EEEXDT2", "EEEXDT2", JdeDataType.Date),
        new JdeField("EEEXDT3", "EEEXDT3", JdeDataType.Date),
        new JdeField("EEEXDT4", "EEEXDT4", JdeDataType.Date),
        new JdeField("EESTSUDT", "EESTSUDT", JdeDataType.Date),
        new JdeField("EEACTIND", "EEACTIND", JdeDataType.String, 2),
        new JdeField("EEUSER", "EEUSER", JdeDataType.String, 20),
        new JdeField("EEPID", "EEPID", JdeDataType.String, 20),
        new JdeField("EEVID", "EEVID", JdeDataType.String, 20),
        new JdeField("EEMKEY", "EEMKEY", JdeDataType.String, 30),
        new JdeField("EEUDTTM", "EEUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA040_0", "Primary Key on EEEMAN8", new[] { "EEEMAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA040_2", "Index on EEDPTCD, EEDPTCNT", new[] { "EEDPTCD", "EEDPTCNT" })
    };
}
