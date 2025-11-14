using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0717 - .
/// </summary>
public class F0717 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JFAN8.
        /// </summary>
        public const string JFAN8 = "JFAN8";

        /// <summary>
        /// JFPCT#.
        /// </summary>
        public const string JFPCT_ = "JFPCT#";

        /// <summary>
        /// JFROEN.
        /// </summary>
        public const string JFROEN = "JFROEN";

        /// <summary>
        /// JFDTM.
        /// </summary>
        public const string JFDTM = "JFDTM";

        /// <summary>
        /// JFROER.
        /// </summary>
        public const string JFROER = "JFROER";

        /// <summary>
        /// JFREDT.
        /// </summary>
        public const string JFREDT = "JFREDT";

        /// <summary>
        /// JFRTRS.
        /// </summary>
        public const string JFRTRS = "JFRTRS";

        /// <summary>
        /// JFDT.
        /// </summary>
        public const string JFDT = "JFDT";

        /// <summary>
        /// JFPPED.
        /// </summary>
        public const string JFPPED = "JFPPED";

        /// <summary>
        /// JFPCCD.
        /// </summary>
        public const string JFPCCD = "JFPCCD";

        /// <summary>
        /// JFIPAY.
        /// </summary>
        public const string JFIPAY = "JFIPAY";

        /// <summary>
        /// JFVPAY.
        /// </summary>
        public const string JFVPAY = "JFVPAY";

        /// <summary>
        /// JFWDT.
        /// </summary>
        public const string JFWDT = "JFWDT";

        /// <summary>
        /// JFWKDT.
        /// </summary>
        public const string JFWKDT = "JFWKDT";

        /// <summary>
        /// JFRCDT.
        /// </summary>
        public const string JFRCDT = "JFRCDT";

        /// <summary>
        /// JFRCFG.
        /// </summary>
        public const string JFRCFG = "JFRCFG";

        /// <summary>
        /// JFQLWK.
        /// </summary>
        public const string JFQLWK = "JFQLWK";

        /// <summary>
        /// JFHPA1.
        /// </summary>
        public const string JFHPA1 = "JFHPA1";

        /// <summary>
        /// JFHLD1.
        /// </summary>
        public const string JFHLD1 = "JFHLD1";

        /// <summary>
        /// JFHPA2.
        /// </summary>
        public const string JFHPA2 = "JFHPA2";

        /// <summary>
        /// JFHLD2.
        /// </summary>
        public const string JFHLD2 = "JFHLD2";

        /// <summary>
        /// JFHPA3.
        /// </summary>
        public const string JFHPA3 = "JFHPA3";

        /// <summary>
        /// JFHLD3.
        /// </summary>
        public const string JFHLD3 = "JFHLD3";

        /// <summary>
        /// JFOPA1.
        /// </summary>
        public const string JFOPA1 = "JFOPA1";

        /// <summary>
        /// JFOPE1.
        /// </summary>
        public const string JFOPE1 = "JFOPE1";

        /// <summary>
        /// JFOPA2.
        /// </summary>
        public const string JFOPA2 = "JFOPA2";

        /// <summary>
        /// JFOPE2.
        /// </summary>
        public const string JFOPE2 = "JFOPE2";

        /// <summary>
        /// JFOPA3.
        /// </summary>
        public const string JFOPA3 = "JFOPA3";

        /// <summary>
        /// JFOPE3.
        /// </summary>
        public const string JFOPE3 = "JFOPE3";

        /// <summary>
        /// JFNWKD.
        /// </summary>
        public const string JFNWKD = "JFNWKD";

        /// <summary>
        /// JFNWKP.
        /// </summary>
        public const string JFNWKP = "JFNWKP";

        /// <summary>
        /// JFNWK#.
        /// </summary>
        public const string JFNWK_ = "JFNWK#";

        /// <summary>
        /// JFINFG.
        /// </summary>
        public const string JFINFG = "JFINFG";

        /// <summary>
        /// JFLUID.
        /// </summary>
        public const string JFLUID = "JFLUID";

        /// <summary>
        /// JFYST.
        /// </summary>
        public const string JFYST = "JFYST";

        /// <summary>
        /// JFHMCO.
        /// </summary>
        public const string JFHMCO = "JFHMCO";

        /// <summary>
        /// JFHMCU.
        /// </summary>
        public const string JFHMCU = "JFHMCU";

        /// <summary>
        /// JFSG.
        /// </summary>
        public const string JFSG = "JFSG";

        /// <summary>
        /// JFUN.
        /// </summary>
        public const string JFUN = "JFUN";

        /// <summary>
        /// JFJBCD.
        /// </summary>
        public const string JFJBCD = "JFJBCD";

        /// <summary>
        /// JFJBST.
        /// </summary>
        public const string JFJBST = "JFJBST";

        /// <summary>
        /// JFMAIL.
        /// </summary>
        public const string JFMAIL = "JFMAIL";

        /// <summary>
        /// JFTARA.
        /// </summary>
        public const string JFTARA = "JFTARA";

        /// <summary>
        /// JFP001.
        /// </summary>
        public const string JFP001 = "JFP001";

        /// <summary>
        /// JFP002.
        /// </summary>
        public const string JFP002 = "JFP002";

        /// <summary>
        /// JFP003.
        /// </summary>
        public const string JFP003 = "JFP003";

        /// <summary>
        /// JFP004.
        /// </summary>
        public const string JFP004 = "JFP004";

        /// <summary>
        /// JFROEF.
        /// </summary>
        public const string JFROEF = "JFROEF";

        /// <summary>
        /// JFVERS.
        /// </summary>
        public const string JFVERS = "JFVERS";

        /// <summary>
        /// JFUSER.
        /// </summary>
        public const string JFUSER = "JFUSER";

        /// <summary>
        /// JFPID.
        /// </summary>
        public const string JFPID = "JFPID";

        /// <summary>
        /// JFUPMJ.
        /// </summary>
        public const string JFUPMJ = "JFUPMJ";

        /// <summary>
        /// JFDTSP.
        /// </summary>
        public const string JFDTSP = "JFDTSP";
    }

    /// <inheritdoc />
    public override string TableName => "F0717";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JFAN8", "JFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JFPCT#", "JFPCT#", JdeDataType.Numeric, null, true, true),
        new JdeField("JFROEN", "JFROEN", JdeDataType.String, 22, true, true),
        new JdeField("JFDTM", "JFDTM", JdeDataType.Numeric),
        new JdeField("JFROER", "JFROER", JdeDataType.String, 22),
        new JdeField("JFREDT", "JFREDT", JdeDataType.Numeric),
        new JdeField("JFRTRS", "JFRTRS", JdeDataType.String, 2),
        new JdeField("JFDT", "JFDT", JdeDataType.Numeric),
        new JdeField("JFPPED", "JFPPED", JdeDataType.Numeric),
        new JdeField("JFPCCD", "JFPCCD", JdeDataType.String, 10),
        new JdeField("JFIPAY", "JFIPAY", JdeDataType.Numeric),
        new JdeField("JFVPAY", "JFVPAY", JdeDataType.Numeric),
        new JdeField("JFWDT", "JFWDT", JdeDataType.Numeric),
        new JdeField("JFWKDT", "JFWKDT", JdeDataType.Numeric),
        new JdeField("JFRCDT", "JFRCDT", JdeDataType.Numeric),
        new JdeField("JFRCFG", "JFRCFG", JdeDataType.String, 2),
        new JdeField("JFQLWK", "JFQLWK", JdeDataType.Numeric),
        new JdeField("JFHPA1", "JFHPA1", JdeDataType.Numeric),
        new JdeField("JFHLD1", "JFHLD1", JdeDataType.Numeric),
        new JdeField("JFHPA2", "JFHPA2", JdeDataType.Numeric),
        new JdeField("JFHLD2", "JFHLD2", JdeDataType.Numeric),
        new JdeField("JFHPA3", "JFHPA3", JdeDataType.Numeric),
        new JdeField("JFHLD3", "JFHLD3", JdeDataType.Numeric),
        new JdeField("JFOPA1", "JFOPA1", JdeDataType.Numeric),
        new JdeField("JFOPE1", "JFOPE1", JdeDataType.String, 32),
        new JdeField("JFOPA2", "JFOPA2", JdeDataType.Numeric),
        new JdeField("JFOPE2", "JFOPE2", JdeDataType.String, 32),
        new JdeField("JFOPA3", "JFOPA3", JdeDataType.Numeric),
        new JdeField("JFOPE3", "JFOPE3", JdeDataType.String, 32),
        new JdeField("JFNWKD", "JFNWKD", JdeDataType.Numeric),
        new JdeField("JFNWKP", "JFNWKP", JdeDataType.Numeric),
        new JdeField("JFNWK#", "JFNWK#", JdeDataType.Numeric),
        new JdeField("JFINFG", "JFINFG", JdeDataType.String, 2),
        new JdeField("JFLUID", "JFLUID", JdeDataType.Numeric),
        new JdeField("JFYST", "JFYST", JdeDataType.String, 2),
        new JdeField("JFHMCO", "JFHMCO", JdeDataType.String, 10),
        new JdeField("JFHMCU", "JFHMCU", JdeDataType.String, 24),
        new JdeField("JFSG", "JFSG", JdeDataType.String, 24),
        new JdeField("JFUN", "JFUN", JdeDataType.String, 12),
        new JdeField("JFJBCD", "JFJBCD", JdeDataType.String, 12),
        new JdeField("JFJBST", "JFJBST", JdeDataType.String, 8),
        new JdeField("JFMAIL", "JFMAIL", JdeDataType.String, 20),
        new JdeField("JFTARA", "JFTARA", JdeDataType.String, 20),
        new JdeField("JFP001", "JFP001", JdeDataType.String, 6),
        new JdeField("JFP002", "JFP002", JdeDataType.String, 6),
        new JdeField("JFP003", "JFP003", JdeDataType.String, 6),
        new JdeField("JFP004", "JFP004", JdeDataType.String, 6),
        new JdeField("JFROEF", "JFROEF", JdeDataType.String, 2),
        new JdeField("JFVERS", "JFVERS", JdeDataType.String, 20),
        new JdeField("JFUSER", "JFUSER", JdeDataType.String, 20),
        new JdeField("JFPID", "JFPID", JdeDataType.String, 20),
        new JdeField("JFUPMJ", "JFUPMJ", JdeDataType.Numeric),
        new JdeField("JFDTSP", "JFDTSP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0717_0", "Primary Key on JFAN8, JFPCT#, JFROEN", new[] { "JFAN8", "JFPCT#", "JFROEN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0717_2", "Index on JFROEN", new[] { "JFROEN" }),
        new JdeIndex("F0717_3", "Index on JFROER, JFAN8", new[] { "JFROER", "JFAN8" }),
        new JdeIndex("F0717_4", "Index on JFDTM, JFAN8", new[] { "JFDTM", "JFAN8" }),
        new JdeIndex("F0717_5", "Index on JFVERS, JFAN8, JFROEF", new[] { "JFVERS", "JFAN8", "JFROEF" }),
        new JdeIndex("F0717_6", "Index on JFVERS, JFDTSP", new[] { "JFVERS", "JFDTSP" }),
        new JdeIndex("F0717_7", "Index on JFAN8, JFPCT#", new[] { "JFAN8", "JFPCT#" }),
        new JdeIndex("F0717_8", "Index on JFAN8, JFROEN, JFDTM", new[] { "JFAN8", "JFROEN", "JFDTM" })
    };
}
