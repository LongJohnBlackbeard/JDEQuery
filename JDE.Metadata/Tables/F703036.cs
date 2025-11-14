using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F703036 - .
/// </summary>
public class F703036 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B1KCO.
        /// </summary>
        public const string B1KCO = "B1KCO";

        /// <summary>
        /// B1DCT.
        /// </summary>
        public const string B1DCT = "B1DCT";

        /// <summary>
        /// B1DOC.
        /// </summary>
        public const string B1DOC = "B1DOC";

        /// <summary>
        /// B1CBNK.
        /// </summary>
        public const string B1CBNK = "B1CBNK";

        /// <summary>
        /// B1IBAN.
        /// </summary>
        public const string B1IBAN = "B1IBAN";

        /// <summary>
        /// B1SWFT.
        /// </summary>
        public const string B1SWFT = "B1SWFT";

        /// <summary>
        /// B1TNST.
        /// </summary>
        public const string B1TNST = "B1TNST";

        /// <summary>
        /// B1AN8BK.
        /// </summary>
        public const string B1AN8BK = "B1AN8BK";

        /// <summary>
        /// B1BACS.
        /// </summary>
        public const string B1BACS = "B1BACS";

        /// <summary>
        /// B1RLN.
        /// </summary>
        public const string B1RLN = "B1RLN";

        /// <summary>
        /// B1RFNM.
        /// </summary>
        public const string B1RFNM = "B1RFNM";
    }

    /// <inheritdoc />
    public override string TableName => "F703036";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B1KCO", "B1KCO", JdeDataType.String, 10, true, true),
        new JdeField("B1DCT", "B1DCT", JdeDataType.String, 4, true, true),
        new JdeField("B1DOC", "B1DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("B1CBNK", "B1CBNK", JdeDataType.String, 40),
        new JdeField("B1IBAN", "B1IBAN", JdeDataType.String, 68),
        new JdeField("B1SWFT", "B1SWFT", JdeDataType.String, 30),
        new JdeField("B1TNST", "B1TNST", JdeDataType.String, 40),
        new JdeField("B1AN8BK", "B1AN8BK", JdeDataType.Numeric),
        new JdeField("B1BACS", "B1BACS", JdeDataType.Numeric),
        new JdeField("B1RLN", "B1RLN", JdeDataType.String, 36),
        new JdeField("B1RFNM", "B1RFNM", JdeDataType.String, 36)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F703036_0", "Primary Key on B1KCO, B1DCT, B1DOC", new[] { "B1KCO", "B1DCT", "B1DOC" }, isUnique: true, isPrimaryKey: true)
    };
}
