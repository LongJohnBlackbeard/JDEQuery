using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B424 - .
/// </summary>
public class F03B424 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKCO.
        /// </summary>
        public const string TKCO = "TKCO";

        /// <summary>
        /// TKINDCT.
        /// </summary>
        public const string TKINDCT = "TKINDCT";

        /// <summary>
        /// TKINMCU.
        /// </summary>
        public const string TKINMCU = "TKINMCU";

        /// <summary>
        /// TKINCUST.
        /// </summary>
        public const string TKINCUST = "TKINCUST";

        /// <summary>
        /// TKCCON.
        /// </summary>
        public const string TKCCON = "TKCCON";

        /// <summary>
        /// TKINCCC.
        /// </summary>
        public const string TKINCCC = "TKINCCC";

        /// <summary>
        /// TKINCCV.
        /// </summary>
        public const string TKINCCV = "TKINCCV";

        /// <summary>
        /// TKUPMJ.
        /// </summary>
        public const string TKUPMJ = "TKUPMJ";

        /// <summary>
        /// TKUPMT.
        /// </summary>
        public const string TKUPMT = "TKUPMT";

        /// <summary>
        /// TKJOBN.
        /// </summary>
        public const string TKJOBN = "TKJOBN";

        /// <summary>
        /// TKUSER.
        /// </summary>
        public const string TKUSER = "TKUSER";

        /// <summary>
        /// TKPID.
        /// </summary>
        public const string TKPID = "TKPID";
    }

    /// <inheritdoc />
    public override string TableName => "F03B424";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKCO", "TKCO", JdeDataType.String, 10, true, true),
        new JdeField("TKINDCT", "TKINDCT", JdeDataType.Numeric),
        new JdeField("TKINMCU", "TKINMCU", JdeDataType.Numeric),
        new JdeField("TKINCUST", "TKINCUST", JdeDataType.Numeric),
        new JdeField("TKCCON", "TKCCON", JdeDataType.Numeric),
        new JdeField("TKINCCC", "TKINCCC", JdeDataType.Numeric),
        new JdeField("TKINCCV", "TKINCCV", JdeDataType.Numeric),
        new JdeField("TKUPMJ", "TKUPMJ", JdeDataType.Numeric),
        new JdeField("TKUPMT", "TKUPMT", JdeDataType.Numeric),
        new JdeField("TKJOBN", "TKJOBN", JdeDataType.String, 20),
        new JdeField("TKUSER", "TKUSER", JdeDataType.String, 20),
        new JdeField("TKPID", "TKPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B424_0", "Primary Key on TKCO", new[] { "TKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
