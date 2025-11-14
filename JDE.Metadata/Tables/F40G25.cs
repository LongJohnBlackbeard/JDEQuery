using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G25 - .
/// </summary>
public class F40G25 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFMATH01.
        /// </summary>
        public const string WFMATH01 = "WFMATH01";

        /// <summary>
        /// WFWOPID.
        /// </summary>
        public const string WFWOPID = "WFWOPID";

        /// <summary>
        /// WFCNTF.
        /// </summary>
        public const string WFCNTF = "WFCNTF";

        /// <summary>
        /// WFBLSCD2.
        /// </summary>
        public const string WFBLSCD2 = "WFBLSCD2";

        /// <summary>
        /// WFHARPER.
        /// </summary>
        public const string WFHARPER = "WFHARPER";

        /// <summary>
        /// WFHARSFX.
        /// </summary>
        public const string WFHARSFX = "WFHARSFX";

        /// <summary>
        /// WFVARCODE.
        /// </summary>
        public const string WFVARCODE = "WFVARCODE";

        /// <summary>
        /// WFWOPN.
        /// </summary>
        public const string WFWOPN = "WFWOPN";

        /// <summary>
        /// WFWCDL01.
        /// </summary>
        public const string WFWCDL01 = "WFWCDL01";

        /// <summary>
        /// WFWOPST.
        /// </summary>
        public const string WFWOPST = "WFWOPST";

        /// <summary>
        /// WFWASDT.
        /// </summary>
        public const string WFWASDT = "WFWASDT";

        /// <summary>
        /// WFWAEDT.
        /// </summary>
        public const string WFWAEDT = "WFWAEDT";

        /// <summary>
        /// WFDL01.
        /// </summary>
        public const string WFDL01 = "WFDL01";

        /// <summary>
        /// WFDESC.
        /// </summary>
        public const string WFDESC = "WFDESC";

        /// <summary>
        /// WFWVID.
        /// </summary>
        public const string WFWVID = "WFWVID";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFUPMT.
        /// </summary>
        public const string WFUPMT = "WFUPMT";

        /// <summary>
        /// WFJOBN.
        /// </summary>
        public const string WFJOBN = "WFJOBN";

        /// <summary>
        /// WFWDOCO.
        /// </summary>
        public const string WFWDOCO = "WFWDOCO";

        /// <summary>
        /// WFWJOBN.
        /// </summary>
        public const string WFWJOBN = "WFWJOBN";

        /// <summary>
        /// WFWSD.
        /// </summary>
        public const string WFWSD = "WFWSD";

        /// <summary>
        /// WFWCOPCD.
        /// </summary>
        public const string WFWCOPCD = "WFWCOPCD";
    }

    /// <inheritdoc />
    public override string TableName => "F40G25";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFMATH01", "WFMATH01", JdeDataType.Numeric, null, true, true),
        new JdeField("WFWOPID", "WFWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCNTF", "WFCNTF", JdeDataType.Numeric, null, true, true),
        new JdeField("WFBLSCD2", "WFBLSCD2", JdeDataType.String, 20),
        new JdeField("WFHARPER", "WFHARPER", JdeDataType.String, 12),
        new JdeField("WFHARSFX", "WFHARSFX", JdeDataType.String, 20),
        new JdeField("WFVARCODE", "WFVARCODE", JdeDataType.String, 10),
        new JdeField("WFWOPN", "WFWOPN", JdeDataType.Numeric),
        new JdeField("WFWCDL01", "WFWCDL01", JdeDataType.String, 60),
        new JdeField("WFWOPST", "WFWOPST", JdeDataType.String, 20),
        new JdeField("WFWASDT", "WFWASDT", JdeDataType.Date),
        new JdeField("WFWAEDT", "WFWAEDT", JdeDataType.Date),
        new JdeField("WFDL01", "WFDL01", JdeDataType.String, 60),
        new JdeField("WFDESC", "WFDESC", JdeDataType.String, 60),
        new JdeField("WFWVID", "WFWVID", JdeDataType.Numeric),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20),
        new JdeField("WFWDOCO", "WFWDOCO", JdeDataType.Numeric),
        new JdeField("WFWJOBN", "WFWJOBN", JdeDataType.Numeric),
        new JdeField("WFWSD", "WFWSD", JdeDataType.String, 60),
        new JdeField("WFWCOPCD", "WFWCOPCD", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G25_0", "Primary Key on WFMATH01, WFWOPID, WFCNTF", new[] { "WFMATH01", "WFWOPID", "WFCNTF" }, isUnique: true, isPrimaryKey: true)
    };
}
