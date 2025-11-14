using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B210 - .
/// </summary>
public class F76B210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MWBRTX.
        /// </summary>
        public const string MWBRTX = "MWBRTX";

        /// <summary>
        /// MWEFTJ.
        /// </summary>
        public const string MWEFTJ = "MWEFTJ";

        /// <summary>
        /// MWB76WMAW.
        /// </summary>
        public const string MWB76WMAW = "MWB76WMAW";

        /// <summary>
        /// MWUSER.
        /// </summary>
        public const string MWUSER = "MWUSER";

        /// <summary>
        /// MWPID.
        /// </summary>
        public const string MWPID = "MWPID";

        /// <summary>
        /// MWJOBN.
        /// </summary>
        public const string MWJOBN = "MWJOBN";

        /// <summary>
        /// MWUPMJ.
        /// </summary>
        public const string MWUPMJ = "MWUPMJ";

        /// <summary>
        /// MWUPMT.
        /// </summary>
        public const string MWUPMT = "MWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MWBRTX", "MWBRTX", JdeDataType.String, 4, true, true),
        new JdeField("MWEFTJ", "MWEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("MWB76WMAW", "MWB76WMAW", JdeDataType.Numeric),
        new JdeField("MWUSER", "MWUSER", JdeDataType.String, 20),
        new JdeField("MWPID", "MWPID", JdeDataType.String, 20),
        new JdeField("MWJOBN", "MWJOBN", JdeDataType.String, 20),
        new JdeField("MWUPMJ", "MWUPMJ", JdeDataType.Numeric),
        new JdeField("MWUPMT", "MWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B210_0", "Primary Key on MWBRTX, MWEFTJ", new[] { "MWBRTX", "MWEFTJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B210_2", "Index on MWBRTX, SYS_NC00009$", new[] { "MWBRTX", "SYS_NC00009$" })
    };
}
