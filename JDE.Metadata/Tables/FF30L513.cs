using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L513 - .
/// </summary>
public class FF30L513 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UCUM.
        /// </summary>
        public const string UCUM = "UCUM";

        /// <summary>
        /// UCRUM.
        /// </summary>
        public const string UCRUM = "UCRUM";

        /// <summary>
        /// UCCONV.
        /// </summary>
        public const string UCCONV = "UCCONV";

        /// <summary>
        /// UCUSER.
        /// </summary>
        public const string UCUSER = "UCUSER";

        /// <summary>
        /// UCPID.
        /// </summary>
        public const string UCPID = "UCPID";

        /// <summary>
        /// UCMKEY.
        /// </summary>
        public const string UCMKEY = "UCMKEY";

        /// <summary>
        /// UCUUPMJ.
        /// </summary>
        public const string UCUUPMJ = "UCUUPMJ";

        /// <summary>
        /// UCEXPO.
        /// </summary>
        public const string UCEXPO = "UCEXPO";

        /// <summary>
        /// UCEXSO.
        /// </summary>
        public const string UCEXSO = "UCEXSO";

        /// <summary>
        /// UCURCD.
        /// </summary>
        public const string UCURCD = "UCURCD";

        /// <summary>
        /// UCURDT.
        /// </summary>
        public const string UCURDT = "UCURDT";

        /// <summary>
        /// UCURAT.
        /// </summary>
        public const string UCURAT = "UCURAT";

        /// <summary>
        /// UCURAB.
        /// </summary>
        public const string UCURAB = "UCURAB";

        /// <summary>
        /// UCURRF.
        /// </summary>
        public const string UCURRF = "UCURRF";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L513";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UCUM", "UCUM", JdeDataType.String, 4, true, true),
        new JdeField("UCRUM", "UCRUM", JdeDataType.String, 4, true, true),
        new JdeField("UCCONV", "UCCONV", JdeDataType.Numeric),
        new JdeField("UCUSER", "UCUSER", JdeDataType.String, 20),
        new JdeField("UCPID", "UCPID", JdeDataType.String, 20),
        new JdeField("UCMKEY", "UCMKEY", JdeDataType.String, 30),
        new JdeField("UCUUPMJ", "UCUUPMJ", JdeDataType.Date),
        new JdeField("UCEXPO", "UCEXPO", JdeDataType.String, 2),
        new JdeField("UCEXSO", "UCEXSO", JdeDataType.String, 2),
        new JdeField("UCURCD", "UCURCD", JdeDataType.String, 4),
        new JdeField("UCURDT", "UCURDT", JdeDataType.Numeric),
        new JdeField("UCURAT", "UCURAT", JdeDataType.Numeric),
        new JdeField("UCURAB", "UCURAB", JdeDataType.Numeric),
        new JdeField("UCURRF", "UCURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L513_0", "Primary Key on UCUM, UCRUM", new[] { "UCUM", "UCRUM" }, isUnique: true, isPrimaryKey: true)
    };
}
