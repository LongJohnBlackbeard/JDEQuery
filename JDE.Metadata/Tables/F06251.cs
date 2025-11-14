using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06251 - .
/// </summary>
public class F06251 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JBAN8.
        /// </summary>
        public const string JBAN8 = "JBAN8";

        /// <summary>
        /// JBUN.
        /// </summary>
        public const string JBUN = "JBUN";

        /// <summary>
        /// JBMCU.
        /// </summary>
        public const string JBMCU = "JBMCU";

        /// <summary>
        /// JBJBCD.
        /// </summary>
        public const string JBJBCD = "JBJBCD";

        /// <summary>
        /// JBJBST.
        /// </summary>
        public const string JBJBST = "JBJBST";

        /// <summary>
        /// JBEFTB.
        /// </summary>
        public const string JBEFTB = "JBEFTB";

        /// <summary>
        /// JBPHRT.
        /// </summary>
        public const string JBPHRT = "JBPHRT";

        /// <summary>
        /// JBCCRS.
        /// </summary>
        public const string JBCCRS = "JBCCRS";

        /// <summary>
        /// JBOVHR.
        /// </summary>
        public const string JBOVHR = "JBOVHR";

        /// <summary>
        /// JBOVFL.
        /// </summary>
        public const string JBOVFL = "JBOVFL";
    }

    /// <inheritdoc />
    public override string TableName => "F06251";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JBAN8", "JBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JBUN", "JBUN", JdeDataType.String, 12, true, true),
        new JdeField("JBMCU", "JBMCU", JdeDataType.String, 24, true, true),
        new JdeField("JBJBCD", "JBJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JBJBST", "JBJBST", JdeDataType.String, 8, true, true),
        new JdeField("JBEFTB", "JBEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("JBPHRT", "JBPHRT", JdeDataType.Numeric),
        new JdeField("JBCCRS", "JBCCRS", JdeDataType.String, 4),
        new JdeField("JBOVHR", "JBOVHR", JdeDataType.Numeric),
        new JdeField("JBOVFL", "JBOVFL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06251_0", "Primary Key on JBAN8, JBJBCD, JBJBST, JBUN, JBMCU, JBEFTB", new[] { "JBAN8", "JBJBCD", "JBJBST", "JBUN", "JBMCU", "JBEFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06251_2", "Index on JBUN, JBAN8, JBMCU, JBJBCD, JBJBST, JBEFTB", new[] { "JBUN", "JBAN8", "JBMCU", "JBJBCD", "JBJBST", "JBEFTB" }),
        new JdeIndex("F06251_3", "Index on JBMCU, JBAN8, JBUN, JBJBCD, JBJBST, JBEFTB", new[] { "JBMCU", "JBAN8", "JBUN", "JBJBCD", "JBJBST", "JBEFTB" }),
        new JdeIndex("F06251_4", "Index on JBJBCD, JBAN8, JBJBST, JBUN, JBMCU, JBEFTB", new[] { "JBJBCD", "JBAN8", "JBJBST", "JBUN", "JBMCU", "JBEFTB" })
    };
}
