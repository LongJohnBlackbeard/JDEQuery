using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4371 - .
/// </summary>
public class F4371 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDITM.
        /// </summary>
        public const string PDITM = "PDITM";

        /// <summary>
        /// PDMCU.
        /// </summary>
        public const string PDMCU = "PDMCU";

        /// <summary>
        /// PDAN8.
        /// </summary>
        public const string PDAN8 = "PDAN8";

        /// <summary>
        /// PDSHAN.
        /// </summary>
        public const string PDSHAN = "PDSHAN";

        /// <summary>
        /// PDBUYR.
        /// </summary>
        public const string PDBUYR = "PDBUYR";

        /// <summary>
        /// PDCRCD.
        /// </summary>
        public const string PDCRCD = "PDCRCD";

        /// <summary>
        /// PDCRDC.
        /// </summary>
        public const string PDCRDC = "PDCRDC";

        /// <summary>
        /// PDCRR.
        /// </summary>
        public const string PDCRR = "PDCRR";

        /// <summary>
        /// PDUITM.
        /// </summary>
        public const string PDUITM = "PDUITM";

        /// <summary>
        /// PDLITM.
        /// </summary>
        public const string PDLITM = "PDLITM";

        /// <summary>
        /// PDAITM.
        /// </summary>
        public const string PDAITM = "PDAITM";

        /// <summary>
        /// PDDSC1.
        /// </summary>
        public const string PDDSC1 = "PDDSC1";

        /// <summary>
        /// PDDSC2.
        /// </summary>
        public const string PDDSC2 = "PDDSC2";

        /// <summary>
        /// PDUNCS.
        /// </summary>
        public const string PDUNCS = "PDUNCS";

        /// <summary>
        /// PDAEXP.
        /// </summary>
        public const string PDAEXP = "PDAEXP";

        /// <summary>
        /// PDUOM1.
        /// </summary>
        public const string PDUOM1 = "PDUOM1";

        /// <summary>
        /// PDUOM3.
        /// </summary>
        public const string PDUOM3 = "PDUOM3";

        /// <summary>
        /// PDUOPN.
        /// </summary>
        public const string PDUOPN = "PDUOPN";

        /// <summary>
        /// PDUORG.
        /// </summary>
        public const string PDUORG = "PDUORG";

        /// <summary>
        /// PDROPI.
        /// </summary>
        public const string PDROPI = "PDROPI";

        /// <summary>
        /// PDSTKT.
        /// </summary>
        public const string PDSTKT = "PDSTKT";

        /// <summary>
        /// PDLNTY.
        /// </summary>
        public const string PDLNTY = "PDLNTY";

        /// <summary>
        /// PDIVI.
        /// </summary>
        public const string PDIVI = "PDIVI";

        /// <summary>
        /// PDVR01.
        /// </summary>
        public const string PDVR01 = "PDVR01";

        /// <summary>
        /// PDVR02.
        /// </summary>
        public const string PDVR02 = "PDVR02";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDCTID.
        /// </summary>
        public const string PDCTID = "PDCTID";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDPEID.
        /// </summary>
        public const string PDPEID = "PDPEID";

        /// <summary>
        /// PDTCID.
        /// </summary>
        public const string PDTCID = "PDTCID";

        /// <summary>
        /// PDTORG.
        /// </summary>
        public const string PDTORG = "PDTORG";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDTDAY.
        /// </summary>
        public const string PDTDAY = "PDTDAY";

        /// <summary>
        /// PDSREC.
        /// </summary>
        public const string PDSREC = "PDSREC";

        /// <summary>
        /// PDBLKT.
        /// </summary>
        public const string PDBLKT = "PDBLKT";
    }

    /// <inheritdoc />
    public override string TableName => "F4371";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDITM", "PDITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PDMCU", "PDMCU", JdeDataType.String, 24, true, true),
        new JdeField("PDAN8", "PDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PDSHAN", "PDSHAN", JdeDataType.Numeric),
        new JdeField("PDBUYR", "PDBUYR", JdeDataType.Numeric),
        new JdeField("PDCRCD", "PDCRCD", JdeDataType.String, 6),
        new JdeField("PDCRDC", "PDCRDC", JdeDataType.String, 6),
        new JdeField("PDCRR", "PDCRR", JdeDataType.Numeric),
        new JdeField("PDUITM", "PDUITM", JdeDataType.String, 52),
        new JdeField("PDLITM", "PDLITM", JdeDataType.String, 50),
        new JdeField("PDAITM", "PDAITM", JdeDataType.String, 50),
        new JdeField("PDDSC1", "PDDSC1", JdeDataType.String, 60),
        new JdeField("PDDSC2", "PDDSC2", JdeDataType.String, 60),
        new JdeField("PDUNCS", "PDUNCS", JdeDataType.Numeric),
        new JdeField("PDAEXP", "PDAEXP", JdeDataType.Numeric),
        new JdeField("PDUOM1", "PDUOM1", JdeDataType.String, 4),
        new JdeField("PDUOM3", "PDUOM3", JdeDataType.String, 4),
        new JdeField("PDUOPN", "PDUOPN", JdeDataType.Numeric),
        new JdeField("PDUORG", "PDUORG", JdeDataType.Numeric),
        new JdeField("PDROPI", "PDROPI", JdeDataType.Numeric),
        new JdeField("PDSTKT", "PDSTKT", JdeDataType.String, 2),
        new JdeField("PDLNTY", "PDLNTY", JdeDataType.String, 4),
        new JdeField("PDIVI", "PDIVI", JdeDataType.String, 2),
        new JdeField("PDVR01", "PDVR01", JdeDataType.String, 50),
        new JdeField("PDVR02", "PDVR02", JdeDataType.String, 50),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDCTID", "PDCTID", JdeDataType.String, 30),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDPEID", "PDPEID", JdeDataType.Numeric),
        new JdeField("PDTCID", "PDTCID", JdeDataType.Numeric),
        new JdeField("PDTORG", "PDTORG", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDTDAY", "PDTDAY", JdeDataType.Numeric),
        new JdeField("PDSREC", "PDSREC", JdeDataType.String, 2),
        new JdeField("PDBLKT", "PDBLKT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4371_0", "Primary Key on PDITM, PDMCU, PDAN8", new[] { "PDITM", "PDMCU", "PDAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
