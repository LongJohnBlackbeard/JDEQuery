using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4551 - .
/// </summary>
public class F4551 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDPRGR.
        /// </summary>
        public const string BDPRGR = "BDPRGR";

        /// <summary>
        /// BDITM.
        /// </summary>
        public const string BDITM = "BDITM";

        /// <summary>
        /// BDIGID.
        /// </summary>
        public const string BDIGID = "BDIGID";

        /// <summary>
        /// BDEFTJ.
        /// </summary>
        public const string BDEFTJ = "BDEFTJ";

        /// <summary>
        /// BDEXDJ.
        /// </summary>
        public const string BDEXDJ = "BDEXDJ";

        /// <summary>
        /// BDBSKTA.
        /// </summary>
        public const string BDBSKTA = "BDBSKTA";

        /// <summary>
        /// BDBSKTP.
        /// </summary>
        public const string BDBSKTP = "BDBSKTP";

        /// <summary>
        /// BDUOM.
        /// </summary>
        public const string BDUOM = "BDUOM";

        /// <summary>
        /// BDURCD.
        /// </summary>
        public const string BDURCD = "BDURCD";

        /// <summary>
        /// BDURDT.
        /// </summary>
        public const string BDURDT = "BDURDT";

        /// <summary>
        /// BDURAT.
        /// </summary>
        public const string BDURAT = "BDURAT";

        /// <summary>
        /// BDURAB.
        /// </summary>
        public const string BDURAB = "BDURAB";

        /// <summary>
        /// BDURRF.
        /// </summary>
        public const string BDURRF = "BDURRF";

        /// <summary>
        /// BDUSER.
        /// </summary>
        public const string BDUSER = "BDUSER";

        /// <summary>
        /// BDPID.
        /// </summary>
        public const string BDPID = "BDPID";

        /// <summary>
        /// BDJOBN.
        /// </summary>
        public const string BDJOBN = "BDJOBN";

        /// <summary>
        /// BDUPMJ.
        /// </summary>
        public const string BDUPMJ = "BDUPMJ";

        /// <summary>
        /// BDTDAY.
        /// </summary>
        public const string BDTDAY = "BDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4551";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDPRGR", "BDPRGR", JdeDataType.String, 16, true, true),
        new JdeField("BDITM", "BDITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BDIGID", "BDIGID", JdeDataType.Numeric, null, true, true),
        new JdeField("BDEFTJ", "BDEFTJ", JdeDataType.Numeric),
        new JdeField("BDEXDJ", "BDEXDJ", JdeDataType.Numeric),
        new JdeField("BDBSKTA", "BDBSKTA", JdeDataType.String, 2),
        new JdeField("BDBSKTP", "BDBSKTP", JdeDataType.String, 2),
        new JdeField("BDUOM", "BDUOM", JdeDataType.String, 4),
        new JdeField("BDURCD", "BDURCD", JdeDataType.String, 4),
        new JdeField("BDURDT", "BDURDT", JdeDataType.Numeric),
        new JdeField("BDURAT", "BDURAT", JdeDataType.Numeric),
        new JdeField("BDURAB", "BDURAB", JdeDataType.Numeric),
        new JdeField("BDURRF", "BDURRF", JdeDataType.String, 30),
        new JdeField("BDUSER", "BDUSER", JdeDataType.String, 20),
        new JdeField("BDPID", "BDPID", JdeDataType.String, 20),
        new JdeField("BDJOBN", "BDJOBN", JdeDataType.String, 20),
        new JdeField("BDUPMJ", "BDUPMJ", JdeDataType.Numeric),
        new JdeField("BDTDAY", "BDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4551_0", "Primary Key on BDPRGR, BDITM, BDIGID", new[] { "BDPRGR", "BDITM", "BDIGID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4551_2", "Index on BDITM, BDIGID", new[] { "BDITM", "BDIGID" })
    };
}
