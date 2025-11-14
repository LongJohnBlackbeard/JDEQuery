using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31K10 - .
/// </summary>
public class FF31K10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FCFSCID.
        /// </summary>
        public const string FCFSCID = "FCFSCID";

        /// <summary>
        /// FCDFMCU.
        /// </summary>
        public const string FCDFMCU = "FCDFMCU";

        /// <summary>
        /// FCPMAPID.
        /// </summary>
        public const string FCPMAPID = "FCPMAPID";

        /// <summary>
        /// FCDFEXDT.
        /// </summary>
        public const string FCDFEXDT = "FCDFEXDT";

        /// <summary>
        /// FCDFFLOW.
        /// </summary>
        public const string FCDFFLOW = "FCDFFLOW";

        /// <summary>
        /// FCURAB.
        /// </summary>
        public const string FCURAB = "FCURAB";

        /// <summary>
        /// FCURAT.
        /// </summary>
        public const string FCURAT = "FCURAT";

        /// <summary>
        /// FCURCD.
        /// </summary>
        public const string FCURCD = "FCURCD";

        /// <summary>
        /// FCURDT.
        /// </summary>
        public const string FCURDT = "FCURDT";

        /// <summary>
        /// FCURRF.
        /// </summary>
        public const string FCURRF = "FCURRF";

        /// <summary>
        /// FCUSER.
        /// </summary>
        public const string FCUSER = "FCUSER";

        /// <summary>
        /// FCJOBN.
        /// </summary>
        public const string FCJOBN = "FCJOBN";

        /// <summary>
        /// FCTORG.
        /// </summary>
        public const string FCTORG = "FCTORG";

        /// <summary>
        /// FCUUPMJ.
        /// </summary>
        public const string FCUUPMJ = "FCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF31K10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FCFSCID", "FCFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("FCDFMCU", "FCDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("FCPMAPID", "FCPMAPID", JdeDataType.Numeric, null, true, true),
        new JdeField("FCDFEXDT", "FCDFEXDT", JdeDataType.Date),
        new JdeField("FCDFFLOW", "FCDFFLOW", JdeDataType.Numeric),
        new JdeField("FCURAB", "FCURAB", JdeDataType.Numeric),
        new JdeField("FCURAT", "FCURAT", JdeDataType.Numeric),
        new JdeField("FCURCD", "FCURCD", JdeDataType.String, 4),
        new JdeField("FCURDT", "FCURDT", JdeDataType.Numeric),
        new JdeField("FCURRF", "FCURRF", JdeDataType.String, 30),
        new JdeField("FCUSER", "FCUSER", JdeDataType.String, 20),
        new JdeField("FCJOBN", "FCJOBN", JdeDataType.String, 20),
        new JdeField("FCTORG", "FCTORG", JdeDataType.String, 20),
        new JdeField("FCUUPMJ", "FCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31K10_0", "Primary Key on FCFSCID, FCDFMCU, FCPMAPID", new[] { "FCFSCID", "FCDFMCU", "FCPMAPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31K10_2", "Index on FCFSCID, FCPMAPID", new[] { "FCFSCID", "FCPMAPID" })
    };
}
