using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F10520 - .
/// </summary>
public class F10520 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CFUDCCF.
        /// </summary>
        public const string CFUDCCF = "CFUDCCF";

        /// <summary>
        /// CFLIN.
        /// </summary>
        public const string CFLIN = "CFLIN";

        /// <summary>
        /// CFLNID.
        /// </summary>
        public const string CFLNID = "CFLNID";

        /// <summary>
        /// CFDCF01.
        /// </summary>
        public const string CFDCF01 = "CFDCF01";

        /// <summary>
        /// CFOBJF.
        /// </summary>
        public const string CFOBJF = "CFOBJF";

        /// <summary>
        /// CFFSUB.
        /// </summary>
        public const string CFFSUB = "CFFSUB";

        /// <summary>
        /// CFOBJT.
        /// </summary>
        public const string CFOBJT = "CFOBJT";

        /// <summary>
        /// CFSUBT.
        /// </summary>
        public const string CFSUBT = "CFSUBT";

        /// <summary>
        /// CFITEM.
        /// </summary>
        public const string CFITEM = "CFITEM";

        /// <summary>
        /// CFUSER.
        /// </summary>
        public const string CFUSER = "CFUSER";

        /// <summary>
        /// CFPID.
        /// </summary>
        public const string CFPID = "CFPID";

        /// <summary>
        /// CFJOBN.
        /// </summary>
        public const string CFJOBN = "CFJOBN";

        /// <summary>
        /// CFUPMJ.
        /// </summary>
        public const string CFUPMJ = "CFUPMJ";

        /// <summary>
        /// CFUPMT.
        /// </summary>
        public const string CFUPMT = "CFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F10520";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CFUDCCF", "CFUDCCF", JdeDataType.String, 20, true, true),
        new JdeField("CFLIN", "CFLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("CFLNID", "CFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CFDCF01", "CFDCF01", JdeDataType.String, 120),
        new JdeField("CFOBJF", "CFOBJF", JdeDataType.String, 12),
        new JdeField("CFFSUB", "CFFSUB", JdeDataType.String, 16),
        new JdeField("CFOBJT", "CFOBJT", JdeDataType.String, 12),
        new JdeField("CFSUBT", "CFSUBT", JdeDataType.String, 16),
        new JdeField("CFITEM", "CFITEM", JdeDataType.String, 12),
        new JdeField("CFUSER", "CFUSER", JdeDataType.String, 20),
        new JdeField("CFPID", "CFPID", JdeDataType.String, 20),
        new JdeField("CFJOBN", "CFJOBN", JdeDataType.String, 20),
        new JdeField("CFUPMJ", "CFUPMJ", JdeDataType.Numeric),
        new JdeField("CFUPMT", "CFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F10520_0", "Primary Key on CFUDCCF, CFLIN, CFLNID", new[] { "CFUDCCF", "CFLIN", "CFLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F10520_2", "Index on CFUDCCF, CFLIN", new[] { "CFUDCCF", "CFLIN" })
    };
}
