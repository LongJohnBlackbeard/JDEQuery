using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V4025 - .
/// </summary>
public class F76V4025 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSCO.
        /// </summary>
        public const string WSCO = "WSCO";

        /// <summary>
        /// WSV76MUNW.
        /// </summary>
        public const string WSV76MUNW = "WSV76MUNW";

        /// <summary>
        /// WSV76MIIM.
        /// </summary>
        public const string WSV76MIIM = "WSV76MIIM";

        /// <summary>
        /// WSV76MXIM.
        /// </summary>
        public const string WSV76MXIM = "WSV76MXIM";

        /// <summary>
        /// WSEFTJ.
        /// </summary>
        public const string WSEFTJ = "WSEFTJ";

        /// <summary>
        /// WSEFDJ.
        /// </summary>
        public const string WSEFDJ = "WSEFDJ";

        /// <summary>
        /// WSV76IMLC.
        /// </summary>
        public const string WSV76IMLC = "WSV76IMLC";

        /// <summary>
        /// WSV76PASW.
        /// </summary>
        public const string WSV76PASW = "WSV76PASW";

        /// <summary>
        /// WSV76WHPE.
        /// </summary>
        public const string WSV76WHPE = "WSV76WHPE";

        /// <summary>
        /// WSUSER.
        /// </summary>
        public const string WSUSER = "WSUSER";

        /// <summary>
        /// WSPID.
        /// </summary>
        public const string WSPID = "WSPID";

        /// <summary>
        /// WSJOBN.
        /// </summary>
        public const string WSJOBN = "WSJOBN";

        /// <summary>
        /// WSUPMJ.
        /// </summary>
        public const string WSUPMJ = "WSUPMJ";

        /// <summary>
        /// WSUPMT.
        /// </summary>
        public const string WSUPMT = "WSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76V4025";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSCO", "WSCO", JdeDataType.String, 10, true, true),
        new JdeField("WSV76MUNW", "WSV76MUNW", JdeDataType.String, 2, true, true),
        new JdeField("WSV76MIIM", "WSV76MIIM", JdeDataType.Numeric, null, true, true),
        new JdeField("WSV76MXIM", "WSV76MXIM", JdeDataType.Numeric),
        new JdeField("WSEFTJ", "WSEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WSEFDJ", "WSEFDJ", JdeDataType.Numeric),
        new JdeField("WSV76IMLC", "WSV76IMLC", JdeDataType.String, 6),
        new JdeField("WSV76PASW", "WSV76PASW", JdeDataType.Numeric),
        new JdeField("WSV76WHPE", "WSV76WHPE", JdeDataType.Numeric),
        new JdeField("WSUSER", "WSUSER", JdeDataType.String, 20),
        new JdeField("WSPID", "WSPID", JdeDataType.String, 20),
        new JdeField("WSJOBN", "WSJOBN", JdeDataType.String, 20),
        new JdeField("WSUPMJ", "WSUPMJ", JdeDataType.Numeric),
        new JdeField("WSUPMT", "WSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V4025_0", "Primary Key on WSCO, WSV76MUNW, WSV76MIIM, WSEFTJ", new[] { "WSCO", "WSV76MUNW", "WSV76MIIM", "WSEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
