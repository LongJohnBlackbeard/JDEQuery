using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D302 - .
/// </summary>
public class F80D302 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRMETRIC.
        /// </summary>
        public const string CRMETRIC = "CRMETRIC";

        /// <summary>
        /// CRTIDEN.
        /// </summary>
        public const string CRTIDEN = "CRTIDEN";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRMKEY.
        /// </summary>
        public const string CRMKEY = "CRMKEY";

        /// <summary>
        /// CRUUPMJ.
        /// </summary>
        public const string CRUUPMJ = "CRUUPMJ";

        /// <summary>
        /// CRURCD.
        /// </summary>
        public const string CRURCD = "CRURCD";

        /// <summary>
        /// CRURAT.
        /// </summary>
        public const string CRURAT = "CRURAT";

        /// <summary>
        /// CRURDT.
        /// </summary>
        public const string CRURDT = "CRURDT";

        /// <summary>
        /// CRURRF.
        /// </summary>
        public const string CRURRF = "CRURRF";

        /// <summary>
        /// CRURAB.
        /// </summary>
        public const string CRURAB = "CRURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F80D302";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRMETRIC", "CRMETRIC", JdeDataType.Numeric, null, true, true),
        new JdeField("CRTIDEN", "CRTIDEN", JdeDataType.Numeric, null, true, true),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRMKEY", "CRMKEY", JdeDataType.String, 30),
        new JdeField("CRUUPMJ", "CRUUPMJ", JdeDataType.Date),
        new JdeField("CRURCD", "CRURCD", JdeDataType.String, 4),
        new JdeField("CRURAT", "CRURAT", JdeDataType.Numeric),
        new JdeField("CRURDT", "CRURDT", JdeDataType.Numeric),
        new JdeField("CRURRF", "CRURRF", JdeDataType.String, 30),
        new JdeField("CRURAB", "CRURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D302_0", "Primary Key on CRMETRIC, CRTIDEN", new[] { "CRMETRIC", "CRTIDEN" }, isUnique: true, isPrimaryKey: true)
    };
}
