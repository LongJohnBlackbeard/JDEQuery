using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D203 - .
/// </summary>
public class F80D203 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FCPRDJ.
        /// </summary>
        public const string FCPRDJ = "FCPRDJ";

        /// <summary>
        /// FCMCU.
        /// </summary>
        public const string FCMCU = "FCMCU";

        /// <summary>
        /// FCAMSB.
        /// </summary>
        public const string FCAMSB = "FCAMSB";

        /// <summary>
        /// FCAMIF.
        /// </summary>
        public const string FCAMIF = "FCAMIF";

        /// <summary>
        /// FCAMOF.
        /// </summary>
        public const string FCAMOF = "FCAMOF";

        /// <summary>
        /// FCUSER.
        /// </summary>
        public const string FCUSER = "FCUSER";

        /// <summary>
        /// FCPID.
        /// </summary>
        public const string FCPID = "FCPID";

        /// <summary>
        /// FCMKEY.
        /// </summary>
        public const string FCMKEY = "FCMKEY";

        /// <summary>
        /// FCUTIME.
        /// </summary>
        public const string FCUTIME = "FCUTIME";

        /// <summary>
        /// FCURCD.
        /// </summary>
        public const string FCURCD = "FCURCD";

        /// <summary>
        /// FCURDT.
        /// </summary>
        public const string FCURDT = "FCURDT";

        /// <summary>
        /// FCURAT.
        /// </summary>
        public const string FCURAT = "FCURAT";

        /// <summary>
        /// FCURAB.
        /// </summary>
        public const string FCURAB = "FCURAB";

        /// <summary>
        /// FCURRF.
        /// </summary>
        public const string FCURRF = "FCURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D203";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FCPRDJ", "FCPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("FCMCU", "FCMCU", JdeDataType.String, 24, true, true),
        new JdeField("FCAMSB", "FCAMSB", JdeDataType.Numeric),
        new JdeField("FCAMIF", "FCAMIF", JdeDataType.Numeric),
        new JdeField("FCAMOF", "FCAMOF", JdeDataType.Numeric),
        new JdeField("FCUSER", "FCUSER", JdeDataType.String, 20),
        new JdeField("FCPID", "FCPID", JdeDataType.String, 20),
        new JdeField("FCMKEY", "FCMKEY", JdeDataType.String, 30),
        new JdeField("FCUTIME", "FCUTIME", JdeDataType.Date),
        new JdeField("FCURCD", "FCURCD", JdeDataType.String, 4),
        new JdeField("FCURDT", "FCURDT", JdeDataType.Numeric),
        new JdeField("FCURAT", "FCURAT", JdeDataType.Numeric),
        new JdeField("FCURAB", "FCURAB", JdeDataType.Numeric),
        new JdeField("FCURRF", "FCURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D203_0", "Primary Key on FCPRDJ, FCMCU", new[] { "FCPRDJ", "FCMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
