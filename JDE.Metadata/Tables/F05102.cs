using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05102 - .
/// </summary>
public class F05102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SMGOAL.
        /// </summary>
        public const string SMGOAL = "SMGOAL";

        /// <summary>
        /// SMAN8.
        /// </summary>
        public const string SMAN8 = "SMAN8";

        /// <summary>
        /// SMGOLT.
        /// </summary>
        public const string SMGOLT = "SMGOLT";

        /// <summary>
        /// SMGDSC.
        /// </summary>
        public const string SMGDSC = "SMGDSC";

        /// <summary>
        /// SMGMSTS.
        /// </summary>
        public const string SMGMSTS = "SMGMSTS";

        /// <summary>
        /// SMGLDT.
        /// </summary>
        public const string SMGLDT = "SMGLDT";

        /// <summary>
        /// SMTINC.
        /// </summary>
        public const string SMTINC = "SMTINC";

        /// <summary>
        /// SMANPA.
        /// </summary>
        public const string SMANPA = "SMANPA";

        /// <summary>
        /// SMDEF.
        /// </summary>
        public const string SMDEF = "SMDEF";

        /// <summary>
        /// SMSERK.
        /// </summary>
        public const string SMSERK = "SMSERK";

        /// <summary>
        /// SMOTPS.
        /// </summary>
        public const string SMOTPS = "SMOTPS";

        /// <summary>
        /// SMORMCU.
        /// </summary>
        public const string SMORMCU = "SMORMCU";

        /// <summary>
        /// SMJBCD.
        /// </summary>
        public const string SMJBCD = "SMJBCD";

        /// <summary>
        /// SMJBST.
        /// </summary>
        public const string SMJBST = "SMJBST";

        /// <summary>
        /// SMGCB.
        /// </summary>
        public const string SMGCB = "SMGCB";

        /// <summary>
        /// SMGOT.
        /// </summary>
        public const string SMGOT = "SMGOT";

        /// <summary>
        /// SMGMN.
        /// </summary>
        public const string SMGMN = "SMGMN";

        /// <summary>
        /// SMUPMJ.
        /// </summary>
        public const string SMUPMJ = "SMUPMJ";

        /// <summary>
        /// SMUPMT.
        /// </summary>
        public const string SMUPMT = "SMUPMT";

        /// <summary>
        /// SMUSER.
        /// </summary>
        public const string SMUSER = "SMUSER";

        /// <summary>
        /// SMPID.
        /// </summary>
        public const string SMPID = "SMPID";

        /// <summary>
        /// SMJOBN.
        /// </summary>
        public const string SMJOBN = "SMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F05102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SMGOAL", "SMGOAL", JdeDataType.String, 20, true, true),
        new JdeField("SMAN8", "SMAN8", JdeDataType.Numeric),
        new JdeField("SMGOLT", "SMGOLT", JdeDataType.String, 2),
        new JdeField("SMGDSC", "SMGDSC", JdeDataType.String, 200),
        new JdeField("SMGMSTS", "SMGMSTS", JdeDataType.String, 8),
        new JdeField("SMGLDT", "SMGLDT", JdeDataType.Numeric),
        new JdeField("SMTINC", "SMTINC", JdeDataType.String, 2),
        new JdeField("SMANPA", "SMANPA", JdeDataType.Numeric),
        new JdeField("SMDEF", "SMDEF", JdeDataType.Numeric),
        new JdeField("SMSERK", "SMSERK", JdeDataType.Numeric),
        new JdeField("SMOTPS", "SMOTPS", JdeDataType.String, 6),
        new JdeField("SMORMCU", "SMORMCU", JdeDataType.String, 24),
        new JdeField("SMJBCD", "SMJBCD", JdeDataType.String, 12),
        new JdeField("SMJBST", "SMJBST", JdeDataType.String, 8),
        new JdeField("SMGCB", "SMGCB", JdeDataType.Numeric),
        new JdeField("SMGOT", "SMGOT", JdeDataType.String, 10),
        new JdeField("SMGMN", "SMGMN", JdeDataType.Numeric),
        new JdeField("SMUPMJ", "SMUPMJ", JdeDataType.Numeric),
        new JdeField("SMUPMT", "SMUPMT", JdeDataType.Numeric),
        new JdeField("SMUSER", "SMUSER", JdeDataType.String, 20),
        new JdeField("SMPID", "SMPID", JdeDataType.String, 20),
        new JdeField("SMJOBN", "SMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05102_0", "Primary Key on SMGOAL", new[] { "SMGOAL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05102_3", "Index on SMAN8, SMGOLT, SMGMSTS", new[] { "SMAN8", "SMGOLT", "SMGMSTS" }),
        new JdeIndex("F05102_4", "Index on SMAN8, SMGLDT", new[] { "SMAN8", "SMGLDT" }),
        new JdeIndex("F05102_5", "Index on SMAN8, SMTINC, SMANPA, SMDEF", new[] { "SMAN8", "SMTINC", "SMANPA", "SMDEF" }),
        new JdeIndex("F05102_6", "Index on SMAN8, SMOTPS, SMORMCU, SMJBCD, SMJBST", new[] { "SMAN8", "SMOTPS", "SMORMCU", "SMJBCD", "SMJBST" }),
        new JdeIndex("F05102_7", "Index on SMSERK", new[] { "SMSERK" })
    };
}
