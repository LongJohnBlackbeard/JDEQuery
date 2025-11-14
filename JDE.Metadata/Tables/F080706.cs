using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F080706 - .
/// </summary>
public class F080706 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FCCONFID.
        /// </summary>
        public const string FCCONFID = "FCCONFID";

        /// <summary>
        /// FCCONFDSC.
        /// </summary>
        public const string FCCONFDSC = "FCCONFDSC";

        /// <summary>
        /// FCCONFNM.
        /// </summary>
        public const string FCCONFNM = "FCCONFNM";

        /// <summary>
        /// FCCONSTS.
        /// </summary>
        public const string FCCONSTS = "FCCONSTS";

        /// <summary>
        /// FCFTPADD.
        /// </summary>
        public const string FCFTPADD = "FCFTPADD";

        /// <summary>
        /// FCFTPUSR.
        /// </summary>
        public const string FCFTPUSR = "FCFTPUSR";

        /// <summary>
        /// FCFTPPWD.
        /// </summary>
        public const string FCFTPPWD = "FCFTPPWD";

        /// <summary>
        /// FCFTPODIR.
        /// </summary>
        public const string FCFTPODIR = "FCFTPODIR";

        /// <summary>
        /// FCFTPIDIR.
        /// </summary>
        public const string FCFTPIDIR = "FCFTPIDIR";

        /// <summary>
        /// FCUPMJ.
        /// </summary>
        public const string FCUPMJ = "FCUPMJ";

        /// <summary>
        /// FCUPMT.
        /// </summary>
        public const string FCUPMT = "FCUPMT";

        /// <summary>
        /// FCUSER.
        /// </summary>
        public const string FCUSER = "FCUSER";

        /// <summary>
        /// FCJOBN.
        /// </summary>
        public const string FCJOBN = "FCJOBN";

        /// <summary>
        /// FCPID.
        /// </summary>
        public const string FCPID = "FCPID";

        /// <summary>
        /// FCCOMPFLG.
        /// </summary>
        public const string FCCOMPFLG = "FCCOMPFLG";
    }

    /// <inheritdoc />
    public override string TableName => "F080706";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FCCONFID", "FCCONFID", JdeDataType.Numeric, null, true, true),
        new JdeField("FCCONFDSC", "FCCONFDSC", JdeDataType.String, 512),
        new JdeField("FCCONFNM", "FCCONFNM", JdeDataType.String, 512),
        new JdeField("FCCONSTS", "FCCONSTS", JdeDataType.String, 2),
        new JdeField("FCFTPADD", "FCFTPADD", JdeDataType.String, 512),
        new JdeField("FCFTPUSR", "FCFTPUSR", JdeDataType.String, 100),
        new JdeField("FCFTPPWD", "FCFTPPWD", JdeDataType.String),
        new JdeField("FCFTPODIR", "FCFTPODIR", JdeDataType.String, 1024),
        new JdeField("FCFTPIDIR", "FCFTPIDIR", JdeDataType.String, 1024),
        new JdeField("FCUPMJ", "FCUPMJ", JdeDataType.Numeric),
        new JdeField("FCUPMT", "FCUPMT", JdeDataType.Numeric),
        new JdeField("FCUSER", "FCUSER", JdeDataType.String, 20),
        new JdeField("FCJOBN", "FCJOBN", JdeDataType.String, 20),
        new JdeField("FCPID", "FCPID", JdeDataType.String, 20),
        new JdeField("FCCOMPFLG", "FCCOMPFLG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F080706_0", "Primary Key on FCCONFID", new[] { "FCCONFID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F080706_2", "Index on FCCONSTS", new[] { "FCCONSTS" })
    };
}
