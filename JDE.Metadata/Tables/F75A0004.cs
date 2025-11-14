using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0004 - .
/// </summary>
public class F75A0004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A4EDTF.
        /// </summary>
        public const string A4EDTF = "A4EDTF";

        /// <summary>
        /// A4EDTT.
        /// </summary>
        public const string A4EDTT = "A4EDTT";

        /// <summary>
        /// A4PAYRNGB.
        /// </summary>
        public const string A4PAYRNGB = "A4PAYRNGB";

        /// <summary>
        /// A4PAYRNGE.
        /// </summary>
        public const string A4PAYRNGE = "A4PAYRNGE";

        /// <summary>
        /// A4MINND1.
        /// </summary>
        public const string A4MINND1 = "A4MINND1";

        /// <summary>
        /// A4MINND2.
        /// </summary>
        public const string A4MINND2 = "A4MINND2";

        /// <summary>
        /// A4MINND5.
        /// </summary>
        public const string A4MINND5 = "A4MINND5";

        /// <summary>
        /// A4MINND10.
        /// </summary>
        public const string A4MINND10 = "A4MINND10";

        /// <summary>
        /// A4MINND20.
        /// </summary>
        public const string A4MINND20 = "A4MINND20";

        /// <summary>
        /// A4MINND50.
        /// </summary>
        public const string A4MINND50 = "A4MINND50";

        /// <summary>
        /// A4MINND100.
        /// </summary>
        public const string A4MINND100 = "A4MINND100";

        /// <summary>
        /// A4UPMJ.
        /// </summary>
        public const string A4UPMJ = "A4UPMJ";

        /// <summary>
        /// A4UPMT.
        /// </summary>
        public const string A4UPMT = "A4UPMT";

        /// <summary>
        /// A4PID.
        /// </summary>
        public const string A4PID = "A4PID";

        /// <summary>
        /// A4USER.
        /// </summary>
        public const string A4USER = "A4USER";

        /// <summary>
        /// A4JOBN.
        /// </summary>
        public const string A4JOBN = "A4JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A4EDTF", "A4EDTF", JdeDataType.Numeric, null, true, true),
        new JdeField("A4EDTT", "A4EDTT", JdeDataType.Numeric),
        new JdeField("A4PAYRNGB", "A4PAYRNGB", JdeDataType.Numeric),
        new JdeField("A4PAYRNGE", "A4PAYRNGE", JdeDataType.Numeric),
        new JdeField("A4MINND1", "A4MINND1", JdeDataType.Numeric),
        new JdeField("A4MINND2", "A4MINND2", JdeDataType.Numeric),
        new JdeField("A4MINND5", "A4MINND5", JdeDataType.Numeric),
        new JdeField("A4MINND10", "A4MINND10", JdeDataType.Numeric),
        new JdeField("A4MINND20", "A4MINND20", JdeDataType.Numeric),
        new JdeField("A4MINND50", "A4MINND50", JdeDataType.Numeric),
        new JdeField("A4MINND100", "A4MINND100", JdeDataType.Numeric),
        new JdeField("A4UPMJ", "A4UPMJ", JdeDataType.Numeric),
        new JdeField("A4UPMT", "A4UPMT", JdeDataType.Numeric),
        new JdeField("A4PID", "A4PID", JdeDataType.String, 20),
        new JdeField("A4USER", "A4USER", JdeDataType.String, 20),
        new JdeField("A4JOBN", "A4JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0004_0", "Primary Key on A4EDTF", new[] { "A4EDTF" }, isUnique: true, isPrimaryKey: true)
    };
}
