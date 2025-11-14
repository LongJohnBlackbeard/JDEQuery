using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08211 - .
/// </summary>
public class F08211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JSRPYR.
        /// </summary>
        public const string JSRPYR = "JSRPYR";

        /// <summary>
        /// JSUTID.
        /// </summary>
        public const string JSUTID = "JSUTID";

        /// <summary>
        /// JSPRDI.
        /// </summary>
        public const string JSPRDI = "JSPRDI";

        /// <summary>
        /// JSBOTT.
        /// </summary>
        public const string JSBOTT = "JSBOTT";

        /// <summary>
        /// JSTFI.
        /// </summary>
        public const string JSTFI = "JSTFI";

        /// <summary>
        /// JSSBMD.
        /// </summary>
        public const string JSSBMD = "JSSBMD";

        /// <summary>
        /// JSTCC.
        /// </summary>
        public const string JSTCC = "JSTCC";

        /// <summary>
        /// JSTEIN.
        /// </summary>
        public const string JSTEIN = "JSTEIN";

        /// <summary>
        /// JSAN8T.
        /// </summary>
        public const string JSAN8T = "JSAN8T";

        /// <summary>
        /// JSTRSS.
        /// </summary>
        public const string JSTRSS = "JSTRSS";

        /// <summary>
        /// JSIRSS.
        /// </summary>
        public const string JSIRSS = "JSIRSS";

        /// <summary>
        /// JSTFEI.
        /// </summary>
        public const string JSTFEI = "JSTFEI";

        /// <summary>
        /// JSRECPTID.
        /// </summary>
        public const string JSRECPTID = "JSRECPTID";

        /// <summary>
        /// JSRIBC.
        /// </summary>
        public const string JSRIBC = "JSRIBC";

        /// <summary>
        /// JSSVAN.
        /// </summary>
        public const string JSSVAN = "JSSVAN";

        /// <summary>
        /// JSSWID.
        /// </summary>
        public const string JSSWID = "JSSWID";

        /// <summary>
        /// JS1095CNT.
        /// </summary>
        public const string JS1095CNT = "JS1095CNT";

        /// <summary>
        /// JS1094CNT.
        /// </summary>
        public const string JS1094CNT = "JS1094CNT";

        /// <summary>
        /// JSCHKSUM.
        /// </summary>
        public const string JSCHKSUM = "JSCHKSUM";

        /// <summary>
        /// JSABS.
        /// </summary>
        public const string JSABS = "JSABS";

        /// <summary>
        /// JSFDFN.
        /// </summary>
        public const string JSFDFN = "JSFDFN";

        /// <summary>
        /// JSSPACUSM1.
        /// </summary>
        public const string JSSPACUSM1 = "JSSPACUSM1";

        /// <summary>
        /// JSSPACUSM2.
        /// </summary>
        public const string JSSPACUSM2 = "JSSPACUSM2";

        /// <summary>
        /// JSSPACUSM3.
        /// </summary>
        public const string JSSPACUSM3 = "JSSPACUSM3";

        /// <summary>
        /// JSSPACUSM4.
        /// </summary>
        public const string JSSPACUSM4 = "JSSPACUSM4";

        /// <summary>
        /// JSSPADUSM1.
        /// </summary>
        public const string JSSPADUSM1 = "JSSPADUSM1";

        /// <summary>
        /// JSSPADUSM2.
        /// </summary>
        public const string JSSPADUSM2 = "JSSPADUSM2";

        /// <summary>
        /// JSSPADUSM3.
        /// </summary>
        public const string JSSPADUSM3 = "JSSPADUSM3";

        /// <summary>
        /// JSSPADUSM4.
        /// </summary>
        public const string JSSPADUSM4 = "JSSPADUSM4";

        /// <summary>
        /// JSSPANUSM1.
        /// </summary>
        public const string JSSPANUSM1 = "JSSPANUSM1";

        /// <summary>
        /// JSSPANUSM2.
        /// </summary>
        public const string JSSPANUSM2 = "JSSPANUSM2";

        /// <summary>
        /// JSSPANUSM3.
        /// </summary>
        public const string JSSPANUSM3 = "JSSPANUSM3";

        /// <summary>
        /// JSSPANUSM4.
        /// </summary>
        public const string JSSPANUSM4 = "JSSPANUSM4";

        /// <summary>
        /// JSSPASUSM1.
        /// </summary>
        public const string JSSPASUSM1 = "JSSPASUSM1";

        /// <summary>
        /// JSSPASUSM2.
        /// </summary>
        public const string JSSPASUSM2 = "JSSPASUSM2";

        /// <summary>
        /// JSSPASUSM3.
        /// </summary>
        public const string JSSPASUSM3 = "JSSPASUSM3";

        /// <summary>
        /// JSSPASUSM4.
        /// </summary>
        public const string JSSPASUSM4 = "JSSPASUSM4";

        /// <summary>
        /// JSSPASUSM5.
        /// </summary>
        public const string JSSPASUSM5 = "JSSPASUSM5";

        /// <summary>
        /// JSSPASUSM6.
        /// </summary>
        public const string JSSPASUSM6 = "JSSPASUSM6";

        /// <summary>
        /// JSSPASUSM7.
        /// </summary>
        public const string JSSPASUSM7 = "JSSPASUSM7";

        /// <summary>
        /// JSSPASUSM8.
        /// </summary>
        public const string JSSPASUSM8 = "JSSPASUSM8";

        /// <summary>
        /// JSUSER.
        /// </summary>
        public const string JSUSER = "JSUSER";

        /// <summary>
        /// JSPID.
        /// </summary>
        public const string JSPID = "JSPID";

        /// <summary>
        /// JSJOBN.
        /// </summary>
        public const string JSJOBN = "JSJOBN";

        /// <summary>
        /// JSUPMJ.
        /// </summary>
        public const string JSUPMJ = "JSUPMJ";

        /// <summary>
        /// JSUPMT.
        /// </summary>
        public const string JSUPMT = "JSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JSRPYR", "JSRPYR", JdeDataType.Numeric, null, true, true),
        new JdeField("JSUTID", "JSUTID", JdeDataType.String, 102, true, true),
        new JdeField("JSPRDI", "JSPRDI", JdeDataType.String, 2),
        new JdeField("JSBOTT", "JSBOTT", JdeDataType.String, 2),
        new JdeField("JSTFI", "JSTFI", JdeDataType.String, 2),
        new JdeField("JSSBMD", "JSSBMD", JdeDataType.Numeric),
        new JdeField("JSTCC", "JSTCC", JdeDataType.String, 10),
        new JdeField("JSTEIN", "JSTEIN", JdeDataType.String, 40),
        new JdeField("JSAN8T", "JSAN8T", JdeDataType.Numeric),
        new JdeField("JSTRSS", "JSTRSS", JdeDataType.String, 2),
        new JdeField("JSIRSS", "JSIRSS", JdeDataType.String, 2),
        new JdeField("JSTFEI", "JSTFEI", JdeDataType.String, 2),
        new JdeField("JSRECPTID", "JSRECPTID", JdeDataType.String, 40),
        new JdeField("JSRIBC", "JSRIBC", JdeDataType.String, 40),
        new JdeField("JSSVAN", "JSSVAN", JdeDataType.Numeric),
        new JdeField("JSSWID", "JSSWID", JdeDataType.String, 20),
        new JdeField("JS1095CNT", "JS1095CNT", JdeDataType.Numeric),
        new JdeField("JS1094CNT", "JS1094CNT", JdeDataType.Numeric),
        new JdeField("JSCHKSUM", "JSCHKSUM", JdeDataType.String, 64),
        new JdeField("JSABS", "JSABS", JdeDataType.Numeric),
        new JdeField("JSFDFN", "JSFDFN", JdeDataType.String, 160),
        new JdeField("JSSPACUSM1", "JSSPACUSM1", JdeDataType.String, 2),
        new JdeField("JSSPACUSM2", "JSSPACUSM2", JdeDataType.String, 2),
        new JdeField("JSSPACUSM3", "JSSPACUSM3", JdeDataType.String, 2),
        new JdeField("JSSPACUSM4", "JSSPACUSM4", JdeDataType.String, 2),
        new JdeField("JSSPADUSM1", "JSSPADUSM1", JdeDataType.Numeric),
        new JdeField("JSSPADUSM2", "JSSPADUSM2", JdeDataType.Numeric),
        new JdeField("JSSPADUSM3", "JSSPADUSM3", JdeDataType.Numeric),
        new JdeField("JSSPADUSM4", "JSSPADUSM4", JdeDataType.Numeric),
        new JdeField("JSSPANUSM1", "JSSPANUSM1", JdeDataType.Numeric),
        new JdeField("JSSPANUSM2", "JSSPANUSM2", JdeDataType.Numeric),
        new JdeField("JSSPANUSM3", "JSSPANUSM3", JdeDataType.Numeric),
        new JdeField("JSSPANUSM4", "JSSPANUSM4", JdeDataType.Numeric),
        new JdeField("JSSPASUSM1", "JSSPASUSM1", JdeDataType.String, 60),
        new JdeField("JSSPASUSM2", "JSSPASUSM2", JdeDataType.String, 60),
        new JdeField("JSSPASUSM3", "JSSPASUSM3", JdeDataType.String, 60),
        new JdeField("JSSPASUSM4", "JSSPASUSM4", JdeDataType.String, 60),
        new JdeField("JSSPASUSM5", "JSSPASUSM5", JdeDataType.String, 20),
        new JdeField("JSSPASUSM6", "JSSPASUSM6", JdeDataType.String, 20),
        new JdeField("JSSPASUSM7", "JSSPASUSM7", JdeDataType.String, 20),
        new JdeField("JSSPASUSM8", "JSSPASUSM8", JdeDataType.String, 20),
        new JdeField("JSUSER", "JSUSER", JdeDataType.String, 20),
        new JdeField("JSPID", "JSPID", JdeDataType.String, 20),
        new JdeField("JSJOBN", "JSJOBN", JdeDataType.String, 20),
        new JdeField("JSUPMJ", "JSUPMJ", JdeDataType.Numeric),
        new JdeField("JSUPMT", "JSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08211_0", "Primary Key on JSRPYR, JSUTID", new[] { "JSRPYR", "JSUTID" }, isUnique: true, isPrimaryKey: true)
    };
}
