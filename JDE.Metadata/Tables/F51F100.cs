using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51F100 - .
/// </summary>
public class F51F100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QF51FFID.
        /// </summary>
        public const string QF51FFID = "QF51FFID";

        /// <summary>
        /// QFMCU.
        /// </summary>
        public const string QFMCU = "QFMCU";

        /// <summary>
        /// QF51FNAME.
        /// </summary>
        public const string QF51FNAME = "QF51FNAME";

        /// <summary>
        /// QF51FSTATS.
        /// </summary>
        public const string QF51FSTATS = "QF51FSTATS";

        /// <summary>
        /// QF51FFBD.
        /// </summary>
        public const string QF51FFBD = "QF51FFBD";

        /// <summary>
        /// QF51FFBT.
        /// </summary>
        public const string QF51FFBT = "QF51FFBT";

        /// <summary>
        /// QFDGJ.
        /// </summary>
        public const string QFDGJ = "QFDGJ";

        /// <summary>
        /// QF51FPF.
        /// </summary>
        public const string QF51FPF = "QF51FPF";

        /// <summary>
        /// QFTORG.
        /// </summary>
        public const string QFTORG = "QFTORG";

        /// <summary>
        /// QFENTJ.
        /// </summary>
        public const string QFENTJ = "QFENTJ";

        /// <summary>
        /// QFTENT.
        /// </summary>
        public const string QFTENT = "QFTENT";

        /// <summary>
        /// QFUSER.
        /// </summary>
        public const string QFUSER = "QFUSER";

        /// <summary>
        /// QFUPMJ.
        /// </summary>
        public const string QFUPMJ = "QFUPMJ";

        /// <summary>
        /// QFUPMT.
        /// </summary>
        public const string QFUPMT = "QFUPMT";

        /// <summary>
        /// QFJOBN.
        /// </summary>
        public const string QFJOBN = "QFJOBN";

        /// <summary>
        /// QFPID.
        /// </summary>
        public const string QFPID = "QFPID";

        /// <summary>
        /// QFMKEY.
        /// </summary>
        public const string QFMKEY = "QFMKEY";

        /// <summary>
        /// QFPN.
        /// </summary>
        public const string QFPN = "QFPN";

        /// <summary>
        /// QFFY.
        /// </summary>
        public const string QFFY = "QFFY";

        /// <summary>
        /// QFCTRY.
        /// </summary>
        public const string QFCTRY = "QFCTRY";
    }

    /// <inheritdoc />
    public override string TableName => "F51F100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QF51FFID", "QF51FFID", JdeDataType.Numeric, null, true, true),
        new JdeField("QFMCU", "QFMCU", JdeDataType.String, 24),
        new JdeField("QF51FNAME", "QF51FNAME", JdeDataType.String, 60),
        new JdeField("QF51FSTATS", "QF51FSTATS", JdeDataType.String, 4),
        new JdeField("QF51FFBD", "QF51FFBD", JdeDataType.Numeric),
        new JdeField("QF51FFBT", "QF51FFBT", JdeDataType.Numeric),
        new JdeField("QFDGJ", "QFDGJ", JdeDataType.Numeric),
        new JdeField("QF51FPF", "QF51FPF", JdeDataType.String, 2),
        new JdeField("QFTORG", "QFTORG", JdeDataType.String, 20),
        new JdeField("QFENTJ", "QFENTJ", JdeDataType.Numeric),
        new JdeField("QFTENT", "QFTENT", JdeDataType.Numeric),
        new JdeField("QFUSER", "QFUSER", JdeDataType.String, 20),
        new JdeField("QFUPMJ", "QFUPMJ", JdeDataType.Numeric),
        new JdeField("QFUPMT", "QFUPMT", JdeDataType.Numeric),
        new JdeField("QFJOBN", "QFJOBN", JdeDataType.String, 20),
        new JdeField("QFPID", "QFPID", JdeDataType.String, 20),
        new JdeField("QFMKEY", "QFMKEY", JdeDataType.String, 30),
        new JdeField("QFPN", "QFPN", JdeDataType.Numeric),
        new JdeField("QFFY", "QFFY", JdeDataType.Numeric),
        new JdeField("QFCTRY", "QFCTRY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51F100_0", "Primary Key on QF51FFID", new[] { "QF51FFID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F51F100_2", "Index on QFMCU, QF51FSTATS, SYS_NC00021$", new[] { "QFMCU", "QF51FSTATS", "SYS_NC00021$" }),
        new JdeIndex("F51F100_3", "Index on SYS_NC00021$, QFMCU, SYS_NC00022$", new[] { "SYS_NC00021$", "QFMCU", "SYS_NC00022$" }),
        new JdeIndex("F51F100_4", "Index on QFMCU, QFPN, SYS_NC00023$, SYS_NC00024$", new[] { "QFMCU", "QFPN", "SYS_NC00023$", "SYS_NC00024$" })
    };
}
