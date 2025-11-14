using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CC040 - .
/// </summary>
public class F90CC040 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMCMPID.
        /// </summary>
        public const string CMCMPID = "CMCMPID";

        /// <summary>
        /// CMCMPNAME.
        /// </summary>
        public const string CMCMPNAME = "CMCMPNAME";

        /// <summary>
        /// CMF4101ITM.
        /// </summary>
        public const string CMF4101ITM = "CMF4101ITM";

        /// <summary>
        /// CMOSTP.
        /// </summary>
        public const string CMOSTP = "CMOSTP";

        /// <summary>
        /// CMUKID.
        /// </summary>
        public const string CMUKID = "CMUKID";

        /// <summary>
        /// CMSTRTDATE.
        /// </summary>
        public const string CMSTRTDATE = "CMSTRTDATE";

        /// <summary>
        /// CMENDDAT.
        /// </summary>
        public const string CMENDDAT = "CMENDDAT";

        /// <summary>
        /// CMCMPBGT.
        /// </summary>
        public const string CMCMPBGT = "CMCMPBGT";

        /// <summary>
        /// CMCMPACT.
        /// </summary>
        public const string CMCMPACT = "CMCMPACT";

        /// <summary>
        /// CMCEMPAN8.
        /// </summary>
        public const string CMCEMPAN8 = "CMCEMPAN8";

        /// <summary>
        /// CMCMPTID.
        /// </summary>
        public const string CMCMPTID = "CMCMPTID";

        /// <summary>
        /// CMHASCHFLG.
        /// </summary>
        public const string CMHASCHFLG = "CMHASCHFLG";

        /// <summary>
        /// CMACTF0013.
        /// </summary>
        public const string CMACTF0013 = "CMACTF0013";

        /// <summary>
        /// CMBGTF0013.
        /// </summary>
        public const string CMBGTF0013 = "CMBGTF0013";

        /// <summary>
        /// CMEVTBGT.
        /// </summary>
        public const string CMEVTBGT = "CMEVTBGT";

        /// <summary>
        /// CMEBAF0013.
        /// </summary>
        public const string CMEBAF0013 = "CMEBAF0013";

        /// <summary>
        /// CMENTDBY.
        /// </summary>
        public const string CMENTDBY = "CMENTDBY";

        /// <summary>
        /// CMMODB.
        /// </summary>
        public const string CMMODB = "CMMODB";

        /// <summary>
        /// CMEDATE.
        /// </summary>
        public const string CMEDATE = "CMEDATE";

        /// <summary>
        /// CMMDATE.
        /// </summary>
        public const string CMMDATE = "CMMDATE";

        /// <summary>
        /// CMEXVAR0.
        /// </summary>
        public const string CMEXVAR0 = "CMEXVAR0";

        /// <summary>
        /// CMEXVAR1.
        /// </summary>
        public const string CMEXVAR1 = "CMEXVAR1";

        /// <summary>
        /// CMEXVAR2.
        /// </summary>
        public const string CMEXVAR2 = "CMEXVAR2";

        /// <summary>
        /// CMEXVAR3.
        /// </summary>
        public const string CMEXVAR3 = "CMEXVAR3";

        /// <summary>
        /// CMEXVAR4.
        /// </summary>
        public const string CMEXVAR4 = "CMEXVAR4";

        /// <summary>
        /// CMEXVAR5.
        /// </summary>
        public const string CMEXVAR5 = "CMEXVAR5";

        /// <summary>
        /// CMEXVAR6.
        /// </summary>
        public const string CMEXVAR6 = "CMEXVAR6";

        /// <summary>
        /// CMEXVAR7.
        /// </summary>
        public const string CMEXVAR7 = "CMEXVAR7";

        /// <summary>
        /// CMEXVAR8.
        /// </summary>
        public const string CMEXVAR8 = "CMEXVAR8";

        /// <summary>
        /// CMEXVAR9.
        /// </summary>
        public const string CMEXVAR9 = "CMEXVAR9";

        /// <summary>
        /// CMEXVAR10.
        /// </summary>
        public const string CMEXVAR10 = "CMEXVAR10";

        /// <summary>
        /// CMEXVAR11.
        /// </summary>
        public const string CMEXVAR11 = "CMEXVAR11";

        /// <summary>
        /// CMEXVAR12.
        /// </summary>
        public const string CMEXVAR12 = "CMEXVAR12";

        /// <summary>
        /// CMEXVAR13.
        /// </summary>
        public const string CMEXVAR13 = "CMEXVAR13";

        /// <summary>
        /// CMEXVAR14.
        /// </summary>
        public const string CMEXVAR14 = "CMEXVAR14";

        /// <summary>
        /// CMEXNM0.
        /// </summary>
        public const string CMEXNM0 = "CMEXNM0";

        /// <summary>
        /// CMEXNM1.
        /// </summary>
        public const string CMEXNM1 = "CMEXNM1";

        /// <summary>
        /// CMEXNM2.
        /// </summary>
        public const string CMEXNM2 = "CMEXNM2";

        /// <summary>
        /// CMEXNM3.
        /// </summary>
        public const string CMEXNM3 = "CMEXNM3";

        /// <summary>
        /// CMEXNM4.
        /// </summary>
        public const string CMEXNM4 = "CMEXNM4";

        /// <summary>
        /// CMEXNMP0.
        /// </summary>
        public const string CMEXNMP0 = "CMEXNMP0";

        /// <summary>
        /// CMEXNMP1.
        /// </summary>
        public const string CMEXNMP1 = "CMEXNMP1";

        /// <summary>
        /// CMEXNMP2.
        /// </summary>
        public const string CMEXNMP2 = "CMEXNMP2";

        /// <summary>
        /// CMEXNMP3.
        /// </summary>
        public const string CMEXNMP3 = "CMEXNMP3";

        /// <summary>
        /// CMEXNMP4.
        /// </summary>
        public const string CMEXNMP4 = "CMEXNMP4";

        /// <summary>
        /// CMEXDT0.
        /// </summary>
        public const string CMEXDT0 = "CMEXDT0";

        /// <summary>
        /// CMEXDT1.
        /// </summary>
        public const string CMEXDT1 = "CMEXDT1";

        /// <summary>
        /// CMEXDT2.
        /// </summary>
        public const string CMEXDT2 = "CMEXDT2";

        /// <summary>
        /// CMEXDT3.
        /// </summary>
        public const string CMEXDT3 = "CMEXDT3";

        /// <summary>
        /// CMEXDT4.
        /// </summary>
        public const string CMEXDT4 = "CMEXDT4";

        /// <summary>
        /// CMSTSUDT.
        /// </summary>
        public const string CMSTSUDT = "CMSTSUDT";

        /// <summary>
        /// CMACTIND.
        /// </summary>
        public const string CMACTIND = "CMACTIND";
    }

    /// <inheritdoc />
    public override string TableName => "F90CC040";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMCMPID", "CMCMPID", JdeDataType.Numeric, null, true, true),
        new JdeField("CMCMPNAME", "CMCMPNAME", JdeDataType.String, 100),
        new JdeField("CMF4101ITM", "CMF4101ITM", JdeDataType.Numeric),
        new JdeField("CMOSTP", "CMOSTP", JdeDataType.String, 6),
        new JdeField("CMUKID", "CMUKID", JdeDataType.Numeric),
        new JdeField("CMSTRTDATE", "CMSTRTDATE", JdeDataType.Date),
        new JdeField("CMENDDAT", "CMENDDAT", JdeDataType.Date),
        new JdeField("CMCMPBGT", "CMCMPBGT", JdeDataType.Numeric),
        new JdeField("CMCMPACT", "CMCMPACT", JdeDataType.Numeric),
        new JdeField("CMCEMPAN8", "CMCEMPAN8", JdeDataType.Numeric),
        new JdeField("CMCMPTID", "CMCMPTID", JdeDataType.Numeric),
        new JdeField("CMHASCHFLG", "CMHASCHFLG", JdeDataType.String, 2),
        new JdeField("CMACTF0013", "CMACTF0013", JdeDataType.String, 6),
        new JdeField("CMBGTF0013", "CMBGTF0013", JdeDataType.String, 6),
        new JdeField("CMEVTBGT", "CMEVTBGT", JdeDataType.Numeric),
        new JdeField("CMEBAF0013", "CMEBAF0013", JdeDataType.String, 6),
        new JdeField("CMENTDBY", "CMENTDBY", JdeDataType.Numeric),
        new JdeField("CMMODB", "CMMODB", JdeDataType.Numeric),
        new JdeField("CMEDATE", "CMEDATE", JdeDataType.Date),
        new JdeField("CMMDATE", "CMMDATE", JdeDataType.Date),
        new JdeField("CMEXVAR0", "CMEXVAR0", JdeDataType.String, 510),
        new JdeField("CMEXVAR1", "CMEXVAR1", JdeDataType.String, 510),
        new JdeField("CMEXVAR2", "CMEXVAR2", JdeDataType.String, 510),
        new JdeField("CMEXVAR3", "CMEXVAR3", JdeDataType.String, 510),
        new JdeField("CMEXVAR4", "CMEXVAR4", JdeDataType.String, 100),
        new JdeField("CMEXVAR5", "CMEXVAR5", JdeDataType.String, 100),
        new JdeField("CMEXVAR6", "CMEXVAR6", JdeDataType.String, 100),
        new JdeField("CMEXVAR7", "CMEXVAR7", JdeDataType.String, 100),
        new JdeField("CMEXVAR8", "CMEXVAR8", JdeDataType.String, 100),
        new JdeField("CMEXVAR9", "CMEXVAR9", JdeDataType.String, 100),
        new JdeField("CMEXVAR10", "CMEXVAR10", JdeDataType.String, 100),
        new JdeField("CMEXVAR11", "CMEXVAR11", JdeDataType.String, 100),
        new JdeField("CMEXVAR12", "CMEXVAR12", JdeDataType.String, 50),
        new JdeField("CMEXVAR13", "CMEXVAR13", JdeDataType.String, 50),
        new JdeField("CMEXVAR14", "CMEXVAR14", JdeDataType.String, 50),
        new JdeField("CMEXNM0", "CMEXNM0", JdeDataType.Numeric),
        new JdeField("CMEXNM1", "CMEXNM1", JdeDataType.Numeric),
        new JdeField("CMEXNM2", "CMEXNM2", JdeDataType.Numeric),
        new JdeField("CMEXNM3", "CMEXNM3", JdeDataType.Numeric),
        new JdeField("CMEXNM4", "CMEXNM4", JdeDataType.Numeric),
        new JdeField("CMEXNMP0", "CMEXNMP0", JdeDataType.Numeric),
        new JdeField("CMEXNMP1", "CMEXNMP1", JdeDataType.Numeric),
        new JdeField("CMEXNMP2", "CMEXNMP2", JdeDataType.Numeric),
        new JdeField("CMEXNMP3", "CMEXNMP3", JdeDataType.Numeric),
        new JdeField("CMEXNMP4", "CMEXNMP4", JdeDataType.Numeric),
        new JdeField("CMEXDT0", "CMEXDT0", JdeDataType.Date),
        new JdeField("CMEXDT1", "CMEXDT1", JdeDataType.Date),
        new JdeField("CMEXDT2", "CMEXDT2", JdeDataType.Date),
        new JdeField("CMEXDT3", "CMEXDT3", JdeDataType.Date),
        new JdeField("CMEXDT4", "CMEXDT4", JdeDataType.Date),
        new JdeField("CMSTSUDT", "CMSTSUDT", JdeDataType.Date),
        new JdeField("CMACTIND", "CMACTIND", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CC040_0", "Primary Key on CMCMPID", new[] { "CMCMPID" }, isUnique: true, isPrimaryKey: true)
    };
}
