using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08395 - .
/// </summary>
public class F08395 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B8DACD.
        /// </summary>
        public const string B8DACD = "B8DACD";

        /// <summary>
        /// B8DL01.
        /// </summary>
        public const string B8DL01 = "B8DL01";

        /// <summary>
        /// B8DTF1.
        /// </summary>
        public const string B8DTF1 = "B8DTF1";

        /// <summary>
        /// B8DYMO.
        /// </summary>
        public const string B8DYMO = "B8DYMO";

        /// <summary>
        /// B8ENDM.
        /// </summary>
        public const string B8ENDM = "B8ENDM";

        /// <summary>
        /// B8DTF2.
        /// </summary>
        public const string B8DTF2 = "B8DTF2";

        /// <summary>
        /// B8BAMT.
        /// </summary>
        public const string B8BAMT = "B8BAMT";

        /// <summary>
        /// B8ELGB.
        /// </summary>
        public const string B8ELGB = "B8ELGB";

        /// <summary>
        /// B8END1.
        /// </summary>
        public const string B8END1 = "B8END1";

        /// <summary>
        /// B8END2.
        /// </summary>
        public const string B8END2 = "B8END2";

        /// <summary>
        /// B8END3.
        /// </summary>
        public const string B8END3 = "B8END3";

        /// <summary>
        /// B8END4.
        /// </summary>
        public const string B8END4 = "B8END4";

        /// <summary>
        /// B8END5.
        /// </summary>
        public const string B8END5 = "B8END5";

        /// <summary>
        /// B8END6.
        /// </summary>
        public const string B8END6 = "B8END6";
    }

    /// <inheritdoc />
    public override string TableName => "F08395";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B8DACD", "B8DACD", JdeDataType.String, 4, true, true),
        new JdeField("B8DL01", "B8DL01", JdeDataType.String, 60),
        new JdeField("B8DTF1", "B8DTF1", JdeDataType.String, 8),
        new JdeField("B8DYMO", "B8DYMO", JdeDataType.Numeric),
        new JdeField("B8ENDM", "B8ENDM", JdeDataType.String, 2),
        new JdeField("B8DTF2", "B8DTF2", JdeDataType.String, 8),
        new JdeField("B8BAMT", "B8BAMT", JdeDataType.Numeric),
        new JdeField("B8ELGB", "B8ELGB", JdeDataType.String, 2),
        new JdeField("B8END1", "B8END1", JdeDataType.Numeric),
        new JdeField("B8END2", "B8END2", JdeDataType.Numeric),
        new JdeField("B8END3", "B8END3", JdeDataType.Numeric),
        new JdeField("B8END4", "B8END4", JdeDataType.Numeric),
        new JdeField("B8END5", "B8END5", JdeDataType.Numeric),
        new JdeField("B8END6", "B8END6", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08395_0", "Primary Key on B8DACD", new[] { "B8DACD" }, isUnique: true, isPrimaryKey: true)
    };
}
