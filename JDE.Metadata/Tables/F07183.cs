using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07183 - .
/// </summary>
public class F07183 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZBAN8.
        /// </summary>
        public const string ZBAN8 = "ZBAN8";

        /// <summary>
        /// ZBCKCN.
        /// </summary>
        public const string ZBCKCN = "ZBCKCN";

        /// <summary>
        /// ZBHMO.
        /// </summary>
        public const string ZBHMO = "ZBHMO";

        /// <summary>
        /// ZBDWK.
        /// </summary>
        public const string ZBDWK = "ZBDWK";

        /// <summary>
        /// ZBPPED.
        /// </summary>
        public const string ZBPPED = "ZBPPED";

        /// <summary>
        /// ZBCKDT.
        /// </summary>
        public const string ZBCKDT = "ZBCKDT";

        /// <summary>
        /// ZBPDBA.
        /// </summary>
        public const string ZBPDBA = "ZBPDBA";

        /// <summary>
        /// ZBPB.
        /// </summary>
        public const string ZBPB = "ZBPB";

        /// <summary>
        /// ZBHMCO.
        /// </summary>
        public const string ZBHMCO = "ZBHMCO";

        /// <summary>
        /// ZBGPA.
        /// </summary>
        public const string ZBGPA = "ZBGPA";

        /// <summary>
        /// ZBJBCD.
        /// </summary>
        public const string ZBJBCD = "ZBJBCD";

        /// <summary>
        /// ZBJBST.
        /// </summary>
        public const string ZBJBST = "ZBJBST";

        /// <summary>
        /// ZBWST.
        /// </summary>
        public const string ZBWST = "ZBWST";

        /// <summary>
        /// ZBWCNT.
        /// </summary>
        public const string ZBWCNT = "ZBWCNT";

        /// <summary>
        /// ZBWCTY.
        /// </summary>
        public const string ZBWCTY = "ZBWCTY";

        /// <summary>
        /// ZBMCU.
        /// </summary>
        public const string ZBMCU = "ZBMCU";

        /// <summary>
        /// ZBWCMP.
        /// </summary>
        public const string ZBWCMP = "ZBWCMP";

        /// <summary>
        /// ZBWET.
        /// </summary>
        public const string ZBWET = "ZBWET";
    }

    /// <inheritdoc />
    public override string TableName => "F07183";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZBAN8", "ZBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZBCKCN", "ZBCKCN", JdeDataType.Numeric),
        new JdeField("ZBHMO", "ZBHMO", JdeDataType.Numeric),
        new JdeField("ZBDWK", "ZBDWK", JdeDataType.Numeric),
        new JdeField("ZBPPED", "ZBPPED", JdeDataType.Numeric, null, true, true),
        new JdeField("ZBCKDT", "ZBCKDT", JdeDataType.Numeric),
        new JdeField("ZBPDBA", "ZBPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("ZBPB", "ZBPB", JdeDataType.String, 2),
        new JdeField("ZBHMCO", "ZBHMCO", JdeDataType.String, 10),
        new JdeField("ZBGPA", "ZBGPA", JdeDataType.Numeric),
        new JdeField("ZBJBCD", "ZBJBCD", JdeDataType.String, 12),
        new JdeField("ZBJBST", "ZBJBST", JdeDataType.String, 8),
        new JdeField("ZBWST", "ZBWST", JdeDataType.Numeric),
        new JdeField("ZBWCNT", "ZBWCNT", JdeDataType.Numeric),
        new JdeField("ZBWCTY", "ZBWCTY", JdeDataType.Numeric),
        new JdeField("ZBMCU", "ZBMCU", JdeDataType.String, 24),
        new JdeField("ZBWCMP", "ZBWCMP", JdeDataType.String, 8),
        new JdeField("ZBWET", "ZBWET", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07183_0", "Primary Key on ZBAN8, ZBPPED, ZBPDBA", new[] { "ZBAN8", "ZBPPED", "ZBPDBA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07183_2", "Index on ZBAN8, ZBPPED", new[] { "ZBAN8", "ZBPPED" }),
        new JdeIndex("F07183_3", "Index on ZBAN8, ZBCKCN", new[] { "ZBAN8", "ZBCKCN" })
    };
}
