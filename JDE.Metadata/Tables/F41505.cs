using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41505 - .
/// </summary>
public class F41505 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// POMCU.
        /// </summary>
        public const string POMCU = "POMCU";

        /// <summary>
        /// POMTXT.
        /// </summary>
        public const string POMTXT = "POMTXT";

        /// <summary>
        /// PODPFG.
        /// </summary>
        public const string PODPFG = "PODPFG";

        /// <summary>
        /// POTKID.
        /// </summary>
        public const string POTKID = "POTKID";

        /// <summary>
        /// POTKTY.
        /// </summary>
        public const string POTKTY = "POTKTY";

        /// <summary>
        /// POFILL.
        /// </summary>
        public const string POFILL = "POFILL";

        /// <summary>
        /// POPDGR.
        /// </summary>
        public const string POPDGR = "POPDGR";

        /// <summary>
        /// POPGTO.
        /// </summary>
        public const string POPGTO = "POPGTO";

        /// <summary>
        /// POIVAL.
        /// </summary>
        public const string POIVAL = "POIVAL";

        /// <summary>
        /// POUSER.
        /// </summary>
        public const string POUSER = "POUSER";

        /// <summary>
        /// POPID.
        /// </summary>
        public const string POPID = "POPID";

        /// <summary>
        /// POJOBN.
        /// </summary>
        public const string POJOBN = "POJOBN";

        /// <summary>
        /// POUPMJ.
        /// </summary>
        public const string POUPMJ = "POUPMJ";

        /// <summary>
        /// POTDAY.
        /// </summary>
        public const string POTDAY = "POTDAY";

        /// <summary>
        /// POURRF.
        /// </summary>
        public const string POURRF = "POURRF";

        /// <summary>
        /// POURDT.
        /// </summary>
        public const string POURDT = "POURDT";

        /// <summary>
        /// POURCD.
        /// </summary>
        public const string POURCD = "POURCD";

        /// <summary>
        /// POURAT.
        /// </summary>
        public const string POURAT = "POURAT";

        /// <summary>
        /// POURAB.
        /// </summary>
        public const string POURAB = "POURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F41505";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("POMCU", "POMCU", JdeDataType.String, 24, true, true),
        new JdeField("POMTXT", "POMTXT", JdeDataType.String, 2, true, true),
        new JdeField("PODPFG", "PODPFG", JdeDataType.String, 2, true, true),
        new JdeField("POTKID", "POTKID", JdeDataType.String, 16, true, true),
        new JdeField("POTKTY", "POTKTY", JdeDataType.String, 6),
        new JdeField("POFILL", "POFILL", JdeDataType.String, 20),
        new JdeField("POPDGR", "POPDGR", JdeDataType.String, 6, true, true),
        new JdeField("POPGTO", "POPGTO", JdeDataType.String, 6, true, true),
        new JdeField("POIVAL", "POIVAL", JdeDataType.String, 2),
        new JdeField("POUSER", "POUSER", JdeDataType.String, 20),
        new JdeField("POPID", "POPID", JdeDataType.String, 20),
        new JdeField("POJOBN", "POJOBN", JdeDataType.String, 20),
        new JdeField("POUPMJ", "POUPMJ", JdeDataType.Numeric),
        new JdeField("POTDAY", "POTDAY", JdeDataType.Numeric),
        new JdeField("POURRF", "POURRF", JdeDataType.String, 30),
        new JdeField("POURDT", "POURDT", JdeDataType.Numeric),
        new JdeField("POURCD", "POURCD", JdeDataType.String, 4),
        new JdeField("POURAT", "POURAT", JdeDataType.Numeric),
        new JdeField("POURAB", "POURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41505_0", "Primary Key on POMCU, POMTXT, PODPFG, POTKID, POPDGR, POPGTO", new[] { "POMCU", "POMTXT", "PODPFG", "POTKID", "POPDGR", "POPGTO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41505_2", "Index on POMCU, POMTXT, PODPFG, POTKTY, POPDGR, POPGTO", new[] { "POMCU", "POMTXT", "PODPFG", "POTKTY", "POPDGR", "POPGTO" })
    };
}
