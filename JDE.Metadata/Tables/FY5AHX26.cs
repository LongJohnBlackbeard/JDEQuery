using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AHX26 - .
/// </summary>
public class FY5AHX26 : JdeTable
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
        /// SDY5AHAIFG.
        /// </summary>
        public const string SDY5AHAIFG = "SDY5AHAIFG";

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
        /// SDICPY.
        /// </summary>
        public const string SDICPY = "SDICPY";

        /// <summary>
        /// SDATN1.
        /// </summary>
        public const string SDATN1 = "SDATN1";

        /// <summary>
        /// SDATN2.
        /// </summary>
        public const string SDATN2 = "SDATN2";

        /// <summary>
        /// SDY5AHMTFG.
        /// </summary>
        public const string SDY5AHMTFG = "SDY5AHMTFG";

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
    public override string TableName => "FY5AHX26";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDY5AHE1RL", "SDY5AHE1RL", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHMDID", "SDY5AHMDID", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHSTID", "SDY5AHSTID", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHSTTP", "SDY5AHSTTP", JdeDataType.String, 2, true, true),
        new JdeField("SDY5AHSETY", "SDY5AHSETY", JdeDataType.String, 2, true, true),
        new JdeField("SDY5AHOBNM", "SDY5AHOBNM", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHVSNM", "SDY5AHVSNM", JdeDataType.String, 20, true, true),
        new JdeField("SDY5AHAIFG", "SDY5AHAIFG", JdeDataType.String, 2),
        new JdeField("SDRUN", "SDRUN", JdeDataType.String, 2),
        new JdeField("SDINSL", "SDINSL", JdeDataType.String, 2),
        new JdeField("SDA", "SDA", JdeDataType.String, 2),
        new JdeField("SDCHNG", "SDCHNG", JdeDataType.String, 2),
        new JdeField("SDDLT", "SDDLT", JdeDataType.String, 2),
        new JdeField("SDVWYN", "SDVWYN", JdeDataType.String, 2),
        new JdeField("SDIOK", "SDIOK", JdeDataType.String, 2),
        new JdeField("SDICPY", "SDICPY", JdeDataType.String, 2),
        new JdeField("SDATN1", "SDATN1", JdeDataType.String, 2),
        new JdeField("SDATN2", "SDATN2", JdeDataType.String, 2),
        new JdeField("SDY5AHMTFG", "SDY5AHMTFG", JdeDataType.String, 2),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AHX26_0", "Primary Key on SDY5AHE1RL, SDY5AHMDID, SDY5AHSTID, SDY5AHSTTP, SDY5AHSETY, SDY5AHOBNM, SDY5AHVSNM", new[] { "SDY5AHE1RL", "SDY5AHMDID", "SDY5AHSTID", "SDY5AHSTTP", "SDY5AHSETY", "SDY5AHOBNM", "SDY5AHVSNM" }, isUnique: true, isPrimaryKey: true)
    };
}
