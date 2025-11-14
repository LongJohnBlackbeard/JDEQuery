using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D312 - .
/// </summary>
public class F80D312 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ASSUBSCR.
        /// </summary>
        public const string ASSUBSCR = "ASSUBSCR";

        /// <summary>
        /// ASLNID.
        /// </summary>
        public const string ASLNID = "ASLNID";

        /// <summary>
        /// ASALERT.
        /// </summary>
        public const string ASALERT = "ASALERT";

        /// <summary>
        /// ASURCD.
        /// </summary>
        public const string ASURCD = "ASURCD";

        /// <summary>
        /// ASURDT.
        /// </summary>
        public const string ASURDT = "ASURDT";

        /// <summary>
        /// ASURAT.
        /// </summary>
        public const string ASURAT = "ASURAT";

        /// <summary>
        /// ASURAB.
        /// </summary>
        public const string ASURAB = "ASURAB";

        /// <summary>
        /// ASURRF.
        /// </summary>
        public const string ASURRF = "ASURRF";

        /// <summary>
        /// ASUSER.
        /// </summary>
        public const string ASUSER = "ASUSER";

        /// <summary>
        /// ASMKEY.
        /// </summary>
        public const string ASMKEY = "ASMKEY";

        /// <summary>
        /// ASPID.
        /// </summary>
        public const string ASPID = "ASPID";

        /// <summary>
        /// ASUUPMJ.
        /// </summary>
        public const string ASUUPMJ = "ASUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D312";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ASSUBSCR", "ASSUBSCR", JdeDataType.Numeric, null, true, true),
        new JdeField("ASLNID", "ASLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ASALERT", "ASALERT", JdeDataType.Numeric),
        new JdeField("ASURCD", "ASURCD", JdeDataType.String, 4),
        new JdeField("ASURDT", "ASURDT", JdeDataType.Numeric),
        new JdeField("ASURAT", "ASURAT", JdeDataType.Numeric),
        new JdeField("ASURAB", "ASURAB", JdeDataType.Numeric),
        new JdeField("ASURRF", "ASURRF", JdeDataType.String, 30),
        new JdeField("ASUSER", "ASUSER", JdeDataType.String, 20),
        new JdeField("ASMKEY", "ASMKEY", JdeDataType.String, 30),
        new JdeField("ASPID", "ASPID", JdeDataType.String, 20),
        new JdeField("ASUUPMJ", "ASUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D312_0", "Primary Key on ASSUBSCR, ASLNID", new[] { "ASSUBSCR", "ASLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
