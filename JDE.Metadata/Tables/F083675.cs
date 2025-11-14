using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F083675 - .
/// </summary>
public class F083675 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PFTSTN.
        /// </summary>
        public const string PFTSTN = "PFTSTN";

        /// <summary>
        /// PFTSTY.
        /// </summary>
        public const string PFTSTY = "PFTSTY";

        /// <summary>
        /// PFHMCO.
        /// </summary>
        public const string PFHMCO = "PFHMCO";

        /// <summary>
        /// PFPLAN.
        /// </summary>
        public const string PFPLAN = "PFPLAN";

        /// <summary>
        /// PFHCETSTN.
        /// </summary>
        public const string PFHCETSTN = "PFHCETSTN";

        /// <summary>
        /// PFHCETSTY.
        /// </summary>
        public const string PFHCETSTY = "PFHCETSTY";

        /// <summary>
        /// PFNADPTSTN.
        /// </summary>
        public const string PFNADPTSTN = "PFNADPTSTN";

        /// <summary>
        /// PFNADPTSTY.
        /// </summary>
        public const string PFNADPTSTY = "PFNADPTSTY";

        /// <summary>
        /// PFNACPTSTN.
        /// </summary>
        public const string PFNACPTSTN = "PFNACPTSTN";

        /// <summary>
        /// PFNACPTSTY.
        /// </summary>
        public const string PFNACPTSTY = "PFNACPTSTY";

        /// <summary>
        /// PFUPYTM.
        /// </summary>
        public const string PFUPYTM = "PFUPYTM";

        /// <summary>
        /// PFHCEE.
        /// </summary>
        public const string PFHCEE = "PFHCEE";

        /// <summary>
        /// PFNHCE.
        /// </summary>
        public const string PFNHCE = "PFNHCE";

        /// <summary>
        /// PFADPH.
        /// </summary>
        public const string PFADPH = "PFADPH";

        /// <summary>
        /// PFADP.
        /// </summary>
        public const string PFADP = "PFADP";

        /// <summary>
        /// PFACPH.
        /// </summary>
        public const string PFACPH = "PFACPH";

        /// <summary>
        /// PFACP.
        /// </summary>
        public const string PFACP = "PFACP";

        /// <summary>
        /// PFPID.
        /// </summary>
        public const string PFPID = "PFPID";

        /// <summary>
        /// PFUSER.
        /// </summary>
        public const string PFUSER = "PFUSER";

        /// <summary>
        /// PFUPMJ.
        /// </summary>
        public const string PFUPMJ = "PFUPMJ";

        /// <summary>
        /// PFUPMT.
        /// </summary>
        public const string PFUPMT = "PFUPMT";

        /// <summary>
        /// PFJOBN.
        /// </summary>
        public const string PFJOBN = "PFJOBN";

        /// <summary>
        /// PFMKEY.
        /// </summary>
        public const string PFMKEY = "PFMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F083675";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PFTSTN", "PFTSTN", JdeDataType.String, 16, true, true),
        new JdeField("PFTSTY", "PFTSTY", JdeDataType.Numeric, null, true, true),
        new JdeField("PFHMCO", "PFHMCO", JdeDataType.String, 10, true, true),
        new JdeField("PFPLAN", "PFPLAN", JdeDataType.String, 16),
        new JdeField("PFHCETSTN", "PFHCETSTN", JdeDataType.String, 16),
        new JdeField("PFHCETSTY", "PFHCETSTY", JdeDataType.Numeric),
        new JdeField("PFNADPTSTN", "PFNADPTSTN", JdeDataType.String, 16),
        new JdeField("PFNADPTSTY", "PFNADPTSTY", JdeDataType.Numeric),
        new JdeField("PFNACPTSTN", "PFNACPTSTN", JdeDataType.String, 16),
        new JdeField("PFNACPTSTY", "PFNACPTSTY", JdeDataType.Numeric),
        new JdeField("PFUPYTM", "PFUPYTM", JdeDataType.String, 2),
        new JdeField("PFHCEE", "PFHCEE", JdeDataType.Numeric),
        new JdeField("PFNHCE", "PFNHCE", JdeDataType.Numeric),
        new JdeField("PFADPH", "PFADPH", JdeDataType.Numeric),
        new JdeField("PFADP", "PFADP", JdeDataType.Numeric),
        new JdeField("PFACPH", "PFACPH", JdeDataType.Numeric),
        new JdeField("PFACP", "PFACP", JdeDataType.Numeric),
        new JdeField("PFPID", "PFPID", JdeDataType.String, 20),
        new JdeField("PFUSER", "PFUSER", JdeDataType.String, 20),
        new JdeField("PFUPMJ", "PFUPMJ", JdeDataType.Numeric),
        new JdeField("PFUPMT", "PFUPMT", JdeDataType.Numeric),
        new JdeField("PFJOBN", "PFJOBN", JdeDataType.String, 20),
        new JdeField("PFMKEY", "PFMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F083675_0", "Primary Key on PFTSTN, PFTSTY, PFHMCO", new[] { "PFTSTN", "PFTSTY", "PFHMCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F083675_2", "Index on PFTSTN, SYS_NC00024$, PFHMCO", new[] { "PFTSTN", "SYS_NC00024$", "PFHMCO" })
    };
}
