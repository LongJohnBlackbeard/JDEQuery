using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E15 - .
/// </summary>
public class F43E15 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SXCOOKIE.
        /// </summary>
        public const string SXCOOKIE = "SXCOOKIE";

        /// <summary>
        /// SXSUPITMID.
        /// </summary>
        public const string SXSUPITMID = "SXSUPITMID";

        /// <summary>
        /// SXITMAUXID.
        /// </summary>
        public const string SXITMAUXID = "SXITMAUXID";

        /// <summary>
        /// SXGENKEY.
        /// </summary>
        public const string SXGENKEY = "SXGENKEY";

        /// <summary>
        /// SXCRSREF01.
        /// </summary>
        public const string SXCRSREF01 = "SXCRSREF01";

        /// <summary>
        /// SXCRSREF02.
        /// </summary>
        public const string SXCRSREF02 = "SXCRSREF02";

        /// <summary>
        /// SXCRSREF03.
        /// </summary>
        public const string SXCRSREF03 = "SXCRSREF03";

        /// <summary>
        /// SXCRSREF04.
        /// </summary>
        public const string SXCRSREF04 = "SXCRSREF04";

        /// <summary>
        /// SXCRSREF05.
        /// </summary>
        public const string SXCRSREF05 = "SXCRSREF05";

        /// <summary>
        /// SXURCD.
        /// </summary>
        public const string SXURCD = "SXURCD";

        /// <summary>
        /// SXURDT.
        /// </summary>
        public const string SXURDT = "SXURDT";

        /// <summary>
        /// SXURAT.
        /// </summary>
        public const string SXURAT = "SXURAT";

        /// <summary>
        /// SXURAB.
        /// </summary>
        public const string SXURAB = "SXURAB";

        /// <summary>
        /// SXURRF.
        /// </summary>
        public const string SXURRF = "SXURRF";

        /// <summary>
        /// SXUSER.
        /// </summary>
        public const string SXUSER = "SXUSER";

        /// <summary>
        /// SXPID.
        /// </summary>
        public const string SXPID = "SXPID";

        /// <summary>
        /// SXJOBN.
        /// </summary>
        public const string SXJOBN = "SXJOBN";

        /// <summary>
        /// SXTORG.
        /// </summary>
        public const string SXTORG = "SXTORG";

        /// <summary>
        /// SXUUPMJ.
        /// </summary>
        public const string SXUUPMJ = "SXUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F43E15";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SXCOOKIE", "SXCOOKIE", JdeDataType.String, 400, true, true),
        new JdeField("SXSUPITMID", "SXSUPITMID", JdeDataType.String, 60, true, true),
        new JdeField("SXITMAUXID", "SXITMAUXID", JdeDataType.String, 100),
        new JdeField("SXGENKEY", "SXGENKEY", JdeDataType.String, 80),
        new JdeField("SXCRSREF01", "SXCRSREF01", JdeDataType.String, 600),
        new JdeField("SXCRSREF02", "SXCRSREF02", JdeDataType.String, 600),
        new JdeField("SXCRSREF03", "SXCRSREF03", JdeDataType.String, 600),
        new JdeField("SXCRSREF04", "SXCRSREF04", JdeDataType.String, 600),
        new JdeField("SXCRSREF05", "SXCRSREF05", JdeDataType.String, 600),
        new JdeField("SXURCD", "SXURCD", JdeDataType.String, 4),
        new JdeField("SXURDT", "SXURDT", JdeDataType.Numeric),
        new JdeField("SXURAT", "SXURAT", JdeDataType.Numeric),
        new JdeField("SXURAB", "SXURAB", JdeDataType.Numeric),
        new JdeField("SXURRF", "SXURRF", JdeDataType.String, 30),
        new JdeField("SXUSER", "SXUSER", JdeDataType.String, 20),
        new JdeField("SXPID", "SXPID", JdeDataType.String, 20),
        new JdeField("SXJOBN", "SXJOBN", JdeDataType.String, 20),
        new JdeField("SXTORG", "SXTORG", JdeDataType.String, 20),
        new JdeField("SXUUPMJ", "SXUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E15_0", "Primary Key on SXCOOKIE, SXSUPITMID", new[] { "SXCOOKIE", "SXSUPITMID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43E15_2", "Index on SXGENKEY", new[] { "SXGENKEY" }),
        new JdeIndex("F43E15_3", "Index on SXCOOKIE, SXITMAUXID, SXSUPITMID", new[] { "SXCOOKIE", "SXITMAUXID", "SXSUPITMID" })
    };
}
