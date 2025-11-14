using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B25 - .
/// </summary>
public class F31B25 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRJOBS.
        /// </summary>
        public const string TRJOBS = "TRJOBS";

        /// <summary>
        /// TRRT1.
        /// </summary>
        public const string TRRT1 = "TRRT1";

        /// <summary>
        /// TRTSRT.
        /// </summary>
        public const string TRTSRT = "TRTSRT";

        /// <summary>
        /// TRTSTRSNM.
        /// </summary>
        public const string TRTSTRSNM = "TRTSTRSNM";

        /// <summary>
        /// TRWOPID.
        /// </summary>
        public const string TRWOPID = "TRWOPID";

        /// <summary>
        /// TRWFTF.
        /// </summary>
        public const string TRWFTF = "TRWFTF";

        /// <summary>
        /// TRWOPN.
        /// </summary>
        public const string TRWOPN = "TRWOPN";

        /// <summary>
        /// TRWBOPCD.
        /// </summary>
        public const string TRWBOPCD = "TRWBOPCD";

        /// <summary>
        /// TRWCOPCD.
        /// </summary>
        public const string TRWCOPCD = "TRWCOPCD";

        /// <summary>
        /// TRWCDL01.
        /// </summary>
        public const string TRWCDL01 = "TRWCDL01";

        /// <summary>
        /// TRMCU.
        /// </summary>
        public const string TRMCU = "TRMCU";

        /// <summary>
        /// TRRSSTS.
        /// </summary>
        public const string TRRSSTS = "TRRSSTS";

        /// <summary>
        /// TRWVNUM.
        /// </summary>
        public const string TRWVNUM = "TRWVNUM";

        /// <summary>
        /// TRWALOTN.
        /// </summary>
        public const string TRWALOTN = "TRWALOTN";

        /// <summary>
        /// TRWBLOTN.
        /// </summary>
        public const string TRWBLOTN = "TRWBLOTN";

        /// <summary>
        /// TRWVTY.
        /// </summary>
        public const string TRWVTY = "TRWVTY";

        /// <summary>
        /// TRWBID.
        /// </summary>
        public const string TRWBID = "TRWBID";

        /// <summary>
        /// TRWSD.
        /// </summary>
        public const string TRWSD = "TRWSD";

        /// <summary>
        /// TRWSDT.
        /// </summary>
        public const string TRWSDT = "TRWSDT";

        /// <summary>
        /// TRQTST.
        /// </summary>
        public const string TRQTST = "TRQTST";

        /// <summary>
        /// TRQVAL.
        /// </summary>
        public const string TRQVAL = "TRQVAL";

        /// <summary>
        /// TRQPF.
        /// </summary>
        public const string TRQPF = "TRQPF";

        /// <summary>
        /// TRCNTF.
        /// </summary>
        public const string TRCNTF = "TRCNTF";

        /// <summary>
        /// TREV01.
        /// </summary>
        public const string TREV01 = "TREV01";

        /// <summary>
        /// TRWEDT.
        /// </summary>
        public const string TRWEDT = "TRWEDT";

        /// <summary>
        /// TRWASDT.
        /// </summary>
        public const string TRWASDT = "TRWASDT";

        /// <summary>
        /// TRWAEDT.
        /// </summary>
        public const string TRWAEDT = "TRWAEDT";

        /// <summary>
        /// TRWOPST.
        /// </summary>
        public const string TRWOPST = "TRWOPST";
    }

    /// <inheritdoc />
    public override string TableName => "F31B25";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRJOBS", "TRJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TRRT1", "TRRT1", JdeDataType.String, 4, true, true),
        new JdeField("TRTSRT", "TRTSRT", JdeDataType.Numeric, null, true, true),
        new JdeField("TRTSTRSNM", "TRTSTRSNM", JdeDataType.String, 60, true, true),
        new JdeField("TRWOPID", "TRWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("TRWFTF", "TRWFTF", JdeDataType.String, 2, true, true),
        new JdeField("TRWOPN", "TRWOPN", JdeDataType.Numeric),
        new JdeField("TRWBOPCD", "TRWBOPCD", JdeDataType.String, 20),
        new JdeField("TRWCOPCD", "TRWCOPCD", JdeDataType.String, 20),
        new JdeField("TRWCDL01", "TRWCDL01", JdeDataType.String, 60),
        new JdeField("TRMCU", "TRMCU", JdeDataType.String, 24),
        new JdeField("TRRSSTS", "TRRSSTS", JdeDataType.String, 2),
        new JdeField("TRWVNUM", "TRWVNUM", JdeDataType.String, 60),
        new JdeField("TRWALOTN", "TRWALOTN", JdeDataType.String, 60),
        new JdeField("TRWBLOTN", "TRWBLOTN", JdeDataType.String, 60),
        new JdeField("TRWVTY", "TRWVTY", JdeDataType.String, 2),
        new JdeField("TRWBID", "TRWBID", JdeDataType.String, 60),
        new JdeField("TRWSD", "TRWSD", JdeDataType.String, 60),
        new JdeField("TRWSDT", "TRWSDT", JdeDataType.Date),
        new JdeField("TRQTST", "TRQTST", JdeDataType.String, 50),
        new JdeField("TRQVAL", "TRQVAL", JdeDataType.String, 30),
        new JdeField("TRQPF", "TRQPF", JdeDataType.String, 2),
        new JdeField("TRCNTF", "TRCNTF", JdeDataType.Numeric),
        new JdeField("TREV01", "TREV01", JdeDataType.String, 2),
        new JdeField("TRWEDT", "TRWEDT", JdeDataType.Date),
        new JdeField("TRWASDT", "TRWASDT", JdeDataType.Date),
        new JdeField("TRWAEDT", "TRWAEDT", JdeDataType.Date),
        new JdeField("TRWOPST", "TRWOPST", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B25_0", "Primary Key on TRJOBS, TRWOPID, TRRT1, TRTSRT, TRTSTRSNM, TRWFTF", new[] { "TRJOBS", "TRWOPID", "TRRT1", "TRTSRT", "TRTSTRSNM", "TRWFTF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B25_2", "Index on TRJOBS, SYS_NC00029$, TRRT1, TRTSRT, TRTSTRSNM", new[] { "TRJOBS", "SYS_NC00029$", "TRRT1", "TRTSRT", "TRTSTRSNM" }),
        new JdeIndex("F31B25_3", "Index on TRJOBS, TRRT1, TRTSRT", new[] { "TRJOBS", "TRRT1", "TRTSRT" }),
        new JdeIndex("F31B25_4", "Index on TRJOBS, TRCNTF, TRWALOTN", new[] { "TRJOBS", "TRCNTF", "TRWALOTN" }),
        new JdeIndex("F31B25_5", "Index on TRJOBS, SYS_NC00030$, SYS_NC00031$, TRRT1, TRTSRT, TRTSTRSNM, TRWFTF", new[] { "TRJOBS", "SYS_NC00030$", "SYS_NC00031$", "TRRT1", "TRTSRT", "TRTSTRSNM", "TRWFTF" })
    };
}
