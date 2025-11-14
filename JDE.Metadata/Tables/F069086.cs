using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069086 - .
/// </summary>
public class F069086 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YICO.
        /// </summary>
        public const string YICO = "YICO";

        /// <summary>
        /// YITARA.
        /// </summary>
        public const string YITARA = "YITARA";

        /// <summary>
        /// YIPTAX.
        /// </summary>
        public const string YIPTAX = "YIPTAX";

        /// <summary>
        /// YITAXX.
        /// </summary>
        public const string YITAXX = "YITAXX";

        /// <summary>
        /// YIUSER.
        /// </summary>
        public const string YIUSER = "YIUSER";

        /// <summary>
        /// YIPID.
        /// </summary>
        public const string YIPID = "YIPID";

        /// <summary>
        /// YIUPMJ.
        /// </summary>
        public const string YIUPMJ = "YIUPMJ";

        /// <summary>
        /// YICPYM.
        /// </summary>
        public const string YICPYM = "YICPYM";

        /// <summary>
        /// YICPGR.
        /// </summary>
        public const string YICPGR = "YICPGR";

        /// <summary>
        /// YIPA8.
        /// </summary>
        public const string YIPA8 = "YIPA8";
    }

    /// <inheritdoc />
    public override string TableName => "F069086";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YICO", "YICO", JdeDataType.String, 10, true, true),
        new JdeField("YITARA", "YITARA", JdeDataType.String, 20, true, true),
        new JdeField("YIPTAX", "YIPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YITAXX", "YITAXX", JdeDataType.String, 40),
        new JdeField("YIUSER", "YIUSER", JdeDataType.String, 20),
        new JdeField("YIPID", "YIPID", JdeDataType.String, 20),
        new JdeField("YIUPMJ", "YIUPMJ", JdeDataType.Numeric),
        new JdeField("YICPYM", "YICPYM", JdeDataType.String, 2),
        new JdeField("YICPGR", "YICPGR", JdeDataType.String, 4),
        new JdeField("YIPA8", "YIPA8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069086_0", "Primary Key on YICO, YITARA, YIPTAX", new[] { "YICO", "YITARA", "YIPTAX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F069086_2", "Index on YITARA, YIPTAX, YICO", new[] { "YITARA", "YIPTAX", "YICO" }),
        new JdeIndex("F069086_3", "Index on YITAXX", new[] { "YITAXX" }),
        new JdeIndex("F069086_4", "Index on YITAXX, YITARA, YIPTAX, YICO", new[] { "YITAXX", "YITARA", "YIPTAX", "YICO" })
    };
}
