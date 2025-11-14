using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G101 - .
/// </summary>
public class F40G101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ODGRECID.
        /// </summary>
        public const string ODGRECID = "ODGRECID";

        /// <summary>
        /// ODTYPEFB.
        /// </summary>
        public const string ODTYPEFB = "ODTYPEFB";

        /// <summary>
        /// ODAN8.
        /// </summary>
        public const string ODAN8 = "ODAN8";

        /// <summary>
        /// ODPERCT.
        /// </summary>
        public const string ODPERCT = "ODPERCT";

        /// <summary>
        /// ODURCD.
        /// </summary>
        public const string ODURCD = "ODURCD";

        /// <summary>
        /// ODURDT.
        /// </summary>
        public const string ODURDT = "ODURDT";

        /// <summary>
        /// ODURRF.
        /// </summary>
        public const string ODURRF = "ODURRF";

        /// <summary>
        /// ODURAB.
        /// </summary>
        public const string ODURAB = "ODURAB";

        /// <summary>
        /// ODURAT.
        /// </summary>
        public const string ODURAT = "ODURAT";

        /// <summary>
        /// ODUSER.
        /// </summary>
        public const string ODUSER = "ODUSER";

        /// <summary>
        /// ODPID.
        /// </summary>
        public const string ODPID = "ODPID";

        /// <summary>
        /// ODUUPMJ.
        /// </summary>
        public const string ODUUPMJ = "ODUUPMJ";

        /// <summary>
        /// ODTORG.
        /// </summary>
        public const string ODTORG = "ODTORG";

        /// <summary>
        /// ODJOBN.
        /// </summary>
        public const string ODJOBN = "ODJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F40G101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ODGRECID", "ODGRECID", JdeDataType.Numeric, null, true, true),
        new JdeField("ODTYPEFB", "ODTYPEFB", JdeDataType.String, 2, true, true),
        new JdeField("ODAN8", "ODAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ODPERCT", "ODPERCT", JdeDataType.Numeric),
        new JdeField("ODURCD", "ODURCD", JdeDataType.String, 4),
        new JdeField("ODURDT", "ODURDT", JdeDataType.Numeric),
        new JdeField("ODURRF", "ODURRF", JdeDataType.String, 30),
        new JdeField("ODURAB", "ODURAB", JdeDataType.Numeric),
        new JdeField("ODURAT", "ODURAT", JdeDataType.Numeric),
        new JdeField("ODUSER", "ODUSER", JdeDataType.String, 20),
        new JdeField("ODPID", "ODPID", JdeDataType.String, 20),
        new JdeField("ODUUPMJ", "ODUUPMJ", JdeDataType.Date),
        new JdeField("ODTORG", "ODTORG", JdeDataType.String, 20),
        new JdeField("ODJOBN", "ODJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G101_0", "Primary Key on ODGRECID, ODTYPEFB, ODAN8", new[] { "ODGRECID", "ODTYPEFB", "ODAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G101_2", "Index on ODAN8", new[] { "ODAN8" })
    };
}
