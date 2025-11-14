using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI82 - .
/// </summary>
public class F76AUI82 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFCO.
        /// </summary>
        public const string WFCO = "WFCO";

        /// <summary>
        /// WFRREF.
        /// </summary>
        public const string WFRREF = "WFRREF";

        /// <summary>
        /// WFPYID.
        /// </summary>
        public const string WFPYID = "WFPYID";

        /// <summary>
        /// WFCKNU.
        /// </summary>
        public const string WFCKNU = "WFCKNU";

        /// <summary>
        /// WFAAP.
        /// </summary>
        public const string WFAAP = "WFAAP";

        /// <summary>
        /// WFACLE.
        /// </summary>
        public const string WFACLE = "WFACLE";

        /// <summary>
        /// WFACTN.
        /// </summary>
        public const string WFACTN = "WFACTN";

        /// <summary>
        /// WFACVA.
        /// </summary>
        public const string WFACVA = "WFACVA";

        /// <summary>
        /// WFADEA.
        /// </summary>
        public const string WFADEA = "WFADEA";

        /// <summary>
        /// WFAM.
        /// </summary>
        public const string WFAM = "WFAM";

        /// <summary>
        /// WFCKAM.
        /// </summary>
        public const string WFCKAM = "WFCKAM";

        /// <summary>
        /// WFAA1.
        /// </summary>
        public const string WFAA1 = "WFAA1";

        /// <summary>
        /// WFKCOG.
        /// </summary>
        public const string WFKCOG = "WFKCOG";

        /// <summary>
        /// WFDCTG.
        /// </summary>
        public const string WFDCTG = "WFDCTG";

        /// <summary>
        /// WFDOCG.
        /// </summary>
        public const string WFDOCG = "WFDOCG";

        /// <summary>
        /// WFDDST.
        /// </summary>
        public const string WFDDST = "WFDDST";

        /// <summary>
        /// WFDMTJ.
        /// </summary>
        public const string WFDMTJ = "WFDMTJ";

        /// <summary>
        /// WFDGJ.
        /// </summary>
        public const string WFDGJ = "WFDGJ";

        /// <summary>
        /// WFDL01.
        /// </summary>
        public const string WFDL01 = "WFDL01";

        /// <summary>
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";

        /// <summary>
        /// WFEV02.
        /// </summary>
        public const string WFEV02 = "WFEV02";

        /// <summary>
        /// WFEV03.
        /// </summary>
        public const string WFEV03 = "WFEV03";

        /// <summary>
        /// WFDL02.
        /// </summary>
        public const string WFDL02 = "WFDL02";

        /// <summary>
        /// WFFAP.
        /// </summary>
        public const string WFFAP = "WFFAP";

        /// <summary>
        /// WFFCAM.
        /// </summary>
        public const string WFFCAM = "WFFCAM";

        /// <summary>
        /// WFAA2.
        /// </summary>
        public const string WFAA2 = "WFAA2";

        /// <summary>
        /// WFICU.
        /// </summary>
        public const string WFICU = "WFICU";

        /// <summary>
        /// WFICUT.
        /// </summary>
        public const string WFICUT = "WFICUT";

        /// <summary>
        /// WFMATH01.
        /// </summary>
        public const string WFMATH01 = "WFMATH01";

        /// <summary>
        /// WFMATH02.
        /// </summary>
        public const string WFMATH02 = "WFMATH02";

        /// <summary>
        /// WFPOST.
        /// </summary>
        public const string WFPOST = "WFPOST";

        /// <summary>
        /// WFVLDT.
        /// </summary>
        public const string WFVLDT = "WFVLDT";

        /// <summary>
        /// WFCTID.
        /// </summary>
        public const string WFCTID = "WFCTID";

        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFDICJ.
        /// </summary>
        public const string WFDICJ = "WFDICJ";

        /// <summary>
        /// WFRYIN.
        /// </summary>
        public const string WFRYIN = "WFRYIN";

        /// <summary>
        /// WFCRRM.
        /// </summary>
        public const string WFCRRM = "WFCRRM";

        /// <summary>
        /// WFCRR.
        /// </summary>
        public const string WFCRR = "WFCRR";

        /// <summary>
        /// WFCRCD.
        /// </summary>
        public const string WFCRCD = "WFCRCD";

        /// <summary>
        /// WFBCRC.
        /// </summary>
        public const string WFBCRC = "WFBCRC";

        /// <summary>
        /// WFAN8.
        /// </summary>
        public const string WFAN8 = "WFAN8";

        /// <summary>
        /// WFPYR.
        /// </summary>
        public const string WFPYR = "WFPYR";

        /// <summary>
        /// WFDLT.
        /// </summary>
        public const string WFDLT = "WFDLT";

        /// <summary>
        /// WFVDGJ.
        /// </summary>
        public const string WFVDGJ = "WFVDGJ";

        /// <summary>
        /// WFVRE.
        /// </summary>
        public const string WFVRE = "WFVRE";

        /// <summary>
        /// WFPSTF.
        /// </summary>
        public const string WFPSTF = "WFPSTF";

        /// <summary>
        /// WFADSTS.
        /// </summary>
        public const string WFADSTS = "WFADSTS";

        /// <summary>
        /// WFMCU.
        /// </summary>
        public const string WFMCU = "WFMCU";

        /// <summary>
        /// WFCRR1.
        /// </summary>
        public const string WFCRR1 = "WFCRR1";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI82";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFCO", "WFCO", JdeDataType.String, 10),
        new JdeField("WFRREF", "WFRREF", JdeDataType.String, 50),
        new JdeField("WFPYID", "WFPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCKNU", "WFCKNU", JdeDataType.String, 50),
        new JdeField("WFAAP", "WFAAP", JdeDataType.Numeric),
        new JdeField("WFACLE", "WFACLE", JdeDataType.String, 4),
        new JdeField("WFACTN", "WFACTN", JdeDataType.String, 2),
        new JdeField("WFACVA", "WFACVA", JdeDataType.String, 20),
        new JdeField("WFADEA", "WFADEA", JdeDataType.String, 20),
        new JdeField("WFAM", "WFAM", JdeDataType.String, 2),
        new JdeField("WFCKAM", "WFCKAM", JdeDataType.Numeric),
        new JdeField("WFAA1", "WFAA1", JdeDataType.Numeric),
        new JdeField("WFKCOG", "WFKCOG", JdeDataType.String, 10),
        new JdeField("WFDCTG", "WFDCTG", JdeDataType.String, 4),
        new JdeField("WFDOCG", "WFDOCG", JdeDataType.Numeric),
        new JdeField("WFDDST", "WFDDST", JdeDataType.String, 2),
        new JdeField("WFDMTJ", "WFDMTJ", JdeDataType.Numeric),
        new JdeField("WFDGJ", "WFDGJ", JdeDataType.Numeric),
        new JdeField("WFDL01", "WFDL01", JdeDataType.String, 60),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2),
        new JdeField("WFEV02", "WFEV02", JdeDataType.String, 2),
        new JdeField("WFEV03", "WFEV03", JdeDataType.String, 2),
        new JdeField("WFDL02", "WFDL02", JdeDataType.String, 60),
        new JdeField("WFFAP", "WFFAP", JdeDataType.Numeric),
        new JdeField("WFFCAM", "WFFCAM", JdeDataType.Numeric),
        new JdeField("WFAA2", "WFAA2", JdeDataType.Numeric),
        new JdeField("WFICU", "WFICU", JdeDataType.Numeric),
        new JdeField("WFICUT", "WFICUT", JdeDataType.String, 4),
        new JdeField("WFMATH01", "WFMATH01", JdeDataType.Numeric),
        new JdeField("WFMATH02", "WFMATH02", JdeDataType.Numeric),
        new JdeField("WFPOST", "WFPOST", JdeDataType.String, 2),
        new JdeField("WFVLDT", "WFVLDT", JdeDataType.Numeric),
        new JdeField("WFCTID", "WFCTID", JdeDataType.String, 30, true, true),
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFDICJ", "WFDICJ", JdeDataType.Numeric),
        new JdeField("WFRYIN", "WFRYIN", JdeDataType.String, 2),
        new JdeField("WFCRRM", "WFCRRM", JdeDataType.String, 2),
        new JdeField("WFCRR", "WFCRR", JdeDataType.Numeric),
        new JdeField("WFCRCD", "WFCRCD", JdeDataType.String, 6),
        new JdeField("WFBCRC", "WFBCRC", JdeDataType.String, 6),
        new JdeField("WFAN8", "WFAN8", JdeDataType.Numeric),
        new JdeField("WFPYR", "WFPYR", JdeDataType.Numeric),
        new JdeField("WFDLT", "WFDLT", JdeDataType.String, 2),
        new JdeField("WFVDGJ", "WFVDGJ", JdeDataType.Numeric),
        new JdeField("WFVRE", "WFVRE", JdeDataType.String, 6),
        new JdeField("WFPSTF", "WFPSTF", JdeDataType.String, 2),
        new JdeField("WFADSTS", "WFADSTS", JdeDataType.String, 2),
        new JdeField("WFMCU", "WFMCU", JdeDataType.String, 24),
        new JdeField("WFCRR1", "WFCRR1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI82_0", "Primary Key on WFPYID, WFJOBS, WFCTID", new[] { "WFPYID", "WFJOBS", "WFCTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76AUI82_2", "Index on WFJOBS, WFCTID, WFCO, WFRREF", new[] { "WFJOBS", "WFCTID", "WFCO", "WFRREF" }),
        new JdeIndex("F76AUI82_4", "Index on WFCO, WFCKNU", new[] { "WFCO", "WFCKNU" })
    };
}
