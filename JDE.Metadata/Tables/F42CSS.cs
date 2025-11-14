using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42CSS - .
/// </summary>
public class F42CSS : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSAN8.
        /// </summary>
        public const string CSAN8 = "CSAN8";

        /// <summary>
        /// CSVERS.
        /// </summary>
        public const string CSVERS = "CSVERS";

        /// <summary>
        /// CSJOBS.
        /// </summary>
        public const string CSJOBS = "CSJOBS";

        /// <summary>
        /// CSMCU.
        /// </summary>
        public const string CSMCU = "CSMCU";

        /// <summary>
        /// CSSHAN.
        /// </summary>
        public const string CSSHAN = "CSSHAN";

        /// <summary>
        /// CSACTN.
        /// </summary>
        public const string CSACTN = "CSACTN";

        /// <summary>
        /// CSPA8.
        /// </summary>
        public const string CSPA8 = "CSPA8";

        /// <summary>
        /// CSAN8R.
        /// </summary>
        public const string CSAN8R = "CSAN8R";

        /// <summary>
        /// CSCTID.
        /// </summary>
        public const string CSCTID = "CSCTID";

        /// <summary>
        /// CSLINN.
        /// </summary>
        public const string CSLINN = "CSLINN";

        /// <summary>
        /// CSURCD.
        /// </summary>
        public const string CSURCD = "CSURCD";

        /// <summary>
        /// CSURDT.
        /// </summary>
        public const string CSURDT = "CSURDT";

        /// <summary>
        /// CSURAT.
        /// </summary>
        public const string CSURAT = "CSURAT";

        /// <summary>
        /// CSURAB.
        /// </summary>
        public const string CSURAB = "CSURAB";

        /// <summary>
        /// CSURRF.
        /// </summary>
        public const string CSURRF = "CSURRF";

        /// <summary>
        /// CSOSTP.
        /// </summary>
        public const string CSOSTP = "CSOSTP";

        /// <summary>
        /// CSCRDC.
        /// </summary>
        public const string CSCRDC = "CSCRDC";

        /// <summary>
        /// CSCRCD.
        /// </summary>
        public const string CSCRCD = "CSCRCD";
    }

    /// <inheritdoc />
    public override string TableName => "F42CSS";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSAN8", "CSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CSVERS", "CSVERS", JdeDataType.String, 20),
        new JdeField("CSJOBS", "CSJOBS", JdeDataType.Numeric),
        new JdeField("CSMCU", "CSMCU", JdeDataType.String, 24),
        new JdeField("CSSHAN", "CSSHAN", JdeDataType.Numeric),
        new JdeField("CSACTN", "CSACTN", JdeDataType.String, 2),
        new JdeField("CSPA8", "CSPA8", JdeDataType.Numeric),
        new JdeField("CSAN8R", "CSAN8R", JdeDataType.Numeric),
        new JdeField("CSCTID", "CSCTID", JdeDataType.String, 30),
        new JdeField("CSLINN", "CSLINN", JdeDataType.Numeric),
        new JdeField("CSURCD", "CSURCD", JdeDataType.String, 4),
        new JdeField("CSURDT", "CSURDT", JdeDataType.Numeric),
        new JdeField("CSURAT", "CSURAT", JdeDataType.Numeric),
        new JdeField("CSURAB", "CSURAB", JdeDataType.Numeric),
        new JdeField("CSURRF", "CSURRF", JdeDataType.String, 30),
        new JdeField("CSOSTP", "CSOSTP", JdeDataType.String, 6),
        new JdeField("CSCRDC", "CSCRDC", JdeDataType.String, 6),
        new JdeField("CSCRCD", "CSCRCD", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42CSS_0", "Primary Key on CSAN8", new[] { "CSAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
