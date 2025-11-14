using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0701732 - .
/// </summary>
public class F0701732 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AOAN8.
        /// </summary>
        public const string AOAN8 = "AOAN8";

        /// <summary>
        /// AOTARA.
        /// </summary>
        public const string AOTARA = "AOTARA";

        /// <summary>
        /// AOPTAX.
        /// </summary>
        public const string AOPTAX = "AOPTAX";

        /// <summary>
        /// AOADTOT.
        /// </summary>
        public const string AOADTOT = "AOADTOT";

        /// <summary>
        /// AOEFTB.
        /// </summary>
        public const string AOEFTB = "AOEFTB";

        /// <summary>
        /// AOEFTE.
        /// </summary>
        public const string AOEFTE = "AOEFTE";

        /// <summary>
        /// AOADTOV.
        /// </summary>
        public const string AOADTOV = "AOADTOV";

        /// <summary>
        /// AOJIT.
        /// </summary>
        public const string AOJIT = "AOJIT";

        /// <summary>
        /// AONRCERT.
        /// </summary>
        public const string AONRCERT = "AONRCERT";

        /// <summary>
        /// AOAZVOL.
        /// </summary>
        public const string AOAZVOL = "AOAZVOL";

        /// <summary>
        /// AOINWH4.
        /// </summary>
        public const string AOINWH4 = "AOINWH4";

        /// <summary>
        /// AOFORM01.
        /// </summary>
        public const string AOFORM01 = "AOFORM01";

        /// <summary>
        /// AOFORM02.
        /// </summary>
        public const string AOFORM02 = "AOFORM02";

        /// <summary>
        /// AOFORM03.
        /// </summary>
        public const string AOFORM03 = "AOFORM03";

        /// <summary>
        /// AOFORM04.
        /// </summary>
        public const string AOFORM04 = "AOFORM04";

        /// <summary>
        /// AOFORM05.
        /// </summary>
        public const string AOFORM05 = "AOFORM05";

        /// <summary>
        /// AOFORM06.
        /// </summary>
        public const string AOFORM06 = "AOFORM06";

        /// <summary>
        /// AOFORM07.
        /// </summary>
        public const string AOFORM07 = "AOFORM07";

        /// <summary>
        /// AOFORM08.
        /// </summary>
        public const string AOFORM08 = "AOFORM08";

        /// <summary>
        /// AOFORM09.
        /// </summary>
        public const string AOFORM09 = "AOFORM09";

        /// <summary>
        /// AOFORM10.
        /// </summary>
        public const string AOFORM10 = "AOFORM10";

        /// <summary>
        /// AOUSER.
        /// </summary>
        public const string AOUSER = "AOUSER";

        /// <summary>
        /// AOJOBN.
        /// </summary>
        public const string AOJOBN = "AOJOBN";

        /// <summary>
        /// AOPID.
        /// </summary>
        public const string AOPID = "AOPID";

        /// <summary>
        /// AOUPMJ.
        /// </summary>
        public const string AOUPMJ = "AOUPMJ";

        /// <summary>
        /// AOUPMT.
        /// </summary>
        public const string AOUPMT = "AOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0701732";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AOAN8", "AOAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AOTARA", "AOTARA", JdeDataType.String, 20, true, true),
        new JdeField("AOPTAX", "AOPTAX", JdeDataType.String, 4, true, true),
        new JdeField("AOADTOT", "AOADTOT", JdeDataType.String, 2, true, true),
        new JdeField("AOEFTB", "AOEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("AOEFTE", "AOEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("AOADTOV", "AOADTOV", JdeDataType.String, 2),
        new JdeField("AOJIT", "AOJIT", JdeDataType.Numeric),
        new JdeField("AONRCERT", "AONRCERT", JdeDataType.String, 2),
        new JdeField("AOAZVOL", "AOAZVOL", JdeDataType.String, 2),
        new JdeField("AOINWH4", "AOINWH4", JdeDataType.String, 2),
        new JdeField("AOFORM01", "AOFORM01", JdeDataType.String, 20),
        new JdeField("AOFORM02", "AOFORM02", JdeDataType.String, 20),
        new JdeField("AOFORM03", "AOFORM03", JdeDataType.String, 20),
        new JdeField("AOFORM04", "AOFORM04", JdeDataType.String, 20),
        new JdeField("AOFORM05", "AOFORM05", JdeDataType.String, 20),
        new JdeField("AOFORM06", "AOFORM06", JdeDataType.String, 20),
        new JdeField("AOFORM07", "AOFORM07", JdeDataType.String, 20),
        new JdeField("AOFORM08", "AOFORM08", JdeDataType.String, 20),
        new JdeField("AOFORM09", "AOFORM09", JdeDataType.String, 20),
        new JdeField("AOFORM10", "AOFORM10", JdeDataType.String, 20),
        new JdeField("AOUSER", "AOUSER", JdeDataType.String, 20),
        new JdeField("AOJOBN", "AOJOBN", JdeDataType.String, 20),
        new JdeField("AOPID", "AOPID", JdeDataType.String, 20),
        new JdeField("AOUPMJ", "AOUPMJ", JdeDataType.Numeric),
        new JdeField("AOUPMT", "AOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0701732_0", "Primary Key on AOAN8, AOTARA, AOPTAX, AOADTOT, AOEFTB, AOEFTE", new[] { "AOAN8", "AOTARA", "AOPTAX", "AOADTOT", "AOEFTB", "AOEFTE" }, isUnique: true, isPrimaryKey: true)
    };
}
