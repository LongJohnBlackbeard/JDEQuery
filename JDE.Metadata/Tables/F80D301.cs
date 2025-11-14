using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D301 - .
/// </summary>
public class F80D301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DMDBC.
        /// </summary>
        public const string DMDBC = "DMDBC";

        /// <summary>
        /// DMMETRIC.
        /// </summary>
        public const string DMMETRIC = "DMMETRIC";

        /// <summary>
        /// DMURCD.
        /// </summary>
        public const string DMURCD = "DMURCD";

        /// <summary>
        /// DMURDT.
        /// </summary>
        public const string DMURDT = "DMURDT";

        /// <summary>
        /// DMURAT.
        /// </summary>
        public const string DMURAT = "DMURAT";

        /// <summary>
        /// DMURAB.
        /// </summary>
        public const string DMURAB = "DMURAB";

        /// <summary>
        /// DMURRF.
        /// </summary>
        public const string DMURRF = "DMURRF";

        /// <summary>
        /// DMUSER.
        /// </summary>
        public const string DMUSER = "DMUSER";

        /// <summary>
        /// DMMKEY.
        /// </summary>
        public const string DMMKEY = "DMMKEY";

        /// <summary>
        /// DMPID.
        /// </summary>
        public const string DMPID = "DMPID";

        /// <summary>
        /// DMUUPMJ.
        /// </summary>
        public const string DMUUPMJ = "DMUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DMDBC", "DMDBC", JdeDataType.String, 12, true, true),
        new JdeField("DMMETRIC", "DMMETRIC", JdeDataType.Numeric, null, true, true),
        new JdeField("DMURCD", "DMURCD", JdeDataType.String, 4),
        new JdeField("DMURDT", "DMURDT", JdeDataType.Numeric),
        new JdeField("DMURAT", "DMURAT", JdeDataType.Numeric),
        new JdeField("DMURAB", "DMURAB", JdeDataType.Numeric),
        new JdeField("DMURRF", "DMURRF", JdeDataType.String, 30),
        new JdeField("DMUSER", "DMUSER", JdeDataType.String, 20),
        new JdeField("DMMKEY", "DMMKEY", JdeDataType.String, 30),
        new JdeField("DMPID", "DMPID", JdeDataType.String, 20),
        new JdeField("DMUUPMJ", "DMUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D301_0", "Primary Key on DMDBC, DMMETRIC", new[] { "DMDBC", "DMMETRIC" }, isUnique: true, isPrimaryKey: true)
    };
}
