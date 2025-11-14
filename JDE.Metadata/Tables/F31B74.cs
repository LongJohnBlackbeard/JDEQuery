using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B74 - .
/// </summary>
public class F31B74 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WMWSD.
        /// </summary>
        public const string WMWSD = "WMWSD";

        /// <summary>
        /// WMWOPST.
        /// </summary>
        public const string WMWOPST = "WMWOPST";

        /// <summary>
        /// WMWDSF.
        /// </summary>
        public const string WMWDSF = "WMWDSF";

        /// <summary>
        /// WMUSER.
        /// </summary>
        public const string WMUSER = "WMUSER";

        /// <summary>
        /// WMTDAY.
        /// </summary>
        public const string WMTDAY = "WMTDAY";

        /// <summary>
        /// WMJOBN.
        /// </summary>
        public const string WMJOBN = "WMJOBN";

        /// <summary>
        /// WMPID.
        /// </summary>
        public const string WMPID = "WMPID";

        /// <summary>
        /// WMUPMJ.
        /// </summary>
        public const string WMUPMJ = "WMUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F31B74";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WMWSD", "WMWSD", JdeDataType.String, 60, true, true),
        new JdeField("WMWOPST", "WMWOPST", JdeDataType.String, 20),
        new JdeField("WMWDSF", "WMWDSF", JdeDataType.String, 2),
        new JdeField("WMUSER", "WMUSER", JdeDataType.String, 20),
        new JdeField("WMTDAY", "WMTDAY", JdeDataType.Numeric),
        new JdeField("WMJOBN", "WMJOBN", JdeDataType.String, 20),
        new JdeField("WMPID", "WMPID", JdeDataType.String, 20),
        new JdeField("WMUPMJ", "WMUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B74_0", "Primary Key on WMWSD", new[] { "WMWSD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B74_3", "Index on WMWOPST, SYS_NC00009$", new[] { "WMWOPST", "SYS_NC00009$" })
    };
}
