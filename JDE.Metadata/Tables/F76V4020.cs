using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V4020 - .
/// </summary>
public class F76V4020 : JdeTable
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
        /// WSV76ISLR.
        /// </summary>
        public const string WSV76ISLR = "WSV76ISLR";

        /// <summary>
        /// WSV76ISFC.
        /// </summary>
        public const string WSV76ISFC = "WSV76ISFC";

        /// <summary>
        /// WSV76MIIS.
        /// </summary>
        public const string WSV76MIIS = "WSV76MIIS";

        /// <summary>
        /// WSV76MXIS.
        /// </summary>
        public const string WSV76MXIS = "WSV76MXIS";

        /// <summary>
        /// WSEFTJ.
        /// </summary>
        public const string WSEFTJ = "WSEFTJ";

        /// <summary>
        /// WSEFDJ.
        /// </summary>
        public const string WSEFDJ = "WSEFDJ";

        /// <summary>
        /// WSV76ISLC.
        /// </summary>
        public const string WSV76ISLC = "WSV76ISLC";

        /// <summary>
        /// WSV76PASW.
        /// </summary>
        public const string WSV76PASW = "WSV76PASW";

        /// <summary>
        /// WSV76WHPE.
        /// </summary>
        public const string WSV76WHPE = "WSV76WHPE";

        /// <summary>
        /// WSBBIR.
        /// </summary>
        public const string WSBBIR = "WSBBIR";

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
    public override string TableName => "F76V4020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSCO", "WSCO", JdeDataType.String, 10, true, true),
        new JdeField("WSV76ISLR", "WSV76ISLR", JdeDataType.String, 6, true, true),
        new JdeField("WSV76ISFC", "WSV76ISFC", JdeDataType.String, 2, true, true),
        new JdeField("WSV76MIIS", "WSV76MIIS", JdeDataType.Numeric, null, true, true),
        new JdeField("WSV76MXIS", "WSV76MXIS", JdeDataType.Numeric),
        new JdeField("WSEFTJ", "WSEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WSEFDJ", "WSEFDJ", JdeDataType.Numeric),
        new JdeField("WSV76ISLC", "WSV76ISLC", JdeDataType.String, 6),
        new JdeField("WSV76PASW", "WSV76PASW", JdeDataType.Numeric),
        new JdeField("WSV76WHPE", "WSV76WHPE", JdeDataType.Numeric),
        new JdeField("WSBBIR", "WSBBIR", JdeDataType.Numeric),
        new JdeField("WSUSER", "WSUSER", JdeDataType.String, 20),
        new JdeField("WSPID", "WSPID", JdeDataType.String, 20),
        new JdeField("WSJOBN", "WSJOBN", JdeDataType.String, 20),
        new JdeField("WSUPMJ", "WSUPMJ", JdeDataType.Numeric),
        new JdeField("WSUPMT", "WSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V4020_0", "Primary Key on WSCO, WSV76ISLR, WSV76ISFC, WSV76MIIS, WSEFTJ", new[] { "WSCO", "WSV76ISLR", "WSV76ISFC", "WSV76MIIS", "WSEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
