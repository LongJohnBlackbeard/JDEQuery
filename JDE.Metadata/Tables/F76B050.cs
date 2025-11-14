using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B050 - .
/// </summary>
public class F76B050 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WAB76ATCT.
        /// </summary>
        public const string WAB76ATCT = "WAB76ATCT";

        /// <summary>
        /// WAJOBS.
        /// </summary>
        public const string WAJOBS = "WAJOBS";

        /// <summary>
        /// WAB76BLCK.
        /// </summary>
        public const string WAB76BLCK = "WAB76BLCK";

        /// <summary>
        /// WATAX.
        /// </summary>
        public const string WATAX = "WATAX";

        /// <summary>
        /// WACO.
        /// </summary>
        public const string WACO = "WACO";

        /// <summary>
        /// WAAN8.
        /// </summary>
        public const string WAAN8 = "WAAN8";

        /// <summary>
        /// WAB76URAB.
        /// </summary>
        public const string WAB76URAB = "WAB76URAB";

        /// <summary>
        /// WAB76URAT.
        /// </summary>
        public const string WAB76URAT = "WAB76URAT";

        /// <summary>
        /// WAB76URRF.
        /// </summary>
        public const string WAB76URRF = "WAB76URRF";

        /// <summary>
        /// WAB76URDT.
        /// </summary>
        public const string WAB76URDT = "WAB76URDT";

        /// <summary>
        /// WAB76URCD.
        /// </summary>
        public const string WAB76URCD = "WAB76URCD";

        /// <summary>
        /// WAUSER.
        /// </summary>
        public const string WAUSER = "WAUSER";

        /// <summary>
        /// WAPID.
        /// </summary>
        public const string WAPID = "WAPID";

        /// <summary>
        /// WAJOBN.
        /// </summary>
        public const string WAJOBN = "WAJOBN";

        /// <summary>
        /// WAUPMJ.
        /// </summary>
        public const string WAUPMJ = "WAUPMJ";

        /// <summary>
        /// WAUPMT.
        /// </summary>
        public const string WAUPMT = "WAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B050";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WAB76ATCT", "WAB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("WAJOBS", "WAJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WAB76BLCK", "WAB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("WATAX", "WATAX", JdeDataType.String, 40, true, true),
        new JdeField("WACO", "WACO", JdeDataType.String, 10, true, true),
        new JdeField("WAAN8", "WAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WAB76URAB", "WAB76URAB", JdeDataType.Numeric),
        new JdeField("WAB76URAT", "WAB76URAT", JdeDataType.Numeric),
        new JdeField("WAB76URRF", "WAB76URRF", JdeDataType.String, 30),
        new JdeField("WAB76URDT", "WAB76URDT", JdeDataType.Numeric),
        new JdeField("WAB76URCD", "WAB76URCD", JdeDataType.String, 4),
        new JdeField("WAUSER", "WAUSER", JdeDataType.String, 20),
        new JdeField("WAPID", "WAPID", JdeDataType.String, 20),
        new JdeField("WAJOBN", "WAJOBN", JdeDataType.String, 20),
        new JdeField("WAUPMJ", "WAUPMJ", JdeDataType.Numeric),
        new JdeField("WAUPMT", "WAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B050_0", "Primary Key on WAJOBS, WAB76ATCT, WAB76BLCK, WATAX, WACO, WAAN8", new[] { "WAJOBS", "WAB76ATCT", "WAB76BLCK", "WATAX", "WACO", "WAAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
