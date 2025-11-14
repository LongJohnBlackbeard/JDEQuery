using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0521 - .
/// </summary>
public class F76B0521 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IMJOBS.
        /// </summary>
        public const string IMJOBS = "IMJOBS";

        /// <summary>
        /// IMITM.
        /// </summary>
        public const string IMITM = "IMITM";

        /// <summary>
        /// IMLITM.
        /// </summary>
        public const string IMLITM = "IMLITM";

        /// <summary>
        /// IMAITM.
        /// </summary>
        public const string IMAITM = "IMAITM";

        /// <summary>
        /// IMDSC1.
        /// </summary>
        public const string IMDSC1 = "IMDSC1";

        /// <summary>
        /// IMURCD.
        /// </summary>
        public const string IMURCD = "IMURCD";

        /// <summary>
        /// IMURDT.
        /// </summary>
        public const string IMURDT = "IMURDT";

        /// <summary>
        /// IMURAT.
        /// </summary>
        public const string IMURAT = "IMURAT";

        /// <summary>
        /// IMURAB.
        /// </summary>
        public const string IMURAB = "IMURAB";

        /// <summary>
        /// IMURRF.
        /// </summary>
        public const string IMURRF = "IMURRF";

        /// <summary>
        /// IMUSER.
        /// </summary>
        public const string IMUSER = "IMUSER";

        /// <summary>
        /// IMPID.
        /// </summary>
        public const string IMPID = "IMPID";

        /// <summary>
        /// IMJOBN.
        /// </summary>
        public const string IMJOBN = "IMJOBN";

        /// <summary>
        /// IMUPMJ.
        /// </summary>
        public const string IMUPMJ = "IMUPMJ";

        /// <summary>
        /// IMUPMT.
        /// </summary>
        public const string IMUPMT = "IMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0521";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IMJOBS", "IMJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("IMITM", "IMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IMLITM", "IMLITM", JdeDataType.String, 50),
        new JdeField("IMAITM", "IMAITM", JdeDataType.String, 50),
        new JdeField("IMDSC1", "IMDSC1", JdeDataType.String, 60),
        new JdeField("IMURCD", "IMURCD", JdeDataType.String, 4),
        new JdeField("IMURDT", "IMURDT", JdeDataType.Numeric),
        new JdeField("IMURAT", "IMURAT", JdeDataType.Numeric),
        new JdeField("IMURAB", "IMURAB", JdeDataType.Numeric),
        new JdeField("IMURRF", "IMURRF", JdeDataType.String, 30),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMUPMT", "IMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0521_0", "Primary Key on IMJOBS, IMITM", new[] { "IMJOBS", "IMITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B0521_2", "Index on IMLITM", new[] { "IMLITM" }),
        new JdeIndex("F76B0521_3", "Index on IMAITM", new[] { "IMAITM" })
    };
}
