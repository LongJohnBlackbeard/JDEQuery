using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AHX12 - .
/// </summary>
public class FY5AHX12 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDY5AHE1RL.
        /// </summary>
        public const string SDY5AHE1RL = "SDY5AHE1RL";

        /// <summary>
        /// SDY5AHMDID.
        /// </summary>
        public const string SDY5AHMDID = "SDY5AHMDID";

        /// <summary>
        /// SDY5AHSTID.
        /// </summary>
        public const string SDY5AHSTID = "SDY5AHSTID";

        /// <summary>
        /// SDY5AHSTTP.
        /// </summary>
        public const string SDY5AHSTTP = "SDY5AHSTTP";

        /// <summary>
        /// SDY5AHSQNO.
        /// </summary>
        public const string SDY5AHSQNO = "SDY5AHSQNO";

        /// <summary>
        /// SDY5AHSETY.
        /// </summary>
        public const string SDY5AHSETY = "SDY5AHSETY";

        /// <summary>
        /// SDY5AHOBNM.
        /// </summary>
        public const string SDY5AHOBNM = "SDY5AHOBNM";

        /// <summary>
        /// SDY5AHVSNM.
        /// </summary>
        public const string SDY5AHVSNM = "SDY5AHVSNM";

        /// <summary>
        /// SDY5AHITEM.
        /// </summary>
        public const string SDY5AHITEM = "SDY5AHITEM";

        /// <summary>
        /// SDY5AHOTYP.
        /// </summary>
        public const string SDY5AHOTYP = "SDY5AHOTYP";

        /// <summary>
        /// SDY5AHAIFG.
        /// </summary>
        public const string SDY5AHAIFG = "SDY5AHAIFG";

        /// <summary>
        /// SDY5AHMTFG.
        /// </summary>
        public const string SDY5AHMTFG = "SDY5AHMTFG";

        /// <summary>
        /// SDOBNM.
        /// </summary>
        public const string SDOBNM = "SDOBNM";

        /// <summary>
        /// SDFMNM.
        /// </summary>
        public const string SDFMNM = "SDFMNM";

        /// <summary>
        /// SDFRDV.
        /// </summary>
        public const string SDFRDV = "SDFRDV";

        /// <summary>
        /// SDTHDV.
        /// </summary>
        public const string SDTHDV = "SDTHDV";

        /// <summary>
        /// SDDTAI.
        /// </summary>
        public const string SDDTAI = "SDDTAI";

        /// <summary>
        /// SDOWDI.
        /// </summary>
        public const string SDOWDI = "SDOWDI";

        /// <summary>
        /// SDSY.
        /// </summary>
        public const string SDSY = "SDSY";

        /// <summary>
        /// SDRUN.
        /// </summary>
        public const string SDRUN = "SDRUN";

        /// <summary>
        /// SDINSL.
        /// </summary>
        public const string SDINSL = "SDINSL";

        /// <summary>
        /// SDA.
        /// </summary>
        public const string SDA = "SDA";

        /// <summary>
        /// SDCHNG.
        /// </summary>
        public const string SDCHNG = "SDCHNG";

        /// <summary>
        /// SDDLT.
        /// </summary>
        public const string SDDLT = "SDDLT";

        /// <summary>
        /// SDVWYN.
        /// </summary>
        public const string SDVWYN = "SDVWYN";

        /// <summary>
        /// SDIOK.
        /// </summary>
        public const string SDIOK = "SDIOK";

        /// <summary>
        /// SDADDC.
        /// </summary>
        public const string SDADDC = "SDADDC";

        /// <summary>
        /// SDICPY.
        /// </summary>
        public const string SDICPY = "SDICPY";

        /// <summary>
        /// SDIUPT.
        /// </summary>
        public const string SDIUPT = "SDIUPT";

        /// <summary>
        /// SDATN1.
        /// </summary>
        public const string SDATN1 = "SDATN1";

        /// <summary>
        /// SDATN2.
        /// </summary>
        public const string SDATN2 = "SDATN2";

        /// <summary>
        /// SDATN3.
        /// </summary>
        public const string SDATN3 = "SDATN3";

        /// <summary>
        /// SDOBID.
        /// </summary>
        public const string SDOBID = "SDOBID";

        /// <summary>
        /// SDEXITID.
        /// </summary>
        public const string SDEXITID = "SDEXITID";

        /// <summary>
        /// SDTABID.
        /// </summary>
        public const string SDTABID = "SDTABID";

        /// <summary>
        /// SDTEXTID.
        /// </summary>
        public const string SDTEXTID = "SDTEXTID";

        /// <summary>
        /// SDPTH.
        /// </summary>
        public const string SDPTH = "SDPTH";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AHX12";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDY5AHE1RL", "SDY5AHE1RL", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHMDID", "SDY5AHMDID", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHSTID", "SDY5AHSTID", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHSTTP", "SDY5AHSTTP", JdeDataType.String, 2, true, true),
        new JdeField("SDY5AHSQNO", "SDY5AHSQNO", JdeDataType.Numeric, null, true, true),
        new JdeField("SDY5AHSETY", "SDY5AHSETY", JdeDataType.String, 2, true, true),
        new JdeField("SDY5AHOBNM", "SDY5AHOBNM", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHVSNM", "SDY5AHVSNM", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHITEM", "SDY5AHITEM", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHOTYP", "SDY5AHOTYP", JdeDataType.String, 8),
        new JdeField("SDY5AHAIFG", "SDY5AHAIFG", JdeDataType.String, 2),
        new JdeField("SDY5AHMTFG", "SDY5AHMTFG", JdeDataType.String, 2),
        new JdeField("SDOBNM", "SDOBNM", JdeDataType.String, 20),
        new JdeField("SDFMNM", "SDFMNM", JdeDataType.String, 20),
        new JdeField("SDFRDV", "SDFRDV", JdeDataType.String, 60),
        new JdeField("SDTHDV", "SDTHDV", JdeDataType.String, 60),
        new JdeField("SDDTAI", "SDDTAI", JdeDataType.String, 20),
        new JdeField("SDOWDI", "SDOWDI", JdeDataType.String, 80),
        new JdeField("SDSY", "SDSY", JdeDataType.String, 8),
        new JdeField("SDRUN", "SDRUN", JdeDataType.String, 2),
        new JdeField("SDINSL", "SDINSL", JdeDataType.String, 2),
        new JdeField("SDA", "SDA", JdeDataType.String, 2),
        new JdeField("SDCHNG", "SDCHNG", JdeDataType.String, 2),
        new JdeField("SDDLT", "SDDLT", JdeDataType.String, 2),
        new JdeField("SDVWYN", "SDVWYN", JdeDataType.String, 2),
        new JdeField("SDIOK", "SDIOK", JdeDataType.String, 2),
        new JdeField("SDADDC", "SDADDC", JdeDataType.String, 2),
        new JdeField("SDICPY", "SDICPY", JdeDataType.String, 2),
        new JdeField("SDIUPT", "SDIUPT", JdeDataType.String, 2),
        new JdeField("SDATN1", "SDATN1", JdeDataType.String, 2),
        new JdeField("SDATN2", "SDATN2", JdeDataType.String, 2),
        new JdeField("SDATN3", "SDATN3", JdeDataType.String, 2),
        new JdeField("SDOBID", "SDOBID", JdeDataType.Numeric),
        new JdeField("SDEXITID", "SDEXITID", JdeDataType.Numeric),
        new JdeField("SDTABID", "SDTABID", JdeDataType.Numeric),
        new JdeField("SDTEXTID", "SDTEXTID", JdeDataType.Numeric),
        new JdeField("SDPTH", "SDPTH", JdeDataType.String, 240),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AHX12_0", "Primary Key on SDY5AHE1RL, SDY5AHMDID, SDY5AHSTID, SDY5AHSTTP, SDY5AHSQNO, SDY5AHSETY, SDY5AHOBNM, SDY5AHVSNM, SDY5AHITEM", new[] { "SDY5AHE1RL", "SDY5AHMDID", "SDY5AHSTID", "SDY5AHSTTP", "SDY5AHSQNO", "SDY5AHSETY", "SDY5AHOBNM", "SDY5AHVSNM", "SDY5AHITEM" }, isUnique: true, isPrimaryKey: true)
    };
}
