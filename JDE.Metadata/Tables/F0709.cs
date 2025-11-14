using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0709 - .
/// </summary>
public class F0709 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y$AN8.
        /// </summary>
        public const string Y_AN8 = "Y$AN8";

        /// <summary>
        /// Y$CKCN.
        /// </summary>
        public const string Y_CKCN = "Y$CKCN";

        /// <summary>
        /// Y$HMO.
        /// </summary>
        public const string Y_HMO = "Y$HMO";

        /// <summary>
        /// Y$DWK.
        /// </summary>
        public const string Y_DWK = "Y$DWK";

        /// <summary>
        /// Y$PPED.
        /// </summary>
        public const string Y_PPED = "Y$PPED";

        /// <summary>
        /// Y$CKDT.
        /// </summary>
        public const string Y_CKDT = "Y$CKDT";

        /// <summary>
        /// Y$PDBA.
        /// </summary>
        public const string Y_PDBA = "Y$PDBA";

        /// <summary>
        /// Y$UKID.
        /// </summary>
        public const string Y_UKID = "Y$UKID";

        /// <summary>
        /// Y$PRTR.
        /// </summary>
        public const string Y_PRTR = "Y$PRTR";

        /// <summary>
        /// Y$CPE.
        /// </summary>
        public const string Y_CPE = "Y$CPE";

        /// <summary>
        /// Y$DISO.
        /// </summary>
        public const string Y_DISO = "Y$DISO";

        /// <summary>
        /// Y$RTAM.
        /// </summary>
        public const string Y_RTAM = "Y$RTAM";

        /// <summary>
        /// Y$DEDM.
        /// </summary>
        public const string Y_DEDM = "Y$DEDM";

        /// <summary>
        /// Y$HMCO.
        /// </summary>
        public const string Y_HMCO = "Y$HMCO";

        /// <summary>
        /// Y$TAXX.
        /// </summary>
        public const string Y_TAXX = "Y$TAXX";

        /// <summary>
        /// Y$GPA.
        /// </summary>
        public const string Y_GPA = "Y$GPA";

        /// <summary>
        /// Y$ARRA.
        /// </summary>
        public const string Y_ARRA = "Y$ARRA";

        /// <summary>
        /// Y$PHRW.
        /// </summary>
        public const string Y_PHRW = "Y$PHRW";

        /// <summary>
        /// Y$MCUG.
        /// </summary>
        public const string Y_MCUG = "Y$MCUG";

        /// <summary>
        /// Y$CMHU.
        /// </summary>
        public const string Y_CMHU = "Y$CMHU";

        /// <summary>
        /// Y$CLBS.
        /// </summary>
        public const string Y_CLBS = "Y$CLBS";

        /// <summary>
        /// Y$UN.
        /// </summary>
        public const string Y_UN = "Y$UN";

        /// <summary>
        /// Y$JBCD.
        /// </summary>
        public const string Y_JBCD = "Y$JBCD";

        /// <summary>
        /// Y$JBST.
        /// </summary>
        public const string Y_JBST = "Y$JBST";

        /// <summary>
        /// Y$WST.
        /// </summary>
        public const string Y_WST = "Y$WST";

        /// <summary>
        /// Y$WCNT.
        /// </summary>
        public const string Y_WCNT = "Y$WCNT";

        /// <summary>
        /// Y$WCTY.
        /// </summary>
        public const string Y_WCTY = "Y$WCTY";

        /// <summary>
        /// Y$ANN8.
        /// </summary>
        public const string Y_ANN8 = "Y$ANN8";

        /// <summary>
        /// Y$WCMP.
        /// </summary>
        public const string Y_WCMP = "Y$WCMP";

        /// <summary>
        /// Y$WET.
        /// </summary>
        public const string Y_WET = "Y$WET";

        /// <summary>
        /// Y$PGRP.
        /// </summary>
        public const string Y_PGRP = "Y$PGRP";

        /// <summary>
        /// Y$MV.
        /// </summary>
        public const string Y_MV = "Y$MV";

        /// <summary>
        /// Y$ICC.
        /// </summary>
        public const string Y_ICC = "Y$ICC";

        /// <summary>
        /// Y$ICS.
        /// </summary>
        public const string Y_ICS = "Y$ICS";

        /// <summary>
        /// Y$USR.
        /// </summary>
        public const string Y_USR = "Y$USR";

        /// <summary>
        /// Y$DAAF.
        /// </summary>
        public const string Y_DAAF = "Y$DAAF";

        /// <summary>
        /// Y$DTSP.
        /// </summary>
        public const string Y_DTSP = "Y$DTSP";

        /// <summary>
        /// Y$PCK.
        /// </summary>
        public const string Y_PCK = "Y$PCK";

        /// <summary>
        /// Y$YST.
        /// </summary>
        public const string Y_YST = "Y$YST";

        /// <summary>
        /// Y$GICU.
        /// </summary>
        public const string Y_GICU = "Y$GICU";

        /// <summary>
        /// Y$CMMT.
        /// </summary>
        public const string Y_CMMT = "Y$CMMT";

        /// <summary>
        /// Y$PCNO.
        /// </summary>
        public const string Y_PCNO = "Y$PCNO";

        /// <summary>
        /// Y$PALF.
        /// </summary>
        public const string Y_PALF = "Y$PALF";

        /// <summary>
        /// Y$GVCH.
        /// </summary>
        public const string Y_GVCH = "Y$GVCH";

        /// <summary>
        /// Y$WANO.
        /// </summary>
        public const string Y_WANO = "Y$WANO";

        /// <summary>
        /// Y$CALC.
        /// </summary>
        public const string Y_CALC = "Y$CALC";

        /// <summary>
        /// Y$DPRI.
        /// </summary>
        public const string Y_DPRI = "Y$DPRI";

        /// <summary>
        /// Y$EPRI.
        /// </summary>
        public const string Y_EPRI = "Y$EPRI";

        /// <summary>
        /// Y$ARRR.
        /// </summary>
        public const string Y_ARRR = "Y$ARRR";

        /// <summary>
        /// Y$DLVL.
        /// </summary>
        public const string Y_DLVL = "Y$DLVL";

        /// <summary>
        /// Y$TDBA.
        /// </summary>
        public const string Y_TDBA = "Y$TDBA";

        /// <summary>
        /// Y$UPMJ.
        /// </summary>
        public const string Y_UPMJ = "Y$UPMJ";

        /// <summary>
        /// Y$UPMT.
        /// </summary>
        public const string Y_UPMT = "Y$UPMT";

        /// <summary>
        /// Y$PID.
        /// </summary>
        public const string Y_PID = "Y$PID";

        /// <summary>
        /// Y$JOBN.
        /// </summary>
        public const string Y_JOBN = "Y$JOBN";

        /// <summary>
        /// Y$USER.
        /// </summary>
        public const string Y_USER = "Y$USER";

        /// <summary>
        /// Y$TCFD.
        /// </summary>
        public const string Y_TCFD = "Y$TCFD";

        /// <summary>
        /// Y$TCTD.
        /// </summary>
        public const string Y_TCTD = "Y$TCTD";

        /// <summary>
        /// Y$AUBP.
        /// </summary>
        public const string Y_AUBP = "Y$AUBP";
    }

    /// <inheritdoc />
    public override string TableName => "F0709";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y$AN8", "Y$AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y$CKCN", "Y$CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y$HMO", "Y$HMO", JdeDataType.Numeric),
        new JdeField("Y$DWK", "Y$DWK", JdeDataType.Numeric),
        new JdeField("Y$PPED", "Y$PPED", JdeDataType.Numeric, null, true, true),
        new JdeField("Y$CKDT", "Y$CKDT", JdeDataType.Numeric),
        new JdeField("Y$PDBA", "Y$PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Y$UKID", "Y$UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("Y$PRTR", "Y$PRTR", JdeDataType.Numeric),
        new JdeField("Y$CPE", "Y$CPE", JdeDataType.Numeric),
        new JdeField("Y$DISO", "Y$DISO", JdeDataType.String, 2),
        new JdeField("Y$RTAM", "Y$RTAM", JdeDataType.Numeric),
        new JdeField("Y$DEDM", "Y$DEDM", JdeDataType.String, 2),
        new JdeField("Y$HMCO", "Y$HMCO", JdeDataType.String, 10),
        new JdeField("Y$TAXX", "Y$TAXX", JdeDataType.String, 40),
        new JdeField("Y$GPA", "Y$GPA", JdeDataType.Numeric),
        new JdeField("Y$ARRA", "Y$ARRA", JdeDataType.Numeric),
        new JdeField("Y$PHRW", "Y$PHRW", JdeDataType.Numeric),
        new JdeField("Y$MCUG", "Y$MCUG", JdeDataType.String, 24),
        new JdeField("Y$CMHU", "Y$CMHU", JdeDataType.String, 2),
        new JdeField("Y$CLBS", "Y$CLBS", JdeDataType.Numeric),
        new JdeField("Y$UN", "Y$UN", JdeDataType.String, 12),
        new JdeField("Y$JBCD", "Y$JBCD", JdeDataType.String, 12),
        new JdeField("Y$JBST", "Y$JBST", JdeDataType.String, 8),
        new JdeField("Y$WST", "Y$WST", JdeDataType.Numeric),
        new JdeField("Y$WCNT", "Y$WCNT", JdeDataType.Numeric),
        new JdeField("Y$WCTY", "Y$WCTY", JdeDataType.Numeric),
        new JdeField("Y$ANN8", "Y$ANN8", JdeDataType.Numeric),
        new JdeField("Y$WCMP", "Y$WCMP", JdeDataType.String, 8),
        new JdeField("Y$WET", "Y$WET", JdeDataType.String, 2),
        new JdeField("Y$PGRP", "Y$PGRP", JdeDataType.String, 4),
        new JdeField("Y$MV", "Y$MV", JdeDataType.String, 2),
        new JdeField("Y$ICC", "Y$ICC", JdeDataType.String, 2),
        new JdeField("Y$ICS", "Y$ICS", JdeDataType.String, 2),
        new JdeField("Y$USR", "Y$USR", JdeDataType.String, 36),
        new JdeField("Y$DAAF", "Y$DAAF", JdeDataType.String, 2),
        new JdeField("Y$DTSP", "Y$DTSP", JdeDataType.Numeric),
        new JdeField("Y$PCK", "Y$PCK", JdeDataType.String, 2),
        new JdeField("Y$YST", "Y$YST", JdeDataType.String, 2),
        new JdeField("Y$GICU", "Y$GICU", JdeDataType.Numeric),
        new JdeField("Y$CMMT", "Y$CMMT", JdeDataType.String, 2),
        new JdeField("Y$PCNO", "Y$PCNO", JdeDataType.Numeric),
        new JdeField("Y$PALF", "Y$PALF", JdeDataType.String, 24),
        new JdeField("Y$GVCH", "Y$GVCH", JdeDataType.String, 2),
        new JdeField("Y$WANO", "Y$WANO", JdeDataType.Numeric),
        new JdeField("Y$CALC", "Y$CALC", JdeDataType.String, 2),
        new JdeField("Y$DPRI", "Y$DPRI", JdeDataType.Numeric),
        new JdeField("Y$EPRI", "Y$EPRI", JdeDataType.String, 2),
        new JdeField("Y$ARRR", "Y$ARRR", JdeDataType.String, 2),
        new JdeField("Y$DLVL", "Y$DLVL", JdeDataType.String, 2),
        new JdeField("Y$TDBA", "Y$TDBA", JdeDataType.String, 2),
        new JdeField("Y$UPMJ", "Y$UPMJ", JdeDataType.Numeric),
        new JdeField("Y$UPMT", "Y$UPMT", JdeDataType.Numeric),
        new JdeField("Y$PID", "Y$PID", JdeDataType.String, 20),
        new JdeField("Y$JOBN", "Y$JOBN", JdeDataType.String, 20),
        new JdeField("Y$USER", "Y$USER", JdeDataType.String, 20),
        new JdeField("Y$TCFD", "Y$TCFD", JdeDataType.Numeric),
        new JdeField("Y$TCTD", "Y$TCTD", JdeDataType.Numeric),
        new JdeField("Y$AUBP", "Y$AUBP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0709_0", "Primary Key on Y$AN8, Y$CKCN, Y$PPED, Y$PDBA, Y$UKID", new[] { "Y$AN8", "Y$CKCN", "Y$PPED", "Y$PDBA", "Y$UKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0709_10", "Index on Y$CKCN, Y$AN8, Y$PDBA", new[] { "Y$CKCN", "Y$AN8", "Y$PDBA" }),
        new JdeIndex("F0709_11", "Index on Y$AN8, Y$PDBA, Y$DPRI", new[] { "Y$AN8", "Y$PDBA", "Y$DPRI" }),
        new JdeIndex("F0709_12", "Index on Y$AN8, Y$CKCN, SYS_NC00060$, SYS_NC00061$", new[] { "Y$AN8", "Y$CKCN", "SYS_NC00060$", "SYS_NC00061$" }),
        new JdeIndex("F0709_13", "Index on Y$USR, Y$ANN8", new[] { "Y$USR", "Y$ANN8" }),
        new JdeIndex("F0709_14", "Index on Y$AN8, Y$PDBA, Y$TAXX", new[] { "Y$AN8", "Y$PDBA", "Y$TAXX" }),
        new JdeIndex("F0709_15", "Index on Y$AN8, Y$CKCN, Y$PGRP, Y$PDBA", new[] { "Y$AN8", "Y$CKCN", "Y$PGRP", "Y$PDBA" }),
        new JdeIndex("F0709_16", "Index on Y$AN8, Y$CKCN, Y$DISO", new[] { "Y$AN8", "Y$CKCN", "Y$DISO" }),
        new JdeIndex("F0709_2", "Index on Y$AN8, Y$PDBA", new[] { "Y$AN8", "Y$PDBA" }),
        new JdeIndex("F0709_3", "Index on Y$AN8, Y$PRTR", new[] { "Y$AN8", "Y$PRTR" }),
        new JdeIndex("F0709_4", "Index on Y$AN8, Y$CKCN, Y$PRTR", new[] { "Y$AN8", "Y$CKCN", "Y$PRTR" }),
        new JdeIndex("F0709_5", "Index on Y$AN8, Y$CKCN, Y$PRTR, Y$PDBA, Y$WST", new[] { "Y$AN8", "Y$CKCN", "Y$PRTR", "Y$PDBA", "Y$WST" }),
        new JdeIndex("F0709_6", "Index on Y$AN8, Y$CKCN, Y$PDBA, Y$DWK", new[] { "Y$AN8", "Y$CKCN", "Y$PDBA", "Y$DWK" }),
        new JdeIndex("F0709_8", "Index on Y$GICU", new[] { "Y$GICU" }),
        new JdeIndex("F0709_9", "Index on Y$AN8, Y$DWK", new[] { "Y$AN8", "Y$DWK" })
    };
}
