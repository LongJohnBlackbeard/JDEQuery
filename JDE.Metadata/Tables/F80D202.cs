using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D202 - .
/// </summary>
public class F80D202 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCPRDJ.
        /// </summary>
        public const string CCPRDJ = "CCPRDJ";

        /// <summary>
        /// CCMCU.
        /// </summary>
        public const string CCMCU = "CCMCU";

        /// <summary>
        /// CCPDSO.
        /// </summary>
        public const string CCPDSO = "CCPDSO";

        /// <summary>
        /// CCPDSI.
        /// </summary>
        public const string CCPDSI = "CCPDSI";

        /// <summary>
        /// CCPDPO.
        /// </summary>
        public const string CCPDPO = "CCPDPO";

        /// <summary>
        /// CCCCCT.
        /// </summary>
        public const string CCCCCT = "CCCCCT";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";

        /// <summary>
        /// CCUTIME.
        /// </summary>
        public const string CCUTIME = "CCUTIME";

        /// <summary>
        /// CCURCD.
        /// </summary>
        public const string CCURCD = "CCURCD";

        /// <summary>
        /// CCURDT.
        /// </summary>
        public const string CCURDT = "CCURDT";

        /// <summary>
        /// CCURAT.
        /// </summary>
        public const string CCURAT = "CCURAT";

        /// <summary>
        /// CCURAB.
        /// </summary>
        public const string CCURAB = "CCURAB";

        /// <summary>
        /// CCURRF.
        /// </summary>
        public const string CCURRF = "CCURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D202";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCPRDJ", "CCPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CCMCU", "CCMCU", JdeDataType.String, 24, true, true),
        new JdeField("CCPDSO", "CCPDSO", JdeDataType.Numeric),
        new JdeField("CCPDSI", "CCPDSI", JdeDataType.Numeric),
        new JdeField("CCPDPO", "CCPDPO", JdeDataType.Numeric),
        new JdeField("CCCCCT", "CCCCCT", JdeDataType.Numeric),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30),
        new JdeField("CCUTIME", "CCUTIME", JdeDataType.Date),
        new JdeField("CCURCD", "CCURCD", JdeDataType.String, 4),
        new JdeField("CCURDT", "CCURDT", JdeDataType.Numeric),
        new JdeField("CCURAT", "CCURAT", JdeDataType.Numeric),
        new JdeField("CCURAB", "CCURAB", JdeDataType.Numeric),
        new JdeField("CCURRF", "CCURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D202_0", "Primary Key on CCPRDJ, CCMCU", new[] { "CCPRDJ", "CCMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
