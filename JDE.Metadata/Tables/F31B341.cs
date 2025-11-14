using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B341 - .
/// </summary>
public class F31B341 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWUKID.
        /// </summary>
        public const string SWUKID = "SWUKID";

        /// <summary>
        /// SWSITEM.
        /// </summary>
        public const string SWSITEM = "SWSITEM";

        /// <summary>
        /// SWMCU.
        /// </summary>
        public const string SWMCU = "SWMCU";

        /// <summary>
        /// SWSCODE.
        /// </summary>
        public const string SWSCODE = "SWSCODE";

        /// <summary>
        /// SWURCD.
        /// </summary>
        public const string SWURCD = "SWURCD";

        /// <summary>
        /// SWURDT.
        /// </summary>
        public const string SWURDT = "SWURDT";

        /// <summary>
        /// SWURAT.
        /// </summary>
        public const string SWURAT = "SWURAT";

        /// <summary>
        /// SWURRF.
        /// </summary>
        public const string SWURRF = "SWURRF";

        /// <summary>
        /// SWURAB.
        /// </summary>
        public const string SWURAB = "SWURAB";

        /// <summary>
        /// SWUSER.
        /// </summary>
        public const string SWUSER = "SWUSER";

        /// <summary>
        /// SWPID.
        /// </summary>
        public const string SWPID = "SWPID";

        /// <summary>
        /// SWJOBN.
        /// </summary>
        public const string SWJOBN = "SWJOBN";

        /// <summary>
        /// SWUPMJ.
        /// </summary>
        public const string SWUPMJ = "SWUPMJ";

        /// <summary>
        /// SWUPMT.
        /// </summary>
        public const string SWUPMT = "SWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B341";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWUKID", "SWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SWSITEM", "SWSITEM", JdeDataType.String, 24),
        new JdeField("SWMCU", "SWMCU", JdeDataType.String, 24),
        new JdeField("SWSCODE", "SWSCODE", JdeDataType.String, 2),
        new JdeField("SWURCD", "SWURCD", JdeDataType.String, 4),
        new JdeField("SWURDT", "SWURDT", JdeDataType.Numeric),
        new JdeField("SWURAT", "SWURAT", JdeDataType.Numeric),
        new JdeField("SWURRF", "SWURRF", JdeDataType.String, 30),
        new JdeField("SWURAB", "SWURAB", JdeDataType.Numeric),
        new JdeField("SWUSER", "SWUSER", JdeDataType.String, 20),
        new JdeField("SWPID", "SWPID", JdeDataType.String, 20),
        new JdeField("SWJOBN", "SWJOBN", JdeDataType.String, 20),
        new JdeField("SWUPMJ", "SWUPMJ", JdeDataType.Numeric),
        new JdeField("SWUPMT", "SWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B341_0", "Primary Key on SWUKID", new[] { "SWUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B341_2", "Index on SWSITEM, SWMCU", new[] { "SWSITEM", "SWMCU" }),
        new JdeIndex("F31B341_3", "Index on SWSITEM", new[] { "SWSITEM" }),
        new JdeIndex("F31B341_4", "Index on SWMCU", new[] { "SWMCU" })
    };
}
