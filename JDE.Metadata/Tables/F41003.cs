using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41003 - .
/// </summary>
public class F41003 : JdeTable
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
        /// UCJOBN.
        /// </summary>
        public const string UCJOBN = "UCJOBN";

        /// <summary>
        /// UCUPMJ.
        /// </summary>
        public const string UCUPMJ = "UCUPMJ";

        /// <summary>
        /// UCTDAY.
        /// </summary>
        public const string UCTDAY = "UCTDAY";

        /// <summary>
        /// UCEXPO.
        /// </summary>
        public const string UCEXPO = "UCEXPO";

        /// <summary>
        /// UCEXSO.
        /// </summary>
        public const string UCEXSO = "UCEXSO";
    }

    /// <inheritdoc />
    public override string TableName => "F41003";

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
        new JdeField("UCJOBN", "UCJOBN", JdeDataType.String, 20),
        new JdeField("UCUPMJ", "UCUPMJ", JdeDataType.Numeric),
        new JdeField("UCTDAY", "UCTDAY", JdeDataType.Numeric),
        new JdeField("UCEXPO", "UCEXPO", JdeDataType.String, 2),
        new JdeField("UCEXSO", "UCEXSO", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41003_0", "Primary Key on UCUM, UCRUM", new[] { "UCUM", "UCRUM" }, isUnique: true, isPrimaryKey: true)
    };
}
