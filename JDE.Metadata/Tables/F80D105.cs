using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D105 - .
/// </summary>
public class F80D105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BLBLISTID.
        /// </summary>
        public const string BLBLISTID = "BLBLISTID";

        /// <summary>
        /// BLMCU.
        /// </summary>
        public const string BLMCU = "BLMCU";

        /// <summary>
        /// BLURCD.
        /// </summary>
        public const string BLURCD = "BLURCD";

        /// <summary>
        /// BLURDT.
        /// </summary>
        public const string BLURDT = "BLURDT";

        /// <summary>
        /// BLURAT.
        /// </summary>
        public const string BLURAT = "BLURAT";

        /// <summary>
        /// BLURAB.
        /// </summary>
        public const string BLURAB = "BLURAB";

        /// <summary>
        /// BLURRF.
        /// </summary>
        public const string BLURRF = "BLURRF";

        /// <summary>
        /// BLUSER.
        /// </summary>
        public const string BLUSER = "BLUSER";

        /// <summary>
        /// BLMKEY.
        /// </summary>
        public const string BLMKEY = "BLMKEY";

        /// <summary>
        /// BLPID.
        /// </summary>
        public const string BLPID = "BLPID";

        /// <summary>
        /// BLUUPMJ.
        /// </summary>
        public const string BLUUPMJ = "BLUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BLBLISTID", "BLBLISTID", JdeDataType.String, 24, true, true),
        new JdeField("BLMCU", "BLMCU", JdeDataType.String, 24, true, true),
        new JdeField("BLURCD", "BLURCD", JdeDataType.String, 4),
        new JdeField("BLURDT", "BLURDT", JdeDataType.Numeric),
        new JdeField("BLURAT", "BLURAT", JdeDataType.Numeric),
        new JdeField("BLURAB", "BLURAB", JdeDataType.Numeric),
        new JdeField("BLURRF", "BLURRF", JdeDataType.String, 30),
        new JdeField("BLUSER", "BLUSER", JdeDataType.String, 20),
        new JdeField("BLMKEY", "BLMKEY", JdeDataType.String, 30),
        new JdeField("BLPID", "BLPID", JdeDataType.String, 20),
        new JdeField("BLUUPMJ", "BLUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D105_0", "Primary Key on BLBLISTID, BLMCU", new[] { "BLBLISTID", "BLMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
