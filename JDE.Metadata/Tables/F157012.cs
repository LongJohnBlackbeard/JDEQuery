using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F157012 - .
/// </summary>
public class F157012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NCOPTY.
        /// </summary>
        public const string NCOPTY = "NCOPTY";

        /// <summary>
        /// NCODET.
        /// </summary>
        public const string NCODET = "NCODET";

        /// <summary>
        /// NCDTLD.
        /// </summary>
        public const string NCDTLD = "NCDTLD";

        /// <summary>
        /// NCSTDO.
        /// </summary>
        public const string NCSTDO = "NCSTDO";

        /// <summary>
        /// NCSTDL.
        /// </summary>
        public const string NCSTDL = "NCSTDL";

        /// <summary>
        /// NCAN8.
        /// </summary>
        public const string NCAN8 = "NCAN8";

        /// <summary>
        /// NCLSET.
        /// </summary>
        public const string NCLSET = "NCLSET";

        /// <summary>
        /// NCRECO.
        /// </summary>
        public const string NCRECO = "NCRECO";

        /// <summary>
        /// NCURCD.
        /// </summary>
        public const string NCURCD = "NCURCD";

        /// <summary>
        /// NCURDT.
        /// </summary>
        public const string NCURDT = "NCURDT";

        /// <summary>
        /// NCURAT.
        /// </summary>
        public const string NCURAT = "NCURAT";

        /// <summary>
        /// NCURAB.
        /// </summary>
        public const string NCURAB = "NCURAB";

        /// <summary>
        /// NCURRF.
        /// </summary>
        public const string NCURRF = "NCURRF";

        /// <summary>
        /// NCUSER.
        /// </summary>
        public const string NCUSER = "NCUSER";

        /// <summary>
        /// NCPID.
        /// </summary>
        public const string NCPID = "NCPID";

        /// <summary>
        /// NCUPMJ.
        /// </summary>
        public const string NCUPMJ = "NCUPMJ";

        /// <summary>
        /// NCUPMT.
        /// </summary>
        public const string NCUPMT = "NCUPMT";

        /// <summary>
        /// NCJOBN.
        /// </summary>
        public const string NCJOBN = "NCJOBN";

        /// <summary>
        /// NCENTJ.
        /// </summary>
        public const string NCENTJ = "NCENTJ";

        /// <summary>
        /// NCTORG.
        /// </summary>
        public const string NCTORG = "NCTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F157012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NCOPTY", "NCOPTY", JdeDataType.String, 8, true, true),
        new JdeField("NCODET", "NCODET", JdeDataType.String, 20, true, true),
        new JdeField("NCDTLD", "NCDTLD", JdeDataType.String, 80),
        new JdeField("NCSTDO", "NCSTDO", JdeDataType.String, 2),
        new JdeField("NCSTDL", "NCSTDL", JdeDataType.String, 2),
        new JdeField("NCAN8", "NCAN8", JdeDataType.Numeric),
        new JdeField("NCLSET", "NCLSET", JdeDataType.String, 4),
        new JdeField("NCRECO", "NCRECO", JdeDataType.String, 20),
        new JdeField("NCURCD", "NCURCD", JdeDataType.String, 4),
        new JdeField("NCURDT", "NCURDT", JdeDataType.Numeric),
        new JdeField("NCURAT", "NCURAT", JdeDataType.Numeric),
        new JdeField("NCURAB", "NCURAB", JdeDataType.Numeric),
        new JdeField("NCURRF", "NCURRF", JdeDataType.String, 30),
        new JdeField("NCUSER", "NCUSER", JdeDataType.String, 20),
        new JdeField("NCPID", "NCPID", JdeDataType.String, 20),
        new JdeField("NCUPMJ", "NCUPMJ", JdeDataType.Numeric),
        new JdeField("NCUPMT", "NCUPMT", JdeDataType.Numeric),
        new JdeField("NCJOBN", "NCJOBN", JdeDataType.String, 20),
        new JdeField("NCENTJ", "NCENTJ", JdeDataType.Numeric),
        new JdeField("NCTORG", "NCTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F157012_0", "Primary Key on NCOPTY, NCODET", new[] { "NCOPTY", "NCODET" }, isUnique: true, isPrimaryKey: true)
    };
}
