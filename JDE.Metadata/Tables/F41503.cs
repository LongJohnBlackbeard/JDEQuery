using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41503 - .
/// </summary>
public class F41503 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PBMCU.
        /// </summary>
        public const string PBMCU = "PBMCU";

        /// <summary>
        /// PBTKID.
        /// </summary>
        public const string PBTKID = "PBTKID";

        /// <summary>
        /// PBSCID.
        /// </summary>
        public const string PBSCID = "PBSCID";

        /// <summary>
        /// PBINVL.
        /// </summary>
        public const string PBINVL = "PBINVL";

        /// <summary>
        /// PBBUM1.
        /// </summary>
        public const string PBBUM1 = "PBBUM1";

        /// <summary>
        /// PBRHGT.
        /// </summary>
        public const string PBRHGT = "PBRHGT";

        /// <summary>
        /// PBVOLP.
        /// </summary>
        public const string PBVOLP = "PBVOLP";

        /// <summary>
        /// PBVOLI.
        /// </summary>
        public const string PBVOLI = "PBVOLI";

        /// <summary>
        /// PBRHFT.
        /// </summary>
        public const string PBRHFT = "PBRHFT";

        /// <summary>
        /// PBRHIN.
        /// </summary>
        public const string PBRHIN = "PBRHIN";

        /// <summary>
        /// PBRH16.
        /// </summary>
        public const string PBRH16 = "PBRH16";

        /// <summary>
        /// PBDTE.
        /// </summary>
        public const string PBDTE = "PBDTE";

        /// <summary>
        /// PBUSRS.
        /// </summary>
        public const string PBUSRS = "PBUSRS";

        /// <summary>
        /// PBUSER.
        /// </summary>
        public const string PBUSER = "PBUSER";

        /// <summary>
        /// PBPID.
        /// </summary>
        public const string PBPID = "PBPID";

        /// <summary>
        /// PBJOBN.
        /// </summary>
        public const string PBJOBN = "PBJOBN";

        /// <summary>
        /// PBUPMJ.
        /// </summary>
        public const string PBUPMJ = "PBUPMJ";

        /// <summary>
        /// PBTDAY.
        /// </summary>
        public const string PBTDAY = "PBTDAY";

        /// <summary>
        /// PBURRF.
        /// </summary>
        public const string PBURRF = "PBURRF";

        /// <summary>
        /// PBURDT.
        /// </summary>
        public const string PBURDT = "PBURDT";

        /// <summary>
        /// PBURCD.
        /// </summary>
        public const string PBURCD = "PBURCD";

        /// <summary>
        /// PBURAT.
        /// </summary>
        public const string PBURAT = "PBURAT";

        /// <summary>
        /// PBURAB.
        /// </summary>
        public const string PBURAB = "PBURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F41503";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PBMCU", "PBMCU", JdeDataType.String, 24, true, true),
        new JdeField("PBTKID", "PBTKID", JdeDataType.String, 16, true, true),
        new JdeField("PBSCID", "PBSCID", JdeDataType.String, 20),
        new JdeField("PBINVL", "PBINVL", JdeDataType.Numeric),
        new JdeField("PBBUM1", "PBBUM1", JdeDataType.String, 4),
        new JdeField("PBRHGT", "PBRHGT", JdeDataType.Numeric, null, true, true),
        new JdeField("PBVOLP", "PBVOLP", JdeDataType.Numeric),
        new JdeField("PBVOLI", "PBVOLI", JdeDataType.Numeric),
        new JdeField("PBRHFT", "PBRHFT", JdeDataType.Numeric),
        new JdeField("PBRHIN", "PBRHIN", JdeDataType.Numeric),
        new JdeField("PBRH16", "PBRH16", JdeDataType.Numeric),
        new JdeField("PBDTE", "PBDTE", JdeDataType.Numeric),
        new JdeField("PBUSRS", "PBUSRS", JdeDataType.String, 20),
        new JdeField("PBUSER", "PBUSER", JdeDataType.String, 20),
        new JdeField("PBPID", "PBPID", JdeDataType.String, 20),
        new JdeField("PBJOBN", "PBJOBN", JdeDataType.String, 20),
        new JdeField("PBUPMJ", "PBUPMJ", JdeDataType.Numeric),
        new JdeField("PBTDAY", "PBTDAY", JdeDataType.Numeric),
        new JdeField("PBURRF", "PBURRF", JdeDataType.String, 30),
        new JdeField("PBURDT", "PBURDT", JdeDataType.Numeric),
        new JdeField("PBURCD", "PBURCD", JdeDataType.String, 4),
        new JdeField("PBURAT", "PBURAT", JdeDataType.Numeric),
        new JdeField("PBURAB", "PBURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41503_0", "Primary Key on PBMCU, PBTKID, PBRHGT", new[] { "PBMCU", "PBTKID", "PBRHGT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41503_2", "Index on PBMCU, PBTKID, SYS_NC00024$", new[] { "PBMCU", "PBTKID", "SYS_NC00024$" })
    };
}
