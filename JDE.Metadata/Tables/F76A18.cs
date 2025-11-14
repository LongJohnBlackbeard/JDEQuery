using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A18 - .
/// </summary>
public class F76A18 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TOKCOO.
        /// </summary>
        public const string TOKCOO = "TOKCOO";

        /// <summary>
        /// TODCTO.
        /// </summary>
        public const string TODCTO = "TODCTO";

        /// <summary>
        /// TODOCO.
        /// </summary>
        public const string TODOCO = "TODOCO";

        /// <summary>
        /// TOLNID.
        /// </summary>
        public const string TOLNID = "TOLNID";

        /// <summary>
        /// TOKCO.
        /// </summary>
        public const string TOKCO = "TOKCO";

        /// <summary>
        /// TODCT.
        /// </summary>
        public const string TODCT = "TODCT";

        /// <summary>
        /// TODOC.
        /// </summary>
        public const string TODOC = "TODOC";

        /// <summary>
        /// TOCO.
        /// </summary>
        public const string TOCO = "TOCO";

        /// <summary>
        /// TOITM.
        /// </summary>
        public const string TOITM = "TOITM";

        /// <summary>
        /// TOAN8.
        /// </summary>
        public const string TOAN8 = "TOAN8";

        /// <summary>
        /// TOAC20.
        /// </summary>
        public const string TOAC20 = "TOAC20";

        /// <summary>
        /// TOSRP0.
        /// </summary>
        public const string TOSRP0 = "TOSRP0";

        /// <summary>
        /// TOATXC.
        /// </summary>
        public const string TOATXC = "TOATXC";

        /// <summary>
        /// TOATDA.
        /// </summary>
        public const string TOATDA = "TOATDA";

        /// <summary>
        /// TOATFA.
        /// </summary>
        public const string TOATFA = "TOATFA";

        /// <summary>
        /// TOTXR1.
        /// </summary>
        public const string TOTXR1 = "TOTXR1";

        /// <summary>
        /// TOAUMT.
        /// </summary>
        public const string TOAUMT = "TOAUMT";

        /// <summary>
        /// TOUOM.
        /// </summary>
        public const string TOUOM = "TOUOM";
    }

    /// <inheritdoc />
    public override string TableName => "F76A18";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TOKCOO", "TOKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TODCTO", "TODCTO", JdeDataType.String, 4, true, true),
        new JdeField("TODOCO", "TODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TOLNID", "TOLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TOKCO", "TOKCO", JdeDataType.String, 10),
        new JdeField("TODCT", "TODCT", JdeDataType.String, 4),
        new JdeField("TODOC", "TODOC", JdeDataType.Numeric),
        new JdeField("TOCO", "TOCO", JdeDataType.String, 10),
        new JdeField("TOITM", "TOITM", JdeDataType.Numeric),
        new JdeField("TOAN8", "TOAN8", JdeDataType.Numeric),
        new JdeField("TOAC20", "TOAC20", JdeDataType.String, 6),
        new JdeField("TOSRP0", "TOSRP0", JdeDataType.String, 12),
        new JdeField("TOATXC", "TOATXC", JdeDataType.String, 20, true, true),
        new JdeField("TOATDA", "TOATDA", JdeDataType.Numeric),
        new JdeField("TOATFA", "TOATFA", JdeDataType.Numeric),
        new JdeField("TOTXR1", "TOTXR1", JdeDataType.Numeric),
        new JdeField("TOAUMT", "TOAUMT", JdeDataType.Numeric),
        new JdeField("TOUOM", "TOUOM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A18_0", "Primary Key on TOKCOO, TODCTO, TODOCO, TOLNID, TOATXC", new[] { "TOKCOO", "TODCTO", "TODOCO", "TOLNID", "TOATXC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A18_2", "Index on TOKCO, TODCT, TODOC, TOATXC", new[] { "TOKCO", "TODCT", "TODOC", "TOATXC" }),
        new JdeIndex("F76A18_3", "Index on TOKCOO, TODCTO, TODOCO, TOATXC", new[] { "TOKCOO", "TODCTO", "TODOCO", "TOATXC" }),
        new JdeIndex("F76A18_4", "Index on TOKCOO, TODCTO, TODOCO", new[] { "TOKCOO", "TODCTO", "TODOCO" })
    };
}
