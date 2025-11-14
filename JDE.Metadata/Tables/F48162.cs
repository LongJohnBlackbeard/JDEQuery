using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48162 - .
/// </summary>
public class F48162 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KNKBTNM.
        /// </summary>
        public const string KNKBTNM = "KNKBTNM";

        /// <summary>
        /// KNDS40.
        /// </summary>
        public const string KNDS40 = "KNDS40";

        /// <summary>
        /// KNKNLT.
        /// </summary>
        public const string KNKNLT = "KNKNLT";

        /// <summary>
        /// KNPRODF.
        /// </summary>
        public const string KNPRODF = "KNPRODF";

        /// <summary>
        /// KNPRODM.
        /// </summary>
        public const string KNPRODM = "KNPRODM";

        /// <summary>
        /// KNPRODC.
        /// </summary>
        public const string KNPRODC = "KNPRODC";

        /// <summary>
        /// KNITM.
        /// </summary>
        public const string KNITM = "KNITM";

        /// <summary>
        /// KNENV.
        /// </summary>
        public const string KNENV = "KNENV";

        /// <summary>
        /// KNZE01.
        /// </summary>
        public const string KNZE01 = "KNZE01";

        /// <summary>
        /// KNZE02.
        /// </summary>
        public const string KNZE02 = "KNZE02";

        /// <summary>
        /// KNZE03.
        /// </summary>
        public const string KNZE03 = "KNZE03";

        /// <summary>
        /// KNZE04.
        /// </summary>
        public const string KNZE04 = "KNZE04";

        /// <summary>
        /// KNZE05.
        /// </summary>
        public const string KNZE05 = "KNZE05";

        /// <summary>
        /// KNZE06.
        /// </summary>
        public const string KNZE06 = "KNZE06";

        /// <summary>
        /// KNZE07.
        /// </summary>
        public const string KNZE07 = "KNZE07";

        /// <summary>
        /// KNZE08.
        /// </summary>
        public const string KNZE08 = "KNZE08";

        /// <summary>
        /// KNZE09.
        /// </summary>
        public const string KNZE09 = "KNZE09";

        /// <summary>
        /// KNZE10.
        /// </summary>
        public const string KNZE10 = "KNZE10";

        /// <summary>
        /// KNURAB.
        /// </summary>
        public const string KNURAB = "KNURAB";

        /// <summary>
        /// KNURAT.
        /// </summary>
        public const string KNURAT = "KNURAT";

        /// <summary>
        /// KNURCD.
        /// </summary>
        public const string KNURCD = "KNURCD";

        /// <summary>
        /// KNURDT.
        /// </summary>
        public const string KNURDT = "KNURDT";

        /// <summary>
        /// KNURRF.
        /// </summary>
        public const string KNURRF = "KNURRF";

        /// <summary>
        /// KNCRTU.
        /// </summary>
        public const string KNCRTU = "KNCRTU";

        /// <summary>
        /// KNUSER.
        /// </summary>
        public const string KNUSER = "KNUSER";

        /// <summary>
        /// KNJOBN.
        /// </summary>
        public const string KNJOBN = "KNJOBN";

        /// <summary>
        /// KNPID.
        /// </summary>
        public const string KNPID = "KNPID";

        /// <summary>
        /// KNUPMJ.
        /// </summary>
        public const string KNUPMJ = "KNUPMJ";

        /// <summary>
        /// KNUPMT.
        /// </summary>
        public const string KNUPMT = "KNUPMT";

        /// <summary>
        /// KNNUMB.
        /// </summary>
        public const string KNNUMB = "KNNUMB";
    }

    /// <inheritdoc />
    public override string TableName => "F48162";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KNKBTNM", "KNKBTNM", JdeDataType.String, 30, true, true),
        new JdeField("KNDS40", "KNDS40", JdeDataType.String, 80),
        new JdeField("KNKNLT", "KNKNLT", JdeDataType.String, 2),
        new JdeField("KNPRODF", "KNPRODF", JdeDataType.String, 16),
        new JdeField("KNPRODM", "KNPRODM", JdeDataType.String, 16),
        new JdeField("KNPRODC", "KNPRODC", JdeDataType.String, 20),
        new JdeField("KNITM", "KNITM", JdeDataType.Numeric),
        new JdeField("KNENV", "KNENV", JdeDataType.String, 20),
        new JdeField("KNZE01", "KNZE01", JdeDataType.String, 20),
        new JdeField("KNZE02", "KNZE02", JdeDataType.String, 20),
        new JdeField("KNZE03", "KNZE03", JdeDataType.String, 20),
        new JdeField("KNZE04", "KNZE04", JdeDataType.String, 20),
        new JdeField("KNZE05", "KNZE05", JdeDataType.String, 20),
        new JdeField("KNZE06", "KNZE06", JdeDataType.String, 20),
        new JdeField("KNZE07", "KNZE07", JdeDataType.String, 20),
        new JdeField("KNZE08", "KNZE08", JdeDataType.String, 20),
        new JdeField("KNZE09", "KNZE09", JdeDataType.String, 20),
        new JdeField("KNZE10", "KNZE10", JdeDataType.String, 20),
        new JdeField("KNURAB", "KNURAB", JdeDataType.Numeric),
        new JdeField("KNURAT", "KNURAT", JdeDataType.Numeric),
        new JdeField("KNURCD", "KNURCD", JdeDataType.String, 4),
        new JdeField("KNURDT", "KNURDT", JdeDataType.Numeric),
        new JdeField("KNURRF", "KNURRF", JdeDataType.String, 30),
        new JdeField("KNCRTU", "KNCRTU", JdeDataType.String, 20),
        new JdeField("KNUSER", "KNUSER", JdeDataType.String, 20),
        new JdeField("KNJOBN", "KNJOBN", JdeDataType.String, 20),
        new JdeField("KNPID", "KNPID", JdeDataType.String, 20),
        new JdeField("KNUPMJ", "KNUPMJ", JdeDataType.Numeric),
        new JdeField("KNUPMT", "KNUPMT", JdeDataType.Numeric),
        new JdeField("KNNUMB", "KNNUMB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48162_0", "Primary Key on KNKBTNM", new[] { "KNKBTNM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48162_2", "Index on KNNUMB, KNITM, KNPRODF, KNPRODM, KNPRODC, KNENV, KNKNLT", new[] { "KNNUMB", "KNITM", "KNPRODF", "KNPRODM", "KNPRODC", "KNENV", "KNKNLT" })
    };
}
