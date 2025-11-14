using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470472 - .
/// </summary>
public class F470472 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S6EDTY.
        /// </summary>
        public const string S6EDTY = "S6EDTY";

        /// <summary>
        /// S6EDSQ.
        /// </summary>
        public const string S6EDSQ = "S6EDSQ";

        /// <summary>
        /// S6EKCO.
        /// </summary>
        public const string S6EKCO = "S6EKCO";

        /// <summary>
        /// S6EDOC.
        /// </summary>
        public const string S6EDOC = "S6EDOC";

        /// <summary>
        /// S6EDCT.
        /// </summary>
        public const string S6EDCT = "S6EDCT";

        /// <summary>
        /// S6EDLN.
        /// </summary>
        public const string S6EDLN = "S6EDLN";

        /// <summary>
        /// S6EDSP.
        /// </summary>
        public const string S6EDSP = "S6EDSP";

        /// <summary>
        /// S6EDBT.
        /// </summary>
        public const string S6EDBT = "S6EDBT";

        /// <summary>
        /// S6SHAN.
        /// </summary>
        public const string S6SHAN = "S6SHAN";

        /// <summary>
        /// S6ALPH.
        /// </summary>
        public const string S6ALPH = "S6ALPH";

        /// <summary>
        /// S6CARS.
        /// </summary>
        public const string S6CARS = "S6CARS";

        /// <summary>
        /// S6SHPN.
        /// </summary>
        public const string S6SHPN = "S6SHPN";

        /// <summary>
        /// S6DEID.
        /// </summary>
        public const string S6DEID = "S6DEID";

        /// <summary>
        /// S6CIRV.
        /// </summary>
        public const string S6CIRV = "S6CIRV";

        /// <summary>
        /// S6CITM.
        /// </summary>
        public const string S6CITM = "S6CITM";

        /// <summary>
        /// S6SCAC.
        /// </summary>
        public const string S6SCAC = "S6SCAC";

        /// <summary>
        /// S6ORIG.
        /// </summary>
        public const string S6ORIG = "S6ORIG";

        /// <summary>
        /// S6DLDT.
        /// </summary>
        public const string S6DLDT = "S6DLDT";

        /// <summary>
        /// S6DLTM.
        /// </summary>
        public const string S6DLTM = "S6DLTM";

        /// <summary>
        /// S6NPCS.
        /// </summary>
        public const string S6NPCS = "S6NPCS";

        /// <summary>
        /// S6CBNK.
        /// </summary>
        public const string S6CBNK = "S6CBNK";

        /// <summary>
        /// S6ETRSC.
        /// </summary>
        public const string S6ETRSC = "S6ETRSC";

        /// <summary>
        /// S6ETRC.
        /// </summary>
        public const string S6ETRC = "S6ETRC";

        /// <summary>
        /// S6AETC.
        /// </summary>
        public const string S6AETC = "S6AETC";

        /// <summary>
        /// S6DKID.
        /// </summary>
        public const string S6DKID = "S6DKID";

        /// <summary>
        /// S6RFQ1.
        /// </summary>
        public const string S6RFQ1 = "S6RFQ1";

        /// <summary>
        /// S6RFQ2.
        /// </summary>
        public const string S6RFQ2 = "S6RFQ2";

        /// <summary>
        /// S6RFQ3.
        /// </summary>
        public const string S6RFQ3 = "S6RFQ3";

        /// <summary>
        /// S6RFQ4.
        /// </summary>
        public const string S6RFQ4 = "S6RFQ4";

        /// <summary>
        /// S6RFQ5.
        /// </summary>
        public const string S6RFQ5 = "S6RFQ5";

        /// <summary>
        /// S6RF1.
        /// </summary>
        public const string S6RF1 = "S6RF1";

        /// <summary>
        /// S6RF2.
        /// </summary>
        public const string S6RF2 = "S6RF2";

        /// <summary>
        /// S6RF3.
        /// </summary>
        public const string S6RF3 = "S6RF3";

        /// <summary>
        /// S6RF4.
        /// </summary>
        public const string S6RF4 = "S6RF4";

        /// <summary>
        /// S6RF5.
        /// </summary>
        public const string S6RF5 = "S6RF5";

        /// <summary>
        /// S6PRTY1.
        /// </summary>
        public const string S6PRTY1 = "S6PRTY1";

        /// <summary>
        /// S6PRTY2.
        /// </summary>
        public const string S6PRTY2 = "S6PRTY2";

        /// <summary>
        /// S6PRTY3.
        /// </summary>
        public const string S6PRTY3 = "S6PRTY3";

        /// <summary>
        /// S6PRTY4.
        /// </summary>
        public const string S6PRTY4 = "S6PRTY4";

        /// <summary>
        /// S6PRTY5.
        /// </summary>
        public const string S6PRTY5 = "S6PRTY5";

        /// <summary>
        /// S6PRNA1.
        /// </summary>
        public const string S6PRNA1 = "S6PRNA1";

        /// <summary>
        /// S6PRNA2.
        /// </summary>
        public const string S6PRNA2 = "S6PRNA2";

        /// <summary>
        /// S6PRNA3.
        /// </summary>
        public const string S6PRNA3 = "S6PRNA3";

        /// <summary>
        /// S6PRNA4.
        /// </summary>
        public const string S6PRNA4 = "S6PRNA4";

        /// <summary>
        /// S6PRNA5.
        /// </summary>
        public const string S6PRNA5 = "S6PRNA5";

        /// <summary>
        /// S6IDTYP1.
        /// </summary>
        public const string S6IDTYP1 = "S6IDTYP1";

        /// <summary>
        /// S6IDTYP2.
        /// </summary>
        public const string S6IDTYP2 = "S6IDTYP2";

        /// <summary>
        /// S6IDTYP3.
        /// </summary>
        public const string S6IDTYP3 = "S6IDTYP3";

        /// <summary>
        /// S6IDTYP4.
        /// </summary>
        public const string S6IDTYP4 = "S6IDTYP4";

        /// <summary>
        /// S6IDTYP5.
        /// </summary>
        public const string S6IDTYP5 = "S6IDTYP5";

        /// <summary>
        /// S6IDNUM1.
        /// </summary>
        public const string S6IDNUM1 = "S6IDNUM1";

        /// <summary>
        /// S6IDNUM2.
        /// </summary>
        public const string S6IDNUM2 = "S6IDNUM2";

        /// <summary>
        /// S6IDNUM3.
        /// </summary>
        public const string S6IDNUM3 = "S6IDNUM3";

        /// <summary>
        /// S6IDNUM4.
        /// </summary>
        public const string S6IDNUM4 = "S6IDNUM4";

        /// <summary>
        /// S6IDNUM5.
        /// </summary>
        public const string S6IDNUM5 = "S6IDNUM5";

        /// <summary>
        /// S6RFTY1.
        /// </summary>
        public const string S6RFTY1 = "S6RFTY1";

        /// <summary>
        /// S6RFTY2.
        /// </summary>
        public const string S6RFTY2 = "S6RFTY2";

        /// <summary>
        /// S6RFTY3.
        /// </summary>
        public const string S6RFTY3 = "S6RFTY3";

        /// <summary>
        /// S6RFTY4.
        /// </summary>
        public const string S6RFTY4 = "S6RFTY4";

        /// <summary>
        /// S6RFTY5.
        /// </summary>
        public const string S6RFTY5 = "S6RFTY5";

        /// <summary>
        /// S6RFNUM1.
        /// </summary>
        public const string S6RFNUM1 = "S6RFNUM1";

        /// <summary>
        /// S6RFNUM2.
        /// </summary>
        public const string S6RFNUM2 = "S6RFNUM2";

        /// <summary>
        /// S6RFNUM3.
        /// </summary>
        public const string S6RFNUM3 = "S6RFNUM3";

        /// <summary>
        /// S6RFNUM4.
        /// </summary>
        public const string S6RFNUM4 = "S6RFNUM4";

        /// <summary>
        /// S6RFNUM5.
        /// </summary>
        public const string S6RFNUM5 = "S6RFNUM5";

        /// <summary>
        /// S6FUT1.
        /// </summary>
        public const string S6FUT1 = "S6FUT1";

        /// <summary>
        /// S6FUT2.
        /// </summary>
        public const string S6FUT2 = "S6FUT2";

        /// <summary>
        /// S6FUT4.
        /// </summary>
        public const string S6FUT4 = "S6FUT4";

        /// <summary>
        /// S6FUT5.
        /// </summary>
        public const string S6FUT5 = "S6FUT5";

        /// <summary>
        /// S6X1.
        /// </summary>
        public const string S6X1 = "S6X1";

        /// <summary>
        /// S6X2.
        /// </summary>
        public const string S6X2 = "S6X2";

        /// <summary>
        /// S6D1FU.
        /// </summary>
        public const string S6D1FU = "S6D1FU";

        /// <summary>
        /// S6D2FU.
        /// </summary>
        public const string S6D2FU = "S6D2FU";

        /// <summary>
        /// S6TORG.
        /// </summary>
        public const string S6TORG = "S6TORG";

        /// <summary>
        /// S6USER.
        /// </summary>
        public const string S6USER = "S6USER";

        /// <summary>
        /// S6PID.
        /// </summary>
        public const string S6PID = "S6PID";

        /// <summary>
        /// S6JOBN.
        /// </summary>
        public const string S6JOBN = "S6JOBN";

        /// <summary>
        /// S6UPMJ.
        /// </summary>
        public const string S6UPMJ = "S6UPMJ";

        /// <summary>
        /// S6UPMT.
        /// </summary>
        public const string S6UPMT = "S6UPMT";

        /// <summary>
        /// S6JOBSQ.
        /// </summary>
        public const string S6JOBSQ = "S6JOBSQ";

        /// <summary>
        /// S6PSJOBNO.
        /// </summary>
        public const string S6PSJOBNO = "S6PSJOBNO";

        /// <summary>
        /// S6CARDNO.
        /// </summary>
        public const string S6CARDNO = "S6CARDNO";

        /// <summary>
        /// S6CIRVQ.
        /// </summary>
        public const string S6CIRVQ = "S6CIRVQ";

        /// <summary>
        /// S6GSHAN.
        /// </summary>
        public const string S6GSHAN = "S6GSHAN";

        /// <summary>
        /// S6GCARS.
        /// </summary>
        public const string S6GCARS = "S6GCARS";
    }

    /// <inheritdoc />
    public override string TableName => "F470472";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S6EDTY", "S6EDTY", JdeDataType.String, 2),
        new JdeField("S6EDSQ", "S6EDSQ", JdeDataType.Numeric),
        new JdeField("S6EKCO", "S6EKCO", JdeDataType.String, 10, true, true),
        new JdeField("S6EDOC", "S6EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("S6EDCT", "S6EDCT", JdeDataType.String, 4, true, true),
        new JdeField("S6EDLN", "S6EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("S6EDSP", "S6EDSP", JdeDataType.String, 2),
        new JdeField("S6EDBT", "S6EDBT", JdeDataType.String, 30),
        new JdeField("S6SHAN", "S6SHAN", JdeDataType.Numeric),
        new JdeField("S6ALPH", "S6ALPH", JdeDataType.String, 80),
        new JdeField("S6CARS", "S6CARS", JdeDataType.Numeric),
        new JdeField("S6SHPN", "S6SHPN", JdeDataType.Numeric),
        new JdeField("S6DEID", "S6DEID", JdeDataType.Numeric),
        new JdeField("S6CIRV", "S6CIRV", JdeDataType.String, 40),
        new JdeField("S6CITM", "S6CITM", JdeDataType.String, 50),
        new JdeField("S6SCAC", "S6SCAC", JdeDataType.String, 8),
        new JdeField("S6ORIG", "S6ORIG", JdeDataType.String, 6),
        new JdeField("S6DLDT", "S6DLDT", JdeDataType.Numeric),
        new JdeField("S6DLTM", "S6DLTM", JdeDataType.Numeric),
        new JdeField("S6NPCS", "S6NPCS", JdeDataType.Numeric),
        new JdeField("S6CBNK", "S6CBNK", JdeDataType.String, 40),
        new JdeField("S6ETRSC", "S6ETRSC", JdeDataType.String, 6),
        new JdeField("S6ETRC", "S6ETRC", JdeDataType.String, 6),
        new JdeField("S6AETC", "S6AETC", JdeDataType.String, 20),
        new JdeField("S6DKID", "S6DKID", JdeDataType.String, 40),
        new JdeField("S6RFQ1", "S6RFQ1", JdeDataType.String, 4),
        new JdeField("S6RFQ2", "S6RFQ2", JdeDataType.String, 4),
        new JdeField("S6RFQ3", "S6RFQ3", JdeDataType.String, 4),
        new JdeField("S6RFQ4", "S6RFQ4", JdeDataType.String, 4),
        new JdeField("S6RFQ5", "S6RFQ5", JdeDataType.String, 4),
        new JdeField("S6RF1", "S6RF1", JdeDataType.String, 60),
        new JdeField("S6RF2", "S6RF2", JdeDataType.String, 60),
        new JdeField("S6RF3", "S6RF3", JdeDataType.String, 60),
        new JdeField("S6RF4", "S6RF4", JdeDataType.String, 60),
        new JdeField("S6RF5", "S6RF5", JdeDataType.String, 60),
        new JdeField("S6PRTY1", "S6PRTY1", JdeDataType.String, 4),
        new JdeField("S6PRTY2", "S6PRTY2", JdeDataType.String, 4),
        new JdeField("S6PRTY3", "S6PRTY3", JdeDataType.String, 4),
        new JdeField("S6PRTY4", "S6PRTY4", JdeDataType.String, 4),
        new JdeField("S6PRTY5", "S6PRTY5", JdeDataType.String, 4),
        new JdeField("S6PRNA1", "S6PRNA1", JdeDataType.String, 70),
        new JdeField("S6PRNA2", "S6PRNA2", JdeDataType.String, 70),
        new JdeField("S6PRNA3", "S6PRNA3", JdeDataType.String, 70),
        new JdeField("S6PRNA4", "S6PRNA4", JdeDataType.String, 70),
        new JdeField("S6PRNA5", "S6PRNA5", JdeDataType.String, 70),
        new JdeField("S6IDTYP1", "S6IDTYP1", JdeDataType.String, 4),
        new JdeField("S6IDTYP2", "S6IDTYP2", JdeDataType.String, 4),
        new JdeField("S6IDTYP3", "S6IDTYP3", JdeDataType.String, 4),
        new JdeField("S6IDTYP4", "S6IDTYP4", JdeDataType.String, 4),
        new JdeField("S6IDTYP5", "S6IDTYP5", JdeDataType.String, 4),
        new JdeField("S6IDNUM1", "S6IDNUM1", JdeDataType.String, 40),
        new JdeField("S6IDNUM2", "S6IDNUM2", JdeDataType.String, 40),
        new JdeField("S6IDNUM3", "S6IDNUM3", JdeDataType.String, 40),
        new JdeField("S6IDNUM4", "S6IDNUM4", JdeDataType.String, 40),
        new JdeField("S6IDNUM5", "S6IDNUM5", JdeDataType.String, 40),
        new JdeField("S6RFTY1", "S6RFTY1", JdeDataType.String, 6),
        new JdeField("S6RFTY2", "S6RFTY2", JdeDataType.String, 6),
        new JdeField("S6RFTY3", "S6RFTY3", JdeDataType.String, 6),
        new JdeField("S6RFTY4", "S6RFTY4", JdeDataType.String, 6),
        new JdeField("S6RFTY5", "S6RFTY5", JdeDataType.String, 6),
        new JdeField("S6RFNUM1", "S6RFNUM1", JdeDataType.String, 60),
        new JdeField("S6RFNUM2", "S6RFNUM2", JdeDataType.String, 60),
        new JdeField("S6RFNUM3", "S6RFNUM3", JdeDataType.String, 60),
        new JdeField("S6RFNUM4", "S6RFNUM4", JdeDataType.String, 60),
        new JdeField("S6RFNUM5", "S6RFNUM5", JdeDataType.String, 60),
        new JdeField("S6FUT1", "S6FUT1", JdeDataType.Numeric),
        new JdeField("S6FUT2", "S6FUT2", JdeDataType.Numeric),
        new JdeField("S6FUT4", "S6FUT4", JdeDataType.String, 50),
        new JdeField("S6FUT5", "S6FUT5", JdeDataType.String, 50),
        new JdeField("S6X1", "S6X1", JdeDataType.String, 2),
        new JdeField("S6X2", "S6X2", JdeDataType.String, 2),
        new JdeField("S6D1FU", "S6D1FU", JdeDataType.Numeric),
        new JdeField("S6D2FU", "S6D2FU", JdeDataType.Numeric),
        new JdeField("S6TORG", "S6TORG", JdeDataType.String, 20),
        new JdeField("S6USER", "S6USER", JdeDataType.String, 20),
        new JdeField("S6PID", "S6PID", JdeDataType.String, 20),
        new JdeField("S6JOBN", "S6JOBN", JdeDataType.String, 20),
        new JdeField("S6UPMJ", "S6UPMJ", JdeDataType.Numeric),
        new JdeField("S6UPMT", "S6UPMT", JdeDataType.Numeric),
        new JdeField("S6JOBSQ", "S6JOBSQ", JdeDataType.String, 30),
        new JdeField("S6PSJOBNO", "S6PSJOBNO", JdeDataType.String, 30),
        new JdeField("S6CARDNO", "S6CARDNO", JdeDataType.String, 8),
        new JdeField("S6CIRVQ", "S6CIRVQ", JdeDataType.String, 4),
        new JdeField("S6GSHAN", "S6GSHAN", JdeDataType.Numeric),
        new JdeField("S6GCARS", "S6GCARS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F470472_0", "Primary Key on S6EKCO, S6EDOC, S6EDCT, S6EDLN", new[] { "S6EKCO", "S6EDOC", "S6EDCT", "S6EDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
