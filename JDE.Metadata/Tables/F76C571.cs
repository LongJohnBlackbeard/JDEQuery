using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C571 - .
/// </summary>
public class F76C571 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R1EF11.
        /// </summary>
        public const string R1EF11 = "R1EF11";

        /// <summary>
        /// R1CTYD.
        /// </summary>
        public const string R1CTYD = "R1CTYD";

        /// <summary>
        /// R1APCD.
        /// </summary>
        public const string R1APCD = "R1APCD";

        /// <summary>
        /// R1C76CN1.
        /// </summary>
        public const string R1C76CN1 = "R1C76CN1";

        /// <summary>
        /// R1C76JCD.
        /// </summary>
        public const string R1C76JCD = "R1C76JCD";

        /// <summary>
        /// R1C76JCA.
        /// </summary>
        public const string R1C76JCA = "R1C76JCA";

        /// <summary>
        /// R1CAEC.
        /// </summary>
        public const string R1CAEC = "R1CAEC";

        /// <summary>
        /// R1C76DIR.
        /// </summary>
        public const string R1C76DIR = "R1C76DIR";

        /// <summary>
        /// R1C76MPO.
        /// </summary>
        public const string R1C76MPO = "R1C76MPO";

        /// <summary>
        /// R1CTR06.
        /// </summary>
        public const string R1CTR06 = "R1CTR06";

        /// <summary>
        /// R1CSMA.
        /// </summary>
        public const string R1CSMA = "R1CSMA";

        /// <summary>
        /// R1ADD1.
        /// </summary>
        public const string R1ADD1 = "R1ADD1";

        /// <summary>
        /// R1UPMJ.
        /// </summary>
        public const string R1UPMJ = "R1UPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76C571";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R1EF11", "R1EF11", JdeDataType.Numeric),
        new JdeField("R1CTYD", "R1CTYD", JdeDataType.Numeric, null, true, true),
        new JdeField("R1APCD", "R1APCD", JdeDataType.Numeric),
        new JdeField("R1C76CN1", "R1C76CN1", JdeDataType.Numeric),
        new JdeField("R1C76JCD", "R1C76JCD", JdeDataType.String, 2),
        new JdeField("R1C76JCA", "R1C76JCA", JdeDataType.String, 120),
        new JdeField("R1CAEC", "R1CAEC", JdeDataType.Numeric),
        new JdeField("R1C76DIR", "R1C76DIR", JdeDataType.String, 80),
        new JdeField("R1C76MPO", "R1C76MPO", JdeDataType.Numeric),
        new JdeField("R1CTR06", "R1CTR06", JdeDataType.Numeric),
        new JdeField("R1CSMA", "R1CSMA", JdeDataType.Numeric),
        new JdeField("R1ADD1", "R1ADD1", JdeDataType.String, 80),
        new JdeField("R1UPMJ", "R1UPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C571_0", "Primary Key on R1CTYD", new[] { "R1CTYD" }, isUnique: true, isPrimaryKey: true)
    };
}
