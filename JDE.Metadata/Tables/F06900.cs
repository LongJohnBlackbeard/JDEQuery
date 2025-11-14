using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06900 - .
/// </summary>
public class F06900 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y$HMCO.
        /// </summary>
        public const string Y_HMCO = "Y$HMCO";

        /// <summary>
        /// Y$DFY.
        /// </summary>
        public const string Y_DFY = "Y$DFY";

        /// <summary>
        /// Y$PNC.
        /// </summary>
        public const string Y_PNC = "Y$PNC";

        /// <summary>
        /// Y$D01.
        /// </summary>
        public const string Y_D01 = "Y$D01";

        /// <summary>
        /// Y$D02.
        /// </summary>
        public const string Y_D02 = "Y$D02";

        /// <summary>
        /// Y$D03.
        /// </summary>
        public const string Y_D03 = "Y$D03";

        /// <summary>
        /// Y$D04.
        /// </summary>
        public const string Y_D04 = "Y$D04";

        /// <summary>
        /// Y$D05.
        /// </summary>
        public const string Y_D05 = "Y$D05";

        /// <summary>
        /// Y$D06.
        /// </summary>
        public const string Y_D06 = "Y$D06";

        /// <summary>
        /// Y$D07.
        /// </summary>
        public const string Y_D07 = "Y$D07";

        /// <summary>
        /// Y$D08.
        /// </summary>
        public const string Y_D08 = "Y$D08";

        /// <summary>
        /// Y$D09.
        /// </summary>
        public const string Y_D09 = "Y$D09";

        /// <summary>
        /// Y$D10.
        /// </summary>
        public const string Y_D10 = "Y$D10";

        /// <summary>
        /// Y$D11.
        /// </summary>
        public const string Y_D11 = "Y$D11";

        /// <summary>
        /// Y$D12.
        /// </summary>
        public const string Y_D12 = "Y$D12";
    }

    /// <inheritdoc />
    public override string TableName => "F06900";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y$HMCO", "Y$HMCO", JdeDataType.String, 10, true, true),
        new JdeField("Y$DFY", "Y$DFY", JdeDataType.Numeric, null, true, true),
        new JdeField("Y$PNC", "Y$PNC", JdeDataType.Numeric),
        new JdeField("Y$D01", "Y$D01", JdeDataType.Numeric),
        new JdeField("Y$D02", "Y$D02", JdeDataType.Numeric),
        new JdeField("Y$D03", "Y$D03", JdeDataType.Numeric),
        new JdeField("Y$D04", "Y$D04", JdeDataType.Numeric),
        new JdeField("Y$D05", "Y$D05", JdeDataType.Numeric),
        new JdeField("Y$D06", "Y$D06", JdeDataType.Numeric),
        new JdeField("Y$D07", "Y$D07", JdeDataType.Numeric),
        new JdeField("Y$D08", "Y$D08", JdeDataType.Numeric),
        new JdeField("Y$D09", "Y$D09", JdeDataType.Numeric),
        new JdeField("Y$D10", "Y$D10", JdeDataType.Numeric),
        new JdeField("Y$D11", "Y$D11", JdeDataType.Numeric),
        new JdeField("Y$D12", "Y$D12", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06900_0", "Primary Key on Y$HMCO, Y$DFY", new[] { "Y$HMCO", "Y$DFY" }, isUnique: true, isPrimaryKey: true)
    };
}
