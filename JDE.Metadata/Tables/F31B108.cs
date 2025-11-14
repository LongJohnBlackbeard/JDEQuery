using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B108 - .
/// </summary>
public class F31B108 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FDNCFRMTID.
        /// </summary>
        public const string FDNCFRMTID = "FDNCFRMTID";

        /// <summary>
        /// FDNCFSQNO.
        /// </summary>
        public const string FDNCFSQNO = "FDNCFSQNO";

        /// <summary>
        /// FDNCID.
        /// </summary>
        public const string FDNCID = "FDNCID";

        /// <summary>
        /// FDNCOBNM.
        /// </summary>
        public const string FDNCOBNM = "FDNCOBNM";

        /// <summary>
        /// FDURAB.
        /// </summary>
        public const string FDURAB = "FDURAB";

        /// <summary>
        /// FDURAT.
        /// </summary>
        public const string FDURAT = "FDURAT";

        /// <summary>
        /// FDURCD.
        /// </summary>
        public const string FDURCD = "FDURCD";

        /// <summary>
        /// FDURDT.
        /// </summary>
        public const string FDURDT = "FDURDT";

        /// <summary>
        /// FDURRF.
        /// </summary>
        public const string FDURRF = "FDURRF";

        /// <summary>
        /// FDWAB.
        /// </summary>
        public const string FDWAB = "FDWAB";

        /// <summary>
        /// FDWNUM.
        /// </summary>
        public const string FDWNUM = "FDWNUM";

        /// <summary>
        /// FDWCD.
        /// </summary>
        public const string FDWCD = "FDWCD";

        /// <summary>
        /// FDWMDT.
        /// </summary>
        public const string FDWMDT = "FDWMDT";

        /// <summary>
        /// FDWRF.
        /// </summary>
        public const string FDWRF = "FDWRF";

        /// <summary>
        /// FDUSER.
        /// </summary>
        public const string FDUSER = "FDUSER";

        /// <summary>
        /// FDUPMJ.
        /// </summary>
        public const string FDUPMJ = "FDUPMJ";

        /// <summary>
        /// FDUPMT.
        /// </summary>
        public const string FDUPMT = "FDUPMT";

        /// <summary>
        /// FDJOBN.
        /// </summary>
        public const string FDJOBN = "FDJOBN";

        /// <summary>
        /// FDMKEY.
        /// </summary>
        public const string FDMKEY = "FDMKEY";

        /// <summary>
        /// FDPID.
        /// </summary>
        public const string FDPID = "FDPID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B108";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FDNCFRMTID", "FDNCFRMTID", JdeDataType.Numeric, null, true, true),
        new JdeField("FDNCFSQNO", "FDNCFSQNO", JdeDataType.Numeric, null, true, true),
        new JdeField("FDNCID", "FDNCID", JdeDataType.Numeric),
        new JdeField("FDNCOBNM", "FDNCOBNM", JdeDataType.String, 20),
        new JdeField("FDURAB", "FDURAB", JdeDataType.Numeric),
        new JdeField("FDURAT", "FDURAT", JdeDataType.Numeric),
        new JdeField("FDURCD", "FDURCD", JdeDataType.String, 4),
        new JdeField("FDURDT", "FDURDT", JdeDataType.Numeric),
        new JdeField("FDURRF", "FDURRF", JdeDataType.String, 30),
        new JdeField("FDWAB", "FDWAB", JdeDataType.Numeric),
        new JdeField("FDWNUM", "FDWNUM", JdeDataType.Numeric),
        new JdeField("FDWCD", "FDWCD", JdeDataType.String, 6),
        new JdeField("FDWMDT", "FDWMDT", JdeDataType.Numeric),
        new JdeField("FDWRF", "FDWRF", JdeDataType.String, 60),
        new JdeField("FDUSER", "FDUSER", JdeDataType.String, 20),
        new JdeField("FDUPMJ", "FDUPMJ", JdeDataType.Numeric),
        new JdeField("FDUPMT", "FDUPMT", JdeDataType.Numeric),
        new JdeField("FDJOBN", "FDJOBN", JdeDataType.String, 20),
        new JdeField("FDMKEY", "FDMKEY", JdeDataType.String, 30),
        new JdeField("FDPID", "FDPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B108_0", "Primary Key on FDNCFRMTID, FDNCFSQNO", new[] { "FDNCFRMTID", "FDNCFSQNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B108_2", "Index on FDNCID", new[] { "FDNCID" })
    };
}
