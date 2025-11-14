using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40P01 - .
/// </summary>
public class F40P01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHPMTN.
        /// </summary>
        public const string PHPMTN = "PHPMTN";

        /// <summary>
        /// PHPRNAME.
        /// </summary>
        public const string PHPRNAME = "PHPRNAME";

        /// <summary>
        /// PHPRSTAT.
        /// </summary>
        public const string PHPRSTAT = "PHPRSTAT";

        /// <summary>
        /// PHPRSRC.
        /// </summary>
        public const string PHPRSRC = "PHPRSRC";

        /// <summary>
        /// PHPRTYPE.
        /// </summary>
        public const string PHPRTYPE = "PHPRTYPE";

        /// <summary>
        /// PHEFTJ.
        /// </summary>
        public const string PHEFTJ = "PHEFTJ";

        /// <summary>
        /// PHEXDJ.
        /// </summary>
        public const string PHEXDJ = "PHEXDJ";

        /// <summary>
        /// PHPRREFR.
        /// </summary>
        public const string PHPRREFR = "PHPRREFR";

        /// <summary>
        /// PHPRREFR2.
        /// </summary>
        public const string PHPRREFR2 = "PHPRREFR2";

        /// <summary>
        /// PHPRTARGR.
        /// </summary>
        public const string PHPRTARGR = "PHPRTARGR";

        /// <summary>
        /// PHPRTARQ1.
        /// </summary>
        public const string PHPRTARQ1 = "PHPRTARQ1";

        /// <summary>
        /// PHPRTARQ2.
        /// </summary>
        public const string PHPRTARQ2 = "PHPRTARQ2";

        /// <summary>
        /// PHUOM.
        /// </summary>
        public const string PHUOM = "PHUOM";

        /// <summary>
        /// PHURAT.
        /// </summary>
        public const string PHURAT = "PHURAT";

        /// <summary>
        /// PHURAB.
        /// </summary>
        public const string PHURAB = "PHURAB";

        /// <summary>
        /// PHURRF.
        /// </summary>
        public const string PHURRF = "PHURRF";

        /// <summary>
        /// PHURCD.
        /// </summary>
        public const string PHURCD = "PHURCD";

        /// <summary>
        /// PHURDT.
        /// </summary>
        public const string PHURDT = "PHURDT";

        /// <summary>
        /// PHFUTUSE12.
        /// </summary>
        public const string PHFUTUSE12 = "PHFUTUSE12";

        /// <summary>
        /// PHFUTUSE13.
        /// </summary>
        public const string PHFUTUSE13 = "PHFUTUSE13";

        /// <summary>
        /// PHFUTUSE14.
        /// </summary>
        public const string PHFUTUSE14 = "PHFUTUSE14";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHPID.
        /// </summary>
        public const string PHPID = "PHPID";

        /// <summary>
        /// PHJOBN.
        /// </summary>
        public const string PHJOBN = "PHJOBN";

        /// <summary>
        /// PHUPMJ.
        /// </summary>
        public const string PHUPMJ = "PHUPMJ";

        /// <summary>
        /// PHTDAY.
        /// </summary>
        public const string PHTDAY = "PHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40P01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHPMTN", "PHPMTN", JdeDataType.String, 24, true, true),
        new JdeField("PHPRNAME", "PHPRNAME", JdeDataType.String, 100),
        new JdeField("PHPRSTAT", "PHPRSTAT", JdeDataType.String, 4),
        new JdeField("PHPRSRC", "PHPRSRC", JdeDataType.String, 60),
        new JdeField("PHPRTYPE", "PHPRTYPE", JdeDataType.String, 4),
        new JdeField("PHEFTJ", "PHEFTJ", JdeDataType.Numeric),
        new JdeField("PHEXDJ", "PHEXDJ", JdeDataType.Numeric),
        new JdeField("PHPRREFR", "PHPRREFR", JdeDataType.String, 60),
        new JdeField("PHPRREFR2", "PHPRREFR2", JdeDataType.String, 60),
        new JdeField("PHPRTARGR", "PHPRTARGR", JdeDataType.Numeric),
        new JdeField("PHPRTARQ1", "PHPRTARQ1", JdeDataType.Numeric),
        new JdeField("PHPRTARQ2", "PHPRTARQ2", JdeDataType.Numeric),
        new JdeField("PHUOM", "PHUOM", JdeDataType.String, 4),
        new JdeField("PHURAT", "PHURAT", JdeDataType.Numeric),
        new JdeField("PHURAB", "PHURAB", JdeDataType.Numeric),
        new JdeField("PHURRF", "PHURRF", JdeDataType.String, 30),
        new JdeField("PHURCD", "PHURCD", JdeDataType.String, 4),
        new JdeField("PHURDT", "PHURDT", JdeDataType.Numeric),
        new JdeField("PHFUTUSE12", "PHFUTUSE12", JdeDataType.String, 8),
        new JdeField("PHFUTUSE13", "PHFUTUSE13", JdeDataType.String, 8),
        new JdeField("PHFUTUSE14", "PHFUTUSE14", JdeDataType.String, 8),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHTDAY", "PHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40P01_0", "Primary Key on PHPMTN", new[] { "PHPMTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40P01_2", "Index on PHPRREFR", new[] { "PHPRREFR" }),
        new JdeIndex("F40P01_3", "Index on PHPRREFR2", new[] { "PHPRREFR2" })
    };
}
