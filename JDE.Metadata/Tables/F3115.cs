using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3115 - .
/// </summary>
public class F3115 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NCPRJM.
        /// </summary>
        public const string NCPRJM = "NCPRJM";

        /// <summary>
        /// NCDOCO.
        /// </summary>
        public const string NCDOCO = "NCDOCO";

        /// <summary>
        /// NCDCTO.
        /// </summary>
        public const string NCDCTO = "NCDCTO";

        /// <summary>
        /// NCMMCU.
        /// </summary>
        public const string NCMMCU = "NCMMCU";

        /// <summary>
        /// NCSRST.
        /// </summary>
        public const string NCSRST = "NCSRST";

        /// <summary>
        /// NCTYPS.
        /// </summary>
        public const string NCTYPS = "NCTYPS";

        /// <summary>
        /// NCSTRT.
        /// </summary>
        public const string NCSTRT = "NCSTRT";

        /// <summary>
        /// NCDRQJ.
        /// </summary>
        public const string NCDRQJ = "NCDRQJ";

        /// <summary>
        /// NCUITM.
        /// </summary>
        public const string NCUITM = "NCUITM";

        /// <summary>
        /// NCITM.
        /// </summary>
        public const string NCITM = "NCITM";

        /// <summary>
        /// NCUORG.
        /// </summary>
        public const string NCUORG = "NCUORG";

        /// <summary>
        /// NCUOM.
        /// </summary>
        public const string NCUOM = "NCUOM";

        /// <summary>
        /// NCUSER.
        /// </summary>
        public const string NCUSER = "NCUSER";

        /// <summary>
        /// NCUPMJ.
        /// </summary>
        public const string NCUPMJ = "NCUPMJ";

        /// <summary>
        /// NCTDAY.
        /// </summary>
        public const string NCTDAY = "NCTDAY";

        /// <summary>
        /// NCPID.
        /// </summary>
        public const string NCPID = "NCPID";

        /// <summary>
        /// NCMKEY.
        /// </summary>
        public const string NCMKEY = "NCMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F3115";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NCPRJM", "NCPRJM", JdeDataType.Numeric, null, true, true),
        new JdeField("NCDOCO", "NCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NCDCTO", "NCDCTO", JdeDataType.String, 4),
        new JdeField("NCMMCU", "NCMMCU", JdeDataType.String, 24),
        new JdeField("NCSRST", "NCSRST", JdeDataType.String, 4),
        new JdeField("NCTYPS", "NCTYPS", JdeDataType.String, 2),
        new JdeField("NCSTRT", "NCSTRT", JdeDataType.Numeric),
        new JdeField("NCDRQJ", "NCDRQJ", JdeDataType.Numeric),
        new JdeField("NCUITM", "NCUITM", JdeDataType.String, 52),
        new JdeField("NCITM", "NCITM", JdeDataType.Numeric),
        new JdeField("NCUORG", "NCUORG", JdeDataType.Numeric),
        new JdeField("NCUOM", "NCUOM", JdeDataType.String, 4),
        new JdeField("NCUSER", "NCUSER", JdeDataType.String, 20),
        new JdeField("NCUPMJ", "NCUPMJ", JdeDataType.Numeric),
        new JdeField("NCTDAY", "NCTDAY", JdeDataType.Numeric),
        new JdeField("NCPID", "NCPID", JdeDataType.String, 20),
        new JdeField("NCMKEY", "NCMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3115_0", "Primary Key on NCPRJM, NCDOCO", new[] { "NCPRJM", "NCDOCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3115_2", "Index on NCDOCO", new[] { "NCDOCO" })
    };
}
