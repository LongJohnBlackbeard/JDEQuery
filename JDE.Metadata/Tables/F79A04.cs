using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A04 - .
/// </summary>
public class F79A04 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GFITM.
        /// </summary>
        public const string GFITM = "GFITM";

        /// <summary>
        /// GFMCU.
        /// </summary>
        public const string GFMCU = "GFMCU";

        /// <summary>
        /// GF79AGHGTT.
        /// </summary>
        public const string GF79AGHGTT = "GF79AGHGTT";

        /// <summary>
        /// GFNUMB.
        /// </summary>
        public const string GFNUMB = "GFNUMB";

        /// <summary>
        /// GFAPID.
        /// </summary>
        public const string GFAPID = "GFAPID";

        /// <summary>
        /// GFLITM.
        /// </summary>
        public const string GFLITM = "GFLITM";

        /// <summary>
        /// GFAITM.
        /// </summary>
        public const string GFAITM = "GFAITM";

        /// <summary>
        /// GFBEFD.
        /// </summary>
        public const string GFBEFD = "GFBEFD";

        /// <summary>
        /// GFEEFD.
        /// </summary>
        public const string GFEEFD = "GFEEFD";

        /// <summary>
        /// GF79AGESID.
        /// </summary>
        public const string GF79AGESID = "GF79AGESID";

        /// <summary>
        /// GF79AEMSC.
        /// </summary>
        public const string GF79AEMSC = "GF79AEMSC";

        /// <summary>
        /// GF79AGIT.
        /// </summary>
        public const string GF79AGIT = "GF79AGIT";

        /// <summary>
        /// GFURCD.
        /// </summary>
        public const string GFURCD = "GFURCD";

        /// <summary>
        /// GFURDT.
        /// </summary>
        public const string GFURDT = "GFURDT";

        /// <summary>
        /// GFURAT.
        /// </summary>
        public const string GFURAT = "GFURAT";

        /// <summary>
        /// GFURAB.
        /// </summary>
        public const string GFURAB = "GFURAB";

        /// <summary>
        /// GFURRF.
        /// </summary>
        public const string GFURRF = "GFURRF";

        /// <summary>
        /// GFUSER.
        /// </summary>
        public const string GFUSER = "GFUSER";

        /// <summary>
        /// GFPID.
        /// </summary>
        public const string GFPID = "GFPID";

        /// <summary>
        /// GFJOBN.
        /// </summary>
        public const string GFJOBN = "GFJOBN";

        /// <summary>
        /// GFUPMJ.
        /// </summary>
        public const string GFUPMJ = "GFUPMJ";

        /// <summary>
        /// GFUPMT.
        /// </summary>
        public const string GFUPMT = "GFUPMT";

        /// <summary>
        /// GF79AGOID.
        /// </summary>
        public const string GF79AGOID = "GF79AGOID";
    }

    /// <inheritdoc />
    public override string TableName => "F79A04";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GFITM", "GFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("GFMCU", "GFMCU", JdeDataType.String, 24, true, true),
        new JdeField("GF79AGHGTT", "GF79AGHGTT", JdeDataType.String, 10, true, true),
        new JdeField("GFNUMB", "GFNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("GFAPID", "GFAPID", JdeDataType.String, 24),
        new JdeField("GFLITM", "GFLITM", JdeDataType.String, 50),
        new JdeField("GFAITM", "GFAITM", JdeDataType.String, 50),
        new JdeField("GFBEFD", "GFBEFD", JdeDataType.Numeric, null, true, true),
        new JdeField("GFEEFD", "GFEEFD", JdeDataType.Numeric),
        new JdeField("GF79AGESID", "GF79AGESID", JdeDataType.Numeric),
        new JdeField("GF79AEMSC", "GF79AEMSC", JdeDataType.String, 20),
        new JdeField("GF79AGIT", "GF79AGIT", JdeDataType.String, 2),
        new JdeField("GFURCD", "GFURCD", JdeDataType.String, 4),
        new JdeField("GFURDT", "GFURDT", JdeDataType.Numeric),
        new JdeField("GFURAT", "GFURAT", JdeDataType.Numeric),
        new JdeField("GFURAB", "GFURAB", JdeDataType.Numeric),
        new JdeField("GFURRF", "GFURRF", JdeDataType.String, 30),
        new JdeField("GFUSER", "GFUSER", JdeDataType.String, 20),
        new JdeField("GFPID", "GFPID", JdeDataType.String, 20),
        new JdeField("GFJOBN", "GFJOBN", JdeDataType.String, 20),
        new JdeField("GFUPMJ", "GFUPMJ", JdeDataType.Numeric),
        new JdeField("GFUPMT", "GFUPMT", JdeDataType.Numeric),
        new JdeField("GF79AGOID", "GF79AGOID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A04_0", "Primary Key on GFITM, GFMCU, GF79AGHGTT, GFNUMB, GFBEFD, GF79AGOID", new[] { "GFITM", "GFMCU", "GF79AGHGTT", "GFNUMB", "GFBEFD", "GF79AGOID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A04_2", "Index on GFLITM, GFMCU, GF79AGHGTT, GFAPID, GFBEFD", new[] { "GFLITM", "GFMCU", "GF79AGHGTT", "GFAPID", "GFBEFD" }),
        new JdeIndex("F79A04_3", "Index on GFAITM, GFMCU, GF79AGHGTT, GFAPID, GFBEFD", new[] { "GFAITM", "GFMCU", "GF79AGHGTT", "GFAPID", "GFBEFD" }),
        new JdeIndex("F79A04_4", "Index on GFMCU, GFBEFD", new[] { "GFMCU", "GFBEFD" })
    };
}
