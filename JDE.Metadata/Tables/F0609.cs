using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0609 - .
/// </summary>
public class F0609 : JdeTable
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
    }

    /// <inheritdoc />
    public override string TableName => "F0609";

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
        new JdeField("Y$CPE", "Y$CPE", JdeDataType.Numeric),
        new JdeField("Y$DISO", "Y$DISO", JdeDataType.String, 2),
        new JdeField("Y$RTAM", "Y$RTAM", JdeDataType.Numeric),
        new JdeField("Y$DEDM", "Y$DEDM", JdeDataType.String, 2),
        new JdeField("Y$HMCO", "Y$HMCO", JdeDataType.String, 10),
        new JdeField("Y$GPA", "Y$GPA", JdeDataType.Numeric),
        new JdeField("Y$ARRA", "Y$ARRA", JdeDataType.Numeric),
        new JdeField("Y$PHRW", "Y$PHRW", JdeDataType.Numeric),
        new JdeField("Y$MCUG", "Y$MCUG", JdeDataType.String, 24),
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
        new JdeField("Y$CALC", "Y$CALC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0609_0", "Primary Key on Y$AN8, Y$CKCN, Y$PPED, Y$PDBA", new[] { "Y$AN8", "Y$CKCN", "Y$PPED", "Y$PDBA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0609_2", "Index on Y$AN8, Y$USR, Y$PDBA, Y$WST", new[] { "Y$AN8", "Y$USR", "Y$PDBA", "Y$WST" }),
        new JdeIndex("F0609_3", "Index on Y$AN8, Y$PCK, Y$CKCN", new[] { "Y$AN8", "Y$PCK", "Y$CKCN" }),
        new JdeIndex("F0609_4", "Index on Y$AN8, Y$CKCN, Y$DWK, Y$PDBA", new[] { "Y$AN8", "Y$CKCN", "Y$DWK", "Y$PDBA" }),
        new JdeIndex("F0609_5", "Index on Y$GICU", new[] { "Y$GICU" }),
        new JdeIndex("F0609_6", "Index on Y$AN8, Y$DWK", new[] { "Y$AN8", "Y$DWK" }),
        new JdeIndex("F0609_7", "Index on Y$AN8, Y$CKCN, Y$PDBA", new[] { "Y$AN8", "Y$CKCN", "Y$PDBA" }),
        new JdeIndex("F0609_8", "Index on Y$AN8, Y$PDBA", new[] { "Y$AN8", "Y$PDBA" }),
        new JdeIndex("F0609_9", "Index on Y$USR, Y$AN8, Y$PDBA, Y$PGRP", new[] { "Y$USR", "Y$AN8", "Y$PDBA", "Y$PGRP" })
    };
}
