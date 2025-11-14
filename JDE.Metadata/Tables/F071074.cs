using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F071074 - .
/// </summary>
public class F071074 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WEAN8.
        /// </summary>
        public const string WEAN8 = "WEAN8";

        /// <summary>
        /// WEPDBA.
        /// </summary>
        public const string WEPDBA = "WEPDBA";

        /// <summary>
        /// WEWANO.
        /// </summary>
        public const string WEWANO = "WEWANO";

        /// <summary>
        /// WEEXMT.
        /// </summary>
        public const string WEEXMT = "WEEXMT";

        /// <summary>
        /// WEEXXA.
        /// </summary>
        public const string WEEXXA = "WEEXXA";

        /// <summary>
        /// WEDESQ.
        /// </summary>
        public const string WEDESQ = "WEDESQ";

        /// <summary>
        /// WEFTC.
        /// </summary>
        public const string WEFTC = "WEFTC";

        /// <summary>
        /// WEMINE.
        /// </summary>
        public const string WEMINE = "WEMINE";

        /// <summary>
        /// WEMAXE.
        /// </summary>
        public const string WEMAXE = "WEMAXE";

        /// <summary>
        /// WEUPMJ.
        /// </summary>
        public const string WEUPMJ = "WEUPMJ";

        /// <summary>
        /// WEUPMT.
        /// </summary>
        public const string WEUPMT = "WEUPMT";

        /// <summary>
        /// WEPID.
        /// </summary>
        public const string WEPID = "WEPID";

        /// <summary>
        /// WEJOBN.
        /// </summary>
        public const string WEJOBN = "WEJOBN";

        /// <summary>
        /// WEUSER.
        /// </summary>
        public const string WEUSER = "WEUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F071074";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WEAN8", "WEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WEPDBA", "WEPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("WEWANO", "WEWANO", JdeDataType.Numeric, null, true, true),
        new JdeField("WEEXMT", "WEEXMT", JdeDataType.String, 2),
        new JdeField("WEEXXA", "WEEXXA", JdeDataType.Numeric),
        new JdeField("WEDESQ", "WEDESQ", JdeDataType.String, 2),
        new JdeField("WEFTC", "WEFTC", JdeDataType.String, 10),
        new JdeField("WEMINE", "WEMINE", JdeDataType.Numeric),
        new JdeField("WEMAXE", "WEMAXE", JdeDataType.Numeric),
        new JdeField("WEUPMJ", "WEUPMJ", JdeDataType.Numeric),
        new JdeField("WEUPMT", "WEUPMT", JdeDataType.Numeric),
        new JdeField("WEPID", "WEPID", JdeDataType.String, 20),
        new JdeField("WEJOBN", "WEJOBN", JdeDataType.String, 20),
        new JdeField("WEUSER", "WEUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F071074_0", "Primary Key on WEAN8, WEPDBA, WEWANO", new[] { "WEAN8", "WEPDBA", "WEWANO" }, isUnique: true, isPrimaryKey: true)
    };
}
