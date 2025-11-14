using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46013 - .
/// </summary>
public class F46013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EQMCU.
        /// </summary>
        public const string EQMCU = "EQMCU";

        /// <summary>
        /// EQITM.
        /// </summary>
        public const string EQITM = "EQITM";

        /// <summary>
        /// EQPRP6.
        /// </summary>
        public const string EQPRP6 = "EQPRP6";

        /// <summary>
        /// EQUOM.
        /// </summary>
        public const string EQUOM = "EQUOM";

        /// <summary>
        /// EQEQTY.
        /// </summary>
        public const string EQEQTY = "EQEQTY";

        /// <summary>
        /// EQEQT2.
        /// </summary>
        public const string EQEQT2 = "EQEQT2";

        /// <summary>
        /// EQFPCT.
        /// </summary>
        public const string EQFPCT = "EQFPCT";

        /// <summary>
        /// EQUSER.
        /// </summary>
        public const string EQUSER = "EQUSER";

        /// <summary>
        /// EQUPMJ.
        /// </summary>
        public const string EQUPMJ = "EQUPMJ";

        /// <summary>
        /// EQTDAY.
        /// </summary>
        public const string EQTDAY = "EQTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EQMCU", "EQMCU", JdeDataType.String, 24, true, true),
        new JdeField("EQITM", "EQITM", JdeDataType.Numeric, null, true, true),
        new JdeField("EQPRP6", "EQPRP6", JdeDataType.String, 12, true, true),
        new JdeField("EQUOM", "EQUOM", JdeDataType.String, 4, true, true),
        new JdeField("EQEQTY", "EQEQTY", JdeDataType.String, 10, true, true),
        new JdeField("EQEQT2", "EQEQT2", JdeDataType.String, 10, true, true),
        new JdeField("EQFPCT", "EQFPCT", JdeDataType.Numeric),
        new JdeField("EQUSER", "EQUSER", JdeDataType.String, 20),
        new JdeField("EQUPMJ", "EQUPMJ", JdeDataType.Numeric),
        new JdeField("EQTDAY", "EQTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46013_0", "Primary Key on EQMCU, EQITM, EQPRP6, EQUOM, EQEQTY, EQEQT2", new[] { "EQMCU", "EQITM", "EQPRP6", "EQUOM", "EQEQTY", "EQEQT2" }, isUnique: true, isPrimaryKey: true)
    };
}
