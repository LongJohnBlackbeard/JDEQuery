using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F157012D - .
/// </summary>
public class F157012D : JdeTable
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
        /// NCLNGP.
        /// </summary>
        public const string NCLNGP = "NCLNGP";

        /// <summary>
        /// NCDTLD.
        /// </summary>
        public const string NCDTLD = "NCDTLD";

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
        /// NCTORG.
        /// </summary>
        public const string NCTORG = "NCTORG";

        /// <summary>
        /// NCENTJ.
        /// </summary>
        public const string NCENTJ = "NCENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F157012D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NCOPTY", "NCOPTY", JdeDataType.String, 8, true, true),
        new JdeField("NCODET", "NCODET", JdeDataType.String, 20, true, true),
        new JdeField("NCLNGP", "NCLNGP", JdeDataType.String, 4, true, true),
        new JdeField("NCDTLD", "NCDTLD", JdeDataType.String, 80),
        new JdeField("NCUSER", "NCUSER", JdeDataType.String, 20),
        new JdeField("NCPID", "NCPID", JdeDataType.String, 20),
        new JdeField("NCUPMJ", "NCUPMJ", JdeDataType.Numeric),
        new JdeField("NCUPMT", "NCUPMT", JdeDataType.Numeric),
        new JdeField("NCJOBN", "NCJOBN", JdeDataType.String, 20),
        new JdeField("NCTORG", "NCTORG", JdeDataType.String, 20),
        new JdeField("NCENTJ", "NCENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F157012D_0", "Primary Key on NCOPTY, NCODET, NCLNGP", new[] { "NCOPTY", "NCODET", "NCLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
