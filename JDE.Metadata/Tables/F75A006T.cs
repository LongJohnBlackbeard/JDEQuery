using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A006T - .
/// </summary>
public class F75A006T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTAN8.
        /// </summary>
        public const string TTAN8 = "TTAN8";

        /// <summary>
        /// TTHMBD.
        /// </summary>
        public const string TTHMBD = "TTHMBD";

        /// <summary>
        /// TTHMED.
        /// </summary>
        public const string TTHMED = "TTHMED";

        /// <summary>
        /// TTTFND.
        /// </summary>
        public const string TTTFND = "TTTFND";

        /// <summary>
        /// TTSPACAUA1.
        /// </summary>
        public const string TTSPACAUA1 = "TTSPACAUA1";

        /// <summary>
        /// TTSPACAUA2.
        /// </summary>
        public const string TTSPACAUA2 = "TTSPACAUA2";

        /// <summary>
        /// TTSPACAUA3.
        /// </summary>
        public const string TTSPACAUA3 = "TTSPACAUA3";

        /// <summary>
        /// TTSPACAUA4.
        /// </summary>
        public const string TTSPACAUA4 = "TTSPACAUA4";

        /// <summary>
        /// TTSPADAUA1.
        /// </summary>
        public const string TTSPADAUA1 = "TTSPADAUA1";

        /// <summary>
        /// TTSPADAUA2.
        /// </summary>
        public const string TTSPADAUA2 = "TTSPADAUA2";

        /// <summary>
        /// TTSPADAUA3.
        /// </summary>
        public const string TTSPADAUA3 = "TTSPADAUA3";

        /// <summary>
        /// TTSPADAUA4.
        /// </summary>
        public const string TTSPADAUA4 = "TTSPADAUA4";

        /// <summary>
        /// TTSPANAUA1.
        /// </summary>
        public const string TTSPANAUA1 = "TTSPANAUA1";

        /// <summary>
        /// TTSPANAUA2.
        /// </summary>
        public const string TTSPANAUA2 = "TTSPANAUA2";

        /// <summary>
        /// TTSPANAUA3.
        /// </summary>
        public const string TTSPANAUA3 = "TTSPANAUA3";

        /// <summary>
        /// TTSPANAUA4.
        /// </summary>
        public const string TTSPANAUA4 = "TTSPANAUA4";

        /// <summary>
        /// TTSPASAUA1.
        /// </summary>
        public const string TTSPASAUA1 = "TTSPASAUA1";

        /// <summary>
        /// TTSPASAUA2.
        /// </summary>
        public const string TTSPASAUA2 = "TTSPASAUA2";

        /// <summary>
        /// TTSPASAUA3.
        /// </summary>
        public const string TTSPASAUA3 = "TTSPASAUA3";

        /// <summary>
        /// TTSPASAUA4.
        /// </summary>
        public const string TTSPASAUA4 = "TTSPASAUA4";

        /// <summary>
        /// TTUSER.
        /// </summary>
        public const string TTUSER = "TTUSER";

        /// <summary>
        /// TTPID.
        /// </summary>
        public const string TTPID = "TTPID";

        /// <summary>
        /// TTUPMJ.
        /// </summary>
        public const string TTUPMJ = "TTUPMJ";

        /// <summary>
        /// TTUPMT.
        /// </summary>
        public const string TTUPMT = "TTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75A006T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTAN8", "TTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TTHMBD", "TTHMBD", JdeDataType.Numeric, null, true, true),
        new JdeField("TTHMED", "TTHMED", JdeDataType.Numeric),
        new JdeField("TTTFND", "TTTFND", JdeDataType.Numeric, null, true, true),
        new JdeField("TTSPACAUA1", "TTSPACAUA1", JdeDataType.String, 2),
        new JdeField("TTSPACAUA2", "TTSPACAUA2", JdeDataType.String, 2),
        new JdeField("TTSPACAUA3", "TTSPACAUA3", JdeDataType.String, 2),
        new JdeField("TTSPACAUA4", "TTSPACAUA4", JdeDataType.String, 2),
        new JdeField("TTSPADAUA1", "TTSPADAUA1", JdeDataType.Numeric),
        new JdeField("TTSPADAUA2", "TTSPADAUA2", JdeDataType.Numeric),
        new JdeField("TTSPADAUA3", "TTSPADAUA3", JdeDataType.Numeric),
        new JdeField("TTSPADAUA4", "TTSPADAUA4", JdeDataType.Numeric),
        new JdeField("TTSPANAUA1", "TTSPANAUA1", JdeDataType.Numeric),
        new JdeField("TTSPANAUA2", "TTSPANAUA2", JdeDataType.Numeric),
        new JdeField("TTSPANAUA3", "TTSPANAUA3", JdeDataType.Numeric),
        new JdeField("TTSPANAUA4", "TTSPANAUA4", JdeDataType.Numeric),
        new JdeField("TTSPASAUA1", "TTSPASAUA1", JdeDataType.String, 80),
        new JdeField("TTSPASAUA2", "TTSPASAUA2", JdeDataType.String, 80),
        new JdeField("TTSPASAUA3", "TTSPASAUA3", JdeDataType.String, 80),
        new JdeField("TTSPASAUA4", "TTSPASAUA4", JdeDataType.String, 80),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTUPMJ", "TTUPMJ", JdeDataType.Numeric),
        new JdeField("TTUPMT", "TTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A006T_0", "Primary Key on TTAN8, TTHMBD, TTTFND", new[] { "TTAN8", "TTHMBD", "TTTFND" }, isUnique: true, isPrimaryKey: true)
    };
}
