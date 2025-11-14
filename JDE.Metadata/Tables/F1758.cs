using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1758 - .
/// </summary>
public class F1758 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZBAR1.
        /// </summary>
        public const string ZBAR1 = "ZBAR1";

        /// <summary>
        /// ZBTIMEZONES.
        /// </summary>
        public const string ZBTIMEZONES = "ZBTIMEZONES";

        /// <summary>
        /// ZBDSAVNAME.
        /// </summary>
        public const string ZBDSAVNAME = "ZBDSAVNAME";

        /// <summary>
        /// ZBURAB.
        /// </summary>
        public const string ZBURAB = "ZBURAB";

        /// <summary>
        /// ZBURCD.
        /// </summary>
        public const string ZBURCD = "ZBURCD";

        /// <summary>
        /// ZBURAT.
        /// </summary>
        public const string ZBURAT = "ZBURAT";

        /// <summary>
        /// ZBURDT.
        /// </summary>
        public const string ZBURDT = "ZBURDT";

        /// <summary>
        /// ZBURRF.
        /// </summary>
        public const string ZBURRF = "ZBURRF";

        /// <summary>
        /// ZBUSER.
        /// </summary>
        public const string ZBUSER = "ZBUSER";

        /// <summary>
        /// ZBUPMJ.
        /// </summary>
        public const string ZBUPMJ = "ZBUPMJ";

        /// <summary>
        /// ZBUPMT.
        /// </summary>
        public const string ZBUPMT = "ZBUPMT";

        /// <summary>
        /// ZBJOBN.
        /// </summary>
        public const string ZBJOBN = "ZBJOBN";

        /// <summary>
        /// ZBPID.
        /// </summary>
        public const string ZBPID = "ZBPID";
    }

    /// <inheritdoc />
    public override string TableName => "F1758";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZBAR1", "ZBAR1", JdeDataType.String, 12, true, true),
        new JdeField("ZBTIMEZONES", "ZBTIMEZONES", JdeDataType.String, 4, true, true),
        new JdeField("ZBDSAVNAME", "ZBDSAVNAME", JdeDataType.String, 20),
        new JdeField("ZBURAB", "ZBURAB", JdeDataType.Numeric),
        new JdeField("ZBURCD", "ZBURCD", JdeDataType.String, 4),
        new JdeField("ZBURAT", "ZBURAT", JdeDataType.Numeric),
        new JdeField("ZBURDT", "ZBURDT", JdeDataType.Numeric),
        new JdeField("ZBURRF", "ZBURRF", JdeDataType.String, 30),
        new JdeField("ZBUSER", "ZBUSER", JdeDataType.String, 20),
        new JdeField("ZBUPMJ", "ZBUPMJ", JdeDataType.Numeric),
        new JdeField("ZBUPMT", "ZBUPMT", JdeDataType.Numeric),
        new JdeField("ZBJOBN", "ZBJOBN", JdeDataType.String, 20),
        new JdeField("ZBPID", "ZBPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1758_0", "Primary Key on ZBAR1, ZBTIMEZONES", new[] { "ZBAR1", "ZBTIMEZONES" }, isUnique: true, isPrimaryKey: true)
    };
}
