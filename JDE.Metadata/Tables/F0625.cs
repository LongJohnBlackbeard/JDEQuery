using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0625 - .
/// </summary>
public class F0625 : JdeTable
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
        /// JBJBCD.
        /// </summary>
        public const string JBJBCD = "JBJBCD";

        /// <summary>
        /// JBJBST.
        /// </summary>
        public const string JBJBST = "JBJBST";

        /// <summary>
        /// JBUN.
        /// </summary>
        public const string JBUN = "JBUN";

        /// <summary>
        /// JBMCU.
        /// </summary>
        public const string JBMCU = "JBMCU";

        /// <summary>
        /// JBCCUN.
        /// </summary>
        public const string JBCCUN = "JBCCUN";

        /// <summary>
        /// JBCCJS.
        /// </summary>
        public const string JBCCJS = "JBCCJS";

        /// <summary>
        /// JBMTHC.
        /// </summary>
        public const string JBMTHC = "JBMTHC";

        /// <summary>
        /// JBNJCD.
        /// </summary>
        public const string JBNJCD = "JBNJCD";

        /// <summary>
        /// JBNJST.
        /// </summary>
        public const string JBNJST = "JBNJST";

        /// <summary>
        /// JBCHCS.
        /// </summary>
        public const string JBCHCS = "JBCHCS";

        /// <summary>
        /// JBEFTB.
        /// </summary>
        public const string JBEFTB = "JBEFTB";

        /// <summary>
        /// JBDIX.
        /// </summary>
        public const string JBDIX = "JBDIX";

        /// <summary>
        /// JBPPCT.
        /// </summary>
        public const string JBPPCT = "JBPPCT";

        /// <summary>
        /// JBHRW.
        /// </summary>
        public const string JBHRW = "JBHRW";

        /// <summary>
        /// JBPID.
        /// </summary>
        public const string JBPID = "JBPID";

        /// <summary>
        /// JBUSER.
        /// </summary>
        public const string JBUSER = "JBUSER";

        /// <summary>
        /// JBUPMJ.
        /// </summary>
        public const string JBUPMJ = "JBUPMJ";

        /// <summary>
        /// JBPHRW.
        /// </summary>
        public const string JBPHRW = "JBPHRW";
    }

    /// <inheritdoc />
    public override string TableName => "F0625";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JBAN8", "JBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JBJBCD", "JBJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JBJBST", "JBJBST", JdeDataType.String, 8, true, true),
        new JdeField("JBUN", "JBUN", JdeDataType.String, 12, true, true),
        new JdeField("JBMCU", "JBMCU", JdeDataType.String, 24, true, true),
        new JdeField("JBCCUN", "JBCCUN", JdeDataType.Numeric),
        new JdeField("JBCCJS", "JBCCJS", JdeDataType.Numeric),
        new JdeField("JBMTHC", "JBMTHC", JdeDataType.String, 2),
        new JdeField("JBNJCD", "JBNJCD", JdeDataType.String, 12),
        new JdeField("JBNJST", "JBNJST", JdeDataType.String, 8),
        new JdeField("JBCHCS", "JBCHCS", JdeDataType.String, 2),
        new JdeField("JBEFTB", "JBEFTB", JdeDataType.Numeric),
        new JdeField("JBDIX", "JBDIX", JdeDataType.Numeric),
        new JdeField("JBPPCT", "JBPPCT", JdeDataType.Numeric),
        new JdeField("JBHRW", "JBHRW", JdeDataType.Numeric),
        new JdeField("JBPID", "JBPID", JdeDataType.String, 20),
        new JdeField("JBUSER", "JBUSER", JdeDataType.String, 20),
        new JdeField("JBUPMJ", "JBUPMJ", JdeDataType.Numeric),
        new JdeField("JBPHRW", "JBPHRW", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0625_0", "Primary Key on JBAN8, JBJBCD, JBJBST, JBUN, JBMCU", new[] { "JBAN8", "JBJBCD", "JBJBST", "JBUN", "JBMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0625_2", "Index on JBJBCD, JBJBST, JBUN, JBMCU, JBAN8, JBEFTB", new[] { "JBJBCD", "JBJBST", "JBUN", "JBMCU", "JBAN8", "JBEFTB" }),
        new JdeIndex("F0625_3", "Index on JBJBCD, JBAN8, JBJBST, JBUN, JBMCU, JBEFTB", new[] { "JBJBCD", "JBAN8", "JBJBST", "JBUN", "JBMCU", "JBEFTB" }),
        new JdeIndex("F0625_4", "Index on JBUN, JBAN8, JBJBCD, JBJBST, JBMCU, JBEFTB", new[] { "JBUN", "JBAN8", "JBJBCD", "JBJBST", "JBMCU", "JBEFTB" }),
        new JdeIndex("F0625_5", "Index on JBMCU, JBAN8, JBJBCD, JBJBST, JBUN, JBEFTB", new[] { "JBMCU", "JBAN8", "JBJBCD", "JBJBST", "JBUN", "JBEFTB" })
    };
}
