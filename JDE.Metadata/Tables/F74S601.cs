using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S601 - .
/// </summary>
public class F74S601 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSCO.
        /// </summary>
        public const string RSCO = "RSCO";

        /// <summary>
        /// RSK70NUMB.
        /// </summary>
        public const string RSK70NUMB = "RSK70NUMB";

        /// <summary>
        /// RSS740100.
        /// </summary>
        public const string RSS740100 = "RSS740100";

        /// <summary>
        /// RSS74IVD.
        /// </summary>
        public const string RSS74IVD = "RSS74IVD";

        /// <summary>
        /// RSS74TRNS.
        /// </summary>
        public const string RSS74TRNS = "RSS74TRNS";

        /// <summary>
        /// RSS74REPS.
        /// </summary>
        public const string RSS74REPS = "RSS74REPS";

        /// <summary>
        /// RSUSER.
        /// </summary>
        public const string RSUSER = "RSUSER";

        /// <summary>
        /// RSPID.
        /// </summary>
        public const string RSPID = "RSPID";

        /// <summary>
        /// RSJOBN.
        /// </summary>
        public const string RSJOBN = "RSJOBN";

        /// <summary>
        /// RSUPMJ.
        /// </summary>
        public const string RSUPMJ = "RSUPMJ";

        /// <summary>
        /// RSUPMT.
        /// </summary>
        public const string RSUPMT = "RSUPMT";

        /// <summary>
        /// RSS74FUT01.
        /// </summary>
        public const string RSS74FUT01 = "RSS74FUT01";

        /// <summary>
        /// RSS74FUT02.
        /// </summary>
        public const string RSS74FUT02 = "RSS74FUT02";

        /// <summary>
        /// RSS74FUT03.
        /// </summary>
        public const string RSS74FUT03 = "RSS74FUT03";

        /// <summary>
        /// RSS74FUT04.
        /// </summary>
        public const string RSS74FUT04 = "RSS74FUT04";

        /// <summary>
        /// RSS74FUT05.
        /// </summary>
        public const string RSS74FUT05 = "RSS74FUT05";
    }

    /// <inheritdoc />
    public override string TableName => "F74S601";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSCO", "RSCO", JdeDataType.String, 10, true, true),
        new JdeField("RSK70NUMB", "RSK70NUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("RSS740100", "RSS740100", JdeDataType.Numeric, null, true, true),
        new JdeField("RSS74IVD", "RSS74IVD", JdeDataType.Numeric),
        new JdeField("RSS74TRNS", "RSS74TRNS", JdeDataType.String, 4),
        new JdeField("RSS74REPS", "RSS74REPS", JdeDataType.String, 4),
        new JdeField("RSUSER", "RSUSER", JdeDataType.String, 20),
        new JdeField("RSPID", "RSPID", JdeDataType.String, 20),
        new JdeField("RSJOBN", "RSJOBN", JdeDataType.String, 20),
        new JdeField("RSUPMJ", "RSUPMJ", JdeDataType.Numeric),
        new JdeField("RSUPMT", "RSUPMT", JdeDataType.Numeric),
        new JdeField("RSS74FUT01", "RSS74FUT01", JdeDataType.Numeric),
        new JdeField("RSS74FUT02", "RSS74FUT02", JdeDataType.String, 60),
        new JdeField("RSS74FUT03", "RSS74FUT03", JdeDataType.String, 2),
        new JdeField("RSS74FUT04", "RSS74FUT04", JdeDataType.String, 2),
        new JdeField("RSS74FUT05", "RSS74FUT05", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S601_0", "Primary Key on RSCO, RSK70NUMB, RSS740100", new[] { "RSCO", "RSK70NUMB", "RSS740100" }, isUnique: true, isPrimaryKey: true)
    };
}
