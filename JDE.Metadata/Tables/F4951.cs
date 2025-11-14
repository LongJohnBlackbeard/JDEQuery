using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4951 - .
/// </summary>
public class F4951 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZNORGN.
        /// </summary>
        public const string ZNORGN = "ZNORGN";

        /// <summary>
        /// ZNCZON.
        /// </summary>
        public const string ZNCZON = "ZNCZON";

        /// <summary>
        /// ZNZTO.
        /// </summary>
        public const string ZNZTO = "ZNZTO";

        /// <summary>
        /// ZNZTH.
        /// </summary>
        public const string ZNZTH = "ZNZTH";

        /// <summary>
        /// ZNCTY1.
        /// </summary>
        public const string ZNCTY1 = "ZNCTY1";

        /// <summary>
        /// ZNADDS.
        /// </summary>
        public const string ZNADDS = "ZNADDS";

        /// <summary>
        /// ZNCOUN.
        /// </summary>
        public const string ZNCOUN = "ZNCOUN";

        /// <summary>
        /// ZNCTR.
        /// </summary>
        public const string ZNCTR = "ZNCTR";

        /// <summary>
        /// ZNURCD.
        /// </summary>
        public const string ZNURCD = "ZNURCD";

        /// <summary>
        /// ZNURDT.
        /// </summary>
        public const string ZNURDT = "ZNURDT";

        /// <summary>
        /// ZNURAT.
        /// </summary>
        public const string ZNURAT = "ZNURAT";

        /// <summary>
        /// ZNURAB.
        /// </summary>
        public const string ZNURAB = "ZNURAB";

        /// <summary>
        /// ZNURRF.
        /// </summary>
        public const string ZNURRF = "ZNURRF";

        /// <summary>
        /// ZNUSER.
        /// </summary>
        public const string ZNUSER = "ZNUSER";

        /// <summary>
        /// ZNPID.
        /// </summary>
        public const string ZNPID = "ZNPID";

        /// <summary>
        /// ZNJOBN.
        /// </summary>
        public const string ZNJOBN = "ZNJOBN";

        /// <summary>
        /// ZNUPMJ.
        /// </summary>
        public const string ZNUPMJ = "ZNUPMJ";

        /// <summary>
        /// ZNTDAY.
        /// </summary>
        public const string ZNTDAY = "ZNTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4951";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZNORGN", "ZNORGN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZNCZON", "ZNCZON", JdeDataType.String, 20, true, true),
        new JdeField("ZNZTO", "ZNZTO", JdeDataType.String, 24, true, true),
        new JdeField("ZNZTH", "ZNZTH", JdeDataType.String, 24),
        new JdeField("ZNCTY1", "ZNCTY1", JdeDataType.String, 50, true, true),
        new JdeField("ZNADDS", "ZNADDS", JdeDataType.String, 6, true, true),
        new JdeField("ZNCOUN", "ZNCOUN", JdeDataType.String, 50, true, true),
        new JdeField("ZNCTR", "ZNCTR", JdeDataType.String, 6, true, true),
        new JdeField("ZNURCD", "ZNURCD", JdeDataType.String, 4),
        new JdeField("ZNURDT", "ZNURDT", JdeDataType.Numeric),
        new JdeField("ZNURAT", "ZNURAT", JdeDataType.Numeric),
        new JdeField("ZNURAB", "ZNURAB", JdeDataType.Numeric),
        new JdeField("ZNURRF", "ZNURRF", JdeDataType.String, 30),
        new JdeField("ZNUSER", "ZNUSER", JdeDataType.String, 20),
        new JdeField("ZNPID", "ZNPID", JdeDataType.String, 20),
        new JdeField("ZNJOBN", "ZNJOBN", JdeDataType.String, 20),
        new JdeField("ZNUPMJ", "ZNUPMJ", JdeDataType.Numeric),
        new JdeField("ZNTDAY", "ZNTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4951_0", "Primary Key on ZNORGN, ZNCZON, ZNZTO, ZNCTY1, ZNADDS, ZNCTR, ZNCOUN", new[] { "ZNORGN", "ZNCZON", "ZNZTO", "ZNCTY1", "ZNADDS", "ZNCTR", "ZNCOUN" }, isUnique: true, isPrimaryKey: true)
    };
}
