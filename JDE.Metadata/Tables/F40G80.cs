using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G80 - .
/// </summary>
public class F40G80 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CVWOPID.
        /// </summary>
        public const string CVWOPID = "CVWOPID";

        /// <summary>
        /// CVWVID.
        /// </summary>
        public const string CVWVID = "CVWVID";

        /// <summary>
        /// CVFARMCDE.
        /// </summary>
        public const string CVFARMCDE = "CVFARMCDE";

        /// <summary>
        /// CVFARMDSC.
        /// </summary>
        public const string CVFARMDSC = "CVFARMDSC";

        /// <summary>
        /// CVFARMVAL.
        /// </summary>
        public const string CVFARMVAL = "CVFARMVAL";

        /// <summary>
        /// CVFARMUOM.
        /// </summary>
        public const string CVFARMUOM = "CVFARMUOM";

        /// <summary>
        /// CVURCD.
        /// </summary>
        public const string CVURCD = "CVURCD";

        /// <summary>
        /// CVURDT.
        /// </summary>
        public const string CVURDT = "CVURDT";

        /// <summary>
        /// CVURRF.
        /// </summary>
        public const string CVURRF = "CVURRF";

        /// <summary>
        /// CVURAT.
        /// </summary>
        public const string CVURAT = "CVURAT";

        /// <summary>
        /// CVURAB.
        /// </summary>
        public const string CVURAB = "CVURAB";

        /// <summary>
        /// CVPID.
        /// </summary>
        public const string CVPID = "CVPID";

        /// <summary>
        /// CVTORG.
        /// </summary>
        public const string CVTORG = "CVTORG";

        /// <summary>
        /// CVUSER.
        /// </summary>
        public const string CVUSER = "CVUSER";

        /// <summary>
        /// CVJOBN.
        /// </summary>
        public const string CVJOBN = "CVJOBN";

        /// <summary>
        /// CVUUPMJ.
        /// </summary>
        public const string CVUUPMJ = "CVUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G80";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CVWOPID", "CVWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("CVWVID", "CVWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("CVFARMCDE", "CVFARMCDE", JdeDataType.String, 20, true, true),
        new JdeField("CVFARMDSC", "CVFARMDSC", JdeDataType.String, 60),
        new JdeField("CVFARMVAL", "CVFARMVAL", JdeDataType.Numeric),
        new JdeField("CVFARMUOM", "CVFARMUOM", JdeDataType.String, 4),
        new JdeField("CVURCD", "CVURCD", JdeDataType.String, 4),
        new JdeField("CVURDT", "CVURDT", JdeDataType.Numeric),
        new JdeField("CVURRF", "CVURRF", JdeDataType.String, 30),
        new JdeField("CVURAT", "CVURAT", JdeDataType.Numeric),
        new JdeField("CVURAB", "CVURAB", JdeDataType.Numeric),
        new JdeField("CVPID", "CVPID", JdeDataType.String, 20),
        new JdeField("CVTORG", "CVTORG", JdeDataType.String, 20),
        new JdeField("CVUSER", "CVUSER", JdeDataType.String, 20),
        new JdeField("CVJOBN", "CVJOBN", JdeDataType.String, 20),
        new JdeField("CVUUPMJ", "CVUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G80_0", "Primary Key on CVWOPID, CVWVID, CVFARMCDE", new[] { "CVWOPID", "CVWVID", "CVFARMCDE" }, isUnique: true, isPrimaryKey: true)
    };
}
